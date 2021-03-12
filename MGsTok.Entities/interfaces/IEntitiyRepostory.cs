using MGsTok.Entities.Contex;
using MGsTok.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace MGsTok.Entities.interfaces
{
    public interface IEntitiyRepostory<TContext,TEntity> where TContext:DbContext,new() where TEntity:class ,new()
    {
         void AddOrUpdate(TContext context,TEntity TEntity);
         void Delete(TContext context, Expression<Func<TEntity, bool>> filter);
         void save(TContext context);
    }
}
