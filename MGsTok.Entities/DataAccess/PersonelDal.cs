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
  public  class PersonelDal: EntityRepostoryBase<MGsTOKContex, Personel, PersonelValidater>//base entiysden miras aldım
    {
        public object PersonelListele(MGsTOKContex contex)
        {
            var result = contex.Personeller.GroupJoin(contex.Fisler, c => c.PersonelKodu, c => c.PlasiyerKodu, (personel, fis) => new
            {
                personel.Id,
                personel.Calisiyot,
                personel.PersonelKodu,
                personel.PersonelAdi,
                personel.Unvani,
                personel.TcKimlikNo,
                personel.IseGirisTarihi,
                personel.IstenCikis,
                personel.VergiDairesi,
                personel.VergiNo,
                personel.CepTelefonu,
                personel.Il,
                personel.Ilce,
                personel.Semt,
                personel.Adres,
                personel.Fax,
                personel.Email,
                personel.Web,
                personel.PrimOrani,
                personel.AylıkMaas,
                personel.Aciklama,
                ToplamSatis = fis.Where(c => c.FisTuru == "Perakende Satış Faturası").Sum(c => c.ToplamTutar) ?? 0,
                Prim = (fis.Where(c => c.FisTuru == "Perakende Satış Faturası").Sum(c => c.ToplamTutar) ?? 0) / 100 * personel.PrimOrani,
            }
            ).ToList();
            return result;
        }
    }
}
