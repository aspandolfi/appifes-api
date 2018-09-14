using CapVerify.Data.Context;
using CapVerify.Domain.Interfaces;
using CapVerify.Domain.Models;
using System.Linq;

namespace CapVerify.Data.Repositories
{
    public class UserRepository : Repository<UserIdentity>, IUserRepository
    {
        readonly CapVerifyContext _context;
        public UserRepository(CapVerifyContext context) : base(context)
        {
            _context = context;
        }

        public UserIdentity GetByEmail(string email)
        {
            return DbSet.SingleOrDefault(x => x.UserName == email);
        }
    }
}
