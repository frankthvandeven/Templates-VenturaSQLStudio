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
	/// The updateable table is [Production].[ProductProductPhoto]. Updateable table column information:
	/// • 4 out of 4 table columns are present in the resultset.
	/// • All primary key columns are present in the resultset: ProductID and ProductPhotoID.
	/// • Non-primary key columns present in the resultset: Primary and ModifiedDate.
	/// Recordset item automatically created by VenturaSQL Studio.
	/// </summary>
	public partial class PriKey_Production_ProductProductPhoto_Recordset : ResultsetObservable<PriKey_Production_ProductProductPhoto_Recordset, PriKey_Production_ProductProductPhoto_Record>, IRecordsetBase
	{
		private IResultsetBase[] _resultsets;
		private string _sqlscript;
		private object[] _inputparametervalues;
		private InputParamHolder _inputparamholder;
		private VenturaSqlSchema _parameterschema;
		private int _rowlimit = 500;
		private const string CRLF = "\r\n";

		public PriKey_Production_ProductProductPhoto_Recordset()
		{
			_resultsets = new IResultsetBase[] { this };

			_sqlscript = @"SELECT [ProductID],[ProductPhotoID],[Primary],[ModifiedDate]" + CRLF +
			             @"FROM [Production].[ProductProductPhoto]" + CRLF +
			             @"WHERE [ProductID] = @ProductID" + CRLF +
			             @"AND [ProductPhotoID] = @ProductPhotoID";

			_inputparametervalues = new object[2];
			_inputparamholder = new InputParamHolder(_inputparametervalues);

			ColumnArrayBuilder param_array = new ColumnArrayBuilder();

			param_array.AddParameterColumn("@ProductID", typeof(int), true, false, DbType.Int32, null, null, null);
			param_array.AddParameterColumn("@ProductPhotoID", typeof(int), true, false, DbType.Int32, null, null, null);

			_parameterschema = new VenturaSqlSchema(param_array);

			ColumnArrayBuilder schema_array = new ColumnArrayBuilder();

			schema_array.Add(new VenturaSqlColumn("ProductID", typeof(int), false)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				IsKey = true,
				BaseSchemaName = "Production",
				BaseTableName = "ProductProductPhoto",
				BaseColumnName = "ProductID"
			});

			schema_array.Add(new VenturaSqlColumn("ProductPhotoID", typeof(int), false)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				IsKey = true,
				BaseSchemaName = "Production",
				BaseTableName = "ProductProductPhoto",
				BaseColumnName = "ProductPhotoID"
			});

			schema_array.Add(new VenturaSqlColumn("Primary", typeof(bool), false)
			{
				Updateable = true,
				ColumnSize = 1,
				ProviderType = 2,
				BaseSchemaName = "Production",
				BaseTableName = "ProductProductPhoto",
				BaseColumnName = "Primary"
			});

			schema_array.Add(new VenturaSqlColumn("ModifiedDate", typeof(DateTime), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 23,
				NumericScale = 3,
				ProviderType = 4,
				BaseSchemaName = "Production",
				BaseTableName = "ProductProductPhoto",
				BaseColumnName = "ModifiedDate"
			});

			((IResultsetBase)this).Schema = new VenturaSqlSchema(schema_array);
			((IResultsetBase)this).UpdateableTablename = "[Production].[ProductProductPhoto]";
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductProductPhoto]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public int ProductID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ProductID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ProductID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductProductPhoto]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public int ProductPhotoID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ProductPhotoID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ProductPhotoID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductProductPhoto]. NotReadonly. NotNull.
		/// </summary>
		public bool Primary
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Primary; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Primary = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductProductPhoto]. NotReadonly. NotNull.
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
			this.InsertItem(index, new PriKey_Production_ProductProductPhoto_Record());
			this.CurrentRecordIndex = index;
		}

		public void Append(PriKey_Production_ProductProductPhoto_Record record)
		{
			int index = this.RecordCount;
			this.InsertItem(index, record);
			this.CurrentRecordIndex = index;
		}

		public PriKey_Production_ProductProductPhoto_Record NewRecord()
		{
			return new PriKey_Production_ProductProductPhoto_Record();
		}

		protected override PriKey_Production_ProductProductPhoto_Record InternalCreateExistingRecordObject(object[] columnvalues) => new PriKey_Production_ProductProductPhoto_Record(columnvalues);

		byte[] IRecordsetBase.Hash
		{
			get { return new byte[] { 81, 47, 77, 103, 124, 199, 201, 31, 140, 84, 125, 211, 211, 235, 30, 121 }; }
		}

		string IRecordsetBase.HashString
		{
			get { return "512F4D677CC7C91F8C547DD3D3EB1E79"; }
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

		public void SetExecSqlParams(int? ProductID, int? ProductPhotoID)
		{
			_inputparametervalues[0] = ProductID;
			_inputparametervalues[1] = ProductPhotoID;
		}

		public void ExecSql(int? ProductID, int? ProductPhotoID)
		{
			_inputparametervalues[0] = ProductID;
			_inputparametervalues[1] = ProductPhotoID;
			Transactional.ExecSql(VenturaSqlConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public void ExecSql(Connector connector, int? ProductID, int? ProductPhotoID)
		{
			_inputparametervalues[0] = ProductID;
			_inputparametervalues[1] = ProductPhotoID;
			Transactional.ExecSql(connector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync(int? ProductID, int? ProductPhotoID)
		{
			_inputparametervalues[0] = ProductID;
			_inputparametervalues[1] = ProductPhotoID;
			await Transactional.ExecSqlAsync(VenturaSqlConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync(Connector connector, int? ProductID, int? ProductPhotoID)
		{
			_inputparametervalues[0] = ProductID;
			_inputparametervalues[1] = ProductPhotoID;
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

			public int? ProductID
			{
				get { return (int?)_values[0]; }
				set { _values[0] = value; }
			}

			public int? ProductPhotoID
			{
				get { return (int?)_values[1]; }
				set { _values[1] = value; }
			}

		}

	}

	public sealed partial class PriKey_Production_ProductProductPhoto_Record : IRecordBase, INotifyPropertyChanged
	{
		private DataRecordStatus _recordstatus;
		private bool _started_with_dbvalues;

		private int _cur__ProductID; private int _ori__ProductID; private bool _mod__ProductID;
		private int _cur__ProductPhotoID; private int _ori__ProductPhotoID; private bool _mod__ProductPhotoID;
		private bool _cur__Primary; private bool _ori__Primary; private bool _mod__Primary;
		private DateTime _cur__ModifiedDate; private DateTime _ori__ModifiedDate; private bool _mod__ModifiedDate;


		public PriKey_Production_ProductProductPhoto_Record()
		{
			_cur__ProductID = 0;
			_cur__ProductPhotoID = 0;
			_cur__Primary = false;
			_cur__ModifiedDate = new DateTime(1900, 1, 1);
			_started_with_dbvalues = false;
			_recordstatus = DataRecordStatus.New;
		}

		public PriKey_Production_ProductProductPhoto_Record(object[] columnvalues)
		{
			_cur__ProductID = (int)columnvalues[0];
			_cur__ProductPhotoID = (int)columnvalues[1];
			_cur__Primary = (bool)columnvalues[2];
			_cur__ModifiedDate = (DateTime)columnvalues[3];
			_started_with_dbvalues = true;
			_recordstatus = DataRecordStatus.Existing;
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductProductPhoto]. PrimaryKey. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [Production].[ProductProductPhoto]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public int ProductPhotoID
		{
			get { return _cur__ProductPhotoID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ProductPhotoID = true;
				if (_cur__ProductPhotoID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ProductPhotoID == false) { _ori__ProductPhotoID = _cur__ProductPhotoID; _mod__ProductPhotoID = true; } // existing record and column is not modified
					else { if (value == _ori__ProductPhotoID) { _ori__ProductPhotoID = default(int); _mod__ProductPhotoID = false; } } // existing record and column is modified
				}
				_cur__ProductPhotoID = value; OnPropertyChanged("ProductPhotoID"); OnAfterPropertyChanged("ProductPhotoID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductProductPhoto]. NotReadonly. NotNull.
		/// </summary>
		public bool Primary
		{
			get { return _cur__Primary; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Primary = true;
				if (_cur__Primary == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Primary == false) { _ori__Primary = _cur__Primary; _mod__Primary = true; } // existing record and column is not modified
					else { if (value == _ori__Primary) { _ori__Primary = default(bool); _mod__Primary = false; } } // existing record and column is modified
				}
				_cur__Primary = value; OnPropertyChanged("Primary"); OnAfterPropertyChanged("Primary");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductProductPhoto]. NotReadonly. NotNull.
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
			if (column_name == "ProductPhotoID") return _mod__ProductPhotoID;
			if (column_name == "Primary") return _mod__Primary;
			if (column_name == "ModifiedDate") return _mod__ModifiedDate;
			throw new ArgumentOutOfRangeException(String.Format(VenturaSqlStrings.UNKNOWN_COLUMN_NAME, column_name));
		}

		public int ModifiedColumnCount()
		{
			int count = 0;
			if (_mod__ProductID == true) count++;
			if (_mod__ProductPhotoID == true) count++;
			if (_mod__Primary == true) count++;
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
				if (_mod__ProductPhotoID) count++;
			}
			if (_mod__Primary == true) count++;
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
			if (_mod__ProductPhotoID == false) throw new Exception(string.Format(VenturaSqlStrings.VALUE_NOT_SET_MSG, record_index_to_display, "ProductPhotoID"));
		}

		void IRecordBase.WriteChangesToTrackArray(TrackArray track_array)
		{
			if (_recordstatus == DataRecordStatus.New)
			{
				track_array.AppendDataValue(0, _cur__ProductID);
				track_array.AppendDataValue(1, _cur__ProductPhotoID);
				track_array.AppendDataValue(2, _cur__Primary);
				track_array.AppendDataValue(3, _cur__ModifiedDate);
			}
			else if (_recordstatus == DataRecordStatus.Existing)
			{
				if (_started_with_dbvalues)
				{
					if (_mod__ProductID) track_array.AppendDataValue(0, _cur__ProductID);
					if (_mod__ProductPhotoID) track_array.AppendDataValue(1, _cur__ProductPhotoID);
				}
				if (_mod__Primary) track_array.AppendDataValue(2, _cur__Primary);
				if (_mod__ModifiedDate) track_array.AppendDataValue(3, _cur__ModifiedDate);
				if (track_array.HasData == false) return;
			}

			if (_recordstatus == DataRecordStatus.Existing || _recordstatus == DataRecordStatus.ExistingDelete)
			{
				track_array.AppendPrikeyValue(0, (_mod__ProductID && _started_with_dbvalues) ? _ori__ProductID : _cur__ProductID);
				track_array.AppendPrikeyValue(1, (_mod__ProductPhotoID && _started_with_dbvalues) ? _ori__ProductPhotoID : _cur__ProductPhotoID);
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
				if (_mod__ProductPhotoID) _ori__ProductPhotoID = default(int);
				if (_mod__Primary) _ori__Primary = default(bool);
				if (_mod__ModifiedDate) _ori__ModifiedDate = default(DateTime);
			}
			_mod__ProductID = false;
			_mod__ProductPhotoID = false;
			_mod__Primary = false;
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
	public partial class PriKey_Production_ProductProductPhoto_Record
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
