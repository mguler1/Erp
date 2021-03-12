using MGsTok.Entities.Contex;
using MGsTok.Entities.Repostories;
using MGsTok.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MGsTok.Entities.Validations;

namespace MGsTok.Entities.DataAccess
{
   public class OdemeTuruDal:EntityRepostoryBase<MGsTOKContex, OdemeTuru,OdemeTuruValidater>//base entiysden miras aldım>//base entiysden miras aldım
    {
        public object OdemeTuruListele(MGsTOKContex context)
        {
            var result = context.OdemeTurleri.GroupJoin(context.KasaHareketleri, c => c.OdemeTuruKodu, c => c.OdemeTuruKodu, (Odemeturu, kasahareket) => new
            {
               Odemeturu.Id,
               Odemeturu.OdemeTuruKodu,
               Odemeturu.OdemeTuruAdi,
               Odemeturu.Aciklama,
                KasaGiris = (kasahareket.Where(c => c.OdemeTuruKodu == Odemeturu.OdemeTuruKodu && c.Hareket == "Kasa Giriş").Sum(c => c.Tutar) ?? 0),
                KasaCıkıs = (kasahareket.Where(c => c.OdemeTuruKodu == Odemeturu.OdemeTuruKodu && c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0),
                Bakiye = (kasahareket.Where(c => c.OdemeTuruKodu == Odemeturu.OdemeTuruKodu && c.Hareket == "Kasa Giriş").Sum(c => c.Tutar) ?? 0) - (kasahareket.Where(c => c.OdemeTuruKodu == Odemeturu.OdemeTuruKodu && c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0)
            }).ToList();
            return result;
        }
    }
}
