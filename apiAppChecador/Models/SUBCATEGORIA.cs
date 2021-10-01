namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ALMACEN.SUBCATEGORIA")]
    public partial class SUBCATEGORIA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SUBCATEGORIA()
        {
            PRODUCTO = new HashSet<PRODUCTO>();
            INVENTARIOCONFIGURACION = new HashSet<INVENTARIOCONFIGURACION>();
            INVENTARIODETALLE = new HashSet<INVENTARIODETALLE>();
        }

        [Key]
        public int IDSUBCATEGORIA { get; set; }

        public bool? ACTIVO { get; set; }

        public int? IDCATEGORIA { get; set; }

        [StringLength(10)]
        public string CLAVE { get; set; }

        [StringLength(100)]
        public string DESCRIPCION { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int? IDEMPRESA { get; set; }

        public virtual CATEGORIA CATEGORIA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCTO> PRODUCTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INVENTARIOCONFIGURACION> INVENTARIOCONFIGURACION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INVENTARIODETALLE> INVENTARIODETALLE { get; set; }

        public virtual EMPRESA1 EMPRESA1 { get; set; }
    }
}
