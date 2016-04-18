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
    public class VariablesEmpresasDataset : DataSet {
        
        private VariablesEmpresasDataTable tableVariablesEmpresas;
        
        public VariablesEmpresasDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected VariablesEmpresasDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["VariablesEmpresas"] != null)) {
                    this.Tables.Add(new VariablesEmpresasDataTable(ds.Tables["VariablesEmpresas"]));
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
        public VariablesEmpresasDataTable VariablesEmpresas {
            get {
                return this.tableVariablesEmpresas;
            }
        }
        
        public override DataSet Clone() {
            VariablesEmpresasDataset cln = ((VariablesEmpresasDataset)(base.Clone()));
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
            if ((ds.Tables["VariablesEmpresas"] != null)) {
                this.Tables.Add(new VariablesEmpresasDataTable(ds.Tables["VariablesEmpresas"]));
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
            this.tableVariablesEmpresas = ((VariablesEmpresasDataTable)(this.Tables["VariablesEmpresas"]));
            if ((this.tableVariablesEmpresas != null)) {
                this.tableVariablesEmpresas.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "VariablesEmpresasDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/VariablesEmpresasDataset.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tableVariablesEmpresas = new VariablesEmpresasDataTable();
            this.Tables.Add(this.tableVariablesEmpresas);
        }
        
        private bool ShouldSerializeVariablesEmpresas() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void VariablesEmpresasRowChangeEventHandler(object sender, VariablesEmpresasRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class VariablesEmpresasDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdVariable;
            
            private DataColumn columnIdEmpresa;
            
            private DataColumn columnValor;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnRowId;
            
            internal VariablesEmpresasDataTable() : 
                    base("VariablesEmpresas") {
                this.InitClass();
            }
            
            internal VariablesEmpresasDataTable(DataTable table) : 
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
            
            internal DataColumn IdVariableColumn {
                get {
                    return this.columnIdVariable;
                }
            }
            
            internal DataColumn IdEmpresaColumn {
                get {
                    return this.columnIdEmpresa;
                }
            }
            
            internal DataColumn ValorColumn {
                get {
                    return this.columnValor;
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
            
            public VariablesEmpresasRow this[int index] {
                get {
                    return ((VariablesEmpresasRow)(this.Rows[index]));
                }
            }
            
            public event VariablesEmpresasRowChangeEventHandler VariablesEmpresasRowChanged;
            
            public event VariablesEmpresasRowChangeEventHandler VariablesEmpresasRowChanging;
            
            public event VariablesEmpresasRowChangeEventHandler VariablesEmpresasRowDeleted;
            
            public event VariablesEmpresasRowChangeEventHandler VariablesEmpresasRowDeleting;
            
            public void AddVariablesEmpresasRow(VariablesEmpresasRow row) {
                this.Rows.Add(row);
            }
            
            public VariablesEmpresasRow AddVariablesEmpresasRow(long IdVariable, long IdEmpresa, string Valor, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, System.Guid RowId) {
                VariablesEmpresasRow rowVariablesEmpresasRow = ((VariablesEmpresasRow)(this.NewRow()));
                rowVariablesEmpresasRow.ItemArray = new object[] {
                        IdVariable,
                        IdEmpresa,
                        Valor,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        RowId};
                this.Rows.Add(rowVariablesEmpresasRow);
                return rowVariablesEmpresasRow;
            }
            
            public VariablesEmpresasRow FindByIdVariableIdEmpresa(long IdVariable, long IdEmpresa) {
                return ((VariablesEmpresasRow)(this.Rows.Find(new object[] {
                            IdVariable,
                            IdEmpresa})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                VariablesEmpresasDataTable cln = ((VariablesEmpresasDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new VariablesEmpresasDataTable();
            }
            
            internal void InitVars() {
                this.columnIdVariable = this.Columns["IdVariable"];
                this.columnIdEmpresa = this.Columns["IdEmpresa"];
                this.columnValor = this.Columns["Valor"];
                this.columnFechaCreacion = this.Columns["FechaCreacion"];
                this.columnIdConexionCreacion = this.Columns["IdConexionCreacion"];
                this.columnUltimaModificacion = this.Columns["UltimaModificacion"];
                this.columnIdConexionUltimaModificacion = this.Columns["IdConexionUltimaModificacion"];
                this.columnRowId = this.Columns["RowId"];
            }
            
            private void InitClass() {
                this.columnIdVariable = new DataColumn("IdVariable", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdVariable);
                this.columnIdEmpresa = new DataColumn("IdEmpresa", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdEmpresa);
                this.columnValor = new DataColumn("Valor", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnValor);
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
                this.Constraints.Add(new UniqueConstraint("VariablesEmpresasDatasetKey1", new DataColumn[] {
                                this.columnIdVariable,
                                this.columnIdEmpresa}, true));
                this.columnIdVariable.AllowDBNull = false;
                this.columnIdEmpresa.AllowDBNull = false;
                this.columnFechaCreacion.AllowDBNull = false;
                this.columnIdConexionCreacion.AllowDBNull = false;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public VariablesEmpresasRow NewVariablesEmpresasRow() {
                return ((VariablesEmpresasRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new VariablesEmpresasRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(VariablesEmpresasRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.VariablesEmpresasRowChanged != null)) {
                    this.VariablesEmpresasRowChanged(this, new VariablesEmpresasRowChangeEvent(((VariablesEmpresasRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.VariablesEmpresasRowChanging != null)) {
                    this.VariablesEmpresasRowChanging(this, new VariablesEmpresasRowChangeEvent(((VariablesEmpresasRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.VariablesEmpresasRowDeleted != null)) {
                    this.VariablesEmpresasRowDeleted(this, new VariablesEmpresasRowChangeEvent(((VariablesEmpresasRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.VariablesEmpresasRowDeleting != null)) {
                    this.VariablesEmpresasRowDeleting(this, new VariablesEmpresasRowChangeEvent(((VariablesEmpresasRow)(e.Row)), e.Action));
                }
            }
            
            public void RemoveVariablesEmpresasRow(VariablesEmpresasRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class VariablesEmpresasRow : DataRow {
            
            private VariablesEmpresasDataTable tableVariablesEmpresas;
            
            internal VariablesEmpresasRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tableVariablesEmpresas = ((VariablesEmpresasDataTable)(this.Table));
            }
            
            public long IdVariable {
                get {
                    return ((long)(this[this.tableVariablesEmpresas.IdVariableColumn]));
                }
                set {
                    this[this.tableVariablesEmpresas.IdVariableColumn] = value;
                }
            }
            
            public long IdEmpresa {
                get {
                    return ((long)(this[this.tableVariablesEmpresas.IdEmpresaColumn]));
                }
                set {
                    this[this.tableVariablesEmpresas.IdEmpresaColumn] = value;
                }
            }
            
            public string Valor {
                get {
                    try {
                        return ((string)(this[this.tableVariablesEmpresas.ValorColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tableVariablesEmpresas.ValorColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    return ((System.DateTime)(this[this.tableVariablesEmpresas.FechaCreacionColumn]));
                }
                set {
                    this[this.tableVariablesEmpresas.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    return ((long)(this[this.tableVariablesEmpresas.IdConexionCreacionColumn]));
                }
                set {
                    this[this.tableVariablesEmpresas.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tableVariablesEmpresas.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tableVariablesEmpresas.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tableVariablesEmpresas.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tableVariablesEmpresas.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tableVariablesEmpresas.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tableVariablesEmpresas.RowIdColumn] = value;
                }
            }
            
            public bool IsValorNull() {
                return this.IsNull(this.tableVariablesEmpresas.ValorColumn);
            }
            
            public void SetValorNull() {
                this[this.tableVariablesEmpresas.ValorColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tableVariablesEmpresas.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tableVariablesEmpresas.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tableVariablesEmpresas.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tableVariablesEmpresas.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tableVariablesEmpresas.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tableVariablesEmpresas.RowIdColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class VariablesEmpresasRowChangeEvent : EventArgs {
            
            private VariablesEmpresasRow eventRow;
            
            private DataRowAction eventAction;
            
            public VariablesEmpresasRowChangeEvent(VariablesEmpresasRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public VariablesEmpresasRow Row {
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