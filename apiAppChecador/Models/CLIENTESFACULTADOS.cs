namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NEGOCIO.CLIENTESFACULTADOS")]
    public partial class CLIENTESFACULTADOS
    {
        [Key]
        public int IDFACTULTADO { get; set; }

        public int IDCLIENTE { get; set; }

        [Required]
        [StringLength(255)]
        public string NOMBRE { get; set; }

        [Required]
        [StringLength(255)]
        public string APELLIDOS { get; set; }

        [StringLength(255)]
        public string TELEFONO { get; set; }

        [StringLength(255)]
        public string CORREOELECTRONICO { get; set; }

        public int IDUSUARIO { get; set; }

        public DateTime? FECHA { get; set; }

        public int IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public bool? ACTIVO { get; set; }

        public virtual CLIENTES2 CLIENTES2 { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        public virtual USUARIO USUARIO1 { get; set; }
    }
}
