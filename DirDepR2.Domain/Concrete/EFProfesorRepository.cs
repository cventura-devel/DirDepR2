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

        public void SaveProfesor(Profesor profesor)
        {
            if(profesor.ID  == 0)
            {
                context.Profesors.Add(profesor);
            }
            else
            {
                Profesor dbEntry = context.Profesors.Find(profesor.ID);
                if (dbEntry != null)
                {
                    dbEntry.Nomina = profesor.Nomina;
                    dbEntry.Nombre = profesor.Nombre;
                    dbEntry.ApellidoPaterno = profesor.ApellidoPaterno;
                    dbEntry.ApellidoMaterno = profesor.ApellidoMaterno;
                    dbEntry.Correo = profesor.Correo;
                    dbEntry.Departamento = profesor.Departamento;
                }
            }
            context.SaveChanges();
        }

        public Profesor DeleteProfesor(int ID)
        {
            Profesor dbEntry = context.Profesors.Find(ID);
            if(dbEntry != null)
            {
                context.Profesors.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }


    }
}
