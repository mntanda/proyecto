using Infraestucture.Models;
using Infraestucture.Utils;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestucture.Repository
{
   public class repositorioProducto : IRepositorioProducto
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
            Producto oProducto = null;
            using (MyContext ctx = new MyContext())
            {
                ctx.Configuration.LazyLoadingEnabled = false;
                oProducto = ctx.Producto.
                    Where(l => l.idProducto == id).Include(l => l.Marca).Include(l => l.Contacto).
                            FirstOrDefault();
            }
            return oProducto;
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
            Producto oProducto = null;
            using (MyContext ctx = new MyContext())
            {
                ctx.Configuration.LazyLoadingEnabled = false;
                oProducto = ctx.Producto.
                    Where(l => l.codProveedor == id).Include(l => l.Marca).Include(l => l.Contacto).
                            FirstOrDefault();
            }
            return oProducto;
        }

        public IEnumerable<Producto> GetProductos()
        {
            try
            {
                IEnumerable<Producto> lista = null;
                using (MyContext ctx = new MyContext())
                {
                    ctx.Configuration.LazyLoadingEnabled = false;
                    //select * from rol
                    lista = ctx.Producto.Include(x =>x.Marca).ToList();
                }
                return lista;
            }
            catch (DbUpdateException dbEx)
            {
                string mensaje = "";
                Log.Error(dbEx, System.Reflection.MethodBase.GetCurrentMethod(), ref mensaje);
                throw new Exception(mensaje);
            }
            catch (Exception ex)
            {
                string mensaje = "";
                Log.Error(ex, System.Reflection.MethodBase.GetCurrentMethod(), ref mensaje);
                throw;
            }
        }

        public IEnumerable<Producto> GetProductosById(int idProducto)
        {
            IEnumerable<Producto> lista = null;
            using (MyContext ctx = new MyContext())
            {
                ctx.Configuration.LazyLoadingEnabled = false;
                lista = ctx.Producto.Where(l => l.idProducto == idProducto).Include(l => l.Marca).Include(l => l.posicion).Include(l => l.Contacto).
                    ToList();
            }
            return lista;
        }

        public Producto save(Producto producto)
        {
            throw new NotImplementedException();
        }
    }
}
