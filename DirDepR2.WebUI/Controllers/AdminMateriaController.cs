using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DirDepR2.Domain.Abstract;
using DirDepR2.Domain.Entities;

namespace DirDepR2.WebUI.Controllers
{
    public class AdminMateriaController : Controller
    {
        private IMateriaRepository repository;
        
        public AdminMateriaController(IMateriaRepository repo)
        {
            repository = repo;
        }

        public ActionResult Index(string searchString)
        {
            if(!string.IsNullOrEmpty(searchString))
            { 
            return View(repository.Materias.Where(n=>n.Nombre.Contains(searchString)||n.ClaveMateria.Contains(searchString)));
            }
            else
                return View(repository.Materias);
        }


        public ViewResult Edit(int ID)
        {
            Materia materia = repository.Materias.FirstOrDefault(p => p.ID == ID);
            return View(materia);
        }

        [HttpPost]
        public ActionResult Edit(Materia materia )
        {
            if (ModelState.IsValid)
            {
                repository.SaveMateria(materia);
                TempData["message"] = string.Format("{0} has been saved", materia.Nombre);
                return RedirectToAction("Index");
            }
            else
                return View(materia);
        }

        public ViewResult Create()
        {
            return View("Edit", new Materia());
        }

        [HttpPost]
        public ActionResult Delete(int ID)
        {
            Materia deleteMateria = repository.DeleteMateria(ID);
            if (deleteMateria != null)
            {
                TempData["message"] = string.Format("{0} was deleted", deleteMateria.Nombre);
            }
            return RedirectToAction("Index");
        }

    }
}