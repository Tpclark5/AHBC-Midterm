using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrandCircusMarket
{
    public class MenuRepo
    {
        public int selectMenuItem()
        {
            int priceOfUserSelection = 0;
            Console.WriteLine("What would you like to order? Please select a number from the menu");
            var userInput = Console.ReadLine();
            if (Enum.TryParse<ItemOptions>(userInput, out ItemOptions itemoptions))
            {
                switch (itemoptions)
                {
                    case ItemOptions.Chicken:
                        priceOfUserSelection = 3;
                        break;
                    case ItemOptions.Beef:
                        priceOfUserSelection = 6;
                        break;
                    case ItemOptions.Fish:
                        priceOfUserSelection = 5;
                        break;
                    case ItemOptions.Pork:
                        priceOfUserSelection = 4;
                        break;
                    case ItemOptions.Apples:
                        priceOfUserSelection = 2;
                        break;
                    case ItemOptions.Oranges:
                        priceOfUserSelection = 2;
                        break;
                    case ItemOptions.Kale:
                        priceOfUserSelection = 5;
                        break;
                    case ItemOptions.Spinach:
                        priceOfUserSelection = 4;
                        break;
                    case ItemOptions.Water:
                        priceOfUserSelection = 1;
                        break;
                    case ItemOptions.Juice:
                        priceOfUserSelection = 3;
                        break;
                    case ItemOptions.Coffee:
                        priceOfUserSelection = 2;
                        break;
                    case ItemOptions.Beer:
                        priceOfUserSelection = 6;
                        break;
                    default:
                        break;
                }
                
            }

            Console.WriteLine($"Your item will cost ${priceOfUserSelection}");

            Console.WriteLine("How Many Would you like?");
            int userQuantityOne = int.Parse(Console.ReadLine());
            var subtotal = priceOfUserSelection * userQuantityOne;
            Console.WriteLine($"Your subtotal is {subtotal}");
            RedisplayMenu();
            return subtotal;

        }

        public void RedisplayMenu()
        {
            bool userWantsMoreFood = true;
            Console.WriteLine( "Would you like to see the menu again? [y/n]");
            var userInput = Console.ReadLine();
            while (userWantsMoreFood)
            {
                if (userInput.Equals("y", StringComparison.OrdinalIgnoreCase))
                {
                    var menu = new FileIO();
                    menu.CreateDoc();
                    selectMenuItem();
                }
                else
                {
                    userWantsMoreFood = false;
                    Console.WriteLine("Thank you for your order!");
                }
              
            }
        }

        

    } 

}
