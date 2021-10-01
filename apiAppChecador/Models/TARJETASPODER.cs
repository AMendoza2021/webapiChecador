namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VENTAS.TARJETASPODER")]
    public partial class TARJETASPODER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TARJETASPODER()
        {
            TARJETASPODERDETALLE = new HashSet<TARJETASPODERDETALLE>();
        }

        [Key]
        public int IDTARJETAPODER { get; set; }

        public int IDCLIENTE { get; set; }

        [StringLength(10)]
        public string FOLIODOCUMENTO { get; set; }

        public DateTime? FECHADOCUMENTO { get; set; }

        public int IDUSUARIO { get; set; }

        public DateTime? FECHA { get; set; }

        public int IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public bool? ACTIVO { get; set; }

        public virtual CLIENTES2 CLIENTES2 { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        public virtual USUARIO USUARIO1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TARJETASPODERDETALLE> TARJETASPODERDETALLE { get; set; }
    }
}
