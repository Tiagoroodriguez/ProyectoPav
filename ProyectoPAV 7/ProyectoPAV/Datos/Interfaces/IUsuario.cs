using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProyectoPAV.Datos.Interfaces
{
    interface IUsuario
    {
        int validarUsuario(string nombre, string clave);
        DataTable RecuperarTodos();
        DataTable RecuperarPorId(int idUsuario);
    }
}
