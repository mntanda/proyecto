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
    public class DetalleController : Controller
    {
        // GET: Detalle
        public ActionResult Index()
        {
            IEnumerable<detalleMovimiento> lista = null;
            try
            {
                IServiceDetalle _ServiceDetalle = new ServiceDetalle();
                lista = _ServiceDetalle.GetDetalleMovimientos();
            }
            catch (Exception ex)
            {
                //using web utils
                Log.Error(ex, MethodBase.GetCurrentMethod());
            }
            ViewBag.Titulo = "Transacciones";
            return View(lista);
        }

        // GET: Detalle/Details/5
        public ActionResult Details(int? id)
        {
            ServiceDetalle _ServiceDetalle = new ServiceDetalle();
            detalleMovimiento oDetalle = null;

            try
            {
                // Si va null
                if (id == null)
                {
                    return RedirectToAction("Index");
                }

                oDetalle = _ServiceDetalle.GetDetalleMovimientoByConsecutivo(id.Value);
                if (id == null)
                {
                    TempData["Message"] = "No existe el Encabezado solicitado";
                    TempData["Redirect"] = "Encabezado";
                    TempData["Redirect-Action"] = "IndexAdmin";
                    // Redireccion a la captura del Error
                    return RedirectToAction("Default", "Error");
                }
                ViewBag.Titulo = "Detalle Movimientos";
                return View(oDetalle);
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

        // GET: Detalle/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Detalle/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Detalle/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Detalle/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Detalle/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Detalle/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
