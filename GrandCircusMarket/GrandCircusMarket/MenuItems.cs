using System;
using System.Collections.Generic;
using System.Text;

namespace GrandCircusMarket
{
    public class MenuItem
    {

    }



    public class Meat : MenuItem
    {
        public int Chicken { get; set; }
        public int Fish { get; set; }
        public int Beef { get; set; }
        public int Pork { get; set; }
    }

    public class Produce : MenuItem
    {
        public int Apples { get; set; }
        public int Oranges { get; set; }
        public int Kale { get; set; }
        public int Spinach { get; set; }
    }


    public class Drink:MenuItem
    { 
        public int Water { get; set; }
        public int Juice { get; set; }
        public int Coffee { get; set; }
        public int Beer { get; set; }
    }



}
