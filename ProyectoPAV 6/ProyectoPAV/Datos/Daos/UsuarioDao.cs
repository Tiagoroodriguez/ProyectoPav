using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ProyectoPAV.Datos.Interfaces;
using ProyectoPAV.Entidades;

namespace ProyectoPAV.Datos.Daos
{
    class UsuarioDao : IUsuario
    {
        public int validarUsuario(string nombre, string clave)
        {
            string consulta = "SELECT * FROM Usuarios WHERE nombreUsu='" + nombre + "' AND claveUsu='" + clave + "'";

            DataTable tabla = DBHelper.obtenerInstancia().consultar(consulta);
            if (tabla.Rows.Count > 0)
                return (int)tabla.Rows[0][0];
            else
                return 0;

        }
        public DataTable RecuperarTodos()
        {
            string consulta = "SELECT * FROM Usuarios WHERE borrado = 0 order by idUsuario";

            return DBHelper.obtenerInstancia().consultar(consulta);
        }

        public DataTable RecuperarPorId(int idUsuario)
        {
            string consulta = "SELECT * FROM Usuarios WHERE borrado = 0 AND id_usuario =" + idUsuario;
            return DBHelper.obtenerInstancia().consultar(consulta);

        }

        public DataTable RecuperarPorNombre(string nombreUsuario)
        {
            string consulta = "SELECT * FROM Usuarios WHERE nombreUsu=" + "'" + nombreUsuario + "'";
            var resultado = DBHelper.obtenerInstancia().consultar(consulta);
            if (resultado.Rows.Count > 0)
            {
                return resultado;
            }
            else
            {
                return null;
            }
        }

        internal bool Delete(Usuario oUsuarioSelected)
        {
            string query = "UPDATE Usuarios SET borrado=1 WHERE nombreUsu=" + "'" + oUsuarioSelected.Nombre + "'";
            return DBHelper.obtenerInstancia().ModificacionSQL(query) == 1;
        }

        internal bool Update(Usuario oUsuario)
        {
            string str_sql = "UPDATE Usuario " +
                             "SET nombreUsu=" + "'" + oUsuario.Nombre + "'" + "," +
                             " apellidoUsu=" + "'" + oUsuario.Apellido + "'" + "," +
                             " claveUsu=" + "'" + oUsuario.Password + "'" + "," +
                             " legajoUsu=" + "'" + oUsuario.Legajo + "'" + "," +
                             " emailUsu=" + "'" + oUsuario.Email + "'" + "," +
                             " idCargo=" + oUsuario.Perfil.idCargo +
                             " WHERE idUsuario=" + oUsuario.Id_usuario;

            return (DBHelper.obtenerInstancia().EjecutarSQL(str_sql) == 1);
        }

        internal IList<Usuario> ObtenerTodos()
        {
            List<Usuario> listaUS = new List<Usuario>();

            String query = string.Concat("SELECT idUsuario, nombreUsu, apellidoUsu, claveUsu, legajoUsu, emailUsu, idCargoUsu, nombreCargo FROM Usuarios u INNER JOIN Cargos c ON u.idCargoUsu=c.idCargo  WHERE u.borrado = 0 ");
            var resultado = DBHelper.obtenerInstancia().consultar(query);

            foreach (DataRow row in resultado.Rows)
            {
                listaUS.Add(ObjectMapping(row));
            }

            return listaUS;
        }

        internal IList<Usuario> ConsultarConCondiciones(string condiciones)
        {
            List<Usuario> list = new List<Usuario>();
            String query = string.Concat("SELECT idUsuario, nombreUsu, apellidoUsu, claveUsu, legajoUsu, emailUsu, idCargoUsu, nombreCargo FROM Usuarios u INNER JOIN Cargos c ON u.idCargoUsu=c.idCargo WHERE u.borrado = 0 " + condiciones);
            var resultado = DBHelper.obtenerInstancia().consultar(query);
            foreach (DataRow row in resultado.Rows)
                list.Add(ObjectMapping(row));
            return list;
        }

        internal IList<Usuario> GetByFiltersSinParametros(String condiciones)
        {
            List<Usuario> lst = new List<Usuario>();
            String strSql = string.Concat(" SELECT idUsuario, ",
                                          " nombreUsu, ",
                                          " apellidoUsu, ",
                                          " claveUsu, ",
                                          " legajoUsu, ",
                                          " emailUsu, ",
                                          " p.idCargo, ",
                                          " p.nombreCargo as cargos ",
                                          " FROM Usuarios u",
                                          " INNER JOIN Cargos p ON u.idCargo= p.idCargo ",
                                          " WHERE u.borrado =0");

            var resultado = DBHelper.obtenerInstancia().consultar(strSql);
            foreach (DataRow row in resultado.Rows)
            {
                lst.Add(ObjectMapping(row));
            }
            return lst;
        }

        private Usuario ObjectMapping(DataRow row)
        {
            Usuario oUsuario = new Usuario();

            oUsuario.Id_usuario = Convert.ToInt32(row["idUsuario"].ToString());
            oUsuario.Legajo = Convert.ToInt32(row["legajoUsu"].ToString());
            oUsuario.Nombre = row["nombreUsu"].ToString();
            oUsuario.Apellido = row["apellidoUsu"].ToString();
            oUsuario.Email = row["emailUsu"].ToString();
            oUsuario.Password = row.Table.Columns.Contains("claveUsu") ? row["claveUsu"].ToString() : null;
            oUsuario.Perfil.idCargo = Convert.ToInt32(row["idCargoUsu"].ToString());
            oUsuario.Perfil.nombreCargo = row["nombreCargo"].ToString();



            return oUsuario;
        }

        //Crea un nuevo usuario
        internal bool Crear(Usuario oUsuario)
        {
            string consultaSql = "INSERT INTO Usuarios (nombreUsu, apellidoUsu, claveUsu, legajoUsu, emailUsu, idCargoUsu, borrado)" +
                                " VALUES (" +
                                "'" + oUsuario.Nombre + "'" + "," +
                                "'" + oUsuario.Apellido + "'" + "," +
                                "'" + oUsuario.Password + "'" + "," +
                                "'" + oUsuario.Legajo + "'" + "," +
                                "'" + oUsuario.Email + "'" + "," +
                                oUsuario.Perfil.idCargo + ",0)";

            return (DBHelper.obtenerInstancia().ModificacionSQL(consultaSql) == 1);

        }

    }
}
