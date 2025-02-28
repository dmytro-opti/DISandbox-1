using DISandbox.Interfaces;

namespace DISandbox.MockClasses
{
    public class ShopSellerMock : IShopSeller
    {
        public string JobTitle { get; set; }
        public IEnumerable<IProduct> SoldProducts { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }

        public ShopSellerMock(string name, double balance)
        {
            Name = name;
            Balance = balance;
        }

        public void Sell(IEnumerable<IProduct> products)
        {

        }
    }
}
