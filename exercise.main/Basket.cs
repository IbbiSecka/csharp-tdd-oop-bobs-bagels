using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class Basket
    {
        List<Item> _items = new List<Item>();
        
        public bool AddItem(Item item) { 
            if (_items.Count < MaxCapacity) 
            { 
                _items.Add(item); 
                return true;
            }
            return false;
        }

        public string RemoveItem(Item item)
        {
            if (!_items.Contains(item))
                { 
                return "Item does not exist"; 
            }
           
            _items.Remove(item);
            return "Item removed";
        }
        public int CheckCapacity() {
            return _items.Count;
        }
        public double Total => _items.Sum(i => i.price);
        public int MaxCapacity { get; set; } = 5;
        public double itemPrice (Item item)
        {
            return item.price;
        }

        public int ChangeMaxCapacity(int MaxCapacity) {


            return MaxCapacity = 8;

        }
        public Dictionary<Item,Filling> AddFilling(Item item, Filling filling)
        {
            Dictionary<Item,Filling> BagelWithFilling = new Dictionary<Item,Filling>();
            BagelWithFilling.Add(item, filling);
            return BagelWithFilling;

        }

    }
}
