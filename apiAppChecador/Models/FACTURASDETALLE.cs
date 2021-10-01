namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FACTURACION.FACTURASDETALLE")]
    public partial class FACTURASDETALLE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FACTURASDETALLE()
        {
            NOTASDEVOLUCIONDETALLE = new HashSet<NOTASDEVOLUCIONDETALLE>();
        }

        [Key]
        public int IDFACTURADETALLE { get; set; }

        public int IDFACTURA { get; set; }

        public int? IDREGISTROVENTA { get; set; }

        public int? IDREGISTROVENTADETALLE { get; set; }

        public int IDPRODUCTO { get; set; }

        public int? IDPRODUCTOFISCAL { get; set; }

        [StringLength(25)]
        public string CLAVE { get; set; }

        [StringLength(25)]
        public string CLAVEFISCAL { get; set; }

        [Required]
        [StringLength(255)]
        public string PRODUCTO { get; set; }

        public int IDUNIDADMEDIDA { get; set; }

        [StringLength(25)]
        public string UNIDADMEDIDA { get; set; }

        [StringLength(25)]
        public string UNIDADMEDIDAFISCAL { get; set; }

        public int? IDEXISTENCIA { get; set; }

        [StringLength(50)]
        public string NOLOTE { get; set; }

        public DateTime? FECHACADUCIDAD { get; set; }

        public decimal CANTIDAD { get; set; }

        public int? IDPRECIOVENTA { get; set; }

        public decimal PRECIO { get; set; }

        public decimal IMPORTESUBTOTAL { get; set; }

        public decimal IMPORTEDESCUENTO { get; set; }

        public int IDIMPUESTO { get; set; }

        public decimal IMPORTEIVA { get; set; }

        public decimal IMPORTETOTAL { get; set; }

        [StringLength(1024)]
        public string COMENTARIOS { get; set; }

        public int IDUSUARIO { get; set; }

        public DateTime? FECHA { get; set; }

        public virtual EXISTENCIA EXISTENCIA { get; set; }

        public virtual PRODUCTO PRODUCTO1 { get; set; }

        public virtual IMPUESTOS IMPUESTOS { get; set; }

        public virtual UNIDADMEDIDA UNIDADMEDIDA1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NOTASDEVOLUCIONDETALLE> NOTASDEVOLUCIONDETALLE { get; set; }

        public virtual FACTURAS FACTURAS { get; set; }

        public virtual PRECIOVENTA PRECIOVENTA { get; set; }

        public virtual PRODUCTO1 PRODUCTO11 { get; set; }

        public virtual REGISTROVENTA REGISTROVENTA { get; set; }

        public virtual REGISTROVENTADETALLE REGISTROVENTADETALLE { get; set; }

        public virtual USUARIO USUARIO { get; set; }
    }
}
