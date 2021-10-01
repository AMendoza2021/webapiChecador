namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("INVENTARIO.INVENTARIODETALLE")]
    public partial class INVENTARIODETALLE
    {
        [Key]
        public int IDREG { get; set; }

        public int? IDINVENTARIO { get; set; }

        public int? IDCONFIGURACION { get; set; }

        public int? IDALMACEN { get; set; }

        public int? IDLOCALIDAD { get; set; }

        public int? IDCATEGORIA { get; set; }

        public int? IDSUBCATEGORIA { get; set; }

        public int? IDPRODUCTO { get; set; }

        public int? IDUNIDADMEDIDA { get; set; }

        public int? IDEXISTENCIA { get; set; }

        public bool? EXISTENTE { get; set; }

        public int? FOLIO { get; set; }

        [StringLength(20)]
        public string CODIGO { get; set; }

        [StringLength(50)]
        public string NOLOTE { get; set; }

        [StringLength(50)]
        public string NOPRODUCTO { get; set; }

        [StringLength(1000)]
        public string PRODUCTODESCRIPCION { get; set; }

        public decimal? COSTOESTANDAR { get; set; }

        public decimal? EXISTENCIATEORICA { get; set; }

        public DateTime? FECHAEXISTENCIATEORICA { get; set; }

        public decimal? EXISTENCIAFISICA { get; set; }

        [StringLength(1000)]
        public string OBSERVACIONES { get; set; }

        public bool? HASPRIMERCONTEO { get; set; }

        public decimal? PRIMERCONTEO { get; set; }

        public DateTime? FECHAPRIMERCONTEO { get; set; }

        public int? IDUSUARIOPRIMERCONTEO { get; set; }

        public bool? HASSEGUNDOCONTEO { get; set; }

        public decimal? SEGUNDOCONTEO { get; set; }

        public DateTime? FECHASEGUNDOCONTEO { get; set; }

        public int? IDUSUARIOSEGUNDOCONTEO { get; set; }

        public bool? HASTERCERCONTEO { get; set; }

        public decimal? TERCERCONTEO { get; set; }

        public DateTime? FECHATERCERCONTEO { get; set; }

        public int? IDUSUARIOTERCERCONTEO { get; set; }

        public bool? AJUSTEREALIZADO { get; set; }

        [StringLength(50)]
        public string AJUSTEFOLIO { get; set; }

        [StringLength(100)]
        public string PRODUCTONOMBRE { get; set; }

        public int? IDUSUARIOREALIZOPRIMERCONTEO { get; set; }

        public int? IDUSUARIOREALIZOSEGUNDOCONTEO { get; set; }

        public int? IDUSUARIOREALIZOTERCERCONTEO { get; set; }

        public virtual ALMACEN ALMACEN { get; set; }

        public virtual ALMACENLOCALIDAD ALMACENLOCALIDAD { get; set; }

        public virtual CATEGORIA CATEGORIA { get; set; }

        public virtual EXISTENCIA EXISTENCIA { get; set; }

        public virtual PRODUCTO PRODUCTO { get; set; }

        public virtual SUBCATEGORIA SUBCATEGORIA { get; set; }

        public virtual UNIDADMEDIDA UNIDADMEDIDA { get; set; }

        public virtual INVENTARIO INVENTARIO { get; set; }

        public virtual INVENTARIOCONFIGURACION INVENTARIOCONFIGURACION { get; set; }
    }
}
