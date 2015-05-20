using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DirDepR2.Domain.Entities;

namespace DirDepR2.WebUI.Models
{
    public class MateriaListViewModel
    {
        public IEnumerable<Materia> Materias { set; get; }
        public PagingInfo PagingInfo { set; get; }
    }
}