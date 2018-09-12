using CapVerify.Data.Context;
using CapVerify.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace CapVerify.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly CapVerifyContext Db;
        protected readonly DbSet<TEntity> DbSet;

        public Repository(CapVerifyContext context)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
        }

        public virtual TEntity Add(TEntity obj)
        {
            return DbSet.Add(obj).Entity;
        }

        public virtual TEntity GetById(long id)
        {
            return DbSet.Find(id);
        }

        public virtual IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> expression = null)
        {
            if (expression == null)
            {
                return DbSet;
            }

            return DbSet.Where(expression);
        }

        public virtual TEntity Update(TEntity obj)
        {
            return DbSet.Update(obj).Entity;
        }

        public virtual void Remove(long id)
        {
            DbSet.Remove(DbSet.Find(id));
        }

        public int SaveChanges()
        {
            return Db.SaveChangesAsync().GetAwaiter().GetResult();
        }

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
