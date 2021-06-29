﻿using Infraestucture.Models;
using Infraestucture.Utils;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestucture.Repository
{
   public class RepositorioUbicacion : IRepositorioUbicacion
    {
        public IEnumerable<Ubicacion> GetUbicacion()
        {
            try
            {
                IEnumerable<Ubicacion> lista = null;
                using (MyContext ctx = new MyContext())
                {
                    ctx.Configuration.LazyLoadingEnabled = false;
                    //select * from rol
                    lista = ctx.Ubicacion.ToList<Ubicacion>();
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

        public Ubicacion GetUbicacionByEstado(int estado)
        {
            throw new NotImplementedException();
        }

        public Ubicacion GetUbicacionByName(string ubicacion)
        {
            throw new NotImplementedException();
        }
    }
}
