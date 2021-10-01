namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RH.PERIODONOMINA")]
    public partial class PERIODONOMINA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PERIODONOMINA()
        {
            CHECADA = new HashSet<CHECADA>();
        }

        [Key]
        public int IDPERIODO { get; set; }

        [StringLength(500)]
        public string DESCRIPCION { get; set; }

        public DateTime FECHAINICIO { get; set; }

        public DateTime FECHAFIN { get; set; }

        public bool? CERRADO { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int IDUSUARIOACTUALIZO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHECADA> CHECADA { get; set; }

        public virtual USUARIO USUARIO { get; set; }
    }
}
