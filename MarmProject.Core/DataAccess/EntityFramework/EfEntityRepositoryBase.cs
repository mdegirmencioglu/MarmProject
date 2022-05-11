using MarmProject.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarmProject.Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
         where TEntity : class, IEntity, new()
         where TContext : DbContext, new()
    {
        public void Delete(TEntity entity)
        {
            using var c = new TContext();
            c.Remove(entity);
            c.SaveChanges();
        }

        public List<TEntity> GetAll()
        {
           using var c=new TContext();
           return c.Set<TEntity>().ToList();
        }

        public TEntity GetByID(int id)
        {
            using var c = new TContext();
            return c.Set<TEntity>().Find(id);
        }

        public void Add(TEntity entity)
        {
            using var c = new TContext();
            c.Add(entity);
            c.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            using var c = new TContext();
            c.Update(entity);
            c.SaveChanges();
        }
    }
}
