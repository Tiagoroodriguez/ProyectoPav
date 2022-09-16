using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ProyectoPAV.Datos.Daos;
using ProyectoPAV.Datos.Interfaces;
using ProyectoPAV.Entidades;

namespace ProyectoPAV.Servicios
{
    class UsuarioService
    {
        private UsuarioDao dao;

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
        //Chequea que no exista un usuario con el mismo nombre que se ingresa por parametro
        internal object ObtenerUsuario(string usuario)
        {
            return dao.RecuperarPorNombre(usuario);
        }
        //Invoca al metodo que crea el usuario
        internal bool CrearUsuario(Usuario oUsuario)
        {
            return dao.Crear(oUsuario);
        }
        internal bool EliminarUsuario(string nombre)
        {
            return dao.Borrar(nombre);
        }
        internal int ObtenerIdUsuario(string nombre)
        {
            return dao.BuscarId(nombre);
        }
        internal bool ModificarUsuario(string nombre, string apellido, string password, int legajo, string email, Perfil perfil)
        {
            return dao.ActualizarUsuario(nombre, apellido, password, legajo, email, perfil);
        }          
    }
}
