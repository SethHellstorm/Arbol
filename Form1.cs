namespace Arbol
{
    public partial class Inicio : Form
    {
        ABinario AB;
        public Inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AB = new ABinario(this);
            AB.Show();
            this.Hide();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
