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
	/// The updateable table is [Person].[Person]. Updateable table column information:
	/// • 13 out of 13 table columns are present in the resultset.
	/// • All primary key columns are present in the resultset: BusinessEntityID.
	/// • Non-primary key columns present in the resultset: PersonType, NameStyle, Title, FirstName, MiddleName, LastName, Suffix,
	///   EmailPromotion, AdditionalContactInfo, Demographics, rowguid and ModifiedDate.
	/// Recordset item automatically created by VenturaSQL Studio.
	/// </summary>
	public partial class PriKey_Person_Person_Recordset : ResultsetObservable<PriKey_Person_Person_Recordset, PriKey_Person_Person_Record>, IRecordsetBase
	{
		private IResultsetBase[] _resultsets;
		private string _sqlscript;
		private object[] _inputparametervalues;
		private InputParamHolder _inputparamholder;
		private VenturaSqlSchema _parameterschema;
		private int _rowlimit = 500;
		private const string CRLF = "\r\n";

		public PriKey_Person_Person_Recordset()
		{
			_resultsets = new IResultsetBase[] { this };

			_sqlscript = @"SELECT [BusinessEntityID],[PersonType],[NameStyle],[Title],[FirstName],[MiddleName],[LastName],[Suffix],[EmailPromotion],[AdditionalContactInfo],[Demographics]," + CRLF +
			             @"[rowguid],[ModifiedDate]" + CRLF +
			             @"FROM [Person].[Person]" + CRLF +
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
				BaseSchemaName = "Person",
				BaseTableName = "Person",
				BaseColumnName = "BusinessEntityID"
			});

			schema_array.Add(new VenturaSqlColumn("PersonType", typeof(string), false)
			{
				Updateable = true,
				ColumnSize = 2,
				ProviderType = 10,
				BaseSchemaName = "Person",
				BaseTableName = "Person",
				BaseColumnName = "PersonType"
			});

			schema_array.Add(new VenturaSqlColumn("NameStyle", typeof(bool), false)
			{
				Updateable = true,
				ColumnSize = 1,
				ProviderType = 2,
				BaseSchemaName = "Person",
				BaseTableName = "Person",
				BaseColumnName = "NameStyle"
			});

			schema_array.Add(new VenturaSqlColumn("Title", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 8,
				ProviderType = 12,
				BaseSchemaName = "Person",
				BaseTableName = "Person",
				BaseColumnName = "Title"
			});

			schema_array.Add(new VenturaSqlColumn("FirstName", typeof(string), false)
			{
				Updateable = true,
				ColumnSize = 50,
				ProviderType = 12,
				BaseSchemaName = "Person",
				BaseTableName = "Person",
				BaseColumnName = "FirstName"
			});

			schema_array.Add(new VenturaSqlColumn("MiddleName", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 50,
				ProviderType = 12,
				BaseSchemaName = "Person",
				BaseTableName = "Person",
				BaseColumnName = "MiddleName"
			});

			schema_array.Add(new VenturaSqlColumn("LastName", typeof(string), false)
			{
				Updateable = true,
				ColumnSize = 50,
				ProviderType = 12,
				BaseSchemaName = "Person",
				BaseTableName = "Person",
				BaseColumnName = "LastName"
			});

			schema_array.Add(new VenturaSqlColumn("Suffix", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 10,
				ProviderType = 12,
				BaseSchemaName = "Person",
				BaseTableName = "Person",
				BaseColumnName = "Suffix"
			});

			schema_array.Add(new VenturaSqlColumn("EmailPromotion", typeof(int), false)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				BaseSchemaName = "Person",
				BaseTableName = "Person",
				BaseColumnName = "EmailPromotion"
			});

			schema_array.Add(new VenturaSqlColumn("AdditionalContactInfo", typeof(string), true)
			{
				Updateable = true,
				ProviderType = 25,
				IsLong = true,
				XmlSchemaCollectionDatabase = "AdventureWorks2017",
				XmlSchemaCollectionOwningSchema = "Person",
				XmlSchemaCollectionName = "AdditionalContactInfoSchemaCollection",
				BaseSchemaName = "Person",
				BaseTableName = "Person",
				BaseColumnName = "AdditionalContactInfo"
			});

			schema_array.Add(new VenturaSqlColumn("Demographics", typeof(string), true)
			{
				Updateable = true,
				ProviderType = 25,
				IsLong = true,
				XmlSchemaCollectionDatabase = "AdventureWorks2017",
				XmlSchemaCollectionOwningSchema = "Person",
				XmlSchemaCollectionName = "IndividualSurveySchemaCollection",
				BaseSchemaName = "Person",
				BaseTableName = "Person",
				BaseColumnName = "Demographics"
			});

			schema_array.Add(new VenturaSqlColumn("rowguid", typeof(Guid), false)
			{
				Updateable = true,
				ColumnSize = 16,
				ProviderType = 14,
				BaseSchemaName = "Person",
				BaseTableName = "Person",
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
				BaseTableName = "Person",
				BaseColumnName = "ModifiedDate"
			});

			((IResultsetBase)this).Schema = new VenturaSqlSchema(schema_array);
			((IResultsetBase)this).UpdateableTablename = "[Person].[Person]";
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[Person]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public int BusinessEntityID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.BusinessEntityID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.BusinessEntityID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[Person]. NotReadonly. NotNull.
		/// </summary>
		public string PersonType
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.PersonType; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.PersonType = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[Person]. NotReadonly. NotNull.
		/// </summary>
		public bool NameStyle
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.NameStyle; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.NameStyle = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[Person]. NotReadonly. AllowNull.
		/// </summary>
		public string Title
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Title; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Title = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[Person]. NotReadonly. NotNull.
		/// </summary>
		public string FirstName
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.FirstName; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.FirstName = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[Person]. NotReadonly. AllowNull.
		/// </summary>
		public string MiddleName
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.MiddleName; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.MiddleName = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[Person]. NotReadonly. NotNull.
		/// </summary>
		public string LastName
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.LastName; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.LastName = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[Person]. NotReadonly. AllowNull.
		/// </summary>
		public string Suffix
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Suffix; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Suffix = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[Person]. NotReadonly. NotNull.
		/// </summary>
		public int EmailPromotion
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.EmailPromotion; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.EmailPromotion = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[Person]. NotReadonly. AllowNull.
		/// </summary>
		public string AdditionalContactInfo
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.AdditionalContactInfo; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.AdditionalContactInfo = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[Person]. NotReadonly. AllowNull.
		/// </summary>
		public string Demographics
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Demographics; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Demographics = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[Person]. NotReadonly. NotNull.
		/// </summary>
		public Guid rowguid
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.rowguid; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.rowguid = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[Person]. NotReadonly. NotNull.
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
			this.InsertItem(index, new PriKey_Person_Person_Record());
			this.CurrentRecordIndex = index;
		}

		public void Append(PriKey_Person_Person_Record record)
		{
			int index = this.RecordCount;
			this.InsertItem(index, record);
			this.CurrentRecordIndex = index;
		}

		public PriKey_Person_Person_Record NewRecord()
		{
			return new PriKey_Person_Person_Record();
		}

		protected override PriKey_Person_Person_Record InternalCreateExistingRecordObject(object[] columnvalues) => new PriKey_Person_Person_Record(columnvalues);

		byte[] IRecordsetBase.Hash
		{
			get { return new byte[] { 138, 228, 186, 134, 34, 206, 109, 196, 121, 115, 119, 135, 38, 222, 96, 133 }; }
		}

		string IRecordsetBase.HashString
		{
			get { return "8AE4BA8622CE6DC47973778726DE6085"; }
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

	public sealed partial class PriKey_Person_Person_Record : IRecordBase, INotifyPropertyChanged
	{
		private DataRecordStatus _recordstatus;
		private bool _started_with_dbvalues;

		private int _cur__BusinessEntityID; private int _ori__BusinessEntityID; private bool _mod__BusinessEntityID;
		private string _cur__PersonType; private string _ori__PersonType; private bool _mod__PersonType;
		private bool _cur__NameStyle; private bool _ori__NameStyle; private bool _mod__NameStyle;
		private string _cur__Title; private string _ori__Title; private bool _mod__Title;
		private string _cur__FirstName; private string _ori__FirstName; private bool _mod__FirstName;
		private string _cur__MiddleName; private string _ori__MiddleName; private bool _mod__MiddleName;
		private string _cur__LastName; private string _ori__LastName; private bool _mod__LastName;
		private string _cur__Suffix; private string _ori__Suffix; private bool _mod__Suffix;
		private int _cur__EmailPromotion; private int _ori__EmailPromotion; private bool _mod__EmailPromotion;
		private string _cur__AdditionalContactInfo; private string _ori__AdditionalContactInfo; private bool _mod__AdditionalContactInfo;
		private string _cur__Demographics; private string _ori__Demographics; private bool _mod__Demographics;
		private Guid _cur__rowguid; private Guid _ori__rowguid; private bool _mod__rowguid;
		private DateTime _cur__ModifiedDate; private DateTime _ori__ModifiedDate; private bool _mod__ModifiedDate;


		public PriKey_Person_Person_Record()
		{
			_cur__BusinessEntityID = 0;
			_cur__PersonType = "";
			_cur__NameStyle = false;
			_cur__Title = null;
			_cur__FirstName = "";
			_cur__MiddleName = null;
			_cur__LastName = "";
			_cur__Suffix = null;
			_cur__EmailPromotion = 0;
			_cur__AdditionalContactInfo = null;
			_cur__Demographics = null;
			_cur__rowguid = Guid.Empty;
			_cur__ModifiedDate = new DateTime(1900, 1, 1);
			_started_with_dbvalues = false;
			_recordstatus = DataRecordStatus.New;
		}

		public PriKey_Person_Person_Record(object[] columnvalues)
		{
			_cur__BusinessEntityID = (int)columnvalues[0];
			_cur__PersonType = (string)columnvalues[1];
			_cur__NameStyle = (bool)columnvalues[2];
			_cur__Title = (string)columnvalues[3];
			_cur__FirstName = (string)columnvalues[4];
			_cur__MiddleName = (string)columnvalues[5];
			_cur__LastName = (string)columnvalues[6];
			_cur__Suffix = (string)columnvalues[7];
			_cur__EmailPromotion = (int)columnvalues[8];
			_cur__AdditionalContactInfo = (string)columnvalues[9];
			_cur__Demographics = (string)columnvalues[10];
			_cur__rowguid = (Guid)columnvalues[11];
			_cur__ModifiedDate = (DateTime)columnvalues[12];
			_started_with_dbvalues = true;
			_recordstatus = DataRecordStatus.Existing;
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[Person]. PrimaryKey. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [Person].[Person]. NotReadonly. NotNull.
		/// </summary>
		public string PersonType
		{
			get { return _cur__PersonType; }
			set
			{
				if (value == null) throw new ArgumentNullException("PersonType", VenturaSqlStrings.SET_NULL_MSG);
				if (_started_with_dbvalues == false) _mod__PersonType = true;
				if (_cur__PersonType == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__PersonType == false) { _ori__PersonType = _cur__PersonType; _mod__PersonType = true; } // existing record and column is not modified
					else { if (value == _ori__PersonType) { _ori__PersonType = default(string); _mod__PersonType = false; } } // existing record and column is modified
				}
				_cur__PersonType = value; OnPropertyChanged("PersonType"); OnAfterPropertyChanged("PersonType");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[Person]. NotReadonly. NotNull.
		/// </summary>
		public bool NameStyle
		{
			get { return _cur__NameStyle; }
			set
			{
				if (_started_with_dbvalues == false) _mod__NameStyle = true;
				if (_cur__NameStyle == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__NameStyle == false) { _ori__NameStyle = _cur__NameStyle; _mod__NameStyle = true; } // existing record and column is not modified
					else { if (value == _ori__NameStyle) { _ori__NameStyle = default(bool); _mod__NameStyle = false; } } // existing record and column is modified
				}
				_cur__NameStyle = value; OnPropertyChanged("NameStyle"); OnAfterPropertyChanged("NameStyle");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[Person]. NotReadonly. AllowNull.
		/// </summary>
		public string Title
		{
			get { return _cur__Title; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Title = true;
				if (_cur__Title == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Title == false) { _ori__Title = _cur__Title; _mod__Title = true; } // existing record and column is not modified
					else { if (value == _ori__Title) { _ori__Title = default(string); _mod__Title = false; } } // existing record and column is modified
				}
				_cur__Title = value; OnPropertyChanged("Title"); OnAfterPropertyChanged("Title");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[Person]. NotReadonly. NotNull.
		/// </summary>
		public string FirstName
		{
			get { return _cur__FirstName; }
			set
			{
				if (value == null) throw new ArgumentNullException("FirstName", VenturaSqlStrings.SET_NULL_MSG);
				if (_started_with_dbvalues == false) _mod__FirstName = true;
				if (_cur__FirstName == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__FirstName == false) { _ori__FirstName = _cur__FirstName; _mod__FirstName = true; } // existing record and column is not modified
					else { if (value == _ori__FirstName) { _ori__FirstName = default(string); _mod__FirstName = false; } } // existing record and column is modified
				}
				_cur__FirstName = value; OnPropertyChanged("FirstName"); OnAfterPropertyChanged("FirstName");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[Person]. NotReadonly. AllowNull.
		/// </summary>
		public string MiddleName
		{
			get { return _cur__MiddleName; }
			set
			{
				if (_started_with_dbvalues == false) _mod__MiddleName = true;
				if (_cur__MiddleName == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__MiddleName == false) { _ori__MiddleName = _cur__MiddleName; _mod__MiddleName = true; } // existing record and column is not modified
					else { if (value == _ori__MiddleName) { _ori__MiddleName = default(string); _mod__MiddleName = false; } } // existing record and column is modified
				}
				_cur__MiddleName = value; OnPropertyChanged("MiddleName"); OnAfterPropertyChanged("MiddleName");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[Person]. NotReadonly. NotNull.
		/// </summary>
		public string LastName
		{
			get { return _cur__LastName; }
			set
			{
				if (value == null) throw new ArgumentNullException("LastName", VenturaSqlStrings.SET_NULL_MSG);
				if (_started_with_dbvalues == false) _mod__LastName = true;
				if (_cur__LastName == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__LastName == false) { _ori__LastName = _cur__LastName; _mod__LastName = true; } // existing record and column is not modified
					else { if (value == _ori__LastName) { _ori__LastName = default(string); _mod__LastName = false; } } // existing record and column is modified
				}
				_cur__LastName = value; OnPropertyChanged("LastName"); OnAfterPropertyChanged("LastName");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[Person]. NotReadonly. AllowNull.
		/// </summary>
		public string Suffix
		{
			get { return _cur__Suffix; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Suffix = true;
				if (_cur__Suffix == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Suffix == false) { _ori__Suffix = _cur__Suffix; _mod__Suffix = true; } // existing record and column is not modified
					else { if (value == _ori__Suffix) { _ori__Suffix = default(string); _mod__Suffix = false; } } // existing record and column is modified
				}
				_cur__Suffix = value; OnPropertyChanged("Suffix"); OnAfterPropertyChanged("Suffix");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[Person]. NotReadonly. NotNull.
		/// </summary>
		public int EmailPromotion
		{
			get { return _cur__EmailPromotion; }
			set
			{
				if (_started_with_dbvalues == false) _mod__EmailPromotion = true;
				if (_cur__EmailPromotion == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__EmailPromotion == false) { _ori__EmailPromotion = _cur__EmailPromotion; _mod__EmailPromotion = true; } // existing record and column is not modified
					else { if (value == _ori__EmailPromotion) { _ori__EmailPromotion = default(int); _mod__EmailPromotion = false; } } // existing record and column is modified
				}
				_cur__EmailPromotion = value; OnPropertyChanged("EmailPromotion"); OnAfterPropertyChanged("EmailPromotion");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[Person]. NotReadonly. AllowNull.
		/// </summary>
		public string AdditionalContactInfo
		{
			get { return _cur__AdditionalContactInfo; }
			set
			{
				if (_started_with_dbvalues == false) _mod__AdditionalContactInfo = true;
				if (_cur__AdditionalContactInfo == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__AdditionalContactInfo == false) { _ori__AdditionalContactInfo = _cur__AdditionalContactInfo; _mod__AdditionalContactInfo = true; } // existing record and column is not modified
					else { if (value == _ori__AdditionalContactInfo) { _ori__AdditionalContactInfo = default(string); _mod__AdditionalContactInfo = false; } } // existing record and column is modified
				}
				_cur__AdditionalContactInfo = value; OnPropertyChanged("AdditionalContactInfo"); OnAfterPropertyChanged("AdditionalContactInfo");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[Person]. NotReadonly. AllowNull.
		/// </summary>
		public string Demographics
		{
			get { return _cur__Demographics; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Demographics = true;
				if (_cur__Demographics == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Demographics == false) { _ori__Demographics = _cur__Demographics; _mod__Demographics = true; } // existing record and column is not modified
					else { if (value == _ori__Demographics) { _ori__Demographics = default(string); _mod__Demographics = false; } } // existing record and column is modified
				}
				_cur__Demographics = value; OnPropertyChanged("Demographics"); OnAfterPropertyChanged("Demographics");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Person].[Person]. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [Person].[Person]. NotReadonly. NotNull.
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
			if (column_name == "PersonType") return _mod__PersonType;
			if (column_name == "NameStyle") return _mod__NameStyle;
			if (column_name == "Title") return _mod__Title;
			if (column_name == "FirstName") return _mod__FirstName;
			if (column_name == "MiddleName") return _mod__MiddleName;
			if (column_name == "LastName") return _mod__LastName;
			if (column_name == "Suffix") return _mod__Suffix;
			if (column_name == "EmailPromotion") return _mod__EmailPromotion;
			if (column_name == "AdditionalContactInfo") return _mod__AdditionalContactInfo;
			if (column_name == "Demographics") return _mod__Demographics;
			if (column_name == "rowguid") return _mod__rowguid;
			if (column_name == "ModifiedDate") return _mod__ModifiedDate;
			throw new ArgumentOutOfRangeException(String.Format(VenturaSqlStrings.UNKNOWN_COLUMN_NAME, column_name));
		}

		public int ModifiedColumnCount()
		{
			int count = 0;
			if (_mod__BusinessEntityID == true) count++;
			if (_mod__PersonType == true) count++;
			if (_mod__NameStyle == true) count++;
			if (_mod__Title == true) count++;
			if (_mod__FirstName == true) count++;
			if (_mod__MiddleName == true) count++;
			if (_mod__LastName == true) count++;
			if (_mod__Suffix == true) count++;
			if (_mod__EmailPromotion == true) count++;
			if (_mod__AdditionalContactInfo == true) count++;
			if (_mod__Demographics == true) count++;
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
			if (_mod__PersonType == true) count++;
			if (_mod__NameStyle == true) count++;
			if (_mod__Title == true) count++;
			if (_mod__FirstName == true) count++;
			if (_mod__MiddleName == true) count++;
			if (_mod__LastName == true) count++;
			if (_mod__Suffix == true) count++;
			if (_mod__EmailPromotion == true) count++;
			if (_mod__AdditionalContactInfo == true) count++;
			if (_mod__Demographics == true) count++;
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
				track_array.AppendDataValue(1, _cur__PersonType);
				track_array.AppendDataValue(2, _cur__NameStyle);
				if (_cur__Title != null) track_array.AppendDataValue(3, _cur__Title);
				track_array.AppendDataValue(4, _cur__FirstName);
				if (_cur__MiddleName != null) track_array.AppendDataValue(5, _cur__MiddleName);
				track_array.AppendDataValue(6, _cur__LastName);
				if (_cur__Suffix != null) track_array.AppendDataValue(7, _cur__Suffix);
				track_array.AppendDataValue(8, _cur__EmailPromotion);
				if (_cur__AdditionalContactInfo != null) track_array.AppendDataValue(9, _cur__AdditionalContactInfo);
				if (_cur__Demographics != null) track_array.AppendDataValue(10, _cur__Demographics);
				track_array.AppendDataValue(11, _cur__rowguid);
				track_array.AppendDataValue(12, _cur__ModifiedDate);
			}
			else if (_recordstatus == DataRecordStatus.Existing)
			{
				if (_started_with_dbvalues)
				{
					if (_mod__BusinessEntityID) track_array.AppendDataValue(0, _cur__BusinessEntityID);
				}
				if (_mod__PersonType) track_array.AppendDataValue(1, _cur__PersonType);
				if (_mod__NameStyle) track_array.AppendDataValue(2, _cur__NameStyle);
				if (_mod__Title) track_array.AppendDataValue(3, _cur__Title);
				if (_mod__FirstName) track_array.AppendDataValue(4, _cur__FirstName);
				if (_mod__MiddleName) track_array.AppendDataValue(5, _cur__MiddleName);
				if (_mod__LastName) track_array.AppendDataValue(6, _cur__LastName);
				if (_mod__Suffix) track_array.AppendDataValue(7, _cur__Suffix);
				if (_mod__EmailPromotion) track_array.AppendDataValue(8, _cur__EmailPromotion);
				if (_mod__AdditionalContactInfo) track_array.AppendDataValue(9, _cur__AdditionalContactInfo);
				if (_mod__Demographics) track_array.AppendDataValue(10, _cur__Demographics);
				if (_mod__rowguid) track_array.AppendDataValue(11, _cur__rowguid);
				if (_mod__ModifiedDate) track_array.AppendDataValue(12, _cur__ModifiedDate);
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
				if (_mod__PersonType) _ori__PersonType = default(string);
				if (_mod__NameStyle) _ori__NameStyle = default(bool);
				if (_mod__Title) _ori__Title = default(string);
				if (_mod__FirstName) _ori__FirstName = default(string);
				if (_mod__MiddleName) _ori__MiddleName = default(string);
				if (_mod__LastName) _ori__LastName = default(string);
				if (_mod__Suffix) _ori__Suffix = default(string);
				if (_mod__EmailPromotion) _ori__EmailPromotion = default(int);
				if (_mod__AdditionalContactInfo) _ori__AdditionalContactInfo = default(string);
				if (_mod__Demographics) _ori__Demographics = default(string);
				if (_mod__rowguid) _ori__rowguid = default(Guid);
				if (_mod__ModifiedDate) _ori__ModifiedDate = default(DateTime);
			}
			_mod__BusinessEntityID = false;
			_mod__PersonType = false;
			_mod__NameStyle = false;
			_mod__Title = false;
			_mod__FirstName = false;
			_mod__MiddleName = false;
			_mod__LastName = false;
			_mod__Suffix = false;
			_mod__EmailPromotion = false;
			_mod__AdditionalContactInfo = false;
			_mod__Demographics = false;
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
	public partial class PriKey_Person_Person_Record
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
