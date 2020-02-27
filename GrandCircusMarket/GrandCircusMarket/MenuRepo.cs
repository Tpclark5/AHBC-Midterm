using System;
using System.Collections.Generic;
using System.Text;

namespace GrandCircusMarket
{
    public class MenuRepo
    {
        public Dictionary<int, List<MenuItems>> GetMenuItems()
        {
            List<MenuItems> customerOptions = new List<MenuItems>();
            
            {
                var presentMenuItems = new Dictionary<int, List<MenuItems>>();
                var meats = new List<MenuItems>();
                var produce = new List<MenuItems>();
                var drinks = new List<MenuItems>();

                meats.Add(new Meat() { Chicken = 3 });
                meats.Add(new Meat() { Beef = 6 });
                meats.Add(new Meat() { Fish = 5 });
                meats.Add(new Meat() { Pork = 4 });
                produce.Add(new Produce() { Apples = 2 });
                produce.Add(new Produce() { Oranges = 2 });
                produce.Add(new Produce() { Kale = 5 });
                produce.Add(new Produce() { Spinach = 4 });
                drinks.Add(new Drinks() { Water = 1 });
                drinks.Add(new Drinks() { Juice = 3 });
                drinks.Add(new Drinks() { Coffee = 2 });
                drinks.Add(new Drinks() { Beer = 6 });

                presentMenuItems[1] = meats;
                presentMenuItems[2] = produce;
                presentMenuItems[3] = drinks;

               
                return presentMenuItems;
            }
            
        }

    }
}
