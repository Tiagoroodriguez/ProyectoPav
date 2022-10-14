using ProyectoPAV.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAV.Datos.Daos
{
    public class DetalleFacturaDao
    {
        public bool CrearDetalle(DetalleFactura detalle)
        {
            string query = "INSERT INTO DetallesFactura (idProducto, numeroFactura, nombreProducto, cantidad, importe, descripcionProducto, borrado)" +
                            "VALUES (" +
                            "'" + detalle.idProducto + "'" + "," +
                            "'" + detalle.numeroFactura + "'" + "," +
                            "'" + detalle.nombreProducto + "'" + "," +
                            "'" + detalle.cantidad + "'" + "," +
                            "'" + detalle.importe + "'" + "," +
                            "'" + detalle.descripcionProducto + "'" + ",0)";
            return (DBHelper.obtenerInstancia().ModificacionSQL(query) == 1);
        }

        public IList<DetalleFactura> TraerTodos(string numero)
        {
            List<DetalleFactura> lista = new List<DetalleFactura>();
            String query = string.Concat("SELECT * FROM DetallesFactura WHERE borrado = 0 AND numeroFactura = " + "'" + numero + "'");
            var resultado = DBHelper.obtenerInstancia().consultar(query);
            foreach (DataRow row in resultado.Rows)
            {
                lista.Add(ObjectMapping(row));
            }
            return lista;

        }

        private DetalleFactura ObjectMapping(DataRow row)
        {
            DetalleFactura detalle = new DetalleFactura()
            {
                idProducto = Convert.ToInt32(row["idProducto"].ToString()),
                numeroFactura = Convert.ToInt32(row["numeroFactura"].ToString()),
                nombreProducto = row["nombreProducto"].ToString(),
                cantidad = Convert.ToInt32(row["cantidad"].ToString()),
                importe = Convert.ToInt32(row["importe"].ToString()),
                descripcionProducto = row["descripcionProducto"].ToString()
            };
            return detalle;
        }

        internal bool BorrarDetalle(int idProducto, int numeroFactura)
        {
            string query = "UPDATE DetallesFactura SET borrado = 1 WHERE numeroFactura=" + "'" + numeroFactura + "'" + " AND idProducto=" + "'" + idProducto + "'";
            return DBHelper.obtenerInstancia().ModificacionSQL(query) == 1;
        }
    }
}

