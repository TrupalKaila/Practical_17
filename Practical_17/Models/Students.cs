using System.ComponentModel.DataAnnotations;

namespace Practical_17.Models
{
    public class Students
    {
        [Key]
        public int StudentId { get; set; }
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
        public string Gender { get; set; }
        
    }
}
