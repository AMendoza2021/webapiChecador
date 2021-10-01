namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ALMACEN.EXISTENCIA")]
    public partial class EXISTENCIA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EXISTENCIA()
        {
            EXISTENCIAACTUAL = new HashSet<EXISTENCIAACTUAL>();
            EXISTENCIADETALLE = new HashSet<EXISTENCIADETALLE>();
            FACTURASDETALLE = new HashSet<FACTURASDETALLE>();
            INVENTARIODETALLE = new HashSet<INVENTARIODETALLE>();
            NOTASDEVOLUCIONDETALLE = new HashSet<NOTASDEVOLUCIONDETALLE>();
            REGISTROVENTADETALLE = new HashSet<REGISTROVENTADETALLE>();
        }

        [Key]
        public int IDEXISTENCIA { get; set; }

        public int? IDEMPRESA { get; set; }

        public int? IDSUCURSAL { get; set; }

        public int? IDPRODUCTO { get; set; }

        [StringLength(3)]
        public string CLASE { get; set; }

        [StringLength(20)]
        public string NOLOTE { get; set; }

        public DateTime? FECHACADUCIDAD { get; set; }

        public DateTime? FECHAFABRICACION { get; set; }

        public decimal? COSTOESTANDAR { get; set; }

        public bool? DISPONIBLE { get; set; }

        [StringLength(1000)]
        public string OBSERVACION { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        [StringLength(50)]
        public string NOLOTEPROVEEDOR { get; set; }

        public virtual EMPRESA1 EMPRESA1 { get; set; }

        public virtual PRODUCTO PRODUCTO { get; set; }

        public virtual SUCURSAL SUCURSAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EXISTENCIAACTUAL> EXISTENCIAACTUAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EXISTENCIADETALLE> EXISTENCIADETALLE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACTURASDETALLE> FACTURASDETALLE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INVENTARIODETALLE> INVENTARIODETALLE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NOTASDEVOLUCIONDETALLE> NOTASDEVOLUCIONDETALLE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REGISTROVENTADETALLE> REGISTROVENTADETALLE { get; set; }
    }
}
