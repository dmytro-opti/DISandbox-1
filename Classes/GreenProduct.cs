using DISandbox.Interfaces;

namespace DISandbox.Classes
{
    public class GreenProduct : IProduct
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        /*public GreenProduct(string title) 
        {
            Title = title;
        }*/
    }
}
