using MGsTok.Entities.Contex;
using MGsTok.Entities.Repostories;
using MGsTok.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MGsTok.Entities.Validations;
using MGsTok.Entities.Contex;
using MGsTok.Entities.Tables;
namespace MGsTok.Entities.DataAccess
{
  public   class KasaDal :EntityRepostoryBase<MGsTOKContex, Kasa,KasaValidater>//base entiysden miras aldım
    {
        public object KasaListele(MGsTOKContex context)
        {
            var result = context.kasalar.GroupJoin(context.KasaHareketleri, c => c.KasaKodu, c => c.KasaKodu, (kasa, kasahareket) => new
            {
                kasa.Id,
                kasa.KasaAdi,
                kasa.KasaKodu,
                kasa.YetkiliKodu,
                kasa.YetkiliAdi,
                kasa.Aciklama,
                KasaGiris= ( kasahareket.Where(c=>c.KasaKodu==kasa.KasaKodu && c.Hareket=="Kasa Giriş").Sum(c=>c.Tutar) ??0),
                KasaCıkıs= (kasahareket.Where(c => c.KasaKodu == kasa.KasaKodu && c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0),
                Bakiye= (kasahareket.Where(c => c.KasaKodu == kasa.KasaKodu && c.Hareket == "Kasa Giriş").Sum(c => c.Tutar) ?? 0)- (kasahareket.Where(c => c.KasaKodu == kasa.KasaKodu && c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0)
            }).ToList();
            return result;
        }
        public object OdemeTuruToplamListele(MGsTOKContex context,string kasakodu)
        {
            var result = (from c in context.KasaHareketleri.Where(c => c.KasaKodu == kasakodu)group c by new { c.OdemeTuruAdi } 
                into grp 
                select new
            {
                    grp.Key.OdemeTuruAdi,
                    KasaGiris=(grp.Where(c=>c.OdemeTuruAdi==grp.Key.OdemeTuruAdi && c.Hareket=="Kasa Giriş").Sum(c=>c.Tutar) ??0),
                    KasaCıkıs=(grp.Where(c => c.OdemeTuruAdi == grp.Key.OdemeTuruAdi && c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0),
                    Bakiye= (grp.Where(c => c.OdemeTuruAdi == grp.Key.OdemeTuruAdi && c.Hareket == "Kasa Giriş").Sum(c => c.Tutar) ?? 0)- (grp.Where(c => c.OdemeTuruAdi == grp.Key.OdemeTuruAdi && c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0)
                }).ToList();
            return result;
        }
        public object GenelToplamListele(MGsTOKContex context, string kasakodu)
        {

            decimal KasaGiris = context.KasaHareketleri.Where(c => c.KasaKodu == kasakodu && c.Hareket == "Kasa Giriş").Sum(c => c.Tutar) ?? 0;
            decimal KasaCıkıs = context.KasaHareketleri.Where(c => c.KasaKodu == kasakodu && c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0;
            int KasaGirisKayitSayisi = context.KasaHareketleri.Where(c => c.KasaKodu == kasakodu && c.Hareket == "Kasa Giriş").Count();
            int KasaCıkısKayitSayisi= context.KasaHareketleri.Where(c => c.KasaKodu == kasakodu && c.Hareket == "Kasa Çıkış").Count();
            List<GenelToplamlar> genelToplam = new List<GenelToplamlar>()
            {
                new GenelToplamlar
                {
                    Bilgi="Kasa Giriş",
                    KayitSayisi=KasaGirisKayitSayisi,
                    ToplamTutar=KasaGiris
                },
                new GenelToplamlar
                {
                    Bilgi="Kasa Çıkış",
                    KayitSayisi=KasaCıkısKayitSayisi,
                    ToplamTutar=KasaGiris
                },
                 new GenelToplamlar
                {
                    Bilgi="Bakiye",
                    KayitSayisi=KasaCıkısKayitSayisi+KasaGirisKayitSayisi,
                    ToplamTutar=KasaGiris-KasaCıkıs
                }
            };
            return genelToplam;
        }
        
    }
}
