namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DOMICILIO.ESTADO")]
    public partial class ESTADO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ESTADO()
        {
            IMPUESTOS = new HashSet<IMPUESTOS>();
        }

        [Key]
        public int IDESTADO { get; set; }

        public bool? ACTIVO { get; set; }

        [StringLength(12)]
        public string CLAVE { get; set; }

        [StringLength(100)]
        public string NOMBRE { get; set; }

        public int? IDPAIS { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IMPUESTOS> IMPUESTOS { get; set; }
    }
}
