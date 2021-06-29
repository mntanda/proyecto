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
   public class RepositorioEncabezado : IRepositorioEncabezado
    {
        public IEnumerable<encabezadoMovimiento> GetEncabezadoMovimientos()
        {
            try
            {
                IEnumerable<encabezadoMovimiento> lista = null;
                using (MyContext ctx = new MyContext())
                {
                    ctx.Configuration.LazyLoadingEnabled = false;
                    //select * from rol
                    lista = ctx.encabezadoMovimiento.Include(x => x.movimientoTipo).Include(x => x.Proveedor).Include(x => x.Persona).
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

        public encabezadoMovimiento GetMovimientoByCliente(int cedulaCliente)
        {
            throw new NotImplementedException();
        }

        public encabezadoMovimiento GetMovimientoByConsecutivo(int consecutivo)
        {
            encabezadoMovimiento oEncabezado = null;
            using (MyContext ctx = new MyContext())
            {
                ctx.Configuration.LazyLoadingEnabled = false;
                oEncabezado = ctx.encabezadoMovimiento.Where(x => x.consMovimiento == consecutivo).
                    Include(x => x.movimientoTipo).Include(x => x.Proveedor).Include(x => x.Persona).Include(x => x.detalleMovimiento).
                    FirstOrDefault();
            }
            return oEncabezado;
        }

        public encabezadoMovimiento GetMovimientoByEmpleado(int empleado)
        {
            throw new NotImplementedException();
        }

        public encabezadoMovimiento GetMovimientoByFecha(string fecha)
        {
            throw new NotImplementedException();
        }

        public encabezadoMovimiento GetMovimientoByPersona(int idPersona)
        {
            throw new NotImplementedException();
        }

        public encabezadoMovimiento GetMovimientoByProveedor(int cedulaProveedor)
        {
            throw new NotImplementedException();
        }

        public encabezadoMovimiento GetMovimientoByTipo(int tipo)
        {
            throw new NotImplementedException();
        }
    }
}
