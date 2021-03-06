﻿using System.Collections.Generic;
using DirDepR2.Domain.Entities;

namespace DirDepR2.Domain.Abstract
{
    public interface IMateriaRepository
    {
        IEnumerable<Materia> Materias { get; }
        void SaveMateria(Materia materia);
        Materia DeleteMateria(int ID);
    }
}
