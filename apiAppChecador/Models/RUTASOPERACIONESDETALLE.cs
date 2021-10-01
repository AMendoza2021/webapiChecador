namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FABRICACION.RUTASOPERACIONESDETALLE")]
    public partial class RUTASOPERACIONESDETALLE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RUTASOPERACIONESDETALLE()
        {
            RUTASOPERACIONESDETALLE1 = new HashSet<RUTASOPERACIONESDETALLE>();
        }

        [Key]
        public int IDRutaDetalle { get; set; }

        public int? IDRuta { get; set; }

        public int IDEmpresa { get; set; }

        public int IDSucursal { get; set; }

        public int IDCentroTrabajo { get; set; }

        public int IDEscenario { get; set; }

        public int IDEtapa { get; set; }

        public int? IDEtapaOperacion { get; set; }

        public int? IDOperacion { get; set; }

        public int? Clave { get; set; }

        public int? IDRutaDetalleSiguiente { get; set; }

        public int? ClaveSiguiente { get; set; }

        public decimal? PorcentajeDestruccion { get; set; }

        public decimal? FactorConsumo { get; set; }

        [StringLength(1)]
        public string RiesgoBMA { get; set; }

        public decimal? TiempoEsperaPrevio { get; set; }

        public decimal? TiempoConfiguracion { get; set; }

        public decimal? TiempoOperacion { get; set; }

        public decimal? CantidadProceso { get; set; }

        public decimal? TiempoTransito { get; set; }

        public decimal? TiempoEsperaPosterior { get; set; }

        public int? IDUsuario { get; set; }

        public DateTime? Fecha { get; set; }

        public int? IDUsuarioActualizo { get; set; }

        public DateTime? FechaActualizo { get; set; }

        public bool? Activo { get; set; }

        public virtual CENTROSTRABAJO CENTROSTRABAJO { get; set; }

        public virtual ESCENARIO ESCENARIO { get; set; }

        public virtual ETAPAS ETAPAS { get; set; }

        public virtual ETAPASOPERACIONES ETAPASOPERACIONES { get; set; }

        public virtual OPERACIONES OPERACIONES { get; set; }

        public virtual RUTASOPERACIONES RUTASOPERACIONES { get; set; }

        public virtual EMPRESA1 EMPRESA1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RUTASOPERACIONESDETALLE> RUTASOPERACIONESDETALLE1 { get; set; }

        public virtual RUTASOPERACIONESDETALLE RUTASOPERACIONESDETALLE2 { get; set; }

        public virtual SUCURSAL SUCURSAL { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        public virtual USUARIO USUARIO1 { get; set; }
    }
}
