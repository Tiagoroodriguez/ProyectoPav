using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoPAV.Entidades;

namespace ProyectoPAV.Datos.Daos
{
    public class FDPDao
    {
        public IList<Forma_de_Pago> TraerTodos()
        {
            List<Forma_de_Pago> lista = new List<Forma_de_Pago>();
            String query = string.Concat("SELECT * FROM Formas_de_Pago c  WHERE c.borrado = 0");
            var resultado = DBHelper.obtenerInstancia().consultar(query);
            foreach (DataRow row in resultado.Rows)
            {
                lista.Add(ObjectMapping(row));
            }
            return lista;
        }

        private Forma_de_Pago ObjectMapping(DataRow row)
        {
            Forma_de_Pago fdp = new Forma_de_Pago()
            {
                idFDP = Convert.ToInt32(row["idFDP"]),
                nombreFDP = row["nombreFDP"].ToString(),
                descripcionFDP = row["descripcionFDP"].ToString(),
                descuentoFDP = Convert.ToDouble(row["descuentoFDP"]),
                recargoFDP = Convert.ToDouble(row["recargoFDP"]),
                cuotasFDP = Convert.ToInt32(row["cuotasFDP"])
            };

            return fdp;
        }
    }
}
