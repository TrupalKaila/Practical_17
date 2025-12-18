using System.ComponentModel.DataAnnotations;

namespace Practical_17.Models
{
    public class UserViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
