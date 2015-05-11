using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DirDepR2.Domain.Abstract;
using DirDepR2.Domain.Entities;

namespace DirDepR2.Domain.Concrete
{
    public class EFProfesorRepository:IProfesorRepository
    {
        private dbContext context = new dbContext();
        public IEnumerable<Profesor> Profesors
        {
            get { return context.Profesors; }
        }

    }
}
