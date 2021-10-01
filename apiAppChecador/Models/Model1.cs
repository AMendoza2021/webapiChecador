using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace apiAppChecador.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=ModelRegistros")
        {
        }

        public virtual DbSet<ALMACEN> ALMACEN { get; set; }
        public virtual DbSet<ALMACENLOCALIDAD> ALMACENLOCALIDAD { get; set; }
        public virtual DbSet<CATEGORIA> CATEGORIA { get; set; }
        public virtual DbSet<ENVIO> ENVIO { get; set; }
        public virtual DbSet<ENVIODETALLE> ENVIODETALLE { get; set; }
        public virtual DbSet<ENVIOFLUJO> ENVIOFLUJO { get; set; }
        public virtual DbSet<ENVIOHISTORICO> ENVIOHISTORICO { get; set; }
        public virtual DbSet<ENVIOREGISTROVENTA> ENVIOREGISTROVENTA { get; set; }
        public virtual DbSet<ESTATUSENVIO> ESTATUSENVIO { get; set; }
        public virtual DbSet<EXISTENCIA> EXISTENCIA { get; set; }
        public virtual DbSet<EXISTENCIAANALISIS> EXISTENCIAANALISIS { get; set; }
        public virtual DbSet<EXISTENCIADETALLE> EXISTENCIADETALLE { get; set; }
        public virtual DbSet<INVENTARIOESTATUS> INVENTARIOESTATUS { get; set; }
        public virtual DbSet<PROCESO> PROCESO { get; set; }
        public virtual DbSet<PRODUCTO> PRODUCTO { get; set; }
        public virtual DbSet<PRODUCTOHISTORIAL> PRODUCTOHISTORIAL { get; set; }
        public virtual DbSet<PRODUCTOMINMAX> PRODUCTOMINMAX { get; set; }
        public virtual DbSet<PRODUCTOSUCURSAL> PRODUCTOSUCURSAL { get; set; }
        public virtual DbSet<RECEPCIONCOMPRA> RECEPCIONCOMPRA { get; set; }
        public virtual DbSet<SUBCATEGORIA> SUBCATEGORIA { get; set; }
        public virtual DbSet<TEST> TEST { get; set; }
        public virtual DbSet<TRASLADOS> TRASLADOS { get; set; }
        public virtual DbSet<ARCHIVOADJUNTO> ARCHIVOADJUNTO { get; set; }
        public virtual DbSet<BANCO> BANCO { get; set; }
        public virtual DbSet<CLASEPRODUCTO> CLASEPRODUCTO { get; set; }
        public virtual DbSet<COMENTARIO> COMENTARIO { get; set; }
        public virtual DbSet<COMPANIATRANSPORTISTA> COMPANIATRANSPORTISTA { get; set; }
        public virtual DbSet<COMUNICACION> COMUNICACION { get; set; }
        public virtual DbSet<CONTACTOS> CONTACTOS { get; set; }
        public virtual DbSet<DEVOLUCIONCATEGORIA> DEVOLUCIONCATEGORIA { get; set; }
        public virtual DbSet<DEVOLUCIONSUBCATEGORIA> DEVOLUCIONSUBCATEGORIA { get; set; }
        public virtual DbSet<ESTATUS> ESTATUS { get; set; }
        public virtual DbSet<ETAPAFABRICACION> ETAPAFABRICACION { get; set; }
        public virtual DbSet<FACTORCONVERSION> FACTORCONVERSION { get; set; }
        public virtual DbSet<FORMAFARMACEUTICA> FORMAFARMACEUTICA { get; set; }
        public virtual DbSet<FORMASPAGO> FORMASPAGO { get; set; }
        public virtual DbSet<FORMULAMAESTRA> FORMULAMAESTRA { get; set; }
        public virtual DbSet<FORMULAMAESTRADETALLE> FORMULAMAESTRADETALLE { get; set; }
        public virtual DbSet<FORMULAMAESTRATAMANO> FORMULAMAESTRATAMANO { get; set; }
        public virtual DbSet<IMPUESTOS> IMPUESTOS { get; set; }
        public virtual DbSet<METODOSPAGO> METODOSPAGO { get; set; }
        public virtual DbSet<MONEDAS> MONEDAS { get; set; }
        public virtual DbSet<PRODUCTOACONDICIONAMIENTO> PRODUCTOACONDICIONAMIENTO { get; set; }
        public virtual DbSet<PRODUCTOACONDICIONAMIENTOETAPA> PRODUCTOACONDICIONAMIENTOETAPA { get; set; }
        public virtual DbSet<PRODUCTOFABRICACION> PRODUCTOFABRICACION { get; set; }
        public virtual DbSet<PRODUCTOFABRICACIONETAPA> PRODUCTOFABRICACIONETAPA { get; set; }
        public virtual DbSet<PRODUCTOVENTAEMPLEADO> PRODUCTOVENTAEMPLEADO { get; set; }
        public virtual DbSet<REGIMENFISCAL> REGIMENFISCAL { get; set; }
        public virtual DbSet<SITUACION> SITUACION { get; set; }
        public virtual DbSet<TIPOCOMPROBANTE> TIPOCOMPROBANTE { get; set; }
        public virtual DbSet<TIPOCOMUNICACION> TIPOCOMUNICACION { get; set; }
        public virtual DbSet<TIPODOCUMENTO> TIPODOCUMENTO { get; set; }
        public virtual DbSet<TIPOMEDIDA> TIPOMEDIDA { get; set; }
        public virtual DbSet<UNIDADMEDIDA> UNIDADMEDIDA { get; set; }
        public virtual DbSet<USOCFDI> USOCFDI { get; set; }
        public virtual DbSet<COMPRA> COMPRA { get; set; }
        public virtual DbSet<COMPRAAUTORIZA> COMPRAAUTORIZA { get; set; }
        public virtual DbSet<COMPRACFDI> COMPRACFDI { get; set; }
        public virtual DbSet<COMPRADETALLE> COMPRADETALLE { get; set; }
        public virtual DbSet<COMPRADETALLEADICIONAL> COMPRADETALLEADICIONAL { get; set; }
        public virtual DbSet<COMPRAFLUJO> COMPRAFLUJO { get; set; }
        public virtual DbSet<COMPRAHISTORICO> COMPRAHISTORICO { get; set; }
        public virtual DbSet<COMPRAREQUISICION> COMPRAREQUISICION { get; set; }
        public virtual DbSet<TIPOCOMPRA> TIPOCOMPRA { get; set; }
        public virtual DbSet<CUENTASCORREO> CUENTASCORREO { get; set; }
        public virtual DbSet<DOCUMENTOS> DOCUMENTOS { get; set; }
        public virtual DbSet<EMAILCPP> EMAILCPP { get; set; }
        public virtual DbSet<EMPRESALOGO> EMPRESALOGO { get; set; }
        public virtual DbSet<ESTATUSPROCESO> ESTATUSPROCESO { get; set; }
        public virtual DbSet<FLUJOS> FLUJOS { get; set; }
        public virtual DbSet<FOLIOSUCURSAL> FOLIOSUCURSAL { get; set; }
        public virtual DbSet<PERMISOENEMAILCPP> PERMISOENEMAILCPP { get; set; }
        public virtual DbSet<PERMISOUSUARIOENPROCESO> PERMISOUSUARIOENPROCESO { get; set; }
        public virtual DbSet<RESTRICCIONUSUARIOENPROCESO> RESTRICCIONUSUARIOENPROCESO { get; set; }
        public virtual DbSet<TIPODOCUMENTO1> TIPODOCUMENTO1 { get; set; }
        public virtual DbSet<ACTIVOSFIJOS> ACTIVOSFIJOS { get; set; }
        public virtual DbSet<ACTIVOSFIJOSCATEGORIAS> ACTIVOSFIJOSCATEGORIAS { get; set; }
        public virtual DbSet<ACTIVOSFIJOSSUBCATEGORIAS> ACTIVOSFIJOSSUBCATEGORIAS { get; set; }
        public virtual DbSet<CUENTAS> CUENTAS { get; set; }
        public virtual DbSet<CUENTASCLIENTES> CUENTASCLIENTES { get; set; }
        public virtual DbSet<CUENTASCOSTOS> CUENTASCOSTOS { get; set; }
        public virtual DbSet<NOTASCREDITO> NOTASCREDITO { get; set; }
        public virtual DbSet<NOTASCREDITOCFDI> NOTASCREDITOCFDI { get; set; }
        public virtual DbSet<NOTASDEVOLUCION> NOTASDEVOLUCION { get; set; }
        public virtual DbSet<NOTASDEVOLUCIONCFDI> NOTASDEVOLUCIONCFDI { get; set; }
        public virtual DbSet<NOTASDEVOLUCIONDETALLE> NOTASDEVOLUCIONDETALLE { get; set; }
        public virtual DbSet<TIPOCUENTACLIENTE> TIPOCUENTACLIENTE { get; set; }
        public virtual DbSet<AREAS> AREAS { get; set; }
        public virtual DbSet<CACTUAL> CACTUAL { get; set; }
        public virtual DbSet<CENTROSCOSTOS> CENTROSCOSTOS { get; set; }
        public virtual DbSet<CHISTORIAL> CHISTORIAL { get; set; }
        public virtual DbSet<DEPARTAMENTO> DEPARTAMENTO { get; set; }
        public virtual DbSet<EMPRESA> EMPRESA { get; set; }
        public virtual DbSet<MAPAS> MAPAS { get; set; }
        public virtual DbSet<MOVIMIENTO> MOVIMIENTO { get; set; }
        public virtual DbSet<ORDENCOSTEO> ORDENCOSTEO { get; set; }
        public virtual DbSet<ORDENCOSTEOSUBTIPO> ORDENCOSTEOSUBTIPO { get; set; }
        public virtual DbSet<ORDENCOSTEOTIPO> ORDENCOSTEOTIPO { get; set; }
        public virtual DbSet<RESPONSABLE> RESPONSABLE { get; set; }
        public virtual DbSet<TIPOACTIVIDAD> TIPOACTIVIDAD { get; set; }
        public virtual DbSet<TIPOAREA> TIPOAREA { get; set; }
        public virtual DbSet<CARTACREDITO> CARTACREDITO { get; set; }
        public virtual DbSet<CARTACREDITOFACTURA> CARTACREDITOFACTURA { get; set; }
        public virtual DbSet<PAGO> PAGO { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<BITACORA> BITACORA { get; set; }
        public virtual DbSet<CFDI> CFDI { get; set; }
        public virtual DbSet<PDF> PDF { get; set; }
        public virtual DbSet<COLONIA> COLONIA { get; set; }
        public virtual DbSet<DOMICILIO> DOMICILIO { get; set; }
        public virtual DbSet<DOMICILIOENTREGA> DOMICILIOENTREGA { get; set; }
        public virtual DbSet<ESTADO> ESTADO { get; set; }
        public virtual DbSet<MUNICIPIO> MUNICIPIO { get; set; }
        public virtual DbSet<PAIS> PAIS { get; set; }
        public virtual DbSet<CENTROSTRABAJO> CENTROSTRABAJO { get; set; }
        public virtual DbSet<CENTROSTRABAJOTIPOS> CENTROSTRABAJOTIPOS { get; set; }
        public virtual DbSet<EDIFICIOS> EDIFICIOS { get; set; }
        public virtual DbSet<ESCENARIO> ESCENARIO { get; set; }
        public virtual DbSet<ETAPAS> ETAPAS { get; set; }
        public virtual DbSet<ETAPASOPERACIONES> ETAPASOPERACIONES { get; set; }
        public virtual DbSet<ETAPASSUBOPERACIONES> ETAPASSUBOPERACIONES { get; set; }
        public virtual DbSet<OPERACIONES> OPERACIONES { get; set; }
        public virtual DbSet<ORDENACONDICIONAMIENTO> ORDENACONDICIONAMIENTO { get; set; }
        public virtual DbSet<ORDENACONDICIONAMIENTODETALLE> ORDENACONDICIONAMIENTODETALLE { get; set; }
        public virtual DbSet<ORDENACONDICIONAMIENTOHISTORIAL> ORDENACONDICIONAMIENTOHISTORIAL { get; set; }
        public virtual DbSet<ORDENPRODUCCION> ORDENPRODUCCION { get; set; }
        public virtual DbSet<ORDENPRODUCCIONDETALLE> ORDENPRODUCCIONDETALLE { get; set; }
        public virtual DbSet<ORDENPRODUCCIONHISTORIAL> ORDENPRODUCCIONHISTORIAL { get; set; }
        public virtual DbSet<PRODUCTOSECTOR> PRODUCTOSECTOR { get; set; }
        public virtual DbSet<PROGRAMAACONDICIONAMIENTO> PROGRAMAACONDICIONAMIENTO { get; set; }
        public virtual DbSet<PROGRAMAACONDICIONAMIENTODETALLE> PROGRAMAACONDICIONAMIENTODETALLE { get; set; }
        public virtual DbSet<PROGRAMAACONDICIONAMIENTOHISTORIAL> PROGRAMAACONDICIONAMIENTOHISTORIAL { get; set; }
        public virtual DbSet<PROGRAMAFABRICACION> PROGRAMAFABRICACION { get; set; }
        public virtual DbSet<PROGRAMAFABRICACIONDETALLE> PROGRAMAFABRICACIONDETALLE { get; set; }
        public virtual DbSet<RUTASOPERACIONES> RUTASOPERACIONES { get; set; }
        public virtual DbSet<RUTASOPERACIONESDETALLE> RUTASOPERACIONESDETALLE { get; set; }
        public virtual DbSet<ABONOS> ABONOS { get; set; }
        public virtual DbSet<ABONOSHISTORIAL> ABONOSHISTORIAL { get; set; }
        public virtual DbSet<CANCELACIONCDFI> CANCELACIONCDFI { get; set; }
        public virtual DbSet<CLIENTEPRODUCTOLICITACION> CLIENTEPRODUCTOLICITACION { get; set; }
        public virtual DbSet<CONFIGURACIONSELLOS> CONFIGURACIONSELLOS { get; set; }
        public virtual DbSet<CPHUSOSHORARIO> CPHUSOSHORARIO { get; set; }
        public virtual DbSet<EMPRESAUSUARIOAUTORIZA> EMPRESAUSUARIOAUTORIZA { get; set; }
        public virtual DbSet<FACTURALICITACION> FACTURALICITACION { get; set; }
        public virtual DbSet<FACTURAS> FACTURAS { get; set; }
        public virtual DbSet<FACTURASCFDI> FACTURASCFDI { get; set; }
        public virtual DbSet<FACTURASDETALLE> FACTURASDETALLE { get; set; }
        public virtual DbSet<FACTURASHISTORIAL> FACTURASHISTORIAL { get; set; }
        public virtual DbSet<PAGOS> PAGOS { get; set; }
        public virtual DbSet<PAGOSCFDI> PAGOSCFDI { get; set; }
        public virtual DbSet<PAGOSCFDIELIMINADOS> PAGOSCFDIELIMINADOS { get; set; }
        public virtual DbSet<PAGOSHISTORIAL> PAGOSHISTORIAL { get; set; }
        public virtual DbSet<PRODUCTOLICITACION> PRODUCTOLICITACION { get; set; }
        public virtual DbSet<REFERENCIASBANCARIAS> REFERENCIASBANCARIAS { get; set; }
        public virtual DbSet<REFERENCIASBANCARIASNEGOCIO> REFERENCIASBANCARIASNEGOCIO { get; set; }
        public virtual DbSet<TIPOFACTURA> TIPOFACTURA { get; set; }
        public virtual DbSet<TIPOPAGO> TIPOPAGO { get; set; }
        public virtual DbSet<USUARIOAUTORIZA> USUARIOAUTORIZA { get; set; }
        public virtual DbSet<CLIENTES> CLIENTES { get; set; }
        public virtual DbSet<CLIENTESHISTORIAL> CLIENTESHISTORIAL { get; set; }
        public virtual DbSet<PRODUCTO1> PRODUCTO1 { get; set; }
        public virtual DbSet<TIPORELACIONCFDI> TIPORELACIONCFDI { get; set; }
        public virtual DbSet<INVENTARIO> INVENTARIO { get; set; }
        public virtual DbSet<INVENTARIOCONFIGURACION> INVENTARIOCONFIGURACION { get; set; }
        public virtual DbSet<INVENTARIODETALLE> INVENTARIODETALLE { get; set; }
        public virtual DbSet<AUTORIZAVENTACREDITO> AUTORIZAVENTACREDITO { get; set; }
        public virtual DbSet<CONFIGURACIONPRODUCTOENVIO> CONFIGURACIONPRODUCTOENVIO { get; set; }
        public virtual DbSet<INVENTARIO1> INVENTARIO1 { get; set; }
        public virtual DbSet<INVENTARIO_ALMSUBTIPO> INVENTARIO_ALMSUBTIPO { get; set; }
        public virtual DbSet<INVENTARIO_LARISSA> INVENTARIO_LARISSA { get; set; }
        public virtual DbSet<INVENTARIOCONFIGURACION1> INVENTARIOCONFIGURACION1 { get; set; }
        public virtual DbSet<INVENTARIODETALLE1> INVENTARIODETALLE1 { get; set; }
        public virtual DbSet<INVENTARIODETALLE_LARISSA> INVENTARIODETALLE_LARISSA { get; set; }
        public virtual DbSet<INVENTARIOTICKET> INVENTARIOTICKET { get; set; }
        public virtual DbSet<SUCURSALENVIO> SUCURSALENVIO { get; set; }
        public virtual DbSet<CFDI1> CFDI1 { get; set; }
        public virtual DbSet<CLIENTES1> CLIENTES1 { get; set; }
        public virtual DbSet<PRODUCTOS> PRODUCTOS { get; set; }
        public virtual DbSet<XMLDATA> XMLDATA { get; set; }
        public virtual DbSet<XMLFACTURA> XMLFACTURA { get; set; }
        public virtual DbSet<XMLFACTURADETALLE> XMLFACTURADETALLE { get; set; }
        public virtual DbSet<AREA> AREA { get; set; }
        public virtual DbSet<AREAS1> AREAS1 { get; set; }
        public virtual DbSet<CLASEPROVEEDOR> CLASEPROVEEDOR { get; set; }
        public virtual DbSet<CLIENTELICITACION> CLIENTELICITACION { get; set; }
        public virtual DbSet<CLIENTES2> CLIENTES2 { get; set; }
        public virtual DbSet<CLIENTESFACULTADOS> CLIENTESFACULTADOS { get; set; }
        public virtual DbSet<CUENTAS1> CUENTAS1 { get; set; }
        public virtual DbSet<DEPARTAMENTO1> DEPARTAMENTO1 { get; set; }
        public virtual DbSet<DEPARTAMENTOS> DEPARTAMENTOS { get; set; }
        public virtual DbSet<DEPARTAMENTOSUCURSAL> DEPARTAMENTOSUCURSAL { get; set; }
        public virtual DbSet<EMPRESA1> EMPRESA1 { get; set; }
        public virtual DbSet<EMPRESACERTIFICADO> EMPRESACERTIFICADO { get; set; }
        public virtual DbSet<EMPRESADATOS> EMPRESADATOS { get; set; }
        public virtual DbSet<PROVEEDOR> PROVEEDOR { get; set; }
        public virtual DbSet<PROVEEDORCONTACTO> PROVEEDORCONTACTO { get; set; }
        public virtual DbSet<RELACIONEMPRESAS> RELACIONEMPRESAS { get; set; }
        public virtual DbSet<SUCURSAL> SUCURSAL { get; set; }
        public virtual DbSet<SUCURSALDATOS> SUCURSALDATOS { get; set; }
        public virtual DbSet<SUCURSALESLARISSA> SUCURSALESLARISSA { get; set; }
        public virtual DbSet<SUCURSALPROVEEDOR> SUCURSALPROVEEDOR { get; set; }
        public virtual DbSet<NOTIFICACION> NOTIFICACION { get; set; }
        public virtual DbSet<CATEGORIA1> CATEGORIA1 { get; set; }
        public virtual DbSet<FAVORITO> FAVORITO { get; set; }
        public virtual DbSet<HISTORICO> HISTORICO { get; set; }
        public virtual DbSet<REPORTE> REPORTE { get; set; }
        public virtual DbSet<REPORTEUSUARIO> REPORTEUSUARIO { get; set; }
        public virtual DbSet<ROL> ROL { get; set; }
        public virtual DbSet<ROLREPORTE> ROLREPORTE { get; set; }
        public virtual DbSet<ROLUSUARIO> ROLUSUARIO { get; set; }
        public virtual DbSet<SUBCATEGORIA1> SUBCATEGORIA1 { get; set; }
        public virtual DbSet<ALMACEN1> ALMACEN1 { get; set; }
        public virtual DbSet<ALMACENARCHIVOADJUNTO> ALMACENARCHIVOADJUNTO { get; set; }
        public virtual DbSet<ALMACENDETALLE> ALMACENDETALLE { get; set; }
        public virtual DbSet<ALMACENHISTORIAL> ALMACENHISTORIAL { get; set; }
        public virtual DbSet<COMPRA1> COMPRA1 { get; set; }
        public virtual DbSet<COMPRAARCHIVOADJUNTO> COMPRAARCHIVOADJUNTO { get; set; }
        public virtual DbSet<COMPRAAUTORIZA1> COMPRAAUTORIZA1 { get; set; }
        public virtual DbSet<COMPRADETALLE1> COMPRADETALLE1 { get; set; }
        public virtual DbSet<COMPRADETALLE_NR> COMPRADETALLE_NR { get; set; }
        public virtual DbSet<COMPRADETALLEPROVEEDOR> COMPRADETALLEPROVEEDOR { get; set; }
        public virtual DbSet<COMPRAFLUJO1> COMPRAFLUJO1 { get; set; }
        public virtual DbSet<COMPRAHISTORICO1> COMPRAHISTORICO1 { get; set; }
        public virtual DbSet<INFORMATICA> INFORMATICA { get; set; }
        public virtual DbSet<INFORMATICAASIGNACION> INFORMATICAASIGNACION { get; set; }
        public virtual DbSet<INFORMATICAASIGNACIONE> INFORMATICAASIGNACIONE { get; set; }
        public virtual DbSet<INFORMATICACATEGORIA> INFORMATICACATEGORIA { get; set; }
        public virtual DbSet<INFORMATICAESTATUS> INFORMATICAESTATUS { get; set; }
        public virtual DbSet<INFORMATICAFLUJO> INFORMATICAFLUJO { get; set; }
        public virtual DbSet<INFORMATICAHISTORICO> INFORMATICAHISTORICO { get; set; }
        public virtual DbSet<INFORMATICASUBCATEGORIA> INFORMATICASUBCATEGORIA { get; set; }
        public virtual DbSet<INFORMATICAUSUARIO> INFORMATICAUSUARIO { get; set; }
        public virtual DbSet<INFORMATICAUSUARIOE> INFORMATICAUSUARIOE { get; set; }
        public virtual DbSet<RH> RH { get; set; }
        public virtual DbSet<RHAUTORIZA> RHAUTORIZA { get; set; }
        public virtual DbSet<RHESTATUS> RHESTATUS { get; set; }
        public virtual DbSet<RHFLUJO> RHFLUJO { get; set; }
        public virtual DbSet<RHHISTORICO> RHHISTORICO { get; set; }
        public virtual DbSet<SERVICIO> SERVICIO { get; set; }
        public virtual DbSet<SERVICIOCATEGORIA> SERVICIOCATEGORIA { get; set; }
        public virtual DbSet<SERVICIOGRUPO> SERVICIOGRUPO { get; set; }
        public virtual DbSet<SERVICIOHISTORIAL> SERVICIOHISTORIAL { get; set; }
        public virtual DbSet<SERVICIOSUBCATEGORIA> SERVICIOSUBCATEGORIA { get; set; }
        public virtual DbSet<SERVICIOTIPO> SERVICIOTIPO { get; set; }
        public virtual DbSet<CHECADA> CHECADA { get; set; }
        public virtual DbSet<EMPLEADO> EMPLEADO { get; set; }
        public virtual DbSet<EMPLEADOIMPORTACION> EMPLEADOIMPORTACION { get; set; }
        public virtual DbSet<INCIDENCIA> INCIDENCIA { get; set; }
        public virtual DbSet<PERIODONOMINA> PERIODONOMINA { get; set; }
        public virtual DbSet<TIPOVALE> TIPOVALE { get; set; }
        public virtual DbSet<USUARIOCHECAEMPLEADO> USUARIOCHECAEMPLEADO { get; set; }
        public virtual DbSet<VALE> VALE { get; set; }
        public virtual DbSet<FIRMADIGITAL> FIRMADIGITAL { get; set; }
        public virtual DbSet<LINK> LINK { get; set; }
        public virtual DbSet<LINKSMENU> LINKSMENU { get; set; }
        public virtual DbSet<MENU> MENU { get; set; }
        public virtual DbSet<MODULO> MODULO { get; set; }
        public virtual DbSet<PASSWORDEMAIL> PASSWORDEMAIL { get; set; }
        public virtual DbSet<ROL1> ROL1 { get; set; }
        public virtual DbSet<USUARIO> USUARIO { get; set; }
        public virtual DbSet<USUARIOESTATUS> USUARIOESTATUS { get; set; }
        public virtual DbSet<USUARIOMODULO> USUARIOMODULO { get; set; }
        public virtual DbSet<USUARIOSUCURSAL> USUARIOSUCURSAL { get; set; }
        public virtual DbSet<IMPORTACION> IMPORTACION { get; set; }
        public virtual DbSet<AGENTES> AGENTES { get; set; }
        public virtual DbSet<PEDIDOS> PEDIDOS { get; set; }
        public virtual DbSet<PEDIDOSDETALLE> PEDIDOSDETALLE { get; set; }
        public virtual DbSet<PERFILCREDITO> PERFILCREDITO { get; set; }
        public virtual DbSet<PERFILCREDITOHISTORICO> PERFILCREDITOHISTORICO { get; set; }
        public virtual DbSet<PRECIOVENTA> PRECIOVENTA { get; set; }
        public virtual DbSet<PRECIOVENTALISTA> PRECIOVENTALISTA { get; set; }
        public virtual DbSet<PRECIOVENTALISTACLIENTE> PRECIOVENTALISTACLIENTE { get; set; }
        public virtual DbSet<REGISTROVENTA> REGISTROVENTA { get; set; }
        public virtual DbSet<REGISTROVENTADETALLE> REGISTROVENTADETALLE { get; set; }
        public virtual DbSet<REGISTROVENTAHISTORIAL> REGISTROVENTAHISTORIAL { get; set; }
        public virtual DbSet<TARJETASPODER> TARJETASPODER { get; set; }
        public virtual DbSet<TARJETASPODERDETALLE> TARJETASPODERDETALLE { get; set; }
        public virtual DbSet<ZONAS> ZONAS { get; set; }
        public virtual DbSet<EXISTENCIAACTUAL> EXISTENCIAACTUAL { get; set; }
        public virtual DbSet<PERMISOSPROCESO> PERMISOSPROCESO { get; set; }
        public virtual DbSet<REGISTRO_ACCIONES> REGISTRO_ACCIONES { get; set; }
        public virtual DbSet<HOJACOSTOSPRODUCCION> HOJACOSTOSPRODUCCION { get; set; }
        public virtual DbSet<PLANMAESTROPRODUCCION> PLANMAESTROPRODUCCION { get; set; }
        public virtual DbSet<ALMACEN_ZTEST> ALMACEN_ZTEST { get; set; }
        public virtual DbSet<CATALOGO_TEST> CATALOGO_TEST { get; set; }
        public virtual DbSet<DOCUMENTO> DOCUMENTO { get; set; }
        public virtual DbSet<ORDENACONDICIONAMIENTOFLUJO> ORDENACONDICIONAMIENTOFLUJO { get; set; }
        public virtual DbSet<ORDENOPRODUCCIONFLUJO> ORDENOPRODUCCIONFLUJO { get; set; }
        public virtual DbSet<PROGRAMA> PROGRAMA { get; set; }
        public virtual DbSet<PROGRAMAFABRICACIONHISTORIAL> PROGRAMAFABRICACIONHISTORIAL { get; set; }
        public virtual DbSet<PROGRAMAFLUJO> PROGRAMAFLUJO { get; set; }
        public virtual DbSet<PROGRAMAHISTORIAL> PROGRAMAHISTORIAL { get; set; }
        public virtual DbSet<LOGSINVENTARIO> LOGSINVENTARIO { get; set; }
        public virtual DbSet<LOGS> LOGS { get; set; }
        public virtual DbSet<ALMACENEXISTENCIA> ALMACENEXISTENCIA { get; set; }
        public virtual DbSet<ALMACENLOCALIDADES> ALMACENLOCALIDADES { get; set; }
        public virtual DbSet<Pagos1> Pagos1 { get; set; }
        public virtual DbSet<PROVEEDORPRODUCTO> PROVEEDORPRODUCTO { get; set; }
        public virtual DbSet<REGISTRO_CHECADA> REGISTRO_CHECADA { get; set; }
        public virtual DbSet<USUARIOSAPP> USUARIOSAPP { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ALMACEN>()
                .Property(e => e.TIPO)
                .IsUnicode(false);

            modelBuilder.Entity<ALMACEN>()
                .Property(e => e.CLAVE)
                .IsUnicode(false);

            modelBuilder.Entity<ALMACEN>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<ALMACEN>()
                .HasMany(e => e.ALMACENLOCALIDAD)
                .WithRequired(e => e.ALMACEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ALMACEN>()
                .HasMany(e => e.REGISTROVENTADETALLE)
                .WithRequired(e => e.ALMACEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ALMACENLOCALIDAD>()
                .Property(e => e.TIPO)
                .IsUnicode(false);

            modelBuilder.Entity<ALMACENLOCALIDAD>()
                .Property(e => e.CLAVE)
                .IsUnicode(false);

            modelBuilder.Entity<ALMACENLOCALIDAD>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<ALMACENLOCALIDAD>()
                .HasMany(e => e.REGISTROVENTADETALLE)
                .WithRequired(e => e.ALMACENLOCALIDAD)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CATEGORIA>()
                .Property(e => e.CLAVE)
                .IsUnicode(false);

            modelBuilder.Entity<CATEGORIA>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<ENVIO>()
                .Property(e => e.FOLIO)
                .IsUnicode(false);

            modelBuilder.Entity<ENVIO>()
                .Property(e => e.COMENTARIOS)
                .IsUnicode(false);

            modelBuilder.Entity<ENVIO>()
                .Property(e => e.CONDICIONESCAMION)
                .IsUnicode(false);

            modelBuilder.Entity<ENVIO>()
                .Property(e => e.PLACAS)
                .IsUnicode(false);

            modelBuilder.Entity<ENVIO>()
                .HasMany(e => e.ENVIODETALLE)
                .WithRequired(e => e.ENVIO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ENVIO>()
                .HasMany(e => e.ENVIOREGISTROVENTA)
                .WithRequired(e => e.ENVIO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ENVIODETALLE>()
                .Property(e => e.NOLOTE)
                .IsUnicode(false);

            modelBuilder.Entity<ENVIODETALLE>()
                .Property(e => e.MOTIVOINCOMPLETO)
                .IsUnicode(false);

            modelBuilder.Entity<ENVIODETALLE>()
                .Property(e => e.OBSERVACIONES)
                .IsUnicode(false);

            modelBuilder.Entity<ENVIODETALLE>()
                .Property(e => e.CLAVEPRODUCTO)
                .IsUnicode(false);

            modelBuilder.Entity<ENVIODETALLE>()
                .Property(e => e.FOLIODOCUMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<ENVIODETALLE>()
                .Property(e => e.CLAVEPRODUCTODESTINO)
                .IsUnicode(false);

            modelBuilder.Entity<ENVIOFLUJO>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<ENVIOFLUJO>()
                .Property(e => e.COLUMNAFIRMA)
                .IsUnicode(false);

            modelBuilder.Entity<ENVIOFLUJO>()
                .Property(e => e.ACCION)
                .IsUnicode(false);

            modelBuilder.Entity<ENVIOHISTORICO>()
                .Property(e => e.ACCION)
                .IsUnicode(false);

            modelBuilder.Entity<ENVIOHISTORICO>()
                .Property(e => e.COMENTARIOS)
                .IsUnicode(false);

            modelBuilder.Entity<ESTATUSENVIO>()
                .Property(e => e.CLAVE)
                .IsUnicode(false);

            modelBuilder.Entity<ESTATUSENVIO>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<ESTATUSENVIO>()
                .HasMany(e => e.ENVIOHISTORICO)
                .WithOptional(e => e.ESTATUSENVIO)
                .HasForeignKey(e => e.IDESTATUSACTUAL);

            modelBuilder.Entity<ESTATUSENVIO>()
                .HasMany(e => e.ENVIOHISTORICO1)
                .WithOptional(e => e.ESTATUSENVIO1)
                .HasForeignKey(e => e.IDESTATUSNUEVO);

            modelBuilder.Entity<EXISTENCIA>()
                .Property(e => e.CLASE)
                .IsUnicode(false);

            modelBuilder.Entity<EXISTENCIA>()
                .Property(e => e.NOLOTE)
                .IsUnicode(false);

            modelBuilder.Entity<EXISTENCIA>()
                .Property(e => e.COSTOESTANDAR)
                .HasPrecision(18, 6);

            modelBuilder.Entity<EXISTENCIA>()
                .Property(e => e.OBSERVACION)
                .IsUnicode(false);

            modelBuilder.Entity<EXISTENCIA>()
                .Property(e => e.NOLOTEPROVEEDOR)
                .IsUnicode(false);

            modelBuilder.Entity<EXISTENCIA>()
                .HasMany(e => e.REGISTROVENTADETALLE)
                .WithRequired(e => e.EXISTENCIA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EXISTENCIAANALISIS>()
                .Property(e => e.FOLIO)
                .IsUnicode(false);

            modelBuilder.Entity<EXISTENCIAANALISIS>()
                .Property(e => e.NOANALISIS)
                .IsUnicode(false);

            modelBuilder.Entity<EXISTENCIAANALISIS>()
                .Property(e => e.TIPO)
                .IsUnicode(false);

            modelBuilder.Entity<EXISTENCIAANALISIS>()
                .Property(e => e.OBSERVACIONES)
                .IsUnicode(false);

            modelBuilder.Entity<EXISTENCIADETALLE>()
                .Property(e => e.FOLIO)
                .IsUnicode(false);

            modelBuilder.Entity<EXISTENCIADETALLE>()
                .Property(e => e.TIPO)
                .IsUnicode(false);

            modelBuilder.Entity<EXISTENCIADETALLE>()
                .Property(e => e.ENTRADA)
                .HasPrecision(18, 4);

            modelBuilder.Entity<EXISTENCIADETALLE>()
                .Property(e => e.SALIDA)
                .HasPrecision(18, 4);

            modelBuilder.Entity<EXISTENCIADETALLE>()
                .Property(e => e.OBSERVACIONES)
                .IsUnicode(false);

            modelBuilder.Entity<EXISTENCIADETALLE>()
                .Property(e => e.CODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTARIOESTATUS>()
                .Property(e => e.CLAVE)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTARIOESTATUS>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<PROCESO>()
                .Property(e => e.CLAVE)
                .IsUnicode(false);

            modelBuilder.Entity<PROCESO>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCTO>()
                .Property(e => e.CLAVE)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCTO>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCTO>()
                .Property(e => e.NOMBREUS)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCTO>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCTO>()
                .Property(e => e.COMENTARIOS)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCTO>()
                .Property(e => e.PREFIJOLOTE)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCTO>()
                .Property(e => e.CLASE)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCTO>()
                .Property(e => e.COSTOESTANDAR)
                .HasPrecision(18, 6);

            modelBuilder.Entity<PRODUCTO>()
                .Property(e => e.MINIMO)
                .HasPrecision(18, 4);

            modelBuilder.Entity<PRODUCTO>()
                .Property(e => e.MAXIMOS)
                .HasPrecision(18, 4);

            modelBuilder.Entity<PRODUCTO>()
                .Property(e => e.PESO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<PRODUCTO>()
                .Property(e => e.PUNTOREORDEN)
                .HasPrecision(18, 4);

            modelBuilder.Entity<PRODUCTO>()
                .Property(e => e.TIPO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCTO>()
                .Property(e => e.MINIMOCOMPRA)
                .HasPrecision(18, 4);

            modelBuilder.Entity<PRODUCTO>()
                .Property(e => e.VOLUMEN)
                .HasPrecision(18, 6);

            modelBuilder.Entity<PRODUCTO>()
                .HasMany(e => e.PRODUCTOMINMAX)
                .WithRequired(e => e.PRODUCTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRODUCTO>()
                .HasMany(e => e.COMPRADETALLE)
                .WithOptional(e => e.PRODUCTO)
                .HasForeignKey(e => e.IDPRODUCTO);

            modelBuilder.Entity<PRODUCTO>()
                .HasMany(e => e.COMPRADETALLE2)
                .WithOptional(e => e.PRODUCTO1)
                .HasForeignKey(e => e.IDPRODUCTO);

            modelBuilder.Entity<PRODUCTO>()
                .HasMany(e => e.FACTURASDETALLE)
                .WithRequired(e => e.PRODUCTO1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRODUCTO>()
                .HasMany(e => e.FORMULAMAESTRADETALLE)
                .WithRequired(e => e.PRODUCTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRODUCTO>()
                .HasMany(e => e.PRECIOVENTA)
                .WithRequired(e => e.PRODUCTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRODUCTO>()
                .HasMany(e => e.REGISTROVENTADETALLE)
                .WithRequired(e => e.PRODUCTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRODUCTOMINMAX>()
                .Property(e => e.MINTIJ)
                .HasPrecision(18, 4);

            modelBuilder.Entity<PRODUCTOMINMAX>()
                .Property(e => e.MAXTIJ)
                .HasPrecision(18, 4);

            modelBuilder.Entity<PRODUCTOMINMAX>()
                .Property(e => e.MINMTY)
                .HasPrecision(18, 4);

            modelBuilder.Entity<PRODUCTOMINMAX>()
                .Property(e => e.MAXMTY)
                .HasPrecision(18, 4);

            modelBuilder.Entity<PRODUCTOMINMAX>()
                .Property(e => e.MINHER)
                .HasPrecision(18, 4);

            modelBuilder.Entity<PRODUCTOMINMAX>()
                .Property(e => e.MAXHER)
                .HasPrecision(18, 4);

            modelBuilder.Entity<PRODUCTOMINMAX>()
                .Property(e => e.MINPUB)
                .HasPrecision(18, 4);

            modelBuilder.Entity<PRODUCTOMINMAX>()
                .Property(e => e.MAXPUB)
                .HasPrecision(18, 4);

            modelBuilder.Entity<PRODUCTOMINMAX>()
                .Property(e => e.MINMEX)
                .HasPrecision(18, 4);

            modelBuilder.Entity<PRODUCTOMINMAX>()
                .Property(e => e.MAXMEX)
                .HasPrecision(18, 4);

            modelBuilder.Entity<PRODUCTOMINMAX>()
                .Property(e => e.MINGUA)
                .HasPrecision(18, 4);

            modelBuilder.Entity<PRODUCTOMINMAX>()
                .Property(e => e.MAXGUA)
                .HasPrecision(18, 4);

            modelBuilder.Entity<PRODUCTOMINMAX>()
                .Property(e => e.MINMER)
                .HasPrecision(18, 4);

            modelBuilder.Entity<PRODUCTOMINMAX>()
                .Property(e => e.MAXMER)
                .HasPrecision(18, 4);

            modelBuilder.Entity<PRODUCTOMINMAX>()
                .Property(e => e.MINGLO)
                .HasPrecision(18, 4);

            modelBuilder.Entity<PRODUCTOMINMAX>()
                .Property(e => e.MAXGLO)
                .HasPrecision(18, 4);

            modelBuilder.Entity<RECEPCIONCOMPRA>()
                .Property(e => e.TIPO)
                .IsUnicode(false);

            modelBuilder.Entity<RECEPCIONCOMPRA>()
                .Property(e => e.RECIBIDO)
                .HasPrecision(18, 4);

            modelBuilder.Entity<RECEPCIONCOMPRA>()
                .Property(e => e.DEVUELTO)
                .HasPrecision(18, 4);

            modelBuilder.Entity<RECEPCIONCOMPRA>()
                .Property(e => e.NOLOTEINTERNO)
                .IsUnicode(false);

            modelBuilder.Entity<RECEPCIONCOMPRA>()
                .Property(e => e.NOLOTEPROVEEDOR)
                .IsUnicode(false);

            modelBuilder.Entity<RECEPCIONCOMPRA>()
                .Property(e => e.FABRICANTE)
                .IsUnicode(false);

            modelBuilder.Entity<RECEPCIONCOMPRA>()
                .Property(e => e.FORMADEENTREGA)
                .IsUnicode(false);

            modelBuilder.Entity<RECEPCIONCOMPRA>()
                .Property(e => e.GUIA)
                .IsUnicode(false);

            modelBuilder.Entity<RECEPCIONCOMPRA>()
                .Property(e => e.FACTURA)
                .IsUnicode(false);

            modelBuilder.Entity<RECEPCIONCOMPRA>()
                .Property(e => e.OBSERVACIONES)
                .IsUnicode(false);

            modelBuilder.Entity<SUBCATEGORIA>()
                .Property(e => e.CLAVE)
                .IsUnicode(false);

            modelBuilder.Entity<SUBCATEGORIA>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<TEST>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<TRASLADOS>()
                .Property(e => e.TIPOCAMBIO)
                .HasPrecision(6, 2);

            modelBuilder.Entity<ARCHIVOADJUNTO>()
                .Property(e => e.NOMBREARCHIVO)
                .IsUnicode(false);

            modelBuilder.Entity<ARCHIVOADJUNTO>()
                .Property(e => e.COMENTARIOS)
                .IsUnicode(false);

            modelBuilder.Entity<ARCHIVOADJUNTO>()
                .Property(e => e.IDCATEGORIAEXPEDIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<BANCO>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<BANCO>()
                .Property(e => e.RAZONSOCIAL)
                .IsUnicode(false);

            modelBuilder.Entity<BANCO>()
                .HasMany(e => e.PAGO)
                .WithOptional(e => e.BANCO)
                .HasForeignKey(e => e.IDBANCODESTINO);

            modelBuilder.Entity<BANCO>()
                .HasMany(e => e.PAGO1)
                .WithOptional(e => e.BANCO1)
                .HasForeignKey(e => e.IDBANCOORIGEN);

            modelBuilder.Entity<BANCO>()
                .HasMany(e => e.PAGOS)
                .WithOptional(e => e.BANCO)
                .HasForeignKey(e => e.IDBANCODESTINO);

            modelBuilder.Entity<BANCO>()
                .HasMany(e => e.PAGOS1)
                .WithOptional(e => e.BANCO1)
                .HasForeignKey(e => e.IDBANCOORIGEN);

            modelBuilder.Entity<BANCO>()
                .HasMany(e => e.PAGOSHISTORIAL)
                .WithOptional(e => e.BANCO)
                .HasForeignKey(e => e.IDBANCODESTINO);

            modelBuilder.Entity<BANCO>()
                .HasMany(e => e.PAGOSHISTORIAL1)
                .WithOptional(e => e.BANCO1)
                .HasForeignKey(e => e.IDBANCOORIGEN);

            modelBuilder.Entity<CLASEPRODUCTO>()
                .Property(e => e.NIVEL)
                .IsUnicode(false);

            modelBuilder.Entity<CLASEPRODUCTO>()
                .Property(e => e.CLAVE)
                .IsUnicode(false);

            modelBuilder.Entity<CLASEPRODUCTO>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<COMENTARIO>()
                .Property(e => e.COMENTARIOS)
                .IsUnicode(false);

            modelBuilder.Entity<COMPANIATRANSPORTISTA>()
                .Property(e => e.CLAVE)
                .IsUnicode(false);

            modelBuilder.Entity<COMPANIATRANSPORTISTA>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<DEVOLUCIONCATEGORIA>()
                .HasMany(e => e.DEVOLUCIONSUBCATEGORIA)
                .WithRequired(e => e.DEVOLUCIONCATEGORIA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DEVOLUCIONCATEGORIA>()
                .HasMany(e => e.NOTASDEVOLUCION)
                .WithRequired(e => e.DEVOLUCIONCATEGORIA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DEVOLUCIONSUBCATEGORIA>()
                .HasMany(e => e.NOTASDEVOLUCION)
                .WithRequired(e => e.DEVOLUCIONSUBCATEGORIA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ESTATUS>()
                .Property(e => e.CLAVE)
                .IsUnicode(false);

            modelBuilder.Entity<ESTATUS>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<ESTATUS>()
                .HasMany(e => e.ENVIOFLUJO)
                .WithOptional(e => e.ESTATUS)
                .HasForeignKey(e => e.ESTADOACTUAL);

            modelBuilder.Entity<ESTATUS>()
                .HasMany(e => e.ENVIOFLUJO1)
                .WithOptional(e => e.ESTATUS1)
                .HasForeignKey(e => e.ESTADONUEVO);

            modelBuilder.Entity<ESTATUS>()
                .HasMany(e => e.COMPRAFLUJO)
                .WithOptional(e => e.ESTATUS)
                .HasForeignKey(e => e.ESTADOACTUAL);

            modelBuilder.Entity<ESTATUS>()
                .HasMany(e => e.COMPRAFLUJO1)
                .WithOptional(e => e.ESTATUS)
                .HasForeignKey(e => e.ESTADOACTUAL);

            modelBuilder.Entity<ESTATUS>()
                .HasMany(e => e.COMPRAFLUJO2)
                .WithOptional(e => e.ESTATUS1)
                .HasForeignKey(e => e.ESTADONUEVO);

            modelBuilder.Entity<ESTATUS>()
                .HasMany(e => e.COMPRAFLUJO11)
                .WithOptional(e => e.ESTATUS1)
                .HasForeignKey(e => e.ESTADONUEVO);

            modelBuilder.Entity<ESTATUS>()
                .HasMany(e => e.COMPRAHISTORICO)
                .WithOptional(e => e.ESTATUS)
                .HasForeignKey(e => e.IDESTATUSACTUAL);

            modelBuilder.Entity<ESTATUS>()
                .HasMany(e => e.COMPRAHISTORICO1)
                .WithOptional(e => e.ESTATUS)
                .HasForeignKey(e => e.IDESTATUSACTUAL);

            modelBuilder.Entity<ESTATUS>()
                .HasMany(e => e.COMPRAHISTORICO2)
                .WithOptional(e => e.ESTATUS1)
                .HasForeignKey(e => e.IDESTATUSNUEVO);

            modelBuilder.Entity<ESTATUS>()
                .HasMany(e => e.COMPRAHISTORICO11)
                .WithOptional(e => e.ESTATUS1)
                .HasForeignKey(e => e.IDESTATUSNUEVO);

            modelBuilder.Entity<ETAPAFABRICACION>()
                .HasMany(e => e.PRODUCTOACONDICIONAMIENTOETAPA)
                .WithRequired(e => e.ETAPAFABRICACION)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FACTORCONVERSION>()
                .Property(e => e.FACTOR)
                .HasPrecision(22, 18);

            modelBuilder.Entity<FACTORCONVERSION>()
                .HasMany(e => e.FORMULAMAESTRADETALLE)
                .WithRequired(e => e.FACTORCONVERSION1)
                .HasForeignKey(e => e.IDFACTORCONVERSIONLOTE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FORMASPAGO>()
                .HasMany(e => e.NOTASDEVOLUCION)
                .WithRequired(e => e.FORMASPAGO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FORMASPAGO>()
                .HasMany(e => e.REFERENCIASBANCARIASNEGOCIO)
                .WithRequired(e => e.FORMASPAGO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FORMULAMAESTRA>()
                .HasMany(e => e.FORMULAMAESTRADETALLE)
                .WithRequired(e => e.FORMULAMAESTRA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FORMULAMAESTRA>()
                .HasMany(e => e.FORMULAMAESTRATAMANO)
                .WithRequired(e => e.FORMULAMAESTRA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FORMULAMAESTRA>()
                .HasMany(e => e.PROGRAMA)
                .WithRequired(e => e.FORMULAMAESTRA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FORMULAMAESTRADETALLE>()
                .Property(e => e.CANTIDAD)
                .HasPrecision(18, 4);

            modelBuilder.Entity<FORMULAMAESTRADETALLE>()
                .Property(e => e.FACTORCONVERSION)
                .HasPrecision(18, 10);

            modelBuilder.Entity<FORMULAMAESTRATAMANO>()
                .Property(e => e.TAMANOLOTE)
                .HasPrecision(18, 4);

            modelBuilder.Entity<FORMULAMAESTRATAMANO>()
                .HasMany(e => e.PROGRAMA)
                .WithRequired(e => e.FORMULAMAESTRATAMANO)
                .HasForeignKey(e => e.IDTAMANOESTANDAR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IMPUESTOS>()
                .Property(e => e.VALOR)
                .HasPrecision(8, 6);

            modelBuilder.Entity<IMPUESTOS>()
                .HasMany(e => e.FACTURASDETALLE)
                .WithRequired(e => e.IMPUESTOS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<METODOSPAGO>()
                .HasMany(e => e.FACTURAS)
                .WithRequired(e => e.METODOSPAGO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<METODOSPAGO>()
                .HasMany(e => e.NOTASDEVOLUCION)
                .WithRequired(e => e.METODOSPAGO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MONEDAS>()
                .HasMany(e => e.TRASLADOS)
                .WithRequired(e => e.MONEDAS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MONEDAS>()
                .HasMany(e => e.FACTURAS)
                .WithRequired(e => e.MONEDAS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MONEDAS>()
                .HasMany(e => e.NOTASCREDITO)
                .WithRequired(e => e.MONEDAS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MONEDAS>()
                .HasMany(e => e.PAGOS)
                .WithRequired(e => e.MONEDAS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MONEDAS>()
                .HasMany(e => e.PERFILCREDITO)
                .WithRequired(e => e.MONEDAS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MONEDAS>()
                .HasMany(e => e.PERFILCREDITOHISTORICO)
                .WithRequired(e => e.MONEDAS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MONEDAS>()
                .HasMany(e => e.PRECIOVENTA)
                .WithRequired(e => e.MONEDAS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MONEDAS>()
                .HasMany(e => e.REGISTROVENTA)
                .WithRequired(e => e.MONEDAS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MONEDAS>()
                .HasMany(e => e.REGISTROVENTAHISTORIAL)
                .WithRequired(e => e.MONEDAS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRODUCTOACONDICIONAMIENTO>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCTOACONDICIONAMIENTO>()
                .Property(e => e.CANTIDAD)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCTOACONDICIONAMIENTO>()
                .HasMany(e => e.PRODUCTOACONDICIONAMIENTOETAPA)
                .WithRequired(e => e.PRODUCTOACONDICIONAMIENTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRODUCTOFABRICACION>()
                .Property(e => e.CONCENTRACION)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCTOVENTAEMPLEADO>()
                .Property(e => e.CLAVE)
                .IsUnicode(false);

            modelBuilder.Entity<REGIMENFISCAL>()
                .HasMany(e => e.CLIENTES2)
                .WithRequired(e => e.REGIMENFISCAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<REGIMENFISCAL>()
                .HasMany(e => e.FACTURAS)
                .WithRequired(e => e.REGIMENFISCAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SITUACION>()
                .HasMany(e => e.CANCELACIONCDFI)
                .WithRequired(e => e.SITUACION)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SITUACION>()
                .HasMany(e => e.FACTURAS)
                .WithRequired(e => e.SITUACION)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SITUACION>()
                .HasMany(e => e.FLUJOS)
                .WithRequired(e => e.SITUACION)
                .HasForeignKey(e => e.IDSITUACION)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SITUACION>()
                .HasMany(e => e.FLUJOS1)
                .WithRequired(e => e.SITUACION1)
                .HasForeignKey(e => e.IDSITUACIONNUEVO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SITUACION>()
                .HasMany(e => e.IMPORTACION)
                .WithRequired(e => e.SITUACION)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SITUACION>()
                .HasMany(e => e.NOTASCREDITO)
                .WithRequired(e => e.SITUACION)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SITUACION>()
                .HasMany(e => e.NOTASDEVOLUCION)
                .WithRequired(e => e.SITUACION)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SITUACION>()
                .HasMany(e => e.NOTASDEVOLUCIONDETALLE)
                .WithRequired(e => e.SITUACION)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SITUACION>()
                .HasMany(e => e.PEDIDOS)
                .WithRequired(e => e.SITUACION)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SITUACION>()
                .HasMany(e => e.PERFILCREDITO)
                .WithRequired(e => e.SITUACION)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SITUACION>()
                .HasMany(e => e.PERFILCREDITOHISTORICO)
                .WithRequired(e => e.SITUACION)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SITUACION>()
                .HasMany(e => e.REGISTROVENTA)
                .WithRequired(e => e.SITUACION)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SITUACION>()
                .HasMany(e => e.REGISTROVENTADETALLE)
                .WithRequired(e => e.SITUACION)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SITUACION>()
                .HasMany(e => e.REGISTROVENTAHISTORIAL)
                .WithRequired(e => e.SITUACION)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SITUACION>()
                .HasMany(e => e.SERVICIO)
                .WithRequired(e => e.SITUACION)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SITUACION>()
                .HasMany(e => e.SERVICIOHISTORIAL)
                .WithRequired(e => e.SITUACION)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPOCOMUNICACION>()
                .HasMany(e => e.COMUNICACION)
                .WithRequired(e => e.TIPOCOMUNICACION)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPODOCUMENTO>()
                .Property(e => e.VISTAPREDET)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TIPOMEDIDA>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<TIPOMEDIDA>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<UNIDADMEDIDA>()
                .Property(e => e.UNIDAD)
                .IsUnicode(false);

            modelBuilder.Entity<UNIDADMEDIDA>()
                .Property(e => e.UNIDADMX)
                .IsUnicode(false);

            modelBuilder.Entity<UNIDADMEDIDA>()
                .Property(e => e.UNIDADUS)
                .IsUnicode(false);

            modelBuilder.Entity<UNIDADMEDIDA>()
                .HasMany(e => e.PRODUCTO)
                .WithOptional(e => e.UNIDADMEDIDA)
                .HasForeignKey(e => e.IDUNIDADMEDIDA);

            modelBuilder.Entity<UNIDADMEDIDA>()
                .HasMany(e => e.PRODUCTO1)
                .WithOptional(e => e.UNIDADMEDIDA1)
                .HasForeignKey(e => e.IDMEDIDACOMPRA);

            modelBuilder.Entity<UNIDADMEDIDA>()
                .HasMany(e => e.PRODUCTO2)
                .WithOptional(e => e.UNIDADMEDIDA2)
                .HasForeignKey(e => e.IDUNIDADMEDIDALOTE);

            modelBuilder.Entity<UNIDADMEDIDA>()
                .HasMany(e => e.PRODUCTO3)
                .WithOptional(e => e.UNIDADMEDIDA3)
                .HasForeignKey(e => e.IDUNIDADMEDIDAPESO);

            modelBuilder.Entity<UNIDADMEDIDA>()
                .HasMany(e => e.PRODUCTO4)
                .WithOptional(e => e.UNIDADMEDIDA4)
                .HasForeignKey(e => e.IDUNIDADMEDIDAVOLUMEN);

            modelBuilder.Entity<UNIDADMEDIDA>()
                .HasMany(e => e.FORMULAMAESTRADETALLE)
                .WithRequired(e => e.UNIDADMEDIDA)
                .HasForeignKey(e => e.IDUMCANTIDAD)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UNIDADMEDIDA>()
                .HasMany(e => e.FORMULAMAESTRATAMANO)
                .WithRequired(e => e.UNIDADMEDIDA)
                .HasForeignKey(e => e.IDUMTAMANOLOTE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UNIDADMEDIDA>()
                .HasMany(e => e.FACTURASDETALLE)
                .WithRequired(e => e.UNIDADMEDIDA1)
                .HasForeignKey(e => e.IDUNIDADMEDIDA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UNIDADMEDIDA>()
                .HasMany(e => e.INVENTARIODETALLE)
                .WithOptional(e => e.UNIDADMEDIDA)
                .HasForeignKey(e => e.IDUNIDADMEDIDA);

            modelBuilder.Entity<USOCFDI>()
                .HasMany(e => e.TRASLADOS)
                .WithRequired(e => e.USOCFDI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<USOCFDI>()
                .HasMany(e => e.CLIENTES)
                .WithRequired(e => e.USOCFDI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<USOCFDI>()
                .HasMany(e => e.CLIENTESHISTORIAL)
                .WithRequired(e => e.USOCFDI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<USOCFDI>()
                .HasMany(e => e.FACTURAS)
                .WithRequired(e => e.USOCFDI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<USOCFDI>()
                .HasMany(e => e.NOTASDEVOLUCION)
                .WithRequired(e => e.USOCFDI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<COMPRA>()
                .Property(e => e.FOLIO)
                .IsUnicode(false);

            modelBuilder.Entity<COMPRA>()
                .Property(e => e.COMENTARIOS)
                .IsUnicode(false);

            modelBuilder.Entity<COMPRA>()
                .Property(e => e.CONTACTOENTREGA)
                .IsUnicode(false);

            modelBuilder.Entity<COMPRA>()
                .Property(e => e.DOMICILIOENTREGA)
                .IsUnicode(false);

            modelBuilder.Entity<COMPRA>()
                .Property(e => e.FACTURA)
                .IsUnicode(false);

            modelBuilder.Entity<COMPRA>()
                .Property(e => e.COTIZACION)
                .IsUnicode(false);

            modelBuilder.Entity<COMPRA>()
                .Property(e => e.FORMAENTREGA)
                .IsUnicode(false);

            modelBuilder.Entity<COMPRA>()
                .Property(e => e.TIPOMONEDA)
                .IsUnicode(false);

            modelBuilder.Entity<COMPRA>()
                .Property(e => e.IMPUESTO)
                .HasPrecision(16, 4);

            modelBuilder.Entity<COMPRA>()
                .Property(e => e.SUBTOTAL)
                .HasPrecision(16, 4);

            modelBuilder.Entity<COMPRA>()
                .Property(e => e.TOTAL)
                .HasPrecision(16, 4);

            modelBuilder.Entity<COMPRA>()
                .Property(e => e.MEDIDAPARCIALIDAD)
                .IsUnicode(false);

            modelBuilder.Entity<COMPRA>()
                .Property(e => e.CONDICIONES)
                .IsUnicode(false);

            modelBuilder.Entity<COMPRA>()
                .Property(e => e.IMPUESTORETENIDO)
                .HasPrecision(16, 4);

            modelBuilder.Entity<COMPRA>()
                .Property(e => e.ISR)
                .HasPrecision(16, 4);

            modelBuilder.Entity<COMPRA>()
                .Property(e => e.DESCUENTO)
                .HasPrecision(16, 4);

            modelBuilder.Entity<COMPRA>()
                .Property(e => e.ISH)
                .HasPrecision(16, 4);

            modelBuilder.Entity<COMPRA>()
                .Property(e => e.ULTIMODESCUENTO)
                .HasPrecision(16, 4);

            modelBuilder.Entity<COMPRA>()
                .HasMany(e => e.COMPRADETALLE)
                .WithOptional(e => e.COMPRA)
                .HasForeignKey(e => e.IDCOMPRA);

            modelBuilder.Entity<COMPRA>()
                .HasMany(e => e.COMPRADETALLE1)
                .WithOptional(e => e.COMPRA1)
                .HasForeignKey(e => e.IDCOMPRA);

            modelBuilder.Entity<COMPRAAUTORIZA>()
                .Property(e => e.CLAVE)
                .IsUnicode(false);

            modelBuilder.Entity<COMPRADETALLE>()
                .Property(e => e.CANTIDAD)
                .HasPrecision(18, 4);

            modelBuilder.Entity<COMPRADETALLE>()
                .Property(e => e.PRECIO)
                .HasPrecision(18, 5);

            modelBuilder.Entity<COMPRADETALLE>()
                .Property(e => e.TOTAL)
                .HasPrecision(16, 4);

            modelBuilder.Entity<COMPRADETALLE>()
                .Property(e => e.PRODUCTORECIBIDO)
                .HasPrecision(18, 4);

            modelBuilder.Entity<COMPRADETALLE>()
                .Property(e => e.PRODUCTOFALTANTE)
                .HasPrecision(18, 4);

            modelBuilder.Entity<COMPRADETALLE>()
                .HasMany(e => e.ACTIVOSFIJOS)
                .WithOptional(e => e.COMPRADETALLE)
                .HasForeignKey(e => e.IDCompraDetalle);

            modelBuilder.Entity<COMPRADETALLEADICIONAL>()
                .Property(e => e.CANTIDAD)
                .HasPrecision(18, 4);

            modelBuilder.Entity<COMPRADETALLEADICIONAL>()
                .Property(e => e.PRECIO)
                .HasPrecision(18, 5);

            modelBuilder.Entity<COMPRADETALLEADICIONAL>()
                .Property(e => e.TOTAL)
                .HasPrecision(16, 4);

            modelBuilder.Entity<COMPRADETALLEADICIONAL>()
                .Property(e => e.PRODUCTORECIBIDO)
                .HasPrecision(18, 4);

            modelBuilder.Entity<COMPRADETALLEADICIONAL>()
                .Property(e => e.PRODUCTOFALTANTE)
                .HasPrecision(18, 4);

            modelBuilder.Entity<COMPRAFLUJO>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<COMPRAFLUJO>()
                .Property(e => e.COLUMNAFIRMA)
                .IsUnicode(false);

            modelBuilder.Entity<COMPRAFLUJO>()
                .Property(e => e.ACCION)
                .IsUnicode(false);

            modelBuilder.Entity<COMPRAHISTORICO>()
                .Property(e => e.ACCION)
                .IsUnicode(false);

            modelBuilder.Entity<COMPRAHISTORICO>()
                .Property(e => e.COMENTARIOS)
                .IsUnicode(false);

            modelBuilder.Entity<TIPOCOMPRA>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<TIPOCOMPRA>()
                .HasMany(e => e.COMPRA)
                .WithOptional(e => e.TIPOCOMPRA)
                .HasForeignKey(e => e.IDTIPOORDEN);

            modelBuilder.Entity<DOCUMENTOS>()
                .Property(e => e.PREFIJOGLOBAL)
                .IsUnicode(false);

            modelBuilder.Entity<DOCUMENTOS>()
                .Property(e => e.PREFIJO)
                .IsUnicode(false);

            modelBuilder.Entity<DOCUMENTOS>()
                .Property(e => e.SUFIJO)
                .IsUnicode(false);

            modelBuilder.Entity<DOCUMENTOS>()
                .Property(e => e.SEPARADORGLOBAL)
                .IsUnicode(false);

            modelBuilder.Entity<DOCUMENTOS>()
                .Property(e => e.SEPARADORPREFIJO)
                .IsUnicode(false);

            modelBuilder.Entity<DOCUMENTOS>()
                .Property(e => e.SEPARADORSUFIJO)
                .IsUnicode(false);

            modelBuilder.Entity<DOCUMENTOS>()
                .Property(e => e.VISTAPREDET)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EMAILCPP>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<EMAILCPP>()
                .Property(e => e.CATEGORIA)
                .IsUnicode(false);

            modelBuilder.Entity<EMAILCPP>()
                .Property(e => e.CATEGORIACLAVE)
                .IsUnicode(false);

            modelBuilder.Entity<EMAILCPP>()
                .Property(e => e.RFCEMPRESA)
                .IsUnicode(false);

            modelBuilder.Entity<EMAILCPP>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<EMAILCPP>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<EMAILCPP>()
                .Property(e => e.CONTRASENA)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESALOGO>()
                .Property(e => e.CLAVE)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESALOGO>()
                .Property(e => e.PATHLOGO)
                .IsUnicode(false);

            modelBuilder.Entity<ESTATUSPROCESO>()
                .Property(e => e.PROCESO)
                .IsUnicode(false);

            modelBuilder.Entity<ESTATUSPROCESO>()
                .Property(e => e.CLAVE)
                .IsUnicode(false);

            modelBuilder.Entity<ESTATUSPROCESO>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<ESTATUSPROCESO>()
                .Property(e => e.ACCION)
                .IsUnicode(false);

            modelBuilder.Entity<ESTATUSPROCESO>()
                .HasMany(e => e.PROGRAMA)
                .WithRequired(e => e.ESTATUSPROCESO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FOLIOSUCURSAL>()
                .Property(e => e.CLAVE)
                .IsUnicode(false);

            modelBuilder.Entity<FOLIOSUCURSAL>()
                .Property(e => e.PREFIJO)
                .IsUnicode(false);

            modelBuilder.Entity<FOLIOSUCURSAL>()
                .Property(e => e.SUFIJO)
                .IsUnicode(false);

            modelBuilder.Entity<PERMISOUSUARIOENPROCESO>()
                .Property(e => e.PROCESO)
                .IsUnicode(false);

            modelBuilder.Entity<PERMISOUSUARIOENPROCESO>()
                .Property(e => e.PERMISO)
                .IsUnicode(false);

            modelBuilder.Entity<RESTRICCIONUSUARIOENPROCESO>()
                .Property(e => e.PROCESO)
                .IsUnicode(false);

            modelBuilder.Entity<RESTRICCIONUSUARIOENPROCESO>()
                .Property(e => e.RESTRICCION)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVOSFIJOS>()
                .Property(e => e.Tipo)
                .IsFixedLength();

            modelBuilder.Entity<ACTIVOSFIJOSCATEGORIAS>()
                .HasMany(e => e.ACTIVOSFIJOSSUBCATEGORIAS)
                .WithRequired(e => e.ACTIVOSFIJOSCATEGORIAS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CUENTAS>()
                .Property(e => e.CLAVE)
                .IsUnicode(false);

            modelBuilder.Entity<CUENTAS>()
                .HasMany(e => e.NOTASDEVOLUCION)
                .WithOptional(e => e.CUENTAS)
                .HasForeignKey(e => e.IDCUENTAPENDIENTE);

            modelBuilder.Entity<CUENTASCOSTOS>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<CUENTASCOSTOS>()
                .HasMany(e => e.CUENTAS1)
                .WithRequired(e => e.CUENTASCOSTOS)
                .HasForeignKey(e => e.IDCUENTACOSTOS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NOTASCREDITO>()
                .HasMany(e => e.NOTASCREDITOCFDI)
                .WithRequired(e => e.NOTASCREDITO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NOTASCREDITOCFDI>()
                .Property(e => e.SELLOEMISOR)
                .IsUnicode(false);

            modelBuilder.Entity<NOTASCREDITOCFDI>()
                .Property(e => e.SELLOSAT)
                .IsUnicode(false);

            modelBuilder.Entity<NOTASCREDITOCFDI>()
                .Property(e => e.CADENAORIGINAL)
                .IsUnicode(false);

            modelBuilder.Entity<NOTASCREDITOCFDI>()
                .Property(e => e.RUTAXML)
                .IsUnicode(false);

            modelBuilder.Entity<NOTASDEVOLUCION>()
                .Property(e => e.IMPORTESUBTOTAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NOTASDEVOLUCION>()
                .Property(e => e.IMPORTEIVA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NOTASDEVOLUCION>()
                .Property(e => e.IMPORTEDESCUENTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NOTASDEVOLUCION>()
                .Property(e => e.IMPORTETOTAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NOTASDEVOLUCION>()
                .Property(e => e.TIPOCAMBIO)
                .HasPrecision(10, 2);

            modelBuilder.Entity<NOTASDEVOLUCION>()
                .HasMany(e => e.NOTASDEVOLUCIONCFDI)
                .WithRequired(e => e.NOTASDEVOLUCION)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NOTASDEVOLUCION>()
                .HasMany(e => e.NOTASDEVOLUCIONDETALLE)
                .WithRequired(e => e.NOTASDEVOLUCION)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NOTASDEVOLUCIONCFDI>()
                .Property(e => e.CADENAORIGINAL)
                .IsUnicode(false);

            modelBuilder.Entity<NOTASDEVOLUCIONCFDI>()
                .Property(e => e.RUTAXML)
                .IsUnicode(false);

            modelBuilder.Entity<NOTASDEVOLUCIONDETALLE>()
                .Property(e => e.CANTIDAD)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TIPOCUENTACLIENTE>()
                .Property(e => e.CLAVE)
                .IsUnicode(false);

            modelBuilder.Entity<TIPOCUENTACLIENTE>()
                .HasMany(e => e.CLIENTES2)
                .WithRequired(e => e.TIPOCUENTACLIENTE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AREAS>()
                .Property(e => e.CMANODEOBRA)
                .HasPrecision(18, 4);

            modelBuilder.Entity<AREAS>()
                .Property(e => e.CFIJO)
                .HasPrecision(18, 4);

            modelBuilder.Entity<AREAS>()
                .Property(e => e.CVARIABLE)
                .HasPrecision(18, 4);

            modelBuilder.Entity<AREAS>()
                .Property(e => e.CMAQUINA)
                .HasPrecision(18, 4);

            modelBuilder.Entity<AREAS>()
                .Property(e => e.NOMAREA)
                .IsUnicode(false);

            modelBuilder.Entity<CENTROSCOSTOS>()
                .Property(e => e.CLAVE)
                .IsUnicode(false);

            modelBuilder.Entity<CENTROSCOSTOS>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<MAPAS>()
                .Property(e => e.NUMMAPA)
                .IsUnicode(false);

            modelBuilder.Entity<MAPAS>()
                .Property(e => e.NOMMAPA)
                .IsUnicode(false);

            modelBuilder.Entity<ORDENCOSTEO>()
                .Property(e => e.CantidadTeorica)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ORDENCOSTEO>()
                .Property(e => e.CantidadObtenida)
                .HasPrecision(18, 4);

            modelBuilder.Entity<RESPONSABLE>()
                .Property(e => e.NOMRESPONSABLE)
                .IsUnicode(false);

            modelBuilder.Entity<CARTACREDITO>()
                .Property(e => e.FOLIO)
                .IsUnicode(false);

            modelBuilder.Entity<CARTACREDITO>()
                .Property(e => e.IMPORTE)
                .HasPrecision(18, 4);

            modelBuilder.Entity<CARTACREDITO>()
                .Property(e => e.TIPOMONEDA)
                .IsUnicode(false);

            modelBuilder.Entity<CARTACREDITO>()
                .Property(e => e.COMENTARIOS)
                .IsUnicode(false);

            modelBuilder.Entity<PAGO>()
                .Property(e => e.FOLIO)
                .IsUnicode(false);

            modelBuilder.Entity<PAGO>()
                .Property(e => e.TITULARORIGEN)
                .IsUnicode(false);

            modelBuilder.Entity<PAGO>()
                .Property(e => e.TITULARDESTINO)
                .IsUnicode(false);

            modelBuilder.Entity<PAGO>()
                .Property(e => e.CUENTAORIGEN)
                .IsUnicode(false);

            modelBuilder.Entity<PAGO>()
                .Property(e => e.CUENTADESTINO)
                .IsUnicode(false);

            modelBuilder.Entity<PAGO>()
                .Property(e => e.FORMAPAGO)
                .IsUnicode(false);

            modelBuilder.Entity<PAGO>()
                .Property(e => e.REFERENCIA)
                .IsUnicode(false);

            modelBuilder.Entity<PAGO>()
                .Property(e => e.CONCEPTO)
                .IsUnicode(false);

            modelBuilder.Entity<PAGO>()
                .Property(e => e.TIPOMONEDA)
                .IsUnicode(false);

            modelBuilder.Entity<BITACORA>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<BITACORA>()
                .Property(e => e.ASUNTO)
                .IsUnicode(false);

            modelBuilder.Entity<BITACORA>()
                .Property(e => e.EMAILORIGEN)
                .IsUnicode(false);

            modelBuilder.Entity<BITACORA>()
                .Property(e => e.EMAILDESTINO)
                .IsUnicode(false);

            modelBuilder.Entity<BITACORA>()
                .Property(e => e.RUTA_ARCHIVOS)
                .IsUnicode(false);

            modelBuilder.Entity<BITACORA>()
                .Property(e => e.FOLIO)
                .IsUnicode(false);

            modelBuilder.Entity<BITACORA>()
                .Property(e => e.RFC_EMISOR)
                .IsUnicode(false);

            modelBuilder.Entity<BITACORA>()
                .Property(e => e.IDEMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<BITACORA>()
                .Property(e => e.RFC_RECEPTOR)
                .IsUnicode(false);

            modelBuilder.Entity<BITACORA>()
                .Property(e => e.MENSAJEATENDIDA)
                .IsUnicode(false);

            modelBuilder.Entity<CFDI>()
                .Property(e => e.VERSION)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CFDI>()
                .Property(e => e.SERIE)
                .IsUnicode(false);

            modelBuilder.Entity<CFDI>()
                .Property(e => e.FOLIO)
                .IsUnicode(false);

            modelBuilder.Entity<CFDI>()
                .Property(e => e.TIPO_COMPROBANTE)
                .IsUnicode(false);

            modelBuilder.Entity<CFDI>()
                .Property(e => e.CERTIFICADO_SAT)
                .IsUnicode(false);

            modelBuilder.Entity<CFDI>()
                .Property(e => e.CERTIFICADO_EMISOR)
                .IsUnicode(false);

            modelBuilder.Entity<CFDI>()
                .Property(e => e.UUID)
                .IsUnicode(false);

            modelBuilder.Entity<CFDI>()
                .Property(e => e.IMPORTE_TOTAL)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CFDI>()
                .Property(e => e.RFC_EMISOR)
                .IsUnicode(false);

            modelBuilder.Entity<CFDI>()
                .Property(e => e.RFC_RECEPTOR)
                .IsUnicode(false);

            modelBuilder.Entity<CFDI>()
                .Property(e => e.RUTA_XML)
                .IsUnicode(false);

            modelBuilder.Entity<CFDI>()
                .Property(e => e.NOMBRE_ORIGINAL)
                .IsUnicode(false);

            modelBuilder.Entity<CFDI>()
                .Property(e => e.EMAIL_ORIGEN)
                .IsUnicode(false);

            modelBuilder.Entity<CFDI>()
                .Property(e => e.PROVEEDOR)
                .IsUnicode(false);

            modelBuilder.Entity<CFDI>()
                .Property(e => e.EMAIL_REMITENTE)
                .IsUnicode(false);

            modelBuilder.Entity<CFDI>()
                .Property(e => e.IDEMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<CFDI>()
                .Property(e => e.MSGCONTRARECIBO)
                .IsUnicode(false);

            modelBuilder.Entity<CFDI>()
                .Property(e => e.DESTINATARIOSCONTRARECIBO)
                .IsUnicode(false);

            modelBuilder.Entity<CFDI>()
                .Property(e => e.ASUNTOCONTRARECIBO)
                .IsUnicode(false);

            modelBuilder.Entity<CFDI>()
                .Property(e => e.CONDICIONES)
                .IsUnicode(false);

            modelBuilder.Entity<CFDI>()
                .Property(e => e.TIPOMONEDA)
                .IsUnicode(false);

            modelBuilder.Entity<CFDI>()
                .Property(e => e.TIPOFACTURA)
                .IsUnicode(false);

            modelBuilder.Entity<CFDI>()
                .Property(e => e.MOTIVOCANCELACION)
                .IsUnicode(false);

            modelBuilder.Entity<CFDI>()
                .HasMany(e => e.PAGO)
                .WithRequired(e => e.CFDI)
                .HasForeignKey(e => e.IDCFDI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CFDI>()
                .HasMany(e => e.PDF)
                .WithOptional(e => e.CFDI)
                .HasForeignKey(e => e.IDCFDI);

            modelBuilder.Entity<PDF>()
                .Property(e => e.RUTA)
                .IsUnicode(false);

            modelBuilder.Entity<PDF>()
                .Property(e => e.NOMBREARCHIVO)
                .IsUnicode(false);

            modelBuilder.Entity<COLONIA>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<COLONIA>()
                .Property(e => e.CODIGOPOSTAL)
                .IsUnicode(false);

            modelBuilder.Entity<DOMICILIO>()
                .Property(e => e.TIPODOMICILIO)
                .IsUnicode(false);

            modelBuilder.Entity<DOMICILIO>()
                .Property(e => e.COLONIA)
                .IsUnicode(false);

            modelBuilder.Entity<DOMICILIO>()
                .Property(e => e.CALLE)
                .IsUnicode(false);

            modelBuilder.Entity<DOMICILIO>()
                .Property(e => e.NOEXT)
                .IsUnicode(false);

            modelBuilder.Entity<DOMICILIO>()
                .Property(e => e.NOINT)
                .IsUnicode(false);

            modelBuilder.Entity<DOMICILIO>()
                .Property(e => e.COMPLEMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<DOMICILIO>()
                .Property(e => e.CODIGOPOSTAL)
                .IsUnicode(false);

            modelBuilder.Entity<DOMICILIO>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<DOMICILIO>()
                .HasMany(e => e.FACTURAS)
                .WithRequired(e => e.DOMICILIO)
                .HasForeignKey(e => e.IDDOMICILIOFISCAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DOMICILIO>()
                .HasMany(e => e.FACTURAS1)
                .WithRequired(e => e.DOMICILIO1)
                .HasForeignKey(e => e.IDDOMICILIOMATRIZ)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DOMICILIO>()
                .HasMany(e => e.FACTURAS2)
                .WithRequired(e => e.DOMICILIO2)
                .HasForeignKey(e => e.IDDOMICILIOSUCURSAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DOMICILIO>()
                .HasMany(e => e.PROVEEDOR)
                .WithOptional(e => e.DOMICILIO)
                .HasForeignKey(e => e.IDDIRECCION);

            modelBuilder.Entity<DOMICILIO>()
                .HasMany(e => e.SUCURSAL)
                .WithOptional(e => e.DOMICILIO)
                .HasForeignKey(e => e.IDDOMICILIO);

            modelBuilder.Entity<DOMICILIO>()
                .HasMany(e => e.SUCURSAL1)
                .WithOptional(e => e.DOMICILIO1)
                .HasForeignKey(e => e.IDDOMICILIOENTREGA);

            modelBuilder.Entity<DOMICILIOENTREGA>()
                .Property(e => e.TIPODOMICILIO)
                .IsUnicode(false);

            modelBuilder.Entity<DOMICILIOENTREGA>()
                .Property(e => e.COLONIA)
                .IsUnicode(false);

            modelBuilder.Entity<DOMICILIOENTREGA>()
                .Property(e => e.CALLE)
                .IsUnicode(false);

            modelBuilder.Entity<DOMICILIOENTREGA>()
                .Property(e => e.NOEXT)
                .IsUnicode(false);

            modelBuilder.Entity<DOMICILIOENTREGA>()
                .Property(e => e.NOINT)
                .IsUnicode(false);

            modelBuilder.Entity<DOMICILIOENTREGA>()
                .Property(e => e.COMPLEMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<DOMICILIOENTREGA>()
                .Property(e => e.CODIGOPOSTAL)
                .IsUnicode(false);

            modelBuilder.Entity<DOMICILIOENTREGA>()
                .Property(e => e.ALIAS)
                .IsUnicode(false);

            modelBuilder.Entity<DOMICILIOENTREGA>()
                .HasMany(e => e.CLIENTES2)
                .WithOptional(e => e.DOMICILIOENTREGA)
                .HasForeignKey(e => e.IDDOMICILIOENVIO);

            modelBuilder.Entity<DOMICILIOENTREGA>()
                .HasMany(e => e.FACTURAS)
                .WithOptional(e => e.DOMICILIOENTREGA)
                .HasForeignKey(e => e.IDDOMICILIOENVIOS);

            modelBuilder.Entity<ESTADO>()
                .Property(e => e.CLAVE)
                .IsUnicode(false);

            modelBuilder.Entity<ESTADO>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<MUNICIPIO>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<PAIS>()
                .Property(e => e.CLAVE)
                .IsUnicode(false);

            modelBuilder.Entity<PAIS>()
                .Property(e => e.CLAVECORTA)
                .IsUnicode(false);

            modelBuilder.Entity<PAIS>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<CENTROSTRABAJO>()
                .Property(e => e.TiempoEsperaPrevio)
                .HasPrecision(5, 2);

            modelBuilder.Entity<CENTROSTRABAJO>()
                .Property(e => e.TiempoConfiguracion)
                .HasPrecision(5, 2);

            modelBuilder.Entity<CENTROSTRABAJO>()
                .Property(e => e.TiempoOperacion)
                .HasPrecision(5, 2);

            modelBuilder.Entity<CENTROSTRABAJO>()
                .Property(e => e.TiempoTransito)
                .HasPrecision(5, 2);

            modelBuilder.Entity<CENTROSTRABAJO>()
                .Property(e => e.TiempoEsperaPosterior)
                .HasPrecision(5, 2);

            modelBuilder.Entity<CENTROSTRABAJO>()
                .Property(e => e.Capacidad)
                .HasPrecision(18, 4);

            modelBuilder.Entity<CENTROSTRABAJO>()
                .Property(e => e.CostoUnitDirecto)
                .HasPrecision(18, 8);

            modelBuilder.Entity<CENTROSTRABAJO>()
                .Property(e => e.CostoIndirectoPorcentaje)
                .HasPrecision(5, 2);

            modelBuilder.Entity<CENTROSTRABAJO>()
                .Property(e => e.TasaCostosGenerales)
                .HasPrecision(18, 8);

            modelBuilder.Entity<CENTROSTRABAJO>()
                .HasMany(e => e.RUTASOPERACIONESDETALLE)
                .WithRequired(e => e.CENTROSTRABAJO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CENTROSTRABAJOTIPOS>()
                .HasMany(e => e.CENTROSTRABAJO)
                .WithRequired(e => e.CENTROSTRABAJOTIPOS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ESCENARIO>()
                .Property(e => e.CLAVE)
                .IsUnicode(false);

            modelBuilder.Entity<ESCENARIO>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<ESCENARIO>()
                .Property(e => e.CATEGORIA)
                .IsUnicode(false);

            modelBuilder.Entity<ESCENARIO>()
                .HasMany(e => e.ETAPAS)
                .WithRequired(e => e.ESCENARIO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ESCENARIO>()
                .HasMany(e => e.ETAPASOPERACIONES)
                .WithRequired(e => e.ESCENARIO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ESCENARIO>()
                .HasMany(e => e.ETAPASSUBOPERACIONES)
                .WithRequired(e => e.ESCENARIO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ESCENARIO>()
                .HasMany(e => e.RUTASOPERACIONESDETALLE)
                .WithRequired(e => e.ESCENARIO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ETAPAS>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<ETAPAS>()
                .HasMany(e => e.ETAPASOPERACIONES)
                .WithRequired(e => e.ETAPAS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ETAPAS>()
                .HasMany(e => e.ETAPASSUBOPERACIONES)
                .WithRequired(e => e.ETAPAS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ETAPAS>()
                .HasMany(e => e.RUTASOPERACIONESDETALLE)
                .WithRequired(e => e.ETAPAS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ETAPASOPERACIONES>()
                .HasMany(e => e.ETAPASSUBOPERACIONES)
                .WithRequired(e => e.ETAPASOPERACIONES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ETAPASOPERACIONES>()
                .HasMany(e => e.RUTASOPERACIONESDETALLE)
                .WithOptional(e => e.ETAPASOPERACIONES)
                .HasForeignKey(e => e.IDEtapaOperacion);

            modelBuilder.Entity<OPERACIONES>()
                .Property(e => e.Tipo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDENACONDICIONAMIENTO>()
                .Property(e => e.TAMANOESTANDAR)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ORDENACONDICIONAMIENTO>()
                .Property(e => e.TAMANOFABRICAR)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ORDENACONDICIONAMIENTO>()
                .Property(e => e.TAMANOFABRICADO)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ORDENACONDICIONAMIENTO>()
                .Property(e => e.RENDIMIENTOOBTENIDO)
                .HasPrecision(5, 2);

            modelBuilder.Entity<ORDENACONDICIONAMIENTO>()
                .HasMany(e => e.ORDENACONDICIONAMIENTOHISTORIAL)
                .WithRequired(e => e.ORDENACONDICIONAMIENTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ORDENACONDICIONAMIENTODETALLE>()
                .Property(e => e.CANTIDADUNITARIA)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ORDENACONDICIONAMIENTODETALLE>()
                .Property(e => e.CANTIDADPORLOTE)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ORDENACONDICIONAMIENTODETALLE>()
                .Property(e => e.CANTIDADREQUERIDA)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ORDENACONDICIONAMIENTODETALLE>()
                .Property(e => e.CANTIDADSURTIDA)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ORDENACONDICIONAMIENTODETALLE>()
                .Property(e => e.CANTIDADDEVOLUCION)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ORDENACONDICIONAMIENTODETALLE>()
                .Property(e => e.CANTIDADDESPERDICIO)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ORDENACONDICIONAMIENTODETALLE>()
                .Property(e => e.CANTIDADAPARTADA)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ORDENPRODUCCION>()
                .Property(e => e.TamanoEstandar)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ORDENPRODUCCION>()
                .Property(e => e.TamanoFabricar)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ORDENPRODUCCION>()
                .Property(e => e.TamanoFabricado)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ORDENPRODUCCION>()
                .Property(e => e.RendimientoObtenido)
                .HasPrecision(5, 2);

            modelBuilder.Entity<ORDENPRODUCCIONDETALLE>()
                .Property(e => e.CANTIDADUNITARIA)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ORDENPRODUCCIONDETALLE>()
                .Property(e => e.CANTIDADPORLOTE)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ORDENPRODUCCIONDETALLE>()
                .Property(e => e.CANTIDADREQUERIDA)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ORDENPRODUCCIONDETALLE>()
                .Property(e => e.CANTIDADAPARTADA)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ORDENPRODUCCIONDETALLE>()
                .Property(e => e.CANTIDADSURTIDA)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ORDENPRODUCCIONDETALLE>()
                .Property(e => e.CANTIDADCONTROL)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ORDENPRODUCCIONDETALLE>()
                .Property(e => e.CANTIDADDEVOLUCION)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ORDENPRODUCCIONDETALLE>()
                .Property(e => e.CANTIDADDESPERDICIO)
                .HasPrecision(18, 4);

            modelBuilder.Entity<PRODUCTOSECTOR>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCTOSECTOR>()
                .Property(e => e.CODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<PROGRAMAACONDICIONAMIENTO>()
                .Property(e => e.TIPO)
                .IsUnicode(false);

            modelBuilder.Entity<PROGRAMAACONDICIONAMIENTO>()
                .Property(e => e.COMENTARIOS)
                .IsUnicode(false);

            modelBuilder.Entity<PROGRAMAACONDICIONAMIENTO>()
                .Property(e => e.FOLIO)
                .IsUnicode(false);

            modelBuilder.Entity<PROGRAMAACONDICIONAMIENTODETALLE>()
                .Property(e => e.TAMANOFABRICAR)
                .HasPrecision(18, 4);

            modelBuilder.Entity<PROGRAMAACONDICIONAMIENTODETALLE>()
                .Property(e => e.CODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<PROGRAMAACONDICIONAMIENTODETALLE>()
                .Property(e => e.TAMANOESTANDAR)
                .HasPrecision(18, 4);

            modelBuilder.Entity<PROGRAMAFABRICACION>()
                .Property(e => e.FOLIO)
                .IsUnicode(false);

            modelBuilder.Entity<PROGRAMAFABRICACION>()
                .Property(e => e.TIPO)
                .IsUnicode(false);

            modelBuilder.Entity<PROGRAMAFABRICACION>()
                .Property(e => e.COMENTARIOS)
                .IsUnicode(false);

            modelBuilder.Entity<PROGRAMAFABRICACIONDETALLE>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<PROGRAMAFABRICACIONDETALLE>()
                .Property(e => e.TamanoFabricar)
                .HasPrecision(18, 4);

            modelBuilder.Entity<PROGRAMAFABRICACIONDETALLE>()
                .Property(e => e.TamanoEstandar)
                .HasPrecision(18, 4);

            modelBuilder.Entity<PROGRAMAFABRICACIONDETALLE>()
                .Property(e => e.TamanoRestante)
                .HasPrecision(18, 4);

            modelBuilder.Entity<PROGRAMAFABRICACIONDETALLE>()
                .Property(e => e.TamanoTransformado)
                .HasPrecision(18, 4);

            modelBuilder.Entity<RUTASOPERACIONESDETALLE>()
                .Property(e => e.PorcentajeDestruccion)
                .HasPrecision(3, 2);

            modelBuilder.Entity<RUTASOPERACIONESDETALLE>()
                .Property(e => e.FactorConsumo)
                .HasPrecision(3, 2);

            modelBuilder.Entity<RUTASOPERACIONESDETALLE>()
                .Property(e => e.RiesgoBMA)
                .IsFixedLength();

            modelBuilder.Entity<RUTASOPERACIONESDETALLE>()
                .Property(e => e.TiempoEsperaPrevio)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RUTASOPERACIONESDETALLE>()
                .Property(e => e.TiempoConfiguracion)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RUTASOPERACIONESDETALLE>()
                .Property(e => e.TiempoOperacion)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RUTASOPERACIONESDETALLE>()
                .Property(e => e.CantidadProceso)
                .HasPrecision(18, 4);

            modelBuilder.Entity<RUTASOPERACIONESDETALLE>()
                .Property(e => e.TiempoTransito)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RUTASOPERACIONESDETALLE>()
                .Property(e => e.TiempoEsperaPosterior)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RUTASOPERACIONESDETALLE>()
                .HasMany(e => e.RUTASOPERACIONESDETALLE1)
                .WithOptional(e => e.RUTASOPERACIONESDETALLE2)
                .HasForeignKey(e => e.IDRutaDetalleSiguiente);

            modelBuilder.Entity<ABONOS>()
                .Property(e => e.TIPOCAMBIO)
                .HasPrecision(12, 2);

            modelBuilder.Entity<CANCELACIONCDFI>()
                .Property(e => e.CHRRUTAXML)
                .IsUnicode(false);

            modelBuilder.Entity<CANCELACIONCDFI>()
                .Property(e => e.STRMOTIVO)
                .IsUnicode(false);

            modelBuilder.Entity<CPHUSOSHORARIO>()
                .Property(e => e.strCodigoPostal)
                .IsUnicode(false);

            modelBuilder.Entity<CPHUSOSHORARIO>()
                .Property(e => e.strClaveEstado)
                .IsUnicode(false);

            modelBuilder.Entity<CPHUSOSHORARIO>()
                .Property(e => e.strMunicipio)
                .IsUnicode(false);

            modelBuilder.Entity<CPHUSOSHORARIO>()
                .Property(e => e.strLocalidad)
                .IsUnicode(false);

            modelBuilder.Entity<CPHUSOSHORARIO>()
                .Property(e => e.strHusoHorario)
                .IsUnicode(false);

            modelBuilder.Entity<CPHUSOSHORARIO>()
                .Property(e => e.strMesHIVerano)
                .IsUnicode(false);

            modelBuilder.Entity<CPHUSOSHORARIO>()
                .Property(e => e.strDiaHVerano)
                .IsUnicode(false);

            modelBuilder.Entity<CPHUSOSHORARIO>()
                .Property(e => e.dtdHoraIHVerano)
                .IsUnicode(false);

            modelBuilder.Entity<CPHUSOSHORARIO>()
                .Property(e => e.strMesHIInvierrno)
                .IsUnicode(false);

            modelBuilder.Entity<CPHUSOSHORARIO>()
                .Property(e => e.strDiaHInvierno)
                .IsUnicode(false);

            modelBuilder.Entity<CPHUSOSHORARIO>()
                .Property(e => e.dtdHoraIHInvierno)
                .IsUnicode(false);

            modelBuilder.Entity<FACTURAS>()
                .Property(e => e.TIPOCAMBIO)
                .HasPrecision(6, 2);

            modelBuilder.Entity<FACTURAS>()
                .Property(e => e.TIPO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FACTURAS>()
                .HasMany(e => e.NOTASCREDITO)
                .WithRequired(e => e.FACTURAS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FACTURAS>()
                .HasMany(e => e.NOTASDEVOLUCION)
                .WithRequired(e => e.FACTURAS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FACTURAS>()
                .HasMany(e => e.ABONOS)
                .WithRequired(e => e.FACTURAS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FACTURAS>()
                .HasMany(e => e.FACTURALICITACION)
                .WithRequired(e => e.FACTURAS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FACTURAS>()
                .HasMany(e => e.FACTURASCFDI)
                .WithRequired(e => e.FACTURAS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FACTURAS>()
                .HasMany(e => e.FACTURASDETALLE)
                .WithRequired(e => e.FACTURAS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FACTURASCFDI>()
                .Property(e => e.SELLOEMISOR)
                .IsUnicode(false);

            modelBuilder.Entity<FACTURASCFDI>()
                .Property(e => e.SELLOSAT)
                .IsUnicode(false);

            modelBuilder.Entity<FACTURASCFDI>()
                .Property(e => e.CADENAORIGINAL)
                .IsUnicode(false);

            modelBuilder.Entity<FACTURASCFDI>()
                .Property(e => e.RUTAXML)
                .IsUnicode(false);

            modelBuilder.Entity<FACTURASDETALLE>()
                .Property(e => e.CANTIDAD)
                .HasPrecision(11, 2);

            modelBuilder.Entity<FACTURASDETALLE>()
                .HasMany(e => e.NOTASDEVOLUCIONDETALLE)
                .WithRequired(e => e.FACTURASDETALLE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PAGOS>()
                .Property(e => e.TIPOCAMBIO)
                .HasPrecision(5, 2);

            modelBuilder.Entity<PAGOS>()
                .HasMany(e => e.ABONOS)
                .WithRequired(e => e.PAGOS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PAGOS>()
                .HasMany(e => e.PAGOSCFDI)
                .WithRequired(e => e.PAGOS)
                .HasForeignKey(e => e.IDPAGO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PAGOS>()
                .HasMany(e => e.PAGOSCFDI1)
                .WithRequired(e => e.PAGOS1)
                .HasForeignKey(e => e.IDPAGO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PAGOS>()
                .HasMany(e => e.PAGOSHISTORIAL)
                .WithRequired(e => e.PAGOS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PAGOSCFDI>()
                .Property(e => e.SELLOEMISOR)
                .IsUnicode(false);

            modelBuilder.Entity<PAGOSCFDI>()
                .Property(e => e.SELLOSAT)
                .IsUnicode(false);

            modelBuilder.Entity<PAGOSCFDI>()
                .Property(e => e.CADENAORIGINAL)
                .IsUnicode(false);

            modelBuilder.Entity<PAGOSCFDI>()
                .Property(e => e.RUTAXML)
                .IsUnicode(false);

            modelBuilder.Entity<PAGOSCFDIELIMINADOS>()
                .Property(e => e.SELLOEMISOR)
                .IsUnicode(false);

            modelBuilder.Entity<PAGOSCFDIELIMINADOS>()
                .Property(e => e.SELLOSAT)
                .IsUnicode(false);

            modelBuilder.Entity<PAGOSCFDIELIMINADOS>()
                .Property(e => e.CADENAORIGINAL)
                .IsUnicode(false);

            modelBuilder.Entity<PAGOSCFDIELIMINADOS>()
                .Property(e => e.RUTAXML)
                .IsUnicode(false);

            modelBuilder.Entity<PAGOSHISTORIAL>()
                .Property(e => e.TIPOCAMBIO)
                .HasPrecision(5, 2);

            modelBuilder.Entity<PRODUCTOLICITACION>()
                .Property(e => e.CLAVE)
                .IsUnicode(false);

            modelBuilder.Entity<REFERENCIASBANCARIAS>()
                .HasMany(e => e.CLIENTESHISTORIAL)
                .WithOptional(e => e.REFERENCIASBANCARIAS)
                .HasForeignKey(e => e.IDREFERENCIA);

            modelBuilder.Entity<REFERENCIASBANCARIASNEGOCIO>()
                .Property(e => e.PREFIJO)
                .IsFixedLength();

            modelBuilder.Entity<TIPOPAGO>()
                .HasMany(e => e.PAGOS)
                .WithRequired(e => e.TIPOPAGO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<USUARIOAUTORIZA>()
                .Property(e => e.CLAVE)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTES>()
                .Property(e => e.DESCUENTOPORCIENTO)
                .HasPrecision(5, 2);

            modelBuilder.Entity<CLIENTES>()
                .HasMany(e => e.CLIENTESHISTORIAL)
                .WithRequired(e => e.CLIENTES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CLIENTESHISTORIAL>()
                .Property(e => e.DESCUENTOPORCIENTO)
                .HasPrecision(5, 2);

            modelBuilder.Entity<INVENTARIO>()
                .Property(e => e.FOLIO)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTARIO>()
                .Property(e => e.TIPO)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTARIO>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTARIO>()
                .Property(e => e.AJUSTEOBSERVACION)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTARIO>()
                .Property(e => e.TITULO)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTARIODETALLE>()
                .Property(e => e.CODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTARIODETALLE>()
                .Property(e => e.NOLOTE)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTARIODETALLE>()
                .Property(e => e.NOPRODUCTO)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTARIODETALLE>()
                .Property(e => e.PRODUCTODESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTARIODETALLE>()
                .Property(e => e.COSTOESTANDAR)
                .HasPrecision(18, 4);

            modelBuilder.Entity<INVENTARIODETALLE>()
                .Property(e => e.EXISTENCIATEORICA)
                .HasPrecision(18, 4);

            modelBuilder.Entity<INVENTARIODETALLE>()
                .Property(e => e.EXISTENCIAFISICA)
                .HasPrecision(18, 4);

            modelBuilder.Entity<INVENTARIODETALLE>()
                .Property(e => e.OBSERVACIONES)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTARIODETALLE>()
                .Property(e => e.PRIMERCONTEO)
                .HasPrecision(18, 4);

            modelBuilder.Entity<INVENTARIODETALLE>()
                .Property(e => e.SEGUNDOCONTEO)
                .HasPrecision(18, 4);

            modelBuilder.Entity<INVENTARIODETALLE>()
                .Property(e => e.TERCERCONTEO)
                .HasPrecision(18, 4);

            modelBuilder.Entity<INVENTARIODETALLE>()
                .Property(e => e.AJUSTEFOLIO)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTARIODETALLE>()
                .Property(e => e.PRODUCTONOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<AUTORIZAVENTACREDITO>()
                .Property(e => e.CREDITOAUTORIZADO)
                .HasPrecision(18, 4);

            modelBuilder.Entity<AUTORIZAVENTACREDITO>()
                .Property(e => e.DEUDAACTUAL)
                .HasPrecision(18, 4);

            modelBuilder.Entity<AUTORIZAVENTACREDITO>()
                .Property(e => e.EXTENSIONDECREDITO)
                .HasPrecision(18, 4);

            modelBuilder.Entity<CONFIGURACIONPRODUCTOENVIO>()
                .Property(e => e.CLAVEORIGEN)
                .IsUnicode(false);

            modelBuilder.Entity<CONFIGURACIONPRODUCTOENVIO>()
                .Property(e => e.CLAVEDESTINO)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTARIO1>()
                .Property(e => e.FOLIO)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTARIO1>()
                .Property(e => e.TITULO)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTARIO_LARISSA>()
                .Property(e => e.FOLIO)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTARIODETALLE1>()
                .Property(e => e.ITEM)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTARIODETALLE1>()
                .Property(e => e.NOLOTE)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTARIODETALLE1>()
                .Property(e => e.NOPRODUCTO)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTARIODETALLE1>()
                .Property(e => e.PRODUCTODESC)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTARIODETALLE1>()
                .Property(e => e.COSTOESTANDAR)
                .HasPrecision(18, 4);

            modelBuilder.Entity<INVENTARIODETALLE1>()
                .Property(e => e.EXISTENCIA)
                .HasPrecision(18, 4);

            modelBuilder.Entity<INVENTARIODETALLE1>()
                .Property(e => e.CONTEOFINAL)
                .HasPrecision(18, 4);

            modelBuilder.Entity<INVENTARIODETALLE1>()
                .Property(e => e.DIFERENCIAFINAL)
                .HasPrecision(18, 4);

            modelBuilder.Entity<INVENTARIODETALLE1>()
                .Property(e => e.PRIMERCONTEO)
                .HasPrecision(18, 4);

            modelBuilder.Entity<INVENTARIODETALLE1>()
                .Property(e => e.SEGUNDOCONTEO)
                .HasPrecision(18, 4);

            modelBuilder.Entity<INVENTARIODETALLE1>()
                .Property(e => e.TERCERCONTEO)
                .HasPrecision(18, 4);

            modelBuilder.Entity<INVENTARIODETALLE1>()
                .Property(e => e.OBSERVACIONES)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTARIODETALLE1>()
                .Property(e => e.PRIMERDIFERENCIA)
                .HasPrecision(18, 4);

            modelBuilder.Entity<INVENTARIODETALLE1>()
                .Property(e => e.SEGUNDADIFERENCIA)
                .HasPrecision(18, 4);

            modelBuilder.Entity<INVENTARIODETALLE1>()
                .Property(e => e.TERCERDIFERENCIA)
                .HasPrecision(18, 4);

            modelBuilder.Entity<INVENTARIODETALLE1>()
                .Property(e => e.CONTEODIFERENCIA)
                .HasPrecision(18, 4);

            modelBuilder.Entity<INVENTARIODETALLE1>()
                .Property(e => e.IMPORTEEXISTENCIA)
                .HasPrecision(18, 4);

            modelBuilder.Entity<INVENTARIODETALLE1>()
                .Property(e => e.IMPORTECONTEO)
                .HasPrecision(18, 4);

            modelBuilder.Entity<INVENTARIODETALLE1>()
                .Property(e => e.IMPORTEDIFERENCIA)
                .HasPrecision(18, 4);

            modelBuilder.Entity<INVENTARIODETALLE_LARISSA>()
                .Property(e => e.NOLOTE)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTARIODETALLE_LARISSA>()
                .Property(e => e.NOPRODUCTO)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTARIODETALLE_LARISSA>()
                .Property(e => e.PRODUCTODESC)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTARIODETALLE_LARISSA>()
                .Property(e => e.EXISTENCIA)
                .HasPrecision(14, 4);

            modelBuilder.Entity<INVENTARIODETALLE_LARISSA>()
                .Property(e => e.CONTADO)
                .HasPrecision(14, 4);

            modelBuilder.Entity<INVENTARIODETALLE_LARISSA>()
                .Property(e => e.DIFERENCIA)
                .HasPrecision(14, 4);

            modelBuilder.Entity<INVENTARIODETALLE_LARISSA>()
                .Property(e => e.COSTOESTANDAR)
                .HasPrecision(12, 4);

            modelBuilder.Entity<INVENTARIODETALLE_LARISSA>()
                .Property(e => e.IMPORTEEXISTENCIA)
                .HasPrecision(18, 4);

            modelBuilder.Entity<INVENTARIODETALLE_LARISSA>()
                .Property(e => e.IMPORTECONTADO)
                .HasPrecision(18, 4);

            modelBuilder.Entity<INVENTARIODETALLE_LARISSA>()
                .Property(e => e.IMPORTEDIFERENCIA)
                .HasPrecision(18, 4);

            modelBuilder.Entity<INVENTARIODETALLE_LARISSA>()
                .Property(e => e.OBSERVACIONES)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTARIOTICKET>()
                .Property(e => e.ESTATUS)
                .IsUnicode(false);

            modelBuilder.Entity<CFDI1>()
                .Property(e => e.IDEMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<CFDI1>()
                .Property(e => e.EMAIL_REMITENTE)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTES1>()
                .Property(e => e.CLAVE)
                .IsFixedLength();

            modelBuilder.Entity<CLIENTES1>()
                .Property(e => e.LIMITECREDITO)
                .HasPrecision(12, 2);

            modelBuilder.Entity<PRODUCTOS>()
                .Property(e => e.CLAVE)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCTOS>()
                .Property(e => e.PREFIJOLOTE)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCTOS>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCTOS>()
                .Property(e => e.NOMBREUS)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCTOS>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCTOS>()
                .Property(e => e.COMENTARIOS)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCTOS>()
                .Property(e => e.CLASE)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCTOS>()
                .Property(e => e.COSTOESTANDAR)
                .HasPrecision(18, 6);

            modelBuilder.Entity<PRODUCTOS>()
                .Property(e => e.MINIMO)
                .HasPrecision(18, 4);

            modelBuilder.Entity<XMLFACTURADETALLE>()
                .Property(e => e.CANTIDAD)
                .HasPrecision(18, 0);

            modelBuilder.Entity<XMLFACTURADETALLE>()
                .Property(e => e.TASA)
                .HasPrecision(10, 6);

            modelBuilder.Entity<AREAS1>()
                .HasMany(e => e.ETAPASSUBOPERACIONES)
                .WithRequired(e => e.AREAS1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CLASEPROVEEDOR>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTES2>()
                .Property(e => e.LIMITECREDITO)
                .HasPrecision(12, 2);

            modelBuilder.Entity<CLIENTES2>()
                .HasMany(e => e.NOTASCREDITO)
                .WithRequired(e => e.CLIENTES2)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CLIENTES2>()
                .HasMany(e => e.NOTASDEVOLUCION)
                .WithRequired(e => e.CLIENTES2)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CLIENTES2>()
                .HasMany(e => e.FACTURAS)
                .WithRequired(e => e.CLIENTES2)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CLIENTES2>()
                .HasMany(e => e.PAGOS)
                .WithRequired(e => e.CLIENTES2)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CLIENTES2>()
                .HasMany(e => e.CLIENTES)
                .WithRequired(e => e.CLIENTES2)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CLIENTES2>()
                .HasMany(e => e.CLIENTESHISTORIAL)
                .WithRequired(e => e.CLIENTES2)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CLIENTES2>()
                .HasMany(e => e.CLIENTELICITACION)
                .WithRequired(e => e.CLIENTES2)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CLIENTES2>()
                .HasMany(e => e.CLIENTESFACULTADOS)
                .WithRequired(e => e.CLIENTES2)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CLIENTES2>()
                .HasMany(e => e.PEDIDOS)
                .WithRequired(e => e.CLIENTES2)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CLIENTES2>()
                .HasMany(e => e.PERFILCREDITO)
                .WithRequired(e => e.CLIENTES2)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CLIENTES2>()
                .HasMany(e => e.PERFILCREDITOHISTORICO)
                .WithRequired(e => e.CLIENTES2)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CLIENTES2>()
                .HasMany(e => e.PRECIOVENTALISTACLIENTE)
                .WithRequired(e => e.CLIENTES2)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CLIENTES2>()
                .HasMany(e => e.REGISTROVENTA)
                .WithRequired(e => e.CLIENTES2)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CLIENTES2>()
                .HasMany(e => e.REGISTROVENTAHISTORIAL)
                .WithRequired(e => e.CLIENTES2)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CLIENTES2>()
                .HasMany(e => e.TARJETASPODER)
                .WithRequired(e => e.CLIENTES2)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DEPARTAMENTO1>()
                .Property(e => e.CLAVE)
                .IsUnicode(false);

            modelBuilder.Entity<DEPARTAMENTO1>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<DEPARTAMENTO1>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<DEPARTAMENTO1>()
                .HasMany(e => e.ETAPASSUBOPERACIONES)
                .WithRequired(e => e.DEPARTAMENTO1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DEPARTAMENTOS>()
                .HasMany(e => e.AREA)
                .WithRequired(e => e.DEPARTAMENTOS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DEPARTAMENTOSUCURSAL>()
                .HasMany(e => e.COMPRA)
                .WithOptional(e => e.DEPARTAMENTOSUCURSAL1)
                .HasForeignKey(e => e.IDDEPARTAMENTO);

            modelBuilder.Entity<DEPARTAMENTOSUCURSAL>()
                .HasMany(e => e.AREAS1)
                .WithRequired(e => e.DEPARTAMENTOSUCURSAL)
                .HasForeignKey(e => e.IDDEPARTAMENTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DEPARTAMENTOSUCURSAL>()
                .HasMany(e => e.CUENTAS1)
                .WithRequired(e => e.DEPARTAMENTOSUCURSAL)
                .HasForeignKey(e => e.IDDEPARTAMENTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DEPARTAMENTOSUCURSAL>()
                .HasMany(e => e.COMPRA1)
                .WithOptional(e => e.DEPARTAMENTOSUCURSAL1)
                .HasForeignKey(e => e.IDDEPARTAMENTO);

            modelBuilder.Entity<EMPRESA1>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESA1>()
                .Property(e => e.RAZONSOCIAL)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESA1>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESA1>()
                .HasMany(e => e.TRASLADOS)
                .WithRequired(e => e.EMPRESA1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA1>()
                .HasMany(e => e.CUENTASCORREO)
                .WithRequired(e => e.EMPRESA1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA1>()
                .HasMany(e => e.TIPODOCUMENTO1)
                .WithRequired(e => e.EMPRESA1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA1>()
                .HasMany(e => e.ACTIVOSFIJOSCATEGORIAS)
                .WithRequired(e => e.EMPRESA1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA1>()
                .HasMany(e => e.ACTIVOSFIJOSSUBCATEGORIAS)
                .WithRequired(e => e.EMPRESA1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA1>()
                .HasMany(e => e.CUENTASCOSTOS)
                .WithRequired(e => e.EMPRESA1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA1>()
                .HasMany(e => e.NOTASCREDITO)
                .WithRequired(e => e.EMPRESA1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA1>()
                .HasMany(e => e.NOTASDEVOLUCION)
                .WithRequired(e => e.EMPRESA1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA1>()
                .HasMany(e => e.ORDENCOSTEOSUBTIPO)
                .WithRequired(e => e.EMPRESA1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA1>()
                .HasMany(e => e.ORDENCOSTEOTIPO)
                .WithRequired(e => e.EMPRESA1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA1>()
                .HasMany(e => e.CENTROSTRABAJO)
                .WithRequired(e => e.EMPRESA1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA1>()
                .HasMany(e => e.CENTROSTRABAJOTIPOS)
                .WithRequired(e => e.EMPRESA1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA1>()
                .HasMany(e => e.EDIFICIOS)
                .WithRequired(e => e.EMPRESA1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA1>()
                .HasMany(e => e.ESCENARIO)
                .WithRequired(e => e.EMPRESA1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA1>()
                .HasMany(e => e.ETAPAS)
                .WithRequired(e => e.EMPRESA1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA1>()
                .HasMany(e => e.ETAPASOPERACIONES)
                .WithRequired(e => e.EMPRESA1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA1>()
                .HasMany(e => e.ETAPASSUBOPERACIONES)
                .WithRequired(e => e.EMPRESA1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA1>()
                .HasMany(e => e.RUTASOPERACIONESDETALLE)
                .WithRequired(e => e.EMPRESA1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA1>()
                .HasMany(e => e.CONFIGURACIONSELLOS)
                .WithRequired(e => e.EMPRESA1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA1>()
                .HasMany(e => e.FACTURAS)
                .WithRequired(e => e.EMPRESA1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA1>()
                .HasMany(e => e.PAGOS)
                .WithRequired(e => e.EMPRESA1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA1>()
                .HasMany(e => e.REFERENCIASBANCARIASNEGOCIO)
                .WithRequired(e => e.EMPRESA1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA1>()
                .HasMany(e => e.CLIENTES)
                .WithRequired(e => e.EMPRESA1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA1>()
                .HasMany(e => e.CLIENTESHISTORIAL)
                .WithRequired(e => e.EMPRESA1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA1>()
                .HasMany(e => e.AREA)
                .WithRequired(e => e.EMPRESA1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA1>()
                .HasMany(e => e.AREAS1)
                .WithRequired(e => e.EMPRESA1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA1>()
                .HasMany(e => e.CLIENTES2)
                .WithRequired(e => e.EMPRESA1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA1>()
                .HasMany(e => e.CUENTAS1)
                .WithRequired(e => e.EMPRESA1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA1>()
                .HasMany(e => e.DEPARTAMENTOS)
                .WithRequired(e => e.EMPRESA1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA1>()
                .HasMany(e => e.IMPORTACION)
                .WithRequired(e => e.EMPRESA1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA1>()
                .HasMany(e => e.PEDIDOS)
                .WithRequired(e => e.EMPRESA1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA1>()
                .HasMany(e => e.PERFILCREDITO)
                .WithRequired(e => e.EMPRESA1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA1>()
                .HasMany(e => e.PERFILCREDITOHISTORICO)
                .WithRequired(e => e.EMPRESA1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA1>()
                .HasMany(e => e.PRECIOVENTALISTA)
                .WithRequired(e => e.EMPRESA1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA1>()
                .HasMany(e => e.PROGRAMA)
                .WithRequired(e => e.EMPRESA1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA1>()
                .HasMany(e => e.REGISTROVENTA)
                .WithRequired(e => e.EMPRESA1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA1>()
                .HasMany(e => e.REGISTROVENTAHISTORIAL)
                .WithRequired(e => e.EMPRESA1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA1>()
                .HasMany(e => e.SERVICIO)
                .WithRequired(e => e.EMPRESA1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA1>()
                .HasMany(e => e.SERVICIOCATEGORIA)
                .WithRequired(e => e.EMPRESA1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA1>()
                .HasMany(e => e.SERVICIOGRUPO)
                .WithRequired(e => e.EMPRESA1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA1>()
                .HasMany(e => e.SERVICIOHISTORIAL)
                .WithRequired(e => e.EMPRESA1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA1>()
                .HasMany(e => e.SERVICIOSUBCATEGORIA)
                .WithRequired(e => e.EMPRESA1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA1>()
                .HasMany(e => e.SERVICIOTIPO)
                .WithRequired(e => e.EMPRESA1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA1>()
                .HasMany(e => e.ZONAS)
                .WithRequired(e => e.EMPRESA1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESACERTIFICADO>()
                .Property(e => e.PATHCER)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESACERTIFICADO>()
                .Property(e => e.PATHKEY)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESACERTIFICADO>()
                .Property(e => e.PASSWORD)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESADATOS>()
                .Property(e => e.CONTACTO)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESADATOS>()
                .Property(e => e.TELEFONO)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESADATOS>()
                .Property(e => e.EXT)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESADATOS>()
                .Property(e => e.CELULAR)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESADATOS>()
                .Property(e => e.FAX)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESADATOS>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<PROVEEDOR>()
                .Property(e => e.CLAVE)
                .IsUnicode(false);

            modelBuilder.Entity<PROVEEDOR>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<PROVEEDOR>()
                .Property(e => e.RAZONSOCIAL)
                .IsUnicode(false);

            modelBuilder.Entity<PROVEEDOR>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<PROVEEDOR>()
                .Property(e => e.COMENTARIO)
                .IsUnicode(false);

            modelBuilder.Entity<PROVEEDOR>()
                .Property(e => e.NUMSUCURSAL)
                .IsUnicode(false);

            modelBuilder.Entity<PROVEEDOR>()
                .Property(e => e.DOMSUCURSAL)
                .IsUnicode(false);

            modelBuilder.Entity<PROVEEDOR>()
                .Property(e => e.CUENTA)
                .IsUnicode(false);

            modelBuilder.Entity<PROVEEDOR>()
                .Property(e => e.CLABE)
                .IsUnicode(false);

            modelBuilder.Entity<PROVEEDOR>()
                .Property(e => e.SCODE)
                .IsUnicode(false);

            modelBuilder.Entity<PROVEEDOR>()
                .Property(e => e.TERMINOPAGO)
                .IsUnicode(false);

            modelBuilder.Entity<PROVEEDOR>()
                .Property(e => e.BANCO)
                .IsUnicode(false);

            modelBuilder.Entity<PROVEEDOR>()
                .HasMany(e => e.CFDI)
                .WithOptional(e => e.PROVEEDOR1)
                .HasForeignKey(e => e.IDEMPRESA);

            modelBuilder.Entity<PROVEEDORCONTACTO>()
                .Property(e => e.CONTACTO)
                .IsUnicode(false);

            modelBuilder.Entity<PROVEEDORCONTACTO>()
                .Property(e => e.TELEFONO)
                .IsUnicode(false);

            modelBuilder.Entity<PROVEEDORCONTACTO>()
                .Property(e => e.EXT)
                .IsUnicode(false);

            modelBuilder.Entity<PROVEEDORCONTACTO>()
                .Property(e => e.CELULAR)
                .IsUnicode(false);

            modelBuilder.Entity<PROVEEDORCONTACTO>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<PROVEEDORCONTACTO>()
                .Property(e => e.FAX)
                .IsUnicode(false);

            modelBuilder.Entity<SUCURSAL>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<SUCURSAL>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<SUCURSAL>()
                .Property(e => e.SEGMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<SUCURSAL>()
                .HasMany(e => e.TRASLADOS)
                .WithRequired(e => e.SUCURSAL)
                .HasForeignKey(e => e.IDSUCURSAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SUCURSAL>()
                .HasMany(e => e.TRASLADOS1)
                .WithRequired(e => e.SUCURSAL1)
                .HasForeignKey(e => e.IDSUCURSALDESTINO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SUCURSAL>()
                .HasMany(e => e.NOTASCREDITO)
                .WithRequired(e => e.SUCURSAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SUCURSAL>()
                .HasMany(e => e.NOTASDEVOLUCION)
                .WithRequired(e => e.SUCURSAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SUCURSAL>()
                .HasMany(e => e.CENTROSTRABAJO)
                .WithRequired(e => e.SUCURSAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SUCURSAL>()
                .HasMany(e => e.EDIFICIOS)
                .WithRequired(e => e.SUCURSAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SUCURSAL>()
                .HasMany(e => e.ESCENARIO)
                .WithRequired(e => e.SUCURSAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SUCURSAL>()
                .HasMany(e => e.ETAPAS)
                .WithRequired(e => e.SUCURSAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SUCURSAL>()
                .HasMany(e => e.ETAPASOPERACIONES)
                .WithRequired(e => e.SUCURSAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SUCURSAL>()
                .HasMany(e => e.ETAPASSUBOPERACIONES)
                .WithRequired(e => e.SUCURSAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SUCURSAL>()
                .HasMany(e => e.RUTASOPERACIONESDETALLE)
                .WithRequired(e => e.SUCURSAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SUCURSAL>()
                .HasMany(e => e.FACTURAS)
                .WithRequired(e => e.SUCURSAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SUCURSAL>()
                .HasMany(e => e.PAGOS)
                .WithRequired(e => e.SUCURSAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SUCURSAL>()
                .HasMany(e => e.CLIENTES)
                .WithRequired(e => e.SUCURSAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SUCURSAL>()
                .HasMany(e => e.CLIENTESHISTORIAL)
                .WithRequired(e => e.SUCURSAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SUCURSAL>()
                .HasMany(e => e.AREA)
                .WithRequired(e => e.SUCURSAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SUCURSAL>()
                .HasMany(e => e.AREAS1)
                .WithRequired(e => e.SUCURSAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SUCURSAL>()
                .HasMany(e => e.CLIENTES2)
                .WithRequired(e => e.SUCURSAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SUCURSAL>()
                .HasMany(e => e.CUENTAS1)
                .WithRequired(e => e.SUCURSAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SUCURSAL>()
                .HasMany(e => e.DEPARTAMENTOS)
                .WithRequired(e => e.SUCURSAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SUCURSAL>()
                .HasMany(e => e.PEDIDOS)
                .WithRequired(e => e.SUCURSAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SUCURSAL>()
                .HasMany(e => e.PERFILCREDITO)
                .WithRequired(e => e.SUCURSAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SUCURSAL>()
                .HasMany(e => e.PERFILCREDITOHISTORICO)
                .WithRequired(e => e.SUCURSAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SUCURSAL>()
                .HasMany(e => e.PRECIOVENTALISTA)
                .WithRequired(e => e.SUCURSAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SUCURSAL>()
                .HasMany(e => e.PRECIOVENTALISTACLIENTE)
                .WithRequired(e => e.SUCURSAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SUCURSAL>()
                .HasMany(e => e.PROGRAMA)
                .WithRequired(e => e.SUCURSAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SUCURSAL>()
                .HasMany(e => e.REGISTROVENTA)
                .WithRequired(e => e.SUCURSAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SUCURSAL>()
                .HasMany(e => e.REGISTROVENTAHISTORIAL)
                .WithRequired(e => e.SUCURSAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SUCURSAL>()
                .HasMany(e => e.SERVICIO)
                .WithRequired(e => e.SUCURSAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SUCURSAL>()
                .HasMany(e => e.SERVICIOHISTORIAL)
                .WithRequired(e => e.SUCURSAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SUCURSAL>()
                .HasMany(e => e.ZONAS)
                .WithRequired(e => e.SUCURSAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SUCURSALDATOS>()
                .Property(e => e.CONTACTO)
                .IsUnicode(false);

            modelBuilder.Entity<SUCURSALDATOS>()
                .Property(e => e.TELEFONO)
                .IsUnicode(false);

            modelBuilder.Entity<SUCURSALDATOS>()
                .Property(e => e.EXT)
                .IsUnicode(false);

            modelBuilder.Entity<SUCURSALDATOS>()
                .Property(e => e.CELULAR)
                .IsUnicode(false);

            modelBuilder.Entity<SUCURSALDATOS>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<SUCURSALDATOS>()
                .Property(e => e.FAX)
                .IsUnicode(false);

            modelBuilder.Entity<NOTIFICACION>()
                .Property(e => e.TOKENID)
                .IsUnicode(false);

            modelBuilder.Entity<NOTIFICACION>()
                .Property(e => e.TIPODISPOSITIVO)
                .IsUnicode(false);

            modelBuilder.Entity<NOTIFICACION>()
                .Property(e => e.MACADD)
                .IsUnicode(false);

            modelBuilder.Entity<NOTIFICACION>()
                .Property(e => e.CATEGORIA)
                .IsUnicode(false);

            modelBuilder.Entity<NOTIFICACION>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<CATEGORIA1>()
                .HasMany(e => e.REPORTE)
                .WithRequired(e => e.CATEGORIA1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CATEGORIA1>()
                .HasMany(e => e.HISTORICO)
                .WithRequired(e => e.CATEGORIA1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<REPORTE>()
                .HasMany(e => e.FAVORITO)
                .WithRequired(e => e.REPORTE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<REPORTE>()
                .HasMany(e => e.HISTORICO)
                .WithRequired(e => e.REPORTE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<REPORTE>()
                .HasMany(e => e.REPORTEUSUARIO)
                .WithRequired(e => e.REPORTE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<REPORTE>()
                .HasMany(e => e.ROLREPORTE)
                .WithRequired(e => e.REPORTE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ROL>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<ROL>()
                .HasMany(e => e.ROLREPORTE)
                .WithRequired(e => e.ROL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ROL>()
                .HasMany(e => e.ROLUSUARIO)
                .WithRequired(e => e.ROL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ALMACEN1>()
                .Property(e => e.FOLIO)
                .IsUnicode(false);

            modelBuilder.Entity<ALMACEN1>()
                .Property(e => e.FOLIOPROCESO)
                .IsUnicode(false);

            modelBuilder.Entity<ALMACEN1>()
                .Property(e => e.COMENTARIOS)
                .IsUnicode(false);

            modelBuilder.Entity<ALMACENARCHIVOADJUNTO>()
                .Property(e => e.NOMBREARCHIVO)
                .IsUnicode(false);

            modelBuilder.Entity<ALMACENARCHIVOADJUNTO>()
                .Property(e => e.COMENTARIOS)
                .IsUnicode(false);

            modelBuilder.Entity<ALMACENDETALLE>()
                .Property(e => e.CLASE)
                .IsUnicode(false);

            modelBuilder.Entity<ALMACENDETALLE>()
                .Property(e => e.CANTIDAD)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ALMACENDETALLE>()
                .Property(e => e.COMENTARIO)
                .IsUnicode(false);

            modelBuilder.Entity<ALMACENDETALLE>()
                .Property(e => e.CANTIDADSURTIDA)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ALMACENDETALLE>()
                .Property(e => e.CANTIDADAUTORIZADA)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ALMACENHISTORIAL>()
                .Property(e => e.ACCION)
                .IsUnicode(false);

            modelBuilder.Entity<ALMACENHISTORIAL>()
                .Property(e => e.COMENTARIOS)
                .IsUnicode(false);

            modelBuilder.Entity<COMPRA1>()
                .Property(e => e.FOLIO)
                .IsUnicode(false);

            modelBuilder.Entity<COMPRA1>()
                .Property(e => e.COMENTARIOS)
                .IsUnicode(false);

            modelBuilder.Entity<COMPRAARCHIVOADJUNTO>()
                .Property(e => e.NOMBREARCHIVO)
                .IsUnicode(false);

            modelBuilder.Entity<COMPRAARCHIVOADJUNTO>()
                .Property(e => e.COMENTARIOS)
                .IsUnicode(false);

            modelBuilder.Entity<COMPRAAUTORIZA1>()
                .Property(e => e.CLAVE)
                .IsUnicode(false);

            modelBuilder.Entity<COMPRADETALLE1>()
                .Property(e => e.CANTIDAD)
                .HasPrecision(18, 4);

            modelBuilder.Entity<COMPRADETALLE1>()
                .Property(e => e.COMENTARIOS)
                .IsUnicode(false);

            modelBuilder.Entity<COMPRADETALLE1>()
                .Property(e => e.PRODUCTOPROCESADO)
                .HasPrecision(18, 4);

            modelBuilder.Entity<COMPRADETALLE1>()
                .Property(e => e.PRODUCTOFALTANTE)
                .HasPrecision(18, 4);

            modelBuilder.Entity<COMPRADETALLE1>()
                .HasMany(e => e.COMPRADETALLEPROVEEDOR)
                .WithOptional(e => e.COMPRADETALLE1)
                .HasForeignKey(e => e.IDREQPRODUCTO);

            modelBuilder.Entity<COMPRADETALLE_NR>()
                .Property(e => e.CLAVE)
                .IsUnicode(false);

            modelBuilder.Entity<COMPRADETALLE_NR>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<COMPRADETALLE_NR>()
                .Property(e => e.CANTIDAD)
                .HasPrecision(18, 4);

            modelBuilder.Entity<COMPRADETALLE_NR>()
                .Property(e => e.MOTIVO)
                .IsUnicode(false);

            modelBuilder.Entity<COMPRAFLUJO1>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<COMPRAFLUJO1>()
                .Property(e => e.COLUMNAFIRMA)
                .IsUnicode(false);

            modelBuilder.Entity<COMPRAFLUJO1>()
                .Property(e => e.ACCION)
                .IsUnicode(false);

            modelBuilder.Entity<COMPRAHISTORICO1>()
                .Property(e => e.ACCION)
                .IsUnicode(false);

            modelBuilder.Entity<COMPRAHISTORICO1>()
                .Property(e => e.COMENTARIOS)
                .IsUnicode(false);

            modelBuilder.Entity<INFORMATICA>()
                .Property(e => e.FOLIO)
                .IsUnicode(false);

            modelBuilder.Entity<INFORMATICA>()
                .Property(e => e.COMENTARIOS)
                .IsUnicode(false);

            modelBuilder.Entity<INFORMATICA>()
                .Property(e => e.TITULO)
                .IsUnicode(false);

            modelBuilder.Entity<INFORMATICA>()
                .Property(e => e.KEYVALUE)
                .IsUnicode(false);

            modelBuilder.Entity<INFORMATICA>()
                .HasMany(e => e.HISTORICO)
                .WithRequired(e => e.INFORMATICA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INFORMATICAASIGNACION>()
                .Property(e => e.COMENTARIO)
                .IsUnicode(false);

            modelBuilder.Entity<INFORMATICAASIGNACIONE>()
                .Property(e => e.COMENTARIO)
                .IsUnicode(false);

            modelBuilder.Entity<INFORMATICACATEGORIA>()
                .Property(e => e.CLAVE)
                .IsUnicode(false);

            modelBuilder.Entity<INFORMATICACATEGORIA>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<INFORMATICAESTATUS>()
                .Property(e => e.CLAVE)
                .IsUnicode(false);

            modelBuilder.Entity<INFORMATICAESTATUS>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<INFORMATICAFLUJO>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<INFORMATICAFLUJO>()
                .Property(e => e.COLUMNAFIRMA)
                .IsUnicode(false);

            modelBuilder.Entity<INFORMATICAFLUJO>()
                .Property(e => e.ACCION)
                .IsUnicode(false);

            modelBuilder.Entity<INFORMATICAHISTORICO>()
                .Property(e => e.ACCION)
                .IsUnicode(false);

            modelBuilder.Entity<INFORMATICAHISTORICO>()
                .Property(e => e.COMENTARIOS)
                .IsUnicode(false);

            modelBuilder.Entity<INFORMATICASUBCATEGORIA>()
                .Property(e => e.CLAVE)
                .IsUnicode(false);

            modelBuilder.Entity<INFORMATICASUBCATEGORIA>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<INFORMATICAUSUARIOE>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<INFORMATICAUSUARIOE>()
                .Property(e => e.CONTACTO)
                .IsUnicode(false);

            modelBuilder.Entity<INFORMATICAUSUARIOE>()
                .Property(e => e.TELEFONOS)
                .IsUnicode(false);

            modelBuilder.Entity<RH>()
                .Property(e => e.FOLIO)
                .IsUnicode(false);

            modelBuilder.Entity<RH>()
                .Property(e => e.TIPO)
                .IsUnicode(false);

            modelBuilder.Entity<RH>()
                .Property(e => e.CONDICION)
                .IsUnicode(false);

            modelBuilder.Entity<RH>()
                .Property(e => e.CONCENTIMIENTO)
                .IsUnicode(false);

            modelBuilder.Entity<RH>()
                .Property(e => e.COMENTARIOS)
                .IsUnicode(false);

            modelBuilder.Entity<RHAUTORIZA>()
                .Property(e => e.CLAVE)
                .IsUnicode(false);

            modelBuilder.Entity<RHESTATUS>()
                .Property(e => e.CLAVE)
                .IsUnicode(false);

            modelBuilder.Entity<RHESTATUS>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<RHESTATUS>()
                .HasMany(e => e.RHHISTORICO)
                .WithOptional(e => e.RHESTATUS)
                .HasForeignKey(e => e.IDESTATUSACTUAL);

            modelBuilder.Entity<RHESTATUS>()
                .HasMany(e => e.RHHISTORICO1)
                .WithOptional(e => e.RHESTATUS1)
                .HasForeignKey(e => e.IDESTATUSNUEVO);

            modelBuilder.Entity<RHFLUJO>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<RHFLUJO>()
                .Property(e => e.COLUMNAFIRMA)
                .IsUnicode(false);

            modelBuilder.Entity<RHFLUJO>()
                .Property(e => e.ACCION)
                .IsUnicode(false);

            modelBuilder.Entity<RHHISTORICO>()
                .Property(e => e.ACCION)
                .IsUnicode(false);

            modelBuilder.Entity<RHHISTORICO>()
                .Property(e => e.COMENTARIOS)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICIO>()
                .Property(e => e.PRIORIDAD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SERVICIO>()
                .HasMany(e => e.SERVICIOHISTORIAL)
                .WithRequired(e => e.SERVICIO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SERVICIOCATEGORIA>()
                .HasMany(e => e.SERVICIOSUBCATEGORIA)
                .WithRequired(e => e.SERVICIOCATEGORIA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SERVICIOHISTORIAL>()
                .Property(e => e.PRIORIDAD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CHECADA>()
                .Property(e => e.COMENTARIOS)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLEADO>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLEADO>()
                .Property(e => e.APATERNO)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLEADO>()
                .Property(e => e.AMATERNO)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLEADO>()
                .Property(e => e.NSS)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLEADO>()
                .Property(e => e.PUESTO)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLEADO>()
                .Property(e => e.REGISTROPATRONAL)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLEADO>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLEADO>()
                .Property(e => e.CURP)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLEADO>()
                .HasMany(e => e.ALMACEN1)
                .WithOptional(e => e.EMPLEADO)
                .HasForeignKey(e => e.IDEMPLEADOSOLICITA);

            modelBuilder.Entity<EMPLEADO>()
                .HasMany(e => e.RH)
                .WithOptional(e => e.EMPLEADO)
                .HasForeignKey(e => e.IDEMPLEADOSOLICITA);

            modelBuilder.Entity<EMPLEADO>()
                .HasMany(e => e.CHECADA)
                .WithRequired(e => e.EMPLEADO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPLEADOIMPORTACION>()
                .Property(e => e.NOEMPLEADO)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLEADOIMPORTACION>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLEADOIMPORTACION>()
                .Property(e => e.APATERNO)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLEADOIMPORTACION>()
                .Property(e => e.AMATERNO)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLEADOIMPORTACION>()
                .Property(e => e.EMPRESA)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLEADOIMPORTACION>()
                .Property(e => e.EMPRESA_ERP)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLEADOIMPORTACION>()
                .Property(e => e.SUCURSAL)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLEADOIMPORTACION>()
                .Property(e => e.SUCURSAL_ERP)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLEADOIMPORTACION>()
                .Property(e => e.DEPARTAMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLEADOIMPORTACION>()
                .Property(e => e.DEPARTAMENTO_ERP)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLEADOIMPORTACION>()
                .Property(e => e.MSG)
                .IsUnicode(false);

            modelBuilder.Entity<INCIDENCIA>()
                .Property(e => e.CLAVE)
                .IsUnicode(false);

            modelBuilder.Entity<INCIDENCIA>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<PERIODONOMINA>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<PERIODONOMINA>()
                .HasMany(e => e.CHECADA)
                .WithRequired(e => e.PERIODONOMINA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPOVALE>()
                .Property(e => e.CLAVE)
                .IsUnicode(false);

            modelBuilder.Entity<TIPOVALE>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<TIPOVALE>()
                .Property(e => e.FORMATO)
                .IsUnicode(false);

            modelBuilder.Entity<FIRMADIGITAL>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<FIRMADIGITAL>()
                .HasMany(e => e.ENVIO)
                .WithOptional(e => e.FIRMADIGITAL)
                .HasForeignKey(e => e.IDFIRMACONDUCTOR);

            modelBuilder.Entity<FIRMADIGITAL>()
                .HasMany(e => e.ENVIO1)
                .WithOptional(e => e.FIRMADIGITAL1)
                .HasForeignKey(e => e.IDFIRMAENTREGA);

            modelBuilder.Entity<FIRMADIGITAL>()
                .HasMany(e => e.ENVIO2)
                .WithOptional(e => e.FIRMADIGITAL2)
                .HasForeignKey(e => e.IDFIRMARECIBE);

            modelBuilder.Entity<FIRMADIGITAL>()
                .HasMany(e => e.COMPRA1)
                .WithOptional(e => e.FIRMADIGITAL)
                .HasForeignKey(e => e.IDFIRMAAUTORIZO);

            modelBuilder.Entity<FIRMADIGITAL>()
                .HasMany(e => e.COMPRA11)
                .WithOptional(e => e.FIRMADIGITAL1)
                .HasForeignKey(e => e.IDFIRMAREALIZO);

            modelBuilder.Entity<FIRMADIGITAL>()
                .HasMany(e => e.COMPRA12)
                .WithOptional(e => e.FIRMADIGITAL2)
                .HasForeignKey(e => e.IDFIRMARECIBE);

            modelBuilder.Entity<LINK>()
                .Property(e => e.CLAVE)
                .IsUnicode(false);

            modelBuilder.Entity<LINK>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<LINK>()
                .Property(e => e.NOMBREUS)
                .IsUnicode(false);

            modelBuilder.Entity<LINK>()
                .Property(e => e.PATH)
                .IsUnicode(false);

            modelBuilder.Entity<MENU>()
                .Property(e => e.CLAVE)
                .IsUnicode(false);

            modelBuilder.Entity<MENU>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<MENU>()
                .Property(e => e.NOMBREUS)
                .IsUnicode(false);

            modelBuilder.Entity<MENU>()
                .Property(e => e.IMAGE)
                .IsUnicode(false);

            modelBuilder.Entity<MODULO>()
                .Property(e => e.CLAVE)
                .IsUnicode(false);

            modelBuilder.Entity<MODULO>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<MODULO>()
                .Property(e => e.NOMBREUS)
                .IsUnicode(false);

            modelBuilder.Entity<PASSWORDEMAIL>()
                .Property(e => e.PASSWORD)
                .IsUnicode(false);

            modelBuilder.Entity<ROL1>()
                .Property(e => e.CLAVE)
                .IsUnicode(false);

            modelBuilder.Entity<ROL1>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIO>()
                .Property(e => e.USUARIO1)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIO>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIO>()
                .Property(e => e.APELLIDO)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIO>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.ENVIO)
            //    .WithOptional(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.ENVIO1)
            //    .WithOptional(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUSUARIOASOLICITARREQ);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.ENVIO2)
            //    .WithOptional(e => e.USUARIO2)
            //    .HasForeignKey(e => e.IDUSUARIOAUTORIZAREQ);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.ENVIO3)
            //    .WithOptional(e => e.USUARIO3)
            //    .HasForeignKey(e => e.IDUSUARIOCONDUCTOR);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.ENVIO4)
            //    .WithOptional(e => e.USUARIO4)
            //    .HasForeignKey(e => e.IDUSUARIOENTREGA);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.ENVIO5)
            //    .WithOptional(e => e.USUARIO5)
            //    .HasForeignKey(e => e.IDUSUARIORECIBE);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.ENVIODETALLE)
            //    .WithOptional(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZA);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.ENVIOREGISTROVENTA)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIOACUTUALIZO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.ESTATUSENVIO)
            //    .WithOptional(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.EXISTENCIADETALLE)
            //    .WithOptional(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.PRODUCTO)
            //    .WithOptional(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIO);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.PRODUCTO1)
            //    .WithOptional(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.TRASLADOS)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.TRASLADOS1)
            //    .WithRequired(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.ARCHIVOADJUNTO)
            //    .WithOptional(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.BANCO)
            //    .WithOptional(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.COMPANIATRANSPORTISTA)
            //    .WithOptional(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.COMUNICACION)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.COMUNICACION1)
            //    .WithOptional(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.CONTACTOS)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.CONTACTOS1)
            //    .WithRequired(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.DEVOLUCIONCATEGORIA)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.DEVOLUCIONCATEGORIA1)
            //    .WithRequired(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.DEVOLUCIONSUBCATEGORIA)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.DEVOLUCIONSUBCATEGORIA1)
            //    .WithRequired(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.ETAPAFABRICACION)
            //    .WithOptional(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.FORMAFARMACEUTICA)
            //    .WithOptional(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.FORMULAMAESTRADETALLE)
            //    .WithOptional(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.FORMULAMAESTRATAMANO)
            //    .WithOptional(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.IMPUESTOS)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.IMPUESTOS1)
            //    .WithRequired(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.MONEDAS)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.MONEDAS1)
            //    .WithRequired(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUSUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.PRODUCTOACONDICIONAMIENTOETAPA)
            //    .WithOptional(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.PRODUCTOFABRICACIONETAPA)
            //    .WithOptional(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.PRODUCTOVENTAEMPLEADO)
            //    .WithOptional(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.SITUACION)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.SITUACION1)
            //    .WithRequired(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.UNIDADMEDIDA)
            //    .WithOptional(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.USOCFDI)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.USOCFDI1)
            //    .WithRequired(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.COMPRA)
            //    .WithOptional(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.COMPRA1)
            //    .WithOptional(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUSUARIOAUTORIZA);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.COMPRA2)
            //    .WithOptional(e => e.USUARIO2)
            //    .HasForeignKey(e => e.IDUSUARIOPREAUTORIZA);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.COMPRA3)
            //    .WithOptional(e => e.USUARIO3)
            //    .HasForeignKey(e => e.IDUSUARIOREALIZO);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.COMPRA4)
            //    .WithOptional(e => e.USUARIO4)
            //    .HasForeignKey(e => e.IDUSUARIOSOLICITA);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.COMPRAAUTORIZA)
            //    .WithOptional(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIOAUTORIZA);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.CUENTASCORREO)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.CUENTASCORREO1)
            //    .WithRequired(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.FLUJOS)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.FLUJOS1)
            //    .WithRequired(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.TIPODOCUMENTO1)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.TIPODOCUMENTO11)
            //    .WithRequired(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.ACTIVOSFIJOS)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUsuario)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.ACTIVOSFIJOS1)
            //    .WithRequired(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUsuarioActualizo)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.ACTIVOSFIJOS2)
            //    .WithOptional(e => e.USUARIO2)
            //    .HasForeignKey(e => e.IDUsuarioFinal);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.ACTIVOSFIJOS3)
            //    .WithOptional(e => e.USUARIO3)
            //    .HasForeignKey(e => e.IDUsuarioResguardo);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.ACTIVOSFIJOSCATEGORIAS)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUsuario)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.ACTIVOSFIJOSCATEGORIAS1)
            //    .WithRequired(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUsuarioActualizo)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.ACTIVOSFIJOSSUBCATEGORIAS)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUsuario)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.ACTIVOSFIJOSSUBCATEGORIAS1)
            //    .WithRequired(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUsuarioActualizo)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.CUENTASCLIENTES)
            //    .WithRequired(e => e.USUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.CUENTASCOSTOS)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.CUENTASCOSTOS1)
            //    .WithRequired(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.NOTASCREDITOCFDI)
            //    .WithRequired(e => e.USUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.NOTASDEVOLUCION)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.NOTASDEVOLUCION1)
            //    .WithRequired(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.NOTASDEVOLUCIONCFDI)
            //    .WithRequired(e => e.USUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.NOTASDEVOLUCIONDETALLE)
            //    .WithRequired(e => e.USUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.ORDENCOSTEOSUBTIPO)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUsuario)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.ORDENCOSTEOSUBTIPO1)
            //    .WithRequired(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUsuarioActualizo)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.ORDENCOSTEOTIPO)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUsuario)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.ORDENCOSTEOTIPO1)
            //    .WithRequired(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUsuarioActualizo)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.PAGO)
            //    .WithOptional(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.CENTROSTRABAJO)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUsuario)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.CENTROSTRABAJO1)
            //    .WithRequired(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUsuarioActualizo)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.CENTROSTRABAJOTIPOS)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUsuario)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.CENTROSTRABAJOTIPOS1)
            //    .WithRequired(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUsuarioActualizo)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.EDIFICIOS)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUsuario)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.EDIFICIOS1)
            //    .WithRequired(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUsuarioActualizo)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.ESCENARIO)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.ESCENARIO1)
            //    .WithRequired(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.ETAPAS)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.ETAPAS1)
            //    .WithRequired(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.ETAPASOPERACIONES)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.ETAPASOPERACIONES1)
            //    .WithRequired(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.ETAPASSUBOPERACIONES)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.ETAPASSUBOPERACIONES1)
            //    .WithRequired(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.OPERACIONES)
            //    .WithOptional(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUsuario);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.OPERACIONES1)
            //    .WithOptional(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUsuarioActualizo);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.ORDENACONDICIONAMIENTOHISTORIAL)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.PRODUCTOSECTOR)
            //    .WithOptional(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIO);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.PRODUCTOSECTOR1)
            //    .WithOptional(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.RUTASOPERACIONESDETALLE)
            //    .WithOptional(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUsuario);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.RUTASOPERACIONESDETALLE1)
            //    .WithOptional(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUsuarioActualizo);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.ABONOS)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.ABONOS1)
            //    .WithOptional(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.ABONOSHISTORIAL)
            //    .WithRequired(e => e.USUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.CANCELACIONCDFI)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.CANCELACIONCDFI1)
            //    .WithRequired(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.CONFIGURACIONSELLOS)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.CONFIGURACIONSELLOS1)
            //    .WithRequired(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.FACTURALICITACION)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.FACTURALICITACION1)
            //    .WithRequired(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.FACTURAS)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.FACTURAS1)
            //    .WithRequired(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.FACTURASCFDI)
            //    .WithRequired(e => e.USUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.FACTURASDETALLE)
            //    .WithRequired(e => e.USUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.PAGOS)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.PAGOS1)
            //    .WithRequired(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.PAGOSCFDI)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.PAGOSCFDI1)
            //    .WithRequired(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUSUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.TIPOFACTURA)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.TIPOFACTURA1)
            //    .WithRequired(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.TIPOPAGO)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.TIPOPAGO1)
            //    .WithRequired(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.USUARIOAUTORIZA)
            //    .WithOptional(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIOAUTORIZA);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.CLIENTES)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.CLIENTES1)
            //    .WithRequired(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.CLIENTESHISTORIAL)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.CLIENTESHISTORIAL1)
            //    .WithRequired(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.PRODUCTO11)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.PRODUCTO12)
            //    .WithRequired(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUSUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.TIPORELACIONCFDI)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.TIPORELACIONCFDI1)
            //    .WithRequired(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.CONFIGURACIONPRODUCTOENVIO)
            //    .WithOptional(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.AREA)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.AREA1)
            //    .WithRequired(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.AREAS1)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.AREAS11)
            //    .WithRequired(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.CLASEPROVEEDOR)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.CLASEPROVEEDOR1)
            //    .WithRequired(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.CLIENTELICITACION)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.CLIENTELICITACION1)
            //    .WithRequired(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.CLIENTES2)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.CLIENTES21)
            //    .WithOptional(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.CLIENTESFACULTADOS)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.CLIENTESFACULTADOS1)
            //    .WithRequired(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.CUENTAS1)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.CUENTAS11)
            //    .WithOptional(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.DEPARTAMENTOS)
            //    .WithOptional(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIO);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.DEPARTAMENTOS1)
            //    .WithRequired(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.SUCURSAL)
            //    .WithOptional(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.SUCURSALESLARISSA)
            //    .WithOptional(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.NOTIFICACION)
            //    .WithOptional(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIO);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.NOTIFICACION1)
            //    .WithOptional(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.CATEGORIA1)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.FAVORITO)
            //    .WithRequired(e => e.USUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.HISTORICO)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.HISTORICO1)
            //    .WithRequired(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUSUARIOREALIZO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.REPORTE)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.REPORTE1)
            //    .WithRequired(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUSUARIOREALIZO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.REPORTEUSUARIO)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.ROL)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.ROLREPORTE)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.ROLUSUARIO)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.SUBCATEGORIA1)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.ALMACENARCHIVOADJUNTO)
            //    .WithOptional(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.COMPRA11)
            //    .WithOptional(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.COMPRA12)
            //    .WithOptional(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUSUARIOAUTORIZA);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.COMPRA13)
            //    .WithOptional(e => e.USUARIO2)
            //    .HasForeignKey(e => e.IDUSUARIOREALIZO);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.COMPRA14)
            //    .WithOptional(e => e.USUARIO3)
            //    .HasForeignKey(e => e.IDUSUARIORECIBE);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.COMPRAAUTORIZA1)
            //    .WithOptional(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIOAUTORIZA);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.SERVICIO)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.SERVICIO1)
            //    .WithRequired(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.SERVICIO2)
            //    .WithRequired(e => e.USUARIO2)
            //    .HasForeignKey(e => e.IDUSUARIOFINAL)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.SERVICIO3)
            //    .WithOptional(e => e.USUARIO3)
            //    .HasForeignKey(e => e.IDUSUARIORECIBE);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.SERVICIO4)
            //    .WithOptional(e => e.USUARIO4)
            //    .HasForeignKey(e => e.IDUSUARIOSOPORTE);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.SERVICIOCATEGORIA)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.SERVICIOCATEGORIA1)
            //    .WithOptional(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.SERVICIOGRUPO)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.SERVICIOGRUPO1)
            //    .WithRequired(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.SERVICIOHISTORIAL)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.SERVICIOHISTORIAL1)
            //    .WithOptional(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUSUARIOFINAL);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.SERVICIOHISTORIAL2)
            //    .WithOptional(e => e.USUARIO2)
            //    .HasForeignKey(e => e.IDUSUARIORECIBE);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.SERVICIOHISTORIAL3)
            //    .WithOptional(e => e.USUARIO3)
            //    .HasForeignKey(e => e.IDUSUARIOSOPORTE);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.SERVICIOSUBCATEGORIA)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.SERVICIOSUBCATEGORIA1)
            //    .WithRequired(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.SERVICIOTIPO)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.SERVICIOTIPO1)
            //    .WithRequired(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.CHECADA)
            //    .WithOptional(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.INCIDENCIA)
            //    .WithOptional(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.PERIODONOMINA)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.USUARIOCHECAEMPLEADO)
            //    .WithOptional(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIO);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.USUARIOCHECAEMPLEADO1)
            //    .WithOptional(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.IMPORTACION)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.IMPORTACION1)
            //    .WithRequired(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.PEDIDOS)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.PEDIDOS1)
            //    .WithRequired(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.PERFILCREDITO)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.PERFILCREDITO1)
            //    .WithRequired(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.PERFILCREDITOHISTORICO)
            //    .WithRequired(e => e.USUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.PRECIOVENTA)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.PRECIOVENTA1)
            //    .WithRequired(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.PRECIOVENTALISTA)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.PRECIOVENTALISTA1)
            //    .WithRequired(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.PRECIOVENTALISTACLIENTE)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.PRECIOVENTALISTACLIENTE1)
            //    .WithRequired(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.PROGRAMA)
            //    .WithOptional(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.REGISTROVENTA)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.REGISTROVENTA1)
            //    .WithRequired(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.REGISTROVENTADETALLE)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.REGISTROVENTADETALLE1)
            //    .WithRequired(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.REGISTROVENTAHISTORIAL)
            //    .WithRequired(e => e.USUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.TARJETASPODER)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.TARJETASPODER1)
            //    .WithRequired(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.TARJETASPODERDETALLE)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUSUARIO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.TARJETASPODERDETALLE1)
            //    .WithRequired(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUSUARIOACTUALIZO)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.ZONAS)
            //    .WithRequired(e => e.USUARIO)
            //    .HasForeignKey(e => e.IDUsuario)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USUARIO>()
            //    .HasMany(e => e.ZONAS1)
            //    .WithRequired(e => e.USUARIO1)
            //    .HasForeignKey(e => e.IDUsuarioActualizo)
            //    .WillCascadeOnDelete(false);

            modelBuilder.Entity<USUARIOESTATUS>()
                .Property(e => e.CLAVE)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIOESTATUS>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<IMPORTACION>()
                .Property(e => e.TIPO)
                .IsFixedLength();

            modelBuilder.Entity<AGENTES>()
                .Property(e => e.CUOTAVENTA)
                .HasPrecision(12, 2);

            modelBuilder.Entity<AGENTES>()
                .Property(e => e.MONTOBONO)
                .HasPrecision(12, 2);

            modelBuilder.Entity<AGENTES>()
                .Property(e => e.COMISION)
                .HasPrecision(5, 2);

            modelBuilder.Entity<AGENTES>()
                .Property(e => e.VENTASYTD)
                .HasPrecision(12, 2);

            modelBuilder.Entity<AGENTES>()
                .Property(e => e.VENTASULTIMOANIO)
                .HasPrecision(12, 2);

            modelBuilder.Entity<AGENTES>()
                .HasMany(e => e.FACTURAS)
                .WithRequired(e => e.AGENTES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AGENTES>()
                .HasMany(e => e.CLIENTES2)
                .WithRequired(e => e.AGENTES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AGENTES>()
                .HasMany(e => e.PEDIDOS)
                .WithRequired(e => e.AGENTES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AGENTES>()
                .HasMany(e => e.REGISTROVENTA)
                .WithRequired(e => e.AGENTES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AGENTES>()
                .HasMany(e => e.REGISTROVENTAHISTORIAL)
                .WithRequired(e => e.AGENTES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PEDIDOS>()
                .HasMany(e => e.REGISTROVENTA)
                .WithRequired(e => e.PEDIDOS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PEDIDOS>()
                .HasMany(e => e.REGISTROVENTAHISTORIAL)
                .WithRequired(e => e.PEDIDOS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PEDIDOSDETALLE>()
                .Property(e => e.CANTIDAD)
                .HasPrecision(18, 4);

            modelBuilder.Entity<PERFILCREDITO>()
                .HasMany(e => e.PERFILCREDITOHISTORICO)
                .WithRequired(e => e.PERFILCREDITO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRECIOVENTA>()
                .Property(e => e.PRECIO)
                .HasPrecision(10, 2);

            modelBuilder.Entity<PRECIOVENTA>()
                .HasMany(e => e.PEDIDOSDETALLE)
                .WithRequired(e => e.PRECIOVENTA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRECIOVENTA>()
                .HasMany(e => e.REGISTROVENTADETALLE)
                .WithRequired(e => e.PRECIOVENTA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRECIOVENTALISTA>()
                .HasMany(e => e.PRECIOVENTA)
                .WithRequired(e => e.PRECIOVENTALISTA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRECIOVENTALISTA>()
                .HasMany(e => e.PRECIOVENTALISTACLIENTE)
                .WithRequired(e => e.PRECIOVENTALISTA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<REGISTROVENTA>()
                .Property(e => e.SUBTOTAL)
                .HasPrecision(12, 2);

            modelBuilder.Entity<REGISTROVENTA>()
                .Property(e => e.DESCUENTO)
                .HasPrecision(12, 2);

            modelBuilder.Entity<REGISTROVENTA>()
                .Property(e => e.IMPUESTOSTRASLADO)
                .HasPrecision(12, 2);

            modelBuilder.Entity<REGISTROVENTA>()
                .Property(e => e.TOTAL)
                .HasPrecision(12, 2);

            modelBuilder.Entity<REGISTROVENTA>()
                .HasMany(e => e.REGISTROVENTADETALLE)
                .WithRequired(e => e.REGISTROVENTA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<REGISTROVENTA>()
                .HasMany(e => e.REGISTROVENTAHISTORIAL)
                .WithRequired(e => e.REGISTROVENTA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<REGISTROVENTADETALLE>()
                .Property(e => e.CANTIDADPEDIDO)
                .HasPrecision(12, 4);

            modelBuilder.Entity<REGISTROVENTADETALLE>()
                .Property(e => e.CANTIDADSURTIDA)
                .HasPrecision(12, 4);

            modelBuilder.Entity<TARJETASPODER>()
                .HasMany(e => e.TARJETASPODERDETALLE)
                .WithRequired(e => e.TARJETASPODER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EXISTENCIAACTUAL>()
                .Property(e => e.NOLOTE)
                .IsUnicode(false);

            modelBuilder.Entity<EXISTENCIAACTUAL>()
                .Property(e => e.TOTAL)
                .HasPrecision(18, 4);

            modelBuilder.Entity<PERMISOSPROCESO>()
                .Property(e => e.PROCESO)
                .IsUnicode(false);

            modelBuilder.Entity<PERMISOSPROCESO>()
                .Property(e => e.PERMISO)
                .IsUnicode(false);

            modelBuilder.Entity<REGISTRO_ACCIONES>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<REGISTRO_ACCIONES>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<HOJACOSTOSPRODUCCION>()
                .Property(e => e.TAMANOLOTE)
                .HasPrecision(18, 4);

            modelBuilder.Entity<HOJACOSTOSPRODUCCION>()
                .Property(e => e.KGACTIVO)
                .HasPrecision(18, 4);

            modelBuilder.Entity<HOJACOSTOSPRODUCCION>()
                .Property(e => e.GRANULADOS1)
                .HasPrecision(18, 4);

            modelBuilder.Entity<HOJACOSTOSPRODUCCION>()
                .Property(e => e.SECADO2)
                .HasPrecision(18, 4);

            modelBuilder.Entity<HOJACOSTOSPRODUCCION>()
                .Property(e => e.GRANULADOS2)
                .HasPrecision(18, 4);

            modelBuilder.Entity<HOJACOSTOSPRODUCCION>()
                .Property(e => e.MEZCLADO1)
                .HasPrecision(18, 4);

            modelBuilder.Entity<HOJACOSTOSPRODUCCION>()
                .Property(e => e.MEZCLADO2)
                .HasPrecision(18, 4);

            modelBuilder.Entity<HOJACOSTOSPRODUCCION>()
                .Property(e => e.TABLETEADO1)
                .HasPrecision(18, 4);

            modelBuilder.Entity<HOJACOSTOSPRODUCCION>()
                .Property(e => e.TABLETEADO2)
                .HasPrecision(18, 4);

            modelBuilder.Entity<HOJACOSTOSPRODUCCION>()
                .Property(e => e.TABLETEADO3)
                .HasPrecision(18, 4);

            modelBuilder.Entity<HOJACOSTOSPRODUCCION>()
                .Property(e => e.TABLETEADO4)
                .HasPrecision(18, 4);

            modelBuilder.Entity<HOJACOSTOSPRODUCCION>()
                .Property(e => e.TABLETEADO5)
                .HasPrecision(18, 4);

            modelBuilder.Entity<HOJACOSTOSPRODUCCION>()
                .Property(e => e.TABLETEADO6)
                .HasPrecision(18, 4);

            modelBuilder.Entity<HOJACOSTOSPRODUCCION>()
                .Property(e => e.ENCAPSULADO2)
                .HasPrecision(18, 4);

            modelBuilder.Entity<HOJACOSTOSPRODUCCION>()
                .Property(e => e.ABRILLANTADO)
                .HasPrecision(18, 4);

            modelBuilder.Entity<HOJACOSTOSPRODUCCION>()
                .Property(e => e.RECUBRIMIENTO1)
                .HasPrecision(18, 4);

            modelBuilder.Entity<HOJACOSTOSPRODUCCION>()
                .Property(e => e.RECUBRIMIENTO2)
                .HasPrecision(18, 4);

            modelBuilder.Entity<HOJACOSTOSPRODUCCION>()
                .Property(e => e.MEZCLADOBETA)
                .HasPrecision(18, 4);

            modelBuilder.Entity<HOJACOSTOSPRODUCCION>()
                .Property(e => e.ENCAPSULADOBETA)
                .HasPrecision(18, 4);

            modelBuilder.Entity<HOJACOSTOSPRODUCCION>()
                .Property(e => e.ABRILLANTADOBETA)
                .HasPrecision(18, 4);

            modelBuilder.Entity<PLANMAESTROPRODUCCION>()
                .Property(e => e.COMENTARIOS)
                .IsUnicode(false);

            modelBuilder.Entity<ALMACEN_ZTEST>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<CATALOGO_TEST>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<DOCUMENTO>()
                .Property(e => e.TITULO)
                .IsUnicode(false);

            modelBuilder.Entity<DOCUMENTO>()
                .Property(e => e.ENLACE)
                .IsUnicode(false);

            modelBuilder.Entity<PROGRAMA>()
                .Property(e => e.TIPO)
                .IsUnicode(false);

            modelBuilder.Entity<PROGRAMA>()
                .Property(e => e.TAMANOFABRICAR)
                .HasPrecision(18, 4);

            modelBuilder.Entity<LOGSINVENTARIO>()
                .Property(e => e.CODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<LOGSINVENTARIO>()
                .Property(e => e.MENSAJE)
                .IsUnicode(false);

            modelBuilder.Entity<LOGS>()
                .Property(e => e.CODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<LOGS>()
                .Property(e => e.MENSAJE)
                .IsUnicode(false);

            modelBuilder.Entity<ALMACENEXISTENCIA>()
                .Property(e => e.Existencia)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Pagos1>()
                .Property(e => e.idLarissa)
                .IsUnicode(false);

            modelBuilder.Entity<PROVEEDORPRODUCTO>()
                .Property(e => e.CLAVE)
                .IsUnicode(false);

            modelBuilder.Entity<PROVEEDORPRODUCTO>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<PROVEEDORPRODUCTO>()
                .Property(e => e.NOMBREUS)
                .IsUnicode(false);

            modelBuilder.Entity<PROVEEDORPRODUCTO>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<PROVEEDORPRODUCTO>()
                .Property(e => e.COMENTARIOS)
                .IsUnicode(false);

            modelBuilder.Entity<PROVEEDORPRODUCTO>()
                .Property(e => e.COSTOMXN)
                .HasPrecision(18, 6);

            modelBuilder.Entity<PROVEEDORPRODUCTO>()
                .Property(e => e.COSTOUSD)
                .HasPrecision(18, 6);

            modelBuilder.Entity<USUARIOSAPP>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIOSAPP>()
                .Property(e => e.APELLIDO)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIOSAPP>()
                .Property(e => e.PASSWORD)
                .IsUnicode(false);
        }
    }
}
