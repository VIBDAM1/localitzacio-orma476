namespace PocketGolems
{
    public partial class Golems : Form
    {
        public Golems()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            menu_lucha.Visible = false;
            button1.Visible = true;
            button2.Visible = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Ya estas en la ventana de golems.", "Error",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button6_Click(object sender, EventArgs e)
        {

            Reglas regla = new Reglas();

            regla.Show();

            this.Close();

        }

        private void button8_Click(object sender, EventArgs e)
        {

            Lucha anar = new Lucha();

            anar.Show();

            this.Close();

        }
    }
}
