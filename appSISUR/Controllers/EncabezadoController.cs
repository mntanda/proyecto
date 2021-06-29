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
    public class EncabezadoController : Controller
    {
        // GET: Encabezado
        public ActionResult Index()
        {
            IEnumerable<encabezadoMovimiento> lista = null;
            try
            {
                IServicoEncabezado _ServiceEncabezado = new ServicioEncabezado();
                lista = _ServiceEncabezado.GetEncabezadoMovimientos();
            }
            catch (Exception ex)
            {
                //using web utils
                Log.Error(ex, MethodBase.GetCurrentMethod());
            }
            ViewBag.Titulo = "Transacciones";
            return View(lista);
        }

        public ActionResult Details(int? id)
        {
            ServicioEncabezado _ServiceEncabezado = new ServicioEncabezado();
            encabezadoMovimiento oEncabezado = null;

            try
            {
                // Si va null
                if (id == null)
                {
                    return RedirectToAction("Index");
                }

                oEncabezado = _ServiceEncabezado.GetMovimientoByConsecutivo(id.Value);
                if (id == null)
                {
                    TempData["Message"] = "No existe el Encabezado solicitado";
                    TempData["Redirect"] = "Encabezado";
                    TempData["Redirect-Action"] = "IndexAdmin";
                    // Redireccion a la captura del Error
                    return RedirectToAction("Default", "Error");
                }
                ViewBag.Titulo = "Detalle Transacciones";
                return View(oEncabezado);
            }
            catch (Exception ex)
            {
                // Salvar el error en un archivo 
                Log.Error(ex, MethodBase.GetCurrentMethod());
                TempData["Message"] = "Error al procesar los datos! " + ex.Message;
                TempData["Redirect"] = "Encabezado";
                TempData["Redirect-Action"] = "IndexAdmin";
                // Redireccion a la captura del Error
                return RedirectToAction("Default", "Error");
            }
        }



    }
}