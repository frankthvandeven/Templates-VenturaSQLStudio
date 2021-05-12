/*
	Project file: "C:\Active\VenturaSQL\BuildSystem\Templates\Wpf_AspNetCore\Template.venproj"
	Target platform: NETStandard
	Generator version: 4.0.128
	Generated on: Wednesday, 12 May 2021 at 18:50:56
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
	/// The updateable table is [HumanResources].[Shift]. Updateable table column information:
	/// • 5 out of 5 table columns are present in the resultset.
	/// • All primary key columns are present in the resultset: ShiftID.
	/// • Non-primary key columns present in the resultset: Name, StartTime, EndTime and ModifiedDate.
	/// Recordset item automatically created by VenturaSQL Studio.
	/// </summary>
	public partial class GetAll_HumanResources_Shift_Recordset : ResultsetObservable<GetAll_HumanResources_Shift_Recordset, GetAll_HumanResources_Shift_Record>, IRecordsetBase
	{
		private IResultsetBase[] _resultsets;
		private string _sqlscript;
		private int _rowlimit = 500;
		private const string CRLF = "\r\n";

		public GetAll_HumanResources_Shift_Recordset()
		{
			_resultsets = new IResultsetBase[] { this };

			_sqlscript = @"SELECT TOP(@RowLimit) [ShiftID],[Name],[StartTime],[EndTime],[ModifiedDate]" + CRLF +
			             @"FROM [HumanResources].[Shift]";

			ColumnArrayBuilder schema_array = new ColumnArrayBuilder();

			schema_array.Add(new VenturaSqlColumn("ShiftID", typeof(byte), false)
			{
				ColumnSize = 1,
				NumericPrecision = 3,
				ProviderType = 20,
				IsKey = true,
				IsIdentity = true,
				IsAutoIncrement = true,
				BaseSchemaName = "HumanResources",
				BaseTableName = "Shift",
				BaseColumnName = "ShiftID"
			});

			schema_array.Add(new VenturaSqlColumn("Name", typeof(string), false)
			{
				Updateable = true,
				ColumnSize = 50,
				ProviderType = 12,
				BaseSchemaName = "HumanResources",
				BaseTableName = "Shift",
				BaseColumnName = "Name"
			});

			schema_array.Add(new VenturaSqlColumn("StartTime", typeof(TimeSpan), false)
			{
				Updateable = true,
				ColumnSize = 5,
				NumericScale = 7,
				ProviderType = 32,
				BaseSchemaName = "HumanResources",
				BaseTableName = "Shift",
				BaseColumnName = "StartTime"
			});

			schema_array.Add(new VenturaSqlColumn("EndTime", typeof(TimeSpan), false)
			{
				Updateable = true,
				ColumnSize = 5,
				NumericScale = 7,
				ProviderType = 32,
				BaseSchemaName = "HumanResources",
				BaseTableName = "Shift",
				BaseColumnName = "EndTime"
			});

			schema_array.Add(new VenturaSqlColumn("ModifiedDate", typeof(DateTime), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 23,
				NumericScale = 3,
				ProviderType = 4,
				BaseSchemaName = "HumanResources",
				BaseTableName = "Shift",
				BaseColumnName = "ModifiedDate"
			});

			((IResultsetBase)this).Schema = new VenturaSqlSchema(schema_array);
			((IResultsetBase)this).UpdateableTablename = "[HumanResources].[Shift]";
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [HumanResources].[Shift]. PrimaryKey. NotReadonly. NotNull. IsIdentity. AutoIncrement.
		/// </summary>
		public byte ShiftID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ShiftID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ShiftID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[Shift]. NotReadonly. NotNull.
		/// </summary>
		public string Name
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Name; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Name = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[Shift]. NotReadonly. NotNull.
		/// </summary>
		public TimeSpan StartTime
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.StartTime; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.StartTime = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[Shift]. NotReadonly. NotNull.
		/// </summary>
		public TimeSpan EndTime
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.EndTime; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.EndTime = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[Shift]. NotReadonly. NotNull.
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
			this.InsertItem(index, new GetAll_HumanResources_Shift_Record());
			this.CurrentRecordIndex = index;
		}

		public void Append(GetAll_HumanResources_Shift_Record record)
		{
			int index = this.RecordCount;
			this.InsertItem(index, record);
			this.CurrentRecordIndex = index;
		}

		public GetAll_HumanResources_Shift_Record NewRecord()
		{
			return new GetAll_HumanResources_Shift_Record();
		}

		protected override GetAll_HumanResources_Shift_Record InternalCreateExistingRecordObject(object[] columnvalues) => new GetAll_HumanResources_Shift_Record(columnvalues);

		byte[] IRecordsetBase.Hash
		{
			get { return new byte[] { 94, 27, 40, 143, 62, 101, 207, 188, 113, 186, 242, 88, 25, 172, 213, 207 }; }
		}

		string IRecordsetBase.HashString
		{
			get { return "5E1B288F3E65CFBC71BAF25819ACD5CF"; }
		}

		VenturaSqlPlatform IRecordsetBase.GeneratorTarget
		{
			get { return VenturaSqlPlatform.NETStandard; }
		}

		Version IRecordsetBase.GeneratorVersion
		{
			get { return new Version(4,0,128); }
		}

		DateTime IRecordsetBase.GeneratorTimestamp
		{
			get { return new DateTime(2021, 5, 12, 18, 50, 56); } // Wednesday, 12 May 2021 at 18:50:56
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

	public sealed partial class GetAll_HumanResources_Shift_Record : IRecordBase, INotifyPropertyChanged
	{
		private DataRecordStatus _recordstatus;
		private bool _started_with_dbvalues;

		private byte _cur__ShiftID; private byte _ori__ShiftID; private bool _mod__ShiftID;
		private string _cur__Name; private string _ori__Name; private bool _mod__Name;
		private TimeSpan _cur__StartTime; private TimeSpan _ori__StartTime; private bool _mod__StartTime;
		private TimeSpan _cur__EndTime; private TimeSpan _ori__EndTime; private bool _mod__EndTime;
		private DateTime _cur__ModifiedDate; private DateTime _ori__ModifiedDate; private bool _mod__ModifiedDate;


		public GetAll_HumanResources_Shift_Record()
		{
			_cur__ShiftID = 0;
			_cur__Name = "";
			_cur__StartTime = new TimeSpan(0);
			_cur__EndTime = new TimeSpan(0);
			_cur__ModifiedDate = new DateTime(1900, 1, 1);
			_started_with_dbvalues = false;
			_recordstatus = DataRecordStatus.New;
		}

		public GetAll_HumanResources_Shift_Record(object[] columnvalues)
		{
			_cur__ShiftID = (byte)columnvalues[0];
			_cur__Name = (string)columnvalues[1];
			_cur__StartTime = (TimeSpan)columnvalues[2];
			_cur__EndTime = (TimeSpan)columnvalues[3];
			_cur__ModifiedDate = (DateTime)columnvalues[4];
			_started_with_dbvalues = true;
			_recordstatus = DataRecordStatus.Existing;
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [HumanResources].[Shift]. PrimaryKey. NotReadonly. NotNull. IsIdentity. AutoIncrement.
		/// </summary>
		public byte ShiftID
		{
			get { return _cur__ShiftID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ShiftID = true;
				if (_cur__ShiftID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ShiftID == false) { _ori__ShiftID = _cur__ShiftID; _mod__ShiftID = true; } // existing record and column is not modified
					else { if (value == _ori__ShiftID) { _ori__ShiftID = default(byte); _mod__ShiftID = false; } } // existing record and column is modified
				}
				_cur__ShiftID = value; OnPropertyChanged("ShiftID"); OnAfterPropertyChanged("ShiftID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[Shift]. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [HumanResources].[Shift]. NotReadonly. NotNull.
		/// </summary>
		public TimeSpan StartTime
		{
			get { return _cur__StartTime; }
			set
			{
				if (_started_with_dbvalues == false) _mod__StartTime = true;
				if (_cur__StartTime == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__StartTime == false) { _ori__StartTime = _cur__StartTime; _mod__StartTime = true; } // existing record and column is not modified
					else { if (value == _ori__StartTime) { _ori__StartTime = default(TimeSpan); _mod__StartTime = false; } } // existing record and column is modified
				}
				_cur__StartTime = value; OnPropertyChanged("StartTime"); OnAfterPropertyChanged("StartTime");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[Shift]. NotReadonly. NotNull.
		/// </summary>
		public TimeSpan EndTime
		{
			get { return _cur__EndTime; }
			set
			{
				if (_started_with_dbvalues == false) _mod__EndTime = true;
				if (_cur__EndTime == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__EndTime == false) { _ori__EndTime = _cur__EndTime; _mod__EndTime = true; } // existing record and column is not modified
					else { if (value == _ori__EndTime) { _ori__EndTime = default(TimeSpan); _mod__EndTime = false; } } // existing record and column is modified
				}
				_cur__EndTime = value; OnPropertyChanged("EndTime"); OnAfterPropertyChanged("EndTime");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[Shift]. NotReadonly. NotNull.
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
			if (column_name == "ShiftID") return _mod__ShiftID;
			if (column_name == "Name") return _mod__Name;
			if (column_name == "StartTime") return _mod__StartTime;
			if (column_name == "EndTime") return _mod__EndTime;
			if (column_name == "ModifiedDate") return _mod__ModifiedDate;
			throw new ArgumentOutOfRangeException(String.Format(VenturaSqlStrings.UNKNOWN_COLUMN_NAME, column_name));
		}

		public int ModifiedColumnCount()
		{
			int count = 0;
			if (_mod__ShiftID == true) count++;
			if (_mod__Name == true) count++;
			if (_mod__StartTime == true) count++;
			if (_mod__EndTime == true) count++;
			if (_mod__ModifiedDate == true) count++;
			return count;
		}

		public bool PendingChanges()
		{
			if (_recordstatus == DataRecordStatus.New || _recordstatus == DataRecordStatus.ExistingDelete) return true;
			int count = 0;
			if (_mod__Name == true) count++;
			if (_mod__StartTime == true) count++;
			if (_mod__EndTime == true) count++;
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
				track_array.AppendDataValue(2, _cur__StartTime);
				track_array.AppendDataValue(3, _cur__EndTime);
				track_array.AppendDataValue(4, _cur__ModifiedDate);
			}
			else if (_recordstatus == DataRecordStatus.Existing)
			{
				if (_mod__Name) track_array.AppendDataValue(1, _cur__Name);
				if (_mod__StartTime) track_array.AppendDataValue(2, _cur__StartTime);
				if (_mod__EndTime) track_array.AppendDataValue(3, _cur__EndTime);
				if (_mod__ModifiedDate) track_array.AppendDataValue(4, _cur__ModifiedDate);
				if (track_array.HasData == false) return;
			}

			if (_recordstatus == DataRecordStatus.Existing || _recordstatus == DataRecordStatus.ExistingDelete)
			{
				track_array.AppendPrikeyValue(0, (_mod__ShiftID && _started_with_dbvalues) ? _ori__ShiftID : _cur__ShiftID);
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
				if (_mod__ShiftID) _ori__ShiftID = default(byte);
				if (_mod__Name) _ori__Name = default(string);
				if (_mod__StartTime) _ori__StartTime = default(TimeSpan);
				if (_mod__EndTime) _ori__EndTime = default(TimeSpan);
				if (_mod__ModifiedDate) _ori__ModifiedDate = default(DateTime);
			}
			_mod__ShiftID = false;
			_mod__Name = false;
			_mod__StartTime = false;
			_mod__EndTime = false;
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
			_cur__ShiftID = (byte)value;
			OnPropertyChanged("ShiftID");
			OnAfterPropertyChanged("ShiftID");
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
	public partial class GetAll_HumanResources_Shift_Record
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
