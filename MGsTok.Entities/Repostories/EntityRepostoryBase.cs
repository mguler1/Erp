using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MGsTok.Entities.interfaces;
using FluentValidation;
using MGsTok.Entities.Tools;
namespace MGsTok.Entities.Repostories
{
    public class EntityRepostoryBase<TContext, TEntity,TValidator> : IEntitiyRepostory<TContext, TEntity> where TContext : DbContext, new() where TEntity : class, new() where TValidator:IValidator,new()
    {

    public List<TEntity> GetAll(TContext context, Expression<Func<TEntity, bool>> filter=null)
        {
            return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
        }
        public TEntity GetByFilter(TContext context, Expression<Func<TEntity, bool>> filter)
        {
            return context.Set<TEntity>().SingleOrDefault(filter);//tek kayıt döndürüyoruz
        }
    public void  AddOrUpdate(TContext context, TEntity entity)
        {
            TValidator validator = new TValidator();
            var validationResult = ValidaterTool.Validate(validator,entity);
           
                context.Set<TEntity>().AddOrUpdate(entity);
            
           
            
        }

        public void Delete(TContext context, Expression<Func<TEntity, bool>> filter)
        {
            context.Set<TEntity>().RemoveRange(context.Set<TEntity>().Where(filter));
        }

        public void save(TContext context)
        {
            context.SaveChanges();
        }
    }
}
