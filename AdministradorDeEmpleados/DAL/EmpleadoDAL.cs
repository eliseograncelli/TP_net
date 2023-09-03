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
            MessageBox.Show("USUARIO " + oEmpleado.Nombre + " CREADO EXITOSAMENTE");
            return conexion.Pruebaconectar(
                "INSERT INTO Empleado (nombre,email,password,tipo, dni, estado) " +
                "VALUES ('" + oEmpleado.Nombre + "', '" + oEmpleado.Email + "', '" + oEmpleado.Password + "','" + oEmpleado.Tipo + "', '" + oEmpleado.DNI + "', '" + oEmpleado.Estado + "' );");
        }
        public int Eliminar(EmpleadosBLL oEmpleado)
        {
            MessageBox.Show("SE ELIMINA EL EMPLEADO: " + oEmpleado.Nombre);
            conexion.Pruebaconectar(
                "DELETE FROM Empleado WHERE id = '" + oEmpleado.Id + "'");
            return 1;
        }
        public int Modificar(EmpleadosBLL oEmpleado)
        {
            string nuevoNombre = oEmpleado.Nombre;
            string nuevoEmail = oEmpleado.Email;
            string nuevaPassword = oEmpleado.Password;
            string nuevoEstado = oEmpleado.Estado;
            string nuevoTipo = oEmpleado.Tipo;
            // int nuevodni = oEmpleado.DNI;

            conexion.Pruebaconectar(
                "Update Empleado Set nombre='"
                + nuevoNombre +/*"',dni='" + nuevodni +*/ "',email='" + nuevoEmail + "',password='" + nuevaPassword + "', tipo= '" +nuevoTipo + "', estado= '" + nuevoEstado + "' Where id =" + oEmpleado.Id);
            return 1;
        }
        public DataSet MostrarEmpleados()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM Empleado");
            return conexion.EjecutarSentencia(sentencia);
        }

        /*  public DataSet BuscarEmp(string email, string contraseña)   // ESTE ANDA PERO NO TAN BIEN
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

              catch (Exception ex)
              {
                  {
                      MessageBox.Show("ERROR AL BUSCAR EMPLEADO " + ex.Message);
                      return ds;
                  }
              }
          } */


        public DataSet BuscarEmp(string email, string contraseña)   // NO FUNCIONA, REVISAR. LA IDEA ES QUE ME TRAIGA UN OBJETO TIPO USUARIO PARA VER SI ES ADMIN O EMPLEADO
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
