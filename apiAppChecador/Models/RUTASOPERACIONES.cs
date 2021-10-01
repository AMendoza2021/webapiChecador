namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FABRICACION.RUTASOPERACIONES")]
    public partial class RUTASOPERACIONES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RUTASOPERACIONES()
        {
            RUTASOPERACIONESDETALLE = new HashSet<RUTASOPERACIONESDETALLE>();
        }

        [Key]
        public int IDRuta { get; set; }

        public int IDEmpresa { get; set; }

        public int IDSucursal { get; set; }

        public int? IDProducto { get; set; }

        public int? IDProductoFabricacion { get; set; }

        public int? IDProductoAcondicionamiento { get; set; }

        [StringLength(50)]
        public string Clave { get; set; }

        [StringLength(500)]
        public string Descripcion { get; set; }

        public int IDUsuario { get; set; }

        public DateTime? Fecha { get; set; }

        public int IDUsuarioActualizo { get; set; }

        public DateTime? FechaActualizo { get; set; }

        public bool? Activo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RUTASOPERACIONESDETALLE> RUTASOPERACIONESDETALLE { get; set; }
    }
}
