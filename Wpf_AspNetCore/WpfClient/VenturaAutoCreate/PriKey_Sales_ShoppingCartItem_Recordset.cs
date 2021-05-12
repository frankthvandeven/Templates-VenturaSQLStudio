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

namespace WpfClient.VenturaAutoCreate
{
	/// <summary>
	/// The updateable table is [Sales].[ShoppingCartItem]. Updateable table column information:
	/// • 6 out of 6 table columns are present in the resultset.
	/// • All primary key columns are present in the resultset: ShoppingCartItemID.
	/// • Non-primary key columns present in the resultset: ShoppingCartID, Quantity, ProductID, DateCreated and ModifiedDate.
	/// Recordset item automatically created by VenturaSQL Studio.
	/// </summary>
	public partial class PriKey_Sales_ShoppingCartItem_Recordset : ResultsetObservable<PriKey_Sales_ShoppingCartItem_Recordset, PriKey_Sales_ShoppingCartItem_Record>, IRecordsetBase
	{
		private IResultsetBase[] _resultsets;
		private string _sqlscript;
		private object[] _inputparametervalues;
		private InputParamHolder _inputparamholder;
		private VenturaSqlSchema _parameterschema;
		private int _rowlimit = 500;
		private const string CRLF = "\r\n";

		public PriKey_Sales_ShoppingCartItem_Recordset()
		{
			_resultsets = new IResultsetBase[] { this };

			_sqlscript = @"SELECT [ShoppingCartItemID],[ShoppingCartID],[Quantity],[ProductID],[DateCreated],[ModifiedDate]" + CRLF +
			             @"FROM [Sales].[ShoppingCartItem]" + CRLF +
			             @"WHERE [ShoppingCartItemID] = @ShoppingCartItemID";

			_inputparametervalues = new object[1];
			_inputparamholder = new InputParamHolder(_inputparametervalues);

			ColumnArrayBuilder param_array = new ColumnArrayBuilder();

			param_array.AddParameterColumn("@ShoppingCartItemID", typeof(int), true, false, DbType.Int32, null, null, null);

			_parameterschema = new VenturaSqlSchema(param_array);

			ColumnArrayBuilder schema_array = new ColumnArrayBuilder();

			schema_array.Add(new VenturaSqlColumn("ShoppingCartItemID", typeof(int), false)
			{
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				IsKey = true,
				IsIdentity = true,
				IsAutoIncrement = true,
				BaseSchemaName = "Sales",
				BaseTableName = "ShoppingCartItem",
				BaseColumnName = "ShoppingCartItemID"
			});

			schema_array.Add(new VenturaSqlColumn("ShoppingCartID", typeof(string), false)
			{
				Updateable = true,
				ColumnSize = 50,
				ProviderType = 12,
				BaseSchemaName = "Sales",
				BaseTableName = "ShoppingCartItem",
				BaseColumnName = "ShoppingCartID"
			});

			schema_array.Add(new VenturaSqlColumn("Quantity", typeof(int), false)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				BaseSchemaName = "Sales",
				BaseTableName = "ShoppingCartItem",
				BaseColumnName = "Quantity"
			});

			schema_array.Add(new VenturaSqlColumn("ProductID", typeof(int), false)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				BaseSchemaName = "Sales",
				BaseTableName = "ShoppingCartItem",
				BaseColumnName = "ProductID"
			});

			schema_array.Add(new VenturaSqlColumn("DateCreated", typeof(DateTime), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 23,
				NumericScale = 3,
				ProviderType = 4,
				BaseSchemaName = "Sales",
				BaseTableName = "ShoppingCartItem",
				BaseColumnName = "DateCreated"
			});

			schema_array.Add(new VenturaSqlColumn("ModifiedDate", typeof(DateTime), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 23,
				NumericScale = 3,
				ProviderType = 4,
				BaseSchemaName = "Sales",
				BaseTableName = "ShoppingCartItem",
				BaseColumnName = "ModifiedDate"
			});

			((IResultsetBase)this).Schema = new VenturaSqlSchema(schema_array);
			((IResultsetBase)this).UpdateableTablename = "[Sales].[ShoppingCartItem]";
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Sales].[ShoppingCartItem]. PrimaryKey. NotReadonly. NotNull. IsIdentity. AutoIncrement.
		/// </summary>
		public int ShoppingCartItemID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ShoppingCartItemID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ShoppingCartItemID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[ShoppingCartItem]. NotReadonly. NotNull.
		/// </summary>
		public string ShoppingCartID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ShoppingCartID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ShoppingCartID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[ShoppingCartItem]. NotReadonly. NotNull.
		/// </summary>
		public int Quantity
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Quantity; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Quantity = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[ShoppingCartItem]. NotReadonly. NotNull.
		/// </summary>
		public int ProductID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ProductID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ProductID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[ShoppingCartItem]. NotReadonly. NotNull.
		/// </summary>
		public DateTime DateCreated
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.DateCreated; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.DateCreated = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[ShoppingCartItem]. NotReadonly. NotNull.
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
			this.InsertItem(index, new PriKey_Sales_ShoppingCartItem_Record());
			this.CurrentRecordIndex = index;
		}

		public void Append(PriKey_Sales_ShoppingCartItem_Record record)
		{
			int index = this.RecordCount;
			this.InsertItem(index, record);
			this.CurrentRecordIndex = index;
		}

		public PriKey_Sales_ShoppingCartItem_Record NewRecord()
		{
			return new PriKey_Sales_ShoppingCartItem_Record();
		}

		protected override PriKey_Sales_ShoppingCartItem_Record InternalCreateExistingRecordObject(object[] columnvalues) => new PriKey_Sales_ShoppingCartItem_Record(columnvalues);

		byte[] IRecordsetBase.Hash
		{
			get { return new byte[] { 164, 191, 79, 73, 108, 171, 103, 95, 169, 120, 110, 107, 30, 198, 174, 112 }; }
		}

		string IRecordsetBase.HashString
		{
			get { return "A4BF4F496CAB675FA9786E6B1EC6AE70"; }
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

		public void SetExecSqlParams(int? ShoppingCartItemID)
		{
			_inputparametervalues[0] = ShoppingCartItemID;
		}

		public void ExecSql(int? ShoppingCartItemID)
		{
			_inputparametervalues[0] = ShoppingCartItemID;
			Transactional.ExecSql(VenturaSqlConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public void ExecSql(Connector connector, int? ShoppingCartItemID)
		{
			_inputparametervalues[0] = ShoppingCartItemID;
			Transactional.ExecSql(connector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync(int? ShoppingCartItemID)
		{
			_inputparametervalues[0] = ShoppingCartItemID;
			await Transactional.ExecSqlAsync(VenturaSqlConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync(Connector connector, int? ShoppingCartItemID)
		{
			_inputparametervalues[0] = ShoppingCartItemID;
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

			public int? ShoppingCartItemID
			{
				get { return (int?)_values[0]; }
				set { _values[0] = value; }
			}

		}

	}

	public sealed partial class PriKey_Sales_ShoppingCartItem_Record : IRecordBase, INotifyPropertyChanged
	{
		private DataRecordStatus _recordstatus;
		private bool _started_with_dbvalues;

		private int _cur__ShoppingCartItemID; private int _ori__ShoppingCartItemID; private bool _mod__ShoppingCartItemID;
		private string _cur__ShoppingCartID; private string _ori__ShoppingCartID; private bool _mod__ShoppingCartID;
		private int _cur__Quantity; private int _ori__Quantity; private bool _mod__Quantity;
		private int _cur__ProductID; private int _ori__ProductID; private bool _mod__ProductID;
		private DateTime _cur__DateCreated; private DateTime _ori__DateCreated; private bool _mod__DateCreated;
		private DateTime _cur__ModifiedDate; private DateTime _ori__ModifiedDate; private bool _mod__ModifiedDate;


		public PriKey_Sales_ShoppingCartItem_Record()
		{
			_cur__ShoppingCartItemID = 0;
			_cur__ShoppingCartID = "";
			_cur__Quantity = 0;
			_cur__ProductID = 0;
			_cur__DateCreated = new DateTime(1900, 1, 1);
			_cur__ModifiedDate = new DateTime(1900, 1, 1);
			_started_with_dbvalues = false;
			_recordstatus = DataRecordStatus.New;
		}

		public PriKey_Sales_ShoppingCartItem_Record(object[] columnvalues)
		{
			_cur__ShoppingCartItemID = (int)columnvalues[0];
			_cur__ShoppingCartID = (string)columnvalues[1];
			_cur__Quantity = (int)columnvalues[2];
			_cur__ProductID = (int)columnvalues[3];
			_cur__DateCreated = (DateTime)columnvalues[4];
			_cur__ModifiedDate = (DateTime)columnvalues[5];
			_started_with_dbvalues = true;
			_recordstatus = DataRecordStatus.Existing;
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Sales].[ShoppingCartItem]. PrimaryKey. NotReadonly. NotNull. IsIdentity. AutoIncrement.
		/// </summary>
		public int ShoppingCartItemID
		{
			get { return _cur__ShoppingCartItemID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ShoppingCartItemID = true;
				if (_cur__ShoppingCartItemID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ShoppingCartItemID == false) { _ori__ShoppingCartItemID = _cur__ShoppingCartItemID; _mod__ShoppingCartItemID = true; } // existing record and column is not modified
					else { if (value == _ori__ShoppingCartItemID) { _ori__ShoppingCartItemID = default(int); _mod__ShoppingCartItemID = false; } } // existing record and column is modified
				}
				_cur__ShoppingCartItemID = value; OnPropertyChanged("ShoppingCartItemID"); OnAfterPropertyChanged("ShoppingCartItemID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[ShoppingCartItem]. NotReadonly. NotNull.
		/// </summary>
		public string ShoppingCartID
		{
			get { return _cur__ShoppingCartID; }
			set
			{
				if (value == null) throw new ArgumentNullException("ShoppingCartID", VenturaSqlStrings.SET_NULL_MSG);
				if (_started_with_dbvalues == false) _mod__ShoppingCartID = true;
				if (_cur__ShoppingCartID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ShoppingCartID == false) { _ori__ShoppingCartID = _cur__ShoppingCartID; _mod__ShoppingCartID = true; } // existing record and column is not modified
					else { if (value == _ori__ShoppingCartID) { _ori__ShoppingCartID = default(string); _mod__ShoppingCartID = false; } } // existing record and column is modified
				}
				_cur__ShoppingCartID = value; OnPropertyChanged("ShoppingCartID"); OnAfterPropertyChanged("ShoppingCartID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[ShoppingCartItem]. NotReadonly. NotNull.
		/// </summary>
		public int Quantity
		{
			get { return _cur__Quantity; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Quantity = true;
				if (_cur__Quantity == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Quantity == false) { _ori__Quantity = _cur__Quantity; _mod__Quantity = true; } // existing record and column is not modified
					else { if (value == _ori__Quantity) { _ori__Quantity = default(int); _mod__Quantity = false; } } // existing record and column is modified
				}
				_cur__Quantity = value; OnPropertyChanged("Quantity"); OnAfterPropertyChanged("Quantity");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[ShoppingCartItem]. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [Sales].[ShoppingCartItem]. NotReadonly. NotNull.
		/// </summary>
		public DateTime DateCreated
		{
			get { return _cur__DateCreated; }
			set
			{
				if (_started_with_dbvalues == false) _mod__DateCreated = true;
				if (_cur__DateCreated == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__DateCreated == false) { _ori__DateCreated = _cur__DateCreated; _mod__DateCreated = true; } // existing record and column is not modified
					else { if (value == _ori__DateCreated) { _ori__DateCreated = default(DateTime); _mod__DateCreated = false; } } // existing record and column is modified
				}
				_cur__DateCreated = value; OnPropertyChanged("DateCreated"); OnAfterPropertyChanged("DateCreated");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[ShoppingCartItem]. NotReadonly. NotNull.
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
			if (column_name == "ShoppingCartItemID") return _mod__ShoppingCartItemID;
			if (column_name == "ShoppingCartID") return _mod__ShoppingCartID;
			if (column_name == "Quantity") return _mod__Quantity;
			if (column_name == "ProductID") return _mod__ProductID;
			if (column_name == "DateCreated") return _mod__DateCreated;
			if (column_name == "ModifiedDate") return _mod__ModifiedDate;
			throw new ArgumentOutOfRangeException(String.Format(VenturaSqlStrings.UNKNOWN_COLUMN_NAME, column_name));
		}

		public int ModifiedColumnCount()
		{
			int count = 0;
			if (_mod__ShoppingCartItemID == true) count++;
			if (_mod__ShoppingCartID == true) count++;
			if (_mod__Quantity == true) count++;
			if (_mod__ProductID == true) count++;
			if (_mod__DateCreated == true) count++;
			if (_mod__ModifiedDate == true) count++;
			return count;
		}

		public bool PendingChanges()
		{
			if (_recordstatus == DataRecordStatus.New || _recordstatus == DataRecordStatus.ExistingDelete) return true;
			int count = 0;
			if (_mod__ShoppingCartID == true) count++;
			if (_mod__Quantity == true) count++;
			if (_mod__ProductID == true) count++;
			if (_mod__DateCreated == true) count++;
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
				track_array.AppendDataValue(1, _cur__ShoppingCartID);
				track_array.AppendDataValue(2, _cur__Quantity);
				track_array.AppendDataValue(3, _cur__ProductID);
				track_array.AppendDataValue(4, _cur__DateCreated);
				track_array.AppendDataValue(5, _cur__ModifiedDate);
			}
			else if (_recordstatus == DataRecordStatus.Existing)
			{
				if (_mod__ShoppingCartID) track_array.AppendDataValue(1, _cur__ShoppingCartID);
				if (_mod__Quantity) track_array.AppendDataValue(2, _cur__Quantity);
				if (_mod__ProductID) track_array.AppendDataValue(3, _cur__ProductID);
				if (_mod__DateCreated) track_array.AppendDataValue(4, _cur__DateCreated);
				if (_mod__ModifiedDate) track_array.AppendDataValue(5, _cur__ModifiedDate);
				if (track_array.HasData == false) return;
			}

			if (_recordstatus == DataRecordStatus.Existing || _recordstatus == DataRecordStatus.ExistingDelete)
			{
				track_array.AppendPrikeyValue(0, (_mod__ShoppingCartItemID && _started_with_dbvalues) ? _ori__ShoppingCartItemID : _cur__ShoppingCartItemID);
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
				if (_mod__ShoppingCartItemID) _ori__ShoppingCartItemID = default(int);
				if (_mod__ShoppingCartID) _ori__ShoppingCartID = default(string);
				if (_mod__Quantity) _ori__Quantity = default(int);
				if (_mod__ProductID) _ori__ProductID = default(int);
				if (_mod__DateCreated) _ori__DateCreated = default(DateTime);
				if (_mod__ModifiedDate) _ori__ModifiedDate = default(DateTime);
			}
			_mod__ShoppingCartItemID = false;
			_mod__ShoppingCartID = false;
			_mod__Quantity = false;
			_mod__ProductID = false;
			_mod__DateCreated = false;
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
			_cur__ShoppingCartItemID = (int)value;
			OnPropertyChanged("ShoppingCartItemID");
			OnAfterPropertyChanged("ShoppingCartItemID");
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
	public partial class PriKey_Sales_ShoppingCartItem_Record
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
