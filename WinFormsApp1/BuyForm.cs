using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class BuyForm : Form
    {
    
        private FullCart fullCartFinish;
        public BuyForm(FullCart cart)
        {
            InitializeComponent();
            fullCartFinish = cart;
            RefreshCart();
        }

        private void RefreshCart()
        {
            listBoxCart.Items.Clear();
            foreach (var item in fullCartFinish.CartObjects)
            {
                listBoxCart.Items.Add(item);
            }
            labelsum.Text = fullCartFinish.GetTotalPrice().ToString();

        }




        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void totalPrice_Click(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            fullCartFinish.ClearCart();
            RefreshCart();
        }

        private void deleteTovarButton_Click(object sender, EventArgs e)
        {
            if (listBoxCart.SelectedItem is CartItem selectedItem)
            {
                fullCartFinish.RemoveObjectsCart(selectedItem);
                RefreshCart();
            }
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            if (listBoxCart.SelectedItem is CartItem plusItem)
            {
                fullCartFinish.AddObjectsCart(plusItem.Product);
                RefreshCart();
            }
        }

        private void minusButton_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            if(fullCartFinish.CartObjects.Count == 0)
            {
                MessageBox.Show($"Кошик порожній");
                return;
            }
            MessageBox.Show($"Сума замовлення - {fullCartFinish.GetTotalPrice()}");
            fullCartFinish.ClearCart();
            RefreshCart();
        }
    }

}
