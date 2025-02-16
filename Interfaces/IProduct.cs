using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISandbox.Interfaces
{
    public interface IProduct
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    }
}
