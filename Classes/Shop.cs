using Autofac;
using Autofac.Core;
using DISandbox.Interfaces;

namespace DISandbox.Classes
{
    public class Shop: IShop
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public IEnumerable<IProduct> Products { get; set; }
        public IEnumerable<IPerson> Staff { get; set; }

        public Shop(
            string title, 
            string description,
            IEnumerable<IProduct> products, 
            IEnumerable<IPerson> staff) 
        { 
            Title = title;
            Description = description;
            Products = products;
            Staff = staff;
        }
    }
}
