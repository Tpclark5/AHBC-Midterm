using System;
using System.Collections.Generic;
using System.Text;

namespace GrandCircusMarket
{
    public class RunMenuApp
    {
      public void GetPaymentType()
        {
            Console.WriteLine("How would you like to pay? Please select one of the following payment types:");
            Console.WriteLine("[1] Cash");
            Console.WriteLine("[2] Credit or Debit Card");
            Console.WriteLine("[3] Check");
            var userSelectedPaymentType = int.Parse(Console.ReadLine());

            if (userSelectedPaymentType == 1)
            {
                var getsubtotal = new ShoppingCart();
                getsubtotal.GetSubTotal();
                Console.WriteLine("Please enter the amount of cash tendered");
                var userInput = double.Parse(Console.ReadLine());
                var cashFromCustomer = new Cash();
                cashFromCustomer.Amount = userInput;
                Console.WriteLine($"You have given me ${cashFromCustomer.Amount}, your change is ${cashFromCustomer.Amount - getsubtotal.GetSubTotal()} ");
                
                
            } else if (userSelectedPaymentType == 2)
            {
                Console.WriteLine("What is the name on the card?");
                var userInput = Console.ReadLine();
                var nameOnCard = new CreditOrDebitCard();
                nameOnCard.Name = userInput;

                Console.WriteLine("Please enter the cardnumber:");
                var userInput2 = double.Parse(Console.ReadLine());
                var cardNumber = new CreditOrDebitCard();
                cardNumber.CardNumber = userInput2;

                Console.WriteLine("Please enter the expiration date of the card:");
                var userInput3 = Console.ReadLine();
                var expirationDate = new CreditOrDebitCard();
                expirationDate.ExpirationDate = userInput3;

                Console.WriteLine("Please enter the CVV for then card:");
                var userInput4 = double.Parse(Console.ReadLine());
                var cardCVV = new CreditOrDebitCard();
                cardCVV.CVV = userInput4;

                Console.Write($" Your card information is as follows " +
                    $"Name: {nameOnCard.Name} " +
                    $"CardNumber: {cardNumber.CardNumber} " +
                    $"Card Expiration Date: {expirationDate.ExpirationDate} " +
                    $"Card CVV: {cardCVV.CVV} " +
                    $"Thank you, your transaction is complete");

            } else
            {
                Console.WriteLine("What is the name on the check?");
                var userInput = Console.ReadLine();
                var accountHolderName = new Check();
                accountHolderName.AccountHolderName = userInput;

                Console.WriteLine("Please enter the check number: ");
                var userInput2 = double.Parse(Console.ReadLine());
                var checknumber = new Check();
                checknumber.CheckNumber = userInput2;

                Console.WriteLine("Please enter the routing number for the bank: ");
                var userInput3 = double.Parse(Console.ReadLine());
                var routingNumber = new Check();
                routingNumber.RoutingNumber = userInput3;

                Console.WriteLine("Please enter the account number: ");
                var userInput4 = double.Parse(Console.ReadLine());
                var accountNumber = new Check();
                accountNumber.AccountNumber = userInput4;
                Console.WriteLine($"Your check information is as follows:" +
                    $"You have entered your name as {userInput} " +
                    $"The check number you wish to use is {userInput2} " +
                    $"The Bank Routing Number is {userInput3} " +
                    $"The Account Number is {userInput4} " +
                    $"Thank you, your transaction is complete");
            }
        }

    }
}
