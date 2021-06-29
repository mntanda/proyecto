using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestucture.Models
{
   internal partial class posicionMetadata
    {
        [Display(Name="Identificador Ubicación")]
        public int idUbicacion { get; set; }

        [Display(Name = "Código Producto")]
        public int codProducto { get; set; }

        [Display(Name = "Cantidad")]
        public int cantidad { get; set; }

        [Display(Name = "Estado")]
        public int estado { get; set; }

        public virtual ICollection<detalleMovimiento> detalleMovimiento { get; set; }

        [Display(Name = "Producto")]
        public virtual Producto Producto { get; set; }

        [Display(Name = "Ubicación")]
        public virtual Ubicacion Ubicacion { get; set; }
    }

    internal partial class productoMetadata
    {
        [Display(Name = "Id. Producto")]
        public int idProducto { get; set; }

        [Display(Name = "Código")]
        public int codProducto { get; set; }

        [Display(Name = "Cod. Proveedor")]
        public int codProveedor { get; set; }

        [Display(Name = "Id Marca")]
        public int idMarca { get; set; }

        [Display(Name = "Nombre Producto")]
        public string descripcionProducto { get; set; }

        [Display(Name = "Modelo")]
        public string modeloProducto { get; set; }

        [Display(Name = "Cantidad Maxima")]
        public int cantMaxima { get; set; }

        [Display(Name = "Cantidad Minima")]
        public int cantMinima { get; set; }

        [Display(Name = "Precio")]
        public int costo { get; set; }

        [Display(Name = "Estado")]
        public int estado { get; set; }

        [Display(Name = "Contacto")]
        public virtual ICollection<Contacto> Contacto { get; set; }

        [Display(Name = "Detalle Movimiento")]
        public virtual ICollection<detalleMovimiento> detalleMovimiento { get; set; }

        [Display(Name = "Marca")]
        public virtual Marca Marca { get; set; }

        [Display(Name = "Posición")]
        public virtual ICollection<posicion> posicion { get; set; }
    }

    internal partial class ubicacionMetadata
    {
        [Display(Name = "Id Ubicación")]
        public int idUbicacion { get; set; }

        [Display(Name = "Ubicación")]
        public string descUbicacion { get; set; }

        [Display(Name = "Estado")]
        public int estado { get; set; }

        [Display(Name = "Posición")]
        public virtual ICollection<posicion> posicion { get; set; }

    }

    internal partial class personaMetadata
    {
        [Display(Name = "Código")]
        public int codPersona { get; set; }

        [Display(Name = "Id. Persona")]
        public string idPersona { get; set; }

        [Display(Name = "Rol")]
        public int idRol { get; set; }

        [Display(Name = "Nombre")]
        public string nombrePersona { get; set; }

        [Display(Name = "Dirección")]
        public string direccionPersona { get; set; }

        [Display(Name = "Teléfono")]
        public string telefonoPersona { get; set; }
     
        public string contrasena { get; set; }

        [Display(Name = "Email")]
        public string email { get; set; }

        [Display(Name = "País")]
        public string pais { get; set; }

        [Display(Name = "Estado")]
        public int estado { get; set; }

        [Display(Name = "Contacto")]
        public virtual ICollection<Contacto> Contacto { get; set; }
        public virtual ICollection<encabezadoMovimiento> encabezadoMovimiento { get; set; }
        public virtual ICollection<encabezadoMovimiento> encabezadoMovimiento1 { get; set; }
        [Display(Name = "Rol")]
        public virtual Rol Rol { get; set; }
    }

    internal partial class marcaMetadata
    {
        [Display(Name = "Id Marca")]
        public int idMarca { get; set; }

        [Display(Name = "Marca")]
        public string nombreMarca { get; set; }

        [Display(Name = "Estado")]
        public int estado { get; set; }

        [Display(Name = "Producto")]
        public virtual ICollection<Producto> Producto { get; set; }
    }

    internal partial class proveedorMetadata
    {
        [Display(Name = "Id Proveedor")]
        public int idProveedor { get; set; }

        [Display(Name = "Código Proveedor")]
        public int codProveedor { get; set; }

        [Display(Name = "Proveedor")]
        public string nombreProveedor { get; set; }

        [Display(Name = "Dirección")]
        public string direccion { get; set; }

        [Display(Name = "País")]
        public string pais { get; set; }

        [Display(Name = "Estado")]
        public int estado { get; set; }

        [Display(Name = "Contacto")]
        public virtual ICollection<Contacto> Contacto { get; set; }

        [Display(Name = "Encabezado")]
        public virtual ICollection<encabezadoMovimiento> encabezadoMovimiento { get; set; }
    }

    internal partial class encabezadoMetadata
    {
        [Display(Name = "N° Movimiento")]
        public int consMovimiento { get; set; }

        [Display(Name = "Id Tipo Movimiento")]
        public int idMovimientoTipo { get; set; }

        [Display(Name = "Id Persona")]
        public string idPersona { get; set; }

        [Display(Name = "Cod. Proveedor")]
        public Nullable<int> codProveedor { get; set; }

        [Display(Name = " Id Empleado")]
        public string idEmpleado { get; set; }

        [Display(Name = "Fecha")]
        public string fecha { get; set; }

        [Display(Name = "Documento Refrencia")]
        public string documento { get; set; }

        [Display(Name = "Estado")]
        public string estado { get; set; }

        [Display(Name = "Detalle")]
        public virtual ICollection<detalleMovimiento> detalleMovimiento { get; set; }

        [Display(Name = "Tipo de Movimiento")]
        public virtual movimientoTipo movimientoTipo { get; set; }

        [Display(Name = "Cliente")]
        public virtual Persona Persona { get; set; }

        [Display(Name = "Intermediario")]
        public virtual Persona Persona1 { get; set; }

        [Display(Name = "Casa Comercial")]
        public virtual Proveedor Proveedor { get; set; }
    }


    internal partial class movimientoTipoMetadata
    {
        [Display(Name = "N° Movimiento")]
        public int idMovimientoTipo { get; set; }

        [Display(Name = "Movimiento")]
        public string nombreMovimiento { get; set; }

        [Display(Name = "Tipo Movimiento")]
        public int Tipo { get; set; }

        [Display(Name = "Detalle Movimiento")]
        public string descTipo { get; set; }

        [Display(Name = "Estado")]
        public int estado { get; set; }

        [Display(Name = "Encabezado")]
        public virtual ICollection<encabezadoMovimiento> encabezadoMovimiento { get; set; }
    }

}
