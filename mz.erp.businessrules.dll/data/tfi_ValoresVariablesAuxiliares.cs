namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tfi_ValoresVariablesAuxiliares : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tfi_ValoresVariablesAuxiliares()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tfi_ValoresVariablesAuxiliares
		/// </summary>
		public static tfi_ValoresVariablesAuxiliaresDataset GetList()
		{
			return mz.erp.dataaccess.tfi_ValoresVariablesAuxiliares.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tfi_ValoresVariablesAuxiliares filtrada por las condiciones de bsqueda
		/// </summary>
		public static tfi_ValoresVariablesAuxiliaresDataset GetList( string IdValorVariable, string IdVariableAuxiliarTDCompTesoreria, string Valor )
		{
			return mz.erp.dataaccess.tfi_ValoresVariablesAuxiliares.GetList( IdValorVariable, IdVariableAuxiliarTDCompTesoreria, Valor );
		}

		/// <summary>
		/// Crea un tfi_ValoresVariablesAuxiliaresRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tfi_ValoresVariablesAuxiliaresDataset.tfi_ValoresVariablesAuxiliaresRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tfi_ValoresVariablesAuxiliares.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tfi_ValoresVariablesAuxiliares que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tfi_ValoresVariablesAuxiliaresDataset.tfi_ValoresVariablesAuxiliaresRow GetByPk( string IdValorVariable, string IdVariableAuxiliarTDCompTesoreria )
		{
			tfi_ValoresVariablesAuxiliaresDataset.tfi_ValoresVariablesAuxiliaresRow row = mz.erp.dataaccess.tfi_ValoresVariablesAuxiliares.GetByPk( IdValorVariable, IdVariableAuxiliarTDCompTesoreria  );
			foreach ( DataColumn dc in row.Table.Columns ) 
			{
				if (row[dc] == System.DBNull.Value)
				{
					row[dc] = Util.DefaultValue( dc.DataType );
				}
			}
			return row;

		}

		/// <summary>
		/// Obtiene un registro de la tabla tfi_ValoresVariablesAuxiliares que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tfi_ValoresVariablesAuxiliaresDataset.tfi_ValoresVariablesAuxiliaresRow GetByPk( object IdValorVariable, object IdVariableAuxiliarTDCompTesoreria )
		{
			return GetByPk( ( string )IdValorVariable, ( string )IdVariableAuxiliarTDCompTesoreria );
		}

		/// <summary>
		/// Establece los valores por defecto de tfi_ValoresVariablesAuxiliaresRow.
		/// </summary>
		public static tfi_ValoresVariablesAuxiliaresDataset.tfi_ValoresVariablesAuxiliaresRow SetRowDefaultValues( tfi_ValoresVariablesAuxiliaresDataset.tfi_ValoresVariablesAuxiliaresRow row )
		{
			row.IdValorVariable = Util.NewStringId(); 
			row.IdVariableAuxiliarTDCompTesoreria = Util.NewStringId(); 
			row.Valor = string.Empty;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdEmpresa = Security.IdEmpresa;
			row.IdSucursal = Security.IdSucursal;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tfi_ValoresVariablesAuxiliaresRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tfi_ValoresVariablesAuxiliaresDataset.tfi_ValoresVariablesAuxiliaresRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tfi_ValoresVariablesAuxiliaresRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tfi_ValoresVariablesAuxiliaresDataset.tfi_ValoresVariablesAuxiliaresRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tfi_ValoresVariablesAuxiliaresRow a la base de datos.
		/// </summary>
		public static void Update( tfi_ValoresVariablesAuxiliaresDataset.tfi_ValoresVariablesAuxiliaresRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_ValoresVariablesAuxiliares.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tfi_ValoresVariablesAuxiliaresDataset a la base de datos.
		/// </summary>
		public static void Update( tfi_ValoresVariablesAuxiliaresDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tfi_ValoresVariablesAuxiliares.Rows.Count > 0, "La tabla dataSet.tfi_ValoresVariablesAuxiliaresDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_ValoresVariablesAuxiliares.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tfi_ValoresVariablesAuxiliaresDataset.tfi_ValoresVariablesAuxiliaresDataTable a la base de datos.
		/// </summary>
		public static void Update( tfi_ValoresVariablesAuxiliaresDataset.tfi_ValoresVariablesAuxiliaresDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_ValoresVariablesAuxiliares.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tfi_ValoresVariablesAuxiliaresRow.
		/// </summary>
		public static bool RowIsValid( tfi_ValoresVariablesAuxiliaresDataset.tfi_ValoresVariablesAuxiliaresRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdValorVariableIsValid( row.IdValorVariable, out mensaje) )
			{ 
				row.SetColumnError( "IdValorVariable" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdVariableAuxiliarTDCompTesoreriaIsValid( row.IdVariableAuxiliarTDCompTesoreria, out mensaje) )
			{ 
				row.SetColumnError( "IdVariableAuxiliarTDCompTesoreria" , mensaje);
				isValid=false;
			
			}
						
			if ( !ValorIsValid( row.Valor, out mensaje) )
			{ 
				row.SetColumnError( "Valor" , mensaje);
				isValid=false;
			
			}
						
			if ( !FechaCreacionIsValid( row.FechaCreacion, out mensaje) )
			{ 
				row.SetColumnError( "FechaCreacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdConexionCreacionIsValid( row.IdConexionCreacion, out mensaje) )
			{ 
				row.SetColumnError( "IdConexionCreacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !UltimaModificacionIsValid( row.UltimaModificacion, out mensaje) )
			{ 
				row.SetColumnError( "UltimaModificacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdConexionUltimaModificacionIsValid( row.IdConexionUltimaModificacion, out mensaje) )
			{ 
				row.SetColumnError( "IdConexionUltimaModificacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdReservadoIsValid( row.IdReservado, out mensaje) )
			{ 
				row.SetColumnError( "IdReservado" , mensaje);
				isValid=false;
			
			}
						
			if ( !RowIdIsValid( row.RowId, out mensaje) )
			{ 
				row.SetColumnError( "RowId" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdEmpresaIsValid( row.IdEmpresa, out mensaje) )
			{ 
				row.SetColumnError( "IdEmpresa" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdSucursalIsValid( row.IdSucursal, out mensaje) )
			{ 
				row.SetColumnError( "IdSucursal" , mensaje);
				isValid=false;
			
			}
			;
			
			return isValid;
		}
		
		/// <summary>
		/// Valida el campo IdValorVariable.
		/// </summary>
		public static bool IdValorVariableIsValid( string IdValorVariable , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdValorVariable. Metodo Sobrecargado
		/// </summary>
		public static bool IdValorVariableIsValid( string IdValorVariable)
		{
			string mensaje;
			return IdValorVariableIsValid( IdValorVariable, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdVariableAuxiliarTDCompTesoreria.
		/// </summary>
		public static bool IdVariableAuxiliarTDCompTesoreriaIsValid( string IdVariableAuxiliarTDCompTesoreria , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdVariableAuxiliarTDCompTesoreria. Metodo Sobrecargado
		/// </summary>
		public static bool IdVariableAuxiliarTDCompTesoreriaIsValid( string IdVariableAuxiliarTDCompTesoreria)
		{
			string mensaje;
			return IdVariableAuxiliarTDCompTesoreriaIsValid( IdVariableAuxiliarTDCompTesoreria, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Valor.
		/// </summary>
		public static bool ValorIsValid( string Valor , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Valor. Metodo Sobrecargado
		/// </summary>
		public static bool ValorIsValid( string Valor)
		{
			string mensaje;
			return ValorIsValid( Valor, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo FechaCreacion.
		/// </summary>
		public static bool FechaCreacionIsValid( DateTime FechaCreacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo FechaCreacion. Metodo Sobrecargado
		/// </summary>
		public static bool FechaCreacionIsValid( DateTime FechaCreacion)
		{
			string mensaje;
			return FechaCreacionIsValid( FechaCreacion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdConexionCreacion.
		/// </summary>
		public static bool IdConexionCreacionIsValid( long IdConexionCreacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdConexionCreacion. Metodo Sobrecargado
		/// </summary>
		public static bool IdConexionCreacionIsValid( long IdConexionCreacion)
		{
			string mensaje;
			return IdConexionCreacionIsValid( IdConexionCreacion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo UltimaModificacion.
		/// </summary>
		public static bool UltimaModificacionIsValid( byte[] UltimaModificacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo UltimaModificacion. Metodo Sobrecargado
		/// </summary>
		public static bool UltimaModificacionIsValid( byte[] UltimaModificacion)
		{
			string mensaje;
			return UltimaModificacionIsValid( UltimaModificacion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdConexionUltimaModificacion.
		/// </summary>
		public static bool IdConexionUltimaModificacionIsValid( long IdConexionUltimaModificacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdConexionUltimaModificacion. Metodo Sobrecargado
		/// </summary>
		public static bool IdConexionUltimaModificacionIsValid( long IdConexionUltimaModificacion)
		{
			string mensaje;
			return IdConexionUltimaModificacionIsValid( IdConexionUltimaModificacion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdReservado.
		/// </summary>
		public static bool IdReservadoIsValid( long IdReservado , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdReservado. Metodo Sobrecargado
		/// </summary>
		public static bool IdReservadoIsValid( long IdReservado)
		{
			string mensaje;
			return IdReservadoIsValid( IdReservado, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo RowId.
		/// </summary>
		public static bool RowIdIsValid( Guid RowId , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo RowId. Metodo Sobrecargado
		/// </summary>
		public static bool RowIdIsValid( Guid RowId)
		{
			string mensaje;
			return RowIdIsValid( RowId, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdEmpresa.
		/// </summary>
		public static bool IdEmpresaIsValid( long IdEmpresa , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdEmpresa. Metodo Sobrecargado
		/// </summary>
		public static bool IdEmpresaIsValid( long IdEmpresa)
		{
			string mensaje;
			return IdEmpresaIsValid( IdEmpresa, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdSucursal.
		/// </summary>
		public static bool IdSucursalIsValid( long IdSucursal , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdSucursal. Metodo Sobrecargado
		/// </summary>
		public static bool IdSucursalIsValid( long IdSucursal)
		{
			string mensaje;
			return IdSucursalIsValid( IdSucursal, out mensaje );
		}		
		

		public void Dispose()
		{
		}
		
	}
}


