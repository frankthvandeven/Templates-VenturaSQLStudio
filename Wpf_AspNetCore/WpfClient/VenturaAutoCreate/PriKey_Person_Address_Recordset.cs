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
	/// The updateable table is [Person].[Address]. Updateable table column information:
	/// • 9 out of 9 table columns are present in the resultset.
	/// • All primary key columns are present in the resultset: AddressID.
	/// • Non-primary key columns present in the resultset: AddressLine1, AddressLine2, City, StateProvinceID, PostalCode,
	///   SpatialLocation, rowguid and ModifiedDate.
	/// Recordset item automatically created by VenturaSQL Studio.
	/// </summary>
	public partial class PriKey_Person_Address_Recordset : ResultsetObservable<PriKey_Person_Address_Recordset, PriKey_Person_Address_Record>, IRecordsetBase
	{
		private IResultsetBase[] _resultsets;
		private string _sqlscript;
		private object[] _inputparametervalues;
		private InputParamHolder _inputparamholder;
		private VenturaSqlSchema _parameterschema;
		private int _rowlimit = 500;
		private const string CRLF = "\r\n";

		public PriKey_Person_Address_Recordset()
		{
			_resultsets = new IResultsetBase[] { this };

			_sqlscript = @"SELECT [AddressID],[AddressLine1],[AddressLine2],[City],[StateProvinceID],[PostalCode],[SpatialLocation],[rowguid],[ModifiedDate]" + CRLF +
			             @"FROM [Person].[Address]" + CRLF +
			             @"WHERE [AddressID] = @AddressID";

			_inputparametervalues = new object[1];
			_inputparamholder = new InputParamHolder(_inputparametervalues);

			ColumnArrayBuilder param_array = new ColumnArrayBuilder();

			param_array.AddParameterColumn("@AddressID", typeof(int), true, false, DbType.Int32, null, null, null);

			_parameterschema = new VenturaSqlSchema(param_array);

			ColumnArrayBuilder schema_array = new ColumnArrayBuilder();

			schema_array.Add(new VenturaSqlColumn("AddressID", typeof(int), false)
			{
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				IsKey = true,
				IsIdentity = true,
				IsAutoIncrement = true,
				BaseSchemaName = "Person",
				BaseTableName = "Address",
				BaseColumnName = "AddressID"
			});

			schema_array.Add(new VenturaSqlColumn("AddressLine1", typeof(string), false)
			{
				Updateable = true,
				ColumnSize = 60,
				ProviderType = 12,
				BaseSchemaName = "Person",
				BaseTableName = "Address",
				BaseColumnName = "AddressLine1"
			});

			schema_array.Add(new VenturaSqlColumn("AddressLine2", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 60,
				ProviderType = 12,
				BaseSchemaName = "Person",
				BaseTableName = "Address",
				BaseColumnName = "AddressLine2"
			});

			schema_array.Add(new VenturaSqlColumn("City", typeof(string), false)
			{
				Updateable = true,
				ColumnSize = 30,
				ProviderType = 12,
				BaseSchemaName = "Person",
				BaseTableName = "Address",
				BaseColumnName = "City"
			});

			schema_array.Add(new VenturaSqlColumn("StateProvinceID", typeof(int), false)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				BaseSchemaName = "Person",
				BaseTableName = "Address",
				BaseColumnName = "StateProvinceID"
			});

			schema_array.Add(new VenturaSqlColumn("PostalCode", typeof(string), false)
			{
				Updateable = true,
				ColumnSize = 15,
				ProviderType = 12,
				BaseSchemaName = "Person",
				BaseTableName = "Address",
				BaseColumnName = "PostalCode"
			});

			schema_array.Add(new VenturaSqlColumn("SpatialLocation", typeof(object), true)
			{
				Updateable = true,
				ProviderType = 29,
				IsLong = true,
				UdtAssemblyQualifiedName = "Microsoft.SqlServer.Types.SqlGeography, Microsoft.SqlServer.Types, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91",
				BaseSchemaName = "Person",
				BaseTableName = "Address",
				BaseColumnName = "SpatialLocation"
			});

			schema_array.Add(new VenturaSqlColumn("rowguid", typeof(Guid), false)
			{
				Updateable = true,
				ColumnSize = 16,
				ProviderType = 14,
				BaseSchemaName = "Person",
				BaseTableName = "Address",
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
				BaseTableName = "Address",
				BaseColumnName = "ModifiedDate"
			});

			((IResultsetBase)this).Schema = new VenturaSqlSchema(schema_array);
			((IResultsetBase)this).UpdateableTablename = "[Person].[Address]";
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Person].[Address]. PrimaryKey. NotReadonly. NotNull. IsIdentity. AutoIncrement.
		/// </summary>
		public int AddressID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.AddressID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.AddressID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[Address]. NotReadonly. NotNull.
		/// </summary>
		public string AddressLine1
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.AddressLine1; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.AddressLine1 = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[Address]. NotReadonly. AllowNull.
		/// </summary>
		public string AddressLine2
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.AddressLine2; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.AddressLine2 = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[Address]. NotReadonly. NotNull.
		/// </summary>
		public string City
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.City; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.City = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[Address]. NotReadonly. NotNull.
		/// </summary>
		public int StateProvinceID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.StateProvinceID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.StateProvinceID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[Address]. NotReadonly. NotNull.
		/// </summary>
		public string PostalCode
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.PostalCode; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.PostalCode = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[Address]. NotReadonly. AllowNull.
		/// </summary>
		public object SpatialLocation
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.SpatialLocation; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.SpatialLocation = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[Address]. NotReadonly. NotNull.
		/// </summary>
		public Guid rowguid
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.rowguid; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.rowguid = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[Address]. NotReadonly. NotNull.
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
			this.InsertItem(index, new PriKey_Person_Address_Record());
			this.CurrentRecordIndex = index;
		}

		public void Append(PriKey_Person_Address_Record record)
		{
			int index = this.RecordCount;
			this.InsertItem(index, record);
			this.CurrentRecordIndex = index;
		}

		public PriKey_Person_Address_Record NewRecord()
		{
			return new PriKey_Person_Address_Record();
		}

		protected override PriKey_Person_Address_Record InternalCreateExistingRecordObject(object[] columnvalues) => new PriKey_Person_Address_Record(columnvalues);

		byte[] IRecordsetBase.Hash
		{
			get { return new byte[] { 254, 48, 238, 124, 206, 41, 194, 39, 62, 142, 194, 255, 117, 94, 218, 34 }; }
		}

		string IRecordsetBase.HashString
		{
			get { return "FE30EE7CCE29C2273E8EC2FF755EDA22"; }
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

		public void SetExecSqlParams(int? AddressID)
		{
			_inputparametervalues[0] = AddressID;
		}

		public void ExecSql(int? AddressID)
		{
			_inputparametervalues[0] = AddressID;
			Transactional.ExecSql(VenturaSqlConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public void ExecSql(Connector connector, int? AddressID)
		{
			_inputparametervalues[0] = AddressID;
			Transactional.ExecSql(connector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync(int? AddressID)
		{
			_inputparametervalues[0] = AddressID;
			await Transactional.ExecSqlAsync(VenturaSqlConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync(Connector connector, int? AddressID)
		{
			_inputparametervalues[0] = AddressID;
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

			public int? AddressID
			{
				get { return (int?)_values[0]; }
				set { _values[0] = value; }
			}

		}

	}

	public sealed partial class PriKey_Person_Address_Record : IRecordBase, INotifyPropertyChanged
	{
		private DataRecordStatus _recordstatus;
		private bool _started_with_dbvalues;

		private int _cur__AddressID; private int _ori__AddressID; private bool _mod__AddressID;
		private string _cur__AddressLine1; private string _ori__AddressLine1; private bool _mod__AddressLine1;
		private string _cur__AddressLine2; private string _ori__AddressLine2; private bool _mod__AddressLine2;
		private string _cur__City; private string _ori__City; private bool _mod__City;
		private int _cur__StateProvinceID; private int _ori__StateProvinceID; private bool _mod__StateProvinceID;
		private string _cur__PostalCode; private string _ori__PostalCode; private bool _mod__PostalCode;
		private object _cur__SpatialLocation; private object _ori__SpatialLocation; private bool _mod__SpatialLocation;
		private Guid _cur__rowguid; private Guid _ori__rowguid; private bool _mod__rowguid;
		private DateTime _cur__ModifiedDate; private DateTime _ori__ModifiedDate; private bool _mod__ModifiedDate;


		public PriKey_Person_Address_Record()
		{
			_cur__AddressID = 0;
			_cur__AddressLine1 = "";
			_cur__AddressLine2 = null;
			_cur__City = "";
			_cur__StateProvinceID = 0;
			_cur__PostalCode = "";
			_cur__SpatialLocation = null;
			_cur__rowguid = Guid.Empty;
			_cur__ModifiedDate = new DateTime(1900, 1, 1);
			_started_with_dbvalues = false;
			_recordstatus = DataRecordStatus.New;
		}

		public PriKey_Person_Address_Record(object[] columnvalues)
		{
			_cur__AddressID = (int)columnvalues[0];
			_cur__AddressLine1 = (string)columnvalues[1];
			_cur__AddressLine2 = (string)columnvalues[2];
			_cur__City = (string)columnvalues[3];
			_cur__StateProvinceID = (int)columnvalues[4];
			_cur__PostalCode = (string)columnvalues[5];
			_cur__SpatialLocation = (object)columnvalues[6];
			_cur__rowguid = (Guid)columnvalues[7];
			_cur__ModifiedDate = (DateTime)columnvalues[8];
			_started_with_dbvalues = true;
			_recordstatus = DataRecordStatus.Existing;
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Person].[Address]. PrimaryKey. NotReadonly. NotNull. IsIdentity. AutoIncrement.
		/// </summary>
		public int AddressID
		{
			get { return _cur__AddressID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__AddressID = true;
				if (_cur__AddressID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__AddressID == false) { _ori__AddressID = _cur__AddressID; _mod__AddressID = true; } // existing record and column is not modified
					else { if (value == _ori__AddressID) { _ori__AddressID = default(int); _mod__AddressID = false; } } // existing record and column is modified
				}
				_cur__AddressID = value; OnPropertyChanged("AddressID"); OnAfterPropertyChanged("AddressID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[Address]. NotReadonly. NotNull.
		/// </summary>
		public string AddressLine1
		{
			get { return _cur__AddressLine1; }
			set
			{
				if (value == null) throw new ArgumentNullException("AddressLine1", VenturaSqlStrings.SET_NULL_MSG);
				if (_started_with_dbvalues == false) _mod__AddressLine1 = true;
				if (_cur__AddressLine1 == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__AddressLine1 == false) { _ori__AddressLine1 = _cur__AddressLine1; _mod__AddressLine1 = true; } // existing record and column is not modified
					else { if (value == _ori__AddressLine1) { _ori__AddressLine1 = default(string); _mod__AddressLine1 = false; } } // existing record and column is modified
				}
				_cur__AddressLine1 = value; OnPropertyChanged("AddressLine1"); OnAfterPropertyChanged("AddressLine1");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[Address]. NotReadonly. AllowNull.
		/// </summary>
		public string AddressLine2
		{
			get { return _cur__AddressLine2; }
			set
			{
				if (_started_with_dbvalues == false) _mod__AddressLine2 = true;
				if (_cur__AddressLine2 == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__AddressLine2 == false) { _ori__AddressLine2 = _cur__AddressLine2; _mod__AddressLine2 = true; } // existing record and column is not modified
					else { if (value == _ori__AddressLine2) { _ori__AddressLine2 = default(string); _mod__AddressLine2 = false; } } // existing record and column is modified
				}
				_cur__AddressLine2 = value; OnPropertyChanged("AddressLine2"); OnAfterPropertyChanged("AddressLine2");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[Address]. NotReadonly. NotNull.
		/// </summary>
		public string City
		{
			get { return _cur__City; }
			set
			{
				if (value == null) throw new ArgumentNullException("City", VenturaSqlStrings.SET_NULL_MSG);
				if (_started_with_dbvalues == false) _mod__City = true;
				if (_cur__City == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__City == false) { _ori__City = _cur__City; _mod__City = true; } // existing record and column is not modified
					else { if (value == _ori__City) { _ori__City = default(string); _mod__City = false; } } // existing record and column is modified
				}
				_cur__City = value; OnPropertyChanged("City"); OnAfterPropertyChanged("City");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[Address]. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [Person].[Address]. NotReadonly. NotNull.
		/// </summary>
		public string PostalCode
		{
			get { return _cur__PostalCode; }
			set
			{
				if (value == null) throw new ArgumentNullException("PostalCode", VenturaSqlStrings.SET_NULL_MSG);
				if (_started_with_dbvalues == false) _mod__PostalCode = true;
				if (_cur__PostalCode == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__PostalCode == false) { _ori__PostalCode = _cur__PostalCode; _mod__PostalCode = true; } // existing record and column is not modified
					else { if (value == _ori__PostalCode) { _ori__PostalCode = default(string); _mod__PostalCode = false; } } // existing record and column is modified
				}
				_cur__PostalCode = value; OnPropertyChanged("PostalCode"); OnAfterPropertyChanged("PostalCode");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[Address]. NotReadonly. AllowNull.
		/// </summary>
		public object SpatialLocation
		{
			get { return _cur__SpatialLocation; }
			set
			{
				if (_started_with_dbvalues == false) _mod__SpatialLocation = true;
				if (_cur__SpatialLocation == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__SpatialLocation == false) { _ori__SpatialLocation = _cur__SpatialLocation; _mod__SpatialLocation = true; } // existing record and column is not modified
					else { if (value == _ori__SpatialLocation) { _ori__SpatialLocation = default(object); _mod__SpatialLocation = false; } } // existing record and column is modified
				}
				_cur__SpatialLocation = value; OnPropertyChanged("SpatialLocation"); OnAfterPropertyChanged("SpatialLocation");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[Address]. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [Person].[Address]. NotReadonly. NotNull.
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
			if (column_name == "AddressID") return _mod__AddressID;
			if (column_name == "AddressLine1") return _mod__AddressLine1;
			if (column_name == "AddressLine2") return _mod__AddressLine2;
			if (column_name == "City") return _mod__City;
			if (column_name == "StateProvinceID") return _mod__StateProvinceID;
			if (column_name == "PostalCode") return _mod__PostalCode;
			if (column_name == "SpatialLocation") return _mod__SpatialLocation;
			if (column_name == "rowguid") return _mod__rowguid;
			if (column_name == "ModifiedDate") return _mod__ModifiedDate;
			throw new ArgumentOutOfRangeException(String.Format(VenturaSqlStrings.UNKNOWN_COLUMN_NAME, column_name));
		}

		public int ModifiedColumnCount()
		{
			int count = 0;
			if (_mod__AddressID == true) count++;
			if (_mod__AddressLine1 == true) count++;
			if (_mod__AddressLine2 == true) count++;
			if (_mod__City == true) count++;
			if (_mod__StateProvinceID == true) count++;
			if (_mod__PostalCode == true) count++;
			if (_mod__SpatialLocation == true) count++;
			if (_mod__rowguid == true) count++;
			if (_mod__ModifiedDate == true) count++;
			return count;
		}

		public bool PendingChanges()
		{
			if (_recordstatus == DataRecordStatus.New || _recordstatus == DataRecordStatus.ExistingDelete) return true;
			int count = 0;
			if (_mod__AddressLine1 == true) count++;
			if (_mod__AddressLine2 == true) count++;
			if (_mod__City == true) count++;
			if (_mod__StateProvinceID == true) count++;
			if (_mod__PostalCode == true) count++;
			if (_mod__SpatialLocation == true) count++;
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
				track_array.AppendDataValue(1, _cur__AddressLine1);
				if (_cur__AddressLine2 != null) track_array.AppendDataValue(2, _cur__AddressLine2);
				track_array.AppendDataValue(3, _cur__City);
				track_array.AppendDataValue(4, _cur__StateProvinceID);
				track_array.AppendDataValue(5, _cur__PostalCode);
				if (_cur__SpatialLocation != null) track_array.AppendDataValue(6, _cur__SpatialLocation);
				track_array.AppendDataValue(7, _cur__rowguid);
				track_array.AppendDataValue(8, _cur__ModifiedDate);
			}
			else if (_recordstatus == DataRecordStatus.Existing)
			{
				if (_mod__AddressLine1) track_array.AppendDataValue(1, _cur__AddressLine1);
				if (_mod__AddressLine2) track_array.AppendDataValue(2, _cur__AddressLine2);
				if (_mod__City) track_array.AppendDataValue(3, _cur__City);
				if (_mod__StateProvinceID) track_array.AppendDataValue(4, _cur__StateProvinceID);
				if (_mod__PostalCode) track_array.AppendDataValue(5, _cur__PostalCode);
				if (_mod__SpatialLocation) track_array.AppendDataValue(6, _cur__SpatialLocation);
				if (_mod__rowguid) track_array.AppendDataValue(7, _cur__rowguid);
				if (_mod__ModifiedDate) track_array.AppendDataValue(8, _cur__ModifiedDate);
				if (track_array.HasData == false) return;
			}

			if (_recordstatus == DataRecordStatus.Existing || _recordstatus == DataRecordStatus.ExistingDelete)
			{
				track_array.AppendPrikeyValue(0, (_mod__AddressID && _started_with_dbvalues) ? _ori__AddressID : _cur__AddressID);
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
				if (_mod__AddressID) _ori__AddressID = default(int);
				if (_mod__AddressLine1) _ori__AddressLine1 = default(string);
				if (_mod__AddressLine2) _ori__AddressLine2 = default(string);
				if (_mod__City) _ori__City = default(string);
				if (_mod__StateProvinceID) _ori__StateProvinceID = default(int);
				if (_mod__PostalCode) _ori__PostalCode = default(string);
				if (_mod__SpatialLocation) _ori__SpatialLocation = default(object);
				if (_mod__rowguid) _ori__rowguid = default(Guid);
				if (_mod__ModifiedDate) _ori__ModifiedDate = default(DateTime);
			}
			_mod__AddressID = false;
			_mod__AddressLine1 = false;
			_mod__AddressLine2 = false;
			_mod__City = false;
			_mod__StateProvinceID = false;
			_mod__PostalCode = false;
			_mod__SpatialLocation = false;
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
			_cur__AddressID = (int)value;
			OnPropertyChanged("AddressID");
			OnAfterPropertyChanged("AddressID");
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
	public partial class PriKey_Person_Address_Record
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
