//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Infraestucture.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    [MetadataType(typeof(personaMetadata))]

    public partial class Persona
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Persona()
        {
            this.Contacto = new HashSet<Contacto>();
            this.encabezadoMovimiento = new HashSet<encabezadoMovimiento>();
            this.encabezadoMovimiento1 = new HashSet<encabezadoMovimiento>();
        }
    
        public int codPersona { get; set; }
        public string idPersona { get; set; }
        public int idRol { get; set; }
        public string nombrePersona { get; set; }
        public string direccionPersona { get; set; }
        public string telefonoPersona { get; set; }
        public string contrasena { get; set; }
        public string email { get; set; }
        public string pais { get; set; }
        public int estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contacto> Contacto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<encabezadoMovimiento> encabezadoMovimiento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<encabezadoMovimiento> encabezadoMovimiento1 { get; set; }
        public virtual Rol Rol { get; set; }
    }
}