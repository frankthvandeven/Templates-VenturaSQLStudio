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
	/// The updateable table is [HumanResources].[Department]. Updateable table column information:
	/// • 4 out of 4 table columns are present in the resultset.
	/// • All primary key columns are present in the resultset: DepartmentID.
	/// • Non-primary key columns present in the resultset: Name, GroupName and ModifiedDate.
	/// Recordset item automatically created by VenturaSQL Studio.
	/// </summary>
	public partial class GetAll_HumanResources_Department_Recordset : ResultsetObservable<GetAll_HumanResources_Department_Recordset, GetAll_HumanResources_Department_Record>, IRecordsetBase
	{
		private IResultsetBase[] _resultsets;
		private string _sqlscript;
		private int _rowlimit = 500;
		private const string CRLF = "\r\n";

		public GetAll_HumanResources_Department_Recordset()
		{
			_resultsets = new IResultsetBase[] { this };

			_sqlscript = @"SELECT TOP(@RowLimit) [DepartmentID],[Name],[GroupName],[ModifiedDate]" + CRLF +
			             @"FROM [HumanResources].[Department]";

			ColumnArrayBuilder schema_array = new ColumnArrayBuilder();

			schema_array.Add(new VenturaSqlColumn("DepartmentID", typeof(short), false)
			{
				ColumnSize = 2,
				NumericPrecision = 5,
				ProviderType = 16,
				IsKey = true,
				IsIdentity = true,
				IsAutoIncrement = true,
				BaseSchemaName = "HumanResources",
				BaseTableName = "Department",
				BaseColumnName = "DepartmentID"
			});

			schema_array.Add(new VenturaSqlColumn("Name", typeof(string), false)
			{
				Updateable = true,
				ColumnSize = 50,
				ProviderType = 12,
				BaseSchemaName = "HumanResources",
				BaseTableName = "Department",
				BaseColumnName = "Name"
			});

			schema_array.Add(new VenturaSqlColumn("GroupName", typeof(string), false)
			{
				Updateable = true,
				ColumnSize = 50,
				ProviderType = 12,
				BaseSchemaName = "HumanResources",
				BaseTableName = "Department",
				BaseColumnName = "GroupName"
			});

			schema_array.Add(new VenturaSqlColumn("ModifiedDate", typeof(DateTime), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 23,
				NumericScale = 3,
				ProviderType = 4,
				BaseSchemaName = "HumanResources",
				BaseTableName = "Department",
				BaseColumnName = "ModifiedDate"
			});

			((IResultsetBase)this).Schema = new VenturaSqlSchema(schema_array);
			((IResultsetBase)this).UpdateableTablename = "[HumanResources].[Department]";
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [HumanResources].[Department]. PrimaryKey. NotReadonly. NotNull. IsIdentity. AutoIncrement.
		/// </summary>
		public short DepartmentID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.DepartmentID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.DepartmentID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[Department]. NotReadonly. NotNull.
		/// </summary>
		public string Name
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Name; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Name = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[Department]. NotReadonly. NotNull.
		/// </summary>
		public string GroupName
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.GroupName; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.GroupName = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[Department]. NotReadonly. NotNull.
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
			this.InsertItem(index, new GetAll_HumanResources_Department_Record());
			this.CurrentRecordIndex = index;
		}

		public void Append(GetAll_HumanResources_Department_Record record)
		{
			int index = this.RecordCount;
			this.InsertItem(index, record);
			this.CurrentRecordIndex = index;
		}

		public GetAll_HumanResources_Department_Record NewRecord()
		{
			return new GetAll_HumanResources_Department_Record();
		}

		protected override GetAll_HumanResources_Department_Record InternalCreateExistingRecordObject(object[] columnvalues) => new GetAll_HumanResources_Department_Record(columnvalues);

		byte[] IRecordsetBase.Hash
		{
			get { return new byte[] { 57, 205, 122, 178, 122, 82, 143, 251, 58, 11, 98, 154, 43, 152, 60, 96 }; }
		}

		string IRecordsetBase.HashString
		{
			get { return "39CD7AB27A528FFB3A0B629A2B983C60"; }
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

	public sealed partial class GetAll_HumanResources_Department_Record : IRecordBase, INotifyPropertyChanged
	{
		private DataRecordStatus _recordstatus;
		private bool _started_with_dbvalues;

		private short _cur__DepartmentID; private short _ori__DepartmentID; private bool _mod__DepartmentID;
		private string _cur__Name; private string _ori__Name; private bool _mod__Name;
		private string _cur__GroupName; private string _ori__GroupName; private bool _mod__GroupName;
		private DateTime _cur__ModifiedDate; private DateTime _ori__ModifiedDate; private bool _mod__ModifiedDate;


		public GetAll_HumanResources_Department_Record()
		{
			_cur__DepartmentID = 0;
			_cur__Name = "";
			_cur__GroupName = "";
			_cur__ModifiedDate = new DateTime(1900, 1, 1);
			_started_with_dbvalues = false;
			_recordstatus = DataRecordStatus.New;
		}

		public GetAll_HumanResources_Department_Record(object[] columnvalues)
		{
			_cur__DepartmentID = (short)columnvalues[0];
			_cur__Name = (string)columnvalues[1];
			_cur__GroupName = (string)columnvalues[2];
			_cur__ModifiedDate = (DateTime)columnvalues[3];
			_started_with_dbvalues = true;
			_recordstatus = DataRecordStatus.Existing;
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [HumanResources].[Department]. PrimaryKey. NotReadonly. NotNull. IsIdentity. AutoIncrement.
		/// </summary>
		public short DepartmentID
		{
			get { return _cur__DepartmentID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__DepartmentID = true;
				if (_cur__DepartmentID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__DepartmentID == false) { _ori__DepartmentID = _cur__DepartmentID; _mod__DepartmentID = true; } // existing record and column is not modified
					else { if (value == _ori__DepartmentID) { _ori__DepartmentID = default(short); _mod__DepartmentID = false; } } // existing record and column is modified
				}
				_cur__DepartmentID = value; OnPropertyChanged("DepartmentID"); OnAfterPropertyChanged("DepartmentID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[Department]. NotReadonly. NotNull.
		/// </summary>
		public string Name
		{
			get { return _cur__Name; }
			set
			{
				if (value == null) throw new ArgumentNullException("Name", VenturaSqlStrings.SET_NULL_MSG);
				if (_started_with_dbvalues == false) _mod__Name = true;
				if (_cur__Name == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Name == false) { _ori__Name = _cur__Name; _mod__Name = true; } // existing record and column is not modified
					else { if (value == _ori__Name) { _ori__Name = default(string); _mod__Name = false; } } // existing record and column is modified
				}
				_cur__Name = value; OnPropertyChanged("Name"); OnAfterPropertyChanged("Name");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[Department]. NotReadonly. NotNull.
		/// </summary>
		public string GroupName
		{
			get { return _cur__GroupName; }
			set
			{
				if (value == null) throw new ArgumentNullException("GroupName", VenturaSqlStrings.SET_NULL_MSG);
				if (_started_with_dbvalues == false) _mod__GroupName = true;
				if (_cur__GroupName == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__GroupName == false) { _ori__GroupName = _cur__GroupName; _mod__GroupName = true; } // existing record and column is not modified
					else { if (value == _ori__GroupName) { _ori__GroupName = default(string); _mod__GroupName = false; } } // existing record and column is modified
				}
				_cur__GroupName = value; OnPropertyChanged("GroupName"); OnAfterPropertyChanged("GroupName");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[Department]. NotReadonly. NotNull.
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
			if (column_name == "DepartmentID") return _mod__DepartmentID;
			if (column_name == "Name") return _mod__Name;
			if (column_name == "GroupName") return _mod__GroupName;
			if (column_name == "ModifiedDate") return _mod__ModifiedDate;
			throw new ArgumentOutOfRangeException(String.Format(VenturaSqlStrings.UNKNOWN_COLUMN_NAME, column_name));
		}

		public int ModifiedColumnCount()
		{
			int count = 0;
			if (_mod__DepartmentID == true) count++;
			if (_mod__Name == true) count++;
			if (_mod__GroupName == true) count++;
			if (_mod__ModifiedDate == true) count++;
			return count;
		}

		public bool PendingChanges()
		{
			if (_recordstatus == DataRecordStatus.New || _recordstatus == DataRecordStatus.ExistingDelete) return true;
			int count = 0;
			if (_mod__Name == true) count++;
			if (_mod__GroupName == true) count++;
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
		}

		void IRecordBase.WriteChangesToTrackArray(TrackArray track_array)
		{
			if (_recordstatus == DataRecordStatus.New)
			{
				track_array.AppendDataValue(1, _cur__Name);
				track_array.AppendDataValue(2, _cur__GroupName);
				track_array.AppendDataValue(3, _cur__ModifiedDate);
			}
			else if (_recordstatus == DataRecordStatus.Existing)
			{
				if (_mod__Name) track_array.AppendDataValue(1, _cur__Name);
				if (_mod__GroupName) track_array.AppendDataValue(2, _cur__GroupName);
				if (_mod__ModifiedDate) track_array.AppendDataValue(3, _cur__ModifiedDate);
				if (track_array.HasData == false) return;
			}

			if (_recordstatus == DataRecordStatus.Existing || _recordstatus == DataRecordStatus.ExistingDelete)
			{
				track_array.AppendPrikeyValue(0, (_mod__DepartmentID && _started_with_dbvalues) ? _ori__DepartmentID : _cur__DepartmentID);
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
				if (_mod__DepartmentID) _ori__DepartmentID = default(short);
				if (_mod__Name) _ori__Name = default(string);
				if (_mod__GroupName) _ori__GroupName = default(string);
				if (_mod__ModifiedDate) _ori__ModifiedDate = default(DateTime);
			}
			_mod__DepartmentID = false;
			_mod__Name = false;
			_mod__GroupName = false;
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
			_cur__DepartmentID = (short)value;
			OnPropertyChanged("DepartmentID");
			OnAfterPropertyChanged("DepartmentID");
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
	public partial class GetAll_HumanResources_Department_Record
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
