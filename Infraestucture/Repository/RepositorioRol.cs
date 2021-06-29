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
   public class RepositorioRol : IRepositorioRol
    {
        public IEnumerable<Rol> GetRol()
        {
            try
            {
                IEnumerable<Rol> lista = null;
                using(MyContext ctx = new MyContext())
                {
                    ctx.Configuration.LazyLoadingEnabled = false;
                    //select * from rol
                    lista = ctx.Rol.ToList<Rol>();
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

        public Rol GetRolById(int id)
        {
            throw new NotImplementedException();
        }

        public Rol GetRolByNombre(string nombre)
        {
            throw new NotImplementedException();
        }
    }
}
