using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using MGsTok.Entities.Tables;

namespace MGsTok.Entities.Validations
{
   public class CariValidater:AbstractValidator<Cari>
    {
        public CariValidater()
        {
            RuleFor(p => p.CariKodu).NotEmpty().WithMessage("Cari Kodu Alanı Boş Geçilemez");
            RuleFor(p => p.CariAdi).NotEmpty().WithMessage("Cari Adı Alanı Boş Geçilemez").Length(5, 50).WithMessage("Stok Adı Alanı 5 ile 50 karakter Arasında olabilir");
            RuleFor(p => p.YetkiliKisi).NotEmpty().WithMessage("Yetkili Kişi Alanı Boş Geçilemez");
            RuleFor(p => p.FaturaUnvani).NotEmpty().WithMessage("Fatura Ünvanı Alanı Boş Geçilemez");
            RuleFor(p => p.Email).EmailAddress().WithMessage("Girdiğiniz E-Mail Adresi Geçersiz");

        }
    }
}
