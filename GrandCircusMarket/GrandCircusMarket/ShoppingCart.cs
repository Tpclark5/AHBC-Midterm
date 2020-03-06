using System;
using System.Collections.Generic;
using System.Text;

namespace GrandCircusMarket
{
    public class ShoppingCart
     {
        public List<MenuItems> Items { get; set; }
        public ShoppingCart()
        {
            Items = new List<MenuItems>();
        }
        public void AddItem(double itemName)
        {
            var newItem = new MenuItems(itemName);
            if (Items.Contains(newItem))
            {
                foreach (MenuItems item in Items)
                {
                    if (item.Equals(newItem))
                    {
                        item.Quantity++;
                    }
                } 
            }
            else
            {
                newItem.Quantity = 1;
                Items.Add(newItem);
            }
        }

        public double GetSubTotal()
        {
            double subTotal = 0;
            foreach (var item in Items)
                subTotal += item.SubTotal;

            return subTotal;
        }
    }
}
