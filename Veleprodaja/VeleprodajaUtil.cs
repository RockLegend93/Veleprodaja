﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Veleprodaja.data.dao;
using Veleprodaja.data.dao.MySqlDao;
using Veleprodaja.data.dto;

namespace Veleprodaja
{
    public class VeleprodajaUtil
    {
        public static DAOFactory getDAOFactory()
        {
            return new MySqlDAOFactory();
        }

        public static void initJedinicaMjereComboBox(ComboBox cb)
        {
            cb.Items.Clear();
            List<JedinicaMjereDTO> lista = VeleprodajaUtil.getDAOFactory().getJedinicaMjereDAO().getAll();
            foreach (JedinicaMjereDTO jedinica in lista)
            {
                cb.Items.Add(jedinica);
            }
        }

        public static void initMjestoComboBox(ComboBox cb)
        {
            cb.Items.Clear();
            List<MjestoDTO> lista = VeleprodajaUtil.getDAOFactory().getMjestoDAO().getAll();
            foreach (MjestoDTO mjesto in lista)
            {
                cb.Items.Add(mjesto);
            }
        }
    }
}