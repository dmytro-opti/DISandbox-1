using Autofac;
using DISandbox.Classes;
using DISandbox.Interfaces;
using DISandbox.MockClasses;

namespace DISandbox
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IContainer container = InitializeDI();
            //IContainer container = InitializeFakeDI();

            var products = new List<IProduct>();
            foreach (var item in Enumerable.Range(1, 100))
            {
                var product = container.Resolve<IProduct>();
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

            var classes = container.Resolve<IEnumerable<IShortProduct>>();

            foreach (var item in classes)
            {
                if (item is GreenProduct)
                {
                    Console.WriteLine("THis is green product!");
                }

                if (item is Product)
                {
                    Console.WriteLine("THis is product!");
                }
            }

            IShortProduct shortProduct = container.Resolve<IShortProduct>();

            Console.WriteLine(shop.Title);

            var shopAssistant = container.Resolve<IShopAssistant>();
            var shopSeller = container.Resolve<IShopSeller>();
            var buyer = container.Resolve<IPerson>();

        }

        public static IContainer InitializeDI()
        {
            var builder = new ContainerBuilder();

            // Scan an assembly for components
            builder.RegisterAssemblyTypes(new Program().GetType().Assembly)
                   .AsImplementedInterfaces();

            // Register individual components
            builder.RegisterType<Shop>();
            builder.RegisterType<Product>().As<IProduct>();
            builder.RegisterType<GreenProduct>().As<IProduct>();


            return builder.Build();
        }

        public static IContainer InitializeFakeDI()
        {
            var builder = new ContainerBuilder();
            // Register individual components
            builder.RegisterType<ProductMock>().As<IProduct>();
            builder.RegisterType<GreenProductMock>().As<IProduct>();
            builder.RegisterType<ProductMock>().As<IShortProduct>();
            builder.RegisterType<GreenProductMock>().As<IShortProduct>();
            builder.RegisterType<ShopMock>().As<IShop>();
            builder.RegisterType<ShopSellerMock>().As<IShopSeller>();
            builder.RegisterType<ShopAssistantMock>().As<IShopAssistant>();
            builder.RegisterType<PersonMock>().As<IPerson>();


            return builder.Build();
        }
    }

}