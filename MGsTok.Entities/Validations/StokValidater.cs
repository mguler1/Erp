using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using MGsTok.Entities.Tables;

namespace MGsTok.Entities.Validations
{
  public  class StokValidater:AbstractValidator<Stok>
    {
        public StokValidater()
        {
           //RuleFor(p => p.StokKodu).NotEmpty().WithMessage("Stok Kodu Alanı Boş Geçilemez");
           //RuleFor(p => p.StokAdi).NotEmpty().WithMessage("Stok Adı Alanı Boş Geçilemez").Length(5,50).WithMessage("Stok Adı Alanı 5 ile 50 karakter Arasında olabilir");
           //RuleFor(p => p.Barkod).NotEmpty().WithMessage("Barkod Alanı Boş Geçilemez");
           // RuleFor(p => p.AlisFiyati1).GreaterThan(0).WithMessage("Alış Fiyatı 0 Dan Büyük Olmalıdır");

        }


    }
}
