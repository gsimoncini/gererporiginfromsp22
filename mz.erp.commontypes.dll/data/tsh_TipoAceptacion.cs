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
    public class tsh_TipoAceptacionDataset : DataSet {
        
        private tsh_TipoAceptacionDataTable tabletsh_TipoAceptacion;
        
        public tsh_TipoAceptacionDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected tsh_TipoAceptacionDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["tsh_TipoAceptacion"] != null)) {
                    this.Tables.Add(new tsh_TipoAceptacionDataTable(ds.Tables["tsh_TipoAceptacion"]));
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
        public tsh_TipoAceptacionDataTable tsh_TipoAceptacion {
            get {
                return this.tabletsh_TipoAceptacion;
            }
        }
        
        public override DataSet Clone() {
            tsh_TipoAceptacionDataset cln = ((tsh_TipoAceptacionDataset)(base.Clone()));
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
            if ((ds.Tables["tsh_TipoAceptacion"] != null)) {
                this.Tables.Add(new tsh_TipoAceptacionDataTable(ds.Tables["tsh_TipoAceptacion"]));
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
            this.tabletsh_TipoAceptacion = ((tsh_TipoAceptacionDataTable)(this.Tables["tsh_TipoAceptacion"]));
            if ((this.tabletsh_TipoAceptacion != null)) {
                this.tabletsh_TipoAceptacion.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "tsh_TipoAceptacionDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/tsh_TipoAceptacion.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tabletsh_TipoAceptacion = new tsh_TipoAceptacionDataTable();
            this.Tables.Add(this.tabletsh_TipoAceptacion);
        }
        
        private bool ShouldSerializetsh_TipoAceptacion() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void tsh_TipoAceptacionRowChangeEventHandler(object sender, tsh_TipoAceptacionRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsh_TipoAceptacionDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdTipoAceptacion;
            
            private DataColumn columnDescripcion;
            
            private DataColumn columnAux1;
            
            private DataColumn columnAux2;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnIdReservado;
            
            private DataColumn columnRowId;
            
            internal tsh_TipoAceptacionDataTable() : 
                    base("tsh_TipoAceptacion") {
                this.InitClass();
            }
            
            internal tsh_TipoAceptacionDataTable(DataTable table) : 
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
            
            internal DataColumn IdTipoAceptacionColumn {
                get {
                    return this.columnIdTipoAceptacion;
                }
            }
            
            internal DataColumn DescripcionColumn {
                get {
                    return this.columnDescripcion;
                }
            }
            
            internal DataColumn Aux1Column {
                get {
                    return this.columnAux1;
                }
            }
            
            internal DataColumn Aux2Column {
                get {
                    return this.columnAux2;
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
            
            public tsh_TipoAceptacionRow this[int index] {
                get {
                    return ((tsh_TipoAceptacionRow)(this.Rows[index]));
                }
            }
            
            public event tsh_TipoAceptacionRowChangeEventHandler tsh_TipoAceptacionRowChanged;
            
            public event tsh_TipoAceptacionRowChangeEventHandler tsh_TipoAceptacionRowChanging;
            
            public event tsh_TipoAceptacionRowChangeEventHandler tsh_TipoAceptacionRowDeleted;
            
            public event tsh_TipoAceptacionRowChangeEventHandler tsh_TipoAceptacionRowDeleting;
            
            public void Addtsh_TipoAceptacionRow(tsh_TipoAceptacionRow row) {
                this.Rows.Add(row);
            }
            
            public tsh_TipoAceptacionRow Addtsh_TipoAceptacionRow(string IdTipoAceptacion, string Descripcion, string Aux1, string Aux2, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, System.Guid RowId) {
                tsh_TipoAceptacionRow rowtsh_TipoAceptacionRow = ((tsh_TipoAceptacionRow)(this.NewRow()));
                rowtsh_TipoAceptacionRow.ItemArray = new object[] {
                        IdTipoAceptacion,
                        Descripcion,
                        Aux1,
                        Aux2,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        IdReservado,
                        RowId};
                this.Rows.Add(rowtsh_TipoAceptacionRow);
                return rowtsh_TipoAceptacionRow;
            }
            
            public tsh_TipoAceptacionRow FindByIdTipoAceptacion(string IdTipoAceptacion) {
                return ((tsh_TipoAceptacionRow)(this.Rows.Find(new object[] {
                            IdTipoAceptacion})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                tsh_TipoAceptacionDataTable cln = ((tsh_TipoAceptacionDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new tsh_TipoAceptacionDataTable();
            }
            
            internal void InitVars() {
                this.columnIdTipoAceptacion = this.Columns["IdTipoAceptacion"];
                this.columnDescripcion = this.Columns["Descripcion"];
                this.columnAux1 = this.Columns["Aux1"];
                this.columnAux2 = this.Columns["Aux2"];
                this.columnFechaCreacion = this.Columns["FechaCreacion"];
                this.columnIdConexionCreacion = this.Columns["IdConexionCreacion"];
                this.columnUltimaModificacion = this.Columns["UltimaModificacion"];
                this.columnIdConexionUltimaModificacion = this.Columns["IdConexionUltimaModificacion"];
                this.columnIdReservado = this.Columns["IdReservado"];
                this.columnRowId = this.Columns["RowId"];
            }
            
            private void InitClass() {
                this.columnIdTipoAceptacion = new DataColumn("IdTipoAceptacion", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdTipoAceptacion);
                this.columnDescripcion = new DataColumn("Descripcion", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnDescripcion);
                this.columnAux1 = new DataColumn("Aux1", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnAux1);
                this.columnAux2 = new DataColumn("Aux2", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnAux2);
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
                this.Constraints.Add(new UniqueConstraint("tsh_TipoAceptacionKey1", new DataColumn[] {
                                this.columnIdTipoAceptacion}, true));
                this.columnIdTipoAceptacion.AllowDBNull = false;
                this.columnIdTipoAceptacion.Unique = true;
                this.columnDescripcion.AllowDBNull = false;
                this.columnAux1.AllowDBNull = false;
                this.columnAux2.AllowDBNull = false;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public tsh_TipoAceptacionRow Newtsh_TipoAceptacionRow() {
                return ((tsh_TipoAceptacionRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new tsh_TipoAceptacionRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(tsh_TipoAceptacionRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.tsh_TipoAceptacionRowChanged != null)) {
                    this.tsh_TipoAceptacionRowChanged(this, new tsh_TipoAceptacionRowChangeEvent(((tsh_TipoAceptacionRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.tsh_TipoAceptacionRowChanging != null)) {
                    this.tsh_TipoAceptacionRowChanging(this, new tsh_TipoAceptacionRowChangeEvent(((tsh_TipoAceptacionRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.tsh_TipoAceptacionRowDeleted != null)) {
                    this.tsh_TipoAceptacionRowDeleted(this, new tsh_TipoAceptacionRowChangeEvent(((tsh_TipoAceptacionRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.tsh_TipoAceptacionRowDeleting != null)) {
                    this.tsh_TipoAceptacionRowDeleting(this, new tsh_TipoAceptacionRowChangeEvent(((tsh_TipoAceptacionRow)(e.Row)), e.Action));
                }
            }
            
            public void Removetsh_TipoAceptacionRow(tsh_TipoAceptacionRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsh_TipoAceptacionRow : DataRow {
            
            private tsh_TipoAceptacionDataTable tabletsh_TipoAceptacion;
            
            internal tsh_TipoAceptacionRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tabletsh_TipoAceptacion = ((tsh_TipoAceptacionDataTable)(this.Table));
            }
            
            public string IdTipoAceptacion {
                get {
                    return ((string)(this[this.tabletsh_TipoAceptacion.IdTipoAceptacionColumn]));
                }
                set {
                    this[this.tabletsh_TipoAceptacion.IdTipoAceptacionColumn] = value;
                }
            }
            
            public string Descripcion {
                get {
                    return ((string)(this[this.tabletsh_TipoAceptacion.DescripcionColumn]));
                }
                set {
                    this[this.tabletsh_TipoAceptacion.DescripcionColumn] = value;
                }
            }
            
            public string Aux1 {
                get {
                    return ((string)(this[this.tabletsh_TipoAceptacion.Aux1Column]));
                }
                set {
                    this[this.tabletsh_TipoAceptacion.Aux1Column] = value;
                }
            }
            
            public string Aux2 {
                get {
                    return ((string)(this[this.tabletsh_TipoAceptacion.Aux2Column]));
                }
                set {
                    this[this.tabletsh_TipoAceptacion.Aux2Column] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    try {
                        return ((System.DateTime)(this[this.tabletsh_TipoAceptacion.FechaCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_TipoAceptacion.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    try {
                        return ((long)(this[this.tabletsh_TipoAceptacion.IdConexionCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_TipoAceptacion.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tabletsh_TipoAceptacion.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_TipoAceptacion.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tabletsh_TipoAceptacion.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_TipoAceptacion.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public long IdReservado {
                get {
                    try {
                        return ((long)(this[this.tabletsh_TipoAceptacion.IdReservadoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_TipoAceptacion.IdReservadoColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tabletsh_TipoAceptacion.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_TipoAceptacion.RowIdColumn] = value;
                }
            }
            
            public bool IsFechaCreacionNull() {
                return this.IsNull(this.tabletsh_TipoAceptacion.FechaCreacionColumn);
            }
            
            public void SetFechaCreacionNull() {
                this[this.tabletsh_TipoAceptacion.FechaCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionCreacionNull() {
                return this.IsNull(this.tabletsh_TipoAceptacion.IdConexionCreacionColumn);
            }
            
            public void SetIdConexionCreacionNull() {
                this[this.tabletsh_TipoAceptacion.IdConexionCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tabletsh_TipoAceptacion.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tabletsh_TipoAceptacion.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tabletsh_TipoAceptacion.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tabletsh_TipoAceptacion.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdReservadoNull() {
                return this.IsNull(this.tabletsh_TipoAceptacion.IdReservadoColumn);
            }
            
            public void SetIdReservadoNull() {
                this[this.tabletsh_TipoAceptacion.IdReservadoColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tabletsh_TipoAceptacion.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tabletsh_TipoAceptacion.RowIdColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsh_TipoAceptacionRowChangeEvent : EventArgs {
            
            private tsh_TipoAceptacionRow eventRow;
            
            private DataRowAction eventAction;
            
            public tsh_TipoAceptacionRowChangeEvent(tsh_TipoAceptacionRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public tsh_TipoAceptacionRow Row {
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
