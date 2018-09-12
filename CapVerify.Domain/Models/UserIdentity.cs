namespace CapVerify.Domain.Models
{
    public class UserIdentity
    {
        public UserIdentity()
        {

        }

        public string Id { get; set; }

        public string Cpf { get; set; }

        public string Name { get; set; }

        public virtual string PhoneNumber { get; set; }

        public virtual string Email { get; set; }

        public virtual string UserName { get; set; }
    }
}
