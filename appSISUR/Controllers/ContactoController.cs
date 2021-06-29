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
    public class ContactoController : Controller
    {
        // GET: Contacto
        public ActionResult Index()
        {
            IEnumerable<Contacto> lista = null;
            try
            {
                IServiceContacto _ServiceContacto = new ServiceContacto();
                lista = _ServiceContacto.GetContacto();
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
            ServiceContacto _ServiceContacto = new ServiceContacto();
            Contacto Contacto = null;

            try
            {
                // Si va null
                if (id == null)
                {
                    return RedirectToAction("Index");
                }

                Contacto = _ServiceContacto.GetContactoByProducto(id.Value);
                if (Contacto == null)
                {
                    TempData["Message"] = "No existe el Contacto solicitado";
                    TempData["Redirect"] = "Contacto";
                    TempData["Redirect-Action"] = "Index";
                    // Redireccion a la captura del Error
                    return RedirectToAction("Default", "Error");
                }
                ViewBag.Titulo = "Detalle de Contacto";
                return View(Contacto);
            }
            catch (Exception ex)
            {
                // Salvar el error en un archivo 
                Log.Error(ex, MethodBase.GetCurrentMethod());
                TempData["Message"] = "Error al procesar los datos! " + ex.Message;
                TempData["Redirect"] = "Contacto";
                TempData["Redirect-Action"] = "IndexAdmin";
                // Redireccion a la captura del Error
                return RedirectToAction("Default", "Error");
            }
        }
    }
}