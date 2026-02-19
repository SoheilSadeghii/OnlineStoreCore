namespace OnlineStoreCore.Models
{
    public class OrderDetail
    {
        public int DetailId { get; set; }
        public int OrderId { get; set; }

        // Navigation Property
        public Order Order { get; set; }
    }
}
