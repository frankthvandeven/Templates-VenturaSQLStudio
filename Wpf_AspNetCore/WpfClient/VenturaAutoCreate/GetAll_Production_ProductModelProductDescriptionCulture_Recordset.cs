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
	/// The updateable table is [Production].[ProductModelProductDescriptionCulture]. Updateable table column information:
	/// • 4 out of 4 table columns are present in the resultset.
	/// • All primary key columns are present in the resultset: ProductModelID, ProductDescriptionID and CultureID.
	/// • Non-primary key column present in the resultset: ModifiedDate.
	/// Recordset item automatically created by VenturaSQL Studio.
	/// </summary>
	public partial class GetAll_Production_ProductModelProductDescriptionCulture_Recordset : ResultsetObservable<GetAll_Production_ProductModelProductDescriptionCulture_Recordset, GetAll_Production_ProductModelProductDescriptionCulture_Record>, IRecordsetBase
	{
		private IResultsetBase[] _resultsets;
		private string _sqlscript;
		private int _rowlimit = 500;
		private const string CRLF = "\r\n";

		public GetAll_Production_ProductModelProductDescriptionCulture_Recordset()
		{
			_resultsets = new IResultsetBase[] { this };

			_sqlscript = @"SELECT [ProductModelID],[ProductDescriptionID],[CultureID],[ModifiedDate]" + CRLF +
			             @"FROM [Production].[ProductModelProductDescriptionCulture]";

			ColumnArrayBuilder schema_array = new ColumnArrayBuilder();

			schema_array.Add(new VenturaSqlColumn("ProductModelID", typeof(int), false)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				IsKey = true,
				BaseSchemaName = "Production",
				BaseTableName = "ProductModelProductDescriptionCulture",
				BaseColumnName = "ProductModelID"
			});

			schema_array.Add(new VenturaSqlColumn("ProductDescriptionID", typeof(int), false)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				IsKey = true,
				BaseSchemaName = "Production",
				BaseTableName = "ProductModelProductDescriptionCulture",
				BaseColumnName = "ProductDescriptionID"
			});

			schema_array.Add(new VenturaSqlColumn("CultureID", typeof(string), false)
			{
				Updateable = true,
				ColumnSize = 6,
				ProviderType = 10,
				IsKey = true,
				BaseSchemaName = "Production",
				BaseTableName = "ProductModelProductDescriptionCulture",
				BaseColumnName = "CultureID"
			});

			schema_array.Add(new VenturaSqlColumn("ModifiedDate", typeof(DateTime), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 23,
				NumericScale = 3,
				ProviderType = 4,
				BaseSchemaName = "Production",
				BaseTableName = "ProductModelProductDescriptionCulture",
				BaseColumnName = "ModifiedDate"
			});

			((IResultsetBase)this).Schema = new VenturaSqlSchema(schema_array);
			((IResultsetBase)this).UpdateableTablename = "[Production].[ProductModelProductDescriptionCulture]";
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductModelProductDescriptionCulture]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public int ProductModelID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ProductModelID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ProductModelID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductModelProductDescriptionCulture]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public int ProductDescriptionID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ProductDescriptionID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ProductDescriptionID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductModelProductDescriptionCulture]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public string CultureID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.CultureID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.CultureID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductModelProductDescriptionCulture]. NotReadonly. NotNull.
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
			this.InsertItem(index, new GetAll_Production_ProductModelProductDescriptionCulture_Record());
			this.CurrentRecordIndex = index;
		}

		public void Append(GetAll_Production_ProductModelProductDescriptionCulture_Record record)
		{
			int index = this.RecordCount;
			this.InsertItem(index, record);
			this.CurrentRecordIndex = index;
		}

		public GetAll_Production_ProductModelProductDescriptionCulture_Record NewRecord()
		{
			return new GetAll_Production_ProductModelProductDescriptionCulture_Record();
		}

		protected override GetAll_Production_ProductModelProductDescriptionCulture_Record InternalCreateExistingRecordObject(object[] columnvalues) => new GetAll_Production_ProductModelProductDescriptionCulture_Record(columnvalues);

		byte[] IRecordsetBase.Hash
		{
			get { return new byte[] { 234, 186, 47, 61, 65, 59, 93, 71, 132, 64, 83, 110, 59, 20, 8, 112 }; }
		}

		string IRecordsetBase.HashString
		{
			get { return "EABA2F3D413B5D478440536E3B140870"; }
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

	public sealed partial class GetAll_Production_ProductModelProductDescriptionCulture_Record : IRecordBase, INotifyPropertyChanged
	{
		private DataRecordStatus _recordstatus;
		private bool _started_with_dbvalues;

		private int _cur__ProductModelID; private int _ori__ProductModelID; private bool _mod__ProductModelID;
		private int _cur__ProductDescriptionID; private int _ori__ProductDescriptionID; private bool _mod__ProductDescriptionID;
		private string _cur__CultureID; private string _ori__CultureID; private bool _mod__CultureID;
		private DateTime _cur__ModifiedDate; private DateTime _ori__ModifiedDate; private bool _mod__ModifiedDate;


		public GetAll_Production_ProductModelProductDescriptionCulture_Record()
		{
			_cur__ProductModelID = 0;
			_cur__ProductDescriptionID = 0;
			_cur__CultureID = "";
			_cur__ModifiedDate = new DateTime(1900, 1, 1);
			_started_with_dbvalues = false;
			_recordstatus = DataRecordStatus.New;
		}

		public GetAll_Production_ProductModelProductDescriptionCulture_Record(object[] columnvalues)
		{
			_cur__ProductModelID = (int)columnvalues[0];
			_cur__ProductDescriptionID = (int)columnvalues[1];
			_cur__CultureID = (string)columnvalues[2];
			_cur__ModifiedDate = (DateTime)columnvalues[3];
			_started_with_dbvalues = true;
			_recordstatus = DataRecordStatus.Existing;
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductModelProductDescriptionCulture]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public int ProductModelID
		{
			get { return _cur__ProductModelID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ProductModelID = true;
				if (_cur__ProductModelID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ProductModelID == false) { _ori__ProductModelID = _cur__ProductModelID; _mod__ProductModelID = true; } // existing record and column is not modified
					else { if (value == _ori__ProductModelID) { _ori__ProductModelID = default(int); _mod__ProductModelID = false; } } // existing record and column is modified
				}
				_cur__ProductModelID = value; OnPropertyChanged("ProductModelID"); OnAfterPropertyChanged("ProductModelID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductModelProductDescriptionCulture]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public int ProductDescriptionID
		{
			get { return _cur__ProductDescriptionID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ProductDescriptionID = true;
				if (_cur__ProductDescriptionID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ProductDescriptionID == false) { _ori__ProductDescriptionID = _cur__ProductDescriptionID; _mod__ProductDescriptionID = true; } // existing record and column is not modified
					else { if (value == _ori__ProductDescriptionID) { _ori__ProductDescriptionID = default(int); _mod__ProductDescriptionID = false; } } // existing record and column is modified
				}
				_cur__ProductDescriptionID = value; OnPropertyChanged("ProductDescriptionID"); OnAfterPropertyChanged("ProductDescriptionID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductModelProductDescriptionCulture]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public string CultureID
		{
			get { return _cur__CultureID; }
			set
			{
				if (value == null) throw new ArgumentNullException("CultureID", VenturaSqlStrings.SET_NULL_MSG);
				if (_started_with_dbvalues == false) _mod__CultureID = true;
				if (_cur__CultureID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__CultureID == false) { _ori__CultureID = _cur__CultureID; _mod__CultureID = true; } // existing record and column is not modified
					else { if (value == _ori__CultureID) { _ori__CultureID = default(string); _mod__CultureID = false; } } // existing record and column is modified
				}
				_cur__CultureID = value; OnPropertyChanged("CultureID"); OnAfterPropertyChanged("CultureID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductModelProductDescriptionCulture]. NotReadonly. NotNull.
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
			if (column_name == "ProductModelID") return _mod__ProductModelID;
			if (column_name == "ProductDescriptionID") return _mod__ProductDescriptionID;
			if (column_name == "CultureID") return _mod__CultureID;
			if (column_name == "ModifiedDate") return _mod__ModifiedDate;
			throw new ArgumentOutOfRangeException(String.Format(VenturaSqlStrings.UNKNOWN_COLUMN_NAME, column_name));
		}

		public int ModifiedColumnCount()
		{
			int count = 0;
			if (_mod__ProductModelID == true) count++;
			if (_mod__ProductDescriptionID == true) count++;
			if (_mod__CultureID == true) count++;
			if (_mod__ModifiedDate == true) count++;
			return count;
		}

		public bool PendingChanges()
		{
			if (_recordstatus == DataRecordStatus.New || _recordstatus == DataRecordStatus.ExistingDelete) return true;
			int count = 0;
			if (_started_with_dbvalues)
			{
				if (_mod__ProductModelID) count++;
				if (_mod__ProductDescriptionID) count++;
				if (_mod__CultureID) count++;
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
			if (_mod__ProductModelID == false) throw new Exception(string.Format(VenturaSqlStrings.VALUE_NOT_SET_MSG, record_index_to_display, "ProductModelID"));
			if (_mod__ProductDescriptionID == false) throw new Exception(string.Format(VenturaSqlStrings.VALUE_NOT_SET_MSG, record_index_to_display, "ProductDescriptionID"));
			if (_mod__CultureID == false) throw new Exception(string.Format(VenturaSqlStrings.VALUE_NOT_SET_MSG, record_index_to_display, "CultureID"));
		}

		void IRecordBase.WriteChangesToTrackArray(TrackArray track_array)
		{
			if (_recordstatus == DataRecordStatus.New)
			{
				track_array.AppendDataValue(0, _cur__ProductModelID);
				track_array.AppendDataValue(1, _cur__ProductDescriptionID);
				track_array.AppendDataValue(2, _cur__CultureID);
				track_array.AppendDataValue(3, _cur__ModifiedDate);
			}
			else if (_recordstatus == DataRecordStatus.Existing)
			{
				if (_started_with_dbvalues)
				{
					if (_mod__ProductModelID) track_array.AppendDataValue(0, _cur__ProductModelID);
					if (_mod__ProductDescriptionID) track_array.AppendDataValue(1, _cur__ProductDescriptionID);
					if (_mod__CultureID) track_array.AppendDataValue(2, _cur__CultureID);
				}
				if (_mod__ModifiedDate) track_array.AppendDataValue(3, _cur__ModifiedDate);
				if (track_array.HasData == false) return;
			}

			if (_recordstatus == DataRecordStatus.Existing || _recordstatus == DataRecordStatus.ExistingDelete)
			{
				track_array.AppendPrikeyValue(0, (_mod__ProductModelID && _started_with_dbvalues) ? _ori__ProductModelID : _cur__ProductModelID);
				track_array.AppendPrikeyValue(1, (_mod__ProductDescriptionID && _started_with_dbvalues) ? _ori__ProductDescriptionID : _cur__ProductDescriptionID);
				track_array.AppendPrikeyValue(2, (_mod__CultureID && _started_with_dbvalues) ? _ori__CultureID : _cur__CultureID);
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
				if (_mod__ProductModelID) _ori__ProductModelID = default(int);
				if (_mod__ProductDescriptionID) _ori__ProductDescriptionID = default(int);
				if (_mod__CultureID) _ori__CultureID = default(string);
				if (_mod__ModifiedDate) _ori__ModifiedDate = default(DateTime);
			}
			_mod__ProductModelID = false;
			_mod__ProductDescriptionID = false;
			_mod__CultureID = false;
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
	public partial class GetAll_Production_ProductModelProductDescriptionCulture_Record
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
