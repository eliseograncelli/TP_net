using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.CompilerServices;
using System.Diagnostics;

namespace AdministradorDeEmpleados.DAL
{
    class ConexionDAL
    {
        private string cadenaConexion = $"Data Source=PC-Fili; Initial Catalog=dbSistema; Integrated Security = True";
        SqlConnection Conexion;

        public SqlConnection EstablecerConexion()
        {
            this.Conexion = new SqlConnection(this.cadenaConexion);
            return this.Conexion;
        }

        /* Metodo INSERT, DELETE, UPDATE*/
        public string Pruebaconectar(string strComando)
        {
            try
            {
                SqlCommand Comando = new SqlCommand();
                Comando.CommandText = strComando;
                Comando.Connection = this.EstablecerConexion();
                Conexion.Open();
                Comando.ExecuteNonQuery();
                Conexion.Close();
                return "true";

            }
            catch (Exception ex) { return ex.Message; }
        }

        /* SELECTS*/
        public DataSet EjecutarSentencia(SqlCommand sqlComando)
        {
            DataSet DS = new DataSet();
            SqlDataAdapter adaptador = new SqlDataAdapter();

            try
            {
                SqlCommand Comando = new SqlCommand();
                Comando = sqlComando;
                Comando.Connection = EstablecerConexion();
                adaptador.SelectCommand = Comando;
                Conexion.Open();
                adaptador.Fill(DS);
                Conexion.Close();
                return DS;
            }
            catch { return DS; }
        }
    }
}