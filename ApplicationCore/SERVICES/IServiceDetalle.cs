using Infraestucture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.SERVICES
{
    public interface IServiceDetalle
    {
        IEnumerable<detalleMovimiento> GetDetalleMovimientos();
        detalleMovimiento GetDetalleMovimientoByConsecutivo(int consecutivo);
        detalleMovimiento GetDetalleMovimientoByTipo(int tipo);
        detalleMovimiento GetDetalleMovimientoByPersona(int idPersona);
        detalleMovimiento GetDetalleMovimientoByFecha(String fecha);
        detalleMovimiento GetDetalleMovimientoByProveedor(int cedulaProveedor);
        detalleMovimiento GetDetalleMovimientoByCliente(int cedulaCliente);
        detalleMovimiento GetDetalleMovimientoByEmpleado(int empleado);
    }
}
