using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ProyectoPAV.Datos.Daos;
using ProyectoPAV.Datos.Interfaces;

namespace ProyectoPAV.Servicios
{
    class UsuarioService
    {
        private IUsuario dao;

        public UsuarioService()
        {
            dao = new UsuarioDao();
        }
        public int encontrarUsuario(string nombre, string clave)
        {
            return dao.validarUsuario(nombre, clave);
        }
        public DataTable traerTodos()
        {
            return dao.RecuperarTodos();
        }
        public DataTable traerPorId(int idUsuario)
        {
            return dao.RecuperarPorId(idUsuario);
        }
    }
}
