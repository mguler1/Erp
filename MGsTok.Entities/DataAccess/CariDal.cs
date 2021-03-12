using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MGsTok.Entities.Contex;
using MGsTok.Entities.interfaces;
using MGsTok.Entities.Repostories;
using MGsTok.Entities.Contex;
using MGsTok.Entities.Tables;
using MGsTok.Entities.Tables;

using MGsTok.Entities.Validations;

namespace MGsTok.Entities.DataAccess
{
    public class CariDal : EntityRepostoryBase<MGsTOKContex, Cari, CariValidater>//base entiysden miras aldım
    {
        public object GetCariler(MGsTOKContex context)//tüm listeyi getirme
        {
            var result = context.Cariler.GroupJoin(context.Fisler, c => c.CariKodu, c => c.CariKodu, (cariler, fisler) => new
            {
                cariler.Id,
                cariler.CariKodu,
                cariler.Durumu,
                cariler.CariAdi,
                cariler.CariTuru,
                cariler.YetkiliKisi,
                cariler.FaturaUnvani,
                cariler.CepTelefonu,
                cariler.Telefon,
                cariler.Fax,
                cariler.Email,
                cariler.WebAdresi,
                cariler.Il,
                cariler.Ilce,
                cariler.Semt,
                cariler.Adres,
                cariler.CariGrubu,
                cariler.CariAltGrubu,
                cariler.OzelKod1,
                cariler.OzelKod2,
                cariler.OzelKod3,
                cariler.OzelKod4,
                cariler.VergiNo,
                cariler.VergiDairesi,
                cariler.IskontoOrani,
                cariler.RiskLimit,
                cariler.AlisOzelFiyati,
                cariler.SatisOzelFiyati,
                cariler.Aciklama,
                AlisToplam = fisler.Where(c => c.FisTuru == "Alış Faturası").Sum(c => c.ToplamTutar) ?? 0,
                SatisToplam = fisler.Where(c => c.FisTuru == "Perakende Satış Faturası").Sum(c => c.ToplamTutar) ?? 0,
            }).GroupJoin(context.KasaHareketleri, c => c.CariKodu, c => c.CariKodu, (cariler, kasahareket) => new
            {
                cariler.Id,
                cariler.CariKodu,
                cariler.Durumu,
                cariler.CariAdi,
                cariler.CariTuru,
                cariler.YetkiliKisi,
                cariler.FaturaUnvani,
                cariler.CepTelefonu,
                cariler.Telefon,
                cariler.Fax,
                cariler.Email,
                cariler.WebAdresi,
                cariler.Il,
                cariler.Ilce,
                cariler.Semt,
                cariler.Adres,
                cariler.CariGrubu,
                cariler.CariAltGrubu,
                cariler.OzelKod1,
                cariler.OzelKod2,
                cariler.OzelKod3,
                cariler.OzelKod4,
                cariler.VergiNo,
                cariler.VergiDairesi,
                cariler.IskontoOrani,
                cariler.RiskLimit,
                cariler.AlisOzelFiyati,
                cariler.SatisOzelFiyati,
                cariler.Aciklama,
                Alacak = cariler.AlisToplam + (kasahareket.Where(c => c.Hareket == "Kasa Giriş").Sum(c => c.Tutar) ?? 0),
                Borc = cariler.SatisToplam + (kasahareket.Where(c => c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0),
                Bakiye = (cariler.AlisToplam + (kasahareket.Where(c => c.Hareket == "Kasa Giriş").Sum(c => c.Tutar) ?? 0)) - (cariler.SatisToplam + (kasahareket.Where(c => c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0))
            }).ToList();
            return result;
        }

        //cari hareket kodlama
        public object CariFisAyrinti(MGsTOKContex context, string cariKodu)
            {
            var result = context.Fisler.Where(c => c.CariKodu == cariKodu).GroupJoin( context.KasaHareketleri.Where(c => c.CariKodu == cariKodu), c => c.CariKodu, c => c.CariKodu,(fisler, kasahareket) => new
            {
                fisler.FisKodu,
                fisler.FisTuru,
                fisler.PlasiyerKodu,
                fisler.PlasiyerAdi,
                fisler.BelgeNo,
                fisler.Tarih,
                fisler.IskontoOrani,
                fisler.IskontoTutari,
                fisler.Aciklama,
                fisler.ToplamTutar,
                Odenen=context.KasaHareketleri.Where(c=>c.FisKodu==fisler.FisKodu).Sum(c=>c.Tutar) ??0,
                kalanOdeme=fisler.ToplamTutar- context.KasaHareketleri.Sum(c => c.Tutar) ?? 0,



            }).ToList();
            return result;
            }

        public object CariFisGenelToplam(MGsTOKContex context, string cariKodu)//Fiş türlerine göre toplamlar
        {
            var result = (from c in context.Fisler.Where(c => c.CariKodu == cariKodu) group c by new { c.FisTuru, c.ToplamTutar } into grp select new
            {
                Bilgi = grp.Key.FisTuru,
                KayitSayisi = grp.Count(),
                ToplamTutar=grp.Sum(c=>c.ToplamTutar)
            }).ToList();
            return result;
        }
        public object CariGenelToplam(MGsTOKContex context, string cariKodu) //Müşteri Ekstresi
        {
            decimal alacak = context.Fisler.Where(c => c.CariKodu == cariKodu && c.FisTuru == "Alış Faturası").Sum(c => c.ToplamTutar) ?? 0 + (context.KasaHareketleri.Where(c=>c.CariKodu==cariKodu && c.Hareket=="Kasa Giriş").Sum(c=>c.Tutar) ?? 0);
            decimal borc= context.Fisler.Where(c => c.CariKodu == cariKodu && c.FisTuru == "Perakende Satış Faturası").Sum(c => c.ToplamTutar) ?? 0 + (context.KasaHareketleri.Where(c => c.CariKodu == cariKodu && c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0);
            List<GenelToplamlar> genelToplam = new List<GenelToplamlar>()
            {
                new GenelToplamlar
                {
                    Bilgi="Alacak",
                    ToplamTutar=alacak
                },
                new GenelToplamlar
                {
                    Bilgi="Borc",
                    ToplamTutar=borc
                },
                 new GenelToplamlar
                {
                    Bilgi="Bakiye",
                    ToplamTutar=alacak-borc
                }
            };
            return genelToplam;
        }
        public CariBakiye CariBakiyesi(MGsTOKContex context,string cariKodu)
        {
            decimal alacak = context.Fisler.Where(c => c.CariKodu == cariKodu && c.FisTuru == "Alış Faturası").Sum(c => c.ToplamTutar) ?? 0 + (context.KasaHareketleri.Where(c => c.CariKodu == cariKodu && c.Hareket == "Kasa Giriş").Sum(c => c.Tutar) ?? 0);
            decimal borc = context.Fisler.Where(c => c.CariKodu == cariKodu && c.FisTuru == "Perakende Satış Faturası").Sum(c => c.ToplamTutar) ?? 0 + (context.KasaHareketleri.Where(c => c.CariKodu == cariKodu && c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0);

            
            CariBakiye enity = new CariBakiye
            {
                CariKodu = cariKodu,
                RiskLimiti = Convert.ToDecimal(context.Cariler.Where(c => c.CariKodu == cariKodu).SingleOrDefault().RiskLimit),
                Alacak=alacak,
                Borc=borc,
                Bakiye=alacak-borc
            };
            return enity;
        }
        public object CariTelefonlari(MGsTOKContex contex)
        {
            var result = (from c in contex.Cariler
                          select new
                          {
                              c.CariKodu,
                              c.CariAdi,
                              c.CepTelefonu
                          }).ToList();
            return result;
        }
    }
}
