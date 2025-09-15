using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class CartItem
    {
        // name, price, Product, ToString

        // Product(object), quantity, CartItem, ToString, Total(method)

        public Product Product { get; set; }
        public int Quantity { get; set; }

        // properties - властивості

        public CartItem(Product product, int quantity) {

            Product = product;
            Quantity = quantity;

        }

        // class Maket {name, price, ToString)

        // class Zavod { 

        /*
         * value: Maket maketKolesa
         * properties(get/set): Maket Maket
         * 
         * 
         * public Zavod(Maket maket) => Maket = maket
         */
        public decimal Total()
        {
            return (Quantity * Product.Price);
        }

        // eventArg TODO
        public decimal TotalPrice => Product.Price * Quantity;

        public override string ToString() {

            return ($"{Product.Name} x {Quantity} = {TotalPrice} ₴");

        }

    }
}
