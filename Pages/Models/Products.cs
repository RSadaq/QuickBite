namespace QuickBite.Pages.Models
{
    public class Products //entities on DB
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageName { get; set; }
    }
}