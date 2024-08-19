using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class Inventory
    {
        public List <Item> items { get; set; }
        public Inventory() {

            items.Add(new Item("Bagel", 0.49, "BGLO", "Onion"));
            items.Add(new Item("Bagel", 0.39, "BGLP", "Plain"));
            items.Add(new Item("Bagel", 0.49, "BGLE", "Everything"));
            items.Add(new Item("Bagel", 0.49, "BGLS", "Sesame"));
            items.Add(new Item("Coffee", 0.99, "COFB", "Black"));
            items.Add(new Item("Coffee", 1.19, "COFW", "White"));
            items.Add(new Item("Coffee", 1.29, "COFC", "Capuccino"));
            items.Add(new Item("Coffee", 1.29, "COFL", "Latte"));
            items.Add(new Item("Filling", 0.12, "FILB", "Bacon"));
            items.Add(new Item("Filling", 0.12, "FILE", "Egg"));
            items.Add(new Item("Filling", 0.12, "FILC", "Cheese"));
            items.Add(new Item("Filling", 0.12, "FILX", "Cream Cheese"));
            items.Add(new Item("Filling", 0.12, "FILS", "Smoked Salmon"));
            items.Add(new Item("Filling", 0.12, "FILH", "Ham"));
        }
        
    }
}