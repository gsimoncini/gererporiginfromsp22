﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.2032
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
    public class tpu_ComprobantesMovimientosDeStockDataset : DataSet {
        
        private tpu_ComprobantesMovimientosDeStockDataTable tabletpu_ComprobantesMovimientosDeStock;
        
        public tpu_ComprobantesMovimientosDeStockDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected tpu_ComprobantesMovimientosDeStockDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["tpu_ComprobantesMovimientosDeStock"] != null)) {
                    this.Tables.Add(new tpu_ComprobantesMovimientosDeStockDataTable(ds.Tables["tpu_ComprobantesMovimientosDeStock"]));
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
        public tpu_ComprobantesMovimientosDeStockDataTable tpu_ComprobantesMovimientosDeStock {
            get {
                return this.tabletpu_ComprobantesMovimientosDeStock;
            }
        }
        
        public override DataSet Clone() {
            tpu_ComprobantesMovimientosDeStockDataset cln = ((tpu_ComprobantesMovimientosDeStockDataset)(base.Clone()));
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
            if ((ds.Tables["tpu_ComprobantesMovimientosDeStock"] != null)) {
                this.Tables.Add(new tpu_ComprobantesMovimientosDeStockDataTable(ds.Tables["tpu_ComprobantesMovimientosDeStock"]));
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
            this.tabletpu_ComprobantesMovimientosDeStock = ((tpu_ComprobantesMovimientosDeStockDataTable)(this.Tables["tpu_ComprobantesMovimientosDeStock"]));
            if ((this.tabletpu_ComprobantesMovimientosDeStock != null)) {
                this.tabletpu_ComprobantesMovimientosDeStock.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "tpu_ComprobantesMovimientosDeStockDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/tpu_ComprobantesMovimientosDeStock.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tabletpu_ComprobantesMovimientosDeStock = new tpu_ComprobantesMovimientosDeStockDataTable();
            this.Tables.Add(this.tabletpu_ComprobantesMovimientosDeStock);
        }
        
        private bool ShouldSerializetpu_ComprobantesMovimientosDeStock() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void tpu_ComprobantesMovimientosDeStockRowChangeEventHandler(object sender, tpu_ComprobantesMovimientosDeStockRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tpu_ComprobantesMovimientosDeStockDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdComprobante;
            
            private DataColumn columnIdMovimientoDeStock;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnIdReservado;
            
            private DataColumn columnRowId;
            
            private DataColumn columnIdEmpresa;
            
            private DataColumn columnIdSucursal;
            
            internal tpu_ComprobantesMovimientosDeStockDataTable() : 
                    base("tpu_ComprobantesMovimientosDeStock") {
                this.InitClass();
            }
            
            internal tpu_ComprobantesMovimientosDeStockDataTable(DataTable table) : 
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
            
            internal DataColumn IdComprobanteColumn {
                get {
                    return this.columnIdComprobante;
                }
            }
            
            internal DataColumn IdMovimientoDeStockColumn {
                get {
                    return this.columnIdMovimientoDeStock;
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
            
            internal DataColumn IdEmpresaColumn {
                get {
                    return this.columnIdEmpresa;
                }
            }
            
            internal DataColumn IdSucursalColumn {
                get {
                    return this.columnIdSucursal;
                }
            }
            
            public tpu_ComprobantesMovimientosDeStockRow this[int index] {
                get {
                    return ((tpu_ComprobantesMovimientosDeStockRow)(this.Rows[index]));
                }
            }
            
            public event tpu_ComprobantesMovimientosDeStockRowChangeEventHandler tpu_ComprobantesMovimientosDeStockRowChanged;
            
            public event tpu_ComprobantesMovimientosDeStockRowChangeEventHandler tpu_ComprobantesMovimientosDeStockRowChanging;
            
            public event tpu_ComprobantesMovimientosDeStockRowChangeEventHandler tpu_ComprobantesMovimientosDeStockRowDeleted;
            
            public event tpu_ComprobantesMovimientosDeStockRowChangeEventHandler tpu_ComprobantesMovimientosDeStockRowDeleting;
            
            public void Addtpu_ComprobantesMovimientosDeStockRow(tpu_ComprobantesMovimientosDeStockRow row) {
                this.Rows.Add(row);
            }
            
            public tpu_ComprobantesMovimientosDeStockRow Addtpu_ComprobantesMovimientosDeStockRow(string IdComprobante, string IdMovimientoDeStock, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, System.Guid RowId, long IdEmpresa, long IdSucursal) {
                tpu_ComprobantesMovimientosDeStockRow rowtpu_ComprobantesMovimientosDeStockRow = ((tpu_ComprobantesMovimientosDeStockRow)(this.NewRow()));
                rowtpu_ComprobantesMovimientosDeStockRow.ItemArray = new object[] {
                        IdComprobante,
                        IdMovimientoDeStock,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        IdReservado,
                        RowId,
                        IdEmpresa,
                        IdSucursal};
                this.Rows.Add(rowtpu_ComprobantesMovimientosDeStockRow);
                return rowtpu_ComprobantesMovimientosDeStockRow;
            }
            
            public tpu_ComprobantesMovimientosDeStockRow FindByIdComprobanteIdMovimientoDeStock(string IdComprobante, string IdMovimientoDeStock) {
                return ((tpu_ComprobantesMovimientosDeStockRow)(this.Rows.Find(new object[] {
                            IdComprobante,
                            IdMovimientoDeStock})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                tpu_ComprobantesMovimientosDeStockDataTable cln = ((tpu_ComprobantesMovimientosDeStockDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new tpu_ComprobantesMovimientosDeStockDataTable();
            }
            
            internal void InitVars() {
                this.columnIdComprobante = this.Columns["IdComprobante"];
                this.columnIdMovimientoDeStock = this.Columns["IdMovimientoDeStock"];
                this.columnFechaCreacion = this.Columns["FechaCreacion"];
                this.columnIdConexionCreacion = this.Columns["IdConexionCreacion"];
                this.columnUltimaModificacion = this.Columns["UltimaModificacion"];
                this.columnIdConexionUltimaModificacion = this.Columns["IdConexionUltimaModificacion"];
                this.columnIdReservado = this.Columns["IdReservado"];
                this.columnRowId = this.Columns["RowId"];
                this.columnIdEmpresa = this.Columns["IdEmpresa"];
                this.columnIdSucursal = this.Columns["IdSucursal"];
            }
            
            private void InitClass() {
                this.columnIdComprobante = new DataColumn("IdComprobante", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdComprobante);
                this.columnIdMovimientoDeStock = new DataColumn("IdMovimientoDeStock", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdMovimientoDeStock);
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
                this.columnIdEmpresa = new DataColumn("IdEmpresa", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdEmpresa);
                this.columnIdSucursal = new DataColumn("IdSucursal", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdSucursal);
                this.Constraints.Add(new UniqueConstraint("tpu_ComprobantesMovimientosDeStockKey1", new DataColumn[] {
                                this.columnIdComprobante,
                                this.columnIdMovimientoDeStock}, true));
                this.columnIdComprobante.AllowDBNull = false;
                this.columnIdMovimientoDeStock.AllowDBNull = false;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public tpu_ComprobantesMovimientosDeStockRow Newtpu_ComprobantesMovimientosDeStockRow() {
                return ((tpu_ComprobantesMovimientosDeStockRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new tpu_ComprobantesMovimientosDeStockRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(tpu_ComprobantesMovimientosDeStockRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.tpu_ComprobantesMovimientosDeStockRowChanged != null)) {
                    this.tpu_ComprobantesMovimientosDeStockRowChanged(this, new tpu_ComprobantesMovimientosDeStockRowChangeEvent(((tpu_ComprobantesMovimientosDeStockRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.tpu_ComprobantesMovimientosDeStockRowChanging != null)) {
                    this.tpu_ComprobantesMovimientosDeStockRowChanging(this, new tpu_ComprobantesMovimientosDeStockRowChangeEvent(((tpu_ComprobantesMovimientosDeStockRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.tpu_ComprobantesMovimientosDeStockRowDeleted != null)) {
                    this.tpu_ComprobantesMovimientosDeStockRowDeleted(this, new tpu_ComprobantesMovimientosDeStockRowChangeEvent(((tpu_ComprobantesMovimientosDeStockRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.tpu_ComprobantesMovimientosDeStockRowDeleting != null)) {
                    this.tpu_ComprobantesMovimientosDeStockRowDeleting(this, new tpu_ComprobantesMovimientosDeStockRowChangeEvent(((tpu_ComprobantesMovimientosDeStockRow)(e.Row)), e.Action));
                }
            }
            
            public void Removetpu_ComprobantesMovimientosDeStockRow(tpu_ComprobantesMovimientosDeStockRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tpu_ComprobantesMovimientosDeStockRow : DataRow {
            
            private tpu_ComprobantesMovimientosDeStockDataTable tabletpu_ComprobantesMovimientosDeStock;
            
            internal tpu_ComprobantesMovimientosDeStockRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tabletpu_ComprobantesMovimientosDeStock = ((tpu_ComprobantesMovimientosDeStockDataTable)(this.Table));
            }
            
            public string IdComprobante {
                get {
                    return ((string)(this[this.tabletpu_ComprobantesMovimientosDeStock.IdComprobanteColumn]));
                }
                set {
                    this[this.tabletpu_ComprobantesMovimientosDeStock.IdComprobanteColumn] = value;
                }
            }
            
            public string IdMovimientoDeStock {
                get {
                    return ((string)(this[this.tabletpu_ComprobantesMovimientosDeStock.IdMovimientoDeStockColumn]));
                }
                set {
                    this[this.tabletpu_ComprobantesMovimientosDeStock.IdMovimientoDeStockColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    try {
                        return ((System.DateTime)(this[this.tabletpu_ComprobantesMovimientosDeStock.FechaCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletpu_ComprobantesMovimientosDeStock.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    try {
                        return ((long)(this[this.tabletpu_ComprobantesMovimientosDeStock.IdConexionCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletpu_ComprobantesMovimientosDeStock.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tabletpu_ComprobantesMovimientosDeStock.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletpu_ComprobantesMovimientosDeStock.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tabletpu_ComprobantesMovimientosDeStock.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletpu_ComprobantesMovimientosDeStock.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public long IdReservado {
                get {
                    try {
                        return ((long)(this[this.tabletpu_ComprobantesMovimientosDeStock.IdReservadoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletpu_ComprobantesMovimientosDeStock.IdReservadoColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tabletpu_ComprobantesMovimientosDeStock.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletpu_ComprobantesMovimientosDeStock.RowIdColumn] = value;
                }
            }
            
            public long IdEmpresa {
                get {
                    try {
                        return ((long)(this[this.tabletpu_ComprobantesMovimientosDeStock.IdEmpresaColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletpu_ComprobantesMovimientosDeStock.IdEmpresaColumn] = value;
                }
            }
            
            public long IdSucursal {
                get {
                    try {
                        return ((long)(this[this.tabletpu_ComprobantesMovimientosDeStock.IdSucursalColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletpu_ComprobantesMovimientosDeStock.IdSucursalColumn] = value;
                }
            }
            
            public bool IsFechaCreacionNull() {
                return this.IsNull(this.tabletpu_ComprobantesMovimientosDeStock.FechaCreacionColumn);
            }
            
            public void SetFechaCreacionNull() {
                this[this.tabletpu_ComprobantesMovimientosDeStock.FechaCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionCreacionNull() {
                return this.IsNull(this.tabletpu_ComprobantesMovimientosDeStock.IdConexionCreacionColumn);
            }
            
            public void SetIdConexionCreacionNull() {
                this[this.tabletpu_ComprobantesMovimientosDeStock.IdConexionCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tabletpu_ComprobantesMovimientosDeStock.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tabletpu_ComprobantesMovimientosDeStock.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tabletpu_ComprobantesMovimientosDeStock.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tabletpu_ComprobantesMovimientosDeStock.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdReservadoNull() {
                return this.IsNull(this.tabletpu_ComprobantesMovimientosDeStock.IdReservadoColumn);
            }
            
            public void SetIdReservadoNull() {
                this[this.tabletpu_ComprobantesMovimientosDeStock.IdReservadoColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tabletpu_ComprobantesMovimientosDeStock.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tabletpu_ComprobantesMovimientosDeStock.RowIdColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdEmpresaNull() {
                return this.IsNull(this.tabletpu_ComprobantesMovimientosDeStock.IdEmpresaColumn);
            }
            
            public void SetIdEmpresaNull() {
                this[this.tabletpu_ComprobantesMovimientosDeStock.IdEmpresaColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdSucursalNull() {
                return this.IsNull(this.tabletpu_ComprobantesMovimientosDeStock.IdSucursalColumn);
            }
            
            public void SetIdSucursalNull() {
                this[this.tabletpu_ComprobantesMovimientosDeStock.IdSucursalColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tpu_ComprobantesMovimientosDeStockRowChangeEvent : EventArgs {
            
            private tpu_ComprobantesMovimientosDeStockRow eventRow;
            
            private DataRowAction eventAction;
            
            public tpu_ComprobantesMovimientosDeStockRowChangeEvent(tpu_ComprobantesMovimientosDeStockRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public tpu_ComprobantesMovimientosDeStockRow Row {
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
