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
    internal class PerfilService
    {
        private IPerfil dao;
        public PerfilService()
        {
            dao = new PerfilDao();
        }
        public DataTable traerTodos()
        {
            return dao.RecuperarTodos();
        }
    }
}
