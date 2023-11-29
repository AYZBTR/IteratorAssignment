using IteratorAndCompositeExercise.InterfaceIterator;
using System.Collections;
using static IteratorAndCompositeExercise.Menus.ModelforMenus;

namespace IteratorAndCompositeExercise.ConcreteIterator
{
    // Concrete iterator for PancakeHouseMenu
    public class PancakeHouseIterator : IIterator
    {
        // Collection of menu items
        ArrayList MenuItems;

        // Position tracker
        int position = 0;

        // Constructor to initialize the iterator with menu items
        public PancakeHouseIterator(ArrayList menuItems)
        {
            this.MenuItems = menuItems;
        }

        // Method to check if there is a next element
        public bool HasNext()
        {
            return position < MenuItems.Count && MenuItems[position] != null;
        }

        // Method to get the next element
        public object Next()
        {
            MenuItem menuItem = (MenuItem)MenuItems[position];
            position++;
            return menuItem;
        }
    }
}
