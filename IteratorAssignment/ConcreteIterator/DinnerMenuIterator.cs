using IteratorAndCompositeExercise.InterfaceIterator;
using static IteratorAndCompositeExercise.Menus.ModelforMenus;

namespace IteratorAndCompositeExercise.ConcreteIterator
{
    // Concrete iterator for DinerMenu
    internal class DinerMenuIterator : IIterator
    {
        // Array of menu items
        MenuItem[] items;

        // Position tracker
        int position = 0;

        // Constructor to initialize the iterator with menu items
        public DinerMenuIterator(MenuItem[] items)
        {
            this.items = items;
        }

        // Method to get the next element
        public object Next()
        {
            MenuItem menuItem = items[position];
            position = position + 1;
            return menuItem;
        }

        // Method to check if there is a next element
        public bool HasNext()
        {
            return position < items.Length && items[position] != null;
        }
    }
}
