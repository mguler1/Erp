using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGsTok.Entities.Tables.Other_Tables
{
   public class FiyatDegistir
    {
        public string FiyatTuru { get; set; }
        public string kolonAdi { get; set; }
        public bool Degistir { get; set; }
        public string DegisimTuru { get; set; }
        public string DegisimYonu { get; set; }
        public decimal Degeri { get; set; }

    }
}
