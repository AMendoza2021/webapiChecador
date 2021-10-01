namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LARISSA.INVENTARIO")]
    public partial class INVENTARIO1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INVENTARIO1()
        {
            INVENTARIO_ALMSUBTIPO = new HashSet<INVENTARIO_ALMSUBTIPO>();
        }

        [Key]
        public int IDINVENTARIO { get; set; }

        [StringLength(50)]
        public string FOLIO { get; set; }

        [StringLength(50)]
        public string TITULO { get; set; }

        public DateTime? FECHAINVENTARIO { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public Guid? IDSUCURSAL { get; set; }

        public Guid? IDEMPRESA { get; set; }

        public int? IDESTATUS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INVENTARIO_ALMSUBTIPO> INVENTARIO_ALMSUBTIPO { get; set; }
    }
}
