namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FACTURACION.TIPOPAGO")]
    public partial class TIPOPAGO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TIPOPAGO()
        {
            PAGOS = new HashSet<PAGOS>();
            PAGOSHISTORIAL = new HashSet<PAGOSHISTORIAL>();
        }

        [Key]
        public int IDTIPOPAGO { get; set; }

        [Required]
        [StringLength(50)]
        public string DESCRIPCION { get; set; }

        public int IDUSUARIO { get; set; }

        public DateTime FECHA { get; set; }

        public int IDUSUARIOACTUALIZO { get; set; }

        public DateTime FECHAACTUALIZO { get; set; }

        public bool ACTIVO { get; set; }

        [StringLength(10)]
        public string CLAVE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PAGOS> PAGOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PAGOSHISTORIAL> PAGOSHISTORIAL { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        public virtual USUARIO USUARIO1 { get; set; }
    }
}
