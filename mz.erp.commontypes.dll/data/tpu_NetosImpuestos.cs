﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.2032
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
    public class tpu_NetosImpuestosDataset : DataSet {
        
        private tpu_NetosImpuestosDataTable tabletpu_NetosImpuestos;
        
        public tpu_NetosImpuestosDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected tpu_NetosImpuestosDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["tpu_NetosImpuestos"] != null)) {
                    this.Tables.Add(new tpu_NetosImpuestosDataTable(ds.Tables["tpu_NetosImpuestos"]));
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
        public tpu_NetosImpuestosDataTable tpu_NetosImpuestos {
            get {
                return this.tabletpu_NetosImpuestos;
            }
        }
        
        public override DataSet Clone() {
            tpu_NetosImpuestosDataset cln = ((tpu_NetosImpuestosDataset)(base.Clone()));
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
            if ((ds.Tables["tpu_NetosImpuestos"] != null)) {
                this.Tables.Add(new tpu_NetosImpuestosDataTable(ds.Tables["tpu_NetosImpuestos"]));
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
            this.tabletpu_NetosImpuestos = ((tpu_NetosImpuestosDataTable)(this.Tables["tpu_NetosImpuestos"]));
            if ((this.tabletpu_NetosImpuestos != null)) {
                this.tabletpu_NetosImpuestos.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "tpu_NetosImpuestosDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/tpu_NetosImpuestos.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tabletpu_NetosImpuestos = new tpu_NetosImpuestosDataTable();
            this.Tables.Add(this.tabletpu_NetosImpuestos);
        }
        
        private bool ShouldSerializetpu_NetosImpuestos() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void tpu_NetosImpuestosRowChangeEventHandler(object sender, tpu_NetosImpuestosRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tpu_NetosImpuestosDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdNetoImpuestos;
            
            private DataColumn columnIdNeto;
            
            private DataColumn columnIdImpuesto;
            
            private DataColumn columnIdTipoDeComprobante;
            
            private DataColumn columnActivo;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnIdReservado;
            
            private DataColumn columnRowId;
            
            private DataColumn columnIdEmpresa;
            
            private DataColumn columnIdSucursal;
            
            private DataColumn columnFamilia;
            
            internal tpu_NetosImpuestosDataTable() : 
                    base("tpu_NetosImpuestos") {
                this.InitClass();
            }
            
            internal tpu_NetosImpuestosDataTable(DataTable table) : 
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
            
            internal DataColumn IdNetoImpuestosColumn {
                get {
                    return this.columnIdNetoImpuestos;
                }
            }
            
            internal DataColumn IdNetoColumn {
                get {
                    return this.columnIdNeto;
                }
            }
            
            internal DataColumn IdImpuestoColumn {
                get {
                    return this.columnIdImpuesto;
                }
            }
            
            internal DataColumn IdTipoDeComprobanteColumn {
                get {
                    return this.columnIdTipoDeComprobante;
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
            
            internal DataColumn FamiliaColumn {
                get {
                    return this.columnFamilia;
                }
            }
            
            public tpu_NetosImpuestosRow this[int index] {
                get {
                    return ((tpu_NetosImpuestosRow)(this.Rows[index]));
                }
            }
            
            public event tpu_NetosImpuestosRowChangeEventHandler tpu_NetosImpuestosRowChanged;
            
            public event tpu_NetosImpuestosRowChangeEventHandler tpu_NetosImpuestosRowChanging;
            
            public event tpu_NetosImpuestosRowChangeEventHandler tpu_NetosImpuestosRowDeleted;
            
            public event tpu_NetosImpuestosRowChangeEventHandler tpu_NetosImpuestosRowDeleting;
            
            public void Addtpu_NetosImpuestosRow(tpu_NetosImpuestosRow row) {
                this.Rows.Add(row);
            }
            
            public tpu_NetosImpuestosRow Addtpu_NetosImpuestosRow(long IdNetoImpuestos, long IdNeto, string IdImpuesto, string IdTipoDeComprobante, bool Activo, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, System.Guid RowId, long IdEmpresa, long IdSucursal, string Familia) {
                tpu_NetosImpuestosRow rowtpu_NetosImpuestosRow = ((tpu_NetosImpuestosRow)(this.NewRow()));
                rowtpu_NetosImpuestosRow.ItemArray = new object[] {
                        IdNetoImpuestos,
                        IdNeto,
                        IdImpuesto,
                        IdTipoDeComprobante,
                        Activo,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        IdReservado,
                        RowId,
                        IdEmpresa,
                        IdSucursal,
                        Familia};
                this.Rows.Add(rowtpu_NetosImpuestosRow);
                return rowtpu_NetosImpuestosRow;
            }
            
            public tpu_NetosImpuestosRow FindByIdNetoImpuestos(long IdNetoImpuestos) {
                return ((tpu_NetosImpuestosRow)(this.Rows.Find(new object[] {
                            IdNetoImpuestos})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                tpu_NetosImpuestosDataTable cln = ((tpu_NetosImpuestosDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new tpu_NetosImpuestosDataTable();
            }
            
            internal void InitVars() {
                this.columnIdNetoImpuestos = this.Columns["IdNetoImpuestos"];
                this.columnIdNeto = this.Columns["IdNeto"];
                this.columnIdImpuesto = this.Columns["IdImpuesto"];
                this.columnIdTipoDeComprobante = this.Columns["IdTipoDeComprobante"];
                this.columnActivo = this.Columns["Activo"];
                this.columnFechaCreacion = this.Columns["FechaCreacion"];
                this.columnIdConexionCreacion = this.Columns["IdConexionCreacion"];
                this.columnUltimaModificacion = this.Columns["UltimaModificacion"];
                this.columnIdConexionUltimaModificacion = this.Columns["IdConexionUltimaModificacion"];
                this.columnIdReservado = this.Columns["IdReservado"];
                this.columnRowId = this.Columns["RowId"];
                this.columnIdEmpresa = this.Columns["IdEmpresa"];
                this.columnIdSucursal = this.Columns["IdSucursal"];
                this.columnFamilia = this.Columns["Familia"];
            }
            
            private void InitClass() {
                this.columnIdNetoImpuestos = new DataColumn("IdNetoImpuestos", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdNetoImpuestos);
                this.columnIdNeto = new DataColumn("IdNeto", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdNeto);
                this.columnIdImpuesto = new DataColumn("IdImpuesto", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdImpuesto);
                this.columnIdTipoDeComprobante = new DataColumn("IdTipoDeComprobante", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdTipoDeComprobante);
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
                this.columnFamilia = new DataColumn("Familia", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnFamilia);
                this.Constraints.Add(new UniqueConstraint("tpu_NetosImpuestosKey1", new DataColumn[] {
                                this.columnIdNetoImpuestos}, true));
                this.columnIdNetoImpuestos.AllowDBNull = false;
                this.columnIdNetoImpuestos.Unique = true;
                this.columnIdNeto.AllowDBNull = false;
                this.columnIdImpuesto.AllowDBNull = false;
                this.columnIdTipoDeComprobante.AllowDBNull = false;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public tpu_NetosImpuestosRow Newtpu_NetosImpuestosRow() {
                return ((tpu_NetosImpuestosRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new tpu_NetosImpuestosRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(tpu_NetosImpuestosRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.tpu_NetosImpuestosRowChanged != null)) {
                    this.tpu_NetosImpuestosRowChanged(this, new tpu_NetosImpuestosRowChangeEvent(((tpu_NetosImpuestosRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.tpu_NetosImpuestosRowChanging != null)) {
                    this.tpu_NetosImpuestosRowChanging(this, new tpu_NetosImpuestosRowChangeEvent(((tpu_NetosImpuestosRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.tpu_NetosImpuestosRowDeleted != null)) {
                    this.tpu_NetosImpuestosRowDeleted(this, new tpu_NetosImpuestosRowChangeEvent(((tpu_NetosImpuestosRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.tpu_NetosImpuestosRowDeleting != null)) {
                    this.tpu_NetosImpuestosRowDeleting(this, new tpu_NetosImpuestosRowChangeEvent(((tpu_NetosImpuestosRow)(e.Row)), e.Action));
                }
            }
            
            public void Removetpu_NetosImpuestosRow(tpu_NetosImpuestosRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tpu_NetosImpuestosRow : DataRow {
            
            private tpu_NetosImpuestosDataTable tabletpu_NetosImpuestos;
            
            internal tpu_NetosImpuestosRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tabletpu_NetosImpuestos = ((tpu_NetosImpuestosDataTable)(this.Table));
            }
            
            public long IdNetoImpuestos {
                get {
                    return ((long)(this[this.tabletpu_NetosImpuestos.IdNetoImpuestosColumn]));
                }
                set {
                    this[this.tabletpu_NetosImpuestos.IdNetoImpuestosColumn] = value;
                }
            }
            
            public long IdNeto {
                get {
                    return ((long)(this[this.tabletpu_NetosImpuestos.IdNetoColumn]));
                }
                set {
                    this[this.tabletpu_NetosImpuestos.IdNetoColumn] = value;
                }
            }
            
            public string IdImpuesto {
                get {
                    return ((string)(this[this.tabletpu_NetosImpuestos.IdImpuestoColumn]));
                }
                set {
                    this[this.tabletpu_NetosImpuestos.IdImpuestoColumn] = value;
                }
            }
            
            public string IdTipoDeComprobante {
                get {
                    return ((string)(this[this.tabletpu_NetosImpuestos.IdTipoDeComprobanteColumn]));
                }
                set {
                    this[this.tabletpu_NetosImpuestos.IdTipoDeComprobanteColumn] = value;
                }
            }
            
            public bool Activo {
                get {
                    try {
                        return ((bool)(this[this.tabletpu_NetosImpuestos.ActivoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletpu_NetosImpuestos.ActivoColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    try {
                        return ((System.DateTime)(this[this.tabletpu_NetosImpuestos.FechaCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletpu_NetosImpuestos.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    try {
                        return ((long)(this[this.tabletpu_NetosImpuestos.IdConexionCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletpu_NetosImpuestos.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tabletpu_NetosImpuestos.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletpu_NetosImpuestos.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tabletpu_NetosImpuestos.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletpu_NetosImpuestos.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public long IdReservado {
                get {
                    try {
                        return ((long)(this[this.tabletpu_NetosImpuestos.IdReservadoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletpu_NetosImpuestos.IdReservadoColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tabletpu_NetosImpuestos.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletpu_NetosImpuestos.RowIdColumn] = value;
                }
            }
            
            public long IdEmpresa {
                get {
                    try {
                        return ((long)(this[this.tabletpu_NetosImpuestos.IdEmpresaColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletpu_NetosImpuestos.IdEmpresaColumn] = value;
                }
            }
            
            public long IdSucursal {
                get {
                    try {
                        return ((long)(this[this.tabletpu_NetosImpuestos.IdSucursalColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletpu_NetosImpuestos.IdSucursalColumn] = value;
                }
            }
            
            public string Familia {
                get {
                    try {
                        return ((string)(this[this.tabletpu_NetosImpuestos.FamiliaColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletpu_NetosImpuestos.FamiliaColumn] = value;
                }
            }
            
            public bool IsActivoNull() {
                return this.IsNull(this.tabletpu_NetosImpuestos.ActivoColumn);
            }
            
            public void SetActivoNull() {
                this[this.tabletpu_NetosImpuestos.ActivoColumn] = System.Convert.DBNull;
            }
            
            public bool IsFechaCreacionNull() {
                return this.IsNull(this.tabletpu_NetosImpuestos.FechaCreacionColumn);
            }
            
            public void SetFechaCreacionNull() {
                this[this.tabletpu_NetosImpuestos.FechaCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionCreacionNull() {
                return this.IsNull(this.tabletpu_NetosImpuestos.IdConexionCreacionColumn);
            }
            
            public void SetIdConexionCreacionNull() {
                this[this.tabletpu_NetosImpuestos.IdConexionCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tabletpu_NetosImpuestos.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tabletpu_NetosImpuestos.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tabletpu_NetosImpuestos.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tabletpu_NetosImpuestos.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdReservadoNull() {
                return this.IsNull(this.tabletpu_NetosImpuestos.IdReservadoColumn);
            }
            
            public void SetIdReservadoNull() {
                this[this.tabletpu_NetosImpuestos.IdReservadoColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tabletpu_NetosImpuestos.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tabletpu_NetosImpuestos.RowIdColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdEmpresaNull() {
                return this.IsNull(this.tabletpu_NetosImpuestos.IdEmpresaColumn);
            }
            
            public void SetIdEmpresaNull() {
                this[this.tabletpu_NetosImpuestos.IdEmpresaColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdSucursalNull() {
                return this.IsNull(this.tabletpu_NetosImpuestos.IdSucursalColumn);
            }
            
            public void SetIdSucursalNull() {
                this[this.tabletpu_NetosImpuestos.IdSucursalColumn] = System.Convert.DBNull;
            }
            
            public bool IsFamiliaNull() {
                return this.IsNull(this.tabletpu_NetosImpuestos.FamiliaColumn);
            }
            
            public void SetFamiliaNull() {
                this[this.tabletpu_NetosImpuestos.FamiliaColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tpu_NetosImpuestosRowChangeEvent : EventArgs {
            
            private tpu_NetosImpuestosRow eventRow;
            
            private DataRowAction eventAction;
            
            public tpu_NetosImpuestosRowChangeEvent(tpu_NetosImpuestosRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public tpu_NetosImpuestosRow Row {
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
