using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DirDepR2.WebUI.Models
{
    public class PagingInfo
    {
        public int TotalProfesors { get; set; }
        public int ProfesorsPerPage { get; set; }
        public int CurrentPage { get; set; }

        public int TotalPages
        {
            get { return (int)Math.Ceiling((decimal)TotalProfesors / ProfesorsPerPage); }
        }
    }
}