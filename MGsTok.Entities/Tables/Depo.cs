using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MGsTok.Entities.interfaces;
namespace MGsTok.Entities.Tables
{
   public class Depo:IEntitiy
    {
        public int Id { get; set; }
        public string DepoKodu { get; set; }
        public string DepoAdi { get; set; }
        public string YetkiliKodu { get; set; }
        public string YetkiliAdi { get; set; }
        public string DepoIl { get; set; }
        public string DepoIlce { get; set; }
        public string Semt { get; set; }
        public string Adresi { get; set; }
        public string Telefon { get; set; }
        public string Aciklama { get; set; }

    }
}
