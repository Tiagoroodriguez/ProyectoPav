using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAV.Entidades
{
    class Usuario
    {
        public int Id_usuario { get; set; }
        public string Nombre { get; set; }
        public string Password { get; set; }
        public int Legajo { get; set; }
        public string Email { get; set; }
        public int Id_cargo { get; set; }
        //public string Estado { get; set; }
        public bool Borrado { get; set; }
    }
}
