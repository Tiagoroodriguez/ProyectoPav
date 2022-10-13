using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAV.Datos.Daos
{
    internal class TipoProdDao
    {
        internal DataTable RecuperarTodos()
        {
            string consulta = "SELECT * FROM TipoProducto WHERE borrado = 0 order by 2";
            return DBHelper.obtenerInstancia().consultar(consulta);
        }
    }
}
