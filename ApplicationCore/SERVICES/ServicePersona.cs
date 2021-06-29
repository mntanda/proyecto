using Infraestucture.Models;
using Infraestucture.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.SERVICES
{
    public class ServicePersona : IServicePersona
    {
        public IEnumerable<Persona> GetPersona()
        {
            IRepositorioPersona repositoryPersona = new RepositorioPersona();
            return repositoryPersona.GetPersona();
        }

        public Persona GetPersonaById(int id)
        {
            throw new NotImplementedException();
        }

        public Persona GetPersonaByNombre(string nombrePersona)
        {
            throw new NotImplementedException();
        }

        public Persona GetPersonaByRol(int rol)
        {
            throw new NotImplementedException();
        }
    }
}
