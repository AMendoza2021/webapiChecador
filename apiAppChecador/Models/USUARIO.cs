namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SEGURIDAD.USUARIO")]
    public partial class USUARIO
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public USUARIO()
        //{
        //    ENVIO = new HashSet<ENVIO>();
        //    ENVIO1 = new HashSet<ENVIO>();
        //    ENVIO2 = new HashSet<ENVIO>();
        //    ENVIO3 = new HashSet<ENVIO>();
        //    ENVIO4 = new HashSet<ENVIO>();
        //    ENVIO5 = new HashSet<ENVIO>();
        //    ENVIODETALLE = new HashSet<ENVIODETALLE>();
        //    ENVIOREGISTROVENTA = new HashSet<ENVIOREGISTROVENTA>();
        //    ESTATUSENVIO = new HashSet<ESTATUSENVIO>();
        //    EXISTENCIADETALLE = new HashSet<EXISTENCIADETALLE>();
        //    PRODUCTO = new HashSet<PRODUCTO>();
        //    PRODUCTO1 = new HashSet<PRODUCTO>();
        //    TRASLADOS = new HashSet<TRASLADOS>();
        //    TRASLADOS1 = new HashSet<TRASLADOS>();
        //    ARCHIVOADJUNTO = new HashSet<ARCHIVOADJUNTO>();
        //    BANCO = new HashSet<BANCO>();
        //    COMPANIATRANSPORTISTA = new HashSet<COMPANIATRANSPORTISTA>();
        //    COMUNICACION = new HashSet<COMUNICACION>();
        //    COMUNICACION1 = new HashSet<COMUNICACION>();
        //    CONTACTOS = new HashSet<CONTACTOS>();
        //    CONTACTOS1 = new HashSet<CONTACTOS>();
        //    DEVOLUCIONCATEGORIA = new HashSet<DEVOLUCIONCATEGORIA>();
        //    DEVOLUCIONCATEGORIA1 = new HashSet<DEVOLUCIONCATEGORIA>();
        //    DEVOLUCIONSUBCATEGORIA = new HashSet<DEVOLUCIONSUBCATEGORIA>();
        //    DEVOLUCIONSUBCATEGORIA1 = new HashSet<DEVOLUCIONSUBCATEGORIA>();
        //    ETAPAFABRICACION = new HashSet<ETAPAFABRICACION>();
        //    FORMAFARMACEUTICA = new HashSet<FORMAFARMACEUTICA>();
        //    FORMULAMAESTRADETALLE = new HashSet<FORMULAMAESTRADETALLE>();
        //    FORMULAMAESTRATAMANO = new HashSet<FORMULAMAESTRATAMANO>();
        //    IMPUESTOS = new HashSet<IMPUESTOS>();
        //    IMPUESTOS1 = new HashSet<IMPUESTOS>();
        //    MONEDAS = new HashSet<MONEDAS>();
        //    MONEDAS1 = new HashSet<MONEDAS>();
        //    PRODUCTOACONDICIONAMIENTOETAPA = new HashSet<PRODUCTOACONDICIONAMIENTOETAPA>();
        //    PRODUCTOFABRICACIONETAPA = new HashSet<PRODUCTOFABRICACIONETAPA>();
        //    PRODUCTOVENTAEMPLEADO = new HashSet<PRODUCTOVENTAEMPLEADO>();
        //    SITUACION = new HashSet<SITUACION>();
        //    SITUACION1 = new HashSet<SITUACION>();
        //    UNIDADMEDIDA = new HashSet<UNIDADMEDIDA>();
        //    USOCFDI = new HashSet<USOCFDI>();
        //    USOCFDI1 = new HashSet<USOCFDI>();
        //    COMPRA = new HashSet<COMPRA>();
        //    COMPRA1 = new HashSet<COMPRA>();
        //    COMPRA2 = new HashSet<COMPRA>();
        //    COMPRA3 = new HashSet<COMPRA>();
        //    COMPRA4 = new HashSet<COMPRA>();
        //    COMPRAAUTORIZA = new HashSet<COMPRAAUTORIZA>();
        //    CUENTASCORREO = new HashSet<CUENTASCORREO>();
        //    CUENTASCORREO1 = new HashSet<CUENTASCORREO>();
        //    FLUJOS = new HashSet<FLUJOS>();
        //    FLUJOS1 = new HashSet<FLUJOS>();
        //    TIPODOCUMENTO1 = new HashSet<TIPODOCUMENTO1>();
        //    TIPODOCUMENTO11 = new HashSet<TIPODOCUMENTO1>();
        //    ACTIVOSFIJOS = new HashSet<ACTIVOSFIJOS>();
        //    ACTIVOSFIJOS1 = new HashSet<ACTIVOSFIJOS>();
        //    ACTIVOSFIJOS2 = new HashSet<ACTIVOSFIJOS>();
        //    ACTIVOSFIJOS3 = new HashSet<ACTIVOSFIJOS>();
        //    ACTIVOSFIJOSCATEGORIAS = new HashSet<ACTIVOSFIJOSCATEGORIAS>();
        //    ACTIVOSFIJOSCATEGORIAS1 = new HashSet<ACTIVOSFIJOSCATEGORIAS>();
        //    ACTIVOSFIJOSSUBCATEGORIAS = new HashSet<ACTIVOSFIJOSSUBCATEGORIAS>();
        //    ACTIVOSFIJOSSUBCATEGORIAS1 = new HashSet<ACTIVOSFIJOSSUBCATEGORIAS>();
        //    CUENTASCLIENTES = new HashSet<CUENTASCLIENTES>();
        //    CUENTASCOSTOS = new HashSet<CUENTASCOSTOS>();
        //    CUENTASCOSTOS1 = new HashSet<CUENTASCOSTOS>();
        //    NOTASCREDITOCFDI = new HashSet<NOTASCREDITOCFDI>();
        //    NOTASDEVOLUCION = new HashSet<NOTASDEVOLUCION>();
        //    NOTASDEVOLUCION1 = new HashSet<NOTASDEVOLUCION>();
        //    NOTASDEVOLUCIONCFDI = new HashSet<NOTASDEVOLUCIONCFDI>();
        //    NOTASDEVOLUCIONDETALLE = new HashSet<NOTASDEVOLUCIONDETALLE>();
        //    ORDENCOSTEOSUBTIPO = new HashSet<ORDENCOSTEOSUBTIPO>();
        //    ORDENCOSTEOSUBTIPO1 = new HashSet<ORDENCOSTEOSUBTIPO>();
        //    ORDENCOSTEOTIPO = new HashSet<ORDENCOSTEOTIPO>();
        //    ORDENCOSTEOTIPO1 = new HashSet<ORDENCOSTEOTIPO>();
        //    PAGO = new HashSet<PAGO>();
        //    CENTROSTRABAJO = new HashSet<CENTROSTRABAJO>();
        //    CENTROSTRABAJO1 = new HashSet<CENTROSTRABAJO>();
        //    CENTROSTRABAJOTIPOS = new HashSet<CENTROSTRABAJOTIPOS>();
        //    CENTROSTRABAJOTIPOS1 = new HashSet<CENTROSTRABAJOTIPOS>();
        //    EDIFICIOS = new HashSet<EDIFICIOS>();
        //    EDIFICIOS1 = new HashSet<EDIFICIOS>();
        //    ESCENARIO = new HashSet<ESCENARIO>();
        //    ESCENARIO1 = new HashSet<ESCENARIO>();
        //    ETAPAS = new HashSet<ETAPAS>();
        //    ETAPAS1 = new HashSet<ETAPAS>();
        //    ETAPASOPERACIONES = new HashSet<ETAPASOPERACIONES>();
        //    ETAPASOPERACIONES1 = new HashSet<ETAPASOPERACIONES>();
        //    ETAPASSUBOPERACIONES = new HashSet<ETAPASSUBOPERACIONES>();
        //    ETAPASSUBOPERACIONES1 = new HashSet<ETAPASSUBOPERACIONES>();
        //    OPERACIONES = new HashSet<OPERACIONES>();
        //    OPERACIONES1 = new HashSet<OPERACIONES>();
        //    ORDENACONDICIONAMIENTOHISTORIAL = new HashSet<ORDENACONDICIONAMIENTOHISTORIAL>();
        //    PRODUCTOSECTOR = new HashSet<PRODUCTOSECTOR>();
        //    PRODUCTOSECTOR1 = new HashSet<PRODUCTOSECTOR>();
        //    RUTASOPERACIONESDETALLE = new HashSet<RUTASOPERACIONESDETALLE>();
        //    RUTASOPERACIONESDETALLE1 = new HashSet<RUTASOPERACIONESDETALLE>();
        //    ABONOS = new HashSet<ABONOS>();
        //    ABONOS1 = new HashSet<ABONOS>();
        //    ABONOSHISTORIAL = new HashSet<ABONOSHISTORIAL>();
        //    CANCELACIONCDFI = new HashSet<CANCELACIONCDFI>();
        //    CANCELACIONCDFI1 = new HashSet<CANCELACIONCDFI>();
        //    CONFIGURACIONSELLOS = new HashSet<CONFIGURACIONSELLOS>();
        //    CONFIGURACIONSELLOS1 = new HashSet<CONFIGURACIONSELLOS>();
        //    FACTURALICITACION = new HashSet<FACTURALICITACION>();
        //    FACTURALICITACION1 = new HashSet<FACTURALICITACION>();
        //    FACTURAS = new HashSet<FACTURAS>();
        //    FACTURAS1 = new HashSet<FACTURAS>();
        //    FACTURASCFDI = new HashSet<FACTURASCFDI>();
        //    FACTURASDETALLE = new HashSet<FACTURASDETALLE>();
        //    PAGOS = new HashSet<PAGOS>();
        //    PAGOS1 = new HashSet<PAGOS>();
        //    PAGOSCFDI = new HashSet<PAGOSCFDI>();
        //    PAGOSCFDI1 = new HashSet<PAGOSCFDI>();
        //    PAGOSHISTORIAL = new HashSet<PAGOSHISTORIAL>();
        //    TIPOFACTURA = new HashSet<TIPOFACTURA>();
        //    TIPOFACTURA1 = new HashSet<TIPOFACTURA>();
        //    TIPOPAGO = new HashSet<TIPOPAGO>();
        //    TIPOPAGO1 = new HashSet<TIPOPAGO>();
        //    USUARIOAUTORIZA = new HashSet<USUARIOAUTORIZA>();
        //    CLIENTES = new HashSet<CLIENTES>();
        //    CLIENTES1 = new HashSet<CLIENTES>();
        //    CLIENTESHISTORIAL = new HashSet<CLIENTESHISTORIAL>();
        //    CLIENTESHISTORIAL1 = new HashSet<CLIENTESHISTORIAL>();
        //    PRODUCTO11 = new HashSet<PRODUCTO1>();
        //    PRODUCTO12 = new HashSet<PRODUCTO1>();
        //    TIPORELACIONCFDI = new HashSet<TIPORELACIONCFDI>();
        //    TIPORELACIONCFDI1 = new HashSet<TIPORELACIONCFDI>();
        //    CONFIGURACIONPRODUCTOENVIO = new HashSet<CONFIGURACIONPRODUCTOENVIO>();
        //    AREA = new HashSet<AREA>();
        //    AREA1 = new HashSet<AREA>();
        //    AREAS1 = new HashSet<AREAS1>();
        //    AREAS11 = new HashSet<AREAS1>();
        //    CLASEPROVEEDOR = new HashSet<CLASEPROVEEDOR>();
        //    CLASEPROVEEDOR1 = new HashSet<CLASEPROVEEDOR>();
        //    CLIENTELICITACION = new HashSet<CLIENTELICITACION>();
        //    CLIENTELICITACION1 = new HashSet<CLIENTELICITACION>();
        //    CLIENTES2 = new HashSet<CLIENTES2>();
        //    CLIENTES21 = new HashSet<CLIENTES2>();
        //    CLIENTESFACULTADOS = new HashSet<CLIENTESFACULTADOS>();
        //    CLIENTESFACULTADOS1 = new HashSet<CLIENTESFACULTADOS>();
        //    CUENTAS1 = new HashSet<CUENTAS1>();
        //    CUENTAS11 = new HashSet<CUENTAS1>();
        //    DEPARTAMENTOS = new HashSet<DEPARTAMENTOS>();
        //    DEPARTAMENTOS1 = new HashSet<DEPARTAMENTOS>();
        //    SUCURSAL = new HashSet<SUCURSAL>();
        //    SUCURSALESLARISSA = new HashSet<SUCURSALESLARISSA>();
        //    NOTIFICACION = new HashSet<NOTIFICACION>();
        //    NOTIFICACION1 = new HashSet<NOTIFICACION>();
        //    CATEGORIA1 = new HashSet<CATEGORIA1>();
        //    FAVORITO = new HashSet<FAVORITO>();
        //    HISTORICO = new HashSet<HISTORICO>();
        //    HISTORICO1 = new HashSet<HISTORICO>();
        //    REPORTE = new HashSet<REPORTE>();
        //    REPORTE1 = new HashSet<REPORTE>();
        //    REPORTEUSUARIO = new HashSet<REPORTEUSUARIO>();
        //    ROL = new HashSet<ROL>();
        //    ROLREPORTE = new HashSet<ROLREPORTE>();
        //    ROLUSUARIO = new HashSet<ROLUSUARIO>();
        //    SUBCATEGORIA1 = new HashSet<SUBCATEGORIA1>();
        //    ALMACENARCHIVOADJUNTO = new HashSet<ALMACENARCHIVOADJUNTO>();
        //    COMPRA11 = new HashSet<COMPRA1>();
        //    COMPRA12 = new HashSet<COMPRA1>();
        //    COMPRA13 = new HashSet<COMPRA1>();
        //    COMPRA14 = new HashSet<COMPRA1>();
        //    COMPRAAUTORIZA1 = new HashSet<COMPRAAUTORIZA1>();
        //    SERVICIO = new HashSet<SERVICIO>();
        //    SERVICIO1 = new HashSet<SERVICIO>();
        //    SERVICIO2 = new HashSet<SERVICIO>();
        //    SERVICIO3 = new HashSet<SERVICIO>();
        //    SERVICIO4 = new HashSet<SERVICIO>();
        //    SERVICIOCATEGORIA = new HashSet<SERVICIOCATEGORIA>();
        //    SERVICIOCATEGORIA1 = new HashSet<SERVICIOCATEGORIA>();
        //    SERVICIOGRUPO = new HashSet<SERVICIOGRUPO>();
        //    SERVICIOGRUPO1 = new HashSet<SERVICIOGRUPO>();
        //    SERVICIOHISTORIAL = new HashSet<SERVICIOHISTORIAL>();
        //    SERVICIOHISTORIAL1 = new HashSet<SERVICIOHISTORIAL>();
        //    SERVICIOHISTORIAL2 = new HashSet<SERVICIOHISTORIAL>();
        //    SERVICIOHISTORIAL3 = new HashSet<SERVICIOHISTORIAL>();
        //    SERVICIOSUBCATEGORIA = new HashSet<SERVICIOSUBCATEGORIA>();
        //    SERVICIOSUBCATEGORIA1 = new HashSet<SERVICIOSUBCATEGORIA>();
        //    SERVICIOTIPO = new HashSet<SERVICIOTIPO>();
        //    SERVICIOTIPO1 = new HashSet<SERVICIOTIPO>();
        //    CHECADA = new HashSet<CHECADA>();
        //    INCIDENCIA = new HashSet<INCIDENCIA>();
        //    PERIODONOMINA = new HashSet<PERIODONOMINA>();
        //    USUARIOCHECAEMPLEADO = new HashSet<USUARIOCHECAEMPLEADO>();
        //    USUARIOCHECAEMPLEADO1 = new HashSet<USUARIOCHECAEMPLEADO>();
        //    PASSWORDEMAIL = new HashSet<PASSWORDEMAIL>();
        //    IMPORTACION = new HashSet<IMPORTACION>();
        //    IMPORTACION1 = new HashSet<IMPORTACION>();
        //    PEDIDOS = new HashSet<PEDIDOS>();
        //    PEDIDOS1 = new HashSet<PEDIDOS>();
        //    PERFILCREDITO = new HashSet<PERFILCREDITO>();
        //    PERFILCREDITO1 = new HashSet<PERFILCREDITO>();
        //    PERFILCREDITOHISTORICO = new HashSet<PERFILCREDITOHISTORICO>();
        //    PRECIOVENTA = new HashSet<PRECIOVENTA>();
        //    PRECIOVENTA1 = new HashSet<PRECIOVENTA>();
        //    PRECIOVENTALISTA = new HashSet<PRECIOVENTALISTA>();
        //    PRECIOVENTALISTA1 = new HashSet<PRECIOVENTALISTA>();
        //    PRECIOVENTALISTACLIENTE = new HashSet<PRECIOVENTALISTACLIENTE>();
        //    PRECIOVENTALISTACLIENTE1 = new HashSet<PRECIOVENTALISTACLIENTE>();
        //    PROGRAMA = new HashSet<PROGRAMA>();
        //    REGISTROVENTA = new HashSet<REGISTROVENTA>();
        //    REGISTROVENTA1 = new HashSet<REGISTROVENTA>();
        //    REGISTROVENTADETALLE = new HashSet<REGISTROVENTADETALLE>();
        //    REGISTROVENTADETALLE1 = new HashSet<REGISTROVENTADETALLE>();
        //    REGISTROVENTAHISTORIAL = new HashSet<REGISTROVENTAHISTORIAL>();
        //    TARJETASPODER = new HashSet<TARJETASPODER>();
        //    TARJETASPODER1 = new HashSet<TARJETASPODER>();
        //    TARJETASPODERDETALLE = new HashSet<TARJETASPODERDETALLE>();
        //    TARJETASPODERDETALLE1 = new HashSet<TARJETASPODERDETALLE>();
        //    USUARIOMODULO = new HashSet<USUARIOMODULO>();
        //    USUARIOSUCURSAL = new HashSet<USUARIOSUCURSAL>();
        //    ZONAS = new HashSet<ZONAS>();
        //    ZONAS1 = new HashSet<ZONAS>();
        //}

        [Key]
        public int IDUSUARIO { get; set; }

        public bool? ACTIVO { get; set; }

        [Column("USUARIO")]
        [StringLength(20)]
        public string USUARIO1 { get; set; }

        public byte[] PASSWORD { get; set; }

        [StringLength(50)]
        public string NOMBRE { get; set; }

        [StringLength(50)]
        public string APELLIDO { get; set; }

        [StringLength(100)]
        public string EMAIL { get; set; }

        public int? IDEMPLEADO { get; set; }

        public int? NOEMPLEADO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int? IDESTATUS { get; set; }

        public bool? ESEXTERNO { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ENVIO> ENVIO { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ENVIO> ENVIO1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ENVIO> ENVIO2 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ENVIO> ENVIO3 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ENVIO> ENVIO4 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ENVIO> ENVIO5 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ENVIODETALLE> ENVIODETALLE { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ENVIOREGISTROVENTA> ENVIOREGISTROVENTA { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ESTATUSENVIO> ESTATUSENVIO { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<EXISTENCIADETALLE> EXISTENCIADETALLE { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PRODUCTO> PRODUCTO { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PRODUCTO> PRODUCTO1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<TRASLADOS> TRASLADOS { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<TRASLADOS> TRASLADOS1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ARCHIVOADJUNTO> ARCHIVOADJUNTO { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<BANCO> BANCO { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<COMPANIATRANSPORTISTA> COMPANIATRANSPORTISTA { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<COMUNICACION> COMUNICACION { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<COMUNICACION> COMUNICACION1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<CONTACTOS> CONTACTOS { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<CONTACTOS> CONTACTOS1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<DEVOLUCIONCATEGORIA> DEVOLUCIONCATEGORIA { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<DEVOLUCIONCATEGORIA> DEVOLUCIONCATEGORIA1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<DEVOLUCIONSUBCATEGORIA> DEVOLUCIONSUBCATEGORIA { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<DEVOLUCIONSUBCATEGORIA> DEVOLUCIONSUBCATEGORIA1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ETAPAFABRICACION> ETAPAFABRICACION { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<FORMAFARMACEUTICA> FORMAFARMACEUTICA { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<FORMULAMAESTRADETALLE> FORMULAMAESTRADETALLE { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<FORMULAMAESTRATAMANO> FORMULAMAESTRATAMANO { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<IMPUESTOS> IMPUESTOS { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<IMPUESTOS> IMPUESTOS1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<MONEDAS> MONEDAS { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<MONEDAS> MONEDAS1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PRODUCTOACONDICIONAMIENTOETAPA> PRODUCTOACONDICIONAMIENTOETAPA { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PRODUCTOFABRICACIONETAPA> PRODUCTOFABRICACIONETAPA { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PRODUCTOVENTAEMPLEADO> PRODUCTOVENTAEMPLEADO { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<SITUACION> SITUACION { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<SITUACION> SITUACION1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<UNIDADMEDIDA> UNIDADMEDIDA { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<USOCFDI> USOCFDI { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<USOCFDI> USOCFDI1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<COMPRA> COMPRA { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<COMPRA> COMPRA1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<COMPRA> COMPRA2 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<COMPRA> COMPRA3 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<COMPRA> COMPRA4 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<COMPRAAUTORIZA> COMPRAAUTORIZA { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<CUENTASCORREO> CUENTASCORREO { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<CUENTASCORREO> CUENTASCORREO1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<FLUJOS> FLUJOS { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<FLUJOS> FLUJOS1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<TIPODOCUMENTO1> TIPODOCUMENTO1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<TIPODOCUMENTO1> TIPODOCUMENTO11 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ACTIVOSFIJOS> ACTIVOSFIJOS { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ACTIVOSFIJOS> ACTIVOSFIJOS1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ACTIVOSFIJOS> ACTIVOSFIJOS2 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ACTIVOSFIJOS> ACTIVOSFIJOS3 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ACTIVOSFIJOSCATEGORIAS> ACTIVOSFIJOSCATEGORIAS { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ACTIVOSFIJOSCATEGORIAS> ACTIVOSFIJOSCATEGORIAS1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ACTIVOSFIJOSSUBCATEGORIAS> ACTIVOSFIJOSSUBCATEGORIAS { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ACTIVOSFIJOSSUBCATEGORIAS> ACTIVOSFIJOSSUBCATEGORIAS1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<CUENTASCLIENTES> CUENTASCLIENTES { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<CUENTASCOSTOS> CUENTASCOSTOS { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<CUENTASCOSTOS> CUENTASCOSTOS1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<NOTASCREDITOCFDI> NOTASCREDITOCFDI { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<NOTASDEVOLUCION> NOTASDEVOLUCION { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<NOTASDEVOLUCION> NOTASDEVOLUCION1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<NOTASDEVOLUCIONCFDI> NOTASDEVOLUCIONCFDI { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<NOTASDEVOLUCIONDETALLE> NOTASDEVOLUCIONDETALLE { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ORDENCOSTEOSUBTIPO> ORDENCOSTEOSUBTIPO { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ORDENCOSTEOSUBTIPO> ORDENCOSTEOSUBTIPO1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ORDENCOSTEOTIPO> ORDENCOSTEOTIPO { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ORDENCOSTEOTIPO> ORDENCOSTEOTIPO1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PAGO> PAGO { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<CENTROSTRABAJO> CENTROSTRABAJO { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<CENTROSTRABAJO> CENTROSTRABAJO1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<CENTROSTRABAJOTIPOS> CENTROSTRABAJOTIPOS { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<CENTROSTRABAJOTIPOS> CENTROSTRABAJOTIPOS1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<EDIFICIOS> EDIFICIOS { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<EDIFICIOS> EDIFICIOS1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ESCENARIO> ESCENARIO { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ESCENARIO> ESCENARIO1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ETAPAS> ETAPAS { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ETAPAS> ETAPAS1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ETAPASOPERACIONES> ETAPASOPERACIONES { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ETAPASOPERACIONES> ETAPASOPERACIONES1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ETAPASSUBOPERACIONES> ETAPASSUBOPERACIONES { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ETAPASSUBOPERACIONES> ETAPASSUBOPERACIONES1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<OPERACIONES> OPERACIONES { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<OPERACIONES> OPERACIONES1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ORDENACONDICIONAMIENTOHISTORIAL> ORDENACONDICIONAMIENTOHISTORIAL { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PRODUCTOSECTOR> PRODUCTOSECTOR { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PRODUCTOSECTOR> PRODUCTOSECTOR1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<RUTASOPERACIONESDETALLE> RUTASOPERACIONESDETALLE { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<RUTASOPERACIONESDETALLE> RUTASOPERACIONESDETALLE1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ABONOS> ABONOS { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ABONOS> ABONOS1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ABONOSHISTORIAL> ABONOSHISTORIAL { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<CANCELACIONCDFI> CANCELACIONCDFI { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<CANCELACIONCDFI> CANCELACIONCDFI1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<CONFIGURACIONSELLOS> CONFIGURACIONSELLOS { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<CONFIGURACIONSELLOS> CONFIGURACIONSELLOS1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<FACTURALICITACION> FACTURALICITACION { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<FACTURALICITACION> FACTURALICITACION1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<FACTURAS> FACTURAS { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<FACTURAS> FACTURAS1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<FACTURASCFDI> FACTURASCFDI { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<FACTURASDETALLE> FACTURASDETALLE { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PAGOS> PAGOS { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PAGOS> PAGOS1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PAGOSCFDI> PAGOSCFDI { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PAGOSCFDI> PAGOSCFDI1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PAGOSHISTORIAL> PAGOSHISTORIAL { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<TIPOFACTURA> TIPOFACTURA { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<TIPOFACTURA> TIPOFACTURA1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<TIPOPAGO> TIPOPAGO { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<TIPOPAGO> TIPOPAGO1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<USUARIOAUTORIZA> USUARIOAUTORIZA { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<CLIENTES> CLIENTES { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<CLIENTES> CLIENTES1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<CLIENTESHISTORIAL> CLIENTESHISTORIAL { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<CLIENTESHISTORIAL> CLIENTESHISTORIAL1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PRODUCTO1> PRODUCTO11 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PRODUCTO1> PRODUCTO12 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<TIPORELACIONCFDI> TIPORELACIONCFDI { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<TIPORELACIONCFDI> TIPORELACIONCFDI1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<CONFIGURACIONPRODUCTOENVIO> CONFIGURACIONPRODUCTOENVIO { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<AREA> AREA { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<AREA> AREA1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<AREAS1> AREAS1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<AREAS1> AREAS11 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<CLASEPROVEEDOR> CLASEPROVEEDOR { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<CLASEPROVEEDOR> CLASEPROVEEDOR1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<CLIENTELICITACION> CLIENTELICITACION { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<CLIENTELICITACION> CLIENTELICITACION1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<CLIENTES2> CLIENTES2 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<CLIENTES2> CLIENTES21 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<CLIENTESFACULTADOS> CLIENTESFACULTADOS { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<CLIENTESFACULTADOS> CLIENTESFACULTADOS1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<CUENTAS1> CUENTAS1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<CUENTAS1> CUENTAS11 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<DEPARTAMENTOS> DEPARTAMENTOS { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<DEPARTAMENTOS> DEPARTAMENTOS1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<SUCURSAL> SUCURSAL { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<SUCURSALESLARISSA> SUCURSALESLARISSA { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<NOTIFICACION> NOTIFICACION { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<NOTIFICACION> NOTIFICACION1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<CATEGORIA1> CATEGORIA1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<FAVORITO> FAVORITO { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<HISTORICO> HISTORICO { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<HISTORICO> HISTORICO1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<REPORTE> REPORTE { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<REPORTE> REPORTE1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<REPORTEUSUARIO> REPORTEUSUARIO { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ROL> ROL { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ROLREPORTE> ROLREPORTE { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ROLUSUARIO> ROLUSUARIO { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<SUBCATEGORIA1> SUBCATEGORIA1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ALMACENARCHIVOADJUNTO> ALMACENARCHIVOADJUNTO { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<COMPRA1> COMPRA11 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<COMPRA1> COMPRA12 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<COMPRA1> COMPRA13 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<COMPRA1> COMPRA14 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<COMPRAAUTORIZA1> COMPRAAUTORIZA1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<SERVICIO> SERVICIO { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<SERVICIO> SERVICIO1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<SERVICIO> SERVICIO2 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<SERVICIO> SERVICIO3 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<SERVICIO> SERVICIO4 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<SERVICIOCATEGORIA> SERVICIOCATEGORIA { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<SERVICIOCATEGORIA> SERVICIOCATEGORIA1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<SERVICIOGRUPO> SERVICIOGRUPO { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<SERVICIOGRUPO> SERVICIOGRUPO1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<SERVICIOHISTORIAL> SERVICIOHISTORIAL { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<SERVICIOHISTORIAL> SERVICIOHISTORIAL1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<SERVICIOHISTORIAL> SERVICIOHISTORIAL2 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<SERVICIOHISTORIAL> SERVICIOHISTORIAL3 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<SERVICIOSUBCATEGORIA> SERVICIOSUBCATEGORIA { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<SERVICIOSUBCATEGORIA> SERVICIOSUBCATEGORIA1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<SERVICIOTIPO> SERVICIOTIPO { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<SERVICIOTIPO> SERVICIOTIPO1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<CHECADA> CHECADA { get; set; }

        //public virtual EMPLEADO EMPLEADO { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<INCIDENCIA> INCIDENCIA { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PERIODONOMINA> PERIODONOMINA { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<USUARIOCHECAEMPLEADO> USUARIOCHECAEMPLEADO { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<USUARIOCHECAEMPLEADO> USUARIOCHECAEMPLEADO1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PASSWORDEMAIL> PASSWORDEMAIL { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<IMPORTACION> IMPORTACION { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<IMPORTACION> IMPORTACION1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PEDIDOS> PEDIDOS { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PEDIDOS> PEDIDOS1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PERFILCREDITO> PERFILCREDITO { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PERFILCREDITO> PERFILCREDITO1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PERFILCREDITOHISTORICO> PERFILCREDITOHISTORICO { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PRECIOVENTA> PRECIOVENTA { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PRECIOVENTA> PRECIOVENTA1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PRECIOVENTALISTA> PRECIOVENTALISTA { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PRECIOVENTALISTA> PRECIOVENTALISTA1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PRECIOVENTALISTACLIENTE> PRECIOVENTALISTACLIENTE { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PRECIOVENTALISTACLIENTE> PRECIOVENTALISTACLIENTE1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PROGRAMA> PROGRAMA { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<REGISTROVENTA> REGISTROVENTA { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<REGISTROVENTA> REGISTROVENTA1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<REGISTROVENTADETALLE> REGISTROVENTADETALLE { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<REGISTROVENTADETALLE> REGISTROVENTADETALLE1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<REGISTROVENTAHISTORIAL> REGISTROVENTAHISTORIAL { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<TARJETASPODER> TARJETASPODER { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<TARJETASPODER> TARJETASPODER1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<TARJETASPODERDETALLE> TARJETASPODERDETALLE { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<TARJETASPODERDETALLE> TARJETASPODERDETALLE1 { get; set; }

        //public virtual USUARIOESTATUS USUARIOESTATUS { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<USUARIOMODULO> USUARIOMODULO { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<USUARIOSUCURSAL> USUARIOSUCURSAL { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ZONAS> ZONAS { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ZONAS> ZONAS1 { get; set; }
    }
}
