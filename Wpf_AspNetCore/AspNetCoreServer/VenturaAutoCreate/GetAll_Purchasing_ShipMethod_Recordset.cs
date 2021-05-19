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
	/// The updateable table is [Purchasing].[ShipMethod]. Updateable table column information:
	/// • 6 out of 6 table columns are present in the resultset.
	/// • All primary key columns are present in the resultset: ShipMethodID.
	/// • Non-primary key columns present in the resultset: Name, ShipBase, ShipRate, rowguid and ModifiedDate.
	/// Recordset item automatically created by VenturaSQL Studio.
	/// </summary>
	public partial class GetAll_Purchasing_ShipMethod_Recordset : ResultsetObservable<GetAll_Purchasing_ShipMethod_Recordset, GetAll_Purchasing_ShipMethod_Record>, IRecordsetBase
	{
		private IResultsetBase[] _resultsets;
		private string _sqlscript;
		private int _rowlimit = 500;
		private const string CRLF = "\r\n";

		public GetAll_Purchasing_ShipMethod_Recordset()
		{
			_resultsets = new IResultsetBase[] { this };

			_sqlscript = @"SELECT TOP(@RowLimit) [ShipMethodID],[Name],[ShipBase],[ShipRate],[rowguid],[ModifiedDate]" + CRLF +
			             @"FROM [Purchasing].[ShipMethod]";

			ColumnArrayBuilder schema_array = new ColumnArrayBuilder();

			schema_array.Add(new VenturaSqlColumn("ShipMethodID", typeof(int), false)
			{
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				IsKey = true,
				IsIdentity = true,
				IsAutoIncrement = true,
				BaseSchemaName = "Purchasing",
				BaseTableName = "ShipMethod",
				BaseColumnName = "ShipMethodID"
			});

			schema_array.Add(new VenturaSqlColumn("Name", typeof(string), false)
			{
				Updateable = true,
				ColumnSize = 50,
				ProviderType = 12,
				BaseSchemaName = "Purchasing",
				BaseTableName = "ShipMethod",
				BaseColumnName = "Name"
			});

			schema_array.Add(new VenturaSqlColumn("ShipBase", typeof(decimal), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 19,
				ProviderType = 9,
				BaseSchemaName = "Purchasing",
				BaseTableName = "ShipMethod",
				BaseColumnName = "ShipBase"
			});

			schema_array.Add(new VenturaSqlColumn("ShipRate", typeof(decimal), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 19,
				ProviderType = 9,
				BaseSchemaName = "Purchasing",
				BaseTableName = "ShipMethod",
				BaseColumnName = "ShipRate"
			});

			schema_array.Add(new VenturaSqlColumn("rowguid", typeof(Guid), false)
			{
				Updateable = true,
				ColumnSize = 16,
				ProviderType = 14,
				BaseSchemaName = "Purchasing",
				BaseTableName = "ShipMethod",
				BaseColumnName = "rowguid"
			});

			schema_array.Add(new VenturaSqlColumn("ModifiedDate", typeof(DateTime), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 23,
				NumericScale = 3,
				ProviderType = 4,
				BaseSchemaName = "Purchasing",
				BaseTableName = "ShipMethod",
				BaseColumnName = "ModifiedDate"
			});

			((IResultsetBase)this).Schema = new VenturaSqlSchema(schema_array);
			((IResultsetBase)this).UpdateableTablename = "[Purchasing].[ShipMethod]";
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Purchasing].[ShipMethod]. PrimaryKey. NotReadonly. NotNull. IsIdentity. AutoIncrement.
		/// </summary>
		public int ShipMethodID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ShipMethodID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ShipMethodID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[ShipMethod]. NotReadonly. NotNull.
		/// </summary>
		public string Name
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Name; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Name = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[ShipMethod]. NotReadonly. NotNull.
		/// </summary>
		public decimal ShipBase
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ShipBase; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ShipBase = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[ShipMethod]. NotReadonly. NotNull.
		/// </summary>
		public decimal ShipRate
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ShipRate; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ShipRate = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[ShipMethod]. NotReadonly. NotNull.
		/// </summary>
		public Guid rowguid
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.rowguid; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.rowguid = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[ShipMethod]. NotReadonly. NotNull.
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
			this.InsertItem(index, new GetAll_Purchasing_ShipMethod_Record());
			this.CurrentRecordIndex = index;
		}

		public void Append(GetAll_Purchasing_ShipMethod_Record record)
		{
			int index = this.RecordCount;
			this.InsertItem(index, record);
			this.CurrentRecordIndex = index;
		}

		public GetAll_Purchasing_ShipMethod_Record NewRecord()
		{
			return new GetAll_Purchasing_ShipMethod_Record();
		}

		protected override GetAll_Purchasing_ShipMethod_Record InternalCreateExistingRecordObject(object[] columnvalues) => new GetAll_Purchasing_ShipMethod_Record(columnvalues);

		byte[] IRecordsetBase.Hash
		{
			get { return new byte[] { 56, 253, 149, 30, 1, 186, 94, 170, 127, 76, 22, 125, 189, 202, 17, 26 }; }
		}

		string IRecordsetBase.HashString
		{
			get { return "38FD951E01BA5EAA7F4C167DBDCA111A"; }
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

	public sealed partial class GetAll_Purchasing_ShipMethod_Record : IRecordBase, INotifyPropertyChanged
	{
		private DataRecordStatus _recordstatus;
		private bool _started_with_dbvalues;

		private int _cur__ShipMethodID; private int _ori__ShipMethodID; private bool _mod__ShipMethodID;
		private string _cur__Name; private string _ori__Name; private bool _mod__Name;
		private decimal _cur__ShipBase; private decimal _ori__ShipBase; private bool _mod__ShipBase;
		private decimal _cur__ShipRate; private decimal _ori__ShipRate; private bool _mod__ShipRate;
		private Guid _cur__rowguid; private Guid _ori__rowguid; private bool _mod__rowguid;
		private DateTime _cur__ModifiedDate; private DateTime _ori__ModifiedDate; private bool _mod__ModifiedDate;


		public GetAll_Purchasing_ShipMethod_Record()
		{
			_cur__ShipMethodID = 0;
			_cur__Name = "";
			_cur__ShipBase = 0.0m;
			_cur__ShipRate = 0.0m;
			_cur__rowguid = Guid.Empty;
			_cur__ModifiedDate = new DateTime(1900, 1, 1);
			_started_with_dbvalues = false;
			_recordstatus = DataRecordStatus.New;
		}

		public GetAll_Purchasing_ShipMethod_Record(object[] columnvalues)
		{
			_cur__ShipMethodID = (int)columnvalues[0];
			_cur__Name = (string)columnvalues[1];
			_cur__ShipBase = (decimal)columnvalues[2];
			_cur__ShipRate = (decimal)columnvalues[3];
			_cur__rowguid = (Guid)columnvalues[4];
			_cur__ModifiedDate = (DateTime)columnvalues[5];
			_started_with_dbvalues = true;
			_recordstatus = DataRecordStatus.Existing;
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Purchasing].[ShipMethod]. PrimaryKey. NotReadonly. NotNull. IsIdentity. AutoIncrement.
		/// </summary>
		public int ShipMethodID
		{
			get { return _cur__ShipMethodID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ShipMethodID = true;
				if (_cur__ShipMethodID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ShipMethodID == false) { _ori__ShipMethodID = _cur__ShipMethodID; _mod__ShipMethodID = true; } // existing record and column is not modified
					else { if (value == _ori__ShipMethodID) { _ori__ShipMethodID = default(int); _mod__ShipMethodID = false; } } // existing record and column is modified
				}
				_cur__ShipMethodID = value; OnPropertyChanged("ShipMethodID"); OnAfterPropertyChanged("ShipMethodID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[ShipMethod]. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [Purchasing].[ShipMethod]. NotReadonly. NotNull.
		/// </summary>
		public decimal ShipBase
		{
			get { return _cur__ShipBase; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ShipBase = true;
				if (_cur__ShipBase == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ShipBase == false) { _ori__ShipBase = _cur__ShipBase; _mod__ShipBase = true; } // existing record and column is not modified
					else { if (value == _ori__ShipBase) { _ori__ShipBase = default(decimal); _mod__ShipBase = false; } } // existing record and column is modified
				}
				_cur__ShipBase = value; OnPropertyChanged("ShipBase"); OnAfterPropertyChanged("ShipBase");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[ShipMethod]. NotReadonly. NotNull.
		/// </summary>
		public decimal ShipRate
		{
			get { return _cur__ShipRate; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ShipRate = true;
				if (_cur__ShipRate == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ShipRate == false) { _ori__ShipRate = _cur__ShipRate; _mod__ShipRate = true; } // existing record and column is not modified
					else { if (value == _ori__ShipRate) { _ori__ShipRate = default(decimal); _mod__ShipRate = false; } } // existing record and column is modified
				}
				_cur__ShipRate = value; OnPropertyChanged("ShipRate"); OnAfterPropertyChanged("ShipRate");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[ShipMethod]. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [Purchasing].[ShipMethod]. NotReadonly. NotNull.
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
			if (column_name == "ShipMethodID") return _mod__ShipMethodID;
			if (column_name == "Name") return _mod__Name;
			if (column_name == "ShipBase") return _mod__ShipBase;
			if (column_name == "ShipRate") return _mod__ShipRate;
			if (column_name == "rowguid") return _mod__rowguid;
			if (column_name == "ModifiedDate") return _mod__ModifiedDate;
			throw new ArgumentOutOfRangeException(String.Format(VenturaSqlStrings.UNKNOWN_COLUMN_NAME, column_name));
		}

		public int ModifiedColumnCount()
		{
			int count = 0;
			if (_mod__ShipMethodID == true) count++;
			if (_mod__Name == true) count++;
			if (_mod__ShipBase == true) count++;
			if (_mod__ShipRate == true) count++;
			if (_mod__rowguid == true) count++;
			if (_mod__ModifiedDate == true) count++;
			return count;
		}

		public bool PendingChanges()
		{
			if (_recordstatus == DataRecordStatus.New || _recordstatus == DataRecordStatus.ExistingDelete) return true;
			int count = 0;
			if (_mod__Name == true) count++;
			if (_mod__ShipBase == true) count++;
			if (_mod__ShipRate == true) count++;
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
		}

		void IRecordBase.WriteChangesToTrackArray(TrackArray track_array)
		{
			if (_recordstatus == DataRecordStatus.New)
			{
				track_array.AppendDataValue(1, _cur__Name);
				track_array.AppendDataValue(2, _cur__ShipBase);
				track_array.AppendDataValue(3, _cur__ShipRate);
				track_array.AppendDataValue(4, _cur__rowguid);
				track_array.AppendDataValue(5, _cur__ModifiedDate);
			}
			else if (_recordstatus == DataRecordStatus.Existing)
			{
				if (_mod__Name) track_array.AppendDataValue(1, _cur__Name);
				if (_mod__ShipBase) track_array.AppendDataValue(2, _cur__ShipBase);
				if (_mod__ShipRate) track_array.AppendDataValue(3, _cur__ShipRate);
				if (_mod__rowguid) track_array.AppendDataValue(4, _cur__rowguid);
				if (_mod__ModifiedDate) track_array.AppendDataValue(5, _cur__ModifiedDate);
				if (track_array.HasData == false) return;
			}

			if (_recordstatus == DataRecordStatus.Existing || _recordstatus == DataRecordStatus.ExistingDelete)
			{
				track_array.AppendPrikeyValue(0, (_mod__ShipMethodID && _started_with_dbvalues) ? _ori__ShipMethodID : _cur__ShipMethodID);
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
				if (_mod__ShipMethodID) _ori__ShipMethodID = default(int);
				if (_mod__Name) _ori__Name = default(string);
				if (_mod__ShipBase) _ori__ShipBase = default(decimal);
				if (_mod__ShipRate) _ori__ShipRate = default(decimal);
				if (_mod__rowguid) _ori__rowguid = default(Guid);
				if (_mod__ModifiedDate) _ori__ModifiedDate = default(DateTime);
			}
			_mod__ShipMethodID = false;
			_mod__Name = false;
			_mod__ShipBase = false;
			_mod__ShipRate = false;
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
			_cur__ShipMethodID = (int)value;
			OnPropertyChanged("ShipMethodID");
			OnAfterPropertyChanged("ShipMethodID");
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
	public partial class GetAll_Purchasing_ShipMethod_Record
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
