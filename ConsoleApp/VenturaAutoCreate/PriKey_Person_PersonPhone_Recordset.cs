/*
	Project file: "C:\Active\VenturaSQL\BuildSystem\Templates\ConsoleApp\Template.venproj"
	Target platform: NETStandard
	Generator version: 4.0.130
	Generated on: Wednesday, 19 May 2021 at 09:11:58
	At the bottom of this file you find a template for extending Recordsets with calculated columns for XAML data binding.
*/
using VenturaSQL;
using System;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel;

namespace ConsoleApp.VenturaAutoCreate
{
	/// <summary>
	/// The updateable table is [Person].[PersonPhone]. Updateable table column information:
	/// • 4 out of 4 table columns are present in the resultset.
	/// • All primary key columns are present in the resultset: BusinessEntityID, PhoneNumber and PhoneNumberTypeID.
	/// • Non-primary key column present in the resultset: ModifiedDate.
	/// Recordset item automatically created by VenturaSQL Studio.
	/// </summary>
	public partial class PriKey_Person_PersonPhone_Recordset : ResultsetObservable<PriKey_Person_PersonPhone_Recordset, PriKey_Person_PersonPhone_Record>, IRecordsetBase
	{
		private IResultsetBase[] _resultsets;
		private string _sqlscript;
		private object[] _inputparametervalues;
		private InputParamHolder _inputparamholder;
		private VenturaSqlSchema _parameterschema;
		private int _rowlimit = 500;
		private const string CRLF = "\r\n";

		public PriKey_Person_PersonPhone_Recordset()
		{
			_resultsets = new IResultsetBase[] { this };

			_sqlscript = @"SELECT [BusinessEntityID],[PhoneNumber],[PhoneNumberTypeID],[ModifiedDate]" + CRLF +
			             @"FROM [Person].[PersonPhone]" + CRLF +
			             @"WHERE [BusinessEntityID] = @BusinessEntityID" + CRLF +
			             @"AND [PhoneNumber] = @PhoneNumber" + CRLF +
			             @"AND [PhoneNumberTypeID] = @PhoneNumberTypeID";

			_inputparametervalues = new object[3];
			_inputparamholder = new InputParamHolder(_inputparametervalues);

			ColumnArrayBuilder param_array = new ColumnArrayBuilder();

			param_array.AddParameterColumn("@BusinessEntityID", typeof(int), true, false, DbType.Int32, null, null, null);
			param_array.AddParameterColumn("@PhoneNumber", typeof(string), true, false, DbType.String, null, null, null);
			param_array.AddParameterColumn("@PhoneNumberTypeID", typeof(int), true, false, DbType.Int32, null, null, null);

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
				BaseTableName = "PersonPhone",
				BaseColumnName = "BusinessEntityID"
			});

			schema_array.Add(new VenturaSqlColumn("PhoneNumber", typeof(string), false)
			{
				Updateable = true,
				ColumnSize = 25,
				ProviderType = 12,
				IsKey = true,
				BaseSchemaName = "Person",
				BaseTableName = "PersonPhone",
				BaseColumnName = "PhoneNumber"
			});

			schema_array.Add(new VenturaSqlColumn("PhoneNumberTypeID", typeof(int), false)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				IsKey = true,
				BaseSchemaName = "Person",
				BaseTableName = "PersonPhone",
				BaseColumnName = "PhoneNumberTypeID"
			});

			schema_array.Add(new VenturaSqlColumn("ModifiedDate", typeof(DateTime), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 23,
				NumericScale = 3,
				ProviderType = 4,
				BaseSchemaName = "Person",
				BaseTableName = "PersonPhone",
				BaseColumnName = "ModifiedDate"
			});

			((IResultsetBase)this).Schema = new VenturaSqlSchema(schema_array);
			((IResultsetBase)this).UpdateableTablename = "[Person].[PersonPhone]";
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[PersonPhone]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public int BusinessEntityID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.BusinessEntityID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.BusinessEntityID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[PersonPhone]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public string PhoneNumber
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.PhoneNumber; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.PhoneNumber = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[PersonPhone]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public int PhoneNumberTypeID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.PhoneNumberTypeID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.PhoneNumberTypeID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[PersonPhone]. NotReadonly. NotNull.
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
			this.InsertItem(index, new PriKey_Person_PersonPhone_Record());
			this.CurrentRecordIndex = index;
		}

		public void Append(PriKey_Person_PersonPhone_Record record)
		{
			int index = this.RecordCount;
			this.InsertItem(index, record);
			this.CurrentRecordIndex = index;
		}

		public PriKey_Person_PersonPhone_Record NewRecord()
		{
			return new PriKey_Person_PersonPhone_Record();
		}

		protected override PriKey_Person_PersonPhone_Record InternalCreateExistingRecordObject(object[] columnvalues) => new PriKey_Person_PersonPhone_Record(columnvalues);

		byte[] IRecordsetBase.Hash
		{
			get { return new byte[] { 91, 249, 63, 144, 110, 79, 65, 121, 86, 152, 50, 65, 218, 67, 154, 13 }; }
		}

		string IRecordsetBase.HashString
		{
			get { return "5BF93F906E4F417956983241DA439A0D"; }
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
			get { return new DateTime(2021, 5, 19, 9, 11, 58); } // Wednesday, 19 May 2021 at 09:11:58
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

		public void SetExecSqlParams(int? BusinessEntityID, string PhoneNumber, int? PhoneNumberTypeID)
		{
			_inputparametervalues[0] = BusinessEntityID;
			_inputparametervalues[1] = PhoneNumber;
			_inputparametervalues[2] = PhoneNumberTypeID;
		}

		public void ExecSql(int? BusinessEntityID, string PhoneNumber, int? PhoneNumberTypeID)
		{
			_inputparametervalues[0] = BusinessEntityID;
			_inputparametervalues[1] = PhoneNumber;
			_inputparametervalues[2] = PhoneNumberTypeID;
			Transactional.ExecSql(VenturaSqlConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public void ExecSql(Connector connector, int? BusinessEntityID, string PhoneNumber, int? PhoneNumberTypeID)
		{
			_inputparametervalues[0] = BusinessEntityID;
			_inputparametervalues[1] = PhoneNumber;
			_inputparametervalues[2] = PhoneNumberTypeID;
			Transactional.ExecSql(connector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync(int? BusinessEntityID, string PhoneNumber, int? PhoneNumberTypeID)
		{
			_inputparametervalues[0] = BusinessEntityID;
			_inputparametervalues[1] = PhoneNumber;
			_inputparametervalues[2] = PhoneNumberTypeID;
			await Transactional.ExecSqlAsync(VenturaSqlConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync(Connector connector, int? BusinessEntityID, string PhoneNumber, int? PhoneNumberTypeID)
		{
			_inputparametervalues[0] = BusinessEntityID;
			_inputparametervalues[1] = PhoneNumber;
			_inputparametervalues[2] = PhoneNumberTypeID;
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

			public string PhoneNumber
			{
				get { return (string)_values[1]; }
				set { _values[1] = value; }
			}

			public int? PhoneNumberTypeID
			{
				get { return (int?)_values[2]; }
				set { _values[2] = value; }
			}

		}

	}

	public sealed partial class PriKey_Person_PersonPhone_Record : IRecordBase, INotifyPropertyChanged
	{
		private DataRecordStatus _recordstatus;
		private bool _started_with_dbvalues;

		private int _cur__BusinessEntityID; private int _ori__BusinessEntityID; private bool _mod__BusinessEntityID;
		private string _cur__PhoneNumber; private string _ori__PhoneNumber; private bool _mod__PhoneNumber;
		private int _cur__PhoneNumberTypeID; private int _ori__PhoneNumberTypeID; private bool _mod__PhoneNumberTypeID;
		private DateTime _cur__ModifiedDate; private DateTime _ori__ModifiedDate; private bool _mod__ModifiedDate;


		public PriKey_Person_PersonPhone_Record()
		{
			_cur__BusinessEntityID = 0;
			_cur__PhoneNumber = "";
			_cur__PhoneNumberTypeID = 0;
			_cur__ModifiedDate = new DateTime(1900, 1, 1);
			_started_with_dbvalues = false;
			_recordstatus = DataRecordStatus.New;
		}

		public PriKey_Person_PersonPhone_Record(object[] columnvalues)
		{
			_cur__BusinessEntityID = (int)columnvalues[0];
			_cur__PhoneNumber = (string)columnvalues[1];
			_cur__PhoneNumberTypeID = (int)columnvalues[2];
			_cur__ModifiedDate = (DateTime)columnvalues[3];
			_started_with_dbvalues = true;
			_recordstatus = DataRecordStatus.Existing;
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[PersonPhone]. PrimaryKey. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [Person].[PersonPhone]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public string PhoneNumber
		{
			get { return _cur__PhoneNumber; }
			set
			{
				if (value == null) throw new ArgumentNullException("PhoneNumber", VenturaSqlStrings.SET_NULL_MSG);
				if (_started_with_dbvalues == false) _mod__PhoneNumber = true;
				if (_cur__PhoneNumber == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__PhoneNumber == false) { _ori__PhoneNumber = _cur__PhoneNumber; _mod__PhoneNumber = true; } // existing record and column is not modified
					else { if (value == _ori__PhoneNumber) { _ori__PhoneNumber = default(string); _mod__PhoneNumber = false; } } // existing record and column is modified
				}
				_cur__PhoneNumber = value; OnPropertyChanged("PhoneNumber"); OnAfterPropertyChanged("PhoneNumber");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[PersonPhone]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public int PhoneNumberTypeID
		{
			get { return _cur__PhoneNumberTypeID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__PhoneNumberTypeID = true;
				if (_cur__PhoneNumberTypeID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__PhoneNumberTypeID == false) { _ori__PhoneNumberTypeID = _cur__PhoneNumberTypeID; _mod__PhoneNumberTypeID = true; } // existing record and column is not modified
					else { if (value == _ori__PhoneNumberTypeID) { _ori__PhoneNumberTypeID = default(int); _mod__PhoneNumberTypeID = false; } } // existing record and column is modified
				}
				_cur__PhoneNumberTypeID = value; OnPropertyChanged("PhoneNumberTypeID"); OnAfterPropertyChanged("PhoneNumberTypeID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[PersonPhone]. NotReadonly. NotNull.
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
			if (column_name == "PhoneNumber") return _mod__PhoneNumber;
			if (column_name == "PhoneNumberTypeID") return _mod__PhoneNumberTypeID;
			if (column_name == "ModifiedDate") return _mod__ModifiedDate;
			throw new ArgumentOutOfRangeException(String.Format(VenturaSqlStrings.UNKNOWN_COLUMN_NAME, column_name));
		}

		public int ModifiedColumnCount()
		{
			int count = 0;
			if (_mod__BusinessEntityID == true) count++;
			if (_mod__PhoneNumber == true) count++;
			if (_mod__PhoneNumberTypeID == true) count++;
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
				if (_mod__PhoneNumber) count++;
				if (_mod__PhoneNumberTypeID) count++;
			}
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
			if (_mod__PhoneNumber == false) throw new Exception(string.Format(VenturaSqlStrings.VALUE_NOT_SET_MSG, record_index_to_display, "PhoneNumber"));
			if (_mod__PhoneNumberTypeID == false) throw new Exception(string.Format(VenturaSqlStrings.VALUE_NOT_SET_MSG, record_index_to_display, "PhoneNumberTypeID"));
		}

		void IRecordBase.WriteChangesToTrackArray(TrackArray track_array)
		{
			if (_recordstatus == DataRecordStatus.New)
			{
				track_array.AppendDataValue(0, _cur__BusinessEntityID);
				track_array.AppendDataValue(1, _cur__PhoneNumber);
				track_array.AppendDataValue(2, _cur__PhoneNumberTypeID);
				track_array.AppendDataValue(3, _cur__ModifiedDate);
			}
			else if (_recordstatus == DataRecordStatus.Existing)
			{
				if (_started_with_dbvalues)
				{
					if (_mod__BusinessEntityID) track_array.AppendDataValue(0, _cur__BusinessEntityID);
					if (_mod__PhoneNumber) track_array.AppendDataValue(1, _cur__PhoneNumber);
					if (_mod__PhoneNumberTypeID) track_array.AppendDataValue(2, _cur__PhoneNumberTypeID);
				}
				if (_mod__ModifiedDate) track_array.AppendDataValue(3, _cur__ModifiedDate);
				if (track_array.HasData == false) return;
			}

			if (_recordstatus == DataRecordStatus.Existing || _recordstatus == DataRecordStatus.ExistingDelete)
			{
				track_array.AppendPrikeyValue(0, (_mod__BusinessEntityID && _started_with_dbvalues) ? _ori__BusinessEntityID : _cur__BusinessEntityID);
				track_array.AppendPrikeyValue(1, (_mod__PhoneNumber && _started_with_dbvalues) ? _ori__PhoneNumber : _cur__PhoneNumber);
				track_array.AppendPrikeyValue(2, (_mod__PhoneNumberTypeID && _started_with_dbvalues) ? _ori__PhoneNumberTypeID : _cur__PhoneNumberTypeID);
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
				if (_mod__PhoneNumber) _ori__PhoneNumber = default(string);
				if (_mod__PhoneNumberTypeID) _ori__PhoneNumberTypeID = default(int);
				if (_mod__ModifiedDate) _ori__ModifiedDate = default(DateTime);
			}
			_mod__BusinessEntityID = false;
			_mod__PhoneNumber = false;
			_mod__PhoneNumberTypeID = false;
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
namespace ConsoleApp.VenturaAutoCreate
{
	public partial class PriKey_Person_PersonPhone_Record
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
