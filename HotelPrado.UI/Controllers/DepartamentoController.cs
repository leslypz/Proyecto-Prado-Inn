using HotelPrado.Abstracciones.Interfaces.LogicaDeNegocio.Departamentos.Listar;
using HotelPrado.LN.Departamentos.Listar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelPrado.UI.Controllers
{
    public class DepartamentoController : Controller
    {
        IListarDepartamentosLN _listarDepartamentos;

        public DepartamentoController() 
        {
            _listarDepartamentos = new ListarDepartamentoLN();
        }

        // GET: Departamento
        public ActionResult IndexDepartamentos()
        {
            ViewBag.Title = "La Persona";
            var laListaDeDepartamentos = _listarDepartamentos.Listar();
            return View(laListaDeDepartamentos);
        }

        // GET: Departamento/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Departamento/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Departamento/Create
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

        // GET: Departamento/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Departamento/Edit/5
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

        // GET: Departamento/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Departamento/Delete/5
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
