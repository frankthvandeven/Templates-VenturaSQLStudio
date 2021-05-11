/*
	Project file: "C:\Active\VenturaSQL\BuildSystem\Templates\BlazorVentura\BlazorVentura.venproj"
	Target platform: NETStandard
	Generator version: 4.0.126
	Generated on: Tuesday, 11 May 2021 at 12:03:58
	At the bottom of this file you find a template for extending Recordsets with calculated columns for XAML data binding.
*/
using VenturaSQL;
using System;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel;

namespace BlazorVentura.Server.VenturaAutoCreate
{
	/// <summary>
	/// The updateable table is [PaymentTypes]. Updateable table column information:
	/// • 2 out of 2 table columns are present in the resultset.
	/// • All primary key columns are present in the resultset: PaymentTypeID.
	/// • Non-primary key column present in the resultset: Name.
	/// Recordset item automatically created by VenturaSQL Studio.
	/// </summary>
	public partial class PriKey_PaymentTypes_Recordset : ResultsetObservable<PriKey_PaymentTypes_Recordset, PriKey_PaymentTypes_Record>, IRecordsetBase
	{
		private IResultsetBase[] _resultsets;
		private string _sqlscript;
		private object[] _inputparametervalues;
		private InputParamHolder _inputparamholder;
		private VenturaSqlSchema _parameterschema;
		private int _rowlimit = 500;
		private const string CRLF = "\r\n";

		public PriKey_PaymentTypes_Recordset()
		{
			_resultsets = new IResultsetBase[] { this };

			_sqlscript = @"SELECT [PaymentTypeID],[Name]" + CRLF +
			             @"FROM [PaymentTypes]" + CRLF +
			             @"WHERE [PaymentTypeID] = @PaymentTypeID";

			_inputparametervalues = new object[1];
			_inputparamholder = new InputParamHolder(_inputparametervalues);

			ColumnArrayBuilder param_array = new ColumnArrayBuilder();

			param_array.AddParameterColumn("@PaymentTypeID", typeof(long), true, false, DbType.Int64, null, null, null);

			_parameterschema = new VenturaSqlSchema(param_array);

			ColumnArrayBuilder schema_array = new ColumnArrayBuilder();

			schema_array.Add(new VenturaSqlColumn("PaymentTypeID", typeof(long), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 19,
				NumericScale = 0,
				ProviderType = 12,
				IsUnique = true,
				IsKey = true,
				BaseCatalogName = "main",
				BaseTableName = "PaymentTypes",
				BaseColumnName = "PaymentTypeID"
			});

			schema_array.Add(new VenturaSqlColumn("Name", typeof(string), false)
			{
				Updateable = true,
				ProviderType = 16,
				BaseCatalogName = "main",
				BaseTableName = "PaymentTypes",
				BaseColumnName = "Name"
			});

			((IResultsetBase)this).Schema = new VenturaSqlSchema(schema_array);
			((IResultsetBase)this).UpdateableTablename = "[PaymentTypes]";
		}

		/// <summary>
		/// Database Column Updateable. Table [PaymentTypes]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public long PaymentTypeID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.PaymentTypeID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.PaymentTypeID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [PaymentTypes]. NotReadonly. NotNull.
		/// </summary>
		public string Name
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Name; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Name = value; }
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
			this.InsertItem(index, new PriKey_PaymentTypes_Record());
			this.CurrentRecordIndex = index;
		}

		public void Append(PriKey_PaymentTypes_Record record)
		{
			int index = this.RecordCount;
			this.InsertItem(index, record);
			this.CurrentRecordIndex = index;
		}

		public PriKey_PaymentTypes_Record NewRecord()
		{
			return new PriKey_PaymentTypes_Record();
		}

		protected override PriKey_PaymentTypes_Record InternalCreateExistingRecordObject(object[] columnvalues) => new PriKey_PaymentTypes_Record(columnvalues);

		byte[] IRecordsetBase.Hash
		{
			get { return new byte[] { 19, 176, 113, 102, 160, 70, 194, 99, 162, 47, 62, 163, 244, 42, 147, 254 }; }
		}

		string IRecordsetBase.HashString
		{
			get { return "13B07166A046C263A22F3EA3F42A93FE"; }
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
			get { return new DateTime(2021, 5, 11, 12, 3, 58); } // Tuesday, 11 May 2021 at 12:03:58
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

		public void SetExecSqlParams(long? PaymentTypeID)
		{
			_inputparametervalues[0] = PaymentTypeID;
		}

		public void ExecSql(long? PaymentTypeID)
		{
			_inputparametervalues[0] = PaymentTypeID;
			Transactional.ExecSql(VenturaSqlConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public void ExecSql(Connector connector, long? PaymentTypeID)
		{
			_inputparametervalues[0] = PaymentTypeID;
			Transactional.ExecSql(connector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync(long? PaymentTypeID)
		{
			_inputparametervalues[0] = PaymentTypeID;
			await Transactional.ExecSqlAsync(VenturaSqlConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync(Connector connector, long? PaymentTypeID)
		{
			_inputparametervalues[0] = PaymentTypeID;
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

			public long? PaymentTypeID
			{
				get { return (long?)_values[0]; }
				set { _values[0] = value; }
			}

		}

	}

	public sealed partial class PriKey_PaymentTypes_Record : IRecordBase, INotifyPropertyChanged
	{
		private DataRecordStatus _recordstatus;
		private bool _started_with_dbvalues;

		private long _cur__PaymentTypeID; private long _ori__PaymentTypeID; private bool _mod__PaymentTypeID;
		private string _cur__Name; private string _ori__Name; private bool _mod__Name;


		public PriKey_PaymentTypes_Record()
		{
			_cur__PaymentTypeID = 0;
			_cur__Name = "";
			_started_with_dbvalues = false;
			_recordstatus = DataRecordStatus.New;
		}

		public PriKey_PaymentTypes_Record(object[] columnvalues)
		{
			_cur__PaymentTypeID = (long)columnvalues[0];
			_cur__Name = (string)columnvalues[1];
			_started_with_dbvalues = true;
			_recordstatus = DataRecordStatus.Existing;
		}

		/// <summary>
		/// Database Column Updateable. Table [PaymentTypes]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public long PaymentTypeID
		{
			get { return _cur__PaymentTypeID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__PaymentTypeID = true;
				if (_cur__PaymentTypeID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__PaymentTypeID == false) { _ori__PaymentTypeID = _cur__PaymentTypeID; _mod__PaymentTypeID = true; } // existing record and column is not modified
					else { if (value == _ori__PaymentTypeID) { _ori__PaymentTypeID = default(long); _mod__PaymentTypeID = false; } } // existing record and column is modified
				}
				_cur__PaymentTypeID = value; OnPropertyChanged("PaymentTypeID"); OnAfterPropertyChanged("PaymentTypeID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [PaymentTypes]. NotReadonly. NotNull.
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

		public bool IsModified(string column_name)
		{
			if (column_name == "PaymentTypeID") return _mod__PaymentTypeID;
			if (column_name == "Name") return _mod__Name;
			throw new ArgumentOutOfRangeException(String.Format(VenturaSqlStrings.UNKNOWN_COLUMN_NAME, column_name));
		}

		public int ModifiedColumnCount()
		{
			int count = 0;
			if (_mod__PaymentTypeID == true) count++;
			if (_mod__Name == true) count++;
			return count;
		}

		public bool PendingChanges()
		{
			if (_recordstatus == DataRecordStatus.New || _recordstatus == DataRecordStatus.ExistingDelete) return true;
			int count = 0;
			if (_started_with_dbvalues)
			{
				if (_mod__PaymentTypeID) count++;
			}
			if (_mod__Name == true) count++;
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
			if (_mod__PaymentTypeID == false) throw new Exception(string.Format(VenturaSqlStrings.VALUE_NOT_SET_MSG, record_index_to_display, "PaymentTypeID"));
		}

		void IRecordBase.WriteChangesToTrackArray(TrackArray track_array)
		{
			if (_recordstatus == DataRecordStatus.New)
			{
				track_array.AppendDataValue(0, _cur__PaymentTypeID);
				track_array.AppendDataValue(1, _cur__Name);
			}
			else if (_recordstatus == DataRecordStatus.Existing)
			{
				if (_started_with_dbvalues)
				{
					if (_mod__PaymentTypeID) track_array.AppendDataValue(0, _cur__PaymentTypeID);
				}
				if (_mod__Name) track_array.AppendDataValue(1, _cur__Name);
				if (track_array.HasData == false) return;
			}

			if (_recordstatus == DataRecordStatus.Existing || _recordstatus == DataRecordStatus.ExistingDelete)
			{
				track_array.AppendPrikeyValue(0, (_mod__PaymentTypeID && _started_with_dbvalues) ? _ori__PaymentTypeID : _cur__PaymentTypeID);
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
				if (_mod__PaymentTypeID) _ori__PaymentTypeID = default(long);
				if (_mod__Name) _ori__Name = default(string);
			}
			_mod__PaymentTypeID = false;
			_mod__Name = false;
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
namespace BlazorVentura.Server.VenturaAutoCreate
{
	public partial class PriKey_PaymentTypes_Record
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
