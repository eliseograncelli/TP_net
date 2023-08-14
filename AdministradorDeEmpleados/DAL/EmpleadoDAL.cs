using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using AdministradorDeEmpleados.BLL;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace AdministradorDeEmpleados.DAL
{
    class EmpleadoDAL
    {
        ConexionDAL conexion;
        public EmpleadoDAL()
        {
            conexion = new ConexionDAL();
        }

        public string Agregar(EmpleadosBLL oEmpleado)
        {
            return conexion.Pruebaconectar(
                "INSERT INTO Empleado (nombre,email,password,tipo) " +
                "VALUES ('" + oEmpleado.nombre+"', '" + oEmpleado.email+"', '"+oEmpleado.password+"','"+oEmpleado.tipo+"');");
        }
        public int Eliminar(EmpleadosBLL oEmpleado)
        {
            MessageBox.Show("Se elimina el empleado: " +oEmpleado.nombre);
            conexion.Pruebaconectar(
                "DELETE FROM Empleado WHERE nombre = '"+oEmpleado.nombre+ "'") ;
            return 1;
        }
        public int Modificar(EmpleadosBLL oEmpleado)
        {
            string nuevoNombre = oEmpleado.nombre;
            string nuevoEmail = oEmpleado.email;
            string nuevaPassword = oEmpleado.password;

            conexion.Pruebaconectar(
                "Update Empleado Set nombre='"
                + nuevoNombre + "',email='"+nuevoEmail+"',password='"+nuevaPassword+"' Where id =" + oEmpleado.id);
            return 1;
        }
        public DataSet MostrarEmpleados()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM Empleado");
            return conexion.EjecutarSentencia(sentencia);
        }
    }
}
