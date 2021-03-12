using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MGsTok.Entities.interfaces;

namespace MGsTok.Entities.Tables
{
  public  class Personel:IEntitiy
    {
        public int Id { get; set; }
        public bool Calisiyot { get; set; }
        public string Unvani { get; set; }
        public string PersonelKodu { get; set; }
        public string PersonelAdi { get; set; }
        public string TcKimlikNo { get; set; }
        public Nullable<DateTime> IseGirisTarihi { get; set; }
        public Nullable<DateTime> IstenCikis { get; set; }
        public string VergiDairesi { get; set; }
        public string VergiNo { get; set; }
        public string CepTelefonu { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Web { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string Semt { get; set; }
        public string Adres { get; set; }
        public Nullable<Decimal> PrimOrani { get; set; }
        public Nullable<Decimal> AylıkMaas { get; set; }
        public string Aciklama { get; set; }

    }
}
