using System;
using System.Collections.Generic;

namespace RestaurantMenu
{
    public class Menu
    {
        public List<MenuItem> MenuItems = new List<MenuItem>();
        //        public string MenuItem { get; set; }
        public DateTime LastTimeUpdated { get; set; }


        public Menu()
        {
            List<MenuItem> menuItems = new List<MenuItem>();
            DateTime lastUpdated = DateTime.Now;
            MenuItems = menuItems;
            LastTimeUpdated = lastUpdated;
        }

        public void AddItems(MenuItem toBeAdded)
        {
            MenuItems.Add(toBeAdded);
            LastTimeUpdated = DateTime.Today;
        }

        public void Remove(MenuItem toBeDeleted)
        {
            MenuItems.Remove(toBeDeleted);
        }

        public bool NewItem(MenuItem item)
        {
            MenuItems.Contains(item);
            return true;
        }
        public void PrintAll()
        {
            /*for (int i=0; i<MenuItems.Count; i++)
            {
                Console.WriteLine(MenuItems[i]);
            }*/
            MenuItems.ForEach(menuItem => Console.WriteLine(menuItem));
        }



    }

}