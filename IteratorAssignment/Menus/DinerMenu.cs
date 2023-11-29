using IteratorAndCompositeExercise.ConcreteIterator;
using IteratorAndCompositeExercise.InterfaceIterator;
using static IteratorAndCompositeExercise.Menus.ModelforMenus;

namespace IteratorAndCompositeExercise.Menus
{
    public class DinerMenu
    {
        // Maximum number of items in the diner menu
        private int Max_Items = 6;

        // Counter for the number of items in the diner menu
        int numberOfItems = 0;

        
        MenuItem[] MenuItems;

        // Constructor to initialize the diner menu with default items
        public DinerMenu()
        {
            // Initialize the array for diner menu items
            MenuItems = new MenuItem[Max_Items];

            // Add default items to the diner menu
            AddItem("Vegetarian BLT", "(Fakin´) Bacon with lettuce & tomato on whole wheat", true, 2.99);
            AddItem("BLT", "Bacon with lettuce & tomato on whole wheat", false, 2.99);
            AddItem("Soup of the day", "Soup of the day, with a side of potato salad", false, 3.29);
            AddItem("HotDog", "A hot dog, with saurkraut, relish, onions, topped with cheese", false, 3.29);
            AddItem("Steamed Veggies and Brown Rice", "Steamed Vegetable over brown rice", true, 3.99);
            AddItem("Pasta", "Spaghetti with Marinara Sauce, and a slice of sourdough bread", true, 3.89);
        }

        // Method to add a new item to the diner menu
        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);

            // Check if the menu is full before adding an item
            if (numberOfItems >= Max_Items)
            {
                Console.WriteLine("Sorry, menu is full! Can't add item to menu");
            }
            else
            {
                // Add the item to the menu and increment the counter
                MenuItems[numberOfItems] = menuItem;
                numberOfItems++;
            }
        }

        
        public IIterator CreateIterator()
        {
            
            return new DinerMenuIterator(MenuItems);
        }
    }
}
