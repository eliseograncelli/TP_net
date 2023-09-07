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

        public string GuardarUsuario(UsuarioBE usuNuevo) // OK
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
        } // OK
        public int Modificar(UsuarioBE usu)
        {
            conexion.Pruebaconectar(
                "Update Empleado Set nombre='"
                + usu.Nombre +"',dni='" + usu.DNI + "',email='" + usu.Email + "' apellido= '" + usu.Apellido + "',password='" + usu.Password + "', tipo= '" + usu.Tipo + "', estado= '" + usu.Estado + "' Where id =" + usu.Id);
            return 1;
        } // OK
        public DataSet MostrarUsuarios()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM Empleado");
            return conexion.EjecutarSentencia(sentencia);
        } // OK


        public UsuarioBE BuscarUsu(UsuarioBE usu)  
        {
            try
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM Usuario WHERE email = '" + usu.Email + "' AND password = '" + usu.Password + "'");
                Conexion c = new Conexion();
                SqlDataReader r;
                r = c.SentenciaAString(comando);

                if (r["email"].ToString() != usu.Email || r["password"].ToString() != usu.Password)
                {
                    // NO ENCUENTRA
                    usu = null;
                }
                else
                {
                    // Usuario encontrado
                    usu.Nombre = r["nombre"].ToString();
                    usu.Apellido = r["apellido"].ToString();
                    usu.Estado = r["estado"].ToString();
                    usu.Tipo = r["tipo"].ToString();
                    usu.DNI = (int)r["dni"];
                    usu.Id = (int)r["id"];
                }
                return usu;
            }
            catch (Exception ex)
            {
                // MENSAJE EXCEPCION
                return usu;
            }
        }  // OK
    }
}
