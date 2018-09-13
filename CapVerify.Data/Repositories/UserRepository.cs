using CapVerify.Data.Context;
using CapVerify.Domain.Interfaces;
using CapVerify.Domain.Models;

namespace CapVerify.Data.Repositories
{
    public class UserRepository : Repository<UserIdentity>, IUserRepository
    {
        public UserRepository(CapVerifyContext context) : base(context)
        {
        }
    }
}
