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
	/// The updateable table is [Purchasing].[ProductVendor]. Updateable table column information:
	/// • 11 out of 11 table columns are present in the resultset.
	/// • All primary key columns are present in the resultset: ProductID and BusinessEntityID.
	/// • Non-primary key columns present in the resultset: AverageLeadTime, StandardPrice, LastReceiptCost, LastReceiptDate,
	///   MinOrderQty, MaxOrderQty, OnOrderQty, UnitMeasureCode and ModifiedDate.
	/// Recordset item automatically created by VenturaSQL Studio.
	/// </summary>
	public partial class GetAll_Purchasing_ProductVendor_Recordset : ResultsetObservable<GetAll_Purchasing_ProductVendor_Recordset, GetAll_Purchasing_ProductVendor_Record>, IRecordsetBase
	{
		private IResultsetBase[] _resultsets;
		private string _sqlscript;
		private int _rowlimit = 500;
		private const string CRLF = "\r\n";

		public GetAll_Purchasing_ProductVendor_Recordset()
		{
			_resultsets = new IResultsetBase[] { this };

			_sqlscript = @"SELECT TOP(@RowLimit) [ProductID],[BusinessEntityID],[AverageLeadTime],[StandardPrice],[LastReceiptCost],[LastReceiptDate],[MinOrderQty],[MaxOrderQty]," + CRLF +
			             @"[OnOrderQty],[UnitMeasureCode],[ModifiedDate]" + CRLF +
			             @"FROM [Purchasing].[ProductVendor]";

			ColumnArrayBuilder schema_array = new ColumnArrayBuilder();

			schema_array.Add(new VenturaSqlColumn("ProductID", typeof(int), false)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				IsKey = true,
				BaseSchemaName = "Purchasing",
				BaseTableName = "ProductVendor",
				BaseColumnName = "ProductID"
			});

			schema_array.Add(new VenturaSqlColumn("BusinessEntityID", typeof(int), false)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				IsKey = true,
				BaseSchemaName = "Purchasing",
				BaseTableName = "ProductVendor",
				BaseColumnName = "BusinessEntityID"
			});

			schema_array.Add(new VenturaSqlColumn("AverageLeadTime", typeof(int), false)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				BaseSchemaName = "Purchasing",
				BaseTableName = "ProductVendor",
				BaseColumnName = "AverageLeadTime"
			});

			schema_array.Add(new VenturaSqlColumn("StandardPrice", typeof(decimal), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 19,
				ProviderType = 9,
				BaseSchemaName = "Purchasing",
				BaseTableName = "ProductVendor",
				BaseColumnName = "StandardPrice"
			});

			schema_array.Add(new VenturaSqlColumn("LastReceiptCost", typeof(decimal), true)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 19,
				ProviderType = 9,
				BaseSchemaName = "Purchasing",
				BaseTableName = "ProductVendor",
				BaseColumnName = "LastReceiptCost"
			});

			schema_array.Add(new VenturaSqlColumn("LastReceiptDate", typeof(DateTime), true)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 23,
				NumericScale = 3,
				ProviderType = 4,
				BaseSchemaName = "Purchasing",
				BaseTableName = "ProductVendor",
				BaseColumnName = "LastReceiptDate"
			});

			schema_array.Add(new VenturaSqlColumn("MinOrderQty", typeof(int), false)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				BaseSchemaName = "Purchasing",
				BaseTableName = "ProductVendor",
				BaseColumnName = "MinOrderQty"
			});

			schema_array.Add(new VenturaSqlColumn("MaxOrderQty", typeof(int), false)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				BaseSchemaName = "Purchasing",
				BaseTableName = "ProductVendor",
				BaseColumnName = "MaxOrderQty"
			});

			schema_array.Add(new VenturaSqlColumn("OnOrderQty", typeof(int), true)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				BaseSchemaName = "Purchasing",
				BaseTableName = "ProductVendor",
				BaseColumnName = "OnOrderQty"
			});

			schema_array.Add(new VenturaSqlColumn("UnitMeasureCode", typeof(string), false)
			{
				Updateable = true,
				ColumnSize = 3,
				ProviderType = 10,
				BaseSchemaName = "Purchasing",
				BaseTableName = "ProductVendor",
				BaseColumnName = "UnitMeasureCode"
			});

			schema_array.Add(new VenturaSqlColumn("ModifiedDate", typeof(DateTime), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 23,
				NumericScale = 3,
				ProviderType = 4,
				BaseSchemaName = "Purchasing",
				BaseTableName = "ProductVendor",
				BaseColumnName = "ModifiedDate"
			});

			((IResultsetBase)this).Schema = new VenturaSqlSchema(schema_array);
			((IResultsetBase)this).UpdateableTablename = "[Purchasing].[ProductVendor]";
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[ProductVendor]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public int ProductID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ProductID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ProductID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[ProductVendor]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public int BusinessEntityID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.BusinessEntityID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.BusinessEntityID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[ProductVendor]. NotReadonly. NotNull.
		/// </summary>
		public int AverageLeadTime
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.AverageLeadTime; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.AverageLeadTime = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[ProductVendor]. NotReadonly. NotNull.
		/// </summary>
		public decimal StandardPrice
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.StandardPrice; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.StandardPrice = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[ProductVendor]. NotReadonly. AllowNull.
		/// </summary>
		public decimal? LastReceiptCost
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.LastReceiptCost; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.LastReceiptCost = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[ProductVendor]. NotReadonly. AllowNull.
		/// </summary>
		public DateTime? LastReceiptDate
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.LastReceiptDate; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.LastReceiptDate = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[ProductVendor]. NotReadonly. NotNull.
		/// </summary>
		public int MinOrderQty
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.MinOrderQty; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.MinOrderQty = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[ProductVendor]. NotReadonly. NotNull.
		/// </summary>
		public int MaxOrderQty
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.MaxOrderQty; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.MaxOrderQty = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[ProductVendor]. NotReadonly. AllowNull.
		/// </summary>
		public int? OnOrderQty
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.OnOrderQty; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.OnOrderQty = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[ProductVendor]. NotReadonly. NotNull.
		/// </summary>
		public string UnitMeasureCode
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.UnitMeasureCode; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.UnitMeasureCode = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[ProductVendor]. NotReadonly. NotNull.
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
			this.InsertItem(index, new GetAll_Purchasing_ProductVendor_Record());
			this.CurrentRecordIndex = index;
		}

		public void Append(GetAll_Purchasing_ProductVendor_Record record)
		{
			int index = this.RecordCount;
			this.InsertItem(index, record);
			this.CurrentRecordIndex = index;
		}

		public GetAll_Purchasing_ProductVendor_Record NewRecord()
		{
			return new GetAll_Purchasing_ProductVendor_Record();
		}

		protected override GetAll_Purchasing_ProductVendor_Record InternalCreateExistingRecordObject(object[] columnvalues) => new GetAll_Purchasing_ProductVendor_Record(columnvalues);

		byte[] IRecordsetBase.Hash
		{
			get { return new byte[] { 243, 162, 214, 207, 27, 126, 29, 128, 107, 79, 225, 49, 3, 121, 252, 105 }; }
		}

		string IRecordsetBase.HashString
		{
			get { return "F3A2D6CF1B7E1D806B4FE1310379FC69"; }
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

	public sealed partial class GetAll_Purchasing_ProductVendor_Record : IRecordBase, INotifyPropertyChanged
	{
		private DataRecordStatus _recordstatus;
		private bool _started_with_dbvalues;

		private int _cur__ProductID; private int _ori__ProductID; private bool _mod__ProductID;
		private int _cur__BusinessEntityID; private int _ori__BusinessEntityID; private bool _mod__BusinessEntityID;
		private int _cur__AverageLeadTime; private int _ori__AverageLeadTime; private bool _mod__AverageLeadTime;
		private decimal _cur__StandardPrice; private decimal _ori__StandardPrice; private bool _mod__StandardPrice;
		private decimal? _cur__LastReceiptCost; private decimal? _ori__LastReceiptCost; private bool _mod__LastReceiptCost;
		private DateTime? _cur__LastReceiptDate; private DateTime? _ori__LastReceiptDate; private bool _mod__LastReceiptDate;
		private int _cur__MinOrderQty; private int _ori__MinOrderQty; private bool _mod__MinOrderQty;
		private int _cur__MaxOrderQty; private int _ori__MaxOrderQty; private bool _mod__MaxOrderQty;
		private int? _cur__OnOrderQty; private int? _ori__OnOrderQty; private bool _mod__OnOrderQty;
		private string _cur__UnitMeasureCode; private string _ori__UnitMeasureCode; private bool _mod__UnitMeasureCode;
		private DateTime _cur__ModifiedDate; private DateTime _ori__ModifiedDate; private bool _mod__ModifiedDate;


		public GetAll_Purchasing_ProductVendor_Record()
		{
			_cur__ProductID = 0;
			_cur__BusinessEntityID = 0;
			_cur__AverageLeadTime = 0;
			_cur__StandardPrice = 0.0m;
			_cur__LastReceiptCost = null;
			_cur__LastReceiptDate = null;
			_cur__MinOrderQty = 0;
			_cur__MaxOrderQty = 0;
			_cur__OnOrderQty = null;
			_cur__UnitMeasureCode = "";
			_cur__ModifiedDate = new DateTime(1900, 1, 1);
			_started_with_dbvalues = false;
			_recordstatus = DataRecordStatus.New;
		}

		public GetAll_Purchasing_ProductVendor_Record(object[] columnvalues)
		{
			_cur__ProductID = (int)columnvalues[0];
			_cur__BusinessEntityID = (int)columnvalues[1];
			_cur__AverageLeadTime = (int)columnvalues[2];
			_cur__StandardPrice = (decimal)columnvalues[3];
			_cur__LastReceiptCost = (decimal?)columnvalues[4];
			_cur__LastReceiptDate = (DateTime?)columnvalues[5];
			_cur__MinOrderQty = (int)columnvalues[6];
			_cur__MaxOrderQty = (int)columnvalues[7];
			_cur__OnOrderQty = (int?)columnvalues[8];
			_cur__UnitMeasureCode = (string)columnvalues[9];
			_cur__ModifiedDate = (DateTime)columnvalues[10];
			_started_with_dbvalues = true;
			_recordstatus = DataRecordStatus.Existing;
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[ProductVendor]. PrimaryKey. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [Purchasing].[ProductVendor]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public int BusinessEntityID
		{
			get { return _cur__BusinessEntityID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__BusinessEntityID = true;
				if (_cur__BusinessEntityID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__BusinessEntityID == false) { _ori__BusinessEntityID = _cur__BusinessEntityID; _mod__BusinessEntityID = true; } // existing record and column is not modified
					else { if (value == _ori__BusinessEntityID) { _ori__BusinessEntityID = default(int); _mod__BusinessEntityID = false; } } // existing record and column is modified
				}
				_cur__BusinessEntityID = value; OnPropertyChanged("BusinessEntityID"); OnAfterPropertyChanged("BusinessEntityID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[ProductVendor]. NotReadonly. NotNull.
		/// </summary>
		public int AverageLeadTime
		{
			get { return _cur__AverageLeadTime; }
			set
			{
				if (_started_with_dbvalues == false) _mod__AverageLeadTime = true;
				if (_cur__AverageLeadTime == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__AverageLeadTime == false) { _ori__AverageLeadTime = _cur__AverageLeadTime; _mod__AverageLeadTime = true; } // existing record and column is not modified
					else { if (value == _ori__AverageLeadTime) { _ori__AverageLeadTime = default(int); _mod__AverageLeadTime = false; } } // existing record and column is modified
				}
				_cur__AverageLeadTime = value; OnPropertyChanged("AverageLeadTime"); OnAfterPropertyChanged("AverageLeadTime");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[ProductVendor]. NotReadonly. NotNull.
		/// </summary>
		public decimal StandardPrice
		{
			get { return _cur__StandardPrice; }
			set
			{
				if (_started_with_dbvalues == false) _mod__StandardPrice = true;
				if (_cur__StandardPrice == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__StandardPrice == false) { _ori__StandardPrice = _cur__StandardPrice; _mod__StandardPrice = true; } // existing record and column is not modified
					else { if (value == _ori__StandardPrice) { _ori__StandardPrice = default(decimal); _mod__StandardPrice = false; } } // existing record and column is modified
				}
				_cur__StandardPrice = value; OnPropertyChanged("StandardPrice"); OnAfterPropertyChanged("StandardPrice");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[ProductVendor]. NotReadonly. AllowNull.
		/// </summary>
		public decimal? LastReceiptCost
		{
			get { return _cur__LastReceiptCost; }
			set
			{
				if (_started_with_dbvalues == false) _mod__LastReceiptCost = true;
				if (_cur__LastReceiptCost == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__LastReceiptCost == false) { _ori__LastReceiptCost = _cur__LastReceiptCost; _mod__LastReceiptCost = true; } // existing record and column is not modified
					else { if (value == _ori__LastReceiptCost) { _ori__LastReceiptCost = default(decimal?); _mod__LastReceiptCost = false; } } // existing record and column is modified
				}
				_cur__LastReceiptCost = value; OnPropertyChanged("LastReceiptCost"); OnAfterPropertyChanged("LastReceiptCost");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[ProductVendor]. NotReadonly. AllowNull.
		/// </summary>
		public DateTime? LastReceiptDate
		{
			get { return _cur__LastReceiptDate; }
			set
			{
				if (_started_with_dbvalues == false) _mod__LastReceiptDate = true;
				if (_cur__LastReceiptDate == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__LastReceiptDate == false) { _ori__LastReceiptDate = _cur__LastReceiptDate; _mod__LastReceiptDate = true; } // existing record and column is not modified
					else { if (value == _ori__LastReceiptDate) { _ori__LastReceiptDate = default(DateTime?); _mod__LastReceiptDate = false; } } // existing record and column is modified
				}
				_cur__LastReceiptDate = value; OnPropertyChanged("LastReceiptDate"); OnAfterPropertyChanged("LastReceiptDate");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[ProductVendor]. NotReadonly. NotNull.
		/// </summary>
		public int MinOrderQty
		{
			get { return _cur__MinOrderQty; }
			set
			{
				if (_started_with_dbvalues == false) _mod__MinOrderQty = true;
				if (_cur__MinOrderQty == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__MinOrderQty == false) { _ori__MinOrderQty = _cur__MinOrderQty; _mod__MinOrderQty = true; } // existing record and column is not modified
					else { if (value == _ori__MinOrderQty) { _ori__MinOrderQty = default(int); _mod__MinOrderQty = false; } } // existing record and column is modified
				}
				_cur__MinOrderQty = value; OnPropertyChanged("MinOrderQty"); OnAfterPropertyChanged("MinOrderQty");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[ProductVendor]. NotReadonly. NotNull.
		/// </summary>
		public int MaxOrderQty
		{
			get { return _cur__MaxOrderQty; }
			set
			{
				if (_started_with_dbvalues == false) _mod__MaxOrderQty = true;
				if (_cur__MaxOrderQty == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__MaxOrderQty == false) { _ori__MaxOrderQty = _cur__MaxOrderQty; _mod__MaxOrderQty = true; } // existing record and column is not modified
					else { if (value == _ori__MaxOrderQty) { _ori__MaxOrderQty = default(int); _mod__MaxOrderQty = false; } } // existing record and column is modified
				}
				_cur__MaxOrderQty = value; OnPropertyChanged("MaxOrderQty"); OnAfterPropertyChanged("MaxOrderQty");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[ProductVendor]. NotReadonly. AllowNull.
		/// </summary>
		public int? OnOrderQty
		{
			get { return _cur__OnOrderQty; }
			set
			{
				if (_started_with_dbvalues == false) _mod__OnOrderQty = true;
				if (_cur__OnOrderQty == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__OnOrderQty == false) { _ori__OnOrderQty = _cur__OnOrderQty; _mod__OnOrderQty = true; } // existing record and column is not modified
					else { if (value == _ori__OnOrderQty) { _ori__OnOrderQty = default(int?); _mod__OnOrderQty = false; } } // existing record and column is modified
				}
				_cur__OnOrderQty = value; OnPropertyChanged("OnOrderQty"); OnAfterPropertyChanged("OnOrderQty");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[ProductVendor]. NotReadonly. NotNull.
		/// </summary>
		public string UnitMeasureCode
		{
			get { return _cur__UnitMeasureCode; }
			set
			{
				if (value == null) throw new ArgumentNullException("UnitMeasureCode", VenturaSqlStrings.SET_NULL_MSG);
				if (_started_with_dbvalues == false) _mod__UnitMeasureCode = true;
				if (_cur__UnitMeasureCode == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__UnitMeasureCode == false) { _ori__UnitMeasureCode = _cur__UnitMeasureCode; _mod__UnitMeasureCode = true; } // existing record and column is not modified
					else { if (value == _ori__UnitMeasureCode) { _ori__UnitMeasureCode = default(string); _mod__UnitMeasureCode = false; } } // existing record and column is modified
				}
				_cur__UnitMeasureCode = value; OnPropertyChanged("UnitMeasureCode"); OnAfterPropertyChanged("UnitMeasureCode");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[ProductVendor]. NotReadonly. NotNull.
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
			if (column_name == "BusinessEntityID") return _mod__BusinessEntityID;
			if (column_name == "AverageLeadTime") return _mod__AverageLeadTime;
			if (column_name == "StandardPrice") return _mod__StandardPrice;
			if (column_name == "LastReceiptCost") return _mod__LastReceiptCost;
			if (column_name == "LastReceiptDate") return _mod__LastReceiptDate;
			if (column_name == "MinOrderQty") return _mod__MinOrderQty;
			if (column_name == "MaxOrderQty") return _mod__MaxOrderQty;
			if (column_name == "OnOrderQty") return _mod__OnOrderQty;
			if (column_name == "UnitMeasureCode") return _mod__UnitMeasureCode;
			if (column_name == "ModifiedDate") return _mod__ModifiedDate;
			throw new ArgumentOutOfRangeException(String.Format(VenturaSqlStrings.UNKNOWN_COLUMN_NAME, column_name));
		}

		public int ModifiedColumnCount()
		{
			int count = 0;
			if (_mod__ProductID == true) count++;
			if (_mod__BusinessEntityID == true) count++;
			if (_mod__AverageLeadTime == true) count++;
			if (_mod__StandardPrice == true) count++;
			if (_mod__LastReceiptCost == true) count++;
			if (_mod__LastReceiptDate == true) count++;
			if (_mod__MinOrderQty == true) count++;
			if (_mod__MaxOrderQty == true) count++;
			if (_mod__OnOrderQty == true) count++;
			if (_mod__UnitMeasureCode == true) count++;
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
				if (_mod__BusinessEntityID) count++;
			}
			if (_mod__AverageLeadTime == true) count++;
			if (_mod__StandardPrice == true) count++;
			if (_mod__LastReceiptCost == true) count++;
			if (_mod__LastReceiptDate == true) count++;
			if (_mod__MinOrderQty == true) count++;
			if (_mod__MaxOrderQty == true) count++;
			if (_mod__OnOrderQty == true) count++;
			if (_mod__UnitMeasureCode == true) count++;
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
			if (_mod__BusinessEntityID == false) throw new Exception(string.Format(VenturaSqlStrings.VALUE_NOT_SET_MSG, record_index_to_display, "BusinessEntityID"));
		}

		void IRecordBase.WriteChangesToTrackArray(TrackArray track_array)
		{
			if (_recordstatus == DataRecordStatus.New)
			{
				track_array.AppendDataValue(0, _cur__ProductID);
				track_array.AppendDataValue(1, _cur__BusinessEntityID);
				track_array.AppendDataValue(2, _cur__AverageLeadTime);
				track_array.AppendDataValue(3, _cur__StandardPrice);
				if (_cur__LastReceiptCost != null) track_array.AppendDataValue(4, _cur__LastReceiptCost);
				if (_cur__LastReceiptDate != null) track_array.AppendDataValue(5, _cur__LastReceiptDate);
				track_array.AppendDataValue(6, _cur__MinOrderQty);
				track_array.AppendDataValue(7, _cur__MaxOrderQty);
				if (_cur__OnOrderQty != null) track_array.AppendDataValue(8, _cur__OnOrderQty);
				track_array.AppendDataValue(9, _cur__UnitMeasureCode);
				track_array.AppendDataValue(10, _cur__ModifiedDate);
			}
			else if (_recordstatus == DataRecordStatus.Existing)
			{
				if (_started_with_dbvalues)
				{
					if (_mod__ProductID) track_array.AppendDataValue(0, _cur__ProductID);
					if (_mod__BusinessEntityID) track_array.AppendDataValue(1, _cur__BusinessEntityID);
				}
				if (_mod__AverageLeadTime) track_array.AppendDataValue(2, _cur__AverageLeadTime);
				if (_mod__StandardPrice) track_array.AppendDataValue(3, _cur__StandardPrice);
				if (_mod__LastReceiptCost) track_array.AppendDataValue(4, _cur__LastReceiptCost);
				if (_mod__LastReceiptDate) track_array.AppendDataValue(5, _cur__LastReceiptDate);
				if (_mod__MinOrderQty) track_array.AppendDataValue(6, _cur__MinOrderQty);
				if (_mod__MaxOrderQty) track_array.AppendDataValue(7, _cur__MaxOrderQty);
				if (_mod__OnOrderQty) track_array.AppendDataValue(8, _cur__OnOrderQty);
				if (_mod__UnitMeasureCode) track_array.AppendDataValue(9, _cur__UnitMeasureCode);
				if (_mod__ModifiedDate) track_array.AppendDataValue(10, _cur__ModifiedDate);
				if (track_array.HasData == false) return;
			}

			if (_recordstatus == DataRecordStatus.Existing || _recordstatus == DataRecordStatus.ExistingDelete)
			{
				track_array.AppendPrikeyValue(0, (_mod__ProductID && _started_with_dbvalues) ? _ori__ProductID : _cur__ProductID);
				track_array.AppendPrikeyValue(1, (_mod__BusinessEntityID && _started_with_dbvalues) ? _ori__BusinessEntityID : _cur__BusinessEntityID);
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
				if (_mod__BusinessEntityID) _ori__BusinessEntityID = default(int);
				if (_mod__AverageLeadTime) _ori__AverageLeadTime = default(int);
				if (_mod__StandardPrice) _ori__StandardPrice = default(decimal);
				if (_mod__LastReceiptCost) _ori__LastReceiptCost = default(decimal?);
				if (_mod__LastReceiptDate) _ori__LastReceiptDate = default(DateTime?);
				if (_mod__MinOrderQty) _ori__MinOrderQty = default(int);
				if (_mod__MaxOrderQty) _ori__MaxOrderQty = default(int);
				if (_mod__OnOrderQty) _ori__OnOrderQty = default(int?);
				if (_mod__UnitMeasureCode) _ori__UnitMeasureCode = default(string);
				if (_mod__ModifiedDate) _ori__ModifiedDate = default(DateTime);
			}
			_mod__ProductID = false;
			_mod__BusinessEntityID = false;
			_mod__AverageLeadTime = false;
			_mod__StandardPrice = false;
			_mod__LastReceiptCost = false;
			_mod__LastReceiptDate = false;
			_mod__MinOrderQty = false;
			_mod__MaxOrderQty = false;
			_mod__OnOrderQty = false;
			_mod__UnitMeasureCode = false;
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
	public partial class GetAll_Purchasing_ProductVendor_Record
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
