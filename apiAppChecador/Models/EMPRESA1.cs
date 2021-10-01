namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NEGOCIO.EMPRESA")]
    public partial class EMPRESA1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EMPRESA1()
        {
            ALMACEN = new HashSet<ALMACEN>();
            CATEGORIA = new HashSet<CATEGORIA>();
            EXISTENCIA = new HashSet<EXISTENCIA>();
            PRODUCTO = new HashSet<PRODUCTO>();
            PRODUCTOSUCURSAL = new HashSet<PRODUCTOSUCURSAL>();
            SUBCATEGORIA = new HashSet<SUBCATEGORIA>();
            TRASLADOS = new HashSet<TRASLADOS>();
            COMPRA = new HashSet<COMPRA>();
            COMPRAAUTORIZA = new HashSet<COMPRAAUTORIZA>();
            CUENTASCORREO = new HashSet<CUENTASCORREO>();
            EMPRESALOGO = new HashSet<EMPRESALOGO>();
            TIPODOCUMENTO1 = new HashSet<TIPODOCUMENTO1>();
            ACTIVOSFIJOS = new HashSet<ACTIVOSFIJOS>();
            ACTIVOSFIJOSCATEGORIAS = new HashSet<ACTIVOSFIJOSCATEGORIAS>();
            ACTIVOSFIJOSSUBCATEGORIAS = new HashSet<ACTIVOSFIJOSSUBCATEGORIAS>();
            CUENTASCOSTOS = new HashSet<CUENTASCOSTOS>();
            NOTASCREDITO = new HashSet<NOTASCREDITO>();
            NOTASDEVOLUCION = new HashSet<NOTASDEVOLUCION>();
            CENTROSCOSTOS = new HashSet<CENTROSCOSTOS>();
            ORDENCOSTEOSUBTIPO = new HashSet<ORDENCOSTEOSUBTIPO>();
            ORDENCOSTEOTIPO = new HashSet<ORDENCOSTEOTIPO>();
            CFDI = new HashSet<CFDI>();
            CENTROSTRABAJO = new HashSet<CENTROSTRABAJO>();
            CENTROSTRABAJOTIPOS = new HashSet<CENTROSTRABAJOTIPOS>();
            EDIFICIOS = new HashSet<EDIFICIOS>();
            ESCENARIO = new HashSet<ESCENARIO>();
            ETAPAS = new HashSet<ETAPAS>();
            ETAPASOPERACIONES = new HashSet<ETAPASOPERACIONES>();
            ETAPASSUBOPERACIONES = new HashSet<ETAPASSUBOPERACIONES>();
            OPERACIONES = new HashSet<OPERACIONES>();
            RUTASOPERACIONESDETALLE = new HashSet<RUTASOPERACIONESDETALLE>();
            CONFIGURACIONSELLOS = new HashSet<CONFIGURACIONSELLOS>();
            EMPRESAUSUARIOAUTORIZA = new HashSet<EMPRESAUSUARIOAUTORIZA>();
            FACTURAS = new HashSet<FACTURAS>();
            PAGOS = new HashSet<PAGOS>();
            PAGOSHISTORIAL = new HashSet<PAGOSHISTORIAL>();
            REFERENCIASBANCARIASNEGOCIO = new HashSet<REFERENCIASBANCARIASNEGOCIO>();
            CLIENTES = new HashSet<CLIENTES>();
            CLIENTESHISTORIAL = new HashSet<CLIENTESHISTORIAL>();
            INVENTARIO = new HashSet<INVENTARIO>();
            AREA = new HashSet<AREA>();
            AREAS1 = new HashSet<AREAS1>();
            CLIENTES2 = new HashSet<CLIENTES2>();
            CUENTAS1 = new HashSet<CUENTAS1>();
            DEPARTAMENTOS = new HashSet<DEPARTAMENTOS>();
            ALMACEN1 = new HashSet<ALMACEN1>();
            COMPRA1 = new HashSet<COMPRA1>();
            COMPRAAUTORIZA1 = new HashSet<COMPRAAUTORIZA1>();
            PLANMAESTROPRODUCCION = new HashSet<PLANMAESTROPRODUCCION>();
            EMPLEADO = new HashSet<EMPLEADO>();
            EMPRESADATOS = new HashSet<EMPRESADATOS>();
            IMPORTACION = new HashSet<IMPORTACION>();
            INFORMATICA = new HashSet<INFORMATICA>();
            INFORMATICAUSUARIO = new HashSet<INFORMATICAUSUARIO>();
            PEDIDOS = new HashSet<PEDIDOS>();
            PERFILCREDITO = new HashSet<PERFILCREDITO>();
            PERFILCREDITOHISTORICO = new HashSet<PERFILCREDITOHISTORICO>();
            PRECIOVENTALISTA = new HashSet<PRECIOVENTALISTA>();
            PROGRAMA = new HashSet<PROGRAMA>();
            PROVEEDOR = new HashSet<PROVEEDOR>();
            REGISTROVENTA = new HashSet<REGISTROVENTA>();
            REGISTROVENTAHISTORIAL = new HashSet<REGISTROVENTAHISTORIAL>();
            RH = new HashSet<RH>();
            SERVICIO = new HashSet<SERVICIO>();
            SERVICIOCATEGORIA = new HashSet<SERVICIOCATEGORIA>();
            SERVICIOGRUPO = new HashSet<SERVICIOGRUPO>();
            SERVICIOHISTORIAL = new HashSet<SERVICIOHISTORIAL>();
            SERVICIOSUBCATEGORIA = new HashSet<SERVICIOSUBCATEGORIA>();
            SERVICIOTIPO = new HashSet<SERVICIOTIPO>();
            SUCURSAL = new HashSet<SUCURSAL>();
            USUARIOSUCURSAL = new HashSet<USUARIOSUCURSAL>();
            ZONAS = new HashSet<ZONAS>();
        }

        [Key]
        public int IDEMPRESA { get; set; }

        public bool? ACTIVO { get; set; }

        [StringLength(100)]
        public string NOMBRE { get; set; }

        [StringLength(100)]
        public string RAZONSOCIAL { get; set; }

        [StringLength(14)]
        public string RFC { get; set; }

        public int? IDDOMICILIO { get; set; }

        public DateTime? FECHA { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHACTUALIZO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ALMACEN> ALMACEN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CATEGORIA> CATEGORIA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EXISTENCIA> EXISTENCIA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCTO> PRODUCTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCTOSUCURSAL> PRODUCTOSUCURSAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SUBCATEGORIA> SUBCATEGORIA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRASLADOS> TRASLADOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPRA> COMPRA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPRAAUTORIZA> COMPRAAUTORIZA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CUENTASCORREO> CUENTASCORREO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPRESALOGO> EMPRESALOGO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TIPODOCUMENTO1> TIPODOCUMENTO1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACTIVOSFIJOS> ACTIVOSFIJOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACTIVOSFIJOSCATEGORIAS> ACTIVOSFIJOSCATEGORIAS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACTIVOSFIJOSSUBCATEGORIAS> ACTIVOSFIJOSSUBCATEGORIAS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CUENTASCOSTOS> CUENTASCOSTOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NOTASCREDITO> NOTASCREDITO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NOTASDEVOLUCION> NOTASDEVOLUCION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CENTROSCOSTOS> CENTROSCOSTOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORDENCOSTEOSUBTIPO> ORDENCOSTEOSUBTIPO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORDENCOSTEOTIPO> ORDENCOSTEOTIPO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CFDI> CFDI { get; set; }

        public virtual DOMICILIO DOMICILIO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CENTROSTRABAJO> CENTROSTRABAJO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CENTROSTRABAJOTIPOS> CENTROSTRABAJOTIPOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EDIFICIOS> EDIFICIOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ESCENARIO> ESCENARIO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ETAPAS> ETAPAS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ETAPASOPERACIONES> ETAPASOPERACIONES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ETAPASSUBOPERACIONES> ETAPASSUBOPERACIONES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OPERACIONES> OPERACIONES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RUTASOPERACIONESDETALLE> RUTASOPERACIONESDETALLE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONFIGURACIONSELLOS> CONFIGURACIONSELLOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPRESAUSUARIOAUTORIZA> EMPRESAUSUARIOAUTORIZA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACTURAS> FACTURAS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PAGOS> PAGOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PAGOSHISTORIAL> PAGOSHISTORIAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REFERENCIASBANCARIASNEGOCIO> REFERENCIASBANCARIASNEGOCIO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIENTES> CLIENTES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIENTESHISTORIAL> CLIENTESHISTORIAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INVENTARIO> INVENTARIO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AREA> AREA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AREAS1> AREAS1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIENTES2> CLIENTES2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CUENTAS1> CUENTAS1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DEPARTAMENTOS> DEPARTAMENTOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ALMACEN1> ALMACEN1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPRA1> COMPRA1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPRAAUTORIZA1> COMPRAAUTORIZA1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PLANMAESTROPRODUCCION> PLANMAESTROPRODUCCION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPLEADO> EMPLEADO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPRESADATOS> EMPRESADATOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IMPORTACION> IMPORTACION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INFORMATICA> INFORMATICA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INFORMATICAUSUARIO> INFORMATICAUSUARIO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PEDIDOS> PEDIDOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERFILCREDITO> PERFILCREDITO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERFILCREDITOHISTORICO> PERFILCREDITOHISTORICO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRECIOVENTALISTA> PRECIOVENTALISTA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROGRAMA> PROGRAMA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROVEEDOR> PROVEEDOR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REGISTROVENTA> REGISTROVENTA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REGISTROVENTAHISTORIAL> REGISTROVENTAHISTORIAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RH> RH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SERVICIO> SERVICIO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SERVICIOCATEGORIA> SERVICIOCATEGORIA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SERVICIOGRUPO> SERVICIOGRUPO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SERVICIOHISTORIAL> SERVICIOHISTORIAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SERVICIOSUBCATEGORIA> SERVICIOSUBCATEGORIA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SERVICIOTIPO> SERVICIOTIPO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SUCURSAL> SUCURSAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USUARIOSUCURSAL> USUARIOSUCURSAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ZONAS> ZONAS { get; set; }
    }
}
