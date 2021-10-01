namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MIGRACION.ALMACENEXISTENCIA")]
    public partial class ALMACENEXISTENCIA
    {
        [Key]
        [Column(Order = 0)]
        public int IDControl { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDSucursal { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid IDSucursalLarissa { get; set; }

        public int? IDProducto { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid IDProductoLarissa { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string NoParte { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal Existencia { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(50)]
        public string Lote { get; set; }

        [Key]
        [Column(Order = 7)]
        public DateTime FechaFabricacion { get; set; }

        [Key]
        [Column(Order = 8)]
        public DateTime FechaCaducidad { get; set; }

        [Key]
        [Column(Order = 9)]
        public bool Disponible { get; set; }

        [Key]
        [Column(Order = 10)]
        public Guid OrigenAlmacen { get; set; }

        [Key]
        [Column(Order = 11)]
        public Guid OrigenAlmacenLocalidad { get; set; }

        public int? DestinoAlmacen { get; set; }

        public int? DestinoAlmacenLocalidad { get; set; }

        [Key]
        [Column(Order = 12)]
        public DateTime Fecha { get; set; }

        public bool? ModificoFechaFab { get; set; }

        public bool? ModificoFechaCad { get; set; }

        public bool? Registrar { get; set; }

        public bool? Registrado { get; set; }
    }
}
