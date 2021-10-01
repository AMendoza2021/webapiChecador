namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LARISSA.INVENTARIO_ALMSUBTIPO")]
    public partial class INVENTARIO_ALMSUBTIPO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INVENTARIO_ALMSUBTIPO()
        {
            INVENTARIODETALLE1 = new HashSet<INVENTARIODETALLE1>();
        }

        [Key]
        public int IDALMSUB { get; set; }

        public int? IDINVENTARIO { get; set; }

        public Guid? IDALMACEN { get; set; }

        public Guid? IDSUBTIPO { get; set; }

        public DateTime? FECHA { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public bool? PROCESADO { get; set; }

        public virtual INVENTARIO1 INVENTARIO1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INVENTARIODETALLE1> INVENTARIODETALLE1 { get; set; }
    }
}
