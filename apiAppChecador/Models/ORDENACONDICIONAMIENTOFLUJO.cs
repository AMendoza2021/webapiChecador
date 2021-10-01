namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FABRICACION.ORDENACONDICIONAMIENTOFLUJO")]
    public partial class ORDENACONDICIONAMIENTOFLUJO
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDFLUJO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string DESCRIPCION { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string ACCION { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDSITUACIONACTUAL { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDSITUACIONNUEVO { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDUSUARIO { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime FECHA { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDUSUARIOACTUALIZO { get; set; }

        [Key]
        [Column(Order = 8)]
        public DateTime FECHAACTUALIZO { get; set; }

        [Key]
        [Column(Order = 9)]
        public bool ACTIVO { get; set; }
    }
}
