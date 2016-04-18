﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.573
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

namespace mz.erp.commontypes.data {
    using System;
    using System.Data;
    using System.Xml;
    using System.Runtime.Serialization;
    
    
    [Serializable()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.ToolboxItem(true)]
    public class tsa_SeguimientoPedidosDataset : DataSet {
        
        private tsa_SeguimientoPedidosDataTable tabletsa_SeguimientoPedidos;
        
        public tsa_SeguimientoPedidosDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected tsa_SeguimientoPedidosDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["tsa_SeguimientoPedidos"] != null)) {
                    this.Tables.Add(new tsa_SeguimientoPedidosDataTable(ds.Tables["tsa_SeguimientoPedidos"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.InitClass();
            }
            this.GetSerializationData(info, context);
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public tsa_SeguimientoPedidosDataTable tsa_SeguimientoPedidos {
            get {
                return this.tabletsa_SeguimientoPedidos;
            }
        }
        
        public override DataSet Clone() {
            tsa_SeguimientoPedidosDataset cln = ((tsa_SeguimientoPedidosDataset)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override bool ShouldSerializeTables() {
            return false;
        }
        
        protected override bool ShouldSerializeRelations() {
            return false;
        }
        
        protected override void ReadXmlSerializable(XmlReader reader) {
            this.Reset();
            DataSet ds = new DataSet();
            ds.ReadXml(reader);
            if ((ds.Tables["tsa_SeguimientoPedidos"] != null)) {
                this.Tables.Add(new tsa_SeguimientoPedidosDataTable(ds.Tables["tsa_SeguimientoPedidos"]));
            }
            this.DataSetName = ds.DataSetName;
            this.Prefix = ds.Prefix;
            this.Namespace = ds.Namespace;
            this.Locale = ds.Locale;
            this.CaseSensitive = ds.CaseSensitive;
            this.EnforceConstraints = ds.EnforceConstraints;
            this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
            this.InitVars();
        }
        
        protected override System.Xml.Schema.XmlSchema GetSchemaSerializable() {
            System.IO.MemoryStream stream = new System.IO.MemoryStream();
            this.WriteXmlSchema(new XmlTextWriter(stream, null));
            stream.Position = 0;
            return System.Xml.Schema.XmlSchema.Read(new XmlTextReader(stream), null);
        }
        
        internal void InitVars() {
            this.tabletsa_SeguimientoPedidos = ((tsa_SeguimientoPedidosDataTable)(this.Tables["tsa_SeguimientoPedidos"]));
            if ((this.tabletsa_SeguimientoPedidos != null)) {
                this.tabletsa_SeguimientoPedidos.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "tsa_SeguimientoPedidosDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/tsa_SeguimientoPedidos.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tabletsa_SeguimientoPedidos = new tsa_SeguimientoPedidosDataTable();
            this.Tables.Add(this.tabletsa_SeguimientoPedidos);
        }
        
        private bool ShouldSerializetsa_SeguimientoPedidos() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void tsa_SeguimientoPedidosRowChangeEventHandler(object sender, tsa_SeguimientoPedidosRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsa_SeguimientoPedidosDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdPedido;
            
            private DataColumn columnIdProducto;
            
            private DataColumn columnRenglon;
            
            private DataColumn columnFecha;
            
            private DataColumn columnDescripcion;
            
            private DataColumn columnIdResponsable;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnIdReservado;
            
            private DataColumn columnRowId;
            
            private DataColumn columnIdSucursal;
            
            private DataColumn columnIdEmpresa;
            
            internal tsa_SeguimientoPedidosDataTable() : 
                    base("tsa_SeguimientoPedidos") {
                this.InitClass();
            }
            
            internal tsa_SeguimientoPedidosDataTable(DataTable table) : 
                    base(table.TableName) {
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
                this.DisplayExpression = table.DisplayExpression;
            }
            
            [System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            internal DataColumn IdPedidoColumn {
                get {
                    return this.columnIdPedido;
                }
            }
            
            internal DataColumn IdProductoColumn {
                get {
                    return this.columnIdProducto;
                }
            }
            
            internal DataColumn RenglonColumn {
                get {
                    return this.columnRenglon;
                }
            }
            
            internal DataColumn FechaColumn {
                get {
                    return this.columnFecha;
                }
            }
            
            internal DataColumn DescripcionColumn {
                get {
                    return this.columnDescripcion;
                }
            }
            
            internal DataColumn IdResponsableColumn {
                get {
                    return this.columnIdResponsable;
                }
            }
            
            internal DataColumn FechaCreacionColumn {
                get {
                    return this.columnFechaCreacion;
                }
            }
            
            internal DataColumn IdConexionCreacionColumn {
                get {
                    return this.columnIdConexionCreacion;
                }
            }
            
            internal DataColumn UltimaModificacionColumn {
                get {
                    return this.columnUltimaModificacion;
                }
            }
            
            internal DataColumn IdConexionUltimaModificacionColumn {
                get {
                    return this.columnIdConexionUltimaModificacion;
                }
            }
            
            internal DataColumn IdReservadoColumn {
                get {
                    return this.columnIdReservado;
                }
            }
            
            internal DataColumn RowIdColumn {
                get {
                    return this.columnRowId;
                }
            }
            
            internal DataColumn IdSucursalColumn {
                get {
                    return this.columnIdSucursal;
                }
            }
            
            internal DataColumn IdEmpresaColumn {
                get {
                    return this.columnIdEmpresa;
                }
            }
            
            public tsa_SeguimientoPedidosRow this[int index] {
                get {
                    return ((tsa_SeguimientoPedidosRow)(this.Rows[index]));
                }
            }
            
            public event tsa_SeguimientoPedidosRowChangeEventHandler tsa_SeguimientoPedidosRowChanged;
            
            public event tsa_SeguimientoPedidosRowChangeEventHandler tsa_SeguimientoPedidosRowChanging;
            
            public event tsa_SeguimientoPedidosRowChangeEventHandler tsa_SeguimientoPedidosRowDeleted;
            
            public event tsa_SeguimientoPedidosRowChangeEventHandler tsa_SeguimientoPedidosRowDeleting;
            
            public void Addtsa_SeguimientoPedidosRow(tsa_SeguimientoPedidosRow row) {
                this.Rows.Add(row);
            }
            
            public tsa_SeguimientoPedidosRow Addtsa_SeguimientoPedidosRow(long IdPedido, string IdProducto, short Renglon, System.DateTime Fecha, string Descripcion, string IdResponsable, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, System.Guid RowId, long IdSucursal, long IdEmpresa) {
                tsa_SeguimientoPedidosRow rowtsa_SeguimientoPedidosRow = ((tsa_SeguimientoPedidosRow)(this.NewRow()));
                rowtsa_SeguimientoPedidosRow.ItemArray = new object[] {
                        IdPedido,
                        IdProducto,
                        Renglon,
                        Fecha,
                        Descripcion,
                        IdResponsable,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        IdReservado,
                        RowId,
                        IdSucursal,
                        IdEmpresa};
                this.Rows.Add(rowtsa_SeguimientoPedidosRow);
                return rowtsa_SeguimientoPedidosRow;
            }
            
            public tsa_SeguimientoPedidosRow FindByIdPedidoIdProductoRenglonFecha(long IdPedido, string IdProducto, short Renglon, System.DateTime Fecha) {
                return ((tsa_SeguimientoPedidosRow)(this.Rows.Find(new object[] {
                            IdPedido,
                            IdProducto,
                            Renglon,
                            Fecha})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                tsa_SeguimientoPedidosDataTable cln = ((tsa_SeguimientoPedidosDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new tsa_SeguimientoPedidosDataTable();
            }
            
            internal void InitVars() {
                this.columnIdPedido = this.Columns["IdPedido"];
                this.columnIdProducto = this.Columns["IdProducto"];
                this.columnRenglon = this.Columns["Renglon"];
                this.columnFecha = this.Columns["Fecha"];
                this.columnDescripcion = this.Columns["Descripcion"];
                this.columnIdResponsable = this.Columns["IdResponsable"];
                this.columnFechaCreacion = this.Columns["FechaCreacion"];
                this.columnIdConexionCreacion = this.Columns["IdConexionCreacion"];
                this.columnUltimaModificacion = this.Columns["UltimaModificacion"];
                this.columnIdConexionUltimaModificacion = this.Columns["IdConexionUltimaModificacion"];
                this.columnIdReservado = this.Columns["IdReservado"];
                this.columnRowId = this.Columns["RowId"];
                this.columnIdSucursal = this.Columns["IdSucursal"];
                this.columnIdEmpresa = this.Columns["IdEmpresa"];
            }
            
            private void InitClass() {
                this.columnIdPedido = new DataColumn("IdPedido", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdPedido);
                this.columnIdProducto = new DataColumn("IdProducto", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdProducto);
                this.columnRenglon = new DataColumn("Renglon", typeof(short), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnRenglon);
                this.columnFecha = new DataColumn("Fecha", typeof(System.DateTime), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnFecha);
                this.columnDescripcion = new DataColumn("Descripcion", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnDescripcion);
                this.columnIdResponsable = new DataColumn("IdResponsable", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdResponsable);
                this.columnFechaCreacion = new DataColumn("FechaCreacion", typeof(System.DateTime), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnFechaCreacion);
                this.columnIdConexionCreacion = new DataColumn("IdConexionCreacion", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdConexionCreacion);
                this.columnUltimaModificacion = new DataColumn("UltimaModificacion", typeof(System.Byte[]), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnUltimaModificacion);
                this.columnIdConexionUltimaModificacion = new DataColumn("IdConexionUltimaModificacion", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdConexionUltimaModificacion);
                this.columnIdReservado = new DataColumn("IdReservado", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdReservado);
                this.columnRowId = new DataColumn("RowId", typeof(System.Guid), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnRowId);
                this.columnIdSucursal = new DataColumn("IdSucursal", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdSucursal);
                this.columnIdEmpresa = new DataColumn("IdEmpresa", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdEmpresa);
                this.Constraints.Add(new UniqueConstraint("tsa_SeguimientoPedidosKey1", new DataColumn[] {
                                this.columnIdPedido,
                                this.columnIdProducto,
                                this.columnRenglon,
                                this.columnFecha}, true));
                this.columnIdPedido.AllowDBNull = false;
                this.columnIdProducto.AllowDBNull = false;
                this.columnRenglon.AllowDBNull = false;
                this.columnFecha.AllowDBNull = false;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public tsa_SeguimientoPedidosRow Newtsa_SeguimientoPedidosRow() {
                return ((tsa_SeguimientoPedidosRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new tsa_SeguimientoPedidosRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(tsa_SeguimientoPedidosRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.tsa_SeguimientoPedidosRowChanged != null)) {
                    this.tsa_SeguimientoPedidosRowChanged(this, new tsa_SeguimientoPedidosRowChangeEvent(((tsa_SeguimientoPedidosRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.tsa_SeguimientoPedidosRowChanging != null)) {
                    this.tsa_SeguimientoPedidosRowChanging(this, new tsa_SeguimientoPedidosRowChangeEvent(((tsa_SeguimientoPedidosRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.tsa_SeguimientoPedidosRowDeleted != null)) {
                    this.tsa_SeguimientoPedidosRowDeleted(this, new tsa_SeguimientoPedidosRowChangeEvent(((tsa_SeguimientoPedidosRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.tsa_SeguimientoPedidosRowDeleting != null)) {
                    this.tsa_SeguimientoPedidosRowDeleting(this, new tsa_SeguimientoPedidosRowChangeEvent(((tsa_SeguimientoPedidosRow)(e.Row)), e.Action));
                }
            }
            
            public void Removetsa_SeguimientoPedidosRow(tsa_SeguimientoPedidosRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsa_SeguimientoPedidosRow : DataRow {
            
            private tsa_SeguimientoPedidosDataTable tabletsa_SeguimientoPedidos;
            
            internal tsa_SeguimientoPedidosRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tabletsa_SeguimientoPedidos = ((tsa_SeguimientoPedidosDataTable)(this.Table));
            }
            
            public long IdPedido {
                get {
                    return ((long)(this[this.tabletsa_SeguimientoPedidos.IdPedidoColumn]));
                }
                set {
                    this[this.tabletsa_SeguimientoPedidos.IdPedidoColumn] = value;
                }
            }
            
            public string IdProducto {
                get {
                    return ((string)(this[this.tabletsa_SeguimientoPedidos.IdProductoColumn]));
                }
                set {
                    this[this.tabletsa_SeguimientoPedidos.IdProductoColumn] = value;
                }
            }
            
            public short Renglon {
                get {
                    return ((short)(this[this.tabletsa_SeguimientoPedidos.RenglonColumn]));
                }
                set {
                    this[this.tabletsa_SeguimientoPedidos.RenglonColumn] = value;
                }
            }
            
            public System.DateTime Fecha {
                get {
                    return ((System.DateTime)(this[this.tabletsa_SeguimientoPedidos.FechaColumn]));
                }
                set {
                    this[this.tabletsa_SeguimientoPedidos.FechaColumn] = value;
                }
            }
            
            public string Descripcion {
                get {
                    try {
                        return ((string)(this[this.tabletsa_SeguimientoPedidos.DescripcionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsa_SeguimientoPedidos.DescripcionColumn] = value;
                }
            }
            
            public string IdResponsable {
                get {
                    try {
                        return ((string)(this[this.tabletsa_SeguimientoPedidos.IdResponsableColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsa_SeguimientoPedidos.IdResponsableColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    try {
                        return ((System.DateTime)(this[this.tabletsa_SeguimientoPedidos.FechaCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsa_SeguimientoPedidos.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    try {
                        return ((long)(this[this.tabletsa_SeguimientoPedidos.IdConexionCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsa_SeguimientoPedidos.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tabletsa_SeguimientoPedidos.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsa_SeguimientoPedidos.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tabletsa_SeguimientoPedidos.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsa_SeguimientoPedidos.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public long IdReservado {
                get {
                    try {
                        return ((long)(this[this.tabletsa_SeguimientoPedidos.IdReservadoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsa_SeguimientoPedidos.IdReservadoColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tabletsa_SeguimientoPedidos.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsa_SeguimientoPedidos.RowIdColumn] = value;
                }
            }
            
            public long IdSucursal {
                get {
                    try {
                        return ((long)(this[this.tabletsa_SeguimientoPedidos.IdSucursalColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsa_SeguimientoPedidos.IdSucursalColumn] = value;
                }
            }
            
            public long IdEmpresa {
                get {
                    try {
                        return ((long)(this[this.tabletsa_SeguimientoPedidos.IdEmpresaColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsa_SeguimientoPedidos.IdEmpresaColumn] = value;
                }
            }
            
            public bool IsDescripcionNull() {
                return this.IsNull(this.tabletsa_SeguimientoPedidos.DescripcionColumn);
            }
            
            public void SetDescripcionNull() {
                this[this.tabletsa_SeguimientoPedidos.DescripcionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdResponsableNull() {
                return this.IsNull(this.tabletsa_SeguimientoPedidos.IdResponsableColumn);
            }
            
            public void SetIdResponsableNull() {
                this[this.tabletsa_SeguimientoPedidos.IdResponsableColumn] = System.Convert.DBNull;
            }
            
            public bool IsFechaCreacionNull() {
                return this.IsNull(this.tabletsa_SeguimientoPedidos.FechaCreacionColumn);
            }
            
            public void SetFechaCreacionNull() {
                this[this.tabletsa_SeguimientoPedidos.FechaCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionCreacionNull() {
                return this.IsNull(this.tabletsa_SeguimientoPedidos.IdConexionCreacionColumn);
            }
            
            public void SetIdConexionCreacionNull() {
                this[this.tabletsa_SeguimientoPedidos.IdConexionCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tabletsa_SeguimientoPedidos.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tabletsa_SeguimientoPedidos.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tabletsa_SeguimientoPedidos.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tabletsa_SeguimientoPedidos.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdReservadoNull() {
                return this.IsNull(this.tabletsa_SeguimientoPedidos.IdReservadoColumn);
            }
            
            public void SetIdReservadoNull() {
                this[this.tabletsa_SeguimientoPedidos.IdReservadoColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tabletsa_SeguimientoPedidos.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tabletsa_SeguimientoPedidos.RowIdColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdSucursalNull() {
                return this.IsNull(this.tabletsa_SeguimientoPedidos.IdSucursalColumn);
            }
            
            public void SetIdSucursalNull() {
                this[this.tabletsa_SeguimientoPedidos.IdSucursalColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdEmpresaNull() {
                return this.IsNull(this.tabletsa_SeguimientoPedidos.IdEmpresaColumn);
            }
            
            public void SetIdEmpresaNull() {
                this[this.tabletsa_SeguimientoPedidos.IdEmpresaColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsa_SeguimientoPedidosRowChangeEvent : EventArgs {
            
            private tsa_SeguimientoPedidosRow eventRow;
            
            private DataRowAction eventAction;
            
            public tsa_SeguimientoPedidosRowChangeEvent(tsa_SeguimientoPedidosRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public tsa_SeguimientoPedidosRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            public DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
    }
}
