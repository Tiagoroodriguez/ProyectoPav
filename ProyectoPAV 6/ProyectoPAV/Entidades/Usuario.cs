using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoPAV.Entidades;

namespace ProyectoPAV.Entidades
{
    class Usuario
    {
        public int Id_usuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Password { get; set; }
        public int Legajo { get; set; }
        public string Email { get; set; }
        public Perfil Perfil { get; set; }
        //public string Estado { get; set; }
        public bool Borrado { get; set; }
        public Usuario()
        {
            Perfil = new Perfil();
        }
    }
}
