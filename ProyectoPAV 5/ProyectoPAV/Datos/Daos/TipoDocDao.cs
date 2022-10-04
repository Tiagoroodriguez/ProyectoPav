using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoPAV.Entidades;

namespace ProyectoPAV.Datos.Daos
{
    public class TipoDocDao
    {
        public IList<TipoDoc> GetAll()
        {
            List<TipoDoc> list = new List<TipoDoc>();
            var query = "SELECT * FROM TipoDocumento WHERE borrado=0";
            var resultado = DBHelper.obtenerInstancia().consultar(query);

            foreach (DataRow row in resultado.Rows)
            {
                list.Add(ObjectMapping(row));
            }
            return list;
        }

        private TipoDoc ObjectMapping(DataRow row)
        {
            TipoDoc oTipoDoc = new TipoDoc
            {
                idTipo = Convert.ToInt32(row["idTipoDocumento"].ToString()),
                nombreTipo = row["nombre"].ToString(),
                descripcion = row["descripcion"].ToString()
            };
            return oTipoDoc;
        }
    }
}
