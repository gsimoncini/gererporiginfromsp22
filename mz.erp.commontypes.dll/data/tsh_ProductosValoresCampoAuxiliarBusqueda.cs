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
    public class tsh_ProductosValoresCampoAuxiliarBusquedaDataset : DataSet {
        
        private tsh_ProductosValoresCampoAuxiliarBusquedaDataTable tabletsh_ProductosValoresCampoAuxiliarBusqueda;
        
        public tsh_ProductosValoresCampoAuxiliarBusquedaDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected tsh_ProductosValoresCampoAuxiliarBusquedaDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["tsh_ProductosValoresCampoAuxiliarBusqueda"] != null)) {
                    this.Tables.Add(new tsh_ProductosValoresCampoAuxiliarBusquedaDataTable(ds.Tables["tsh_ProductosValoresCampoAuxiliarBusqueda"]));
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
        public tsh_ProductosValoresCampoAuxiliarBusquedaDataTable tsh_ProductosValoresCampoAuxiliarBusqueda {
            get {
                return this.tabletsh_ProductosValoresCampoAuxiliarBusqueda;
            }
        }
        
        public override DataSet Clone() {
            tsh_ProductosValoresCampoAuxiliarBusquedaDataset cln = ((tsh_ProductosValoresCampoAuxiliarBusquedaDataset)(base.Clone()));
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
            if ((ds.Tables["tsh_ProductosValoresCampoAuxiliarBusqueda"] != null)) {
                this.Tables.Add(new tsh_ProductosValoresCampoAuxiliarBusquedaDataTable(ds.Tables["tsh_ProductosValoresCampoAuxiliarBusqueda"]));
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
            this.tabletsh_ProductosValoresCampoAuxiliarBusqueda = ((tsh_ProductosValoresCampoAuxiliarBusquedaDataTable)(this.Tables["tsh_ProductosValoresCampoAuxiliarBusqueda"]));
            if ((this.tabletsh_ProductosValoresCampoAuxiliarBusqueda != null)) {
                this.tabletsh_ProductosValoresCampoAuxiliarBusqueda.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "tsh_ProductosValoresCampoAuxiliarBusquedaDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/tsh_ProductosValoresCampoAuxiliarBusqueda.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tabletsh_ProductosValoresCampoAuxiliarBusqueda = new tsh_ProductosValoresCampoAuxiliarBusquedaDataTable();
            this.Tables.Add(this.tabletsh_ProductosValoresCampoAuxiliarBusqueda);
        }
        
        private bool ShouldSerializetsh_ProductosValoresCampoAuxiliarBusqueda() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void tsh_ProductosValoresCampoAuxiliarBusquedaRowChangeEventHandler(object sender, tsh_ProductosValoresCampoAuxiliarBusquedaRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsh_ProductosValoresCampoAuxiliarBusquedaDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdCampoBusqueda;
            
            private DataColumn columnDescripcion;
            
            private DataColumn columnActivo;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnIdReservado;
            
            private DataColumn columnRowId;
            
            private DataColumn columnIdEmpresa;
            
            private DataColumn columnIdSucursal;
            
            internal tsh_ProductosValoresCampoAuxiliarBusquedaDataTable() : 
                    base("tsh_ProductosValoresCampoAuxiliarBusqueda") {
                this.InitClass();
            }
            
            internal tsh_ProductosValoresCampoAuxiliarBusquedaDataTable(DataTable table) : 
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
            
            internal DataColumn IdCampoBusquedaColumn {
                get {
                    return this.columnIdCampoBusqueda;
                }
            }
            
            internal DataColumn DescripcionColumn {
                get {
                    return this.columnDescripcion;
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
            
            public tsh_ProductosValoresCampoAuxiliarBusquedaRow this[int index] {
                get {
                    return ((tsh_ProductosValoresCampoAuxiliarBusquedaRow)(this.Rows[index]));
                }
            }
            
            public event tsh_ProductosValoresCampoAuxiliarBusquedaRowChangeEventHandler tsh_ProductosValoresCampoAuxiliarBusquedaRowChanged;
            
            public event tsh_ProductosValoresCampoAuxiliarBusquedaRowChangeEventHandler tsh_ProductosValoresCampoAuxiliarBusquedaRowChanging;
            
            public event tsh_ProductosValoresCampoAuxiliarBusquedaRowChangeEventHandler tsh_ProductosValoresCampoAuxiliarBusquedaRowDeleted;
            
            public event tsh_ProductosValoresCampoAuxiliarBusquedaRowChangeEventHandler tsh_ProductosValoresCampoAuxiliarBusquedaRowDeleting;
            
            public void Addtsh_ProductosValoresCampoAuxiliarBusquedaRow(tsh_ProductosValoresCampoAuxiliarBusquedaRow row) {
                this.Rows.Add(row);
            }
            
            public tsh_ProductosValoresCampoAuxiliarBusquedaRow Addtsh_ProductosValoresCampoAuxiliarBusquedaRow(string IdCampoBusqueda, string Descripcion, bool Activo, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, System.Guid RowId, long IdEmpresa, long IdSucursal) {
                tsh_ProductosValoresCampoAuxiliarBusquedaRow rowtsh_ProductosValoresCampoAuxiliarBusquedaRow = ((tsh_ProductosValoresCampoAuxiliarBusquedaRow)(this.NewRow()));
                rowtsh_ProductosValoresCampoAuxiliarBusquedaRow.ItemArray = new object[] {
                        IdCampoBusqueda,
                        Descripcion,
                        Activo,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        IdReservado,
                        RowId,
                        IdEmpresa,
                        IdSucursal};
                this.Rows.Add(rowtsh_ProductosValoresCampoAuxiliarBusquedaRow);
                return rowtsh_ProductosValoresCampoAuxiliarBusquedaRow;
            }
            
            public tsh_ProductosValoresCampoAuxiliarBusquedaRow FindByIdCampoBusqueda(string IdCampoBusqueda) {
                return ((tsh_ProductosValoresCampoAuxiliarBusquedaRow)(this.Rows.Find(new object[] {
                            IdCampoBusqueda})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                tsh_ProductosValoresCampoAuxiliarBusquedaDataTable cln = ((tsh_ProductosValoresCampoAuxiliarBusquedaDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new tsh_ProductosValoresCampoAuxiliarBusquedaDataTable();
            }
            
            internal void InitVars() {
                this.columnIdCampoBusqueda = this.Columns["IdCampoBusqueda"];
                this.columnDescripcion = this.Columns["Descripcion"];
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
                this.columnIdCampoBusqueda = new DataColumn("IdCampoBusqueda", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdCampoBusqueda);
                this.columnDescripcion = new DataColumn("Descripcion", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnDescripcion);
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
                this.Constraints.Add(new UniqueConstraint("tsh_ProductosValoresCampoAuxiliarBusquedaKey1", new DataColumn[] {
                                this.columnIdCampoBusqueda}, true));
                this.columnIdCampoBusqueda.AllowDBNull = false;
                this.columnIdCampoBusqueda.Unique = true;
                this.columnDescripcion.AllowDBNull = false;
                this.columnActivo.AllowDBNull = false;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public tsh_ProductosValoresCampoAuxiliarBusquedaRow Newtsh_ProductosValoresCampoAuxiliarBusquedaRow() {
                return ((tsh_ProductosValoresCampoAuxiliarBusquedaRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new tsh_ProductosValoresCampoAuxiliarBusquedaRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(tsh_ProductosValoresCampoAuxiliarBusquedaRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.tsh_ProductosValoresCampoAuxiliarBusquedaRowChanged != null)) {
                    this.tsh_ProductosValoresCampoAuxiliarBusquedaRowChanged(this, new tsh_ProductosValoresCampoAuxiliarBusquedaRowChangeEvent(((tsh_ProductosValoresCampoAuxiliarBusquedaRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.tsh_ProductosValoresCampoAuxiliarBusquedaRowChanging != null)) {
                    this.tsh_ProductosValoresCampoAuxiliarBusquedaRowChanging(this, new tsh_ProductosValoresCampoAuxiliarBusquedaRowChangeEvent(((tsh_ProductosValoresCampoAuxiliarBusquedaRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.tsh_ProductosValoresCampoAuxiliarBusquedaRowDeleted != null)) {
                    this.tsh_ProductosValoresCampoAuxiliarBusquedaRowDeleted(this, new tsh_ProductosValoresCampoAuxiliarBusquedaRowChangeEvent(((tsh_ProductosValoresCampoAuxiliarBusquedaRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.tsh_ProductosValoresCampoAuxiliarBusquedaRowDeleting != null)) {
                    this.tsh_ProductosValoresCampoAuxiliarBusquedaRowDeleting(this, new tsh_ProductosValoresCampoAuxiliarBusquedaRowChangeEvent(((tsh_ProductosValoresCampoAuxiliarBusquedaRow)(e.Row)), e.Action));
                }
            }
            
            public void Removetsh_ProductosValoresCampoAuxiliarBusquedaRow(tsh_ProductosValoresCampoAuxiliarBusquedaRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsh_ProductosValoresCampoAuxiliarBusquedaRow : DataRow {
            
            private tsh_ProductosValoresCampoAuxiliarBusquedaDataTable tabletsh_ProductosValoresCampoAuxiliarBusqueda;
            
            internal tsh_ProductosValoresCampoAuxiliarBusquedaRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tabletsh_ProductosValoresCampoAuxiliarBusqueda = ((tsh_ProductosValoresCampoAuxiliarBusquedaDataTable)(this.Table));
            }
            
            public string IdCampoBusqueda {
                get {
                    return ((string)(this[this.tabletsh_ProductosValoresCampoAuxiliarBusqueda.IdCampoBusquedaColumn]));
                }
                set {
                    this[this.tabletsh_ProductosValoresCampoAuxiliarBusqueda.IdCampoBusquedaColumn] = value;
                }
            }
            
            public string Descripcion {
                get {
                    return ((string)(this[this.tabletsh_ProductosValoresCampoAuxiliarBusqueda.DescripcionColumn]));
                }
                set {
                    this[this.tabletsh_ProductosValoresCampoAuxiliarBusqueda.DescripcionColumn] = value;
                }
            }
            
            public bool Activo {
                get {
                    return ((bool)(this[this.tabletsh_ProductosValoresCampoAuxiliarBusqueda.ActivoColumn]));
                }
                set {
                    this[this.tabletsh_ProductosValoresCampoAuxiliarBusqueda.ActivoColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    try {
                        return ((System.DateTime)(this[this.tabletsh_ProductosValoresCampoAuxiliarBusqueda.FechaCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_ProductosValoresCampoAuxiliarBusqueda.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    try {
                        return ((long)(this[this.tabletsh_ProductosValoresCampoAuxiliarBusqueda.IdConexionCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_ProductosValoresCampoAuxiliarBusqueda.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tabletsh_ProductosValoresCampoAuxiliarBusqueda.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_ProductosValoresCampoAuxiliarBusqueda.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tabletsh_ProductosValoresCampoAuxiliarBusqueda.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_ProductosValoresCampoAuxiliarBusqueda.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public long IdReservado {
                get {
                    try {
                        return ((long)(this[this.tabletsh_ProductosValoresCampoAuxiliarBusqueda.IdReservadoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_ProductosValoresCampoAuxiliarBusqueda.IdReservadoColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tabletsh_ProductosValoresCampoAuxiliarBusqueda.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_ProductosValoresCampoAuxiliarBusqueda.RowIdColumn] = value;
                }
            }
            
            public long IdEmpresa {
                get {
                    try {
                        return ((long)(this[this.tabletsh_ProductosValoresCampoAuxiliarBusqueda.IdEmpresaColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_ProductosValoresCampoAuxiliarBusqueda.IdEmpresaColumn] = value;
                }
            }
            
            public long IdSucursal {
                get {
                    try {
                        return ((long)(this[this.tabletsh_ProductosValoresCampoAuxiliarBusqueda.IdSucursalColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_ProductosValoresCampoAuxiliarBusqueda.IdSucursalColumn] = value;
                }
            }
            
            public bool IsFechaCreacionNull() {
                return this.IsNull(this.tabletsh_ProductosValoresCampoAuxiliarBusqueda.FechaCreacionColumn);
            }
            
            public void SetFechaCreacionNull() {
                this[this.tabletsh_ProductosValoresCampoAuxiliarBusqueda.FechaCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionCreacionNull() {
                return this.IsNull(this.tabletsh_ProductosValoresCampoAuxiliarBusqueda.IdConexionCreacionColumn);
            }
            
            public void SetIdConexionCreacionNull() {
                this[this.tabletsh_ProductosValoresCampoAuxiliarBusqueda.IdConexionCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tabletsh_ProductosValoresCampoAuxiliarBusqueda.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tabletsh_ProductosValoresCampoAuxiliarBusqueda.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tabletsh_ProductosValoresCampoAuxiliarBusqueda.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tabletsh_ProductosValoresCampoAuxiliarBusqueda.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdReservadoNull() {
                return this.IsNull(this.tabletsh_ProductosValoresCampoAuxiliarBusqueda.IdReservadoColumn);
            }
            
            public void SetIdReservadoNull() {
                this[this.tabletsh_ProductosValoresCampoAuxiliarBusqueda.IdReservadoColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tabletsh_ProductosValoresCampoAuxiliarBusqueda.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tabletsh_ProductosValoresCampoAuxiliarBusqueda.RowIdColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdEmpresaNull() {
                return this.IsNull(this.tabletsh_ProductosValoresCampoAuxiliarBusqueda.IdEmpresaColumn);
            }
            
            public void SetIdEmpresaNull() {
                this[this.tabletsh_ProductosValoresCampoAuxiliarBusqueda.IdEmpresaColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdSucursalNull() {
                return this.IsNull(this.tabletsh_ProductosValoresCampoAuxiliarBusqueda.IdSucursalColumn);
            }
            
            public void SetIdSucursalNull() {
                this[this.tabletsh_ProductosValoresCampoAuxiliarBusqueda.IdSucursalColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsh_ProductosValoresCampoAuxiliarBusquedaRowChangeEvent : EventArgs {
            
            private tsh_ProductosValoresCampoAuxiliarBusquedaRow eventRow;
            
            private DataRowAction eventAction;
            
            public tsh_ProductosValoresCampoAuxiliarBusquedaRowChangeEvent(tsh_ProductosValoresCampoAuxiliarBusquedaRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public tsh_ProductosValoresCampoAuxiliarBusquedaRow Row {
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