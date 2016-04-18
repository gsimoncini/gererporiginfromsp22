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
    public class TiposRecursosDataset : DataSet {
        
        private TiposRecursosDataTable tableTiposRecursos;
        
        public TiposRecursosDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected TiposRecursosDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["TiposRecursos"] != null)) {
                    this.Tables.Add(new TiposRecursosDataTable(ds.Tables["TiposRecursos"]));
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
        public TiposRecursosDataTable TiposRecursos {
            get {
                return this.tableTiposRecursos;
            }
        }
        
        public override DataSet Clone() {
            TiposRecursosDataset cln = ((TiposRecursosDataset)(base.Clone()));
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
            if ((ds.Tables["TiposRecursos"] != null)) {
                this.Tables.Add(new TiposRecursosDataTable(ds.Tables["TiposRecursos"]));
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
            this.tableTiposRecursos = ((TiposRecursosDataTable)(this.Tables["TiposRecursos"]));
            if ((this.tableTiposRecursos != null)) {
                this.tableTiposRecursos.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "TiposRecursosDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/TiposRecursosDataset.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tableTiposRecursos = new TiposRecursosDataTable();
            this.Tables.Add(this.tableTiposRecursos);
        }
        
        private bool ShouldSerializeTiposRecursos() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void TiposRecursosRowChangeEventHandler(object sender, TiposRecursosRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class TiposRecursosDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdTipoRecurso;
            
            private DataColumn columnDescripcion;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnRowId;
            
            internal TiposRecursosDataTable() : 
                    base("TiposRecursos") {
                this.InitClass();
            }
            
            internal TiposRecursosDataTable(DataTable table) : 
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
            
            internal DataColumn IdTipoRecursoColumn {
                get {
                    return this.columnIdTipoRecurso;
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
            
            public TiposRecursosRow this[int index] {
                get {
                    return ((TiposRecursosRow)(this.Rows[index]));
                }
            }
            
            public event TiposRecursosRowChangeEventHandler TiposRecursosRowChanged;
            
            public event TiposRecursosRowChangeEventHandler TiposRecursosRowChanging;
            
            public event TiposRecursosRowChangeEventHandler TiposRecursosRowDeleted;
            
            public event TiposRecursosRowChangeEventHandler TiposRecursosRowDeleting;
            
            public void AddTiposRecursosRow(TiposRecursosRow row) {
                this.Rows.Add(row);
            }
            
            public TiposRecursosRow AddTiposRecursosRow(long IdTipoRecurso, string Descripcion, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, System.Guid RowId) {
                TiposRecursosRow rowTiposRecursosRow = ((TiposRecursosRow)(this.NewRow()));
                rowTiposRecursosRow.ItemArray = new object[] {
                        IdTipoRecurso,
                        Descripcion,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        RowId};
                this.Rows.Add(rowTiposRecursosRow);
                return rowTiposRecursosRow;
            }
            
            public TiposRecursosRow FindByIdTipoRecurso(long IdTipoRecurso) {
                return ((TiposRecursosRow)(this.Rows.Find(new object[] {
                            IdTipoRecurso})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                TiposRecursosDataTable cln = ((TiposRecursosDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new TiposRecursosDataTable();
            }
            
            internal void InitVars() {
                this.columnIdTipoRecurso = this.Columns["IdTipoRecurso"];
                this.columnDescripcion = this.Columns["Descripcion"];
                this.columnFechaCreacion = this.Columns["FechaCreacion"];
                this.columnIdConexionCreacion = this.Columns["IdConexionCreacion"];
                this.columnUltimaModificacion = this.Columns["UltimaModificacion"];
                this.columnIdConexionUltimaModificacion = this.Columns["IdConexionUltimaModificacion"];
                this.columnRowId = this.Columns["RowId"];
            }
            
            private void InitClass() {
                this.columnIdTipoRecurso = new DataColumn("IdTipoRecurso", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdTipoRecurso);
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
                this.Constraints.Add(new UniqueConstraint("TiposRecursosDatasetKey1", new DataColumn[] {
                                this.columnIdTipoRecurso}, true));
                this.columnIdTipoRecurso.AllowDBNull = false;
                this.columnIdTipoRecurso.Unique = true;
                this.columnFechaCreacion.AllowDBNull = false;
                this.columnIdConexionCreacion.AllowDBNull = false;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public TiposRecursosRow NewTiposRecursosRow() {
                return ((TiposRecursosRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new TiposRecursosRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(TiposRecursosRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.TiposRecursosRowChanged != null)) {
                    this.TiposRecursosRowChanged(this, new TiposRecursosRowChangeEvent(((TiposRecursosRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.TiposRecursosRowChanging != null)) {
                    this.TiposRecursosRowChanging(this, new TiposRecursosRowChangeEvent(((TiposRecursosRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.TiposRecursosRowDeleted != null)) {
                    this.TiposRecursosRowDeleted(this, new TiposRecursosRowChangeEvent(((TiposRecursosRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.TiposRecursosRowDeleting != null)) {
                    this.TiposRecursosRowDeleting(this, new TiposRecursosRowChangeEvent(((TiposRecursosRow)(e.Row)), e.Action));
                }
            }
            
            public void RemoveTiposRecursosRow(TiposRecursosRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class TiposRecursosRow : DataRow {
            
            private TiposRecursosDataTable tableTiposRecursos;
            
            internal TiposRecursosRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tableTiposRecursos = ((TiposRecursosDataTable)(this.Table));
            }
            
            public long IdTipoRecurso {
                get {
                    return ((long)(this[this.tableTiposRecursos.IdTipoRecursoColumn]));
                }
                set {
                    this[this.tableTiposRecursos.IdTipoRecursoColumn] = value;
                }
            }
            
            public string Descripcion {
                get {
                    try {
                        return ((string)(this[this.tableTiposRecursos.DescripcionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tableTiposRecursos.DescripcionColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    return ((System.DateTime)(this[this.tableTiposRecursos.FechaCreacionColumn]));
                }
                set {
                    this[this.tableTiposRecursos.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    return ((long)(this[this.tableTiposRecursos.IdConexionCreacionColumn]));
                }
                set {
                    this[this.tableTiposRecursos.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tableTiposRecursos.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tableTiposRecursos.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tableTiposRecursos.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tableTiposRecursos.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tableTiposRecursos.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tableTiposRecursos.RowIdColumn] = value;
                }
            }
            
            public bool IsDescripcionNull() {
                return this.IsNull(this.tableTiposRecursos.DescripcionColumn);
            }
            
            public void SetDescripcionNull() {
                this[this.tableTiposRecursos.DescripcionColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tableTiposRecursos.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tableTiposRecursos.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tableTiposRecursos.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tableTiposRecursos.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tableTiposRecursos.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tableTiposRecursos.RowIdColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class TiposRecursosRowChangeEvent : EventArgs {
            
            private TiposRecursosRow eventRow;
            
            private DataRowAction eventAction;
            
            public TiposRecursosRowChangeEvent(TiposRecursosRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public TiposRecursosRow Row {
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
