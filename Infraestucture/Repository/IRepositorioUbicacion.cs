using Infraestucture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestucture.Repository
{
    public interface IRepositorioUbicacion
    {
        IEnumerable<Ubicacion> GetUbicacion();
        Ubicacion GetUbicacionByName(String ubicacion);
        Ubicacion GetUbicacionByEstado(int estado);
    }
}
