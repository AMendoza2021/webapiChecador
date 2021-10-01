namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NEGOCIO.CLIENTES")]
    public partial class CLIENTES2
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CLIENTES2()
        {
            NOTASCREDITO = new HashSet<NOTASCREDITO>();
            NOTASDEVOLUCION = new HashSet<NOTASDEVOLUCION>();
            FACTURAS = new HashSet<FACTURAS>();
            PAGOS = new HashSet<PAGOS>();
            PAGOSHISTORIAL = new HashSet<PAGOSHISTORIAL>();
            CLIENTES = new HashSet<CLIENTES>();
            CLIENTESHISTORIAL = new HashSet<CLIENTESHISTORIAL>();
            CLIENTELICITACION = new HashSet<CLIENTELICITACION>();
            CLIENTESFACULTADOS = new HashSet<CLIENTESFACULTADOS>();
            PEDIDOS = new HashSet<PEDIDOS>();
            PERFILCREDITO = new HashSet<PERFILCREDITO>();
            PERFILCREDITOHISTORICO = new HashSet<PERFILCREDITOHISTORICO>();
            PRECIOVENTALISTACLIENTE = new HashSet<PRECIOVENTALISTACLIENTE>();
            REGISTROVENTA = new HashSet<REGISTROVENTA>();
            REGISTROVENTAHISTORIAL = new HashSet<REGISTROVENTAHISTORIAL>();
            TARJETASPODER = new HashSet<TARJETASPODER>();
        }

        [Key]
        public int IDCLIENTE { get; set; }

        public int IDEMPRESA { get; set; }

        public int IDSUCURSAL { get; set; }

        public int IDAGENTE { get; set; }

        [Required]
        [StringLength(10)]
        public string CLAVE { get; set; }

        [Required]
        [StringLength(100)]
        public string NOMBRE { get; set; }

        [Required]
        [StringLength(100)]
        public string RAZONSOCIAL { get; set; }

        [Required]
        [StringLength(13)]
        public string RFC { get; set; }

        [StringLength(100)]
        public string REPRESENTANTE { get; set; }

        [StringLength(13)]
        public string REPRESENTANTERFC { get; set; }

        public int IDREGIMENFISCAL { get; set; }

        public int IDTIPOCUENTACLIENTE { get; set; }

        public decimal LIMITECREDITO { get; set; }

        public int PORCENTAJEDESCUENTO { get; set; }

        public int PORCENTAJEIVA { get; set; }

        public int? IDCONTACTOPRINCIPAL { get; set; }

        public int? IDCONTACTOENVIOS { get; set; }

        public int? IDDOMICILIO { get; set; }

        public int? IDDOMICILIOENVIO { get; set; }

        public Guid? IDCOMENTARIOGPO { get; set; }

        public int IDUSUARIO { get; set; }

        public DateTime FECHA { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public bool ACTIVO { get; set; }

        public DateTime? FECHAULTIMACOMPRA { get; set; }

        [StringLength(100)]
        public string DESCUENTO { get; set; }

        public int? IDZONAVENTA { get; set; }

        public int? IDIMPUESTO { get; set; }

        public virtual REGIMENFISCAL REGIMENFISCAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NOTASCREDITO> NOTASCREDITO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NOTASDEVOLUCION> NOTASDEVOLUCION { get; set; }

        public virtual TIPOCUENTACLIENTE TIPOCUENTACLIENTE { get; set; }

        public virtual DOMICILIO DOMICILIO { get; set; }

        public virtual DOMICILIOENTREGA DOMICILIOENTREGA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACTURAS> FACTURAS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PAGOS> PAGOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PAGOSHISTORIAL> PAGOSHISTORIAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIENTES> CLIENTES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIENTESHISTORIAL> CLIENTESHISTORIAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIENTELICITACION> CLIENTELICITACION { get; set; }

        public virtual AGENTES AGENTES { get; set; }

        public virtual EMPRESA1 EMPRESA1 { get; set; }

        public virtual SUCURSAL SUCURSAL { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        public virtual USUARIO USUARIO1 { get; set; }

        public virtual ZONAS ZONAS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIENTESFACULTADOS> CLIENTESFACULTADOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PEDIDOS> PEDIDOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERFILCREDITO> PERFILCREDITO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERFILCREDITOHISTORICO> PERFILCREDITOHISTORICO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRECIOVENTALISTACLIENTE> PRECIOVENTALISTACLIENTE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REGISTROVENTA> REGISTROVENTA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REGISTROVENTAHISTORIAL> REGISTROVENTAHISTORIAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TARJETASPODER> TARJETASPODER { get; set; }
    }
}
