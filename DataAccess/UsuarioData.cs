using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;

namespace DataAccess
{
    public class UsuarioData
    {
        Conexion conexion;
        public UsuarioData()
        {
            conexion = new Conexion();
        }

        public string GuardarUsuario(UsuarioBE usuNuevo) //((int dni, string nombre, string apellido, string email, byte foto, string password, string tipo, string estado)
        {
            return conexion.Pruebaconectar(
                "INSERT INTO Usuario (dni,nombre,apellido,email,password,tipo,estado) " +
                "VALUES ('" + usuNuevo.DNI +"','" + usuNuevo.Nombre + "', '" + usuNuevo.Apellido + "', '" + usuNuevo.Email + "','" + usuNuevo.Password + "', '" + usuNuevo.Tipo + "', '" + usuNuevo.Estado + "' );");
        }

        public int EliminarDeBD(int id)
        {
            conexion.Pruebaconectar(
                "DELETE FROM Empleado WHERE id = '" + id + "'");
            return 1;
        }
        public int Modificar(UsuarioBE usu)
        {
            conexion.Pruebaconectar(
                "Update Empleado Set nombre='"
                + usu.Nombre +"',dni='" + usu.DNI + "',email='" + usu.Email + "' apellido= '" + usu.Apellido + "',password='" + usu.Password + "', tipo= '" + usu.Tipo + "', estado= '" + usu.Estado + "' Where id =" + usu.Id);
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
