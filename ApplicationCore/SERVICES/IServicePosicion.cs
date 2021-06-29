using Infraestucture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.SERVICES
{
    public interface IServicePosicion
    {
        IEnumerable<posicion> GetPsicion();
        IEnumerable<posicion> GetPosicionById(int idPosicion);
        posicion getDetalleByCodigo(int cod);
        posicion getDetalleById(int id);
        posicion getDetalleByUbicacion(String ubicacion);
        posicion getDetalleByEstado(int estado);
    }
}
