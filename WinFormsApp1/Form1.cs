using System.Windows.Forms;

namespace WinFormsApp1 {

    public partial class FlowerCityForm : Form
    {

        public FlowerCityForm()
        {

            InitializeComponent();

        }

        private void FlowerCityForm_Load(object sender, EventArgs e)
        {

            List<Product> products = new List<Product>() {

                new Product("Квіти у зрізі", 1000),
                new Product("Кімнатні рослини", 700),
                new Product("Сухоцвіти", 600),
                new Product("Готова композиція", 1500),
                new Product("Ґрунт", 50),
                new Product("Стрічка", 30),
                new Product("Кошики", 100),
                new Product("Листя", 200),
                new Product("Упаковка", 50),
                new Product("Листівка", 40),
                new Product("М'яка іграшка", 400),
                new Product("Food-букет", 2000),
                new Product("Візитка", 0)

            };

            List<Image> images = new List<Image>
            {
                Properties.Resources.tovar1,
                Properties.Resources.tovar2,
                Properties.Resources.tovar3,
                Properties.Resources.tovar4,
                Properties.Resources.tovar5,
                Properties.Resources.tovar6,
                Properties.Resources.tovar7,
                Properties.Resources.tovar8,
                Properties.Resources.tovar9,
                Properties.Resources.tovar10,
                Properties.Resources.tovar11,
                Properties.Resources.tovar12,
                Properties.Resources.tovar13
            };

            List<PictureBox> pictureBoxes = new List<PictureBox>();
            pictureBoxes.AddRange(new PictureBox[]
            {
                pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox6, pictureBox7,
                pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13

            });
            
            foreach (var product in products)
            {

                //назва_обʼєкту_форми.власт.дія(параметр)
                listBoxProducts.Items.Add(product);
                

            }
            List<Label> labelsProducts = new List<Label>();

           
            labelsProducts.AddRange(new Label[]
            {
                label1, label2, label3, label4, label5, label6, label7, label8, label11, label12,
                label13, label14, label15, label16, label17, label18, label19, label20, label21,
                label22, label23, label24, label25, label26
            });
            int index = 0;
            for(int i = 0; i < labelsProducts.Count; index++)
            {
                labelsProducts[i].Text = products[index].Name;
                i++;
                labelsProducts[i].Text = products[index].Price.ToString();
                i++;
                pictureBoxes[index].Image = images[index];

                pictureBoxes[index].SizeMode = PictureBoxSizeMode.Zoom;
                
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
