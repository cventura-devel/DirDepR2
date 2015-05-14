using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DirDepR2.Domain.Abstract;
using DirDepR2.Domain.Entities;

namespace DirDepR2.WebUI.Controllers
{
    public class AdminProfesorController : Controller
    {
        private IProfesorRepository repository;

        public AdminProfesorController(IProfesorRepository repo)
        {
            repository = repo;
        }

        public ActionResult Index()
        {
            return View(repository.Profesors);
        }

        public ViewResult Edit(int ID)
        {
            Profesor profesor = repository.Profesors.FirstOrDefault(p => p.ID == ID);
            return View(profesor);
        }

        [HttpPost]
        public ActionResult Edit(Profesor profesor)
        {
            if (ModelState.IsValid)
            {
                repository.SaveProfesor(profesor);
                TempData["message"] = string.Format("{0} has been saved", profesor.Nombre);
                return RedirectToAction("Index");
            }
            else
                return View(profesor);
        }

        public ViewResult Create()
        {
            return View("Edit", new Profesor());
        }

        [HttpPost]
        public ActionResult Delete(int ID)
        {
            Profesor deleteProfesor = repository.DeleteProfesor(ID);
            if(deleteProfesor != null)
            {
                TempData["message"] = string.Format("{0} was deleted", deleteProfesor.Nombre);
            }
            return RedirectToAction("Index");
        }

    }
}