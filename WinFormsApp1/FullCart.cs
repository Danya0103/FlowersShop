using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1 {

    public class FullCart {

        public List<CartItem> CartObjects = new List<CartItem>();

        // TODO
        public void AddObjectsCart(Product product) {

            // event перевірки 
            // var - універсальний тип даних (variable) - змінна

            try
            {
                var existing = CartObjects.FirstOrDefault(i => i.Product.Name == product.Name);  // 1, null     
                if(existing != null)
                {
                    existing.Quantity++;
                }
               
            }
            catch{
                CartObjects.Add(new CartItem(product, 1));
                //new Product("Візитка", 0)
                CartObjects.Add(new CartItem((new Product("Візитка", 0)) , 1));
            }
            // list<string> list, list.add(251);
        }

        public void RemoveObjectsCart(CartItem cartItem) {

            CartObjects.Remove(cartItem);

        }
        // ДецИмал
        public decimal GetTotalPrice()
        {
            // CartItem(Product(string, decimal), int)
            return (CartObjects.Sum(i => i.Total()));
        }

        public void ClearCart()
        {
            CartObjects.Clear();
        }
    }
}
