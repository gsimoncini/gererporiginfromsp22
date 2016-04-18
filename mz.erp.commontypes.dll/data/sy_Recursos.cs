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
    public class sy_RecursosDataset : DataSet {
        
        private sy_RecursosDataTable tablesy_Recursos;
        
        public sy_RecursosDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected sy_RecursosDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["sy_Recursos"] != null)) {
                    this.Tables.Add(new sy_RecursosDataTable(ds.Tables["sy_Recursos"]));
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
        public sy_RecursosDataTable sy_Recursos {
            get {
                return this.tablesy_Recursos;
            }
        }
        
        public override DataSet Clone() {
            sy_RecursosDataset cln = ((sy_RecursosDataset)(base.Clone()));
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
            if ((ds.Tables["sy_Recursos"] != null)) {
                this.Tables.Add(new sy_RecursosDataTable(ds.Tables["sy_Recursos"]));
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
            this.tablesy_Recursos = ((sy_RecursosDataTable)(this.Tables["sy_Recursos"]));
            if ((this.tablesy_Recursos != null)) {
                this.tablesy_Recursos.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "sy_RecursosDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/sy_Recursos.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tablesy_Recursos = new sy_RecursosDataTable();
            this.Tables.Add(this.tablesy_Recursos);
        }
        
        private bool ShouldSerializesy_Recursos() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void sy_RecursosRowChangeEventHandler(object sender, sy_RecursosRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class sy_RecursosDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdRecurso;
            
            private DataColumn columnDescripcion;
            
            private DataColumn columnDatos;
            
            private DataColumn columnIdTipoRecurso;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnRowId;
            
            internal sy_RecursosDataTable() : 
                    base("sy_Recursos") {
                this.InitClass();
            }
            
            internal sy_RecursosDataTable(DataTable table) : 
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
            
            internal DataColumn IdRecursoColumn {
                get {
                    return this.columnIdRecurso;
                }
            }
            
            internal DataColumn DescripcionColumn {
                get {
                    return this.columnDescripcion;
                }
            }
            
            internal DataColumn DatosColumn {
                get {
                    return this.columnDatos;
                }
            }
            
            internal DataColumn IdTipoRecursoColumn {
                get {
                    return this.columnIdTipoRecurso;
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
            
            public sy_RecursosRow this[int index] {
                get {
                    return ((sy_RecursosRow)(this.Rows[index]));
                }
            }
            
            public event sy_RecursosRowChangeEventHandler sy_RecursosRowChanged;
            
            public event sy_RecursosRowChangeEventHandler sy_RecursosRowChanging;
            
            public event sy_RecursosRowChangeEventHandler sy_RecursosRowDeleted;
            
            public event sy_RecursosRowChangeEventHandler sy_RecursosRowDeleting;
            
            public void Addsy_RecursosRow(sy_RecursosRow row) {
                this.Rows.Add(row);
            }
            
            public sy_RecursosRow Addsy_RecursosRow(long IdRecurso, string Descripcion, System.Byte[] Datos, long IdTipoRecurso, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, System.Guid RowId) {
                sy_RecursosRow rowsy_RecursosRow = ((sy_RecursosRow)(this.NewRow()));
                rowsy_RecursosRow.ItemArray = new object[] {
                        IdRecurso,
                        Descripcion,
                        Datos,
                        IdTipoRecurso,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        RowId};
                this.Rows.Add(rowsy_RecursosRow);
                return rowsy_RecursosRow;
            }
            
            public sy_RecursosRow FindByIdRecurso(long IdRecurso) {
                return ((sy_RecursosRow)(this.Rows.Find(new object[] {
                            IdRecurso})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                sy_RecursosDataTable cln = ((sy_RecursosDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new sy_RecursosDataTable();
            }
            
            internal void InitVars() {
                this.columnIdRecurso = this.Columns["IdRecurso"];
                this.columnDescripcion = this.Columns["Descripcion"];
                this.columnDatos = this.Columns["Datos"];
                this.columnIdTipoRecurso = this.Columns["IdTipoRecurso"];
                this.columnFechaCreacion = this.Columns["FechaCreacion"];
                this.columnIdConexionCreacion = this.Columns["IdConexionCreacion"];
                this.columnUltimaModificacion = this.Columns["UltimaModificacion"];
                this.columnIdConexionUltimaModificacion = this.Columns["IdConexionUltimaModificacion"];
                this.columnRowId = this.Columns["RowId"];
            }
            
            private void InitClass() {
                this.columnIdRecurso = new DataColumn("IdRecurso", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdRecurso);
                this.columnDescripcion = new DataColumn("Descripcion", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnDescripcion);
                this.columnDatos = new DataColumn("Datos", typeof(System.Byte[]), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnDatos);
                this.columnIdTipoRecurso = new DataColumn("IdTipoRecurso", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdTipoRecurso);
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
                this.Constraints.Add(new UniqueConstraint("sy_RecursosKey1", new DataColumn[] {
                                this.columnIdRecurso}, true));
                this.columnIdRecurso.AllowDBNull = false;
                this.columnIdRecurso.Unique = true;
                this.columnFechaCreacion.AllowDBNull = false;
                this.columnIdConexionCreacion.AllowDBNull = false;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public sy_RecursosRow Newsy_RecursosRow() {
                return ((sy_RecursosRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new sy_RecursosRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(sy_RecursosRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.sy_RecursosRowChanged != null)) {
                    this.sy_RecursosRowChanged(this, new sy_RecursosRowChangeEvent(((sy_RecursosRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.sy_RecursosRowChanging != null)) {
                    this.sy_RecursosRowChanging(this, new sy_RecursosRowChangeEvent(((sy_RecursosRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.sy_RecursosRowDeleted != null)) {
                    this.sy_RecursosRowDeleted(this, new sy_RecursosRowChangeEvent(((sy_RecursosRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.sy_RecursosRowDeleting != null)) {
                    this.sy_RecursosRowDeleting(this, new sy_RecursosRowChangeEvent(((sy_RecursosRow)(e.Row)), e.Action));
                }
            }
            
            public void Removesy_RecursosRow(sy_RecursosRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class sy_RecursosRow : DataRow {
            
            private sy_RecursosDataTable tablesy_Recursos;
            
            internal sy_RecursosRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tablesy_Recursos = ((sy_RecursosDataTable)(this.Table));
            }
            
            public long IdRecurso {
                get {
                    return ((long)(this[this.tablesy_Recursos.IdRecursoColumn]));
                }
                set {
                    this[this.tablesy_Recursos.IdRecursoColumn] = value;
                }
            }
            
            public string Descripcion {
                get {
                    try {
                        return ((string)(this[this.tablesy_Recursos.DescripcionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_Recursos.DescripcionColumn] = value;
                }
            }
            
            public System.Byte[] Datos {
                get {
                    try {
                        return ((System.Byte[])(this[this.tablesy_Recursos.DatosColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_Recursos.DatosColumn] = value;
                }
            }
            
            public long IdTipoRecurso {
                get {
                    try {
                        return ((long)(this[this.tablesy_Recursos.IdTipoRecursoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_Recursos.IdTipoRecursoColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    return ((System.DateTime)(this[this.tablesy_Recursos.FechaCreacionColumn]));
                }
                set {
                    this[this.tablesy_Recursos.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    return ((long)(this[this.tablesy_Recursos.IdConexionCreacionColumn]));
                }
                set {
                    this[this.tablesy_Recursos.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tablesy_Recursos.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_Recursos.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tablesy_Recursos.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_Recursos.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tablesy_Recursos.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_Recursos.RowIdColumn] = value;
                }
            }
            
            public bool IsDescripcionNull() {
                return this.IsNull(this.tablesy_Recursos.DescripcionColumn);
            }
            
            public void SetDescripcionNull() {
                this[this.tablesy_Recursos.DescripcionColumn] = System.Convert.DBNull;
            }
            
            public bool IsDatosNull() {
                return this.IsNull(this.tablesy_Recursos.DatosColumn);
            }
            
            public void SetDatosNull() {
                this[this.tablesy_Recursos.DatosColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdTipoRecursoNull() {
                return this.IsNull(this.tablesy_Recursos.IdTipoRecursoColumn);
            }
            
            public void SetIdTipoRecursoNull() {
                this[this.tablesy_Recursos.IdTipoRecursoColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tablesy_Recursos.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tablesy_Recursos.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tablesy_Recursos.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tablesy_Recursos.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tablesy_Recursos.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tablesy_Recursos.RowIdColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class sy_RecursosRowChangeEvent : EventArgs {
            
            private sy_RecursosRow eventRow;
            
            private DataRowAction eventAction;
            
            public sy_RecursosRowChangeEvent(sy_RecursosRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public sy_RecursosRow Row {
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
