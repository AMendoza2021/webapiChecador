namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ALMACEN.PROCESO")]
    public partial class PROCESO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PROCESO()
        {
            EXISTENCIADETALLE = new HashSet<EXISTENCIADETALLE>();
            ALMACEN1 = new HashSet<ALMACEN1>();
        }

        [Key]
        public int IDPROCESO { get; set; }

        public bool? VISIBLE { get; set; }

        [StringLength(3)]
        public string CLAVE { get; set; }

        [StringLength(50)]
        public string DESCRIPCION { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EXISTENCIADETALLE> EXISTENCIADETALLE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ALMACEN1> ALMACEN1 { get; set; }
    }
}
