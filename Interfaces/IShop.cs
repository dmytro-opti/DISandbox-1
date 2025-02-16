using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISandbox.Interfaces
{
    public interface IShop
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public IEnumerable<IProduct> Products { get; set; }
        public IEnumerable<IPerson> Staff { get; set; }
    }
}
