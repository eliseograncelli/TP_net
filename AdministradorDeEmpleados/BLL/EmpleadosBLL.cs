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
        public int id { set; get; }
        public string nombre { get; set; }
        public string email { get; set; }
        public string password { get; set;}
        public byte[] foto { get; set; }
        public string tipo { get; set; }
        public void setId()
        {
            this.id = ++ID;
        }
    }
}
