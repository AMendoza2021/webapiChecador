namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CATALOGO.COMUNICACION")]
    public partial class COMUNICACION
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDREG { get; set; }

        public Guid IDCOMUNICACION { get; set; }

        public int? CONSECUTIVO { get; set; }

        [Required]
        [StringLength(30)]
        public string DESCRIPCION { get; set; }

        public int IDTIPOCOMUNICACION { get; set; }

        public int IDUSUARIO { get; set; }

        public DateTime FECHA { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public bool ACTIVO { get; set; }

        public virtual TIPOCOMUNICACION TIPOCOMUNICACION { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        public virtual USUARIO USUARIO1 { get; set; }
    }
}
