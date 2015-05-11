using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DirDepR2.Domain.Entities;

namespace DirDepR2.Domain.Abstract
{
    public interface IStoreProcedures
    {
        IEnumerable<RegresaPuntosExtras_Result> regresaPuntosExtras(string nomina);
        IEnumerable<RegresaHorarioProfesor_Result> regresaHorarioProfesor(string nomina);
    }
}
