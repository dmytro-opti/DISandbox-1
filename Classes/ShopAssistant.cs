using DISandbox.Interfaces;

namespace DISandbox.Classes
{
    public class ShopAssistant : IShopAssistant
    {
        public IEnumerable<IProduct> ResponsibleProducts { get; set; }
        public string JobTitle { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }

        public ShopAssistant(string name, double balance) 
        { 
            Name = name;
            Balance = balance;
        }
    }
}
