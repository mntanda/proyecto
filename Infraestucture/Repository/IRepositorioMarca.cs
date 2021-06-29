using Infraestucture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestucture.Repository
{
    public interface IRepositorioMarca
    {
        IEnumerable<Marca> GetMarca();
        Marca GetMarcaByNombre(String marca);
        Marca GetMarcaById(int id);
    }
}
