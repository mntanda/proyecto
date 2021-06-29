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
    public class PosicionController : Controller
    {
        // GET: CPosicion
        public ActionResult Index()
        {
            IEnumerable<posicion> lista = null;
            try
            {
                IServicePosicion _ServicePosicion = new ServicePosicion();
                lista = _ServicePosicion.GetPsicion();
            }
            catch (Exception ex)
            {
                //using web utils
                Log.Error(ex, MethodBase.GetCurrentMethod());
            }
            ViewBag.titulo = "Listado de Productos";
            return View(lista);
        }
        public ActionResult IndexAdmin()
        {
            IEnumerable<posicion> lista = null;
            try
            {
                IServicePosicion _ServicePosicion = new ServicePosicion();
                lista = _ServicePosicion.GetPsicion();
            }
            catch (Exception ex)
            {
                //using web utils
                Log.Error(ex, MethodBase.GetCurrentMethod());
            }
            return View(lista);
        }


        // GET: CPosicion/Details/5
        public ActionResult Details(int? id)
        {
            ServicePosicion _ServicePosicion = new ServicePosicion();
            posicion Posicion = null;

            try
            {
                // Si va null
                if (id == null)
                {
                    return RedirectToAction("Index");
                }

                Posicion = _ServicePosicion.getDetalleById(id.Value);
                if (Posicion == null)
                {
                    TempData["Message"] = "No existe el Posicion solicitado";
                    TempData["Redirect"] = "Posicion";
                    TempData["Redirect-Action"] = "IndexAdmin";
                    // Redireccion a la captura del Error
                    return RedirectToAction("Default", "Error");
                }
                return View(Posicion);
            }
            catch (Exception ex)
            {
                // Salvar el error en un archivo 
                Log.Error(ex, MethodBase.GetCurrentMethod());
                TempData["Message"] = "Error al procesar los datos! " + ex.Message;
                TempData["Redirect"] = "Posicion";
                TempData["Redirect-Action"] = "IndexAdmin";
                // Redireccion a la captura del Error
                return RedirectToAction("Default", "Error");
            }
        }

        // GET: CPosicion/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CPosicion/Create
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

        // GET: CPosicion/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CPosicion/Edit/5
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

        // GET: CPosicion/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CPosicion/Delete/5
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
