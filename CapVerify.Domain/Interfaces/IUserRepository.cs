using CapVerify.Domain.Models;

namespace CapVerify.Domain.Interfaces
{
    public interface IUserRepository : IRepository<UserIdentity>
    {
        UserIdentity GetByEmail(string email);
    }
}
