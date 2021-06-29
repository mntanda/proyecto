using ApplicationCore.Services;
using appSISUR.Utils;
using Infraestucture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Util;

namespace appSISUR.Controllers
{
    public class RolController : Controller
    {
        // GET: Rol
        public ActionResult Index()
        {

            IEnumerable<Rol> lista = null;
            try
            {
                IServiceRol _ServiceRol = new ServiceRol();
                lista = _ServiceRol.GetRol();
            }
            catch (Exception ex)
            {
                //using web utils
                Log.Error(ex, MethodBase.GetCurrentMethod());
            }
            return View(lista);
        }


        public ActionResult Details(int? id)
        {
            ServiceRol _ServiceRol = new ServiceRol();
            Rol Rol = null;

            try
            {
                // Si va null
                if (id == null)
                {
                    return RedirectToAction("Index");
                }

                Rol = _ServiceRol.GetRolById(id.Value);    
                if (Rol == null)
                {
                    TempData["Message"] = "No existe el Rol solicitado";
                    TempData["Redirect"] = "Rol";
                    TempData["Redirect-Action"] = "Index";
                    // Redireccion a la captura del Error
                    return RedirectToAction("Default", "Error");
                }
                return View(Rol);
            }
            catch (Exception ex)
            {
                // Salvar el error en un archivo 
                Log.Error(ex, MethodBase.GetCurrentMethod());
                TempData["Message"] = "Error al procesar los datos! " + ex.Message;
                TempData["Redirect"] = "Rol";
                TempData["Redirect-Action"] = "Index";
                // Redireccion a la captura del Error
                return RedirectToAction("Default", "Error");
            }
        }

    }
}