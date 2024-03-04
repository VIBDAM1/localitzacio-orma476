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
    public partial class Reglas : Form
    {
        public Reglas()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Golems golem = new Golems();

            golem.Show();

            this.Close();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ya estas en la ventana de reglas.", "Error",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button8_Click(object sender, EventArgs e)
        {

            Lucha anar = new Lucha();

            anar.Show();

            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            menu_lucha.Visible = true;
            button1.Visible = false;
            button2.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {

            menu_lucha.Visible = false;
            button1.Visible = true;
            button2.Visible = false;

        }
    }
}
