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
	/// The updateable table is [Production].[ProductInventory]. Updateable table column information:
	/// • 7 out of 7 table columns are present in the resultset.
	/// • All primary key columns are present in the resultset: ProductID and LocationID.
	/// • Non-primary key columns present in the resultset: Shelf, Bin, Quantity, rowguid and ModifiedDate.
	/// Recordset item automatically created by VenturaSQL Studio.
	/// </summary>
	public partial class PriKey_Production_ProductInventory_Recordset : ResultsetObservable<PriKey_Production_ProductInventory_Recordset, PriKey_Production_ProductInventory_Record>, IRecordsetBase
	{
		private IResultsetBase[] _resultsets;
		private string _sqlscript;
		private object[] _inputparametervalues;
		private InputParamHolder _inputparamholder;
		private VenturaSqlSchema _parameterschema;
		private int _rowlimit = 500;
		private const string CRLF = "\r\n";

		public PriKey_Production_ProductInventory_Recordset()
		{
			_resultsets = new IResultsetBase[] { this };

			_sqlscript = @"SELECT [ProductID],[LocationID],[Shelf],[Bin],[Quantity],[rowguid],[ModifiedDate]" + CRLF +
			             @"FROM [Production].[ProductInventory]" + CRLF +
			             @"WHERE [ProductID] = @ProductID" + CRLF +
			             @"AND [LocationID] = @LocationID";

			_inputparametervalues = new object[2];
			_inputparamholder = new InputParamHolder(_inputparametervalues);

			ColumnArrayBuilder param_array = new ColumnArrayBuilder();

			param_array.AddParameterColumn("@ProductID", typeof(int), true, false, DbType.Int32, null, null, null);
			param_array.AddParameterColumn("@LocationID", typeof(short), true, false, DbType.Int16, null, null, null);

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
				BaseTableName = "ProductInventory",
				BaseColumnName = "ProductID"
			});

			schema_array.Add(new VenturaSqlColumn("LocationID", typeof(short), false)
			{
				Updateable = true,
				ColumnSize = 2,
				NumericPrecision = 5,
				ProviderType = 16,
				IsKey = true,
				BaseSchemaName = "Production",
				BaseTableName = "ProductInventory",
				BaseColumnName = "LocationID"
			});

			schema_array.Add(new VenturaSqlColumn("Shelf", typeof(string), false)
			{
				Updateable = true,
				ColumnSize = 10,
				ProviderType = 12,
				BaseSchemaName = "Production",
				BaseTableName = "ProductInventory",
				BaseColumnName = "Shelf"
			});

			schema_array.Add(new VenturaSqlColumn("Bin", typeof(byte), false)
			{
				Updateable = true,
				ColumnSize = 1,
				NumericPrecision = 3,
				ProviderType = 20,
				BaseSchemaName = "Production",
				BaseTableName = "ProductInventory",
				BaseColumnName = "Bin"
			});

			schema_array.Add(new VenturaSqlColumn("Quantity", typeof(short), false)
			{
				Updateable = true,
				ColumnSize = 2,
				NumericPrecision = 5,
				ProviderType = 16,
				BaseSchemaName = "Production",
				BaseTableName = "ProductInventory",
				BaseColumnName = "Quantity"
			});

			schema_array.Add(new VenturaSqlColumn("rowguid", typeof(Guid), false)
			{
				Updateable = true,
				ColumnSize = 16,
				ProviderType = 14,
				BaseSchemaName = "Production",
				BaseTableName = "ProductInventory",
				BaseColumnName = "rowguid"
			});

			schema_array.Add(new VenturaSqlColumn("ModifiedDate", typeof(DateTime), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 23,
				NumericScale = 3,
				ProviderType = 4,
				BaseSchemaName = "Production",
				BaseTableName = "ProductInventory",
				BaseColumnName = "ModifiedDate"
			});

			((IResultsetBase)this).Schema = new VenturaSqlSchema(schema_array);
			((IResultsetBase)this).UpdateableTablename = "[Production].[ProductInventory]";
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductInventory]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public int ProductID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ProductID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ProductID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductInventory]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public short LocationID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.LocationID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.LocationID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductInventory]. NotReadonly. NotNull.
		/// </summary>
		public string Shelf
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Shelf; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Shelf = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductInventory]. NotReadonly. NotNull.
		/// </summary>
		public byte Bin
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Bin; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Bin = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductInventory]. NotReadonly. NotNull.
		/// </summary>
		public short Quantity
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Quantity; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Quantity = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductInventory]. NotReadonly. NotNull.
		/// </summary>
		public Guid rowguid
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.rowguid; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.rowguid = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductInventory]. NotReadonly. NotNull.
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
			this.InsertItem(index, new PriKey_Production_ProductInventory_Record());
			this.CurrentRecordIndex = index;
		}

		public void Append(PriKey_Production_ProductInventory_Record record)
		{
			int index = this.RecordCount;
			this.InsertItem(index, record);
			this.CurrentRecordIndex = index;
		}

		public PriKey_Production_ProductInventory_Record NewRecord()
		{
			return new PriKey_Production_ProductInventory_Record();
		}

		protected override PriKey_Production_ProductInventory_Record InternalCreateExistingRecordObject(object[] columnvalues) => new PriKey_Production_ProductInventory_Record(columnvalues);

		byte[] IRecordsetBase.Hash
		{
			get { return new byte[] { 11, 252, 173, 104, 176, 30, 28, 205, 138, 91, 119, 137, 211, 234, 217, 55 }; }
		}

		string IRecordsetBase.HashString
		{
			get { return "0BFCAD68B01E1CCD8A5B7789D3EAD937"; }
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

		public void SetExecSqlParams(int? ProductID, short? LocationID)
		{
			_inputparametervalues[0] = ProductID;
			_inputparametervalues[1] = LocationID;
		}

		public void ExecSql(int? ProductID, short? LocationID)
		{
			_inputparametervalues[0] = ProductID;
			_inputparametervalues[1] = LocationID;
			Transactional.ExecSql(VenturaSqlConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public void ExecSql(Connector connector, int? ProductID, short? LocationID)
		{
			_inputparametervalues[0] = ProductID;
			_inputparametervalues[1] = LocationID;
			Transactional.ExecSql(connector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync(int? ProductID, short? LocationID)
		{
			_inputparametervalues[0] = ProductID;
			_inputparametervalues[1] = LocationID;
			await Transactional.ExecSqlAsync(VenturaSqlConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync(Connector connector, int? ProductID, short? LocationID)
		{
			_inputparametervalues[0] = ProductID;
			_inputparametervalues[1] = LocationID;
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

			public short? LocationID
			{
				get { return (short?)_values[1]; }
				set { _values[1] = value; }
			}

		}

	}

	public sealed partial class PriKey_Production_ProductInventory_Record : IRecordBase, INotifyPropertyChanged
	{
		private DataRecordStatus _recordstatus;
		private bool _started_with_dbvalues;

		private int _cur__ProductID; private int _ori__ProductID; private bool _mod__ProductID;
		private short _cur__LocationID; private short _ori__LocationID; private bool _mod__LocationID;
		private string _cur__Shelf; private string _ori__Shelf; private bool _mod__Shelf;
		private byte _cur__Bin; private byte _ori__Bin; private bool _mod__Bin;
		private short _cur__Quantity; private short _ori__Quantity; private bool _mod__Quantity;
		private Guid _cur__rowguid; private Guid _ori__rowguid; private bool _mod__rowguid;
		private DateTime _cur__ModifiedDate; private DateTime _ori__ModifiedDate; private bool _mod__ModifiedDate;


		public PriKey_Production_ProductInventory_Record()
		{
			_cur__ProductID = 0;
			_cur__LocationID = 0;
			_cur__Shelf = "";
			_cur__Bin = 0;
			_cur__Quantity = 0;
			_cur__rowguid = Guid.Empty;
			_cur__ModifiedDate = new DateTime(1900, 1, 1);
			_started_with_dbvalues = false;
			_recordstatus = DataRecordStatus.New;
		}

		public PriKey_Production_ProductInventory_Record(object[] columnvalues)
		{
			_cur__ProductID = (int)columnvalues[0];
			_cur__LocationID = (short)columnvalues[1];
			_cur__Shelf = (string)columnvalues[2];
			_cur__Bin = (byte)columnvalues[3];
			_cur__Quantity = (short)columnvalues[4];
			_cur__rowguid = (Guid)columnvalues[5];
			_cur__ModifiedDate = (DateTime)columnvalues[6];
			_started_with_dbvalues = true;
			_recordstatus = DataRecordStatus.Existing;
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductInventory]. PrimaryKey. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [Production].[ProductInventory]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public short LocationID
		{
			get { return _cur__LocationID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__LocationID = true;
				if (_cur__LocationID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__LocationID == false) { _ori__LocationID = _cur__LocationID; _mod__LocationID = true; } // existing record and column is not modified
					else { if (value == _ori__LocationID) { _ori__LocationID = default(short); _mod__LocationID = false; } } // existing record and column is modified
				}
				_cur__LocationID = value; OnPropertyChanged("LocationID"); OnAfterPropertyChanged("LocationID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductInventory]. NotReadonly. NotNull.
		/// </summary>
		public string Shelf
		{
			get { return _cur__Shelf; }
			set
			{
				if (value == null) throw new ArgumentNullException("Shelf", VenturaSqlStrings.SET_NULL_MSG);
				if (_started_with_dbvalues == false) _mod__Shelf = true;
				if (_cur__Shelf == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Shelf == false) { _ori__Shelf = _cur__Shelf; _mod__Shelf = true; } // existing record and column is not modified
					else { if (value == _ori__Shelf) { _ori__Shelf = default(string); _mod__Shelf = false; } } // existing record and column is modified
				}
				_cur__Shelf = value; OnPropertyChanged("Shelf"); OnAfterPropertyChanged("Shelf");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductInventory]. NotReadonly. NotNull.
		/// </summary>
		public byte Bin
		{
			get { return _cur__Bin; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Bin = true;
				if (_cur__Bin == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Bin == false) { _ori__Bin = _cur__Bin; _mod__Bin = true; } // existing record and column is not modified
					else { if (value == _ori__Bin) { _ori__Bin = default(byte); _mod__Bin = false; } } // existing record and column is modified
				}
				_cur__Bin = value; OnPropertyChanged("Bin"); OnAfterPropertyChanged("Bin");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductInventory]. NotReadonly. NotNull.
		/// </summary>
		public short Quantity
		{
			get { return _cur__Quantity; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Quantity = true;
				if (_cur__Quantity == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Quantity == false) { _ori__Quantity = _cur__Quantity; _mod__Quantity = true; } // existing record and column is not modified
					else { if (value == _ori__Quantity) { _ori__Quantity = default(short); _mod__Quantity = false; } } // existing record and column is modified
				}
				_cur__Quantity = value; OnPropertyChanged("Quantity"); OnAfterPropertyChanged("Quantity");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductInventory]. NotReadonly. NotNull.
		/// </summary>
		public Guid rowguid
		{
			get { return _cur__rowguid; }
			set
			{
				if (_started_with_dbvalues == false) _mod__rowguid = true;
				if (_cur__rowguid == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__rowguid == false) { _ori__rowguid = _cur__rowguid; _mod__rowguid = true; } // existing record and column is not modified
					else { if (value == _ori__rowguid) { _ori__rowguid = default(Guid); _mod__rowguid = false; } } // existing record and column is modified
				}
				_cur__rowguid = value; OnPropertyChanged("rowguid"); OnAfterPropertyChanged("rowguid");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductInventory]. NotReadonly. NotNull.
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
			if (column_name == "LocationID") return _mod__LocationID;
			if (column_name == "Shelf") return _mod__Shelf;
			if (column_name == "Bin") return _mod__Bin;
			if (column_name == "Quantity") return _mod__Quantity;
			if (column_name == "rowguid") return _mod__rowguid;
			if (column_name == "ModifiedDate") return _mod__ModifiedDate;
			throw new ArgumentOutOfRangeException(String.Format(VenturaSqlStrings.UNKNOWN_COLUMN_NAME, column_name));
		}

		public int ModifiedColumnCount()
		{
			int count = 0;
			if (_mod__ProductID == true) count++;
			if (_mod__LocationID == true) count++;
			if (_mod__Shelf == true) count++;
			if (_mod__Bin == true) count++;
			if (_mod__Quantity == true) count++;
			if (_mod__rowguid == true) count++;
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
				if (_mod__LocationID) count++;
			}
			if (_mod__Shelf == true) count++;
			if (_mod__Bin == true) count++;
			if (_mod__Quantity == true) count++;
			if (_mod__rowguid == true) count++;
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
			if (_mod__LocationID == false) throw new Exception(string.Format(VenturaSqlStrings.VALUE_NOT_SET_MSG, record_index_to_display, "LocationID"));
		}

		void IRecordBase.WriteChangesToTrackArray(TrackArray track_array)
		{
			if (_recordstatus == DataRecordStatus.New)
			{
				track_array.AppendDataValue(0, _cur__ProductID);
				track_array.AppendDataValue(1, _cur__LocationID);
				track_array.AppendDataValue(2, _cur__Shelf);
				track_array.AppendDataValue(3, _cur__Bin);
				track_array.AppendDataValue(4, _cur__Quantity);
				track_array.AppendDataValue(5, _cur__rowguid);
				track_array.AppendDataValue(6, _cur__ModifiedDate);
			}
			else if (_recordstatus == DataRecordStatus.Existing)
			{
				if (_started_with_dbvalues)
				{
					if (_mod__ProductID) track_array.AppendDataValue(0, _cur__ProductID);
					if (_mod__LocationID) track_array.AppendDataValue(1, _cur__LocationID);
				}
				if (_mod__Shelf) track_array.AppendDataValue(2, _cur__Shelf);
				if (_mod__Bin) track_array.AppendDataValue(3, _cur__Bin);
				if (_mod__Quantity) track_array.AppendDataValue(4, _cur__Quantity);
				if (_mod__rowguid) track_array.AppendDataValue(5, _cur__rowguid);
				if (_mod__ModifiedDate) track_array.AppendDataValue(6, _cur__ModifiedDate);
				if (track_array.HasData == false) return;
			}

			if (_recordstatus == DataRecordStatus.Existing || _recordstatus == DataRecordStatus.ExistingDelete)
			{
				track_array.AppendPrikeyValue(0, (_mod__ProductID && _started_with_dbvalues) ? _ori__ProductID : _cur__ProductID);
				track_array.AppendPrikeyValue(1, (_mod__LocationID && _started_with_dbvalues) ? _ori__LocationID : _cur__LocationID);
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
				if (_mod__LocationID) _ori__LocationID = default(short);
				if (_mod__Shelf) _ori__Shelf = default(string);
				if (_mod__Bin) _ori__Bin = default(byte);
				if (_mod__Quantity) _ori__Quantity = default(short);
				if (_mod__rowguid) _ori__rowguid = default(Guid);
				if (_mod__ModifiedDate) _ori__ModifiedDate = default(DateTime);
			}
			_mod__ProductID = false;
			_mod__LocationID = false;
			_mod__Shelf = false;
			_mod__Bin = false;
			_mod__Quantity = false;
			_mod__rowguid = false;
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
	public partial class PriKey_Production_ProductInventory_Record
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
