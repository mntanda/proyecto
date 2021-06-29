using Infraestucture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestucture.Repository
{
   public interface IRepositorioEncabezado
    {
        IEnumerable<encabezadoMovimiento> GetEncabezadoMovimientos();
        encabezadoMovimiento GetMovimientoByConsecutivo(int consecutivo);
        encabezadoMovimiento GetMovimientoByTipo(int tipo);
        encabezadoMovimiento GetMovimientoByPersona(int idPersona);
        encabezadoMovimiento GetMovimientoByFecha(String fecha);
        encabezadoMovimiento GetMovimientoByProveedor(int cedulaProveedor);
        encabezadoMovimiento GetMovimientoByCliente(int cedulaCliente);
        encabezadoMovimiento GetMovimientoByEmpleado(int empleado);
    }
}
