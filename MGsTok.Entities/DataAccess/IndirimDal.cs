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
   public class IndirimDal:EntityRepostoryBase<MGsTOKContex,Indirim,IndirimValidator>
    {
    }
}
