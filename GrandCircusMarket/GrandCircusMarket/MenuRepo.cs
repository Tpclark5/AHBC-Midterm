using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrandCircusMarket
{
    public class MenuRepo
    {
        ShoppingCart shoppingCart = new ShoppingCart();
        List<double> userQuantity = new List<double>();
        List<double> subtotal = new List<double>();

        public void RedisplayMenu()
        {
            
            bool userWantsMoreFood = true;

            while (userWantsMoreFood)
            {
                
                price();
                Console.WriteLine($"Your subtotal is ${subtotal.Sum()}");

                if (GetUserAnswer().Equals("y", StringComparison.OrdinalIgnoreCase))
                {
                    var menu = new FileIO();
                    menu.CreateDoc(); 
                }
                else
                {
                    userWantsMoreFood = false;
                    Console.WriteLine("Thank you for your order!");
                    Console.WriteLine($"Your Grand Total is ${subtotal.Sum() + (subtotal.Sum() * .06)}");
                }
            }
            PaymentType();
        }

        private string GetUserAnswer()
        {
            Console.WriteLine("Would you like to see the menu again? [y/n]");
            var userInput = Console.ReadLine();
            return userInput;
        }

       

        private void AddUserItems()
        {
            ShoppingCart shoppingCart = new ShoppingCart();

        }

        public double GetUserQuantity()
        {
            Console.WriteLine("How Many Would you like?");
            double userInput = double.Parse(Console.ReadLine());
            userQuantity.Add(userInput);
            return userInput;
        }

        
            public double price()
            {
            double priceOfUserSelection = 0;
            Console.WriteLine("What would you like to order? Please select a number from the menu");
            var userInput = Console.ReadLine();
            shoppingCart.AddItem(userInput);

            if (Enum.TryParse<ItemOptions>(userInput, out ItemOptions itemoptions))
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
                subtotal.Add(priceOfUserSelection);
                }

                return priceOfUserSelection;

            }
        public void PaymentType()
        {
            string expirationDateEntered = "";
            double cardNumberEntered = 0;
            double CVVentered = 0;
            double checkNumberentered = 0;
            double accountNumberentered = 0;
            double routingnumberentered = 0;
            string nameoncardorcheckentered = "";
            double changeReturned = 0;
            double cashGiven = 0;
            string paymentTypeIs = "";
            Console.WriteLine("How would you like to pay? Please select one of the following payment types:");
            Console.WriteLine("[1] Cash");
            Console.WriteLine("[2] Credit or Debit Card");
            Console.WriteLine("[3] Check");
            var userSelectedPaymentType = int.Parse(Console.ReadLine());
            var userPaymentSelected = userSelectedPaymentType;
            if (userSelectedPaymentType == 1)
            {
                Console.WriteLine("You selected to pay by Cash");
                Console.WriteLine("Please enter the amount of cash tendered");
                var userInput = double.Parse(Console.ReadLine());
                var cashFromCustomer = new Cash();
                cashFromCustomer.Amount = userInput;
                Console.WriteLine($"You have given me ${cashFromCustomer.Amount}, your change is ${cashFromCustomer.Amount - subtotal.Sum() + (subtotal.Sum() * .06) } ");
                cashGiven = cashFromCustomer.Amount;
                changeReturned = cashFromCustomer.Amount - (subtotal.Sum() + (subtotal.Sum() * .06));
            }
            else if (userSelectedPaymentType == 2)
            {
                Console.WriteLine("You selected to pay by Debit or Credit card");
                Console.WriteLine("What is the name on the card?");
                var userInput = Console.ReadLine();
                var nameOnCard = new CreditOrDebitCard();
                nameOnCard.Name = userInput;
                nameoncardorcheckentered = nameOnCard.Name;

                Console.WriteLine("Please enter the cardnumber:");
                var userInput2 = double.Parse(Console.ReadLine());
                var cardNumber = new CreditOrDebitCard();
                cardNumber.CardNumber = userInput2;
                cardNumberEntered = cardNumber.CardNumber;

                Console.WriteLine("Please enter the expiration date of the card:");
                var userInput3 = Console.ReadLine();
                var expirationDate = new CreditOrDebitCard();
                expirationDate.ExpirationDate = userInput3;
                expirationDateEntered = expirationDate.ExpirationDate;

                Console.WriteLine("Please enter the CVV for then card:");
                var userInput4 = double.Parse(Console.ReadLine());
                var cardCVV = new CreditOrDebitCard();
                cardCVV.CVV = userInput4;
                CVVentered = cardCVV.CVV;

                Console.Write($" Your card information is as follows " +
                    $"Name: {nameOnCard.Name} " +
                    $"CardNumber: {cardNumber.CardNumber} " +
                    $"Card Expiration Date: {expirationDate.ExpirationDate} " +
                    $"Card CVV: {cardCVV.CVV} " +
                    $"Thank you, your transaction is complete");

            }
            else
            {
                Console.WriteLine("What is the name on the check?");
                var userInput = Console.ReadLine();
                var accountHolderName = new Check();
                accountHolderName.AccountHolderName = userInput;
                nameoncardorcheckentered = accountHolderName.AccountHolderName;

                Console.WriteLine("Please enter the check number: ");
                var userInput2 = double.Parse(Console.ReadLine());
                var checknumber = new Check();
                checknumber.CheckNumber = userInput2;
                checkNumberentered = checknumber.CheckNumber;

                Console.WriteLine("Please enter the routing number for the bank: ");
                var userInput3 = double.Parse(Console.ReadLine());
                var routingNumber = new Check();
                routingNumber.RoutingNumber = userInput3;
                routingnumberentered = routingNumber.RoutingNumber;

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

            if (userPaymentSelected == 1)
            {
                paymentTypeIs = "cash"; 
            } else if (userPaymentSelected == 2)
            {
                paymentTypeIs = "Credit or Debit Card";
            }
            else
            {
                paymentTypeIs = "Check";
            }
            Console.WriteLine("Thank You For Your Purchase, Here Is Your Receipt");
            Console.WriteLine($"You Ordered {MenuItems.GetProperties()}");
            Console.WriteLine($"Subtotal . . . . . {subtotal.Sum()}");
            Console.WriteLine($"Grand Total . . . . . {subtotal.Sum() + (subtotal.Sum() * .06)}");
            Console.WriteLine($"Payment Type . . . . . {paymentTypeIs}");
            if (userSelectedPaymentType == 1)
            {
                Console.WriteLine($" Amount Tendered . . . . ${cashGiven}");
                Console.WriteLine($" Change Returned . . . .${changeReturned}");
            } else if( userSelectedPaymentType == 2)
            {
                Console.WriteLine($" Your card information is as follows " +
                    $"Name: {nameoncardorcheckentered} " +
                    $"CardNumber: {cardNumberEntered} " +
                    $"Card Expiration Date: {expirationDateEntered} " +
                    $"Card CVV: {CVVentered} ");
            }
            else
            {
                Console.WriteLine($"Your check information is as follows:" +
                       $"You have entered your name as {nameoncardorcheckentered} " +
                       $"The check number you wish to use is {checkNumberentered} " +
                       $"The Bank Routing Number is {routingnumberentered} " +
                       $"The Account Number is {accountNumberentered} ");
                       
            }
            Console.WriteLine("Thank you, Please Come Again!");
        }

        
    
    }
}
