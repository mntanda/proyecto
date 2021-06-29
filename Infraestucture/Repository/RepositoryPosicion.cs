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
    public class RepositoryPosicion : IRepositoryPosicion
    {
        public posicion getDetalleByCodigo(int cod)
        {
            posicion oPosicion = null;
            using (MyContext ctx = new MyContext())
            {
                ctx.Configuration.LazyLoadingEnabled = false;
                oPosicion = ctx.posicion.Where(x => x.Producto.codProducto == cod)
                    .FirstOrDefault();
            }
            return oPosicion;
        }

        public posicion getDetalleByEstado(int estado)
        {
            throw new NotImplementedException();
        }


        //este es mi gallo!!!
        public posicion getDetalleById(int id)
        {
            posicion oPosicion = null;
            using (MyContext ctx = new MyContext())
            {
                ctx.Configuration.LazyLoadingEnabled = false;
                oPosicion = ctx.posicion.Where(x => x.idUbicacion  == id).Include(x => x.Ubicacion).Include(x => x.Producto).Include(x => x.Producto.Marca).Include(x => x.Producto.Contacto)
                    .FirstOrDefault();
            }
            return oPosicion;
        }

        public posicion getDetalleByUbicacion(string ubicacion)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<posicion> GetPosicionById(int idPosicion)
        {
            IEnumerable<posicion> lista = null;
            using (MyContext ctx = new MyContext())
            {
                ctx.Configuration.LazyLoadingEnabled = false;
                lista = ctx.posicion.Where(x => x.idUbicacion == idPosicion).Include(x => x.Ubicacion).Include(x => x.Producto).
                   // Include(x => x.Producto.descripcionProducto).Include(x => x.Producto.Marca).Include(x => x.Ubicacion.descUbicacion).
                    ToList();
            }
            return lista;
        }

        public IEnumerable<posicion> GetPsicion()
        {
            try
            {
                IEnumerable<posicion> lista = null;
                using (MyContext ctx = new MyContext())
                {
                    ctx.Configuration.LazyLoadingEnabled = false;
                    //select * from rol
                    lista = ctx.posicion.Include(x => x.Ubicacion).Include(x=>x.Producto).ToList();
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
    }
}
