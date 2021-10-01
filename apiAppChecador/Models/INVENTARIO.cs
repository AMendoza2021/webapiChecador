namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("INVENTARIO.INVENTARIO")]
    public partial class INVENTARIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INVENTARIO()
        {
            INVENTARIOCONFIGURACION = new HashSet<INVENTARIOCONFIGURACION>();
            INVENTARIODETALLE = new HashSet<INVENTARIODETALLE>();
        }

        [Key]
        public int IDINVENTARIO { get; set; }

        public bool? ACTIVO { get; set; }

        public int? IDESTATUS { get; set; }

        public int? IDEMPRESA { get; set; }

        public int? IDSUCURSAL { get; set; }

        [StringLength(50)]
        public string FOLIO { get; set; }

        public int? TICKETINICIAL { get; set; }

        [StringLength(50)]
        public string TIPO { get; set; }

        [StringLength(1000)]
        public string DESCRIPCION { get; set; }

        [StringLength(50)]
        public string AJUSTEOBSERVACION { get; set; }

        public DateTime? FECHAINICIO { get; set; }

        public DateTime? FECHAFIN { get; set; }

        public Guid? IDCOMENTARIO { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        [StringLength(50)]
        public string TITULO { get; set; }

        public virtual ESTATUSPROCESO ESTATUSPROCESO { get; set; }

        public virtual EMPRESA1 EMPRESA1 { get; set; }

        public virtual SUCURSAL SUCURSAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INVENTARIOCONFIGURACION> INVENTARIOCONFIGURACION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INVENTARIODETALLE> INVENTARIODETALLE { get; set; }
    }
}
