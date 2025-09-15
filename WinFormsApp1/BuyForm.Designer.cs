namespace WinFormsApp1
{
    partial class BuyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxCart = new ListBox();
            plusButton = new Button();
            minusButton = new Button();
            finishButton = new Button();
            labelBasket = new Label();
            labalTotalPrice = new Label();
            labelsum = new Label();
            deleteTovarButton = new Button();
            clearButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // listBoxCart
            // 
            listBoxCart.FormattingEnabled = true;
            listBoxCart.Location = new Point(317, 81);
            listBoxCart.Name = "listBoxCart";
            listBoxCart.Size = new Size(150, 104);
            listBoxCart.TabIndex = 0;
            // 
            // plusButton
            // 
            plusButton.Location = new Point(273, 217);
            plusButton.Name = "plusButton";
            plusButton.Size = new Size(94, 29);
            plusButton.TabIndex = 1;
            plusButton.Text = "+";
            plusButton.UseVisualStyleBackColor = true;
            plusButton.Click += plusButton_Click;
            // 
            // minusButton
            // 
            minusButton.Location = new Point(411, 217);
            minusButton.Name = "minusButton";
            minusButton.Size = new Size(94, 29);
            minusButton.TabIndex = 2;
            minusButton.Text = "-";
            minusButton.UseVisualStyleBackColor = true;
            minusButton.Click += minusButton_Click;
            // 
            // finishButton
            // 
            finishButton.Location = new Point(668, 409);
            finishButton.Name = "finishButton";
            finishButton.Size = new Size(94, 29);
            finishButton.TabIndex = 3;
            finishButton.Text = "Сплатити";
            finishButton.UseVisualStyleBackColor = true;
            finishButton.Click += finishButton_Click;
            // 
            // labelBasket
            // 
            labelBasket.AutoSize = true;
            labelBasket.Location = new Point(358, 20);
            labelBasket.Name = "labelBasket";
            labelBasket.Size = new Size(63, 20);
            labelBasket.TabIndex = 4;
            labelBasket.Text = "КОШИК";
            // 
            // labalTotalPrice
            // 
            labalTotalPrice.AutoSize = true;
            labalTotalPrice.Location = new Point(473, 81);
            labalTotalPrice.Name = "labalTotalPrice";
            labalTotalPrice.Size = new Size(103, 20);
            labalTotalPrice.TabIndex = 5;
            labalTotalPrice.Text = "Ітогова ціна -";
            labalTotalPrice.Click += totalPrice_Click;
            // 
            // labelsum
            // 
            labelsum.AutoSize = true;
            labelsum.Location = new Point(572, 81);
            labelsum.Name = "labelsum";
            labelsum.Size = new Size(17, 20);
            labelsum.TabIndex = 6;
            labelsum.Text = "0";
            labelsum.Click += label3_Click;
            // 
            // deleteTovarButton
            // 
            deleteTovarButton.Location = new Point(411, 285);
            deleteTovarButton.Name = "deleteTovarButton";
            deleteTovarButton.Size = new Size(128, 29);
            deleteTovarButton.TabIndex = 7;
            deleteTovarButton.Text = "Видалити товар";
            deleteTovarButton.UseVisualStyleBackColor = true;
            deleteTovarButton.Click += deleteTovarButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(273, 285);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(94, 29);
            clearButton.TabIndex = 8;
            clearButton.Text = "Очистити кошик";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clear_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(690, 11);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(111, 29);
            exitButton.TabIndex = 9;
            exitButton.Text = "Повернутись";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // BuyForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(deleteTovarButton);
            Controls.Add(labelsum);
            Controls.Add(labalTotalPrice);
            Controls.Add(labelBasket);
            Controls.Add(finishButton);
            Controls.Add(minusButton);
            Controls.Add(plusButton);
            Controls.Add(listBoxCart);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BuyForm";
            Text = "BuyForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxCart;
        private Button plusButton;
        private Button minusButton;
        private Button finishButton;
        private Label labelBasket;
        private Label labalTotalPrice;
        private Label labelsum;
        private Button deleteTovarButton;
        private Button clearButton;
        private Button exitButton;
    }
}