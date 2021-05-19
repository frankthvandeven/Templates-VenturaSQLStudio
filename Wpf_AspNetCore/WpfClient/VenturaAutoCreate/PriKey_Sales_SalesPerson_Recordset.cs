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

namespace WpfClient.VenturaAutoCreate
{
	/// <summary>
	/// The updateable table is [Sales].[SalesPerson]. Updateable table column information:
	/// • 9 out of 9 table columns are present in the resultset.
	/// • All primary key columns are present in the resultset: BusinessEntityID.
	/// • Non-primary key columns present in the resultset: TerritoryID, SalesQuota, Bonus, CommissionPct, SalesYTD, SalesLastYear,
	///   rowguid and ModifiedDate.
	/// Recordset item automatically created by VenturaSQL Studio.
	/// </summary>
	public partial class PriKey_Sales_SalesPerson_Recordset : ResultsetObservable<PriKey_Sales_SalesPerson_Recordset, PriKey_Sales_SalesPerson_Record>, IRecordsetBase
	{
		private IResultsetBase[] _resultsets;
		private string _sqlscript;
		private object[] _inputparametervalues;
		private InputParamHolder _inputparamholder;
		private VenturaSqlSchema _parameterschema;
		private int _rowlimit = 500;
		private const string CRLF = "\r\n";

		public PriKey_Sales_SalesPerson_Recordset()
		{
			_resultsets = new IResultsetBase[] { this };

			_sqlscript = @"SELECT [BusinessEntityID],[TerritoryID],[SalesQuota],[Bonus],[CommissionPct],[SalesYTD],[SalesLastYear],[rowguid],[ModifiedDate]" + CRLF +
			             @"FROM [Sales].[SalesPerson]" + CRLF +
			             @"WHERE [BusinessEntityID] = @BusinessEntityID";

			_inputparametervalues = new object[1];
			_inputparamholder = new InputParamHolder(_inputparametervalues);

			ColumnArrayBuilder param_array = new ColumnArrayBuilder();

			param_array.AddParameterColumn("@BusinessEntityID", typeof(int), true, false, DbType.Int32, null, null, null);

			_parameterschema = new VenturaSqlSchema(param_array);

			ColumnArrayBuilder schema_array = new ColumnArrayBuilder();

			schema_array.Add(new VenturaSqlColumn("BusinessEntityID", typeof(int), false)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				IsKey = true,
				BaseSchemaName = "Sales",
				BaseTableName = "SalesPerson",
				BaseColumnName = "BusinessEntityID"
			});

			schema_array.Add(new VenturaSqlColumn("TerritoryID", typeof(int), true)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				BaseSchemaName = "Sales",
				BaseTableName = "SalesPerson",
				BaseColumnName = "TerritoryID"
			});

			schema_array.Add(new VenturaSqlColumn("SalesQuota", typeof(decimal), true)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 19,
				ProviderType = 9,
				BaseSchemaName = "Sales",
				BaseTableName = "SalesPerson",
				BaseColumnName = "SalesQuota"
			});

			schema_array.Add(new VenturaSqlColumn("Bonus", typeof(decimal), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 19,
				ProviderType = 9,
				BaseSchemaName = "Sales",
				BaseTableName = "SalesPerson",
				BaseColumnName = "Bonus"
			});

			schema_array.Add(new VenturaSqlColumn("CommissionPct", typeof(decimal), false)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 17,
				BaseSchemaName = "Sales",
				BaseTableName = "SalesPerson",
				BaseColumnName = "CommissionPct"
			});

			schema_array.Add(new VenturaSqlColumn("SalesYTD", typeof(decimal), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 19,
				ProviderType = 9,
				BaseSchemaName = "Sales",
				BaseTableName = "SalesPerson",
				BaseColumnName = "SalesYTD"
			});

			schema_array.Add(new VenturaSqlColumn("SalesLastYear", typeof(decimal), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 19,
				ProviderType = 9,
				BaseSchemaName = "Sales",
				BaseTableName = "SalesPerson",
				BaseColumnName = "SalesLastYear"
			});

			schema_array.Add(new VenturaSqlColumn("rowguid", typeof(Guid), false)
			{
				Updateable = true,
				ColumnSize = 16,
				ProviderType = 14,
				BaseSchemaName = "Sales",
				BaseTableName = "SalesPerson",
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
				BaseTableName = "SalesPerson",
				BaseColumnName = "ModifiedDate"
			});

			((IResultsetBase)this).Schema = new VenturaSqlSchema(schema_array);
			((IResultsetBase)this).UpdateableTablename = "[Sales].[SalesPerson]";
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesPerson]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public int BusinessEntityID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.BusinessEntityID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.BusinessEntityID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesPerson]. NotReadonly. AllowNull.
		/// </summary>
		public int? TerritoryID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.TerritoryID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.TerritoryID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesPerson]. NotReadonly. AllowNull.
		/// </summary>
		public decimal? SalesQuota
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.SalesQuota; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.SalesQuota = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesPerson]. NotReadonly. NotNull.
		/// </summary>
		public decimal Bonus
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Bonus; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Bonus = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesPerson]. NotReadonly. NotNull.
		/// </summary>
		public decimal CommissionPct
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.CommissionPct; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.CommissionPct = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesPerson]. NotReadonly. NotNull.
		/// </summary>
		public decimal SalesYTD
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.SalesYTD; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.SalesYTD = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesPerson]. NotReadonly. NotNull.
		/// </summary>
		public decimal SalesLastYear
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.SalesLastYear; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.SalesLastYear = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesPerson]. NotReadonly. NotNull.
		/// </summary>
		public Guid rowguid
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.rowguid; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.rowguid = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesPerson]. NotReadonly. NotNull.
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
			this.InsertItem(index, new PriKey_Sales_SalesPerson_Record());
			this.CurrentRecordIndex = index;
		}

		public void Append(PriKey_Sales_SalesPerson_Record record)
		{
			int index = this.RecordCount;
			this.InsertItem(index, record);
			this.CurrentRecordIndex = index;
		}

		public PriKey_Sales_SalesPerson_Record NewRecord()
		{
			return new PriKey_Sales_SalesPerson_Record();
		}

		protected override PriKey_Sales_SalesPerson_Record InternalCreateExistingRecordObject(object[] columnvalues) => new PriKey_Sales_SalesPerson_Record(columnvalues);

		byte[] IRecordsetBase.Hash
		{
			get { return new byte[] { 185, 142, 35, 6, 164, 120, 36, 98, 133, 122, 207, 1, 15, 124, 99, 61 }; }
		}

		string IRecordsetBase.HashString
		{
			get { return "B98E2306A4782462857ACF010F7C633D"; }
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

		public void SetExecSqlParams(int? BusinessEntityID)
		{
			_inputparametervalues[0] = BusinessEntityID;
		}

		public void ExecSql(int? BusinessEntityID)
		{
			_inputparametervalues[0] = BusinessEntityID;
			Transactional.ExecSql(VenturaSqlConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public void ExecSql(Connector connector, int? BusinessEntityID)
		{
			_inputparametervalues[0] = BusinessEntityID;
			Transactional.ExecSql(connector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync(int? BusinessEntityID)
		{
			_inputparametervalues[0] = BusinessEntityID;
			await Transactional.ExecSqlAsync(VenturaSqlConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync(Connector connector, int? BusinessEntityID)
		{
			_inputparametervalues[0] = BusinessEntityID;
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

			public int? BusinessEntityID
			{
				get { return (int?)_values[0]; }
				set { _values[0] = value; }
			}

		}

	}

	public sealed partial class PriKey_Sales_SalesPerson_Record : IRecordBase, INotifyPropertyChanged
	{
		private DataRecordStatus _recordstatus;
		private bool _started_with_dbvalues;

		private int _cur__BusinessEntityID; private int _ori__BusinessEntityID; private bool _mod__BusinessEntityID;
		private int? _cur__TerritoryID; private int? _ori__TerritoryID; private bool _mod__TerritoryID;
		private decimal? _cur__SalesQuota; private decimal? _ori__SalesQuota; private bool _mod__SalesQuota;
		private decimal _cur__Bonus; private decimal _ori__Bonus; private bool _mod__Bonus;
		private decimal _cur__CommissionPct; private decimal _ori__CommissionPct; private bool _mod__CommissionPct;
		private decimal _cur__SalesYTD; private decimal _ori__SalesYTD; private bool _mod__SalesYTD;
		private decimal _cur__SalesLastYear; private decimal _ori__SalesLastYear; private bool _mod__SalesLastYear;
		private Guid _cur__rowguid; private Guid _ori__rowguid; private bool _mod__rowguid;
		private DateTime _cur__ModifiedDate; private DateTime _ori__ModifiedDate; private bool _mod__ModifiedDate;


		public PriKey_Sales_SalesPerson_Record()
		{
			_cur__BusinessEntityID = 0;
			_cur__TerritoryID = null;
			_cur__SalesQuota = null;
			_cur__Bonus = 0.0m;
			_cur__CommissionPct = 0.0m;
			_cur__SalesYTD = 0.0m;
			_cur__SalesLastYear = 0.0m;
			_cur__rowguid = Guid.Empty;
			_cur__ModifiedDate = new DateTime(1900, 1, 1);
			_started_with_dbvalues = false;
			_recordstatus = DataRecordStatus.New;
		}

		public PriKey_Sales_SalesPerson_Record(object[] columnvalues)
		{
			_cur__BusinessEntityID = (int)columnvalues[0];
			_cur__TerritoryID = (int?)columnvalues[1];
			_cur__SalesQuota = (decimal?)columnvalues[2];
			_cur__Bonus = (decimal)columnvalues[3];
			_cur__CommissionPct = (decimal)columnvalues[4];
			_cur__SalesYTD = (decimal)columnvalues[5];
			_cur__SalesLastYear = (decimal)columnvalues[6];
			_cur__rowguid = (Guid)columnvalues[7];
			_cur__ModifiedDate = (DateTime)columnvalues[8];
			_started_with_dbvalues = true;
			_recordstatus = DataRecordStatus.Existing;
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesPerson]. PrimaryKey. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [Sales].[SalesPerson]. NotReadonly. AllowNull.
		/// </summary>
		public int? TerritoryID
		{
			get { return _cur__TerritoryID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__TerritoryID = true;
				if (_cur__TerritoryID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__TerritoryID == false) { _ori__TerritoryID = _cur__TerritoryID; _mod__TerritoryID = true; } // existing record and column is not modified
					else { if (value == _ori__TerritoryID) { _ori__TerritoryID = default(int?); _mod__TerritoryID = false; } } // existing record and column is modified
				}
				_cur__TerritoryID = value; OnPropertyChanged("TerritoryID"); OnAfterPropertyChanged("TerritoryID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesPerson]. NotReadonly. AllowNull.
		/// </summary>
		public decimal? SalesQuota
		{
			get { return _cur__SalesQuota; }
			set
			{
				if (_started_with_dbvalues == false) _mod__SalesQuota = true;
				if (_cur__SalesQuota == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__SalesQuota == false) { _ori__SalesQuota = _cur__SalesQuota; _mod__SalesQuota = true; } // existing record and column is not modified
					else { if (value == _ori__SalesQuota) { _ori__SalesQuota = default(decimal?); _mod__SalesQuota = false; } } // existing record and column is modified
				}
				_cur__SalesQuota = value; OnPropertyChanged("SalesQuota"); OnAfterPropertyChanged("SalesQuota");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesPerson]. NotReadonly. NotNull.
		/// </summary>
		public decimal Bonus
		{
			get { return _cur__Bonus; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Bonus = true;
				if (_cur__Bonus == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Bonus == false) { _ori__Bonus = _cur__Bonus; _mod__Bonus = true; } // existing record and column is not modified
					else { if (value == _ori__Bonus) { _ori__Bonus = default(decimal); _mod__Bonus = false; } } // existing record and column is modified
				}
				_cur__Bonus = value; OnPropertyChanged("Bonus"); OnAfterPropertyChanged("Bonus");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesPerson]. NotReadonly. NotNull.
		/// </summary>
		public decimal CommissionPct
		{
			get { return _cur__CommissionPct; }
			set
			{
				if (_started_with_dbvalues == false) _mod__CommissionPct = true;
				if (_cur__CommissionPct == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__CommissionPct == false) { _ori__CommissionPct = _cur__CommissionPct; _mod__CommissionPct = true; } // existing record and column is not modified
					else { if (value == _ori__CommissionPct) { _ori__CommissionPct = default(decimal); _mod__CommissionPct = false; } } // existing record and column is modified
				}
				_cur__CommissionPct = value; OnPropertyChanged("CommissionPct"); OnAfterPropertyChanged("CommissionPct");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesPerson]. NotReadonly. NotNull.
		/// </summary>
		public decimal SalesYTD
		{
			get { return _cur__SalesYTD; }
			set
			{
				if (_started_with_dbvalues == false) _mod__SalesYTD = true;
				if (_cur__SalesYTD == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__SalesYTD == false) { _ori__SalesYTD = _cur__SalesYTD; _mod__SalesYTD = true; } // existing record and column is not modified
					else { if (value == _ori__SalesYTD) { _ori__SalesYTD = default(decimal); _mod__SalesYTD = false; } } // existing record and column is modified
				}
				_cur__SalesYTD = value; OnPropertyChanged("SalesYTD"); OnAfterPropertyChanged("SalesYTD");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesPerson]. NotReadonly. NotNull.
		/// </summary>
		public decimal SalesLastYear
		{
			get { return _cur__SalesLastYear; }
			set
			{
				if (_started_with_dbvalues == false) _mod__SalesLastYear = true;
				if (_cur__SalesLastYear == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__SalesLastYear == false) { _ori__SalesLastYear = _cur__SalesLastYear; _mod__SalesLastYear = true; } // existing record and column is not modified
					else { if (value == _ori__SalesLastYear) { _ori__SalesLastYear = default(decimal); _mod__SalesLastYear = false; } } // existing record and column is modified
				}
				_cur__SalesLastYear = value; OnPropertyChanged("SalesLastYear"); OnAfterPropertyChanged("SalesLastYear");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesPerson]. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [Sales].[SalesPerson]. NotReadonly. NotNull.
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
			if (column_name == "BusinessEntityID") return _mod__BusinessEntityID;
			if (column_name == "TerritoryID") return _mod__TerritoryID;
			if (column_name == "SalesQuota") return _mod__SalesQuota;
			if (column_name == "Bonus") return _mod__Bonus;
			if (column_name == "CommissionPct") return _mod__CommissionPct;
			if (column_name == "SalesYTD") return _mod__SalesYTD;
			if (column_name == "SalesLastYear") return _mod__SalesLastYear;
			if (column_name == "rowguid") return _mod__rowguid;
			if (column_name == "ModifiedDate") return _mod__ModifiedDate;
			throw new ArgumentOutOfRangeException(String.Format(VenturaSqlStrings.UNKNOWN_COLUMN_NAME, column_name));
		}

		public int ModifiedColumnCount()
		{
			int count = 0;
			if (_mod__BusinessEntityID == true) count++;
			if (_mod__TerritoryID == true) count++;
			if (_mod__SalesQuota == true) count++;
			if (_mod__Bonus == true) count++;
			if (_mod__CommissionPct == true) count++;
			if (_mod__SalesYTD == true) count++;
			if (_mod__SalesLastYear == true) count++;
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
				if (_mod__BusinessEntityID) count++;
			}
			if (_mod__TerritoryID == true) count++;
			if (_mod__SalesQuota == true) count++;
			if (_mod__Bonus == true) count++;
			if (_mod__CommissionPct == true) count++;
			if (_mod__SalesYTD == true) count++;
			if (_mod__SalesLastYear == true) count++;
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
			if (_mod__BusinessEntityID == false) throw new Exception(string.Format(VenturaSqlStrings.VALUE_NOT_SET_MSG, record_index_to_display, "BusinessEntityID"));
		}

		void IRecordBase.WriteChangesToTrackArray(TrackArray track_array)
		{
			if (_recordstatus == DataRecordStatus.New)
			{
				track_array.AppendDataValue(0, _cur__BusinessEntityID);
				if (_cur__TerritoryID != null) track_array.AppendDataValue(1, _cur__TerritoryID);
				if (_cur__SalesQuota != null) track_array.AppendDataValue(2, _cur__SalesQuota);
				track_array.AppendDataValue(3, _cur__Bonus);
				track_array.AppendDataValue(4, _cur__CommissionPct);
				track_array.AppendDataValue(5, _cur__SalesYTD);
				track_array.AppendDataValue(6, _cur__SalesLastYear);
				track_array.AppendDataValue(7, _cur__rowguid);
				track_array.AppendDataValue(8, _cur__ModifiedDate);
			}
			else if (_recordstatus == DataRecordStatus.Existing)
			{
				if (_started_with_dbvalues)
				{
					if (_mod__BusinessEntityID) track_array.AppendDataValue(0, _cur__BusinessEntityID);
				}
				if (_mod__TerritoryID) track_array.AppendDataValue(1, _cur__TerritoryID);
				if (_mod__SalesQuota) track_array.AppendDataValue(2, _cur__SalesQuota);
				if (_mod__Bonus) track_array.AppendDataValue(3, _cur__Bonus);
				if (_mod__CommissionPct) track_array.AppendDataValue(4, _cur__CommissionPct);
				if (_mod__SalesYTD) track_array.AppendDataValue(5, _cur__SalesYTD);
				if (_mod__SalesLastYear) track_array.AppendDataValue(6, _cur__SalesLastYear);
				if (_mod__rowguid) track_array.AppendDataValue(7, _cur__rowguid);
				if (_mod__ModifiedDate) track_array.AppendDataValue(8, _cur__ModifiedDate);
				if (track_array.HasData == false) return;
			}

			if (_recordstatus == DataRecordStatus.Existing || _recordstatus == DataRecordStatus.ExistingDelete)
			{
				track_array.AppendPrikeyValue(0, (_mod__BusinessEntityID && _started_with_dbvalues) ? _ori__BusinessEntityID : _cur__BusinessEntityID);
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
				if (_mod__BusinessEntityID) _ori__BusinessEntityID = default(int);
				if (_mod__TerritoryID) _ori__TerritoryID = default(int?);
				if (_mod__SalesQuota) _ori__SalesQuota = default(decimal?);
				if (_mod__Bonus) _ori__Bonus = default(decimal);
				if (_mod__CommissionPct) _ori__CommissionPct = default(decimal);
				if (_mod__SalesYTD) _ori__SalesYTD = default(decimal);
				if (_mod__SalesLastYear) _ori__SalesLastYear = default(decimal);
				if (_mod__rowguid) _ori__rowguid = default(Guid);
				if (_mod__ModifiedDate) _ori__ModifiedDate = default(DateTime);
			}
			_mod__BusinessEntityID = false;
			_mod__TerritoryID = false;
			_mod__SalesQuota = false;
			_mod__Bonus = false;
			_mod__CommissionPct = false;
			_mod__SalesYTD = false;
			_mod__SalesLastYear = false;
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
	public partial class PriKey_Sales_SalesPerson_Record
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
