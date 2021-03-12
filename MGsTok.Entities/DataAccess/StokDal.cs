using MGsTok.Entities.Contex;
using MGsTok.Entities.Repostories;
using MGsTok.Entities.Tables;
using MGsTok.Entities.Validations;
using System.Linq;
namespace MGsTok.Entities.DataAccess
{
    public class StokDal:EntityRepostoryBase<MGsTOKContex,Stok,StokValidater>//base entiysden miras aldım

    {
        public object GetAlljoin(MGsTOKContex context)
        {
            //group joinle stoklar ve stok harekteleri  tabllosunu birrleştirdim
            var tablo = context.Stoklar.GroupJoin(context.StokHareketleri, c => c.StokKodu, c => c.StokKodu, (Stoklar, StokHareketleri) => new
            {
                Stoklar.Id,
                Stoklar.Durumu,
                Stoklar.StokKodu,
                Stoklar.StokAdi,
                Stoklar.Barkod,
                Stoklar.BarkodTuru,
                Stoklar.StokBirimi,
                Stoklar.StokGrubu,
                Stoklar.StokAltGrubu,
                Stoklar.Marka,
                Stoklar.Model,
                Stoklar.OzelKod1,
                Stoklar.OzelKod2,
                Stoklar.OzelKod3,
                Stoklar.OzelKod4,
                Stoklar.GarantiSuresi,
                Stoklar.UreticiKodu,
                Stoklar.AlisKdv,
                Stoklar.SatisKdv,
                Stoklar.AlisFiyati1,
                Stoklar.AlisFiyati2,
                Stoklar.AlisFiyati3,
                Stoklar.SatisFiyati1,
                Stoklar.SatisFiyati2,
                Stoklar.SatisFiyati3,
                Stoklar.MinStokMiktari,
                Stoklar.MaxStokMiktari,
                Stoklar.Aciklama,
                StokGiris = StokHareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktari) ?? 0,//stok giriş adında kolon oluşturdum stok harektelerinin toplam değerini atadım.
                StokCıkıs = StokHareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktari) ?? 0,//stok çıkış adında kolon oluşturdum stok harektelerinin toplam değerini atadım
                MevcutStok = StokHareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktari) - StokHareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktari) ?? 0 // nulll ise değerini 0 ata
            }
         ).ToList();
            return tablo;
        }


       
     
    }
}
