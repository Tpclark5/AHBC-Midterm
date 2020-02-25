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
        public double PriceOfChicken { get; set; }
        public double PriceOfFish { get; set; }
        public double PriceOfBeef { get; set; }
        public double PriceOfPork { get; set; }
    }

    public class Produce : MenuItems
    {
        public double PriceOfApples { get; set; }
        public double PriceOfOranges { get; set; }
        public double PriceOfKale { get; set; }
        public double PriceOfSpinach { get; set; }

    }

    public class Drinks : MenuItems
    {
        public double PriceOfWater { get; set; }
        public double PriceOfJuice { get; set; }
        public double PriceOfCoffee { get; set; }
        public double PriceOfBeer { get; set; }
    }
}
