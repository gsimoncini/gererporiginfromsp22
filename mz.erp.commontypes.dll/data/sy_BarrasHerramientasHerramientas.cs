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
    public class sy_BarrasHerramientasHerramientasDataset : DataSet {
        
        private sy_BarrasHerramientasHerramientasDataTable tablesy_BarrasHerramientasHerramientas;
        
        public sy_BarrasHerramientasHerramientasDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected sy_BarrasHerramientasHerramientasDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["sy_BarrasHerramientasHerramientas"] != null)) {
                    this.Tables.Add(new sy_BarrasHerramientasHerramientasDataTable(ds.Tables["sy_BarrasHerramientasHerramientas"]));
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
        public sy_BarrasHerramientasHerramientasDataTable sy_BarrasHerramientasHerramientas {
            get {
                return this.tablesy_BarrasHerramientasHerramientas;
            }
        }
        
        public override DataSet Clone() {
            sy_BarrasHerramientasHerramientasDataset cln = ((sy_BarrasHerramientasHerramientasDataset)(base.Clone()));
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
            if ((ds.Tables["sy_BarrasHerramientasHerramientas"] != null)) {
                this.Tables.Add(new sy_BarrasHerramientasHerramientasDataTable(ds.Tables["sy_BarrasHerramientasHerramientas"]));
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
            this.tablesy_BarrasHerramientasHerramientas = ((sy_BarrasHerramientasHerramientasDataTable)(this.Tables["sy_BarrasHerramientasHerramientas"]));
            if ((this.tablesy_BarrasHerramientasHerramientas != null)) {
                this.tablesy_BarrasHerramientasHerramientas.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "sy_BarrasHerramientasHerramientasDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/sy_BarrasHerramientasHerramientas.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tablesy_BarrasHerramientasHerramientas = new sy_BarrasHerramientasHerramientasDataTable();
            this.Tables.Add(this.tablesy_BarrasHerramientasHerramientas);
        }
        
        private bool ShouldSerializesy_BarrasHerramientasHerramientas() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void sy_BarrasHerramientasHerramientasRowChangeEventHandler(object sender, sy_BarrasHerramientasHerramientasRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class sy_BarrasHerramientasHerramientasDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdBarraHerramienta;
            
            private DataColumn columnIdHerramienta;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnRowId;
            
            internal sy_BarrasHerramientasHerramientasDataTable() : 
                    base("sy_BarrasHerramientasHerramientas") {
                this.InitClass();
            }
            
            internal sy_BarrasHerramientasHerramientasDataTable(DataTable table) : 
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
            
            internal DataColumn IdBarraHerramientaColumn {
                get {
                    return this.columnIdBarraHerramienta;
                }
            }
            
            internal DataColumn IdHerramientaColumn {
                get {
                    return this.columnIdHerramienta;
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
            
            internal DataColumn RowIdColumn {
                get {
                    return this.columnRowId;
                }
            }
            
            public sy_BarrasHerramientasHerramientasRow this[int index] {
                get {
                    return ((sy_BarrasHerramientasHerramientasRow)(this.Rows[index]));
                }
            }
            
            public event sy_BarrasHerramientasHerramientasRowChangeEventHandler sy_BarrasHerramientasHerramientasRowChanged;
            
            public event sy_BarrasHerramientasHerramientasRowChangeEventHandler sy_BarrasHerramientasHerramientasRowChanging;
            
            public event sy_BarrasHerramientasHerramientasRowChangeEventHandler sy_BarrasHerramientasHerramientasRowDeleted;
            
            public event sy_BarrasHerramientasHerramientasRowChangeEventHandler sy_BarrasHerramientasHerramientasRowDeleting;
            
            public void Addsy_BarrasHerramientasHerramientasRow(sy_BarrasHerramientasHerramientasRow row) {
                this.Rows.Add(row);
            }
            
            public sy_BarrasHerramientasHerramientasRow Addsy_BarrasHerramientasHerramientasRow(long IdBarraHerramienta, long IdHerramienta, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, System.Guid RowId) {
                sy_BarrasHerramientasHerramientasRow rowsy_BarrasHerramientasHerramientasRow = ((sy_BarrasHerramientasHerramientasRow)(this.NewRow()));
                rowsy_BarrasHerramientasHerramientasRow.ItemArray = new object[] {
                        IdBarraHerramienta,
                        IdHerramienta,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        RowId};
                this.Rows.Add(rowsy_BarrasHerramientasHerramientasRow);
                return rowsy_BarrasHerramientasHerramientasRow;
            }
            
            public sy_BarrasHerramientasHerramientasRow FindByIdBarraHerramientaIdHerramienta(long IdBarraHerramienta, long IdHerramienta) {
                return ((sy_BarrasHerramientasHerramientasRow)(this.Rows.Find(new object[] {
                            IdBarraHerramienta,
                            IdHerramienta})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                sy_BarrasHerramientasHerramientasDataTable cln = ((sy_BarrasHerramientasHerramientasDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new sy_BarrasHerramientasHerramientasDataTable();
            }
            
            internal void InitVars() {
                this.columnIdBarraHerramienta = this.Columns["IdBarraHerramienta"];
                this.columnIdHerramienta = this.Columns["IdHerramienta"];
                this.columnFechaCreacion = this.Columns["FechaCreacion"];
                this.columnIdConexionCreacion = this.Columns["IdConexionCreacion"];
                this.columnUltimaModificacion = this.Columns["UltimaModificacion"];
                this.columnIdConexionUltimaModificacion = this.Columns["IdConexionUltimaModificacion"];
                this.columnRowId = this.Columns["RowId"];
            }
            
            private void InitClass() {
                this.columnIdBarraHerramienta = new DataColumn("IdBarraHerramienta", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdBarraHerramienta);
                this.columnIdHerramienta = new DataColumn("IdHerramienta", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdHerramienta);
                this.columnFechaCreacion = new DataColumn("FechaCreacion", typeof(System.DateTime), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnFechaCreacion);
                this.columnIdConexionCreacion = new DataColumn("IdConexionCreacion", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdConexionCreacion);
                this.columnUltimaModificacion = new DataColumn("UltimaModificacion", typeof(System.Byte[]), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnUltimaModificacion);
                this.columnIdConexionUltimaModificacion = new DataColumn("IdConexionUltimaModificacion", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdConexionUltimaModificacion);
                this.columnRowId = new DataColumn("RowId", typeof(System.Guid), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnRowId);
                this.Constraints.Add(new UniqueConstraint("sy_BarrasHerramientasHerramientasKey1", new DataColumn[] {
                                this.columnIdBarraHerramienta,
                                this.columnIdHerramienta}, true));
                this.columnIdBarraHerramienta.AllowDBNull = false;
                this.columnIdHerramienta.AllowDBNull = false;
                this.columnFechaCreacion.AllowDBNull = false;
                this.columnIdConexionCreacion.AllowDBNull = false;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public sy_BarrasHerramientasHerramientasRow Newsy_BarrasHerramientasHerramientasRow() {
                return ((sy_BarrasHerramientasHerramientasRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new sy_BarrasHerramientasHerramientasRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(sy_BarrasHerramientasHerramientasRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.sy_BarrasHerramientasHerramientasRowChanged != null)) {
                    this.sy_BarrasHerramientasHerramientasRowChanged(this, new sy_BarrasHerramientasHerramientasRowChangeEvent(((sy_BarrasHerramientasHerramientasRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.sy_BarrasHerramientasHerramientasRowChanging != null)) {
                    this.sy_BarrasHerramientasHerramientasRowChanging(this, new sy_BarrasHerramientasHerramientasRowChangeEvent(((sy_BarrasHerramientasHerramientasRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.sy_BarrasHerramientasHerramientasRowDeleted != null)) {
                    this.sy_BarrasHerramientasHerramientasRowDeleted(this, new sy_BarrasHerramientasHerramientasRowChangeEvent(((sy_BarrasHerramientasHerramientasRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.sy_BarrasHerramientasHerramientasRowDeleting != null)) {
                    this.sy_BarrasHerramientasHerramientasRowDeleting(this, new sy_BarrasHerramientasHerramientasRowChangeEvent(((sy_BarrasHerramientasHerramientasRow)(e.Row)), e.Action));
                }
            }
            
            public void Removesy_BarrasHerramientasHerramientasRow(sy_BarrasHerramientasHerramientasRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class sy_BarrasHerramientasHerramientasRow : DataRow {
            
            private sy_BarrasHerramientasHerramientasDataTable tablesy_BarrasHerramientasHerramientas;
            
            internal sy_BarrasHerramientasHerramientasRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tablesy_BarrasHerramientasHerramientas = ((sy_BarrasHerramientasHerramientasDataTable)(this.Table));
            }
            
            public long IdBarraHerramienta {
                get {
                    return ((long)(this[this.tablesy_BarrasHerramientasHerramientas.IdBarraHerramientaColumn]));
                }
                set {
                    this[this.tablesy_BarrasHerramientasHerramientas.IdBarraHerramientaColumn] = value;
                }
            }
            
            public long IdHerramienta {
                get {
                    return ((long)(this[this.tablesy_BarrasHerramientasHerramientas.IdHerramientaColumn]));
                }
                set {
                    this[this.tablesy_BarrasHerramientasHerramientas.IdHerramientaColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    return ((System.DateTime)(this[this.tablesy_BarrasHerramientasHerramientas.FechaCreacionColumn]));
                }
                set {
                    this[this.tablesy_BarrasHerramientasHerramientas.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    return ((long)(this[this.tablesy_BarrasHerramientasHerramientas.IdConexionCreacionColumn]));
                }
                set {
                    this[this.tablesy_BarrasHerramientasHerramientas.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tablesy_BarrasHerramientasHerramientas.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_BarrasHerramientasHerramientas.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tablesy_BarrasHerramientasHerramientas.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_BarrasHerramientasHerramientas.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tablesy_BarrasHerramientasHerramientas.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_BarrasHerramientasHerramientas.RowIdColumn] = value;
                }
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tablesy_BarrasHerramientasHerramientas.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tablesy_BarrasHerramientasHerramientas.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tablesy_BarrasHerramientasHerramientas.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tablesy_BarrasHerramientasHerramientas.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tablesy_BarrasHerramientasHerramientas.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tablesy_BarrasHerramientasHerramientas.RowIdColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class sy_BarrasHerramientasHerramientasRowChangeEvent : EventArgs {
            
            private sy_BarrasHerramientasHerramientasRow eventRow;
            
            private DataRowAction eventAction;
            
            public sy_BarrasHerramientasHerramientasRowChangeEvent(sy_BarrasHerramientasHerramientasRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public sy_BarrasHerramientasHerramientasRow Row {
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