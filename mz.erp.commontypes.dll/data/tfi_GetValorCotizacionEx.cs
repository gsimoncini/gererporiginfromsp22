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
    public class tfi_GetValorCotizacionExDataset : DataSet {
        
        private Pr_tfi_CotizacionesMoneda_GetValorCotizacionDataTable tablePr_tfi_CotizacionesMoneda_GetValorCotizacion;
        
        public tfi_GetValorCotizacionExDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected tfi_GetValorCotizacionExDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["Pr_tfi_CotizacionesMoneda_GetValorCotizacion"] != null)) {
                    this.Tables.Add(new Pr_tfi_CotizacionesMoneda_GetValorCotizacionDataTable(ds.Tables["Pr_tfi_CotizacionesMoneda_GetValorCotizacion"]));
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
        public Pr_tfi_CotizacionesMoneda_GetValorCotizacionDataTable Pr_tfi_CotizacionesMoneda_GetValorCotizacion {
            get {
                return this.tablePr_tfi_CotizacionesMoneda_GetValorCotizacion;
            }
        }
        
        public override DataSet Clone() {
            tfi_GetValorCotizacionExDataset cln = ((tfi_GetValorCotizacionExDataset)(base.Clone()));
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
            if ((ds.Tables["Pr_tfi_CotizacionesMoneda_GetValorCotizacion"] != null)) {
                this.Tables.Add(new Pr_tfi_CotizacionesMoneda_GetValorCotizacionDataTable(ds.Tables["Pr_tfi_CotizacionesMoneda_GetValorCotizacion"]));
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
            this.tablePr_tfi_CotizacionesMoneda_GetValorCotizacion = ((Pr_tfi_CotizacionesMoneda_GetValorCotizacionDataTable)(this.Tables["Pr_tfi_CotizacionesMoneda_GetValorCotizacion"]));
            if ((this.tablePr_tfi_CotizacionesMoneda_GetValorCotizacion != null)) {
                this.tablePr_tfi_CotizacionesMoneda_GetValorCotizacion.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "tfi_GetValorCotizacionExDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/tfi_GetValorCotizacion.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tablePr_tfi_CotizacionesMoneda_GetValorCotizacion = new Pr_tfi_CotizacionesMoneda_GetValorCotizacionDataTable();
            this.Tables.Add(this.tablePr_tfi_CotizacionesMoneda_GetValorCotizacion);
        }
        
        private bool ShouldSerializePr_tfi_CotizacionesMoneda_GetValorCotizacion() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void Pr_tfi_CotizacionesMoneda_GetValorCotizacionRowChangeEventHandler(object sender, Pr_tfi_CotizacionesMoneda_GetValorCotizacionRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class Pr_tfi_CotizacionesMoneda_GetValorCotizacionDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnvalor;
            
            internal Pr_tfi_CotizacionesMoneda_GetValorCotizacionDataTable() : 
                    base("Pr_tfi_CotizacionesMoneda_GetValorCotizacion") {
                this.InitClass();
            }
            
            internal Pr_tfi_CotizacionesMoneda_GetValorCotizacionDataTable(DataTable table) : 
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
            
            internal DataColumn valorColumn {
                get {
                    return this.columnvalor;
                }
            }
            
            public Pr_tfi_CotizacionesMoneda_GetValorCotizacionRow this[int index] {
                get {
                    return ((Pr_tfi_CotizacionesMoneda_GetValorCotizacionRow)(this.Rows[index]));
                }
            }
            
            public event Pr_tfi_CotizacionesMoneda_GetValorCotizacionRowChangeEventHandler Pr_tfi_CotizacionesMoneda_GetValorCotizacionRowChanged;
            
            public event Pr_tfi_CotizacionesMoneda_GetValorCotizacionRowChangeEventHandler Pr_tfi_CotizacionesMoneda_GetValorCotizacionRowChanging;
            
            public event Pr_tfi_CotizacionesMoneda_GetValorCotizacionRowChangeEventHandler Pr_tfi_CotizacionesMoneda_GetValorCotizacionRowDeleted;
            
            public event Pr_tfi_CotizacionesMoneda_GetValorCotizacionRowChangeEventHandler Pr_tfi_CotizacionesMoneda_GetValorCotizacionRowDeleting;
            
            public void AddPr_tfi_CotizacionesMoneda_GetValorCotizacionRow(Pr_tfi_CotizacionesMoneda_GetValorCotizacionRow row) {
                this.Rows.Add(row);
            }
            
            public Pr_tfi_CotizacionesMoneda_GetValorCotizacionRow AddPr_tfi_CotizacionesMoneda_GetValorCotizacionRow(System.Decimal valor) {
                Pr_tfi_CotizacionesMoneda_GetValorCotizacionRow rowPr_tfi_CotizacionesMoneda_GetValorCotizacionRow = ((Pr_tfi_CotizacionesMoneda_GetValorCotizacionRow)(this.NewRow()));
                rowPr_tfi_CotizacionesMoneda_GetValorCotizacionRow.ItemArray = new object[] {
                        valor};
                this.Rows.Add(rowPr_tfi_CotizacionesMoneda_GetValorCotizacionRow);
                return rowPr_tfi_CotizacionesMoneda_GetValorCotizacionRow;
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                Pr_tfi_CotizacionesMoneda_GetValorCotizacionDataTable cln = ((Pr_tfi_CotizacionesMoneda_GetValorCotizacionDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new Pr_tfi_CotizacionesMoneda_GetValorCotizacionDataTable();
            }
            
            internal void InitVars() {
                this.columnvalor = this.Columns["valor"];
            }
            
            private void InitClass() {
                this.columnvalor = new DataColumn("valor", typeof(System.Decimal), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnvalor);
            }
            
            public Pr_tfi_CotizacionesMoneda_GetValorCotizacionRow NewPr_tfi_CotizacionesMoneda_GetValorCotizacionRow() {
                return ((Pr_tfi_CotizacionesMoneda_GetValorCotizacionRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new Pr_tfi_CotizacionesMoneda_GetValorCotizacionRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(Pr_tfi_CotizacionesMoneda_GetValorCotizacionRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.Pr_tfi_CotizacionesMoneda_GetValorCotizacionRowChanged != null)) {
                    this.Pr_tfi_CotizacionesMoneda_GetValorCotizacionRowChanged(this, new Pr_tfi_CotizacionesMoneda_GetValorCotizacionRowChangeEvent(((Pr_tfi_CotizacionesMoneda_GetValorCotizacionRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.Pr_tfi_CotizacionesMoneda_GetValorCotizacionRowChanging != null)) {
                    this.Pr_tfi_CotizacionesMoneda_GetValorCotizacionRowChanging(this, new Pr_tfi_CotizacionesMoneda_GetValorCotizacionRowChangeEvent(((Pr_tfi_CotizacionesMoneda_GetValorCotizacionRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.Pr_tfi_CotizacionesMoneda_GetValorCotizacionRowDeleted != null)) {
                    this.Pr_tfi_CotizacionesMoneda_GetValorCotizacionRowDeleted(this, new Pr_tfi_CotizacionesMoneda_GetValorCotizacionRowChangeEvent(((Pr_tfi_CotizacionesMoneda_GetValorCotizacionRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.Pr_tfi_CotizacionesMoneda_GetValorCotizacionRowDeleting != null)) {
                    this.Pr_tfi_CotizacionesMoneda_GetValorCotizacionRowDeleting(this, new Pr_tfi_CotizacionesMoneda_GetValorCotizacionRowChangeEvent(((Pr_tfi_CotizacionesMoneda_GetValorCotizacionRow)(e.Row)), e.Action));
                }
            }
            
            public void RemovePr_tfi_CotizacionesMoneda_GetValorCotizacionRow(Pr_tfi_CotizacionesMoneda_GetValorCotizacionRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class Pr_tfi_CotizacionesMoneda_GetValorCotizacionRow : DataRow {
            
            private Pr_tfi_CotizacionesMoneda_GetValorCotizacionDataTable tablePr_tfi_CotizacionesMoneda_GetValorCotizacion;
            
            internal Pr_tfi_CotizacionesMoneda_GetValorCotizacionRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tablePr_tfi_CotizacionesMoneda_GetValorCotizacion = ((Pr_tfi_CotizacionesMoneda_GetValorCotizacionDataTable)(this.Table));
            }
            
            public System.Decimal valor {
                get {
                    try {
                        return ((System.Decimal)(this[this.tablePr_tfi_CotizacionesMoneda_GetValorCotizacion.valorColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablePr_tfi_CotizacionesMoneda_GetValorCotizacion.valorColumn] = value;
                }
            }
            
            public bool IsvalorNull() {
                return this.IsNull(this.tablePr_tfi_CotizacionesMoneda_GetValorCotizacion.valorColumn);
            }
            
            public void SetvalorNull() {
                this[this.tablePr_tfi_CotizacionesMoneda_GetValorCotizacion.valorColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class Pr_tfi_CotizacionesMoneda_GetValorCotizacionRowChangeEvent : EventArgs {
            
            private Pr_tfi_CotizacionesMoneda_GetValorCotizacionRow eventRow;
            
            private DataRowAction eventAction;
            
            public Pr_tfi_CotizacionesMoneda_GetValorCotizacionRowChangeEvent(Pr_tfi_CotizacionesMoneda_GetValorCotizacionRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public Pr_tfi_CotizacionesMoneda_GetValorCotizacionRow Row {
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
