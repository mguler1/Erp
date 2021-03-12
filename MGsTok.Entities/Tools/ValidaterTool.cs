using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentValidation;
using MGsTok.Entities.interfaces;

namespace MGsTok.Entities.Tools
{
   public static class ValidaterTool
    {
        public static bool Validate(IValidator validator, IEntitiy entity)
        {
            bool result = true;
            var validationResult = validator.Validate(entity);
            if (!validationResult.IsValid)//doğrulanmadıysa
            {
                string message = null;
                foreach (var eror in validationResult.Errors)
                {
                    message += eror.ErrorMessage + System.Environment.NewLine;//mesaja erordaki mesajı atıyor
                }
                MessageBox.Show(message);
                result = false;
            }
            return result;
        }

        internal static object Validate<TValidator, TEntity>(TValidator validator, TEntity entity)
            where TValidator : IValidator, new()
            where TEntity : class, new()
        {
            bool result = true;
          //  var validationResult = validator.Validate(entity);
           // if (!validationResult.IsValid)//doğrulanmadıysa
            {
                string message = "İşlem Başarılı";
           //     foreach (var eror in validationResult.Errors)
                {
                //    message += eror.ErrorMessage + System.Environment.NewLine;//mesaja erordaki mesajı atıyor
                }
                MessageBox.Show(message);
                result = false;
            }
            return result;
        }


    }
}
