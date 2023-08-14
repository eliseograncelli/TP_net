using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdministradorDeEmpleados.DAL;
using AdministradorDeEmpleados.BLL;


namespace AdministradorDeEmpleados.PL
{
    public partial class frmEmpleados : Form
    {
        EmpleadoDAL oEmpleadoDAL;
        public frmEmpleados()
        {
            oEmpleadoDAL = new EmpleadoDAL();
            InitializeComponent();
            dgvEmpleados.DataSource = oEmpleadoDAL.MostrarEmpleados().Tables[0];
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            EmpleadosBLL nuevoEmpleado = RecuperarInformacion();
            oEmpleadoDAL.Agregar(nuevoEmpleado);
            dgvEmpleados.DataSource = oEmpleadoDAL.MostrarEmpleados().Tables[0];
        }

        private EmpleadosBLL RecuperarInformacion()
        {
            EmpleadosBLL oEmpleado = new EmpleadosBLL();
            oEmpleado.nombre = txtNombre.Text;
            oEmpleado.email = txtEmail.Text;
            oEmpleado.password = txtPass.Text;
            oEmpleado.tipo = "Cliente";
            oEmpleado.setId();
            return oEmpleado;
        }
        private EmpleadosBLL RecuperarInformacionBM()
        {
            EmpleadosBLL oEmpleado = new EmpleadosBLL();
            oEmpleado.nombre = txtNombre.Text;
            oEmpleado.email = txtEmail.Text;
            oEmpleado.password = txtPass.Text;
            oEmpleado.tipo = "Cliente";
            oEmpleado.id = int.Parse(txtId.Text);
            return oEmpleado;
        }

        private void Seleccionar(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indice = e.RowIndex;
            txtNombre.Text = dgvEmpleados.Rows[indice].Cells[1].Value.ToString();
            txtEmail.Text = dgvEmpleados.Rows[indice].Cells[2].Value.ToString();
            txtPass.Text = dgvEmpleados.Rows[indice].Cells[4].Value.ToString();
            txtId.Text = dgvEmpleados.Rows[indice].Cells[0].Value.ToString();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            oEmpleadoDAL.Eliminar(RecuperarInformacionBM());
            dgvEmpleados.DataSource = oEmpleadoDAL.MostrarEmpleados().Tables[0];
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            oEmpleadoDAL.Modificar(RecuperarInformacionBM());
            dgvEmpleados.DataSource = oEmpleadoDAL.MostrarEmpleados().Tables[0];
        }
    }
}
