using System;
using System.Collections.Generic;
using System.Text;

namespace GrandCircusMarket
{
    public class MenuItems
    {
        public string ItemName { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }
        public double SubTotal { get; set; }
        public string Description { get; set; }
        
        public MenuItems(string itemName)
        {
            ItemName = itemName;
           

            switch (itemName)
            {
                case "1":
                    this.Price = 3;
                    this.Description = "Chicken";
                    break;
                case "2":
                    this.Price = 6;
                    this.Description = "Beef";
                    break;
                case "3":
                    this.Price = 5;
                    this.Description = "Fish";
                    break;
                case "4":
                    this.Price = 4;
                    this.Description = "Pork";
                    break;
                case "5":
                    this.Price = 2;
                    this.Description = "Apples";
                    break;
                case "6":
                    this.Price = 2;
                    this.Description = "Oranges";
                    break;
                case "7":
                    this.Price = 5;
                    this.Description = "Kale";
                    break;
                case "8":
                    this.Price = 4;
                    this.Description = "Spinach";
                    break;
                case "9":
                    this.Price = 1;
                    this.Description = "Water";
                    break;
                case "10":
                    this.Price = 3;
                    this.Description = "Juice";
                    break;
                case "11":
                    this.Price = 2;
                    this.Description = "Coffee";
                    break;
                case "12":
                    this.Price = 6;
                    this.Description = "Beer";
                    break;
                default:
                    Console.WriteLine("Invalid Entry, Please select an item from the menu");
                    break;

            }
        }

    }
}
