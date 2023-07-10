using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

namespace Clases_Entidades
{
    public class Producto
    {
        private static int ultimoID = 0;

        private string nombre;
        private int id;
        private string descripcion;
        private byte[] foto;

        public string Nombre { get; set; }
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public byte[] Foto { get; set; }


        public Producto()//string nombre, string descripcion, byte[] foto)
        {
            this.Id = ultimoID++;
            /*this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Foto = foto;*/
        }
    }
} 