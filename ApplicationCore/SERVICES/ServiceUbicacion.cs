using Infraestucture.Models;
using Infraestucture.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.SERVICES
{
    public class ServiceUbicacion : IServiceUbicacion
    {
        public IEnumerable<Ubicacion> GetUbicacion()
        {
            IRepositorioUbicacion repositoryUbicacion = new RepositorioUbicacion();
            return repositoryUbicacion.GetUbicacion();
        }

        public Ubicacion GetUbicacionByEstado(int estado)
        {
            throw new NotImplementedException();
        }

        public Ubicacion GetUbicacionByName(string ubicacion)
        {
            throw new NotImplementedException();
        }
    }
}
