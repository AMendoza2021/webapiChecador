namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FACTURACION.PAGOSHISTORIAL")]
    public partial class PAGOSHISTORIAL
    {
        [Key]
        public int IDPAGOHISTORIAL { get; set; }

        public int? IDFLUJO { get; set; }

        [Required]
        [StringLength(50)]
        public string ACCION { get; set; }

        [Required]
        [StringLength(50)]
        public string MOTIVO { get; set; }

        public int IDPAGO { get; set; }

        public int? IDEMPRESA { get; set; }

        public int? IDSUCURSAL { get; set; }

        public int? IDCLIENTE { get; set; }

        public int? IDAGENTE { get; set; }

        public int? IDSITUACION { get; set; }

        public int? IDTIPOPAGO { get; set; }

        [StringLength(50)]
        public string FOLIO { get; set; }

        public decimal? IMPORTE { get; set; }

        public int? IDMONEDA { get; set; }

        public decimal? TIPOCAMBIO { get; set; }

        [StringLength(50)]
        public string REFERENCIA { get; set; }

        public DateTime? FECHADEPOSITO { get; set; }

        public bool? GENERADO { get; set; }

        public int? IDFORMAPAGO { get; set; }

        public int? IDBANCOORIGEN { get; set; }

        [StringLength(50)]
        public string CUENTAORDENANTE { get; set; }

        public int? IDBANCODESTINO { get; set; }

        [StringLength(50)]
        public string CUENTADESTINO { get; set; }

        public bool? ACTIVO { get; set; }

        public int? IDUSUARIO { get; set; }

        public DateTime? FECHA { get; set; }

        public virtual BANCO BANCO { get; set; }

        public virtual BANCO BANCO1 { get; set; }

        public virtual FORMASPAGO FORMASPAGO { get; set; }

        public virtual MONEDAS MONEDAS { get; set; }

        public virtual SITUACION SITUACION { get; set; }

        public virtual FLUJOS FLUJOS { get; set; }

        public virtual PAGOS PAGOS { get; set; }

        public virtual AGENTES AGENTES { get; set; }

        public virtual CLIENTES2 CLIENTES2 { get; set; }

        public virtual EMPRESA1 EMPRESA1 { get; set; }

        public virtual SUCURSAL SUCURSAL { get; set; }

        public virtual TIPOPAGO TIPOPAGO { get; set; }

        public virtual USUARIO USUARIO { get; set; }
    }
}
