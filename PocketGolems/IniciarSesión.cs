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

            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
            //Recarregar el formulari
            this.Hide();
            IniciarSesión f1 = new IniciarSesión();
            f1.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //obrir manualment arxiu d'ajuda
            Help.ShowHelp(this, helpProvider1.HelpNamespace);
        }

        private void IniciarSesión_Load(object sender, EventArgs e)
        {
            // Defineix el text de la ajuda contextual per a cada control
            toolTip1.SetToolTip(this.button2, "Botó que serveix per saltar-te aquesta finestra (temporalment)");
            toolTip1.SetToolTip(this.button3, "Botó d'ajuda, que obra la pàgina web on està el manual d'ajuda.");
            toolTip1.SetToolTip(this.buttonspanish, "Espanyol");
            toolTip1.SetToolTip(this.buttonmorocco, "Àrab");
            toolTip1.SetToolTip(this.buttonchinese, "Chines");
            toolTip1.SetToolTip(this.textBox1, "Casella on s'introdueix el nom d'usuari");
            toolTip1.SetToolTip(this.textBox2, "Casella on s'introdueix la contrasenya del usuari");
            toolTip1.SetToolTip(this.textBox3, "Casella on s'introdueix el email del usuari");
           


        }
    }
}
