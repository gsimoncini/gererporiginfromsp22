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
    public class tfi_FormasDePagoDataset : DataSet {
        
        private tfi_FormasDePagoDataTable tabletfi_FormasDePago;
        
        public tfi_FormasDePagoDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected tfi_FormasDePagoDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["tfi_FormasDePago"] != null)) {
                    this.Tables.Add(new tfi_FormasDePagoDataTable(ds.Tables["tfi_FormasDePago"]));
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
        public tfi_FormasDePagoDataTable tfi_FormasDePago {
            get {
                return this.tabletfi_FormasDePago;
            }
        }
        
        public override DataSet Clone() {
            tfi_FormasDePagoDataset cln = ((tfi_FormasDePagoDataset)(base.Clone()));
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
            if ((ds.Tables["tfi_FormasDePago"] != null)) {
                this.Tables.Add(new tfi_FormasDePagoDataTable(ds.Tables["tfi_FormasDePago"]));
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
            this.tabletfi_FormasDePago = ((tfi_FormasDePagoDataTable)(this.Tables["tfi_FormasDePago"]));
            if ((this.tabletfi_FormasDePago != null)) {
                this.tabletfi_FormasDePago.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "tfi_FormasDePagoDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/tfi_FormasDePago.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tabletfi_FormasDePago = new tfi_FormasDePagoDataTable();
            this.Tables.Add(this.tabletfi_FormasDePago);
        }
        
        private bool ShouldSerializetfi_FormasDePago() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void tfi_FormasDePagoRowChangeEventHandler(object sender, tfi_FormasDePagoRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tfi_FormasDePagoDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdTDCompTesoreria;
            
            private DataColumn columnIdMoneda;
            
            private DataColumn columnIdEntidad;
            
            private DataColumn columnCuotas;
            
            private DataColumn columnRecargo;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnIdReservado;
            
            private DataColumn columnRowId;
            
            private DataColumn columnIdEmpresa;
            
            private DataColumn columnIdSucursal;
            
            private DataColumn columnIdFormaDePago;
            
            internal tfi_FormasDePagoDataTable() : 
                    base("tfi_FormasDePago") {
                this.InitClass();
            }
            
            internal tfi_FormasDePagoDataTable(DataTable table) : 
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
            
            internal DataColumn IdTDCompTesoreriaColumn {
                get {
                    return this.columnIdTDCompTesoreria;
                }
            }
            
            internal DataColumn IdMonedaColumn {
                get {
                    return this.columnIdMoneda;
                }
            }
            
            internal DataColumn IdEntidadColumn {
                get {
                    return this.columnIdEntidad;
                }
            }
            
            internal DataColumn CuotasColumn {
                get {
                    return this.columnCuotas;
                }
            }
            
            internal DataColumn RecargoColumn {
                get {
                    return this.columnRecargo;
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
            
            internal DataColumn IdFormaDePagoColumn {
                get {
                    return this.columnIdFormaDePago;
                }
            }
            
            public tfi_FormasDePagoRow this[int index] {
                get {
                    return ((tfi_FormasDePagoRow)(this.Rows[index]));
                }
            }
            
            public event tfi_FormasDePagoRowChangeEventHandler tfi_FormasDePagoRowChanged;
            
            public event tfi_FormasDePagoRowChangeEventHandler tfi_FormasDePagoRowChanging;
            
            public event tfi_FormasDePagoRowChangeEventHandler tfi_FormasDePagoRowDeleted;
            
            public event tfi_FormasDePagoRowChangeEventHandler tfi_FormasDePagoRowDeleting;
            
            public void Addtfi_FormasDePagoRow(tfi_FormasDePagoRow row) {
                this.Rows.Add(row);
            }
            
            public tfi_FormasDePagoRow Addtfi_FormasDePagoRow(string IdTDCompTesoreria, string IdMoneda, string IdEntidad, short Cuotas, System.Decimal Recargo, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, System.Guid RowId, long IdEmpresa, long IdSucursal, string IdFormaDePago) {
                tfi_FormasDePagoRow rowtfi_FormasDePagoRow = ((tfi_FormasDePagoRow)(this.NewRow()));
                rowtfi_FormasDePagoRow.ItemArray = new object[] {
                        IdTDCompTesoreria,
                        IdMoneda,
                        IdEntidad,
                        Cuotas,
                        Recargo,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        IdReservado,
                        RowId,
                        IdEmpresa,
                        IdSucursal,
                        IdFormaDePago};
                this.Rows.Add(rowtfi_FormasDePagoRow);
                return rowtfi_FormasDePagoRow;
            }
            
            public tfi_FormasDePagoRow FindByIdFormaDePago(string IdFormaDePago) {
                return ((tfi_FormasDePagoRow)(this.Rows.Find(new object[] {
                            IdFormaDePago})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                tfi_FormasDePagoDataTable cln = ((tfi_FormasDePagoDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new tfi_FormasDePagoDataTable();
            }
            
            internal void InitVars() {
                this.columnIdTDCompTesoreria = this.Columns["IdTDCompTesoreria"];
                this.columnIdMoneda = this.Columns["IdMoneda"];
                this.columnIdEntidad = this.Columns["IdEntidad"];
                this.columnCuotas = this.Columns["Cuotas"];
                this.columnRecargo = this.Columns["Recargo"];
                this.columnFechaCreacion = this.Columns["FechaCreacion"];
                this.columnIdConexionCreacion = this.Columns["IdConexionCreacion"];
                this.columnUltimaModificacion = this.Columns["UltimaModificacion"];
                this.columnIdConexionUltimaModificacion = this.Columns["IdConexionUltimaModificacion"];
                this.columnIdReservado = this.Columns["IdReservado"];
                this.columnRowId = this.Columns["RowId"];
                this.columnIdEmpresa = this.Columns["IdEmpresa"];
                this.columnIdSucursal = this.Columns["IdSucursal"];
                this.columnIdFormaDePago = this.Columns["IdFormaDePago"];
            }
            
            private void InitClass() {
                this.columnIdTDCompTesoreria = new DataColumn("IdTDCompTesoreria", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdTDCompTesoreria);
                this.columnIdMoneda = new DataColumn("IdMoneda", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdMoneda);
                this.columnIdEntidad = new DataColumn("IdEntidad", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdEntidad);
                this.columnCuotas = new DataColumn("Cuotas", typeof(short), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCuotas);
                this.columnRecargo = new DataColumn("Recargo", typeof(System.Decimal), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnRecargo);
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
                this.columnIdFormaDePago = new DataColumn("IdFormaDePago", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdFormaDePago);
                this.Constraints.Add(new UniqueConstraint("tfi_FormasDePagoKey1", new DataColumn[] {
                                this.columnIdFormaDePago}, true));
                this.columnIdTDCompTesoreria.AllowDBNull = false;
                this.columnIdMoneda.AllowDBNull = false;
                this.columnIdEntidad.AllowDBNull = false;
                this.columnCuotas.AllowDBNull = false;
                this.columnRecargo.AllowDBNull = false;
                this.columnUltimaModificacion.ReadOnly = true;
                this.columnIdFormaDePago.AllowDBNull = false;
                this.columnIdFormaDePago.Unique = true;
            }
            
            public tfi_FormasDePagoRow Newtfi_FormasDePagoRow() {
                return ((tfi_FormasDePagoRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new tfi_FormasDePagoRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(tfi_FormasDePagoRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.tfi_FormasDePagoRowChanged != null)) {
                    this.tfi_FormasDePagoRowChanged(this, new tfi_FormasDePagoRowChangeEvent(((tfi_FormasDePagoRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.tfi_FormasDePagoRowChanging != null)) {
                    this.tfi_FormasDePagoRowChanging(this, new tfi_FormasDePagoRowChangeEvent(((tfi_FormasDePagoRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.tfi_FormasDePagoRowDeleted != null)) {
                    this.tfi_FormasDePagoRowDeleted(this, new tfi_FormasDePagoRowChangeEvent(((tfi_FormasDePagoRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.tfi_FormasDePagoRowDeleting != null)) {
                    this.tfi_FormasDePagoRowDeleting(this, new tfi_FormasDePagoRowChangeEvent(((tfi_FormasDePagoRow)(e.Row)), e.Action));
                }
            }
            
            public void Removetfi_FormasDePagoRow(tfi_FormasDePagoRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tfi_FormasDePagoRow : DataRow {
            
            private tfi_FormasDePagoDataTable tabletfi_FormasDePago;
            
            internal tfi_FormasDePagoRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tabletfi_FormasDePago = ((tfi_FormasDePagoDataTable)(this.Table));
            }
            
            public string IdTDCompTesoreria {
                get {
                    return ((string)(this[this.tabletfi_FormasDePago.IdTDCompTesoreriaColumn]));
                }
                set {
                    this[this.tabletfi_FormasDePago.IdTDCompTesoreriaColumn] = value;
                }
            }
            
            public string IdMoneda {
                get {
                    return ((string)(this[this.tabletfi_FormasDePago.IdMonedaColumn]));
                }
                set {
                    this[this.tabletfi_FormasDePago.IdMonedaColumn] = value;
                }
            }
            
            public string IdEntidad {
                get {
                    return ((string)(this[this.tabletfi_FormasDePago.IdEntidadColumn]));
                }
                set {
                    this[this.tabletfi_FormasDePago.IdEntidadColumn] = value;
                }
            }
            
            public short Cuotas {
                get {
                    return ((short)(this[this.tabletfi_FormasDePago.CuotasColumn]));
                }
                set {
                    this[this.tabletfi_FormasDePago.CuotasColumn] = value;
                }
            }
            
            public System.Decimal Recargo {
                get {
                    return ((System.Decimal)(this[this.tabletfi_FormasDePago.RecargoColumn]));
                }
                set {
                    this[this.tabletfi_FormasDePago.RecargoColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    try {
                        return ((System.DateTime)(this[this.tabletfi_FormasDePago.FechaCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletfi_FormasDePago.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    try {
                        return ((long)(this[this.tabletfi_FormasDePago.IdConexionCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletfi_FormasDePago.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tabletfi_FormasDePago.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletfi_FormasDePago.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tabletfi_FormasDePago.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletfi_FormasDePago.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public long IdReservado {
                get {
                    try {
                        return ((long)(this[this.tabletfi_FormasDePago.IdReservadoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletfi_FormasDePago.IdReservadoColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tabletfi_FormasDePago.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletfi_FormasDePago.RowIdColumn] = value;
                }
            }
            
            public long IdEmpresa {
                get {
                    try {
                        return ((long)(this[this.tabletfi_FormasDePago.IdEmpresaColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletfi_FormasDePago.IdEmpresaColumn] = value;
                }
            }
            
            public long IdSucursal {
                get {
                    try {
                        return ((long)(this[this.tabletfi_FormasDePago.IdSucursalColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletfi_FormasDePago.IdSucursalColumn] = value;
                }
            }
            
            public string IdFormaDePago {
                get {
                    return ((string)(this[this.tabletfi_FormasDePago.IdFormaDePagoColumn]));
                }
                set {
                    this[this.tabletfi_FormasDePago.IdFormaDePagoColumn] = value;
                }
            }
            
            public bool IsFechaCreacionNull() {
                return this.IsNull(this.tabletfi_FormasDePago.FechaCreacionColumn);
            }
            
            public void SetFechaCreacionNull() {
                this[this.tabletfi_FormasDePago.FechaCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionCreacionNull() {
                return this.IsNull(this.tabletfi_FormasDePago.IdConexionCreacionColumn);
            }
            
            public void SetIdConexionCreacionNull() {
                this[this.tabletfi_FormasDePago.IdConexionCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tabletfi_FormasDePago.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tabletfi_FormasDePago.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tabletfi_FormasDePago.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tabletfi_FormasDePago.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdReservadoNull() {
                return this.IsNull(this.tabletfi_FormasDePago.IdReservadoColumn);
            }
            
            public void SetIdReservadoNull() {
                this[this.tabletfi_FormasDePago.IdReservadoColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tabletfi_FormasDePago.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tabletfi_FormasDePago.RowIdColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdEmpresaNull() {
                return this.IsNull(this.tabletfi_FormasDePago.IdEmpresaColumn);
            }
            
            public void SetIdEmpresaNull() {
                this[this.tabletfi_FormasDePago.IdEmpresaColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdSucursalNull() {
                return this.IsNull(this.tabletfi_FormasDePago.IdSucursalColumn);
            }
            
            public void SetIdSucursalNull() {
                this[this.tabletfi_FormasDePago.IdSucursalColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tfi_FormasDePagoRowChangeEvent : EventArgs {
            
            private tfi_FormasDePagoRow eventRow;
            
            private DataRowAction eventAction;
            
            public tfi_FormasDePagoRowChangeEvent(tfi_FormasDePagoRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public tfi_FormasDePagoRow Row {
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
