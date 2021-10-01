namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VENTAS.ZONAS")]
    public partial class ZONAS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ZONAS()
        {
            CLIENTES2 = new HashSet<CLIENTES2>();
        }

        [Key]
        public int IDZonaVenta { get; set; }

        public int IDEmpresa { get; set; }

        public int IDSucursal { get; set; }

        [Required]
        [StringLength(25)]
        public string Clave { get; set; }

        [Required]
        [StringLength(255)]
        public string Descripcion { get; set; }

        public int IDUsuario { get; set; }

        public DateTime? Fecha { get; set; }

        public int IDUsuarioActualizo { get; set; }

        public DateTime? FechaActualizo { get; set; }

        public bool? Activo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIENTES2> CLIENTES2 { get; set; }

        public virtual EMPRESA1 EMPRESA1 { get; set; }

        public virtual SUCURSAL SUCURSAL { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        public virtual USUARIO USUARIO1 { get; set; }
    }
}
