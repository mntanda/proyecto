using Infraestucture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.SERVICES
{
   public interface IServicePersona
    {
        IEnumerable<Persona> GetPersona();
        Persona GetPersonaById(int id);
        Persona GetPersonaByNombre(String nombrePersona);
        Persona GetPersonaByRol(int rol);
    }
}
