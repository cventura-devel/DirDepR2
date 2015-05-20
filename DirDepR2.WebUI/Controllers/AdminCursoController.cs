using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DirDepR2.Domain.Abstract;
using DirDepR2.Domain.Entities;

namespace DirDepR2.WebUI.Controllers
{
    public class AdminCursoController : Controller
    {

        private ICursoRepository repository;
        private IMateriaRepository materiaRepository;
        private IProfesorRepository profesorRepository;
        public AdminCursoController(ICursoRepository repo, IMateriaRepository repoM, IProfesorRepository repoP)
        {
            repository = repo;
            materiaRepository = repoM;
            profesorRepository = repoP;
        }


        public ActionResult Index()
        {
             return View(repository.Cursos);
        }

        public ViewResult Edit(int ID)
        {
            Curso curso = repository.Cursos.FirstOrDefault(p => p.ID == ID);
            PopulateMateriasDropDownList(curso.IDMateria);
            PopulateProfesorsDropDownList(curso.IDProfesor);
            return View(curso);
        }


        private void PopulateMateriasDropDownList(object selectedMateria = null)
        {
            var materiasQuery = materiaRepository.Materias;
            ViewData["Materias"] = new SelectList(materiasQuery,"ID","Nombre",selectedMateria);

        }

        private void PopulateProfesorsDropDownList(object selectedProfesor = null)
        {
            var profesorQuery = profesorRepository.Profesors;
            ViewData["Profesores"] = new SelectList(profesorQuery,"ID","Nombre",selectedProfesor);
         }

    }
}