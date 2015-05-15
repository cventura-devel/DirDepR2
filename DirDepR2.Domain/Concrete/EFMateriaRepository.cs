using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DirDepR2.Domain.Abstract;
using DirDepR2.Domain.Entities;


namespace DirDepR2.Domain.Concrete
{
    public class EFMateriaRepository:IMateriaRepository
    {
        private dbContext context = new dbContext();
        public IEnumerable<Materia> Materias
        {
            get { return context.Materias; }
        }

        public void SaveMateria(Materia materia)
        {
            if (materia.ID == 0)
            {
                context.Materias.Add(materia);
            }
            else
            {
                Materia dbEntry = context.Materias.Find(materia.ID);
                if (dbEntry != null)
                {
                    dbEntry.ClaveMateria = materia.ClaveMateria;
                    dbEntry.Nombre = materia.Nombre;
                    dbEntry.Unidades = materia.Unidades;
                    dbEntry.Lab = materia.Lab;
                    dbEntry.Nivel = materia.Nivel;
                }
            }
            context.SaveChanges();
        }

        public Materia DeleteMateria(int ID)
        {
            Materia dbEntry = context.Materias.Find(ID);
            if (dbEntry != null)
            {
                context.Materias.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }


    
    }
}
