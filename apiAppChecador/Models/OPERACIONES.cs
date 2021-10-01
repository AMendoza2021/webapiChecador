namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FABRICACION.OPERACIONES")]
    public partial class OPERACIONES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OPERACIONES()
        {
            RUTASOPERACIONESDETALLE = new HashSet<RUTASOPERACIONESDETALLE>();
        }

        [Key]
        public int IDOperacion { get; set; }

        public int? IDEmpresa { get; set; }

        [StringLength(50)]
        public string Clave { get; set; }

        [StringLength(500)]
        public string Descripcion { get; set; }

        public int? IDUsuario { get; set; }

        public DateTime? Fecha { get; set; }

        public int? IDUsuarioActualizo { get; set; }

        public DateTime? FechaActualizo { get; set; }

        public bool? Activo { get; set; }

        [StringLength(50)]
        public string Tipo { get; set; }

        public virtual EMPRESA1 EMPRESA1 { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        public virtual USUARIO USUARIO1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RUTASOPERACIONESDETALLE> RUTASOPERACIONESDETALLE { get; set; }
    }
}
