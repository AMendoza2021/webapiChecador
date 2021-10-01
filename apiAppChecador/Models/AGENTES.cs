namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VENTAS.AGENTES")]
    public partial class AGENTES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AGENTES()
        {
            FACTURAS = new HashSet<FACTURAS>();
            PAGOS = new HashSet<PAGOS>();
            PAGOSHISTORIAL = new HashSet<PAGOSHISTORIAL>();
            CLIENTES2 = new HashSet<CLIENTES2>();
            PEDIDOS = new HashSet<PEDIDOS>();
            PERFILCREDITO = new HashSet<PERFILCREDITO>();
            REGISTROVENTA = new HashSet<REGISTROVENTA>();
            REGISTROVENTAHISTORIAL = new HashSet<REGISTROVENTAHISTORIAL>();
        }

        [Key]
        public int IDAGENTE { get; set; }

        public int IDEMPRESA { get; set; }

        public int IDSUCURSAL { get; set; }

        public int IDEMPLEADO { get; set; }

        public int IDUSUARIOAGENTE { get; set; }

        [StringLength(6)]
        public string CLAVE { get; set; }

        public decimal CUOTAVENTA { get; set; }

        public decimal MONTOBONO { get; set; }

        public decimal COMISION { get; set; }

        public decimal VENTASYTD { get; set; }

        public decimal VENTASULTIMOANIO { get; set; }

        public int IDUSUARIO { get; set; }

        public DateTime FECHA { get; set; }

        public int IDUSUARIOACTUALIZO { get; set; }

        public DateTime FECHAACTUALIZO { get; set; }

        public bool ACTIVO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACTURAS> FACTURAS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PAGOS> PAGOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PAGOSHISTORIAL> PAGOSHISTORIAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIENTES2> CLIENTES2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PEDIDOS> PEDIDOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERFILCREDITO> PERFILCREDITO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REGISTROVENTA> REGISTROVENTA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REGISTROVENTAHISTORIAL> REGISTROVENTAHISTORIAL { get; set; }
    }
}
