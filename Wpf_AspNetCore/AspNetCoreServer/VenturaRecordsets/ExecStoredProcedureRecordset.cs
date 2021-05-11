/*
	Project file: "C:\Active\VenturaSQL\BuildSystem\Templates\Wpf_AspNetCore\Template.venproj"
	Target platform: NETStandard
	Generator version: 4.0.126
	Generated on: Tuesday, 11 May 2021 at 12:04:37
	At the bottom of this file you find a template for extending Recordsets with calculated columns for XAML data binding.
*/
using VenturaSQL;
using System;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel;

namespace AspNetCoreServer.VenturaRecordsets
{
	/// <summary>
	/// The resultset is read-only.
	/// </summary>
	public partial class ExecStoredProcedureRecordset : ResultsetObservable<ExecStoredProcedureRecordset, ExecStoredProcedureRecord>, IRecordsetBase
	{
		private IResultsetBase[] _resultsets;
		private string _sqlscript;
		private object[] _inputparametervalues;
		private InputParamHolder _inputparamholder;
		private VenturaSqlSchema _parameterschema;
		private int _rowlimit = 500;
		private const string CRLF = "\r\n";

		public ExecStoredProcedureRecordset()
		{
			_resultsets = new IResultsetBase[] { this };

			_sqlscript = @"EXEC  [dbo].[uspGetBillOfMaterials] @ParamStartProductID, @ParamCheckDate";

			_inputparametervalues = new object[2];
			_inputparamholder = new InputParamHolder(_inputparametervalues);

			ColumnArrayBuilder param_array = new ColumnArrayBuilder();

			param_array.AddParameterColumn("@ParamStartProductID", typeof(int), true, false, DbType.Int32, null, null, null);
			param_array.AddParameterColumn("@ParamCheckDate", typeof(DateTime), true, false, DbType.Date, null, null, null);

			_parameterschema = new VenturaSqlSchema(param_array);

			ColumnArrayBuilder schema_array = new ColumnArrayBuilder();

			schema_array.Add(new VenturaSqlColumn("ProductAssemblyID", typeof(int), true)
			{
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				IsExpression = true,
				BaseColumnName = "ProductAssemblyID"
			});

			schema_array.Add(new VenturaSqlColumn("ComponentID", typeof(int), true)
			{
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				IsExpression = true,
				BaseColumnName = "ComponentID"
			});

			schema_array.Add(new VenturaSqlColumn("ComponentDesc", typeof(string), true)
			{
				ColumnSize = 50,
				ProviderType = 12,
				IsExpression = true,
				BaseColumnName = "ComponentDesc"
			});

			schema_array.Add(new VenturaSqlColumn("TotalQuantity", typeof(decimal), true)
			{
				ColumnSize = 17,
				NumericPrecision = 38,
				NumericScale = 2,
				ProviderType = 5,
				IsExpression = true,
				BaseColumnName = "TotalQuantity"
			});

			schema_array.Add(new VenturaSqlColumn("StandardCost", typeof(decimal), true)
			{
				ColumnSize = 8,
				NumericPrecision = 19,
				ProviderType = 9,
				IsExpression = true,
				BaseColumnName = "StandardCost"
			});

			schema_array.Add(new VenturaSqlColumn("ListPrice", typeof(decimal), true)
			{
				ColumnSize = 8,
				NumericPrecision = 19,
				ProviderType = 9,
				IsExpression = true,
				BaseColumnName = "ListPrice"
			});

			schema_array.Add(new VenturaSqlColumn("BOMLevel", typeof(short), true)
			{
				ColumnSize = 2,
				NumericPrecision = 5,
				ProviderType = 16,
				IsExpression = true,
				BaseColumnName = "BOMLevel"
			});

			schema_array.Add(new VenturaSqlColumn("RecursionLevel", typeof(int), true)
			{
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				IsExpression = true,
				BaseColumnName = "RecursionLevel"
			});

			((IResultsetBase)this).Schema = new VenturaSqlSchema(schema_array);
		}

		/// <summary>
		/// Database Column NotUpdateable. NotReadonly. AllowNull. Expression.
		/// </summary>
		public int? ProductAssemblyID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ProductAssemblyID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ProductAssemblyID = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. NotReadonly. AllowNull. Expression.
		/// </summary>
		public int? ComponentID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ComponentID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ComponentID = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. NotReadonly. AllowNull. Expression.
		/// </summary>
		public string ComponentDesc
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ComponentDesc; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ComponentDesc = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. NotReadonly. AllowNull. Expression.
		/// </summary>
		public decimal? TotalQuantity
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.TotalQuantity; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.TotalQuantity = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. NotReadonly. AllowNull. Expression.
		/// </summary>
		public decimal? StandardCost
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.StandardCost; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.StandardCost = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. NotReadonly. AllowNull. Expression.
		/// </summary>
		public decimal? ListPrice
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ListPrice; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ListPrice = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. NotReadonly. AllowNull. Expression.
		/// </summary>
		public short? BOMLevel
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.BOMLevel; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.BOMLevel = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. NotReadonly. AllowNull. Expression.
		/// </summary>
		public int? RecursionLevel
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.RecursionLevel; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.RecursionLevel = value; }
		}

		public void ResetToUnmodified()
		{
			if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET);
			CurrentRecord.ResetToUnmodified();
		}

		public void ResetToUnmodifiedExisting()
		{
			if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET);
			CurrentRecord.ResetToUnmodifiedExisting();
		}

		public void ResetToExisting()
		{
			if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET);
			CurrentRecord.ResetToExisting();
		}

		public void Append()
		{
			int index = this.RecordCount;
			this.InsertItem(index, new ExecStoredProcedureRecord());
			this.CurrentRecordIndex = index;
		}

		public void Append(ExecStoredProcedureRecord record)
		{
			int index = this.RecordCount;
			this.InsertItem(index, record);
			this.CurrentRecordIndex = index;
		}

		public ExecStoredProcedureRecord NewRecord()
		{
			return new ExecStoredProcedureRecord();
		}

		protected override ExecStoredProcedureRecord InternalCreateExistingRecordObject(object[] columnvalues) => new ExecStoredProcedureRecord(columnvalues);

		byte[] IRecordsetBase.Hash
		{
			get { return new byte[] { 21, 227, 170, 28, 17, 162, 18, 177, 47, 81, 150, 95, 185, 95, 77, 35 }; }
		}

		string IRecordsetBase.HashString
		{
			get { return "15E3AA1C11A212B12F51965FB95F4D23"; }
		}

		VenturaSqlPlatform IRecordsetBase.GeneratorTarget
		{
			get { return VenturaSqlPlatform.NETStandard; }
		}

		Version IRecordsetBase.GeneratorVersion
		{
			get { return new Version(4,0,126); }
		}

		DateTime IRecordsetBase.GeneratorTimestamp
		{
			get { return new DateTime(2021, 5, 11, 12, 4, 37); } // Tuesday, 11 May 2021 at 12:04:37
		}

		string IRecordsetBase.GeneratorProviderInvariantName
		{
			get { return "System.Data.SqlClient"; }
		}

		IResultsetBase[] IRecordsetBase.Resultsets
		{
			get { return _resultsets; }
		}

		string IRecordsetBase.SqlScript
		{
			get { return _sqlscript; }
		}

		VenturaSqlSchema IRecordsetBase.ParameterSchema
		{
			get { return _parameterschema; }
		}

		/// <summary>
		/// For internal use by VenturaSQL only. Use SetExecSqlParams() instead.
		/// </summary>
		object[] IRecordsetBase.InputParameterValues
		{
			get { return _inputparametervalues; }
		}

		/// <summary>
		/// For internal use by VenturaSQL only. Use Output property instead.
		/// </summary>
		object[] IRecordsetBase.OutputParameterValues
		{
			get { return null; }
		}

		public InputParamHolder InputParam
		{
			get { return _inputparamholder; }
		}

		public int RowLimit
		{
			get { return _rowlimit; }
			set { _rowlimit = value; }
		}

		public void SetExecSqlParams(int? ParamStartProductID, DateTime? ParamCheckDate)
		{
			_inputparametervalues[0] = ParamStartProductID;
			_inputparametervalues[1] = ParamCheckDate;
		}

		public void ExecSql(int? ParamStartProductID, DateTime? ParamCheckDate)
		{
			_inputparametervalues[0] = ParamStartProductID;
			_inputparametervalues[1] = ParamCheckDate;
			Transactional.ExecSql(VenturaSqlConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public void ExecSql(Connector connector, int? ParamStartProductID, DateTime? ParamCheckDate)
		{
			_inputparametervalues[0] = ParamStartProductID;
			_inputparametervalues[1] = ParamCheckDate;
			Transactional.ExecSql(connector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync(int? ParamStartProductID, DateTime? ParamCheckDate)
		{
			_inputparametervalues[0] = ParamStartProductID;
			_inputparametervalues[1] = ParamCheckDate;
			await Transactional.ExecSqlAsync(VenturaSqlConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync(Connector connector, int? ParamStartProductID, DateTime? ParamCheckDate)
		{
			_inputparametervalues[0] = ParamStartProductID;
			_inputparametervalues[1] = ParamCheckDate;
			await Transactional.ExecSqlAsync(connector, new IRecordsetBase[] { this });
		}

		public class InputParamHolder
		{
			private object[] _values;

			public InputParamHolder(object[] values)
			{
				_values = values;
			}

			public int? ParamStartProductID
			{
				get { return (int?)_values[0]; }
				set { _values[0] = value; }
			}

			public DateTime? ParamCheckDate
			{
				get { return (DateTime?)_values[1]; }
				set { _values[1] = value; }
			}

		}

	}

	public sealed partial class ExecStoredProcedureRecord : IRecordBase, INotifyPropertyChanged
	{
		private DataRecordStatus _recordstatus;
		private bool _started_with_dbvalues;

		private int? _cur__ProductAssemblyID; private int? _ori__ProductAssemblyID; private bool _mod__ProductAssemblyID;
		private int? _cur__ComponentID; private int? _ori__ComponentID; private bool _mod__ComponentID;
		private string _cur__ComponentDesc; private string _ori__ComponentDesc; private bool _mod__ComponentDesc;
		private decimal? _cur__TotalQuantity; private decimal? _ori__TotalQuantity; private bool _mod__TotalQuantity;
		private decimal? _cur__StandardCost; private decimal? _ori__StandardCost; private bool _mod__StandardCost;
		private decimal? _cur__ListPrice; private decimal? _ori__ListPrice; private bool _mod__ListPrice;
		private short? _cur__BOMLevel; private short? _ori__BOMLevel; private bool _mod__BOMLevel;
		private int? _cur__RecursionLevel; private int? _ori__RecursionLevel; private bool _mod__RecursionLevel;


		public ExecStoredProcedureRecord()
		{
			_cur__ProductAssemblyID = null;
			_cur__ComponentID = null;
			_cur__ComponentDesc = null;
			_cur__TotalQuantity = null;
			_cur__StandardCost = null;
			_cur__ListPrice = null;
			_cur__BOMLevel = null;
			_cur__RecursionLevel = null;
			_started_with_dbvalues = false;
			_recordstatus = DataRecordStatus.New;
		}

		public ExecStoredProcedureRecord(object[] columnvalues)
		{
			_cur__ProductAssemblyID = (int?)columnvalues[0];
			_cur__ComponentID = (int?)columnvalues[1];
			_cur__ComponentDesc = (string)columnvalues[2];
			_cur__TotalQuantity = (decimal?)columnvalues[3];
			_cur__StandardCost = (decimal?)columnvalues[4];
			_cur__ListPrice = (decimal?)columnvalues[5];
			_cur__BOMLevel = (short?)columnvalues[6];
			_cur__RecursionLevel = (int?)columnvalues[7];
			_started_with_dbvalues = true;
			_recordstatus = DataRecordStatus.Existing;
		}

		/// <summary>
		/// Database Column NotUpdateable. NotReadonly. AllowNull. Expression.
		/// </summary>
		public int? ProductAssemblyID
		{
			get { return _cur__ProductAssemblyID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ProductAssemblyID = true;
				if (_cur__ProductAssemblyID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ProductAssemblyID == false) { _ori__ProductAssemblyID = _cur__ProductAssemblyID; _mod__ProductAssemblyID = true; } // existing record and column is not modified
					else { if (value == _ori__ProductAssemblyID) { _ori__ProductAssemblyID = default(int?); _mod__ProductAssemblyID = false; } } // existing record and column is modified
				}
				_cur__ProductAssemblyID = value; OnPropertyChanged("ProductAssemblyID"); OnAfterPropertyChanged("ProductAssemblyID");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. NotReadonly. AllowNull. Expression.
		/// </summary>
		public int? ComponentID
		{
			get { return _cur__ComponentID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ComponentID = true;
				if (_cur__ComponentID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ComponentID == false) { _ori__ComponentID = _cur__ComponentID; _mod__ComponentID = true; } // existing record and column is not modified
					else { if (value == _ori__ComponentID) { _ori__ComponentID = default(int?); _mod__ComponentID = false; } } // existing record and column is modified
				}
				_cur__ComponentID = value; OnPropertyChanged("ComponentID"); OnAfterPropertyChanged("ComponentID");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. NotReadonly. AllowNull. Expression.
		/// </summary>
		public string ComponentDesc
		{
			get { return _cur__ComponentDesc; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ComponentDesc = true;
				if (_cur__ComponentDesc == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ComponentDesc == false) { _ori__ComponentDesc = _cur__ComponentDesc; _mod__ComponentDesc = true; } // existing record and column is not modified
					else { if (value == _ori__ComponentDesc) { _ori__ComponentDesc = default(string); _mod__ComponentDesc = false; } } // existing record and column is modified
				}
				_cur__ComponentDesc = value; OnPropertyChanged("ComponentDesc"); OnAfterPropertyChanged("ComponentDesc");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. NotReadonly. AllowNull. Expression.
		/// </summary>
		public decimal? TotalQuantity
		{
			get { return _cur__TotalQuantity; }
			set
			{
				if (_started_with_dbvalues == false) _mod__TotalQuantity = true;
				if (_cur__TotalQuantity == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__TotalQuantity == false) { _ori__TotalQuantity = _cur__TotalQuantity; _mod__TotalQuantity = true; } // existing record and column is not modified
					else { if (value == _ori__TotalQuantity) { _ori__TotalQuantity = default(decimal?); _mod__TotalQuantity = false; } } // existing record and column is modified
				}
				_cur__TotalQuantity = value; OnPropertyChanged("TotalQuantity"); OnAfterPropertyChanged("TotalQuantity");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. NotReadonly. AllowNull. Expression.
		/// </summary>
		public decimal? StandardCost
		{
			get { return _cur__StandardCost; }
			set
			{
				if (_started_with_dbvalues == false) _mod__StandardCost = true;
				if (_cur__StandardCost == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__StandardCost == false) { _ori__StandardCost = _cur__StandardCost; _mod__StandardCost = true; } // existing record and column is not modified
					else { if (value == _ori__StandardCost) { _ori__StandardCost = default(decimal?); _mod__StandardCost = false; } } // existing record and column is modified
				}
				_cur__StandardCost = value; OnPropertyChanged("StandardCost"); OnAfterPropertyChanged("StandardCost");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. NotReadonly. AllowNull. Expression.
		/// </summary>
		public decimal? ListPrice
		{
			get { return _cur__ListPrice; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ListPrice = true;
				if (_cur__ListPrice == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ListPrice == false) { _ori__ListPrice = _cur__ListPrice; _mod__ListPrice = true; } // existing record and column is not modified
					else { if (value == _ori__ListPrice) { _ori__ListPrice = default(decimal?); _mod__ListPrice = false; } } // existing record and column is modified
				}
				_cur__ListPrice = value; OnPropertyChanged("ListPrice"); OnAfterPropertyChanged("ListPrice");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. NotReadonly. AllowNull. Expression.
		/// </summary>
		public short? BOMLevel
		{
			get { return _cur__BOMLevel; }
			set
			{
				if (_started_with_dbvalues == false) _mod__BOMLevel = true;
				if (_cur__BOMLevel == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__BOMLevel == false) { _ori__BOMLevel = _cur__BOMLevel; _mod__BOMLevel = true; } // existing record and column is not modified
					else { if (value == _ori__BOMLevel) { _ori__BOMLevel = default(short?); _mod__BOMLevel = false; } } // existing record and column is modified
				}
				_cur__BOMLevel = value; OnPropertyChanged("BOMLevel"); OnAfterPropertyChanged("BOMLevel");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. NotReadonly. AllowNull. Expression.
		/// </summary>
		public int? RecursionLevel
		{
			get { return _cur__RecursionLevel; }
			set
			{
				if (_started_with_dbvalues == false) _mod__RecursionLevel = true;
				if (_cur__RecursionLevel == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__RecursionLevel == false) { _ori__RecursionLevel = _cur__RecursionLevel; _mod__RecursionLevel = true; } // existing record and column is not modified
					else { if (value == _ori__RecursionLevel) { _ori__RecursionLevel = default(int?); _mod__RecursionLevel = false; } } // existing record and column is modified
				}
				_cur__RecursionLevel = value; OnPropertyChanged("RecursionLevel"); OnAfterPropertyChanged("RecursionLevel");
			}
		}

		public bool IsModified(string column_name)
		{
			if (column_name == "ProductAssemblyID") return _mod__ProductAssemblyID;
			if (column_name == "ComponentID") return _mod__ComponentID;
			if (column_name == "ComponentDesc") return _mod__ComponentDesc;
			if (column_name == "TotalQuantity") return _mod__TotalQuantity;
			if (column_name == "StandardCost") return _mod__StandardCost;
			if (column_name == "ListPrice") return _mod__ListPrice;
			if (column_name == "BOMLevel") return _mod__BOMLevel;
			if (column_name == "RecursionLevel") return _mod__RecursionLevel;
			throw new ArgumentOutOfRangeException(String.Format(VenturaSqlStrings.UNKNOWN_COLUMN_NAME, column_name));
		}

		public int ModifiedColumnCount()
		{
			int count = 0;
			if (_mod__ProductAssemblyID == true) count++;
			if (_mod__ComponentID == true) count++;
			if (_mod__ComponentDesc == true) count++;
			if (_mod__TotalQuantity == true) count++;
			if (_mod__StandardCost == true) count++;
			if (_mod__ListPrice == true) count++;
			if (_mod__BOMLevel == true) count++;
			if (_mod__RecursionLevel == true) count++;
			return count;
		}

		public bool PendingChanges()
		{
			return false;
		}

		public DataRecordStatus RecordStatus()
		{
			return _recordstatus;
		}

		DataRecordStatus IRecordBase.RecordStatus
		{
			get { return _recordstatus; }
			set { _recordstatus = value; }
		}

		void IRecordBase.ValidateBeforeSaving(int record_index_to_display)
		{
		}

		void IRecordBase.WriteChangesToTrackArray(TrackArray track_array)
		{
		}

		public bool StartedWithDbValues()
		{
			return _started_with_dbvalues;
		}

		/// <summary>
		/// Resets all columns to not-modified status.
		/// </summary>
		public void ResetToUnmodified()
		{
			if (_started_with_dbvalues == true)
			{
				if (_mod__ProductAssemblyID) _ori__ProductAssemblyID = default(int?);
				if (_mod__ComponentID) _ori__ComponentID = default(int?);
				if (_mod__ComponentDesc) _ori__ComponentDesc = default(string);
				if (_mod__TotalQuantity) _ori__TotalQuantity = default(decimal?);
				if (_mod__StandardCost) _ori__StandardCost = default(decimal?);
				if (_mod__ListPrice) _ori__ListPrice = default(decimal?);
				if (_mod__BOMLevel) _ori__BOMLevel = default(short?);
				if (_mod__RecursionLevel) _ori__RecursionLevel = default(int?);
			}
			_mod__ProductAssemblyID = false;
			_mod__ComponentID = false;
			_mod__ComponentDesc = false;
			_mod__TotalQuantity = false;
			_mod__StandardCost = false;
			_mod__ListPrice = false;
			_mod__BOMLevel = false;
			_mod__RecursionLevel = false;
		}

		/// <summary>
		/// Resets the record to DataRecordStatus.Existing. Like it was freshly loaded from the database.
		/// </summary>
		public void ResetToUnmodifiedExisting()
		{
			ResetToUnmodified();
			_recordstatus = DataRecordStatus.Existing;
		}

		/// <summary>
		/// Resets the record to DataRecordStatus.Existing.
		/// </summary>
		public void ResetToExisting()
		{
			_recordstatus = DataRecordStatus.Existing;
		}

		void IRecordBase.SetIdentityColumnValue(object value)
		{
		}

		partial void OnAfterPropertyChanged(string propertyName);

		public event PropertyChangedEventHandler PropertyChanged;

		private void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

	}
}

// The following commented out code is a template for implementing calculated columns.
//
// How to guide: https://docs.sysdev.nl/CalculatedColumns.html

/*
namespace AspNetCoreServer.VenturaRecordsets
{
	public partial class ExecStoredProcedureRecord
	{
		partial void OnAfterPropertyChanged(string propertyName)
		{
			if (propertyName == "FirstName" || propertyName == "LastName")
				this.OnPropertyChanged("FirstNameLastName");
		}

		public string FirstNameLastName
		{
			get
			{
				return this.FirstName + " " + this.LastName;
			}
		}
	}

}
*/
