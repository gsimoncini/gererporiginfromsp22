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
    public class twf_ControllerTareaDataset : DataSet {
        
        private twf_ControllerTareaDataTable tabletwf_ControllerTarea;
        
        public twf_ControllerTareaDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected twf_ControllerTareaDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["twf_ControllerTarea"] != null)) {
                    this.Tables.Add(new twf_ControllerTareaDataTable(ds.Tables["twf_ControllerTarea"]));
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
        public twf_ControllerTareaDataTable twf_ControllerTarea {
            get {
                return this.tabletwf_ControllerTarea;
            }
        }
        
        public override DataSet Clone() {
            twf_ControllerTareaDataset cln = ((twf_ControllerTareaDataset)(base.Clone()));
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
            if ((ds.Tables["twf_ControllerTarea"] != null)) {
                this.Tables.Add(new twf_ControllerTareaDataTable(ds.Tables["twf_ControllerTarea"]));
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
            this.tabletwf_ControllerTarea = ((twf_ControllerTareaDataTable)(this.Tables["twf_ControllerTarea"]));
            if ((this.tabletwf_ControllerTarea != null)) {
                this.tabletwf_ControllerTarea.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "twf_ControllerTareaDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/twf_ControllerTarea.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tabletwf_ControllerTarea = new twf_ControllerTareaDataTable();
            this.Tables.Add(this.tabletwf_ControllerTarea);
        }
        
        private bool ShouldSerializetwf_ControllerTarea() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void twf_ControllerTareaRowChangeEventHandler(object sender, twf_ControllerTareaRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class twf_ControllerTareaDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnId;
            
            private DataColumn columnIdTarea;
            
            private DataColumn columnController;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnIdReservado;
            
            private DataColumn columnRowId;
            
            private DataColumn columnIdEmpresa;
            
            private DataColumn columnIdSucursal;
            
            internal twf_ControllerTareaDataTable() : 
                    base("twf_ControllerTarea") {
                this.InitClass();
            }
            
            internal twf_ControllerTareaDataTable(DataTable table) : 
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
            
            internal DataColumn IdColumn {
                get {
                    return this.columnId;
                }
            }
            
            internal DataColumn IdTareaColumn {
                get {
                    return this.columnIdTarea;
                }
            }
            
            internal DataColumn ControllerColumn {
                get {
                    return this.columnController;
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
            
            public twf_ControllerTareaRow this[int index] {
                get {
                    return ((twf_ControllerTareaRow)(this.Rows[index]));
                }
            }
            
            public event twf_ControllerTareaRowChangeEventHandler twf_ControllerTareaRowChanged;
            
            public event twf_ControllerTareaRowChangeEventHandler twf_ControllerTareaRowChanging;
            
            public event twf_ControllerTareaRowChangeEventHandler twf_ControllerTareaRowDeleted;
            
            public event twf_ControllerTareaRowChangeEventHandler twf_ControllerTareaRowDeleting;
            
            public void Addtwf_ControllerTareaRow(twf_ControllerTareaRow row) {
                this.Rows.Add(row);
            }
            
            public twf_ControllerTareaRow Addtwf_ControllerTareaRow(long Id, long IdTarea, string Controller, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, System.Guid RowId, long IdEmpresa, long IdSucursal) {
                twf_ControllerTareaRow rowtwf_ControllerTareaRow = ((twf_ControllerTareaRow)(this.NewRow()));
                rowtwf_ControllerTareaRow.ItemArray = new object[] {
                        Id,
                        IdTarea,
                        Controller,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        IdReservado,
                        RowId,
                        IdEmpresa,
                        IdSucursal};
                this.Rows.Add(rowtwf_ControllerTareaRow);
                return rowtwf_ControllerTareaRow;
            }
            
            public twf_ControllerTareaRow FindById(long Id) {
                return ((twf_ControllerTareaRow)(this.Rows.Find(new object[] {
                            Id})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                twf_ControllerTareaDataTable cln = ((twf_ControllerTareaDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new twf_ControllerTareaDataTable();
            }
            
            internal void InitVars() {
                this.columnId = this.Columns["Id"];
                this.columnIdTarea = this.Columns["IdTarea"];
                this.columnController = this.Columns["Controller"];
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
                this.columnId = new DataColumn("Id", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnId);
                this.columnIdTarea = new DataColumn("IdTarea", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdTarea);
                this.columnController = new DataColumn("Controller", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnController);
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
                this.Constraints.Add(new UniqueConstraint("twf_ControllerTareaKey1", new DataColumn[] {
                                this.columnId}, true));
                this.columnId.AllowDBNull = false;
                this.columnId.Unique = true;
                this.columnIdTarea.AllowDBNull = false;
                this.columnController.AllowDBNull = false;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public twf_ControllerTareaRow Newtwf_ControllerTareaRow() {
                return ((twf_ControllerTareaRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new twf_ControllerTareaRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(twf_ControllerTareaRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.twf_ControllerTareaRowChanged != null)) {
                    this.twf_ControllerTareaRowChanged(this, new twf_ControllerTareaRowChangeEvent(((twf_ControllerTareaRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.twf_ControllerTareaRowChanging != null)) {
                    this.twf_ControllerTareaRowChanging(this, new twf_ControllerTareaRowChangeEvent(((twf_ControllerTareaRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.twf_ControllerTareaRowDeleted != null)) {
                    this.twf_ControllerTareaRowDeleted(this, new twf_ControllerTareaRowChangeEvent(((twf_ControllerTareaRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.twf_ControllerTareaRowDeleting != null)) {
                    this.twf_ControllerTareaRowDeleting(this, new twf_ControllerTareaRowChangeEvent(((twf_ControllerTareaRow)(e.Row)), e.Action));
                }
            }
            
            public void Removetwf_ControllerTareaRow(twf_ControllerTareaRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class twf_ControllerTareaRow : DataRow {
            
            private twf_ControllerTareaDataTable tabletwf_ControllerTarea;
            
            internal twf_ControllerTareaRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tabletwf_ControllerTarea = ((twf_ControllerTareaDataTable)(this.Table));
            }
            
            public long Id {
                get {
                    return ((long)(this[this.tabletwf_ControllerTarea.IdColumn]));
                }
                set {
                    this[this.tabletwf_ControllerTarea.IdColumn] = value;
                }
            }
            
            public long IdTarea {
                get {
                    return ((long)(this[this.tabletwf_ControllerTarea.IdTareaColumn]));
                }
                set {
                    this[this.tabletwf_ControllerTarea.IdTareaColumn] = value;
                }
            }
            
            public string Controller {
                get {
                    return ((string)(this[this.tabletwf_ControllerTarea.ControllerColumn]));
                }
                set {
                    this[this.tabletwf_ControllerTarea.ControllerColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    try {
                        return ((System.DateTime)(this[this.tabletwf_ControllerTarea.FechaCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletwf_ControllerTarea.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    try {
                        return ((long)(this[this.tabletwf_ControllerTarea.IdConexionCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletwf_ControllerTarea.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tabletwf_ControllerTarea.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletwf_ControllerTarea.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tabletwf_ControllerTarea.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletwf_ControllerTarea.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public long IdReservado {
                get {
                    try {
                        return ((long)(this[this.tabletwf_ControllerTarea.IdReservadoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletwf_ControllerTarea.IdReservadoColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tabletwf_ControllerTarea.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletwf_ControllerTarea.RowIdColumn] = value;
                }
            }
            
            public long IdEmpresa {
                get {
                    try {
                        return ((long)(this[this.tabletwf_ControllerTarea.IdEmpresaColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletwf_ControllerTarea.IdEmpresaColumn] = value;
                }
            }
            
            public long IdSucursal {
                get {
                    try {
                        return ((long)(this[this.tabletwf_ControllerTarea.IdSucursalColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletwf_ControllerTarea.IdSucursalColumn] = value;
                }
            }
            
            public bool IsFechaCreacionNull() {
                return this.IsNull(this.tabletwf_ControllerTarea.FechaCreacionColumn);
            }
            
            public void SetFechaCreacionNull() {
                this[this.tabletwf_ControllerTarea.FechaCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionCreacionNull() {
                return this.IsNull(this.tabletwf_ControllerTarea.IdConexionCreacionColumn);
            }
            
            public void SetIdConexionCreacionNull() {
                this[this.tabletwf_ControllerTarea.IdConexionCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tabletwf_ControllerTarea.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tabletwf_ControllerTarea.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tabletwf_ControllerTarea.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tabletwf_ControllerTarea.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdReservadoNull() {
                return this.IsNull(this.tabletwf_ControllerTarea.IdReservadoColumn);
            }
            
            public void SetIdReservadoNull() {
                this[this.tabletwf_ControllerTarea.IdReservadoColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tabletwf_ControllerTarea.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tabletwf_ControllerTarea.RowIdColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdEmpresaNull() {
                return this.IsNull(this.tabletwf_ControllerTarea.IdEmpresaColumn);
            }
            
            public void SetIdEmpresaNull() {
                this[this.tabletwf_ControllerTarea.IdEmpresaColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdSucursalNull() {
                return this.IsNull(this.tabletwf_ControllerTarea.IdSucursalColumn);
            }
            
            public void SetIdSucursalNull() {
                this[this.tabletwf_ControllerTarea.IdSucursalColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class twf_ControllerTareaRowChangeEvent : EventArgs {
            
            private twf_ControllerTareaRow eventRow;
            
            private DataRowAction eventAction;
            
            public twf_ControllerTareaRowChangeEvent(twf_ControllerTareaRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public twf_ControllerTareaRow Row {
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
