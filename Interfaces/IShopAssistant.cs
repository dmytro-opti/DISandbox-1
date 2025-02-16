using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISandbox.Interfaces
{
    public interface IShopAssistant : IPerson
    {
        public IEnumerable<IProduct> ResponsibleProducts { get; set; }
        public string JobTitle { get; set; }
    }
}
