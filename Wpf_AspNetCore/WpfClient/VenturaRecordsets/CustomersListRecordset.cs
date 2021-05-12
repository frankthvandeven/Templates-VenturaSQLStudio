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

namespace WpfClient.VenturaRecordsets
{
	/// <summary>
	/// The resultset is read-only.
	/// </summary>
	public partial class CustomersListRecordset : ResultsetObservable<CustomersListRecordset, CustomersListRecord>, IRecordsetBase
	{
		private IResultsetBase[] _resultsets;
		private string _sqlscript;
		private int _rowlimit = 500;
		private const string CRLF = "\r\n";

		public CustomersListRecordset()
		{
			_resultsets = new IResultsetBase[] { this };

			_sqlscript = @"SELECT TOP (10) [CustomerID]" + CRLF +
			             @"      ,[PersonID]" + CRLF +
			             @"      ,[StoreID]" + CRLF +
			             @"      ,[TerritoryID]" + CRLF +
			             @"      ,[AccountNumber]" + CRLF +
			             @"      ,[rowguid]" + CRLF +
			             @"      ,[ModifiedDate]" + CRLF +
			             @"  FROM [Sales].[Customer]";

			ColumnArrayBuilder schema_array = new ColumnArrayBuilder();

			schema_array.Add(new VenturaSqlColumn("CustomerID", typeof(int), false)
			{
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				IsKey = true,
				IsIdentity = true,
				IsAutoIncrement = true,
				BaseSchemaName = "Sales",
				BaseTableName = "Customer",
				BaseColumnName = "CustomerID"
			});

			schema_array.Add(new VenturaSqlColumn("PersonID", typeof(int), true)
			{
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				BaseSchemaName = "Sales",
				BaseTableName = "Customer",
				BaseColumnName = "PersonID"
			});

			schema_array.Add(new VenturaSqlColumn("StoreID", typeof(int), true)
			{
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				BaseSchemaName = "Sales",
				BaseTableName = "Customer",
				BaseColumnName = "StoreID"
			});

			schema_array.Add(new VenturaSqlColumn("TerritoryID", typeof(int), true)
			{
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				BaseSchemaName = "Sales",
				BaseTableName = "Customer",
				BaseColumnName = "TerritoryID"
			});

			schema_array.Add(new VenturaSqlColumn("AccountNumber", typeof(string), false)
			{
				ColumnSize = 10,
				ProviderType = 22,
				BaseSchemaName = "Sales",
				BaseTableName = "Customer",
				BaseColumnName = "AccountNumber"
			});

			schema_array.Add(new VenturaSqlColumn("rowguid", typeof(Guid), false)
			{
				ColumnSize = 16,
				ProviderType = 14,
				BaseSchemaName = "Sales",
				BaseTableName = "Customer",
				BaseColumnName = "rowguid"
			});

			schema_array.Add(new VenturaSqlColumn("ModifiedDate", typeof(DateTime), false)
			{
				ColumnSize = 8,
				NumericPrecision = 23,
				NumericScale = 3,
				ProviderType = 4,
				BaseSchemaName = "Sales",
				BaseTableName = "Customer",
				BaseColumnName = "ModifiedDate"
			});

			((IResultsetBase)this).Schema = new VenturaSqlSchema(schema_array);
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Sales].[Customer]. PrimaryKey. NotReadonly. NotNull. IsIdentity. AutoIncrement.
		/// </summary>
		public int CustomerID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.CustomerID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.CustomerID = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Sales].[Customer]. NotReadonly. AllowNull.
		/// </summary>
		public int? PersonID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.PersonID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.PersonID = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Sales].[Customer]. NotReadonly. AllowNull.
		/// </summary>
		public int? StoreID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.StoreID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.StoreID = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Sales].[Customer]. NotReadonly. AllowNull.
		/// </summary>
		public int? TerritoryID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.TerritoryID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.TerritoryID = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Sales].[Customer]. NotReadonly. NotNull.
		/// </summary>
		public string AccountNumber
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.AccountNumber; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.AccountNumber = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Sales].[Customer]. NotReadonly. NotNull.
		/// </summary>
		public Guid rowguid
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.rowguid; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.rowguid = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Sales].[Customer]. NotReadonly. NotNull.
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
			this.InsertItem(index, new CustomersListRecord());
			this.CurrentRecordIndex = index;
		}

		public void Append(CustomersListRecord record)
		{
			int index = this.RecordCount;
			this.InsertItem(index, record);
			this.CurrentRecordIndex = index;
		}

		public CustomersListRecord NewRecord()
		{
			return new CustomersListRecord();
		}

		protected override CustomersListRecord InternalCreateExistingRecordObject(object[] columnvalues) => new CustomersListRecord(columnvalues);

		byte[] IRecordsetBase.Hash
		{
			get { return new byte[] { 39, 25, 100, 203, 212, 52, 57, 20, 224, 243, 1, 226, 71, 118, 222, 36 }; }
		}

		string IRecordsetBase.HashString
		{
			get { return "271964CBD4343914E0F301E24776DE24"; }
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

	}

	public sealed partial class CustomersListRecord : IRecordBase, INotifyPropertyChanged
	{
		private DataRecordStatus _recordstatus;
		private bool _started_with_dbvalues;

		private int _cur__CustomerID; private int _ori__CustomerID; private bool _mod__CustomerID;
		private int? _cur__PersonID; private int? _ori__PersonID; private bool _mod__PersonID;
		private int? _cur__StoreID; private int? _ori__StoreID; private bool _mod__StoreID;
		private int? _cur__TerritoryID; private int? _ori__TerritoryID; private bool _mod__TerritoryID;
		private string _cur__AccountNumber; private string _ori__AccountNumber; private bool _mod__AccountNumber;
		private Guid _cur__rowguid; private Guid _ori__rowguid; private bool _mod__rowguid;
		private DateTime _cur__ModifiedDate; private DateTime _ori__ModifiedDate; private bool _mod__ModifiedDate;


		public CustomersListRecord()
		{
			_cur__CustomerID = 0;
			_cur__PersonID = null;
			_cur__StoreID = null;
			_cur__TerritoryID = null;
			_cur__AccountNumber = "";
			_cur__rowguid = Guid.Empty;
			_cur__ModifiedDate = new DateTime(1900, 1, 1);
			_started_with_dbvalues = false;
			_recordstatus = DataRecordStatus.New;
		}

		public CustomersListRecord(object[] columnvalues)
		{
			_cur__CustomerID = (int)columnvalues[0];
			_cur__PersonID = (int?)columnvalues[1];
			_cur__StoreID = (int?)columnvalues[2];
			_cur__TerritoryID = (int?)columnvalues[3];
			_cur__AccountNumber = (string)columnvalues[4];
			_cur__rowguid = (Guid)columnvalues[5];
			_cur__ModifiedDate = (DateTime)columnvalues[6];
			_started_with_dbvalues = true;
			_recordstatus = DataRecordStatus.Existing;
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Sales].[Customer]. PrimaryKey. NotReadonly. NotNull. IsIdentity. AutoIncrement.
		/// </summary>
		public int CustomerID
		{
			get { return _cur__CustomerID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__CustomerID = true;
				if (_cur__CustomerID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__CustomerID == false) { _ori__CustomerID = _cur__CustomerID; _mod__CustomerID = true; } // existing record and column is not modified
					else { if (value == _ori__CustomerID) { _ori__CustomerID = default(int); _mod__CustomerID = false; } } // existing record and column is modified
				}
				_cur__CustomerID = value; OnPropertyChanged("CustomerID"); OnAfterPropertyChanged("CustomerID");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Sales].[Customer]. NotReadonly. AllowNull.
		/// </summary>
		public int? PersonID
		{
			get { return _cur__PersonID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__PersonID = true;
				if (_cur__PersonID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__PersonID == false) { _ori__PersonID = _cur__PersonID; _mod__PersonID = true; } // existing record and column is not modified
					else { if (value == _ori__PersonID) { _ori__PersonID = default(int?); _mod__PersonID = false; } } // existing record and column is modified
				}
				_cur__PersonID = value; OnPropertyChanged("PersonID"); OnAfterPropertyChanged("PersonID");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Sales].[Customer]. NotReadonly. AllowNull.
		/// </summary>
		public int? StoreID
		{
			get { return _cur__StoreID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__StoreID = true;
				if (_cur__StoreID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__StoreID == false) { _ori__StoreID = _cur__StoreID; _mod__StoreID = true; } // existing record and column is not modified
					else { if (value == _ori__StoreID) { _ori__StoreID = default(int?); _mod__StoreID = false; } } // existing record and column is modified
				}
				_cur__StoreID = value; OnPropertyChanged("StoreID"); OnAfterPropertyChanged("StoreID");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Sales].[Customer]. NotReadonly. AllowNull.
		/// </summary>
		public int? TerritoryID
		{
			get { return _cur__TerritoryID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__TerritoryID = true;
				if (_cur__TerritoryID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__TerritoryID == false) { _ori__TerritoryID = _cur__TerritoryID; _mod__TerritoryID = true; } // existing record and column is not modified
					else { if (value == _ori__TerritoryID) { _ori__TerritoryID = default(int?); _mod__TerritoryID = false; } } // existing record and column is modified
				}
				_cur__TerritoryID = value; OnPropertyChanged("TerritoryID"); OnAfterPropertyChanged("TerritoryID");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Sales].[Customer]. NotReadonly. NotNull.
		/// </summary>
		public string AccountNumber
		{
			get { return _cur__AccountNumber; }
			set
			{
				if (value == null) throw new ArgumentNullException("AccountNumber", VenturaSqlStrings.SET_NULL_MSG);
				if (_started_with_dbvalues == false) _mod__AccountNumber = true;
				if (_cur__AccountNumber == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__AccountNumber == false) { _ori__AccountNumber = _cur__AccountNumber; _mod__AccountNumber = true; } // existing record and column is not modified
					else { if (value == _ori__AccountNumber) { _ori__AccountNumber = default(string); _mod__AccountNumber = false; } } // existing record and column is modified
				}
				_cur__AccountNumber = value; OnPropertyChanged("AccountNumber"); OnAfterPropertyChanged("AccountNumber");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Sales].[Customer]. NotReadonly. NotNull.
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
		/// Database Column NotUpdateable. Table [Sales].[Customer]. NotReadonly. NotNull.
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
			if (column_name == "CustomerID") return _mod__CustomerID;
			if (column_name == "PersonID") return _mod__PersonID;
			if (column_name == "StoreID") return _mod__StoreID;
			if (column_name == "TerritoryID") return _mod__TerritoryID;
			if (column_name == "AccountNumber") return _mod__AccountNumber;
			if (column_name == "rowguid") return _mod__rowguid;
			if (column_name == "ModifiedDate") return _mod__ModifiedDate;
			throw new ArgumentOutOfRangeException(String.Format(VenturaSqlStrings.UNKNOWN_COLUMN_NAME, column_name));
		}

		public int ModifiedColumnCount()
		{
			int count = 0;
			if (_mod__CustomerID == true) count++;
			if (_mod__PersonID == true) count++;
			if (_mod__StoreID == true) count++;
			if (_mod__TerritoryID == true) count++;
			if (_mod__AccountNumber == true) count++;
			if (_mod__rowguid == true) count++;
			if (_mod__ModifiedDate == true) count++;
			return count;
		}

		public bool PendingChanges()
		{
			return false;
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
				if (_mod__CustomerID) _ori__CustomerID = default(int);
				if (_mod__PersonID) _ori__PersonID = default(int?);
				if (_mod__StoreID) _ori__StoreID = default(int?);
				if (_mod__TerritoryID) _ori__TerritoryID = default(int?);
				if (_mod__AccountNumber) _ori__AccountNumber = default(string);
				if (_mod__rowguid) _ori__rowguid = default(Guid);
				if (_mod__ModifiedDate) _ori__ModifiedDate = default(DateTime);
			}
			_mod__CustomerID = false;
			_mod__PersonID = false;
			_mod__StoreID = false;
			_mod__TerritoryID = false;
			_mod__AccountNumber = false;
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
			_cur__CustomerID = (int)value;
			OnPropertyChanged("CustomerID");
			OnAfterPropertyChanged("CustomerID");
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
namespace WpfClient.VenturaRecordsets
{
	public partial class CustomersListRecord
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
