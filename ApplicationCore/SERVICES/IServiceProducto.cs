using Infraestucture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.SERVICES
{
    public interface IServiceProducto
    {
        IEnumerable<Producto> GetProductos();
        IEnumerable<Producto> GetProductosById(int idProducto);
        Producto GetProductoById(int id);
        Producto GetProductoByCodigo(int id);
        Producto GetProductoByProveedor(int id);
        Producto GetProductoByMarca(String marca);
        Producto GetProductoByNombreProducto(String nombre);
        Producto save(Producto producto);
        void DeleteProducto(int id);
    }
}
