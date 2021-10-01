namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MIGRACION.CLIENTES")]
    public partial class CLIENTES1
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDCLIENTE { get; set; }

        public int IDEMPRESA { get; set; }

        public int IDSUCURSAL { get; set; }

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

        public int? IDDOMICILIO { get; set; }

        [Required]
        [StringLength(25)]
        public string TELEFONO { get; set; }

        [StringLength(25)]
        public string TELEFONOALTERNO { get; set; }

        [StringLength(25)]
        public string FAX { get; set; }

        [Required]
        [StringLength(100)]
        public string CONTACTO { get; set; }

        [Required]
        [StringLength(50)]
        public string CONTACTOEMAIL { get; set; }

        [StringLength(50)]
        public string GIROCOMERCIAL { get; set; }

        [StringLength(100)]
        public string CONTACTOENVIO { get; set; }

        public int IDDOMICILIOENVIO { get; set; }

        public decimal? LIMITECREDITO { get; set; }

        public int IDUSUARIO { get; set; }

        public DateTime FECHA { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public bool ACTIVO { get; set; }
    }
}
