namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CATALOGO.DEVOLUCIONSUBCATEGORIA")]
    public partial class DEVOLUCIONSUBCATEGORIA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DEVOLUCIONSUBCATEGORIA()
        {
            NOTASDEVOLUCION = new HashSet<NOTASDEVOLUCION>();
        }

        [Key]
        public int IDSUBCATEGORIA { get; set; }

        public int IDCATEGORIA { get; set; }

        [Required]
        [StringLength(500)]
        public string DESCRIPCION { get; set; }

        public int IDUSUARIO { get; set; }

        public DateTime? FECHA { get; set; }

        public int IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public bool? ACTIVO { get; set; }

        public virtual DEVOLUCIONCATEGORIA DEVOLUCIONCATEGORIA { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        public virtual USUARIO USUARIO1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NOTASDEVOLUCION> NOTASDEVOLUCION { get; set; }
    }
}
