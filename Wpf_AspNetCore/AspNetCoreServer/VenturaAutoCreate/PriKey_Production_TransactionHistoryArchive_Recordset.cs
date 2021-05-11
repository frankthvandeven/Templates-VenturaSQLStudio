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
	/// The updateable table is [Production].[TransactionHistoryArchive]. Updateable table column information:
	/// • 9 out of 9 table columns are present in the resultset.
	/// • All primary key columns are present in the resultset: TransactionID.
	/// • Non-primary key columns present in the resultset: ProductID, ReferenceOrderID, ReferenceOrderLineID, TransactionDate,
	///   TransactionType, Quantity, ActualCost and ModifiedDate.
	/// Recordset item automatically created by VenturaSQL Studio.
	/// </summary>
	public partial class PriKey_Production_TransactionHistoryArchive_Recordset : ResultsetObservable<PriKey_Production_TransactionHistoryArchive_Recordset, PriKey_Production_TransactionHistoryArchive_Record>, IRecordsetBase
	{
		private IResultsetBase[] _resultsets;
		private string _sqlscript;
		private object[] _inputparametervalues;
		private InputParamHolder _inputparamholder;
		private VenturaSqlSchema _parameterschema;
		private int _rowlimit = 500;
		private const string CRLF = "\r\n";

		public PriKey_Production_TransactionHistoryArchive_Recordset()
		{
			_resultsets = new IResultsetBase[] { this };

			_sqlscript = @"SELECT [TransactionID],[ProductID],[ReferenceOrderID],[ReferenceOrderLineID],[TransactionDate],[TransactionType],[Quantity],[ActualCost],[ModifiedDate]" + CRLF +
			             @"FROM [Production].[TransactionHistoryArchive]" + CRLF +
			             @"WHERE [TransactionID] = @TransactionID";

			_inputparametervalues = new object[1];
			_inputparamholder = new InputParamHolder(_inputparametervalues);

			ColumnArrayBuilder param_array = new ColumnArrayBuilder();

			param_array.AddParameterColumn("@TransactionID", typeof(int), true, false, DbType.Int32, null, null, null);

			_parameterschema = new VenturaSqlSchema(param_array);

			ColumnArrayBuilder schema_array = new ColumnArrayBuilder();

			schema_array.Add(new VenturaSqlColumn("TransactionID", typeof(int), false)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				IsKey = true,
				BaseSchemaName = "Production",
				BaseTableName = "TransactionHistoryArchive",
				BaseColumnName = "TransactionID"
			});

			schema_array.Add(new VenturaSqlColumn("ProductID", typeof(int), false)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				BaseSchemaName = "Production",
				BaseTableName = "TransactionHistoryArchive",
				BaseColumnName = "ProductID"
			});

			schema_array.Add(new VenturaSqlColumn("ReferenceOrderID", typeof(int), false)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				BaseSchemaName = "Production",
				BaseTableName = "TransactionHistoryArchive",
				BaseColumnName = "ReferenceOrderID"
			});

			schema_array.Add(new VenturaSqlColumn("ReferenceOrderLineID", typeof(int), false)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				BaseSchemaName = "Production",
				BaseTableName = "TransactionHistoryArchive",
				BaseColumnName = "ReferenceOrderLineID"
			});

			schema_array.Add(new VenturaSqlColumn("TransactionDate", typeof(DateTime), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 23,
				NumericScale = 3,
				ProviderType = 4,
				BaseSchemaName = "Production",
				BaseTableName = "TransactionHistoryArchive",
				BaseColumnName = "TransactionDate"
			});

			schema_array.Add(new VenturaSqlColumn("TransactionType", typeof(string), false)
			{
				Updateable = true,
				ColumnSize = 1,
				ProviderType = 10,
				BaseSchemaName = "Production",
				BaseTableName = "TransactionHistoryArchive",
				BaseColumnName = "TransactionType"
			});

			schema_array.Add(new VenturaSqlColumn("Quantity", typeof(int), false)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				BaseSchemaName = "Production",
				BaseTableName = "TransactionHistoryArchive",
				BaseColumnName = "Quantity"
			});

			schema_array.Add(new VenturaSqlColumn("ActualCost", typeof(decimal), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 19,
				ProviderType = 9,
				BaseSchemaName = "Production",
				BaseTableName = "TransactionHistoryArchive",
				BaseColumnName = "ActualCost"
			});

			schema_array.Add(new VenturaSqlColumn("ModifiedDate", typeof(DateTime), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 23,
				NumericScale = 3,
				ProviderType = 4,
				BaseSchemaName = "Production",
				BaseTableName = "TransactionHistoryArchive",
				BaseColumnName = "ModifiedDate"
			});

			((IResultsetBase)this).Schema = new VenturaSqlSchema(schema_array);
			((IResultsetBase)this).UpdateableTablename = "[Production].[TransactionHistoryArchive]";
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[TransactionHistoryArchive]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public int TransactionID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.TransactionID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.TransactionID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[TransactionHistoryArchive]. NotReadonly. NotNull.
		/// </summary>
		public int ProductID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ProductID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ProductID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[TransactionHistoryArchive]. NotReadonly. NotNull.
		/// </summary>
		public int ReferenceOrderID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ReferenceOrderID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ReferenceOrderID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[TransactionHistoryArchive]. NotReadonly. NotNull.
		/// </summary>
		public int ReferenceOrderLineID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ReferenceOrderLineID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ReferenceOrderLineID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[TransactionHistoryArchive]. NotReadonly. NotNull.
		/// </summary>
		public DateTime TransactionDate
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.TransactionDate; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.TransactionDate = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[TransactionHistoryArchive]. NotReadonly. NotNull.
		/// </summary>
		public string TransactionType
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.TransactionType; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.TransactionType = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[TransactionHistoryArchive]. NotReadonly. NotNull.
		/// </summary>
		public int Quantity
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Quantity; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Quantity = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[TransactionHistoryArchive]. NotReadonly. NotNull.
		/// </summary>
		public decimal ActualCost
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ActualCost; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ActualCost = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[TransactionHistoryArchive]. NotReadonly. NotNull.
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
			this.InsertItem(index, new PriKey_Production_TransactionHistoryArchive_Record());
			this.CurrentRecordIndex = index;
		}

		public void Append(PriKey_Production_TransactionHistoryArchive_Record record)
		{
			int index = this.RecordCount;
			this.InsertItem(index, record);
			this.CurrentRecordIndex = index;
		}

		public PriKey_Production_TransactionHistoryArchive_Record NewRecord()
		{
			return new PriKey_Production_TransactionHistoryArchive_Record();
		}

		protected override PriKey_Production_TransactionHistoryArchive_Record InternalCreateExistingRecordObject(object[] columnvalues) => new PriKey_Production_TransactionHistoryArchive_Record(columnvalues);

		byte[] IRecordsetBase.Hash
		{
			get { return new byte[] { 208, 216, 118, 131, 156, 135, 192, 232, 170, 156, 114, 200, 165, 11, 22, 39 }; }
		}

		string IRecordsetBase.HashString
		{
			get { return "D0D876839C87C0E8AA9C72C8A50B1627"; }
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

		public void SetExecSqlParams(int? TransactionID)
		{
			_inputparametervalues[0] = TransactionID;
		}

		public void ExecSql(int? TransactionID)
		{
			_inputparametervalues[0] = TransactionID;
			Transactional.ExecSql(VenturaSqlConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public void ExecSql(Connector connector, int? TransactionID)
		{
			_inputparametervalues[0] = TransactionID;
			Transactional.ExecSql(connector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync(int? TransactionID)
		{
			_inputparametervalues[0] = TransactionID;
			await Transactional.ExecSqlAsync(VenturaSqlConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync(Connector connector, int? TransactionID)
		{
			_inputparametervalues[0] = TransactionID;
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

			public int? TransactionID
			{
				get { return (int?)_values[0]; }
				set { _values[0] = value; }
			}

		}

	}

	public sealed partial class PriKey_Production_TransactionHistoryArchive_Record : IRecordBase, INotifyPropertyChanged
	{
		private DataRecordStatus _recordstatus;
		private bool _started_with_dbvalues;

		private int _cur__TransactionID; private int _ori__TransactionID; private bool _mod__TransactionID;
		private int _cur__ProductID; private int _ori__ProductID; private bool _mod__ProductID;
		private int _cur__ReferenceOrderID; private int _ori__ReferenceOrderID; private bool _mod__ReferenceOrderID;
		private int _cur__ReferenceOrderLineID; private int _ori__ReferenceOrderLineID; private bool _mod__ReferenceOrderLineID;
		private DateTime _cur__TransactionDate; private DateTime _ori__TransactionDate; private bool _mod__TransactionDate;
		private string _cur__TransactionType; private string _ori__TransactionType; private bool _mod__TransactionType;
		private int _cur__Quantity; private int _ori__Quantity; private bool _mod__Quantity;
		private decimal _cur__ActualCost; private decimal _ori__ActualCost; private bool _mod__ActualCost;
		private DateTime _cur__ModifiedDate; private DateTime _ori__ModifiedDate; private bool _mod__ModifiedDate;


		public PriKey_Production_TransactionHistoryArchive_Record()
		{
			_cur__TransactionID = 0;
			_cur__ProductID = 0;
			_cur__ReferenceOrderID = 0;
			_cur__ReferenceOrderLineID = 0;
			_cur__TransactionDate = new DateTime(1900, 1, 1);
			_cur__TransactionType = "";
			_cur__Quantity = 0;
			_cur__ActualCost = 0.0m;
			_cur__ModifiedDate = new DateTime(1900, 1, 1);
			_started_with_dbvalues = false;
			_recordstatus = DataRecordStatus.New;
		}

		public PriKey_Production_TransactionHistoryArchive_Record(object[] columnvalues)
		{
			_cur__TransactionID = (int)columnvalues[0];
			_cur__ProductID = (int)columnvalues[1];
			_cur__ReferenceOrderID = (int)columnvalues[2];
			_cur__ReferenceOrderLineID = (int)columnvalues[3];
			_cur__TransactionDate = (DateTime)columnvalues[4];
			_cur__TransactionType = (string)columnvalues[5];
			_cur__Quantity = (int)columnvalues[6];
			_cur__ActualCost = (decimal)columnvalues[7];
			_cur__ModifiedDate = (DateTime)columnvalues[8];
			_started_with_dbvalues = true;
			_recordstatus = DataRecordStatus.Existing;
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[TransactionHistoryArchive]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public int TransactionID
		{
			get { return _cur__TransactionID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__TransactionID = true;
				if (_cur__TransactionID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__TransactionID == false) { _ori__TransactionID = _cur__TransactionID; _mod__TransactionID = true; } // existing record and column is not modified
					else { if (value == _ori__TransactionID) { _ori__TransactionID = default(int); _mod__TransactionID = false; } } // existing record and column is modified
				}
				_cur__TransactionID = value; OnPropertyChanged("TransactionID"); OnAfterPropertyChanged("TransactionID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[TransactionHistoryArchive]. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [Production].[TransactionHistoryArchive]. NotReadonly. NotNull.
		/// </summary>
		public int ReferenceOrderID
		{
			get { return _cur__ReferenceOrderID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ReferenceOrderID = true;
				if (_cur__ReferenceOrderID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ReferenceOrderID == false) { _ori__ReferenceOrderID = _cur__ReferenceOrderID; _mod__ReferenceOrderID = true; } // existing record and column is not modified
					else { if (value == _ori__ReferenceOrderID) { _ori__ReferenceOrderID = default(int); _mod__ReferenceOrderID = false; } } // existing record and column is modified
				}
				_cur__ReferenceOrderID = value; OnPropertyChanged("ReferenceOrderID"); OnAfterPropertyChanged("ReferenceOrderID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[TransactionHistoryArchive]. NotReadonly. NotNull.
		/// </summary>
		public int ReferenceOrderLineID
		{
			get { return _cur__ReferenceOrderLineID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ReferenceOrderLineID = true;
				if (_cur__ReferenceOrderLineID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ReferenceOrderLineID == false) { _ori__ReferenceOrderLineID = _cur__ReferenceOrderLineID; _mod__ReferenceOrderLineID = true; } // existing record and column is not modified
					else { if (value == _ori__ReferenceOrderLineID) { _ori__ReferenceOrderLineID = default(int); _mod__ReferenceOrderLineID = false; } } // existing record and column is modified
				}
				_cur__ReferenceOrderLineID = value; OnPropertyChanged("ReferenceOrderLineID"); OnAfterPropertyChanged("ReferenceOrderLineID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[TransactionHistoryArchive]. NotReadonly. NotNull.
		/// </summary>
		public DateTime TransactionDate
		{
			get { return _cur__TransactionDate; }
			set
			{
				if (_started_with_dbvalues == false) _mod__TransactionDate = true;
				if (_cur__TransactionDate == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__TransactionDate == false) { _ori__TransactionDate = _cur__TransactionDate; _mod__TransactionDate = true; } // existing record and column is not modified
					else { if (value == _ori__TransactionDate) { _ori__TransactionDate = default(DateTime); _mod__TransactionDate = false; } } // existing record and column is modified
				}
				_cur__TransactionDate = value; OnPropertyChanged("TransactionDate"); OnAfterPropertyChanged("TransactionDate");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[TransactionHistoryArchive]. NotReadonly. NotNull.
		/// </summary>
		public string TransactionType
		{
			get { return _cur__TransactionType; }
			set
			{
				if (value == null) throw new ArgumentNullException("TransactionType", VenturaSqlStrings.SET_NULL_MSG);
				if (_started_with_dbvalues == false) _mod__TransactionType = true;
				if (_cur__TransactionType == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__TransactionType == false) { _ori__TransactionType = _cur__TransactionType; _mod__TransactionType = true; } // existing record and column is not modified
					else { if (value == _ori__TransactionType) { _ori__TransactionType = default(string); _mod__TransactionType = false; } } // existing record and column is modified
				}
				_cur__TransactionType = value; OnPropertyChanged("TransactionType"); OnAfterPropertyChanged("TransactionType");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[TransactionHistoryArchive]. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [Production].[TransactionHistoryArchive]. NotReadonly. NotNull.
		/// </summary>
		public decimal ActualCost
		{
			get { return _cur__ActualCost; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ActualCost = true;
				if (_cur__ActualCost == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ActualCost == false) { _ori__ActualCost = _cur__ActualCost; _mod__ActualCost = true; } // existing record and column is not modified
					else { if (value == _ori__ActualCost) { _ori__ActualCost = default(decimal); _mod__ActualCost = false; } } // existing record and column is modified
				}
				_cur__ActualCost = value; OnPropertyChanged("ActualCost"); OnAfterPropertyChanged("ActualCost");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[TransactionHistoryArchive]. NotReadonly. NotNull.
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
			if (column_name == "TransactionID") return _mod__TransactionID;
			if (column_name == "ProductID") return _mod__ProductID;
			if (column_name == "ReferenceOrderID") return _mod__ReferenceOrderID;
			if (column_name == "ReferenceOrderLineID") return _mod__ReferenceOrderLineID;
			if (column_name == "TransactionDate") return _mod__TransactionDate;
			if (column_name == "TransactionType") return _mod__TransactionType;
			if (column_name == "Quantity") return _mod__Quantity;
			if (column_name == "ActualCost") return _mod__ActualCost;
			if (column_name == "ModifiedDate") return _mod__ModifiedDate;
			throw new ArgumentOutOfRangeException(String.Format(VenturaSqlStrings.UNKNOWN_COLUMN_NAME, column_name));
		}

		public int ModifiedColumnCount()
		{
			int count = 0;
			if (_mod__TransactionID == true) count++;
			if (_mod__ProductID == true) count++;
			if (_mod__ReferenceOrderID == true) count++;
			if (_mod__ReferenceOrderLineID == true) count++;
			if (_mod__TransactionDate == true) count++;
			if (_mod__TransactionType == true) count++;
			if (_mod__Quantity == true) count++;
			if (_mod__ActualCost == true) count++;
			if (_mod__ModifiedDate == true) count++;
			return count;
		}

		public bool PendingChanges()
		{
			if (_recordstatus == DataRecordStatus.New || _recordstatus == DataRecordStatus.ExistingDelete) return true;
			int count = 0;
			if (_started_with_dbvalues)
			{
				if (_mod__TransactionID) count++;
			}
			if (_mod__ProductID == true) count++;
			if (_mod__ReferenceOrderID == true) count++;
			if (_mod__ReferenceOrderLineID == true) count++;
			if (_mod__TransactionDate == true) count++;
			if (_mod__TransactionType == true) count++;
			if (_mod__Quantity == true) count++;
			if (_mod__ActualCost == true) count++;
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
			if (_mod__TransactionID == false) throw new Exception(string.Format(VenturaSqlStrings.VALUE_NOT_SET_MSG, record_index_to_display, "TransactionID"));
		}

		void IRecordBase.WriteChangesToTrackArray(TrackArray track_array)
		{
			if (_recordstatus == DataRecordStatus.New)
			{
				track_array.AppendDataValue(0, _cur__TransactionID);
				track_array.AppendDataValue(1, _cur__ProductID);
				track_array.AppendDataValue(2, _cur__ReferenceOrderID);
				track_array.AppendDataValue(3, _cur__ReferenceOrderLineID);
				track_array.AppendDataValue(4, _cur__TransactionDate);
				track_array.AppendDataValue(5, _cur__TransactionType);
				track_array.AppendDataValue(6, _cur__Quantity);
				track_array.AppendDataValue(7, _cur__ActualCost);
				track_array.AppendDataValue(8, _cur__ModifiedDate);
			}
			else if (_recordstatus == DataRecordStatus.Existing)
			{
				if (_started_with_dbvalues)
				{
					if (_mod__TransactionID) track_array.AppendDataValue(0, _cur__TransactionID);
				}
				if (_mod__ProductID) track_array.AppendDataValue(1, _cur__ProductID);
				if (_mod__ReferenceOrderID) track_array.AppendDataValue(2, _cur__ReferenceOrderID);
				if (_mod__ReferenceOrderLineID) track_array.AppendDataValue(3, _cur__ReferenceOrderLineID);
				if (_mod__TransactionDate) track_array.AppendDataValue(4, _cur__TransactionDate);
				if (_mod__TransactionType) track_array.AppendDataValue(5, _cur__TransactionType);
				if (_mod__Quantity) track_array.AppendDataValue(6, _cur__Quantity);
				if (_mod__ActualCost) track_array.AppendDataValue(7, _cur__ActualCost);
				if (_mod__ModifiedDate) track_array.AppendDataValue(8, _cur__ModifiedDate);
				if (track_array.HasData == false) return;
			}

			if (_recordstatus == DataRecordStatus.Existing || _recordstatus == DataRecordStatus.ExistingDelete)
			{
				track_array.AppendPrikeyValue(0, (_mod__TransactionID && _started_with_dbvalues) ? _ori__TransactionID : _cur__TransactionID);
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
				if (_mod__TransactionID) _ori__TransactionID = default(int);
				if (_mod__ProductID) _ori__ProductID = default(int);
				if (_mod__ReferenceOrderID) _ori__ReferenceOrderID = default(int);
				if (_mod__ReferenceOrderLineID) _ori__ReferenceOrderLineID = default(int);
				if (_mod__TransactionDate) _ori__TransactionDate = default(DateTime);
				if (_mod__TransactionType) _ori__TransactionType = default(string);
				if (_mod__Quantity) _ori__Quantity = default(int);
				if (_mod__ActualCost) _ori__ActualCost = default(decimal);
				if (_mod__ModifiedDate) _ori__ModifiedDate = default(DateTime);
			}
			_mod__TransactionID = false;
			_mod__ProductID = false;
			_mod__ReferenceOrderID = false;
			_mod__ReferenceOrderLineID = false;
			_mod__TransactionDate = false;
			_mod__TransactionType = false;
			_mod__Quantity = false;
			_mod__ActualCost = false;
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
	public partial class PriKey_Production_TransactionHistoryArchive_Record
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
