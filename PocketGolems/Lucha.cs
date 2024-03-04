using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PocketGolems
{
    public partial class Lucha : Form
    {
        public Lucha()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            menu_lucha.Visible = true;
            button2.Visible = false;
            button7.Visible = true;

        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {



        }

        private void button7_Click(object sender, EventArgs e)
        {
            menu_lucha.Visible = false;
            button2.Visible = true;
            button7.Visible = false;

        }

        private void Lucha_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Golems golem = new Golems();

            golem.Show();

            this.Close();

        }

        private void button6_Click(object sender, EventArgs e)
        {

            Reglas regla = new Reglas();

            regla.Show();

            this.Close();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ya estas en la ventana de lucha.","Error",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);

           
           

        }
    }

}
