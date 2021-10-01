namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RH.EMPLEADO")]
    public partial class EMPLEADO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EMPLEADO()
        {
            ALMACEN1 = new HashSet<ALMACEN1>();
            INFORMATICAASIGNACION = new HashSet<INFORMATICAASIGNACION>();
            INFORMATICAUSUARIO = new HashSet<INFORMATICAUSUARIO>();
            RH = new HashSet<RH>();
            CHECADA = new HashSet<CHECADA>();
            USUARIO = new HashSet<USUARIO>();
            USUARIOCHECAEMPLEADO = new HashSet<USUARIOCHECAEMPLEADO>();
            VALE = new HashSet<VALE>();
        }

        [Key]
        public int IDEMPLEADO { get; set; }

        public bool? ACTIVO { get; set; }

        public int? NOEMPLEADO { get; set; }

        [StringLength(50)]
        public string NOMBRE { get; set; }

        [StringLength(50)]
        public string APATERNO { get; set; }

        [StringLength(50)]
        public string AMATERNO { get; set; }

        public int? IDEMPRESA { get; set; }

        public int? IDSUCURSAL { get; set; }

        public int? IDDEPARTAMENTO { get; set; }

        public int? IDJEFEINMEDIATO { get; set; }

        public int? IDPUESTO { get; set; }

        public DateTime? FECHAALTA { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public DateTime? FECHANACIMIENTO { get; set; }

        [StringLength(15)]
        public string NSS { get; set; }

        [StringLength(100)]
        public string PUESTO { get; set; }

        public byte[] FOTO { get; set; }

        [StringLength(20)]
        public string REGISTROPATRONAL { get; set; }

        [StringLength(20)]
        public string RFC { get; set; }

        [StringLength(20)]
        public string CURP { get; set; }

        public bool? FORANEO { get; set; }

        public Guid? IDCOMENTARIO { get; set; }

        public bool? EXPEDIENTEPRIVADO { get; set; }

        public DateTime? FECHAINGRESO { get; set; }

        public virtual DEPARTAMENTO1 DEPARTAMENTO1 { get; set; }

        public virtual EMPRESA1 EMPRESA1 { get; set; }

        public virtual SUCURSAL SUCURSAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ALMACEN1> ALMACEN1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INFORMATICAASIGNACION> INFORMATICAASIGNACION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INFORMATICAUSUARIO> INFORMATICAUSUARIO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RH> RH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHECADA> CHECADA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USUARIO> USUARIO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USUARIOCHECAEMPLEADO> USUARIOCHECAEMPLEADO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VALE> VALE { get; set; }
    }
}
