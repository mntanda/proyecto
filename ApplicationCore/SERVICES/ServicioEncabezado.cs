using Infraestucture.Models;
using Infraestucture.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.SERVICES
{
    public class ServicioEncabezado : IServicoEncabezado
    {
        public IEnumerable<encabezadoMovimiento> GetEncabezadoMovimientos()
        {
            IRepositorioEncabezado repositoryEncabezado = new RepositorioEncabezado();
            return repositoryEncabezado.GetEncabezadoMovimientos();
        }

        public encabezadoMovimiento GetMovimientoByCliente(int cedulaCliente)
        {
            throw new NotImplementedException();
        }

        public encabezadoMovimiento GetMovimientoByConsecutivo(int consecutivo)
        {
            IRepositorioEncabezado repository = new RepositorioEncabezado();
            return repository.GetMovimientoByConsecutivo(consecutivo);
        }

        public encabezadoMovimiento GetMovimientoByEmpleado(int empleado)
        {
            throw new NotImplementedException();
        }

        public encabezadoMovimiento GetMovimientoByFecha(string fecha)
        {
            throw new NotImplementedException();
        }

        public encabezadoMovimiento GetMovimientoByPersona(int idPersona)
        {
            throw new NotImplementedException();
        }

        public encabezadoMovimiento GetMovimientoByProveedor(int cedulaProveedor)
        {
            throw new NotImplementedException();
        }

        public encabezadoMovimiento GetMovimientoByTipo(int tipo)
        {
            throw new NotImplementedException();
        }
    }
}
