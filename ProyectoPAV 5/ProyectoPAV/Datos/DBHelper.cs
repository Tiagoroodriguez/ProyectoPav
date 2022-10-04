using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoPAV.Datos
{
    internal class DBHelper
    {
        private static DBHelper instacia;
        private SqlConnection conexion;
        private SqlCommand comando;
        private string cadenaConexion;

        private DBHelper()
        {
            conexion = new SqlConnection();
            comando = new SqlCommand();
            cadenaConexion = "Data Source=DESKTOP-IC3GU53\\SQLEXPRESS;Initial Catalog=DB_Pav2;Integrated Security=True";
        }

        public static DBHelper obtenerInstancia()
        {
            if (instacia == null)
            {
                instacia = new DBHelper();
            }
            return instacia;
        }
        public DataTable consultar(string consultaSQL)
        {
            DataTable tabla = new DataTable();
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = consultaSQL;
            tabla.Load(comando.ExecuteReader());

            conexion.Close();
            return tabla;
        }

        public int ModificacionSQL(string strSql)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlTransaction t = null;
            int rtdo = 0;

            try
            {
                // Establece que conexión usar
                conexion.ConnectionString = cadenaConexion;
                // Abre la conexión
                conexion.Open();
                t = conexion.BeginTransaction();
                cmd.Connection = conexion;
                cmd.Transaction = t;
                cmd.CommandType = CommandType.Text;
                // Establece la instrucción a ejecutar
                cmd.CommandText = strSql;
                // Retorna el resultado de ejecutar el comando
                rtdo = cmd.ExecuteNonQuery();
                t.Commit();
            }
            catch (Exception ex)
            {
                if (t != null)
                    t.Rollback();
            }
            finally
            {
                // Cierra la conexión 
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
                conexion.Dispose();
            }
            return rtdo;
        }

        internal int EjecutarSQL(string str_sql)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlTransaction t = null;
            int rtdo = 0;

            try
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                t = conexion.BeginTransaction();
                cmd.Connection = conexion;
                cmd.Transaction = t;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = str_sql;
                rtdo = cmd.ExecuteNonQuery();
                t.Commit();
            }
            catch (Exception ex)
            {
                if (t != null)
                    t.Rollback();
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
                conexion.Dispose();
            }
            return rtdo;
        }
    }
}
