﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISandbox.Interfaces
{
    public interface IProduct : IShortProduct
    {
        public string Description { get; set; }
    }
}
