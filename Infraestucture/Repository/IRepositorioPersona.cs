using Infraestucture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestucture.Repository
{
    public interface IRepositorioPersona
    {
        IEnumerable<Persona> GetPersona();
        Persona GetPersonaById(int id);
        Persona GetPersonaByNombre(String nombrePersona);
        Persona GetPersonaByRol(int rol);
        Persona Save(Persona persona);
        void DeletePersona(int id);
    }
}
