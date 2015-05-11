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
    public class EvaluacionExtraController : Controller
    {

        private IStoreProcedures storeProcedure;
        private IProfesorRepository profesorRepository;

        public EvaluacionExtraController(IStoreProcedures storeP, IProfesorRepository repo)
        {
            storeProcedure = storeP;
            profesorRepository = repo;
        }


        public ActionResult Index()
        {
            return View();
        }

        public ViewResult ListaPorProfesor(string nomina)
        {
            PuntosExtraViewModel puntosExtra = new PuntosExtraViewModel
            {
                PuntosExtra = storeProcedure.regresaPuntosExtras(nomina),
                Profesor = profesorRepository.Profesors.FirstOrDefault(p => p.Nomina==nomina)
                
            };
            return View(puntosExtra);
        }


    }
}