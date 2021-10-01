namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("REQUISICION.COMPRA")]
    public partial class COMPRA1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public COMPRA1()
        {
            ENVIO = new HashSet<ENVIO>();
            COMPRAREQUISICION = new HashSet<COMPRAREQUISICION>();
            COMPRADETALLE1 = new HashSet<COMPRADETALLE1>();
            COMPRAHISTORICO1 = new HashSet<COMPRAHISTORICO1>();
        }

        [Key]
        public int IDREQUISICION { get; set; }

        [Required]
        [StringLength(50)]
        public string FOLIO { get; set; }

        public bool? ACTIVO { get; set; }

        public int? IDESTATUS { get; set; }

        [StringLength(1000)]
        public string COMENTARIOS { get; set; }

        public int? IDDEPARTAMENTO { get; set; }

        public int? IDEMPRESA { get; set; }

        public int? IDSUCURSAL { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHACIERRE { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public int? IDUSUARIOREALIZO { get; set; }

        public int? IDUSUARIOAUTORIZA { get; set; }

        public int? IDUSUARIORECIBE { get; set; }

        public int? IDFIRMAREALIZO { get; set; }

        public int? IDFIRMAAUTORIZO { get; set; }

        public int? IDFIRMARECIBE { get; set; }

        public DateTime? FECHAENTREGA { get; set; }

        public bool? ENTREGADOMICILIO { get; set; }

        public int? IDAREA { get; set; }

        public bool? DEPARTAMENTOSUCURSAL { get; set; }

        public int? IDCUENTA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ENVIO> ENVIO { get; set; }

        public virtual ESTATUS ESTATUS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPRAREQUISICION> COMPRAREQUISICION { get; set; }

        public virtual DEPARTAMENTOSUCURSAL DEPARTAMENTOSUCURSAL1 { get; set; }

        public virtual EMPRESA1 EMPRESA1 { get; set; }

        public virtual SUCURSAL SUCURSAL { get; set; }

        public virtual FIRMADIGITAL FIRMADIGITAL { get; set; }

        public virtual FIRMADIGITAL FIRMADIGITAL1 { get; set; }

        public virtual FIRMADIGITAL FIRMADIGITAL2 { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        public virtual USUARIO USUARIO1 { get; set; }

        public virtual USUARIO USUARIO2 { get; set; }

        public virtual USUARIO USUARIO3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPRADETALLE1> COMPRADETALLE1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPRAHISTORICO1> COMPRAHISTORICO1 { get; set; }
    }
}
