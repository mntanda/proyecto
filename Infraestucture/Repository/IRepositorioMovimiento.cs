using Infraestucture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestucture.Repository
{
    public interface IRepositorioMovimiento
    {
        IEnumerable<movimientoTipo> GetMovimientoTipo();
        movimientoTipo GetMovimientoTipoById(int id);
        movimientoTipo GetMovimientoTipoByTipo(int tipo);
    }
}
