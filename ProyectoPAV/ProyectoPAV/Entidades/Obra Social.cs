﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAV.Entidades
{
    public class ObraSocial
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Telefono { get; set; }
        public int CUIT { get; set; }
        public string Mail { get; set; }
        public int Borrado { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
