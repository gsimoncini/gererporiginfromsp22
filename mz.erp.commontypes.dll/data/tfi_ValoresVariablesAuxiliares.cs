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
    public class tfi_ValoresVariablesAuxiliaresDataset : DataSet {
        
        private tfi_ValoresVariablesAuxiliaresDataTable tabletfi_ValoresVariablesAuxiliares;
        
        public tfi_ValoresVariablesAuxiliaresDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected tfi_ValoresVariablesAuxiliaresDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["tfi_ValoresVariablesAuxiliares"] != null)) {
                    this.Tables.Add(new tfi_ValoresVariablesAuxiliaresDataTable(ds.Tables["tfi_ValoresVariablesAuxiliares"]));
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
        public tfi_ValoresVariablesAuxiliaresDataTable tfi_ValoresVariablesAuxiliares {
            get {
                return this.tabletfi_ValoresVariablesAuxiliares;
            }
        }
        
        public override DataSet Clone() {
            tfi_ValoresVariablesAuxiliaresDataset cln = ((tfi_ValoresVariablesAuxiliaresDataset)(base.Clone()));
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
            if ((ds.Tables["tfi_ValoresVariablesAuxiliares"] != null)) {
                this.Tables.Add(new tfi_ValoresVariablesAuxiliaresDataTable(ds.Tables["tfi_ValoresVariablesAuxiliares"]));
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
            this.tabletfi_ValoresVariablesAuxiliares = ((tfi_ValoresVariablesAuxiliaresDataTable)(this.Tables["tfi_ValoresVariablesAuxiliares"]));
            if ((this.tabletfi_ValoresVariablesAuxiliares != null)) {
                this.tabletfi_ValoresVariablesAuxiliares.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "tfi_ValoresVariablesAuxiliaresDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/tfi_ValoresVariablesAuxiliares.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tabletfi_ValoresVariablesAuxiliares = new tfi_ValoresVariablesAuxiliaresDataTable();
            this.Tables.Add(this.tabletfi_ValoresVariablesAuxiliares);
        }
        
        private bool ShouldSerializetfi_ValoresVariablesAuxiliares() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void tfi_ValoresVariablesAuxiliaresRowChangeEventHandler(object sender, tfi_ValoresVariablesAuxiliaresRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tfi_ValoresVariablesAuxiliaresDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdValorVariable;
            
            private DataColumn columnIdVariableAuxiliarTDCompTesoreria;
            
            private DataColumn columnValor;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnIdReservado;
            
            private DataColumn columnRowId;
            
            private DataColumn columnIdEmpresa;
            
            private DataColumn columnIdSucursal;
            
            internal tfi_ValoresVariablesAuxiliaresDataTable() : 
                    base("tfi_ValoresVariablesAuxiliares") {
                this.InitClass();
            }
            
            internal tfi_ValoresVariablesAuxiliaresDataTable(DataTable table) : 
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
            
            internal DataColumn IdValorVariableColumn {
                get {
                    return this.columnIdValorVariable;
                }
            }
            
            internal DataColumn IdVariableAuxiliarTDCompTesoreriaColumn {
                get {
                    return this.columnIdVariableAuxiliarTDCompTesoreria;
                }
            }
            
            internal DataColumn ValorColumn {
                get {
                    return this.columnValor;
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
            
            public tfi_ValoresVariablesAuxiliaresRow this[int index] {
                get {
                    return ((tfi_ValoresVariablesAuxiliaresRow)(this.Rows[index]));
                }
            }
            
            public event tfi_ValoresVariablesAuxiliaresRowChangeEventHandler tfi_ValoresVariablesAuxiliaresRowChanged;
            
            public event tfi_ValoresVariablesAuxiliaresRowChangeEventHandler tfi_ValoresVariablesAuxiliaresRowChanging;
            
            public event tfi_ValoresVariablesAuxiliaresRowChangeEventHandler tfi_ValoresVariablesAuxiliaresRowDeleted;
            
            public event tfi_ValoresVariablesAuxiliaresRowChangeEventHandler tfi_ValoresVariablesAuxiliaresRowDeleting;
            
            public void Addtfi_ValoresVariablesAuxiliaresRow(tfi_ValoresVariablesAuxiliaresRow row) {
                this.Rows.Add(row);
            }
            
            public tfi_ValoresVariablesAuxiliaresRow Addtfi_ValoresVariablesAuxiliaresRow(string IdValorVariable, string IdVariableAuxiliarTDCompTesoreria, string Valor, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, System.Guid RowId, long IdEmpresa, long IdSucursal) {
                tfi_ValoresVariablesAuxiliaresRow rowtfi_ValoresVariablesAuxiliaresRow = ((tfi_ValoresVariablesAuxiliaresRow)(this.NewRow()));
                rowtfi_ValoresVariablesAuxiliaresRow.ItemArray = new object[] {
                        IdValorVariable,
                        IdVariableAuxiliarTDCompTesoreria,
                        Valor,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        IdReservado,
                        RowId,
                        IdEmpresa,
                        IdSucursal};
                this.Rows.Add(rowtfi_ValoresVariablesAuxiliaresRow);
                return rowtfi_ValoresVariablesAuxiliaresRow;
            }
            
            public tfi_ValoresVariablesAuxiliaresRow FindByIdValorVariableIdVariableAuxiliarTDCompTesoreria(string IdValorVariable, string IdVariableAuxiliarTDCompTesoreria) {
                return ((tfi_ValoresVariablesAuxiliaresRow)(this.Rows.Find(new object[] {
                            IdValorVariable,
                            IdVariableAuxiliarTDCompTesoreria})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                tfi_ValoresVariablesAuxiliaresDataTable cln = ((tfi_ValoresVariablesAuxiliaresDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new tfi_ValoresVariablesAuxiliaresDataTable();
            }
            
            internal void InitVars() {
                this.columnIdValorVariable = this.Columns["IdValorVariable"];
                this.columnIdVariableAuxiliarTDCompTesoreria = this.Columns["IdVariableAuxiliarTDCompTesoreria"];
                this.columnValor = this.Columns["Valor"];
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
                this.columnIdValorVariable = new DataColumn("IdValorVariable", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdValorVariable);
                this.columnIdVariableAuxiliarTDCompTesoreria = new DataColumn("IdVariableAuxiliarTDCompTesoreria", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdVariableAuxiliarTDCompTesoreria);
                this.columnValor = new DataColumn("Valor", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnValor);
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
                this.Constraints.Add(new UniqueConstraint("tfi_ValoresVariablesAuxiliaresKey1", new DataColumn[] {
                                this.columnIdValorVariable,
                                this.columnIdVariableAuxiliarTDCompTesoreria}, true));
                this.columnIdValorVariable.AllowDBNull = false;
                this.columnIdVariableAuxiliarTDCompTesoreria.AllowDBNull = false;
                this.columnValor.AllowDBNull = false;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public tfi_ValoresVariablesAuxiliaresRow Newtfi_ValoresVariablesAuxiliaresRow() {
                return ((tfi_ValoresVariablesAuxiliaresRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new tfi_ValoresVariablesAuxiliaresRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(tfi_ValoresVariablesAuxiliaresRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.tfi_ValoresVariablesAuxiliaresRowChanged != null)) {
                    this.tfi_ValoresVariablesAuxiliaresRowChanged(this, new tfi_ValoresVariablesAuxiliaresRowChangeEvent(((tfi_ValoresVariablesAuxiliaresRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.tfi_ValoresVariablesAuxiliaresRowChanging != null)) {
                    this.tfi_ValoresVariablesAuxiliaresRowChanging(this, new tfi_ValoresVariablesAuxiliaresRowChangeEvent(((tfi_ValoresVariablesAuxiliaresRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.tfi_ValoresVariablesAuxiliaresRowDeleted != null)) {
                    this.tfi_ValoresVariablesAuxiliaresRowDeleted(this, new tfi_ValoresVariablesAuxiliaresRowChangeEvent(((tfi_ValoresVariablesAuxiliaresRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.tfi_ValoresVariablesAuxiliaresRowDeleting != null)) {
                    this.tfi_ValoresVariablesAuxiliaresRowDeleting(this, new tfi_ValoresVariablesAuxiliaresRowChangeEvent(((tfi_ValoresVariablesAuxiliaresRow)(e.Row)), e.Action));
                }
            }
            
            public void Removetfi_ValoresVariablesAuxiliaresRow(tfi_ValoresVariablesAuxiliaresRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tfi_ValoresVariablesAuxiliaresRow : DataRow {
            
            private tfi_ValoresVariablesAuxiliaresDataTable tabletfi_ValoresVariablesAuxiliares;
            
            internal tfi_ValoresVariablesAuxiliaresRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tabletfi_ValoresVariablesAuxiliares = ((tfi_ValoresVariablesAuxiliaresDataTable)(this.Table));
            }
            
            public string IdValorVariable {
                get {
                    return ((string)(this[this.tabletfi_ValoresVariablesAuxiliares.IdValorVariableColumn]));
                }
                set {
                    this[this.tabletfi_ValoresVariablesAuxiliares.IdValorVariableColumn] = value;
                }
            }
            
            public string IdVariableAuxiliarTDCompTesoreria {
                get {
                    return ((string)(this[this.tabletfi_ValoresVariablesAuxiliares.IdVariableAuxiliarTDCompTesoreriaColumn]));
                }
                set {
                    this[this.tabletfi_ValoresVariablesAuxiliares.IdVariableAuxiliarTDCompTesoreriaColumn] = value;
                }
            }
            
            public string Valor {
                get {
                    return ((string)(this[this.tabletfi_ValoresVariablesAuxiliares.ValorColumn]));
                }
                set {
                    this[this.tabletfi_ValoresVariablesAuxiliares.ValorColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    try {
                        return ((System.DateTime)(this[this.tabletfi_ValoresVariablesAuxiliares.FechaCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletfi_ValoresVariablesAuxiliares.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    try {
                        return ((long)(this[this.tabletfi_ValoresVariablesAuxiliares.IdConexionCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletfi_ValoresVariablesAuxiliares.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tabletfi_ValoresVariablesAuxiliares.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletfi_ValoresVariablesAuxiliares.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tabletfi_ValoresVariablesAuxiliares.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletfi_ValoresVariablesAuxiliares.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public long IdReservado {
                get {
                    try {
                        return ((long)(this[this.tabletfi_ValoresVariablesAuxiliares.IdReservadoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletfi_ValoresVariablesAuxiliares.IdReservadoColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tabletfi_ValoresVariablesAuxiliares.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletfi_ValoresVariablesAuxiliares.RowIdColumn] = value;
                }
            }
            
            public long IdEmpresa {
                get {
                    try {
                        return ((long)(this[this.tabletfi_ValoresVariablesAuxiliares.IdEmpresaColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletfi_ValoresVariablesAuxiliares.IdEmpresaColumn] = value;
                }
            }
            
            public long IdSucursal {
                get {
                    try {
                        return ((long)(this[this.tabletfi_ValoresVariablesAuxiliares.IdSucursalColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletfi_ValoresVariablesAuxiliares.IdSucursalColumn] = value;
                }
            }
            
            public bool IsFechaCreacionNull() {
                return this.IsNull(this.tabletfi_ValoresVariablesAuxiliares.FechaCreacionColumn);
            }
            
            public void SetFechaCreacionNull() {
                this[this.tabletfi_ValoresVariablesAuxiliares.FechaCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionCreacionNull() {
                return this.IsNull(this.tabletfi_ValoresVariablesAuxiliares.IdConexionCreacionColumn);
            }
            
            public void SetIdConexionCreacionNull() {
                this[this.tabletfi_ValoresVariablesAuxiliares.IdConexionCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tabletfi_ValoresVariablesAuxiliares.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tabletfi_ValoresVariablesAuxiliares.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tabletfi_ValoresVariablesAuxiliares.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tabletfi_ValoresVariablesAuxiliares.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdReservadoNull() {
                return this.IsNull(this.tabletfi_ValoresVariablesAuxiliares.IdReservadoColumn);
            }
            
            public void SetIdReservadoNull() {
                this[this.tabletfi_ValoresVariablesAuxiliares.IdReservadoColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tabletfi_ValoresVariablesAuxiliares.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tabletfi_ValoresVariablesAuxiliares.RowIdColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdEmpresaNull() {
                return this.IsNull(this.tabletfi_ValoresVariablesAuxiliares.IdEmpresaColumn);
            }
            
            public void SetIdEmpresaNull() {
                this[this.tabletfi_ValoresVariablesAuxiliares.IdEmpresaColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdSucursalNull() {
                return this.IsNull(this.tabletfi_ValoresVariablesAuxiliares.IdSucursalColumn);
            }
            
            public void SetIdSucursalNull() {
                this[this.tabletfi_ValoresVariablesAuxiliares.IdSucursalColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tfi_ValoresVariablesAuxiliaresRowChangeEvent : EventArgs {
            
            private tfi_ValoresVariablesAuxiliaresRow eventRow;
            
            private DataRowAction eventAction;
            
            public tfi_ValoresVariablesAuxiliaresRowChangeEvent(tfi_ValoresVariablesAuxiliaresRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public tfi_ValoresVariablesAuxiliaresRow Row {
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
