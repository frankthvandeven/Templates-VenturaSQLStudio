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

namespace AspNetCoreServer.VenturaAutoCreate
{
	/// <summary>
	/// The updateable table is [Person].[EmailAddress]. Updateable table column information:
	/// • 5 out of 5 table columns are present in the resultset.
	/// • All primary key columns are present in the resultset: BusinessEntityID and EmailAddressID.
	/// • Non-primary key columns present in the resultset: EmailAddress, rowguid and ModifiedDate.
	/// Recordset item automatically created by VenturaSQL Studio.
	/// </summary>
	public partial class GetAll_Person_EmailAddress_Recordset : ResultsetObservable<GetAll_Person_EmailAddress_Recordset, GetAll_Person_EmailAddress_Record>, IRecordsetBase
	{
		private IResultsetBase[] _resultsets;
		private string _sqlscript;
		private int _rowlimit = 500;
		private const string CRLF = "\r\n";

		public GetAll_Person_EmailAddress_Recordset()
		{
			_resultsets = new IResultsetBase[] { this };

			_sqlscript = @"SELECT TOP(@RowLimit) [BusinessEntityID],[EmailAddressID],[EmailAddress],[rowguid],[ModifiedDate]" + CRLF +
			             @"FROM [Person].[EmailAddress]";

			ColumnArrayBuilder schema_array = new ColumnArrayBuilder();

			schema_array.Add(new VenturaSqlColumn("BusinessEntityID", typeof(int), false)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				IsKey = true,
				BaseSchemaName = "Person",
				BaseTableName = "EmailAddress",
				BaseColumnName = "BusinessEntityID"
			});

			schema_array.Add(new VenturaSqlColumn("EmailAddressID", typeof(int), false)
			{
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				IsKey = true,
				IsIdentity = true,
				IsAutoIncrement = true,
				BaseSchemaName = "Person",
				BaseTableName = "EmailAddress",
				BaseColumnName = "EmailAddressID"
			});

			schema_array.Add(new VenturaSqlColumn("EmailAddress", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 50,
				ProviderType = 12,
				BaseSchemaName = "Person",
				BaseTableName = "EmailAddress",
				BaseColumnName = "EmailAddress"
			});

			schema_array.Add(new VenturaSqlColumn("rowguid", typeof(Guid), false)
			{
				Updateable = true,
				ColumnSize = 16,
				ProviderType = 14,
				BaseSchemaName = "Person",
				BaseTableName = "EmailAddress",
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
				BaseTableName = "EmailAddress",
				BaseColumnName = "ModifiedDate"
			});

			((IResultsetBase)this).Schema = new VenturaSqlSchema(schema_array);
			((IResultsetBase)this).UpdateableTablename = "[Person].[EmailAddress]";
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[EmailAddress]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public int BusinessEntityID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.BusinessEntityID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.BusinessEntityID = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Person].[EmailAddress]. PrimaryKey. NotReadonly. NotNull. IsIdentity. AutoIncrement.
		/// </summary>
		public int EmailAddressID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.EmailAddressID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.EmailAddressID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[EmailAddress]. NotReadonly. AllowNull.
		/// </summary>
		public string EmailAddress
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.EmailAddress; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.EmailAddress = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[EmailAddress]. NotReadonly. NotNull.
		/// </summary>
		public Guid rowguid
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.rowguid; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.rowguid = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[EmailAddress]. NotReadonly. NotNull.
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
			this.InsertItem(index, new GetAll_Person_EmailAddress_Record());
			this.CurrentRecordIndex = index;
		}

		public void Append(GetAll_Person_EmailAddress_Record record)
		{
			int index = this.RecordCount;
			this.InsertItem(index, record);
			this.CurrentRecordIndex = index;
		}

		public GetAll_Person_EmailAddress_Record NewRecord()
		{
			return new GetAll_Person_EmailAddress_Record();
		}

		protected override GetAll_Person_EmailAddress_Record InternalCreateExistingRecordObject(object[] columnvalues) => new GetAll_Person_EmailAddress_Record(columnvalues);

		byte[] IRecordsetBase.Hash
		{
			get { return new byte[] { 232, 105, 10, 156, 30, 211, 194, 96, 194, 237, 45, 97, 87, 130, 5, 5 }; }
		}

		string IRecordsetBase.HashString
		{
			get { return "E8690A9C1ED3C260C2ED2D6157820505"; }
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
			get { return null; }
		}

		/// <summary>
		/// For internal use by VenturaSQL only. Use SetExecSqlParams() instead.
		/// </summary>
		object[] IRecordsetBase.InputParameterValues
		{
			get { return null; }
		}

		/// <summary>
		/// For internal use by VenturaSQL only. Use Output property instead.
		/// </summary>
		object[] IRecordsetBase.OutputParameterValues
		{
			get { return null; }
		}

		public int RowLimit
		{
			get { return _rowlimit; }
			set { _rowlimit = value; }
		}

		public void ExecSql()
		{
			Transactional.ExecSql(VenturaSqlConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public void ExecSql(Connector connector)
		{
			Transactional.ExecSql(connector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync()
		{
			await Transactional.ExecSqlAsync(VenturaSqlConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync(Connector connector)
		{
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

	}

	public sealed partial class GetAll_Person_EmailAddress_Record : IRecordBase, INotifyPropertyChanged
	{
		private DataRecordStatus _recordstatus;
		private bool _started_with_dbvalues;

		private int _cur__BusinessEntityID; private int _ori__BusinessEntityID; private bool _mod__BusinessEntityID;
		private int _cur__EmailAddressID; private int _ori__EmailAddressID; private bool _mod__EmailAddressID;
		private string _cur__EmailAddress; private string _ori__EmailAddress; private bool _mod__EmailAddress;
		private Guid _cur__rowguid; private Guid _ori__rowguid; private bool _mod__rowguid;
		private DateTime _cur__ModifiedDate; private DateTime _ori__ModifiedDate; private bool _mod__ModifiedDate;


		public GetAll_Person_EmailAddress_Record()
		{
			_cur__BusinessEntityID = 0;
			_cur__EmailAddressID = 0;
			_cur__EmailAddress = null;
			_cur__rowguid = Guid.Empty;
			_cur__ModifiedDate = new DateTime(1900, 1, 1);
			_started_with_dbvalues = false;
			_recordstatus = DataRecordStatus.New;
		}

		public GetAll_Person_EmailAddress_Record(object[] columnvalues)
		{
			_cur__BusinessEntityID = (int)columnvalues[0];
			_cur__EmailAddressID = (int)columnvalues[1];
			_cur__EmailAddress = (string)columnvalues[2];
			_cur__rowguid = (Guid)columnvalues[3];
			_cur__ModifiedDate = (DateTime)columnvalues[4];
			_started_with_dbvalues = true;
			_recordstatus = DataRecordStatus.Existing;
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[EmailAddress]. PrimaryKey. NotReadonly. NotNull.
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
		/// Database Column NotUpdateable. Table [Person].[EmailAddress]. PrimaryKey. NotReadonly. NotNull. IsIdentity. AutoIncrement.
		/// </summary>
		public int EmailAddressID
		{
			get { return _cur__EmailAddressID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__EmailAddressID = true;
				if (_cur__EmailAddressID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__EmailAddressID == false) { _ori__EmailAddressID = _cur__EmailAddressID; _mod__EmailAddressID = true; } // existing record and column is not modified
					else { if (value == _ori__EmailAddressID) { _ori__EmailAddressID = default(int); _mod__EmailAddressID = false; } } // existing record and column is modified
				}
				_cur__EmailAddressID = value; OnPropertyChanged("EmailAddressID"); OnAfterPropertyChanged("EmailAddressID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[EmailAddress]. NotReadonly. AllowNull.
		/// </summary>
		public string EmailAddress
		{
			get { return _cur__EmailAddress; }
			set
			{
				if (_started_with_dbvalues == false) _mod__EmailAddress = true;
				if (_cur__EmailAddress == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__EmailAddress == false) { _ori__EmailAddress = _cur__EmailAddress; _mod__EmailAddress = true; } // existing record and column is not modified
					else { if (value == _ori__EmailAddress) { _ori__EmailAddress = default(string); _mod__EmailAddress = false; } } // existing record and column is modified
				}
				_cur__EmailAddress = value; OnPropertyChanged("EmailAddress"); OnAfterPropertyChanged("EmailAddress");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[EmailAddress]. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [Person].[EmailAddress]. NotReadonly. NotNull.
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
			if (column_name == "EmailAddressID") return _mod__EmailAddressID;
			if (column_name == "EmailAddress") return _mod__EmailAddress;
			if (column_name == "rowguid") return _mod__rowguid;
			if (column_name == "ModifiedDate") return _mod__ModifiedDate;
			throw new ArgumentOutOfRangeException(String.Format(VenturaSqlStrings.UNKNOWN_COLUMN_NAME, column_name));
		}

		public int ModifiedColumnCount()
		{
			int count = 0;
			if (_mod__BusinessEntityID == true) count++;
			if (_mod__EmailAddressID == true) count++;
			if (_mod__EmailAddress == true) count++;
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
			}
			if (_mod__EmailAddress == true) count++;
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
		}

		void IRecordBase.WriteChangesToTrackArray(TrackArray track_array)
		{
			if (_recordstatus == DataRecordStatus.New)
			{
				track_array.AppendDataValue(0, _cur__BusinessEntityID);
				if (_cur__EmailAddress != null) track_array.AppendDataValue(2, _cur__EmailAddress);
				track_array.AppendDataValue(3, _cur__rowguid);
				track_array.AppendDataValue(4, _cur__ModifiedDate);
			}
			else if (_recordstatus == DataRecordStatus.Existing)
			{
				if (_started_with_dbvalues)
				{
					if (_mod__BusinessEntityID) track_array.AppendDataValue(0, _cur__BusinessEntityID);
				}
				if (_mod__EmailAddress) track_array.AppendDataValue(2, _cur__EmailAddress);
				if (_mod__rowguid) track_array.AppendDataValue(3, _cur__rowguid);
				if (_mod__ModifiedDate) track_array.AppendDataValue(4, _cur__ModifiedDate);
				if (track_array.HasData == false) return;
			}

			if (_recordstatus == DataRecordStatus.Existing || _recordstatus == DataRecordStatus.ExistingDelete)
			{
				track_array.AppendPrikeyValue(0, (_mod__BusinessEntityID && _started_with_dbvalues) ? _ori__BusinessEntityID : _cur__BusinessEntityID);
				track_array.AppendPrikeyValue(1, (_mod__EmailAddressID && _started_with_dbvalues) ? _ori__EmailAddressID : _cur__EmailAddressID);
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
				if (_mod__EmailAddressID) _ori__EmailAddressID = default(int);
				if (_mod__EmailAddress) _ori__EmailAddress = default(string);
				if (_mod__rowguid) _ori__rowguid = default(Guid);
				if (_mod__ModifiedDate) _ori__ModifiedDate = default(DateTime);
			}
			_mod__BusinessEntityID = false;
			_mod__EmailAddressID = false;
			_mod__EmailAddress = false;
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
			_cur__EmailAddressID = (int)value;
			OnPropertyChanged("EmailAddressID");
			OnAfterPropertyChanged("EmailAddressID");
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
	public partial class GetAll_Person_EmailAddress_Record
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
