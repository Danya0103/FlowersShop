using System.Windows.Forms;

namespace WinFormsApp1 {

    public partial class FlowerCityForm : Form
    {

        public FlowerCityForm()
        {

            InitializeComponent();

        }

        public FullCart fullCart = new FullCart();

        private void Panel_Click(object sender, EventArgs e)
        {
            if (sender is Panel panel && panel.Tag is Product product)
            {
                fullCart.AddObjectsCart(product);
                listBoxProducts.Items.Add(product);
                MessageBox.Show($"{product.Name} - додано в кошик");

            }
        }

        private void FlowerCityForm_Load(object sender, EventArgs e)
        {

            List<Product> products = new List<Product>() {

                new Product("Квіти у зрізі", 1000),
                new Product("Кімнатні рослини", 700),
                new Product("Сухоцвіти", 600),
                new Product("Готова композиція", 1500),
                new Product("Ґрунт", 50),
                new Product("Окрема візитка", 0),
                new Product("Кошики", 100),
                new Product("Листя", 200),
                new Product("Упаковка", 50),
                new Product("Листівка", 40),
                new Product("М'яка іграшка", 400),
                new Product("Food-букет", 2000),
                new Product("Візитка", 0)

            };

            panelTovar1.Tag = products[0];
            panelTovar2.Tag = products[1];
            panelTovar3.Tag = products[2];
            panelTovar4.Tag = products[3];
            panelTovar5.Tag = products[4];
            panelTovar6.Tag = products[5];
            panelTovar7.Tag = products[6];
            panelTovar8.Tag = products[7];
            panelTovar9.Tag = products[8];
            panelTovar10.Tag = products[9];
            panelTovar11.Tag = products[10];
            panelTovar12.Tag = products[11];


            List<Image> images = new List<Image>
            {
                Properties.Resources.tovar1,
                Properties.Resources.tovar2,
                Properties.Resources.tovar3,
                Properties.Resources.tovar4,
                Properties.Resources.tovar5,
                Properties.Resources.tovar6,
                Properties.Resources.tovar11,
                Properties.Resources.tovar8,
                Properties.Resources.tovar9,
                Properties.Resources.tovar10,
                Properties.Resources.tovar7,
                Properties.Resources.tovar12,
                Properties.Resources.tovar13
            };

            List<PictureBox> pictureBoxes = new List<PictureBox>();
            pictureBoxes.AddRange(new PictureBox[]
            {
                pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox7,
                pictureBox12, pictureBox9, pictureBox10, pictureBox11, pictureBox8, pictureBox6

            });

            foreach (var product in products)
            {

                //назва_обʼєкту_форми.власт.дія(параметр)
                //listBoxProducts.Items.Add(product);


            }
            List<Label> labelsProducts = new List<Label>();


            labelsProducts.AddRange(new Label[]
            {
                label1, label2, label3, label4, label5, label6, label7, label8, label9, label10,
                label11, label12, label13, label14, label15, label16, label17, label18, label19, label20, label21,
                label22, label23, label24
            });
            int index = 0;
            for (int i = 0; i < labelsProducts.Count; index++)
            {
                labelsProducts[i].Text = products[index].Name;
                i++;
                labelsProducts[i].Text = products[index].Price.ToString();
                i++;
                pictureBoxes[index].Image = images[index];

                pictureBoxes[index].SizeMode = PictureBoxSizeMode.Zoom;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuyForm buyForm = new BuyForm(fullCart);
            buyForm.ShowDialog();
        }
    }
}
