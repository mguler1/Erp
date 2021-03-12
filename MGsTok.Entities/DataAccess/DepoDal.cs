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
    public class DepoDal : EntityRepostoryBase<MGsTOKContex, Depo, StokValidater>//base entiysden miras aldım
    {
        public object DepobazındaStokListele(MGsTOKContex context, string stokkodu)

        {
            var result = context.Depolar.GroupJoin(context.StokHareketleri.Where(c => c.StokKodu == stokkodu), c => c.DepoKodu, c => c.DepoKodu, (depolar, stokhareketleri) => new
            {
                depolar.Id,
                depolar.DepoKodu,
                depolar.DepoAdi,
                depolar.YetkiliKodu,
                depolar.YetkiliAdi,
                depolar.Telefon,
                depolar.DepoIl,
                depolar.DepoIlce,
                depolar.Semt,
                depolar.Adresi,
                StokGiris = stokhareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktari) ?? 0,
                StokCikis = stokhareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktari) ?? 0,
                MevcutStok = stokhareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktari) ?? 0 - stokhareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktari) ?? 0,
            }).ToList();
            return result;
        }
    }
}