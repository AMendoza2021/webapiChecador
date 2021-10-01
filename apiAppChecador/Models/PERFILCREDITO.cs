namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VENTAS.PERFILCREDITO")]
    public partial class PERFILCREDITO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PERFILCREDITO()
        {
            PERFILCREDITOHISTORICO = new HashSet<PERFILCREDITOHISTORICO>();
        }

        [Key]
        public int IDCREDITO { get; set; }

        public int IDEMPRESA { get; set; }

        public int IDSUCURSAL { get; set; }

        public int IDCLIENTE { get; set; }

        public int? IDAGENTE { get; set; }

        public int IDSITUACION { get; set; }

        public decimal MONTOSOLICITADO { get; set; }

        public decimal? MONTOCREDITO { get; set; }

        public int IDMONEDA { get; set; }

        public int PLAZODIAS { get; set; }

        [StringLength(250)]
        public string CONDICIONES { get; set; }

        public DateTime? VENCIMIENTO { get; set; }

        public int? IDRIESGO { get; set; }

        public int? SCORE { get; set; }

        public bool BLOQUEADO { get; set; }

        [StringLength(50)]
        public string RAZONBLOQUEO { get; set; }

        public int IDUSUARIO { get; set; }

        public DateTime? FECHA { get; set; }

        public int IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public bool? ACTIVO { get; set; }

        public virtual MONEDAS MONEDAS { get; set; }

        public virtual SITUACION SITUACION { get; set; }

        public virtual CLIENTES2 CLIENTES2 { get; set; }

        public virtual EMPRESA1 EMPRESA1 { get; set; }

        public virtual SUCURSAL SUCURSAL { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        public virtual USUARIO USUARIO1 { get; set; }

        public virtual AGENTES AGENTES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERFILCREDITOHISTORICO> PERFILCREDITOHISTORICO { get; set; }
    }
}
