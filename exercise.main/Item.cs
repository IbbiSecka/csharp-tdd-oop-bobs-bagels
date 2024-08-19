using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class Item
    {
        public string name { get; set; }
        public double price { get; set; }
        public string sku { get; set; }
        public string variant { get; set; }
        public Item(string name, double price, string sku, string variant) {
            this.name = name;
            this.price = price;
            this.sku = sku;
            this.variant = variant;

        }


    }
}
