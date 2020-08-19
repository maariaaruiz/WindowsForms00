﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms00
{
    class PersonaRepositoryMemoria : IPersonaRepository
    {
        public IList<Persona> BuscarTodos()
        {
            List<Persona> lista = new List<Persona>();
            lista.Add(new Persona("Juan", 20));
            lista.Add(new Persona("David", 30));
            lista.Add(new Persona("Ana", 40));
            return lista;
        }
    }
}
