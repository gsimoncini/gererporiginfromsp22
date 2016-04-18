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
    public class GruposVariablesExDataset : DataSet {
        
        private GruposVariablesDataTable tableGruposVariables;
        
        public GruposVariablesExDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected GruposVariablesExDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["GruposVariables"] != null)) {
                    this.Tables.Add(new GruposVariablesDataTable(ds.Tables["GruposVariables"]));
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
        public GruposVariablesDataTable GruposVariables {
            get {
                return this.tableGruposVariables;
            }
        }
        
        public override DataSet Clone() {
            GruposVariablesExDataset cln = ((GruposVariablesExDataset)(base.Clone()));
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
            if ((ds.Tables["GruposVariables"] != null)) {
                this.Tables.Add(new GruposVariablesDataTable(ds.Tables["GruposVariables"]));
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
            this.tableGruposVariables = ((GruposVariablesDataTable)(this.Tables["GruposVariables"]));
            if ((this.tableGruposVariables != null)) {
                this.tableGruposVariables.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "GruposVariablesExDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/GruposVariablesExDataset.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tableGruposVariables = new GruposVariablesDataTable();
            this.Tables.Add(this.tableGruposVariables);
        }
        
        private bool ShouldSerializeGruposVariables() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void GruposVariablesRowChangeEventHandler(object sender, GruposVariablesRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class GruposVariablesDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdGrupo;
            
            private DataColumn columnIdVariable;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnRowId;
            
            internal GruposVariablesDataTable() : 
                    base("GruposVariables") {
                this.InitClass();
            }
            
            internal GruposVariablesDataTable(DataTable table) : 
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
            
            internal DataColumn IdGrupoColumn {
                get {
                    return this.columnIdGrupo;
                }
            }
            
            internal DataColumn IdVariableColumn {
                get {
                    return this.columnIdVariable;
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
            
            public GruposVariablesRow this[int index] {
                get {
                    return ((GruposVariablesRow)(this.Rows[index]));
                }
            }
            
            public event GruposVariablesRowChangeEventHandler GruposVariablesRowChanged;
            
            public event GruposVariablesRowChangeEventHandler GruposVariablesRowChanging;
            
            public event GruposVariablesRowChangeEventHandler GruposVariablesRowDeleted;
            
            public event GruposVariablesRowChangeEventHandler GruposVariablesRowDeleting;
            
            public void AddGruposVariablesRow(GruposVariablesRow row) {
                this.Rows.Add(row);
            }
            
            public GruposVariablesRow AddGruposVariablesRow(long IdGrupo, long IdVariable, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, System.Guid RowId) {
                GruposVariablesRow rowGruposVariablesRow = ((GruposVariablesRow)(this.NewRow()));
                rowGruposVariablesRow.ItemArray = new object[] {
                        IdGrupo,
                        IdVariable,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        RowId};
                this.Rows.Add(rowGruposVariablesRow);
                return rowGruposVariablesRow;
            }
            
            public GruposVariablesRow FindByIdGrupoIdVariable(long IdGrupo, long IdVariable) {
                return ((GruposVariablesRow)(this.Rows.Find(new object[] {
                            IdGrupo,
                            IdVariable})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                GruposVariablesDataTable cln = ((GruposVariablesDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new GruposVariablesDataTable();
            }
            
            internal void InitVars() {
                this.columnIdGrupo = this.Columns["IdGrupo"];
                this.columnIdVariable = this.Columns["IdVariable"];
                this.columnFechaCreacion = this.Columns["FechaCreacion"];
                this.columnIdConexionCreacion = this.Columns["IdConexionCreacion"];
                this.columnUltimaModificacion = this.Columns["UltimaModificacion"];
                this.columnIdConexionUltimaModificacion = this.Columns["IdConexionUltimaModificacion"];
                this.columnRowId = this.Columns["RowId"];
            }
            
            private void InitClass() {
                this.columnIdGrupo = new DataColumn("IdGrupo", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdGrupo);
                this.columnIdVariable = new DataColumn("IdVariable", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdVariable);
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
                this.Constraints.Add(new UniqueConstraint("GruposVariablesExDatasetKey1", new DataColumn[] {
                                this.columnIdGrupo,
                                this.columnIdVariable}, true));
                this.columnIdGrupo.AllowDBNull = false;
                this.columnIdVariable.AllowDBNull = false;
                this.columnFechaCreacion.AllowDBNull = false;
                this.columnIdConexionCreacion.AllowDBNull = false;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public GruposVariablesRow NewGruposVariablesRow() {
                return ((GruposVariablesRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new GruposVariablesRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(GruposVariablesRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.GruposVariablesRowChanged != null)) {
                    this.GruposVariablesRowChanged(this, new GruposVariablesRowChangeEvent(((GruposVariablesRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.GruposVariablesRowChanging != null)) {
                    this.GruposVariablesRowChanging(this, new GruposVariablesRowChangeEvent(((GruposVariablesRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.GruposVariablesRowDeleted != null)) {
                    this.GruposVariablesRowDeleted(this, new GruposVariablesRowChangeEvent(((GruposVariablesRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.GruposVariablesRowDeleting != null)) {
                    this.GruposVariablesRowDeleting(this, new GruposVariablesRowChangeEvent(((GruposVariablesRow)(e.Row)), e.Action));
                }
            }
            
            public void RemoveGruposVariablesRow(GruposVariablesRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class GruposVariablesRow : DataRow {
            
            private GruposVariablesDataTable tableGruposVariables;
            
            internal GruposVariablesRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tableGruposVariables = ((GruposVariablesDataTable)(this.Table));
            }
            
            public long IdGrupo {
                get {
                    return ((long)(this[this.tableGruposVariables.IdGrupoColumn]));
                }
                set {
                    this[this.tableGruposVariables.IdGrupoColumn] = value;
                }
            }
            
            public long IdVariable {
                get {
                    return ((long)(this[this.tableGruposVariables.IdVariableColumn]));
                }
                set {
                    this[this.tableGruposVariables.IdVariableColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    return ((System.DateTime)(this[this.tableGruposVariables.FechaCreacionColumn]));
                }
                set {
                    this[this.tableGruposVariables.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    return ((long)(this[this.tableGruposVariables.IdConexionCreacionColumn]));
                }
                set {
                    this[this.tableGruposVariables.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tableGruposVariables.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tableGruposVariables.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tableGruposVariables.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tableGruposVariables.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tableGruposVariables.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tableGruposVariables.RowIdColumn] = value;
                }
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tableGruposVariables.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tableGruposVariables.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tableGruposVariables.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tableGruposVariables.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tableGruposVariables.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tableGruposVariables.RowIdColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class GruposVariablesRowChangeEvent : EventArgs {
            
            private GruposVariablesRow eventRow;
            
            private DataRowAction eventAction;
            
            public GruposVariablesRowChangeEvent(GruposVariablesRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public GruposVariablesRow Row {
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
