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
    public class tsy_TiposMovimientosExDataset : DataSet {
        
        private tsy_TiposMovimientosDataTable tabletsy_TiposMovimientos;
        
        public tsy_TiposMovimientosExDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected tsy_TiposMovimientosExDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["tsy_TiposMovimientos"] != null)) {
                    this.Tables.Add(new tsy_TiposMovimientosDataTable(ds.Tables["tsy_TiposMovimientos"]));
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
        public tsy_TiposMovimientosDataTable tsy_TiposMovimientos {
            get {
                return this.tabletsy_TiposMovimientos;
            }
        }
        
        public override DataSet Clone() {
            tsy_TiposMovimientosExDataset cln = ((tsy_TiposMovimientosExDataset)(base.Clone()));
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
            if ((ds.Tables["tsy_TiposMovimientos"] != null)) {
                this.Tables.Add(new tsy_TiposMovimientosDataTable(ds.Tables["tsy_TiposMovimientos"]));
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
            this.tabletsy_TiposMovimientos = ((tsy_TiposMovimientosDataTable)(this.Tables["tsy_TiposMovimientos"]));
            if ((this.tabletsy_TiposMovimientos != null)) {
                this.tabletsy_TiposMovimientos.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "tsy_TiposMovimientosExDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/tsy_TiposMovimientosEx.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tabletsy_TiposMovimientos = new tsy_TiposMovimientosDataTable();
            this.Tables.Add(this.tabletsy_TiposMovimientos);
        }
        
        private bool ShouldSerializetsy_TiposMovimientos() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void tsy_TiposMovimientosRowChangeEventHandler(object sender, tsy_TiposMovimientosRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsy_TiposMovimientosDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdTipoMovimiento;
            
            private DataColumn columnAfectaStock;
            
            private DataColumn columnDescripcion;
            
            private DataColumn columnSistema;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnIdReservado;
            
            private DataColumn columnRowId;
            
            private DataColumn columnIdEmpresa;
            
            internal tsy_TiposMovimientosDataTable() : 
                    base("tsy_TiposMovimientos") {
                this.InitClass();
            }
            
            internal tsy_TiposMovimientosDataTable(DataTable table) : 
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
            
            internal DataColumn IdTipoMovimientoColumn {
                get {
                    return this.columnIdTipoMovimiento;
                }
            }
            
            internal DataColumn AfectaStockColumn {
                get {
                    return this.columnAfectaStock;
                }
            }
            
            internal DataColumn DescripcionColumn {
                get {
                    return this.columnDescripcion;
                }
            }
            
            internal DataColumn SistemaColumn {
                get {
                    return this.columnSistema;
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
            
            public tsy_TiposMovimientosRow this[int index] {
                get {
                    return ((tsy_TiposMovimientosRow)(this.Rows[index]));
                }
            }
            
            public event tsy_TiposMovimientosRowChangeEventHandler tsy_TiposMovimientosRowChanged;
            
            public event tsy_TiposMovimientosRowChangeEventHandler tsy_TiposMovimientosRowChanging;
            
            public event tsy_TiposMovimientosRowChangeEventHandler tsy_TiposMovimientosRowDeleted;
            
            public event tsy_TiposMovimientosRowChangeEventHandler tsy_TiposMovimientosRowDeleting;
            
            public void Addtsy_TiposMovimientosRow(tsy_TiposMovimientosRow row) {
                this.Rows.Add(row);
            }
            
            public tsy_TiposMovimientosRow Addtsy_TiposMovimientosRow(string IdTipoMovimiento, bool AfectaStock, string Descripcion, bool Sistema, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, System.Guid RowId, long IdEmpresa) {
                tsy_TiposMovimientosRow rowtsy_TiposMovimientosRow = ((tsy_TiposMovimientosRow)(this.NewRow()));
                rowtsy_TiposMovimientosRow.ItemArray = new object[] {
                        IdTipoMovimiento,
                        AfectaStock,
                        Descripcion,
                        Sistema,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        IdReservado,
                        RowId,
                        IdEmpresa};
                this.Rows.Add(rowtsy_TiposMovimientosRow);
                return rowtsy_TiposMovimientosRow;
            }
            
            public tsy_TiposMovimientosRow FindByIdTipoMovimiento(string IdTipoMovimiento) {
                return ((tsy_TiposMovimientosRow)(this.Rows.Find(new object[] {
                            IdTipoMovimiento})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                tsy_TiposMovimientosDataTable cln = ((tsy_TiposMovimientosDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new tsy_TiposMovimientosDataTable();
            }
            
            internal void InitVars() {
                this.columnIdTipoMovimiento = this.Columns["IdTipoMovimiento"];
                this.columnAfectaStock = this.Columns["AfectaStock"];
                this.columnDescripcion = this.Columns["Descripcion"];
                this.columnSistema = this.Columns["Sistema"];
                this.columnFechaCreacion = this.Columns["FechaCreacion"];
                this.columnIdConexionCreacion = this.Columns["IdConexionCreacion"];
                this.columnUltimaModificacion = this.Columns["UltimaModificacion"];
                this.columnIdConexionUltimaModificacion = this.Columns["IdConexionUltimaModificacion"];
                this.columnIdReservado = this.Columns["IdReservado"];
                this.columnRowId = this.Columns["RowId"];
                this.columnIdEmpresa = this.Columns["IdEmpresa"];
            }
            
            private void InitClass() {
                this.columnIdTipoMovimiento = new DataColumn("IdTipoMovimiento", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdTipoMovimiento);
                this.columnAfectaStock = new DataColumn("AfectaStock", typeof(bool), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnAfectaStock);
                this.columnDescripcion = new DataColumn("Descripcion", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnDescripcion);
                this.columnSistema = new DataColumn("Sistema", typeof(bool), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnSistema);
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
                this.Constraints.Add(new UniqueConstraint("tsy_TiposMovimientosExKey1", new DataColumn[] {
                                this.columnIdTipoMovimiento}, true));
                this.columnIdTipoMovimiento.AllowDBNull = false;
                this.columnIdTipoMovimiento.Unique = true;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public tsy_TiposMovimientosRow Newtsy_TiposMovimientosRow() {
                return ((tsy_TiposMovimientosRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new tsy_TiposMovimientosRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(tsy_TiposMovimientosRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.tsy_TiposMovimientosRowChanged != null)) {
                    this.tsy_TiposMovimientosRowChanged(this, new tsy_TiposMovimientosRowChangeEvent(((tsy_TiposMovimientosRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.tsy_TiposMovimientosRowChanging != null)) {
                    this.tsy_TiposMovimientosRowChanging(this, new tsy_TiposMovimientosRowChangeEvent(((tsy_TiposMovimientosRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.tsy_TiposMovimientosRowDeleted != null)) {
                    this.tsy_TiposMovimientosRowDeleted(this, new tsy_TiposMovimientosRowChangeEvent(((tsy_TiposMovimientosRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.tsy_TiposMovimientosRowDeleting != null)) {
                    this.tsy_TiposMovimientosRowDeleting(this, new tsy_TiposMovimientosRowChangeEvent(((tsy_TiposMovimientosRow)(e.Row)), e.Action));
                }
            }
            
            public void Removetsy_TiposMovimientosRow(tsy_TiposMovimientosRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsy_TiposMovimientosRow : DataRow {
            
            private tsy_TiposMovimientosDataTable tabletsy_TiposMovimientos;
            
            internal tsy_TiposMovimientosRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tabletsy_TiposMovimientos = ((tsy_TiposMovimientosDataTable)(this.Table));
            }
            
            public string IdTipoMovimiento {
                get {
                    return ((string)(this[this.tabletsy_TiposMovimientos.IdTipoMovimientoColumn]));
                }
                set {
                    this[this.tabletsy_TiposMovimientos.IdTipoMovimientoColumn] = value;
                }
            }
            
            public bool AfectaStock {
                get {
                    try {
                        return ((bool)(this[this.tabletsy_TiposMovimientos.AfectaStockColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsy_TiposMovimientos.AfectaStockColumn] = value;
                }
            }
            
            public string Descripcion {
                get {
                    try {
                        return ((string)(this[this.tabletsy_TiposMovimientos.DescripcionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsy_TiposMovimientos.DescripcionColumn] = value;
                }
            }
            
            public bool Sistema {
                get {
                    try {
                        return ((bool)(this[this.tabletsy_TiposMovimientos.SistemaColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsy_TiposMovimientos.SistemaColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    try {
                        return ((System.DateTime)(this[this.tabletsy_TiposMovimientos.FechaCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsy_TiposMovimientos.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    try {
                        return ((long)(this[this.tabletsy_TiposMovimientos.IdConexionCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsy_TiposMovimientos.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tabletsy_TiposMovimientos.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsy_TiposMovimientos.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tabletsy_TiposMovimientos.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsy_TiposMovimientos.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public long IdReservado {
                get {
                    try {
                        return ((long)(this[this.tabletsy_TiposMovimientos.IdReservadoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsy_TiposMovimientos.IdReservadoColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tabletsy_TiposMovimientos.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsy_TiposMovimientos.RowIdColumn] = value;
                }
            }
            
            public long IdEmpresa {
                get {
                    try {
                        return ((long)(this[this.tabletsy_TiposMovimientos.IdEmpresaColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsy_TiposMovimientos.IdEmpresaColumn] = value;
                }
            }
            
            public bool IsAfectaStockNull() {
                return this.IsNull(this.tabletsy_TiposMovimientos.AfectaStockColumn);
            }
            
            public void SetAfectaStockNull() {
                this[this.tabletsy_TiposMovimientos.AfectaStockColumn] = System.Convert.DBNull;
            }
            
            public bool IsDescripcionNull() {
                return this.IsNull(this.tabletsy_TiposMovimientos.DescripcionColumn);
            }
            
            public void SetDescripcionNull() {
                this[this.tabletsy_TiposMovimientos.DescripcionColumn] = System.Convert.DBNull;
            }
            
            public bool IsSistemaNull() {
                return this.IsNull(this.tabletsy_TiposMovimientos.SistemaColumn);
            }
            
            public void SetSistemaNull() {
                this[this.tabletsy_TiposMovimientos.SistemaColumn] = System.Convert.DBNull;
            }
            
            public bool IsFechaCreacionNull() {
                return this.IsNull(this.tabletsy_TiposMovimientos.FechaCreacionColumn);
            }
            
            public void SetFechaCreacionNull() {
                this[this.tabletsy_TiposMovimientos.FechaCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionCreacionNull() {
                return this.IsNull(this.tabletsy_TiposMovimientos.IdConexionCreacionColumn);
            }
            
            public void SetIdConexionCreacionNull() {
                this[this.tabletsy_TiposMovimientos.IdConexionCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tabletsy_TiposMovimientos.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tabletsy_TiposMovimientos.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tabletsy_TiposMovimientos.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tabletsy_TiposMovimientos.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdReservadoNull() {
                return this.IsNull(this.tabletsy_TiposMovimientos.IdReservadoColumn);
            }
            
            public void SetIdReservadoNull() {
                this[this.tabletsy_TiposMovimientos.IdReservadoColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tabletsy_TiposMovimientos.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tabletsy_TiposMovimientos.RowIdColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdEmpresaNull() {
                return this.IsNull(this.tabletsy_TiposMovimientos.IdEmpresaColumn);
            }
            
            public void SetIdEmpresaNull() {
                this[this.tabletsy_TiposMovimientos.IdEmpresaColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsy_TiposMovimientosRowChangeEvent : EventArgs {
            
            private tsy_TiposMovimientosRow eventRow;
            
            private DataRowAction eventAction;
            
            public tsy_TiposMovimientosRowChangeEvent(tsy_TiposMovimientosRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public tsy_TiposMovimientosRow Row {
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
