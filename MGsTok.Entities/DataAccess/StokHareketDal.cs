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
    public class StokHareketDal : EntityRepostoryBase<MGsTOKContex, StokHareket, StokHareketValidator>//base entiysden miras aldım
    {
        public object GetGenelStok(MGsTOKContex context, string stokkodu)//stok kodunu ilgili stoğun harektelerini getirmek için kullandım
        {
            var result = (from c in context.StokHareketleri.Where(c => c.StokKodu == stokkodu)
                          group c by new { c.Hareket } into g
                          select new
                          {
                              Bilgi = g.Key.Hareket,
                              KayitSayisi = g.Count(),
                              Toplam = g.Sum(c => c.Miktari)
                          }).ToList();
            return result;
        }

        public object GetDepoStok(MGsTOKContex context, string stokkodu)
        {
            var result = context.Depolar.GroupJoin(context.StokHareketleri.Where(c => c.StokKodu == stokkodu), c => c.DepoKodu, c => c.DepoKodu, (depolar, stokhareketleri) => new
            {
                depolar.DepoKodu,
                depolar.DepoAdi,
                StokGiris = stokhareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktari) ?? 0,
                StokCikis = stokhareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktari) ?? 0,
                MevcutStok = stokhareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktari) ?? 0 - stokhareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktari) ?? 0,
            }).ToList();
            return result;
        }


        public object DepoStokListele(MGsTOKContex context,string depokodu)
        {
            //group joinle stoklar ve stok harekteleri  tabllosunu birrleştirdim
            var tablo = context.Stoklar.GroupJoin(context.StokHareketleri.Where(c=>c.DepoKodu==depokodu), c => c.StokKodu, c => c.StokKodu, (Stoklar, StokHareketleri) => new
            {


                Stoklar.StokAdi,
                Stoklar.Barkod,

                StokGiris = StokHareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktari) ?? 0,//stok giriş adında kolon oluşturdum stok harektelerinin toplam değerini atadım.
                StokCıkıs = StokHareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktari) ?? 0,//stok çıkış adında kolon oluşturdum stok harektelerinin toplam değerini atadım
                MevcutStok = StokHareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktari) - StokHareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktari) ?? 0 // nulll ise değerini 0 ata
            }
         ).ToList();
            return tablo;
        }
         public object DepoIstatistik (MGsTOKContex context, string depokodu) //
        {

            List<GenelToplamlar> genelToplam = new List<GenelToplamlar>()
            {
                new GenelToplamlar
                {
                    Bilgi="Stok Giriş",
                    KayitSayisi=context.StokHareketleri.Where(c=>c.DepoKodu==depokodu && c.Hareket=="Stok Giriş").Count(),
                  //  Tutar=context.StokHareketleri.Where(c=>c.DepoKodu==depokodu && c.Hareket=="Stok Giriş").Sum(c=>c.Miktari) ??0
                },
                new GenelToplamlar
                {
                    Bilgi="Stok Çıkış",
                     KayitSayisi=context.StokHareketleri.Where(c=>c.DepoKodu==depokodu && c.Hareket=="Stok Çıkış").Count(),
                 //   Tutar=context.StokHareketleri.Where(c=>c.DepoKodu==depokodu && c.Hareket=="Stok Çıkış").Sum(c=>c.Miktari) ??0
                },
              
            };
            return genelToplam;
        }
        
    }

}