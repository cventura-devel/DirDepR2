//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DirDepR2.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Alumno
    {
        public Alumno()
        {
            this.PuntosExtras = new HashSet<PuntosExtra>();
        }
    
        public int ID { get; set; }
        public string Matricula { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Carrera { get; set; }
    
        public virtual ICollection<PuntosExtra> PuntosExtras { get; set; }
    }
}
