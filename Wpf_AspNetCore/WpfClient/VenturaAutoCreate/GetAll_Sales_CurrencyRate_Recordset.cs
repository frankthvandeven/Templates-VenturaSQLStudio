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
	/// The updateable table is [Sales].[CurrencyRate]. Updateable table column information:
	/// • 7 out of 7 table columns are present in the resultset.
	/// • All primary key columns are present in the resultset: CurrencyRateID.
	/// • Non-primary key columns present in the resultset: CurrencyRateDate, FromCurrencyCode, ToCurrencyCode, AverageRate,
	///   EndOfDayRate and ModifiedDate.
	/// Recordset item automatically created by VenturaSQL Studio.
	/// </summary>
	public partial class GetAll_Sales_CurrencyRate_Recordset : ResultsetObservable<GetAll_Sales_CurrencyRate_Recordset, GetAll_Sales_CurrencyRate_Record>, IRecordsetBase
	{
		private IResultsetBase[] _resultsets;
		private string _sqlscript;
		private int _rowlimit = 500;
		private const string CRLF = "\r\n";

		public GetAll_Sales_CurrencyRate_Recordset()
		{
			_resultsets = new IResultsetBase[] { this };

			_sqlscript = @"SELECT [CurrencyRateID],[CurrencyRateDate],[FromCurrencyCode],[ToCurrencyCode],[AverageRate],[EndOfDayRate],[ModifiedDate]" + CRLF +
			             @"FROM [Sales].[CurrencyRate]";

			ColumnArrayBuilder schema_array = new ColumnArrayBuilder();

			schema_array.Add(new VenturaSqlColumn("CurrencyRateID", typeof(int), false)
			{
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				IsKey = true,
				IsIdentity = true,
				IsAutoIncrement = true,
				BaseSchemaName = "Sales",
				BaseTableName = "CurrencyRate",
				BaseColumnName = "CurrencyRateID"
			});

			schema_array.Add(new VenturaSqlColumn("CurrencyRateDate", typeof(DateTime), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 23,
				NumericScale = 3,
				ProviderType = 4,
				BaseSchemaName = "Sales",
				BaseTableName = "CurrencyRate",
				BaseColumnName = "CurrencyRateDate"
			});

			schema_array.Add(new VenturaSqlColumn("FromCurrencyCode", typeof(string), false)
			{
				Updateable = true,
				ColumnSize = 3,
				ProviderType = 10,
				BaseSchemaName = "Sales",
				BaseTableName = "CurrencyRate",
				BaseColumnName = "FromCurrencyCode"
			});

			schema_array.Add(new VenturaSqlColumn("ToCurrencyCode", typeof(string), false)
			{
				Updateable = true,
				ColumnSize = 3,
				ProviderType = 10,
				BaseSchemaName = "Sales",
				BaseTableName = "CurrencyRate",
				BaseColumnName = "ToCurrencyCode"
			});

			schema_array.Add(new VenturaSqlColumn("AverageRate", typeof(decimal), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 19,
				ProviderType = 9,
				BaseSchemaName = "Sales",
				BaseTableName = "CurrencyRate",
				BaseColumnName = "AverageRate"
			});

			schema_array.Add(new VenturaSqlColumn("EndOfDayRate", typeof(decimal), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 19,
				ProviderType = 9,
				BaseSchemaName = "Sales",
				BaseTableName = "CurrencyRate",
				BaseColumnName = "EndOfDayRate"
			});

			schema_array.Add(new VenturaSqlColumn("ModifiedDate", typeof(DateTime), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 23,
				NumericScale = 3,
				ProviderType = 4,
				BaseSchemaName = "Sales",
				BaseTableName = "CurrencyRate",
				BaseColumnName = "ModifiedDate"
			});

			((IResultsetBase)this).Schema = new VenturaSqlSchema(schema_array);
			((IResultsetBase)this).UpdateableTablename = "[Sales].[CurrencyRate]";
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Sales].[CurrencyRate]. PrimaryKey. NotReadonly. NotNull. IsIdentity. AutoIncrement.
		/// </summary>
		public int CurrencyRateID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.CurrencyRateID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.CurrencyRateID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[CurrencyRate]. NotReadonly. NotNull.
		/// </summary>
		public DateTime CurrencyRateDate
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.CurrencyRateDate; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.CurrencyRateDate = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[CurrencyRate]. NotReadonly. NotNull.
		/// </summary>
		public string FromCurrencyCode
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.FromCurrencyCode; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.FromCurrencyCode = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[CurrencyRate]. NotReadonly. NotNull.
		/// </summary>
		public string ToCurrencyCode
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ToCurrencyCode; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ToCurrencyCode = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[CurrencyRate]. NotReadonly. NotNull.
		/// </summary>
		public decimal AverageRate
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.AverageRate; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.AverageRate = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[CurrencyRate]. NotReadonly. NotNull.
		/// </summary>
		public decimal EndOfDayRate
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.EndOfDayRate; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.EndOfDayRate = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[CurrencyRate]. NotReadonly. NotNull.
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
			this.InsertItem(index, new GetAll_Sales_CurrencyRate_Record());
			this.CurrentRecordIndex = index;
		}

		public void Append(GetAll_Sales_CurrencyRate_Record record)
		{
			int index = this.RecordCount;
			this.InsertItem(index, record);
			this.CurrentRecordIndex = index;
		}

		public GetAll_Sales_CurrencyRate_Record NewRecord()
		{
			return new GetAll_Sales_CurrencyRate_Record();
		}

		protected override GetAll_Sales_CurrencyRate_Record InternalCreateExistingRecordObject(object[] columnvalues) => new GetAll_Sales_CurrencyRate_Record(columnvalues);

		byte[] IRecordsetBase.Hash
		{
			get { return new byte[] { 177, 1, 213, 124, 220, 80, 50, 240, 153, 62, 96, 89, 182, 194, 210, 44 }; }
		}

		string IRecordsetBase.HashString
		{
			get { return "B101D57CDC5032F0993E6059B6C2D22C"; }
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

	public sealed partial class GetAll_Sales_CurrencyRate_Record : IRecordBase, INotifyPropertyChanged
	{
		private DataRecordStatus _recordstatus;
		private bool _started_with_dbvalues;

		private int _cur__CurrencyRateID; private int _ori__CurrencyRateID; private bool _mod__CurrencyRateID;
		private DateTime _cur__CurrencyRateDate; private DateTime _ori__CurrencyRateDate; private bool _mod__CurrencyRateDate;
		private string _cur__FromCurrencyCode; private string _ori__FromCurrencyCode; private bool _mod__FromCurrencyCode;
		private string _cur__ToCurrencyCode; private string _ori__ToCurrencyCode; private bool _mod__ToCurrencyCode;
		private decimal _cur__AverageRate; private decimal _ori__AverageRate; private bool _mod__AverageRate;
		private decimal _cur__EndOfDayRate; private decimal _ori__EndOfDayRate; private bool _mod__EndOfDayRate;
		private DateTime _cur__ModifiedDate; private DateTime _ori__ModifiedDate; private bool _mod__ModifiedDate;


		public GetAll_Sales_CurrencyRate_Record()
		{
			_cur__CurrencyRateID = 0;
			_cur__CurrencyRateDate = new DateTime(1900, 1, 1);
			_cur__FromCurrencyCode = "";
			_cur__ToCurrencyCode = "";
			_cur__AverageRate = 0.0m;
			_cur__EndOfDayRate = 0.0m;
			_cur__ModifiedDate = new DateTime(1900, 1, 1);
			_started_with_dbvalues = false;
			_recordstatus = DataRecordStatus.New;
		}

		public GetAll_Sales_CurrencyRate_Record(object[] columnvalues)
		{
			_cur__CurrencyRateID = (int)columnvalues[0];
			_cur__CurrencyRateDate = (DateTime)columnvalues[1];
			_cur__FromCurrencyCode = (string)columnvalues[2];
			_cur__ToCurrencyCode = (string)columnvalues[3];
			_cur__AverageRate = (decimal)columnvalues[4];
			_cur__EndOfDayRate = (decimal)columnvalues[5];
			_cur__ModifiedDate = (DateTime)columnvalues[6];
			_started_with_dbvalues = true;
			_recordstatus = DataRecordStatus.Existing;
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Sales].[CurrencyRate]. PrimaryKey. NotReadonly. NotNull. IsIdentity. AutoIncrement.
		/// </summary>
		public int CurrencyRateID
		{
			get { return _cur__CurrencyRateID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__CurrencyRateID = true;
				if (_cur__CurrencyRateID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__CurrencyRateID == false) { _ori__CurrencyRateID = _cur__CurrencyRateID; _mod__CurrencyRateID = true; } // existing record and column is not modified
					else { if (value == _ori__CurrencyRateID) { _ori__CurrencyRateID = default(int); _mod__CurrencyRateID = false; } } // existing record and column is modified
				}
				_cur__CurrencyRateID = value; OnPropertyChanged("CurrencyRateID"); OnAfterPropertyChanged("CurrencyRateID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[CurrencyRate]. NotReadonly. NotNull.
		/// </summary>
		public DateTime CurrencyRateDate
		{
			get { return _cur__CurrencyRateDate; }
			set
			{
				if (_started_with_dbvalues == false) _mod__CurrencyRateDate = true;
				if (_cur__CurrencyRateDate == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__CurrencyRateDate == false) { _ori__CurrencyRateDate = _cur__CurrencyRateDate; _mod__CurrencyRateDate = true; } // existing record and column is not modified
					else { if (value == _ori__CurrencyRateDate) { _ori__CurrencyRateDate = default(DateTime); _mod__CurrencyRateDate = false; } } // existing record and column is modified
				}
				_cur__CurrencyRateDate = value; OnPropertyChanged("CurrencyRateDate"); OnAfterPropertyChanged("CurrencyRateDate");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[CurrencyRate]. NotReadonly. NotNull.
		/// </summary>
		public string FromCurrencyCode
		{
			get { return _cur__FromCurrencyCode; }
			set
			{
				if (value == null) throw new ArgumentNullException("FromCurrencyCode", VenturaSqlStrings.SET_NULL_MSG);
				if (_started_with_dbvalues == false) _mod__FromCurrencyCode = true;
				if (_cur__FromCurrencyCode == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__FromCurrencyCode == false) { _ori__FromCurrencyCode = _cur__FromCurrencyCode; _mod__FromCurrencyCode = true; } // existing record and column is not modified
					else { if (value == _ori__FromCurrencyCode) { _ori__FromCurrencyCode = default(string); _mod__FromCurrencyCode = false; } } // existing record and column is modified
				}
				_cur__FromCurrencyCode = value; OnPropertyChanged("FromCurrencyCode"); OnAfterPropertyChanged("FromCurrencyCode");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[CurrencyRate]. NotReadonly. NotNull.
		/// </summary>
		public string ToCurrencyCode
		{
			get { return _cur__ToCurrencyCode; }
			set
			{
				if (value == null) throw new ArgumentNullException("ToCurrencyCode", VenturaSqlStrings.SET_NULL_MSG);
				if (_started_with_dbvalues == false) _mod__ToCurrencyCode = true;
				if (_cur__ToCurrencyCode == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ToCurrencyCode == false) { _ori__ToCurrencyCode = _cur__ToCurrencyCode; _mod__ToCurrencyCode = true; } // existing record and column is not modified
					else { if (value == _ori__ToCurrencyCode) { _ori__ToCurrencyCode = default(string); _mod__ToCurrencyCode = false; } } // existing record and column is modified
				}
				_cur__ToCurrencyCode = value; OnPropertyChanged("ToCurrencyCode"); OnAfterPropertyChanged("ToCurrencyCode");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[CurrencyRate]. NotReadonly. NotNull.
		/// </summary>
		public decimal AverageRate
		{
			get { return _cur__AverageRate; }
			set
			{
				if (_started_with_dbvalues == false) _mod__AverageRate = true;
				if (_cur__AverageRate == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__AverageRate == false) { _ori__AverageRate = _cur__AverageRate; _mod__AverageRate = true; } // existing record and column is not modified
					else { if (value == _ori__AverageRate) { _ori__AverageRate = default(decimal); _mod__AverageRate = false; } } // existing record and column is modified
				}
				_cur__AverageRate = value; OnPropertyChanged("AverageRate"); OnAfterPropertyChanged("AverageRate");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[CurrencyRate]. NotReadonly. NotNull.
		/// </summary>
		public decimal EndOfDayRate
		{
			get { return _cur__EndOfDayRate; }
			set
			{
				if (_started_with_dbvalues == false) _mod__EndOfDayRate = true;
				if (_cur__EndOfDayRate == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__EndOfDayRate == false) { _ori__EndOfDayRate = _cur__EndOfDayRate; _mod__EndOfDayRate = true; } // existing record and column is not modified
					else { if (value == _ori__EndOfDayRate) { _ori__EndOfDayRate = default(decimal); _mod__EndOfDayRate = false; } } // existing record and column is modified
				}
				_cur__EndOfDayRate = value; OnPropertyChanged("EndOfDayRate"); OnAfterPropertyChanged("EndOfDayRate");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[CurrencyRate]. NotReadonly. NotNull.
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
			if (column_name == "CurrencyRateID") return _mod__CurrencyRateID;
			if (column_name == "CurrencyRateDate") return _mod__CurrencyRateDate;
			if (column_name == "FromCurrencyCode") return _mod__FromCurrencyCode;
			if (column_name == "ToCurrencyCode") return _mod__ToCurrencyCode;
			if (column_name == "AverageRate") return _mod__AverageRate;
			if (column_name == "EndOfDayRate") return _mod__EndOfDayRate;
			if (column_name == "ModifiedDate") return _mod__ModifiedDate;
			throw new ArgumentOutOfRangeException(String.Format(VenturaSqlStrings.UNKNOWN_COLUMN_NAME, column_name));
		}

		public int ModifiedColumnCount()
		{
			int count = 0;
			if (_mod__CurrencyRateID == true) count++;
			if (_mod__CurrencyRateDate == true) count++;
			if (_mod__FromCurrencyCode == true) count++;
			if (_mod__ToCurrencyCode == true) count++;
			if (_mod__AverageRate == true) count++;
			if (_mod__EndOfDayRate == true) count++;
			if (_mod__ModifiedDate == true) count++;
			return count;
		}

		public bool PendingChanges()
		{
			if (_recordstatus == DataRecordStatus.New || _recordstatus == DataRecordStatus.ExistingDelete) return true;
			int count = 0;
			if (_mod__CurrencyRateDate == true) count++;
			if (_mod__FromCurrencyCode == true) count++;
			if (_mod__ToCurrencyCode == true) count++;
			if (_mod__AverageRate == true) count++;
			if (_mod__EndOfDayRate == true) count++;
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
				track_array.AppendDataValue(1, _cur__CurrencyRateDate);
				track_array.AppendDataValue(2, _cur__FromCurrencyCode);
				track_array.AppendDataValue(3, _cur__ToCurrencyCode);
				track_array.AppendDataValue(4, _cur__AverageRate);
				track_array.AppendDataValue(5, _cur__EndOfDayRate);
				track_array.AppendDataValue(6, _cur__ModifiedDate);
			}
			else if (_recordstatus == DataRecordStatus.Existing)
			{
				if (_mod__CurrencyRateDate) track_array.AppendDataValue(1, _cur__CurrencyRateDate);
				if (_mod__FromCurrencyCode) track_array.AppendDataValue(2, _cur__FromCurrencyCode);
				if (_mod__ToCurrencyCode) track_array.AppendDataValue(3, _cur__ToCurrencyCode);
				if (_mod__AverageRate) track_array.AppendDataValue(4, _cur__AverageRate);
				if (_mod__EndOfDayRate) track_array.AppendDataValue(5, _cur__EndOfDayRate);
				if (_mod__ModifiedDate) track_array.AppendDataValue(6, _cur__ModifiedDate);
				if (track_array.HasData == false) return;
			}

			if (_recordstatus == DataRecordStatus.Existing || _recordstatus == DataRecordStatus.ExistingDelete)
			{
				track_array.AppendPrikeyValue(0, (_mod__CurrencyRateID && _started_with_dbvalues) ? _ori__CurrencyRateID : _cur__CurrencyRateID);
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
				if (_mod__CurrencyRateID) _ori__CurrencyRateID = default(int);
				if (_mod__CurrencyRateDate) _ori__CurrencyRateDate = default(DateTime);
				if (_mod__FromCurrencyCode) _ori__FromCurrencyCode = default(string);
				if (_mod__ToCurrencyCode) _ori__ToCurrencyCode = default(string);
				if (_mod__AverageRate) _ori__AverageRate = default(decimal);
				if (_mod__EndOfDayRate) _ori__EndOfDayRate = default(decimal);
				if (_mod__ModifiedDate) _ori__ModifiedDate = default(DateTime);
			}
			_mod__CurrencyRateID = false;
			_mod__CurrencyRateDate = false;
			_mod__FromCurrencyCode = false;
			_mod__ToCurrencyCode = false;
			_mod__AverageRate = false;
			_mod__EndOfDayRate = false;
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
			_cur__CurrencyRateID = (int)value;
			OnPropertyChanged("CurrencyRateID");
			OnAfterPropertyChanged("CurrencyRateID");
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
	public partial class GetAll_Sales_CurrencyRate_Record
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
