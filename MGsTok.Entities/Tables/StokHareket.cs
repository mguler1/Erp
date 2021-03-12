using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MGsTok.Entities.interfaces;

namespace MGsTok.Entities.Tables
{
   public class StokHareket:IEntitiy
    {
        public int Id { get; set; }
        public string Fiskodu { get; set; }
        public string Hareket { get; set; }
        public string StokKodu { get; set; }
        public string StokAdi { get; set; }
        public string BarkodTuru { get; set; }
        public string Barkod { get; set; }
        public string Birimi { get; set; }
        public Nullable<decimal> Miktari { get; set; }
        public int Kdv { get; set; }
        public Nullable<decimal> BirimFiyati { get; set; }
        public Nullable<decimal> IndirimOrani { get; set; }
        public string DepoKodu { get; set; }
        public string DepoAdi { get; set; }
        public string SeriNo { get; set; }
        public Nullable< DateTime> Tarih { get; set; }
        public string Aciklama { get; set; }

    }
}
