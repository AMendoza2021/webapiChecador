namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("INVENTARIO.INVENTARIOCONFIGURACION")]
    public partial class INVENTARIOCONFIGURACION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INVENTARIOCONFIGURACION()
        {
            INVENTARIODETALLE = new HashSet<INVENTARIODETALLE>();
        }

        [Key]
        public int IDCONFIGURACION { get; set; }

        public int? IDINVENTARIO { get; set; }

        public int? IDALMACEN { get; set; }

        public int? IDLOCALIDAD { get; set; }

        public int? IDCATEGORIA { get; set; }

        public int? IDSUBCATEGORIA { get; set; }

        public bool? PROCESADO { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public virtual ALMACEN ALMACEN { get; set; }

        public virtual ALMACENLOCALIDAD ALMACENLOCALIDAD { get; set; }

        public virtual CATEGORIA CATEGORIA { get; set; }

        public virtual SUBCATEGORIA SUBCATEGORIA { get; set; }

        public virtual INVENTARIO INVENTARIO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INVENTARIODETALLE> INVENTARIODETALLE { get; set; }
    }
}
