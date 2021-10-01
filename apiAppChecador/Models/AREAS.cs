namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("COSTOS.AREAS")]
    public partial class AREAS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AREAS()
        {
            ACTIVOSFIJOS = new HashSet<ACTIVOSFIJOS>();
        }

        [Key]
        public int IDAREA { get; set; }

        public int? IDEMPRESA { get; set; }

        public int? IDDEPARTAMENTO { get; set; }

        public int? IDMAPA { get; set; }

        [StringLength(255)]
        public string CONSECUTIVO { get; set; }

        public double? METROSCUADRADOS { get; set; }

        public decimal? CMANODEOBRA { get; set; }

        public decimal? CFIJO { get; set; }

        public decimal? CVARIABLE { get; set; }

        public decimal? CMAQUINA { get; set; }

        [StringLength(80)]
        public string NOMAREA { get; set; }

        public int? IDTIPOAREA { get; set; }

        public int? IDRESPONSABLE { get; set; }

        public bool? ACTIVO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACTIVOSFIJOS> ACTIVOSFIJOS { get; set; }
    }
}
