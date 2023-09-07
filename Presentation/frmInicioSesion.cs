using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessEntities;
using BusinessLogic;

namespace Presentation
{
    public partial class frmInicioSesion : Form
    {
        public frmInicioSesion()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            UsuarioBL us = new UsuarioBL();
            UsuarioBE usu = us.Buscador(txtEmail.Text, txtPassword.Text);
            if (usu != null )
            {
                /*if(usu.Tipo == "Administrador")
                {
                    //Cosas de administrador
                } */
                if (usu.Email == "Admin" && usu.Password == "admin")
                {

                }
                else
                {

                }
            }
            
        }
    }
}
