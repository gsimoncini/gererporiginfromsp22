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
    public class tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataset : DataSet {
        
        private tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataTable tabletui_ConfiguracionGrillaEstilosCondicionalesUsuarios;
        
        public tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["tui_ConfiguracionGrillaEstilosCondicionalesUsuarios"] != null)) {
                    this.Tables.Add(new tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataTable(ds.Tables["tui_ConfiguracionGrillaEstilosCondicionalesUsuarios"]));
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
        public tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataTable tui_ConfiguracionGrillaEstilosCondicionalesUsuarios {
            get {
                return this.tabletui_ConfiguracionGrillaEstilosCondicionalesUsuarios;
            }
        }
        
        public override DataSet Clone() {
            tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataset cln = ((tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataset)(base.Clone()));
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
            if ((ds.Tables["tui_ConfiguracionGrillaEstilosCondicionalesUsuarios"] != null)) {
                this.Tables.Add(new tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataTable(ds.Tables["tui_ConfiguracionGrillaEstilosCondicionalesUsuarios"]));
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
            this.tabletui_ConfiguracionGrillaEstilosCondicionalesUsuarios = ((tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataTable)(this.Tables["tui_ConfiguracionGrillaEstilosCondicionalesUsuarios"]));
            if ((this.tabletui_ConfiguracionGrillaEstilosCondicionalesUsuarios != null)) {
                this.tabletui_ConfiguracionGrillaEstilosCondicionalesUsuarios.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/tui_ConfiguracionGrillaEstilosCondicionalesUsuarios.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tabletui_ConfiguracionGrillaEstilosCondicionalesUsuarios = new tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataTable();
            this.Tables.Add(this.tabletui_ConfiguracionGrillaEstilosCondicionalesUsuarios);
        }
        
        private bool ShouldSerializetui_ConfiguracionGrillaEstilosCondicionalesUsuarios() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRowChangeEventHandler(object sender, tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdUsuario;
            
            private DataColumn columnIdConfiguracion;
            
            private DataColumn columnNombre;
            
            private DataColumn columnIdUsuarioCreador;
            
            private DataColumn columnActivo;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnIdReservado;
            
            private DataColumn columnRowId;
            
            private DataColumn columnIdEmpresa;
            
            private DataColumn columnIdSucursal;
            
            internal tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataTable() : 
                    base("tui_ConfiguracionGrillaEstilosCondicionalesUsuarios") {
                this.InitClass();
            }
            
            internal tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataTable(DataTable table) : 
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
            
            internal DataColumn IdUsuarioColumn {
                get {
                    return this.columnIdUsuario;
                }
            }
            
            internal DataColumn IdConfiguracionColumn {
                get {
                    return this.columnIdConfiguracion;
                }
            }
            
            internal DataColumn NombreColumn {
                get {
                    return this.columnNombre;
                }
            }
            
            internal DataColumn IdUsuarioCreadorColumn {
                get {
                    return this.columnIdUsuarioCreador;
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
            
            internal DataColumn IdReservadoColumn {
                get {
                    return this.columnIdReservado;
                }
            }
            
            internal DataColumn RowIdColumn {
                get {
                    return this.columnRowId;
                }
            }
            
            internal DataColumn IdEmpresaColumn {
                get {
                    return this.columnIdEmpresa;
                }
            }
            
            internal DataColumn IdSucursalColumn {
                get {
                    return this.columnIdSucursal;
                }
            }
            
            public tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow this[int index] {
                get {
                    return ((tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow)(this.Rows[index]));
                }
            }
            
            public event tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRowChangeEventHandler tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRowChanged;
            
            public event tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRowChangeEventHandler tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRowChanging;
            
            public event tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRowChangeEventHandler tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRowDeleted;
            
            public event tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRowChangeEventHandler tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRowDeleting;
            
            public void Addtui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow(tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow row) {
                this.Rows.Add(row);
            }
            
            public tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow Addtui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow(string IdUsuario, long IdConfiguracion, string Nombre, string IdUsuarioCreador, bool Activo, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, System.Guid RowId, long IdEmpresa, long IdSucursal) {
                tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow rowtui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow = ((tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow)(this.NewRow()));
                rowtui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow.ItemArray = new object[] {
                        IdUsuario,
                        IdConfiguracion,
                        Nombre,
                        IdUsuarioCreador,
                        Activo,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        IdReservado,
                        RowId,
                        IdEmpresa,
                        IdSucursal};
                this.Rows.Add(rowtui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow);
                return rowtui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow;
            }
            
            public tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow FindByIdUsuarioIdConfiguracion(string IdUsuario, long IdConfiguracion) {
                return ((tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow)(this.Rows.Find(new object[] {
                            IdUsuario,
                            IdConfiguracion})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataTable cln = ((tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataTable();
            }
            
            internal void InitVars() {
                this.columnIdUsuario = this.Columns["IdUsuario"];
                this.columnIdConfiguracion = this.Columns["IdConfiguracion"];
                this.columnNombre = this.Columns["Nombre"];
                this.columnIdUsuarioCreador = this.Columns["IdUsuarioCreador"];
                this.columnActivo = this.Columns["Activo"];
                this.columnFechaCreacion = this.Columns["FechaCreacion"];
                this.columnIdConexionCreacion = this.Columns["IdConexionCreacion"];
                this.columnUltimaModificacion = this.Columns["UltimaModificacion"];
                this.columnIdConexionUltimaModificacion = this.Columns["IdConexionUltimaModificacion"];
                this.columnIdReservado = this.Columns["IdReservado"];
                this.columnRowId = this.Columns["RowId"];
                this.columnIdEmpresa = this.Columns["IdEmpresa"];
                this.columnIdSucursal = this.Columns["IdSucursal"];
            }
            
            private void InitClass() {
                this.columnIdUsuario = new DataColumn("IdUsuario", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdUsuario);
                this.columnIdConfiguracion = new DataColumn("IdConfiguracion", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdConfiguracion);
                this.columnNombre = new DataColumn("Nombre", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnNombre);
                this.columnIdUsuarioCreador = new DataColumn("IdUsuarioCreador", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdUsuarioCreador);
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
                this.columnIdReservado = new DataColumn("IdReservado", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdReservado);
                this.columnRowId = new DataColumn("RowId", typeof(System.Guid), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnRowId);
                this.columnIdEmpresa = new DataColumn("IdEmpresa", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdEmpresa);
                this.columnIdSucursal = new DataColumn("IdSucursal", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdSucursal);
                this.Constraints.Add(new UniqueConstraint("tui_ConfiguracionGrillaEstilosCondicionalesUsuariosKey1", new DataColumn[] {
                                this.columnIdUsuario,
                                this.columnIdConfiguracion}, true));
                this.columnIdUsuario.AllowDBNull = false;
                this.columnIdConfiguracion.AllowDBNull = false;
                this.columnNombre.AllowDBNull = false;
                this.columnIdUsuarioCreador.AllowDBNull = false;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow Newtui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow() {
                return ((tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRowChanged != null)) {
                    this.tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRowChanged(this, new tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRowChangeEvent(((tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRowChanging != null)) {
                    this.tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRowChanging(this, new tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRowChangeEvent(((tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRowDeleted != null)) {
                    this.tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRowDeleted(this, new tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRowChangeEvent(((tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRowDeleting != null)) {
                    this.tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRowDeleting(this, new tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRowChangeEvent(((tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow)(e.Row)), e.Action));
                }
            }
            
            public void Removetui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow(tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow : DataRow {
            
            private tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataTable tabletui_ConfiguracionGrillaEstilosCondicionalesUsuarios;
            
            internal tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tabletui_ConfiguracionGrillaEstilosCondicionalesUsuarios = ((tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataTable)(this.Table));
            }
            
            public string IdUsuario {
                get {
                    return ((string)(this[this.tabletui_ConfiguracionGrillaEstilosCondicionalesUsuarios.IdUsuarioColumn]));
                }
                set {
                    this[this.tabletui_ConfiguracionGrillaEstilosCondicionalesUsuarios.IdUsuarioColumn] = value;
                }
            }
            
            public long IdConfiguracion {
                get {
                    return ((long)(this[this.tabletui_ConfiguracionGrillaEstilosCondicionalesUsuarios.IdConfiguracionColumn]));
                }
                set {
                    this[this.tabletui_ConfiguracionGrillaEstilosCondicionalesUsuarios.IdConfiguracionColumn] = value;
                }
            }
            
            public string Nombre {
                get {
                    return ((string)(this[this.tabletui_ConfiguracionGrillaEstilosCondicionalesUsuarios.NombreColumn]));
                }
                set {
                    this[this.tabletui_ConfiguracionGrillaEstilosCondicionalesUsuarios.NombreColumn] = value;
                }
            }
            
            public string IdUsuarioCreador {
                get {
                    return ((string)(this[this.tabletui_ConfiguracionGrillaEstilosCondicionalesUsuarios.IdUsuarioCreadorColumn]));
                }
                set {
                    this[this.tabletui_ConfiguracionGrillaEstilosCondicionalesUsuarios.IdUsuarioCreadorColumn] = value;
                }
            }
            
            public bool Activo {
                get {
                    try {
                        return ((bool)(this[this.tabletui_ConfiguracionGrillaEstilosCondicionalesUsuarios.ActivoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletui_ConfiguracionGrillaEstilosCondicionalesUsuarios.ActivoColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    try {
                        return ((System.DateTime)(this[this.tabletui_ConfiguracionGrillaEstilosCondicionalesUsuarios.FechaCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletui_ConfiguracionGrillaEstilosCondicionalesUsuarios.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    try {
                        return ((long)(this[this.tabletui_ConfiguracionGrillaEstilosCondicionalesUsuarios.IdConexionCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletui_ConfiguracionGrillaEstilosCondicionalesUsuarios.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tabletui_ConfiguracionGrillaEstilosCondicionalesUsuarios.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletui_ConfiguracionGrillaEstilosCondicionalesUsuarios.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tabletui_ConfiguracionGrillaEstilosCondicionalesUsuarios.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletui_ConfiguracionGrillaEstilosCondicionalesUsuarios.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public long IdReservado {
                get {
                    try {
                        return ((long)(this[this.tabletui_ConfiguracionGrillaEstilosCondicionalesUsuarios.IdReservadoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletui_ConfiguracionGrillaEstilosCondicionalesUsuarios.IdReservadoColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tabletui_ConfiguracionGrillaEstilosCondicionalesUsuarios.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletui_ConfiguracionGrillaEstilosCondicionalesUsuarios.RowIdColumn] = value;
                }
            }
            
            public long IdEmpresa {
                get {
                    try {
                        return ((long)(this[this.tabletui_ConfiguracionGrillaEstilosCondicionalesUsuarios.IdEmpresaColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletui_ConfiguracionGrillaEstilosCondicionalesUsuarios.IdEmpresaColumn] = value;
                }
            }
            
            public long IdSucursal {
                get {
                    try {
                        return ((long)(this[this.tabletui_ConfiguracionGrillaEstilosCondicionalesUsuarios.IdSucursalColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletui_ConfiguracionGrillaEstilosCondicionalesUsuarios.IdSucursalColumn] = value;
                }
            }
            
            public bool IsActivoNull() {
                return this.IsNull(this.tabletui_ConfiguracionGrillaEstilosCondicionalesUsuarios.ActivoColumn);
            }
            
            public void SetActivoNull() {
                this[this.tabletui_ConfiguracionGrillaEstilosCondicionalesUsuarios.ActivoColumn] = System.Convert.DBNull;
            }
            
            public bool IsFechaCreacionNull() {
                return this.IsNull(this.tabletui_ConfiguracionGrillaEstilosCondicionalesUsuarios.FechaCreacionColumn);
            }
            
            public void SetFechaCreacionNull() {
                this[this.tabletui_ConfiguracionGrillaEstilosCondicionalesUsuarios.FechaCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionCreacionNull() {
                return this.IsNull(this.tabletui_ConfiguracionGrillaEstilosCondicionalesUsuarios.IdConexionCreacionColumn);
            }
            
            public void SetIdConexionCreacionNull() {
                this[this.tabletui_ConfiguracionGrillaEstilosCondicionalesUsuarios.IdConexionCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tabletui_ConfiguracionGrillaEstilosCondicionalesUsuarios.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tabletui_ConfiguracionGrillaEstilosCondicionalesUsuarios.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tabletui_ConfiguracionGrillaEstilosCondicionalesUsuarios.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tabletui_ConfiguracionGrillaEstilosCondicionalesUsuarios.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdReservadoNull() {
                return this.IsNull(this.tabletui_ConfiguracionGrillaEstilosCondicionalesUsuarios.IdReservadoColumn);
            }
            
            public void SetIdReservadoNull() {
                this[this.tabletui_ConfiguracionGrillaEstilosCondicionalesUsuarios.IdReservadoColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tabletui_ConfiguracionGrillaEstilosCondicionalesUsuarios.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tabletui_ConfiguracionGrillaEstilosCondicionalesUsuarios.RowIdColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdEmpresaNull() {
                return this.IsNull(this.tabletui_ConfiguracionGrillaEstilosCondicionalesUsuarios.IdEmpresaColumn);
            }
            
            public void SetIdEmpresaNull() {
                this[this.tabletui_ConfiguracionGrillaEstilosCondicionalesUsuarios.IdEmpresaColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdSucursalNull() {
                return this.IsNull(this.tabletui_ConfiguracionGrillaEstilosCondicionalesUsuarios.IdSucursalColumn);
            }
            
            public void SetIdSucursalNull() {
                this[this.tabletui_ConfiguracionGrillaEstilosCondicionalesUsuarios.IdSucursalColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRowChangeEvent : EventArgs {
            
            private tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow eventRow;
            
            private DataRowAction eventAction;
            
            public tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRowChangeEvent(tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow Row {
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
