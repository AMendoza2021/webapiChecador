namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FABRICACION.EDIFICIOS")]
    public partial class EDIFICIOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EDIFICIOS()
        {
            CENTROSTRABAJO = new HashSet<CENTROSTRABAJO>();
        }

        [Key]
        public int IDEdificio { get; set; }

        public int IDEmpresa { get; set; }

        public int IDSucursal { get; set; }

        [Required]
        [StringLength(50)]
        public string Clave { get; set; }

        [Required]
        [StringLength(500)]
        public string Descripcion { get; set; }

        public int IDUsuario { get; set; }

        public DateTime? Fecha { get; set; }

        public int IDUsuarioActualizo { get; set; }

        public DateTime? FechaActualizo { get; set; }

        public bool? Activo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CENTROSTRABAJO> CENTROSTRABAJO { get; set; }

        public virtual EMPRESA1 EMPRESA1 { get; set; }

        public virtual SUCURSAL SUCURSAL { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        public virtual USUARIO USUARIO1 { get; set; }
    }
}
