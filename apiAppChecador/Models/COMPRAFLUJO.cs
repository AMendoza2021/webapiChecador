namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("COMPRAS.COMPRAFLUJO")]
    public partial class COMPRAFLUJO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public COMPRAFLUJO()
        {
            COMPRAHISTORICO = new HashSet<COMPRAHISTORICO>();
        }

        [Key]
        public int IDFLUJO { get; set; }

        public bool? ACTIVO { get; set; }

        [StringLength(50)]
        public string DESCRIPCION { get; set; }

        public int? ESTADOACTUAL { get; set; }

        public int? ESTADONUEVO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public bool? REQFIRMA { get; set; }

        [StringLength(50)]
        public string COLUMNAFIRMA { get; set; }

        [StringLength(50)]
        public string ACCION { get; set; }

        public bool? OCULTO { get; set; }

        public virtual ESTATUS ESTATUS { get; set; }

        public virtual ESTATUS ESTATUS1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPRAHISTORICO> COMPRAHISTORICO { get; set; }
    }
}
