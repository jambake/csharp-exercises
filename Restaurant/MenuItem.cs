using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant
{
    public class MenuItem
    {
        public string Name { get; set; }
        public double Price { get; internal set; }
        public string Description { get; set; }
        public List<string> Category { get; set; } // make int field as index position of list?
        public bool IsNewItem { get; set; }


        public MenuItem(string name, string description, double price, List<string> category)
        { 
            Name = name;
            Price = price;
            Description = description;
            Category = category;
            IsNewItem = true;
        }
    }
}
