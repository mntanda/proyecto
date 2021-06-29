using Infraestucture.Models;
using Infraestucture.Utils;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
//esta referencia a pie
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestucture.Repository
{
    public class RepositorioPersona : IRepositorioPersona
    {
        public void DeletePersona(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Persona> GetPersona()
        {
            try
            {
                IEnumerable<Persona> lista = null;
                using (MyContext ctx = new MyContext())
                {
                    ctx.Configuration.LazyLoadingEnabled = false;
                    //select * from rol
                    lista = ctx.Persona.Include(x=>x.Rol).ToList();
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

        public Persona GetPersonaById(int id)
        {
            Persona oPersona = null;
            using (MyContext ctx= new MyContext())
            {
                ctx.Configuration.LazyLoadingEnabled = false;
                oPersona = ctx.Persona.Where(x => x.codPersona == id).FirstOrDefault();
            }
            return oPersona;
        }

        public Persona GetPersonaByNombre(string nombrePersona)
        {
            throw new NotImplementedException();
        }

        public Persona GetPersonaByRol(int rol)
        {
            throw new NotImplementedException();
        }

        public Persona Save(Persona persona)
        {
            throw new NotImplementedException();
        }
    }
}
