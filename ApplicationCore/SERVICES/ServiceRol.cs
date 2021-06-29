using Infraestucture.Models;
using Infraestucture.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
   public class ServiceRol : IServiceRol
    {
        public IEnumerable<Rol> GetRol()
        {
            IRepositorioRol repositoryRol = new RepositorioRol();
            return repositoryRol.GetRol();
        }

        public Rol GetRolById(int id)
        {
            throw new NotImplementedException();
        }

        public Rol GetRolByNombre(string nombre)
        {
            throw new NotImplementedException();
        }
    }
}
