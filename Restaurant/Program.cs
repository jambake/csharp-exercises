using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Menu newMenu = new Menu();



            Console.ReadLine();
        }
    }

    class Menu
    {
        public Dictionary<string, Object> MenuItems { get; set; }

        public Menu()
        {

        }
        public Menu (Dictionary<string, Object> menuItems)
        {
            MenuItems = menuItems;
        }
    }

    class MenuItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }

        public MenuItem (string name, double price, string description, string category)
        {
            Name = name;
            Price = price;
            Description = description;
            Category = category;
        }
    }
}
