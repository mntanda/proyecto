using Infraestucture.Models;
using Infraestucture.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.SERVICES
{
    public class ServiceContacto : IServiceContacto
    {
        public IEnumerable<Contacto> GetContacto()
        {
            IRepositoryContacto repositoryContacto = new RepositoryContacto();
            return repositoryContacto.GetContacto();
        }

        public Contacto GetContactoByProducto(int id)
        {
            IRepositoryContacto repositoryContacto = new RepositoryContacto();
            return repositoryContacto.GetContactoByProducto(id);
        }

        public Contacto GetContactoByProveedor(int id)
        {
            IRepositoryContacto repositoryContacto = new RepositoryContacto();
            return repositoryContacto.GetContactoByProveedor(id);
        }
    }
}
