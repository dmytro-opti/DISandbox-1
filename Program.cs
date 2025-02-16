using Autofac;
using DISandbox.Classes;
using DISandbox.Interfaces;

namespace DISandbox
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            IContainer container = InitializeDI();

            var products = new List<IProduct>();
            foreach (var item in Enumerable.Range(1, 100))
            {
                var product = container.Resolve<IProduct>(
                    new NamedParameter(nameof(IProduct.Title).ToLower(), $"Product {item}"),
                    new NamedParameter(nameof(IProduct.Description).ToLower(), $"Description {item}"),
                    new NamedParameter(nameof(IProduct.Price).ToLower(), new Random().Next(1, 100))
                );
                products.Add(product);
            }

            var sellers = new List<IShopSeller>();
            foreach (var item in Enumerable.Range(1, 5))
            {
                var seller = container.Resolve<IShopSeller>(
                    new NamedParameter(nameof(IShopSeller.Name).ToLower(), $"Product {item}"),
                    new NamedParameter(nameof(IShopSeller.Balance).ToLower(), new Random().Next(1, 100))
                );
                sellers.Add(seller);
            }


            IShop shop = container.Resolve<IShop>(
                new NamedParameter(nameof(IShop.Title).ToLower(), "Duty Free"),
                new NamedParameter(nameof(IShop.Description).ToLower(), "Super Shop"),
                new NamedParameter(nameof(IShop.Products).ToLower(), products),
                new NamedParameter(nameof(IShop.Staff).ToLower(), sellers)
                );

            Console.WriteLine(shop.Title);

            var shopAssistant = container.Resolve<IShopAssistant>();
            var shopSeller = container.Resolve<IShopSeller>();
            var buyer = container.Resolve<IPerson>();

        }

        public static IContainer InitializeDI()
        {
            var builder = new ContainerBuilder();

            // Register individual components
            /*builder.RegisterInstance(new Shop()).As<IShop>();
            builder.RegisterType<Shop>();
            builder.Register(c => new ShopAssistant()).As<IShopAssistant>();
            builder.Register(c => new ShopSeller()).As<IShopSeller>();
            builder.Register(c => new Person()).As<IPerson>();
            builder.Register(c => new Product()).As<IProduct>();*/

            // Scan an assembly for components
            builder.RegisterAssemblyTypes(new Program().GetType().Assembly)
                   .AsImplementedInterfaces();

            return builder.Build();
        }
    }

}