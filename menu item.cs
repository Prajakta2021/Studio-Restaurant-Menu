using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    public class MenuItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsNew { get; set; }
        public MenuItem(string name, string description, string category, double price)
        {
            Name = name;
            Description = description;
            Category = category;
            Price = price;
            DateAdded = DateTime.Now;
        }

        public override bool Equals(object obj)
        {
            if (obj == this)
            {
                return true;
            }
            if (obj == null)
            {
                return false;
            }
            if (obj.GetType() != GetType())
            {
                return false;
            }

            MenuItem menuItemObj = obj as MenuItem;
            return Name == menuItemObj.Name && Price == menuItemObj.Price;
        }

    }


}