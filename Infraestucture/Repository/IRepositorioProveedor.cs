using Infraestucture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestucture.Repository
{
    public interface IRepositorioProveedor
    {
        IEnumerable<Proveedor> GetProveedor();
        Proveedor GetProveedorByCodigo(int codigo);
        Proveedor GetProveedorById(int Id);
        Proveedor GetProveedorByNombre(String nombre);
        Proveedor GetProveedorByestado(int estado);
    }
}
