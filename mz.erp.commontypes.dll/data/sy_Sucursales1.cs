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
    public class sy_SucursalesDataset : DataSet {
        
        private sy_SucursalesDataTable tablesy_Sucursales;
        
        public sy_SucursalesDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected sy_SucursalesDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["sy_Sucursales"] != null)) {
                    this.Tables.Add(new sy_SucursalesDataTable(ds.Tables["sy_Sucursales"]));
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
        public sy_SucursalesDataTable sy_Sucursales {
            get {
                return this.tablesy_Sucursales;
            }
        }
        
        public override DataSet Clone() {
            sy_SucursalesDataset cln = ((sy_SucursalesDataset)(base.Clone()));
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
            if ((ds.Tables["sy_Sucursales"] != null)) {
                this.Tables.Add(new sy_SucursalesDataTable(ds.Tables["sy_Sucursales"]));
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
            this.tablesy_Sucursales = ((sy_SucursalesDataTable)(this.Tables["sy_Sucursales"]));
            if ((this.tablesy_Sucursales != null)) {
                this.tablesy_Sucursales.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "sy_SucursalesDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/sy_Sucursales.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tablesy_Sucursales = new sy_SucursalesDataTable();
            this.Tables.Add(this.tablesy_Sucursales);
        }
        
        private bool ShouldSerializesy_Sucursales() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void sy_SucursalesRowChangeEventHandler(object sender, sy_SucursalesRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class sy_SucursalesDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdSucursal;
            
            private DataColumn columnIdEmpresa;
            
            private DataColumn columnDescripcion;
            
            private DataColumn columnIdResponsable;
            
            private DataColumn columnDireccion;
            
            private DataColumn columnIdLocalidad;
            
            private DataColumn columnCargoFijoProductos;
            
            private DataColumn columnBonificacionRecargoProductos;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnIdReservado;
            
            private DataColumn columnRowId;
            
            internal sy_SucursalesDataTable() : 
                    base("sy_Sucursales") {
                this.InitClass();
            }
            
            internal sy_SucursalesDataTable(DataTable table) : 
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
            
            internal DataColumn DescripcionColumn {
                get {
                    return this.columnDescripcion;
                }
            }
            
            internal DataColumn IdResponsableColumn {
                get {
                    return this.columnIdResponsable;
                }
            }
            
            internal DataColumn DireccionColumn {
                get {
                    return this.columnDireccion;
                }
            }
            
            internal DataColumn IdLocalidadColumn {
                get {
                    return this.columnIdLocalidad;
                }
            }
            
            internal DataColumn CargoFijoProductosColumn {
                get {
                    return this.columnCargoFijoProductos;
                }
            }
            
            internal DataColumn BonificacionRecargoProductosColumn {
                get {
                    return this.columnBonificacionRecargoProductos;
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
            
            public sy_SucursalesRow this[int index] {
                get {
                    return ((sy_SucursalesRow)(this.Rows[index]));
                }
            }
            
            public event sy_SucursalesRowChangeEventHandler sy_SucursalesRowChanged;
            
            public event sy_SucursalesRowChangeEventHandler sy_SucursalesRowChanging;
            
            public event sy_SucursalesRowChangeEventHandler sy_SucursalesRowDeleted;
            
            public event sy_SucursalesRowChangeEventHandler sy_SucursalesRowDeleting;
            
            public void Addsy_SucursalesRow(sy_SucursalesRow row) {
                this.Rows.Add(row);
            }
            
            public sy_SucursalesRow Addsy_SucursalesRow(long IdSucursal, long IdEmpresa, string Descripcion, string IdResponsable, string Direccion, long IdLocalidad, System.Decimal CargoFijoProductos, System.Decimal BonificacionRecargoProductos, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, System.Guid RowId) {
                sy_SucursalesRow rowsy_SucursalesRow = ((sy_SucursalesRow)(this.NewRow()));
                rowsy_SucursalesRow.ItemArray = new object[] {
                        IdSucursal,
                        IdEmpresa,
                        Descripcion,
                        IdResponsable,
                        Direccion,
                        IdLocalidad,
                        CargoFijoProductos,
                        BonificacionRecargoProductos,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        IdReservado,
                        RowId};
                this.Rows.Add(rowsy_SucursalesRow);
                return rowsy_SucursalesRow;
            }
            
            public sy_SucursalesRow FindByIdSucursalIdEmpresa(long IdSucursal, long IdEmpresa) {
                return ((sy_SucursalesRow)(this.Rows.Find(new object[] {
                            IdSucursal,
                            IdEmpresa})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                sy_SucursalesDataTable cln = ((sy_SucursalesDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new sy_SucursalesDataTable();
            }
            
            internal void InitVars() {
                this.columnIdSucursal = this.Columns["IdSucursal"];
                this.columnIdEmpresa = this.Columns["IdEmpresa"];
                this.columnDescripcion = this.Columns["Descripcion"];
                this.columnIdResponsable = this.Columns["IdResponsable"];
                this.columnDireccion = this.Columns["Direccion"];
                this.columnIdLocalidad = this.Columns["IdLocalidad"];
                this.columnCargoFijoProductos = this.Columns["CargoFijoProductos"];
                this.columnBonificacionRecargoProductos = this.Columns["BonificacionRecargoProductos"];
                this.columnFechaCreacion = this.Columns["FechaCreacion"];
                this.columnIdConexionCreacion = this.Columns["IdConexionCreacion"];
                this.columnUltimaModificacion = this.Columns["UltimaModificacion"];
                this.columnIdConexionUltimaModificacion = this.Columns["IdConexionUltimaModificacion"];
                this.columnIdReservado = this.Columns["IdReservado"];
                this.columnRowId = this.Columns["RowId"];
            }
            
            private void InitClass() {
                this.columnIdSucursal = new DataColumn("IdSucursal", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdSucursal);
                this.columnIdEmpresa = new DataColumn("IdEmpresa", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdEmpresa);
                this.columnDescripcion = new DataColumn("Descripcion", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnDescripcion);
                this.columnIdResponsable = new DataColumn("IdResponsable", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdResponsable);
                this.columnDireccion = new DataColumn("Direccion", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnDireccion);
                this.columnIdLocalidad = new DataColumn("IdLocalidad", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdLocalidad);
                this.columnCargoFijoProductos = new DataColumn("CargoFijoProductos", typeof(System.Decimal), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCargoFijoProductos);
                this.columnBonificacionRecargoProductos = new DataColumn("BonificacionRecargoProductos", typeof(System.Decimal), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnBonificacionRecargoProductos);
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
                this.Constraints.Add(new UniqueConstraint("sy_SucursalesDatasetKey1", new DataColumn[] {
                                this.columnIdSucursal,
                                this.columnIdEmpresa}, true));
                this.columnIdSucursal.AllowDBNull = false;
                this.columnIdEmpresa.AllowDBNull = false;
                this.columnCargoFijoProductos.DefaultValue = 0m;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public sy_SucursalesRow Newsy_SucursalesRow() {
                return ((sy_SucursalesRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new sy_SucursalesRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(sy_SucursalesRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.sy_SucursalesRowChanged != null)) {
                    this.sy_SucursalesRowChanged(this, new sy_SucursalesRowChangeEvent(((sy_SucursalesRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.sy_SucursalesRowChanging != null)) {
                    this.sy_SucursalesRowChanging(this, new sy_SucursalesRowChangeEvent(((sy_SucursalesRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.sy_SucursalesRowDeleted != null)) {
                    this.sy_SucursalesRowDeleted(this, new sy_SucursalesRowChangeEvent(((sy_SucursalesRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.sy_SucursalesRowDeleting != null)) {
                    this.sy_SucursalesRowDeleting(this, new sy_SucursalesRowChangeEvent(((sy_SucursalesRow)(e.Row)), e.Action));
                }
            }
            
            public void Removesy_SucursalesRow(sy_SucursalesRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class sy_SucursalesRow : DataRow {
            
            private sy_SucursalesDataTable tablesy_Sucursales;
            
            internal sy_SucursalesRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tablesy_Sucursales = ((sy_SucursalesDataTable)(this.Table));
            }
            
            public long IdSucursal {
                get {
                    return ((long)(this[this.tablesy_Sucursales.IdSucursalColumn]));
                }
                set {
                    this[this.tablesy_Sucursales.IdSucursalColumn] = value;
                }
            }
            
            public long IdEmpresa {
                get {
                    return ((long)(this[this.tablesy_Sucursales.IdEmpresaColumn]));
                }
                set {
                    this[this.tablesy_Sucursales.IdEmpresaColumn] = value;
                }
            }
            
            public string Descripcion {
                get {
                    try {
                        return ((string)(this[this.tablesy_Sucursales.DescripcionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_Sucursales.DescripcionColumn] = value;
                }
            }
            
            public string IdResponsable {
                get {
                    try {
                        return ((string)(this[this.tablesy_Sucursales.IdResponsableColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_Sucursales.IdResponsableColumn] = value;
                }
            }
            
            public string Direccion {
                get {
                    try {
                        return ((string)(this[this.tablesy_Sucursales.DireccionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_Sucursales.DireccionColumn] = value;
                }
            }
            
            public long IdLocalidad {
                get {
                    try {
                        return ((long)(this[this.tablesy_Sucursales.IdLocalidadColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_Sucursales.IdLocalidadColumn] = value;
                }
            }
            
            public System.Decimal CargoFijoProductos {
                get {
                    try {
                        return ((System.Decimal)(this[this.tablesy_Sucursales.CargoFijoProductosColumn]));
                    }
                    catch (InvalidCastException e) {
                        return 0;
                    }
                }
                set {
                    this[this.tablesy_Sucursales.CargoFijoProductosColumn] = value;
                }
            }
            
            public System.Decimal BonificacionRecargoProductos {
                get {
                    try {
                        return ((System.Decimal)(this[this.tablesy_Sucursales.BonificacionRecargoProductosColumn]));
                    }
                    catch (InvalidCastException e) {
                       return 0;
                    }
                }
                set {
                    this[this.tablesy_Sucursales.BonificacionRecargoProductosColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    try {
                        return ((System.DateTime)(this[this.tablesy_Sucursales.FechaCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_Sucursales.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    try {
                        return ((long)(this[this.tablesy_Sucursales.IdConexionCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_Sucursales.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tablesy_Sucursales.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_Sucursales.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tablesy_Sucursales.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_Sucursales.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public long IdReservado {
                get {
                    try {
                        return ((long)(this[this.tablesy_Sucursales.IdReservadoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_Sucursales.IdReservadoColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tablesy_Sucursales.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_Sucursales.RowIdColumn] = value;
                }
            }
            
            public bool IsDescripcionNull() {
                return this.IsNull(this.tablesy_Sucursales.DescripcionColumn);
            }
            
            public void SetDescripcionNull() {
                this[this.tablesy_Sucursales.DescripcionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdResponsableNull() {
                return this.IsNull(this.tablesy_Sucursales.IdResponsableColumn);
            }
            
            public void SetIdResponsableNull() {
                this[this.tablesy_Sucursales.IdResponsableColumn] = System.Convert.DBNull;
            }
            
            public bool IsDireccionNull() {
                return this.IsNull(this.tablesy_Sucursales.DireccionColumn);
            }
            
            public void SetDireccionNull() {
                this[this.tablesy_Sucursales.DireccionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdLocalidadNull() {
                return this.IsNull(this.tablesy_Sucursales.IdLocalidadColumn);
            }
            
            public void SetIdLocalidadNull() {
                this[this.tablesy_Sucursales.IdLocalidadColumn] = System.Convert.DBNull;
            }
            
            public bool IsCargoFijoProductosNull() {
                return this.IsNull(this.tablesy_Sucursales.CargoFijoProductosColumn);
            }
            
            public void SetCargoFijoProductosNull() {
                this[this.tablesy_Sucursales.CargoFijoProductosColumn] = System.Convert.DBNull;
            }
            
            public bool IsBonificacionRecargoProductosNull() {
                return this.IsNull(this.tablesy_Sucursales.BonificacionRecargoProductosColumn);
            }
            
            public void SetBonificacionRecargoProductosNull() {
                this[this.tablesy_Sucursales.BonificacionRecargoProductosColumn] = System.Convert.DBNull;
            }
            
            public bool IsFechaCreacionNull() {
                return this.IsNull(this.tablesy_Sucursales.FechaCreacionColumn);
            }
            
            public void SetFechaCreacionNull() {
                this[this.tablesy_Sucursales.FechaCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionCreacionNull() {
                return this.IsNull(this.tablesy_Sucursales.IdConexionCreacionColumn);
            }
            
            public void SetIdConexionCreacionNull() {
                this[this.tablesy_Sucursales.IdConexionCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tablesy_Sucursales.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tablesy_Sucursales.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tablesy_Sucursales.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tablesy_Sucursales.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdReservadoNull() {
                return this.IsNull(this.tablesy_Sucursales.IdReservadoColumn);
            }
            
            public void SetIdReservadoNull() {
                this[this.tablesy_Sucursales.IdReservadoColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tablesy_Sucursales.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tablesy_Sucursales.RowIdColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class sy_SucursalesRowChangeEvent : EventArgs {
            
            private sy_SucursalesRow eventRow;
            
            private DataRowAction eventAction;
            
            public sy_SucursalesRowChangeEvent(sy_SucursalesRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public sy_SucursalesRow Row {
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