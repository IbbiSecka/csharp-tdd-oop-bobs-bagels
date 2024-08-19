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

        public bool RemoveItem(Item item)
        {
            _items.Remove(item);
            return true;
        }
        public int CheckCapacity() {
            return _items.Count;
        }
        public double Total => _items.Sum(i => i.price);
        public int MaxCapacity { get; set; } = 5;    
    
    }
}
