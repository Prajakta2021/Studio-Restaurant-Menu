using System;
using System.Collections.Generic;

namespace RestaurantMenu
{
    public class Menu
    {
        public List<MenuItem> MenuItems = new List<MenuItem>();
//        public string MenuItem { get; set; }
        public DateTime LastTimeUpdated { get; set; }

      
        public Menu(string menuItem, DateTime lastTimeUpdated)
        {
          
            LastTimeUpdated = lastTimeUpdated;
        }
    }
}

