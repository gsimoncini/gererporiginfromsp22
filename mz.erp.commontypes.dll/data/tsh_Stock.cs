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
    public class tsh_StockDataset : DataSet {
        
        private tsh_StockDataTable tabletsh_Stock;
        
        public tsh_StockDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected tsh_StockDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["tsh_Stock"] != null)) {
                    this.Tables.Add(new tsh_StockDataTable(ds.Tables["tsh_Stock"]));
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
        public tsh_StockDataTable tsh_Stock {
            get {
                return this.tabletsh_Stock;
            }
        }
        
        public override DataSet Clone() {
            tsh_StockDataset cln = ((tsh_StockDataset)(base.Clone()));
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
            if ((ds.Tables["tsh_Stock"] != null)) {
                this.Tables.Add(new tsh_StockDataTable(ds.Tables["tsh_Stock"]));
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
            this.tabletsh_Stock = ((tsh_StockDataTable)(this.Tables["tsh_Stock"]));
            if ((this.tabletsh_Stock != null)) {
                this.tabletsh_Stock.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "tsh_StockDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/tsh_Stock.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tabletsh_Stock = new tsh_StockDataTable();
            this.Tables.Add(this.tabletsh_Stock);
        }
        
        private bool ShouldSerializetsh_Stock() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void tsh_StockRowChangeEventHandler(object sender, tsh_StockRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsh_StockDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdProducto;
            
            private DataColumn columnIdSeccion;
            
            private DataColumn columnCantidad;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnIdReservado;
            
            private DataColumn columnRowId;
            
            private DataColumn columnIdSucursal;
            
            private DataColumn columnIdEmpresa;
            
            internal tsh_StockDataTable() : 
                    base("tsh_Stock") {
                this.InitClass();
            }
            
            internal tsh_StockDataTable(DataTable table) : 
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
            
            internal DataColumn IdProductoColumn {
                get {
                    return this.columnIdProducto;
                }
            }
            
            internal DataColumn IdSeccionColumn {
                get {
                    return this.columnIdSeccion;
                }
            }
            
            internal DataColumn CantidadColumn {
                get {
                    return this.columnCantidad;
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
            
            public tsh_StockRow this[int index] {
                get {
                    return ((tsh_StockRow)(this.Rows[index]));
                }
            }
            
            public event tsh_StockRowChangeEventHandler tsh_StockRowChanged;
            
            public event tsh_StockRowChangeEventHandler tsh_StockRowChanging;
            
            public event tsh_StockRowChangeEventHandler tsh_StockRowDeleted;
            
            public event tsh_StockRowChangeEventHandler tsh_StockRowDeleting;
            
            public void Addtsh_StockRow(tsh_StockRow row) {
                this.Rows.Add(row);
            }
            
            public tsh_StockRow Addtsh_StockRow(string IdProducto, long IdSeccion, System.Decimal Cantidad, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, System.Guid RowId, long IdSucursal, long IdEmpresa) {
                tsh_StockRow rowtsh_StockRow = ((tsh_StockRow)(this.NewRow()));
                rowtsh_StockRow.ItemArray = new object[] {
                        IdProducto,
                        IdSeccion,
                        Cantidad,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        IdReservado,
                        RowId,
                        IdSucursal,
                        IdEmpresa};
                this.Rows.Add(rowtsh_StockRow);
                return rowtsh_StockRow;
            }
            
            public tsh_StockRow FindByIdProductoIdSeccion(string IdProducto, long IdSeccion) {
                return ((tsh_StockRow)(this.Rows.Find(new object[] {
                            IdProducto,
                            IdSeccion})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                tsh_StockDataTable cln = ((tsh_StockDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new tsh_StockDataTable();
            }
            
            internal void InitVars() {
                this.columnIdProducto = this.Columns["IdProducto"];
                this.columnIdSeccion = this.Columns["IdSeccion"];
                this.columnCantidad = this.Columns["Cantidad"];
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
                this.columnIdProducto = new DataColumn("IdProducto", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdProducto);
                this.columnIdSeccion = new DataColumn("IdSeccion", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdSeccion);
                this.columnCantidad = new DataColumn("Cantidad", typeof(System.Decimal), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCantidad);
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
                this.Constraints.Add(new UniqueConstraint("tsh_StockKey1", new DataColumn[] {
                                this.columnIdProducto,
                                this.columnIdSeccion}, true));
                this.columnIdProducto.AllowDBNull = false;
                this.columnIdSeccion.AllowDBNull = false;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public tsh_StockRow Newtsh_StockRow() {
                return ((tsh_StockRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new tsh_StockRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(tsh_StockRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.tsh_StockRowChanged != null)) {
                    this.tsh_StockRowChanged(this, new tsh_StockRowChangeEvent(((tsh_StockRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.tsh_StockRowChanging != null)) {
                    this.tsh_StockRowChanging(this, new tsh_StockRowChangeEvent(((tsh_StockRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.tsh_StockRowDeleted != null)) {
                    this.tsh_StockRowDeleted(this, new tsh_StockRowChangeEvent(((tsh_StockRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.tsh_StockRowDeleting != null)) {
                    this.tsh_StockRowDeleting(this, new tsh_StockRowChangeEvent(((tsh_StockRow)(e.Row)), e.Action));
                }
            }
            
            public void Removetsh_StockRow(tsh_StockRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsh_StockRow : DataRow {
            
            private tsh_StockDataTable tabletsh_Stock;
            
            internal tsh_StockRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tabletsh_Stock = ((tsh_StockDataTable)(this.Table));
            }
            
            public string IdProducto {
                get {
                    return ((string)(this[this.tabletsh_Stock.IdProductoColumn]));
                }
                set {
                    this[this.tabletsh_Stock.IdProductoColumn] = value;
                }
            }
            
            public long IdSeccion {
                get {
                    return ((long)(this[this.tabletsh_Stock.IdSeccionColumn]));
                }
                set {
                    this[this.tabletsh_Stock.IdSeccionColumn] = value;
                }
            }
            
            public System.Decimal Cantidad {
                get {
                    try {
                        return ((System.Decimal)(this[this.tabletsh_Stock.CantidadColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_Stock.CantidadColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    try {
                        return ((System.DateTime)(this[this.tabletsh_Stock.FechaCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_Stock.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    try {
                        return ((long)(this[this.tabletsh_Stock.IdConexionCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_Stock.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tabletsh_Stock.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_Stock.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tabletsh_Stock.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_Stock.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public long IdReservado {
                get {
                    try {
                        return ((long)(this[this.tabletsh_Stock.IdReservadoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_Stock.IdReservadoColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tabletsh_Stock.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_Stock.RowIdColumn] = value;
                }
            }
            
            public long IdSucursal {
                get {
                    try {
                        return ((long)(this[this.tabletsh_Stock.IdSucursalColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_Stock.IdSucursalColumn] = value;
                }
            }
            
            public long IdEmpresa {
                get {
                    try {
                        return ((long)(this[this.tabletsh_Stock.IdEmpresaColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_Stock.IdEmpresaColumn] = value;
                }
            }
            
            public bool IsCantidadNull() {
                return this.IsNull(this.tabletsh_Stock.CantidadColumn);
            }
            
            public void SetCantidadNull() {
                this[this.tabletsh_Stock.CantidadColumn] = System.Convert.DBNull;
            }
            
            public bool IsFechaCreacionNull() {
                return this.IsNull(this.tabletsh_Stock.FechaCreacionColumn);
            }
            
            public void SetFechaCreacionNull() {
                this[this.tabletsh_Stock.FechaCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionCreacionNull() {
                return this.IsNull(this.tabletsh_Stock.IdConexionCreacionColumn);
            }
            
            public void SetIdConexionCreacionNull() {
                this[this.tabletsh_Stock.IdConexionCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tabletsh_Stock.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tabletsh_Stock.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tabletsh_Stock.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tabletsh_Stock.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdReservadoNull() {
                return this.IsNull(this.tabletsh_Stock.IdReservadoColumn);
            }
            
            public void SetIdReservadoNull() {
                this[this.tabletsh_Stock.IdReservadoColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tabletsh_Stock.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tabletsh_Stock.RowIdColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdSucursalNull() {
                return this.IsNull(this.tabletsh_Stock.IdSucursalColumn);
            }
            
            public void SetIdSucursalNull() {
                this[this.tabletsh_Stock.IdSucursalColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdEmpresaNull() {
                return this.IsNull(this.tabletsh_Stock.IdEmpresaColumn);
            }
            
            public void SetIdEmpresaNull() {
                this[this.tabletsh_Stock.IdEmpresaColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsh_StockRowChangeEvent : EventArgs {
            
            private tsh_StockRow eventRow;
            
            private DataRowAction eventAction;
            
            public tsh_StockRowChangeEvent(tsh_StockRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public tsh_StockRow Row {
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
