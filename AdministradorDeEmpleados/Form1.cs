using AdministradorDeEmpleados.BLL;
using AdministradorDeEmpleados.PL;
using System.Data;
using AdministradorDeEmpleados.DAL;

namespace AdministradorDeEmpleados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        { /*
            MessageBox.Show("HOLA");

            DataSet emp;
            EmpleadoDAL eDAL = new EmpleadoDAL(); ;
            emp = eDAL.BuscarEmp(txtEmail.Text, txtPas.Text);
            if (emp == null)
            {
                MessageBox.Show("USUARIO NO ENCONTRADO");
            }
            else
            { */
                /* if (emp.Tipo = "Cliente")
                 {
                     // ACCIONES PARA UN CLIENTE
                 }
                 else
                 {
                     MessageBox.Show("INICIO COMO ADMINISTRADOR");
                     frmEmpleados formEmp = new frmEmpleados();
                     formEmp.Show();
                 } */
           /*     MessageBox.Show("Usuario encontrado");
            }
            */
        }     // NO ANDA

        private void btnIniciarSesion_Click_1(object sender, EventArgs e)
        {
            DataSet emp;
            EmpleadoDAL eDAL = new EmpleadoDAL(); 
           // EmpleadosBLL empBLL = new EmpleadosBLL();
            emp = eDAL.BuscarEmp(txtEmail.Text, txtPas.Text);
            if (emp == null)
            {
                MessageBox.Show("USUARIO NO ENCONTRADO");
            }
            else
            {
                /* if (emp.Tipo = "Cliente")
                 {
                     // ACCIONES PARA UN CLIENTE
                 }
                 else
                 {
                     MessageBox.Show("INICIO COMO ADMINISTRADOR");
                     frmEmpleados formEmp = new frmEmpleados();
                     formEmp.Show();
                 } */

                MessageBox.Show("Usuario encontrado");
                
            }
        }
    }
}