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
    public class sy_JerarquiaAgrupVariablesDataset : DataSet {
        
        private sy_JerarquiaAgrupVariablesDataTable tablesy_JerarquiaAgrupVariables;
        
        public sy_JerarquiaAgrupVariablesDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected sy_JerarquiaAgrupVariablesDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["sy_JerarquiaAgrupVariables"] != null)) {
                    this.Tables.Add(new sy_JerarquiaAgrupVariablesDataTable(ds.Tables["sy_JerarquiaAgrupVariables"]));
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
        public sy_JerarquiaAgrupVariablesDataTable sy_JerarquiaAgrupVariables {
            get {
                return this.tablesy_JerarquiaAgrupVariables;
            }
        }
        
        public override DataSet Clone() {
            sy_JerarquiaAgrupVariablesDataset cln = ((sy_JerarquiaAgrupVariablesDataset)(base.Clone()));
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
            if ((ds.Tables["sy_JerarquiaAgrupVariables"] != null)) {
                this.Tables.Add(new sy_JerarquiaAgrupVariablesDataTable(ds.Tables["sy_JerarquiaAgrupVariables"]));
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
            this.tablesy_JerarquiaAgrupVariables = ((sy_JerarquiaAgrupVariablesDataTable)(this.Tables["sy_JerarquiaAgrupVariables"]));
            if ((this.tablesy_JerarquiaAgrupVariables != null)) {
                this.tablesy_JerarquiaAgrupVariables.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "sy_JerarquiaAgrupVariablesDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/sy_JerarquiaAgrupVariables.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tablesy_JerarquiaAgrupVariables = new sy_JerarquiaAgrupVariablesDataTable();
            this.Tables.Add(this.tablesy_JerarquiaAgrupVariables);
        }
        
        private bool ShouldSerializesy_JerarquiaAgrupVariables() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void sy_JerarquiaAgrupVariablesRowChangeEventHandler(object sender, sy_JerarquiaAgrupVariablesRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class sy_JerarquiaAgrupVariablesDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnId;
            
            private DataColumn columnDescripcion;
            
            private DataColumn columnNivel;
            
            private DataColumn columnIdPadre;
            
            private DataColumn columnJerarquia;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnIdReservado;
            
            private DataColumn columnRowId;
            
            internal sy_JerarquiaAgrupVariablesDataTable() : 
                    base("sy_JerarquiaAgrupVariables") {
                this.InitClass();
            }
            
            internal sy_JerarquiaAgrupVariablesDataTable(DataTable table) : 
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
            
            internal DataColumn DescripcionColumn {
                get {
                    return this.columnDescripcion;
                }
            }
            
            internal DataColumn NivelColumn {
                get {
                    return this.columnNivel;
                }
            }
            
            internal DataColumn IdPadreColumn {
                get {
                    return this.columnIdPadre;
                }
            }
            
            internal DataColumn JerarquiaColumn {
                get {
                    return this.columnJerarquia;
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
            
            public sy_JerarquiaAgrupVariablesRow this[int index] {
                get {
                    return ((sy_JerarquiaAgrupVariablesRow)(this.Rows[index]));
                }
            }
            
            public event sy_JerarquiaAgrupVariablesRowChangeEventHandler sy_JerarquiaAgrupVariablesRowChanged;
            
            public event sy_JerarquiaAgrupVariablesRowChangeEventHandler sy_JerarquiaAgrupVariablesRowChanging;
            
            public event sy_JerarquiaAgrupVariablesRowChangeEventHandler sy_JerarquiaAgrupVariablesRowDeleted;
            
            public event sy_JerarquiaAgrupVariablesRowChangeEventHandler sy_JerarquiaAgrupVariablesRowDeleting;
            
            public void Addsy_JerarquiaAgrupVariablesRow(sy_JerarquiaAgrupVariablesRow row) {
                this.Rows.Add(row);
            }
            
            public sy_JerarquiaAgrupVariablesRow Addsy_JerarquiaAgrupVariablesRow(string Id, string Descripcion, long Nivel, string IdPadre, string Jerarquia, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, System.Guid RowId) {
                sy_JerarquiaAgrupVariablesRow rowsy_JerarquiaAgrupVariablesRow = ((sy_JerarquiaAgrupVariablesRow)(this.NewRow()));
                rowsy_JerarquiaAgrupVariablesRow.ItemArray = new object[] {
                        Id,
                        Descripcion,
                        Nivel,
                        IdPadre,
                        Jerarquia,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        IdReservado,
                        RowId};
                this.Rows.Add(rowsy_JerarquiaAgrupVariablesRow);
                return rowsy_JerarquiaAgrupVariablesRow;
            }
            
            public sy_JerarquiaAgrupVariablesRow FindById(string Id) {
                return ((sy_JerarquiaAgrupVariablesRow)(this.Rows.Find(new object[] {
                            Id})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                sy_JerarquiaAgrupVariablesDataTable cln = ((sy_JerarquiaAgrupVariablesDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new sy_JerarquiaAgrupVariablesDataTable();
            }
            
            internal void InitVars() {
                this.columnId = this.Columns["Id"];
                this.columnDescripcion = this.Columns["Descripcion"];
                this.columnNivel = this.Columns["Nivel"];
                this.columnIdPadre = this.Columns["IdPadre"];
                this.columnJerarquia = this.Columns["Jerarquia"];
                this.columnFechaCreacion = this.Columns["FechaCreacion"];
                this.columnIdConexionCreacion = this.Columns["IdConexionCreacion"];
                this.columnUltimaModificacion = this.Columns["UltimaModificacion"];
                this.columnIdConexionUltimaModificacion = this.Columns["IdConexionUltimaModificacion"];
                this.columnIdReservado = this.Columns["IdReservado"];
                this.columnRowId = this.Columns["RowId"];
            }
            
            private void InitClass() {
                this.columnId = new DataColumn("Id", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnId);
                this.columnDescripcion = new DataColumn("Descripcion", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnDescripcion);
                this.columnNivel = new DataColumn("Nivel", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnNivel);
                this.columnIdPadre = new DataColumn("IdPadre", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdPadre);
                this.columnJerarquia = new DataColumn("Jerarquia", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnJerarquia);
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
                this.Constraints.Add(new UniqueConstraint("sy_JerarquiaAgrupVariablesDatasetKey1", new DataColumn[] {
                                this.columnId}, true));
                this.columnId.AllowDBNull = false;
                this.columnId.Unique = true;
                this.columnJerarquia.AllowDBNull = false;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public sy_JerarquiaAgrupVariablesRow Newsy_JerarquiaAgrupVariablesRow() {
                return ((sy_JerarquiaAgrupVariablesRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new sy_JerarquiaAgrupVariablesRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(sy_JerarquiaAgrupVariablesRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.sy_JerarquiaAgrupVariablesRowChanged != null)) {
                    this.sy_JerarquiaAgrupVariablesRowChanged(this, new sy_JerarquiaAgrupVariablesRowChangeEvent(((sy_JerarquiaAgrupVariablesRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.sy_JerarquiaAgrupVariablesRowChanging != null)) {
                    this.sy_JerarquiaAgrupVariablesRowChanging(this, new sy_JerarquiaAgrupVariablesRowChangeEvent(((sy_JerarquiaAgrupVariablesRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.sy_JerarquiaAgrupVariablesRowDeleted != null)) {
                    this.sy_JerarquiaAgrupVariablesRowDeleted(this, new sy_JerarquiaAgrupVariablesRowChangeEvent(((sy_JerarquiaAgrupVariablesRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.sy_JerarquiaAgrupVariablesRowDeleting != null)) {
                    this.sy_JerarquiaAgrupVariablesRowDeleting(this, new sy_JerarquiaAgrupVariablesRowChangeEvent(((sy_JerarquiaAgrupVariablesRow)(e.Row)), e.Action));
                }
            }
            
            public void Removesy_JerarquiaAgrupVariablesRow(sy_JerarquiaAgrupVariablesRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class sy_JerarquiaAgrupVariablesRow : DataRow {
            
            private sy_JerarquiaAgrupVariablesDataTable tablesy_JerarquiaAgrupVariables;
            
            internal sy_JerarquiaAgrupVariablesRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tablesy_JerarquiaAgrupVariables = ((sy_JerarquiaAgrupVariablesDataTable)(this.Table));
            }
            
            public string Id {
                get {
                    return ((string)(this[this.tablesy_JerarquiaAgrupVariables.IdColumn]));
                }
                set {
                    this[this.tablesy_JerarquiaAgrupVariables.IdColumn] = value;
                }
            }
            
            public string Descripcion {
                get {
                    try {
                        return ((string)(this[this.tablesy_JerarquiaAgrupVariables.DescripcionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_JerarquiaAgrupVariables.DescripcionColumn] = value;
                }
            }
            
            public long Nivel {
                get {
                    try {
                        return ((long)(this[this.tablesy_JerarquiaAgrupVariables.NivelColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_JerarquiaAgrupVariables.NivelColumn] = value;
                }
            }
            
            public string IdPadre {
                get {
                    try {
                        return ((string)(this[this.tablesy_JerarquiaAgrupVariables.IdPadreColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_JerarquiaAgrupVariables.IdPadreColumn] = value;
                }
            }
            
            public string Jerarquia {
                get {
                    return ((string)(this[this.tablesy_JerarquiaAgrupVariables.JerarquiaColumn]));
                }
                set {
                    this[this.tablesy_JerarquiaAgrupVariables.JerarquiaColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    try {
                        return ((System.DateTime)(this[this.tablesy_JerarquiaAgrupVariables.FechaCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_JerarquiaAgrupVariables.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    try {
                        return ((long)(this[this.tablesy_JerarquiaAgrupVariables.IdConexionCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_JerarquiaAgrupVariables.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tablesy_JerarquiaAgrupVariables.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_JerarquiaAgrupVariables.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tablesy_JerarquiaAgrupVariables.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_JerarquiaAgrupVariables.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public long IdReservado {
                get {
                    try {
                        return ((long)(this[this.tablesy_JerarquiaAgrupVariables.IdReservadoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_JerarquiaAgrupVariables.IdReservadoColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tablesy_JerarquiaAgrupVariables.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_JerarquiaAgrupVariables.RowIdColumn] = value;
                }
            }
            
            public bool IsDescripcionNull() {
                return this.IsNull(this.tablesy_JerarquiaAgrupVariables.DescripcionColumn);
            }
            
            public void SetDescripcionNull() {
                this[this.tablesy_JerarquiaAgrupVariables.DescripcionColumn] = System.Convert.DBNull;
            }
            
            public bool IsNivelNull() {
                return this.IsNull(this.tablesy_JerarquiaAgrupVariables.NivelColumn);
            }
            
            public void SetNivelNull() {
                this[this.tablesy_JerarquiaAgrupVariables.NivelColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdPadreNull() {
                return this.IsNull(this.tablesy_JerarquiaAgrupVariables.IdPadreColumn);
            }
            
            public void SetIdPadreNull() {
                this[this.tablesy_JerarquiaAgrupVariables.IdPadreColumn] = System.Convert.DBNull;
            }
            
            public bool IsFechaCreacionNull() {
                return this.IsNull(this.tablesy_JerarquiaAgrupVariables.FechaCreacionColumn);
            }
            
            public void SetFechaCreacionNull() {
                this[this.tablesy_JerarquiaAgrupVariables.FechaCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionCreacionNull() {
                return this.IsNull(this.tablesy_JerarquiaAgrupVariables.IdConexionCreacionColumn);
            }
            
            public void SetIdConexionCreacionNull() {
                this[this.tablesy_JerarquiaAgrupVariables.IdConexionCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tablesy_JerarquiaAgrupVariables.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tablesy_JerarquiaAgrupVariables.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tablesy_JerarquiaAgrupVariables.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tablesy_JerarquiaAgrupVariables.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdReservadoNull() {
                return this.IsNull(this.tablesy_JerarquiaAgrupVariables.IdReservadoColumn);
            }
            
            public void SetIdReservadoNull() {
                this[this.tablesy_JerarquiaAgrupVariables.IdReservadoColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tablesy_JerarquiaAgrupVariables.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tablesy_JerarquiaAgrupVariables.RowIdColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class sy_JerarquiaAgrupVariablesRowChangeEvent : EventArgs {
            
            private sy_JerarquiaAgrupVariablesRow eventRow;
            
            private DataRowAction eventAction;
            
            public sy_JerarquiaAgrupVariablesRowChangeEvent(sy_JerarquiaAgrupVariablesRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public sy_JerarquiaAgrupVariablesRow Row {
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
