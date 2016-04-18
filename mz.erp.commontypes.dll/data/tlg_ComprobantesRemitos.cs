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
    public class tlg_ComprobantesRemitosDataset : DataSet {
        
        private tlg_ComprobantesRemitosDataTable tabletlg_ComprobantesRemitos;
        
        public tlg_ComprobantesRemitosDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected tlg_ComprobantesRemitosDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["tlg_ComprobantesRemitos"] != null)) {
                    this.Tables.Add(new tlg_ComprobantesRemitosDataTable(ds.Tables["tlg_ComprobantesRemitos"]));
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
        public tlg_ComprobantesRemitosDataTable tlg_ComprobantesRemitos {
            get {
                return this.tabletlg_ComprobantesRemitos;
            }
        }
        
        public override DataSet Clone() {
            tlg_ComprobantesRemitosDataset cln = ((tlg_ComprobantesRemitosDataset)(base.Clone()));
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
            if ((ds.Tables["tlg_ComprobantesRemitos"] != null)) {
                this.Tables.Add(new tlg_ComprobantesRemitosDataTable(ds.Tables["tlg_ComprobantesRemitos"]));
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
            this.tabletlg_ComprobantesRemitos = ((tlg_ComprobantesRemitosDataTable)(this.Tables["tlg_ComprobantesRemitos"]));
            if ((this.tabletlg_ComprobantesRemitos != null)) {
                this.tabletlg_ComprobantesRemitos.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "tlg_ComprobantesRemitosDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/tlg_ComprobantesRemitos.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tabletlg_ComprobantesRemitos = new tlg_ComprobantesRemitosDataTable();
            this.Tables.Add(this.tabletlg_ComprobantesRemitos);
        }
        
        private bool ShouldSerializetlg_ComprobantesRemitos() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void tlg_ComprobantesRemitosRowChangeEventHandler(object sender, tlg_ComprobantesRemitosRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tlg_ComprobantesRemitosDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdRemito;
            
            private DataColumn columnIdProducto;
            
            private DataColumn columnFecha;
            
            private DataColumn columnTipo;
            
            private DataColumn columnNumero;
            
            private DataColumn columnIdRenglon;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnIdReservado;
            
            private DataColumn columnRowId;
            
            private DataColumn columnIdSucursal;
            
            private DataColumn columnIdEmpresa;
            
            internal tlg_ComprobantesRemitosDataTable() : 
                    base("tlg_ComprobantesRemitos") {
                this.InitClass();
            }
            
            internal tlg_ComprobantesRemitosDataTable(DataTable table) : 
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
            
            internal DataColumn IdRemitoColumn {
                get {
                    return this.columnIdRemito;
                }
            }
            
            internal DataColumn IdProductoColumn {
                get {
                    return this.columnIdProducto;
                }
            }
            
            internal DataColumn FechaColumn {
                get {
                    return this.columnFecha;
                }
            }
            
            internal DataColumn TipoColumn {
                get {
                    return this.columnTipo;
                }
            }
            
            internal DataColumn NumeroColumn {
                get {
                    return this.columnNumero;
                }
            }
            
            internal DataColumn IdRenglonColumn {
                get {
                    return this.columnIdRenglon;
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
            
            public tlg_ComprobantesRemitosRow this[int index] {
                get {
                    return ((tlg_ComprobantesRemitosRow)(this.Rows[index]));
                }
            }
            
            public event tlg_ComprobantesRemitosRowChangeEventHandler tlg_ComprobantesRemitosRowChanged;
            
            public event tlg_ComprobantesRemitosRowChangeEventHandler tlg_ComprobantesRemitosRowChanging;
            
            public event tlg_ComprobantesRemitosRowChangeEventHandler tlg_ComprobantesRemitosRowDeleted;
            
            public event tlg_ComprobantesRemitosRowChangeEventHandler tlg_ComprobantesRemitosRowDeleting;
            
            public void Addtlg_ComprobantesRemitosRow(tlg_ComprobantesRemitosRow row) {
                this.Rows.Add(row);
            }
            
            public tlg_ComprobantesRemitosRow Addtlg_ComprobantesRemitosRow(long IdRemito, string IdProducto, System.DateTime Fecha, string Tipo, string Numero, short IdRenglon, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, System.Guid RowId, long IdSucursal, long IdEmpresa) {
                tlg_ComprobantesRemitosRow rowtlg_ComprobantesRemitosRow = ((tlg_ComprobantesRemitosRow)(this.NewRow()));
                rowtlg_ComprobantesRemitosRow.ItemArray = new object[] {
                        IdRemito,
                        IdProducto,
                        Fecha,
                        Tipo,
                        Numero,
                        IdRenglon,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        IdReservado,
                        RowId,
                        IdSucursal,
                        IdEmpresa};
                this.Rows.Add(rowtlg_ComprobantesRemitosRow);
                return rowtlg_ComprobantesRemitosRow;
            }
            
            public tlg_ComprobantesRemitosRow FindByIdRemitoIdProductoFechaTipoNumeroIdRenglon(long IdRemito, string IdProducto, System.DateTime Fecha, string Tipo, string Numero, short IdRenglon) {
                return ((tlg_ComprobantesRemitosRow)(this.Rows.Find(new object[] {
                            IdRemito,
                            IdProducto,
                            Fecha,
                            Tipo,
                            Numero,
                            IdRenglon})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                tlg_ComprobantesRemitosDataTable cln = ((tlg_ComprobantesRemitosDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new tlg_ComprobantesRemitosDataTable();
            }
            
            internal void InitVars() {
                this.columnIdRemito = this.Columns["IdRemito"];
                this.columnIdProducto = this.Columns["IdProducto"];
                this.columnFecha = this.Columns["Fecha"];
                this.columnTipo = this.Columns["Tipo"];
                this.columnNumero = this.Columns["Numero"];
                this.columnIdRenglon = this.Columns["IdRenglon"];
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
                this.columnIdRemito = new DataColumn("IdRemito", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdRemito);
                this.columnIdProducto = new DataColumn("IdProducto", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdProducto);
                this.columnFecha = new DataColumn("Fecha", typeof(System.DateTime), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnFecha);
                this.columnTipo = new DataColumn("Tipo", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnTipo);
                this.columnNumero = new DataColumn("Numero", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnNumero);
                this.columnIdRenglon = new DataColumn("IdRenglon", typeof(short), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdRenglon);
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
                this.Constraints.Add(new UniqueConstraint("tlg_ComprobantesRemitosKey1", new DataColumn[] {
                                this.columnIdRemito,
                                this.columnIdProducto,
                                this.columnFecha,
                                this.columnTipo,
                                this.columnNumero,
                                this.columnIdRenglon}, true));
                this.columnIdRemito.AllowDBNull = false;
                this.columnIdProducto.AllowDBNull = false;
                this.columnFecha.AllowDBNull = false;
                this.columnTipo.AllowDBNull = false;
                this.columnNumero.AllowDBNull = false;
                this.columnIdRenglon.AllowDBNull = false;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public tlg_ComprobantesRemitosRow Newtlg_ComprobantesRemitosRow() {
                return ((tlg_ComprobantesRemitosRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new tlg_ComprobantesRemitosRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(tlg_ComprobantesRemitosRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.tlg_ComprobantesRemitosRowChanged != null)) {
                    this.tlg_ComprobantesRemitosRowChanged(this, new tlg_ComprobantesRemitosRowChangeEvent(((tlg_ComprobantesRemitosRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.tlg_ComprobantesRemitosRowChanging != null)) {
                    this.tlg_ComprobantesRemitosRowChanging(this, new tlg_ComprobantesRemitosRowChangeEvent(((tlg_ComprobantesRemitosRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.tlg_ComprobantesRemitosRowDeleted != null)) {
                    this.tlg_ComprobantesRemitosRowDeleted(this, new tlg_ComprobantesRemitosRowChangeEvent(((tlg_ComprobantesRemitosRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.tlg_ComprobantesRemitosRowDeleting != null)) {
                    this.tlg_ComprobantesRemitosRowDeleting(this, new tlg_ComprobantesRemitosRowChangeEvent(((tlg_ComprobantesRemitosRow)(e.Row)), e.Action));
                }
            }
            
            public void Removetlg_ComprobantesRemitosRow(tlg_ComprobantesRemitosRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tlg_ComprobantesRemitosRow : DataRow {
            
            private tlg_ComprobantesRemitosDataTable tabletlg_ComprobantesRemitos;
            
            internal tlg_ComprobantesRemitosRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tabletlg_ComprobantesRemitos = ((tlg_ComprobantesRemitosDataTable)(this.Table));
            }
            
            public long IdRemito {
                get {
                    return ((long)(this[this.tabletlg_ComprobantesRemitos.IdRemitoColumn]));
                }
                set {
                    this[this.tabletlg_ComprobantesRemitos.IdRemitoColumn] = value;
                }
            }
            
            public string IdProducto {
                get {
                    return ((string)(this[this.tabletlg_ComprobantesRemitos.IdProductoColumn]));
                }
                set {
                    this[this.tabletlg_ComprobantesRemitos.IdProductoColumn] = value;
                }
            }
            
            public System.DateTime Fecha {
                get {
                    return ((System.DateTime)(this[this.tabletlg_ComprobantesRemitos.FechaColumn]));
                }
                set {
                    this[this.tabletlg_ComprobantesRemitos.FechaColumn] = value;
                }
            }
            
            public string Tipo {
                get {
                    return ((string)(this[this.tabletlg_ComprobantesRemitos.TipoColumn]));
                }
                set {
                    this[this.tabletlg_ComprobantesRemitos.TipoColumn] = value;
                }
            }
            
            public string Numero {
                get {
                    return ((string)(this[this.tabletlg_ComprobantesRemitos.NumeroColumn]));
                }
                set {
                    this[this.tabletlg_ComprobantesRemitos.NumeroColumn] = value;
                }
            }
            
            public short IdRenglon {
                get {
                    return ((short)(this[this.tabletlg_ComprobantesRemitos.IdRenglonColumn]));
                }
                set {
                    this[this.tabletlg_ComprobantesRemitos.IdRenglonColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    try {
                        return ((System.DateTime)(this[this.tabletlg_ComprobantesRemitos.FechaCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_ComprobantesRemitos.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    try {
                        return ((long)(this[this.tabletlg_ComprobantesRemitos.IdConexionCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_ComprobantesRemitos.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tabletlg_ComprobantesRemitos.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_ComprobantesRemitos.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tabletlg_ComprobantesRemitos.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_ComprobantesRemitos.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public long IdReservado {
                get {
                    try {
                        return ((long)(this[this.tabletlg_ComprobantesRemitos.IdReservadoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_ComprobantesRemitos.IdReservadoColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tabletlg_ComprobantesRemitos.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_ComprobantesRemitos.RowIdColumn] = value;
                }
            }
            
            public long IdSucursal {
                get {
                    try {
                        return ((long)(this[this.tabletlg_ComprobantesRemitos.IdSucursalColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_ComprobantesRemitos.IdSucursalColumn] = value;
                }
            }
            
            public long IdEmpresa {
                get {
                    try {
                        return ((long)(this[this.tabletlg_ComprobantesRemitos.IdEmpresaColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_ComprobantesRemitos.IdEmpresaColumn] = value;
                }
            }
            
            public bool IsFechaCreacionNull() {
                return this.IsNull(this.tabletlg_ComprobantesRemitos.FechaCreacionColumn);
            }
            
            public void SetFechaCreacionNull() {
                this[this.tabletlg_ComprobantesRemitos.FechaCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionCreacionNull() {
                return this.IsNull(this.tabletlg_ComprobantesRemitos.IdConexionCreacionColumn);
            }
            
            public void SetIdConexionCreacionNull() {
                this[this.tabletlg_ComprobantesRemitos.IdConexionCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tabletlg_ComprobantesRemitos.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tabletlg_ComprobantesRemitos.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tabletlg_ComprobantesRemitos.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tabletlg_ComprobantesRemitos.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdReservadoNull() {
                return this.IsNull(this.tabletlg_ComprobantesRemitos.IdReservadoColumn);
            }
            
            public void SetIdReservadoNull() {
                this[this.tabletlg_ComprobantesRemitos.IdReservadoColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tabletlg_ComprobantesRemitos.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tabletlg_ComprobantesRemitos.RowIdColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdSucursalNull() {
                return this.IsNull(this.tabletlg_ComprobantesRemitos.IdSucursalColumn);
            }
            
            public void SetIdSucursalNull() {
                this[this.tabletlg_ComprobantesRemitos.IdSucursalColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdEmpresaNull() {
                return this.IsNull(this.tabletlg_ComprobantesRemitos.IdEmpresaColumn);
            }
            
            public void SetIdEmpresaNull() {
                this[this.tabletlg_ComprobantesRemitos.IdEmpresaColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tlg_ComprobantesRemitosRowChangeEvent : EventArgs {
            
            private tlg_ComprobantesRemitosRow eventRow;
            
            private DataRowAction eventAction;
            
            public tlg_ComprobantesRemitosRowChangeEvent(tlg_ComprobantesRemitosRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public tlg_ComprobantesRemitosRow Row {
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
