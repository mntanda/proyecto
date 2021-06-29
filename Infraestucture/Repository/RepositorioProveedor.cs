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
   public class RepositorioProveedor : IRepositorioProveedor
    {
        public IEnumerable<Proveedor> GetProveedor()
        {
            try
            {
                IEnumerable<Proveedor> lista = null;
                using (MyContext ctx = new MyContext())
                {
                    ctx.Configuration.LazyLoadingEnabled = false;
                    //select * from rol
                    lista = ctx.Proveedor.ToList<Proveedor>();
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

        public Proveedor GetProveedorByCodigo(int codigo)
        {
            throw new NotImplementedException();
        }

        public Proveedor GetProveedorByestado(int estado)
        {
            throw new NotImplementedException();
        }

        public Proveedor GetProveedorById(int Id)
        {
            Proveedor oProveedor = null;
            using (MyContext ctx = new MyContext())
            {
                ctx.Configuration.LazyLoadingEnabled = false;
                oProveedor = ctx.Proveedor.Where(x => x.idProveedor == Id).Include(x => x.Contacto)
                    .FirstOrDefault();
            }
            return oProveedor;
        }

        public Proveedor GetProveedorByNombre(string nombre)
        {
            throw new NotImplementedException();
        }
    }
}
