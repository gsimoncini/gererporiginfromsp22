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
    public class twf_TareasTiposDeComprobantesDataset : DataSet {
        
        private twf_TareasTiposDeComprobantesDataTable tabletwf_TareasTiposDeComprobantes;
        
        public twf_TareasTiposDeComprobantesDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected twf_TareasTiposDeComprobantesDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["twf_TareasTiposDeComprobantes"] != null)) {
                    this.Tables.Add(new twf_TareasTiposDeComprobantesDataTable(ds.Tables["twf_TareasTiposDeComprobantes"]));
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
        public twf_TareasTiposDeComprobantesDataTable twf_TareasTiposDeComprobantes {
            get {
                return this.tabletwf_TareasTiposDeComprobantes;
            }
        }
        
        public override DataSet Clone() {
            twf_TareasTiposDeComprobantesDataset cln = ((twf_TareasTiposDeComprobantesDataset)(base.Clone()));
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
            if ((ds.Tables["twf_TareasTiposDeComprobantes"] != null)) {
                this.Tables.Add(new twf_TareasTiposDeComprobantesDataTable(ds.Tables["twf_TareasTiposDeComprobantes"]));
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
            this.tabletwf_TareasTiposDeComprobantes = ((twf_TareasTiposDeComprobantesDataTable)(this.Tables["twf_TareasTiposDeComprobantes"]));
            if ((this.tabletwf_TareasTiposDeComprobantes != null)) {
                this.tabletwf_TareasTiposDeComprobantes.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "twf_TareasTiposDeComprobantesDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/twf_TareasTiposDeComprobantes.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tabletwf_TareasTiposDeComprobantes = new twf_TareasTiposDeComprobantesDataTable();
            this.Tables.Add(this.tabletwf_TareasTiposDeComprobantes);
        }
        
        private bool ShouldSerializetwf_TareasTiposDeComprobantes() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void twf_TareasTiposDeComprobantesRowChangeEventHandler(object sender, twf_TareasTiposDeComprobantesRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class twf_TareasTiposDeComprobantesDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdTarea;
            
            private DataColumn columnIdTipoDeComprobante;
            
            private DataColumn columnIdConexion;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnRowId;
            
            private DataColumn columnObservaciones;
            
            internal twf_TareasTiposDeComprobantesDataTable() : 
                    base("twf_TareasTiposDeComprobantes") {
                this.InitClass();
            }
            
            internal twf_TareasTiposDeComprobantesDataTable(DataTable table) : 
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
            
            internal DataColumn IdTareaColumn {
                get {
                    return this.columnIdTarea;
                }
            }
            
            internal DataColumn IdTipoDeComprobanteColumn {
                get {
                    return this.columnIdTipoDeComprobante;
                }
            }
            
            internal DataColumn IdConexionColumn {
                get {
                    return this.columnIdConexion;
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
            
            internal DataColumn ObservacionesColumn {
                get {
                    return this.columnObservaciones;
                }
            }
            
            public twf_TareasTiposDeComprobantesRow this[int index] {
                get {
                    return ((twf_TareasTiposDeComprobantesRow)(this.Rows[index]));
                }
            }
            
            public event twf_TareasTiposDeComprobantesRowChangeEventHandler twf_TareasTiposDeComprobantesRowChanged;
            
            public event twf_TareasTiposDeComprobantesRowChangeEventHandler twf_TareasTiposDeComprobantesRowChanging;
            
            public event twf_TareasTiposDeComprobantesRowChangeEventHandler twf_TareasTiposDeComprobantesRowDeleted;
            
            public event twf_TareasTiposDeComprobantesRowChangeEventHandler twf_TareasTiposDeComprobantesRowDeleting;
            
            public void Addtwf_TareasTiposDeComprobantesRow(twf_TareasTiposDeComprobantesRow row) {
                this.Rows.Add(row);
            }
            
            public twf_TareasTiposDeComprobantesRow Addtwf_TareasTiposDeComprobantesRow(long IdTarea, string IdTipoDeComprobante, long IdConexion, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, System.Guid RowId, string Observaciones) {
                twf_TareasTiposDeComprobantesRow rowtwf_TareasTiposDeComprobantesRow = ((twf_TareasTiposDeComprobantesRow)(this.NewRow()));
                rowtwf_TareasTiposDeComprobantesRow.ItemArray = new object[] {
                        IdTarea,
                        IdTipoDeComprobante,
                        IdConexion,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        RowId,
                        Observaciones};
                this.Rows.Add(rowtwf_TareasTiposDeComprobantesRow);
                return rowtwf_TareasTiposDeComprobantesRow;
            }
            
            public twf_TareasTiposDeComprobantesRow FindByIdTareaIdTipoDeComprobante(long IdTarea, string IdTipoDeComprobante) {
                return ((twf_TareasTiposDeComprobantesRow)(this.Rows.Find(new object[] {
                            IdTarea,
                            IdTipoDeComprobante})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                twf_TareasTiposDeComprobantesDataTable cln = ((twf_TareasTiposDeComprobantesDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new twf_TareasTiposDeComprobantesDataTable();
            }
            
            internal void InitVars() {
                this.columnIdTarea = this.Columns["IdTarea"];
                this.columnIdTipoDeComprobante = this.Columns["IdTipoDeComprobante"];
                this.columnIdConexion = this.Columns["IdConexion"];
                this.columnFechaCreacion = this.Columns["FechaCreacion"];
                this.columnIdConexionCreacion = this.Columns["IdConexionCreacion"];
                this.columnUltimaModificacion = this.Columns["UltimaModificacion"];
                this.columnIdConexionUltimaModificacion = this.Columns["IdConexionUltimaModificacion"];
                this.columnRowId = this.Columns["RowId"];
                this.columnObservaciones = this.Columns["Observaciones"];
            }
            
            private void InitClass() {
                this.columnIdTarea = new DataColumn("IdTarea", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdTarea);
                this.columnIdTipoDeComprobante = new DataColumn("IdTipoDeComprobante", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdTipoDeComprobante);
                this.columnIdConexion = new DataColumn("IdConexion", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdConexion);
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
                this.columnObservaciones = new DataColumn("Observaciones", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnObservaciones);
                this.Constraints.Add(new UniqueConstraint("twf_TareasTiposDeComprobantesKey1", new DataColumn[] {
                                this.columnIdTarea,
                                this.columnIdTipoDeComprobante}, true));
                this.columnIdTarea.AllowDBNull = false;
                this.columnIdTipoDeComprobante.AllowDBNull = false;
                this.columnFechaCreacion.AllowDBNull = false;
                this.columnIdConexionCreacion.AllowDBNull = false;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public twf_TareasTiposDeComprobantesRow Newtwf_TareasTiposDeComprobantesRow() {
                return ((twf_TareasTiposDeComprobantesRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new twf_TareasTiposDeComprobantesRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(twf_TareasTiposDeComprobantesRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.twf_TareasTiposDeComprobantesRowChanged != null)) {
                    this.twf_TareasTiposDeComprobantesRowChanged(this, new twf_TareasTiposDeComprobantesRowChangeEvent(((twf_TareasTiposDeComprobantesRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.twf_TareasTiposDeComprobantesRowChanging != null)) {
                    this.twf_TareasTiposDeComprobantesRowChanging(this, new twf_TareasTiposDeComprobantesRowChangeEvent(((twf_TareasTiposDeComprobantesRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.twf_TareasTiposDeComprobantesRowDeleted != null)) {
                    this.twf_TareasTiposDeComprobantesRowDeleted(this, new twf_TareasTiposDeComprobantesRowChangeEvent(((twf_TareasTiposDeComprobantesRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.twf_TareasTiposDeComprobantesRowDeleting != null)) {
                    this.twf_TareasTiposDeComprobantesRowDeleting(this, new twf_TareasTiposDeComprobantesRowChangeEvent(((twf_TareasTiposDeComprobantesRow)(e.Row)), e.Action));
                }
            }
            
            public void Removetwf_TareasTiposDeComprobantesRow(twf_TareasTiposDeComprobantesRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class twf_TareasTiposDeComprobantesRow : DataRow {
            
            private twf_TareasTiposDeComprobantesDataTable tabletwf_TareasTiposDeComprobantes;
            
            internal twf_TareasTiposDeComprobantesRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tabletwf_TareasTiposDeComprobantes = ((twf_TareasTiposDeComprobantesDataTable)(this.Table));
            }
            
            public long IdTarea {
                get {
                    return ((long)(this[this.tabletwf_TareasTiposDeComprobantes.IdTareaColumn]));
                }
                set {
                    this[this.tabletwf_TareasTiposDeComprobantes.IdTareaColumn] = value;
                }
            }
            
            public string IdTipoDeComprobante {
                get {
                    return ((string)(this[this.tabletwf_TareasTiposDeComprobantes.IdTipoDeComprobanteColumn]));
                }
                set {
                    this[this.tabletwf_TareasTiposDeComprobantes.IdTipoDeComprobanteColumn] = value;
                }
            }
            
            public long IdConexion {
                get {
                    try {
                        return ((long)(this[this.tabletwf_TareasTiposDeComprobantes.IdConexionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletwf_TareasTiposDeComprobantes.IdConexionColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    return ((System.DateTime)(this[this.tabletwf_TareasTiposDeComprobantes.FechaCreacionColumn]));
                }
                set {
                    this[this.tabletwf_TareasTiposDeComprobantes.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    return ((long)(this[this.tabletwf_TareasTiposDeComprobantes.IdConexionCreacionColumn]));
                }
                set {
                    this[this.tabletwf_TareasTiposDeComprobantes.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tabletwf_TareasTiposDeComprobantes.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletwf_TareasTiposDeComprobantes.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tabletwf_TareasTiposDeComprobantes.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletwf_TareasTiposDeComprobantes.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tabletwf_TareasTiposDeComprobantes.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletwf_TareasTiposDeComprobantes.RowIdColumn] = value;
                }
            }
            
            public string Observaciones {
                get {
                    try {
                        return ((string)(this[this.tabletwf_TareasTiposDeComprobantes.ObservacionesColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletwf_TareasTiposDeComprobantes.ObservacionesColumn] = value;
                }
            }
            
            public bool IsIdConexionNull() {
                return this.IsNull(this.tabletwf_TareasTiposDeComprobantes.IdConexionColumn);
            }
            
            public void SetIdConexionNull() {
                this[this.tabletwf_TareasTiposDeComprobantes.IdConexionColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tabletwf_TareasTiposDeComprobantes.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tabletwf_TareasTiposDeComprobantes.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tabletwf_TareasTiposDeComprobantes.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tabletwf_TareasTiposDeComprobantes.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tabletwf_TareasTiposDeComprobantes.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tabletwf_TareasTiposDeComprobantes.RowIdColumn] = System.Convert.DBNull;
            }
            
            public bool IsObservacionesNull() {
                return this.IsNull(this.tabletwf_TareasTiposDeComprobantes.ObservacionesColumn);
            }
            
            public void SetObservacionesNull() {
                this[this.tabletwf_TareasTiposDeComprobantes.ObservacionesColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class twf_TareasTiposDeComprobantesRowChangeEvent : EventArgs {
            
            private twf_TareasTiposDeComprobantesRow eventRow;
            
            private DataRowAction eventAction;
            
            public twf_TareasTiposDeComprobantesRowChangeEvent(twf_TareasTiposDeComprobantesRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public twf_TareasTiposDeComprobantesRow Row {
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