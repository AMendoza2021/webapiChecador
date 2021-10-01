namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FABRICACION.CENTROSTRABAJO")]
    public partial class CENTROSTRABAJO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CENTROSTRABAJO()
        {
            RUTASOPERACIONESDETALLE = new HashSet<RUTASOPERACIONESDETALLE>();
        }

        [Key]
        public int IDCentroTrabajo { get; set; }

        public int IDEmpresa { get; set; }

        public int IDSucursal { get; set; }

        public int? IDEdificio { get; set; }

        public int? IDArea { get; set; }

        public int IDTipo { get; set; }

        public int? IDSituacion { get; set; }

        [Required]
        [StringLength(50)]
        public string Clave { get; set; }

        [Required]
        [StringLength(500)]
        public string Descripcion { get; set; }

        public bool Bloqueado { get; set; }

        public decimal? TiempoEsperaPrevio { get; set; }

        public decimal? TiempoConfiguracion { get; set; }

        public decimal? TiempoOperacion { get; set; }

        public decimal? TiempoTransito { get; set; }

        public decimal? TiempoEsperaPosterior { get; set; }

        public decimal? Capacidad { get; set; }

        public int? IDUMCapacidad { get; set; }

        public decimal? CostoUnitDirecto { get; set; }

        public decimal? CostoIndirectoPorcentaje { get; set; }

        public decimal? TasaCostosGenerales { get; set; }

        public int? IDUMCostoUnit { get; set; }

        public int? IDCuentaMP { get; set; }

        public int? IDCuentaWIP { get; set; }

        public int? IDCuentaCostoMP { get; set; }

        public int? IDCuentaCostoOffS { get; set; }

        public int IDUsuario { get; set; }

        public DateTime? Fecha { get; set; }

        public int IDUsuarioActualizo { get; set; }

        public DateTime? FechaActualizo { get; set; }

        public bool? Activo { get; set; }

        public virtual CENTROSTRABAJOTIPOS CENTROSTRABAJOTIPOS { get; set; }

        public virtual EDIFICIOS EDIFICIOS { get; set; }

        public virtual EMPRESA1 EMPRESA1 { get; set; }

        public virtual SUCURSAL SUCURSAL { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        public virtual USUARIO USUARIO1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RUTASOPERACIONESDETALLE> RUTASOPERACIONESDETALLE { get; set; }
    }
}
