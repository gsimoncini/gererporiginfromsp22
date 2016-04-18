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
    public class tlg_MovimientosDeStockDataset : DataSet {
        
        private tlg_MovimientosDeStockDataTable tabletlg_MovimientosDeStock;
        
        public tlg_MovimientosDeStockDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected tlg_MovimientosDeStockDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["tlg_MovimientosDeStock"] != null)) {
                    this.Tables.Add(new tlg_MovimientosDeStockDataTable(ds.Tables["tlg_MovimientosDeStock"]));
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
        public tlg_MovimientosDeStockDataTable tlg_MovimientosDeStock {
            get {
                return this.tabletlg_MovimientosDeStock;
            }
        }
        
        public override DataSet Clone() {
            tlg_MovimientosDeStockDataset cln = ((tlg_MovimientosDeStockDataset)(base.Clone()));
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
            if ((ds.Tables["tlg_MovimientosDeStock"] != null)) {
                this.Tables.Add(new tlg_MovimientosDeStockDataTable(ds.Tables["tlg_MovimientosDeStock"]));
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
            this.tabletlg_MovimientosDeStock = ((tlg_MovimientosDeStockDataTable)(this.Tables["tlg_MovimientosDeStock"]));
            if ((this.tabletlg_MovimientosDeStock != null)) {
                this.tabletlg_MovimientosDeStock.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "tlg_MovimientosDeStockDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/tlg_MovimientosDeStock.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tabletlg_MovimientosDeStock = new tlg_MovimientosDeStockDataTable();
            this.Tables.Add(this.tabletlg_MovimientosDeStock);
        }
        
        private bool ShouldSerializetlg_MovimientosDeStock() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void tlg_MovimientosDeStockRowChangeEventHandler(object sender, tlg_MovimientosDeStockRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tlg_MovimientosDeStockDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdMovimientoDeStock;
            
            private DataColumn columnIdProducto;
            
            private DataColumn columnCantidad;
            
            private DataColumn columnIdDeposito;
            
            private DataColumn columnIdSeccion;
            
            private DataColumn columnIdEstadoDeStock;
            
            private DataColumn columnIdTipoDeAjuste;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnIdReservado;
            
            private DataColumn columnRowId;
            
            private DataColumn columnIdSucursal;
            
            private DataColumn columnIdEmpresa;
            
            internal tlg_MovimientosDeStockDataTable() : 
                    base("tlg_MovimientosDeStock") {
                this.InitClass();
            }
            
            internal tlg_MovimientosDeStockDataTable(DataTable table) : 
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
            
            internal DataColumn IdMovimientoDeStockColumn {
                get {
                    return this.columnIdMovimientoDeStock;
                }
            }
            
            internal DataColumn IdProductoColumn {
                get {
                    return this.columnIdProducto;
                }
            }
            
            internal DataColumn CantidadColumn {
                get {
                    return this.columnCantidad;
                }
            }
            
            internal DataColumn IdDepositoColumn {
                get {
                    return this.columnIdDeposito;
                }
            }
            
            internal DataColumn IdSeccionColumn {
                get {
                    return this.columnIdSeccion;
                }
            }
            
            internal DataColumn IdEstadoDeStockColumn {
                get {
                    return this.columnIdEstadoDeStock;
                }
            }
            
            internal DataColumn IdTipoDeAjusteColumn {
                get {
                    return this.columnIdTipoDeAjuste;
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
            
            internal DataColumn IdSucursalColumn {
                get {
                    return this.columnIdSucursal;
                }
            }
            
            internal DataColumn IdEmpresaColumn {
                get {
                    return this.columnIdEmpresa;
                }
            }
            
            public tlg_MovimientosDeStockRow this[int index] {
                get {
                    return ((tlg_MovimientosDeStockRow)(this.Rows[index]));
                }
            }
            
            public event tlg_MovimientosDeStockRowChangeEventHandler tlg_MovimientosDeStockRowChanged;
            
            public event tlg_MovimientosDeStockRowChangeEventHandler tlg_MovimientosDeStockRowChanging;
            
            public event tlg_MovimientosDeStockRowChangeEventHandler tlg_MovimientosDeStockRowDeleted;
            
            public event tlg_MovimientosDeStockRowChangeEventHandler tlg_MovimientosDeStockRowDeleting;
            
            public void Addtlg_MovimientosDeStockRow(tlg_MovimientosDeStockRow row) {
                this.Rows.Add(row);
            }
            
            public tlg_MovimientosDeStockRow Addtlg_MovimientosDeStockRow(string IdMovimientoDeStock, string IdProducto, System.Decimal Cantidad, string IdDeposito, string IdSeccion, string IdEstadoDeStock, string IdTipoDeAjuste, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, System.Guid RowId, long IdSucursal, long IdEmpresa) {
                tlg_MovimientosDeStockRow rowtlg_MovimientosDeStockRow = ((tlg_MovimientosDeStockRow)(this.NewRow()));
                rowtlg_MovimientosDeStockRow.ItemArray = new object[] {
                        IdMovimientoDeStock,
                        IdProducto,
                        Cantidad,
                        IdDeposito,
                        IdSeccion,
                        IdEstadoDeStock,
                        IdTipoDeAjuste,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        IdReservado,
                        RowId,
                        IdSucursal,
                        IdEmpresa};
                this.Rows.Add(rowtlg_MovimientosDeStockRow);
                return rowtlg_MovimientosDeStockRow;
            }
            
            public tlg_MovimientosDeStockRow FindByIdMovimientoDeStock(string IdMovimientoDeStock) {
                return ((tlg_MovimientosDeStockRow)(this.Rows.Find(new object[] {
                            IdMovimientoDeStock})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                tlg_MovimientosDeStockDataTable cln = ((tlg_MovimientosDeStockDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new tlg_MovimientosDeStockDataTable();
            }
            
            internal void InitVars() {
                this.columnIdMovimientoDeStock = this.Columns["IdMovimientoDeStock"];
                this.columnIdProducto = this.Columns["IdProducto"];
                this.columnCantidad = this.Columns["Cantidad"];
                this.columnIdDeposito = this.Columns["IdDeposito"];
                this.columnIdSeccion = this.Columns["IdSeccion"];
                this.columnIdEstadoDeStock = this.Columns["IdEstadoDeStock"];
                this.columnIdTipoDeAjuste = this.Columns["IdTipoDeAjuste"];
                this.columnFechaCreacion = this.Columns["FechaCreacion"];
                this.columnIdConexionCreacion = this.Columns["IdConexionCreacion"];
                this.columnUltimaModificacion = this.Columns["UltimaModificacion"];
                this.columnIdConexionUltimaModificacion = this.Columns["IdConexionUltimaModificacion"];
                this.columnIdReservado = this.Columns["IdReservado"];
                this.columnRowId = this.Columns["RowId"];
                this.columnIdSucursal = this.Columns["IdSucursal"];
                this.columnIdEmpresa = this.Columns["IdEmpresa"];
            }
            
            private void InitClass() {
                this.columnIdMovimientoDeStock = new DataColumn("IdMovimientoDeStock", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdMovimientoDeStock);
                this.columnIdProducto = new DataColumn("IdProducto", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdProducto);
                this.columnCantidad = new DataColumn("Cantidad", typeof(System.Decimal), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCantidad);
                this.columnIdDeposito = new DataColumn("IdDeposito", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdDeposito);
                this.columnIdSeccion = new DataColumn("IdSeccion", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdSeccion);
                this.columnIdEstadoDeStock = new DataColumn("IdEstadoDeStock", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdEstadoDeStock);
                this.columnIdTipoDeAjuste = new DataColumn("IdTipoDeAjuste", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdTipoDeAjuste);
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
                this.columnIdSucursal = new DataColumn("IdSucursal", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdSucursal);
                this.columnIdEmpresa = new DataColumn("IdEmpresa", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdEmpresa);
                this.Constraints.Add(new UniqueConstraint("tlg_MovimientosDeStockKey1", new DataColumn[] {
                                this.columnIdMovimientoDeStock}, true));
                this.columnIdMovimientoDeStock.AllowDBNull = false;
                this.columnIdMovimientoDeStock.Unique = true;
                this.columnIdProducto.AllowDBNull = false;
                this.columnCantidad.AllowDBNull = false;
                this.columnIdDeposito.AllowDBNull = false;
                this.columnIdSeccion.AllowDBNull = false;
                this.columnIdEstadoDeStock.AllowDBNull = false;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public tlg_MovimientosDeStockRow Newtlg_MovimientosDeStockRow() {
                return ((tlg_MovimientosDeStockRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new tlg_MovimientosDeStockRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(tlg_MovimientosDeStockRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.tlg_MovimientosDeStockRowChanged != null)) {
                    this.tlg_MovimientosDeStockRowChanged(this, new tlg_MovimientosDeStockRowChangeEvent(((tlg_MovimientosDeStockRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.tlg_MovimientosDeStockRowChanging != null)) {
                    this.tlg_MovimientosDeStockRowChanging(this, new tlg_MovimientosDeStockRowChangeEvent(((tlg_MovimientosDeStockRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.tlg_MovimientosDeStockRowDeleted != null)) {
                    this.tlg_MovimientosDeStockRowDeleted(this, new tlg_MovimientosDeStockRowChangeEvent(((tlg_MovimientosDeStockRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.tlg_MovimientosDeStockRowDeleting != null)) {
                    this.tlg_MovimientosDeStockRowDeleting(this, new tlg_MovimientosDeStockRowChangeEvent(((tlg_MovimientosDeStockRow)(e.Row)), e.Action));
                }
            }
            
            public void Removetlg_MovimientosDeStockRow(tlg_MovimientosDeStockRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tlg_MovimientosDeStockRow : DataRow {
            
            private tlg_MovimientosDeStockDataTable tabletlg_MovimientosDeStock;
            
            internal tlg_MovimientosDeStockRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tabletlg_MovimientosDeStock = ((tlg_MovimientosDeStockDataTable)(this.Table));
            }
            
            public string IdMovimientoDeStock {
                get {
                    return ((string)(this[this.tabletlg_MovimientosDeStock.IdMovimientoDeStockColumn]));
                }
                set {
                    this[this.tabletlg_MovimientosDeStock.IdMovimientoDeStockColumn] = value;
                }
            }
            
            public string IdProducto {
                get {
                    return ((string)(this[this.tabletlg_MovimientosDeStock.IdProductoColumn]));
                }
                set {
                    this[this.tabletlg_MovimientosDeStock.IdProductoColumn] = value;
                }
            }
            
            public System.Decimal Cantidad {
                get {
                    return ((System.Decimal)(this[this.tabletlg_MovimientosDeStock.CantidadColumn]));
                }
                set {
                    this[this.tabletlg_MovimientosDeStock.CantidadColumn] = value;
                }
            }
            
            public string IdDeposito {
                get {
                    return ((string)(this[this.tabletlg_MovimientosDeStock.IdDepositoColumn]));
                }
                set {
                    this[this.tabletlg_MovimientosDeStock.IdDepositoColumn] = value;
                }
            }
            
            public string IdSeccion {
                get {
                    return ((string)(this[this.tabletlg_MovimientosDeStock.IdSeccionColumn]));
                }
                set {
                    this[this.tabletlg_MovimientosDeStock.IdSeccionColumn] = value;
                }
            }
            
            public string IdEstadoDeStock {
                get {
                    return ((string)(this[this.tabletlg_MovimientosDeStock.IdEstadoDeStockColumn]));
                }
                set {
                    this[this.tabletlg_MovimientosDeStock.IdEstadoDeStockColumn] = value;
                }
            }
            
            public string IdTipoDeAjuste {
                get {
                    try {
                        return ((string)(this[this.tabletlg_MovimientosDeStock.IdTipoDeAjusteColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_MovimientosDeStock.IdTipoDeAjusteColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    try {
                        return ((System.DateTime)(this[this.tabletlg_MovimientosDeStock.FechaCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_MovimientosDeStock.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    try {
                        return ((long)(this[this.tabletlg_MovimientosDeStock.IdConexionCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_MovimientosDeStock.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tabletlg_MovimientosDeStock.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_MovimientosDeStock.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tabletlg_MovimientosDeStock.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_MovimientosDeStock.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public long IdReservado {
                get {
                    try {
                        return ((long)(this[this.tabletlg_MovimientosDeStock.IdReservadoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_MovimientosDeStock.IdReservadoColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tabletlg_MovimientosDeStock.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_MovimientosDeStock.RowIdColumn] = value;
                }
            }
            
            public long IdSucursal {
                get {
                    try {
                        return ((long)(this[this.tabletlg_MovimientosDeStock.IdSucursalColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_MovimientosDeStock.IdSucursalColumn] = value;
                }
            }
            
            public long IdEmpresa {
                get {
                    try {
                        return ((long)(this[this.tabletlg_MovimientosDeStock.IdEmpresaColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_MovimientosDeStock.IdEmpresaColumn] = value;
                }
            }
            
            public bool IsIdTipoDeAjusteNull() {
                return this.IsNull(this.tabletlg_MovimientosDeStock.IdTipoDeAjusteColumn);
            }
            
            public void SetIdTipoDeAjusteNull() {
                this[this.tabletlg_MovimientosDeStock.IdTipoDeAjusteColumn] = System.Convert.DBNull;
            }
            
            public bool IsFechaCreacionNull() {
                return this.IsNull(this.tabletlg_MovimientosDeStock.FechaCreacionColumn);
            }
            
            public void SetFechaCreacionNull() {
                this[this.tabletlg_MovimientosDeStock.FechaCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionCreacionNull() {
                return this.IsNull(this.tabletlg_MovimientosDeStock.IdConexionCreacionColumn);
            }
            
            public void SetIdConexionCreacionNull() {
                this[this.tabletlg_MovimientosDeStock.IdConexionCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tabletlg_MovimientosDeStock.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tabletlg_MovimientosDeStock.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tabletlg_MovimientosDeStock.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tabletlg_MovimientosDeStock.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdReservadoNull() {
                return this.IsNull(this.tabletlg_MovimientosDeStock.IdReservadoColumn);
            }
            
            public void SetIdReservadoNull() {
                this[this.tabletlg_MovimientosDeStock.IdReservadoColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tabletlg_MovimientosDeStock.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tabletlg_MovimientosDeStock.RowIdColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdSucursalNull() {
                return this.IsNull(this.tabletlg_MovimientosDeStock.IdSucursalColumn);
            }
            
            public void SetIdSucursalNull() {
                this[this.tabletlg_MovimientosDeStock.IdSucursalColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdEmpresaNull() {
                return this.IsNull(this.tabletlg_MovimientosDeStock.IdEmpresaColumn);
            }
            
            public void SetIdEmpresaNull() {
                this[this.tabletlg_MovimientosDeStock.IdEmpresaColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tlg_MovimientosDeStockRowChangeEvent : EventArgs {
            
            private tlg_MovimientosDeStockRow eventRow;
            
            private DataRowAction eventAction;
            
            public tlg_MovimientosDeStockRowChangeEvent(tlg_MovimientosDeStockRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public tlg_MovimientosDeStockRow Row {
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
