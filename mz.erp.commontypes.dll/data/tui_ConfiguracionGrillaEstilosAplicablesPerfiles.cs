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
    public class tui_ConfiguracionGrillaEstilosAplicablesPerfilesDataset : DataSet {
        
        private tui_ConfiguracionGrillaEstilosAplicablesPerfilesDataTable tabletui_ConfiguracionGrillaEstilosAplicablesPerfiles;
        
        public tui_ConfiguracionGrillaEstilosAplicablesPerfilesDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected tui_ConfiguracionGrillaEstilosAplicablesPerfilesDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["tui_ConfiguracionGrillaEstilosAplicablesPerfiles"] != null)) {
                    this.Tables.Add(new tui_ConfiguracionGrillaEstilosAplicablesPerfilesDataTable(ds.Tables["tui_ConfiguracionGrillaEstilosAplicablesPerfiles"]));
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
        public tui_ConfiguracionGrillaEstilosAplicablesPerfilesDataTable tui_ConfiguracionGrillaEstilosAplicablesPerfiles {
            get {
                return this.tabletui_ConfiguracionGrillaEstilosAplicablesPerfiles;
            }
        }
        
        public override DataSet Clone() {
            tui_ConfiguracionGrillaEstilosAplicablesPerfilesDataset cln = ((tui_ConfiguracionGrillaEstilosAplicablesPerfilesDataset)(base.Clone()));
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
            if ((ds.Tables["tui_ConfiguracionGrillaEstilosAplicablesPerfiles"] != null)) {
                this.Tables.Add(new tui_ConfiguracionGrillaEstilosAplicablesPerfilesDataTable(ds.Tables["tui_ConfiguracionGrillaEstilosAplicablesPerfiles"]));
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
            this.tabletui_ConfiguracionGrillaEstilosAplicablesPerfiles = ((tui_ConfiguracionGrillaEstilosAplicablesPerfilesDataTable)(this.Tables["tui_ConfiguracionGrillaEstilosAplicablesPerfiles"]));
            if ((this.tabletui_ConfiguracionGrillaEstilosAplicablesPerfiles != null)) {
                this.tabletui_ConfiguracionGrillaEstilosAplicablesPerfiles.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "tui_ConfiguracionGrillaEstilosAplicablesPerfilesDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/tui_ConfiguracionGrillaEstilosAplicablesPerfiles.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tabletui_ConfiguracionGrillaEstilosAplicablesPerfiles = new tui_ConfiguracionGrillaEstilosAplicablesPerfilesDataTable();
            this.Tables.Add(this.tabletui_ConfiguracionGrillaEstilosAplicablesPerfiles);
        }
        
        private bool ShouldSerializetui_ConfiguracionGrillaEstilosAplicablesPerfiles() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void tui_ConfiguracionGrillaEstilosAplicablesPerfilesRowChangeEventHandler(object sender, tui_ConfiguracionGrillaEstilosAplicablesPerfilesRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tui_ConfiguracionGrillaEstilosAplicablesPerfilesDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdProceso;
            
            private DataColumn columnIdTarea;
            
            private DataColumn columnGrilla;
            
            private DataColumn columnFormulario;
            
            private DataColumn columnIdPerfil;
            
            private DataColumn columnIdConfiguracion;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnIdReservado;
            
            private DataColumn columnRowId;
            
            private DataColumn columnIdEmpresa;
            
            private DataColumn columnIdSucursal;
            
            internal tui_ConfiguracionGrillaEstilosAplicablesPerfilesDataTable() : 
                    base("tui_ConfiguracionGrillaEstilosAplicablesPerfiles") {
                this.InitClass();
            }
            
            internal tui_ConfiguracionGrillaEstilosAplicablesPerfilesDataTable(DataTable table) : 
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
            
            internal DataColumn IdProcesoColumn {
                get {
                    return this.columnIdProceso;
                }
            }
            
            internal DataColumn IdTareaColumn {
                get {
                    return this.columnIdTarea;
                }
            }
            
            internal DataColumn GrillaColumn {
                get {
                    return this.columnGrilla;
                }
            }
            
            internal DataColumn FormularioColumn {
                get {
                    return this.columnFormulario;
                }
            }
            
            internal DataColumn IdPerfilColumn {
                get {
                    return this.columnIdPerfil;
                }
            }
            
            internal DataColumn IdConfiguracionColumn {
                get {
                    return this.columnIdConfiguracion;
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
            
            public tui_ConfiguracionGrillaEstilosAplicablesPerfilesRow this[int index] {
                get {
                    return ((tui_ConfiguracionGrillaEstilosAplicablesPerfilesRow)(this.Rows[index]));
                }
            }
            
            public event tui_ConfiguracionGrillaEstilosAplicablesPerfilesRowChangeEventHandler tui_ConfiguracionGrillaEstilosAplicablesPerfilesRowChanged;
            
            public event tui_ConfiguracionGrillaEstilosAplicablesPerfilesRowChangeEventHandler tui_ConfiguracionGrillaEstilosAplicablesPerfilesRowChanging;
            
            public event tui_ConfiguracionGrillaEstilosAplicablesPerfilesRowChangeEventHandler tui_ConfiguracionGrillaEstilosAplicablesPerfilesRowDeleted;
            
            public event tui_ConfiguracionGrillaEstilosAplicablesPerfilesRowChangeEventHandler tui_ConfiguracionGrillaEstilosAplicablesPerfilesRowDeleting;
            
            public void Addtui_ConfiguracionGrillaEstilosAplicablesPerfilesRow(tui_ConfiguracionGrillaEstilosAplicablesPerfilesRow row) {
                this.Rows.Add(row);
            }
            
            public tui_ConfiguracionGrillaEstilosAplicablesPerfilesRow Addtui_ConfiguracionGrillaEstilosAplicablesPerfilesRow(long IdProceso, long IdTarea, string Grilla, string Formulario, long IdPerfil, long IdConfiguracion, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, System.Guid RowId, long IdEmpresa, long IdSucursal) {
                tui_ConfiguracionGrillaEstilosAplicablesPerfilesRow rowtui_ConfiguracionGrillaEstilosAplicablesPerfilesRow = ((tui_ConfiguracionGrillaEstilosAplicablesPerfilesRow)(this.NewRow()));
                rowtui_ConfiguracionGrillaEstilosAplicablesPerfilesRow.ItemArray = new object[] {
                        IdProceso,
                        IdTarea,
                        Grilla,
                        Formulario,
                        IdPerfil,
                        IdConfiguracion,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        IdReservado,
                        RowId,
                        IdEmpresa,
                        IdSucursal};
                this.Rows.Add(rowtui_ConfiguracionGrillaEstilosAplicablesPerfilesRow);
                return rowtui_ConfiguracionGrillaEstilosAplicablesPerfilesRow;
            }
            
            public tui_ConfiguracionGrillaEstilosAplicablesPerfilesRow FindByIdProcesoIdTareaGrillaIdPerfilIdConfiguracion(long IdProceso, long IdTarea, string Grilla, long IdPerfil, long IdConfiguracion) {
                return ((tui_ConfiguracionGrillaEstilosAplicablesPerfilesRow)(this.Rows.Find(new object[] {
                            IdProceso,
                            IdTarea,
                            Grilla,
                            IdPerfil,
                            IdConfiguracion})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                tui_ConfiguracionGrillaEstilosAplicablesPerfilesDataTable cln = ((tui_ConfiguracionGrillaEstilosAplicablesPerfilesDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new tui_ConfiguracionGrillaEstilosAplicablesPerfilesDataTable();
            }
            
            internal void InitVars() {
                this.columnIdProceso = this.Columns["IdProceso"];
                this.columnIdTarea = this.Columns["IdTarea"];
                this.columnGrilla = this.Columns["Grilla"];
                this.columnFormulario = this.Columns["Formulario"];
                this.columnIdPerfil = this.Columns["IdPerfil"];
                this.columnIdConfiguracion = this.Columns["IdConfiguracion"];
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
                this.columnIdProceso = new DataColumn("IdProceso", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdProceso);
                this.columnIdTarea = new DataColumn("IdTarea", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdTarea);
                this.columnGrilla = new DataColumn("Grilla", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnGrilla);
                this.columnFormulario = new DataColumn("Formulario", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnFormulario);
                this.columnIdPerfil = new DataColumn("IdPerfil", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdPerfil);
                this.columnIdConfiguracion = new DataColumn("IdConfiguracion", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdConfiguracion);
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
                this.Constraints.Add(new UniqueConstraint("tui_ConfiguracionGrillaEstilosAplicablesPerfilesKey1", new DataColumn[] {
                                this.columnIdProceso,
                                this.columnIdTarea,
                                this.columnGrilla,
                                this.columnIdPerfil,
                                this.columnIdConfiguracion}, true));
                this.columnIdProceso.AllowDBNull = false;
                this.columnIdTarea.AllowDBNull = false;
                this.columnGrilla.AllowDBNull = false;
                this.columnIdPerfil.AllowDBNull = false;
                this.columnIdConfiguracion.AllowDBNull = false;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public tui_ConfiguracionGrillaEstilosAplicablesPerfilesRow Newtui_ConfiguracionGrillaEstilosAplicablesPerfilesRow() {
                return ((tui_ConfiguracionGrillaEstilosAplicablesPerfilesRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new tui_ConfiguracionGrillaEstilosAplicablesPerfilesRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(tui_ConfiguracionGrillaEstilosAplicablesPerfilesRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.tui_ConfiguracionGrillaEstilosAplicablesPerfilesRowChanged != null)) {
                    this.tui_ConfiguracionGrillaEstilosAplicablesPerfilesRowChanged(this, new tui_ConfiguracionGrillaEstilosAplicablesPerfilesRowChangeEvent(((tui_ConfiguracionGrillaEstilosAplicablesPerfilesRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.tui_ConfiguracionGrillaEstilosAplicablesPerfilesRowChanging != null)) {
                    this.tui_ConfiguracionGrillaEstilosAplicablesPerfilesRowChanging(this, new tui_ConfiguracionGrillaEstilosAplicablesPerfilesRowChangeEvent(((tui_ConfiguracionGrillaEstilosAplicablesPerfilesRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.tui_ConfiguracionGrillaEstilosAplicablesPerfilesRowDeleted != null)) {
                    this.tui_ConfiguracionGrillaEstilosAplicablesPerfilesRowDeleted(this, new tui_ConfiguracionGrillaEstilosAplicablesPerfilesRowChangeEvent(((tui_ConfiguracionGrillaEstilosAplicablesPerfilesRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.tui_ConfiguracionGrillaEstilosAplicablesPerfilesRowDeleting != null)) {
                    this.tui_ConfiguracionGrillaEstilosAplicablesPerfilesRowDeleting(this, new tui_ConfiguracionGrillaEstilosAplicablesPerfilesRowChangeEvent(((tui_ConfiguracionGrillaEstilosAplicablesPerfilesRow)(e.Row)), e.Action));
                }
            }
            
            public void Removetui_ConfiguracionGrillaEstilosAplicablesPerfilesRow(tui_ConfiguracionGrillaEstilosAplicablesPerfilesRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tui_ConfiguracionGrillaEstilosAplicablesPerfilesRow : DataRow {
            
            private tui_ConfiguracionGrillaEstilosAplicablesPerfilesDataTable tabletui_ConfiguracionGrillaEstilosAplicablesPerfiles;
            
            internal tui_ConfiguracionGrillaEstilosAplicablesPerfilesRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tabletui_ConfiguracionGrillaEstilosAplicablesPerfiles = ((tui_ConfiguracionGrillaEstilosAplicablesPerfilesDataTable)(this.Table));
            }
            
            public long IdProceso {
                get {
                    return ((long)(this[this.tabletui_ConfiguracionGrillaEstilosAplicablesPerfiles.IdProcesoColumn]));
                }
                set {
                    this[this.tabletui_ConfiguracionGrillaEstilosAplicablesPerfiles.IdProcesoColumn] = value;
                }
            }
            
            public long IdTarea {
                get {
                    return ((long)(this[this.tabletui_ConfiguracionGrillaEstilosAplicablesPerfiles.IdTareaColumn]));
                }
                set {
                    this[this.tabletui_ConfiguracionGrillaEstilosAplicablesPerfiles.IdTareaColumn] = value;
                }
            }
            
            public string Grilla {
                get {
                    return ((string)(this[this.tabletui_ConfiguracionGrillaEstilosAplicablesPerfiles.GrillaColumn]));
                }
                set {
                    this[this.tabletui_ConfiguracionGrillaEstilosAplicablesPerfiles.GrillaColumn] = value;
                }
            }
            
            public string Formulario {
                get {
                    try {
                        return ((string)(this[this.tabletui_ConfiguracionGrillaEstilosAplicablesPerfiles.FormularioColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletui_ConfiguracionGrillaEstilosAplicablesPerfiles.FormularioColumn] = value;
                }
            }
            
            public long IdPerfil {
                get {
                    return ((long)(this[this.tabletui_ConfiguracionGrillaEstilosAplicablesPerfiles.IdPerfilColumn]));
                }
                set {
                    this[this.tabletui_ConfiguracionGrillaEstilosAplicablesPerfiles.IdPerfilColumn] = value;
                }
            }
            
            public long IdConfiguracion {
                get {
                    return ((long)(this[this.tabletui_ConfiguracionGrillaEstilosAplicablesPerfiles.IdConfiguracionColumn]));
                }
                set {
                    this[this.tabletui_ConfiguracionGrillaEstilosAplicablesPerfiles.IdConfiguracionColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    try {
                        return ((System.DateTime)(this[this.tabletui_ConfiguracionGrillaEstilosAplicablesPerfiles.FechaCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletui_ConfiguracionGrillaEstilosAplicablesPerfiles.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    try {
                        return ((long)(this[this.tabletui_ConfiguracionGrillaEstilosAplicablesPerfiles.IdConexionCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletui_ConfiguracionGrillaEstilosAplicablesPerfiles.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tabletui_ConfiguracionGrillaEstilosAplicablesPerfiles.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletui_ConfiguracionGrillaEstilosAplicablesPerfiles.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tabletui_ConfiguracionGrillaEstilosAplicablesPerfiles.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletui_ConfiguracionGrillaEstilosAplicablesPerfiles.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public long IdReservado {
                get {
                    try {
                        return ((long)(this[this.tabletui_ConfiguracionGrillaEstilosAplicablesPerfiles.IdReservadoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletui_ConfiguracionGrillaEstilosAplicablesPerfiles.IdReservadoColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tabletui_ConfiguracionGrillaEstilosAplicablesPerfiles.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletui_ConfiguracionGrillaEstilosAplicablesPerfiles.RowIdColumn] = value;
                }
            }
            
            public long IdEmpresa {
                get {
                    try {
                        return ((long)(this[this.tabletui_ConfiguracionGrillaEstilosAplicablesPerfiles.IdEmpresaColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletui_ConfiguracionGrillaEstilosAplicablesPerfiles.IdEmpresaColumn] = value;
                }
            }
            
            public long IdSucursal {
                get {
                    try {
                        return ((long)(this[this.tabletui_ConfiguracionGrillaEstilosAplicablesPerfiles.IdSucursalColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletui_ConfiguracionGrillaEstilosAplicablesPerfiles.IdSucursalColumn] = value;
                }
            }
            
            public bool IsFormularioNull() {
                return this.IsNull(this.tabletui_ConfiguracionGrillaEstilosAplicablesPerfiles.FormularioColumn);
            }
            
            public void SetFormularioNull() {
                this[this.tabletui_ConfiguracionGrillaEstilosAplicablesPerfiles.FormularioColumn] = System.Convert.DBNull;
            }
            
            public bool IsFechaCreacionNull() {
                return this.IsNull(this.tabletui_ConfiguracionGrillaEstilosAplicablesPerfiles.FechaCreacionColumn);
            }
            
            public void SetFechaCreacionNull() {
                this[this.tabletui_ConfiguracionGrillaEstilosAplicablesPerfiles.FechaCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionCreacionNull() {
                return this.IsNull(this.tabletui_ConfiguracionGrillaEstilosAplicablesPerfiles.IdConexionCreacionColumn);
            }
            
            public void SetIdConexionCreacionNull() {
                this[this.tabletui_ConfiguracionGrillaEstilosAplicablesPerfiles.IdConexionCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tabletui_ConfiguracionGrillaEstilosAplicablesPerfiles.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tabletui_ConfiguracionGrillaEstilosAplicablesPerfiles.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tabletui_ConfiguracionGrillaEstilosAplicablesPerfiles.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tabletui_ConfiguracionGrillaEstilosAplicablesPerfiles.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdReservadoNull() {
                return this.IsNull(this.tabletui_ConfiguracionGrillaEstilosAplicablesPerfiles.IdReservadoColumn);
            }
            
            public void SetIdReservadoNull() {
                this[this.tabletui_ConfiguracionGrillaEstilosAplicablesPerfiles.IdReservadoColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tabletui_ConfiguracionGrillaEstilosAplicablesPerfiles.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tabletui_ConfiguracionGrillaEstilosAplicablesPerfiles.RowIdColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdEmpresaNull() {
                return this.IsNull(this.tabletui_ConfiguracionGrillaEstilosAplicablesPerfiles.IdEmpresaColumn);
            }
            
            public void SetIdEmpresaNull() {
                this[this.tabletui_ConfiguracionGrillaEstilosAplicablesPerfiles.IdEmpresaColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdSucursalNull() {
                return this.IsNull(this.tabletui_ConfiguracionGrillaEstilosAplicablesPerfiles.IdSucursalColumn);
            }
            
            public void SetIdSucursalNull() {
                this[this.tabletui_ConfiguracionGrillaEstilosAplicablesPerfiles.IdSucursalColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tui_ConfiguracionGrillaEstilosAplicablesPerfilesRowChangeEvent : EventArgs {
            
            private tui_ConfiguracionGrillaEstilosAplicablesPerfilesRow eventRow;
            
            private DataRowAction eventAction;
            
            public tui_ConfiguracionGrillaEstilosAplicablesPerfilesRowChangeEvent(tui_ConfiguracionGrillaEstilosAplicablesPerfilesRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public tui_ConfiguracionGrillaEstilosAplicablesPerfilesRow Row {
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
