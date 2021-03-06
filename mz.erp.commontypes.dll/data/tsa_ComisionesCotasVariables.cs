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
    public class tsa_ComisionesCotasVariablesDataset : DataSet {
        
        private tsa_ComisionesCotasVariablesDataTable tabletsa_ComisionesCotasVariables;
        
        public tsa_ComisionesCotasVariablesDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected tsa_ComisionesCotasVariablesDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["tsa_ComisionesCotasVariables"] != null)) {
                    this.Tables.Add(new tsa_ComisionesCotasVariablesDataTable(ds.Tables["tsa_ComisionesCotasVariables"]));
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
        public tsa_ComisionesCotasVariablesDataTable tsa_ComisionesCotasVariables {
            get {
                return this.tabletsa_ComisionesCotasVariables;
            }
        }
        
        public override DataSet Clone() {
            tsa_ComisionesCotasVariablesDataset cln = ((tsa_ComisionesCotasVariablesDataset)(base.Clone()));
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
            if ((ds.Tables["tsa_ComisionesCotasVariables"] != null)) {
                this.Tables.Add(new tsa_ComisionesCotasVariablesDataTable(ds.Tables["tsa_ComisionesCotasVariables"]));
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
            this.tabletsa_ComisionesCotasVariables = ((tsa_ComisionesCotasVariablesDataTable)(this.Tables["tsa_ComisionesCotasVariables"]));
            if ((this.tabletsa_ComisionesCotasVariables != null)) {
                this.tabletsa_ComisionesCotasVariables.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "tsa_ComisionesCotasVariablesDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/tsa_ComisionesCotasVariables.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tabletsa_ComisionesCotasVariables = new tsa_ComisionesCotasVariablesDataTable();
            this.Tables.Add(this.tabletsa_ComisionesCotasVariables);
        }
        
        private bool ShouldSerializetsa_ComisionesCotasVariables() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void tsa_ComisionesCotasVariablesRowChangeEventHandler(object sender, tsa_ComisionesCotasVariablesRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsa_ComisionesCotasVariablesDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdComision;
            
            private DataColumn columnRenglon;
            
            private DataColumn columnCotaInferior;
            
            private DataColumn columnCotaSuperior;
            
            private DataColumn columnValorAAplicar;
            
            private DataColumn columnFormaDeAplicacion;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnIdReservado;
            
            private DataColumn columnRowId;
            
            private DataColumn columnIdSucursal;
            
            private DataColumn columnIdEmpresa;
            
            internal tsa_ComisionesCotasVariablesDataTable() : 
                    base("tsa_ComisionesCotasVariables") {
                this.InitClass();
            }
            
            internal tsa_ComisionesCotasVariablesDataTable(DataTable table) : 
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
            
            internal DataColumn IdComisionColumn {
                get {
                    return this.columnIdComision;
                }
            }
            
            internal DataColumn RenglonColumn {
                get {
                    return this.columnRenglon;
                }
            }
            
            internal DataColumn CotaInferiorColumn {
                get {
                    return this.columnCotaInferior;
                }
            }
            
            internal DataColumn CotaSuperiorColumn {
                get {
                    return this.columnCotaSuperior;
                }
            }
            
            internal DataColumn ValorAAplicarColumn {
                get {
                    return this.columnValorAAplicar;
                }
            }
            
            internal DataColumn FormaDeAplicacionColumn {
                get {
                    return this.columnFormaDeAplicacion;
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
            
            public tsa_ComisionesCotasVariablesRow this[int index] {
                get {
                    return ((tsa_ComisionesCotasVariablesRow)(this.Rows[index]));
                }
            }
            
            public event tsa_ComisionesCotasVariablesRowChangeEventHandler tsa_ComisionesCotasVariablesRowChanged;
            
            public event tsa_ComisionesCotasVariablesRowChangeEventHandler tsa_ComisionesCotasVariablesRowChanging;
            
            public event tsa_ComisionesCotasVariablesRowChangeEventHandler tsa_ComisionesCotasVariablesRowDeleted;
            
            public event tsa_ComisionesCotasVariablesRowChangeEventHandler tsa_ComisionesCotasVariablesRowDeleting;
            
            public void Addtsa_ComisionesCotasVariablesRow(tsa_ComisionesCotasVariablesRow row) {
                this.Rows.Add(row);
            }
            
            public tsa_ComisionesCotasVariablesRow Addtsa_ComisionesCotasVariablesRow(long IdComision, short Renglon, System.Decimal CotaInferior, System.Decimal CotaSuperior, System.Decimal ValorAAplicar, string FormaDeAplicacion, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, System.Guid RowId, long IdSucursal, long IdEmpresa) {
                tsa_ComisionesCotasVariablesRow rowtsa_ComisionesCotasVariablesRow = ((tsa_ComisionesCotasVariablesRow)(this.NewRow()));
                rowtsa_ComisionesCotasVariablesRow.ItemArray = new object[] {
                        IdComision,
                        Renglon,
                        CotaInferior,
                        CotaSuperior,
                        ValorAAplicar,
                        FormaDeAplicacion,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        IdReservado,
                        RowId,
                        IdSucursal,
                        IdEmpresa};
                this.Rows.Add(rowtsa_ComisionesCotasVariablesRow);
                return rowtsa_ComisionesCotasVariablesRow;
            }
            
            public tsa_ComisionesCotasVariablesRow FindByIdComisionRenglon(long IdComision, short Renglon) {
                return ((tsa_ComisionesCotasVariablesRow)(this.Rows.Find(new object[] {
                            IdComision,
                            Renglon})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                tsa_ComisionesCotasVariablesDataTable cln = ((tsa_ComisionesCotasVariablesDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new tsa_ComisionesCotasVariablesDataTable();
            }
            
            internal void InitVars() {
                this.columnIdComision = this.Columns["IdComision"];
                this.columnRenglon = this.Columns["Renglon"];
                this.columnCotaInferior = this.Columns["CotaInferior"];
                this.columnCotaSuperior = this.Columns["CotaSuperior"];
                this.columnValorAAplicar = this.Columns["ValorAAplicar"];
                this.columnFormaDeAplicacion = this.Columns["FormaDeAplicacion"];
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
                this.columnIdComision = new DataColumn("IdComision", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdComision);
                this.columnRenglon = new DataColumn("Renglon", typeof(short), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnRenglon);
                this.columnCotaInferior = new DataColumn("CotaInferior", typeof(System.Decimal), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCotaInferior);
                this.columnCotaSuperior = new DataColumn("CotaSuperior", typeof(System.Decimal), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCotaSuperior);
                this.columnValorAAplicar = new DataColumn("ValorAAplicar", typeof(System.Decimal), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnValorAAplicar);
                this.columnFormaDeAplicacion = new DataColumn("FormaDeAplicacion", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnFormaDeAplicacion);
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
                this.Constraints.Add(new UniqueConstraint("tsa_ComisionesCotasVariablesKey1", new DataColumn[] {
                                this.columnIdComision,
                                this.columnRenglon}, true));
                this.columnIdComision.AllowDBNull = false;
                this.columnRenglon.AllowDBNull = false;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public tsa_ComisionesCotasVariablesRow Newtsa_ComisionesCotasVariablesRow() {
                return ((tsa_ComisionesCotasVariablesRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new tsa_ComisionesCotasVariablesRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(tsa_ComisionesCotasVariablesRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.tsa_ComisionesCotasVariablesRowChanged != null)) {
                    this.tsa_ComisionesCotasVariablesRowChanged(this, new tsa_ComisionesCotasVariablesRowChangeEvent(((tsa_ComisionesCotasVariablesRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.tsa_ComisionesCotasVariablesRowChanging != null)) {
                    this.tsa_ComisionesCotasVariablesRowChanging(this, new tsa_ComisionesCotasVariablesRowChangeEvent(((tsa_ComisionesCotasVariablesRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.tsa_ComisionesCotasVariablesRowDeleted != null)) {
                    this.tsa_ComisionesCotasVariablesRowDeleted(this, new tsa_ComisionesCotasVariablesRowChangeEvent(((tsa_ComisionesCotasVariablesRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.tsa_ComisionesCotasVariablesRowDeleting != null)) {
                    this.tsa_ComisionesCotasVariablesRowDeleting(this, new tsa_ComisionesCotasVariablesRowChangeEvent(((tsa_ComisionesCotasVariablesRow)(e.Row)), e.Action));
                }
            }
            
            public void Removetsa_ComisionesCotasVariablesRow(tsa_ComisionesCotasVariablesRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsa_ComisionesCotasVariablesRow : DataRow {
            
            private tsa_ComisionesCotasVariablesDataTable tabletsa_ComisionesCotasVariables;
            
            internal tsa_ComisionesCotasVariablesRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tabletsa_ComisionesCotasVariables = ((tsa_ComisionesCotasVariablesDataTable)(this.Table));
            }
            
            public long IdComision {
                get {
                    return ((long)(this[this.tabletsa_ComisionesCotasVariables.IdComisionColumn]));
                }
                set {
                    this[this.tabletsa_ComisionesCotasVariables.IdComisionColumn] = value;
                }
            }
            
            public short Renglon {
                get {
                    return ((short)(this[this.tabletsa_ComisionesCotasVariables.RenglonColumn]));
                }
                set {
                    this[this.tabletsa_ComisionesCotasVariables.RenglonColumn] = value;
                }
            }
            
            public System.Decimal CotaInferior {
                get {
                    try {
                        return ((System.Decimal)(this[this.tabletsa_ComisionesCotasVariables.CotaInferiorColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsa_ComisionesCotasVariables.CotaInferiorColumn] = value;
                }
            }
            
            public System.Decimal CotaSuperior {
                get {
                    try {
                        return ((System.Decimal)(this[this.tabletsa_ComisionesCotasVariables.CotaSuperiorColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsa_ComisionesCotasVariables.CotaSuperiorColumn] = value;
                }
            }
            
            public System.Decimal ValorAAplicar {
                get {
                    try {
                        return ((System.Decimal)(this[this.tabletsa_ComisionesCotasVariables.ValorAAplicarColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsa_ComisionesCotasVariables.ValorAAplicarColumn] = value;
                }
            }
            
            public string FormaDeAplicacion {
                get {
                    try {
                        return ((string)(this[this.tabletsa_ComisionesCotasVariables.FormaDeAplicacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsa_ComisionesCotasVariables.FormaDeAplicacionColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    try {
                        return ((System.DateTime)(this[this.tabletsa_ComisionesCotasVariables.FechaCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsa_ComisionesCotasVariables.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    try {
                        return ((long)(this[this.tabletsa_ComisionesCotasVariables.IdConexionCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsa_ComisionesCotasVariables.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tabletsa_ComisionesCotasVariables.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsa_ComisionesCotasVariables.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tabletsa_ComisionesCotasVariables.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsa_ComisionesCotasVariables.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public long IdReservado {
                get {
                    try {
                        return ((long)(this[this.tabletsa_ComisionesCotasVariables.IdReservadoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsa_ComisionesCotasVariables.IdReservadoColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tabletsa_ComisionesCotasVariables.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsa_ComisionesCotasVariables.RowIdColumn] = value;
                }
            }
            
            public long IdSucursal {
                get {
                    try {
                        return ((long)(this[this.tabletsa_ComisionesCotasVariables.IdSucursalColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsa_ComisionesCotasVariables.IdSucursalColumn] = value;
                }
            }
            
            public long IdEmpresa {
                get {
                    try {
                        return ((long)(this[this.tabletsa_ComisionesCotasVariables.IdEmpresaColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsa_ComisionesCotasVariables.IdEmpresaColumn] = value;
                }
            }
            
            public bool IsCotaInferiorNull() {
                return this.IsNull(this.tabletsa_ComisionesCotasVariables.CotaInferiorColumn);
            }
            
            public void SetCotaInferiorNull() {
                this[this.tabletsa_ComisionesCotasVariables.CotaInferiorColumn] = System.Convert.DBNull;
            }
            
            public bool IsCotaSuperiorNull() {
                return this.IsNull(this.tabletsa_ComisionesCotasVariables.CotaSuperiorColumn);
            }
            
            public void SetCotaSuperiorNull() {
                this[this.tabletsa_ComisionesCotasVariables.CotaSuperiorColumn] = System.Convert.DBNull;
            }
            
            public bool IsValorAAplicarNull() {
                return this.IsNull(this.tabletsa_ComisionesCotasVariables.ValorAAplicarColumn);
            }
            
            public void SetValorAAplicarNull() {
                this[this.tabletsa_ComisionesCotasVariables.ValorAAplicarColumn] = System.Convert.DBNull;
            }
            
            public bool IsFormaDeAplicacionNull() {
                return this.IsNull(this.tabletsa_ComisionesCotasVariables.FormaDeAplicacionColumn);
            }
            
            public void SetFormaDeAplicacionNull() {
                this[this.tabletsa_ComisionesCotasVariables.FormaDeAplicacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsFechaCreacionNull() {
                return this.IsNull(this.tabletsa_ComisionesCotasVariables.FechaCreacionColumn);
            }
            
            public void SetFechaCreacionNull() {
                this[this.tabletsa_ComisionesCotasVariables.FechaCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionCreacionNull() {
                return this.IsNull(this.tabletsa_ComisionesCotasVariables.IdConexionCreacionColumn);
            }
            
            public void SetIdConexionCreacionNull() {
                this[this.tabletsa_ComisionesCotasVariables.IdConexionCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tabletsa_ComisionesCotasVariables.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tabletsa_ComisionesCotasVariables.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tabletsa_ComisionesCotasVariables.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tabletsa_ComisionesCotasVariables.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdReservadoNull() {
                return this.IsNull(this.tabletsa_ComisionesCotasVariables.IdReservadoColumn);
            }
            
            public void SetIdReservadoNull() {
                this[this.tabletsa_ComisionesCotasVariables.IdReservadoColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tabletsa_ComisionesCotasVariables.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tabletsa_ComisionesCotasVariables.RowIdColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdSucursalNull() {
                return this.IsNull(this.tabletsa_ComisionesCotasVariables.IdSucursalColumn);
            }
            
            public void SetIdSucursalNull() {
                this[this.tabletsa_ComisionesCotasVariables.IdSucursalColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdEmpresaNull() {
                return this.IsNull(this.tabletsa_ComisionesCotasVariables.IdEmpresaColumn);
            }
            
            public void SetIdEmpresaNull() {
                this[this.tabletsa_ComisionesCotasVariables.IdEmpresaColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsa_ComisionesCotasVariablesRowChangeEvent : EventArgs {
            
            private tsa_ComisionesCotasVariablesRow eventRow;
            
            private DataRowAction eventAction;
            
            public tsa_ComisionesCotasVariablesRowChangeEvent(tsa_ComisionesCotasVariablesRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public tsa_ComisionesCotasVariablesRow Row {
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
