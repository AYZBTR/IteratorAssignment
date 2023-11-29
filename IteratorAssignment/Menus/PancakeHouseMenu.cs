using IteratorAndCompositeExercise.ConcreteIterator;
using IteratorAndCompositeExercise.InterfaceIterator;
using System.Collections;
using static IteratorAndCompositeExercise.Menus.ModelforMenus;

namespace IteratorAndCompositeExercise.Menus
{
    public class PancakeHouseMenu
    {
        // Collection to store menu items
        public ArrayList MenuItems { get; set; }

        // Constructor to initialize and add default menu items
        public PancakeHouseMenu()
        {
            // Initialize the menu items collection
            MenuItems = new ArrayList();

            // Add default menu items
            AddItem("K&B´s Pancake Breakfast", "Pancakes with scrambled eggs, and toast", false, 2.99);
            AddItem("Regular Pancake Breakfast", "Pancakes with fried eggs, sausage", false, 2.99);
            AddItem("Blueberry Pancakes", "Pancakes made with fresh blueberries", true, 3.49);
            AddItem("Waffles", "Waffles, with your choice of blueberries or strawberries", true, 3.59);
        }

        // Method to add a new menu item to the collection
        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            // Create a new MenuItem and add it to the collection
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            MenuItems.Add(menuItem);
        }

        // Method to create and return an iterator for the menu
        public IIterator CreateIterator()
        {
            // Create and return a PancakeHouseIterator with the menu items
            return new PancakeHouseIterator(MenuItems);
        }
    }
}
