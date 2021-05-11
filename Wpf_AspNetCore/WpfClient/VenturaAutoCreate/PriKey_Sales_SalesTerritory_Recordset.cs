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
	/// The updateable table is [Sales].[SalesTerritory]. Updateable table column information:
	/// • 10 out of 10 table columns are present in the resultset.
	/// • All primary key columns are present in the resultset: TerritoryID.
	/// • Non-primary key columns present in the resultset: Name, CountryRegionCode, Group, SalesYTD, SalesLastYear, CostYTD,
	///   CostLastYear, rowguid and ModifiedDate.
	/// Recordset item automatically created by VenturaSQL Studio.
	/// </summary>
	public partial class PriKey_Sales_SalesTerritory_Recordset : ResultsetObservable<PriKey_Sales_SalesTerritory_Recordset, PriKey_Sales_SalesTerritory_Record>, IRecordsetBase
	{
		private IResultsetBase[] _resultsets;
		private string _sqlscript;
		private object[] _inputparametervalues;
		private InputParamHolder _inputparamholder;
		private VenturaSqlSchema _parameterschema;
		private int _rowlimit = 500;
		private const string CRLF = "\r\n";

		public PriKey_Sales_SalesTerritory_Recordset()
		{
			_resultsets = new IResultsetBase[] { this };

			_sqlscript = @"SELECT [TerritoryID],[Name],[CountryRegionCode],[Group],[SalesYTD],[SalesLastYear],[CostYTD],[CostLastYear],[rowguid],[ModifiedDate]" + CRLF +
			             @"FROM [Sales].[SalesTerritory]" + CRLF +
			             @"WHERE [TerritoryID] = @TerritoryID";

			_inputparametervalues = new object[1];
			_inputparamholder = new InputParamHolder(_inputparametervalues);

			ColumnArrayBuilder param_array = new ColumnArrayBuilder();

			param_array.AddParameterColumn("@TerritoryID", typeof(int), true, false, DbType.Int32, null, null, null);

			_parameterschema = new VenturaSqlSchema(param_array);

			ColumnArrayBuilder schema_array = new ColumnArrayBuilder();

			schema_array.Add(new VenturaSqlColumn("TerritoryID", typeof(int), false)
			{
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				IsKey = true,
				IsIdentity = true,
				IsAutoIncrement = true,
				BaseSchemaName = "Sales",
				BaseTableName = "SalesTerritory",
				BaseColumnName = "TerritoryID"
			});

			schema_array.Add(new VenturaSqlColumn("Name", typeof(string), false)
			{
				Updateable = true,
				ColumnSize = 50,
				ProviderType = 12,
				BaseSchemaName = "Sales",
				BaseTableName = "SalesTerritory",
				BaseColumnName = "Name"
			});

			schema_array.Add(new VenturaSqlColumn("CountryRegionCode", typeof(string), false)
			{
				Updateable = true,
				ColumnSize = 3,
				ProviderType = 12,
				BaseSchemaName = "Sales",
				BaseTableName = "SalesTerritory",
				BaseColumnName = "CountryRegionCode"
			});

			schema_array.Add(new VenturaSqlColumn("Group", typeof(string), false)
			{
				Updateable = true,
				ColumnSize = 50,
				ProviderType = 12,
				BaseSchemaName = "Sales",
				BaseTableName = "SalesTerritory",
				BaseColumnName = "Group"
			});

			schema_array.Add(new VenturaSqlColumn("SalesYTD", typeof(decimal), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 19,
				ProviderType = 9,
				BaseSchemaName = "Sales",
				BaseTableName = "SalesTerritory",
				BaseColumnName = "SalesYTD"
			});

			schema_array.Add(new VenturaSqlColumn("SalesLastYear", typeof(decimal), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 19,
				ProviderType = 9,
				BaseSchemaName = "Sales",
				BaseTableName = "SalesTerritory",
				BaseColumnName = "SalesLastYear"
			});

			schema_array.Add(new VenturaSqlColumn("CostYTD", typeof(decimal), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 19,
				ProviderType = 9,
				BaseSchemaName = "Sales",
				BaseTableName = "SalesTerritory",
				BaseColumnName = "CostYTD"
			});

			schema_array.Add(new VenturaSqlColumn("CostLastYear", typeof(decimal), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 19,
				ProviderType = 9,
				BaseSchemaName = "Sales",
				BaseTableName = "SalesTerritory",
				BaseColumnName = "CostLastYear"
			});

			schema_array.Add(new VenturaSqlColumn("rowguid", typeof(Guid), false)
			{
				Updateable = true,
				ColumnSize = 16,
				ProviderType = 14,
				BaseSchemaName = "Sales",
				BaseTableName = "SalesTerritory",
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
				BaseTableName = "SalesTerritory",
				BaseColumnName = "ModifiedDate"
			});

			((IResultsetBase)this).Schema = new VenturaSqlSchema(schema_array);
			((IResultsetBase)this).UpdateableTablename = "[Sales].[SalesTerritory]";
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Sales].[SalesTerritory]. PrimaryKey. NotReadonly. NotNull. IsIdentity. AutoIncrement.
		/// </summary>
		public int TerritoryID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.TerritoryID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.TerritoryID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesTerritory]. NotReadonly. NotNull.
		/// </summary>
		public string Name
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Name; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Name = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesTerritory]. NotReadonly. NotNull.
		/// </summary>
		public string CountryRegionCode
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.CountryRegionCode; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.CountryRegionCode = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesTerritory]. NotReadonly. NotNull.
		/// </summary>
		public string Group
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Group; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Group = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesTerritory]. NotReadonly. NotNull.
		/// </summary>
		public decimal SalesYTD
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.SalesYTD; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.SalesYTD = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesTerritory]. NotReadonly. NotNull.
		/// </summary>
		public decimal SalesLastYear
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.SalesLastYear; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.SalesLastYear = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesTerritory]. NotReadonly. NotNull.
		/// </summary>
		public decimal CostYTD
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.CostYTD; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.CostYTD = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesTerritory]. NotReadonly. NotNull.
		/// </summary>
		public decimal CostLastYear
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.CostLastYear; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.CostLastYear = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesTerritory]. NotReadonly. NotNull.
		/// </summary>
		public Guid rowguid
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.rowguid; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.rowguid = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesTerritory]. NotReadonly. NotNull.
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
			this.InsertItem(index, new PriKey_Sales_SalesTerritory_Record());
			this.CurrentRecordIndex = index;
		}

		public void Append(PriKey_Sales_SalesTerritory_Record record)
		{
			int index = this.RecordCount;
			this.InsertItem(index, record);
			this.CurrentRecordIndex = index;
		}

		public PriKey_Sales_SalesTerritory_Record NewRecord()
		{
			return new PriKey_Sales_SalesTerritory_Record();
		}

		protected override PriKey_Sales_SalesTerritory_Record InternalCreateExistingRecordObject(object[] columnvalues) => new PriKey_Sales_SalesTerritory_Record(columnvalues);

		byte[] IRecordsetBase.Hash
		{
			get { return new byte[] { 207, 128, 193, 133, 205, 185, 236, 188, 52, 126, 223, 160, 110, 21, 121, 240 }; }
		}

		string IRecordsetBase.HashString
		{
			get { return "CF80C185CDB9ECBC347EDFA06E1579F0"; }
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

		public void SetExecSqlParams(int? TerritoryID)
		{
			_inputparametervalues[0] = TerritoryID;
		}

		public void ExecSql(int? TerritoryID)
		{
			_inputparametervalues[0] = TerritoryID;
			Transactional.ExecSql(VenturaSqlConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public void ExecSql(Connector connector, int? TerritoryID)
		{
			_inputparametervalues[0] = TerritoryID;
			Transactional.ExecSql(connector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync(int? TerritoryID)
		{
			_inputparametervalues[0] = TerritoryID;
			await Transactional.ExecSqlAsync(VenturaSqlConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync(Connector connector, int? TerritoryID)
		{
			_inputparametervalues[0] = TerritoryID;
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

			public int? TerritoryID
			{
				get { return (int?)_values[0]; }
				set { _values[0] = value; }
			}

		}

	}

	public sealed partial class PriKey_Sales_SalesTerritory_Record : IRecordBase, INotifyPropertyChanged
	{
		private DataRecordStatus _recordstatus;
		private bool _started_with_dbvalues;

		private int _cur__TerritoryID; private int _ori__TerritoryID; private bool _mod__TerritoryID;
		private string _cur__Name; private string _ori__Name; private bool _mod__Name;
		private string _cur__CountryRegionCode; private string _ori__CountryRegionCode; private bool _mod__CountryRegionCode;
		private string _cur__Group; private string _ori__Group; private bool _mod__Group;
		private decimal _cur__SalesYTD; private decimal _ori__SalesYTD; private bool _mod__SalesYTD;
		private decimal _cur__SalesLastYear; private decimal _ori__SalesLastYear; private bool _mod__SalesLastYear;
		private decimal _cur__CostYTD; private decimal _ori__CostYTD; private bool _mod__CostYTD;
		private decimal _cur__CostLastYear; private decimal _ori__CostLastYear; private bool _mod__CostLastYear;
		private Guid _cur__rowguid; private Guid _ori__rowguid; private bool _mod__rowguid;
		private DateTime _cur__ModifiedDate; private DateTime _ori__ModifiedDate; private bool _mod__ModifiedDate;


		public PriKey_Sales_SalesTerritory_Record()
		{
			_cur__TerritoryID = 0;
			_cur__Name = "";
			_cur__CountryRegionCode = "";
			_cur__Group = "";
			_cur__SalesYTD = 0.0m;
			_cur__SalesLastYear = 0.0m;
			_cur__CostYTD = 0.0m;
			_cur__CostLastYear = 0.0m;
			_cur__rowguid = Guid.Empty;
			_cur__ModifiedDate = new DateTime(1900, 1, 1);
			_started_with_dbvalues = false;
			_recordstatus = DataRecordStatus.New;
		}

		public PriKey_Sales_SalesTerritory_Record(object[] columnvalues)
		{
			_cur__TerritoryID = (int)columnvalues[0];
			_cur__Name = (string)columnvalues[1];
			_cur__CountryRegionCode = (string)columnvalues[2];
			_cur__Group = (string)columnvalues[3];
			_cur__SalesYTD = (decimal)columnvalues[4];
			_cur__SalesLastYear = (decimal)columnvalues[5];
			_cur__CostYTD = (decimal)columnvalues[6];
			_cur__CostLastYear = (decimal)columnvalues[7];
			_cur__rowguid = (Guid)columnvalues[8];
			_cur__ModifiedDate = (DateTime)columnvalues[9];
			_started_with_dbvalues = true;
			_recordstatus = DataRecordStatus.Existing;
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Sales].[SalesTerritory]. PrimaryKey. NotReadonly. NotNull. IsIdentity. AutoIncrement.
		/// </summary>
		public int TerritoryID
		{
			get { return _cur__TerritoryID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__TerritoryID = true;
				if (_cur__TerritoryID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__TerritoryID == false) { _ori__TerritoryID = _cur__TerritoryID; _mod__TerritoryID = true; } // existing record and column is not modified
					else { if (value == _ori__TerritoryID) { _ori__TerritoryID = default(int); _mod__TerritoryID = false; } } // existing record and column is modified
				}
				_cur__TerritoryID = value; OnPropertyChanged("TerritoryID"); OnAfterPropertyChanged("TerritoryID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesTerritory]. NotReadonly. NotNull.
		/// </summary>
		public string Name
		{
			get { return _cur__Name; }
			set
			{
				if (value == null) throw new ArgumentNullException("Name", VenturaSqlStrings.SET_NULL_MSG);
				if (_started_with_dbvalues == false) _mod__Name = true;
				if (_cur__Name == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Name == false) { _ori__Name = _cur__Name; _mod__Name = true; } // existing record and column is not modified
					else { if (value == _ori__Name) { _ori__Name = default(string); _mod__Name = false; } } // existing record and column is modified
				}
				_cur__Name = value; OnPropertyChanged("Name"); OnAfterPropertyChanged("Name");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesTerritory]. NotReadonly. NotNull.
		/// </summary>
		public string CountryRegionCode
		{
			get { return _cur__CountryRegionCode; }
			set
			{
				if (value == null) throw new ArgumentNullException("CountryRegionCode", VenturaSqlStrings.SET_NULL_MSG);
				if (_started_with_dbvalues == false) _mod__CountryRegionCode = true;
				if (_cur__CountryRegionCode == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__CountryRegionCode == false) { _ori__CountryRegionCode = _cur__CountryRegionCode; _mod__CountryRegionCode = true; } // existing record and column is not modified
					else { if (value == _ori__CountryRegionCode) { _ori__CountryRegionCode = default(string); _mod__CountryRegionCode = false; } } // existing record and column is modified
				}
				_cur__CountryRegionCode = value; OnPropertyChanged("CountryRegionCode"); OnAfterPropertyChanged("CountryRegionCode");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesTerritory]. NotReadonly. NotNull.
		/// </summary>
		public string Group
		{
			get { return _cur__Group; }
			set
			{
				if (value == null) throw new ArgumentNullException("Group", VenturaSqlStrings.SET_NULL_MSG);
				if (_started_with_dbvalues == false) _mod__Group = true;
				if (_cur__Group == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Group == false) { _ori__Group = _cur__Group; _mod__Group = true; } // existing record and column is not modified
					else { if (value == _ori__Group) { _ori__Group = default(string); _mod__Group = false; } } // existing record and column is modified
				}
				_cur__Group = value; OnPropertyChanged("Group"); OnAfterPropertyChanged("Group");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesTerritory]. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [Sales].[SalesTerritory]. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [Sales].[SalesTerritory]. NotReadonly. NotNull.
		/// </summary>
		public decimal CostYTD
		{
			get { return _cur__CostYTD; }
			set
			{
				if (_started_with_dbvalues == false) _mod__CostYTD = true;
				if (_cur__CostYTD == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__CostYTD == false) { _ori__CostYTD = _cur__CostYTD; _mod__CostYTD = true; } // existing record and column is not modified
					else { if (value == _ori__CostYTD) { _ori__CostYTD = default(decimal); _mod__CostYTD = false; } } // existing record and column is modified
				}
				_cur__CostYTD = value; OnPropertyChanged("CostYTD"); OnAfterPropertyChanged("CostYTD");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesTerritory]. NotReadonly. NotNull.
		/// </summary>
		public decimal CostLastYear
		{
			get { return _cur__CostLastYear; }
			set
			{
				if (_started_with_dbvalues == false) _mod__CostLastYear = true;
				if (_cur__CostLastYear == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__CostLastYear == false) { _ori__CostLastYear = _cur__CostLastYear; _mod__CostLastYear = true; } // existing record and column is not modified
					else { if (value == _ori__CostLastYear) { _ori__CostLastYear = default(decimal); _mod__CostLastYear = false; } } // existing record and column is modified
				}
				_cur__CostLastYear = value; OnPropertyChanged("CostLastYear"); OnAfterPropertyChanged("CostLastYear");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesTerritory]. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [Sales].[SalesTerritory]. NotReadonly. NotNull.
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
			if (column_name == "TerritoryID") return _mod__TerritoryID;
			if (column_name == "Name") return _mod__Name;
			if (column_name == "CountryRegionCode") return _mod__CountryRegionCode;
			if (column_name == "Group") return _mod__Group;
			if (column_name == "SalesYTD") return _mod__SalesYTD;
			if (column_name == "SalesLastYear") return _mod__SalesLastYear;
			if (column_name == "CostYTD") return _mod__CostYTD;
			if (column_name == "CostLastYear") return _mod__CostLastYear;
			if (column_name == "rowguid") return _mod__rowguid;
			if (column_name == "ModifiedDate") return _mod__ModifiedDate;
			throw new ArgumentOutOfRangeException(String.Format(VenturaSqlStrings.UNKNOWN_COLUMN_NAME, column_name));
		}

		public int ModifiedColumnCount()
		{
			int count = 0;
			if (_mod__TerritoryID == true) count++;
			if (_mod__Name == true) count++;
			if (_mod__CountryRegionCode == true) count++;
			if (_mod__Group == true) count++;
			if (_mod__SalesYTD == true) count++;
			if (_mod__SalesLastYear == true) count++;
			if (_mod__CostYTD == true) count++;
			if (_mod__CostLastYear == true) count++;
			if (_mod__rowguid == true) count++;
			if (_mod__ModifiedDate == true) count++;
			return count;
		}

		public bool PendingChanges()
		{
			if (_recordstatus == DataRecordStatus.New || _recordstatus == DataRecordStatus.ExistingDelete) return true;
			int count = 0;
			if (_mod__Name == true) count++;
			if (_mod__CountryRegionCode == true) count++;
			if (_mod__Group == true) count++;
			if (_mod__SalesYTD == true) count++;
			if (_mod__SalesLastYear == true) count++;
			if (_mod__CostYTD == true) count++;
			if (_mod__CostLastYear == true) count++;
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
		}

		void IRecordBase.WriteChangesToTrackArray(TrackArray track_array)
		{
			if (_recordstatus == DataRecordStatus.New)
			{
				track_array.AppendDataValue(1, _cur__Name);
				track_array.AppendDataValue(2, _cur__CountryRegionCode);
				track_array.AppendDataValue(3, _cur__Group);
				track_array.AppendDataValue(4, _cur__SalesYTD);
				track_array.AppendDataValue(5, _cur__SalesLastYear);
				track_array.AppendDataValue(6, _cur__CostYTD);
				track_array.AppendDataValue(7, _cur__CostLastYear);
				track_array.AppendDataValue(8, _cur__rowguid);
				track_array.AppendDataValue(9, _cur__ModifiedDate);
			}
			else if (_recordstatus == DataRecordStatus.Existing)
			{
				if (_mod__Name) track_array.AppendDataValue(1, _cur__Name);
				if (_mod__CountryRegionCode) track_array.AppendDataValue(2, _cur__CountryRegionCode);
				if (_mod__Group) track_array.AppendDataValue(3, _cur__Group);
				if (_mod__SalesYTD) track_array.AppendDataValue(4, _cur__SalesYTD);
				if (_mod__SalesLastYear) track_array.AppendDataValue(5, _cur__SalesLastYear);
				if (_mod__CostYTD) track_array.AppendDataValue(6, _cur__CostYTD);
				if (_mod__CostLastYear) track_array.AppendDataValue(7, _cur__CostLastYear);
				if (_mod__rowguid) track_array.AppendDataValue(8, _cur__rowguid);
				if (_mod__ModifiedDate) track_array.AppendDataValue(9, _cur__ModifiedDate);
				if (track_array.HasData == false) return;
			}

			if (_recordstatus == DataRecordStatus.Existing || _recordstatus == DataRecordStatus.ExistingDelete)
			{
				track_array.AppendPrikeyValue(0, (_mod__TerritoryID && _started_with_dbvalues) ? _ori__TerritoryID : _cur__TerritoryID);
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
				if (_mod__TerritoryID) _ori__TerritoryID = default(int);
				if (_mod__Name) _ori__Name = default(string);
				if (_mod__CountryRegionCode) _ori__CountryRegionCode = default(string);
				if (_mod__Group) _ori__Group = default(string);
				if (_mod__SalesYTD) _ori__SalesYTD = default(decimal);
				if (_mod__SalesLastYear) _ori__SalesLastYear = default(decimal);
				if (_mod__CostYTD) _ori__CostYTD = default(decimal);
				if (_mod__CostLastYear) _ori__CostLastYear = default(decimal);
				if (_mod__rowguid) _ori__rowguid = default(Guid);
				if (_mod__ModifiedDate) _ori__ModifiedDate = default(DateTime);
			}
			_mod__TerritoryID = false;
			_mod__Name = false;
			_mod__CountryRegionCode = false;
			_mod__Group = false;
			_mod__SalesYTD = false;
			_mod__SalesLastYear = false;
			_mod__CostYTD = false;
			_mod__CostLastYear = false;
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
			_cur__TerritoryID = (int)value;
			OnPropertyChanged("TerritoryID");
			OnAfterPropertyChanged("TerritoryID");
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
	public partial class PriKey_Sales_SalesTerritory_Record
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
