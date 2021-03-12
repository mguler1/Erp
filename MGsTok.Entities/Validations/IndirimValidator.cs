using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using MGsTok.Entities.Tables;

namespace MGsTok.Entities.Validations
{
 public  class IndirimValidator:AbstractValidator<Indirim>
    {
        public IndirimValidator()
        {

        }
    }
}
