using CapVerify.Domain.Interfaces;
using CapVerify.Domain.Interfaces.Services;

namespace CapVerify.Domain.Services
{
    public abstract class Service<TEntity> : IService<TEntity> where TEntity : class
    {
        private readonly IRepository<TEntity> _repository;
        protected readonly IUnitOfWork UoW;

        public Service(IRepository<TEntity> repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            UoW = unitOfWork;
        }

        public virtual TEntity Add(TEntity obj)
        {
            obj = _repository.Add(obj);

            UoW.Commit();

            return obj;
        }

        public virtual void Dispose()
        {
            _repository.Dispose();
        }

        public virtual void Remove(long id)
        {
            _repository.Remove(id);

            UoW.Commit();
        }

        public virtual TEntity Update(TEntity obj)
        {
            obj = _repository.Update(obj);

            UoW.Commit();

            return obj;
        }
    }
}
