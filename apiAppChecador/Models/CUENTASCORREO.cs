namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CONFIGURADOR.CUENTASCORREO")]
    public partial class CUENTASCORREO
    {
        [Key]
        public int IDCORREO { get; set; }

        public int IDEMPRESA { get; set; }

        [Required]
        [StringLength(25)]
        public string CLAVE { get; set; }

        [Required]
        [StringLength(255)]
        public string DESCRIPCION { get; set; }

        [Required]
        [StringLength(255)]
        public string NOMBRE { get; set; }

        [Required]
        [StringLength(150)]
        public string CUENTA { get; set; }

        [Required]
        [StringLength(50)]
        public string CUENTAUSUARIO { get; set; }

        [Required]
        [StringLength(50)]
        public string CUENTACLAVE { get; set; }

        public int IDUSUARIO { get; set; }

        public DateTime? FECHA { get; set; }

        public int IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public bool? ACTIVO { get; set; }

        public virtual EMPRESA1 EMPRESA1 { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        public virtual USUARIO USUARIO1 { get; set; }
    }
}
