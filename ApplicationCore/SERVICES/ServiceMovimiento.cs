using Infraestucture.Models;
using Infraestucture.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.SERVICES
{
    public class ServiceMovimiento : IServiceMovimiento
    {
        public IEnumerable<movimientoTipo> GetMovimientoTipo()
        {
            IRepositorioMovimiento repositoryMovimiento = new RepositorioMovimiento();
            return repositoryMovimiento.GetMovimientoTipo();
        }

        public movimientoTipo GetMovimientoTipoById(int id)
        {
            throw new NotImplementedException();
        }

        public movimientoTipo GetMovimientoTipoByTipo(int tipo)
        {
            throw new NotImplementedException();
        }
    }
}
