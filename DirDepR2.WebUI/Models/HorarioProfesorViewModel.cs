using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DirDepR2.Domain.Entities;

namespace DirDepR2.WebUI.Models
{
    public class HorarioProfesorViewModel
    {
        public IEnumerable<RegresaHorarioProfesor_Result> Horario { set; get; }
        public Profesor Profesor { set; get; }
    }
}