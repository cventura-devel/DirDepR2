using System.Collections.Generic;
using DirDepR2.Domain.Entities;


namespace DirDepR2.Domain.Abstract
{
    public interface ICursoRepository
    {
        IEnumerable<Curso> Cursos { get; }
        void SaveCurso(Curso curso);
        Curso DeleteCurso(int ID);
    }
}
