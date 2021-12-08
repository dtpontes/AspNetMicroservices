using System.Collections.Generic;

namespace Basket.API.Entities
{
    public class ShoppingCart
    {
        public ShoppingCart()
        {
            
        }

        public ShoppingCart(string userName)
        {
            UserName = userName;
        }

        public string UserName { get; set; }

        public List<ShoppingCartItem> Items { get; set; }

        public decimal TotalPrice 
        {
            get
            {
                if (Items == null)
                    Items = new List<ShoppingCartItem>();
                decimal totalPrice = 0;
                foreach(var item in Items)
                {
                    totalPrice += item.Price * item.Quantity;
                }
                return totalPrice;
            }

        }
    }
}
