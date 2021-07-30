using System;
namespace RestaurantMenu
{
    public class Menu
    {
        public string MenuItem { get; set; }
        public DateTime LastTimeUpdated { get; set; }

      
        public Menu(string menuItem, DateTime lastTimeUpdated)
        {
            MenuItem = menuItem;
            LastTimeUpdated = lastTimeUpdated;
        }
    }
}

