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
	/// The updateable table is [HumanResources].[EmployeeDepartmentHistory]. Updateable table column information:
	/// • 6 out of 6 table columns are present in the resultset.
	/// • All primary key columns are present in the resultset: BusinessEntityID, DepartmentID, ShiftID and StartDate.
	/// • Non-primary key columns present in the resultset: EndDate and ModifiedDate.
	/// Recordset item automatically created by VenturaSQL Studio.
	/// </summary>
	public partial class GetAll_HumanResources_EmployeeDepartmentHistory_Recordset : ResultsetObservable<GetAll_HumanResources_EmployeeDepartmentHistory_Recordset, GetAll_HumanResources_EmployeeDepartmentHistory_Record>, IRecordsetBase
	{
		private IResultsetBase[] _resultsets;
		private string _sqlscript;
		private int _rowlimit = 500;
		private const string CRLF = "\r\n";

		public GetAll_HumanResources_EmployeeDepartmentHistory_Recordset()
		{
			_resultsets = new IResultsetBase[] { this };

			_sqlscript = @"SELECT TOP(@RowLimit) [BusinessEntityID],[DepartmentID],[ShiftID],[StartDate],[EndDate],[ModifiedDate]" + CRLF +
			             @"FROM [HumanResources].[EmployeeDepartmentHistory]";

			ColumnArrayBuilder schema_array = new ColumnArrayBuilder();

			schema_array.Add(new VenturaSqlColumn("BusinessEntityID", typeof(int), false)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				IsKey = true,
				BaseSchemaName = "HumanResources",
				BaseTableName = "EmployeeDepartmentHistory",
				BaseColumnName = "BusinessEntityID"
			});

			schema_array.Add(new VenturaSqlColumn("DepartmentID", typeof(short), false)
			{
				Updateable = true,
				ColumnSize = 2,
				NumericPrecision = 5,
				ProviderType = 16,
				IsKey = true,
				BaseSchemaName = "HumanResources",
				BaseTableName = "EmployeeDepartmentHistory",
				BaseColumnName = "DepartmentID"
			});

			schema_array.Add(new VenturaSqlColumn("ShiftID", typeof(byte), false)
			{
				Updateable = true,
				ColumnSize = 1,
				NumericPrecision = 3,
				ProviderType = 20,
				IsKey = true,
				BaseSchemaName = "HumanResources",
				BaseTableName = "EmployeeDepartmentHistory",
				BaseColumnName = "ShiftID"
			});

			schema_array.Add(new VenturaSqlColumn("StartDate", typeof(DateTime), false)
			{
				Updateable = true,
				ColumnSize = 3,
				ProviderType = 31,
				IsKey = true,
				BaseSchemaName = "HumanResources",
				BaseTableName = "EmployeeDepartmentHistory",
				BaseColumnName = "StartDate"
			});

			schema_array.Add(new VenturaSqlColumn("EndDate", typeof(DateTime), true)
			{
				Updateable = true,
				ColumnSize = 3,
				ProviderType = 31,
				BaseSchemaName = "HumanResources",
				BaseTableName = "EmployeeDepartmentHistory",
				BaseColumnName = "EndDate"
			});

			schema_array.Add(new VenturaSqlColumn("ModifiedDate", typeof(DateTime), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 23,
				NumericScale = 3,
				ProviderType = 4,
				BaseSchemaName = "HumanResources",
				BaseTableName = "EmployeeDepartmentHistory",
				BaseColumnName = "ModifiedDate"
			});

			((IResultsetBase)this).Schema = new VenturaSqlSchema(schema_array);
			((IResultsetBase)this).UpdateableTablename = "[HumanResources].[EmployeeDepartmentHistory]";
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[EmployeeDepartmentHistory]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public int BusinessEntityID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.BusinessEntityID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.BusinessEntityID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[EmployeeDepartmentHistory]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public short DepartmentID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.DepartmentID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.DepartmentID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[EmployeeDepartmentHistory]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public byte ShiftID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ShiftID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ShiftID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[EmployeeDepartmentHistory]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public DateTime StartDate
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.StartDate; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.StartDate = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[EmployeeDepartmentHistory]. NotReadonly. AllowNull.
		/// </summary>
		public DateTime? EndDate
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.EndDate; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.EndDate = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[EmployeeDepartmentHistory]. NotReadonly. NotNull.
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
			this.InsertItem(index, new GetAll_HumanResources_EmployeeDepartmentHistory_Record());
			this.CurrentRecordIndex = index;
		}

		public void Append(GetAll_HumanResources_EmployeeDepartmentHistory_Record record)
		{
			int index = this.RecordCount;
			this.InsertItem(index, record);
			this.CurrentRecordIndex = index;
		}

		public GetAll_HumanResources_EmployeeDepartmentHistory_Record NewRecord()
		{
			return new GetAll_HumanResources_EmployeeDepartmentHistory_Record();
		}

		protected override GetAll_HumanResources_EmployeeDepartmentHistory_Record InternalCreateExistingRecordObject(object[] columnvalues) => new GetAll_HumanResources_EmployeeDepartmentHistory_Record(columnvalues);

		byte[] IRecordsetBase.Hash
		{
			get { return new byte[] { 131, 112, 65, 141, 2, 12, 123, 180, 196, 118, 193, 71, 191, 50, 39, 82 }; }
		}

		string IRecordsetBase.HashString
		{
			get { return "8370418D020C7BB4C476C147BF322752"; }
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

	public sealed partial class GetAll_HumanResources_EmployeeDepartmentHistory_Record : IRecordBase, INotifyPropertyChanged
	{
		private DataRecordStatus _recordstatus;
		private bool _started_with_dbvalues;

		private int _cur__BusinessEntityID; private int _ori__BusinessEntityID; private bool _mod__BusinessEntityID;
		private short _cur__DepartmentID; private short _ori__DepartmentID; private bool _mod__DepartmentID;
		private byte _cur__ShiftID; private byte _ori__ShiftID; private bool _mod__ShiftID;
		private DateTime _cur__StartDate; private DateTime _ori__StartDate; private bool _mod__StartDate;
		private DateTime? _cur__EndDate; private DateTime? _ori__EndDate; private bool _mod__EndDate;
		private DateTime _cur__ModifiedDate; private DateTime _ori__ModifiedDate; private bool _mod__ModifiedDate;


		public GetAll_HumanResources_EmployeeDepartmentHistory_Record()
		{
			_cur__BusinessEntityID = 0;
			_cur__DepartmentID = 0;
			_cur__ShiftID = 0;
			_cur__StartDate = new DateTime(1900, 1, 1);
			_cur__EndDate = null;
			_cur__ModifiedDate = new DateTime(1900, 1, 1);
			_started_with_dbvalues = false;
			_recordstatus = DataRecordStatus.New;
		}

		public GetAll_HumanResources_EmployeeDepartmentHistory_Record(object[] columnvalues)
		{
			_cur__BusinessEntityID = (int)columnvalues[0];
			_cur__DepartmentID = (short)columnvalues[1];
			_cur__ShiftID = (byte)columnvalues[2];
			_cur__StartDate = (DateTime)columnvalues[3];
			_cur__EndDate = (DateTime?)columnvalues[4];
			_cur__ModifiedDate = (DateTime)columnvalues[5];
			_started_with_dbvalues = true;
			_recordstatus = DataRecordStatus.Existing;
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[EmployeeDepartmentHistory]. PrimaryKey. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [HumanResources].[EmployeeDepartmentHistory]. PrimaryKey. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [HumanResources].[EmployeeDepartmentHistory]. PrimaryKey. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [HumanResources].[EmployeeDepartmentHistory]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public DateTime StartDate
		{
			get { return _cur__StartDate; }
			set
			{
				if (_started_with_dbvalues == false) _mod__StartDate = true;
				if (_cur__StartDate == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__StartDate == false) { _ori__StartDate = _cur__StartDate; _mod__StartDate = true; } // existing record and column is not modified
					else { if (value == _ori__StartDate) { _ori__StartDate = default(DateTime); _mod__StartDate = false; } } // existing record and column is modified
				}
				_cur__StartDate = value; OnPropertyChanged("StartDate"); OnAfterPropertyChanged("StartDate");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[EmployeeDepartmentHistory]. NotReadonly. AllowNull.
		/// </summary>
		public DateTime? EndDate
		{
			get { return _cur__EndDate; }
			set
			{
				if (_started_with_dbvalues == false) _mod__EndDate = true;
				if (_cur__EndDate == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__EndDate == false) { _ori__EndDate = _cur__EndDate; _mod__EndDate = true; } // existing record and column is not modified
					else { if (value == _ori__EndDate) { _ori__EndDate = default(DateTime?); _mod__EndDate = false; } } // existing record and column is modified
				}
				_cur__EndDate = value; OnPropertyChanged("EndDate"); OnAfterPropertyChanged("EndDate");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[EmployeeDepartmentHistory]. NotReadonly. NotNull.
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
			if (column_name == "DepartmentID") return _mod__DepartmentID;
			if (column_name == "ShiftID") return _mod__ShiftID;
			if (column_name == "StartDate") return _mod__StartDate;
			if (column_name == "EndDate") return _mod__EndDate;
			if (column_name == "ModifiedDate") return _mod__ModifiedDate;
			throw new ArgumentOutOfRangeException(String.Format(VenturaSqlStrings.UNKNOWN_COLUMN_NAME, column_name));
		}

		public int ModifiedColumnCount()
		{
			int count = 0;
			if (_mod__BusinessEntityID == true) count++;
			if (_mod__DepartmentID == true) count++;
			if (_mod__ShiftID == true) count++;
			if (_mod__StartDate == true) count++;
			if (_mod__EndDate == true) count++;
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
				if (_mod__DepartmentID) count++;
				if (_mod__ShiftID) count++;
				if (_mod__StartDate) count++;
			}
			if (_mod__EndDate == true) count++;
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
			if (_mod__DepartmentID == false) throw new Exception(string.Format(VenturaSqlStrings.VALUE_NOT_SET_MSG, record_index_to_display, "DepartmentID"));
			if (_mod__ShiftID == false) throw new Exception(string.Format(VenturaSqlStrings.VALUE_NOT_SET_MSG, record_index_to_display, "ShiftID"));
			if (_mod__StartDate == false) throw new Exception(string.Format(VenturaSqlStrings.VALUE_NOT_SET_MSG, record_index_to_display, "StartDate"));
		}

		void IRecordBase.WriteChangesToTrackArray(TrackArray track_array)
		{
			if (_recordstatus == DataRecordStatus.New)
			{
				track_array.AppendDataValue(0, _cur__BusinessEntityID);
				track_array.AppendDataValue(1, _cur__DepartmentID);
				track_array.AppendDataValue(2, _cur__ShiftID);
				track_array.AppendDataValue(3, _cur__StartDate);
				if (_cur__EndDate != null) track_array.AppendDataValue(4, _cur__EndDate);
				track_array.AppendDataValue(5, _cur__ModifiedDate);
			}
			else if (_recordstatus == DataRecordStatus.Existing)
			{
				if (_started_with_dbvalues)
				{
					if (_mod__BusinessEntityID) track_array.AppendDataValue(0, _cur__BusinessEntityID);
					if (_mod__DepartmentID) track_array.AppendDataValue(1, _cur__DepartmentID);
					if (_mod__ShiftID) track_array.AppendDataValue(2, _cur__ShiftID);
					if (_mod__StartDate) track_array.AppendDataValue(3, _cur__StartDate);
				}
				if (_mod__EndDate) track_array.AppendDataValue(4, _cur__EndDate);
				if (_mod__ModifiedDate) track_array.AppendDataValue(5, _cur__ModifiedDate);
				if (track_array.HasData == false) return;
			}

			if (_recordstatus == DataRecordStatus.Existing || _recordstatus == DataRecordStatus.ExistingDelete)
			{
				track_array.AppendPrikeyValue(0, (_mod__BusinessEntityID && _started_with_dbvalues) ? _ori__BusinessEntityID : _cur__BusinessEntityID);
				track_array.AppendPrikeyValue(1, (_mod__DepartmentID && _started_with_dbvalues) ? _ori__DepartmentID : _cur__DepartmentID);
				track_array.AppendPrikeyValue(2, (_mod__ShiftID && _started_with_dbvalues) ? _ori__ShiftID : _cur__ShiftID);
				track_array.AppendPrikeyValue(3, (_mod__StartDate && _started_with_dbvalues) ? _ori__StartDate : _cur__StartDate);
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
				if (_mod__DepartmentID) _ori__DepartmentID = default(short);
				if (_mod__ShiftID) _ori__ShiftID = default(byte);
				if (_mod__StartDate) _ori__StartDate = default(DateTime);
				if (_mod__EndDate) _ori__EndDate = default(DateTime?);
				if (_mod__ModifiedDate) _ori__ModifiedDate = default(DateTime);
			}
			_mod__BusinessEntityID = false;
			_mod__DepartmentID = false;
			_mod__ShiftID = false;
			_mod__StartDate = false;
			_mod__EndDate = false;
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
	public partial class GetAll_HumanResources_EmployeeDepartmentHistory_Record
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
