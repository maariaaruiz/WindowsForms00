﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms00
{
    class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
   

        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

    }
}
