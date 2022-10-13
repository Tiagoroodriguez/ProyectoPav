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
            String query = string.Concat("SELECT * /*nroDocumento, idTipoDocumento, nombreCliente, apellidoCliente, edad, telefono, idObraSocial*/ FROM Clientes c INNER JOIN TipoDocumento t ON c.tipoDocumento=t.idTipoDocumento*/ FROM Clientes c INNER JOIN Obras_Sociales o ON c.idObraSocial=o.idOS WHERE c.borrado = 0");
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
            Cliente cliente = new Cliente();

            cliente.nroDocumento = Convert.ToInt32(row["nroDocumento"].ToString());
            cliente.nombre = row["nombreCliente"].ToString();
            cliente.apellido = row["apellidoCliente"].ToString();
            cliente.edad = Convert.ToInt32(row["edad"].ToString());
            cliente.telefono = Convert.ToInt32(row["telefono"].ToString());
            cliente.obraSocial = new ObraSocial();

            cliente.obraSocial.Id = Convert.ToInt32(row["idOS"].ToString());
            cliente.obraSocial.Nombre = row["nombreOS"].ToString();
            cliente.obraSocial.Telefono = Convert.ToInt32(row["Telefono"].ToString());
            cliente.obraSocial.CUIT = Convert.ToInt32(row["CUIT"].ToString());
            cliente.obraSocial.Mail = row["email"].ToString();
            cliente.obraSocial.Borrado = Convert.ToInt32(row["borrado"].ToString());

            cliente.tipoDocumento = new TipoDoc();
            cliente.tipoDocumento.idTipo = Convert.ToInt32(row["idTipo"].ToString());
            cliente.tipoDocumento.nombreTipo = row["nombreTipo"].ToString();
            cliente.tipoDocumento.descripcion = row["descripcion"].ToString();

            return cliente;
        }

        internal bool Crear(Cliente oCliente)
        {
            string query = "INSERT INTO Clientes (nroDocumento, tipoDocumento, nombreCliente, apellidoCliente, telefono, edad, idObraSocial, borrado)" +
                            "VALUES (" +
                            "'" + oCliente.nroDocumento + "'" + "," +
                            "'" + oCliente.tipoDocumento.idTipo + "'" + "," +
                            "'" + oCliente.nombre + "'" + "," +
                            "'" + oCliente.apellido + "'" + "," +
                            "'" + oCliente.telefono + "'" + "," +
                            "'" + oCliente.edad + "'" + "," +
                            "'" + oCliente.obraSocial.Id + "'" + ",0)";
            return (DBHelper.obtenerInstancia().ModificacionSQL(query) == 1);
        }

        internal bool Update(Cliente oCliente)
        {
            string query = "UPDATE Clientes SET nroDocumento=" + "'" + oCliente.nroDocumento + "'" + "," + "tipoDocumento=" + "'" + oCliente.tipoDocumento.idTipo + "'" + "," + "nombreCliente=" + "'" + oCliente.nombre + "'" + "," + "apellidoCliente=" + "'" + oCliente.apellido + "'" + "," + "edad=" + "'" + oCliente.edad + "'" + "telefono=" + "'" + oCliente.telefono + "'" + "," + "idObraSocial=" + "'" + oCliente.obraSocial.Id + "'" + "borrado = 0";
            return DBHelper.obtenerInstancia().ModificacionSQL(query) == 1;
        }

        internal bool Borrado(Cliente oCliente)
        {
            string query = "UPDATE Clientes SET borrado = 1 WHERE nroDocumento=" + "'" + oCliente.nroDocumento + "'";
            return DBHelper.obtenerInstancia().ModificacionSQL(query) == 1;
        }




    }
}

