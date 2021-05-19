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
	/// The updateable table is [Sales].[CreditCard]. Updateable table column information:
	/// • 6 out of 6 table columns are present in the resultset.
	/// • All primary key columns are present in the resultset: CreditCardID.
	/// • Non-primary key columns present in the resultset: CardType, CardNumber, ExpMonth, ExpYear and ModifiedDate.
	/// Recordset item automatically created by VenturaSQL Studio.
	/// </summary>
	public partial class PriKey_Sales_CreditCard_Recordset : ResultsetObservable<PriKey_Sales_CreditCard_Recordset, PriKey_Sales_CreditCard_Record>, IRecordsetBase
	{
		private IResultsetBase[] _resultsets;
		private string _sqlscript;
		private object[] _inputparametervalues;
		private InputParamHolder _inputparamholder;
		private VenturaSqlSchema _parameterschema;
		private int _rowlimit = 500;
		private const string CRLF = "\r\n";

		public PriKey_Sales_CreditCard_Recordset()
		{
			_resultsets = new IResultsetBase[] { this };

			_sqlscript = @"SELECT [CreditCardID],[CardType],[CardNumber],[ExpMonth],[ExpYear],[ModifiedDate]" + CRLF +
			             @"FROM [Sales].[CreditCard]" + CRLF +
			             @"WHERE [CreditCardID] = @CreditCardID";

			_inputparametervalues = new object[1];
			_inputparamholder = new InputParamHolder(_inputparametervalues);

			ColumnArrayBuilder param_array = new ColumnArrayBuilder();

			param_array.AddParameterColumn("@CreditCardID", typeof(int), true, false, DbType.Int32, null, null, null);

			_parameterschema = new VenturaSqlSchema(param_array);

			ColumnArrayBuilder schema_array = new ColumnArrayBuilder();

			schema_array.Add(new VenturaSqlColumn("CreditCardID", typeof(int), false)
			{
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				IsKey = true,
				IsIdentity = true,
				IsAutoIncrement = true,
				BaseSchemaName = "Sales",
				BaseTableName = "CreditCard",
				BaseColumnName = "CreditCardID"
			});

			schema_array.Add(new VenturaSqlColumn("CardType", typeof(string), false)
			{
				Updateable = true,
				ColumnSize = 50,
				ProviderType = 12,
				BaseSchemaName = "Sales",
				BaseTableName = "CreditCard",
				BaseColumnName = "CardType"
			});

			schema_array.Add(new VenturaSqlColumn("CardNumber", typeof(string), false)
			{
				Updateable = true,
				ColumnSize = 25,
				ProviderType = 12,
				BaseSchemaName = "Sales",
				BaseTableName = "CreditCard",
				BaseColumnName = "CardNumber"
			});

			schema_array.Add(new VenturaSqlColumn("ExpMonth", typeof(byte), false)
			{
				Updateable = true,
				ColumnSize = 1,
				NumericPrecision = 3,
				ProviderType = 20,
				BaseSchemaName = "Sales",
				BaseTableName = "CreditCard",
				BaseColumnName = "ExpMonth"
			});

			schema_array.Add(new VenturaSqlColumn("ExpYear", typeof(short), false)
			{
				Updateable = true,
				ColumnSize = 2,
				NumericPrecision = 5,
				ProviderType = 16,
				BaseSchemaName = "Sales",
				BaseTableName = "CreditCard",
				BaseColumnName = "ExpYear"
			});

			schema_array.Add(new VenturaSqlColumn("ModifiedDate", typeof(DateTime), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 23,
				NumericScale = 3,
				ProviderType = 4,
				BaseSchemaName = "Sales",
				BaseTableName = "CreditCard",
				BaseColumnName = "ModifiedDate"
			});

			((IResultsetBase)this).Schema = new VenturaSqlSchema(schema_array);
			((IResultsetBase)this).UpdateableTablename = "[Sales].[CreditCard]";
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Sales].[CreditCard]. PrimaryKey. NotReadonly. NotNull. IsIdentity. AutoIncrement.
		/// </summary>
		public int CreditCardID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.CreditCardID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.CreditCardID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[CreditCard]. NotReadonly. NotNull.
		/// </summary>
		public string CardType
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.CardType; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.CardType = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[CreditCard]. NotReadonly. NotNull.
		/// </summary>
		public string CardNumber
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.CardNumber; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.CardNumber = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[CreditCard]. NotReadonly. NotNull.
		/// </summary>
		public byte ExpMonth
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ExpMonth; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ExpMonth = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[CreditCard]. NotReadonly. NotNull.
		/// </summary>
		public short ExpYear
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ExpYear; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ExpYear = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[CreditCard]. NotReadonly. NotNull.
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
			this.InsertItem(index, new PriKey_Sales_CreditCard_Record());
			this.CurrentRecordIndex = index;
		}

		public void Append(PriKey_Sales_CreditCard_Record record)
		{
			int index = this.RecordCount;
			this.InsertItem(index, record);
			this.CurrentRecordIndex = index;
		}

		public PriKey_Sales_CreditCard_Record NewRecord()
		{
			return new PriKey_Sales_CreditCard_Record();
		}

		protected override PriKey_Sales_CreditCard_Record InternalCreateExistingRecordObject(object[] columnvalues) => new PriKey_Sales_CreditCard_Record(columnvalues);

		byte[] IRecordsetBase.Hash
		{
			get { return new byte[] { 209, 155, 146, 228, 225, 102, 52, 234, 155, 48, 235, 180, 2, 226, 239, 57 }; }
		}

		string IRecordsetBase.HashString
		{
			get { return "D19B92E4E16634EA9B30EBB402E2EF39"; }
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
			get { return _parameterschema; }
		}

		/// <summary>
		/// For internal use by VenturaSQL only. Use SetExecSqlParams() instead.
		/// </summary>
		object[] IRecordsetBase.InputParameterValues
		{
			get { return _inputparametervalues; }
		}

		/// <summary>
		/// For internal use by VenturaSQL only. Use Output property instead.
		/// </summary>
		object[] IRecordsetBase.OutputParameterValues
		{
			get { return null; }
		}

		public InputParamHolder InputParam
		{
			get { return _inputparamholder; }
		}

		public int RowLimit
		{
			get { return _rowlimit; }
			set { _rowlimit = value; }
		}

		public void SetExecSqlParams(int? CreditCardID)
		{
			_inputparametervalues[0] = CreditCardID;
		}

		public void ExecSql(int? CreditCardID)
		{
			_inputparametervalues[0] = CreditCardID;
			Transactional.ExecSql(VenturaSqlConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public void ExecSql(Connector connector, int? CreditCardID)
		{
			_inputparametervalues[0] = CreditCardID;
			Transactional.ExecSql(connector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync(int? CreditCardID)
		{
			_inputparametervalues[0] = CreditCardID;
			await Transactional.ExecSqlAsync(VenturaSqlConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync(Connector connector, int? CreditCardID)
		{
			_inputparametervalues[0] = CreditCardID;
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

		public class InputParamHolder
		{
			private object[] _values;

			public InputParamHolder(object[] values)
			{
				_values = values;
			}

			public int? CreditCardID
			{
				get { return (int?)_values[0]; }
				set { _values[0] = value; }
			}

		}

	}

	public sealed partial class PriKey_Sales_CreditCard_Record : IRecordBase, INotifyPropertyChanged
	{
		private DataRecordStatus _recordstatus;
		private bool _started_with_dbvalues;

		private int _cur__CreditCardID; private int _ori__CreditCardID; private bool _mod__CreditCardID;
		private string _cur__CardType; private string _ori__CardType; private bool _mod__CardType;
		private string _cur__CardNumber; private string _ori__CardNumber; private bool _mod__CardNumber;
		private byte _cur__ExpMonth; private byte _ori__ExpMonth; private bool _mod__ExpMonth;
		private short _cur__ExpYear; private short _ori__ExpYear; private bool _mod__ExpYear;
		private DateTime _cur__ModifiedDate; private DateTime _ori__ModifiedDate; private bool _mod__ModifiedDate;


		public PriKey_Sales_CreditCard_Record()
		{
			_cur__CreditCardID = 0;
			_cur__CardType = "";
			_cur__CardNumber = "";
			_cur__ExpMonth = 0;
			_cur__ExpYear = 0;
			_cur__ModifiedDate = new DateTime(1900, 1, 1);
			_started_with_dbvalues = false;
			_recordstatus = DataRecordStatus.New;
		}

		public PriKey_Sales_CreditCard_Record(object[] columnvalues)
		{
			_cur__CreditCardID = (int)columnvalues[0];
			_cur__CardType = (string)columnvalues[1];
			_cur__CardNumber = (string)columnvalues[2];
			_cur__ExpMonth = (byte)columnvalues[3];
			_cur__ExpYear = (short)columnvalues[4];
			_cur__ModifiedDate = (DateTime)columnvalues[5];
			_started_with_dbvalues = true;
			_recordstatus = DataRecordStatus.Existing;
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Sales].[CreditCard]. PrimaryKey. NotReadonly. NotNull. IsIdentity. AutoIncrement.
		/// </summary>
		public int CreditCardID
		{
			get { return _cur__CreditCardID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__CreditCardID = true;
				if (_cur__CreditCardID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__CreditCardID == false) { _ori__CreditCardID = _cur__CreditCardID; _mod__CreditCardID = true; } // existing record and column is not modified
					else { if (value == _ori__CreditCardID) { _ori__CreditCardID = default(int); _mod__CreditCardID = false; } } // existing record and column is modified
				}
				_cur__CreditCardID = value; OnPropertyChanged("CreditCardID"); OnAfterPropertyChanged("CreditCardID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[CreditCard]. NotReadonly. NotNull.
		/// </summary>
		public string CardType
		{
			get { return _cur__CardType; }
			set
			{
				if (value == null) throw new ArgumentNullException("CardType", VenturaSqlStrings.SET_NULL_MSG);
				if (_started_with_dbvalues == false) _mod__CardType = true;
				if (_cur__CardType == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__CardType == false) { _ori__CardType = _cur__CardType; _mod__CardType = true; } // existing record and column is not modified
					else { if (value == _ori__CardType) { _ori__CardType = default(string); _mod__CardType = false; } } // existing record and column is modified
				}
				_cur__CardType = value; OnPropertyChanged("CardType"); OnAfterPropertyChanged("CardType");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[CreditCard]. NotReadonly. NotNull.
		/// </summary>
		public string CardNumber
		{
			get { return _cur__CardNumber; }
			set
			{
				if (value == null) throw new ArgumentNullException("CardNumber", VenturaSqlStrings.SET_NULL_MSG);
				if (_started_with_dbvalues == false) _mod__CardNumber = true;
				if (_cur__CardNumber == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__CardNumber == false) { _ori__CardNumber = _cur__CardNumber; _mod__CardNumber = true; } // existing record and column is not modified
					else { if (value == _ori__CardNumber) { _ori__CardNumber = default(string); _mod__CardNumber = false; } } // existing record and column is modified
				}
				_cur__CardNumber = value; OnPropertyChanged("CardNumber"); OnAfterPropertyChanged("CardNumber");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[CreditCard]. NotReadonly. NotNull.
		/// </summary>
		public byte ExpMonth
		{
			get { return _cur__ExpMonth; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ExpMonth = true;
				if (_cur__ExpMonth == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ExpMonth == false) { _ori__ExpMonth = _cur__ExpMonth; _mod__ExpMonth = true; } // existing record and column is not modified
					else { if (value == _ori__ExpMonth) { _ori__ExpMonth = default(byte); _mod__ExpMonth = false; } } // existing record and column is modified
				}
				_cur__ExpMonth = value; OnPropertyChanged("ExpMonth"); OnAfterPropertyChanged("ExpMonth");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[CreditCard]. NotReadonly. NotNull.
		/// </summary>
		public short ExpYear
		{
			get { return _cur__ExpYear; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ExpYear = true;
				if (_cur__ExpYear == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ExpYear == false) { _ori__ExpYear = _cur__ExpYear; _mod__ExpYear = true; } // existing record and column is not modified
					else { if (value == _ori__ExpYear) { _ori__ExpYear = default(short); _mod__ExpYear = false; } } // existing record and column is modified
				}
				_cur__ExpYear = value; OnPropertyChanged("ExpYear"); OnAfterPropertyChanged("ExpYear");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[CreditCard]. NotReadonly. NotNull.
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
			if (column_name == "CreditCardID") return _mod__CreditCardID;
			if (column_name == "CardType") return _mod__CardType;
			if (column_name == "CardNumber") return _mod__CardNumber;
			if (column_name == "ExpMonth") return _mod__ExpMonth;
			if (column_name == "ExpYear") return _mod__ExpYear;
			if (column_name == "ModifiedDate") return _mod__ModifiedDate;
			throw new ArgumentOutOfRangeException(String.Format(VenturaSqlStrings.UNKNOWN_COLUMN_NAME, column_name));
		}

		public int ModifiedColumnCount()
		{
			int count = 0;
			if (_mod__CreditCardID == true) count++;
			if (_mod__CardType == true) count++;
			if (_mod__CardNumber == true) count++;
			if (_mod__ExpMonth == true) count++;
			if (_mod__ExpYear == true) count++;
			if (_mod__ModifiedDate == true) count++;
			return count;
		}

		public bool PendingChanges()
		{
			if (_recordstatus == DataRecordStatus.New || _recordstatus == DataRecordStatus.ExistingDelete) return true;
			int count = 0;
			if (_mod__CardType == true) count++;
			if (_mod__CardNumber == true) count++;
			if (_mod__ExpMonth == true) count++;
			if (_mod__ExpYear == true) count++;
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
				track_array.AppendDataValue(1, _cur__CardType);
				track_array.AppendDataValue(2, _cur__CardNumber);
				track_array.AppendDataValue(3, _cur__ExpMonth);
				track_array.AppendDataValue(4, _cur__ExpYear);
				track_array.AppendDataValue(5, _cur__ModifiedDate);
			}
			else if (_recordstatus == DataRecordStatus.Existing)
			{
				if (_mod__CardType) track_array.AppendDataValue(1, _cur__CardType);
				if (_mod__CardNumber) track_array.AppendDataValue(2, _cur__CardNumber);
				if (_mod__ExpMonth) track_array.AppendDataValue(3, _cur__ExpMonth);
				if (_mod__ExpYear) track_array.AppendDataValue(4, _cur__ExpYear);
				if (_mod__ModifiedDate) track_array.AppendDataValue(5, _cur__ModifiedDate);
				if (track_array.HasData == false) return;
			}

			if (_recordstatus == DataRecordStatus.Existing || _recordstatus == DataRecordStatus.ExistingDelete)
			{
				track_array.AppendPrikeyValue(0, (_mod__CreditCardID && _started_with_dbvalues) ? _ori__CreditCardID : _cur__CreditCardID);
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
				if (_mod__CreditCardID) _ori__CreditCardID = default(int);
				if (_mod__CardType) _ori__CardType = default(string);
				if (_mod__CardNumber) _ori__CardNumber = default(string);
				if (_mod__ExpMonth) _ori__ExpMonth = default(byte);
				if (_mod__ExpYear) _ori__ExpYear = default(short);
				if (_mod__ModifiedDate) _ori__ModifiedDate = default(DateTime);
			}
			_mod__CreditCardID = false;
			_mod__CardType = false;
			_mod__CardNumber = false;
			_mod__ExpMonth = false;
			_mod__ExpYear = false;
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
			_cur__CreditCardID = (int)value;
			OnPropertyChanged("CreditCardID");
			OnAfterPropertyChanged("CreditCardID");
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
	public partial class PriKey_Sales_CreditCard_Record
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
