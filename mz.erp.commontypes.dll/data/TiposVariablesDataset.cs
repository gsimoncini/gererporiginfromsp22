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
    public class TiposVariablesDataset : DataSet {
        
        private TiposVariablesDataTable tableTiposVariables;
        
        public TiposVariablesDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected TiposVariablesDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["TiposVariables"] != null)) {
                    this.Tables.Add(new TiposVariablesDataTable(ds.Tables["TiposVariables"]));
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
        public TiposVariablesDataTable TiposVariables {
            get {
                return this.tableTiposVariables;
            }
        }
        
        public override DataSet Clone() {
            TiposVariablesDataset cln = ((TiposVariablesDataset)(base.Clone()));
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
            if ((ds.Tables["TiposVariables"] != null)) {
                this.Tables.Add(new TiposVariablesDataTable(ds.Tables["TiposVariables"]));
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
            this.tableTiposVariables = ((TiposVariablesDataTable)(this.Tables["TiposVariables"]));
            if ((this.tableTiposVariables != null)) {
                this.tableTiposVariables.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "TiposVariablesDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/TiposVariablesDataset.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tableTiposVariables = new TiposVariablesDataTable();
            this.Tables.Add(this.tableTiposVariables);
        }
        
        private bool ShouldSerializeTiposVariables() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void TiposVariablesRowChangeEventHandler(object sender, TiposVariablesRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class TiposVariablesDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdTipoVariable;
            
            private DataColumn columnDescripcion;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnRowId;
            
            internal TiposVariablesDataTable() : 
                    base("TiposVariables") {
                this.InitClass();
            }
            
            internal TiposVariablesDataTable(DataTable table) : 
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
            
            internal DataColumn IdTipoVariableColumn {
                get {
                    return this.columnIdTipoVariable;
                }
            }
            
            internal DataColumn DescripcionColumn {
                get {
                    return this.columnDescripcion;
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
            
            public TiposVariablesRow this[int index] {
                get {
                    return ((TiposVariablesRow)(this.Rows[index]));
                }
            }
            
            public event TiposVariablesRowChangeEventHandler TiposVariablesRowChanged;
            
            public event TiposVariablesRowChangeEventHandler TiposVariablesRowChanging;
            
            public event TiposVariablesRowChangeEventHandler TiposVariablesRowDeleted;
            
            public event TiposVariablesRowChangeEventHandler TiposVariablesRowDeleting;
            
            public void AddTiposVariablesRow(TiposVariablesRow row) {
                this.Rows.Add(row);
            }
            
            public TiposVariablesRow AddTiposVariablesRow(long IdTipoVariable, string Descripcion, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, System.Guid RowId) {
                TiposVariablesRow rowTiposVariablesRow = ((TiposVariablesRow)(this.NewRow()));
                rowTiposVariablesRow.ItemArray = new object[] {
                        IdTipoVariable,
                        Descripcion,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        RowId};
                this.Rows.Add(rowTiposVariablesRow);
                return rowTiposVariablesRow;
            }
            
            public TiposVariablesRow FindByIdTipoVariable(long IdTipoVariable) {
                return ((TiposVariablesRow)(this.Rows.Find(new object[] {
                            IdTipoVariable})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                TiposVariablesDataTable cln = ((TiposVariablesDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new TiposVariablesDataTable();
            }
            
            internal void InitVars() {
                this.columnIdTipoVariable = this.Columns["IdTipoVariable"];
                this.columnDescripcion = this.Columns["Descripcion"];
                this.columnFechaCreacion = this.Columns["FechaCreacion"];
                this.columnIdConexionCreacion = this.Columns["IdConexionCreacion"];
                this.columnUltimaModificacion = this.Columns["UltimaModificacion"];
                this.columnIdConexionUltimaModificacion = this.Columns["IdConexionUltimaModificacion"];
                this.columnRowId = this.Columns["RowId"];
            }
            
            private void InitClass() {
                this.columnIdTipoVariable = new DataColumn("IdTipoVariable", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdTipoVariable);
                this.columnDescripcion = new DataColumn("Descripcion", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnDescripcion);
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
                this.Constraints.Add(new UniqueConstraint("TiposVariablesDatasetKey1", new DataColumn[] {
                                this.columnIdTipoVariable}, true));
                this.columnIdTipoVariable.AllowDBNull = false;
                this.columnIdTipoVariable.Unique = true;
                this.columnFechaCreacion.AllowDBNull = false;
                this.columnIdConexionCreacion.AllowDBNull = false;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public TiposVariablesRow NewTiposVariablesRow() {
                return ((TiposVariablesRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new TiposVariablesRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(TiposVariablesRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.TiposVariablesRowChanged != null)) {
                    this.TiposVariablesRowChanged(this, new TiposVariablesRowChangeEvent(((TiposVariablesRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.TiposVariablesRowChanging != null)) {
                    this.TiposVariablesRowChanging(this, new TiposVariablesRowChangeEvent(((TiposVariablesRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.TiposVariablesRowDeleted != null)) {
                    this.TiposVariablesRowDeleted(this, new TiposVariablesRowChangeEvent(((TiposVariablesRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.TiposVariablesRowDeleting != null)) {
                    this.TiposVariablesRowDeleting(this, new TiposVariablesRowChangeEvent(((TiposVariablesRow)(e.Row)), e.Action));
                }
            }
            
            public void RemoveTiposVariablesRow(TiposVariablesRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class TiposVariablesRow : DataRow {
            
            private TiposVariablesDataTable tableTiposVariables;
            
            internal TiposVariablesRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tableTiposVariables = ((TiposVariablesDataTable)(this.Table));
            }
            
            public long IdTipoVariable {
                get {
                    return ((long)(this[this.tableTiposVariables.IdTipoVariableColumn]));
                }
                set {
                    this[this.tableTiposVariables.IdTipoVariableColumn] = value;
                }
            }
            
            public string Descripcion {
                get {
                    try {
                        return ((string)(this[this.tableTiposVariables.DescripcionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tableTiposVariables.DescripcionColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    return ((System.DateTime)(this[this.tableTiposVariables.FechaCreacionColumn]));
                }
                set {
                    this[this.tableTiposVariables.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    return ((long)(this[this.tableTiposVariables.IdConexionCreacionColumn]));
                }
                set {
                    this[this.tableTiposVariables.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tableTiposVariables.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tableTiposVariables.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tableTiposVariables.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tableTiposVariables.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tableTiposVariables.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tableTiposVariables.RowIdColumn] = value;
                }
            }
            
            public bool IsDescripcionNull() {
                return this.IsNull(this.tableTiposVariables.DescripcionColumn);
            }
            
            public void SetDescripcionNull() {
                this[this.tableTiposVariables.DescripcionColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tableTiposVariables.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tableTiposVariables.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tableTiposVariables.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tableTiposVariables.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tableTiposVariables.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tableTiposVariables.RowIdColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class TiposVariablesRowChangeEvent : EventArgs {
            
            private TiposVariablesRow eventRow;
            
            private DataRowAction eventAction;
            
            public TiposVariablesRowChangeEvent(TiposVariablesRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public TiposVariablesRow Row {
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
