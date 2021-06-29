using Infraestucture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestucture.Repository
{
   public interface IRepositoryPosicion
    {
        IEnumerable<posicion> GetPsicion();
        IEnumerable<posicion> GetPosicionById(int idPosicion);     
        posicion getDetalleByCodigo(int cod);
        posicion getDetalleById(int id);
        posicion getDetalleByUbicacion(String ubicacion);
        posicion getDetalleByEstado(int estado);
    }
}
