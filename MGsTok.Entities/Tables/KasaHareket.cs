﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MGsTok.Entities.interfaces;

namespace MGsTok.Entities.Tables
{
   public class KasaHareket:IEntitiy
    {
        public int Id { get; set; }
        public string FisKodu { get; set; }
        public string Hareket { get; set; }
        public string KasaKodu { get; set; }
        public string KasaAdi { get; set; }
        public string OdemeTuruKodu { get; set; }
        public string OdemeTuruAdi { get; set; }
        public string CariKodu { get; set; }
        public string CariAdi { get; set; }
        public Nullable< DateTime> Tarih { get; set; }
        public Nullable<decimal> Tutar { get; set; }
        public string Aciklama { get; set; }

    }
}
