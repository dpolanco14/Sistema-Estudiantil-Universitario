//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sistema_Estudiantil_Universitario.Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProfesionesHorarios
    {
        public int Id { get; set; }
        public int IdHorario { get; set; }
        public int IdProfesion { get; set; }
    
        public virtual Horarios Horarios { get; set; }
        public virtual Profesiones Profesiones { get; set; }
    }
}