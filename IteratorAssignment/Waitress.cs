using IteratorAndCompositeExercise.InterfaceIterator;
using IteratorAndCompositeExercise.Menus;
using static IteratorAndCompositeExercise.Menus.ModelforMenus;

namespace IteratorAndCompositeExercise
{
    public class Waitress
    {
        // Declare instances of PancakeHouseMenu and DinerMenu
        PancakeHouseMenu pancakeHouseMenu;
        DinerMenu dinerMenu;


        // Constructor to initialize the Waitress with menus
        public Waitress(PancakeHouseMenu pancakeHouseMenu, DinerMenu dinerMenu)
        {
            this.pancakeHouseMenu = pancakeHouseMenu;
            this.dinerMenu = dinerMenu;
        }
        public void PrintMenu()
        {
            // Create iterators for PancakeHouseMenu and DinerMenu
            IIterator pancakeIterator = pancakeHouseMenu.CreateIterator();
            IIterator dinerIterator = dinerMenu.CreateIterator();

            // Print Breakfast Menus
            Console.WriteLine("MENU\n---\nBREAKFAST");
            PrintMenu(pancakeIterator);

            // Print lunch menu
            Console.WriteLine("\nLUNCH");
            PrintMenu(dinerIterator);
        }
        public void PrintMenu(IIterator iterator)
        {
            while (iterator.HasNext())
            
            {
                MenuItem menuItem = (MenuItem)iterator.Next();
                Console.Write(menuItem.GetName() + ", ");
                Console.Write(menuItem.GetPrice() + " -- ");
                Console.WriteLine(menuItem.GetDescription());
            }
        }

    }
}