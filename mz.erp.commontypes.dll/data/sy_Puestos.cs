﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.2407
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
    public class sy_PuestosDataset : DataSet {
        
        private sy_PuestosDataTable tablesy_Puestos;
        
        public sy_PuestosDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected sy_PuestosDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["sy_Puestos"] != null)) {
                    this.Tables.Add(new sy_PuestosDataTable(ds.Tables["sy_Puestos"]));
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
        public sy_PuestosDataTable sy_Puestos {
            get {
                return this.tablesy_Puestos;
            }
        }
        
        public override DataSet Clone() {
            sy_PuestosDataset cln = ((sy_PuestosDataset)(base.Clone()));
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
            if ((ds.Tables["sy_Puestos"] != null)) {
                this.Tables.Add(new sy_PuestosDataTable(ds.Tables["sy_Puestos"]));
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
            this.tablesy_Puestos = ((sy_PuestosDataTable)(this.Tables["sy_Puestos"]));
            if ((this.tablesy_Puestos != null)) {
                this.tablesy_Puestos.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "sy_PuestosDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/sy_Puestos.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tablesy_Puestos = new sy_PuestosDataTable();
            this.Tables.Add(this.tablesy_Puestos);
        }
        
        private bool ShouldSerializesy_Puestos() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void sy_PuestosRowChangeEventHandler(object sender, sy_PuestosRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class sy_PuestosDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdPuesto;
            
            private DataColumn columnDescripcion;
            
            private DataColumn columnIdHardware;
            
            private DataColumn columnUbicacion;
            
            private DataColumn columnUsuarioSO;
            
            private DataColumn columnActivo;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnRowId;
            
            internal sy_PuestosDataTable() : 
                    base("sy_Puestos") {
                this.InitClass();
            }
            
            internal sy_PuestosDataTable(DataTable table) : 
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
            
            internal DataColumn IdPuestoColumn {
                get {
                    return this.columnIdPuesto;
                }
            }
            
            internal DataColumn DescripcionColumn {
                get {
                    return this.columnDescripcion;
                }
            }
            
            internal DataColumn IdHardwareColumn {
                get {
                    return this.columnIdHardware;
                }
            }
            
            internal DataColumn UbicacionColumn {
                get {
                    return this.columnUbicacion;
                }
            }
            
            internal DataColumn UsuarioSOColumn {
                get {
                    return this.columnUsuarioSO;
                }
            }
            
            internal DataColumn ActivoColumn {
                get {
                    return this.columnActivo;
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
            
            public sy_PuestosRow this[int index] {
                get {
                    return ((sy_PuestosRow)(this.Rows[index]));
                }
            }
            
            public event sy_PuestosRowChangeEventHandler sy_PuestosRowChanged;
            
            public event sy_PuestosRowChangeEventHandler sy_PuestosRowChanging;
            
            public event sy_PuestosRowChangeEventHandler sy_PuestosRowDeleted;
            
            public event sy_PuestosRowChangeEventHandler sy_PuestosRowDeleting;
            
            public void Addsy_PuestosRow(sy_PuestosRow row) {
                this.Rows.Add(row);
            }
            
            public sy_PuestosRow Addsy_PuestosRow(long IdPuesto, string Descripcion, string IdHardware, string Ubicacion, string UsuarioSO, bool Activo, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, System.Guid RowId) {
                sy_PuestosRow rowsy_PuestosRow = ((sy_PuestosRow)(this.NewRow()));
                rowsy_PuestosRow.ItemArray = new object[] {
                        IdPuesto,
                        Descripcion,
                        IdHardware,
                        Ubicacion,
                        UsuarioSO,
                        Activo,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        RowId};
                this.Rows.Add(rowsy_PuestosRow);
                return rowsy_PuestosRow;
            }
            
            public sy_PuestosRow FindByIdPuesto(long IdPuesto) {
                return ((sy_PuestosRow)(this.Rows.Find(new object[] {
                            IdPuesto})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                sy_PuestosDataTable cln = ((sy_PuestosDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new sy_PuestosDataTable();
            }
            
            internal void InitVars() {
                this.columnIdPuesto = this.Columns["IdPuesto"];
                this.columnDescripcion = this.Columns["Descripcion"];
                this.columnIdHardware = this.Columns["IdHardware"];
                this.columnUbicacion = this.Columns["Ubicacion"];
                this.columnUsuarioSO = this.Columns["UsuarioSO"];
                this.columnActivo = this.Columns["Activo"];
                this.columnFechaCreacion = this.Columns["FechaCreacion"];
                this.columnIdConexionCreacion = this.Columns["IdConexionCreacion"];
                this.columnUltimaModificacion = this.Columns["UltimaModificacion"];
                this.columnIdConexionUltimaModificacion = this.Columns["IdConexionUltimaModificacion"];
                this.columnRowId = this.Columns["RowId"];
            }
            
            private void InitClass() {
                this.columnIdPuesto = new DataColumn("IdPuesto", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdPuesto);
                this.columnDescripcion = new DataColumn("Descripcion", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnDescripcion);
                this.columnIdHardware = new DataColumn("IdHardware", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdHardware);
                this.columnUbicacion = new DataColumn("Ubicacion", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnUbicacion);
                this.columnUsuarioSO = new DataColumn("UsuarioSO", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnUsuarioSO);
                this.columnActivo = new DataColumn("Activo", typeof(bool), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnActivo);
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
                this.Constraints.Add(new UniqueConstraint("sy_PuestosKey1", new DataColumn[] {
                                this.columnIdPuesto}, true));
                this.columnIdPuesto.AllowDBNull = false;
                this.columnIdPuesto.Unique = true;
                this.columnDescripcion.AllowDBNull = false;
                this.columnIdHardware.AllowDBNull = false;
                this.columnUbicacion.AllowDBNull = false;
                this.columnFechaCreacion.AllowDBNull = false;
                this.columnIdConexionCreacion.AllowDBNull = false;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public sy_PuestosRow Newsy_PuestosRow() {
                return ((sy_PuestosRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new sy_PuestosRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(sy_PuestosRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.sy_PuestosRowChanged != null)) {
                    this.sy_PuestosRowChanged(this, new sy_PuestosRowChangeEvent(((sy_PuestosRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.sy_PuestosRowChanging != null)) {
                    this.sy_PuestosRowChanging(this, new sy_PuestosRowChangeEvent(((sy_PuestosRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.sy_PuestosRowDeleted != null)) {
                    this.sy_PuestosRowDeleted(this, new sy_PuestosRowChangeEvent(((sy_PuestosRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.sy_PuestosRowDeleting != null)) {
                    this.sy_PuestosRowDeleting(this, new sy_PuestosRowChangeEvent(((sy_PuestosRow)(e.Row)), e.Action));
                }
            }
            
            public void Removesy_PuestosRow(sy_PuestosRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class sy_PuestosRow : DataRow {
            
            private sy_PuestosDataTable tablesy_Puestos;
            
            internal sy_PuestosRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tablesy_Puestos = ((sy_PuestosDataTable)(this.Table));
            }
            
            public long IdPuesto {
                get {
                    return ((long)(this[this.tablesy_Puestos.IdPuestoColumn]));
                }
                set {
                    this[this.tablesy_Puestos.IdPuestoColumn] = value;
                }
            }
            
            public string Descripcion {
                get {
                    return ((string)(this[this.tablesy_Puestos.DescripcionColumn]));
                }
                set {
                    this[this.tablesy_Puestos.DescripcionColumn] = value;
                }
            }
            
            public string IdHardware {
                get {
                    return ((string)(this[this.tablesy_Puestos.IdHardwareColumn]));
                }
                set {
                    this[this.tablesy_Puestos.IdHardwareColumn] = value;
                }
            }
            
            public string Ubicacion {
                get {
                    return ((string)(this[this.tablesy_Puestos.UbicacionColumn]));
                }
                set {
                    this[this.tablesy_Puestos.UbicacionColumn] = value;
                }
            }
            
            public string UsuarioSO {
                get {
                    if (this.IsUsuarioSONull()) {
                        return string.Empty;
                    }
                    else {
                        return ((string)(this[this.tablesy_Puestos.UsuarioSOColumn]));
                    }
                }
                set {
                    this[this.tablesy_Puestos.UsuarioSOColumn] = value;
                }
            }
            
            public bool Activo {
                get {
                    try {
                        return ((bool)(this[this.tablesy_Puestos.ActivoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_Puestos.ActivoColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    return ((System.DateTime)(this[this.tablesy_Puestos.FechaCreacionColumn]));
                }
                set {
                    this[this.tablesy_Puestos.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    return ((long)(this[this.tablesy_Puestos.IdConexionCreacionColumn]));
                }
                set {
                    this[this.tablesy_Puestos.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tablesy_Puestos.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_Puestos.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tablesy_Puestos.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_Puestos.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tablesy_Puestos.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_Puestos.RowIdColumn] = value;
                }
            }
            
            public bool IsUsuarioSONull() {
                return this.IsNull(this.tablesy_Puestos.UsuarioSOColumn);
            }
            
            public void SetUsuarioSONull() {
                this[this.tablesy_Puestos.UsuarioSOColumn] = System.Convert.DBNull;
            }
            
            public bool IsActivoNull() {
                return this.IsNull(this.tablesy_Puestos.ActivoColumn);
            }
            
            public void SetActivoNull() {
                this[this.tablesy_Puestos.ActivoColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tablesy_Puestos.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tablesy_Puestos.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tablesy_Puestos.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tablesy_Puestos.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tablesy_Puestos.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tablesy_Puestos.RowIdColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class sy_PuestosRowChangeEvent : EventArgs {
            
            private sy_PuestosRow eventRow;
            
            private DataRowAction eventAction;
            
            public sy_PuestosRowChangeEvent(sy_PuestosRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public sy_PuestosRow Row {
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
