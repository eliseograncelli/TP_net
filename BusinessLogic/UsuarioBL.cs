using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Windows;
//using System.Windows.Forms;



namespace BusinessLogic
{
    class UsuarioBL
    {
        Conexion conexion;
        public UsuarioBL()
        {
            conexion = new Conexion();
        }

        public string Agregar(UsuarioBL oEmpleado)
        {
            MessageBox.Show("USUARIO " + oEmpleado.Nombre + " CREADO EXITOSAMENTE");
            return conexion.Pruebaconectar(
                "INSERT INTO Empleado (nombre,email,password,tipo, dni, estado) " +
                "VALUES ('" + oEmpleado.Nombre + "', '" + oEmpleado.Email + "', '" + oEmpleado.Password + "','" + oEmpleado.Tipo + "', '" + oEmpleado.DNI + "', '" + oEmpleado.Estado + "' );");
        }
        public int Eliminar(UsuarioBL oEmpleado)
        {
            MessageBox.Show("SE ELIMINA EL EMPLEADO: " + oEmpleado.Nombre);
            conexion.Pruebaconectar(
                "DELETE FROM Empleado WHERE id = '" + oEmpleado.Id + "'");
            return 1;
        }
        public int Modificar(UsuarioBL oEmpleado)
        {
            string nuevoNombre = oEmpleado.Nombre;
            string nuevoEmail = oEmpleado.Email;
            string nuevaPassword = oEmpleado.Password;
            string nuevoEstado = oEmpleado.Estado;
            string nuevoTipo = oEmpleado.Tipo;
            // int nuevodni = oEmpleado.DNI;

            conexion.Pruebaconectar(
                "Update Empleado Set nombre='"
                + nuevoNombre +/*"',dni='" + nuevodni +*/ "',email='" + nuevoEmail + "',password='" + nuevaPassword + "', tipo= '" + nuevoTipo + "', estado= '" + nuevoEstado + "' Where id =" + oEmpleado.Id);
            return 1;
        }
        public DataSet MostrarEmpleados()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM Empleado");
            return conexion.EjecutarSentencia(sentencia);
        }


        public DataSet BuscarEmp(string email, string contraseña)   // NO FUNCIONA, REVISAR
        {
            DataSet ds = new DataSet();
            ds = null;

            try
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM Empleado WHERE email = '" + email + "' AND password = '" + contraseña + "'");
                ds = conexion.EjecutarSentencia(comando);


                if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
                {
                    ds = null;
                    return ds;
                }

                return ds;



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar empleado: " + ex.Message);
                return ds;
            }
        }


    }
}
