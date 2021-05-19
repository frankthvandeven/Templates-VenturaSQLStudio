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
	/// The updateable table is [Sales].[SalesTaxRate]. Updateable table column information:
	/// • 7 out of 7 table columns are present in the resultset.
	/// • All primary key columns are present in the resultset: SalesTaxRateID.
	/// • Non-primary key columns present in the resultset: StateProvinceID, TaxType, TaxRate, Name, rowguid and ModifiedDate.
	/// Recordset item automatically created by VenturaSQL Studio.
	/// </summary>
	public partial class GetAll_Sales_SalesTaxRate_Recordset : ResultsetObservable<GetAll_Sales_SalesTaxRate_Recordset, GetAll_Sales_SalesTaxRate_Record>, IRecordsetBase
	{
		private IResultsetBase[] _resultsets;
		private string _sqlscript;
		private int _rowlimit = 500;
		private const string CRLF = "\r\n";

		public GetAll_Sales_SalesTaxRate_Recordset()
		{
			_resultsets = new IResultsetBase[] { this };

			_sqlscript = @"SELECT TOP(@RowLimit) [SalesTaxRateID],[StateProvinceID],[TaxType],[TaxRate],[Name],[rowguid],[ModifiedDate]" + CRLF +
			             @"FROM [Sales].[SalesTaxRate]";

			ColumnArrayBuilder schema_array = new ColumnArrayBuilder();

			schema_array.Add(new VenturaSqlColumn("SalesTaxRateID", typeof(int), false)
			{
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				IsKey = true,
				IsIdentity = true,
				IsAutoIncrement = true,
				BaseSchemaName = "Sales",
				BaseTableName = "SalesTaxRate",
				BaseColumnName = "SalesTaxRateID"
			});

			schema_array.Add(new VenturaSqlColumn("StateProvinceID", typeof(int), false)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				BaseSchemaName = "Sales",
				BaseTableName = "SalesTaxRate",
				BaseColumnName = "StateProvinceID"
			});

			schema_array.Add(new VenturaSqlColumn("TaxType", typeof(byte), false)
			{
				Updateable = true,
				ColumnSize = 1,
				NumericPrecision = 3,
				ProviderType = 20,
				BaseSchemaName = "Sales",
				BaseTableName = "SalesTaxRate",
				BaseColumnName = "TaxType"
			});

			schema_array.Add(new VenturaSqlColumn("TaxRate", typeof(decimal), false)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 17,
				BaseSchemaName = "Sales",
				BaseTableName = "SalesTaxRate",
				BaseColumnName = "TaxRate"
			});

			schema_array.Add(new VenturaSqlColumn("Name", typeof(string), false)
			{
				Updateable = true,
				ColumnSize = 50,
				ProviderType = 12,
				BaseSchemaName = "Sales",
				BaseTableName = "SalesTaxRate",
				BaseColumnName = "Name"
			});

			schema_array.Add(new VenturaSqlColumn("rowguid", typeof(Guid), false)
			{
				Updateable = true,
				ColumnSize = 16,
				ProviderType = 14,
				BaseSchemaName = "Sales",
				BaseTableName = "SalesTaxRate",
				BaseColumnName = "rowguid"
			});

			schema_array.Add(new VenturaSqlColumn("ModifiedDate", typeof(DateTime), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 23,
				NumericScale = 3,
				ProviderType = 4,
				BaseSchemaName = "Sales",
				BaseTableName = "SalesTaxRate",
				BaseColumnName = "ModifiedDate"
			});

			((IResultsetBase)this).Schema = new VenturaSqlSchema(schema_array);
			((IResultsetBase)this).UpdateableTablename = "[Sales].[SalesTaxRate]";
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Sales].[SalesTaxRate]. PrimaryKey. NotReadonly. NotNull. IsIdentity. AutoIncrement.
		/// </summary>
		public int SalesTaxRateID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.SalesTaxRateID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.SalesTaxRateID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesTaxRate]. NotReadonly. NotNull.
		/// </summary>
		public int StateProvinceID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.StateProvinceID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.StateProvinceID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesTaxRate]. NotReadonly. NotNull.
		/// </summary>
		public byte TaxType
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.TaxType; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.TaxType = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesTaxRate]. NotReadonly. NotNull.
		/// </summary>
		public decimal TaxRate
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.TaxRate; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.TaxRate = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesTaxRate]. NotReadonly. NotNull.
		/// </summary>
		public string Name
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Name; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Name = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesTaxRate]. NotReadonly. NotNull.
		/// </summary>
		public Guid rowguid
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.rowguid; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.rowguid = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesTaxRate]. NotReadonly. NotNull.
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
			this.InsertItem(index, new GetAll_Sales_SalesTaxRate_Record());
			this.CurrentRecordIndex = index;
		}

		public void Append(GetAll_Sales_SalesTaxRate_Record record)
		{
			int index = this.RecordCount;
			this.InsertItem(index, record);
			this.CurrentRecordIndex = index;
		}

		public GetAll_Sales_SalesTaxRate_Record NewRecord()
		{
			return new GetAll_Sales_SalesTaxRate_Record();
		}

		protected override GetAll_Sales_SalesTaxRate_Record InternalCreateExistingRecordObject(object[] columnvalues) => new GetAll_Sales_SalesTaxRate_Record(columnvalues);

		byte[] IRecordsetBase.Hash
		{
			get { return new byte[] { 142, 168, 119, 221, 163, 235, 9, 26, 151, 161, 103, 104, 2, 103, 78, 107 }; }
		}

		string IRecordsetBase.HashString
		{
			get { return "8EA877DDA3EB091A97A1676802674E6B"; }
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

	public sealed partial class GetAll_Sales_SalesTaxRate_Record : IRecordBase, INotifyPropertyChanged
	{
		private DataRecordStatus _recordstatus;
		private bool _started_with_dbvalues;

		private int _cur__SalesTaxRateID; private int _ori__SalesTaxRateID; private bool _mod__SalesTaxRateID;
		private int _cur__StateProvinceID; private int _ori__StateProvinceID; private bool _mod__StateProvinceID;
		private byte _cur__TaxType; private byte _ori__TaxType; private bool _mod__TaxType;
		private decimal _cur__TaxRate; private decimal _ori__TaxRate; private bool _mod__TaxRate;
		private string _cur__Name; private string _ori__Name; private bool _mod__Name;
		private Guid _cur__rowguid; private Guid _ori__rowguid; private bool _mod__rowguid;
		private DateTime _cur__ModifiedDate; private DateTime _ori__ModifiedDate; private bool _mod__ModifiedDate;


		public GetAll_Sales_SalesTaxRate_Record()
		{
			_cur__SalesTaxRateID = 0;
			_cur__StateProvinceID = 0;
			_cur__TaxType = 0;
			_cur__TaxRate = 0.0m;
			_cur__Name = "";
			_cur__rowguid = Guid.Empty;
			_cur__ModifiedDate = new DateTime(1900, 1, 1);
			_started_with_dbvalues = false;
			_recordstatus = DataRecordStatus.New;
		}

		public GetAll_Sales_SalesTaxRate_Record(object[] columnvalues)
		{
			_cur__SalesTaxRateID = (int)columnvalues[0];
			_cur__StateProvinceID = (int)columnvalues[1];
			_cur__TaxType = (byte)columnvalues[2];
			_cur__TaxRate = (decimal)columnvalues[3];
			_cur__Name = (string)columnvalues[4];
			_cur__rowguid = (Guid)columnvalues[5];
			_cur__ModifiedDate = (DateTime)columnvalues[6];
			_started_with_dbvalues = true;
			_recordstatus = DataRecordStatus.Existing;
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Sales].[SalesTaxRate]. PrimaryKey. NotReadonly. NotNull. IsIdentity. AutoIncrement.
		/// </summary>
		public int SalesTaxRateID
		{
			get { return _cur__SalesTaxRateID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__SalesTaxRateID = true;
				if (_cur__SalesTaxRateID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__SalesTaxRateID == false) { _ori__SalesTaxRateID = _cur__SalesTaxRateID; _mod__SalesTaxRateID = true; } // existing record and column is not modified
					else { if (value == _ori__SalesTaxRateID) { _ori__SalesTaxRateID = default(int); _mod__SalesTaxRateID = false; } } // existing record and column is modified
				}
				_cur__SalesTaxRateID = value; OnPropertyChanged("SalesTaxRateID"); OnAfterPropertyChanged("SalesTaxRateID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesTaxRate]. NotReadonly. NotNull.
		/// </summary>
		public int StateProvinceID
		{
			get { return _cur__StateProvinceID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__StateProvinceID = true;
				if (_cur__StateProvinceID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__StateProvinceID == false) { _ori__StateProvinceID = _cur__StateProvinceID; _mod__StateProvinceID = true; } // existing record and column is not modified
					else { if (value == _ori__StateProvinceID) { _ori__StateProvinceID = default(int); _mod__StateProvinceID = false; } } // existing record and column is modified
				}
				_cur__StateProvinceID = value; OnPropertyChanged("StateProvinceID"); OnAfterPropertyChanged("StateProvinceID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesTaxRate]. NotReadonly. NotNull.
		/// </summary>
		public byte TaxType
		{
			get { return _cur__TaxType; }
			set
			{
				if (_started_with_dbvalues == false) _mod__TaxType = true;
				if (_cur__TaxType == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__TaxType == false) { _ori__TaxType = _cur__TaxType; _mod__TaxType = true; } // existing record and column is not modified
					else { if (value == _ori__TaxType) { _ori__TaxType = default(byte); _mod__TaxType = false; } } // existing record and column is modified
				}
				_cur__TaxType = value; OnPropertyChanged("TaxType"); OnAfterPropertyChanged("TaxType");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesTaxRate]. NotReadonly. NotNull.
		/// </summary>
		public decimal TaxRate
		{
			get { return _cur__TaxRate; }
			set
			{
				if (_started_with_dbvalues == false) _mod__TaxRate = true;
				if (_cur__TaxRate == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__TaxRate == false) { _ori__TaxRate = _cur__TaxRate; _mod__TaxRate = true; } // existing record and column is not modified
					else { if (value == _ori__TaxRate) { _ori__TaxRate = default(decimal); _mod__TaxRate = false; } } // existing record and column is modified
				}
				_cur__TaxRate = value; OnPropertyChanged("TaxRate"); OnAfterPropertyChanged("TaxRate");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesTaxRate]. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [Sales].[SalesTaxRate]. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [Sales].[SalesTaxRate]. NotReadonly. NotNull.
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
			if (column_name == "SalesTaxRateID") return _mod__SalesTaxRateID;
			if (column_name == "StateProvinceID") return _mod__StateProvinceID;
			if (column_name == "TaxType") return _mod__TaxType;
			if (column_name == "TaxRate") return _mod__TaxRate;
			if (column_name == "Name") return _mod__Name;
			if (column_name == "rowguid") return _mod__rowguid;
			if (column_name == "ModifiedDate") return _mod__ModifiedDate;
			throw new ArgumentOutOfRangeException(String.Format(VenturaSqlStrings.UNKNOWN_COLUMN_NAME, column_name));
		}

		public int ModifiedColumnCount()
		{
			int count = 0;
			if (_mod__SalesTaxRateID == true) count++;
			if (_mod__StateProvinceID == true) count++;
			if (_mod__TaxType == true) count++;
			if (_mod__TaxRate == true) count++;
			if (_mod__Name == true) count++;
			if (_mod__rowguid == true) count++;
			if (_mod__ModifiedDate == true) count++;
			return count;
		}

		public bool PendingChanges()
		{
			if (_recordstatus == DataRecordStatus.New || _recordstatus == DataRecordStatus.ExistingDelete) return true;
			int count = 0;
			if (_mod__StateProvinceID == true) count++;
			if (_mod__TaxType == true) count++;
			if (_mod__TaxRate == true) count++;
			if (_mod__Name == true) count++;
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
				track_array.AppendDataValue(1, _cur__StateProvinceID);
				track_array.AppendDataValue(2, _cur__TaxType);
				track_array.AppendDataValue(3, _cur__TaxRate);
				track_array.AppendDataValue(4, _cur__Name);
				track_array.AppendDataValue(5, _cur__rowguid);
				track_array.AppendDataValue(6, _cur__ModifiedDate);
			}
			else if (_recordstatus == DataRecordStatus.Existing)
			{
				if (_mod__StateProvinceID) track_array.AppendDataValue(1, _cur__StateProvinceID);
				if (_mod__TaxType) track_array.AppendDataValue(2, _cur__TaxType);
				if (_mod__TaxRate) track_array.AppendDataValue(3, _cur__TaxRate);
				if (_mod__Name) track_array.AppendDataValue(4, _cur__Name);
				if (_mod__rowguid) track_array.AppendDataValue(5, _cur__rowguid);
				if (_mod__ModifiedDate) track_array.AppendDataValue(6, _cur__ModifiedDate);
				if (track_array.HasData == false) return;
			}

			if (_recordstatus == DataRecordStatus.Existing || _recordstatus == DataRecordStatus.ExistingDelete)
			{
				track_array.AppendPrikeyValue(0, (_mod__SalesTaxRateID && _started_with_dbvalues) ? _ori__SalesTaxRateID : _cur__SalesTaxRateID);
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
				if (_mod__SalesTaxRateID) _ori__SalesTaxRateID = default(int);
				if (_mod__StateProvinceID) _ori__StateProvinceID = default(int);
				if (_mod__TaxType) _ori__TaxType = default(byte);
				if (_mod__TaxRate) _ori__TaxRate = default(decimal);
				if (_mod__Name) _ori__Name = default(string);
				if (_mod__rowguid) _ori__rowguid = default(Guid);
				if (_mod__ModifiedDate) _ori__ModifiedDate = default(DateTime);
			}
			_mod__SalesTaxRateID = false;
			_mod__StateProvinceID = false;
			_mod__TaxType = false;
			_mod__TaxRate = false;
			_mod__Name = false;
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
			_cur__SalesTaxRateID = (int)value;
			OnPropertyChanged("SalesTaxRateID");
			OnAfterPropertyChanged("SalesTaxRateID");
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
	public partial class GetAll_Sales_SalesTaxRate_Record
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
