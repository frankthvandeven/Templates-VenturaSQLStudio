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
	/// The updateable table is [Production].[WorkOrder]. Updateable table column information:
	/// • 10 out of 10 table columns are present in the resultset.
	/// • All primary key columns are present in the resultset: WorkOrderID.
	/// • Non-primary key columns present in the resultset: ProductID, OrderQty, StockedQty, ScrappedQty, StartDate, EndDate,
	///   DueDate, ScrapReasonID and ModifiedDate.
	/// Recordset item automatically created by VenturaSQL Studio.
	/// </summary>
	public partial class GetAll_Production_WorkOrder_Recordset : ResultsetObservable<GetAll_Production_WorkOrder_Recordset, GetAll_Production_WorkOrder_Record>, IRecordsetBase
	{
		private IResultsetBase[] _resultsets;
		private string _sqlscript;
		private int _rowlimit = 500;
		private const string CRLF = "\r\n";

		public GetAll_Production_WorkOrder_Recordset()
		{
			_resultsets = new IResultsetBase[] { this };

			_sqlscript = @"SELECT TOP(@RowLimit) [WorkOrderID],[ProductID],[OrderQty],[StockedQty],[ScrappedQty],[StartDate],[EndDate],[DueDate],[ScrapReasonID],[ModifiedDate]" + CRLF +
			             @"FROM [Production].[WorkOrder]";

			ColumnArrayBuilder schema_array = new ColumnArrayBuilder();

			schema_array.Add(new VenturaSqlColumn("WorkOrderID", typeof(int), false)
			{
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				IsKey = true,
				IsIdentity = true,
				IsAutoIncrement = true,
				BaseSchemaName = "Production",
				BaseTableName = "WorkOrder",
				BaseColumnName = "WorkOrderID"
			});

			schema_array.Add(new VenturaSqlColumn("ProductID", typeof(int), false)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				BaseSchemaName = "Production",
				BaseTableName = "WorkOrder",
				BaseColumnName = "ProductID"
			});

			schema_array.Add(new VenturaSqlColumn("OrderQty", typeof(int), false)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				BaseSchemaName = "Production",
				BaseTableName = "WorkOrder",
				BaseColumnName = "OrderQty"
			});

			schema_array.Add(new VenturaSqlColumn("StockedQty", typeof(int), false)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				BaseSchemaName = "Production",
				BaseTableName = "WorkOrder",
				BaseColumnName = "StockedQty"
			});

			schema_array.Add(new VenturaSqlColumn("ScrappedQty", typeof(short), false)
			{
				Updateable = true,
				ColumnSize = 2,
				NumericPrecision = 5,
				ProviderType = 16,
				BaseSchemaName = "Production",
				BaseTableName = "WorkOrder",
				BaseColumnName = "ScrappedQty"
			});

			schema_array.Add(new VenturaSqlColumn("StartDate", typeof(DateTime), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 23,
				NumericScale = 3,
				ProviderType = 4,
				BaseSchemaName = "Production",
				BaseTableName = "WorkOrder",
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
				BaseTableName = "WorkOrder",
				BaseColumnName = "EndDate"
			});

			schema_array.Add(new VenturaSqlColumn("DueDate", typeof(DateTime), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 23,
				NumericScale = 3,
				ProviderType = 4,
				BaseSchemaName = "Production",
				BaseTableName = "WorkOrder",
				BaseColumnName = "DueDate"
			});

			schema_array.Add(new VenturaSqlColumn("ScrapReasonID", typeof(short), true)
			{
				Updateable = true,
				ColumnSize = 2,
				NumericPrecision = 5,
				ProviderType = 16,
				BaseSchemaName = "Production",
				BaseTableName = "WorkOrder",
				BaseColumnName = "ScrapReasonID"
			});

			schema_array.Add(new VenturaSqlColumn("ModifiedDate", typeof(DateTime), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 23,
				NumericScale = 3,
				ProviderType = 4,
				BaseSchemaName = "Production",
				BaseTableName = "WorkOrder",
				BaseColumnName = "ModifiedDate"
			});

			((IResultsetBase)this).Schema = new VenturaSqlSchema(schema_array);
			((IResultsetBase)this).UpdateableTablename = "[Production].[WorkOrder]";
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Production].[WorkOrder]. PrimaryKey. NotReadonly. NotNull. IsIdentity. AutoIncrement.
		/// </summary>
		public int WorkOrderID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.WorkOrderID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.WorkOrderID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[WorkOrder]. NotReadonly. NotNull.
		/// </summary>
		public int ProductID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ProductID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ProductID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[WorkOrder]. NotReadonly. NotNull.
		/// </summary>
		public int OrderQty
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.OrderQty; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.OrderQty = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[WorkOrder]. NotReadonly. NotNull.
		/// </summary>
		public int StockedQty
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.StockedQty; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.StockedQty = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[WorkOrder]. NotReadonly. NotNull.
		/// </summary>
		public short ScrappedQty
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ScrappedQty; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ScrappedQty = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[WorkOrder]. NotReadonly. NotNull.
		/// </summary>
		public DateTime StartDate
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.StartDate; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.StartDate = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[WorkOrder]. NotReadonly. AllowNull.
		/// </summary>
		public DateTime? EndDate
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.EndDate; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.EndDate = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[WorkOrder]. NotReadonly. NotNull.
		/// </summary>
		public DateTime DueDate
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.DueDate; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.DueDate = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[WorkOrder]. NotReadonly. AllowNull.
		/// </summary>
		public short? ScrapReasonID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ScrapReasonID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ScrapReasonID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[WorkOrder]. NotReadonly. NotNull.
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
			this.InsertItem(index, new GetAll_Production_WorkOrder_Record());
			this.CurrentRecordIndex = index;
		}

		public void Append(GetAll_Production_WorkOrder_Record record)
		{
			int index = this.RecordCount;
			this.InsertItem(index, record);
			this.CurrentRecordIndex = index;
		}

		public GetAll_Production_WorkOrder_Record NewRecord()
		{
			return new GetAll_Production_WorkOrder_Record();
		}

		protected override GetAll_Production_WorkOrder_Record InternalCreateExistingRecordObject(object[] columnvalues) => new GetAll_Production_WorkOrder_Record(columnvalues);

		byte[] IRecordsetBase.Hash
		{
			get { return new byte[] { 105, 237, 54, 159, 9, 66, 202, 234, 124, 252, 31, 94, 63, 181, 147, 229 }; }
		}

		string IRecordsetBase.HashString
		{
			get { return "69ED369F0942CAEA7CFC1F5E3FB593E5"; }
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

	public sealed partial class GetAll_Production_WorkOrder_Record : IRecordBase, INotifyPropertyChanged
	{
		private DataRecordStatus _recordstatus;
		private bool _started_with_dbvalues;

		private int _cur__WorkOrderID; private int _ori__WorkOrderID; private bool _mod__WorkOrderID;
		private int _cur__ProductID; private int _ori__ProductID; private bool _mod__ProductID;
		private int _cur__OrderQty; private int _ori__OrderQty; private bool _mod__OrderQty;
		private int _cur__StockedQty; private int _ori__StockedQty; private bool _mod__StockedQty;
		private short _cur__ScrappedQty; private short _ori__ScrappedQty; private bool _mod__ScrappedQty;
		private DateTime _cur__StartDate; private DateTime _ori__StartDate; private bool _mod__StartDate;
		private DateTime? _cur__EndDate; private DateTime? _ori__EndDate; private bool _mod__EndDate;
		private DateTime _cur__DueDate; private DateTime _ori__DueDate; private bool _mod__DueDate;
		private short? _cur__ScrapReasonID; private short? _ori__ScrapReasonID; private bool _mod__ScrapReasonID;
		private DateTime _cur__ModifiedDate; private DateTime _ori__ModifiedDate; private bool _mod__ModifiedDate;


		public GetAll_Production_WorkOrder_Record()
		{
			_cur__WorkOrderID = 0;
			_cur__ProductID = 0;
			_cur__OrderQty = 0;
			_cur__StockedQty = 0;
			_cur__ScrappedQty = 0;
			_cur__StartDate = new DateTime(1900, 1, 1);
			_cur__EndDate = null;
			_cur__DueDate = new DateTime(1900, 1, 1);
			_cur__ScrapReasonID = null;
			_cur__ModifiedDate = new DateTime(1900, 1, 1);
			_started_with_dbvalues = false;
			_recordstatus = DataRecordStatus.New;
		}

		public GetAll_Production_WorkOrder_Record(object[] columnvalues)
		{
			_cur__WorkOrderID = (int)columnvalues[0];
			_cur__ProductID = (int)columnvalues[1];
			_cur__OrderQty = (int)columnvalues[2];
			_cur__StockedQty = (int)columnvalues[3];
			_cur__ScrappedQty = (short)columnvalues[4];
			_cur__StartDate = (DateTime)columnvalues[5];
			_cur__EndDate = (DateTime?)columnvalues[6];
			_cur__DueDate = (DateTime)columnvalues[7];
			_cur__ScrapReasonID = (short?)columnvalues[8];
			_cur__ModifiedDate = (DateTime)columnvalues[9];
			_started_with_dbvalues = true;
			_recordstatus = DataRecordStatus.Existing;
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Production].[WorkOrder]. PrimaryKey. NotReadonly. NotNull. IsIdentity. AutoIncrement.
		/// </summary>
		public int WorkOrderID
		{
			get { return _cur__WorkOrderID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__WorkOrderID = true;
				if (_cur__WorkOrderID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__WorkOrderID == false) { _ori__WorkOrderID = _cur__WorkOrderID; _mod__WorkOrderID = true; } // existing record and column is not modified
					else { if (value == _ori__WorkOrderID) { _ori__WorkOrderID = default(int); _mod__WorkOrderID = false; } } // existing record and column is modified
				}
				_cur__WorkOrderID = value; OnPropertyChanged("WorkOrderID"); OnAfterPropertyChanged("WorkOrderID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[WorkOrder]. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [Production].[WorkOrder]. NotReadonly. NotNull.
		/// </summary>
		public int OrderQty
		{
			get { return _cur__OrderQty; }
			set
			{
				if (_started_with_dbvalues == false) _mod__OrderQty = true;
				if (_cur__OrderQty == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__OrderQty == false) { _ori__OrderQty = _cur__OrderQty; _mod__OrderQty = true; } // existing record and column is not modified
					else { if (value == _ori__OrderQty) { _ori__OrderQty = default(int); _mod__OrderQty = false; } } // existing record and column is modified
				}
				_cur__OrderQty = value; OnPropertyChanged("OrderQty"); OnAfterPropertyChanged("OrderQty");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[WorkOrder]. NotReadonly. NotNull.
		/// </summary>
		public int StockedQty
		{
			get { return _cur__StockedQty; }
			set
			{
				if (_started_with_dbvalues == false) _mod__StockedQty = true;
				if (_cur__StockedQty == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__StockedQty == false) { _ori__StockedQty = _cur__StockedQty; _mod__StockedQty = true; } // existing record and column is not modified
					else { if (value == _ori__StockedQty) { _ori__StockedQty = default(int); _mod__StockedQty = false; } } // existing record and column is modified
				}
				_cur__StockedQty = value; OnPropertyChanged("StockedQty"); OnAfterPropertyChanged("StockedQty");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[WorkOrder]. NotReadonly. NotNull.
		/// </summary>
		public short ScrappedQty
		{
			get { return _cur__ScrappedQty; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ScrappedQty = true;
				if (_cur__ScrappedQty == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ScrappedQty == false) { _ori__ScrappedQty = _cur__ScrappedQty; _mod__ScrappedQty = true; } // existing record and column is not modified
					else { if (value == _ori__ScrappedQty) { _ori__ScrappedQty = default(short); _mod__ScrappedQty = false; } } // existing record and column is modified
				}
				_cur__ScrappedQty = value; OnPropertyChanged("ScrappedQty"); OnAfterPropertyChanged("ScrappedQty");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[WorkOrder]. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [Production].[WorkOrder]. NotReadonly. AllowNull.
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
		/// Database Column Updateable. Table [Production].[WorkOrder]. NotReadonly. NotNull.
		/// </summary>
		public DateTime DueDate
		{
			get { return _cur__DueDate; }
			set
			{
				if (_started_with_dbvalues == false) _mod__DueDate = true;
				if (_cur__DueDate == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__DueDate == false) { _ori__DueDate = _cur__DueDate; _mod__DueDate = true; } // existing record and column is not modified
					else { if (value == _ori__DueDate) { _ori__DueDate = default(DateTime); _mod__DueDate = false; } } // existing record and column is modified
				}
				_cur__DueDate = value; OnPropertyChanged("DueDate"); OnAfterPropertyChanged("DueDate");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[WorkOrder]. NotReadonly. AllowNull.
		/// </summary>
		public short? ScrapReasonID
		{
			get { return _cur__ScrapReasonID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ScrapReasonID = true;
				if (_cur__ScrapReasonID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ScrapReasonID == false) { _ori__ScrapReasonID = _cur__ScrapReasonID; _mod__ScrapReasonID = true; } // existing record and column is not modified
					else { if (value == _ori__ScrapReasonID) { _ori__ScrapReasonID = default(short?); _mod__ScrapReasonID = false; } } // existing record and column is modified
				}
				_cur__ScrapReasonID = value; OnPropertyChanged("ScrapReasonID"); OnAfterPropertyChanged("ScrapReasonID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[WorkOrder]. NotReadonly. NotNull.
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
			if (column_name == "WorkOrderID") return _mod__WorkOrderID;
			if (column_name == "ProductID") return _mod__ProductID;
			if (column_name == "OrderQty") return _mod__OrderQty;
			if (column_name == "StockedQty") return _mod__StockedQty;
			if (column_name == "ScrappedQty") return _mod__ScrappedQty;
			if (column_name == "StartDate") return _mod__StartDate;
			if (column_name == "EndDate") return _mod__EndDate;
			if (column_name == "DueDate") return _mod__DueDate;
			if (column_name == "ScrapReasonID") return _mod__ScrapReasonID;
			if (column_name == "ModifiedDate") return _mod__ModifiedDate;
			throw new ArgumentOutOfRangeException(String.Format(VenturaSqlStrings.UNKNOWN_COLUMN_NAME, column_name));
		}

		public int ModifiedColumnCount()
		{
			int count = 0;
			if (_mod__WorkOrderID == true) count++;
			if (_mod__ProductID == true) count++;
			if (_mod__OrderQty == true) count++;
			if (_mod__StockedQty == true) count++;
			if (_mod__ScrappedQty == true) count++;
			if (_mod__StartDate == true) count++;
			if (_mod__EndDate == true) count++;
			if (_mod__DueDate == true) count++;
			if (_mod__ScrapReasonID == true) count++;
			if (_mod__ModifiedDate == true) count++;
			return count;
		}

		public bool PendingChanges()
		{
			if (_recordstatus == DataRecordStatus.New || _recordstatus == DataRecordStatus.ExistingDelete) return true;
			int count = 0;
			if (_mod__ProductID == true) count++;
			if (_mod__OrderQty == true) count++;
			if (_mod__StockedQty == true) count++;
			if (_mod__ScrappedQty == true) count++;
			if (_mod__StartDate == true) count++;
			if (_mod__EndDate == true) count++;
			if (_mod__DueDate == true) count++;
			if (_mod__ScrapReasonID == true) count++;
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
				track_array.AppendDataValue(1, _cur__ProductID);
				track_array.AppendDataValue(2, _cur__OrderQty);
				track_array.AppendDataValue(3, _cur__StockedQty);
				track_array.AppendDataValue(4, _cur__ScrappedQty);
				track_array.AppendDataValue(5, _cur__StartDate);
				if (_cur__EndDate != null) track_array.AppendDataValue(6, _cur__EndDate);
				track_array.AppendDataValue(7, _cur__DueDate);
				if (_cur__ScrapReasonID != null) track_array.AppendDataValue(8, _cur__ScrapReasonID);
				track_array.AppendDataValue(9, _cur__ModifiedDate);
			}
			else if (_recordstatus == DataRecordStatus.Existing)
			{
				if (_mod__ProductID) track_array.AppendDataValue(1, _cur__ProductID);
				if (_mod__OrderQty) track_array.AppendDataValue(2, _cur__OrderQty);
				if (_mod__StockedQty) track_array.AppendDataValue(3, _cur__StockedQty);
				if (_mod__ScrappedQty) track_array.AppendDataValue(4, _cur__ScrappedQty);
				if (_mod__StartDate) track_array.AppendDataValue(5, _cur__StartDate);
				if (_mod__EndDate) track_array.AppendDataValue(6, _cur__EndDate);
				if (_mod__DueDate) track_array.AppendDataValue(7, _cur__DueDate);
				if (_mod__ScrapReasonID) track_array.AppendDataValue(8, _cur__ScrapReasonID);
				if (_mod__ModifiedDate) track_array.AppendDataValue(9, _cur__ModifiedDate);
				if (track_array.HasData == false) return;
			}

			if (_recordstatus == DataRecordStatus.Existing || _recordstatus == DataRecordStatus.ExistingDelete)
			{
				track_array.AppendPrikeyValue(0, (_mod__WorkOrderID && _started_with_dbvalues) ? _ori__WorkOrderID : _cur__WorkOrderID);
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
				if (_mod__WorkOrderID) _ori__WorkOrderID = default(int);
				if (_mod__ProductID) _ori__ProductID = default(int);
				if (_mod__OrderQty) _ori__OrderQty = default(int);
				if (_mod__StockedQty) _ori__StockedQty = default(int);
				if (_mod__ScrappedQty) _ori__ScrappedQty = default(short);
				if (_mod__StartDate) _ori__StartDate = default(DateTime);
				if (_mod__EndDate) _ori__EndDate = default(DateTime?);
				if (_mod__DueDate) _ori__DueDate = default(DateTime);
				if (_mod__ScrapReasonID) _ori__ScrapReasonID = default(short?);
				if (_mod__ModifiedDate) _ori__ModifiedDate = default(DateTime);
			}
			_mod__WorkOrderID = false;
			_mod__ProductID = false;
			_mod__OrderQty = false;
			_mod__StockedQty = false;
			_mod__ScrappedQty = false;
			_mod__StartDate = false;
			_mod__EndDate = false;
			_mod__DueDate = false;
			_mod__ScrapReasonID = false;
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
			_cur__WorkOrderID = (int)value;
			OnPropertyChanged("WorkOrderID");
			OnAfterPropertyChanged("WorkOrderID");
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
	public partial class GetAll_Production_WorkOrder_Record
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
