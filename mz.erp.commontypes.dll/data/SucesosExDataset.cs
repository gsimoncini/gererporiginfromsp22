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
    public class SucesosExDataset : DataSet {
        
        private SucesosDataTable tableSucesos;
        
        public SucesosExDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected SucesosExDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["Sucesos"] != null)) {
                    this.Tables.Add(new SucesosDataTable(ds.Tables["Sucesos"]));
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
        public SucesosDataTable Sucesos {
            get {
                return this.tableSucesos;
            }
        }
        
        public override DataSet Clone() {
            SucesosExDataset cln = ((SucesosExDataset)(base.Clone()));
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
            if ((ds.Tables["Sucesos"] != null)) {
                this.Tables.Add(new SucesosDataTable(ds.Tables["Sucesos"]));
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
            this.tableSucesos = ((SucesosDataTable)(this.Tables["Sucesos"]));
            if ((this.tableSucesos != null)) {
                this.tableSucesos.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "SucesosExDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/SucesosExDataset.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tableSucesos = new SucesosDataTable();
            this.Tables.Add(this.tableSucesos);
        }
        
        private bool ShouldSerializeSucesos() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void SucesosRowChangeEventHandler(object sender, SucesosRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class SucesosDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdSuceso;
            
            private DataColumn columnIdTipoSuceso;
            
            private DataColumn columnFecha;
            
            private DataColumn columnMensaje;
            
            private DataColumn columnIdConexion;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnRowId;
            
            internal SucesosDataTable() : 
                    base("Sucesos") {
                this.InitClass();
            }
            
            internal SucesosDataTable(DataTable table) : 
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
            
            internal DataColumn IdSucesoColumn {
                get {
                    return this.columnIdSuceso;
                }
            }
            
            internal DataColumn IdTipoSucesoColumn {
                get {
                    return this.columnIdTipoSuceso;
                }
            }
            
            internal DataColumn FechaColumn {
                get {
                    return this.columnFecha;
                }
            }
            
            internal DataColumn MensajeColumn {
                get {
                    return this.columnMensaje;
                }
            }
            
            internal DataColumn IdConexionColumn {
                get {
                    return this.columnIdConexion;
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
            
            public SucesosRow this[int index] {
                get {
                    return ((SucesosRow)(this.Rows[index]));
                }
            }
            
            public event SucesosRowChangeEventHandler SucesosRowChanged;
            
            public event SucesosRowChangeEventHandler SucesosRowChanging;
            
            public event SucesosRowChangeEventHandler SucesosRowDeleted;
            
            public event SucesosRowChangeEventHandler SucesosRowDeleting;
            
            public void AddSucesosRow(SucesosRow row) {
                this.Rows.Add(row);
            }
            
            public SucesosRow AddSucesosRow(long IdSuceso, long IdTipoSuceso, System.DateTime Fecha, string Mensaje, long IdConexion, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, System.Guid RowId) {
                SucesosRow rowSucesosRow = ((SucesosRow)(this.NewRow()));
                rowSucesosRow.ItemArray = new object[] {
                        IdSuceso,
                        IdTipoSuceso,
                        Fecha,
                        Mensaje,
                        IdConexion,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        RowId};
                this.Rows.Add(rowSucesosRow);
                return rowSucesosRow;
            }
            
            public SucesosRow FindByIdSuceso(long IdSuceso) {
                return ((SucesosRow)(this.Rows.Find(new object[] {
                            IdSuceso})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                SucesosDataTable cln = ((SucesosDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new SucesosDataTable();
            }
            
            internal void InitVars() {
                this.columnIdSuceso = this.Columns["IdSuceso"];
                this.columnIdTipoSuceso = this.Columns["IdTipoSuceso"];
                this.columnFecha = this.Columns["Fecha"];
                this.columnMensaje = this.Columns["Mensaje"];
                this.columnIdConexion = this.Columns["IdConexion"];
                this.columnFechaCreacion = this.Columns["FechaCreacion"];
                this.columnIdConexionCreacion = this.Columns["IdConexionCreacion"];
                this.columnUltimaModificacion = this.Columns["UltimaModificacion"];
                this.columnIdConexionUltimaModificacion = this.Columns["IdConexionUltimaModificacion"];
                this.columnRowId = this.Columns["RowId"];
            }
            
            private void InitClass() {
                this.columnIdSuceso = new DataColumn("IdSuceso", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdSuceso);
                this.columnIdTipoSuceso = new DataColumn("IdTipoSuceso", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdTipoSuceso);
                this.columnFecha = new DataColumn("Fecha", typeof(System.DateTime), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnFecha);
                this.columnMensaje = new DataColumn("Mensaje", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnMensaje);
                this.columnIdConexion = new DataColumn("IdConexion", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdConexion);
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
                this.Constraints.Add(new UniqueConstraint("SucesosExDatasetKey1", new DataColumn[] {
                                this.columnIdSuceso}, true));
                this.columnIdSuceso.AllowDBNull = false;
                this.columnIdSuceso.Unique = true;
                this.columnIdTipoSuceso.AllowDBNull = false;
                this.columnFechaCreacion.AllowDBNull = false;
                this.columnIdConexionCreacion.AllowDBNull = false;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public SucesosRow NewSucesosRow() {
                return ((SucesosRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new SucesosRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(SucesosRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.SucesosRowChanged != null)) {
                    this.SucesosRowChanged(this, new SucesosRowChangeEvent(((SucesosRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.SucesosRowChanging != null)) {
                    this.SucesosRowChanging(this, new SucesosRowChangeEvent(((SucesosRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.SucesosRowDeleted != null)) {
                    this.SucesosRowDeleted(this, new SucesosRowChangeEvent(((SucesosRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.SucesosRowDeleting != null)) {
                    this.SucesosRowDeleting(this, new SucesosRowChangeEvent(((SucesosRow)(e.Row)), e.Action));
                }
            }
            
            public void RemoveSucesosRow(SucesosRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class SucesosRow : DataRow {
            
            private SucesosDataTable tableSucesos;
            
            internal SucesosRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tableSucesos = ((SucesosDataTable)(this.Table));
            }
            
            public long IdSuceso {
                get {
                    return ((long)(this[this.tableSucesos.IdSucesoColumn]));
                }
                set {
                    this[this.tableSucesos.IdSucesoColumn] = value;
                }
            }
            
            public long IdTipoSuceso {
                get {
                    return ((long)(this[this.tableSucesos.IdTipoSucesoColumn]));
                }
                set {
                    this[this.tableSucesos.IdTipoSucesoColumn] = value;
                }
            }
            
            public System.DateTime Fecha {
                get {
                    try {
                        return ((System.DateTime)(this[this.tableSucesos.FechaColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tableSucesos.FechaColumn] = value;
                }
            }
            
            public string Mensaje {
                get {
                    try {
                        return ((string)(this[this.tableSucesos.MensajeColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tableSucesos.MensajeColumn] = value;
                }
            }
            
            public long IdConexion {
                get {
                    try {
                        return ((long)(this[this.tableSucesos.IdConexionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tableSucesos.IdConexionColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    return ((System.DateTime)(this[this.tableSucesos.FechaCreacionColumn]));
                }
                set {
                    this[this.tableSucesos.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    return ((long)(this[this.tableSucesos.IdConexionCreacionColumn]));
                }
                set {
                    this[this.tableSucesos.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tableSucesos.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tableSucesos.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tableSucesos.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tableSucesos.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tableSucesos.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tableSucesos.RowIdColumn] = value;
                }
            }
            
            public bool IsFechaNull() {
                return this.IsNull(this.tableSucesos.FechaColumn);
            }
            
            public void SetFechaNull() {
                this[this.tableSucesos.FechaColumn] = System.Convert.DBNull;
            }
            
            public bool IsMensajeNull() {
                return this.IsNull(this.tableSucesos.MensajeColumn);
            }
            
            public void SetMensajeNull() {
                this[this.tableSucesos.MensajeColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionNull() {
                return this.IsNull(this.tableSucesos.IdConexionColumn);
            }
            
            public void SetIdConexionNull() {
                this[this.tableSucesos.IdConexionColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tableSucesos.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tableSucesos.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tableSucesos.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tableSucesos.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tableSucesos.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tableSucesos.RowIdColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class SucesosRowChangeEvent : EventArgs {
            
            private SucesosRow eventRow;
            
            private DataRowAction eventAction;
            
            public SucesosRowChangeEvent(SucesosRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public SucesosRow Row {
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
