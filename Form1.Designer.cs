namespace dashboard
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(253, 351);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Wheat;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(685, 67);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 128);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(252, 67);
            panel2.Name = "panel2";
            panel2.Size = new Size(433, 351);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(252, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(77, 67);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(347, 21);
            label1.Name = "label1";
            label1.Size = new Size(141, 26);
            label1.TabIndex = 1;
            label1.Text = "Adicionar Livro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 34);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 0;
            label2.Text = "Nome do Livro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 76);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 1;
            label3.Text = "Autor do Livro";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 122);
            label4.Name = "label4";
            label4.Size = new Size(108, 15);
            label4.TabIndex = 2;
            label4.Text = "Data de Publicação";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 172);
            label5.Name = "label5";
            label5.Size = new Size(139, 15);
            label5.TabIndex = 3;
            label5.Text = "Data de Compra do Livro";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 219);
            label6.Name = "label6";
            label6.Size = new Size(79, 15);
            label6.TabIndex = 4;
            label6.Text = "Valor do Livro";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(36, 263);
            label7.Name = "label7";
            label7.Size = new Size(119, 15);
            label7.TabIndex = 5;
            label7.Text = "Quantidade de Livros";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(205, 166);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(205, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(205, 119);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 23);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(205, 73);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 23);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(205, 260);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(200, 23);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(205, 219);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(200, 23);
            textBox5.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(205, 311);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(330, 311);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 13;
            button2.Text = "Salvar";
            button2.UseVisualStyleBackColor = true;
            // 
            // AddBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 418);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "AddBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddBook";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox2;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button2;
        private Button button1;
    }
}