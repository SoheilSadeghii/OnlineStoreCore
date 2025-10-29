namespace OnlineStoreCore.Models
{
    public class Product
    {
        public Product() { Categories = new List<Category>(); }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Category> Categories { get; set; }
    }
}
