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
    public class tsh_ListasDePreciosDataset : DataSet {
        
        private tsh_ListasDePreciosDataTable tabletsh_ListasDePrecios;
        
        public tsh_ListasDePreciosDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected tsh_ListasDePreciosDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["tsh_ListasDePrecios"] != null)) {
                    this.Tables.Add(new tsh_ListasDePreciosDataTable(ds.Tables["tsh_ListasDePrecios"]));
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
        public tsh_ListasDePreciosDataTable tsh_ListasDePrecios {
            get {
                return this.tabletsh_ListasDePrecios;
            }
        }
        
        public override DataSet Clone() {
            tsh_ListasDePreciosDataset cln = ((tsh_ListasDePreciosDataset)(base.Clone()));
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
            if ((ds.Tables["tsh_ListasDePrecios"] != null)) {
                this.Tables.Add(new tsh_ListasDePreciosDataTable(ds.Tables["tsh_ListasDePrecios"]));
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
            this.tabletsh_ListasDePrecios = ((tsh_ListasDePreciosDataTable)(this.Tables["tsh_ListasDePrecios"]));
            if ((this.tabletsh_ListasDePrecios != null)) {
                this.tabletsh_ListasDePrecios.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "tsh_ListasDePreciosDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/tsh_ListasDePrecios.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tabletsh_ListasDePrecios = new tsh_ListasDePreciosDataTable();
            this.Tables.Add(this.tabletsh_ListasDePrecios);
        }
        
        private bool ShouldSerializetsh_ListasDePrecios() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void tsh_ListasDePreciosRowChangeEventHandler(object sender, tsh_ListasDePreciosRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsh_ListasDePreciosDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdListaDePrecio;
            
            private DataColumn columnDescripcion;
            
            private DataColumn columnCodigo;
            
            private DataColumn columnCoeficiente;
            
            private DataColumn columnActivo;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnIdReservado;
            
            private DataColumn columnRowId;
            
            private DataColumn columnIdEmpresa;
            
            private DataColumn columnIdSucursal;
            
            private DataColumn columnisDefault;
            
            internal tsh_ListasDePreciosDataTable() : 
                    base("tsh_ListasDePrecios") {
                this.InitClass();
            }
            
            internal tsh_ListasDePreciosDataTable(DataTable table) : 
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
            
            internal DataColumn IdListaDePrecioColumn {
                get {
                    return this.columnIdListaDePrecio;
                }
            }
            
            internal DataColumn DescripcionColumn {
                get {
                    return this.columnDescripcion;
                }
            }
            
            internal DataColumn CodigoColumn {
                get {
                    return this.columnCodigo;
                }
            }
            
            internal DataColumn CoeficienteColumn {
                get {
                    return this.columnCoeficiente;
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
            
            internal DataColumn isDefaultColumn {
                get {
                    return this.columnisDefault;
                }
            }
            
            public tsh_ListasDePreciosRow this[int index] {
                get {
                    return ((tsh_ListasDePreciosRow)(this.Rows[index]));
                }
            }
            
            public event tsh_ListasDePreciosRowChangeEventHandler tsh_ListasDePreciosRowChanged;
            
            public event tsh_ListasDePreciosRowChangeEventHandler tsh_ListasDePreciosRowChanging;
            
            public event tsh_ListasDePreciosRowChangeEventHandler tsh_ListasDePreciosRowDeleted;
            
            public event tsh_ListasDePreciosRowChangeEventHandler tsh_ListasDePreciosRowDeleting;
            
            public void Addtsh_ListasDePreciosRow(tsh_ListasDePreciosRow row) {
                this.Rows.Add(row);
            }
            
            public tsh_ListasDePreciosRow Addtsh_ListasDePreciosRow(string IdListaDePrecio, string Descripcion, string Codigo, System.Decimal Coeficiente, bool Activo, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, System.Guid RowId, long IdEmpresa, long IdSucursal, bool isDefault) {
                tsh_ListasDePreciosRow rowtsh_ListasDePreciosRow = ((tsh_ListasDePreciosRow)(this.NewRow()));
                rowtsh_ListasDePreciosRow.ItemArray = new object[] {
                        IdListaDePrecio,
                        Descripcion,
                        Codigo,
                        Coeficiente,
                        Activo,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        IdReservado,
                        RowId,
                        IdEmpresa,
                        IdSucursal,
                        isDefault};
                this.Rows.Add(rowtsh_ListasDePreciosRow);
                return rowtsh_ListasDePreciosRow;
            }
            
            public tsh_ListasDePreciosRow FindByIdListaDePrecio(string IdListaDePrecio) {
                return ((tsh_ListasDePreciosRow)(this.Rows.Find(new object[] {
                            IdListaDePrecio})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                tsh_ListasDePreciosDataTable cln = ((tsh_ListasDePreciosDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new tsh_ListasDePreciosDataTable();
            }
            
            internal void InitVars() {
                this.columnIdListaDePrecio = this.Columns["IdListaDePrecio"];
                this.columnDescripcion = this.Columns["Descripcion"];
                this.columnCodigo = this.Columns["Codigo"];
                this.columnCoeficiente = this.Columns["Coeficiente"];
                this.columnActivo = this.Columns["Activo"];
                this.columnFechaCreacion = this.Columns["FechaCreacion"];
                this.columnIdConexionCreacion = this.Columns["IdConexionCreacion"];
                this.columnUltimaModificacion = this.Columns["UltimaModificacion"];
                this.columnIdConexionUltimaModificacion = this.Columns["IdConexionUltimaModificacion"];
                this.columnIdReservado = this.Columns["IdReservado"];
                this.columnRowId = this.Columns["RowId"];
                this.columnIdEmpresa = this.Columns["IdEmpresa"];
                this.columnIdSucursal = this.Columns["IdSucursal"];
                this.columnisDefault = this.Columns["isDefault"];
            }
            
            private void InitClass() {
                this.columnIdListaDePrecio = new DataColumn("IdListaDePrecio", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdListaDePrecio);
                this.columnDescripcion = new DataColumn("Descripcion", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnDescripcion);
                this.columnCodigo = new DataColumn("Codigo", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCodigo);
                this.columnCoeficiente = new DataColumn("Coeficiente", typeof(System.Decimal), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCoeficiente);
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
                this.columnisDefault = new DataColumn("isDefault", typeof(bool), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnisDefault);
                this.Constraints.Add(new UniqueConstraint("tsh_ListasDePreciosDatasetKey1", new DataColumn[] {
                                this.columnIdListaDePrecio}, true));
                this.columnIdListaDePrecio.AllowDBNull = false;
                this.columnIdListaDePrecio.Unique = true;
                this.columnCodigo.AllowDBNull = false;
                this.columnCoeficiente.AllowDBNull = false;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public tsh_ListasDePreciosRow Newtsh_ListasDePreciosRow() {
                return ((tsh_ListasDePreciosRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new tsh_ListasDePreciosRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(tsh_ListasDePreciosRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.tsh_ListasDePreciosRowChanged != null)) {
                    this.tsh_ListasDePreciosRowChanged(this, new tsh_ListasDePreciosRowChangeEvent(((tsh_ListasDePreciosRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.tsh_ListasDePreciosRowChanging != null)) {
                    this.tsh_ListasDePreciosRowChanging(this, new tsh_ListasDePreciosRowChangeEvent(((tsh_ListasDePreciosRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.tsh_ListasDePreciosRowDeleted != null)) {
                    this.tsh_ListasDePreciosRowDeleted(this, new tsh_ListasDePreciosRowChangeEvent(((tsh_ListasDePreciosRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.tsh_ListasDePreciosRowDeleting != null)) {
                    this.tsh_ListasDePreciosRowDeleting(this, new tsh_ListasDePreciosRowChangeEvent(((tsh_ListasDePreciosRow)(e.Row)), e.Action));
                }
            }
            
            public void Removetsh_ListasDePreciosRow(tsh_ListasDePreciosRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsh_ListasDePreciosRow : DataRow {
            
            private tsh_ListasDePreciosDataTable tabletsh_ListasDePrecios;
            
            internal tsh_ListasDePreciosRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tabletsh_ListasDePrecios = ((tsh_ListasDePreciosDataTable)(this.Table));
            }
            
            public string IdListaDePrecio {
                get {
                    return ((string)(this[this.tabletsh_ListasDePrecios.IdListaDePrecioColumn]));
                }
                set {
                    this[this.tabletsh_ListasDePrecios.IdListaDePrecioColumn] = value;
                }
            }
            
            public string Descripcion {
                get {
                    try {
                        return ((string)(this[this.tabletsh_ListasDePrecios.DescripcionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_ListasDePrecios.DescripcionColumn] = value;
                }
            }
            
            public string Codigo {
                get {
                    return ((string)(this[this.tabletsh_ListasDePrecios.CodigoColumn]));
                }
                set {
                    this[this.tabletsh_ListasDePrecios.CodigoColumn] = value;
                }
            }
            
            public System.Decimal Coeficiente {
                get {
                    return ((System.Decimal)(this[this.tabletsh_ListasDePrecios.CoeficienteColumn]));
                }
                set {
                    this[this.tabletsh_ListasDePrecios.CoeficienteColumn] = value;
                }
            }
            
            public bool Activo {
                get {
                    try {
                        return ((bool)(this[this.tabletsh_ListasDePrecios.ActivoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_ListasDePrecios.ActivoColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    try {
                        return ((System.DateTime)(this[this.tabletsh_ListasDePrecios.FechaCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_ListasDePrecios.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    try {
                        return ((long)(this[this.tabletsh_ListasDePrecios.IdConexionCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_ListasDePrecios.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tabletsh_ListasDePrecios.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_ListasDePrecios.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tabletsh_ListasDePrecios.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_ListasDePrecios.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public long IdReservado {
                get {
                    try {
                        return ((long)(this[this.tabletsh_ListasDePrecios.IdReservadoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_ListasDePrecios.IdReservadoColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tabletsh_ListasDePrecios.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_ListasDePrecios.RowIdColumn] = value;
                }
            }
            
            public long IdEmpresa {
                get {
                    try {
                        return ((long)(this[this.tabletsh_ListasDePrecios.IdEmpresaColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_ListasDePrecios.IdEmpresaColumn] = value;
                }
            }
            
            public long IdSucursal {
                get {
                    try {
                        return ((long)(this[this.tabletsh_ListasDePrecios.IdSucursalColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_ListasDePrecios.IdSucursalColumn] = value;
                }
            }
            
            public bool isDefault {
                get {
                    try {
                        return ((bool)(this[this.tabletsh_ListasDePrecios.isDefaultColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_ListasDePrecios.isDefaultColumn] = value;
                }
            }
            
            public bool IsDescripcionNull() {
                return this.IsNull(this.tabletsh_ListasDePrecios.DescripcionColumn);
            }
            
            public void SetDescripcionNull() {
                this[this.tabletsh_ListasDePrecios.DescripcionColumn] = System.Convert.DBNull;
            }
            
            public bool IsActivoNull() {
                return this.IsNull(this.tabletsh_ListasDePrecios.ActivoColumn);
            }
            
            public void SetActivoNull() {
                this[this.tabletsh_ListasDePrecios.ActivoColumn] = System.Convert.DBNull;
            }
            
            public bool IsFechaCreacionNull() {
                return this.IsNull(this.tabletsh_ListasDePrecios.FechaCreacionColumn);
            }
            
            public void SetFechaCreacionNull() {
                this[this.tabletsh_ListasDePrecios.FechaCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionCreacionNull() {
                return this.IsNull(this.tabletsh_ListasDePrecios.IdConexionCreacionColumn);
            }
            
            public void SetIdConexionCreacionNull() {
                this[this.tabletsh_ListasDePrecios.IdConexionCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tabletsh_ListasDePrecios.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tabletsh_ListasDePrecios.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tabletsh_ListasDePrecios.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tabletsh_ListasDePrecios.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdReservadoNull() {
                return this.IsNull(this.tabletsh_ListasDePrecios.IdReservadoColumn);
            }
            
            public void SetIdReservadoNull() {
                this[this.tabletsh_ListasDePrecios.IdReservadoColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tabletsh_ListasDePrecios.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tabletsh_ListasDePrecios.RowIdColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdEmpresaNull() {
                return this.IsNull(this.tabletsh_ListasDePrecios.IdEmpresaColumn);
            }
            
            public void SetIdEmpresaNull() {
                this[this.tabletsh_ListasDePrecios.IdEmpresaColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdSucursalNull() {
                return this.IsNull(this.tabletsh_ListasDePrecios.IdSucursalColumn);
            }
            
            public void SetIdSucursalNull() {
                this[this.tabletsh_ListasDePrecios.IdSucursalColumn] = System.Convert.DBNull;
            }
            
            public bool IsisDefaultNull() {
                return this.IsNull(this.tabletsh_ListasDePrecios.isDefaultColumn);
            }
            
            public void SetisDefaultNull() {
                this[this.tabletsh_ListasDePrecios.isDefaultColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsh_ListasDePreciosRowChangeEvent : EventArgs {
            
            private tsh_ListasDePreciosRow eventRow;
            
            private DataRowAction eventAction;
            
            public tsh_ListasDePreciosRowChangeEvent(tsh_ListasDePreciosRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public tsh_ListasDePreciosRow Row {
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
