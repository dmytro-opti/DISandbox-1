using DISandbox.Interfaces;

namespace DISandbox.MockClasses
{
    public class ProductMock : IProduct
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    }
}
