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
	/// The updateable table is [Person].[StateProvince]. Updateable table column information:
	/// • 8 out of 8 table columns are present in the resultset.
	/// • All primary key columns are present in the resultset: StateProvinceID.
	/// • Non-primary key columns present in the resultset: StateProvinceCode, CountryRegionCode, IsOnlyStateProvinceFlag, Name,
	///   TerritoryID, rowguid and ModifiedDate.
	/// Recordset item automatically created by VenturaSQL Studio.
	/// </summary>
	public partial class PriKey_Person_StateProvince_Recordset : ResultsetObservable<PriKey_Person_StateProvince_Recordset, PriKey_Person_StateProvince_Record>, IRecordsetBase
	{
		private IResultsetBase[] _resultsets;
		private string _sqlscript;
		private object[] _inputparametervalues;
		private InputParamHolder _inputparamholder;
		private VenturaSqlSchema _parameterschema;
		private int _rowlimit = 500;
		private const string CRLF = "\r\n";

		public PriKey_Person_StateProvince_Recordset()
		{
			_resultsets = new IResultsetBase[] { this };

			_sqlscript = @"SELECT [StateProvinceID],[StateProvinceCode],[CountryRegionCode],[IsOnlyStateProvinceFlag],[Name],[TerritoryID],[rowguid],[ModifiedDate]" + CRLF +
			             @"FROM [Person].[StateProvince]" + CRLF +
			             @"WHERE [StateProvinceID] = @StateProvinceID";

			_inputparametervalues = new object[1];
			_inputparamholder = new InputParamHolder(_inputparametervalues);

			ColumnArrayBuilder param_array = new ColumnArrayBuilder();

			param_array.AddParameterColumn("@StateProvinceID", typeof(int), true, false, DbType.Int32, null, null, null);

			_parameterschema = new VenturaSqlSchema(param_array);

			ColumnArrayBuilder schema_array = new ColumnArrayBuilder();

			schema_array.Add(new VenturaSqlColumn("StateProvinceID", typeof(int), false)
			{
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				IsKey = true,
				IsIdentity = true,
				IsAutoIncrement = true,
				BaseSchemaName = "Person",
				BaseTableName = "StateProvince",
				BaseColumnName = "StateProvinceID"
			});

			schema_array.Add(new VenturaSqlColumn("StateProvinceCode", typeof(string), false)
			{
				Updateable = true,
				ColumnSize = 3,
				ProviderType = 10,
				BaseSchemaName = "Person",
				BaseTableName = "StateProvince",
				BaseColumnName = "StateProvinceCode"
			});

			schema_array.Add(new VenturaSqlColumn("CountryRegionCode", typeof(string), false)
			{
				Updateable = true,
				ColumnSize = 3,
				ProviderType = 12,
				BaseSchemaName = "Person",
				BaseTableName = "StateProvince",
				BaseColumnName = "CountryRegionCode"
			});

			schema_array.Add(new VenturaSqlColumn("IsOnlyStateProvinceFlag", typeof(bool), false)
			{
				Updateable = true,
				ColumnSize = 1,
				ProviderType = 2,
				BaseSchemaName = "Person",
				BaseTableName = "StateProvince",
				BaseColumnName = "IsOnlyStateProvinceFlag"
			});

			schema_array.Add(new VenturaSqlColumn("Name", typeof(string), false)
			{
				Updateable = true,
				ColumnSize = 50,
				ProviderType = 12,
				BaseSchemaName = "Person",
				BaseTableName = "StateProvince",
				BaseColumnName = "Name"
			});

			schema_array.Add(new VenturaSqlColumn("TerritoryID", typeof(int), false)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				BaseSchemaName = "Person",
				BaseTableName = "StateProvince",
				BaseColumnName = "TerritoryID"
			});

			schema_array.Add(new VenturaSqlColumn("rowguid", typeof(Guid), false)
			{
				Updateable = true,
				ColumnSize = 16,
				ProviderType = 14,
				BaseSchemaName = "Person",
				BaseTableName = "StateProvince",
				BaseColumnName = "rowguid"
			});

			schema_array.Add(new VenturaSqlColumn("ModifiedDate", typeof(DateTime), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 23,
				NumericScale = 3,
				ProviderType = 4,
				BaseSchemaName = "Person",
				BaseTableName = "StateProvince",
				BaseColumnName = "ModifiedDate"
			});

			((IResultsetBase)this).Schema = new VenturaSqlSchema(schema_array);
			((IResultsetBase)this).UpdateableTablename = "[Person].[StateProvince]";
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Person].[StateProvince]. PrimaryKey. NotReadonly. NotNull. IsIdentity. AutoIncrement.
		/// </summary>
		public int StateProvinceID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.StateProvinceID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.StateProvinceID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[StateProvince]. NotReadonly. NotNull.
		/// </summary>
		public string StateProvinceCode
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.StateProvinceCode; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.StateProvinceCode = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[StateProvince]. NotReadonly. NotNull.
		/// </summary>
		public string CountryRegionCode
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.CountryRegionCode; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.CountryRegionCode = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[StateProvince]. NotReadonly. NotNull.
		/// </summary>
		public bool IsOnlyStateProvinceFlag
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.IsOnlyStateProvinceFlag; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.IsOnlyStateProvinceFlag = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[StateProvince]. NotReadonly. NotNull.
		/// </summary>
		public string Name
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Name; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Name = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[StateProvince]. NotReadonly. NotNull.
		/// </summary>
		public int TerritoryID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.TerritoryID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.TerritoryID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[StateProvince]. NotReadonly. NotNull.
		/// </summary>
		public Guid rowguid
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.rowguid; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.rowguid = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[StateProvince]. NotReadonly. NotNull.
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
			this.InsertItem(index, new PriKey_Person_StateProvince_Record());
			this.CurrentRecordIndex = index;
		}

		public void Append(PriKey_Person_StateProvince_Record record)
		{
			int index = this.RecordCount;
			this.InsertItem(index, record);
			this.CurrentRecordIndex = index;
		}

		public PriKey_Person_StateProvince_Record NewRecord()
		{
			return new PriKey_Person_StateProvince_Record();
		}

		protected override PriKey_Person_StateProvince_Record InternalCreateExistingRecordObject(object[] columnvalues) => new PriKey_Person_StateProvince_Record(columnvalues);

		byte[] IRecordsetBase.Hash
		{
			get { return new byte[] { 74, 129, 187, 246, 225, 27, 125, 252, 243, 13, 227, 84, 172, 126, 217, 172 }; }
		}

		string IRecordsetBase.HashString
		{
			get { return "4A81BBF6E11B7DFCF30DE354AC7ED9AC"; }
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

		public void SetExecSqlParams(int? StateProvinceID)
		{
			_inputparametervalues[0] = StateProvinceID;
		}

		public void ExecSql(int? StateProvinceID)
		{
			_inputparametervalues[0] = StateProvinceID;
			Transactional.ExecSql(VenturaSqlConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public void ExecSql(Connector connector, int? StateProvinceID)
		{
			_inputparametervalues[0] = StateProvinceID;
			Transactional.ExecSql(connector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync(int? StateProvinceID)
		{
			_inputparametervalues[0] = StateProvinceID;
			await Transactional.ExecSqlAsync(VenturaSqlConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync(Connector connector, int? StateProvinceID)
		{
			_inputparametervalues[0] = StateProvinceID;
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

			public int? StateProvinceID
			{
				get { return (int?)_values[0]; }
				set { _values[0] = value; }
			}

		}

	}

	public sealed partial class PriKey_Person_StateProvince_Record : IRecordBase, INotifyPropertyChanged
	{
		private DataRecordStatus _recordstatus;
		private bool _started_with_dbvalues;

		private int _cur__StateProvinceID; private int _ori__StateProvinceID; private bool _mod__StateProvinceID;
		private string _cur__StateProvinceCode; private string _ori__StateProvinceCode; private bool _mod__StateProvinceCode;
		private string _cur__CountryRegionCode; private string _ori__CountryRegionCode; private bool _mod__CountryRegionCode;
		private bool _cur__IsOnlyStateProvinceFlag; private bool _ori__IsOnlyStateProvinceFlag; private bool _mod__IsOnlyStateProvinceFlag;
		private string _cur__Name; private string _ori__Name; private bool _mod__Name;
		private int _cur__TerritoryID; private int _ori__TerritoryID; private bool _mod__TerritoryID;
		private Guid _cur__rowguid; private Guid _ori__rowguid; private bool _mod__rowguid;
		private DateTime _cur__ModifiedDate; private DateTime _ori__ModifiedDate; private bool _mod__ModifiedDate;


		public PriKey_Person_StateProvince_Record()
		{
			_cur__StateProvinceID = 0;
			_cur__StateProvinceCode = "";
			_cur__CountryRegionCode = "";
			_cur__IsOnlyStateProvinceFlag = false;
			_cur__Name = "";
			_cur__TerritoryID = 0;
			_cur__rowguid = Guid.Empty;
			_cur__ModifiedDate = new DateTime(1900, 1, 1);
			_started_with_dbvalues = false;
			_recordstatus = DataRecordStatus.New;
		}

		public PriKey_Person_StateProvince_Record(object[] columnvalues)
		{
			_cur__StateProvinceID = (int)columnvalues[0];
			_cur__StateProvinceCode = (string)columnvalues[1];
			_cur__CountryRegionCode = (string)columnvalues[2];
			_cur__IsOnlyStateProvinceFlag = (bool)columnvalues[3];
			_cur__Name = (string)columnvalues[4];
			_cur__TerritoryID = (int)columnvalues[5];
			_cur__rowguid = (Guid)columnvalues[6];
			_cur__ModifiedDate = (DateTime)columnvalues[7];
			_started_with_dbvalues = true;
			_recordstatus = DataRecordStatus.Existing;
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Person].[StateProvince]. PrimaryKey. NotReadonly. NotNull. IsIdentity. AutoIncrement.
		/// </summary>
		public int StateProvinceID
		{
			get { return _cur__StateProvinceID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__StateProvinceID = true;
				if (_cur__StateProvinceID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__StateProvinceID == false) { _ori__StateProvinceID = _cur__StateProvinceID; _mod__StateProvinceID = true; } // existing record and column is not modified
					else { if (value == _ori__StateProvinceID) { _ori__StateProvinceID = default(int); _mod__StateProvinceID = false; } } // existing record and column is modified
				}
				_cur__StateProvinceID = value; OnPropertyChanged("StateProvinceID"); OnAfterPropertyChanged("StateProvinceID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[StateProvince]. NotReadonly. NotNull.
		/// </summary>
		public string StateProvinceCode
		{
			get { return _cur__StateProvinceCode; }
			set
			{
				if (value == null) throw new ArgumentNullException("StateProvinceCode", VenturaSqlStrings.SET_NULL_MSG);
				if (_started_with_dbvalues == false) _mod__StateProvinceCode = true;
				if (_cur__StateProvinceCode == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__StateProvinceCode == false) { _ori__StateProvinceCode = _cur__StateProvinceCode; _mod__StateProvinceCode = true; } // existing record and column is not modified
					else { if (value == _ori__StateProvinceCode) { _ori__StateProvinceCode = default(string); _mod__StateProvinceCode = false; } } // existing record and column is modified
				}
				_cur__StateProvinceCode = value; OnPropertyChanged("StateProvinceCode"); OnAfterPropertyChanged("StateProvinceCode");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[StateProvince]. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [Person].[StateProvince]. NotReadonly. NotNull.
		/// </summary>
		public bool IsOnlyStateProvinceFlag
		{
			get { return _cur__IsOnlyStateProvinceFlag; }
			set
			{
				if (_started_with_dbvalues == false) _mod__IsOnlyStateProvinceFlag = true;
				if (_cur__IsOnlyStateProvinceFlag == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__IsOnlyStateProvinceFlag == false) { _ori__IsOnlyStateProvinceFlag = _cur__IsOnlyStateProvinceFlag; _mod__IsOnlyStateProvinceFlag = true; } // existing record and column is not modified
					else { if (value == _ori__IsOnlyStateProvinceFlag) { _ori__IsOnlyStateProvinceFlag = default(bool); _mod__IsOnlyStateProvinceFlag = false; } } // existing record and column is modified
				}
				_cur__IsOnlyStateProvinceFlag = value; OnPropertyChanged("IsOnlyStateProvinceFlag"); OnAfterPropertyChanged("IsOnlyStateProvinceFlag");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[StateProvince]. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [Person].[StateProvince]. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [Person].[StateProvince]. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [Person].[StateProvince]. NotReadonly. NotNull.
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
			if (column_name == "StateProvinceID") return _mod__StateProvinceID;
			if (column_name == "StateProvinceCode") return _mod__StateProvinceCode;
			if (column_name == "CountryRegionCode") return _mod__CountryRegionCode;
			if (column_name == "IsOnlyStateProvinceFlag") return _mod__IsOnlyStateProvinceFlag;
			if (column_name == "Name") return _mod__Name;
			if (column_name == "TerritoryID") return _mod__TerritoryID;
			if (column_name == "rowguid") return _mod__rowguid;
			if (column_name == "ModifiedDate") return _mod__ModifiedDate;
			throw new ArgumentOutOfRangeException(String.Format(VenturaSqlStrings.UNKNOWN_COLUMN_NAME, column_name));
		}

		public int ModifiedColumnCount()
		{
			int count = 0;
			if (_mod__StateProvinceID == true) count++;
			if (_mod__StateProvinceCode == true) count++;
			if (_mod__CountryRegionCode == true) count++;
			if (_mod__IsOnlyStateProvinceFlag == true) count++;
			if (_mod__Name == true) count++;
			if (_mod__TerritoryID == true) count++;
			if (_mod__rowguid == true) count++;
			if (_mod__ModifiedDate == true) count++;
			return count;
		}

		public bool PendingChanges()
		{
			if (_recordstatus == DataRecordStatus.New || _recordstatus == DataRecordStatus.ExistingDelete) return true;
			int count = 0;
			if (_mod__StateProvinceCode == true) count++;
			if (_mod__CountryRegionCode == true) count++;
			if (_mod__IsOnlyStateProvinceFlag == true) count++;
			if (_mod__Name == true) count++;
			if (_mod__TerritoryID == true) count++;
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
				track_array.AppendDataValue(1, _cur__StateProvinceCode);
				track_array.AppendDataValue(2, _cur__CountryRegionCode);
				track_array.AppendDataValue(3, _cur__IsOnlyStateProvinceFlag);
				track_array.AppendDataValue(4, _cur__Name);
				track_array.AppendDataValue(5, _cur__TerritoryID);
				track_array.AppendDataValue(6, _cur__rowguid);
				track_array.AppendDataValue(7, _cur__ModifiedDate);
			}
			else if (_recordstatus == DataRecordStatus.Existing)
			{
				if (_mod__StateProvinceCode) track_array.AppendDataValue(1, _cur__StateProvinceCode);
				if (_mod__CountryRegionCode) track_array.AppendDataValue(2, _cur__CountryRegionCode);
				if (_mod__IsOnlyStateProvinceFlag) track_array.AppendDataValue(3, _cur__IsOnlyStateProvinceFlag);
				if (_mod__Name) track_array.AppendDataValue(4, _cur__Name);
				if (_mod__TerritoryID) track_array.AppendDataValue(5, _cur__TerritoryID);
				if (_mod__rowguid) track_array.AppendDataValue(6, _cur__rowguid);
				if (_mod__ModifiedDate) track_array.AppendDataValue(7, _cur__ModifiedDate);
				if (track_array.HasData == false) return;
			}

			if (_recordstatus == DataRecordStatus.Existing || _recordstatus == DataRecordStatus.ExistingDelete)
			{
				track_array.AppendPrikeyValue(0, (_mod__StateProvinceID && _started_with_dbvalues) ? _ori__StateProvinceID : _cur__StateProvinceID);
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
				if (_mod__StateProvinceID) _ori__StateProvinceID = default(int);
				if (_mod__StateProvinceCode) _ori__StateProvinceCode = default(string);
				if (_mod__CountryRegionCode) _ori__CountryRegionCode = default(string);
				if (_mod__IsOnlyStateProvinceFlag) _ori__IsOnlyStateProvinceFlag = default(bool);
				if (_mod__Name) _ori__Name = default(string);
				if (_mod__TerritoryID) _ori__TerritoryID = default(int);
				if (_mod__rowguid) _ori__rowguid = default(Guid);
				if (_mod__ModifiedDate) _ori__ModifiedDate = default(DateTime);
			}
			_mod__StateProvinceID = false;
			_mod__StateProvinceCode = false;
			_mod__CountryRegionCode = false;
			_mod__IsOnlyStateProvinceFlag = false;
			_mod__Name = false;
			_mod__TerritoryID = false;
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
			_cur__StateProvinceID = (int)value;
			OnPropertyChanged("StateProvinceID");
			OnAfterPropertyChanged("StateProvinceID");
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
	public partial class PriKey_Person_StateProvince_Record
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
