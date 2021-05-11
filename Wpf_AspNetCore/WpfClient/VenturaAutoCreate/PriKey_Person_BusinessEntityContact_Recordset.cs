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

namespace WpfClient.VenturaAutoCreate
{
	/// <summary>
	/// The updateable table is [Person].[BusinessEntityContact]. Updateable table column information:
	/// • 5 out of 5 table columns are present in the resultset.
	/// • All primary key columns are present in the resultset: BusinessEntityID, PersonID and ContactTypeID.
	/// • Non-primary key columns present in the resultset: rowguid and ModifiedDate.
	/// Recordset item automatically created by VenturaSQL Studio.
	/// </summary>
	public partial class PriKey_Person_BusinessEntityContact_Recordset : ResultsetObservable<PriKey_Person_BusinessEntityContact_Recordset, PriKey_Person_BusinessEntityContact_Record>, IRecordsetBase
	{
		private IResultsetBase[] _resultsets;
		private string _sqlscript;
		private object[] _inputparametervalues;
		private InputParamHolder _inputparamholder;
		private VenturaSqlSchema _parameterschema;
		private int _rowlimit = 500;
		private const string CRLF = "\r\n";

		public PriKey_Person_BusinessEntityContact_Recordset()
		{
			_resultsets = new IResultsetBase[] { this };

			_sqlscript = @"SELECT [BusinessEntityID],[PersonID],[ContactTypeID],[rowguid],[ModifiedDate]" + CRLF +
			             @"FROM [Person].[BusinessEntityContact]" + CRLF +
			             @"WHERE [BusinessEntityID] = @BusinessEntityID" + CRLF +
			             @"AND [PersonID] = @PersonID" + CRLF +
			             @"AND [ContactTypeID] = @ContactTypeID";

			_inputparametervalues = new object[3];
			_inputparamholder = new InputParamHolder(_inputparametervalues);

			ColumnArrayBuilder param_array = new ColumnArrayBuilder();

			param_array.AddParameterColumn("@BusinessEntityID", typeof(int), true, false, DbType.Int32, null, null, null);
			param_array.AddParameterColumn("@PersonID", typeof(int), true, false, DbType.Int32, null, null, null);
			param_array.AddParameterColumn("@ContactTypeID", typeof(int), true, false, DbType.Int32, null, null, null);

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
				BaseTableName = "BusinessEntityContact",
				BaseColumnName = "BusinessEntityID"
			});

			schema_array.Add(new VenturaSqlColumn("PersonID", typeof(int), false)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				IsKey = true,
				BaseSchemaName = "Person",
				BaseTableName = "BusinessEntityContact",
				BaseColumnName = "PersonID"
			});

			schema_array.Add(new VenturaSqlColumn("ContactTypeID", typeof(int), false)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				IsKey = true,
				BaseSchemaName = "Person",
				BaseTableName = "BusinessEntityContact",
				BaseColumnName = "ContactTypeID"
			});

			schema_array.Add(new VenturaSqlColumn("rowguid", typeof(Guid), false)
			{
				Updateable = true,
				ColumnSize = 16,
				ProviderType = 14,
				BaseSchemaName = "Person",
				BaseTableName = "BusinessEntityContact",
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
				BaseTableName = "BusinessEntityContact",
				BaseColumnName = "ModifiedDate"
			});

			((IResultsetBase)this).Schema = new VenturaSqlSchema(schema_array);
			((IResultsetBase)this).UpdateableTablename = "[Person].[BusinessEntityContact]";
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[BusinessEntityContact]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public int BusinessEntityID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.BusinessEntityID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.BusinessEntityID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[BusinessEntityContact]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public int PersonID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.PersonID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.PersonID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[BusinessEntityContact]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public int ContactTypeID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ContactTypeID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ContactTypeID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[BusinessEntityContact]. NotReadonly. NotNull.
		/// </summary>
		public Guid rowguid
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.rowguid; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.rowguid = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[BusinessEntityContact]. NotReadonly. NotNull.
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
			this.InsertItem(index, new PriKey_Person_BusinessEntityContact_Record());
			this.CurrentRecordIndex = index;
		}

		public void Append(PriKey_Person_BusinessEntityContact_Record record)
		{
			int index = this.RecordCount;
			this.InsertItem(index, record);
			this.CurrentRecordIndex = index;
		}

		public PriKey_Person_BusinessEntityContact_Record NewRecord()
		{
			return new PriKey_Person_BusinessEntityContact_Record();
		}

		protected override PriKey_Person_BusinessEntityContact_Record InternalCreateExistingRecordObject(object[] columnvalues) => new PriKey_Person_BusinessEntityContact_Record(columnvalues);

		byte[] IRecordsetBase.Hash
		{
			get { return new byte[] { 243, 138, 21, 213, 87, 76, 61, 205, 58, 153, 175, 35, 10, 53, 10, 225 }; }
		}

		string IRecordsetBase.HashString
		{
			get { return "F38A15D5574C3DCD3A99AF230A350AE1"; }
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

		public void SetExecSqlParams(int? BusinessEntityID, int? PersonID, int? ContactTypeID)
		{
			_inputparametervalues[0] = BusinessEntityID;
			_inputparametervalues[1] = PersonID;
			_inputparametervalues[2] = ContactTypeID;
		}

		public void ExecSql(int? BusinessEntityID, int? PersonID, int? ContactTypeID)
		{
			_inputparametervalues[0] = BusinessEntityID;
			_inputparametervalues[1] = PersonID;
			_inputparametervalues[2] = ContactTypeID;
			Transactional.ExecSql(VenturaSqlConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public void ExecSql(Connector connector, int? BusinessEntityID, int? PersonID, int? ContactTypeID)
		{
			_inputparametervalues[0] = BusinessEntityID;
			_inputparametervalues[1] = PersonID;
			_inputparametervalues[2] = ContactTypeID;
			Transactional.ExecSql(connector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync(int? BusinessEntityID, int? PersonID, int? ContactTypeID)
		{
			_inputparametervalues[0] = BusinessEntityID;
			_inputparametervalues[1] = PersonID;
			_inputparametervalues[2] = ContactTypeID;
			await Transactional.ExecSqlAsync(VenturaSqlConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync(Connector connector, int? BusinessEntityID, int? PersonID, int? ContactTypeID)
		{
			_inputparametervalues[0] = BusinessEntityID;
			_inputparametervalues[1] = PersonID;
			_inputparametervalues[2] = ContactTypeID;
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

			public int? PersonID
			{
				get { return (int?)_values[1]; }
				set { _values[1] = value; }
			}

			public int? ContactTypeID
			{
				get { return (int?)_values[2]; }
				set { _values[2] = value; }
			}

		}

	}

	public sealed partial class PriKey_Person_BusinessEntityContact_Record : IRecordBase, INotifyPropertyChanged
	{
		private DataRecordStatus _recordstatus;
		private bool _started_with_dbvalues;

		private int _cur__BusinessEntityID; private int _ori__BusinessEntityID; private bool _mod__BusinessEntityID;
		private int _cur__PersonID; private int _ori__PersonID; private bool _mod__PersonID;
		private int _cur__ContactTypeID; private int _ori__ContactTypeID; private bool _mod__ContactTypeID;
		private Guid _cur__rowguid; private Guid _ori__rowguid; private bool _mod__rowguid;
		private DateTime _cur__ModifiedDate; private DateTime _ori__ModifiedDate; private bool _mod__ModifiedDate;


		public PriKey_Person_BusinessEntityContact_Record()
		{
			_cur__BusinessEntityID = 0;
			_cur__PersonID = 0;
			_cur__ContactTypeID = 0;
			_cur__rowguid = Guid.Empty;
			_cur__ModifiedDate = new DateTime(1900, 1, 1);
			_started_with_dbvalues = false;
			_recordstatus = DataRecordStatus.New;
		}

		public PriKey_Person_BusinessEntityContact_Record(object[] columnvalues)
		{
			_cur__BusinessEntityID = (int)columnvalues[0];
			_cur__PersonID = (int)columnvalues[1];
			_cur__ContactTypeID = (int)columnvalues[2];
			_cur__rowguid = (Guid)columnvalues[3];
			_cur__ModifiedDate = (DateTime)columnvalues[4];
			_started_with_dbvalues = true;
			_recordstatus = DataRecordStatus.Existing;
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[BusinessEntityContact]. PrimaryKey. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [Person].[BusinessEntityContact]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public int PersonID
		{
			get { return _cur__PersonID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__PersonID = true;
				if (_cur__PersonID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__PersonID == false) { _ori__PersonID = _cur__PersonID; _mod__PersonID = true; } // existing record and column is not modified
					else { if (value == _ori__PersonID) { _ori__PersonID = default(int); _mod__PersonID = false; } } // existing record and column is modified
				}
				_cur__PersonID = value; OnPropertyChanged("PersonID"); OnAfterPropertyChanged("PersonID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[BusinessEntityContact]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public int ContactTypeID
		{
			get { return _cur__ContactTypeID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ContactTypeID = true;
				if (_cur__ContactTypeID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ContactTypeID == false) { _ori__ContactTypeID = _cur__ContactTypeID; _mod__ContactTypeID = true; } // existing record and column is not modified
					else { if (value == _ori__ContactTypeID) { _ori__ContactTypeID = default(int); _mod__ContactTypeID = false; } } // existing record and column is modified
				}
				_cur__ContactTypeID = value; OnPropertyChanged("ContactTypeID"); OnAfterPropertyChanged("ContactTypeID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[BusinessEntityContact]. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [Person].[BusinessEntityContact]. NotReadonly. NotNull.
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
			if (column_name == "PersonID") return _mod__PersonID;
			if (column_name == "ContactTypeID") return _mod__ContactTypeID;
			if (column_name == "rowguid") return _mod__rowguid;
			if (column_name == "ModifiedDate") return _mod__ModifiedDate;
			throw new ArgumentOutOfRangeException(String.Format(VenturaSqlStrings.UNKNOWN_COLUMN_NAME, column_name));
		}

		public int ModifiedColumnCount()
		{
			int count = 0;
			if (_mod__BusinessEntityID == true) count++;
			if (_mod__PersonID == true) count++;
			if (_mod__ContactTypeID == true) count++;
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
				if (_mod__PersonID) count++;
				if (_mod__ContactTypeID) count++;
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
			if (_mod__PersonID == false) throw new Exception(string.Format(VenturaSqlStrings.VALUE_NOT_SET_MSG, record_index_to_display, "PersonID"));
			if (_mod__ContactTypeID == false) throw new Exception(string.Format(VenturaSqlStrings.VALUE_NOT_SET_MSG, record_index_to_display, "ContactTypeID"));
		}

		void IRecordBase.WriteChangesToTrackArray(TrackArray track_array)
		{
			if (_recordstatus == DataRecordStatus.New)
			{
				track_array.AppendDataValue(0, _cur__BusinessEntityID);
				track_array.AppendDataValue(1, _cur__PersonID);
				track_array.AppendDataValue(2, _cur__ContactTypeID);
				track_array.AppendDataValue(3, _cur__rowguid);
				track_array.AppendDataValue(4, _cur__ModifiedDate);
			}
			else if (_recordstatus == DataRecordStatus.Existing)
			{
				if (_started_with_dbvalues)
				{
					if (_mod__BusinessEntityID) track_array.AppendDataValue(0, _cur__BusinessEntityID);
					if (_mod__PersonID) track_array.AppendDataValue(1, _cur__PersonID);
					if (_mod__ContactTypeID) track_array.AppendDataValue(2, _cur__ContactTypeID);
				}
				if (_mod__rowguid) track_array.AppendDataValue(3, _cur__rowguid);
				if (_mod__ModifiedDate) track_array.AppendDataValue(4, _cur__ModifiedDate);
				if (track_array.HasData == false) return;
			}

			if (_recordstatus == DataRecordStatus.Existing || _recordstatus == DataRecordStatus.ExistingDelete)
			{
				track_array.AppendPrikeyValue(0, (_mod__BusinessEntityID && _started_with_dbvalues) ? _ori__BusinessEntityID : _cur__BusinessEntityID);
				track_array.AppendPrikeyValue(1, (_mod__PersonID && _started_with_dbvalues) ? _ori__PersonID : _cur__PersonID);
				track_array.AppendPrikeyValue(2, (_mod__ContactTypeID && _started_with_dbvalues) ? _ori__ContactTypeID : _cur__ContactTypeID);
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
				if (_mod__PersonID) _ori__PersonID = default(int);
				if (_mod__ContactTypeID) _ori__ContactTypeID = default(int);
				if (_mod__rowguid) _ori__rowguid = default(Guid);
				if (_mod__ModifiedDate) _ori__ModifiedDate = default(DateTime);
			}
			_mod__BusinessEntityID = false;
			_mod__PersonID = false;
			_mod__ContactTypeID = false;
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
namespace WpfClient.VenturaAutoCreate
{
	public partial class PriKey_Person_BusinessEntityContact_Record
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
