using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoPAV.Entidades;

namespace ProyectoPAV.Datos.Daos
{
    public class ClienteDao
    {
        public IList<Cliente> TraerTodos()
        {
            List<Cliente> lista = new List<Cliente>();
            String query = string.Concat("SELECT * /*nroDocumento, t.idTipoDocumento, nombreCliente, apellidoCliente, fechaNacimiento, idLocalidad*/ FROM Clientes c INNER JOIN TipoDocumento t ON c.tipoDocumento=t.idTipoDocumento WHERE c.borrado = 0");
            var resultado = DBHelper.obtenerInstancia().consultar(query);
            foreach (DataRow row in resultado.Rows)
            {
                lista.Add(ObjectMapping(row));
            }
            return lista;

        }
        public IList<Cliente> ConsultarCondiciones(String condiciones)
        {
            List<Cliente> lista = new List<Cliente>();
            String query = string.Concat("SELECT * /*nroDocumento, tipoDocumento, nombreCliente, apellidoCliente, fechaNacimiento, idLocalidad*/ FROM Clientes c INNER JOIN TipoDocumento t ON c.tipoDocumento=t.idTipoDocumento WHERE c.borrado = 0 " + condiciones);

            var resultado = DBHelper.obtenerInstancia().consultar(query);
            foreach (DataRow row in resultado.Rows)
                lista.Add(ObjectMapping(row));
            return lista;
        }

        public Cliente ObtenerCliente(string numero)
        {
            String query = ("SELECT * FROM Clientes c INNER JOIN TipoDocumento t ON c.tipoDocumento=t.idTipoDocumento WHERE nroDocumento = " + "'" + numero + "'");
            var resultado = DBHelper.obtenerInstancia().consultar(query);
            if (resultado.Rows.Count > 0)
            {
                return ObjectMapping(resultado.Rows[0]);
            }
            return null;
        }

        private Cliente ObjectMapping(DataRow row)
        {
            Cliente cliente = new Cliente
            {
                nroDocumento = Convert.ToInt32(row["nroDocumento"].ToString()),
                nombre = row["nombreCliente"].ToString(),
                apellido = row["apellidoCliente"].ToString(),
                fechaNacimiento = Convert.ToDateTime(row["fechaNacimiento"].ToString()),
                //idLocalidad = Convert.ToInt32(row["idLocalidad"].ToString()),
                tipoDocumento = new TipoDoc()
                {
                    idTipo = Convert.ToInt32(row["idTipoDocumento"].ToString()),
                    nombreTipo = row["nombre"].ToString(),
                    descripcion = row["descripcion"].ToString(),
                    borrado = Convert.ToInt32(row["borrado"].ToString()),
                }
            };
            return cliente;
        }

        internal bool Crear(Cliente oCliente)
        {
            string query = "INSERT INTO Clientes (nroDocumento, tipoDocumento, nombreCliente, apellidoCliente, telefono, fechaNacimiento, borrado)" +
                            "VALUES (" +
                            "'" + oCliente.nroDocumento + "'" + "," +
                            "'" + oCliente.tipoDocumento.idTipo + "'" + "," +
                            "'" + oCliente.nombre + "'" + "," +
                            "'" + oCliente.apellido + "'" + "," +
                            "'" + oCliente.telefono + "'" + "," +
                            "'" + oCliente.fechaNacimiento + "'" + ",0)";
            return (DBHelper.obtenerInstancia().ModificacionSQL(query) == 1);
        }

        internal bool Update(Cliente oCliente)
        {
            string query = "UPDATE Clientes SET nroDocumento=" + "'" + oCliente.nroDocumento + "'" + "," + "tipoDocumento=" + "'" + oCliente.tipoDocumento.idTipo + "'" + "," + "nombreCliente=" + "'" + oCliente.nombre + "'" + "," + "apellidoCliente=" + "'" + oCliente.apellido + "'" + "," + "fechaNacimiento=" + "'" + oCliente.fechaNacimiento + "'" + "," + "borrado = 0";
            return DBHelper.obtenerInstancia().ModificacionSQL(query) == 1;
        }

        internal bool Borrado(Cliente oCliente)
        {
            string query = "UPDATE Clientes SET borrado = 1 WHERE nroDocumento=" + "'" + oCliente.nroDocumento + "'";
            return DBHelper.obtenerInstancia().ModificacionSQL(query) == 1;
        }




    }
}

