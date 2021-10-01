namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CONTABILIDAD.ACTIVOSFIJOS")]
    public partial class ACTIVOSFIJOS
    {
        [Key]
        public int IDActivo { get; set; }

        public int? IDEmpresa { get; set; }

        public int? IDSucursal { get; set; }

        public int? IDDepartamento { get; set; }

        public int? IDArea { get; set; }

        [StringLength(15)]
        public string NoPedimento { get; set; }

        public DateTime? FechaPedimento { get; set; }

        public int? IDProveedor { get; set; }

        [StringLength(50)]
        public string Marca { get; set; }

        [StringLength(50)]
        public string Modelo { get; set; }

        [StringLength(50)]
        public string NoSerie { get; set; }

        public decimal? Subtotal { get; set; }

        public decimal? Iva { get; set; }

        public decimal? Total { get; set; }

        public int? IDSituacion { get; set; }

        public DateTime? FechaInicioUso { get; set; }

        public DateTime? Fecha { get; set; }

        public int IDUsuario { get; set; }

        public int IDUsuarioActualizo { get; set; }

        public DateTime? FechaActualizo { get; set; }

        public bool? Activo { get; set; }

        [StringLength(1000)]
        public string Descripcion { get; set; }

        public int? IDUsuarioFinal { get; set; }

        public int? IDUsuarioResguardo { get; set; }

        [Required]
        [StringLength(1000)]
        public string Nombre { get; set; }

        [StringLength(1000)]
        public string Comentarios { get; set; }

        public int? IDCategoria { get; set; }

        public int? IDSubcategoria { get; set; }

        [Required]
        [StringLength(50)]
        public string Codigo { get; set; }

        public int? IDCompra { get; set; }

        [StringLength(1)]
        public string Tipo { get; set; }

        public int? IDAseguradora { get; set; }

        public int? IDCompraDetalle { get; set; }

        public int? Depreciacion { get; set; }

        public virtual COMPRA COMPRA { get; set; }

        public virtual COMPRADETALLE COMPRADETALLE { get; set; }

        public virtual ACTIVOSFIJOSCATEGORIAS ACTIVOSFIJOSCATEGORIAS { get; set; }

        public virtual ACTIVOSFIJOSSUBCATEGORIAS ACTIVOSFIJOSSUBCATEGORIAS { get; set; }

        public virtual AREAS AREAS { get; set; }

        public virtual DEPARTAMENTO DEPARTAMENTO { get; set; }

        public virtual EMPRESA1 EMPRESA1 { get; set; }

        public virtual SUCURSAL SUCURSAL { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        public virtual USUARIO USUARIO1 { get; set; }

        public virtual USUARIO USUARIO2 { get; set; }

        public virtual USUARIO USUARIO3 { get; set; }
    }
}
