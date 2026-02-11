using System.ComponentModel.DataAnnotations;

namespace OnlineStoreCore.Models
{
    public class RegisterViewModel
    {
        [Required]
        [MaxLength(300)]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MaxLength(50)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [MaxLength(50)]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string RePassword { get; set; }
    }
}
