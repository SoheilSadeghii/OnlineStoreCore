using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

namespace OnlineStoreCore.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        [Required]
        public int UserID { get; set; }

        [Required]
        public DateTime CreateDate { get; set; }
        public bool IsFinaly { get; set; }

        // Navigation Property
        public User Users { get; set; }
    }
}
