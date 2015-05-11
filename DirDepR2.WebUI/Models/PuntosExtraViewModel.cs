using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DirDepR2.Domain.Entities;

namespace DirDepR2.WebUI.Models
{
    public class PuntosExtraViewModel
    {
        public IEnumerable<RegresaPuntosExtras_Result> PuntosExtra { set; get; }
        public Profesor Profesor { set; get; }
    }
}