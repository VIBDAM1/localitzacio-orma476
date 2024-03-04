namespace PocketGolems
{
    partial class Reglas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reglas));
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            menu_lucha = new Panel();
            button8 = new Button();
            button6 = new Button();
            button5 = new Button();
            textBox5 = new TextBox();
            button4 = new Button();
            pictureBox6 = new PictureBox();
            button3 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            menu_lucha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 65, 77);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1143, 193);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(65, 86, 103);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(201, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(930, 166);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Mono", 51.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 149, 135);
            label1.Location = new Point(176, 31);
            label1.Name = "label1";
            label1.Size = new Size(559, 91);
            label1.TabIndex = 2;
            label1.Text = "POCKET GOLEMS";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(174, 166);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.golems___copia;
            button1.Location = new Point(524, 696);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(111, 57);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(156, 210);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(846, 472);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // menu_lucha
            // 
            menu_lucha.BackColor = Color.FromArgb(57, 92, 106);
            menu_lucha.BorderStyle = BorderStyle.FixedSingle;
            menu_lucha.Controls.Add(button8);
            menu_lucha.Controls.Add(button6);
            menu_lucha.Controls.Add(button5);
            menu_lucha.Controls.Add(textBox5);
            menu_lucha.Controls.Add(button4);
            menu_lucha.Controls.Add(pictureBox6);
            menu_lucha.Controls.Add(button3);
            menu_lucha.Location = new Point(0, 560);
            menu_lucha.Name = "menu_lucha";
            menu_lucha.Size = new Size(1143, 193);
            menu_lucha.TabIndex = 24;
            menu_lucha.Visible = false;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(158, 158, 158);
            button8.FlatStyle = FlatStyle.Popup;
            button8.Font = new Font("Cascadia Code", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.Location = new Point(930, 57);
            button8.Name = "button8";
            button8.Size = new Size(185, 86);
            button8.TabIndex = 11;
            button8.Text = "A LUCHAR!";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(255, 152, 0);
            button6.FlatStyle = FlatStyle.Popup;
            button6.Font = new Font("Cascadia Code", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(723, 103);
            button6.Name = "button6";
            button6.Size = new Size(178, 49);
            button6.TabIndex = 9;
            button6.Text = "REGLAS";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(158, 158, 158);
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Cascadia Code", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(723, 48);
            button5.Name = "button5";
            button5.Size = new Size(178, 49);
            button5.TabIndex = 8;
            button5.Text = "GOLEMS";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(57, 92, 106);
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Arial Black", 30F, FontStyle.Bold);
            textBox5.Location = new Point(200, 57);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(216, 57);
            textBox5.TabIndex = 7;
            textBox5.Text = "USUARIO";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(35, 149);
            button4.Name = "button4";
            button4.Size = new Size(176, 35);
            button4.TabIndex = 6;
            button4.Text = "Modificar imagen";
            button4.UseVisualStyleBackColor = true;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(55, 21);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(130, 122);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 5;
            pictureBox6.TabStop = false;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderColor = Color.White;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = Properties.Resources.golems___copia;
            button3.Location = new Point(516, 696);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(111, 57);
            button3.TabIndex = 4;
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = Properties.Resources.golems___copia;
            button2.Location = new Point(524, 506);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(111, 57);
            button2.TabIndex = 25;
            button2.UseVisualStyleBackColor = false;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // Reglas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(82, 120, 137);
            ClientSize = new Size(1143, 750);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(menu_lucha);
            Controls.Add(button2);
            Controls.Add(pictureBox2);
            Name = "Reglas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reglas";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            menu_lucha.ResumeLayout(false);
            menu_lucha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button button1;
        private PictureBox pictureBox2;
        private Panel menu_lucha;
        private Button button8;
        private Button button6;
        private Button button5;
        private TextBox textBox5;
        private Button button4;
        private PictureBox pictureBox6;
        private Button button3;
        private Button button2;
    }
}