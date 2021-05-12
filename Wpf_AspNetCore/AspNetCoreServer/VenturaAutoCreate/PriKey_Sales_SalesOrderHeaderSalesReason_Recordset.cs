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
	/// The updateable table is [Sales].[SalesOrderHeaderSalesReason]. Updateable table column information:
	/// • 3 out of 3 table columns are present in the resultset.
	/// • All primary key columns are present in the resultset: SalesOrderID and SalesReasonID.
	/// • Non-primary key column present in the resultset: ModifiedDate.
	/// Recordset item automatically created by VenturaSQL Studio.
	/// </summary>
	public partial class PriKey_Sales_SalesOrderHeaderSalesReason_Recordset : ResultsetObservable<PriKey_Sales_SalesOrderHeaderSalesReason_Recordset, PriKey_Sales_SalesOrderHeaderSalesReason_Record>, IRecordsetBase
	{
		private IResultsetBase[] _resultsets;
		private string _sqlscript;
		private object[] _inputparametervalues;
		private InputParamHolder _inputparamholder;
		private VenturaSqlSchema _parameterschema;
		private int _rowlimit = 500;
		private const string CRLF = "\r\n";

		public PriKey_Sales_SalesOrderHeaderSalesReason_Recordset()
		{
			_resultsets = new IResultsetBase[] { this };

			_sqlscript = @"SELECT [SalesOrderID],[SalesReasonID],[ModifiedDate]" + CRLF +
			             @"FROM [Sales].[SalesOrderHeaderSalesReason]" + CRLF +
			             @"WHERE [SalesOrderID] = @SalesOrderID" + CRLF +
			             @"AND [SalesReasonID] = @SalesReasonID";

			_inputparametervalues = new object[2];
			_inputparamholder = new InputParamHolder(_inputparametervalues);

			ColumnArrayBuilder param_array = new ColumnArrayBuilder();

			param_array.AddParameterColumn("@SalesOrderID", typeof(int), true, false, DbType.Int32, null, null, null);
			param_array.AddParameterColumn("@SalesReasonID", typeof(int), true, false, DbType.Int32, null, null, null);

			_parameterschema = new VenturaSqlSchema(param_array);

			ColumnArrayBuilder schema_array = new ColumnArrayBuilder();

			schema_array.Add(new VenturaSqlColumn("SalesOrderID", typeof(int), false)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				IsKey = true,
				BaseSchemaName = "Sales",
				BaseTableName = "SalesOrderHeaderSalesReason",
				BaseColumnName = "SalesOrderID"
			});

			schema_array.Add(new VenturaSqlColumn("SalesReasonID", typeof(int), false)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				IsKey = true,
				BaseSchemaName = "Sales",
				BaseTableName = "SalesOrderHeaderSalesReason",
				BaseColumnName = "SalesReasonID"
			});

			schema_array.Add(new VenturaSqlColumn("ModifiedDate", typeof(DateTime), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 23,
				NumericScale = 3,
				ProviderType = 4,
				BaseSchemaName = "Sales",
				BaseTableName = "SalesOrderHeaderSalesReason",
				BaseColumnName = "ModifiedDate"
			});

			((IResultsetBase)this).Schema = new VenturaSqlSchema(schema_array);
			((IResultsetBase)this).UpdateableTablename = "[Sales].[SalesOrderHeaderSalesReason]";
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderHeaderSalesReason]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public int SalesOrderID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.SalesOrderID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.SalesOrderID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderHeaderSalesReason]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public int SalesReasonID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.SalesReasonID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.SalesReasonID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderHeaderSalesReason]. NotReadonly. NotNull.
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
			this.InsertItem(index, new PriKey_Sales_SalesOrderHeaderSalesReason_Record());
			this.CurrentRecordIndex = index;
		}

		public void Append(PriKey_Sales_SalesOrderHeaderSalesReason_Record record)
		{
			int index = this.RecordCount;
			this.InsertItem(index, record);
			this.CurrentRecordIndex = index;
		}

		public PriKey_Sales_SalesOrderHeaderSalesReason_Record NewRecord()
		{
			return new PriKey_Sales_SalesOrderHeaderSalesReason_Record();
		}

		protected override PriKey_Sales_SalesOrderHeaderSalesReason_Record InternalCreateExistingRecordObject(object[] columnvalues) => new PriKey_Sales_SalesOrderHeaderSalesReason_Record(columnvalues);

		byte[] IRecordsetBase.Hash
		{
			get { return new byte[] { 153, 12, 238, 252, 128, 118, 79, 234, 142, 216, 66, 104, 170, 220, 186, 56 }; }
		}

		string IRecordsetBase.HashString
		{
			get { return "990CEEFC80764FEA8ED84268AADCBA38"; }
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

		public void SetExecSqlParams(int? SalesOrderID, int? SalesReasonID)
		{
			_inputparametervalues[0] = SalesOrderID;
			_inputparametervalues[1] = SalesReasonID;
		}

		public void ExecSql(int? SalesOrderID, int? SalesReasonID)
		{
			_inputparametervalues[0] = SalesOrderID;
			_inputparametervalues[1] = SalesReasonID;
			Transactional.ExecSql(VenturaSqlConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public void ExecSql(Connector connector, int? SalesOrderID, int? SalesReasonID)
		{
			_inputparametervalues[0] = SalesOrderID;
			_inputparametervalues[1] = SalesReasonID;
			Transactional.ExecSql(connector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync(int? SalesOrderID, int? SalesReasonID)
		{
			_inputparametervalues[0] = SalesOrderID;
			_inputparametervalues[1] = SalesReasonID;
			await Transactional.ExecSqlAsync(VenturaSqlConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync(Connector connector, int? SalesOrderID, int? SalesReasonID)
		{
			_inputparametervalues[0] = SalesOrderID;
			_inputparametervalues[1] = SalesReasonID;
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

			public int? SalesOrderID
			{
				get { return (int?)_values[0]; }
				set { _values[0] = value; }
			}

			public int? SalesReasonID
			{
				get { return (int?)_values[1]; }
				set { _values[1] = value; }
			}

		}

	}

	public sealed partial class PriKey_Sales_SalesOrderHeaderSalesReason_Record : IRecordBase, INotifyPropertyChanged
	{
		private DataRecordStatus _recordstatus;
		private bool _started_with_dbvalues;

		private int _cur__SalesOrderID; private int _ori__SalesOrderID; private bool _mod__SalesOrderID;
		private int _cur__SalesReasonID; private int _ori__SalesReasonID; private bool _mod__SalesReasonID;
		private DateTime _cur__ModifiedDate; private DateTime _ori__ModifiedDate; private bool _mod__ModifiedDate;


		public PriKey_Sales_SalesOrderHeaderSalesReason_Record()
		{
			_cur__SalesOrderID = 0;
			_cur__SalesReasonID = 0;
			_cur__ModifiedDate = new DateTime(1900, 1, 1);
			_started_with_dbvalues = false;
			_recordstatus = DataRecordStatus.New;
		}

		public PriKey_Sales_SalesOrderHeaderSalesReason_Record(object[] columnvalues)
		{
			_cur__SalesOrderID = (int)columnvalues[0];
			_cur__SalesReasonID = (int)columnvalues[1];
			_cur__ModifiedDate = (DateTime)columnvalues[2];
			_started_with_dbvalues = true;
			_recordstatus = DataRecordStatus.Existing;
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderHeaderSalesReason]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public int SalesOrderID
		{
			get { return _cur__SalesOrderID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__SalesOrderID = true;
				if (_cur__SalesOrderID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__SalesOrderID == false) { _ori__SalesOrderID = _cur__SalesOrderID; _mod__SalesOrderID = true; } // existing record and column is not modified
					else { if (value == _ori__SalesOrderID) { _ori__SalesOrderID = default(int); _mod__SalesOrderID = false; } } // existing record and column is modified
				}
				_cur__SalesOrderID = value; OnPropertyChanged("SalesOrderID"); OnAfterPropertyChanged("SalesOrderID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderHeaderSalesReason]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public int SalesReasonID
		{
			get { return _cur__SalesReasonID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__SalesReasonID = true;
				if (_cur__SalesReasonID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__SalesReasonID == false) { _ori__SalesReasonID = _cur__SalesReasonID; _mod__SalesReasonID = true; } // existing record and column is not modified
					else { if (value == _ori__SalesReasonID) { _ori__SalesReasonID = default(int); _mod__SalesReasonID = false; } } // existing record and column is modified
				}
				_cur__SalesReasonID = value; OnPropertyChanged("SalesReasonID"); OnAfterPropertyChanged("SalesReasonID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderHeaderSalesReason]. NotReadonly. NotNull.
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
			if (column_name == "SalesOrderID") return _mod__SalesOrderID;
			if (column_name == "SalesReasonID") return _mod__SalesReasonID;
			if (column_name == "ModifiedDate") return _mod__ModifiedDate;
			throw new ArgumentOutOfRangeException(String.Format(VenturaSqlStrings.UNKNOWN_COLUMN_NAME, column_name));
		}

		public int ModifiedColumnCount()
		{
			int count = 0;
			if (_mod__SalesOrderID == true) count++;
			if (_mod__SalesReasonID == true) count++;
			if (_mod__ModifiedDate == true) count++;
			return count;
		}

		public bool PendingChanges()
		{
			if (_recordstatus == DataRecordStatus.New || _recordstatus == DataRecordStatus.ExistingDelete) return true;
			int count = 0;
			if (_started_with_dbvalues)
			{
				if (_mod__SalesOrderID) count++;
				if (_mod__SalesReasonID) count++;
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
			if (_mod__SalesOrderID == false) throw new Exception(string.Format(VenturaSqlStrings.VALUE_NOT_SET_MSG, record_index_to_display, "SalesOrderID"));
			if (_mod__SalesReasonID == false) throw new Exception(string.Format(VenturaSqlStrings.VALUE_NOT_SET_MSG, record_index_to_display, "SalesReasonID"));
		}

		void IRecordBase.WriteChangesToTrackArray(TrackArray track_array)
		{
			if (_recordstatus == DataRecordStatus.New)
			{
				track_array.AppendDataValue(0, _cur__SalesOrderID);
				track_array.AppendDataValue(1, _cur__SalesReasonID);
				track_array.AppendDataValue(2, _cur__ModifiedDate);
			}
			else if (_recordstatus == DataRecordStatus.Existing)
			{
				if (_started_with_dbvalues)
				{
					if (_mod__SalesOrderID) track_array.AppendDataValue(0, _cur__SalesOrderID);
					if (_mod__SalesReasonID) track_array.AppendDataValue(1, _cur__SalesReasonID);
				}
				if (_mod__ModifiedDate) track_array.AppendDataValue(2, _cur__ModifiedDate);
				if (track_array.HasData == false) return;
			}

			if (_recordstatus == DataRecordStatus.Existing || _recordstatus == DataRecordStatus.ExistingDelete)
			{
				track_array.AppendPrikeyValue(0, (_mod__SalesOrderID && _started_with_dbvalues) ? _ori__SalesOrderID : _cur__SalesOrderID);
				track_array.AppendPrikeyValue(1, (_mod__SalesReasonID && _started_with_dbvalues) ? _ori__SalesReasonID : _cur__SalesReasonID);
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
				if (_mod__SalesOrderID) _ori__SalesOrderID = default(int);
				if (_mod__SalesReasonID) _ori__SalesReasonID = default(int);
				if (_mod__ModifiedDate) _ori__ModifiedDate = default(DateTime);
			}
			_mod__SalesOrderID = false;
			_mod__SalesReasonID = false;
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
	public partial class PriKey_Sales_SalesOrderHeaderSalesReason_Record
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
