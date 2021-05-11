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
	/// The updateable table is [Production].[WorkOrderRouting]. Updateable table column information:
	/// • 12 out of 12 table columns are present in the resultset.
	/// • All primary key columns are present in the resultset: WorkOrderID, ProductID and OperationSequence.
	/// • Non-primary key columns present in the resultset: LocationID, ScheduledStartDate, ScheduledEndDate, ActualStartDate,
	///   ActualEndDate, ActualResourceHrs, PlannedCost, ActualCost and ModifiedDate.
	/// Recordset item automatically created by VenturaSQL Studio.
	/// </summary>
	public partial class PriKey_Production_WorkOrderRouting_Recordset : ResultsetObservable<PriKey_Production_WorkOrderRouting_Recordset, PriKey_Production_WorkOrderRouting_Record>, IRecordsetBase
	{
		private IResultsetBase[] _resultsets;
		private string _sqlscript;
		private object[] _inputparametervalues;
		private InputParamHolder _inputparamholder;
		private VenturaSqlSchema _parameterschema;
		private int _rowlimit = 500;
		private const string CRLF = "\r\n";

		public PriKey_Production_WorkOrderRouting_Recordset()
		{
			_resultsets = new IResultsetBase[] { this };

			_sqlscript = @"SELECT [WorkOrderID],[ProductID],[OperationSequence],[LocationID],[ScheduledStartDate],[ScheduledEndDate],[ActualStartDate],[ActualEndDate],[ActualResourceHrs]," + CRLF +
			             @"[PlannedCost],[ActualCost],[ModifiedDate]" + CRLF +
			             @"FROM [Production].[WorkOrderRouting]" + CRLF +
			             @"WHERE [WorkOrderID] = @WorkOrderID" + CRLF +
			             @"AND [ProductID] = @ProductID" + CRLF +
			             @"AND [OperationSequence] = @OperationSequence";

			_inputparametervalues = new object[3];
			_inputparamholder = new InputParamHolder(_inputparametervalues);

			ColumnArrayBuilder param_array = new ColumnArrayBuilder();

			param_array.AddParameterColumn("@WorkOrderID", typeof(int), true, false, DbType.Int32, null, null, null);
			param_array.AddParameterColumn("@ProductID", typeof(int), true, false, DbType.Int32, null, null, null);
			param_array.AddParameterColumn("@OperationSequence", typeof(short), true, false, DbType.Int16, null, null, null);

			_parameterschema = new VenturaSqlSchema(param_array);

			ColumnArrayBuilder schema_array = new ColumnArrayBuilder();

			schema_array.Add(new VenturaSqlColumn("WorkOrderID", typeof(int), false)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				IsKey = true,
				BaseSchemaName = "Production",
				BaseTableName = "WorkOrderRouting",
				BaseColumnName = "WorkOrderID"
			});

			schema_array.Add(new VenturaSqlColumn("ProductID", typeof(int), false)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				IsKey = true,
				BaseSchemaName = "Production",
				BaseTableName = "WorkOrderRouting",
				BaseColumnName = "ProductID"
			});

			schema_array.Add(new VenturaSqlColumn("OperationSequence", typeof(short), false)
			{
				Updateable = true,
				ColumnSize = 2,
				NumericPrecision = 5,
				ProviderType = 16,
				IsKey = true,
				BaseSchemaName = "Production",
				BaseTableName = "WorkOrderRouting",
				BaseColumnName = "OperationSequence"
			});

			schema_array.Add(new VenturaSqlColumn("LocationID", typeof(short), false)
			{
				Updateable = true,
				ColumnSize = 2,
				NumericPrecision = 5,
				ProviderType = 16,
				BaseSchemaName = "Production",
				BaseTableName = "WorkOrderRouting",
				BaseColumnName = "LocationID"
			});

			schema_array.Add(new VenturaSqlColumn("ScheduledStartDate", typeof(DateTime), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 23,
				NumericScale = 3,
				ProviderType = 4,
				BaseSchemaName = "Production",
				BaseTableName = "WorkOrderRouting",
				BaseColumnName = "ScheduledStartDate"
			});

			schema_array.Add(new VenturaSqlColumn("ScheduledEndDate", typeof(DateTime), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 23,
				NumericScale = 3,
				ProviderType = 4,
				BaseSchemaName = "Production",
				BaseTableName = "WorkOrderRouting",
				BaseColumnName = "ScheduledEndDate"
			});

			schema_array.Add(new VenturaSqlColumn("ActualStartDate", typeof(DateTime), true)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 23,
				NumericScale = 3,
				ProviderType = 4,
				BaseSchemaName = "Production",
				BaseTableName = "WorkOrderRouting",
				BaseColumnName = "ActualStartDate"
			});

			schema_array.Add(new VenturaSqlColumn("ActualEndDate", typeof(DateTime), true)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 23,
				NumericScale = 3,
				ProviderType = 4,
				BaseSchemaName = "Production",
				BaseTableName = "WorkOrderRouting",
				BaseColumnName = "ActualEndDate"
			});

			schema_array.Add(new VenturaSqlColumn("ActualResourceHrs", typeof(decimal), true)
			{
				Updateable = true,
				ColumnSize = 17,
				NumericPrecision = 9,
				NumericScale = 4,
				ProviderType = 5,
				BaseSchemaName = "Production",
				BaseTableName = "WorkOrderRouting",
				BaseColumnName = "ActualResourceHrs"
			});

			schema_array.Add(new VenturaSqlColumn("PlannedCost", typeof(decimal), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 19,
				ProviderType = 9,
				BaseSchemaName = "Production",
				BaseTableName = "WorkOrderRouting",
				BaseColumnName = "PlannedCost"
			});

			schema_array.Add(new VenturaSqlColumn("ActualCost", typeof(decimal), true)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 19,
				ProviderType = 9,
				BaseSchemaName = "Production",
				BaseTableName = "WorkOrderRouting",
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
				BaseTableName = "WorkOrderRouting",
				BaseColumnName = "ModifiedDate"
			});

			((IResultsetBase)this).Schema = new VenturaSqlSchema(schema_array);
			((IResultsetBase)this).UpdateableTablename = "[Production].[WorkOrderRouting]";
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[WorkOrderRouting]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public int WorkOrderID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.WorkOrderID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.WorkOrderID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[WorkOrderRouting]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public int ProductID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ProductID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ProductID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[WorkOrderRouting]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public short OperationSequence
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.OperationSequence; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.OperationSequence = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[WorkOrderRouting]. NotReadonly. NotNull.
		/// </summary>
		public short LocationID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.LocationID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.LocationID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[WorkOrderRouting]. NotReadonly. NotNull.
		/// </summary>
		public DateTime ScheduledStartDate
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ScheduledStartDate; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ScheduledStartDate = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[WorkOrderRouting]. NotReadonly. NotNull.
		/// </summary>
		public DateTime ScheduledEndDate
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ScheduledEndDate; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ScheduledEndDate = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[WorkOrderRouting]. NotReadonly. AllowNull.
		/// </summary>
		public DateTime? ActualStartDate
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ActualStartDate; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ActualStartDate = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[WorkOrderRouting]. NotReadonly. AllowNull.
		/// </summary>
		public DateTime? ActualEndDate
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ActualEndDate; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ActualEndDate = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[WorkOrderRouting]. NotReadonly. AllowNull.
		/// </summary>
		public decimal? ActualResourceHrs
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ActualResourceHrs; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ActualResourceHrs = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[WorkOrderRouting]. NotReadonly. NotNull.
		/// </summary>
		public decimal PlannedCost
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.PlannedCost; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.PlannedCost = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[WorkOrderRouting]. NotReadonly. AllowNull.
		/// </summary>
		public decimal? ActualCost
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ActualCost; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ActualCost = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[WorkOrderRouting]. NotReadonly. NotNull.
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
			this.InsertItem(index, new PriKey_Production_WorkOrderRouting_Record());
			this.CurrentRecordIndex = index;
		}

		public void Append(PriKey_Production_WorkOrderRouting_Record record)
		{
			int index = this.RecordCount;
			this.InsertItem(index, record);
			this.CurrentRecordIndex = index;
		}

		public PriKey_Production_WorkOrderRouting_Record NewRecord()
		{
			return new PriKey_Production_WorkOrderRouting_Record();
		}

		protected override PriKey_Production_WorkOrderRouting_Record InternalCreateExistingRecordObject(object[] columnvalues) => new PriKey_Production_WorkOrderRouting_Record(columnvalues);

		byte[] IRecordsetBase.Hash
		{
			get { return new byte[] { 45, 59, 170, 131, 89, 138, 26, 170, 23, 204, 244, 90, 166, 110, 84, 101 }; }
		}

		string IRecordsetBase.HashString
		{
			get { return "2D3BAA83598A1AAA17CCF45AA66E5465"; }
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

		public void SetExecSqlParams(int? WorkOrderID, int? ProductID, short? OperationSequence)
		{
			_inputparametervalues[0] = WorkOrderID;
			_inputparametervalues[1] = ProductID;
			_inputparametervalues[2] = OperationSequence;
		}

		public void ExecSql(int? WorkOrderID, int? ProductID, short? OperationSequence)
		{
			_inputparametervalues[0] = WorkOrderID;
			_inputparametervalues[1] = ProductID;
			_inputparametervalues[2] = OperationSequence;
			Transactional.ExecSql(VenturaSqlConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public void ExecSql(Connector connector, int? WorkOrderID, int? ProductID, short? OperationSequence)
		{
			_inputparametervalues[0] = WorkOrderID;
			_inputparametervalues[1] = ProductID;
			_inputparametervalues[2] = OperationSequence;
			Transactional.ExecSql(connector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync(int? WorkOrderID, int? ProductID, short? OperationSequence)
		{
			_inputparametervalues[0] = WorkOrderID;
			_inputparametervalues[1] = ProductID;
			_inputparametervalues[2] = OperationSequence;
			await Transactional.ExecSqlAsync(VenturaSqlConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync(Connector connector, int? WorkOrderID, int? ProductID, short? OperationSequence)
		{
			_inputparametervalues[0] = WorkOrderID;
			_inputparametervalues[1] = ProductID;
			_inputparametervalues[2] = OperationSequence;
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

			public int? WorkOrderID
			{
				get { return (int?)_values[0]; }
				set { _values[0] = value; }
			}

			public int? ProductID
			{
				get { return (int?)_values[1]; }
				set { _values[1] = value; }
			}

			public short? OperationSequence
			{
				get { return (short?)_values[2]; }
				set { _values[2] = value; }
			}

		}

	}

	public sealed partial class PriKey_Production_WorkOrderRouting_Record : IRecordBase, INotifyPropertyChanged
	{
		private DataRecordStatus _recordstatus;
		private bool _started_with_dbvalues;

		private int _cur__WorkOrderID; private int _ori__WorkOrderID; private bool _mod__WorkOrderID;
		private int _cur__ProductID; private int _ori__ProductID; private bool _mod__ProductID;
		private short _cur__OperationSequence; private short _ori__OperationSequence; private bool _mod__OperationSequence;
		private short _cur__LocationID; private short _ori__LocationID; private bool _mod__LocationID;
		private DateTime _cur__ScheduledStartDate; private DateTime _ori__ScheduledStartDate; private bool _mod__ScheduledStartDate;
		private DateTime _cur__ScheduledEndDate; private DateTime _ori__ScheduledEndDate; private bool _mod__ScheduledEndDate;
		private DateTime? _cur__ActualStartDate; private DateTime? _ori__ActualStartDate; private bool _mod__ActualStartDate;
		private DateTime? _cur__ActualEndDate; private DateTime? _ori__ActualEndDate; private bool _mod__ActualEndDate;
		private decimal? _cur__ActualResourceHrs; private decimal? _ori__ActualResourceHrs; private bool _mod__ActualResourceHrs;
		private decimal _cur__PlannedCost; private decimal _ori__PlannedCost; private bool _mod__PlannedCost;
		private decimal? _cur__ActualCost; private decimal? _ori__ActualCost; private bool _mod__ActualCost;
		private DateTime _cur__ModifiedDate; private DateTime _ori__ModifiedDate; private bool _mod__ModifiedDate;


		public PriKey_Production_WorkOrderRouting_Record()
		{
			_cur__WorkOrderID = 0;
			_cur__ProductID = 0;
			_cur__OperationSequence = 0;
			_cur__LocationID = 0;
			_cur__ScheduledStartDate = new DateTime(1900, 1, 1);
			_cur__ScheduledEndDate = new DateTime(1900, 1, 1);
			_cur__ActualStartDate = null;
			_cur__ActualEndDate = null;
			_cur__ActualResourceHrs = null;
			_cur__PlannedCost = 0.0m;
			_cur__ActualCost = null;
			_cur__ModifiedDate = new DateTime(1900, 1, 1);
			_started_with_dbvalues = false;
			_recordstatus = DataRecordStatus.New;
		}

		public PriKey_Production_WorkOrderRouting_Record(object[] columnvalues)
		{
			_cur__WorkOrderID = (int)columnvalues[0];
			_cur__ProductID = (int)columnvalues[1];
			_cur__OperationSequence = (short)columnvalues[2];
			_cur__LocationID = (short)columnvalues[3];
			_cur__ScheduledStartDate = (DateTime)columnvalues[4];
			_cur__ScheduledEndDate = (DateTime)columnvalues[5];
			_cur__ActualStartDate = (DateTime?)columnvalues[6];
			_cur__ActualEndDate = (DateTime?)columnvalues[7];
			_cur__ActualResourceHrs = (decimal?)columnvalues[8];
			_cur__PlannedCost = (decimal)columnvalues[9];
			_cur__ActualCost = (decimal?)columnvalues[10];
			_cur__ModifiedDate = (DateTime)columnvalues[11];
			_started_with_dbvalues = true;
			_recordstatus = DataRecordStatus.Existing;
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[WorkOrderRouting]. PrimaryKey. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [Production].[WorkOrderRouting]. PrimaryKey. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [Production].[WorkOrderRouting]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public short OperationSequence
		{
			get { return _cur__OperationSequence; }
			set
			{
				if (_started_with_dbvalues == false) _mod__OperationSequence = true;
				if (_cur__OperationSequence == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__OperationSequence == false) { _ori__OperationSequence = _cur__OperationSequence; _mod__OperationSequence = true; } // existing record and column is not modified
					else { if (value == _ori__OperationSequence) { _ori__OperationSequence = default(short); _mod__OperationSequence = false; } } // existing record and column is modified
				}
				_cur__OperationSequence = value; OnPropertyChanged("OperationSequence"); OnAfterPropertyChanged("OperationSequence");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[WorkOrderRouting]. NotReadonly. NotNull.
		/// </summary>
		public short LocationID
		{
			get { return _cur__LocationID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__LocationID = true;
				if (_cur__LocationID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__LocationID == false) { _ori__LocationID = _cur__LocationID; _mod__LocationID = true; } // existing record and column is not modified
					else { if (value == _ori__LocationID) { _ori__LocationID = default(short); _mod__LocationID = false; } } // existing record and column is modified
				}
				_cur__LocationID = value; OnPropertyChanged("LocationID"); OnAfterPropertyChanged("LocationID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[WorkOrderRouting]. NotReadonly. NotNull.
		/// </summary>
		public DateTime ScheduledStartDate
		{
			get { return _cur__ScheduledStartDate; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ScheduledStartDate = true;
				if (_cur__ScheduledStartDate == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ScheduledStartDate == false) { _ori__ScheduledStartDate = _cur__ScheduledStartDate; _mod__ScheduledStartDate = true; } // existing record and column is not modified
					else { if (value == _ori__ScheduledStartDate) { _ori__ScheduledStartDate = default(DateTime); _mod__ScheduledStartDate = false; } } // existing record and column is modified
				}
				_cur__ScheduledStartDate = value; OnPropertyChanged("ScheduledStartDate"); OnAfterPropertyChanged("ScheduledStartDate");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[WorkOrderRouting]. NotReadonly. NotNull.
		/// </summary>
		public DateTime ScheduledEndDate
		{
			get { return _cur__ScheduledEndDate; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ScheduledEndDate = true;
				if (_cur__ScheduledEndDate == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ScheduledEndDate == false) { _ori__ScheduledEndDate = _cur__ScheduledEndDate; _mod__ScheduledEndDate = true; } // existing record and column is not modified
					else { if (value == _ori__ScheduledEndDate) { _ori__ScheduledEndDate = default(DateTime); _mod__ScheduledEndDate = false; } } // existing record and column is modified
				}
				_cur__ScheduledEndDate = value; OnPropertyChanged("ScheduledEndDate"); OnAfterPropertyChanged("ScheduledEndDate");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[WorkOrderRouting]. NotReadonly. AllowNull.
		/// </summary>
		public DateTime? ActualStartDate
		{
			get { return _cur__ActualStartDate; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ActualStartDate = true;
				if (_cur__ActualStartDate == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ActualStartDate == false) { _ori__ActualStartDate = _cur__ActualStartDate; _mod__ActualStartDate = true; } // existing record and column is not modified
					else { if (value == _ori__ActualStartDate) { _ori__ActualStartDate = default(DateTime?); _mod__ActualStartDate = false; } } // existing record and column is modified
				}
				_cur__ActualStartDate = value; OnPropertyChanged("ActualStartDate"); OnAfterPropertyChanged("ActualStartDate");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[WorkOrderRouting]. NotReadonly. AllowNull.
		/// </summary>
		public DateTime? ActualEndDate
		{
			get { return _cur__ActualEndDate; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ActualEndDate = true;
				if (_cur__ActualEndDate == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ActualEndDate == false) { _ori__ActualEndDate = _cur__ActualEndDate; _mod__ActualEndDate = true; } // existing record and column is not modified
					else { if (value == _ori__ActualEndDate) { _ori__ActualEndDate = default(DateTime?); _mod__ActualEndDate = false; } } // existing record and column is modified
				}
				_cur__ActualEndDate = value; OnPropertyChanged("ActualEndDate"); OnAfterPropertyChanged("ActualEndDate");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[WorkOrderRouting]. NotReadonly. AllowNull.
		/// </summary>
		public decimal? ActualResourceHrs
		{
			get { return _cur__ActualResourceHrs; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ActualResourceHrs = true;
				if (_cur__ActualResourceHrs == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ActualResourceHrs == false) { _ori__ActualResourceHrs = _cur__ActualResourceHrs; _mod__ActualResourceHrs = true; } // existing record and column is not modified
					else { if (value == _ori__ActualResourceHrs) { _ori__ActualResourceHrs = default(decimal?); _mod__ActualResourceHrs = false; } } // existing record and column is modified
				}
				_cur__ActualResourceHrs = value; OnPropertyChanged("ActualResourceHrs"); OnAfterPropertyChanged("ActualResourceHrs");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[WorkOrderRouting]. NotReadonly. NotNull.
		/// </summary>
		public decimal PlannedCost
		{
			get { return _cur__PlannedCost; }
			set
			{
				if (_started_with_dbvalues == false) _mod__PlannedCost = true;
				if (_cur__PlannedCost == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__PlannedCost == false) { _ori__PlannedCost = _cur__PlannedCost; _mod__PlannedCost = true; } // existing record and column is not modified
					else { if (value == _ori__PlannedCost) { _ori__PlannedCost = default(decimal); _mod__PlannedCost = false; } } // existing record and column is modified
				}
				_cur__PlannedCost = value; OnPropertyChanged("PlannedCost"); OnAfterPropertyChanged("PlannedCost");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[WorkOrderRouting]. NotReadonly. AllowNull.
		/// </summary>
		public decimal? ActualCost
		{
			get { return _cur__ActualCost; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ActualCost = true;
				if (_cur__ActualCost == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ActualCost == false) { _ori__ActualCost = _cur__ActualCost; _mod__ActualCost = true; } // existing record and column is not modified
					else { if (value == _ori__ActualCost) { _ori__ActualCost = default(decimal?); _mod__ActualCost = false; } } // existing record and column is modified
				}
				_cur__ActualCost = value; OnPropertyChanged("ActualCost"); OnAfterPropertyChanged("ActualCost");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[WorkOrderRouting]. NotReadonly. NotNull.
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
			if (column_name == "OperationSequence") return _mod__OperationSequence;
			if (column_name == "LocationID") return _mod__LocationID;
			if (column_name == "ScheduledStartDate") return _mod__ScheduledStartDate;
			if (column_name == "ScheduledEndDate") return _mod__ScheduledEndDate;
			if (column_name == "ActualStartDate") return _mod__ActualStartDate;
			if (column_name == "ActualEndDate") return _mod__ActualEndDate;
			if (column_name == "ActualResourceHrs") return _mod__ActualResourceHrs;
			if (column_name == "PlannedCost") return _mod__PlannedCost;
			if (column_name == "ActualCost") return _mod__ActualCost;
			if (column_name == "ModifiedDate") return _mod__ModifiedDate;
			throw new ArgumentOutOfRangeException(String.Format(VenturaSqlStrings.UNKNOWN_COLUMN_NAME, column_name));
		}

		public int ModifiedColumnCount()
		{
			int count = 0;
			if (_mod__WorkOrderID == true) count++;
			if (_mod__ProductID == true) count++;
			if (_mod__OperationSequence == true) count++;
			if (_mod__LocationID == true) count++;
			if (_mod__ScheduledStartDate == true) count++;
			if (_mod__ScheduledEndDate == true) count++;
			if (_mod__ActualStartDate == true) count++;
			if (_mod__ActualEndDate == true) count++;
			if (_mod__ActualResourceHrs == true) count++;
			if (_mod__PlannedCost == true) count++;
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
				if (_mod__WorkOrderID) count++;
				if (_mod__ProductID) count++;
				if (_mod__OperationSequence) count++;
			}
			if (_mod__LocationID == true) count++;
			if (_mod__ScheduledStartDate == true) count++;
			if (_mod__ScheduledEndDate == true) count++;
			if (_mod__ActualStartDate == true) count++;
			if (_mod__ActualEndDate == true) count++;
			if (_mod__ActualResourceHrs == true) count++;
			if (_mod__PlannedCost == true) count++;
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
			if (_mod__WorkOrderID == false) throw new Exception(string.Format(VenturaSqlStrings.VALUE_NOT_SET_MSG, record_index_to_display, "WorkOrderID"));
			if (_mod__ProductID == false) throw new Exception(string.Format(VenturaSqlStrings.VALUE_NOT_SET_MSG, record_index_to_display, "ProductID"));
			if (_mod__OperationSequence == false) throw new Exception(string.Format(VenturaSqlStrings.VALUE_NOT_SET_MSG, record_index_to_display, "OperationSequence"));
		}

		void IRecordBase.WriteChangesToTrackArray(TrackArray track_array)
		{
			if (_recordstatus == DataRecordStatus.New)
			{
				track_array.AppendDataValue(0, _cur__WorkOrderID);
				track_array.AppendDataValue(1, _cur__ProductID);
				track_array.AppendDataValue(2, _cur__OperationSequence);
				track_array.AppendDataValue(3, _cur__LocationID);
				track_array.AppendDataValue(4, _cur__ScheduledStartDate);
				track_array.AppendDataValue(5, _cur__ScheduledEndDate);
				if (_cur__ActualStartDate != null) track_array.AppendDataValue(6, _cur__ActualStartDate);
				if (_cur__ActualEndDate != null) track_array.AppendDataValue(7, _cur__ActualEndDate);
				if (_cur__ActualResourceHrs != null) track_array.AppendDataValue(8, _cur__ActualResourceHrs);
				track_array.AppendDataValue(9, _cur__PlannedCost);
				if (_cur__ActualCost != null) track_array.AppendDataValue(10, _cur__ActualCost);
				track_array.AppendDataValue(11, _cur__ModifiedDate);
			}
			else if (_recordstatus == DataRecordStatus.Existing)
			{
				if (_started_with_dbvalues)
				{
					if (_mod__WorkOrderID) track_array.AppendDataValue(0, _cur__WorkOrderID);
					if (_mod__ProductID) track_array.AppendDataValue(1, _cur__ProductID);
					if (_mod__OperationSequence) track_array.AppendDataValue(2, _cur__OperationSequence);
				}
				if (_mod__LocationID) track_array.AppendDataValue(3, _cur__LocationID);
				if (_mod__ScheduledStartDate) track_array.AppendDataValue(4, _cur__ScheduledStartDate);
				if (_mod__ScheduledEndDate) track_array.AppendDataValue(5, _cur__ScheduledEndDate);
				if (_mod__ActualStartDate) track_array.AppendDataValue(6, _cur__ActualStartDate);
				if (_mod__ActualEndDate) track_array.AppendDataValue(7, _cur__ActualEndDate);
				if (_mod__ActualResourceHrs) track_array.AppendDataValue(8, _cur__ActualResourceHrs);
				if (_mod__PlannedCost) track_array.AppendDataValue(9, _cur__PlannedCost);
				if (_mod__ActualCost) track_array.AppendDataValue(10, _cur__ActualCost);
				if (_mod__ModifiedDate) track_array.AppendDataValue(11, _cur__ModifiedDate);
				if (track_array.HasData == false) return;
			}

			if (_recordstatus == DataRecordStatus.Existing || _recordstatus == DataRecordStatus.ExistingDelete)
			{
				track_array.AppendPrikeyValue(0, (_mod__WorkOrderID && _started_with_dbvalues) ? _ori__WorkOrderID : _cur__WorkOrderID);
				track_array.AppendPrikeyValue(1, (_mod__ProductID && _started_with_dbvalues) ? _ori__ProductID : _cur__ProductID);
				track_array.AppendPrikeyValue(2, (_mod__OperationSequence && _started_with_dbvalues) ? _ori__OperationSequence : _cur__OperationSequence);
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
				if (_mod__OperationSequence) _ori__OperationSequence = default(short);
				if (_mod__LocationID) _ori__LocationID = default(short);
				if (_mod__ScheduledStartDate) _ori__ScheduledStartDate = default(DateTime);
				if (_mod__ScheduledEndDate) _ori__ScheduledEndDate = default(DateTime);
				if (_mod__ActualStartDate) _ori__ActualStartDate = default(DateTime?);
				if (_mod__ActualEndDate) _ori__ActualEndDate = default(DateTime?);
				if (_mod__ActualResourceHrs) _ori__ActualResourceHrs = default(decimal?);
				if (_mod__PlannedCost) _ori__PlannedCost = default(decimal);
				if (_mod__ActualCost) _ori__ActualCost = default(decimal?);
				if (_mod__ModifiedDate) _ori__ModifiedDate = default(DateTime);
			}
			_mod__WorkOrderID = false;
			_mod__ProductID = false;
			_mod__OperationSequence = false;
			_mod__LocationID = false;
			_mod__ScheduledStartDate = false;
			_mod__ScheduledEndDate = false;
			_mod__ActualStartDate = false;
			_mod__ActualEndDate = false;
			_mod__ActualResourceHrs = false;
			_mod__PlannedCost = false;
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
namespace WpfClient.VenturaAutoCreate
{
	public partial class PriKey_Production_WorkOrderRouting_Record
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
