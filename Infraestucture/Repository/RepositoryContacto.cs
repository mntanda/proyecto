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
    public class RepositoryContacto : IRepositoryContacto
    {
        public void DeleteContacto(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Contacto> GetContacto()
        {
            try
            {
                IEnumerable<Contacto> lista = null;
                using (MyContext ctx = new MyContext())
                {
                    ctx.Configuration.LazyLoadingEnabled = false;
                    //select * from rol
                    lista = ctx.Contacto.Include(x=>x.Persona).Include(x=>x.Producto).Include(x=> x.Proveedor).ToList();
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
      

        public Contacto GetContactoByProducto(int id)
        {
            Contacto oContacto = null;
            using (MyContext ctx = new MyContext())
            {
                ctx.Configuration.LazyLoadingEnabled = false;
                oContacto = ctx.Contacto.Where(x => x.codProducto == id).
                    Include(x => x.Producto).Include(x => x.Proveedor).Include(x => x.Persona).
                    FirstOrDefault();
            }
            return oContacto;
        }

        public Contacto GetContactoByProveedor(int id)
        {
            Contacto oPosicion = null;
            using (MyContext ctx = new MyContext())
            {
                ctx.Configuration.LazyLoadingEnabled = false;
                oPosicion = ctx.Contacto.Where(x => x.idProveedor  == id)
                   // .Include(x => x. Ubicacion).Include(x => x.Producto).Include(x => x.Producto.Marca).Include(x => x.Producto.Contacto)
                    .FirstOrDefault();
            }
            return oPosicion;
        }

        public Contacto Save(Contacto contacto)
        {
            throw new NotImplementedException();
        }
    }
}
