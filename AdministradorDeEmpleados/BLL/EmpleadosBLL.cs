using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministradorDeEmpleados.BLL
{
   class EmpleadosBLL
    {
        static int ID = 0;
        public int Id { set; get; }
        public int DNI { set; get; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Password { get; set;}
        public byte[] Foto { get; set; }
        public string Tipo { get; set; }
        public void setId()
        {
            this.Id = ++ID;
        }
    }
}
