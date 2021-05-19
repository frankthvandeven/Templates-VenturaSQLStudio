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
	/// The updateable table is [Production].[ProductCostHistory]. Updateable table column information:
	/// • 5 out of 5 table columns are present in the resultset.
	/// • All primary key columns are present in the resultset: ProductID and StartDate.
	/// • Non-primary key columns present in the resultset: EndDate, StandardCost and ModifiedDate.
	/// Recordset item automatically created by VenturaSQL Studio.
	/// </summary>
	public partial class GetAll_Production_ProductCostHistory_Recordset : ResultsetObservable<GetAll_Production_ProductCostHistory_Recordset, GetAll_Production_ProductCostHistory_Record>, IRecordsetBase
	{
		private IResultsetBase[] _resultsets;
		private string _sqlscript;
		private int _rowlimit = 500;
		private const string CRLF = "\r\n";

		public GetAll_Production_ProductCostHistory_Recordset()
		{
			_resultsets = new IResultsetBase[] { this };

			_sqlscript = @"SELECT TOP(@RowLimit) [ProductID],[StartDate],[EndDate],[StandardCost],[ModifiedDate]" + CRLF +
			             @"FROM [Production].[ProductCostHistory]";

			ColumnArrayBuilder schema_array = new ColumnArrayBuilder();

			schema_array.Add(new VenturaSqlColumn("ProductID", typeof(int), false)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				IsKey = true,
				BaseSchemaName = "Production",
				BaseTableName = "ProductCostHistory",
				BaseColumnName = "ProductID"
			});

			schema_array.Add(new VenturaSqlColumn("StartDate", typeof(DateTime), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 23,
				NumericScale = 3,
				ProviderType = 4,
				IsKey = true,
				BaseSchemaName = "Production",
				BaseTableName = "ProductCostHistory",
				BaseColumnName = "StartDate"
			});

			schema_array.Add(new VenturaSqlColumn("EndDate", typeof(DateTime), true)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 23,
				NumericScale = 3,
				ProviderType = 4,
				BaseSchemaName = "Production",
				BaseTableName = "ProductCostHistory",
				BaseColumnName = "EndDate"
			});

			schema_array.Add(new VenturaSqlColumn("StandardCost", typeof(decimal), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 19,
				ProviderType = 9,
				BaseSchemaName = "Production",
				BaseTableName = "ProductCostHistory",
				BaseColumnName = "StandardCost"
			});

			schema_array.Add(new VenturaSqlColumn("ModifiedDate", typeof(DateTime), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 23,
				NumericScale = 3,
				ProviderType = 4,
				BaseSchemaName = "Production",
				BaseTableName = "ProductCostHistory",
				BaseColumnName = "ModifiedDate"
			});

			((IResultsetBase)this).Schema = new VenturaSqlSchema(schema_array);
			((IResultsetBase)this).UpdateableTablename = "[Production].[ProductCostHistory]";
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductCostHistory]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public int ProductID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ProductID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ProductID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductCostHistory]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public DateTime StartDate
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.StartDate; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.StartDate = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductCostHistory]. NotReadonly. AllowNull.
		/// </summary>
		public DateTime? EndDate
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.EndDate; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.EndDate = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductCostHistory]. NotReadonly. NotNull.
		/// </summary>
		public decimal StandardCost
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.StandardCost; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.StandardCost = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductCostHistory]. NotReadonly. NotNull.
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
			this.InsertItem(index, new GetAll_Production_ProductCostHistory_Record());
			this.CurrentRecordIndex = index;
		}

		public void Append(GetAll_Production_ProductCostHistory_Record record)
		{
			int index = this.RecordCount;
			this.InsertItem(index, record);
			this.CurrentRecordIndex = index;
		}

		public GetAll_Production_ProductCostHistory_Record NewRecord()
		{
			return new GetAll_Production_ProductCostHistory_Record();
		}

		protected override GetAll_Production_ProductCostHistory_Record InternalCreateExistingRecordObject(object[] columnvalues) => new GetAll_Production_ProductCostHistory_Record(columnvalues);

		byte[] IRecordsetBase.Hash
		{
			get { return new byte[] { 188, 231, 193, 39, 146, 122, 23, 154, 157, 204, 66, 83, 223, 117, 81, 12 }; }
		}

		string IRecordsetBase.HashString
		{
			get { return "BCE7C127927A179A9DCC4253DF75510C"; }
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

	public sealed partial class GetAll_Production_ProductCostHistory_Record : IRecordBase, INotifyPropertyChanged
	{
		private DataRecordStatus _recordstatus;
		private bool _started_with_dbvalues;

		private int _cur__ProductID; private int _ori__ProductID; private bool _mod__ProductID;
		private DateTime _cur__StartDate; private DateTime _ori__StartDate; private bool _mod__StartDate;
		private DateTime? _cur__EndDate; private DateTime? _ori__EndDate; private bool _mod__EndDate;
		private decimal _cur__StandardCost; private decimal _ori__StandardCost; private bool _mod__StandardCost;
		private DateTime _cur__ModifiedDate; private DateTime _ori__ModifiedDate; private bool _mod__ModifiedDate;


		public GetAll_Production_ProductCostHistory_Record()
		{
			_cur__ProductID = 0;
			_cur__StartDate = new DateTime(1900, 1, 1);
			_cur__EndDate = null;
			_cur__StandardCost = 0.0m;
			_cur__ModifiedDate = new DateTime(1900, 1, 1);
			_started_with_dbvalues = false;
			_recordstatus = DataRecordStatus.New;
		}

		public GetAll_Production_ProductCostHistory_Record(object[] columnvalues)
		{
			_cur__ProductID = (int)columnvalues[0];
			_cur__StartDate = (DateTime)columnvalues[1];
			_cur__EndDate = (DateTime?)columnvalues[2];
			_cur__StandardCost = (decimal)columnvalues[3];
			_cur__ModifiedDate = (DateTime)columnvalues[4];
			_started_with_dbvalues = true;
			_recordstatus = DataRecordStatus.Existing;
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductCostHistory]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public int ProductID
		{
			get { return _cur__ProductID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ProductID = true;
				if (_cur__ProductID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ProductID == false) { _ori__ProductID = _cur__ProductID; _mod__ProductID = true; } // existing record and column is not modified
					else { if (value == _ori__ProductID) { _ori__ProductID = default(int); _mod__ProductID = false; } } // existing record and column is modified
				}
				_cur__ProductID = value; OnPropertyChanged("ProductID"); OnAfterPropertyChanged("ProductID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductCostHistory]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public DateTime StartDate
		{
			get { return _cur__StartDate; }
			set
			{
				if (_started_with_dbvalues == false) _mod__StartDate = true;
				if (_cur__StartDate == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__StartDate == false) { _ori__StartDate = _cur__StartDate; _mod__StartDate = true; } // existing record and column is not modified
					else { if (value == _ori__StartDate) { _ori__StartDate = default(DateTime); _mod__StartDate = false; } } // existing record and column is modified
				}
				_cur__StartDate = value; OnPropertyChanged("StartDate"); OnAfterPropertyChanged("StartDate");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductCostHistory]. NotReadonly. AllowNull.
		/// </summary>
		public DateTime? EndDate
		{
			get { return _cur__EndDate; }
			set
			{
				if (_started_with_dbvalues == false) _mod__EndDate = true;
				if (_cur__EndDate == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__EndDate == false) { _ori__EndDate = _cur__EndDate; _mod__EndDate = true; } // existing record and column is not modified
					else { if (value == _ori__EndDate) { _ori__EndDate = default(DateTime?); _mod__EndDate = false; } } // existing record and column is modified
				}
				_cur__EndDate = value; OnPropertyChanged("EndDate"); OnAfterPropertyChanged("EndDate");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductCostHistory]. NotReadonly. NotNull.
		/// </summary>
		public decimal StandardCost
		{
			get { return _cur__StandardCost; }
			set
			{
				if (_started_with_dbvalues == false) _mod__StandardCost = true;
				if (_cur__StandardCost == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__StandardCost == false) { _ori__StandardCost = _cur__StandardCost; _mod__StandardCost = true; } // existing record and column is not modified
					else { if (value == _ori__StandardCost) { _ori__StandardCost = default(decimal); _mod__StandardCost = false; } } // existing record and column is modified
				}
				_cur__StandardCost = value; OnPropertyChanged("StandardCost"); OnAfterPropertyChanged("StandardCost");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductCostHistory]. NotReadonly. NotNull.
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
			if (column_name == "ProductID") return _mod__ProductID;
			if (column_name == "StartDate") return _mod__StartDate;
			if (column_name == "EndDate") return _mod__EndDate;
			if (column_name == "StandardCost") return _mod__StandardCost;
			if (column_name == "ModifiedDate") return _mod__ModifiedDate;
			throw new ArgumentOutOfRangeException(String.Format(VenturaSqlStrings.UNKNOWN_COLUMN_NAME, column_name));
		}

		public int ModifiedColumnCount()
		{
			int count = 0;
			if (_mod__ProductID == true) count++;
			if (_mod__StartDate == true) count++;
			if (_mod__EndDate == true) count++;
			if (_mod__StandardCost == true) count++;
			if (_mod__ModifiedDate == true) count++;
			return count;
		}

		public bool PendingChanges()
		{
			if (_recordstatus == DataRecordStatus.New || _recordstatus == DataRecordStatus.ExistingDelete) return true;
			int count = 0;
			if (_started_with_dbvalues)
			{
				if (_mod__ProductID) count++;
				if (_mod__StartDate) count++;
			}
			if (_mod__EndDate == true) count++;
			if (_mod__StandardCost == true) count++;
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
			if (_mod__ProductID == false) throw new Exception(string.Format(VenturaSqlStrings.VALUE_NOT_SET_MSG, record_index_to_display, "ProductID"));
			if (_mod__StartDate == false) throw new Exception(string.Format(VenturaSqlStrings.VALUE_NOT_SET_MSG, record_index_to_display, "StartDate"));
		}

		void IRecordBase.WriteChangesToTrackArray(TrackArray track_array)
		{
			if (_recordstatus == DataRecordStatus.New)
			{
				track_array.AppendDataValue(0, _cur__ProductID);
				track_array.AppendDataValue(1, _cur__StartDate);
				if (_cur__EndDate != null) track_array.AppendDataValue(2, _cur__EndDate);
				track_array.AppendDataValue(3, _cur__StandardCost);
				track_array.AppendDataValue(4, _cur__ModifiedDate);
			}
			else if (_recordstatus == DataRecordStatus.Existing)
			{
				if (_started_with_dbvalues)
				{
					if (_mod__ProductID) track_array.AppendDataValue(0, _cur__ProductID);
					if (_mod__StartDate) track_array.AppendDataValue(1, _cur__StartDate);
				}
				if (_mod__EndDate) track_array.AppendDataValue(2, _cur__EndDate);
				if (_mod__StandardCost) track_array.AppendDataValue(3, _cur__StandardCost);
				if (_mod__ModifiedDate) track_array.AppendDataValue(4, _cur__ModifiedDate);
				if (track_array.HasData == false) return;
			}

			if (_recordstatus == DataRecordStatus.Existing || _recordstatus == DataRecordStatus.ExistingDelete)
			{
				track_array.AppendPrikeyValue(0, (_mod__ProductID && _started_with_dbvalues) ? _ori__ProductID : _cur__ProductID);
				track_array.AppendPrikeyValue(1, (_mod__StartDate && _started_with_dbvalues) ? _ori__StartDate : _cur__StartDate);
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
				if (_mod__ProductID) _ori__ProductID = default(int);
				if (_mod__StartDate) _ori__StartDate = default(DateTime);
				if (_mod__EndDate) _ori__EndDate = default(DateTime?);
				if (_mod__StandardCost) _ori__StandardCost = default(decimal);
				if (_mod__ModifiedDate) _ori__ModifiedDate = default(DateTime);
			}
			_mod__ProductID = false;
			_mod__StartDate = false;
			_mod__EndDate = false;
			_mod__StandardCost = false;
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
	public partial class GetAll_Production_ProductCostHistory_Record
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
