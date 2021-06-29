using Infraestucture.Models;
using Infraestucture.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.SERVICES
{
    public class ServicePosicion : IServicePosicion
    {
        public posicion getDetalleByCodigo(int cod)
        {
            IRepositoryPosicion repository = new RepositoryPosicion();
            return repository.getDetalleById(cod);
        }

        public posicion getDetalleByEstado(int estado)
        {
            throw new NotImplementedException();
        }

        public posicion getDetalleById(int id)
        {
            IRepositoryPosicion repository = new RepositoryPosicion();
            return repository.getDetalleById(id);
        }

        public posicion getDetalleByUbicacion(string ubicacion)
        {
            throw new NotImplementedException();
        }       

        public IEnumerable<posicion> GetPosicionById(int idPosicion)
        {
            IRepositoryPosicion repositoryPoscicion = new RepositoryPosicion();
            return repositoryPoscicion.GetPosicionById(idPosicion);
        }

        public IEnumerable<posicion> GetPsicion()
        {
            IRepositoryPosicion repositoryPosicion = new RepositoryPosicion();
            return repositoryPosicion.GetPsicion();
        }
    }
}
