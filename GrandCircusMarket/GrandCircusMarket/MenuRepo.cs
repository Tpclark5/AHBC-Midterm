using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrandCircusMarket
{
    public class MenuRepo
    { 
        public double selectMenuItem()
        {
            int priceOfUserSelection = 0;
            GetUserOrder();
            GetUserQuantity();
          
            if (Enum.TryParse<ItemOptions>(GetUserOrder(), out ItemOptions itemoptions))
            {
                switch (itemoptions)
                {
                    case ItemOptions.Chicken:
                        priceOfUserSelection = 3 * GetUserQuantity();
                        break;
                    case ItemOptions.Beef:
                        priceOfUserSelection = 6 * GetUserQuantity();
                       break;
                    case ItemOptions.Fish:
                        priceOfUserSelection = 5 * GetUserQuantity();
                         break;
                    case ItemOptions.Pork:
                        priceOfUserSelection = 4 * GetUserQuantity();
                        break;
                    case ItemOptions.Apples:
                        priceOfUserSelection = 2 * GetUserQuantity();
                        break;
                    case ItemOptions.Oranges:
                        priceOfUserSelection = 2 * GetUserQuantity();
                        break;
                    case ItemOptions.Kale:
                        priceOfUserSelection = 5 * GetUserQuantity();
                        break;
                    case ItemOptions.Spinach:
                        priceOfUserSelection = 4 * GetUserQuantity();
                        break;
                    case ItemOptions.Water:
                        priceOfUserSelection = 1 * GetUserQuantity();
                        break;
                    case ItemOptions.Juice:
                        priceOfUserSelection = 3 * GetUserQuantity();
                       break;
                    case ItemOptions.Coffee:
                        priceOfUserSelection = 2 * GetUserQuantity();
                        break;
                    case ItemOptions.Beer:
                        priceOfUserSelection = 6 * GetUserQuantity();
                        break;
                    default:
                        break;
                }
                Console.WriteLine($"Your subtotal is ${priceOfUserSelection}");
            }
            RedisplayMenu();
           
            return priceOfUserSelection;

        }

        public void RedisplayMenu()
        {
            bool userWantsMoreFood = true;
            GetUserAnswer();
            while (userWantsMoreFood)
            {
                if (GetUserAnswer() == "y" || GetUserAnswer() == "Y")
                {
                    var menu = new FileIO();
                    menu.CreateDoc();
                    selectMenuItem();
                }
                else
                {
                    userWantsMoreFood = false;
                }
              
            }
            Console.WriteLine("Thank you for your order!");
        }

        public string GetUserAnswer()
        {
            
            Console.WriteLine("Would you like to see the menu again? [y/n]");
            var userInput = Console.ReadLine();
            return userInput;

        }
        
        public string GetUserOrder()
        {
            
            Console.WriteLine("What would you like to order? Please select a number from the menu");
            var userInput = Console.ReadLine();
            return userInput;

        }

        public int GetUserQuantity()
        {
            
            Console.WriteLine("How Many Would you like?");
            int userQuantity = int.Parse(Console.ReadLine());
            return userQuantity;
        }

    } 

}
