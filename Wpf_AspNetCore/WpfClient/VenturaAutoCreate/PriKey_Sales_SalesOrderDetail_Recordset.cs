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
	/// The updateable table is [Sales].[SalesOrderDetail]. Updateable table column information:
	/// • 11 out of 11 table columns are present in the resultset.
	/// • All primary key columns are present in the resultset: SalesOrderID and SalesOrderDetailID.
	/// • Non-primary key columns present in the resultset: CarrierTrackingNumber, OrderQty, ProductID, SpecialOfferID, UnitPrice,
	///   UnitPriceDiscount, LineTotal, rowguid and ModifiedDate.
	/// Recordset item automatically created by VenturaSQL Studio.
	/// </summary>
	public partial class PriKey_Sales_SalesOrderDetail_Recordset : ResultsetObservable<PriKey_Sales_SalesOrderDetail_Recordset, PriKey_Sales_SalesOrderDetail_Record>, IRecordsetBase
	{
		private IResultsetBase[] _resultsets;
		private string _sqlscript;
		private object[] _inputparametervalues;
		private InputParamHolder _inputparamholder;
		private VenturaSqlSchema _parameterschema;
		private int _rowlimit = 500;
		private const string CRLF = "\r\n";

		public PriKey_Sales_SalesOrderDetail_Recordset()
		{
			_resultsets = new IResultsetBase[] { this };

			_sqlscript = @"SELECT [SalesOrderID],[SalesOrderDetailID],[CarrierTrackingNumber],[OrderQty],[ProductID],[SpecialOfferID],[UnitPrice],[UnitPriceDiscount],[LineTotal]," + CRLF +
			             @"[rowguid],[ModifiedDate]" + CRLF +
			             @"FROM [Sales].[SalesOrderDetail]" + CRLF +
			             @"WHERE [SalesOrderID] = @SalesOrderID" + CRLF +
			             @"AND [SalesOrderDetailID] = @SalesOrderDetailID";

			_inputparametervalues = new object[2];
			_inputparamholder = new InputParamHolder(_inputparametervalues);

			ColumnArrayBuilder param_array = new ColumnArrayBuilder();

			param_array.AddParameterColumn("@SalesOrderID", typeof(int), true, false, DbType.Int32, null, null, null);
			param_array.AddParameterColumn("@SalesOrderDetailID", typeof(int), true, false, DbType.Int32, null, null, null);

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
				BaseTableName = "SalesOrderDetail",
				BaseColumnName = "SalesOrderID"
			});

			schema_array.Add(new VenturaSqlColumn("SalesOrderDetailID", typeof(int), false)
			{
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				IsKey = true,
				IsIdentity = true,
				IsAutoIncrement = true,
				BaseSchemaName = "Sales",
				BaseTableName = "SalesOrderDetail",
				BaseColumnName = "SalesOrderDetailID"
			});

			schema_array.Add(new VenturaSqlColumn("CarrierTrackingNumber", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 25,
				ProviderType = 12,
				BaseSchemaName = "Sales",
				BaseTableName = "SalesOrderDetail",
				BaseColumnName = "CarrierTrackingNumber"
			});

			schema_array.Add(new VenturaSqlColumn("OrderQty", typeof(short), false)
			{
				Updateable = true,
				ColumnSize = 2,
				NumericPrecision = 5,
				ProviderType = 16,
				BaseSchemaName = "Sales",
				BaseTableName = "SalesOrderDetail",
				BaseColumnName = "OrderQty"
			});

			schema_array.Add(new VenturaSqlColumn("ProductID", typeof(int), false)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				BaseSchemaName = "Sales",
				BaseTableName = "SalesOrderDetail",
				BaseColumnName = "ProductID"
			});

			schema_array.Add(new VenturaSqlColumn("SpecialOfferID", typeof(int), false)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				BaseSchemaName = "Sales",
				BaseTableName = "SalesOrderDetail",
				BaseColumnName = "SpecialOfferID"
			});

			schema_array.Add(new VenturaSqlColumn("UnitPrice", typeof(decimal), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 19,
				ProviderType = 9,
				BaseSchemaName = "Sales",
				BaseTableName = "SalesOrderDetail",
				BaseColumnName = "UnitPrice"
			});

			schema_array.Add(new VenturaSqlColumn("UnitPriceDiscount", typeof(decimal), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 19,
				ProviderType = 9,
				BaseSchemaName = "Sales",
				BaseTableName = "SalesOrderDetail",
				BaseColumnName = "UnitPriceDiscount"
			});

			schema_array.Add(new VenturaSqlColumn("LineTotal", typeof(decimal), false)
			{
				Updateable = true,
				ColumnSize = 17,
				NumericPrecision = 38,
				NumericScale = 6,
				ProviderType = 5,
				BaseSchemaName = "Sales",
				BaseTableName = "SalesOrderDetail",
				BaseColumnName = "LineTotal"
			});

			schema_array.Add(new VenturaSqlColumn("rowguid", typeof(Guid), false)
			{
				Updateable = true,
				ColumnSize = 16,
				ProviderType = 14,
				BaseSchemaName = "Sales",
				BaseTableName = "SalesOrderDetail",
				BaseColumnName = "rowguid"
			});

			schema_array.Add(new VenturaSqlColumn("ModifiedDate", typeof(DateTime), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 23,
				NumericScale = 3,
				ProviderType = 4,
				BaseSchemaName = "Sales",
				BaseTableName = "SalesOrderDetail",
				BaseColumnName = "ModifiedDate"
			});

			((IResultsetBase)this).Schema = new VenturaSqlSchema(schema_array);
			((IResultsetBase)this).UpdateableTablename = "[Sales].[SalesOrderDetail]";
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderDetail]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public int SalesOrderID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.SalesOrderID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.SalesOrderID = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Sales].[SalesOrderDetail]. PrimaryKey. NotReadonly. NotNull. IsIdentity. AutoIncrement.
		/// </summary>
		public int SalesOrderDetailID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.SalesOrderDetailID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.SalesOrderDetailID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderDetail]. NotReadonly. AllowNull.
		/// </summary>
		public string CarrierTrackingNumber
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.CarrierTrackingNumber; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.CarrierTrackingNumber = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderDetail]. NotReadonly. NotNull.
		/// </summary>
		public short OrderQty
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.OrderQty; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.OrderQty = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderDetail]. NotReadonly. NotNull.
		/// </summary>
		public int ProductID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ProductID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ProductID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderDetail]. NotReadonly. NotNull.
		/// </summary>
		public int SpecialOfferID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.SpecialOfferID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.SpecialOfferID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderDetail]. NotReadonly. NotNull.
		/// </summary>
		public decimal UnitPrice
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.UnitPrice; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.UnitPrice = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderDetail]. NotReadonly. NotNull.
		/// </summary>
		public decimal UnitPriceDiscount
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.UnitPriceDiscount; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.UnitPriceDiscount = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderDetail]. NotReadonly. NotNull.
		/// </summary>
		public decimal LineTotal
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.LineTotal; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.LineTotal = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderDetail]. NotReadonly. NotNull.
		/// </summary>
		public Guid rowguid
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.rowguid; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.rowguid = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderDetail]. NotReadonly. NotNull.
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
			this.InsertItem(index, new PriKey_Sales_SalesOrderDetail_Record());
			this.CurrentRecordIndex = index;
		}

		public void Append(PriKey_Sales_SalesOrderDetail_Record record)
		{
			int index = this.RecordCount;
			this.InsertItem(index, record);
			this.CurrentRecordIndex = index;
		}

		public PriKey_Sales_SalesOrderDetail_Record NewRecord()
		{
			return new PriKey_Sales_SalesOrderDetail_Record();
		}

		protected override PriKey_Sales_SalesOrderDetail_Record InternalCreateExistingRecordObject(object[] columnvalues) => new PriKey_Sales_SalesOrderDetail_Record(columnvalues);

		byte[] IRecordsetBase.Hash
		{
			get { return new byte[] { 104, 67, 74, 89, 41, 82, 190, 107, 68, 236, 159, 4, 104, 4, 78, 58 }; }
		}

		string IRecordsetBase.HashString
		{
			get { return "68434A592952BE6B44EC9F0468044E3A"; }
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

		public void SetExecSqlParams(int? SalesOrderID, int? SalesOrderDetailID)
		{
			_inputparametervalues[0] = SalesOrderID;
			_inputparametervalues[1] = SalesOrderDetailID;
		}

		public void ExecSql(int? SalesOrderID, int? SalesOrderDetailID)
		{
			_inputparametervalues[0] = SalesOrderID;
			_inputparametervalues[1] = SalesOrderDetailID;
			Transactional.ExecSql(VenturaSqlConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public void ExecSql(Connector connector, int? SalesOrderID, int? SalesOrderDetailID)
		{
			_inputparametervalues[0] = SalesOrderID;
			_inputparametervalues[1] = SalesOrderDetailID;
			Transactional.ExecSql(connector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync(int? SalesOrderID, int? SalesOrderDetailID)
		{
			_inputparametervalues[0] = SalesOrderID;
			_inputparametervalues[1] = SalesOrderDetailID;
			await Transactional.ExecSqlAsync(VenturaSqlConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync(Connector connector, int? SalesOrderID, int? SalesOrderDetailID)
		{
			_inputparametervalues[0] = SalesOrderID;
			_inputparametervalues[1] = SalesOrderDetailID;
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

			public int? SalesOrderDetailID
			{
				get { return (int?)_values[1]; }
				set { _values[1] = value; }
			}

		}

	}

	public sealed partial class PriKey_Sales_SalesOrderDetail_Record : IRecordBase, INotifyPropertyChanged
	{
		private DataRecordStatus _recordstatus;
		private bool _started_with_dbvalues;

		private int _cur__SalesOrderID; private int _ori__SalesOrderID; private bool _mod__SalesOrderID;
		private int _cur__SalesOrderDetailID; private int _ori__SalesOrderDetailID; private bool _mod__SalesOrderDetailID;
		private string _cur__CarrierTrackingNumber; private string _ori__CarrierTrackingNumber; private bool _mod__CarrierTrackingNumber;
		private short _cur__OrderQty; private short _ori__OrderQty; private bool _mod__OrderQty;
		private int _cur__ProductID; private int _ori__ProductID; private bool _mod__ProductID;
		private int _cur__SpecialOfferID; private int _ori__SpecialOfferID; private bool _mod__SpecialOfferID;
		private decimal _cur__UnitPrice; private decimal _ori__UnitPrice; private bool _mod__UnitPrice;
		private decimal _cur__UnitPriceDiscount; private decimal _ori__UnitPriceDiscount; private bool _mod__UnitPriceDiscount;
		private decimal _cur__LineTotal; private decimal _ori__LineTotal; private bool _mod__LineTotal;
		private Guid _cur__rowguid; private Guid _ori__rowguid; private bool _mod__rowguid;
		private DateTime _cur__ModifiedDate; private DateTime _ori__ModifiedDate; private bool _mod__ModifiedDate;


		public PriKey_Sales_SalesOrderDetail_Record()
		{
			_cur__SalesOrderID = 0;
			_cur__SalesOrderDetailID = 0;
			_cur__CarrierTrackingNumber = null;
			_cur__OrderQty = 0;
			_cur__ProductID = 0;
			_cur__SpecialOfferID = 0;
			_cur__UnitPrice = 0.0m;
			_cur__UnitPriceDiscount = 0.0m;
			_cur__LineTotal = 0.0m;
			_cur__rowguid = Guid.Empty;
			_cur__ModifiedDate = new DateTime(1900, 1, 1);
			_started_with_dbvalues = false;
			_recordstatus = DataRecordStatus.New;
		}

		public PriKey_Sales_SalesOrderDetail_Record(object[] columnvalues)
		{
			_cur__SalesOrderID = (int)columnvalues[0];
			_cur__SalesOrderDetailID = (int)columnvalues[1];
			_cur__CarrierTrackingNumber = (string)columnvalues[2];
			_cur__OrderQty = (short)columnvalues[3];
			_cur__ProductID = (int)columnvalues[4];
			_cur__SpecialOfferID = (int)columnvalues[5];
			_cur__UnitPrice = (decimal)columnvalues[6];
			_cur__UnitPriceDiscount = (decimal)columnvalues[7];
			_cur__LineTotal = (decimal)columnvalues[8];
			_cur__rowguid = (Guid)columnvalues[9];
			_cur__ModifiedDate = (DateTime)columnvalues[10];
			_started_with_dbvalues = true;
			_recordstatus = DataRecordStatus.Existing;
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderDetail]. PrimaryKey. NotReadonly. NotNull.
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
		/// Database Column NotUpdateable. Table [Sales].[SalesOrderDetail]. PrimaryKey. NotReadonly. NotNull. IsIdentity. AutoIncrement.
		/// </summary>
		public int SalesOrderDetailID
		{
			get { return _cur__SalesOrderDetailID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__SalesOrderDetailID = true;
				if (_cur__SalesOrderDetailID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__SalesOrderDetailID == false) { _ori__SalesOrderDetailID = _cur__SalesOrderDetailID; _mod__SalesOrderDetailID = true; } // existing record and column is not modified
					else { if (value == _ori__SalesOrderDetailID) { _ori__SalesOrderDetailID = default(int); _mod__SalesOrderDetailID = false; } } // existing record and column is modified
				}
				_cur__SalesOrderDetailID = value; OnPropertyChanged("SalesOrderDetailID"); OnAfterPropertyChanged("SalesOrderDetailID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderDetail]. NotReadonly. AllowNull.
		/// </summary>
		public string CarrierTrackingNumber
		{
			get { return _cur__CarrierTrackingNumber; }
			set
			{
				if (_started_with_dbvalues == false) _mod__CarrierTrackingNumber = true;
				if (_cur__CarrierTrackingNumber == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__CarrierTrackingNumber == false) { _ori__CarrierTrackingNumber = _cur__CarrierTrackingNumber; _mod__CarrierTrackingNumber = true; } // existing record and column is not modified
					else { if (value == _ori__CarrierTrackingNumber) { _ori__CarrierTrackingNumber = default(string); _mod__CarrierTrackingNumber = false; } } // existing record and column is modified
				}
				_cur__CarrierTrackingNumber = value; OnPropertyChanged("CarrierTrackingNumber"); OnAfterPropertyChanged("CarrierTrackingNumber");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderDetail]. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [Sales].[SalesOrderDetail]. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [Sales].[SalesOrderDetail]. NotReadonly. NotNull.
		/// </summary>
		public int SpecialOfferID
		{
			get { return _cur__SpecialOfferID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__SpecialOfferID = true;
				if (_cur__SpecialOfferID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__SpecialOfferID == false) { _ori__SpecialOfferID = _cur__SpecialOfferID; _mod__SpecialOfferID = true; } // existing record and column is not modified
					else { if (value == _ori__SpecialOfferID) { _ori__SpecialOfferID = default(int); _mod__SpecialOfferID = false; } } // existing record and column is modified
				}
				_cur__SpecialOfferID = value; OnPropertyChanged("SpecialOfferID"); OnAfterPropertyChanged("SpecialOfferID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderDetail]. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [Sales].[SalesOrderDetail]. NotReadonly. NotNull.
		/// </summary>
		public decimal UnitPriceDiscount
		{
			get { return _cur__UnitPriceDiscount; }
			set
			{
				if (_started_with_dbvalues == false) _mod__UnitPriceDiscount = true;
				if (_cur__UnitPriceDiscount == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__UnitPriceDiscount == false) { _ori__UnitPriceDiscount = _cur__UnitPriceDiscount; _mod__UnitPriceDiscount = true; } // existing record and column is not modified
					else { if (value == _ori__UnitPriceDiscount) { _ori__UnitPriceDiscount = default(decimal); _mod__UnitPriceDiscount = false; } } // existing record and column is modified
				}
				_cur__UnitPriceDiscount = value; OnPropertyChanged("UnitPriceDiscount"); OnAfterPropertyChanged("UnitPriceDiscount");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderDetail]. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [Sales].[SalesOrderDetail]. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [Sales].[SalesOrderDetail]. NotReadonly. NotNull.
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
			if (column_name == "SalesOrderDetailID") return _mod__SalesOrderDetailID;
			if (column_name == "CarrierTrackingNumber") return _mod__CarrierTrackingNumber;
			if (column_name == "OrderQty") return _mod__OrderQty;
			if (column_name == "ProductID") return _mod__ProductID;
			if (column_name == "SpecialOfferID") return _mod__SpecialOfferID;
			if (column_name == "UnitPrice") return _mod__UnitPrice;
			if (column_name == "UnitPriceDiscount") return _mod__UnitPriceDiscount;
			if (column_name == "LineTotal") return _mod__LineTotal;
			if (column_name == "rowguid") return _mod__rowguid;
			if (column_name == "ModifiedDate") return _mod__ModifiedDate;
			throw new ArgumentOutOfRangeException(String.Format(VenturaSqlStrings.UNKNOWN_COLUMN_NAME, column_name));
		}

		public int ModifiedColumnCount()
		{
			int count = 0;
			if (_mod__SalesOrderID == true) count++;
			if (_mod__SalesOrderDetailID == true) count++;
			if (_mod__CarrierTrackingNumber == true) count++;
			if (_mod__OrderQty == true) count++;
			if (_mod__ProductID == true) count++;
			if (_mod__SpecialOfferID == true) count++;
			if (_mod__UnitPrice == true) count++;
			if (_mod__UnitPriceDiscount == true) count++;
			if (_mod__LineTotal == true) count++;
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
				if (_mod__SalesOrderID) count++;
			}
			if (_mod__CarrierTrackingNumber == true) count++;
			if (_mod__OrderQty == true) count++;
			if (_mod__ProductID == true) count++;
			if (_mod__SpecialOfferID == true) count++;
			if (_mod__UnitPrice == true) count++;
			if (_mod__UnitPriceDiscount == true) count++;
			if (_mod__LineTotal == true) count++;
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
			if (_mod__SalesOrderID == false) throw new Exception(string.Format(VenturaSqlStrings.VALUE_NOT_SET_MSG, record_index_to_display, "SalesOrderID"));
		}

		void IRecordBase.WriteChangesToTrackArray(TrackArray track_array)
		{
			if (_recordstatus == DataRecordStatus.New)
			{
				track_array.AppendDataValue(0, _cur__SalesOrderID);
				if (_cur__CarrierTrackingNumber != null) track_array.AppendDataValue(2, _cur__CarrierTrackingNumber);
				track_array.AppendDataValue(3, _cur__OrderQty);
				track_array.AppendDataValue(4, _cur__ProductID);
				track_array.AppendDataValue(5, _cur__SpecialOfferID);
				track_array.AppendDataValue(6, _cur__UnitPrice);
				track_array.AppendDataValue(7, _cur__UnitPriceDiscount);
				track_array.AppendDataValue(8, _cur__LineTotal);
				track_array.AppendDataValue(9, _cur__rowguid);
				track_array.AppendDataValue(10, _cur__ModifiedDate);
			}
			else if (_recordstatus == DataRecordStatus.Existing)
			{
				if (_started_with_dbvalues)
				{
					if (_mod__SalesOrderID) track_array.AppendDataValue(0, _cur__SalesOrderID);
				}
				if (_mod__CarrierTrackingNumber) track_array.AppendDataValue(2, _cur__CarrierTrackingNumber);
				if (_mod__OrderQty) track_array.AppendDataValue(3, _cur__OrderQty);
				if (_mod__ProductID) track_array.AppendDataValue(4, _cur__ProductID);
				if (_mod__SpecialOfferID) track_array.AppendDataValue(5, _cur__SpecialOfferID);
				if (_mod__UnitPrice) track_array.AppendDataValue(6, _cur__UnitPrice);
				if (_mod__UnitPriceDiscount) track_array.AppendDataValue(7, _cur__UnitPriceDiscount);
				if (_mod__LineTotal) track_array.AppendDataValue(8, _cur__LineTotal);
				if (_mod__rowguid) track_array.AppendDataValue(9, _cur__rowguid);
				if (_mod__ModifiedDate) track_array.AppendDataValue(10, _cur__ModifiedDate);
				if (track_array.HasData == false) return;
			}

			if (_recordstatus == DataRecordStatus.Existing || _recordstatus == DataRecordStatus.ExistingDelete)
			{
				track_array.AppendPrikeyValue(0, (_mod__SalesOrderID && _started_with_dbvalues) ? _ori__SalesOrderID : _cur__SalesOrderID);
				track_array.AppendPrikeyValue(1, (_mod__SalesOrderDetailID && _started_with_dbvalues) ? _ori__SalesOrderDetailID : _cur__SalesOrderDetailID);
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
				if (_mod__SalesOrderDetailID) _ori__SalesOrderDetailID = default(int);
				if (_mod__CarrierTrackingNumber) _ori__CarrierTrackingNumber = default(string);
				if (_mod__OrderQty) _ori__OrderQty = default(short);
				if (_mod__ProductID) _ori__ProductID = default(int);
				if (_mod__SpecialOfferID) _ori__SpecialOfferID = default(int);
				if (_mod__UnitPrice) _ori__UnitPrice = default(decimal);
				if (_mod__UnitPriceDiscount) _ori__UnitPriceDiscount = default(decimal);
				if (_mod__LineTotal) _ori__LineTotal = default(decimal);
				if (_mod__rowguid) _ori__rowguid = default(Guid);
				if (_mod__ModifiedDate) _ori__ModifiedDate = default(DateTime);
			}
			_mod__SalesOrderID = false;
			_mod__SalesOrderDetailID = false;
			_mod__CarrierTrackingNumber = false;
			_mod__OrderQty = false;
			_mod__ProductID = false;
			_mod__SpecialOfferID = false;
			_mod__UnitPrice = false;
			_mod__UnitPriceDiscount = false;
			_mod__LineTotal = false;
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
			_cur__SalesOrderDetailID = (int)value;
			OnPropertyChanged("SalesOrderDetailID");
			OnAfterPropertyChanged("SalesOrderDetailID");
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
	public partial class PriKey_Sales_SalesOrderDetail_Record
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
