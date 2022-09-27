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
            string consulta = "SELECT * FROM Usuarios WHERE borrado = 0 AND idUsuario =" + idUsuario;
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
        //Crea un nuevo usuario
        internal bool Crear(Usuario oUsuario)
        {
            string consultaSql = "INSERT INTO Usuarios (nombreUsu, claveUsu, legajoUsu, emailUsu, idCargoUsu, borrado)" +
                                " VALUES (" +
                                "'" + oUsuario.Nombre + "'" + "," +
                                "'" + oUsuario.Password + "'" + "," +
                                "'" + oUsuario.Legajo + "'" + "," +
                                "'" + oUsuario.Email + "'" + "," + 
                                oUsuario.Perfil.idCargo + ",0)";

            return (DBHelper.obtenerInstancia().ModificacionSQL(consultaSql) == 1);
                                
        }

        internal bool Borrar(string nombre)
        {
            string consultaSql = "UPDATE Usuarios " +
                                 "SET borrado = 1 " +
                                 "WHERE nombreUsu =" + "'" + nombre + "'";
            return (DBHelper.obtenerInstancia().ModificacionSQL(consultaSql) == 1);

        }

        internal int BuscarId(string nombre)
        {
            string conultaSql = "SELECT * FROM Usuarios WHERE nombreUsu=" + "'" + nombre + "'";
            DataTable tabla = DBHelper.obtenerInstancia().consultar(conultaSql);
            return (int)tabla.Rows[0][0];
        }

        internal bool ActualizarUsuario(string nombre, string apellido, string password, int legajo, string email, Perfil perfil)
        {
            string consultaSql = "UPDATE Usuarios " +
                                 "SET claveUsu =" + "'" + password + "'" + "," +
                                 "legajoUsu=" + "'" + legajo + "'" + "," +
                                 "emailUsu=" + "'" + email + "'" + "," +
                                 "idCargoUsu=" + perfil.idCargo +
                                 "WHERE nombreUsu=" + "'" + nombre + "'";
            return (DBHelper.obtenerInstancia().ModificacionSQL(consultaSql) == 1);
        }

    }
}
