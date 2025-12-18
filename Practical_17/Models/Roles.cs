using System.ComponentModel.DataAnnotations;

namespace Practical_17.Models
{
    public class Roles
    {
        [Key]
        public int RoleId { get; set; }

        [Required]
        [MaxLength(30)]
        public string RoleName { get; set; } 

        public ICollection<Users> Users { get; set; }
    }
}
