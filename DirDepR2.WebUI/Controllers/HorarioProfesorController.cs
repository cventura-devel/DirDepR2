using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DirDepR2.Domain.Abstract;
using DirDepR2.Domain.Entities;
using DirDepR2.WebUI.Models;


namespace DirDepR2.WebUI.Controllers
{
    public class HorarioProfesorController : Controller
    {
         private IStoreProcedures storeProcedure;
        private IProfesorRepository profesorRepository;

        public HorarioProfesorController(IStoreProcedures storeP, IProfesorRepository repo)
        {
            storeProcedure = storeP;
            profesorRepository = repo;
        }
        
        // GET: HorarioProfesor
        public ActionResult Index()
        {
            return View();
        }


        public ViewResult Horario(string nomina)
        {
            HorarioProfesorViewModel horarioProfesor = new HorarioProfesorViewModel
            {
                Horario = storeProcedure.regresaHorarioProfesor(nomina.Trim()),
                Profesor = profesorRepository.Profesors.FirstOrDefault(p => p.Nomina == nomina.Trim())

            };
            return View(horarioProfesor);
        }
        


    }
}