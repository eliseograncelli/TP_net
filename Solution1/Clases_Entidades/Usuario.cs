using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        private static int ultimoId = 0;
        private int id;
        private int dni;
        private string nombre;
        private string apellido;
        private string email;

        public int Id { get; set; }
        public int Dni { get; set; }
        public string Nombre { get; set;}
        public string Apellido { get; set;}
        public string Email { get; set;}

        public Usuario(int dni, string nombre, string apellido, string email)
        {
            incrementaId();
            this.Id = ultimoId;
            this.Dni = dni;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Email = email;
        }

        private static void incrementaId()
        {
            ultimoId++ ;
        }

   

    }
}
