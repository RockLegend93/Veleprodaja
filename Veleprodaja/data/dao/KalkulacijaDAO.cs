﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veleprodaja.data.dto;

namespace Veleprodaja.data.dao
{
    public interface KalkulacijaDAO
    {
        List<KalkulacijaDTO> getAll();
        int insert(KalkulacijaDTO kalkulacija);
        void updateObjectIznos(KalkulacijaDTO kalkulacija);

        int update(KalkulacijaDTO kalkulacija);

        void delete(KalkulacijaDTO kalkulacija);
    }
}
