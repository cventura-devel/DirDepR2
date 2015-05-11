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
    public class ProfesorController : Controller
    {
        private IProfesorRepository repository;
        public int PageSize = 4;

        public ProfesorController(IProfesorRepository profesorRepository)
        {
            this.repository = profesorRepository;
        }

        public ViewResult List(int page = 1)
        {
            ProfesorsListViewModel model = new ProfesorsListViewModel
            {
                Profesors = repository.Profesors.OrderBy(p => p.ID).Skip((page - 1) * PageSize).Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ProfesorsPerPage = PageSize,
                    TotalProfesors = repository.Profesors.Count()
                }
            };
            
            
            return View(model);
        }

    }
}