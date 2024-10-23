using System.ComponentModel.DataAnnotations;

namespace IdentityandDataProtection.Dtos
{
    public class IdentityandDataProtectionDtos
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
