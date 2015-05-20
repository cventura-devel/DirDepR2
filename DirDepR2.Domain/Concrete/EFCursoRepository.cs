using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DirDepR2.Domain.Abstract;
using DirDepR2.Domain.Entities;
using System.Data.Entity;

namespace DirDepR2.Domain.Concrete
{
    public class EFCursoRepository:ICursoRepository
    {
        private dbContext context = new dbContext();
        public IEnumerable<Curso> Cursos
        {
            get { return context.Cursoes.Include(m => m.Materia).Include(n => n.Profesor); }
        }

        public void SaveCurso(Curso curso)
        {
            if (curso.ID == 0)
            {
                context.Cursoes.Add(curso);
            }
            else
            {
                Curso dbEntry = context.Cursoes.Find(curso.ID);
                if (dbEntry != null)
                {
                    dbEntry.CRN = curso.CRN;
                    dbEntry.Cupo= curso.Cupo;
                    dbEntry.IDMateria = curso.IDMateria;
                    dbEntry.IDProfesor = curso.IDProfesor;
                    dbEntry.Inscritos = curso.Inscritos;
                    dbEntry.Periodo = curso.Periodo;
                    dbEntry.Grupo = curso.Grupo;
                }
            }
            context.SaveChanges();
        }

        public Curso DeleteCurso(int ID)
        {
            Curso dbEntry = context.Cursoes.Find(ID);
            if (dbEntry != null)
            {
                context.Cursoes.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }

    
    
    }
}
