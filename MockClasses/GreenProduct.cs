using DISandbox.Interfaces;

namespace DISandbox.MockClasses
{
    public class GreenProductMock : IProduct
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

    }
}
