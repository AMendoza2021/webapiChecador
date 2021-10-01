namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VENTAS.REGISTROVENTADETALLE")]
    public partial class REGISTROVENTADETALLE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public REGISTROVENTADETALLE()
        {
            FACTURASDETALLE = new HashSet<FACTURASDETALLE>();
        }

        [Key]
        public int IDREGISTROVENTADETALLE { get; set; }

        public int IDREGISTROVENTA { get; set; }

        public int IDSITUACION { get; set; }

        public int IDPRODUCTO { get; set; }

        public int IDEXISTENCIA { get; set; }

        public int IDALMACEN { get; set; }

        public int IDLOCALIDAD { get; set; }

        [Required]
        [StringLength(25)]
        public string NOLOTE { get; set; }

        public decimal CANTIDADPEDIDO { get; set; }

        public decimal CANTIDADSURTIDA { get; set; }

        public DateTime FECHACADUCIDAD { get; set; }

        public int IDPRECIOVENTA { get; set; }

        public decimal PRECIO { get; set; }

        public decimal SUBTOTAL { get; set; }

        public decimal DESCUENTO { get; set; }

        public decimal IMPUESTOSTRASLADO { get; set; }

        public decimal TOTAL { get; set; }

        [StringLength(250)]
        public string NOTAS { get; set; }

        public int IDUSUARIO { get; set; }

        public DateTime? FECHA { get; set; }

        public int IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public bool? ACTIVO { get; set; }

        public virtual ALMACEN ALMACEN { get; set; }

        public virtual ALMACENLOCALIDAD ALMACENLOCALIDAD { get; set; }

        public virtual EXISTENCIA EXISTENCIA { get; set; }

        public virtual PRODUCTO PRODUCTO { get; set; }

        public virtual SITUACION SITUACION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACTURASDETALLE> FACTURASDETALLE { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        public virtual USUARIO USUARIO1 { get; set; }

        public virtual PRECIOVENTA PRECIOVENTA { get; set; }

        public virtual REGISTROVENTA REGISTROVENTA { get; set; }
    }
}
