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

namespace AspNetCoreServer.VenturaAutoCreate
{
	/// <summary>
	/// The updateable table is [Purchasing].[Vendor]. Updateable table column information:
	/// • 8 out of 8 table columns are present in the resultset.
	/// • All primary key columns are present in the resultset: BusinessEntityID.
	/// • Non-primary key columns present in the resultset: AccountNumber, Name, CreditRating, PreferredVendorStatus, ActiveFlag,
	///   PurchasingWebServiceURL and ModifiedDate.
	/// Recordset item automatically created by VenturaSQL Studio.
	/// </summary>
	public partial class GetAll_Purchasing_Vendor_Recordset : ResultsetObservable<GetAll_Purchasing_Vendor_Recordset, GetAll_Purchasing_Vendor_Record>, IRecordsetBase
	{
		private IResultsetBase[] _resultsets;
		private string _sqlscript;
		private int _rowlimit = 500;
		private const string CRLF = "\r\n";

		public GetAll_Purchasing_Vendor_Recordset()
		{
			_resultsets = new IResultsetBase[] { this };

			_sqlscript = @"SELECT [BusinessEntityID],[AccountNumber],[Name],[CreditRating],[PreferredVendorStatus],[ActiveFlag],[PurchasingWebServiceURL],[ModifiedDate]" + CRLF +
			             @"FROM [Purchasing].[Vendor]";

			ColumnArrayBuilder schema_array = new ColumnArrayBuilder();

			schema_array.Add(new VenturaSqlColumn("BusinessEntityID", typeof(int), false)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				IsKey = true,
				BaseSchemaName = "Purchasing",
				BaseTableName = "Vendor",
				BaseColumnName = "BusinessEntityID"
			});

			schema_array.Add(new VenturaSqlColumn("AccountNumber", typeof(string), false)
			{
				Updateable = true,
				ColumnSize = 15,
				ProviderType = 12,
				BaseSchemaName = "Purchasing",
				BaseTableName = "Vendor",
				BaseColumnName = "AccountNumber"
			});

			schema_array.Add(new VenturaSqlColumn("Name", typeof(string), false)
			{
				Updateable = true,
				ColumnSize = 50,
				ProviderType = 12,
				BaseSchemaName = "Purchasing",
				BaseTableName = "Vendor",
				BaseColumnName = "Name"
			});

			schema_array.Add(new VenturaSqlColumn("CreditRating", typeof(byte), false)
			{
				Updateable = true,
				ColumnSize = 1,
				NumericPrecision = 3,
				ProviderType = 20,
				BaseSchemaName = "Purchasing",
				BaseTableName = "Vendor",
				BaseColumnName = "CreditRating"
			});

			schema_array.Add(new VenturaSqlColumn("PreferredVendorStatus", typeof(bool), false)
			{
				Updateable = true,
				ColumnSize = 1,
				ProviderType = 2,
				BaseSchemaName = "Purchasing",
				BaseTableName = "Vendor",
				BaseColumnName = "PreferredVendorStatus"
			});

			schema_array.Add(new VenturaSqlColumn("ActiveFlag", typeof(bool), false)
			{
				Updateable = true,
				ColumnSize = 1,
				ProviderType = 2,
				BaseSchemaName = "Purchasing",
				BaseTableName = "Vendor",
				BaseColumnName = "ActiveFlag"
			});

			schema_array.Add(new VenturaSqlColumn("PurchasingWebServiceURL", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 1024,
				ProviderType = 12,
				BaseSchemaName = "Purchasing",
				BaseTableName = "Vendor",
				BaseColumnName = "PurchasingWebServiceURL"
			});

			schema_array.Add(new VenturaSqlColumn("ModifiedDate", typeof(DateTime), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 23,
				NumericScale = 3,
				ProviderType = 4,
				BaseSchemaName = "Purchasing",
				BaseTableName = "Vendor",
				BaseColumnName = "ModifiedDate"
			});

			((IResultsetBase)this).Schema = new VenturaSqlSchema(schema_array);
			((IResultsetBase)this).UpdateableTablename = "[Purchasing].[Vendor]";
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[Vendor]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public int BusinessEntityID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.BusinessEntityID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.BusinessEntityID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[Vendor]. NotReadonly. NotNull.
		/// </summary>
		public string AccountNumber
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.AccountNumber; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.AccountNumber = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[Vendor]. NotReadonly. NotNull.
		/// </summary>
		public string Name
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Name; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Name = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[Vendor]. NotReadonly. NotNull.
		/// </summary>
		public byte CreditRating
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.CreditRating; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.CreditRating = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[Vendor]. NotReadonly. NotNull.
		/// </summary>
		public bool PreferredVendorStatus
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.PreferredVendorStatus; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.PreferredVendorStatus = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[Vendor]. NotReadonly. NotNull.
		/// </summary>
		public bool ActiveFlag
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ActiveFlag; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ActiveFlag = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[Vendor]. NotReadonly. AllowNull.
		/// </summary>
		public string PurchasingWebServiceURL
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.PurchasingWebServiceURL; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.PurchasingWebServiceURL = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[Vendor]. NotReadonly. NotNull.
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
			this.InsertItem(index, new GetAll_Purchasing_Vendor_Record());
			this.CurrentRecordIndex = index;
		}

		public void Append(GetAll_Purchasing_Vendor_Record record)
		{
			int index = this.RecordCount;
			this.InsertItem(index, record);
			this.CurrentRecordIndex = index;
		}

		public GetAll_Purchasing_Vendor_Record NewRecord()
		{
			return new GetAll_Purchasing_Vendor_Record();
		}

		protected override GetAll_Purchasing_Vendor_Record InternalCreateExistingRecordObject(object[] columnvalues) => new GetAll_Purchasing_Vendor_Record(columnvalues);

		byte[] IRecordsetBase.Hash
		{
			get { return new byte[] { 178, 15, 31, 126, 19, 40, 143, 74, 32, 108, 185, 134, 70, 18, 159, 210 }; }
		}

		string IRecordsetBase.HashString
		{
			get { return "B20F1F7E13288F4A206CB98646129FD2"; }
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

	public sealed partial class GetAll_Purchasing_Vendor_Record : IRecordBase, INotifyPropertyChanged
	{
		private DataRecordStatus _recordstatus;
		private bool _started_with_dbvalues;

		private int _cur__BusinessEntityID; private int _ori__BusinessEntityID; private bool _mod__BusinessEntityID;
		private string _cur__AccountNumber; private string _ori__AccountNumber; private bool _mod__AccountNumber;
		private string _cur__Name; private string _ori__Name; private bool _mod__Name;
		private byte _cur__CreditRating; private byte _ori__CreditRating; private bool _mod__CreditRating;
		private bool _cur__PreferredVendorStatus; private bool _ori__PreferredVendorStatus; private bool _mod__PreferredVendorStatus;
		private bool _cur__ActiveFlag; private bool _ori__ActiveFlag; private bool _mod__ActiveFlag;
		private string _cur__PurchasingWebServiceURL; private string _ori__PurchasingWebServiceURL; private bool _mod__PurchasingWebServiceURL;
		private DateTime _cur__ModifiedDate; private DateTime _ori__ModifiedDate; private bool _mod__ModifiedDate;


		public GetAll_Purchasing_Vendor_Record()
		{
			_cur__BusinessEntityID = 0;
			_cur__AccountNumber = "";
			_cur__Name = "";
			_cur__CreditRating = 0;
			_cur__PreferredVendorStatus = false;
			_cur__ActiveFlag = false;
			_cur__PurchasingWebServiceURL = null;
			_cur__ModifiedDate = new DateTime(1900, 1, 1);
			_started_with_dbvalues = false;
			_recordstatus = DataRecordStatus.New;
		}

		public GetAll_Purchasing_Vendor_Record(object[] columnvalues)
		{
			_cur__BusinessEntityID = (int)columnvalues[0];
			_cur__AccountNumber = (string)columnvalues[1];
			_cur__Name = (string)columnvalues[2];
			_cur__CreditRating = (byte)columnvalues[3];
			_cur__PreferredVendorStatus = (bool)columnvalues[4];
			_cur__ActiveFlag = (bool)columnvalues[5];
			_cur__PurchasingWebServiceURL = (string)columnvalues[6];
			_cur__ModifiedDate = (DateTime)columnvalues[7];
			_started_with_dbvalues = true;
			_recordstatus = DataRecordStatus.Existing;
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[Vendor]. PrimaryKey. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [Purchasing].[Vendor]. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [Purchasing].[Vendor]. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [Purchasing].[Vendor]. NotReadonly. NotNull.
		/// </summary>
		public byte CreditRating
		{
			get { return _cur__CreditRating; }
			set
			{
				if (_started_with_dbvalues == false) _mod__CreditRating = true;
				if (_cur__CreditRating == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__CreditRating == false) { _ori__CreditRating = _cur__CreditRating; _mod__CreditRating = true; } // existing record and column is not modified
					else { if (value == _ori__CreditRating) { _ori__CreditRating = default(byte); _mod__CreditRating = false; } } // existing record and column is modified
				}
				_cur__CreditRating = value; OnPropertyChanged("CreditRating"); OnAfterPropertyChanged("CreditRating");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[Vendor]. NotReadonly. NotNull.
		/// </summary>
		public bool PreferredVendorStatus
		{
			get { return _cur__PreferredVendorStatus; }
			set
			{
				if (_started_with_dbvalues == false) _mod__PreferredVendorStatus = true;
				if (_cur__PreferredVendorStatus == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__PreferredVendorStatus == false) { _ori__PreferredVendorStatus = _cur__PreferredVendorStatus; _mod__PreferredVendorStatus = true; } // existing record and column is not modified
					else { if (value == _ori__PreferredVendorStatus) { _ori__PreferredVendorStatus = default(bool); _mod__PreferredVendorStatus = false; } } // existing record and column is modified
				}
				_cur__PreferredVendorStatus = value; OnPropertyChanged("PreferredVendorStatus"); OnAfterPropertyChanged("PreferredVendorStatus");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[Vendor]. NotReadonly. NotNull.
		/// </summary>
		public bool ActiveFlag
		{
			get { return _cur__ActiveFlag; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ActiveFlag = true;
				if (_cur__ActiveFlag == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ActiveFlag == false) { _ori__ActiveFlag = _cur__ActiveFlag; _mod__ActiveFlag = true; } // existing record and column is not modified
					else { if (value == _ori__ActiveFlag) { _ori__ActiveFlag = default(bool); _mod__ActiveFlag = false; } } // existing record and column is modified
				}
				_cur__ActiveFlag = value; OnPropertyChanged("ActiveFlag"); OnAfterPropertyChanged("ActiveFlag");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[Vendor]. NotReadonly. AllowNull.
		/// </summary>
		public string PurchasingWebServiceURL
		{
			get { return _cur__PurchasingWebServiceURL; }
			set
			{
				if (_started_with_dbvalues == false) _mod__PurchasingWebServiceURL = true;
				if (_cur__PurchasingWebServiceURL == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__PurchasingWebServiceURL == false) { _ori__PurchasingWebServiceURL = _cur__PurchasingWebServiceURL; _mod__PurchasingWebServiceURL = true; } // existing record and column is not modified
					else { if (value == _ori__PurchasingWebServiceURL) { _ori__PurchasingWebServiceURL = default(string); _mod__PurchasingWebServiceURL = false; } } // existing record and column is modified
				}
				_cur__PurchasingWebServiceURL = value; OnPropertyChanged("PurchasingWebServiceURL"); OnAfterPropertyChanged("PurchasingWebServiceURL");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[Vendor]. NotReadonly. NotNull.
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
			if (column_name == "AccountNumber") return _mod__AccountNumber;
			if (column_name == "Name") return _mod__Name;
			if (column_name == "CreditRating") return _mod__CreditRating;
			if (column_name == "PreferredVendorStatus") return _mod__PreferredVendorStatus;
			if (column_name == "ActiveFlag") return _mod__ActiveFlag;
			if (column_name == "PurchasingWebServiceURL") return _mod__PurchasingWebServiceURL;
			if (column_name == "ModifiedDate") return _mod__ModifiedDate;
			throw new ArgumentOutOfRangeException(String.Format(VenturaSqlStrings.UNKNOWN_COLUMN_NAME, column_name));
		}

		public int ModifiedColumnCount()
		{
			int count = 0;
			if (_mod__BusinessEntityID == true) count++;
			if (_mod__AccountNumber == true) count++;
			if (_mod__Name == true) count++;
			if (_mod__CreditRating == true) count++;
			if (_mod__PreferredVendorStatus == true) count++;
			if (_mod__ActiveFlag == true) count++;
			if (_mod__PurchasingWebServiceURL == true) count++;
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
			if (_mod__AccountNumber == true) count++;
			if (_mod__Name == true) count++;
			if (_mod__CreditRating == true) count++;
			if (_mod__PreferredVendorStatus == true) count++;
			if (_mod__ActiveFlag == true) count++;
			if (_mod__PurchasingWebServiceURL == true) count++;
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
				track_array.AppendDataValue(1, _cur__AccountNumber);
				track_array.AppendDataValue(2, _cur__Name);
				track_array.AppendDataValue(3, _cur__CreditRating);
				track_array.AppendDataValue(4, _cur__PreferredVendorStatus);
				track_array.AppendDataValue(5, _cur__ActiveFlag);
				if (_cur__PurchasingWebServiceURL != null) track_array.AppendDataValue(6, _cur__PurchasingWebServiceURL);
				track_array.AppendDataValue(7, _cur__ModifiedDate);
			}
			else if (_recordstatus == DataRecordStatus.Existing)
			{
				if (_started_with_dbvalues)
				{
					if (_mod__BusinessEntityID) track_array.AppendDataValue(0, _cur__BusinessEntityID);
				}
				if (_mod__AccountNumber) track_array.AppendDataValue(1, _cur__AccountNumber);
				if (_mod__Name) track_array.AppendDataValue(2, _cur__Name);
				if (_mod__CreditRating) track_array.AppendDataValue(3, _cur__CreditRating);
				if (_mod__PreferredVendorStatus) track_array.AppendDataValue(4, _cur__PreferredVendorStatus);
				if (_mod__ActiveFlag) track_array.AppendDataValue(5, _cur__ActiveFlag);
				if (_mod__PurchasingWebServiceURL) track_array.AppendDataValue(6, _cur__PurchasingWebServiceURL);
				if (_mod__ModifiedDate) track_array.AppendDataValue(7, _cur__ModifiedDate);
				if (track_array.HasData == false) return;
			}

			if (_recordstatus == DataRecordStatus.Existing || _recordstatus == DataRecordStatus.ExistingDelete)
			{
				track_array.AppendPrikeyValue(0, (_mod__BusinessEntityID && _started_with_dbvalues) ? _ori__BusinessEntityID : _cur__BusinessEntityID);
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
				if (_mod__AccountNumber) _ori__AccountNumber = default(string);
				if (_mod__Name) _ori__Name = default(string);
				if (_mod__CreditRating) _ori__CreditRating = default(byte);
				if (_mod__PreferredVendorStatus) _ori__PreferredVendorStatus = default(bool);
				if (_mod__ActiveFlag) _ori__ActiveFlag = default(bool);
				if (_mod__PurchasingWebServiceURL) _ori__PurchasingWebServiceURL = default(string);
				if (_mod__ModifiedDate) _ori__ModifiedDate = default(DateTime);
			}
			_mod__BusinessEntityID = false;
			_mod__AccountNumber = false;
			_mod__Name = false;
			_mod__CreditRating = false;
			_mod__PreferredVendorStatus = false;
			_mod__ActiveFlag = false;
			_mod__PurchasingWebServiceURL = false;
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
	public partial class GetAll_Purchasing_Vendor_Record
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
