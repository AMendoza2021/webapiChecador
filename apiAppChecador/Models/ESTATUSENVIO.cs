namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ALMACEN.ESTATUSENVIO")]
    public partial class ESTATUSENVIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ESTATUSENVIO()
        {
            ENVIO = new HashSet<ENVIO>();
            ENVIOHISTORICO = new HashSet<ENVIOHISTORICO>();
            ENVIOHISTORICO1 = new HashSet<ENVIOHISTORICO>();
        }

        [Key]
        public int IDESTATUS { get; set; }

        public bool? ACTIVO { get; set; }

        [StringLength(10)]
        public string CLAVE { get; set; }

        [StringLength(100)]
        public string DESCRIPCION { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ENVIO> ENVIO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ENVIOHISTORICO> ENVIOHISTORICO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ENVIOHISTORICO> ENVIOHISTORICO1 { get; set; }

        public virtual USUARIO USUARIO { get; set; }
    }
}
