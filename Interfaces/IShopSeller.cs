using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISandbox.Interfaces
{
    public interface IShopSeller : IPerson
    {
        public string JobTitle { get; set; }
        public IEnumerable<IProduct> SoldProducts { get; set; }

        public void Sell(IEnumerable<IProduct> products);
    }
}
