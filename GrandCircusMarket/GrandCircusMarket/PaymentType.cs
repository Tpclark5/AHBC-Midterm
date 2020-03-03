using System;
using System.Collections.Generic;
using System.Text;

namespace GrandCircusMarket
{
    public abstract class PaymentType
    {

    }

    public class Cash: PaymentType
    {
        public double Amount { get; set; }

    }

    public class CreditOrDebitCard : PaymentType
    {
        public string Name { get; set; }
        public double CardNumber { get; set; }
        public double CVV { get; set; }
        public string ExpirationDate { get; set; }
    }

    public class Check: PaymentType
    {
        public string AccountHolderName { get; set; }
        public double CheckNumber { get; set; }
        public double RoutingNumber { get; set; }
        public double AccountNumber { get; set; }
    }
}
