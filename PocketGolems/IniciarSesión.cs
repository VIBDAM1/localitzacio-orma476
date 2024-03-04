using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace PocketGolems
{
    public partial class IniciarSesión : Form
    {
        public IniciarSesión()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Lucha anar = new Lucha();

            anar.Show();

            this.Hide();

        }

        private void buttonspanish_Click(object sender, EventArgs e)
        {

            Thread.CurrentThread.CurrentUICulture = CultureInfo.CurrentCulture;
            //Recarregar el formulari
            this.Hide();
            IniciarSesión f1 = new IniciarSesión();
            f1.Show();

        }

        private void buttonmorocco_Click(object sender, EventArgs e)
        {

            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ar-MA");
            //Recarregar el formulari
            this.Hide();
            IniciarSesión f1 = new IniciarSesión();
            f1.Show();

        }

        private void buttonchinese_Click(object sender, EventArgs e)
        {

            Thread.CurrentThread.CurrentUICulture = new CultureInfo("zh-Hans");
            //Recarregar el formulari
            this.Hide();
            IniciarSesión f1 = new IniciarSesión();
            f1.Show();

        }
    }
}
