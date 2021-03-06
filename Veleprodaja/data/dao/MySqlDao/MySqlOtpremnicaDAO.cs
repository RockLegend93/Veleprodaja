﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veleprodaja.data.dto;

namespace Veleprodaja.data.dao.MySqlDao
{
    public class MySqlOtpremnicaDAO:OtpremnicaDAO
    {
        private string qGetAll = "select * from otpremnica_osnovno where PoslovnaGodina=?PoslovnaGodina;";
        private string qInsert = "insert into otpremnica (RedniBroj) values (?RedniBroj);";
        public List<OtpremnicaDTO> getAll()
        {
            MySqlConnection connection = ConnectionPool.checkOutConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = qGetAll;
            command.Parameters.AddWithValue("PoslovnaGodina", VeleprodajaUtil.PoslovnaGodina);
            MySqlDataReader reader = command.ExecuteReader();
            List<OtpremnicaDTO> lista = new List<OtpremnicaDTO>();
            while (reader.Read())
            {
                OtpremnicaDTO otpremnica = readerToOtpremnicaDTO(reader);
                otpremnica.Partner = MySqlPartnerDAO.readerToPartnerDTO(reader);
                otpremnica.Partner.Mjesto = MySqlMjestoDAO.readerToMjestoDTO(reader);
                updateObjectIznos(otpremnica);
                lista.Add(otpremnica);
            }
            reader.Close();
            ConnectionPool.checkInConnection(connection);
            return lista;
        }

        private OtpremnicaDTO readerToOtpremnicaDTO(MySqlDataReader reader)
        {
            OtpremnicaDTO otpremnica = new OtpremnicaDTO(MySqlStavkaKnjigeTrgovineNaVeliko.readerToStavkaKnjigeTrgovineNaVeliko(reader));
            return otpremnica;
        }

        public int insert(dto.OtpremnicaDTO otpremnica)
        {
            int rows = new MySqlStavkaKnjigeTrgovineNaVeliko().insert(otpremnica);
            if (rows > 0)
            {
                 MySqlConnection connection = ConnectionPool.checkOutConnection();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = qInsert;
                command.Parameters.AddWithValue("RedniBroj", otpremnica.RedniBroj);
                int rows1=command.ExecuteNonQuery();
                ConnectionPool.checkInConnection(connection);
                return rows;
            }
            return rows;
        }


        public void updateObjectIznos(OtpremnicaDTO otpremnica)
        {
            MySqlConnection connection = ConnectionPool.checkOutConnection();
            MySqlCommand command = new MySqlCommand("iznosOtpremnice", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("rb", otpremnica.RedniBroj);
            command.Parameters["rb"].Direction = System.Data.ParameterDirection.Input;
            command.Parameters.AddWithValue("@velIznos", otpremnica.VeleprodajniIznos);
            command.Parameters["@velIznos"].Direction = System.Data.ParameterDirection.Output;
            command.Parameters.AddWithValue("@izSaRabatom", otpremnica.IznosSaRabatom);
            command.Parameters["@izSaRabatom"].Direction = System.Data.ParameterDirection.Output;
            command.Parameters.AddWithValue("@iznosRabata", otpremnica.IznosRabata);
            command.Parameters["@iznosRabata"].Direction = System.Data.ParameterDirection.Output;
            command.ExecuteNonQuery();
            try
            {
                otpremnica.IznosRabata = Convert.ToDouble(command.Parameters["@iznosRabata"].Value.ToString());
                otpremnica.IznosSaRabatom = Convert.ToDouble(command.Parameters["@izSaRabatom"].Value.ToString());
                otpremnica.VeleprodajniIznos = Convert.ToDouble(command.Parameters["@velIznos"].Value.ToString());
            }
            catch (Exception)
            {

            }

            ConnectionPool.checkInConnection(connection);
        }
    }
}
