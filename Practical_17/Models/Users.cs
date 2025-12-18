using System.ComponentModel.DataAnnotations;

namespace Practical_17.Models
{
    public class Users
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MaxLength(15)]
        public string MobileNumber { get; set; }
        [Required]
        public string Password { get; set; }

        public int RoleId { get; set; }
        public Roles Role { get; set; }
    }
}
