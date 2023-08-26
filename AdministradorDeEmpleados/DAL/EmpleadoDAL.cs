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
                "INSERT INTO Empleado (nombre,email,password,tipo, dni) " +
                "VALUES ('" + oEmpleado.Nombre+"', '" + oEmpleado.Email+"', '"+oEmpleado.Password+"','"+oEmpleado.Tipo+"', '"+oEmpleado.DNI+"' );");
        }
        public int Eliminar(EmpleadosBLL oEmpleado)
        {
            MessageBox.Show("Se elimina el empleado: " +oEmpleado.Nombre);
            conexion.Pruebaconectar(
                "DELETE FROM Empleado WHERE id = '"+oEmpleado.Id+ "'") ;
            return 1;
        }
        public int Modificar(EmpleadosBLL oEmpleado)
        {
            string nuevoNombre = oEmpleado.Nombre;
            string nuevoEmail = oEmpleado.Email;
            string nuevaPassword = oEmpleado.Password;
           // int nuevodni = oEmpleado.DNI;

            conexion.Pruebaconectar(
                "Update Empleado Set nombre='"
                + nuevoNombre +/*"',dni='" + nuevodni +*/ "',email='" +nuevoEmail+"',password='"+nuevaPassword+"' Where id =" + oEmpleado.Id);
            return 1;
        }
        public DataSet MostrarEmpleados()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM Empleado");
            return conexion.EjecutarSentencia(sentencia);
        }

        public DataSet BuscarEmp(string email, string contraseña)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlCommand sentencia = new SqlCommand("SELECT * FROM Empleado WHERE email = '" + email + "' AND password = '" + contraseña + "'");
                ds = conexion.EjecutarSentencia(sentencia);
                if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
                {
                    ds = null;
                }
                return ds;
            }
            catch
            {
                MessageBox.Show("ERROR AL BUSCAR EMPLEADO");
                return ds;
            }
        }
    }
}
