using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DirDepR2.Domain.Abstract;
using DirDepR2.Domain.Entities;

namespace DirDepR2.Domain.Concrete
{
    public class EFStoreProcedure:IStoreProcedures
    {
        private dbContext context = new dbContext();
        
        public IEnumerable<RegresaPuntosExtras_Result> regresaPuntosExtras(string nomina)
        {
            return context.RegresaPuntosExtras(nomina);
        }

        public IEnumerable<RegresaHorarioProfesor_Result> regresaHorarioProfesor(string nomina)
        {
            return context.RegresaHorarioProfesor(nomina);
        }
    }
}
