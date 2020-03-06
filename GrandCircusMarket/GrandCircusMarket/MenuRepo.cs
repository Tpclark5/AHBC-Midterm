using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrandCircusMarket
{
    public class MenuRepo
    {
        public double SelectMenuItem()
        {
            var getsubtotal = new ShoppingCart();
            getsubtotal.GetSubTotal();
            Console.WriteLine($"Your subtotal is ${getsubtotal.GetSubTotal()}");
            
            return getsubtotal.GetSubTotal();
        }

        public void RedisplayMenu()
        {
            bool userWantsMoreFood = true;

            while (userWantsMoreFood)
            {
                GetUserOrder();
                Console.WriteLine("How Many Would you like?");
                double userinput = double.Parse(Console.ReadLine());
                SelectMenuItem();
                if (GetUserAnswer().Equals("y", StringComparison.OrdinalIgnoreCase))
                {
                    var menu = new FileIO();
                    menu.CreateDoc(); 
                }
                else
                {
                    userWantsMoreFood = false;
                    Console.WriteLine("Thank you for your order!");
                } 

            }  
        }

        public string GetUserAnswer()
        {
            Console.WriteLine("Would you like to see the menu again? [y/n]");
            var userInput = Console.ReadLine();
            return userInput;
        }

        public MenuItems GetUserOrder()
        {
            Console.WriteLine("What would you like to order? Please select a number from the menu");
            var userInput = double.Parse(Console.ReadLine());
            var getUserInput = new MenuItems(userInput);
            var addItem = new ShoppingCart();
            addItem.AddItem(userInput);
            return getUserInput;
        }
    }
}
