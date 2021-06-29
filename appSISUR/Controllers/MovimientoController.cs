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
    public class MovimientoController : Controller
    {
        // GET: Movimiento
        public ActionResult Index()
        {
            IEnumerable<movimientoTipo> lista = null;
            try
            {
                IServiceMovimiento _ServiceMovimiento = new ServiceMovimiento();
                lista = _ServiceMovimiento.GetMovimientoTipo();
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