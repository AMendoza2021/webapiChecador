namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FACTURACION.REFERENCIASBANCARIAS")]
    public partial class REFERENCIASBANCARIAS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public REFERENCIASBANCARIAS()
        {
            FACTURAS = new HashSet<FACTURAS>();
            CLIENTES = new HashSet<CLIENTES>();
            CLIENTESHISTORIAL = new HashSet<CLIENTESHISTORIAL>();
        }

        [Key]
        public int IDREFERENCIABANCARIA { get; set; }

        public int IDEMPRESA { get; set; }

        public int IDSUCURSAL { get; set; }

        public int IDCLIENTE { get; set; }

        public int IDFORMAPAGO { get; set; }

        public int? IDBANCO { get; set; }

        [StringLength(50)]
        public string NUMEROCUENTA { get; set; }

        [StringLength(18)]
        public string CLABE { get; set; }

        [StringLength(250)]
        public string NOTAS { get; set; }

        public int IDUSUARIO { get; set; }

        public DateTime? FECHA { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public bool? ACTIVO { get; set; }

        public virtual BANCO BANCO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACTURAS> FACTURAS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIENTES> CLIENTES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIENTESHISTORIAL> CLIENTESHISTORIAL { get; set; }
    }
}
