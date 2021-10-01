namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CATALOGO.TIPOMEDIDA")]
    public partial class TIPOMEDIDA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TIPOMEDIDA()
        {
            UNIDADMEDIDA = new HashSet<UNIDADMEDIDA>();
        }

        [Key]
        public int IDTIPO { get; set; }

        public bool? ACTIVO { get; set; }

        [StringLength(50)]
        public string NOMBRE { get; set; }

        [StringLength(100)]
        public string DESCRIPCION { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        [StringLength(5)]
        public string CLAVEFISCAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UNIDADMEDIDA> UNIDADMEDIDA { get; set; }
    }
}
