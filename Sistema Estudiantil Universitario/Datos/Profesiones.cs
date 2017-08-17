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
    using DataAnnotationsExtensions;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Profesiones
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Profesiones()
        {
            this.Docentes = new HashSet<Docentes>();
        }

        public int Id { get; set; }

        public string Codigo { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "* Requerido")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "* Debe ser mayor a 0 meses ")]
        public string Profesion { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "* Requerido")]
        [Min(1, ErrorMessage = "* Debe ser mayor a 0")]
        public decimal Duracion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Docentes> Docentes { get; set; }
    }
}
