using System;
using System.ComponentModel.DataAnnotations;

namespace CapVerify.Identity.Models
{
    public class LoginViewModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
