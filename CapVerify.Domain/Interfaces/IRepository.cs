using System;
using System.Linq;
using System.Linq.Expressions;

namespace CapVerify.Domain.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        TEntity Add(TEntity obj);
        TEntity GetById(long id);
        IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> expression = null);
        TEntity Update(TEntity obj);
        void Remove(long id);
        int SaveChanges();
    }
}
