using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class Filling 
    {
        public string name {  get; set; } 
        public double price { get; set; }
        public Item bagel { get; set; }
        public Filling(string name, double price, Item bagel)
        {
            this.name = name;
            this.price = price;
            this.bagel = bagel;


        }

    }

    
}
