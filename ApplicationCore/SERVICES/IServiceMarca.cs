using Infraestucture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.SERVICES
{
    public interface IServiceMarca
    {
        IEnumerable<Marca> GetMarca();
        Marca GetMarcaByNombre(String marca);
        Marca GetMarcaById(int id);
    }
}
