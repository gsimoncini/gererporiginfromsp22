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
    public class PerfilesFuncionalidadesDataset : DataSet {
        
        private PerfilesFuncionalidadesDataTable tablePerfilesFuncionalidades;
        
        public PerfilesFuncionalidadesDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected PerfilesFuncionalidadesDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["PerfilesFuncionalidades"] != null)) {
                    this.Tables.Add(new PerfilesFuncionalidadesDataTable(ds.Tables["PerfilesFuncionalidades"]));
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
        public PerfilesFuncionalidadesDataTable PerfilesFuncionalidades {
            get {
                return this.tablePerfilesFuncionalidades;
            }
        }
        
        public override DataSet Clone() {
            PerfilesFuncionalidadesDataset cln = ((PerfilesFuncionalidadesDataset)(base.Clone()));
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
            if ((ds.Tables["PerfilesFuncionalidades"] != null)) {
                this.Tables.Add(new PerfilesFuncionalidadesDataTable(ds.Tables["PerfilesFuncionalidades"]));
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
            this.tablePerfilesFuncionalidades = ((PerfilesFuncionalidadesDataTable)(this.Tables["PerfilesFuncionalidades"]));
            if ((this.tablePerfilesFuncionalidades != null)) {
                this.tablePerfilesFuncionalidades.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "PerfilesFuncionalidadesDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/PerfilesFuncionalidadesDataset.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tablePerfilesFuncionalidades = new PerfilesFuncionalidadesDataTable();
            this.Tables.Add(this.tablePerfilesFuncionalidades);
        }
        
        private bool ShouldSerializePerfilesFuncionalidades() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void PerfilesFuncionalidadesRowChangeEventHandler(object sender, PerfilesFuncionalidadesRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class PerfilesFuncionalidadesDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdPerfil;
            
            private DataColumn columnIdFuncionalidad;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnRowId;
            
            internal PerfilesFuncionalidadesDataTable() : 
                    base("PerfilesFuncionalidades") {
                this.InitClass();
            }
            
            internal PerfilesFuncionalidadesDataTable(DataTable table) : 
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
            
            internal DataColumn IdPerfilColumn {
                get {
                    return this.columnIdPerfil;
                }
            }
            
            internal DataColumn IdFuncionalidadColumn {
                get {
                    return this.columnIdFuncionalidad;
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
            
            public PerfilesFuncionalidadesRow this[int index] {
                get {
                    return ((PerfilesFuncionalidadesRow)(this.Rows[index]));
                }
            }
            
            public event PerfilesFuncionalidadesRowChangeEventHandler PerfilesFuncionalidadesRowChanged;
            
            public event PerfilesFuncionalidadesRowChangeEventHandler PerfilesFuncionalidadesRowChanging;
            
            public event PerfilesFuncionalidadesRowChangeEventHandler PerfilesFuncionalidadesRowDeleted;
            
            public event PerfilesFuncionalidadesRowChangeEventHandler PerfilesFuncionalidadesRowDeleting;
            
            public void AddPerfilesFuncionalidadesRow(PerfilesFuncionalidadesRow row) {
                this.Rows.Add(row);
            }
            
            public PerfilesFuncionalidadesRow AddPerfilesFuncionalidadesRow(long IdPerfil, long IdFuncionalidad, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, System.Guid RowId) {
                PerfilesFuncionalidadesRow rowPerfilesFuncionalidadesRow = ((PerfilesFuncionalidadesRow)(this.NewRow()));
                rowPerfilesFuncionalidadesRow.ItemArray = new object[] {
                        IdPerfil,
                        IdFuncionalidad,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        RowId};
                this.Rows.Add(rowPerfilesFuncionalidadesRow);
                return rowPerfilesFuncionalidadesRow;
            }
            
            public PerfilesFuncionalidadesRow FindByIdPerfilIdFuncionalidad(long IdPerfil, long IdFuncionalidad) {
                return ((PerfilesFuncionalidadesRow)(this.Rows.Find(new object[] {
                            IdPerfil,
                            IdFuncionalidad})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                PerfilesFuncionalidadesDataTable cln = ((PerfilesFuncionalidadesDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new PerfilesFuncionalidadesDataTable();
            }
            
            internal void InitVars() {
                this.columnIdPerfil = this.Columns["IdPerfil"];
                this.columnIdFuncionalidad = this.Columns["IdFuncionalidad"];
                this.columnFechaCreacion = this.Columns["FechaCreacion"];
                this.columnIdConexionCreacion = this.Columns["IdConexionCreacion"];
                this.columnUltimaModificacion = this.Columns["UltimaModificacion"];
                this.columnIdConexionUltimaModificacion = this.Columns["IdConexionUltimaModificacion"];
                this.columnRowId = this.Columns["RowId"];
            }
            
            private void InitClass() {
                this.columnIdPerfil = new DataColumn("IdPerfil", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdPerfil);
                this.columnIdFuncionalidad = new DataColumn("IdFuncionalidad", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdFuncionalidad);
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
                this.Constraints.Add(new UniqueConstraint("PerfilesFuncionalidadesDatasetKey1", new DataColumn[] {
                                this.columnIdPerfil,
                                this.columnIdFuncionalidad}, true));
                this.columnIdPerfil.AllowDBNull = false;
                this.columnIdFuncionalidad.AllowDBNull = false;
                this.columnFechaCreacion.AllowDBNull = false;
                this.columnIdConexionCreacion.AllowDBNull = false;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public PerfilesFuncionalidadesRow NewPerfilesFuncionalidadesRow() {
                return ((PerfilesFuncionalidadesRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new PerfilesFuncionalidadesRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(PerfilesFuncionalidadesRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.PerfilesFuncionalidadesRowChanged != null)) {
                    this.PerfilesFuncionalidadesRowChanged(this, new PerfilesFuncionalidadesRowChangeEvent(((PerfilesFuncionalidadesRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.PerfilesFuncionalidadesRowChanging != null)) {
                    this.PerfilesFuncionalidadesRowChanging(this, new PerfilesFuncionalidadesRowChangeEvent(((PerfilesFuncionalidadesRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.PerfilesFuncionalidadesRowDeleted != null)) {
                    this.PerfilesFuncionalidadesRowDeleted(this, new PerfilesFuncionalidadesRowChangeEvent(((PerfilesFuncionalidadesRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.PerfilesFuncionalidadesRowDeleting != null)) {
                    this.PerfilesFuncionalidadesRowDeleting(this, new PerfilesFuncionalidadesRowChangeEvent(((PerfilesFuncionalidadesRow)(e.Row)), e.Action));
                }
            }
            
            public void RemovePerfilesFuncionalidadesRow(PerfilesFuncionalidadesRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class PerfilesFuncionalidadesRow : DataRow {
            
            private PerfilesFuncionalidadesDataTable tablePerfilesFuncionalidades;
            
            internal PerfilesFuncionalidadesRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tablePerfilesFuncionalidades = ((PerfilesFuncionalidadesDataTable)(this.Table));
            }
            
            public long IdPerfil {
                get {
                    return ((long)(this[this.tablePerfilesFuncionalidades.IdPerfilColumn]));
                }
                set {
                    this[this.tablePerfilesFuncionalidades.IdPerfilColumn] = value;
                }
            }
            
            public long IdFuncionalidad {
                get {
                    return ((long)(this[this.tablePerfilesFuncionalidades.IdFuncionalidadColumn]));
                }
                set {
                    this[this.tablePerfilesFuncionalidades.IdFuncionalidadColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    return ((System.DateTime)(this[this.tablePerfilesFuncionalidades.FechaCreacionColumn]));
                }
                set {
                    this[this.tablePerfilesFuncionalidades.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    return ((long)(this[this.tablePerfilesFuncionalidades.IdConexionCreacionColumn]));
                }
                set {
                    this[this.tablePerfilesFuncionalidades.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tablePerfilesFuncionalidades.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablePerfilesFuncionalidades.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tablePerfilesFuncionalidades.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablePerfilesFuncionalidades.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tablePerfilesFuncionalidades.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablePerfilesFuncionalidades.RowIdColumn] = value;
                }
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tablePerfilesFuncionalidades.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tablePerfilesFuncionalidades.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tablePerfilesFuncionalidades.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tablePerfilesFuncionalidades.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tablePerfilesFuncionalidades.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tablePerfilesFuncionalidades.RowIdColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class PerfilesFuncionalidadesRowChangeEvent : EventArgs {
            
            private PerfilesFuncionalidadesRow eventRow;
            
            private DataRowAction eventAction;
            
            public PerfilesFuncionalidadesRowChangeEvent(PerfilesFuncionalidadesRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public PerfilesFuncionalidadesRow Row {
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
