using System;
using System.Collections.Generic;
using System.Text;

namespace GrandCircusMarket
{
    public class MenuItems
    {

    }
  
    public class Meat : MenuItems
    {
        public double Chicken { get; set; }
        public double Fish { get; set; }
        public double Beef { get; set; }
        public double Pork { get; set; }
    }

    public class Produce : MenuItems
    {
        public double Apples { get; set; }
        public double Oranges { get; set; }
        public double Kale { get; set; }
        public double Spinach { get; set; }

    }

    public class Drinks : MenuItems
    {
        public double Water { get; set; }
        public double Juice { get; set; }
        public double Coffee { get; set; }
        public double Beer { get; set; }
    }



}
