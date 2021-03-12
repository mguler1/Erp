using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MGsTok.Entities.interfaces;

namespace MGsTok.Entities.Tables
{
    public class OdemeTuru:IEntitiy
    {
        public int Id { get; set; }
        public string OdemeTuruKodu { get; set; }
        public string OdemeTuruAdi { get; set; }
        public string Aciklama { get; set; }

    }
}
