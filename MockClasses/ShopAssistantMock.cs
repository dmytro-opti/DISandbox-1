using DISandbox.Interfaces;

namespace DISandbox.MockClasses
{
    public class ShopAssistantMock : IShopAssistant
    {
        public IEnumerable<IProduct> ResponsibleProducts { get; set; }
        public string JobTitle { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }

        public ShopAssistantMock(string name, double balance) 
        { 
            Name = name;
            Balance = balance;
        }
    }
}
