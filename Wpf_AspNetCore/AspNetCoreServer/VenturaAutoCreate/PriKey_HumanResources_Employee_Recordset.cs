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
	/// The updateable table is [HumanResources].[Employee]. Updateable table column information:
	/// • 16 out of 16 table columns are present in the resultset.
	/// • All primary key columns are present in the resultset: BusinessEntityID.
	/// • Non-primary key columns present in the resultset: NationalIDNumber, LoginID, OrganizationNode, OrganizationLevel,
	///   JobTitle, BirthDate, MaritalStatus, Gender, HireDate, SalariedFlag, VacationHours, SickLeaveHours, CurrentFlag, rowguid
	///   and ModifiedDate.
	/// Recordset item automatically created by VenturaSQL Studio.
	/// </summary>
	public partial class PriKey_HumanResources_Employee_Recordset : ResultsetObservable<PriKey_HumanResources_Employee_Recordset, PriKey_HumanResources_Employee_Record>, IRecordsetBase
	{
		private IResultsetBase[] _resultsets;
		private string _sqlscript;
		private object[] _inputparametervalues;
		private InputParamHolder _inputparamholder;
		private VenturaSqlSchema _parameterschema;
		private int _rowlimit = 500;
		private const string CRLF = "\r\n";

		public PriKey_HumanResources_Employee_Recordset()
		{
			_resultsets = new IResultsetBase[] { this };

			_sqlscript = @"SELECT [BusinessEntityID],[NationalIDNumber],[LoginID],[OrganizationNode],[OrganizationLevel],[JobTitle],[BirthDate],[MaritalStatus],[Gender],[HireDate]," + CRLF +
			             @"[SalariedFlag],[VacationHours],[SickLeaveHours],[CurrentFlag],[rowguid],[ModifiedDate]" + CRLF +
			             @"FROM [HumanResources].[Employee]" + CRLF +
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
				BaseSchemaName = "HumanResources",
				BaseTableName = "Employee",
				BaseColumnName = "BusinessEntityID"
			});

			schema_array.Add(new VenturaSqlColumn("NationalIDNumber", typeof(string), false)
			{
				Updateable = true,
				ColumnSize = 15,
				ProviderType = 12,
				BaseSchemaName = "HumanResources",
				BaseTableName = "Employee",
				BaseColumnName = "NationalIDNumber"
			});

			schema_array.Add(new VenturaSqlColumn("LoginID", typeof(string), false)
			{
				Updateable = true,
				ColumnSize = 256,
				ProviderType = 12,
				BaseSchemaName = "HumanResources",
				BaseTableName = "Employee",
				BaseColumnName = "LoginID"
			});

			schema_array.Add(new VenturaSqlColumn("OrganizationNode", typeof(object), true)
			{
				Updateable = true,
				ColumnSize = 892,
				ProviderType = 29,
				UdtAssemblyQualifiedName = "Microsoft.SqlServer.Types.SqlHierarchyId, Microsoft.SqlServer.Types, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91",
				BaseSchemaName = "HumanResources",
				BaseTableName = "Employee",
				BaseColumnName = "OrganizationNode"
			});

			schema_array.Add(new VenturaSqlColumn("OrganizationLevel", typeof(short), true)
			{
				Updateable = true,
				ColumnSize = 2,
				NumericPrecision = 5,
				ProviderType = 16,
				BaseSchemaName = "HumanResources",
				BaseTableName = "Employee",
				BaseColumnName = "OrganizationLevel"
			});

			schema_array.Add(new VenturaSqlColumn("JobTitle", typeof(string), false)
			{
				Updateable = true,
				ColumnSize = 50,
				ProviderType = 12,
				BaseSchemaName = "HumanResources",
				BaseTableName = "Employee",
				BaseColumnName = "JobTitle"
			});

			schema_array.Add(new VenturaSqlColumn("BirthDate", typeof(DateTime), false)
			{
				Updateable = true,
				ColumnSize = 3,
				ProviderType = 31,
				BaseSchemaName = "HumanResources",
				BaseTableName = "Employee",
				BaseColumnName = "BirthDate"
			});

			schema_array.Add(new VenturaSqlColumn("MaritalStatus", typeof(string), false)
			{
				Updateable = true,
				ColumnSize = 1,
				ProviderType = 10,
				BaseSchemaName = "HumanResources",
				BaseTableName = "Employee",
				BaseColumnName = "MaritalStatus"
			});

			schema_array.Add(new VenturaSqlColumn("Gender", typeof(string), false)
			{
				Updateable = true,
				ColumnSize = 1,
				ProviderType = 10,
				BaseSchemaName = "HumanResources",
				BaseTableName = "Employee",
				BaseColumnName = "Gender"
			});

			schema_array.Add(new VenturaSqlColumn("HireDate", typeof(DateTime), false)
			{
				Updateable = true,
				ColumnSize = 3,
				ProviderType = 31,
				BaseSchemaName = "HumanResources",
				BaseTableName = "Employee",
				BaseColumnName = "HireDate"
			});

			schema_array.Add(new VenturaSqlColumn("SalariedFlag", typeof(bool), false)
			{
				Updateable = true,
				ColumnSize = 1,
				ProviderType = 2,
				BaseSchemaName = "HumanResources",
				BaseTableName = "Employee",
				BaseColumnName = "SalariedFlag"
			});

			schema_array.Add(new VenturaSqlColumn("VacationHours", typeof(short), false)
			{
				Updateable = true,
				ColumnSize = 2,
				NumericPrecision = 5,
				ProviderType = 16,
				BaseSchemaName = "HumanResources",
				BaseTableName = "Employee",
				BaseColumnName = "VacationHours"
			});

			schema_array.Add(new VenturaSqlColumn("SickLeaveHours", typeof(short), false)
			{
				Updateable = true,
				ColumnSize = 2,
				NumericPrecision = 5,
				ProviderType = 16,
				BaseSchemaName = "HumanResources",
				BaseTableName = "Employee",
				BaseColumnName = "SickLeaveHours"
			});

			schema_array.Add(new VenturaSqlColumn("CurrentFlag", typeof(bool), false)
			{
				Updateable = true,
				ColumnSize = 1,
				ProviderType = 2,
				BaseSchemaName = "HumanResources",
				BaseTableName = "Employee",
				BaseColumnName = "CurrentFlag"
			});

			schema_array.Add(new VenturaSqlColumn("rowguid", typeof(Guid), false)
			{
				Updateable = true,
				ColumnSize = 16,
				ProviderType = 14,
				BaseSchemaName = "HumanResources",
				BaseTableName = "Employee",
				BaseColumnName = "rowguid"
			});

			schema_array.Add(new VenturaSqlColumn("ModifiedDate", typeof(DateTime), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 23,
				NumericScale = 3,
				ProviderType = 4,
				BaseSchemaName = "HumanResources",
				BaseTableName = "Employee",
				BaseColumnName = "ModifiedDate"
			});

			((IResultsetBase)this).Schema = new VenturaSqlSchema(schema_array);
			((IResultsetBase)this).UpdateableTablename = "[HumanResources].[Employee]";
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[Employee]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public int BusinessEntityID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.BusinessEntityID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.BusinessEntityID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[Employee]. NotReadonly. NotNull.
		/// </summary>
		public string NationalIDNumber
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.NationalIDNumber; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.NationalIDNumber = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[Employee]. NotReadonly. NotNull.
		/// </summary>
		public string LoginID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.LoginID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.LoginID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[Employee]. NotReadonly. AllowNull.
		/// </summary>
		public object OrganizationNode
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.OrganizationNode; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.OrganizationNode = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[Employee]. NotReadonly. AllowNull.
		/// </summary>
		public short? OrganizationLevel
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.OrganizationLevel; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.OrganizationLevel = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[Employee]. NotReadonly. NotNull.
		/// </summary>
		public string JobTitle
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.JobTitle; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.JobTitle = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[Employee]. NotReadonly. NotNull.
		/// </summary>
		public DateTime BirthDate
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.BirthDate; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.BirthDate = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[Employee]. NotReadonly. NotNull.
		/// </summary>
		public string MaritalStatus
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.MaritalStatus; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.MaritalStatus = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[Employee]. NotReadonly. NotNull.
		/// </summary>
		public string Gender
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Gender; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Gender = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[Employee]. NotReadonly. NotNull.
		/// </summary>
		public DateTime HireDate
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.HireDate; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.HireDate = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[Employee]. NotReadonly. NotNull.
		/// </summary>
		public bool SalariedFlag
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.SalariedFlag; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.SalariedFlag = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[Employee]. NotReadonly. NotNull.
		/// </summary>
		public short VacationHours
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.VacationHours; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.VacationHours = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[Employee]. NotReadonly. NotNull.
		/// </summary>
		public short SickLeaveHours
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.SickLeaveHours; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.SickLeaveHours = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[Employee]. NotReadonly. NotNull.
		/// </summary>
		public bool CurrentFlag
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.CurrentFlag; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.CurrentFlag = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[Employee]. NotReadonly. NotNull.
		/// </summary>
		public Guid rowguid
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.rowguid; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.rowguid = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[Employee]. NotReadonly. NotNull.
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
			this.InsertItem(index, new PriKey_HumanResources_Employee_Record());
			this.CurrentRecordIndex = index;
		}

		public void Append(PriKey_HumanResources_Employee_Record record)
		{
			int index = this.RecordCount;
			this.InsertItem(index, record);
			this.CurrentRecordIndex = index;
		}

		public PriKey_HumanResources_Employee_Record NewRecord()
		{
			return new PriKey_HumanResources_Employee_Record();
		}

		protected override PriKey_HumanResources_Employee_Record InternalCreateExistingRecordObject(object[] columnvalues) => new PriKey_HumanResources_Employee_Record(columnvalues);

		byte[] IRecordsetBase.Hash
		{
			get { return new byte[] { 237, 231, 96, 151, 59, 236, 184, 71, 52, 8, 89, 167, 84, 6, 210, 162 }; }
		}

		string IRecordsetBase.HashString
		{
			get { return "EDE760973BECB847340859A75406D2A2"; }
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

	public sealed partial class PriKey_HumanResources_Employee_Record : IRecordBase, INotifyPropertyChanged
	{
		private DataRecordStatus _recordstatus;
		private bool _started_with_dbvalues;

		private int _cur__BusinessEntityID; private int _ori__BusinessEntityID; private bool _mod__BusinessEntityID;
		private string _cur__NationalIDNumber; private string _ori__NationalIDNumber; private bool _mod__NationalIDNumber;
		private string _cur__LoginID; private string _ori__LoginID; private bool _mod__LoginID;
		private object _cur__OrganizationNode; private object _ori__OrganizationNode; private bool _mod__OrganizationNode;
		private short? _cur__OrganizationLevel; private short? _ori__OrganizationLevel; private bool _mod__OrganizationLevel;
		private string _cur__JobTitle; private string _ori__JobTitle; private bool _mod__JobTitle;
		private DateTime _cur__BirthDate; private DateTime _ori__BirthDate; private bool _mod__BirthDate;
		private string _cur__MaritalStatus; private string _ori__MaritalStatus; private bool _mod__MaritalStatus;
		private string _cur__Gender; private string _ori__Gender; private bool _mod__Gender;
		private DateTime _cur__HireDate; private DateTime _ori__HireDate; private bool _mod__HireDate;
		private bool _cur__SalariedFlag; private bool _ori__SalariedFlag; private bool _mod__SalariedFlag;
		private short _cur__VacationHours; private short _ori__VacationHours; private bool _mod__VacationHours;
		private short _cur__SickLeaveHours; private short _ori__SickLeaveHours; private bool _mod__SickLeaveHours;
		private bool _cur__CurrentFlag; private bool _ori__CurrentFlag; private bool _mod__CurrentFlag;
		private Guid _cur__rowguid; private Guid _ori__rowguid; private bool _mod__rowguid;
		private DateTime _cur__ModifiedDate; private DateTime _ori__ModifiedDate; private bool _mod__ModifiedDate;


		public PriKey_HumanResources_Employee_Record()
		{
			_cur__BusinessEntityID = 0;
			_cur__NationalIDNumber = "";
			_cur__LoginID = "";
			_cur__OrganizationNode = null;
			_cur__OrganizationLevel = null;
			_cur__JobTitle = "";
			_cur__BirthDate = new DateTime(1900, 1, 1);
			_cur__MaritalStatus = "";
			_cur__Gender = "";
			_cur__HireDate = new DateTime(1900, 1, 1);
			_cur__SalariedFlag = false;
			_cur__VacationHours = 0;
			_cur__SickLeaveHours = 0;
			_cur__CurrentFlag = false;
			_cur__rowguid = Guid.Empty;
			_cur__ModifiedDate = new DateTime(1900, 1, 1);
			_started_with_dbvalues = false;
			_recordstatus = DataRecordStatus.New;
		}

		public PriKey_HumanResources_Employee_Record(object[] columnvalues)
		{
			_cur__BusinessEntityID = (int)columnvalues[0];
			_cur__NationalIDNumber = (string)columnvalues[1];
			_cur__LoginID = (string)columnvalues[2];
			_cur__OrganizationNode = (object)columnvalues[3];
			_cur__OrganizationLevel = (short?)columnvalues[4];
			_cur__JobTitle = (string)columnvalues[5];
			_cur__BirthDate = (DateTime)columnvalues[6];
			_cur__MaritalStatus = (string)columnvalues[7];
			_cur__Gender = (string)columnvalues[8];
			_cur__HireDate = (DateTime)columnvalues[9];
			_cur__SalariedFlag = (bool)columnvalues[10];
			_cur__VacationHours = (short)columnvalues[11];
			_cur__SickLeaveHours = (short)columnvalues[12];
			_cur__CurrentFlag = (bool)columnvalues[13];
			_cur__rowguid = (Guid)columnvalues[14];
			_cur__ModifiedDate = (DateTime)columnvalues[15];
			_started_with_dbvalues = true;
			_recordstatus = DataRecordStatus.Existing;
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[Employee]. PrimaryKey. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [HumanResources].[Employee]. NotReadonly. NotNull.
		/// </summary>
		public string NationalIDNumber
		{
			get { return _cur__NationalIDNumber; }
			set
			{
				if (value == null) throw new ArgumentNullException("NationalIDNumber", VenturaSqlStrings.SET_NULL_MSG);
				if (_started_with_dbvalues == false) _mod__NationalIDNumber = true;
				if (_cur__NationalIDNumber == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__NationalIDNumber == false) { _ori__NationalIDNumber = _cur__NationalIDNumber; _mod__NationalIDNumber = true; } // existing record and column is not modified
					else { if (value == _ori__NationalIDNumber) { _ori__NationalIDNumber = default(string); _mod__NationalIDNumber = false; } } // existing record and column is modified
				}
				_cur__NationalIDNumber = value; OnPropertyChanged("NationalIDNumber"); OnAfterPropertyChanged("NationalIDNumber");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[Employee]. NotReadonly. NotNull.
		/// </summary>
		public string LoginID
		{
			get { return _cur__LoginID; }
			set
			{
				if (value == null) throw new ArgumentNullException("LoginID", VenturaSqlStrings.SET_NULL_MSG);
				if (_started_with_dbvalues == false) _mod__LoginID = true;
				if (_cur__LoginID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__LoginID == false) { _ori__LoginID = _cur__LoginID; _mod__LoginID = true; } // existing record and column is not modified
					else { if (value == _ori__LoginID) { _ori__LoginID = default(string); _mod__LoginID = false; } } // existing record and column is modified
				}
				_cur__LoginID = value; OnPropertyChanged("LoginID"); OnAfterPropertyChanged("LoginID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[Employee]. NotReadonly. AllowNull.
		/// </summary>
		public object OrganizationNode
		{
			get { return _cur__OrganizationNode; }
			set
			{
				if (_started_with_dbvalues == false) _mod__OrganizationNode = true;
				if (_cur__OrganizationNode == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__OrganizationNode == false) { _ori__OrganizationNode = _cur__OrganizationNode; _mod__OrganizationNode = true; } // existing record and column is not modified
					else { if (value == _ori__OrganizationNode) { _ori__OrganizationNode = default(object); _mod__OrganizationNode = false; } } // existing record and column is modified
				}
				_cur__OrganizationNode = value; OnPropertyChanged("OrganizationNode"); OnAfterPropertyChanged("OrganizationNode");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[Employee]. NotReadonly. AllowNull.
		/// </summary>
		public short? OrganizationLevel
		{
			get { return _cur__OrganizationLevel; }
			set
			{
				if (_started_with_dbvalues == false) _mod__OrganizationLevel = true;
				if (_cur__OrganizationLevel == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__OrganizationLevel == false) { _ori__OrganizationLevel = _cur__OrganizationLevel; _mod__OrganizationLevel = true; } // existing record and column is not modified
					else { if (value == _ori__OrganizationLevel) { _ori__OrganizationLevel = default(short?); _mod__OrganizationLevel = false; } } // existing record and column is modified
				}
				_cur__OrganizationLevel = value; OnPropertyChanged("OrganizationLevel"); OnAfterPropertyChanged("OrganizationLevel");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[Employee]. NotReadonly. NotNull.
		/// </summary>
		public string JobTitle
		{
			get { return _cur__JobTitle; }
			set
			{
				if (value == null) throw new ArgumentNullException("JobTitle", VenturaSqlStrings.SET_NULL_MSG);
				if (_started_with_dbvalues == false) _mod__JobTitle = true;
				if (_cur__JobTitle == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__JobTitle == false) { _ori__JobTitle = _cur__JobTitle; _mod__JobTitle = true; } // existing record and column is not modified
					else { if (value == _ori__JobTitle) { _ori__JobTitle = default(string); _mod__JobTitle = false; } } // existing record and column is modified
				}
				_cur__JobTitle = value; OnPropertyChanged("JobTitle"); OnAfterPropertyChanged("JobTitle");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[Employee]. NotReadonly. NotNull.
		/// </summary>
		public DateTime BirthDate
		{
			get { return _cur__BirthDate; }
			set
			{
				if (_started_with_dbvalues == false) _mod__BirthDate = true;
				if (_cur__BirthDate == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__BirthDate == false) { _ori__BirthDate = _cur__BirthDate; _mod__BirthDate = true; } // existing record and column is not modified
					else { if (value == _ori__BirthDate) { _ori__BirthDate = default(DateTime); _mod__BirthDate = false; } } // existing record and column is modified
				}
				_cur__BirthDate = value; OnPropertyChanged("BirthDate"); OnAfterPropertyChanged("BirthDate");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[Employee]. NotReadonly. NotNull.
		/// </summary>
		public string MaritalStatus
		{
			get { return _cur__MaritalStatus; }
			set
			{
				if (value == null) throw new ArgumentNullException("MaritalStatus", VenturaSqlStrings.SET_NULL_MSG);
				if (_started_with_dbvalues == false) _mod__MaritalStatus = true;
				if (_cur__MaritalStatus == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__MaritalStatus == false) { _ori__MaritalStatus = _cur__MaritalStatus; _mod__MaritalStatus = true; } // existing record and column is not modified
					else { if (value == _ori__MaritalStatus) { _ori__MaritalStatus = default(string); _mod__MaritalStatus = false; } } // existing record and column is modified
				}
				_cur__MaritalStatus = value; OnPropertyChanged("MaritalStatus"); OnAfterPropertyChanged("MaritalStatus");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[Employee]. NotReadonly. NotNull.
		/// </summary>
		public string Gender
		{
			get { return _cur__Gender; }
			set
			{
				if (value == null) throw new ArgumentNullException("Gender", VenturaSqlStrings.SET_NULL_MSG);
				if (_started_with_dbvalues == false) _mod__Gender = true;
				if (_cur__Gender == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Gender == false) { _ori__Gender = _cur__Gender; _mod__Gender = true; } // existing record and column is not modified
					else { if (value == _ori__Gender) { _ori__Gender = default(string); _mod__Gender = false; } } // existing record and column is modified
				}
				_cur__Gender = value; OnPropertyChanged("Gender"); OnAfterPropertyChanged("Gender");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[Employee]. NotReadonly. NotNull.
		/// </summary>
		public DateTime HireDate
		{
			get { return _cur__HireDate; }
			set
			{
				if (_started_with_dbvalues == false) _mod__HireDate = true;
				if (_cur__HireDate == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__HireDate == false) { _ori__HireDate = _cur__HireDate; _mod__HireDate = true; } // existing record and column is not modified
					else { if (value == _ori__HireDate) { _ori__HireDate = default(DateTime); _mod__HireDate = false; } } // existing record and column is modified
				}
				_cur__HireDate = value; OnPropertyChanged("HireDate"); OnAfterPropertyChanged("HireDate");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[Employee]. NotReadonly. NotNull.
		/// </summary>
		public bool SalariedFlag
		{
			get { return _cur__SalariedFlag; }
			set
			{
				if (_started_with_dbvalues == false) _mod__SalariedFlag = true;
				if (_cur__SalariedFlag == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__SalariedFlag == false) { _ori__SalariedFlag = _cur__SalariedFlag; _mod__SalariedFlag = true; } // existing record and column is not modified
					else { if (value == _ori__SalariedFlag) { _ori__SalariedFlag = default(bool); _mod__SalariedFlag = false; } } // existing record and column is modified
				}
				_cur__SalariedFlag = value; OnPropertyChanged("SalariedFlag"); OnAfterPropertyChanged("SalariedFlag");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[Employee]. NotReadonly. NotNull.
		/// </summary>
		public short VacationHours
		{
			get { return _cur__VacationHours; }
			set
			{
				if (_started_with_dbvalues == false) _mod__VacationHours = true;
				if (_cur__VacationHours == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__VacationHours == false) { _ori__VacationHours = _cur__VacationHours; _mod__VacationHours = true; } // existing record and column is not modified
					else { if (value == _ori__VacationHours) { _ori__VacationHours = default(short); _mod__VacationHours = false; } } // existing record and column is modified
				}
				_cur__VacationHours = value; OnPropertyChanged("VacationHours"); OnAfterPropertyChanged("VacationHours");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[Employee]. NotReadonly. NotNull.
		/// </summary>
		public short SickLeaveHours
		{
			get { return _cur__SickLeaveHours; }
			set
			{
				if (_started_with_dbvalues == false) _mod__SickLeaveHours = true;
				if (_cur__SickLeaveHours == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__SickLeaveHours == false) { _ori__SickLeaveHours = _cur__SickLeaveHours; _mod__SickLeaveHours = true; } // existing record and column is not modified
					else { if (value == _ori__SickLeaveHours) { _ori__SickLeaveHours = default(short); _mod__SickLeaveHours = false; } } // existing record and column is modified
				}
				_cur__SickLeaveHours = value; OnPropertyChanged("SickLeaveHours"); OnAfterPropertyChanged("SickLeaveHours");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[Employee]. NotReadonly. NotNull.
		/// </summary>
		public bool CurrentFlag
		{
			get { return _cur__CurrentFlag; }
			set
			{
				if (_started_with_dbvalues == false) _mod__CurrentFlag = true;
				if (_cur__CurrentFlag == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__CurrentFlag == false) { _ori__CurrentFlag = _cur__CurrentFlag; _mod__CurrentFlag = true; } // existing record and column is not modified
					else { if (value == _ori__CurrentFlag) { _ori__CurrentFlag = default(bool); _mod__CurrentFlag = false; } } // existing record and column is modified
				}
				_cur__CurrentFlag = value; OnPropertyChanged("CurrentFlag"); OnAfterPropertyChanged("CurrentFlag");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[Employee]. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [HumanResources].[Employee]. NotReadonly. NotNull.
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
			if (column_name == "NationalIDNumber") return _mod__NationalIDNumber;
			if (column_name == "LoginID") return _mod__LoginID;
			if (column_name == "OrganizationNode") return _mod__OrganizationNode;
			if (column_name == "OrganizationLevel") return _mod__OrganizationLevel;
			if (column_name == "JobTitle") return _mod__JobTitle;
			if (column_name == "BirthDate") return _mod__BirthDate;
			if (column_name == "MaritalStatus") return _mod__MaritalStatus;
			if (column_name == "Gender") return _mod__Gender;
			if (column_name == "HireDate") return _mod__HireDate;
			if (column_name == "SalariedFlag") return _mod__SalariedFlag;
			if (column_name == "VacationHours") return _mod__VacationHours;
			if (column_name == "SickLeaveHours") return _mod__SickLeaveHours;
			if (column_name == "CurrentFlag") return _mod__CurrentFlag;
			if (column_name == "rowguid") return _mod__rowguid;
			if (column_name == "ModifiedDate") return _mod__ModifiedDate;
			throw new ArgumentOutOfRangeException(String.Format(VenturaSqlStrings.UNKNOWN_COLUMN_NAME, column_name));
		}

		public int ModifiedColumnCount()
		{
			int count = 0;
			if (_mod__BusinessEntityID == true) count++;
			if (_mod__NationalIDNumber == true) count++;
			if (_mod__LoginID == true) count++;
			if (_mod__OrganizationNode == true) count++;
			if (_mod__OrganizationLevel == true) count++;
			if (_mod__JobTitle == true) count++;
			if (_mod__BirthDate == true) count++;
			if (_mod__MaritalStatus == true) count++;
			if (_mod__Gender == true) count++;
			if (_mod__HireDate == true) count++;
			if (_mod__SalariedFlag == true) count++;
			if (_mod__VacationHours == true) count++;
			if (_mod__SickLeaveHours == true) count++;
			if (_mod__CurrentFlag == true) count++;
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
			if (_mod__NationalIDNumber == true) count++;
			if (_mod__LoginID == true) count++;
			if (_mod__OrganizationNode == true) count++;
			if (_mod__OrganizationLevel == true) count++;
			if (_mod__JobTitle == true) count++;
			if (_mod__BirthDate == true) count++;
			if (_mod__MaritalStatus == true) count++;
			if (_mod__Gender == true) count++;
			if (_mod__HireDate == true) count++;
			if (_mod__SalariedFlag == true) count++;
			if (_mod__VacationHours == true) count++;
			if (_mod__SickLeaveHours == true) count++;
			if (_mod__CurrentFlag == true) count++;
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
				track_array.AppendDataValue(1, _cur__NationalIDNumber);
				track_array.AppendDataValue(2, _cur__LoginID);
				if (_cur__OrganizationNode != null) track_array.AppendDataValue(3, _cur__OrganizationNode);
				if (_cur__OrganizationLevel != null) track_array.AppendDataValue(4, _cur__OrganizationLevel);
				track_array.AppendDataValue(5, _cur__JobTitle);
				track_array.AppendDataValue(6, _cur__BirthDate);
				track_array.AppendDataValue(7, _cur__MaritalStatus);
				track_array.AppendDataValue(8, _cur__Gender);
				track_array.AppendDataValue(9, _cur__HireDate);
				track_array.AppendDataValue(10, _cur__SalariedFlag);
				track_array.AppendDataValue(11, _cur__VacationHours);
				track_array.AppendDataValue(12, _cur__SickLeaveHours);
				track_array.AppendDataValue(13, _cur__CurrentFlag);
				track_array.AppendDataValue(14, _cur__rowguid);
				track_array.AppendDataValue(15, _cur__ModifiedDate);
			}
			else if (_recordstatus == DataRecordStatus.Existing)
			{
				if (_started_with_dbvalues)
				{
					if (_mod__BusinessEntityID) track_array.AppendDataValue(0, _cur__BusinessEntityID);
				}
				if (_mod__NationalIDNumber) track_array.AppendDataValue(1, _cur__NationalIDNumber);
				if (_mod__LoginID) track_array.AppendDataValue(2, _cur__LoginID);
				if (_mod__OrganizationNode) track_array.AppendDataValue(3, _cur__OrganizationNode);
				if (_mod__OrganizationLevel) track_array.AppendDataValue(4, _cur__OrganizationLevel);
				if (_mod__JobTitle) track_array.AppendDataValue(5, _cur__JobTitle);
				if (_mod__BirthDate) track_array.AppendDataValue(6, _cur__BirthDate);
				if (_mod__MaritalStatus) track_array.AppendDataValue(7, _cur__MaritalStatus);
				if (_mod__Gender) track_array.AppendDataValue(8, _cur__Gender);
				if (_mod__HireDate) track_array.AppendDataValue(9, _cur__HireDate);
				if (_mod__SalariedFlag) track_array.AppendDataValue(10, _cur__SalariedFlag);
				if (_mod__VacationHours) track_array.AppendDataValue(11, _cur__VacationHours);
				if (_mod__SickLeaveHours) track_array.AppendDataValue(12, _cur__SickLeaveHours);
				if (_mod__CurrentFlag) track_array.AppendDataValue(13, _cur__CurrentFlag);
				if (_mod__rowguid) track_array.AppendDataValue(14, _cur__rowguid);
				if (_mod__ModifiedDate) track_array.AppendDataValue(15, _cur__ModifiedDate);
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
				if (_mod__NationalIDNumber) _ori__NationalIDNumber = default(string);
				if (_mod__LoginID) _ori__LoginID = default(string);
				if (_mod__OrganizationNode) _ori__OrganizationNode = default(object);
				if (_mod__OrganizationLevel) _ori__OrganizationLevel = default(short?);
				if (_mod__JobTitle) _ori__JobTitle = default(string);
				if (_mod__BirthDate) _ori__BirthDate = default(DateTime);
				if (_mod__MaritalStatus) _ori__MaritalStatus = default(string);
				if (_mod__Gender) _ori__Gender = default(string);
				if (_mod__HireDate) _ori__HireDate = default(DateTime);
				if (_mod__SalariedFlag) _ori__SalariedFlag = default(bool);
				if (_mod__VacationHours) _ori__VacationHours = default(short);
				if (_mod__SickLeaveHours) _ori__SickLeaveHours = default(short);
				if (_mod__CurrentFlag) _ori__CurrentFlag = default(bool);
				if (_mod__rowguid) _ori__rowguid = default(Guid);
				if (_mod__ModifiedDate) _ori__ModifiedDate = default(DateTime);
			}
			_mod__BusinessEntityID = false;
			_mod__NationalIDNumber = false;
			_mod__LoginID = false;
			_mod__OrganizationNode = false;
			_mod__OrganizationLevel = false;
			_mod__JobTitle = false;
			_mod__BirthDate = false;
			_mod__MaritalStatus = false;
			_mod__Gender = false;
			_mod__HireDate = false;
			_mod__SalariedFlag = false;
			_mod__VacationHours = false;
			_mod__SickLeaveHours = false;
			_mod__CurrentFlag = false;
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
namespace AspNetCoreServer.VenturaAutoCreate
{
	public partial class PriKey_HumanResources_Employee_Record
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
