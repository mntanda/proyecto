using Infraestucture.Models;
using Infraestucture.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.SERVICES
{
   public class ServiceProducto : IServiceProducto
    {
        public void DeleteProducto(int id)
        {
            throw new NotImplementedException();
        }

        public Producto GetProductoByCodigo(int id)
        {
            throw new NotImplementedException();
        }

        public Producto GetProductoById(int id)
        {
            IRepositorioProducto repository = new repositorioProducto();
            return repository.GetProductoById(id);
        }

        public Producto GetProductoByMarca(string marca)
        {
            throw new NotImplementedException();
        }

        public Producto GetProductoByNombreProducto(string nombre)
        {
            throw new NotImplementedException();
        }

        public Producto GetProductoByProveedor(int id)
        {
            IRepositorioProducto repository = new repositorioProducto();
            return repository.GetProductoByProveedor(id);
        }

        public IEnumerable<Producto> GetProductos()
        {
            IRepositorioProducto repositoryProducto = new repositorioProducto();
            return repositoryProducto.GetProductos();
        }

        public IEnumerable<Producto> GetProductosById(int idProducto)
        {
            IRepositorioProducto repositoryProducto = new repositorioProducto();
            return repositoryProducto.GetProductosById(idProducto);
        }

        public Producto save(Producto producto)
        {
            throw new NotImplementedException();
        }
    }
}
