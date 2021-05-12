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

namespace AspNetCoreServer.VenturaRecordsets
{
	/// <summary>
	/// The resultset is read-only.
	/// </summary>
	public partial class JoinRecordset : ResultsetObservable<JoinRecordset, JoinRecord>, IRecordsetBase
	{
		private IResultsetBase[] _resultsets;
		private string _sqlscript;
		private int _rowlimit = 500;
		private const string CRLF = "\r\n";

		public JoinRecordset()
		{
			_resultsets = new IResultsetBase[] { this };

			_sqlscript = @"SELECT TOP (10) e.BusinessEntityID, p.Title, p.FirstName, p.MiddleName, p.LastName, p.Suffix, e.JobTitle, pp.PhoneNumber, pnt.Name AS PhoneNumberType, ea.EmailAddress, p.EmailPromotion, a.AddressLine1, a.AddressLine2, a.City, sp.Name AS StateProvinceName, a.PostalCode, cr.Name AS CountryRegionName, " + CRLF +
			             @"           p.AdditionalContactInfo" + CRLF +
			             @"FROM   HumanResources.Employee AS e INNER JOIN" + CRLF +
			             @"           Person.Person AS p ON p.BusinessEntityID = e.BusinessEntityID INNER JOIN" + CRLF +
			             @"           Person.BusinessEntityAddress AS bea ON bea.BusinessEntityID = e.BusinessEntityID INNER JOIN" + CRLF +
			             @"           Person.Address AS a ON a.AddressID = bea.AddressID INNER JOIN" + CRLF +
			             @"           Person.StateProvince AS sp ON sp.StateProvinceID = a.StateProvinceID INNER JOIN" + CRLF +
			             @"           Person.CountryRegion AS cr ON cr.CountryRegionCode = sp.CountryRegionCode LEFT OUTER JOIN" + CRLF +
			             @"           Person.PersonPhone AS pp ON pp.BusinessEntityID = p.BusinessEntityID LEFT OUTER JOIN" + CRLF +
			             @"           Person.PhoneNumberType AS pnt ON pp.PhoneNumberTypeID = pnt.PhoneNumberTypeID LEFT OUTER JOIN" + CRLF +
			             @"           Person.EmailAddress AS ea ON p.BusinessEntityID = ea.BusinessEntityID";

			ColumnArrayBuilder schema_array = new ColumnArrayBuilder();

			schema_array.Add(new VenturaSqlColumn("BusinessEntityID", typeof(int), false)
			{
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				IsKey = true,
				BaseSchemaName = "HumanResources",
				BaseTableName = "Employee",
				BaseColumnName = "BusinessEntityID"
			});

			schema_array.Add(new VenturaSqlColumn("Title", typeof(string), true)
			{
				ColumnSize = 8,
				ProviderType = 12,
				BaseSchemaName = "Person",
				BaseTableName = "Person",
				BaseColumnName = "Title"
			});

			schema_array.Add(new VenturaSqlColumn("FirstName", typeof(string), false)
			{
				ColumnSize = 50,
				ProviderType = 12,
				BaseSchemaName = "Person",
				BaseTableName = "Person",
				BaseColumnName = "FirstName"
			});

			schema_array.Add(new VenturaSqlColumn("MiddleName", typeof(string), true)
			{
				ColumnSize = 50,
				ProviderType = 12,
				BaseSchemaName = "Person",
				BaseTableName = "Person",
				BaseColumnName = "MiddleName"
			});

			schema_array.Add(new VenturaSqlColumn("LastName", typeof(string), false)
			{
				ColumnSize = 50,
				ProviderType = 12,
				BaseSchemaName = "Person",
				BaseTableName = "Person",
				BaseColumnName = "LastName"
			});

			schema_array.Add(new VenturaSqlColumn("Suffix", typeof(string), true)
			{
				ColumnSize = 10,
				ProviderType = 12,
				BaseSchemaName = "Person",
				BaseTableName = "Person",
				BaseColumnName = "Suffix"
			});

			schema_array.Add(new VenturaSqlColumn("JobTitle", typeof(string), false)
			{
				ColumnSize = 50,
				ProviderType = 12,
				BaseSchemaName = "HumanResources",
				BaseTableName = "Employee",
				BaseColumnName = "JobTitle"
			});

			schema_array.Add(new VenturaSqlColumn("PhoneNumber", typeof(string), true)
			{
				ColumnSize = 25,
				ProviderType = 12,
				IsKey = true,
				BaseSchemaName = "Person",
				BaseTableName = "PersonPhone",
				BaseColumnName = "PhoneNumber"
			});

			schema_array.Add(new VenturaSqlColumn("PhoneNumberType", typeof(string), true)
			{
				ColumnSize = 50,
				ProviderType = 12,
				IsAliased = true,
				BaseSchemaName = "Person",
				BaseTableName = "PhoneNumberType",
				BaseColumnName = "Name"
			});

			schema_array.Add(new VenturaSqlColumn("EmailAddress", typeof(string), true)
			{
				ColumnSize = 50,
				ProviderType = 12,
				BaseSchemaName = "Person",
				BaseTableName = "EmailAddress",
				BaseColumnName = "EmailAddress"
			});

			schema_array.Add(new VenturaSqlColumn("EmailPromotion", typeof(int), false)
			{
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				BaseSchemaName = "Person",
				BaseTableName = "Person",
				BaseColumnName = "EmailPromotion"
			});

			schema_array.Add(new VenturaSqlColumn("AddressLine1", typeof(string), false)
			{
				ColumnSize = 60,
				ProviderType = 12,
				BaseSchemaName = "Person",
				BaseTableName = "Address",
				BaseColumnName = "AddressLine1"
			});

			schema_array.Add(new VenturaSqlColumn("AddressLine2", typeof(string), true)
			{
				ColumnSize = 60,
				ProviderType = 12,
				BaseSchemaName = "Person",
				BaseTableName = "Address",
				BaseColumnName = "AddressLine2"
			});

			schema_array.Add(new VenturaSqlColumn("City", typeof(string), false)
			{
				ColumnSize = 30,
				ProviderType = 12,
				BaseSchemaName = "Person",
				BaseTableName = "Address",
				BaseColumnName = "City"
			});

			schema_array.Add(new VenturaSqlColumn("StateProvinceName", typeof(string), false)
			{
				ColumnSize = 50,
				ProviderType = 12,
				IsAliased = true,
				BaseSchemaName = "Person",
				BaseTableName = "StateProvince",
				BaseColumnName = "Name"
			});

			schema_array.Add(new VenturaSqlColumn("PostalCode", typeof(string), false)
			{
				ColumnSize = 15,
				ProviderType = 12,
				BaseSchemaName = "Person",
				BaseTableName = "Address",
				BaseColumnName = "PostalCode"
			});

			schema_array.Add(new VenturaSqlColumn("CountryRegionName", typeof(string), false)
			{
				ColumnSize = 50,
				ProviderType = 12,
				IsAliased = true,
				BaseSchemaName = "Person",
				BaseTableName = "CountryRegion",
				BaseColumnName = "Name"
			});

			schema_array.Add(new VenturaSqlColumn("AdditionalContactInfo", typeof(string), true)
			{
				ProviderType = 25,
				IsLong = true,
				XmlSchemaCollectionDatabase = "AdventureWorks2017",
				XmlSchemaCollectionOwningSchema = "Person",
				XmlSchemaCollectionName = "AdditionalContactInfoSchemaCollection",
				BaseSchemaName = "Person",
				BaseTableName = "Person",
				BaseColumnName = "AdditionalContactInfo"
			});

			((IResultsetBase)this).Schema = new VenturaSqlSchema(schema_array);
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [HumanResources].[Employee]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public int BusinessEntityID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.BusinessEntityID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.BusinessEntityID = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Person].[Person]. NotReadonly. AllowNull.
		/// </summary>
		public string Title
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Title; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Title = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Person].[Person]. NotReadonly. NotNull.
		/// </summary>
		public string FirstName
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.FirstName; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.FirstName = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Person].[Person]. NotReadonly. AllowNull.
		/// </summary>
		public string MiddleName
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.MiddleName; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.MiddleName = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Person].[Person]. NotReadonly. NotNull.
		/// </summary>
		public string LastName
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.LastName; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.LastName = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Person].[Person]. NotReadonly. AllowNull.
		/// </summary>
		public string Suffix
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Suffix; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Suffix = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [HumanResources].[Employee]. NotReadonly. NotNull.
		/// </summary>
		public string JobTitle
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.JobTitle; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.JobTitle = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Person].[PersonPhone]. PrimaryKey. NotReadonly. AllowNull.
		/// </summary>
		public string PhoneNumber
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.PhoneNumber; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.PhoneNumber = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Person].[PhoneNumberType]. NotReadonly. AllowNull.
		/// </summary>
		public string PhoneNumberType
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.PhoneNumberType; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.PhoneNumberType = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Person].[EmailAddress]. NotReadonly. AllowNull.
		/// </summary>
		public string EmailAddress
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.EmailAddress; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.EmailAddress = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Person].[Person]. NotReadonly. NotNull.
		/// </summary>
		public int EmailPromotion
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.EmailPromotion; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.EmailPromotion = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Person].[Address]. NotReadonly. NotNull.
		/// </summary>
		public string AddressLine1
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.AddressLine1; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.AddressLine1 = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Person].[Address]. NotReadonly. AllowNull.
		/// </summary>
		public string AddressLine2
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.AddressLine2; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.AddressLine2 = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Person].[Address]. NotReadonly. NotNull.
		/// </summary>
		public string City
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.City; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.City = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Person].[StateProvince]. NotReadonly. NotNull.
		/// </summary>
		public string StateProvinceName
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.StateProvinceName; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.StateProvinceName = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Person].[Address]. NotReadonly. NotNull.
		/// </summary>
		public string PostalCode
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.PostalCode; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.PostalCode = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Person].[CountryRegion]. NotReadonly. NotNull.
		/// </summary>
		public string CountryRegionName
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.CountryRegionName; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.CountryRegionName = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Person].[Person]. NotReadonly. AllowNull.
		/// </summary>
		public string AdditionalContactInfo
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.AdditionalContactInfo; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.AdditionalContactInfo = value; }
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
			this.InsertItem(index, new JoinRecord());
			this.CurrentRecordIndex = index;
		}

		public void Append(JoinRecord record)
		{
			int index = this.RecordCount;
			this.InsertItem(index, record);
			this.CurrentRecordIndex = index;
		}

		public JoinRecord NewRecord()
		{
			return new JoinRecord();
		}

		protected override JoinRecord InternalCreateExistingRecordObject(object[] columnvalues) => new JoinRecord(columnvalues);

		byte[] IRecordsetBase.Hash
		{
			get { return new byte[] { 179, 25, 33, 180, 12, 59, 28, 82, 42, 252, 75, 102, 49, 99, 31, 87 }; }
		}

		string IRecordsetBase.HashString
		{
			get { return "B31921B40C3B1C522AFC4B6631631F57"; }
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

	}

	public sealed partial class JoinRecord : IRecordBase, INotifyPropertyChanged
	{
		private DataRecordStatus _recordstatus;
		private bool _started_with_dbvalues;

		private int _cur__BusinessEntityID; private int _ori__BusinessEntityID; private bool _mod__BusinessEntityID;
		private string _cur__Title; private string _ori__Title; private bool _mod__Title;
		private string _cur__FirstName; private string _ori__FirstName; private bool _mod__FirstName;
		private string _cur__MiddleName; private string _ori__MiddleName; private bool _mod__MiddleName;
		private string _cur__LastName; private string _ori__LastName; private bool _mod__LastName;
		private string _cur__Suffix; private string _ori__Suffix; private bool _mod__Suffix;
		private string _cur__JobTitle; private string _ori__JobTitle; private bool _mod__JobTitle;
		private string _cur__PhoneNumber; private string _ori__PhoneNumber; private bool _mod__PhoneNumber;
		private string _cur__PhoneNumberType; private string _ori__PhoneNumberType; private bool _mod__PhoneNumberType;
		private string _cur__EmailAddress; private string _ori__EmailAddress; private bool _mod__EmailAddress;
		private int _cur__EmailPromotion; private int _ori__EmailPromotion; private bool _mod__EmailPromotion;
		private string _cur__AddressLine1; private string _ori__AddressLine1; private bool _mod__AddressLine1;
		private string _cur__AddressLine2; private string _ori__AddressLine2; private bool _mod__AddressLine2;
		private string _cur__City; private string _ori__City; private bool _mod__City;
		private string _cur__StateProvinceName; private string _ori__StateProvinceName; private bool _mod__StateProvinceName;
		private string _cur__PostalCode; private string _ori__PostalCode; private bool _mod__PostalCode;
		private string _cur__CountryRegionName; private string _ori__CountryRegionName; private bool _mod__CountryRegionName;
		private string _cur__AdditionalContactInfo; private string _ori__AdditionalContactInfo; private bool _mod__AdditionalContactInfo;


		public JoinRecord()
		{
			_cur__BusinessEntityID = 0;
			_cur__Title = null;
			_cur__FirstName = "";
			_cur__MiddleName = null;
			_cur__LastName = "";
			_cur__Suffix = null;
			_cur__JobTitle = "";
			_cur__PhoneNumber = null;
			_cur__PhoneNumberType = null;
			_cur__EmailAddress = null;
			_cur__EmailPromotion = 0;
			_cur__AddressLine1 = "";
			_cur__AddressLine2 = null;
			_cur__City = "";
			_cur__StateProvinceName = "";
			_cur__PostalCode = "";
			_cur__CountryRegionName = "";
			_cur__AdditionalContactInfo = null;
			_started_with_dbvalues = false;
			_recordstatus = DataRecordStatus.New;
		}

		public JoinRecord(object[] columnvalues)
		{
			_cur__BusinessEntityID = (int)columnvalues[0];
			_cur__Title = (string)columnvalues[1];
			_cur__FirstName = (string)columnvalues[2];
			_cur__MiddleName = (string)columnvalues[3];
			_cur__LastName = (string)columnvalues[4];
			_cur__Suffix = (string)columnvalues[5];
			_cur__JobTitle = (string)columnvalues[6];
			_cur__PhoneNumber = (string)columnvalues[7];
			_cur__PhoneNumberType = (string)columnvalues[8];
			_cur__EmailAddress = (string)columnvalues[9];
			_cur__EmailPromotion = (int)columnvalues[10];
			_cur__AddressLine1 = (string)columnvalues[11];
			_cur__AddressLine2 = (string)columnvalues[12];
			_cur__City = (string)columnvalues[13];
			_cur__StateProvinceName = (string)columnvalues[14];
			_cur__PostalCode = (string)columnvalues[15];
			_cur__CountryRegionName = (string)columnvalues[16];
			_cur__AdditionalContactInfo = (string)columnvalues[17];
			_started_with_dbvalues = true;
			_recordstatus = DataRecordStatus.Existing;
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [HumanResources].[Employee]. PrimaryKey. NotReadonly. NotNull.
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
		/// Database Column NotUpdateable. Table [Person].[Person]. NotReadonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Person].[Person]. NotReadonly. NotNull.
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
		/// Database Column NotUpdateable. Table [Person].[Person]. NotReadonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Person].[Person]. NotReadonly. NotNull.
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
		/// Database Column NotUpdateable. Table [Person].[Person]. NotReadonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [HumanResources].[Employee]. NotReadonly. NotNull.
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
		/// Database Column NotUpdateable. Table [Person].[PersonPhone]. PrimaryKey. NotReadonly. AllowNull.
		/// </summary>
		public string PhoneNumber
		{
			get { return _cur__PhoneNumber; }
			set
			{
				if (_started_with_dbvalues == false) _mod__PhoneNumber = true;
				if (_cur__PhoneNumber == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__PhoneNumber == false) { _ori__PhoneNumber = _cur__PhoneNumber; _mod__PhoneNumber = true; } // existing record and column is not modified
					else { if (value == _ori__PhoneNumber) { _ori__PhoneNumber = default(string); _mod__PhoneNumber = false; } } // existing record and column is modified
				}
				_cur__PhoneNumber = value; OnPropertyChanged("PhoneNumber"); OnAfterPropertyChanged("PhoneNumber");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Person].[PhoneNumberType]. NotReadonly. AllowNull.
		/// </summary>
		public string PhoneNumberType
		{
			get { return _cur__PhoneNumberType; }
			set
			{
				if (_started_with_dbvalues == false) _mod__PhoneNumberType = true;
				if (_cur__PhoneNumberType == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__PhoneNumberType == false) { _ori__PhoneNumberType = _cur__PhoneNumberType; _mod__PhoneNumberType = true; } // existing record and column is not modified
					else { if (value == _ori__PhoneNumberType) { _ori__PhoneNumberType = default(string); _mod__PhoneNumberType = false; } } // existing record and column is modified
				}
				_cur__PhoneNumberType = value; OnPropertyChanged("PhoneNumberType"); OnAfterPropertyChanged("PhoneNumberType");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Person].[EmailAddress]. NotReadonly. AllowNull.
		/// </summary>
		public string EmailAddress
		{
			get { return _cur__EmailAddress; }
			set
			{
				if (_started_with_dbvalues == false) _mod__EmailAddress = true;
				if (_cur__EmailAddress == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__EmailAddress == false) { _ori__EmailAddress = _cur__EmailAddress; _mod__EmailAddress = true; } // existing record and column is not modified
					else { if (value == _ori__EmailAddress) { _ori__EmailAddress = default(string); _mod__EmailAddress = false; } } // existing record and column is modified
				}
				_cur__EmailAddress = value; OnPropertyChanged("EmailAddress"); OnAfterPropertyChanged("EmailAddress");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Person].[Person]. NotReadonly. NotNull.
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
		/// Database Column NotUpdateable. Table [Person].[Address]. NotReadonly. NotNull.
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
		/// Database Column NotUpdateable. Table [Person].[Address]. NotReadonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Person].[Address]. NotReadonly. NotNull.
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
		/// Database Column NotUpdateable. Table [Person].[StateProvince]. NotReadonly. NotNull.
		/// </summary>
		public string StateProvinceName
		{
			get { return _cur__StateProvinceName; }
			set
			{
				if (value == null) throw new ArgumentNullException("StateProvinceName", VenturaSqlStrings.SET_NULL_MSG);
				if (_started_with_dbvalues == false) _mod__StateProvinceName = true;
				if (_cur__StateProvinceName == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__StateProvinceName == false) { _ori__StateProvinceName = _cur__StateProvinceName; _mod__StateProvinceName = true; } // existing record and column is not modified
					else { if (value == _ori__StateProvinceName) { _ori__StateProvinceName = default(string); _mod__StateProvinceName = false; } } // existing record and column is modified
				}
				_cur__StateProvinceName = value; OnPropertyChanged("StateProvinceName"); OnAfterPropertyChanged("StateProvinceName");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Person].[Address]. NotReadonly. NotNull.
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
		/// Database Column NotUpdateable. Table [Person].[CountryRegion]. NotReadonly. NotNull.
		/// </summary>
		public string CountryRegionName
		{
			get { return _cur__CountryRegionName; }
			set
			{
				if (value == null) throw new ArgumentNullException("CountryRegionName", VenturaSqlStrings.SET_NULL_MSG);
				if (_started_with_dbvalues == false) _mod__CountryRegionName = true;
				if (_cur__CountryRegionName == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__CountryRegionName == false) { _ori__CountryRegionName = _cur__CountryRegionName; _mod__CountryRegionName = true; } // existing record and column is not modified
					else { if (value == _ori__CountryRegionName) { _ori__CountryRegionName = default(string); _mod__CountryRegionName = false; } } // existing record and column is modified
				}
				_cur__CountryRegionName = value; OnPropertyChanged("CountryRegionName"); OnAfterPropertyChanged("CountryRegionName");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Person].[Person]. NotReadonly. AllowNull.
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

		public bool IsModified(string column_name)
		{
			if (column_name == "BusinessEntityID") return _mod__BusinessEntityID;
			if (column_name == "Title") return _mod__Title;
			if (column_name == "FirstName") return _mod__FirstName;
			if (column_name == "MiddleName") return _mod__MiddleName;
			if (column_name == "LastName") return _mod__LastName;
			if (column_name == "Suffix") return _mod__Suffix;
			if (column_name == "JobTitle") return _mod__JobTitle;
			if (column_name == "PhoneNumber") return _mod__PhoneNumber;
			if (column_name == "PhoneNumberType") return _mod__PhoneNumberType;
			if (column_name == "EmailAddress") return _mod__EmailAddress;
			if (column_name == "EmailPromotion") return _mod__EmailPromotion;
			if (column_name == "AddressLine1") return _mod__AddressLine1;
			if (column_name == "AddressLine2") return _mod__AddressLine2;
			if (column_name == "City") return _mod__City;
			if (column_name == "StateProvinceName") return _mod__StateProvinceName;
			if (column_name == "PostalCode") return _mod__PostalCode;
			if (column_name == "CountryRegionName") return _mod__CountryRegionName;
			if (column_name == "AdditionalContactInfo") return _mod__AdditionalContactInfo;
			throw new ArgumentOutOfRangeException(String.Format(VenturaSqlStrings.UNKNOWN_COLUMN_NAME, column_name));
		}

		public int ModifiedColumnCount()
		{
			int count = 0;
			if (_mod__BusinessEntityID == true) count++;
			if (_mod__Title == true) count++;
			if (_mod__FirstName == true) count++;
			if (_mod__MiddleName == true) count++;
			if (_mod__LastName == true) count++;
			if (_mod__Suffix == true) count++;
			if (_mod__JobTitle == true) count++;
			if (_mod__PhoneNumber == true) count++;
			if (_mod__PhoneNumberType == true) count++;
			if (_mod__EmailAddress == true) count++;
			if (_mod__EmailPromotion == true) count++;
			if (_mod__AddressLine1 == true) count++;
			if (_mod__AddressLine2 == true) count++;
			if (_mod__City == true) count++;
			if (_mod__StateProvinceName == true) count++;
			if (_mod__PostalCode == true) count++;
			if (_mod__CountryRegionName == true) count++;
			if (_mod__AdditionalContactInfo == true) count++;
			return count;
		}

		public bool PendingChanges()
		{
			return false;
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
				if (_mod__Title) _ori__Title = default(string);
				if (_mod__FirstName) _ori__FirstName = default(string);
				if (_mod__MiddleName) _ori__MiddleName = default(string);
				if (_mod__LastName) _ori__LastName = default(string);
				if (_mod__Suffix) _ori__Suffix = default(string);
				if (_mod__JobTitle) _ori__JobTitle = default(string);
				if (_mod__PhoneNumber) _ori__PhoneNumber = default(string);
				if (_mod__PhoneNumberType) _ori__PhoneNumberType = default(string);
				if (_mod__EmailAddress) _ori__EmailAddress = default(string);
				if (_mod__EmailPromotion) _ori__EmailPromotion = default(int);
				if (_mod__AddressLine1) _ori__AddressLine1 = default(string);
				if (_mod__AddressLine2) _ori__AddressLine2 = default(string);
				if (_mod__City) _ori__City = default(string);
				if (_mod__StateProvinceName) _ori__StateProvinceName = default(string);
				if (_mod__PostalCode) _ori__PostalCode = default(string);
				if (_mod__CountryRegionName) _ori__CountryRegionName = default(string);
				if (_mod__AdditionalContactInfo) _ori__AdditionalContactInfo = default(string);
			}
			_mod__BusinessEntityID = false;
			_mod__Title = false;
			_mod__FirstName = false;
			_mod__MiddleName = false;
			_mod__LastName = false;
			_mod__Suffix = false;
			_mod__JobTitle = false;
			_mod__PhoneNumber = false;
			_mod__PhoneNumberType = false;
			_mod__EmailAddress = false;
			_mod__EmailPromotion = false;
			_mod__AddressLine1 = false;
			_mod__AddressLine2 = false;
			_mod__City = false;
			_mod__StateProvinceName = false;
			_mod__PostalCode = false;
			_mod__CountryRegionName = false;
			_mod__AdditionalContactInfo = false;
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
namespace AspNetCoreServer.VenturaRecordsets
{
	public partial class JoinRecord
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
