using System;
using System.Collections.Generic;
using System.Text;

namespace GrandCircusMarket
{
    public class RunMenuApp
    {
      public void RunApp()
        {
            Console.WriteLine("How would you like to pay? Please select one of the following payment types:");
            Console.WriteLine("[1] Cash");
            Console.WriteLine("[2] Credit or Debit Card");
            Console.WriteLine("[3] Check");
            var userSelectedPaymentType = int.Parse(Console.ReadLine());
            if (userSelectedPaymentType == 1)
            {
                Console.WriteLine("Please enter the amount of cash tendered");
                var userInput = double.Parse(Console.ReadLine());
                var cashFromCustomer = new Cash();
                cashFromCustomer.Amount = userInput;
                Console.WriteLine($"You have given me {cashFromCustomer}");
            }
        }

    }
}
