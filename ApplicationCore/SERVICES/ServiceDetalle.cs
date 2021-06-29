using Infraestucture.Models;
using Infraestucture.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.SERVICES
{
    public class ServiceDetalle : IServiceDetalle
    {
        public detalleMovimiento GetDetalleMovimientoByCliente(int cedulaCliente)
        {
            throw new NotImplementedException();
        }

        public detalleMovimiento GetDetalleMovimientoByConsecutivo(int consecutivo)
        {
            IRepositoryDetalle repository = new RepositoryDetalle();
            return repository.GetDetalleMovimientoByConsecutivo(consecutivo);
        }

        public detalleMovimiento GetDetalleMovimientoByEmpleado(int empleado)
        {
            throw new NotImplementedException();
        }

        public detalleMovimiento GetDetalleMovimientoByFecha(string fecha)
        {
            throw new NotImplementedException();
        }

        public detalleMovimiento GetDetalleMovimientoByPersona(int idPersona)
        {
            throw new NotImplementedException();
        }

        public detalleMovimiento GetDetalleMovimientoByProveedor(int cedulaProveedor)
        {
            throw new NotImplementedException();
        }

        public detalleMovimiento GetDetalleMovimientoByTipo(int tipo)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<detalleMovimiento> GetDetalleMovimientos()
        {
            IRepositoryDetalle repositoryDetalle = new RepositoryDetalle();
            return repositoryDetalle.GetDetalleMovimientos();
        }
    }
}
