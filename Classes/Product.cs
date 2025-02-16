using DISandbox.Interfaces;

namespace DISandbox.Classes
{
    public class Product : IProduct
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public Product(string title, string description, double price) 
        {
            Title = title;
            Description = description;
            Price = price;
        }
    }
}
