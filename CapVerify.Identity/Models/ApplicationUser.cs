using Microsoft.AspNetCore.Identity;

namespace CapVerify.Identity.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Cpf { get; set; }

        public string Name { get; set; }
    }
}
