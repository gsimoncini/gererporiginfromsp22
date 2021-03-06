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
    public class EmpresasDataset : DataSet {
        
        private EmpresasDataTable tableEmpresas;
        
        public EmpresasDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected EmpresasDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["Empresas"] != null)) {
                    this.Tables.Add(new EmpresasDataTable(ds.Tables["Empresas"]));
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
        public EmpresasDataTable Empresas {
            get {
                return this.tableEmpresas;
            }
        }
        
        public override DataSet Clone() {
            EmpresasDataset cln = ((EmpresasDataset)(base.Clone()));
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
            if ((ds.Tables["Empresas"] != null)) {
                this.Tables.Add(new EmpresasDataTable(ds.Tables["Empresas"]));
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
            this.tableEmpresas = ((EmpresasDataTable)(this.Tables["Empresas"]));
            if ((this.tableEmpresas != null)) {
                this.tableEmpresas.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "EmpresasDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/EmpresasDataset.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tableEmpresas = new EmpresasDataTable();
            this.Tables.Add(this.tableEmpresas);
        }
        
        private bool ShouldSerializeEmpresas() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void EmpresasRowChangeEventHandler(object sender, EmpresasRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class EmpresasDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdEmpresa;
            
            private DataColumn columnDescripcion;
            
            private DataColumn columnConexion;
            
            private DataColumn columnBaseDeDatos;
            
            private DataColumn columnUsuario;
            
            private DataColumn columnPassword;
            
            private DataColumn columnActivo;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnRowId;
            
            internal EmpresasDataTable() : 
                    base("Empresas") {
                this.InitClass();
            }
            
            internal EmpresasDataTable(DataTable table) : 
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
            
            internal DataColumn IdEmpresaColumn {
                get {
                    return this.columnIdEmpresa;
                }
            }
            
            internal DataColumn DescripcionColumn {
                get {
                    return this.columnDescripcion;
                }
            }
            
            internal DataColumn ConexionColumn {
                get {
                    return this.columnConexion;
                }
            }
            
            internal DataColumn BaseDeDatosColumn {
                get {
                    return this.columnBaseDeDatos;
                }
            }
            
            internal DataColumn UsuarioColumn {
                get {
                    return this.columnUsuario;
                }
            }
            
            internal DataColumn PasswordColumn {
                get {
                    return this.columnPassword;
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
            
            public EmpresasRow this[int index] {
                get {
                    return ((EmpresasRow)(this.Rows[index]));
                }
            }
            
            public event EmpresasRowChangeEventHandler EmpresasRowChanged;
            
            public event EmpresasRowChangeEventHandler EmpresasRowChanging;
            
            public event EmpresasRowChangeEventHandler EmpresasRowDeleted;
            
            public event EmpresasRowChangeEventHandler EmpresasRowDeleting;
            
            public void AddEmpresasRow(EmpresasRow row) {
                this.Rows.Add(row);
            }
            
            public EmpresasRow AddEmpresasRow(long IdEmpresa, string Descripcion, string Conexion, string BaseDeDatos, string Usuario, string Password, string Activo, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, System.Guid RowId) {
                EmpresasRow rowEmpresasRow = ((EmpresasRow)(this.NewRow()));
                rowEmpresasRow.ItemArray = new object[] {
                        IdEmpresa,
                        Descripcion,
                        Conexion,
                        BaseDeDatos,
                        Usuario,
                        Password,
                        Activo,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        RowId};
                this.Rows.Add(rowEmpresasRow);
                return rowEmpresasRow;
            }
            
            public EmpresasRow FindByIdEmpresa(long IdEmpresa) {
                return ((EmpresasRow)(this.Rows.Find(new object[] {
                            IdEmpresa})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                EmpresasDataTable cln = ((EmpresasDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new EmpresasDataTable();
            }
            
            internal void InitVars() {
                this.columnIdEmpresa = this.Columns["IdEmpresa"];
                this.columnDescripcion = this.Columns["Descripcion"];
                this.columnConexion = this.Columns["Conexion"];
                this.columnBaseDeDatos = this.Columns["BaseDeDatos"];
                this.columnUsuario = this.Columns["Usuario"];
                this.columnPassword = this.Columns["Password"];
                this.columnActivo = this.Columns["Activo"];
                this.columnFechaCreacion = this.Columns["FechaCreacion"];
                this.columnIdConexionCreacion = this.Columns["IdConexionCreacion"];
                this.columnUltimaModificacion = this.Columns["UltimaModificacion"];
                this.columnIdConexionUltimaModificacion = this.Columns["IdConexionUltimaModificacion"];
                this.columnRowId = this.Columns["RowId"];
            }
            
            private void InitClass() {
                this.columnIdEmpresa = new DataColumn("IdEmpresa", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdEmpresa);
                this.columnDescripcion = new DataColumn("Descripcion", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnDescripcion);
                this.columnConexion = new DataColumn("Conexion", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnConexion);
                this.columnBaseDeDatos = new DataColumn("BaseDeDatos", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnBaseDeDatos);
                this.columnUsuario = new DataColumn("Usuario", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnUsuario);
                this.columnPassword = new DataColumn("Password", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnPassword);
                this.columnActivo = new DataColumn("Activo", typeof(string), null, System.Data.MappingType.Element);
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
                this.Constraints.Add(new UniqueConstraint("EmpresasDatasetKey1", new DataColumn[] {
                                this.columnIdEmpresa}, true));
                this.columnIdEmpresa.AllowDBNull = false;
                this.columnIdEmpresa.Unique = true;
                this.columnDescripcion.AllowDBNull = false;
                this.columnConexion.AllowDBNull = false;
                this.columnBaseDeDatos.AllowDBNull = false;
                this.columnUsuario.AllowDBNull = false;
                this.columnPassword.AllowDBNull = false;
                this.columnFechaCreacion.AllowDBNull = false;
                this.columnIdConexionCreacion.AllowDBNull = false;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public EmpresasRow NewEmpresasRow() {
                return ((EmpresasRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new EmpresasRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(EmpresasRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.EmpresasRowChanged != null)) {
                    this.EmpresasRowChanged(this, new EmpresasRowChangeEvent(((EmpresasRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.EmpresasRowChanging != null)) {
                    this.EmpresasRowChanging(this, new EmpresasRowChangeEvent(((EmpresasRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.EmpresasRowDeleted != null)) {
                    this.EmpresasRowDeleted(this, new EmpresasRowChangeEvent(((EmpresasRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.EmpresasRowDeleting != null)) {
                    this.EmpresasRowDeleting(this, new EmpresasRowChangeEvent(((EmpresasRow)(e.Row)), e.Action));
                }
            }
            
            public void RemoveEmpresasRow(EmpresasRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class EmpresasRow : DataRow {
            
            private EmpresasDataTable tableEmpresas;
            
            internal EmpresasRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tableEmpresas = ((EmpresasDataTable)(this.Table));
            }
            
            public long IdEmpresa {
                get {
                    return ((long)(this[this.tableEmpresas.IdEmpresaColumn]));
                }
                set {
                    this[this.tableEmpresas.IdEmpresaColumn] = value;
                }
            }
            
            public string Descripcion {
                get {
                    return ((string)(this[this.tableEmpresas.DescripcionColumn]));
                }
                set {
                    this[this.tableEmpresas.DescripcionColumn] = value;
                }
            }
            
            public string Conexion {
                get {
                    return ((string)(this[this.tableEmpresas.ConexionColumn]));
                }
                set {
                    this[this.tableEmpresas.ConexionColumn] = value;
                }
            }
            
            public string BaseDeDatos {
                get {
                    return ((string)(this[this.tableEmpresas.BaseDeDatosColumn]));
                }
                set {
                    this[this.tableEmpresas.BaseDeDatosColumn] = value;
                }
            }
            
            public string Usuario {
                get {
                    return ((string)(this[this.tableEmpresas.UsuarioColumn]));
                }
                set {
                    this[this.tableEmpresas.UsuarioColumn] = value;
                }
            }
            
            public string Password {
                get {
                    return ((string)(this[this.tableEmpresas.PasswordColumn]));
                }
                set {
                    this[this.tableEmpresas.PasswordColumn] = value;
                }
            }
            
            public string Activo {
                get {
                    try {
                        return ((string)(this[this.tableEmpresas.ActivoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tableEmpresas.ActivoColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    return ((System.DateTime)(this[this.tableEmpresas.FechaCreacionColumn]));
                }
                set {
                    this[this.tableEmpresas.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    return ((long)(this[this.tableEmpresas.IdConexionCreacionColumn]));
                }
                set {
                    this[this.tableEmpresas.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tableEmpresas.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tableEmpresas.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tableEmpresas.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tableEmpresas.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tableEmpresas.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tableEmpresas.RowIdColumn] = value;
                }
            }
            
            public bool IsActivoNull() {
                return this.IsNull(this.tableEmpresas.ActivoColumn);
            }
            
            public void SetActivoNull() {
                this[this.tableEmpresas.ActivoColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tableEmpresas.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tableEmpresas.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tableEmpresas.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tableEmpresas.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tableEmpresas.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tableEmpresas.RowIdColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class EmpresasRowChangeEvent : EventArgs {
            
            private EmpresasRow eventRow;
            
            private DataRowAction eventAction;
            
            public EmpresasRowChangeEvent(EmpresasRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public EmpresasRow Row {
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
