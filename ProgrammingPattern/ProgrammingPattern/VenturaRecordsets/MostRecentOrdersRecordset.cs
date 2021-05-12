/*
	Project file: "C:\Active\VenturaSQL\BuildSystem\Templates\ProgrammingPattern\ProgrammingPattern.venproj"
	Target platform: NETStandard
	Generator version: 4.0.128
	Generated on: Wednesday, 12 May 2021 at 18:50:44
	At the bottom of this file you find a template for extending Recordsets with calculated columns for XAML data binding.
*/
using VenturaSQL;
using System;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel;

namespace ProgrammingPattern.VenturaRecordsets
{
	/// <summary>
	/// The updateable table is [Orders]. Updateable table column information:
	/// • 5 out of 17 table columns are present in the resultset.
	/// • All primary key columns are present in the resultset: OrderID.
	/// • Non-primary key columns present in the resultset: CustomerID, OrderDate, ShipAddress and ShipCity.
	/// • Non-primary key columns not present in the resultset: DeliveredDate, LastModifiedOn, PaymentType, SearchTerms,
	///   ShipCountryCode, ShipPhone, ShipPostalCode, ShipRegion, ShipVia, ShippedDate, Status and TrackingNumber.
	/// </summary>
	public partial class MostRecentOrdersRecordset : ResultsetObservable<MostRecentOrdersRecordset, MostRecentOrdersRecord>, IRecordsetBase
	{
		private IResultsetBase[] _resultsets;
		private string _sqlscript;
		private int _rowlimit = 500;
		private const string CRLF = "\r\n";

		public MostRecentOrdersRecordset()
		{
			_resultsets = new IResultsetBase[] { this };

			_sqlscript = @"select Orders.OrderID, Orders.OrderDate, Orders.ShipAddress, Orders.ShipCity, Orders.CustomerID, Customers.FirstName, Customers.LastName" + CRLF +
			             @"from  Orders" + CRLF +
			             @"join Customers" + CRLF +
			             @"   on Customers.CustomerID = Orders.CustomerID  order by OrderDate desc limit 50";

			ColumnArrayBuilder schema_array = new ColumnArrayBuilder();

			schema_array.Add(new VenturaSqlColumn("OrderID", typeof(long), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 19,
				NumericScale = 0,
				ProviderType = 12,
				IsKey = true,
				BaseCatalogName = "main",
				BaseTableName = "Orders",
				BaseColumnName = "OrderID"
			});

			schema_array.Add(new VenturaSqlColumn("OrderDate", typeof(string), false)
			{
				Updateable = true,
				ProviderType = 16,
				BaseCatalogName = "main",
				BaseTableName = "Orders",
				BaseColumnName = "OrderDate"
			});

			schema_array.Add(new VenturaSqlColumn("ShipAddress", typeof(string), true)
			{
				Updateable = true,
				ProviderType = 16,
				BaseCatalogName = "main",
				BaseTableName = "Orders",
				BaseColumnName = "ShipAddress"
			});

			schema_array.Add(new VenturaSqlColumn("ShipCity", typeof(string), true)
			{
				Updateable = true,
				ProviderType = 16,
				BaseCatalogName = "main",
				BaseTableName = "Orders",
				BaseColumnName = "ShipCity"
			});

			schema_array.Add(new VenturaSqlColumn("CustomerID", typeof(long), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 19,
				NumericScale = 0,
				ProviderType = 12,
				BaseCatalogName = "main",
				BaseTableName = "Orders",
				BaseColumnName = "CustomerID"
			});

			schema_array.Add(new VenturaSqlColumn("FirstName", typeof(string), false)
			{
				ProviderType = 16,
				BaseCatalogName = "main",
				BaseTableName = "Customers",
				BaseColumnName = "FirstName"
			});

			schema_array.Add(new VenturaSqlColumn("LastName", typeof(string), false)
			{
				ProviderType = 16,
				BaseCatalogName = "main",
				BaseTableName = "Customers",
				BaseColumnName = "LastName"
			});

			((IResultsetBase)this).Schema = new VenturaSqlSchema(schema_array);
			((IResultsetBase)this).UpdateableTablename = "[Orders]";
		}

		/// <summary>
		/// Database Column Updateable. Table [Orders]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public long OrderID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.OrderID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.OrderID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Orders]. NotReadonly. NotNull.
		/// </summary>
		public string OrderDate
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.OrderDate; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.OrderDate = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Orders]. NotReadonly. AllowNull.
		/// </summary>
		public string ShipAddress
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ShipAddress; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ShipAddress = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Orders]. NotReadonly. AllowNull.
		/// </summary>
		public string ShipCity
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ShipCity; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ShipCity = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Orders]. NotReadonly. NotNull.
		/// </summary>
		public long CustomerID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.CustomerID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.CustomerID = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Customers]. NotReadonly. NotNull.
		/// </summary>
		public string FirstName
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.FirstName; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.FirstName = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Customers]. NotReadonly. NotNull.
		/// </summary>
		public string LastName
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.LastName; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.LastName = value; }
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
			this.InsertItem(index, new MostRecentOrdersRecord());
			this.CurrentRecordIndex = index;
		}

		public void Append(MostRecentOrdersRecord record)
		{
			int index = this.RecordCount;
			this.InsertItem(index, record);
			this.CurrentRecordIndex = index;
		}

		public MostRecentOrdersRecord NewRecord()
		{
			return new MostRecentOrdersRecord();
		}

		protected override MostRecentOrdersRecord InternalCreateExistingRecordObject(object[] columnvalues) => new MostRecentOrdersRecord(columnvalues);

		byte[] IRecordsetBase.Hash
		{
			get { return new byte[] { 217, 243, 186, 230, 171, 211, 54, 109, 251, 146, 87, 253, 171, 82, 194, 157 }; }
		}

		string IRecordsetBase.HashString
		{
			get { return "D9F3BAE6ABD3366DFB9257FDAB52C29D"; }
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
			get { return new DateTime(2021, 5, 12, 18, 50, 44); } // Wednesday, 12 May 2021 at 18:50:44
		}

		string IRecordsetBase.GeneratorProviderInvariantName
		{
			get { return "System.Data.SQLite"; }
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

	public sealed partial class MostRecentOrdersRecord : IRecordBase, INotifyPropertyChanged
	{
		private DataRecordStatus _recordstatus;
		private bool _started_with_dbvalues;

		private long _cur__OrderID; private long _ori__OrderID; private bool _mod__OrderID;
		private string _cur__OrderDate; private string _ori__OrderDate; private bool _mod__OrderDate;
		private string _cur__ShipAddress; private string _ori__ShipAddress; private bool _mod__ShipAddress;
		private string _cur__ShipCity; private string _ori__ShipCity; private bool _mod__ShipCity;
		private long _cur__CustomerID; private long _ori__CustomerID; private bool _mod__CustomerID;
		private string _cur__FirstName; private string _ori__FirstName; private bool _mod__FirstName;
		private string _cur__LastName; private string _ori__LastName; private bool _mod__LastName;


		public MostRecentOrdersRecord()
		{
			_cur__OrderID = 0;
			_cur__OrderDate = "";
			_cur__ShipAddress = null;
			_cur__ShipCity = null;
			_cur__CustomerID = 0;
			_cur__FirstName = "";
			_cur__LastName = "";
			_started_with_dbvalues = false;
			_recordstatus = DataRecordStatus.New;
		}

		public MostRecentOrdersRecord(object[] columnvalues)
		{
			_cur__OrderID = (long)columnvalues[0];
			_cur__OrderDate = (string)columnvalues[1];
			_cur__ShipAddress = (string)columnvalues[2];
			_cur__ShipCity = (string)columnvalues[3];
			_cur__CustomerID = (long)columnvalues[4];
			_cur__FirstName = (string)columnvalues[5];
			_cur__LastName = (string)columnvalues[6];
			_started_with_dbvalues = true;
			_recordstatus = DataRecordStatus.Existing;
		}

		/// <summary>
		/// Database Column Updateable. Table [Orders]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public long OrderID
		{
			get { return _cur__OrderID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__OrderID = true;
				if (_cur__OrderID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__OrderID == false) { _ori__OrderID = _cur__OrderID; _mod__OrderID = true; } // existing record and column is not modified
					else { if (value == _ori__OrderID) { _ori__OrderID = default(long); _mod__OrderID = false; } } // existing record and column is modified
				}
				_cur__OrderID = value; OnPropertyChanged("OrderID"); OnAfterPropertyChanged("OrderID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Orders]. NotReadonly. NotNull.
		/// </summary>
		public string OrderDate
		{
			get { return _cur__OrderDate; }
			set
			{
				if (value == null) throw new ArgumentNullException("OrderDate", VenturaSqlStrings.SET_NULL_MSG);
				if (_started_with_dbvalues == false) _mod__OrderDate = true;
				if (_cur__OrderDate == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__OrderDate == false) { _ori__OrderDate = _cur__OrderDate; _mod__OrderDate = true; } // existing record and column is not modified
					else { if (value == _ori__OrderDate) { _ori__OrderDate = default(string); _mod__OrderDate = false; } } // existing record and column is modified
				}
				_cur__OrderDate = value; OnPropertyChanged("OrderDate"); OnAfterPropertyChanged("OrderDate");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Orders]. NotReadonly. AllowNull.
		/// </summary>
		public string ShipAddress
		{
			get { return _cur__ShipAddress; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ShipAddress = true;
				if (_cur__ShipAddress == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ShipAddress == false) { _ori__ShipAddress = _cur__ShipAddress; _mod__ShipAddress = true; } // existing record and column is not modified
					else { if (value == _ori__ShipAddress) { _ori__ShipAddress = default(string); _mod__ShipAddress = false; } } // existing record and column is modified
				}
				_cur__ShipAddress = value; OnPropertyChanged("ShipAddress"); OnAfterPropertyChanged("ShipAddress");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Orders]. NotReadonly. AllowNull.
		/// </summary>
		public string ShipCity
		{
			get { return _cur__ShipCity; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ShipCity = true;
				if (_cur__ShipCity == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ShipCity == false) { _ori__ShipCity = _cur__ShipCity; _mod__ShipCity = true; } // existing record and column is not modified
					else { if (value == _ori__ShipCity) { _ori__ShipCity = default(string); _mod__ShipCity = false; } } // existing record and column is modified
				}
				_cur__ShipCity = value; OnPropertyChanged("ShipCity"); OnAfterPropertyChanged("ShipCity");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Orders]. NotReadonly. NotNull.
		/// </summary>
		public long CustomerID
		{
			get { return _cur__CustomerID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__CustomerID = true;
				if (_cur__CustomerID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__CustomerID == false) { _ori__CustomerID = _cur__CustomerID; _mod__CustomerID = true; } // existing record and column is not modified
					else { if (value == _ori__CustomerID) { _ori__CustomerID = default(long); _mod__CustomerID = false; } } // existing record and column is modified
				}
				_cur__CustomerID = value; OnPropertyChanged("CustomerID"); OnAfterPropertyChanged("CustomerID");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Customers]. NotReadonly. NotNull.
		/// </summary>
		public string FirstName
		{
			get { return _cur__FirstName; }
			set
			{
				if (value == null) throw new ArgumentNullException("FirstName", VenturaSqlStrings.SET_NULL_MSG);
				if (_started_with_dbvalues == false) _mod__FirstName = true;
				if (_cur__FirstName == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__FirstName == false) { _ori__FirstName = _cur__FirstName; _mod__FirstName = true; } // existing record and column is not modified
					else { if (value == _ori__FirstName) { _ori__FirstName = default(string); _mod__FirstName = false; } } // existing record and column is modified
				}
				_cur__FirstName = value; OnPropertyChanged("FirstName"); OnAfterPropertyChanged("FirstName");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Customers]. NotReadonly. NotNull.
		/// </summary>
		public string LastName
		{
			get { return _cur__LastName; }
			set
			{
				if (value == null) throw new ArgumentNullException("LastName", VenturaSqlStrings.SET_NULL_MSG);
				if (_started_with_dbvalues == false) _mod__LastName = true;
				if (_cur__LastName == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__LastName == false) { _ori__LastName = _cur__LastName; _mod__LastName = true; } // existing record and column is not modified
					else { if (value == _ori__LastName) { _ori__LastName = default(string); _mod__LastName = false; } } // existing record and column is modified
				}
				_cur__LastName = value; OnPropertyChanged("LastName"); OnAfterPropertyChanged("LastName");
			}
		}

		public bool IsModified(string column_name)
		{
			if (column_name == "OrderID") return _mod__OrderID;
			if (column_name == "OrderDate") return _mod__OrderDate;
			if (column_name == "ShipAddress") return _mod__ShipAddress;
			if (column_name == "ShipCity") return _mod__ShipCity;
			if (column_name == "CustomerID") return _mod__CustomerID;
			if (column_name == "FirstName") return _mod__FirstName;
			if (column_name == "LastName") return _mod__LastName;
			throw new ArgumentOutOfRangeException(String.Format(VenturaSqlStrings.UNKNOWN_COLUMN_NAME, column_name));
		}

		public int ModifiedColumnCount()
		{
			int count = 0;
			if (_mod__OrderID == true) count++;
			if (_mod__OrderDate == true) count++;
			if (_mod__ShipAddress == true) count++;
			if (_mod__ShipCity == true) count++;
			if (_mod__CustomerID == true) count++;
			if (_mod__FirstName == true) count++;
			if (_mod__LastName == true) count++;
			return count;
		}

		public bool PendingChanges()
		{
			if (_recordstatus == DataRecordStatus.New || _recordstatus == DataRecordStatus.ExistingDelete) return true;
			int count = 0;
			if (_started_with_dbvalues)
			{
				if (_mod__OrderID) count++;
			}
			if (_mod__OrderDate == true) count++;
			if (_mod__ShipAddress == true) count++;
			if (_mod__ShipCity == true) count++;
			if (_mod__CustomerID == true) count++;
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
			if (_mod__OrderID == false) throw new Exception(string.Format(VenturaSqlStrings.VALUE_NOT_SET_MSG, record_index_to_display, "OrderID"));
		}

		void IRecordBase.WriteChangesToTrackArray(TrackArray track_array)
		{
			if (_recordstatus == DataRecordStatus.New)
			{
				track_array.AppendDataValue(0, _cur__OrderID);
				track_array.AppendDataValue(1, _cur__OrderDate);
				if (_cur__ShipAddress != null) track_array.AppendDataValue(2, _cur__ShipAddress);
				if (_cur__ShipCity != null) track_array.AppendDataValue(3, _cur__ShipCity);
				track_array.AppendDataValue(4, _cur__CustomerID);
			}
			else if (_recordstatus == DataRecordStatus.Existing)
			{
				if (_started_with_dbvalues)
				{
					if (_mod__OrderID) track_array.AppendDataValue(0, _cur__OrderID);
				}
				if (_mod__OrderDate) track_array.AppendDataValue(1, _cur__OrderDate);
				if (_mod__ShipAddress) track_array.AppendDataValue(2, _cur__ShipAddress);
				if (_mod__ShipCity) track_array.AppendDataValue(3, _cur__ShipCity);
				if (_mod__CustomerID) track_array.AppendDataValue(4, _cur__CustomerID);
				if (track_array.HasData == false) return;
			}

			if (_recordstatus == DataRecordStatus.Existing || _recordstatus == DataRecordStatus.ExistingDelete)
			{
				track_array.AppendPrikeyValue(0, (_mod__OrderID && _started_with_dbvalues) ? _ori__OrderID : _cur__OrderID);
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
				if (_mod__OrderID) _ori__OrderID = default(long);
				if (_mod__OrderDate) _ori__OrderDate = default(string);
				if (_mod__ShipAddress) _ori__ShipAddress = default(string);
				if (_mod__ShipCity) _ori__ShipCity = default(string);
				if (_mod__CustomerID) _ori__CustomerID = default(long);
				if (_mod__FirstName) _ori__FirstName = default(string);
				if (_mod__LastName) _ori__LastName = default(string);
			}
			_mod__OrderID = false;
			_mod__OrderDate = false;
			_mod__ShipAddress = false;
			_mod__ShipCity = false;
			_mod__CustomerID = false;
			_mod__FirstName = false;
			_mod__LastName = false;
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
namespace ProgrammingPattern.VenturaRecordsets
{
	public partial class MostRecentOrdersRecord
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
