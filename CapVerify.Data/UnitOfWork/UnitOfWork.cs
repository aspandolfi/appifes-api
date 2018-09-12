using CapVerify.Data.Context;
using CapVerify.Domain.Interfaces;

namespace CapVerify.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CapVerifyContext _context;

        public UnitOfWork(CapVerifyContext context)
        {
            _context = context;
        }

        public bool Commit()
        {
            return _context.SaveChangesAsync().GetAwaiter().GetResult() > 0;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
