using ProyectoPAV.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAV.Datos.Daos
{
    public class ObraSocialDao
    {
        public IList<ObraSocial> ObtenerTodos()
        {
            List<ObraSocial> listaOS = new List<ObraSocial>();

            String query = string.Concat("SELECT idOS, nombreOS, Telefono, email, CUIT FROM Obras_Sociales WHERE borrado = 0 ");
            var resultado = DBHelper.obtenerInstancia().consultar(query);

            foreach (DataRow row in resultado.Rows)
            {
                listaOS.Add(ObjectMapping(row));
            }

            return listaOS;
        }

        public IList<ObraSocial> ConsultarConCondiciones(String condiciones)
        {
            List<ObraSocial> list = new List<ObraSocial>();
            String query = string.Concat("SELECT idOS, nombreOS, Telefono, email, CUIT FROM Obras_Sociales WHERE borrado = 0 " + condiciones);
            var resultado = DBHelper.obtenerInstancia().consultar(query);
            foreach (DataRow row in resultado.Rows)
                list.Add(ObjectMapping(row));
            return list;
        }


        private ObraSocial ObjectMapping(DataRow row)
        {
            ObraSocial oOS = new ObraSocial
            {
                Id = Convert.ToInt32(row["idOS"].ToString()),
                Nombre = row["NombreOS"].ToString(),
                Mail = row["email"].ToString(),
                CUIT = Convert.ToInt32(row["CUIT"].ToString()),
                Telefono = Convert.ToInt32(row["Telefono"].ToString())
            };
            return oOS;
        }

        public ObraSocial GetOSNombre(string nombre)
        {
            String query = string.Concat("SELECT * FROM Obras_Sociales WHERE borrado = 0 AND nombreOS=" + "'" + nombre + "'");
            var resultado = DBHelper.obtenerInstancia().consultar(query);
            if (resultado.Rows.Count > 0)
            {
                return ObjectMapping(resultado.Rows[0]);
            }
            return null;
        }

        internal bool Crear(ObraSocial oObraSocial)
        {
            string query = "INSERT INTO Obras_Sociales (nombreOS, Telefono, CUIT, email, borrado) VALUES (" + "'" + oObraSocial.Nombre + "'" + "," + "'" + oObraSocial.Telefono + "'" + "," + "'" + oObraSocial.CUIT + "'" + "," + "'" + oObraSocial.Mail + "'" + ",0)";
            return (DBHelper.obtenerInstancia().EjecutarSQL(query) == 1);
        }

        internal bool Actualizar(ObraSocial obraSocial)
        {
            string query = "UPDATE Obras_Sociales SET Telefono=" + "'" + obraSocial.Telefono + "'" + "," + "CUIT =" + "'" + obraSocial.CUIT + "'" + "," + "email= " + "'" + obraSocial.Mail + "'" + "," + "borrado= 0 WHERE nombreOS=" + "'" + obraSocial.Nombre + "'";
            return (DBHelper.obtenerInstancia().ModificacionSQL(query) == 1);
        }

        internal bool Borrado(ObraSocial oObraSocial)
        {
            string query = "UPDATE Obras_Sociales SET borrado=1 WHERE nombreOS=" + "'" + oObraSocial.Nombre + "'";
            return DBHelper.obtenerInstancia().ModificacionSQL(query) == 1;
        }
    }
}
