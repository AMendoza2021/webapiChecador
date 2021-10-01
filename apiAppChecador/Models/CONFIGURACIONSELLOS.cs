namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FACTURACION.CONFIGURACIONSELLOS")]
    public partial class CONFIGURACIONSELLOS
    {
        [Key]
        public int IDCONFIGCFDI { get; set; }

        public int IDEMPRESA { get; set; }

        [Required]
        [StringLength(150)]
        public string CERTIFICADO { get; set; }

        [StringLength(255)]
        public string LLAVE { get; set; }

        [Required]
        [StringLength(255)]
        public string CLAVE { get; set; }

        public DateTime FECHACREACION { get; set; }

        public DateTime FECHAVENCIMIENTO { get; set; }

        [Required]
        [StringLength(150)]
        public string RUTARESGUARDOS { get; set; }

        [StringLength(1024)]
        public string RUTATIMBRADO { get; set; }

        public int IDUSUARIO { get; set; }

        public DateTime FECHA { get; set; }

        public int IDUSUARIOACTUALIZO { get; set; }

        public DateTime FECHAACTUALIZO { get; set; }

        public bool ACTIVO { get; set; }

        [StringLength(500)]
        public string DESCRIPCION { get; set; }

        public bool? MOSTRARNOTIFICACION { get; set; }

        public int? NOTIFICACIONESDIAS { get; set; }

        [StringLength(255)]
        public string TIMBRADOUSUARIO { get; set; }

        [StringLength(255)]
        public string TIMBRADOCLAVE { get; set; }

        public string CERTIFICADOENCRIPTADO { get; set; }

        public string LLAVEENCRIPADO { get; set; }

        public virtual EMPRESA1 EMPRESA1 { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        public virtual USUARIO USUARIO1 { get; set; }
    }
}
