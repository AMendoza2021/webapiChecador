namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FABRICACION.ORDENACONDICIONAMIENTO")]
    public partial class ORDENACONDICIONAMIENTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ORDENACONDICIONAMIENTO()
        {
            ORDENACONDICIONAMIENTOHISTORIAL = new HashSet<ORDENACONDICIONAMIENTOHISTORIAL>();
        }

        [Key]
        public int IDORDEN { get; set; }

        public int IDEMPRESA { get; set; }

        public int IDSUCURSAL { get; set; }

        public int IDPROGRAMA { get; set; }

        public int? IDORDENPRODUCCION { get; set; }

        public int IDSITUACION { get; set; }

        public int IDFORMULA { get; set; }

        public int IDPRODUCTOACONDICIONAMIENTO { get; set; }

        public int IDPRODUCTOSALIDA { get; set; }

        [Required]
        [StringLength(50)]
        public string TIPO { get; set; }

        [Required]
        [StringLength(50)]
        public string CLAVEFORMULA { get; set; }

        [Required]
        [StringLength(50)]
        public string NOFORMULA { get; set; }

        [Required]
        [StringLength(50)]
        public string PNO { get; set; }

        [Required]
        [StringLength(50)]
        public string ANALISIS { get; set; }

        [Required]
        [StringLength(255)]
        public string OBSERVACIONES { get; set; }

        public int NOORDEN { get; set; }

        [Required]
        [StringLength(25)]
        public string NOLOTE { get; set; }

        public DateTime FECHACADUCIDADLOTE { get; set; }

        public decimal TAMANOESTANDAR { get; set; }

        public decimal TAMANOFABRICAR { get; set; }

        public decimal? TAMANOFABRICADO { get; set; }

        public int IDUMTAMANOLOTE { get; set; }

        public DateTime? FECHAINICIO { get; set; }

        public DateTime? FECHAFIN { get; set; }

        public int? IDUSUARIOEMITIO { get; set; }

        public DateTime? FECHAEMISION { get; set; }

        public int? IDUSUARIOPRODUCCION { get; set; }

        public DateTime? FECHAUSUARIOPRODUCCION { get; set; }

        public int? IDUSUARIOCALIDAD { get; set; }

        public DateTime? FECHAUSUARIOCALIDAD { get; set; }

        public int? IDUSUARIORESPSANITARIO { get; set; }

        public DateTime? FECHAUSUARIORESPSANITARIO { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        [StringLength(50)]
        public string CLAVE { get; set; }

        [StringLength(200)]
        public string LEYENDA { get; set; }

        public decimal? RENDIMIENTOOBTENIDO { get; set; }

        public int? RENDIMIENTOPARCIAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORDENACONDICIONAMIENTOHISTORIAL> ORDENACONDICIONAMIENTOHISTORIAL { get; set; }
    }
}
