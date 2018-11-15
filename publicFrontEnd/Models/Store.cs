using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace publicFrontEnd.Models
{
    public class Store
    {
        public string Name { get; }

        public string Description { get; }

        public string BrandName { get; }

        public string CatagoryName { get; }

        public string StockRequired { get; }

        public int StockNumbers { get; set; }

    }
}
