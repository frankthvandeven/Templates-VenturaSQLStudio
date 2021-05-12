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
	/// The updateable table is [Production].[BillOfMaterials]. Updateable table column information:
	/// • 9 out of 9 table columns are present in the resultset.
	/// • All primary key columns are present in the resultset: ProductAssemblyID, ComponentID and StartDate.
	/// • Non-primary key columns present in the resultset: BillOfMaterialsID, EndDate, UnitMeasureCode, BOMLevel, PerAssemblyQty
	///   and ModifiedDate.
	/// Recordset item automatically created by VenturaSQL Studio.
	/// </summary>
	public partial class GetAll_Production_BillOfMaterials_Recordset : ResultsetObservable<GetAll_Production_BillOfMaterials_Recordset, GetAll_Production_BillOfMaterials_Record>, IRecordsetBase
	{
		private IResultsetBase[] _resultsets;
		private string _sqlscript;
		private int _rowlimit = 500;
		private const string CRLF = "\r\n";

		public GetAll_Production_BillOfMaterials_Recordset()
		{
			_resultsets = new IResultsetBase[] { this };

			_sqlscript = @"SELECT TOP(@RowLimit) [BillOfMaterialsID],[ProductAssemblyID],[ComponentID],[StartDate],[EndDate],[UnitMeasureCode],[BOMLevel],[PerAssemblyQty],[ModifiedDate]" + CRLF +
			             @"FROM [Production].[BillOfMaterials]";

			ColumnArrayBuilder schema_array = new ColumnArrayBuilder();

			schema_array.Add(new VenturaSqlColumn("BillOfMaterialsID", typeof(int), false)
			{
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				IsIdentity = true,
				IsAutoIncrement = true,
				BaseSchemaName = "Production",
				BaseTableName = "BillOfMaterials",
				BaseColumnName = "BillOfMaterialsID"
			});

			schema_array.Add(new VenturaSqlColumn("ProductAssemblyID", typeof(int), true)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				IsKey = true,
				BaseSchemaName = "Production",
				BaseTableName = "BillOfMaterials",
				BaseColumnName = "ProductAssemblyID"
			});

			schema_array.Add(new VenturaSqlColumn("ComponentID", typeof(int), false)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				IsKey = true,
				BaseSchemaName = "Production",
				BaseTableName = "BillOfMaterials",
				BaseColumnName = "ComponentID"
			});

			schema_array.Add(new VenturaSqlColumn("StartDate", typeof(DateTime), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 23,
				NumericScale = 3,
				ProviderType = 4,
				IsKey = true,
				BaseSchemaName = "Production",
				BaseTableName = "BillOfMaterials",
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
				BaseTableName = "BillOfMaterials",
				BaseColumnName = "EndDate"
			});

			schema_array.Add(new VenturaSqlColumn("UnitMeasureCode", typeof(string), false)
			{
				Updateable = true,
				ColumnSize = 3,
				ProviderType = 10,
				BaseSchemaName = "Production",
				BaseTableName = "BillOfMaterials",
				BaseColumnName = "UnitMeasureCode"
			});

			schema_array.Add(new VenturaSqlColumn("BOMLevel", typeof(short), false)
			{
				Updateable = true,
				ColumnSize = 2,
				NumericPrecision = 5,
				ProviderType = 16,
				BaseSchemaName = "Production",
				BaseTableName = "BillOfMaterials",
				BaseColumnName = "BOMLevel"
			});

			schema_array.Add(new VenturaSqlColumn("PerAssemblyQty", typeof(decimal), false)
			{
				Updateable = true,
				ColumnSize = 17,
				NumericPrecision = 8,
				NumericScale = 2,
				ProviderType = 5,
				BaseSchemaName = "Production",
				BaseTableName = "BillOfMaterials",
				BaseColumnName = "PerAssemblyQty"
			});

			schema_array.Add(new VenturaSqlColumn("ModifiedDate", typeof(DateTime), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 23,
				NumericScale = 3,
				ProviderType = 4,
				BaseSchemaName = "Production",
				BaseTableName = "BillOfMaterials",
				BaseColumnName = "ModifiedDate"
			});

			((IResultsetBase)this).Schema = new VenturaSqlSchema(schema_array);
			((IResultsetBase)this).UpdateableTablename = "[Production].[BillOfMaterials]";
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Production].[BillOfMaterials]. NotReadonly. NotNull. IsIdentity. AutoIncrement.
		/// </summary>
		public int BillOfMaterialsID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.BillOfMaterialsID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.BillOfMaterialsID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[BillOfMaterials]. PrimaryKey. NotReadonly. AllowNull.
		/// </summary>
		public int? ProductAssemblyID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ProductAssemblyID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ProductAssemblyID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[BillOfMaterials]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public int ComponentID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ComponentID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ComponentID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[BillOfMaterials]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public DateTime StartDate
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.StartDate; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.StartDate = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[BillOfMaterials]. NotReadonly. AllowNull.
		/// </summary>
		public DateTime? EndDate
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.EndDate; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.EndDate = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[BillOfMaterials]. NotReadonly. NotNull.
		/// </summary>
		public string UnitMeasureCode
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.UnitMeasureCode; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.UnitMeasureCode = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[BillOfMaterials]. NotReadonly. NotNull.
		/// </summary>
		public short BOMLevel
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.BOMLevel; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.BOMLevel = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[BillOfMaterials]. NotReadonly. NotNull.
		/// </summary>
		public decimal PerAssemblyQty
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.PerAssemblyQty; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.PerAssemblyQty = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[BillOfMaterials]. NotReadonly. NotNull.
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
			this.InsertItem(index, new GetAll_Production_BillOfMaterials_Record());
			this.CurrentRecordIndex = index;
		}

		public void Append(GetAll_Production_BillOfMaterials_Record record)
		{
			int index = this.RecordCount;
			this.InsertItem(index, record);
			this.CurrentRecordIndex = index;
		}

		public GetAll_Production_BillOfMaterials_Record NewRecord()
		{
			return new GetAll_Production_BillOfMaterials_Record();
		}

		protected override GetAll_Production_BillOfMaterials_Record InternalCreateExistingRecordObject(object[] columnvalues) => new GetAll_Production_BillOfMaterials_Record(columnvalues);

		byte[] IRecordsetBase.Hash
		{
			get { return new byte[] { 155, 13, 110, 63, 154, 100, 75, 44, 53, 18, 13, 223, 149, 225, 178, 223 }; }
		}

		string IRecordsetBase.HashString
		{
			get { return "9B0D6E3F9A644B2C35120DDF95E1B2DF"; }
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

	public sealed partial class GetAll_Production_BillOfMaterials_Record : IRecordBase, INotifyPropertyChanged
	{
		private DataRecordStatus _recordstatus;
		private bool _started_with_dbvalues;

		private int _cur__BillOfMaterialsID; private int _ori__BillOfMaterialsID; private bool _mod__BillOfMaterialsID;
		private int? _cur__ProductAssemblyID; private int? _ori__ProductAssemblyID; private bool _mod__ProductAssemblyID;
		private int _cur__ComponentID; private int _ori__ComponentID; private bool _mod__ComponentID;
		private DateTime _cur__StartDate; private DateTime _ori__StartDate; private bool _mod__StartDate;
		private DateTime? _cur__EndDate; private DateTime? _ori__EndDate; private bool _mod__EndDate;
		private string _cur__UnitMeasureCode; private string _ori__UnitMeasureCode; private bool _mod__UnitMeasureCode;
		private short _cur__BOMLevel; private short _ori__BOMLevel; private bool _mod__BOMLevel;
		private decimal _cur__PerAssemblyQty; private decimal _ori__PerAssemblyQty; private bool _mod__PerAssemblyQty;
		private DateTime _cur__ModifiedDate; private DateTime _ori__ModifiedDate; private bool _mod__ModifiedDate;


		public GetAll_Production_BillOfMaterials_Record()
		{
			_cur__BillOfMaterialsID = 0;
			_cur__ProductAssemblyID = null;
			_cur__ComponentID = 0;
			_cur__StartDate = new DateTime(1900, 1, 1);
			_cur__EndDate = null;
			_cur__UnitMeasureCode = "";
			_cur__BOMLevel = 0;
			_cur__PerAssemblyQty = 0.0m;
			_cur__ModifiedDate = new DateTime(1900, 1, 1);
			_started_with_dbvalues = false;
			_recordstatus = DataRecordStatus.New;
		}

		public GetAll_Production_BillOfMaterials_Record(object[] columnvalues)
		{
			_cur__BillOfMaterialsID = (int)columnvalues[0];
			_cur__ProductAssemblyID = (int?)columnvalues[1];
			_cur__ComponentID = (int)columnvalues[2];
			_cur__StartDate = (DateTime)columnvalues[3];
			_cur__EndDate = (DateTime?)columnvalues[4];
			_cur__UnitMeasureCode = (string)columnvalues[5];
			_cur__BOMLevel = (short)columnvalues[6];
			_cur__PerAssemblyQty = (decimal)columnvalues[7];
			_cur__ModifiedDate = (DateTime)columnvalues[8];
			_started_with_dbvalues = true;
			_recordstatus = DataRecordStatus.Existing;
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Production].[BillOfMaterials]. NotReadonly. NotNull. IsIdentity. AutoIncrement.
		/// </summary>
		public int BillOfMaterialsID
		{
			get { return _cur__BillOfMaterialsID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__BillOfMaterialsID = true;
				if (_cur__BillOfMaterialsID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__BillOfMaterialsID == false) { _ori__BillOfMaterialsID = _cur__BillOfMaterialsID; _mod__BillOfMaterialsID = true; } // existing record and column is not modified
					else { if (value == _ori__BillOfMaterialsID) { _ori__BillOfMaterialsID = default(int); _mod__BillOfMaterialsID = false; } } // existing record and column is modified
				}
				_cur__BillOfMaterialsID = value; OnPropertyChanged("BillOfMaterialsID"); OnAfterPropertyChanged("BillOfMaterialsID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[BillOfMaterials]. PrimaryKey. NotReadonly. AllowNull.
		/// </summary>
		public int? ProductAssemblyID
		{
			get { return _cur__ProductAssemblyID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ProductAssemblyID = true;
				if (_cur__ProductAssemblyID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ProductAssemblyID == false) { _ori__ProductAssemblyID = _cur__ProductAssemblyID; _mod__ProductAssemblyID = true; } // existing record and column is not modified
					else { if (value == _ori__ProductAssemblyID) { _ori__ProductAssemblyID = default(int?); _mod__ProductAssemblyID = false; } } // existing record and column is modified
				}
				_cur__ProductAssemblyID = value; OnPropertyChanged("ProductAssemblyID"); OnAfterPropertyChanged("ProductAssemblyID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[BillOfMaterials]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public int ComponentID
		{
			get { return _cur__ComponentID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ComponentID = true;
				if (_cur__ComponentID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ComponentID == false) { _ori__ComponentID = _cur__ComponentID; _mod__ComponentID = true; } // existing record and column is not modified
					else { if (value == _ori__ComponentID) { _ori__ComponentID = default(int); _mod__ComponentID = false; } } // existing record and column is modified
				}
				_cur__ComponentID = value; OnPropertyChanged("ComponentID"); OnAfterPropertyChanged("ComponentID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[BillOfMaterials]. PrimaryKey. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [Production].[BillOfMaterials]. NotReadonly. AllowNull.
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
		/// Database Column Updateable. Table [Production].[BillOfMaterials]. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [Production].[BillOfMaterials]. NotReadonly. NotNull.
		/// </summary>
		public short BOMLevel
		{
			get { return _cur__BOMLevel; }
			set
			{
				if (_started_with_dbvalues == false) _mod__BOMLevel = true;
				if (_cur__BOMLevel == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__BOMLevel == false) { _ori__BOMLevel = _cur__BOMLevel; _mod__BOMLevel = true; } // existing record and column is not modified
					else { if (value == _ori__BOMLevel) { _ori__BOMLevel = default(short); _mod__BOMLevel = false; } } // existing record and column is modified
				}
				_cur__BOMLevel = value; OnPropertyChanged("BOMLevel"); OnAfterPropertyChanged("BOMLevel");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[BillOfMaterials]. NotReadonly. NotNull.
		/// </summary>
		public decimal PerAssemblyQty
		{
			get { return _cur__PerAssemblyQty; }
			set
			{
				if (_started_with_dbvalues == false) _mod__PerAssemblyQty = true;
				if (_cur__PerAssemblyQty == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__PerAssemblyQty == false) { _ori__PerAssemblyQty = _cur__PerAssemblyQty; _mod__PerAssemblyQty = true; } // existing record and column is not modified
					else { if (value == _ori__PerAssemblyQty) { _ori__PerAssemblyQty = default(decimal); _mod__PerAssemblyQty = false; } } // existing record and column is modified
				}
				_cur__PerAssemblyQty = value; OnPropertyChanged("PerAssemblyQty"); OnAfterPropertyChanged("PerAssemblyQty");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[BillOfMaterials]. NotReadonly. NotNull.
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
			if (column_name == "BillOfMaterialsID") return _mod__BillOfMaterialsID;
			if (column_name == "ProductAssemblyID") return _mod__ProductAssemblyID;
			if (column_name == "ComponentID") return _mod__ComponentID;
			if (column_name == "StartDate") return _mod__StartDate;
			if (column_name == "EndDate") return _mod__EndDate;
			if (column_name == "UnitMeasureCode") return _mod__UnitMeasureCode;
			if (column_name == "BOMLevel") return _mod__BOMLevel;
			if (column_name == "PerAssemblyQty") return _mod__PerAssemblyQty;
			if (column_name == "ModifiedDate") return _mod__ModifiedDate;
			throw new ArgumentOutOfRangeException(String.Format(VenturaSqlStrings.UNKNOWN_COLUMN_NAME, column_name));
		}

		public int ModifiedColumnCount()
		{
			int count = 0;
			if (_mod__BillOfMaterialsID == true) count++;
			if (_mod__ProductAssemblyID == true) count++;
			if (_mod__ComponentID == true) count++;
			if (_mod__StartDate == true) count++;
			if (_mod__EndDate == true) count++;
			if (_mod__UnitMeasureCode == true) count++;
			if (_mod__BOMLevel == true) count++;
			if (_mod__PerAssemblyQty == true) count++;
			if (_mod__ModifiedDate == true) count++;
			return count;
		}

		public bool PendingChanges()
		{
			if (_recordstatus == DataRecordStatus.New || _recordstatus == DataRecordStatus.ExistingDelete) return true;
			int count = 0;
			if (_started_with_dbvalues)
			{
				if (_mod__ProductAssemblyID) count++;
				if (_mod__ComponentID) count++;
				if (_mod__StartDate) count++;
			}
			if (_mod__EndDate == true) count++;
			if (_mod__UnitMeasureCode == true) count++;
			if (_mod__BOMLevel == true) count++;
			if (_mod__PerAssemblyQty == true) count++;
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
			if (_mod__ComponentID == false) throw new Exception(string.Format(VenturaSqlStrings.VALUE_NOT_SET_MSG, record_index_to_display, "ComponentID"));
			if (_mod__StartDate == false) throw new Exception(string.Format(VenturaSqlStrings.VALUE_NOT_SET_MSG, record_index_to_display, "StartDate"));
		}

		void IRecordBase.WriteChangesToTrackArray(TrackArray track_array)
		{
			if (_recordstatus == DataRecordStatus.New)
			{
				if (_cur__ProductAssemblyID != null) track_array.AppendDataValue(1, _cur__ProductAssemblyID);
				track_array.AppendDataValue(2, _cur__ComponentID);
				track_array.AppendDataValue(3, _cur__StartDate);
				if (_cur__EndDate != null) track_array.AppendDataValue(4, _cur__EndDate);
				track_array.AppendDataValue(5, _cur__UnitMeasureCode);
				track_array.AppendDataValue(6, _cur__BOMLevel);
				track_array.AppendDataValue(7, _cur__PerAssemblyQty);
				track_array.AppendDataValue(8, _cur__ModifiedDate);
			}
			else if (_recordstatus == DataRecordStatus.Existing)
			{
				if (_started_with_dbvalues)
				{
					if (_mod__ProductAssemblyID) track_array.AppendDataValue(1, _cur__ProductAssemblyID);
					if (_mod__ComponentID) track_array.AppendDataValue(2, _cur__ComponentID);
					if (_mod__StartDate) track_array.AppendDataValue(3, _cur__StartDate);
				}
				if (_mod__EndDate) track_array.AppendDataValue(4, _cur__EndDate);
				if (_mod__UnitMeasureCode) track_array.AppendDataValue(5, _cur__UnitMeasureCode);
				if (_mod__BOMLevel) track_array.AppendDataValue(6, _cur__BOMLevel);
				if (_mod__PerAssemblyQty) track_array.AppendDataValue(7, _cur__PerAssemblyQty);
				if (_mod__ModifiedDate) track_array.AppendDataValue(8, _cur__ModifiedDate);
				if (track_array.HasData == false) return;
			}

			if (_recordstatus == DataRecordStatus.Existing || _recordstatus == DataRecordStatus.ExistingDelete)
			{
				track_array.AppendPrikeyValue(1, (_mod__ProductAssemblyID && _started_with_dbvalues) ? _ori__ProductAssemblyID : _cur__ProductAssemblyID);
				track_array.AppendPrikeyValue(2, (_mod__ComponentID && _started_with_dbvalues) ? _ori__ComponentID : _cur__ComponentID);
				track_array.AppendPrikeyValue(3, (_mod__StartDate && _started_with_dbvalues) ? _ori__StartDate : _cur__StartDate);
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
				if (_mod__BillOfMaterialsID) _ori__BillOfMaterialsID = default(int);
				if (_mod__ProductAssemblyID) _ori__ProductAssemblyID = default(int?);
				if (_mod__ComponentID) _ori__ComponentID = default(int);
				if (_mod__StartDate) _ori__StartDate = default(DateTime);
				if (_mod__EndDate) _ori__EndDate = default(DateTime?);
				if (_mod__UnitMeasureCode) _ori__UnitMeasureCode = default(string);
				if (_mod__BOMLevel) _ori__BOMLevel = default(short);
				if (_mod__PerAssemblyQty) _ori__PerAssemblyQty = default(decimal);
				if (_mod__ModifiedDate) _ori__ModifiedDate = default(DateTime);
			}
			_mod__BillOfMaterialsID = false;
			_mod__ProductAssemblyID = false;
			_mod__ComponentID = false;
			_mod__StartDate = false;
			_mod__EndDate = false;
			_mod__UnitMeasureCode = false;
			_mod__BOMLevel = false;
			_mod__PerAssemblyQty = false;
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
			_cur__BillOfMaterialsID = (int)value;
			OnPropertyChanged("BillOfMaterialsID");
			OnAfterPropertyChanged("BillOfMaterialsID");
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
	public partial class GetAll_Production_BillOfMaterials_Record
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
