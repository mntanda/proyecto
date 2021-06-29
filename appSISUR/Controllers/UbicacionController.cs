using ApplicationCore.SERVICES;
using appSISUR.Utils;
using Infraestucture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace appSISUR.Controllers
{
    public class UbicacionController : Controller
    {
        // GET: Ubicacion
        public ActionResult Index()
        {
            IEnumerable<Ubicacion> lista = null;
            try
            {
                IServiceUbicacion _ServiceUbicacion = new ServiceUbicacion();
                lista = _ServiceUbicacion.GetUbicacion();
            }
            catch (Exception ex)
            {
                //using web utils
                Log.Error(ex, MethodBase.GetCurrentMethod());
            }
            return View(lista);
        }
    }
}