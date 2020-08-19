using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms00
{
    interface IPersonaRepository
    {
        IList<Persona> BuscarTodos();
        
    }
}
