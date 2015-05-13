using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DirDepR2.Domain.Abstract;

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
    }
}