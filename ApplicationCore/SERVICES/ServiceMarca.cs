using Infraestucture.Models;
using Infraestucture.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.SERVICES
{
    public class ServiceMarca : IServiceMarca
    {
        public IEnumerable<Marca> GetMarca()
        {
            IRepositorioMarca repositoryMarca = new RepositorioMarca();
            return repositoryMarca.GetMarca();
        }

        public Marca GetMarcaById(int id)
        {
            throw new NotImplementedException();
        }

        public Marca GetMarcaByNombre(string marca)
        {
            throw new NotImplementedException();
        }
    }
}
