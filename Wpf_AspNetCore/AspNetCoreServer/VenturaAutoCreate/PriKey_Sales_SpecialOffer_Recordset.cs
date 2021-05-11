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
	/// The updateable table is [Sales].[SpecialOffer]. Updateable table column information:
	/// • 11 out of 11 table columns are present in the resultset.
	/// • All primary key columns are present in the resultset: SpecialOfferID.
	/// • Non-primary key columns present in the resultset: Description, DiscountPct, Type, Category, StartDate, EndDate, MinQty,
	///   MaxQty, rowguid and ModifiedDate.
	/// Recordset item automatically created by VenturaSQL Studio.
	/// </summary>
	public partial class PriKey_Sales_SpecialOffer_Recordset : ResultsetObservable<PriKey_Sales_SpecialOffer_Recordset, PriKey_Sales_SpecialOffer_Record>, IRecordsetBase
	{
		private IResultsetBase[] _resultsets;
		private string _sqlscript;
		private object[] _inputparametervalues;
		private InputParamHolder _inputparamholder;
		private VenturaSqlSchema _parameterschema;
		private int _rowlimit = 500;
		private const string CRLF = "\r\n";

		public PriKey_Sales_SpecialOffer_Recordset()
		{
			_resultsets = new IResultsetBase[] { this };

			_sqlscript = @"SELECT [SpecialOfferID],[Description],[DiscountPct],[Type],[Category],[StartDate],[EndDate],[MinQty],[MaxQty],[rowguid],[ModifiedDate]" + CRLF +
			             @"FROM [Sales].[SpecialOffer]" + CRLF +
			             @"WHERE [SpecialOfferID] = @SpecialOfferID";

			_inputparametervalues = new object[1];
			_inputparamholder = new InputParamHolder(_inputparametervalues);

			ColumnArrayBuilder param_array = new ColumnArrayBuilder();

			param_array.AddParameterColumn("@SpecialOfferID", typeof(int), true, false, DbType.Int32, null, null, null);

			_parameterschema = new VenturaSqlSchema(param_array);

			ColumnArrayBuilder schema_array = new ColumnArrayBuilder();

			schema_array.Add(new VenturaSqlColumn("SpecialOfferID", typeof(int), false)
			{
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				IsKey = true,
				IsIdentity = true,
				IsAutoIncrement = true,
				BaseSchemaName = "Sales",
				BaseTableName = "SpecialOffer",
				BaseColumnName = "SpecialOfferID"
			});

			schema_array.Add(new VenturaSqlColumn("Description", typeof(string), false)
			{
				Updateable = true,
				ColumnSize = 255,
				ProviderType = 12,
				BaseSchemaName = "Sales",
				BaseTableName = "SpecialOffer",
				BaseColumnName = "Description"
			});

			schema_array.Add(new VenturaSqlColumn("DiscountPct", typeof(decimal), false)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 17,
				BaseSchemaName = "Sales",
				BaseTableName = "SpecialOffer",
				BaseColumnName = "DiscountPct"
			});

			schema_array.Add(new VenturaSqlColumn("Type", typeof(string), false)
			{
				Updateable = true,
				ColumnSize = 50,
				ProviderType = 12,
				BaseSchemaName = "Sales",
				BaseTableName = "SpecialOffer",
				BaseColumnName = "Type"
			});

			schema_array.Add(new VenturaSqlColumn("Category", typeof(string), false)
			{
				Updateable = true,
				ColumnSize = 50,
				ProviderType = 12,
				BaseSchemaName = "Sales",
				BaseTableName = "SpecialOffer",
				BaseColumnName = "Category"
			});

			schema_array.Add(new VenturaSqlColumn("StartDate", typeof(DateTime), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 23,
				NumericScale = 3,
				ProviderType = 4,
				BaseSchemaName = "Sales",
				BaseTableName = "SpecialOffer",
				BaseColumnName = "StartDate"
			});

			schema_array.Add(new VenturaSqlColumn("EndDate", typeof(DateTime), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 23,
				NumericScale = 3,
				ProviderType = 4,
				BaseSchemaName = "Sales",
				BaseTableName = "SpecialOffer",
				BaseColumnName = "EndDate"
			});

			schema_array.Add(new VenturaSqlColumn("MinQty", typeof(int), false)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				BaseSchemaName = "Sales",
				BaseTableName = "SpecialOffer",
				BaseColumnName = "MinQty"
			});

			schema_array.Add(new VenturaSqlColumn("MaxQty", typeof(int), true)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				BaseSchemaName = "Sales",
				BaseTableName = "SpecialOffer",
				BaseColumnName = "MaxQty"
			});

			schema_array.Add(new VenturaSqlColumn("rowguid", typeof(Guid), false)
			{
				Updateable = true,
				ColumnSize = 16,
				ProviderType = 14,
				BaseSchemaName = "Sales",
				BaseTableName = "SpecialOffer",
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
				BaseTableName = "SpecialOffer",
				BaseColumnName = "ModifiedDate"
			});

			((IResultsetBase)this).Schema = new VenturaSqlSchema(schema_array);
			((IResultsetBase)this).UpdateableTablename = "[Sales].[SpecialOffer]";
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Sales].[SpecialOffer]. PrimaryKey. NotReadonly. NotNull. IsIdentity. AutoIncrement.
		/// </summary>
		public int SpecialOfferID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.SpecialOfferID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.SpecialOfferID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SpecialOffer]. NotReadonly. NotNull.
		/// </summary>
		public string Description
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Description; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Description = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SpecialOffer]. NotReadonly. NotNull.
		/// </summary>
		public decimal DiscountPct
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.DiscountPct; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.DiscountPct = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SpecialOffer]. NotReadonly. NotNull.
		/// </summary>
		public string Type
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Type; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Type = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SpecialOffer]. NotReadonly. NotNull.
		/// </summary>
		public string Category
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Category; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Category = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SpecialOffer]. NotReadonly. NotNull.
		/// </summary>
		public DateTime StartDate
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.StartDate; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.StartDate = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SpecialOffer]. NotReadonly. NotNull.
		/// </summary>
		public DateTime EndDate
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.EndDate; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.EndDate = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SpecialOffer]. NotReadonly. NotNull.
		/// </summary>
		public int MinQty
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.MinQty; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.MinQty = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SpecialOffer]. NotReadonly. AllowNull.
		/// </summary>
		public int? MaxQty
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.MaxQty; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.MaxQty = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SpecialOffer]. NotReadonly. NotNull.
		/// </summary>
		public Guid rowguid
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.rowguid; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.rowguid = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SpecialOffer]. NotReadonly. NotNull.
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
			this.InsertItem(index, new PriKey_Sales_SpecialOffer_Record());
			this.CurrentRecordIndex = index;
		}

		public void Append(PriKey_Sales_SpecialOffer_Record record)
		{
			int index = this.RecordCount;
			this.InsertItem(index, record);
			this.CurrentRecordIndex = index;
		}

		public PriKey_Sales_SpecialOffer_Record NewRecord()
		{
			return new PriKey_Sales_SpecialOffer_Record();
		}

		protected override PriKey_Sales_SpecialOffer_Record InternalCreateExistingRecordObject(object[] columnvalues) => new PriKey_Sales_SpecialOffer_Record(columnvalues);

		byte[] IRecordsetBase.Hash
		{
			get { return new byte[] { 118, 240, 251, 153, 37, 220, 108, 194, 136, 219, 175, 244, 60, 110, 91, 211 }; }
		}

		string IRecordsetBase.HashString
		{
			get { return "76F0FB9925DC6CC288DBAFF43C6E5BD3"; }
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

		public void SetExecSqlParams(int? SpecialOfferID)
		{
			_inputparametervalues[0] = SpecialOfferID;
		}

		public void ExecSql(int? SpecialOfferID)
		{
			_inputparametervalues[0] = SpecialOfferID;
			Transactional.ExecSql(VenturaSqlConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public void ExecSql(Connector connector, int? SpecialOfferID)
		{
			_inputparametervalues[0] = SpecialOfferID;
			Transactional.ExecSql(connector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync(int? SpecialOfferID)
		{
			_inputparametervalues[0] = SpecialOfferID;
			await Transactional.ExecSqlAsync(VenturaSqlConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync(Connector connector, int? SpecialOfferID)
		{
			_inputparametervalues[0] = SpecialOfferID;
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

			public int? SpecialOfferID
			{
				get { return (int?)_values[0]; }
				set { _values[0] = value; }
			}

		}

	}

	public sealed partial class PriKey_Sales_SpecialOffer_Record : IRecordBase, INotifyPropertyChanged
	{
		private DataRecordStatus _recordstatus;
		private bool _started_with_dbvalues;

		private int _cur__SpecialOfferID; private int _ori__SpecialOfferID; private bool _mod__SpecialOfferID;
		private string _cur__Description; private string _ori__Description; private bool _mod__Description;
		private decimal _cur__DiscountPct; private decimal _ori__DiscountPct; private bool _mod__DiscountPct;
		private string _cur__Type; private string _ori__Type; private bool _mod__Type;
		private string _cur__Category; private string _ori__Category; private bool _mod__Category;
		private DateTime _cur__StartDate; private DateTime _ori__StartDate; private bool _mod__StartDate;
		private DateTime _cur__EndDate; private DateTime _ori__EndDate; private bool _mod__EndDate;
		private int _cur__MinQty; private int _ori__MinQty; private bool _mod__MinQty;
		private int? _cur__MaxQty; private int? _ori__MaxQty; private bool _mod__MaxQty;
		private Guid _cur__rowguid; private Guid _ori__rowguid; private bool _mod__rowguid;
		private DateTime _cur__ModifiedDate; private DateTime _ori__ModifiedDate; private bool _mod__ModifiedDate;


		public PriKey_Sales_SpecialOffer_Record()
		{
			_cur__SpecialOfferID = 0;
			_cur__Description = "";
			_cur__DiscountPct = 0.0m;
			_cur__Type = "";
			_cur__Category = "";
			_cur__StartDate = new DateTime(1900, 1, 1);
			_cur__EndDate = new DateTime(1900, 1, 1);
			_cur__MinQty = 0;
			_cur__MaxQty = null;
			_cur__rowguid = Guid.Empty;
			_cur__ModifiedDate = new DateTime(1900, 1, 1);
			_started_with_dbvalues = false;
			_recordstatus = DataRecordStatus.New;
		}

		public PriKey_Sales_SpecialOffer_Record(object[] columnvalues)
		{
			_cur__SpecialOfferID = (int)columnvalues[0];
			_cur__Description = (string)columnvalues[1];
			_cur__DiscountPct = (decimal)columnvalues[2];
			_cur__Type = (string)columnvalues[3];
			_cur__Category = (string)columnvalues[4];
			_cur__StartDate = (DateTime)columnvalues[5];
			_cur__EndDate = (DateTime)columnvalues[6];
			_cur__MinQty = (int)columnvalues[7];
			_cur__MaxQty = (int?)columnvalues[8];
			_cur__rowguid = (Guid)columnvalues[9];
			_cur__ModifiedDate = (DateTime)columnvalues[10];
			_started_with_dbvalues = true;
			_recordstatus = DataRecordStatus.Existing;
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Sales].[SpecialOffer]. PrimaryKey. NotReadonly. NotNull. IsIdentity. AutoIncrement.
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
		/// Database Column Updateable. Table [Sales].[SpecialOffer]. NotReadonly. NotNull.
		/// </summary>
		public string Description
		{
			get { return _cur__Description; }
			set
			{
				if (value == null) throw new ArgumentNullException("Description", VenturaSqlStrings.SET_NULL_MSG);
				if (_started_with_dbvalues == false) _mod__Description = true;
				if (_cur__Description == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Description == false) { _ori__Description = _cur__Description; _mod__Description = true; } // existing record and column is not modified
					else { if (value == _ori__Description) { _ori__Description = default(string); _mod__Description = false; } } // existing record and column is modified
				}
				_cur__Description = value; OnPropertyChanged("Description"); OnAfterPropertyChanged("Description");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SpecialOffer]. NotReadonly. NotNull.
		/// </summary>
		public decimal DiscountPct
		{
			get { return _cur__DiscountPct; }
			set
			{
				if (_started_with_dbvalues == false) _mod__DiscountPct = true;
				if (_cur__DiscountPct == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__DiscountPct == false) { _ori__DiscountPct = _cur__DiscountPct; _mod__DiscountPct = true; } // existing record and column is not modified
					else { if (value == _ori__DiscountPct) { _ori__DiscountPct = default(decimal); _mod__DiscountPct = false; } } // existing record and column is modified
				}
				_cur__DiscountPct = value; OnPropertyChanged("DiscountPct"); OnAfterPropertyChanged("DiscountPct");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SpecialOffer]. NotReadonly. NotNull.
		/// </summary>
		public string Type
		{
			get { return _cur__Type; }
			set
			{
				if (value == null) throw new ArgumentNullException("Type", VenturaSqlStrings.SET_NULL_MSG);
				if (_started_with_dbvalues == false) _mod__Type = true;
				if (_cur__Type == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Type == false) { _ori__Type = _cur__Type; _mod__Type = true; } // existing record and column is not modified
					else { if (value == _ori__Type) { _ori__Type = default(string); _mod__Type = false; } } // existing record and column is modified
				}
				_cur__Type = value; OnPropertyChanged("Type"); OnAfterPropertyChanged("Type");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SpecialOffer]. NotReadonly. NotNull.
		/// </summary>
		public string Category
		{
			get { return _cur__Category; }
			set
			{
				if (value == null) throw new ArgumentNullException("Category", VenturaSqlStrings.SET_NULL_MSG);
				if (_started_with_dbvalues == false) _mod__Category = true;
				if (_cur__Category == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Category == false) { _ori__Category = _cur__Category; _mod__Category = true; } // existing record and column is not modified
					else { if (value == _ori__Category) { _ori__Category = default(string); _mod__Category = false; } } // existing record and column is modified
				}
				_cur__Category = value; OnPropertyChanged("Category"); OnAfterPropertyChanged("Category");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SpecialOffer]. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [Sales].[SpecialOffer]. NotReadonly. NotNull.
		/// </summary>
		public DateTime EndDate
		{
			get { return _cur__EndDate; }
			set
			{
				if (_started_with_dbvalues == false) _mod__EndDate = true;
				if (_cur__EndDate == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__EndDate == false) { _ori__EndDate = _cur__EndDate; _mod__EndDate = true; } // existing record and column is not modified
					else { if (value == _ori__EndDate) { _ori__EndDate = default(DateTime); _mod__EndDate = false; } } // existing record and column is modified
				}
				_cur__EndDate = value; OnPropertyChanged("EndDate"); OnAfterPropertyChanged("EndDate");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SpecialOffer]. NotReadonly. NotNull.
		/// </summary>
		public int MinQty
		{
			get { return _cur__MinQty; }
			set
			{
				if (_started_with_dbvalues == false) _mod__MinQty = true;
				if (_cur__MinQty == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__MinQty == false) { _ori__MinQty = _cur__MinQty; _mod__MinQty = true; } // existing record and column is not modified
					else { if (value == _ori__MinQty) { _ori__MinQty = default(int); _mod__MinQty = false; } } // existing record and column is modified
				}
				_cur__MinQty = value; OnPropertyChanged("MinQty"); OnAfterPropertyChanged("MinQty");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SpecialOffer]. NotReadonly. AllowNull.
		/// </summary>
		public int? MaxQty
		{
			get { return _cur__MaxQty; }
			set
			{
				if (_started_with_dbvalues == false) _mod__MaxQty = true;
				if (_cur__MaxQty == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__MaxQty == false) { _ori__MaxQty = _cur__MaxQty; _mod__MaxQty = true; } // existing record and column is not modified
					else { if (value == _ori__MaxQty) { _ori__MaxQty = default(int?); _mod__MaxQty = false; } } // existing record and column is modified
				}
				_cur__MaxQty = value; OnPropertyChanged("MaxQty"); OnAfterPropertyChanged("MaxQty");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SpecialOffer]. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [Sales].[SpecialOffer]. NotReadonly. NotNull.
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
			if (column_name == "SpecialOfferID") return _mod__SpecialOfferID;
			if (column_name == "Description") return _mod__Description;
			if (column_name == "DiscountPct") return _mod__DiscountPct;
			if (column_name == "Type") return _mod__Type;
			if (column_name == "Category") return _mod__Category;
			if (column_name == "StartDate") return _mod__StartDate;
			if (column_name == "EndDate") return _mod__EndDate;
			if (column_name == "MinQty") return _mod__MinQty;
			if (column_name == "MaxQty") return _mod__MaxQty;
			if (column_name == "rowguid") return _mod__rowguid;
			if (column_name == "ModifiedDate") return _mod__ModifiedDate;
			throw new ArgumentOutOfRangeException(String.Format(VenturaSqlStrings.UNKNOWN_COLUMN_NAME, column_name));
		}

		public int ModifiedColumnCount()
		{
			int count = 0;
			if (_mod__SpecialOfferID == true) count++;
			if (_mod__Description == true) count++;
			if (_mod__DiscountPct == true) count++;
			if (_mod__Type == true) count++;
			if (_mod__Category == true) count++;
			if (_mod__StartDate == true) count++;
			if (_mod__EndDate == true) count++;
			if (_mod__MinQty == true) count++;
			if (_mod__MaxQty == true) count++;
			if (_mod__rowguid == true) count++;
			if (_mod__ModifiedDate == true) count++;
			return count;
		}

		public bool PendingChanges()
		{
			if (_recordstatus == DataRecordStatus.New || _recordstatus == DataRecordStatus.ExistingDelete) return true;
			int count = 0;
			if (_mod__Description == true) count++;
			if (_mod__DiscountPct == true) count++;
			if (_mod__Type == true) count++;
			if (_mod__Category == true) count++;
			if (_mod__StartDate == true) count++;
			if (_mod__EndDate == true) count++;
			if (_mod__MinQty == true) count++;
			if (_mod__MaxQty == true) count++;
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
				track_array.AppendDataValue(1, _cur__Description);
				track_array.AppendDataValue(2, _cur__DiscountPct);
				track_array.AppendDataValue(3, _cur__Type);
				track_array.AppendDataValue(4, _cur__Category);
				track_array.AppendDataValue(5, _cur__StartDate);
				track_array.AppendDataValue(6, _cur__EndDate);
				track_array.AppendDataValue(7, _cur__MinQty);
				if (_cur__MaxQty != null) track_array.AppendDataValue(8, _cur__MaxQty);
				track_array.AppendDataValue(9, _cur__rowguid);
				track_array.AppendDataValue(10, _cur__ModifiedDate);
			}
			else if (_recordstatus == DataRecordStatus.Existing)
			{
				if (_mod__Description) track_array.AppendDataValue(1, _cur__Description);
				if (_mod__DiscountPct) track_array.AppendDataValue(2, _cur__DiscountPct);
				if (_mod__Type) track_array.AppendDataValue(3, _cur__Type);
				if (_mod__Category) track_array.AppendDataValue(4, _cur__Category);
				if (_mod__StartDate) track_array.AppendDataValue(5, _cur__StartDate);
				if (_mod__EndDate) track_array.AppendDataValue(6, _cur__EndDate);
				if (_mod__MinQty) track_array.AppendDataValue(7, _cur__MinQty);
				if (_mod__MaxQty) track_array.AppendDataValue(8, _cur__MaxQty);
				if (_mod__rowguid) track_array.AppendDataValue(9, _cur__rowguid);
				if (_mod__ModifiedDate) track_array.AppendDataValue(10, _cur__ModifiedDate);
				if (track_array.HasData == false) return;
			}

			if (_recordstatus == DataRecordStatus.Existing || _recordstatus == DataRecordStatus.ExistingDelete)
			{
				track_array.AppendPrikeyValue(0, (_mod__SpecialOfferID && _started_with_dbvalues) ? _ori__SpecialOfferID : _cur__SpecialOfferID);
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
				if (_mod__SpecialOfferID) _ori__SpecialOfferID = default(int);
				if (_mod__Description) _ori__Description = default(string);
				if (_mod__DiscountPct) _ori__DiscountPct = default(decimal);
				if (_mod__Type) _ori__Type = default(string);
				if (_mod__Category) _ori__Category = default(string);
				if (_mod__StartDate) _ori__StartDate = default(DateTime);
				if (_mod__EndDate) _ori__EndDate = default(DateTime);
				if (_mod__MinQty) _ori__MinQty = default(int);
				if (_mod__MaxQty) _ori__MaxQty = default(int?);
				if (_mod__rowguid) _ori__rowguid = default(Guid);
				if (_mod__ModifiedDate) _ori__ModifiedDate = default(DateTime);
			}
			_mod__SpecialOfferID = false;
			_mod__Description = false;
			_mod__DiscountPct = false;
			_mod__Type = false;
			_mod__Category = false;
			_mod__StartDate = false;
			_mod__EndDate = false;
			_mod__MinQty = false;
			_mod__MaxQty = false;
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
			_cur__SpecialOfferID = (int)value;
			OnPropertyChanged("SpecialOfferID");
			OnAfterPropertyChanged("SpecialOfferID");
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
	public partial class PriKey_Sales_SpecialOffer_Record
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
