using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrandCircusMarket
{
    public class MenuRepo
    {
        ShoppingCart shoppingCart = new ShoppingCart();
       

        public void RedisplayMenu()
        {
            
            bool userWantsMoreFood = true;

            while (userWantsMoreFood)
            {
                AddUserItems();
                GetUserQuantity();
                var subtotal = shoppingCart.GetSubTotal();            
                
                if (GetUserAnswer().Equals("y", StringComparison.OrdinalIgnoreCase))
                {
                    var menu = new FileIO();
                    menu.CreateDoc(); 
                }
                else
                {
                    userWantsMoreFood = false;
                    Console.WriteLine("Thank you for your order!");
                    Console.WriteLine($"Your subtotal is {subtotal}");
                }
            }  
        }

        private string GetUserAnswer()
        {
            Console.WriteLine("Would you like to see the menu again? [y/n]");
            var userInput = Console.ReadLine();
            return userInput;
        }

        private double GetUserOrder()
        {
            Console.WriteLine("What would you like to order? Please select a number from the menu");
            var userInput = double.Parse(Console.ReadLine());
            return userInput;
        }

        private void AddUserItems()
        {
            
            shoppingCart.AddItem(GetUserOrder());
        }

        private double GetUserQuantity()
        {
            Console.WriteLine("How Many Would you like?");
            double userInput = double.Parse(Console.ReadLine());
            return userInput;
        }

    }
}
