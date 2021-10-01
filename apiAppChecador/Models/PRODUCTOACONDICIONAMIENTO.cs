namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CATALOGO.PRODUCTOACONDICIONAMIENTO")]
    public partial class PRODUCTOACONDICIONAMIENTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRODUCTOACONDICIONAMIENTO()
        {
            PRODUCTOACONDICIONAMIENTOETAPA = new HashSet<PRODUCTOACONDICIONAMIENTOETAPA>();
        }

        [Key]
        public int IDPRODUCTO { get; set; }

        public int? IDEMPRESA { get; set; }

        public int IDPRODUCTOFABRICACION { get; set; }

        public int IDPRODUCTOSALIDA { get; set; }

        [StringLength(25)]
        public string CODIGO { get; set; }

        [StringLength(50)]
        public string NOMBRE { get; set; }

        [StringLength(255)]
        public string ANALISIS { get; set; }

        public int? IDUMPRESENTACION { get; set; }

        [StringLength(50)]
        public string CANTIDAD { get; set; }

        public int? IDUMCANTIDAD { get; set; }

        public int? IDSECTOR { get; set; }

        public int? RENDIMIENTOTEORICO { get; set; }

        public int? RENDIMIENTOMAXIMO { get; set; }

        public int? RENDIMIENTOMINIMO { get; set; }

        public int? IDUSUARIO { get; set; }

        public DateTime? FECHA { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public bool ACTIVO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCTOACONDICIONAMIENTOETAPA> PRODUCTOACONDICIONAMIENTOETAPA { get; set; }
    }
}
