using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MGsTok.Entities.interfaces;

namespace MGsTok.Entities.Tables
{
   public class Tanim:IEntitiy
    {
        public int Id { get; set; }
        public string Turu { get; set; }//grup,altgrup,özel kod
        public string Tanimi { get; set; }
        public string Aciklama { get; set; }

    }
}
