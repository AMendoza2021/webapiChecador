namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VENTAS.PERFILCREDITOHISTORICO")]
    public partial class PERFILCREDITOHISTORICO
    {
        [Key]
        public int IDHISTORICO { get; set; }

        public int? IDFLUJO { get; set; }

        [Required]
        [StringLength(50)]
        public string ACCION { get; set; }

        [Required]
        [StringLength(500)]
        public string COMENTARIOS { get; set; }

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

        [StringLength(255)]
        public string CONDICIONES { get; set; }

        public DateTime? VENCIMIENTO { get; set; }

        public int? IDRIESGO { get; set; }

        public int? SCORE { get; set; }

        public bool BLOQUEADO { get; set; }

        [StringLength(255)]
        public string RAZONBLOQUEO { get; set; }

        public int IDUSUARIO { get; set; }

        public DateTime? FECHA { get; set; }

        public virtual MONEDAS MONEDAS { get; set; }

        public virtual SITUACION SITUACION { get; set; }

        public virtual FLUJOS FLUJOS { get; set; }

        public virtual CLIENTES2 CLIENTES2 { get; set; }

        public virtual EMPRESA1 EMPRESA1 { get; set; }

        public virtual SUCURSAL SUCURSAL { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        public virtual PERFILCREDITO PERFILCREDITO { get; set; }
    }
}
