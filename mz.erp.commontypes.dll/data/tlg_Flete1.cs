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
    public class tlg_FleteDataset : DataSet {
        
        private tlg_FleteDataTable tabletlg_Flete;
        
        public tlg_FleteDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected tlg_FleteDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["tlg_Flete"] != null)) {
                    this.Tables.Add(new tlg_FleteDataTable(ds.Tables["tlg_Flete"]));
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
        public tlg_FleteDataTable tlg_Flete {
            get {
                return this.tabletlg_Flete;
            }
        }
        
        public override DataSet Clone() {
            tlg_FleteDataset cln = ((tlg_FleteDataset)(base.Clone()));
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
            if ((ds.Tables["tlg_Flete"] != null)) {
                this.Tables.Add(new tlg_FleteDataTable(ds.Tables["tlg_Flete"]));
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
            this.tabletlg_Flete = ((tlg_FleteDataTable)(this.Tables["tlg_Flete"]));
            if ((this.tabletlg_Flete != null)) {
                this.tabletlg_Flete.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "tlg_FleteDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/tlg_Flete.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tabletlg_Flete = new tlg_FleteDataTable();
            this.Tables.Add(this.tabletlg_Flete);
        }
        
        private bool ShouldSerializetlg_Flete() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void tlg_FleteRowChangeEventHandler(object sender, tlg_FleteRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tlg_FleteDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdComprobanteCargoAdicional;
            
            private DataColumn columnIdTransporte;
            
            private DataColumn columnCampoAuxiliar1;
            
            private DataColumn columnCampoAuxiliar2;
            
            private DataColumn columnCampoAuxiliar3;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnIdReservado;
            
            private DataColumn columnRowId;
            
            internal tlg_FleteDataTable() : 
                    base("tlg_Flete") {
                this.InitClass();
            }
            
            internal tlg_FleteDataTable(DataTable table) : 
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
            
            internal DataColumn IdComprobanteCargoAdicionalColumn {
                get {
                    return this.columnIdComprobanteCargoAdicional;
                }
            }
            
            internal DataColumn IdTransporteColumn {
                get {
                    return this.columnIdTransporte;
                }
            }
            
            internal DataColumn CampoAuxiliar1Column {
                get {
                    return this.columnCampoAuxiliar1;
                }
            }
            
            internal DataColumn CampoAuxiliar2Column {
                get {
                    return this.columnCampoAuxiliar2;
                }
            }
            
            internal DataColumn CampoAuxiliar3Column {
                get {
                    return this.columnCampoAuxiliar3;
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
            
            public tlg_FleteRow this[int index] {
                get {
                    return ((tlg_FleteRow)(this.Rows[index]));
                }
            }
            
            public event tlg_FleteRowChangeEventHandler tlg_FleteRowChanged;
            
            public event tlg_FleteRowChangeEventHandler tlg_FleteRowChanging;
            
            public event tlg_FleteRowChangeEventHandler tlg_FleteRowDeleted;
            
            public event tlg_FleteRowChangeEventHandler tlg_FleteRowDeleting;
            
            public void Addtlg_FleteRow(tlg_FleteRow row) {
                this.Rows.Add(row);
            }
            
            public tlg_FleteRow Addtlg_FleteRow(string IdComprobanteCargoAdicional, string IdTransporte, string CampoAuxiliar1, string CampoAuxiliar2, string CampoAuxiliar3, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, System.Guid RowId) {
                tlg_FleteRow rowtlg_FleteRow = ((tlg_FleteRow)(this.NewRow()));
                rowtlg_FleteRow.ItemArray = new object[] {
                        IdComprobanteCargoAdicional,
                        IdTransporte,
                        CampoAuxiliar1,
                        CampoAuxiliar2,
                        CampoAuxiliar3,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        IdReservado,
                        RowId};
                this.Rows.Add(rowtlg_FleteRow);
                return rowtlg_FleteRow;
            }
            
            public tlg_FleteRow FindByIdComprobanteCargoAdicionalIdTransporte(string IdComprobanteCargoAdicional, string IdTransporte) {
                return ((tlg_FleteRow)(this.Rows.Find(new object[] {
                            IdComprobanteCargoAdicional,
                            IdTransporte})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                tlg_FleteDataTable cln = ((tlg_FleteDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new tlg_FleteDataTable();
            }
            
            internal void InitVars() {
                this.columnIdComprobanteCargoAdicional = this.Columns["IdComprobanteCargoAdicional"];
                this.columnIdTransporte = this.Columns["IdTransporte"];
                this.columnCampoAuxiliar1 = this.Columns["CampoAuxiliar1"];
                this.columnCampoAuxiliar2 = this.Columns["CampoAuxiliar2"];
                this.columnCampoAuxiliar3 = this.Columns["CampoAuxiliar3"];
                this.columnFechaCreacion = this.Columns["FechaCreacion"];
                this.columnIdConexionCreacion = this.Columns["IdConexionCreacion"];
                this.columnUltimaModificacion = this.Columns["UltimaModificacion"];
                this.columnIdConexionUltimaModificacion = this.Columns["IdConexionUltimaModificacion"];
                this.columnIdReservado = this.Columns["IdReservado"];
                this.columnRowId = this.Columns["RowId"];
            }
            
            private void InitClass() {
                this.columnIdComprobanteCargoAdicional = new DataColumn("IdComprobanteCargoAdicional", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdComprobanteCargoAdicional);
                this.columnIdTransporte = new DataColumn("IdTransporte", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdTransporte);
                this.columnCampoAuxiliar1 = new DataColumn("CampoAuxiliar1", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCampoAuxiliar1);
                this.columnCampoAuxiliar2 = new DataColumn("CampoAuxiliar2", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCampoAuxiliar2);
                this.columnCampoAuxiliar3 = new DataColumn("CampoAuxiliar3", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCampoAuxiliar3);
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
                this.Constraints.Add(new UniqueConstraint("tlg_FleteDatasetKey1", new DataColumn[] {
                                this.columnIdComprobanteCargoAdicional,
                                this.columnIdTransporte}, true));
                this.columnIdComprobanteCargoAdicional.AllowDBNull = false;
                this.columnIdTransporte.AllowDBNull = false;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public tlg_FleteRow Newtlg_FleteRow() {
                return ((tlg_FleteRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new tlg_FleteRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(tlg_FleteRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.tlg_FleteRowChanged != null)) {
                    this.tlg_FleteRowChanged(this, new tlg_FleteRowChangeEvent(((tlg_FleteRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.tlg_FleteRowChanging != null)) {
                    this.tlg_FleteRowChanging(this, new tlg_FleteRowChangeEvent(((tlg_FleteRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.tlg_FleteRowDeleted != null)) {
                    this.tlg_FleteRowDeleted(this, new tlg_FleteRowChangeEvent(((tlg_FleteRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.tlg_FleteRowDeleting != null)) {
                    this.tlg_FleteRowDeleting(this, new tlg_FleteRowChangeEvent(((tlg_FleteRow)(e.Row)), e.Action));
                }
            }
            
            public void Removetlg_FleteRow(tlg_FleteRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tlg_FleteRow : DataRow {
            
            private tlg_FleteDataTable tabletlg_Flete;
            
            internal tlg_FleteRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tabletlg_Flete = ((tlg_FleteDataTable)(this.Table));
            }
            
            public string IdComprobanteCargoAdicional {
                get {
                    return ((string)(this[this.tabletlg_Flete.IdComprobanteCargoAdicionalColumn]));
                }
                set {
                    this[this.tabletlg_Flete.IdComprobanteCargoAdicionalColumn] = value;
                }
            }
            
            public string IdTransporte {
                get {
                    return ((string)(this[this.tabletlg_Flete.IdTransporteColumn]));
                }
                set {
                    this[this.tabletlg_Flete.IdTransporteColumn] = value;
                }
            }
            
            public string CampoAuxiliar1 {
                get {
                    try {
                        return ((string)(this[this.tabletlg_Flete.CampoAuxiliar1Column]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_Flete.CampoAuxiliar1Column] = value;
                }
            }
            
            public string CampoAuxiliar2 {
                get {
                    try {
                        return ((string)(this[this.tabletlg_Flete.CampoAuxiliar2Column]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_Flete.CampoAuxiliar2Column] = value;
                }
            }
            
            public string CampoAuxiliar3 {
                get {
                    try {
                        return ((string)(this[this.tabletlg_Flete.CampoAuxiliar3Column]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_Flete.CampoAuxiliar3Column] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    try {
                        return ((System.DateTime)(this[this.tabletlg_Flete.FechaCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_Flete.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    try {
                        return ((long)(this[this.tabletlg_Flete.IdConexionCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_Flete.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tabletlg_Flete.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_Flete.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tabletlg_Flete.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_Flete.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public long IdReservado {
                get {
                    try {
                        return ((long)(this[this.tabletlg_Flete.IdReservadoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_Flete.IdReservadoColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tabletlg_Flete.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_Flete.RowIdColumn] = value;
                }
            }
            
            public bool IsCampoAuxiliar1Null() {
                return this.IsNull(this.tabletlg_Flete.CampoAuxiliar1Column);
            }
            
            public void SetCampoAuxiliar1Null() {
                this[this.tabletlg_Flete.CampoAuxiliar1Column] = System.Convert.DBNull;
            }
            
            public bool IsCampoAuxiliar2Null() {
                return this.IsNull(this.tabletlg_Flete.CampoAuxiliar2Column);
            }
            
            public void SetCampoAuxiliar2Null() {
                this[this.tabletlg_Flete.CampoAuxiliar2Column] = System.Convert.DBNull;
            }
            
            public bool IsCampoAuxiliar3Null() {
                return this.IsNull(this.tabletlg_Flete.CampoAuxiliar3Column);
            }
            
            public void SetCampoAuxiliar3Null() {
                this[this.tabletlg_Flete.CampoAuxiliar3Column] = System.Convert.DBNull;
            }
            
            public bool IsFechaCreacionNull() {
                return this.IsNull(this.tabletlg_Flete.FechaCreacionColumn);
            }
            
            public void SetFechaCreacionNull() {
                this[this.tabletlg_Flete.FechaCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionCreacionNull() {
                return this.IsNull(this.tabletlg_Flete.IdConexionCreacionColumn);
            }
            
            public void SetIdConexionCreacionNull() {
                this[this.tabletlg_Flete.IdConexionCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tabletlg_Flete.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tabletlg_Flete.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tabletlg_Flete.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tabletlg_Flete.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdReservadoNull() {
                return this.IsNull(this.tabletlg_Flete.IdReservadoColumn);
            }
            
            public void SetIdReservadoNull() {
                this[this.tabletlg_Flete.IdReservadoColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tabletlg_Flete.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tabletlg_Flete.RowIdColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tlg_FleteRowChangeEvent : EventArgs {
            
            private tlg_FleteRow eventRow;
            
            private DataRowAction eventAction;
            
            public tlg_FleteRowChangeEvent(tlg_FleteRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public tlg_FleteRow Row {
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
