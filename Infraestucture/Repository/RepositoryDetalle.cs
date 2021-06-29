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
    public class RepositoryDetalle : IRepositoryDetalle
    {
        public detalleMovimiento GetDetalleMovimientoByCliente(int cedulaCliente)
        {
            throw new NotImplementedException();
        }

        public detalleMovimiento GetDetalleMovimientoByConsecutivo(int consecutivo)
        {
            detalleMovimiento oEncabezado = null;
            using (MyContext ctx = new MyContext())
            {
                ctx.Configuration.LazyLoadingEnabled = false;
                oEncabezado = ctx.detalleMovimiento.Where(x => x.consMovimiento == consecutivo).
                        Include(x => x.encabezadoMovimiento).Include(x => x.Producto).Include(x => x.posicion.Ubicacion).Include(x => x.encabezadoMovimiento.Persona).Include(x => x.encabezadoMovimiento.Proveedor).Include(x => x.encabezadoMovimiento.movimientoTipo).
                FirstOrDefault();
            }
            return oEncabezado;
        }

        public detalleMovimiento GetDetalleMovimientoByEmpleado(int empleado)
        {
            throw new NotImplementedException();
        }

        public detalleMovimiento GetDetalleMovimientoByFecha(string fecha)
        {
            throw new NotImplementedException();
        }

        public detalleMovimiento GetDetalleMovimientoByPersona(int idPersona)
        {
            throw new NotImplementedException();
        }

        public detalleMovimiento GetDetalleMovimientoByProveedor(int cedulaProveedor)
        {
            throw new NotImplementedException();
        }

        public detalleMovimiento GetDetalleMovimientoByTipo(int tipo)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<detalleMovimiento> GetDetalleMovimientos()
        {
            try
            {
                IEnumerable<detalleMovimiento> lista = null;
                using (MyContext ctx = new MyContext())
                {
                    ctx.Configuration.LazyLoadingEnabled = false;
                    //select * from rol
                    lista = ctx.detalleMovimiento.
                        Include(x => x.encabezadoMovimiento).Include(x => x.Producto).Include(x => x.posicion.Ubicacion).Include(x => x.encabezadoMovimiento.Persona).Include(x => x.encabezadoMovimiento.Proveedor).Include(x => x.encabezadoMovimiento.movimientoTipo).
                        ToList();
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
