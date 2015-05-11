using System.Collections.Generic;
using DirDepR2.Domain.Entities;


namespace DirDepR2.Domain.Abstract
{
    public interface IProfesorRepository
    {
        IEnumerable<Profesor> Profesors { get; }
    }
}
