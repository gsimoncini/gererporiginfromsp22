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
    public class tlg_OrdenesRemitosDataset : DataSet {
        
        private tlg_OrdenesRemitosDataTable tabletlg_OrdenesRemitos;
        
        public tlg_OrdenesRemitosDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected tlg_OrdenesRemitosDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["tlg_OrdenesRemitos"] != null)) {
                    this.Tables.Add(new tlg_OrdenesRemitosDataTable(ds.Tables["tlg_OrdenesRemitos"]));
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
        public tlg_OrdenesRemitosDataTable tlg_OrdenesRemitos {
            get {
                return this.tabletlg_OrdenesRemitos;
            }
        }
        
        public override DataSet Clone() {
            tlg_OrdenesRemitosDataset cln = ((tlg_OrdenesRemitosDataset)(base.Clone()));
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
            if ((ds.Tables["tlg_OrdenesRemitos"] != null)) {
                this.Tables.Add(new tlg_OrdenesRemitosDataTable(ds.Tables["tlg_OrdenesRemitos"]));
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
            this.tabletlg_OrdenesRemitos = ((tlg_OrdenesRemitosDataTable)(this.Tables["tlg_OrdenesRemitos"]));
            if ((this.tabletlg_OrdenesRemitos != null)) {
                this.tabletlg_OrdenesRemitos.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "tlg_OrdenesRemitosDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/tlg_OrdenesRemitos.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tabletlg_OrdenesRemitos = new tlg_OrdenesRemitosDataTable();
            this.Tables.Add(this.tabletlg_OrdenesRemitos);
        }
        
        private bool ShouldSerializetlg_OrdenesRemitos() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void tlg_OrdenesRemitosRowChangeEventHandler(object sender, tlg_OrdenesRemitosRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tlg_OrdenesRemitosDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdOrdenPreparacion;
            
            private DataColumn columnIdProductoOrden;
            
            private DataColumn columnIdRemito;
            
            private DataColumn columnIdProductoRemito;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnIdReservado;
            
            private DataColumn columnRowId;
            
            private DataColumn columnIdSucursal;
            
            private DataColumn columnIdEmpresa;
            
            internal tlg_OrdenesRemitosDataTable() : 
                    base("tlg_OrdenesRemitos") {
                this.InitClass();
            }
            
            internal tlg_OrdenesRemitosDataTable(DataTable table) : 
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
            
            internal DataColumn IdOrdenPreparacionColumn {
                get {
                    return this.columnIdOrdenPreparacion;
                }
            }
            
            internal DataColumn IdProductoOrdenColumn {
                get {
                    return this.columnIdProductoOrden;
                }
            }
            
            internal DataColumn IdRemitoColumn {
                get {
                    return this.columnIdRemito;
                }
            }
            
            internal DataColumn IdProductoRemitoColumn {
                get {
                    return this.columnIdProductoRemito;
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
            
            public tlg_OrdenesRemitosRow this[int index] {
                get {
                    return ((tlg_OrdenesRemitosRow)(this.Rows[index]));
                }
            }
            
            public event tlg_OrdenesRemitosRowChangeEventHandler tlg_OrdenesRemitosRowChanged;
            
            public event tlg_OrdenesRemitosRowChangeEventHandler tlg_OrdenesRemitosRowChanging;
            
            public event tlg_OrdenesRemitosRowChangeEventHandler tlg_OrdenesRemitosRowDeleted;
            
            public event tlg_OrdenesRemitosRowChangeEventHandler tlg_OrdenesRemitosRowDeleting;
            
            public void Addtlg_OrdenesRemitosRow(tlg_OrdenesRemitosRow row) {
                this.Rows.Add(row);
            }
            
            public tlg_OrdenesRemitosRow Addtlg_OrdenesRemitosRow(long IdOrdenPreparacion, string IdProductoOrden, long IdRemito, string IdProductoRemito, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, System.Guid RowId, long IdSucursal, long IdEmpresa) {
                tlg_OrdenesRemitosRow rowtlg_OrdenesRemitosRow = ((tlg_OrdenesRemitosRow)(this.NewRow()));
                rowtlg_OrdenesRemitosRow.ItemArray = new object[] {
                        IdOrdenPreparacion,
                        IdProductoOrden,
                        IdRemito,
                        IdProductoRemito,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        IdReservado,
                        RowId,
                        IdSucursal,
                        IdEmpresa};
                this.Rows.Add(rowtlg_OrdenesRemitosRow);
                return rowtlg_OrdenesRemitosRow;
            }
            
            public tlg_OrdenesRemitosRow FindByIdOrdenPreparacionIdProductoOrdenIdRemitoIdProductoRemito(long IdOrdenPreparacion, string IdProductoOrden, long IdRemito, string IdProductoRemito) {
                return ((tlg_OrdenesRemitosRow)(this.Rows.Find(new object[] {
                            IdOrdenPreparacion,
                            IdProductoOrden,
                            IdRemito,
                            IdProductoRemito})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                tlg_OrdenesRemitosDataTable cln = ((tlg_OrdenesRemitosDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new tlg_OrdenesRemitosDataTable();
            }
            
            internal void InitVars() {
                this.columnIdOrdenPreparacion = this.Columns["IdOrdenPreparacion"];
                this.columnIdProductoOrden = this.Columns["IdProductoOrden"];
                this.columnIdRemito = this.Columns["IdRemito"];
                this.columnIdProductoRemito = this.Columns["IdProductoRemito"];
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
                this.columnIdOrdenPreparacion = new DataColumn("IdOrdenPreparacion", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdOrdenPreparacion);
                this.columnIdProductoOrden = new DataColumn("IdProductoOrden", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdProductoOrden);
                this.columnIdRemito = new DataColumn("IdRemito", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdRemito);
                this.columnIdProductoRemito = new DataColumn("IdProductoRemito", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdProductoRemito);
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
                this.Constraints.Add(new UniqueConstraint("tlg_OrdenesRemitosKey1", new DataColumn[] {
                                this.columnIdOrdenPreparacion,
                                this.columnIdProductoOrden,
                                this.columnIdRemito,
                                this.columnIdProductoRemito}, true));
                this.columnIdOrdenPreparacion.AllowDBNull = false;
                this.columnIdProductoOrden.AllowDBNull = false;
                this.columnIdRemito.AllowDBNull = false;
                this.columnIdProductoRemito.AllowDBNull = false;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public tlg_OrdenesRemitosRow Newtlg_OrdenesRemitosRow() {
                return ((tlg_OrdenesRemitosRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new tlg_OrdenesRemitosRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(tlg_OrdenesRemitosRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.tlg_OrdenesRemitosRowChanged != null)) {
                    this.tlg_OrdenesRemitosRowChanged(this, new tlg_OrdenesRemitosRowChangeEvent(((tlg_OrdenesRemitosRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.tlg_OrdenesRemitosRowChanging != null)) {
                    this.tlg_OrdenesRemitosRowChanging(this, new tlg_OrdenesRemitosRowChangeEvent(((tlg_OrdenesRemitosRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.tlg_OrdenesRemitosRowDeleted != null)) {
                    this.tlg_OrdenesRemitosRowDeleted(this, new tlg_OrdenesRemitosRowChangeEvent(((tlg_OrdenesRemitosRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.tlg_OrdenesRemitosRowDeleting != null)) {
                    this.tlg_OrdenesRemitosRowDeleting(this, new tlg_OrdenesRemitosRowChangeEvent(((tlg_OrdenesRemitosRow)(e.Row)), e.Action));
                }
            }
            
            public void Removetlg_OrdenesRemitosRow(tlg_OrdenesRemitosRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tlg_OrdenesRemitosRow : DataRow {
            
            private tlg_OrdenesRemitosDataTable tabletlg_OrdenesRemitos;
            
            internal tlg_OrdenesRemitosRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tabletlg_OrdenesRemitos = ((tlg_OrdenesRemitosDataTable)(this.Table));
            }
            
            public long IdOrdenPreparacion {
                get {
                    return ((long)(this[this.tabletlg_OrdenesRemitos.IdOrdenPreparacionColumn]));
                }
                set {
                    this[this.tabletlg_OrdenesRemitos.IdOrdenPreparacionColumn] = value;
                }
            }
            
            public string IdProductoOrden {
                get {
                    return ((string)(this[this.tabletlg_OrdenesRemitos.IdProductoOrdenColumn]));
                }
                set {
                    this[this.tabletlg_OrdenesRemitos.IdProductoOrdenColumn] = value;
                }
            }
            
            public long IdRemito {
                get {
                    return ((long)(this[this.tabletlg_OrdenesRemitos.IdRemitoColumn]));
                }
                set {
                    this[this.tabletlg_OrdenesRemitos.IdRemitoColumn] = value;
                }
            }
            
            public string IdProductoRemito {
                get {
                    return ((string)(this[this.tabletlg_OrdenesRemitos.IdProductoRemitoColumn]));
                }
                set {
                    this[this.tabletlg_OrdenesRemitos.IdProductoRemitoColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    try {
                        return ((System.DateTime)(this[this.tabletlg_OrdenesRemitos.FechaCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_OrdenesRemitos.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    try {
                        return ((long)(this[this.tabletlg_OrdenesRemitos.IdConexionCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_OrdenesRemitos.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tabletlg_OrdenesRemitos.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_OrdenesRemitos.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tabletlg_OrdenesRemitos.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_OrdenesRemitos.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public long IdReservado {
                get {
                    try {
                        return ((long)(this[this.tabletlg_OrdenesRemitos.IdReservadoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_OrdenesRemitos.IdReservadoColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tabletlg_OrdenesRemitos.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_OrdenesRemitos.RowIdColumn] = value;
                }
            }
            
            public long IdSucursal {
                get {
                    try {
                        return ((long)(this[this.tabletlg_OrdenesRemitos.IdSucursalColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_OrdenesRemitos.IdSucursalColumn] = value;
                }
            }
            
            public long IdEmpresa {
                get {
                    try {
                        return ((long)(this[this.tabletlg_OrdenesRemitos.IdEmpresaColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_OrdenesRemitos.IdEmpresaColumn] = value;
                }
            }
            
            public bool IsFechaCreacionNull() {
                return this.IsNull(this.tabletlg_OrdenesRemitos.FechaCreacionColumn);
            }
            
            public void SetFechaCreacionNull() {
                this[this.tabletlg_OrdenesRemitos.FechaCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionCreacionNull() {
                return this.IsNull(this.tabletlg_OrdenesRemitos.IdConexionCreacionColumn);
            }
            
            public void SetIdConexionCreacionNull() {
                this[this.tabletlg_OrdenesRemitos.IdConexionCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tabletlg_OrdenesRemitos.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tabletlg_OrdenesRemitos.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tabletlg_OrdenesRemitos.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tabletlg_OrdenesRemitos.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdReservadoNull() {
                return this.IsNull(this.tabletlg_OrdenesRemitos.IdReservadoColumn);
            }
            
            public void SetIdReservadoNull() {
                this[this.tabletlg_OrdenesRemitos.IdReservadoColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tabletlg_OrdenesRemitos.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tabletlg_OrdenesRemitos.RowIdColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdSucursalNull() {
                return this.IsNull(this.tabletlg_OrdenesRemitos.IdSucursalColumn);
            }
            
            public void SetIdSucursalNull() {
                this[this.tabletlg_OrdenesRemitos.IdSucursalColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdEmpresaNull() {
                return this.IsNull(this.tabletlg_OrdenesRemitos.IdEmpresaColumn);
            }
            
            public void SetIdEmpresaNull() {
                this[this.tabletlg_OrdenesRemitos.IdEmpresaColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tlg_OrdenesRemitosRowChangeEvent : EventArgs {
            
            private tlg_OrdenesRemitosRow eventRow;
            
            private DataRowAction eventAction;
            
            public tlg_OrdenesRemitosRowChangeEvent(tlg_OrdenesRemitosRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public tlg_OrdenesRemitosRow Row {
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
