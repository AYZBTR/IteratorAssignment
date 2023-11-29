using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorAndCompositeExercise.Menus
{
    internal class ModelforMenus
    {
        // Class representing a menu item
        public class MenuItem
        {
            // Properties for menu item details
            public string Name { get; set; }
            public string Description { get; set; }
            public bool Vegetarian { get; set; }
            public double Price { get; set; }

            // Constructor to initialize menu item details
            public MenuItem(string name, string description, bool vegetarian, double price)
            {
                Name = name;
                Description = description;
                Vegetarian = vegetarian;
                Price = price;
            }

            // Method to get the name of the menu item
            public string GetName()
            {
                return Name;
            }

            // Method to get the description of the menu item
            public string GetDescription()
            {
                return Description;
            }

            // Method to check if the menu item is vegetarian
            public bool IsVegetarian()
            {
                return Vegetarian;
            }

            // Method to get the price of the menu item
            public double GetPrice()
            {
                return Price;
            }
        }
    }
}
