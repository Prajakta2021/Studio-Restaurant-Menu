using System;

namespace RestaurantMenu
{
    //public enum ItemTypes { appetizer, mainCourse, dessert }
    /*An enumeration type is a value type defined by a set of
    named constants of the underlying integral numeric type.*/
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            MenuItem item1 = new MenuItem("Chicken Dum Biryani", "Chicken marinated with yogurt and spices cooked with rice then steamed to blen flavor", "mainCourse", 14.77);
            MenuItem item2 = new MenuItem("Gulab Jamoon", "Melt in your mouth, fried dumplings made of thickend milk and then soaked in sugar syrupmade with rose water", "dessert", 3.99);
            menu.AddItems(item1);
            menu.AddItems(item2);
            menu.PrintAll();
            Console.ReadLine();


        }





    }
}
