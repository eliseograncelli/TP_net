using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Entidades
{
    internal class Precio
    {
        private int idProducto;
        private float[] valor = new float[4];

        public int IdProducto { get; set; }
        public float[] Valor { get; set; } // El primer valor es precio unitario, el segundo valor es para entre 5 y 10
                                           // productos, el tercer valor entre 10 y 20, y el cuarto +20u

        public Precio(int idProducto, float[] valor)
        {
            this.IdProducto = idProducto;
            this.Valor = valor;
        }
    }
}
