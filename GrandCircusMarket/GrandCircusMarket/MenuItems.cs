using System;
using System.Collections.Generic;
using System.Text;

namespace GrandCircusMarket
{
    public class MenuItems
    {
        public double ItemName { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }
        public double SubTotal { get; set; }


        public MenuItems(double itemName)
        {
            ItemName = itemName;

            switch (itemName)
            {
                case 1:
                    this.Price = 3;
                    break;
                case 2:
                    this.Price = 6;
                    break;
                case 3:
                    this.Price = 5;
                    break;
                case 4:
                    this.Price = 4;
                    break;
                case 5:
                    this.Price = 2;
                    break;
                case 6:
                    this.Price = 2;
                    break;
                case 7:
                    this.Price = 5;
                    break;
                case 8:
                    this.Price = 4;
                    break;
                case 9:
                    this.Price = 1;
                    break;
                case 10:
                    this.Price = 3;
                    break;
                case 11:
                    this.Price = 2;
                    break;
                case 12:
                    this.Price = 6;
                    break;
                default:
                    Console.WriteLine("Invalid Entry, Please select an item from the menu");
                    break;

            }
        }

    }
}
