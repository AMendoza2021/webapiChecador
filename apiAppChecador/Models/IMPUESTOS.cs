namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CATALOGO.IMPUESTOS")]
    public partial class IMPUESTOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IMPUESTOS()
        {
            PRODUCTO = new HashSet<PRODUCTO>();
            FACTURASDETALLE = new HashSet<FACTURASDETALLE>();
        }

        [Key]
        public int IDIMPUESTO { get; set; }

        [Required]
        [StringLength(5)]
        public string CLAVE { get; set; }

        [Required]
        [StringLength(25)]
        public string DESCRIPCION { get; set; }

        [Required]
        [StringLength(10)]
        public string FACTOR { get; set; }

        public decimal VALOR { get; set; }

        public bool ESRETENCION { get; set; }

        public bool ESTRASLADO { get; set; }

        public bool ESFEDERAL { get; set; }

        public int? IDESTADO { get; set; }

        public int IDUSUARIO { get; set; }

        public DateTime? FECHA { get; set; }

        public int IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public bool ACTIVO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCTO> PRODUCTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACTURASDETALLE> FACTURASDETALLE { get; set; }

        public virtual ESTADO ESTADO { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        public virtual USUARIO USUARIO1 { get; set; }
    }
}
