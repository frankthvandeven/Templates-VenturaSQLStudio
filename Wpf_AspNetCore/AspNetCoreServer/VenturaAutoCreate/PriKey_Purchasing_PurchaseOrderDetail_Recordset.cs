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
	/// The updateable table is [Purchasing].[PurchaseOrderDetail]. Updateable table column information:
	/// • 11 out of 11 table columns are present in the resultset.
	/// • All primary key columns are present in the resultset: PurchaseOrderID and PurchaseOrderDetailID.
	/// • Non-primary key columns present in the resultset: DueDate, OrderQty, ProductID, UnitPrice, LineTotal, ReceivedQty,
	///   RejectedQty, StockedQty and ModifiedDate.
	/// Recordset item automatically created by VenturaSQL Studio.
	/// </summary>
	public partial class PriKey_Purchasing_PurchaseOrderDetail_Recordset : ResultsetObservable<PriKey_Purchasing_PurchaseOrderDetail_Recordset, PriKey_Purchasing_PurchaseOrderDetail_Record>, IRecordsetBase
	{
		private IResultsetBase[] _resultsets;
		private string _sqlscript;
		private object[] _inputparametervalues;
		private InputParamHolder _inputparamholder;
		private VenturaSqlSchema _parameterschema;
		private int _rowlimit = 500;
		private const string CRLF = "\r\n";

		public PriKey_Purchasing_PurchaseOrderDetail_Recordset()
		{
			_resultsets = new IResultsetBase[] { this };

			_sqlscript = @"SELECT [PurchaseOrderID],[PurchaseOrderDetailID],[DueDate],[OrderQty],[ProductID],[UnitPrice],[LineTotal],[ReceivedQty],[RejectedQty],[StockedQty],[ModifiedDate]" + CRLF +
			             @"FROM [Purchasing].[PurchaseOrderDetail]" + CRLF +
			             @"WHERE [PurchaseOrderID] = @PurchaseOrderID" + CRLF +
			             @"AND [PurchaseOrderDetailID] = @PurchaseOrderDetailID";

			_inputparametervalues = new object[2];
			_inputparamholder = new InputParamHolder(_inputparametervalues);

			ColumnArrayBuilder param_array = new ColumnArrayBuilder();

			param_array.AddParameterColumn("@PurchaseOrderID", typeof(int), true, false, DbType.Int32, null, null, null);
			param_array.AddParameterColumn("@PurchaseOrderDetailID", typeof(int), true, false, DbType.Int32, null, null, null);

			_parameterschema = new VenturaSqlSchema(param_array);

			ColumnArrayBuilder schema_array = new ColumnArrayBuilder();

			schema_array.Add(new VenturaSqlColumn("PurchaseOrderID", typeof(int), false)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				IsKey = true,
				BaseSchemaName = "Purchasing",
				BaseTableName = "PurchaseOrderDetail",
				BaseColumnName = "PurchaseOrderID"
			});

			schema_array.Add(new VenturaSqlColumn("PurchaseOrderDetailID", typeof(int), false)
			{
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				IsKey = true,
				IsIdentity = true,
				IsAutoIncrement = true,
				BaseSchemaName = "Purchasing",
				BaseTableName = "PurchaseOrderDetail",
				BaseColumnName = "PurchaseOrderDetailID"
			});

			schema_array.Add(new VenturaSqlColumn("DueDate", typeof(DateTime), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 23,
				NumericScale = 3,
				ProviderType = 4,
				BaseSchemaName = "Purchasing",
				BaseTableName = "PurchaseOrderDetail",
				BaseColumnName = "DueDate"
			});

			schema_array.Add(new VenturaSqlColumn("OrderQty", typeof(short), false)
			{
				Updateable = true,
				ColumnSize = 2,
				NumericPrecision = 5,
				ProviderType = 16,
				BaseSchemaName = "Purchasing",
				BaseTableName = "PurchaseOrderDetail",
				BaseColumnName = "OrderQty"
			});

			schema_array.Add(new VenturaSqlColumn("ProductID", typeof(int), false)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				BaseSchemaName = "Purchasing",
				BaseTableName = "PurchaseOrderDetail",
				BaseColumnName = "ProductID"
			});

			schema_array.Add(new VenturaSqlColumn("UnitPrice", typeof(decimal), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 19,
				ProviderType = 9,
				BaseSchemaName = "Purchasing",
				BaseTableName = "PurchaseOrderDetail",
				BaseColumnName = "UnitPrice"
			});

			schema_array.Add(new VenturaSqlColumn("LineTotal", typeof(decimal), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 19,
				ProviderType = 9,
				BaseSchemaName = "Purchasing",
				BaseTableName = "PurchaseOrderDetail",
				BaseColumnName = "LineTotal"
			});

			schema_array.Add(new VenturaSqlColumn("ReceivedQty", typeof(decimal), false)
			{
				Updateable = true,
				ColumnSize = 17,
				NumericPrecision = 8,
				NumericScale = 2,
				ProviderType = 5,
				BaseSchemaName = "Purchasing",
				BaseTableName = "PurchaseOrderDetail",
				BaseColumnName = "ReceivedQty"
			});

			schema_array.Add(new VenturaSqlColumn("RejectedQty", typeof(decimal), false)
			{
				Updateable = true,
				ColumnSize = 17,
				NumericPrecision = 8,
				NumericScale = 2,
				ProviderType = 5,
				BaseSchemaName = "Purchasing",
				BaseTableName = "PurchaseOrderDetail",
				BaseColumnName = "RejectedQty"
			});

			schema_array.Add(new VenturaSqlColumn("StockedQty", typeof(decimal), false)
			{
				Updateable = true,
				ColumnSize = 17,
				NumericPrecision = 9,
				NumericScale = 2,
				ProviderType = 5,
				BaseSchemaName = "Purchasing",
				BaseTableName = "PurchaseOrderDetail",
				BaseColumnName = "StockedQty"
			});

			schema_array.Add(new VenturaSqlColumn("ModifiedDate", typeof(DateTime), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 23,
				NumericScale = 3,
				ProviderType = 4,
				BaseSchemaName = "Purchasing",
				BaseTableName = "PurchaseOrderDetail",
				BaseColumnName = "ModifiedDate"
			});

			((IResultsetBase)this).Schema = new VenturaSqlSchema(schema_array);
			((IResultsetBase)this).UpdateableTablename = "[Purchasing].[PurchaseOrderDetail]";
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[PurchaseOrderDetail]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public int PurchaseOrderID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.PurchaseOrderID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.PurchaseOrderID = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Purchasing].[PurchaseOrderDetail]. PrimaryKey. NotReadonly. NotNull. IsIdentity. AutoIncrement.
		/// </summary>
		public int PurchaseOrderDetailID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.PurchaseOrderDetailID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.PurchaseOrderDetailID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[PurchaseOrderDetail]. NotReadonly. NotNull.
		/// </summary>
		public DateTime DueDate
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.DueDate; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.DueDate = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[PurchaseOrderDetail]. NotReadonly. NotNull.
		/// </summary>
		public short OrderQty
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.OrderQty; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.OrderQty = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[PurchaseOrderDetail]. NotReadonly. NotNull.
		/// </summary>
		public int ProductID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ProductID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ProductID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[PurchaseOrderDetail]. NotReadonly. NotNull.
		/// </summary>
		public decimal UnitPrice
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.UnitPrice; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.UnitPrice = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[PurchaseOrderDetail]. NotReadonly. NotNull.
		/// </summary>
		public decimal LineTotal
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.LineTotal; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.LineTotal = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[PurchaseOrderDetail]. NotReadonly. NotNull.
		/// </summary>
		public decimal ReceivedQty
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ReceivedQty; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ReceivedQty = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[PurchaseOrderDetail]. NotReadonly. NotNull.
		/// </summary>
		public decimal RejectedQty
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.RejectedQty; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.RejectedQty = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[PurchaseOrderDetail]. NotReadonly. NotNull.
		/// </summary>
		public decimal StockedQty
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.StockedQty; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.StockedQty = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[PurchaseOrderDetail]. NotReadonly. NotNull.
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
			this.InsertItem(index, new PriKey_Purchasing_PurchaseOrderDetail_Record());
			this.CurrentRecordIndex = index;
		}

		public void Append(PriKey_Purchasing_PurchaseOrderDetail_Record record)
		{
			int index = this.RecordCount;
			this.InsertItem(index, record);
			this.CurrentRecordIndex = index;
		}

		public PriKey_Purchasing_PurchaseOrderDetail_Record NewRecord()
		{
			return new PriKey_Purchasing_PurchaseOrderDetail_Record();
		}

		protected override PriKey_Purchasing_PurchaseOrderDetail_Record InternalCreateExistingRecordObject(object[] columnvalues) => new PriKey_Purchasing_PurchaseOrderDetail_Record(columnvalues);

		byte[] IRecordsetBase.Hash
		{
			get { return new byte[] { 79, 192, 6, 233, 64, 154, 158, 115, 58, 44, 76, 223, 17, 167, 127, 2 }; }
		}

		string IRecordsetBase.HashString
		{
			get { return "4FC006E9409A9E733A2C4CDF11A77F02"; }
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

		public void SetExecSqlParams(int? PurchaseOrderID, int? PurchaseOrderDetailID)
		{
			_inputparametervalues[0] = PurchaseOrderID;
			_inputparametervalues[1] = PurchaseOrderDetailID;
		}

		public void ExecSql(int? PurchaseOrderID, int? PurchaseOrderDetailID)
		{
			_inputparametervalues[0] = PurchaseOrderID;
			_inputparametervalues[1] = PurchaseOrderDetailID;
			Transactional.ExecSql(VenturaSqlConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public void ExecSql(Connector connector, int? PurchaseOrderID, int? PurchaseOrderDetailID)
		{
			_inputparametervalues[0] = PurchaseOrderID;
			_inputparametervalues[1] = PurchaseOrderDetailID;
			Transactional.ExecSql(connector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync(int? PurchaseOrderID, int? PurchaseOrderDetailID)
		{
			_inputparametervalues[0] = PurchaseOrderID;
			_inputparametervalues[1] = PurchaseOrderDetailID;
			await Transactional.ExecSqlAsync(VenturaSqlConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync(Connector connector, int? PurchaseOrderID, int? PurchaseOrderDetailID)
		{
			_inputparametervalues[0] = PurchaseOrderID;
			_inputparametervalues[1] = PurchaseOrderDetailID;
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

			public int? PurchaseOrderID
			{
				get { return (int?)_values[0]; }
				set { _values[0] = value; }
			}

			public int? PurchaseOrderDetailID
			{
				get { return (int?)_values[1]; }
				set { _values[1] = value; }
			}

		}

	}

	public sealed partial class PriKey_Purchasing_PurchaseOrderDetail_Record : IRecordBase, INotifyPropertyChanged
	{
		private DataRecordStatus _recordstatus;
		private bool _started_with_dbvalues;

		private int _cur__PurchaseOrderID; private int _ori__PurchaseOrderID; private bool _mod__PurchaseOrderID;
		private int _cur__PurchaseOrderDetailID; private int _ori__PurchaseOrderDetailID; private bool _mod__PurchaseOrderDetailID;
		private DateTime _cur__DueDate; private DateTime _ori__DueDate; private bool _mod__DueDate;
		private short _cur__OrderQty; private short _ori__OrderQty; private bool _mod__OrderQty;
		private int _cur__ProductID; private int _ori__ProductID; private bool _mod__ProductID;
		private decimal _cur__UnitPrice; private decimal _ori__UnitPrice; private bool _mod__UnitPrice;
		private decimal _cur__LineTotal; private decimal _ori__LineTotal; private bool _mod__LineTotal;
		private decimal _cur__ReceivedQty; private decimal _ori__ReceivedQty; private bool _mod__ReceivedQty;
		private decimal _cur__RejectedQty; private decimal _ori__RejectedQty; private bool _mod__RejectedQty;
		private decimal _cur__StockedQty; private decimal _ori__StockedQty; private bool _mod__StockedQty;
		private DateTime _cur__ModifiedDate; private DateTime _ori__ModifiedDate; private bool _mod__ModifiedDate;


		public PriKey_Purchasing_PurchaseOrderDetail_Record()
		{
			_cur__PurchaseOrderID = 0;
			_cur__PurchaseOrderDetailID = 0;
			_cur__DueDate = new DateTime(1900, 1, 1);
			_cur__OrderQty = 0;
			_cur__ProductID = 0;
			_cur__UnitPrice = 0.0m;
			_cur__LineTotal = 0.0m;
			_cur__ReceivedQty = 0.0m;
			_cur__RejectedQty = 0.0m;
			_cur__StockedQty = 0.0m;
			_cur__ModifiedDate = new DateTime(1900, 1, 1);
			_started_with_dbvalues = false;
			_recordstatus = DataRecordStatus.New;
		}

		public PriKey_Purchasing_PurchaseOrderDetail_Record(object[] columnvalues)
		{
			_cur__PurchaseOrderID = (int)columnvalues[0];
			_cur__PurchaseOrderDetailID = (int)columnvalues[1];
			_cur__DueDate = (DateTime)columnvalues[2];
			_cur__OrderQty = (short)columnvalues[3];
			_cur__ProductID = (int)columnvalues[4];
			_cur__UnitPrice = (decimal)columnvalues[5];
			_cur__LineTotal = (decimal)columnvalues[6];
			_cur__ReceivedQty = (decimal)columnvalues[7];
			_cur__RejectedQty = (decimal)columnvalues[8];
			_cur__StockedQty = (decimal)columnvalues[9];
			_cur__ModifiedDate = (DateTime)columnvalues[10];
			_started_with_dbvalues = true;
			_recordstatus = DataRecordStatus.Existing;
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[PurchaseOrderDetail]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public int PurchaseOrderID
		{
			get { return _cur__PurchaseOrderID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__PurchaseOrderID = true;
				if (_cur__PurchaseOrderID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__PurchaseOrderID == false) { _ori__PurchaseOrderID = _cur__PurchaseOrderID; _mod__PurchaseOrderID = true; } // existing record and column is not modified
					else { if (value == _ori__PurchaseOrderID) { _ori__PurchaseOrderID = default(int); _mod__PurchaseOrderID = false; } } // existing record and column is modified
				}
				_cur__PurchaseOrderID = value; OnPropertyChanged("PurchaseOrderID"); OnAfterPropertyChanged("PurchaseOrderID");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Purchasing].[PurchaseOrderDetail]. PrimaryKey. NotReadonly. NotNull. IsIdentity. AutoIncrement.
		/// </summary>
		public int PurchaseOrderDetailID
		{
			get { return _cur__PurchaseOrderDetailID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__PurchaseOrderDetailID = true;
				if (_cur__PurchaseOrderDetailID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__PurchaseOrderDetailID == false) { _ori__PurchaseOrderDetailID = _cur__PurchaseOrderDetailID; _mod__PurchaseOrderDetailID = true; } // existing record and column is not modified
					else { if (value == _ori__PurchaseOrderDetailID) { _ori__PurchaseOrderDetailID = default(int); _mod__PurchaseOrderDetailID = false; } } // existing record and column is modified
				}
				_cur__PurchaseOrderDetailID = value; OnPropertyChanged("PurchaseOrderDetailID"); OnAfterPropertyChanged("PurchaseOrderDetailID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[PurchaseOrderDetail]. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [Purchasing].[PurchaseOrderDetail]. NotReadonly. NotNull.
		/// </summary>
		public short OrderQty
		{
			get { return _cur__OrderQty; }
			set
			{
				if (_started_with_dbvalues == false) _mod__OrderQty = true;
				if (_cur__OrderQty == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__OrderQty == false) { _ori__OrderQty = _cur__OrderQty; _mod__OrderQty = true; } // existing record and column is not modified
					else { if (value == _ori__OrderQty) { _ori__OrderQty = default(short); _mod__OrderQty = false; } } // existing record and column is modified
				}
				_cur__OrderQty = value; OnPropertyChanged("OrderQty"); OnAfterPropertyChanged("OrderQty");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[PurchaseOrderDetail]. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [Purchasing].[PurchaseOrderDetail]. NotReadonly. NotNull.
		/// </summary>
		public decimal UnitPrice
		{
			get { return _cur__UnitPrice; }
			set
			{
				if (_started_with_dbvalues == false) _mod__UnitPrice = true;
				if (_cur__UnitPrice == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__UnitPrice == false) { _ori__UnitPrice = _cur__UnitPrice; _mod__UnitPrice = true; } // existing record and column is not modified
					else { if (value == _ori__UnitPrice) { _ori__UnitPrice = default(decimal); _mod__UnitPrice = false; } } // existing record and column is modified
				}
				_cur__UnitPrice = value; OnPropertyChanged("UnitPrice"); OnAfterPropertyChanged("UnitPrice");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[PurchaseOrderDetail]. NotReadonly. NotNull.
		/// </summary>
		public decimal LineTotal
		{
			get { return _cur__LineTotal; }
			set
			{
				if (_started_with_dbvalues == false) _mod__LineTotal = true;
				if (_cur__LineTotal == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__LineTotal == false) { _ori__LineTotal = _cur__LineTotal; _mod__LineTotal = true; } // existing record and column is not modified
					else { if (value == _ori__LineTotal) { _ori__LineTotal = default(decimal); _mod__LineTotal = false; } } // existing record and column is modified
				}
				_cur__LineTotal = value; OnPropertyChanged("LineTotal"); OnAfterPropertyChanged("LineTotal");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[PurchaseOrderDetail]. NotReadonly. NotNull.
		/// </summary>
		public decimal ReceivedQty
		{
			get { return _cur__ReceivedQty; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ReceivedQty = true;
				if (_cur__ReceivedQty == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ReceivedQty == false) { _ori__ReceivedQty = _cur__ReceivedQty; _mod__ReceivedQty = true; } // existing record and column is not modified
					else { if (value == _ori__ReceivedQty) { _ori__ReceivedQty = default(decimal); _mod__ReceivedQty = false; } } // existing record and column is modified
				}
				_cur__ReceivedQty = value; OnPropertyChanged("ReceivedQty"); OnAfterPropertyChanged("ReceivedQty");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[PurchaseOrderDetail]. NotReadonly. NotNull.
		/// </summary>
		public decimal RejectedQty
		{
			get { return _cur__RejectedQty; }
			set
			{
				if (_started_with_dbvalues == false) _mod__RejectedQty = true;
				if (_cur__RejectedQty == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__RejectedQty == false) { _ori__RejectedQty = _cur__RejectedQty; _mod__RejectedQty = true; } // existing record and column is not modified
					else { if (value == _ori__RejectedQty) { _ori__RejectedQty = default(decimal); _mod__RejectedQty = false; } } // existing record and column is modified
				}
				_cur__RejectedQty = value; OnPropertyChanged("RejectedQty"); OnAfterPropertyChanged("RejectedQty");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[PurchaseOrderDetail]. NotReadonly. NotNull.
		/// </summary>
		public decimal StockedQty
		{
			get { return _cur__StockedQty; }
			set
			{
				if (_started_with_dbvalues == false) _mod__StockedQty = true;
				if (_cur__StockedQty == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__StockedQty == false) { _ori__StockedQty = _cur__StockedQty; _mod__StockedQty = true; } // existing record and column is not modified
					else { if (value == _ori__StockedQty) { _ori__StockedQty = default(decimal); _mod__StockedQty = false; } } // existing record and column is modified
				}
				_cur__StockedQty = value; OnPropertyChanged("StockedQty"); OnAfterPropertyChanged("StockedQty");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[PurchaseOrderDetail]. NotReadonly. NotNull.
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
			if (column_name == "PurchaseOrderID") return _mod__PurchaseOrderID;
			if (column_name == "PurchaseOrderDetailID") return _mod__PurchaseOrderDetailID;
			if (column_name == "DueDate") return _mod__DueDate;
			if (column_name == "OrderQty") return _mod__OrderQty;
			if (column_name == "ProductID") return _mod__ProductID;
			if (column_name == "UnitPrice") return _mod__UnitPrice;
			if (column_name == "LineTotal") return _mod__LineTotal;
			if (column_name == "ReceivedQty") return _mod__ReceivedQty;
			if (column_name == "RejectedQty") return _mod__RejectedQty;
			if (column_name == "StockedQty") return _mod__StockedQty;
			if (column_name == "ModifiedDate") return _mod__ModifiedDate;
			throw new ArgumentOutOfRangeException(String.Format(VenturaSqlStrings.UNKNOWN_COLUMN_NAME, column_name));
		}

		public int ModifiedColumnCount()
		{
			int count = 0;
			if (_mod__PurchaseOrderID == true) count++;
			if (_mod__PurchaseOrderDetailID == true) count++;
			if (_mod__DueDate == true) count++;
			if (_mod__OrderQty == true) count++;
			if (_mod__ProductID == true) count++;
			if (_mod__UnitPrice == true) count++;
			if (_mod__LineTotal == true) count++;
			if (_mod__ReceivedQty == true) count++;
			if (_mod__RejectedQty == true) count++;
			if (_mod__StockedQty == true) count++;
			if (_mod__ModifiedDate == true) count++;
			return count;
		}

		public bool PendingChanges()
		{
			if (_recordstatus == DataRecordStatus.New || _recordstatus == DataRecordStatus.ExistingDelete) return true;
			int count = 0;
			if (_started_with_dbvalues)
			{
				if (_mod__PurchaseOrderID) count++;
			}
			if (_mod__DueDate == true) count++;
			if (_mod__OrderQty == true) count++;
			if (_mod__ProductID == true) count++;
			if (_mod__UnitPrice == true) count++;
			if (_mod__LineTotal == true) count++;
			if (_mod__ReceivedQty == true) count++;
			if (_mod__RejectedQty == true) count++;
			if (_mod__StockedQty == true) count++;
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
			if (_mod__PurchaseOrderID == false) throw new Exception(string.Format(VenturaSqlStrings.VALUE_NOT_SET_MSG, record_index_to_display, "PurchaseOrderID"));
		}

		void IRecordBase.WriteChangesToTrackArray(TrackArray track_array)
		{
			if (_recordstatus == DataRecordStatus.New)
			{
				track_array.AppendDataValue(0, _cur__PurchaseOrderID);
				track_array.AppendDataValue(2, _cur__DueDate);
				track_array.AppendDataValue(3, _cur__OrderQty);
				track_array.AppendDataValue(4, _cur__ProductID);
				track_array.AppendDataValue(5, _cur__UnitPrice);
				track_array.AppendDataValue(6, _cur__LineTotal);
				track_array.AppendDataValue(7, _cur__ReceivedQty);
				track_array.AppendDataValue(8, _cur__RejectedQty);
				track_array.AppendDataValue(9, _cur__StockedQty);
				track_array.AppendDataValue(10, _cur__ModifiedDate);
			}
			else if (_recordstatus == DataRecordStatus.Existing)
			{
				if (_started_with_dbvalues)
				{
					if (_mod__PurchaseOrderID) track_array.AppendDataValue(0, _cur__PurchaseOrderID);
				}
				if (_mod__DueDate) track_array.AppendDataValue(2, _cur__DueDate);
				if (_mod__OrderQty) track_array.AppendDataValue(3, _cur__OrderQty);
				if (_mod__ProductID) track_array.AppendDataValue(4, _cur__ProductID);
				if (_mod__UnitPrice) track_array.AppendDataValue(5, _cur__UnitPrice);
				if (_mod__LineTotal) track_array.AppendDataValue(6, _cur__LineTotal);
				if (_mod__ReceivedQty) track_array.AppendDataValue(7, _cur__ReceivedQty);
				if (_mod__RejectedQty) track_array.AppendDataValue(8, _cur__RejectedQty);
				if (_mod__StockedQty) track_array.AppendDataValue(9, _cur__StockedQty);
				if (_mod__ModifiedDate) track_array.AppendDataValue(10, _cur__ModifiedDate);
				if (track_array.HasData == false) return;
			}

			if (_recordstatus == DataRecordStatus.Existing || _recordstatus == DataRecordStatus.ExistingDelete)
			{
				track_array.AppendPrikeyValue(0, (_mod__PurchaseOrderID && _started_with_dbvalues) ? _ori__PurchaseOrderID : _cur__PurchaseOrderID);
				track_array.AppendPrikeyValue(1, (_mod__PurchaseOrderDetailID && _started_with_dbvalues) ? _ori__PurchaseOrderDetailID : _cur__PurchaseOrderDetailID);
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
				if (_mod__PurchaseOrderID) _ori__PurchaseOrderID = default(int);
				if (_mod__PurchaseOrderDetailID) _ori__PurchaseOrderDetailID = default(int);
				if (_mod__DueDate) _ori__DueDate = default(DateTime);
				if (_mod__OrderQty) _ori__OrderQty = default(short);
				if (_mod__ProductID) _ori__ProductID = default(int);
				if (_mod__UnitPrice) _ori__UnitPrice = default(decimal);
				if (_mod__LineTotal) _ori__LineTotal = default(decimal);
				if (_mod__ReceivedQty) _ori__ReceivedQty = default(decimal);
				if (_mod__RejectedQty) _ori__RejectedQty = default(decimal);
				if (_mod__StockedQty) _ori__StockedQty = default(decimal);
				if (_mod__ModifiedDate) _ori__ModifiedDate = default(DateTime);
			}
			_mod__PurchaseOrderID = false;
			_mod__PurchaseOrderDetailID = false;
			_mod__DueDate = false;
			_mod__OrderQty = false;
			_mod__ProductID = false;
			_mod__UnitPrice = false;
			_mod__LineTotal = false;
			_mod__ReceivedQty = false;
			_mod__RejectedQty = false;
			_mod__StockedQty = false;
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
			_cur__PurchaseOrderDetailID = (int)value;
			OnPropertyChanged("PurchaseOrderDetailID");
			OnAfterPropertyChanged("PurchaseOrderDetailID");
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
	public partial class PriKey_Purchasing_PurchaseOrderDetail_Record
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
