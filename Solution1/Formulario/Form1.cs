namespace Formulario
{
    using Entidades;
    public partial class ABMUs : Form
    {
        public ABMUs()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Alta_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
        }

        private void Alta_MouseClick(object sender, MouseEventArgs e)
        {
            Form abrir = new FormAlta();
        }
    }
}