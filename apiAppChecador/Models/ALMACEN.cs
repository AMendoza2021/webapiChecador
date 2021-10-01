namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ALMACEN.ALMACEN")]
    public partial class ALMACEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ALMACEN()
        {
            ALMACENLOCALIDAD = new HashSet<ALMACENLOCALIDAD>();
            EXISTENCIAACTUAL = new HashSet<EXISTENCIAACTUAL>();
            EXISTENCIADETALLE = new HashSet<EXISTENCIADETALLE>();
            INVENTARIOCONFIGURACION = new HashSet<INVENTARIOCONFIGURACION>();
            INVENTARIODETALLE = new HashSet<INVENTARIODETALLE>();
            NOTASDEVOLUCIONDETALLE = new HashSet<NOTASDEVOLUCIONDETALLE>();
            REGISTROVENTADETALLE = new HashSet<REGISTROVENTADETALLE>();
        }

        [Key]
        public int IDALMACEN { get; set; }

        public bool? ACTIVO { get; set; }

        public int? IDEMPRESA { get; set; }

        public int? IDSUCURSAL { get; set; }

        [StringLength(3)]
        public string TIPO { get; set; }

        [StringLength(20)]
        public string CLAVE { get; set; }

        [StringLength(100)]
        public string NOMBRE { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public virtual EMPRESA1 EMPRESA1 { get; set; }

        public virtual SUCURSAL SUCURSAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ALMACENLOCALIDAD> ALMACENLOCALIDAD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EXISTENCIAACTUAL> EXISTENCIAACTUAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EXISTENCIADETALLE> EXISTENCIADETALLE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INVENTARIOCONFIGURACION> INVENTARIOCONFIGURACION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INVENTARIODETALLE> INVENTARIODETALLE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NOTASDEVOLUCIONDETALLE> NOTASDEVOLUCIONDETALLE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REGISTROVENTADETALLE> REGISTROVENTADETALLE { get; set; }
    }
}
