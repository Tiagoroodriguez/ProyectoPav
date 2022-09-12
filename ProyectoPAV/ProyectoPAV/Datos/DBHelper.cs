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
            cadenaConexion = "Data Source=DESKTOP-IC3GU53\\SQLEXPRESS;Initial Catalog=DB_Pav;Integrated Security=True";
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

    }
}
