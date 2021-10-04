using System;
using System.Collections.Generic;


namespace Chapter4Studio
{
    public class Menu
    {
        private List<MenuItem> MenuItems { get; set; }
        private DateTime LastUpdated { get; set; }


        public Menu(MenuItem item)
        {
            MenuItems.Add(item);
        }

        public override string ToString()
        {
            return MenuItems.ToString();
        }

    }
}