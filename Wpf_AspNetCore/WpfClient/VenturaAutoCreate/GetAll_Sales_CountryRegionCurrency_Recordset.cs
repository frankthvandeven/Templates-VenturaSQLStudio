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
	/// The updateable table is [Sales].[CountryRegionCurrency]. Updateable table column information:
	/// • 3 out of 3 table columns are present in the resultset.
	/// • All primary key columns are present in the resultset: CountryRegionCode and CurrencyCode.
	/// • Non-primary key column present in the resultset: ModifiedDate.
	/// Recordset item automatically created by VenturaSQL Studio.
	/// </summary>
	public partial class GetAll_Sales_CountryRegionCurrency_Recordset : ResultsetObservable<GetAll_Sales_CountryRegionCurrency_Recordset, GetAll_Sales_CountryRegionCurrency_Record>, IRecordsetBase
	{
		private IResultsetBase[] _resultsets;
		private string _sqlscript;
		private int _rowlimit = 500;
		private const string CRLF = "\r\n";

		public GetAll_Sales_CountryRegionCurrency_Recordset()
		{
			_resultsets = new IResultsetBase[] { this };

			_sqlscript = @"SELECT [CountryRegionCode],[CurrencyCode],[ModifiedDate]" + CRLF +
			             @"FROM [Sales].[CountryRegionCurrency]";

			ColumnArrayBuilder schema_array = new ColumnArrayBuilder();

			schema_array.Add(new VenturaSqlColumn("CountryRegionCode", typeof(string), false)
			{
				Updateable = true,
				ColumnSize = 3,
				ProviderType = 12,
				IsKey = true,
				BaseSchemaName = "Sales",
				BaseTableName = "CountryRegionCurrency",
				BaseColumnName = "CountryRegionCode"
			});

			schema_array.Add(new VenturaSqlColumn("CurrencyCode", typeof(string), false)
			{
				Updateable = true,
				ColumnSize = 3,
				ProviderType = 10,
				IsKey = true,
				BaseSchemaName = "Sales",
				BaseTableName = "CountryRegionCurrency",
				BaseColumnName = "CurrencyCode"
			});

			schema_array.Add(new VenturaSqlColumn("ModifiedDate", typeof(DateTime), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 23,
				NumericScale = 3,
				ProviderType = 4,
				BaseSchemaName = "Sales",
				BaseTableName = "CountryRegionCurrency",
				BaseColumnName = "ModifiedDate"
			});

			((IResultsetBase)this).Schema = new VenturaSqlSchema(schema_array);
			((IResultsetBase)this).UpdateableTablename = "[Sales].[CountryRegionCurrency]";
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[CountryRegionCurrency]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public string CountryRegionCode
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.CountryRegionCode; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.CountryRegionCode = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[CountryRegionCurrency]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public string CurrencyCode
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.CurrencyCode; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.CurrencyCode = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[CountryRegionCurrency]. NotReadonly. NotNull.
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
			this.InsertItem(index, new GetAll_Sales_CountryRegionCurrency_Record());
			this.CurrentRecordIndex = index;
		}

		public void Append(GetAll_Sales_CountryRegionCurrency_Record record)
		{
			int index = this.RecordCount;
			this.InsertItem(index, record);
			this.CurrentRecordIndex = index;
		}

		public GetAll_Sales_CountryRegionCurrency_Record NewRecord()
		{
			return new GetAll_Sales_CountryRegionCurrency_Record();
		}

		protected override GetAll_Sales_CountryRegionCurrency_Record InternalCreateExistingRecordObject(object[] columnvalues) => new GetAll_Sales_CountryRegionCurrency_Record(columnvalues);

		byte[] IRecordsetBase.Hash
		{
			get { return new byte[] { 135, 82, 199, 102, 205, 233, 42, 149, 15, 146, 70, 177, 242, 17, 8, 60 }; }
		}

		string IRecordsetBase.HashString
		{
			get { return "8752C766CDE92A950F9246B1F211083C"; }
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

	public sealed partial class GetAll_Sales_CountryRegionCurrency_Record : IRecordBase, INotifyPropertyChanged
	{
		private DataRecordStatus _recordstatus;
		private bool _started_with_dbvalues;

		private string _cur__CountryRegionCode; private string _ori__CountryRegionCode; private bool _mod__CountryRegionCode;
		private string _cur__CurrencyCode; private string _ori__CurrencyCode; private bool _mod__CurrencyCode;
		private DateTime _cur__ModifiedDate; private DateTime _ori__ModifiedDate; private bool _mod__ModifiedDate;


		public GetAll_Sales_CountryRegionCurrency_Record()
		{
			_cur__CountryRegionCode = "";
			_cur__CurrencyCode = "";
			_cur__ModifiedDate = new DateTime(1900, 1, 1);
			_started_with_dbvalues = false;
			_recordstatus = DataRecordStatus.New;
		}

		public GetAll_Sales_CountryRegionCurrency_Record(object[] columnvalues)
		{
			_cur__CountryRegionCode = (string)columnvalues[0];
			_cur__CurrencyCode = (string)columnvalues[1];
			_cur__ModifiedDate = (DateTime)columnvalues[2];
			_started_with_dbvalues = true;
			_recordstatus = DataRecordStatus.Existing;
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[CountryRegionCurrency]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public string CountryRegionCode
		{
			get { return _cur__CountryRegionCode; }
			set
			{
				if (value == null) throw new ArgumentNullException("CountryRegionCode", VenturaSqlStrings.SET_NULL_MSG);
				if (_started_with_dbvalues == false) _mod__CountryRegionCode = true;
				if (_cur__CountryRegionCode == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__CountryRegionCode == false) { _ori__CountryRegionCode = _cur__CountryRegionCode; _mod__CountryRegionCode = true; } // existing record and column is not modified
					else { if (value == _ori__CountryRegionCode) { _ori__CountryRegionCode = default(string); _mod__CountryRegionCode = false; } } // existing record and column is modified
				}
				_cur__CountryRegionCode = value; OnPropertyChanged("CountryRegionCode"); OnAfterPropertyChanged("CountryRegionCode");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[CountryRegionCurrency]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public string CurrencyCode
		{
			get { return _cur__CurrencyCode; }
			set
			{
				if (value == null) throw new ArgumentNullException("CurrencyCode", VenturaSqlStrings.SET_NULL_MSG);
				if (_started_with_dbvalues == false) _mod__CurrencyCode = true;
				if (_cur__CurrencyCode == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__CurrencyCode == false) { _ori__CurrencyCode = _cur__CurrencyCode; _mod__CurrencyCode = true; } // existing record and column is not modified
					else { if (value == _ori__CurrencyCode) { _ori__CurrencyCode = default(string); _mod__CurrencyCode = false; } } // existing record and column is modified
				}
				_cur__CurrencyCode = value; OnPropertyChanged("CurrencyCode"); OnAfterPropertyChanged("CurrencyCode");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[CountryRegionCurrency]. NotReadonly. NotNull.
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
			if (column_name == "CountryRegionCode") return _mod__CountryRegionCode;
			if (column_name == "CurrencyCode") return _mod__CurrencyCode;
			if (column_name == "ModifiedDate") return _mod__ModifiedDate;
			throw new ArgumentOutOfRangeException(String.Format(VenturaSqlStrings.UNKNOWN_COLUMN_NAME, column_name));
		}

		public int ModifiedColumnCount()
		{
			int count = 0;
			if (_mod__CountryRegionCode == true) count++;
			if (_mod__CurrencyCode == true) count++;
			if (_mod__ModifiedDate == true) count++;
			return count;
		}

		public bool PendingChanges()
		{
			if (_recordstatus == DataRecordStatus.New || _recordstatus == DataRecordStatus.ExistingDelete) return true;
			int count = 0;
			if (_started_with_dbvalues)
			{
				if (_mod__CountryRegionCode) count++;
				if (_mod__CurrencyCode) count++;
			}
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
			if (_mod__CountryRegionCode == false) throw new Exception(string.Format(VenturaSqlStrings.VALUE_NOT_SET_MSG, record_index_to_display, "CountryRegionCode"));
			if (_mod__CurrencyCode == false) throw new Exception(string.Format(VenturaSqlStrings.VALUE_NOT_SET_MSG, record_index_to_display, "CurrencyCode"));
		}

		void IRecordBase.WriteChangesToTrackArray(TrackArray track_array)
		{
			if (_recordstatus == DataRecordStatus.New)
			{
				track_array.AppendDataValue(0, _cur__CountryRegionCode);
				track_array.AppendDataValue(1, _cur__CurrencyCode);
				track_array.AppendDataValue(2, _cur__ModifiedDate);
			}
			else if (_recordstatus == DataRecordStatus.Existing)
			{
				if (_started_with_dbvalues)
				{
					if (_mod__CountryRegionCode) track_array.AppendDataValue(0, _cur__CountryRegionCode);
					if (_mod__CurrencyCode) track_array.AppendDataValue(1, _cur__CurrencyCode);
				}
				if (_mod__ModifiedDate) track_array.AppendDataValue(2, _cur__ModifiedDate);
				if (track_array.HasData == false) return;
			}

			if (_recordstatus == DataRecordStatus.Existing || _recordstatus == DataRecordStatus.ExistingDelete)
			{
				track_array.AppendPrikeyValue(0, (_mod__CountryRegionCode && _started_with_dbvalues) ? _ori__CountryRegionCode : _cur__CountryRegionCode);
				track_array.AppendPrikeyValue(1, (_mod__CurrencyCode && _started_with_dbvalues) ? _ori__CurrencyCode : _cur__CurrencyCode);
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
				if (_mod__CountryRegionCode) _ori__CountryRegionCode = default(string);
				if (_mod__CurrencyCode) _ori__CurrencyCode = default(string);
				if (_mod__ModifiedDate) _ori__ModifiedDate = default(DateTime);
			}
			_mod__CountryRegionCode = false;
			_mod__CurrencyCode = false;
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
namespace WpfClient.VenturaAutoCreate
{
	public partial class GetAll_Sales_CountryRegionCurrency_Record
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
