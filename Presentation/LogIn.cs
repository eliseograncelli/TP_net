namespace Presentation
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            frmInicioSesion frm = new frmInicioSesion();
            frm.Show();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            frmRegistrarse frm = new frmRegistrarse();
            frm.Show();
        }
    }
}