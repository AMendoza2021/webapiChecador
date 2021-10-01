namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CATALOGO.CONTACTOS")]
    public partial class CONTACTOS
    {
        [Key]
        public int IDCONTACTO { get; set; }

        [Required]
        [StringLength(25)]
        public string TIPO { get; set; }

        [StringLength(20)]
        public string TITULO { get; set; }

        [Required]
        [StringLength(100)]
        public string NOMBRE { get; set; }

        [Required]
        [StringLength(100)]
        public string APELLIDOS { get; set; }

        [StringLength(100)]
        public string ALIAS { get; set; }

        [StringLength(50)]
        public string TELEFONO { get; set; }

        [StringLength(10)]
        public string EXTENSION { get; set; }

        [StringLength(50)]
        public string CELULAR { get; set; }

        [StringLength(50)]
        public string CORREO { get; set; }

        [StringLength(100)]
        public string NOTAS { get; set; }

        public int IDUSUARIO { get; set; }

        public DateTime FECHA { get; set; }

        public int IDUSUARIOACTUALIZO { get; set; }

        public DateTime FECHAACTUALIZO { get; set; }

        public bool ACTIVO { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        public virtual USUARIO USUARIO1 { get; set; }
    }
}
