using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineStoreCore.Models
{
    public class OrderDetail
    {
        public int DetailId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }


        // Navigation Property
        public Order Order { get; set; }
        [ForeignKey("ProductId")]
        public Product MyProperty { get; set; }
    }
}
