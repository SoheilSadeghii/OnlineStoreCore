namespace OnlineStoreCore.Models
{
    public class CartItem
    {
        public string Id { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
        public decimal getTotalPrice()
        {
            return Item.Price = Quantity;
        }
    }
}
