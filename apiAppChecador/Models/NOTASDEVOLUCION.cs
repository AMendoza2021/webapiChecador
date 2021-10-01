namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CONTABILIDAD.NOTASDEVOLUCION")]
    public partial class NOTASDEVOLUCION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NOTASDEVOLUCION()
        {
            NOTASDEVOLUCIONCFDI = new HashSet<NOTASDEVOLUCIONCFDI>();
            NOTASDEVOLUCIONDETALLE = new HashSet<NOTASDEVOLUCIONDETALLE>();
        }

        [Key]
        public int IDNOTADEVOLUCION { get; set; }

        public int IDEMPRESA { get; set; }

        public int IDSUCURSAL { get; set; }

        public int IDCLIENTE { get; set; }

        public int IDFACTURA { get; set; }

        public int IDSITUACION { get; set; }

        [StringLength(15)]
        public string SERIE { get; set; }

        [Required]
        [StringLength(25)]
        public string FOLIO { get; set; }

        public int IDUSOCFDI { get; set; }

        public int IDMETODOPAGO { get; set; }

        public int IDFORMAPAGO { get; set; }

        public int IDCATEGORIA { get; set; }

        public int IDSUBCATEGORIA { get; set; }

        [Required]
        [StringLength(10)]
        public string LUGAREXPEDICION { get; set; }

        public decimal IMPORTESUBTOTAL { get; set; }

        public decimal IMPORTEIVA { get; set; }

        public decimal IMPORTEDESCUENTO { get; set; }

        public decimal IMPORTETOTAL { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string IMPORTELETRA { get; set; }

        public int IDMONEDA { get; set; }

        public decimal? TIPOCAMBIO { get; set; }

        [Required]
        [StringLength(255)]
        public string COMENTARIOS { get; set; }

        public int? IDCUENTAPENDIENTE { get; set; }

        public int IDUSUARIO { get; set; }

        public DateTime? FECHA { get; set; }

        public int IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public bool? ACTIVO { get; set; }

        public virtual DEVOLUCIONCATEGORIA DEVOLUCIONCATEGORIA { get; set; }

        public virtual DEVOLUCIONSUBCATEGORIA DEVOLUCIONSUBCATEGORIA { get; set; }

        public virtual FORMASPAGO FORMASPAGO { get; set; }

        public virtual METODOSPAGO METODOSPAGO { get; set; }

        public virtual SITUACION SITUACION { get; set; }

        public virtual USOCFDI USOCFDI { get; set; }

        public virtual CUENTAS CUENTAS { get; set; }

        public virtual CLIENTES2 CLIENTES2 { get; set; }

        public virtual EMPRESA1 EMPRESA1 { get; set; }

        public virtual FACTURAS FACTURAS { get; set; }

        public virtual SUCURSAL SUCURSAL { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        public virtual USUARIO USUARIO1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NOTASDEVOLUCIONCFDI> NOTASDEVOLUCIONCFDI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NOTASDEVOLUCIONDETALLE> NOTASDEVOLUCIONDETALLE { get; set; }
    }
}
