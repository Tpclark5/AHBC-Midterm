using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrandCircusMarket
{
    public class MenuRepo
    {
        public string selectMenuItem()
        {
            var customerOptions = new List<MenuItem>();

            customerOptions.Add(new Meat() { Chicken = 3 });
            customerOptions.Add(new Meat() { Beef = 6 });
            customerOptions.Add(new Meat() { Fish = 5 });
            customerOptions.Add(new Meat() { Pork = 4 });
            customerOptions.Add(new Produce() { Apples = 2 });
            customerOptions.Add(new Produce() { Oranges = 2 });
            customerOptions.Add(new Produce() { Kale = 5 });
            customerOptions.Add(new Produce() { Spinach = 4 });
            customerOptions.Add(new Drink() { Water = 1 });
            customerOptions.Add(new Drink() { Juice = 3 });
            customerOptions.Add(new Drink() { Coffee = 2 });
            customerOptions.Add(new Drink() { Beer = 6 });


            Console.WriteLine("What would you like to order? Please select a number from the menu");
            int userOrderOne = int.Parse(Console.ReadLine());
            var firstItem = customerOptions[userOrderOne];
            Console.WriteLine(firstItem);

            Console.WriteLine("How Many Would you like?");
            int userQuantityOne = int.Parse(Console.ReadLine());

            
           
            return $"You have Ordered {userQuantityOne} {firstItem}";

                      
            
        }

    }
}
