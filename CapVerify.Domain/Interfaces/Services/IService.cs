using System;

namespace CapVerify.Domain.Interfaces.Services
{
    public interface IService<TEntity> : IDisposable where TEntity : class
    {
        TEntity Add(TEntity obj);
        TEntity Update(TEntity obj);
        void Remove(long id);
    }
}
