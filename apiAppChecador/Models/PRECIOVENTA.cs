namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VENTAS.PRECIOVENTA")]
    public partial class PRECIOVENTA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRECIOVENTA()
        {
            FACTURASDETALLE = new HashSet<FACTURASDETALLE>();
            PEDIDOSDETALLE = new HashSet<PEDIDOSDETALLE>();
            REGISTROVENTADETALLE = new HashSet<REGISTROVENTADETALLE>();
        }

        [Key]
        public int IDPRECIOVENTA { get; set; }

        public int IDPRECIOVENTALISTA { get; set; }

        public int IDPRODUCTO { get; set; }

        public decimal PRECIO { get; set; }

        public int IDMONEDA { get; set; }

        [StringLength(150)]
        public string COMENTARIOS { get; set; }

        public int IDUSUARIO { get; set; }

        public DateTime? FECHA { get; set; }

        public int IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public bool? ACTIVO { get; set; }

        public virtual PRODUCTO PRODUCTO { get; set; }

        public virtual MONEDAS MONEDAS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACTURASDETALLE> FACTURASDETALLE { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        public virtual USUARIO USUARIO1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PEDIDOSDETALLE> PEDIDOSDETALLE { get; set; }

        public virtual PRECIOVENTALISTA PRECIOVENTALISTA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REGISTROVENTADETALLE> REGISTROVENTADETALLE { get; set; }
    }
}
