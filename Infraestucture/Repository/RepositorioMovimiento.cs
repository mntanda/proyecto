using Infraestucture.Models;
using Infraestucture.Utils;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestucture.Repository
{
   public class RepositorioMovimiento : IRepositorioMovimiento
    {
        public IEnumerable<movimientoTipo> GetMovimientoTipo()
        {
            try
            {
                IEnumerable<movimientoTipo> lista = null;
                using (MyContext ctx = new MyContext())
                {
                    ctx.Configuration.LazyLoadingEnabled = false;
                    //select * from rol
                    lista = ctx.movimientoTipo.ToList<movimientoTipo>();
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

        public movimientoTipo GetMovimientoTipoById(int id)
        {
            throw new NotImplementedException();
        }

        public movimientoTipo GetMovimientoTipoByTipo(int tipo)
        {
            throw new NotImplementedException();
        }
    }
}
