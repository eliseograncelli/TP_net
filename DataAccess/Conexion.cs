using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;




namespace DataAccess
{
    public class Conexion
    {
        // private string cadenaConexion = $"Data Source=PC-Fili; Initial Catalog=dbSistema; Integrated Security =True";
        private string cadenaConexion = $"Data Source=DESKTOP-JPRR102; Initial Catalog=dbSistema; Integrated Security =True";
        SqlConnection conexion;


        public SqlConnection EstablecerConexion()
        {
            this.conexion = new SqlConnection(this.cadenaConexion);
            return this.conexion;
        }

        /* Metodo INSERT, DELETE, UPDATE*/
        public string Pruebaconectar(string strComando)
        {
            try
            {
                SqlCommand Comando = new SqlCommand();
                Comando.CommandText = strComando;
                Comando.Connection = this.EstablecerConexion();
                conexion.Open();
                Comando.ExecuteNonQuery();
                conexion.Close();
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
                conexion.Open();
                adaptador.Fill(DS);
                conexion.Close();
                return DS;
            }
            catch { return DS; }
        }
    }
}
