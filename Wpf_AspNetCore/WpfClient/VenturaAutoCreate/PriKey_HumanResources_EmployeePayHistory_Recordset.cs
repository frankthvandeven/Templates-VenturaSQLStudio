/*
	Project file: "C:\Active\VenturaSQL\BuildSystem\Templates\Wpf_AspNetCore\Template.venproj"
	Target platform: NETStandard
	Generator version: 4.0.130
	Generated on: Wednesday, 19 May 2021 at 09:12:24
	At the bottom of this file you find a template for extending Recordsets with calculated columns for XAML data binding.
*/
using VenturaSQL;
using System;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel;

namespace WpfClient.VenturaAutoCreate
{
	/// <summary>
	/// The updateable table is [HumanResources].[EmployeePayHistory]. Updateable table column information:
	/// • 5 out of 5 table columns are present in the resultset.
	/// • All primary key columns are present in the resultset: BusinessEntityID and RateChangeDate.
	/// • Non-primary key columns present in the resultset: Rate, PayFrequency and ModifiedDate.
	/// Recordset item automatically created by VenturaSQL Studio.
	/// </summary>
	public partial class PriKey_HumanResources_EmployeePayHistory_Recordset : ResultsetObservable<PriKey_HumanResources_EmployeePayHistory_Recordset, PriKey_HumanResources_EmployeePayHistory_Record>, IRecordsetBase
	{
		private IResultsetBase[] _resultsets;
		private string _sqlscript;
		private object[] _inputparametervalues;
		private InputParamHolder _inputparamholder;
		private VenturaSqlSchema _parameterschema;
		private int _rowlimit = 500;
		private const string CRLF = "\r\n";

		public PriKey_HumanResources_EmployeePayHistory_Recordset()
		{
			_resultsets = new IResultsetBase[] { this };

			_sqlscript = @"SELECT [BusinessEntityID],[RateChangeDate],[Rate],[PayFrequency],[ModifiedDate]" + CRLF +
			             @"FROM [HumanResources].[EmployeePayHistory]" + CRLF +
			             @"WHERE [BusinessEntityID] = @BusinessEntityID" + CRLF +
			             @"AND [RateChangeDate] = @RateChangeDate";

			_inputparametervalues = new object[2];
			_inputparamholder = new InputParamHolder(_inputparametervalues);

			ColumnArrayBuilder param_array = new ColumnArrayBuilder();

			param_array.AddParameterColumn("@BusinessEntityID", typeof(int), true, false, DbType.Int32, null, null, null);
			param_array.AddParameterColumn("@RateChangeDate", typeof(DateTime), true, false, DbType.DateTime, null, null, null);

			_parameterschema = new VenturaSqlSchema(param_array);

			ColumnArrayBuilder schema_array = new ColumnArrayBuilder();

			schema_array.Add(new VenturaSqlColumn("BusinessEntityID", typeof(int), false)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				IsKey = true,
				BaseSchemaName = "HumanResources",
				BaseTableName = "EmployeePayHistory",
				BaseColumnName = "BusinessEntityID"
			});

			schema_array.Add(new VenturaSqlColumn("RateChangeDate", typeof(DateTime), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 23,
				NumericScale = 3,
				ProviderType = 4,
				IsKey = true,
				BaseSchemaName = "HumanResources",
				BaseTableName = "EmployeePayHistory",
				BaseColumnName = "RateChangeDate"
			});

			schema_array.Add(new VenturaSqlColumn("Rate", typeof(decimal), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 19,
				ProviderType = 9,
				BaseSchemaName = "HumanResources",
				BaseTableName = "EmployeePayHistory",
				BaseColumnName = "Rate"
			});

			schema_array.Add(new VenturaSqlColumn("PayFrequency", typeof(byte), false)
			{
				Updateable = true,
				ColumnSize = 1,
				NumericPrecision = 3,
				ProviderType = 20,
				BaseSchemaName = "HumanResources",
				BaseTableName = "EmployeePayHistory",
				BaseColumnName = "PayFrequency"
			});

			schema_array.Add(new VenturaSqlColumn("ModifiedDate", typeof(DateTime), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 23,
				NumericScale = 3,
				ProviderType = 4,
				BaseSchemaName = "HumanResources",
				BaseTableName = "EmployeePayHistory",
				BaseColumnName = "ModifiedDate"
			});

			((IResultsetBase)this).Schema = new VenturaSqlSchema(schema_array);
			((IResultsetBase)this).UpdateableTablename = "[HumanResources].[EmployeePayHistory]";
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[EmployeePayHistory]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public int BusinessEntityID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.BusinessEntityID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.BusinessEntityID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[EmployeePayHistory]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public DateTime RateChangeDate
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.RateChangeDate; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.RateChangeDate = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[EmployeePayHistory]. NotReadonly. NotNull.
		/// </summary>
		public decimal Rate
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Rate; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Rate = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[EmployeePayHistory]. NotReadonly. NotNull.
		/// </summary>
		public byte PayFrequency
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.PayFrequency; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.PayFrequency = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[EmployeePayHistory]. NotReadonly. NotNull.
		/// </summary>
		public DateTime ModifiedDate
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ModifiedDate; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ModifiedDate = value; }
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
			this.InsertItem(index, new PriKey_HumanResources_EmployeePayHistory_Record());
			this.CurrentRecordIndex = index;
		}

		public void Append(PriKey_HumanResources_EmployeePayHistory_Record record)
		{
			int index = this.RecordCount;
			this.InsertItem(index, record);
			this.CurrentRecordIndex = index;
		}

		public PriKey_HumanResources_EmployeePayHistory_Record NewRecord()
		{
			return new PriKey_HumanResources_EmployeePayHistory_Record();
		}

		protected override PriKey_HumanResources_EmployeePayHistory_Record InternalCreateExistingRecordObject(object[] columnvalues) => new PriKey_HumanResources_EmployeePayHistory_Record(columnvalues);

		byte[] IRecordsetBase.Hash
		{
			get { return new byte[] { 152, 85, 249, 52, 169, 51, 223, 9, 27, 172, 226, 16, 188, 247, 214, 130 }; }
		}

		string IRecordsetBase.HashString
		{
			get { return "9855F934A933DF091BACE210BCF7D682"; }
		}

		VenturaSqlPlatform IRecordsetBase.GeneratorTarget
		{
			get { return VenturaSqlPlatform.NETStandard; }
		}

		Version IRecordsetBase.GeneratorVersion
		{
			get { return new Version(4,0,130); }
		}

		DateTime IRecordsetBase.GeneratorTimestamp
		{
			get { return new DateTime(2021, 5, 19, 9, 12, 24); } // Wednesday, 19 May 2021 at 09:12:24
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

		public void SetExecSqlParams(int? BusinessEntityID, DateTime? RateChangeDate)
		{
			_inputparametervalues[0] = BusinessEntityID;
			_inputparametervalues[1] = RateChangeDate;
		}

		public void ExecSql(int? BusinessEntityID, DateTime? RateChangeDate)
		{
			_inputparametervalues[0] = BusinessEntityID;
			_inputparametervalues[1] = RateChangeDate;
			Transactional.ExecSql(VenturaSqlConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public void ExecSql(Connector connector, int? BusinessEntityID, DateTime? RateChangeDate)
		{
			_inputparametervalues[0] = BusinessEntityID;
			_inputparametervalues[1] = RateChangeDate;
			Transactional.ExecSql(connector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync(int? BusinessEntityID, DateTime? RateChangeDate)
		{
			_inputparametervalues[0] = BusinessEntityID;
			_inputparametervalues[1] = RateChangeDate;
			await Transactional.ExecSqlAsync(VenturaSqlConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync(Connector connector, int? BusinessEntityID, DateTime? RateChangeDate)
		{
			_inputparametervalues[0] = BusinessEntityID;
			_inputparametervalues[1] = RateChangeDate;
			await Transactional.ExecSqlAsync(connector, new IRecordsetBase[] { this });
		}

		public void SaveChanges()
		{
			Transactional.SaveChanges(VenturaSqlConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public void SaveChanges(Connector connector)
		{
			Transactional.SaveChanges(connector, new IRecordsetBase[] { this });
		}

		public async Task SaveChangesAsync()
		{
			await Transactional.SaveChangesAsync(VenturaSqlConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public async Task SaveChangesAsync(Connector connector)
		{
			await Transactional.SaveChangesAsync(connector, new IRecordsetBase[] { this });
		}

		public class InputParamHolder
		{
			private object[] _values;

			public InputParamHolder(object[] values)
			{
				_values = values;
			}

			public int? BusinessEntityID
			{
				get { return (int?)_values[0]; }
				set { _values[0] = value; }
			}

			public DateTime? RateChangeDate
			{
				get { return (DateTime?)_values[1]; }
				set { _values[1] = value; }
			}

		}

	}

	public sealed partial class PriKey_HumanResources_EmployeePayHistory_Record : IRecordBase, INotifyPropertyChanged
	{
		private DataRecordStatus _recordstatus;
		private bool _started_with_dbvalues;

		private int _cur__BusinessEntityID; private int _ori__BusinessEntityID; private bool _mod__BusinessEntityID;
		private DateTime _cur__RateChangeDate; private DateTime _ori__RateChangeDate; private bool _mod__RateChangeDate;
		private decimal _cur__Rate; private decimal _ori__Rate; private bool _mod__Rate;
		private byte _cur__PayFrequency; private byte _ori__PayFrequency; private bool _mod__PayFrequency;
		private DateTime _cur__ModifiedDate; private DateTime _ori__ModifiedDate; private bool _mod__ModifiedDate;


		public PriKey_HumanResources_EmployeePayHistory_Record()
		{
			_cur__BusinessEntityID = 0;
			_cur__RateChangeDate = new DateTime(1900, 1, 1);
			_cur__Rate = 0.0m;
			_cur__PayFrequency = 0;
			_cur__ModifiedDate = new DateTime(1900, 1, 1);
			_started_with_dbvalues = false;
			_recordstatus = DataRecordStatus.New;
		}

		public PriKey_HumanResources_EmployeePayHistory_Record(object[] columnvalues)
		{
			_cur__BusinessEntityID = (int)columnvalues[0];
			_cur__RateChangeDate = (DateTime)columnvalues[1];
			_cur__Rate = (decimal)columnvalues[2];
			_cur__PayFrequency = (byte)columnvalues[3];
			_cur__ModifiedDate = (DateTime)columnvalues[4];
			_started_with_dbvalues = true;
			_recordstatus = DataRecordStatus.Existing;
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[EmployeePayHistory]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public int BusinessEntityID
		{
			get { return _cur__BusinessEntityID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__BusinessEntityID = true;
				if (_cur__BusinessEntityID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__BusinessEntityID == false) { _ori__BusinessEntityID = _cur__BusinessEntityID; _mod__BusinessEntityID = true; } // existing record and column is not modified
					else { if (value == _ori__BusinessEntityID) { _ori__BusinessEntityID = default(int); _mod__BusinessEntityID = false; } } // existing record and column is modified
				}
				_cur__BusinessEntityID = value; OnPropertyChanged("BusinessEntityID"); OnAfterPropertyChanged("BusinessEntityID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[EmployeePayHistory]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public DateTime RateChangeDate
		{
			get { return _cur__RateChangeDate; }
			set
			{
				if (_started_with_dbvalues == false) _mod__RateChangeDate = true;
				if (_cur__RateChangeDate == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__RateChangeDate == false) { _ori__RateChangeDate = _cur__RateChangeDate; _mod__RateChangeDate = true; } // existing record and column is not modified
					else { if (value == _ori__RateChangeDate) { _ori__RateChangeDate = default(DateTime); _mod__RateChangeDate = false; } } // existing record and column is modified
				}
				_cur__RateChangeDate = value; OnPropertyChanged("RateChangeDate"); OnAfterPropertyChanged("RateChangeDate");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[EmployeePayHistory]. NotReadonly. NotNull.
		/// </summary>
		public decimal Rate
		{
			get { return _cur__Rate; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Rate = true;
				if (_cur__Rate == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Rate == false) { _ori__Rate = _cur__Rate; _mod__Rate = true; } // existing record and column is not modified
					else { if (value == _ori__Rate) { _ori__Rate = default(decimal); _mod__Rate = false; } } // existing record and column is modified
				}
				_cur__Rate = value; OnPropertyChanged("Rate"); OnAfterPropertyChanged("Rate");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[EmployeePayHistory]. NotReadonly. NotNull.
		/// </summary>
		public byte PayFrequency
		{
			get { return _cur__PayFrequency; }
			set
			{
				if (_started_with_dbvalues == false) _mod__PayFrequency = true;
				if (_cur__PayFrequency == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__PayFrequency == false) { _ori__PayFrequency = _cur__PayFrequency; _mod__PayFrequency = true; } // existing record and column is not modified
					else { if (value == _ori__PayFrequency) { _ori__PayFrequency = default(byte); _mod__PayFrequency = false; } } // existing record and column is modified
				}
				_cur__PayFrequency = value; OnPropertyChanged("PayFrequency"); OnAfterPropertyChanged("PayFrequency");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[EmployeePayHistory]. NotReadonly. NotNull.
		/// </summary>
		public DateTime ModifiedDate
		{
			get { return _cur__ModifiedDate; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ModifiedDate = true;
				if (_cur__ModifiedDate == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ModifiedDate == false) { _ori__ModifiedDate = _cur__ModifiedDate; _mod__ModifiedDate = true; } // existing record and column is not modified
					else { if (value == _ori__ModifiedDate) { _ori__ModifiedDate = default(DateTime); _mod__ModifiedDate = false; } } // existing record and column is modified
				}
				_cur__ModifiedDate = value; OnPropertyChanged("ModifiedDate"); OnAfterPropertyChanged("ModifiedDate");
			}
		}

		public bool IsModified(string column_name)
		{
			if (column_name == "BusinessEntityID") return _mod__BusinessEntityID;
			if (column_name == "RateChangeDate") return _mod__RateChangeDate;
			if (column_name == "Rate") return _mod__Rate;
			if (column_name == "PayFrequency") return _mod__PayFrequency;
			if (column_name == "ModifiedDate") return _mod__ModifiedDate;
			throw new ArgumentOutOfRangeException(String.Format(VenturaSqlStrings.UNKNOWN_COLUMN_NAME, column_name));
		}

		public int ModifiedColumnCount()
		{
			int count = 0;
			if (_mod__BusinessEntityID == true) count++;
			if (_mod__RateChangeDate == true) count++;
			if (_mod__Rate == true) count++;
			if (_mod__PayFrequency == true) count++;
			if (_mod__ModifiedDate == true) count++;
			return count;
		}

		public bool PendingChanges()
		{
			if (_recordstatus == DataRecordStatus.New || _recordstatus == DataRecordStatus.ExistingDelete) return true;
			int count = 0;
			if (_started_with_dbvalues)
			{
				if (_mod__BusinessEntityID) count++;
				if (_mod__RateChangeDate) count++;
			}
			if (_mod__Rate == true) count++;
			if (_mod__PayFrequency == true) count++;
			if (_mod__ModifiedDate == true) count++;
			return count > 0;
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
			if (_started_with_dbvalues) return;
			if (_recordstatus == DataRecordStatus.Existing) return;
			if (_mod__BusinessEntityID == false) throw new Exception(string.Format(VenturaSqlStrings.VALUE_NOT_SET_MSG, record_index_to_display, "BusinessEntityID"));
			if (_mod__RateChangeDate == false) throw new Exception(string.Format(VenturaSqlStrings.VALUE_NOT_SET_MSG, record_index_to_display, "RateChangeDate"));
		}

		void IRecordBase.WriteChangesToTrackArray(TrackArray track_array)
		{
			if (_recordstatus == DataRecordStatus.New)
			{
				track_array.AppendDataValue(0, _cur__BusinessEntityID);
				track_array.AppendDataValue(1, _cur__RateChangeDate);
				track_array.AppendDataValue(2, _cur__Rate);
				track_array.AppendDataValue(3, _cur__PayFrequency);
				track_array.AppendDataValue(4, _cur__ModifiedDate);
			}
			else if (_recordstatus == DataRecordStatus.Existing)
			{
				if (_started_with_dbvalues)
				{
					if (_mod__BusinessEntityID) track_array.AppendDataValue(0, _cur__BusinessEntityID);
					if (_mod__RateChangeDate) track_array.AppendDataValue(1, _cur__RateChangeDate);
				}
				if (_mod__Rate) track_array.AppendDataValue(2, _cur__Rate);
				if (_mod__PayFrequency) track_array.AppendDataValue(3, _cur__PayFrequency);
				if (_mod__ModifiedDate) track_array.AppendDataValue(4, _cur__ModifiedDate);
				if (track_array.HasData == false) return;
			}

			if (_recordstatus == DataRecordStatus.Existing || _recordstatus == DataRecordStatus.ExistingDelete)
			{
				track_array.AppendPrikeyValue(0, (_mod__BusinessEntityID && _started_with_dbvalues) ? _ori__BusinessEntityID : _cur__BusinessEntityID);
				track_array.AppendPrikeyValue(1, (_mod__RateChangeDate && _started_with_dbvalues) ? _ori__RateChangeDate : _cur__RateChangeDate);
			}

			if (_recordstatus == DataRecordStatus.New) track_array.Status = TrackArrayStatus.DataForINSERT;
			else if (_recordstatus == DataRecordStatus.Existing) track_array.Status = TrackArrayStatus.DataForUPDATE;
			else if (_recordstatus == DataRecordStatus.ExistingDelete) track_array.Status = TrackArrayStatus.DataForDELETE;
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
				if (_mod__BusinessEntityID) _ori__BusinessEntityID = default(int);
				if (_mod__RateChangeDate) _ori__RateChangeDate = default(DateTime);
				if (_mod__Rate) _ori__Rate = default(decimal);
				if (_mod__PayFrequency) _ori__PayFrequency = default(byte);
				if (_mod__ModifiedDate) _ori__ModifiedDate = default(DateTime);
			}
			_mod__BusinessEntityID = false;
			_mod__RateChangeDate = false;
			_mod__Rate = false;
			_mod__PayFrequency = false;
			_mod__ModifiedDate = false;
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
namespace WpfClient.VenturaAutoCreate
{
	public partial class PriKey_HumanResources_EmployeePayHistory_Record
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
