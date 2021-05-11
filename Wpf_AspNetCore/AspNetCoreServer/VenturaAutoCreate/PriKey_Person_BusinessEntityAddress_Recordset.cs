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

namespace AspNetCoreServer.VenturaAutoCreate
{
	/// <summary>
	/// The updateable table is [Person].[BusinessEntityAddress]. Updateable table column information:
	/// • 5 out of 5 table columns are present in the resultset.
	/// • All primary key columns are present in the resultset: BusinessEntityID, AddressID and AddressTypeID.
	/// • Non-primary key columns present in the resultset: rowguid and ModifiedDate.
	/// Recordset item automatically created by VenturaSQL Studio.
	/// </summary>
	public partial class PriKey_Person_BusinessEntityAddress_Recordset : ResultsetObservable<PriKey_Person_BusinessEntityAddress_Recordset, PriKey_Person_BusinessEntityAddress_Record>, IRecordsetBase
	{
		private IResultsetBase[] _resultsets;
		private string _sqlscript;
		private object[] _inputparametervalues;
		private InputParamHolder _inputparamholder;
		private VenturaSqlSchema _parameterschema;
		private int _rowlimit = 500;
		private const string CRLF = "\r\n";

		public PriKey_Person_BusinessEntityAddress_Recordset()
		{
			_resultsets = new IResultsetBase[] { this };

			_sqlscript = @"SELECT [BusinessEntityID],[AddressID],[AddressTypeID],[rowguid],[ModifiedDate]" + CRLF +
			             @"FROM [Person].[BusinessEntityAddress]" + CRLF +
			             @"WHERE [BusinessEntityID] = @BusinessEntityID" + CRLF +
			             @"AND [AddressID] = @AddressID" + CRLF +
			             @"AND [AddressTypeID] = @AddressTypeID";

			_inputparametervalues = new object[3];
			_inputparamholder = new InputParamHolder(_inputparametervalues);

			ColumnArrayBuilder param_array = new ColumnArrayBuilder();

			param_array.AddParameterColumn("@BusinessEntityID", typeof(int), true, false, DbType.Int32, null, null, null);
			param_array.AddParameterColumn("@AddressID", typeof(int), true, false, DbType.Int32, null, null, null);
			param_array.AddParameterColumn("@AddressTypeID", typeof(int), true, false, DbType.Int32, null, null, null);

			_parameterschema = new VenturaSqlSchema(param_array);

			ColumnArrayBuilder schema_array = new ColumnArrayBuilder();

			schema_array.Add(new VenturaSqlColumn("BusinessEntityID", typeof(int), false)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				IsKey = true,
				BaseSchemaName = "Person",
				BaseTableName = "BusinessEntityAddress",
				BaseColumnName = "BusinessEntityID"
			});

			schema_array.Add(new VenturaSqlColumn("AddressID", typeof(int), false)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				IsKey = true,
				BaseSchemaName = "Person",
				BaseTableName = "BusinessEntityAddress",
				BaseColumnName = "AddressID"
			});

			schema_array.Add(new VenturaSqlColumn("AddressTypeID", typeof(int), false)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				IsKey = true,
				BaseSchemaName = "Person",
				BaseTableName = "BusinessEntityAddress",
				BaseColumnName = "AddressTypeID"
			});

			schema_array.Add(new VenturaSqlColumn("rowguid", typeof(Guid), false)
			{
				Updateable = true,
				ColumnSize = 16,
				ProviderType = 14,
				BaseSchemaName = "Person",
				BaseTableName = "BusinessEntityAddress",
				BaseColumnName = "rowguid"
			});

			schema_array.Add(new VenturaSqlColumn("ModifiedDate", typeof(DateTime), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 23,
				NumericScale = 3,
				ProviderType = 4,
				BaseSchemaName = "Person",
				BaseTableName = "BusinessEntityAddress",
				BaseColumnName = "ModifiedDate"
			});

			((IResultsetBase)this).Schema = new VenturaSqlSchema(schema_array);
			((IResultsetBase)this).UpdateableTablename = "[Person].[BusinessEntityAddress]";
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[BusinessEntityAddress]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public int BusinessEntityID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.BusinessEntityID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.BusinessEntityID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[BusinessEntityAddress]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public int AddressID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.AddressID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.AddressID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[BusinessEntityAddress]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public int AddressTypeID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.AddressTypeID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.AddressTypeID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[BusinessEntityAddress]. NotReadonly. NotNull.
		/// </summary>
		public Guid rowguid
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.rowguid; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.rowguid = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[BusinessEntityAddress]. NotReadonly. NotNull.
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
			this.InsertItem(index, new PriKey_Person_BusinessEntityAddress_Record());
			this.CurrentRecordIndex = index;
		}

		public void Append(PriKey_Person_BusinessEntityAddress_Record record)
		{
			int index = this.RecordCount;
			this.InsertItem(index, record);
			this.CurrentRecordIndex = index;
		}

		public PriKey_Person_BusinessEntityAddress_Record NewRecord()
		{
			return new PriKey_Person_BusinessEntityAddress_Record();
		}

		protected override PriKey_Person_BusinessEntityAddress_Record InternalCreateExistingRecordObject(object[] columnvalues) => new PriKey_Person_BusinessEntityAddress_Record(columnvalues);

		byte[] IRecordsetBase.Hash
		{
			get { return new byte[] { 114, 70, 12, 238, 40, 159, 225, 40, 187, 236, 145, 134, 108, 246, 113, 99 }; }
		}

		string IRecordsetBase.HashString
		{
			get { return "72460CEE289FE128BBEC91866CF67163"; }
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

		public void SetExecSqlParams(int? BusinessEntityID, int? AddressID, int? AddressTypeID)
		{
			_inputparametervalues[0] = BusinessEntityID;
			_inputparametervalues[1] = AddressID;
			_inputparametervalues[2] = AddressTypeID;
		}

		public void ExecSql(int? BusinessEntityID, int? AddressID, int? AddressTypeID)
		{
			_inputparametervalues[0] = BusinessEntityID;
			_inputparametervalues[1] = AddressID;
			_inputparametervalues[2] = AddressTypeID;
			Transactional.ExecSql(VenturaSqlConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public void ExecSql(Connector connector, int? BusinessEntityID, int? AddressID, int? AddressTypeID)
		{
			_inputparametervalues[0] = BusinessEntityID;
			_inputparametervalues[1] = AddressID;
			_inputparametervalues[2] = AddressTypeID;
			Transactional.ExecSql(connector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync(int? BusinessEntityID, int? AddressID, int? AddressTypeID)
		{
			_inputparametervalues[0] = BusinessEntityID;
			_inputparametervalues[1] = AddressID;
			_inputparametervalues[2] = AddressTypeID;
			await Transactional.ExecSqlAsync(VenturaSqlConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync(Connector connector, int? BusinessEntityID, int? AddressID, int? AddressTypeID)
		{
			_inputparametervalues[0] = BusinessEntityID;
			_inputparametervalues[1] = AddressID;
			_inputparametervalues[2] = AddressTypeID;
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

			public int? AddressID
			{
				get { return (int?)_values[1]; }
				set { _values[1] = value; }
			}

			public int? AddressTypeID
			{
				get { return (int?)_values[2]; }
				set { _values[2] = value; }
			}

		}

	}

	public sealed partial class PriKey_Person_BusinessEntityAddress_Record : IRecordBase, INotifyPropertyChanged
	{
		private DataRecordStatus _recordstatus;
		private bool _started_with_dbvalues;

		private int _cur__BusinessEntityID; private int _ori__BusinessEntityID; private bool _mod__BusinessEntityID;
		private int _cur__AddressID; private int _ori__AddressID; private bool _mod__AddressID;
		private int _cur__AddressTypeID; private int _ori__AddressTypeID; private bool _mod__AddressTypeID;
		private Guid _cur__rowguid; private Guid _ori__rowguid; private bool _mod__rowguid;
		private DateTime _cur__ModifiedDate; private DateTime _ori__ModifiedDate; private bool _mod__ModifiedDate;


		public PriKey_Person_BusinessEntityAddress_Record()
		{
			_cur__BusinessEntityID = 0;
			_cur__AddressID = 0;
			_cur__AddressTypeID = 0;
			_cur__rowguid = Guid.Empty;
			_cur__ModifiedDate = new DateTime(1900, 1, 1);
			_started_with_dbvalues = false;
			_recordstatus = DataRecordStatus.New;
		}

		public PriKey_Person_BusinessEntityAddress_Record(object[] columnvalues)
		{
			_cur__BusinessEntityID = (int)columnvalues[0];
			_cur__AddressID = (int)columnvalues[1];
			_cur__AddressTypeID = (int)columnvalues[2];
			_cur__rowguid = (Guid)columnvalues[3];
			_cur__ModifiedDate = (DateTime)columnvalues[4];
			_started_with_dbvalues = true;
			_recordstatus = DataRecordStatus.Existing;
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[BusinessEntityAddress]. PrimaryKey. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [Person].[BusinessEntityAddress]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public int AddressID
		{
			get { return _cur__AddressID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__AddressID = true;
				if (_cur__AddressID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__AddressID == false) { _ori__AddressID = _cur__AddressID; _mod__AddressID = true; } // existing record and column is not modified
					else { if (value == _ori__AddressID) { _ori__AddressID = default(int); _mod__AddressID = false; } } // existing record and column is modified
				}
				_cur__AddressID = value; OnPropertyChanged("AddressID"); OnAfterPropertyChanged("AddressID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[BusinessEntityAddress]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public int AddressTypeID
		{
			get { return _cur__AddressTypeID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__AddressTypeID = true;
				if (_cur__AddressTypeID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__AddressTypeID == false) { _ori__AddressTypeID = _cur__AddressTypeID; _mod__AddressTypeID = true; } // existing record and column is not modified
					else { if (value == _ori__AddressTypeID) { _ori__AddressTypeID = default(int); _mod__AddressTypeID = false; } } // existing record and column is modified
				}
				_cur__AddressTypeID = value; OnPropertyChanged("AddressTypeID"); OnAfterPropertyChanged("AddressTypeID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[BusinessEntityAddress]. NotReadonly. NotNull.
		/// </summary>
		public Guid rowguid
		{
			get { return _cur__rowguid; }
			set
			{
				if (_started_with_dbvalues == false) _mod__rowguid = true;
				if (_cur__rowguid == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__rowguid == false) { _ori__rowguid = _cur__rowguid; _mod__rowguid = true; } // existing record and column is not modified
					else { if (value == _ori__rowguid) { _ori__rowguid = default(Guid); _mod__rowguid = false; } } // existing record and column is modified
				}
				_cur__rowguid = value; OnPropertyChanged("rowguid"); OnAfterPropertyChanged("rowguid");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[BusinessEntityAddress]. NotReadonly. NotNull.
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
			if (column_name == "AddressID") return _mod__AddressID;
			if (column_name == "AddressTypeID") return _mod__AddressTypeID;
			if (column_name == "rowguid") return _mod__rowguid;
			if (column_name == "ModifiedDate") return _mod__ModifiedDate;
			throw new ArgumentOutOfRangeException(String.Format(VenturaSqlStrings.UNKNOWN_COLUMN_NAME, column_name));
		}

		public int ModifiedColumnCount()
		{
			int count = 0;
			if (_mod__BusinessEntityID == true) count++;
			if (_mod__AddressID == true) count++;
			if (_mod__AddressTypeID == true) count++;
			if (_mod__rowguid == true) count++;
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
				if (_mod__AddressID) count++;
				if (_mod__AddressTypeID) count++;
			}
			if (_mod__rowguid == true) count++;
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
			if (_mod__AddressID == false) throw new Exception(string.Format(VenturaSqlStrings.VALUE_NOT_SET_MSG, record_index_to_display, "AddressID"));
			if (_mod__AddressTypeID == false) throw new Exception(string.Format(VenturaSqlStrings.VALUE_NOT_SET_MSG, record_index_to_display, "AddressTypeID"));
		}

		void IRecordBase.WriteChangesToTrackArray(TrackArray track_array)
		{
			if (_recordstatus == DataRecordStatus.New)
			{
				track_array.AppendDataValue(0, _cur__BusinessEntityID);
				track_array.AppendDataValue(1, _cur__AddressID);
				track_array.AppendDataValue(2, _cur__AddressTypeID);
				track_array.AppendDataValue(3, _cur__rowguid);
				track_array.AppendDataValue(4, _cur__ModifiedDate);
			}
			else if (_recordstatus == DataRecordStatus.Existing)
			{
				if (_started_with_dbvalues)
				{
					if (_mod__BusinessEntityID) track_array.AppendDataValue(0, _cur__BusinessEntityID);
					if (_mod__AddressID) track_array.AppendDataValue(1, _cur__AddressID);
					if (_mod__AddressTypeID) track_array.AppendDataValue(2, _cur__AddressTypeID);
				}
				if (_mod__rowguid) track_array.AppendDataValue(3, _cur__rowguid);
				if (_mod__ModifiedDate) track_array.AppendDataValue(4, _cur__ModifiedDate);
				if (track_array.HasData == false) return;
			}

			if (_recordstatus == DataRecordStatus.Existing || _recordstatus == DataRecordStatus.ExistingDelete)
			{
				track_array.AppendPrikeyValue(0, (_mod__BusinessEntityID && _started_with_dbvalues) ? _ori__BusinessEntityID : _cur__BusinessEntityID);
				track_array.AppendPrikeyValue(1, (_mod__AddressID && _started_with_dbvalues) ? _ori__AddressID : _cur__AddressID);
				track_array.AppendPrikeyValue(2, (_mod__AddressTypeID && _started_with_dbvalues) ? _ori__AddressTypeID : _cur__AddressTypeID);
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
				if (_mod__AddressID) _ori__AddressID = default(int);
				if (_mod__AddressTypeID) _ori__AddressTypeID = default(int);
				if (_mod__rowguid) _ori__rowguid = default(Guid);
				if (_mod__ModifiedDate) _ori__ModifiedDate = default(DateTime);
			}
			_mod__BusinessEntityID = false;
			_mod__AddressID = false;
			_mod__AddressTypeID = false;
			_mod__rowguid = false;
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
namespace AspNetCoreServer.VenturaAutoCreate
{
	public partial class PriKey_Person_BusinessEntityAddress_Record
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
