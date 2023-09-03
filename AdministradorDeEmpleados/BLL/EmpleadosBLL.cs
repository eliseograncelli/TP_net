using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministradorDeEmpleados.BLL
{
   class EmpleadosBLL
    {
        private int id { set; get; }
        private int dNI { set; get; }
        private string nombre { get; set; }
        private string email { get; set; }
        private string password { get; set; }
        private byte[] foto { get; set; }
        private string tipo { get; set; }
        private string estado { get; set; }


        static int ID = 0;
        public int Id { set; get; }
        public int DNI { set; get; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Password { get; set;}
        public byte[] Foto { get; set; }
        public string Tipo { get; set; }
        public string Estado { get; set; }
        public void setId()
        {
            this.Id = ++ID;
        }

        public EmpleadosBLL()
        {
            Tipo = "Cliente";
            Estado = "Inactivo";
        }
    }
}
