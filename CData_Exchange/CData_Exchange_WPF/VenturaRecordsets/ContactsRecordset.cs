/*
	Project file: "C:\Active\VenturaSQL\BuildSystem\Templates\CData_Exchange\CData_Exchange.venproj"
	Target platform: NETStandard
	Generator version: 3.1.70
	Generated on: Monday, 27 July 2020 at 11:52:05
	At the bottom of this file you find a template for extending Recordsets with calculated columns for XAML data binding.
*/
using Ventura;
using System;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel;

namespace WpfApp1.VenturaRecordsets
{
	/// <summary>
	/// The updateable table is [Exchange].[Contacts]. Updateable table column information:
	/// • 4 out of 135 table columns are present in the resultset.
	/// • All primary key columns are present in the resultset: ItemId.
	/// • Non-primary key columns present in the resultset: DisplayName, EmailAddress1 and MobilePhone.
	/// • Non-primary key columns not present in the resultset: MimeContent, ItemChangeKey, ParentFolderId, ParentFolderChangeKey,
	///   ItemClass, Subject, Sensitivity, Body, DateTimeReceived, Size, Categories, Importance, IsSubmitted, InReplyTo, IsDraft,
	///   IsFromMe, IsResend, IsUnmodified, InternetMessageHeaders, DateTimeSent, DateTimeCreated, ReminderDueBy, ReminderIsSet,
	///   ReminderMinutesBeforeStart, DisplayCc, DisplayTo, HasAttachments, Culture, EffectiveRights_CreateAssociated,
	///   EffectiveRights_CreateContents, EffectiveRights_CreateHierarchy, EffectiveRights_Delete, EffectiveRights_Modify,
	///   EffectiveRights_Read, EffectiveRights_ViewPrivateItems, LastModifiedName, LastModifiedTime, IsAssociated,
	///   WebClientReadFormQueryString, WebClientEditFormQueryString, ConversationId, UniqueBody, UniqueBodyType, FileAs,
	///   FileAsMapping, GivenName, Initials, MiddleName, Nickname, CompleteName_Title, CompleteName_FirstName,
	///   CompleteName_MiddleName, CompleteName_LastName, CompleteName_Suffix, CompleteName_Initials, CompleteName_FullName,
	///   CompleteName_Nickname, CompleteName_YomiFirstName, CompleteName_YomiLastName, CompanyName, EmailAddress2, EmailAddress3,
	///   BusinessAddress_Street, BusinessAddress_City, BusinessAddress_State, BusinessAddress_Country, BusinessAddress_PostalCode,
	///   HomeAddress_Street, HomeAddress_City, HomeAddress_State, HomeAddress_Country, HomeAddress_PostalCode,
	///   OtherAddress_Street, OtherAddress_City, OtherAddress_State, OtherAddress_Country, OtherAddress_PostalCode,
	///   AssistantPhone, BusinessFax, BusinessPhone, BusinessPhone2, Callback, CarPhone, CompanyMainPhone, HomeFax, HomePhone,
	///   HomePhone2, Isdn, OtherFax, OtherTelephone, Pager, PrimaryPhone, RadioPhone, Telex, TtyTddPhone, AssistantName, Birthday,
	///   BusinessHomePage, Children_1, Children_2, Children_3, Companies_1, Companies_2, Companies_3, ContactSource, Department,
	///   Generation, ImAddress1, ImAddress2, ImAddress3, JobTitle, Manager, Mileage, OfficeLocation, PostalAddressIndex,
	///   Profession, SpouseName, Surname, WeddingAnniversary, HasPicture, PhoneticFullName, PhoneticFirstName, PhoneticLastName,
	///   Alias, Notes, Photo, UserSMIMECertificate, MSExchangeCertificate, DirectoryId, ManagerMailbox and DirectReports.
	/// </summary>
	public partial class ContactsRecordset : ResultsetObservable<ContactsRecordset, ContactsRecord>, IRecordsetBase
	{
		private IResultsetBase[] _resultsets;
		private string _sqlscript;
		private int _rowlimit = 500;
		private const string CRLF = "\r\n";

		public ContactsRecordset()
		{
			_resultsets = new IResultsetBase[] { this };

			_sqlscript = @"select DisplayName, MobilePhone, Emailaddress1, ItemID from Exchange.Contacts";

			ColumnArrayBuilder schema_array = new ColumnArrayBuilder();

			schema_array.Add(new VenturaColumn("DisplayName", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "DisplayName"
			});

			schema_array.Add(new VenturaColumn("MobilePhone", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "MobilePhone"
			});

			schema_array.Add(new VenturaColumn("Emailaddress1", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "EmailAddress1"
			});

			schema_array.Add(new VenturaColumn("ItemID", typeof(string), true)
			{
				ColumnSize = 255,
				NumericScale = 0,
				ProviderType = 16,
				IsUnique = true,
				IsKey = true,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "ItemId"
			});

			((IResultsetBase)this).Schema = new VenturaSchema(schema_array);
			((IResultsetBase)this).UpdateableTablename = "[Exchange].[Contacts]";
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Defines the display name of a folder, contact, distribution list, delegate user, location, or rule.
		/// </summary>
		public string DisplayName
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.DisplayName; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.DisplayName = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the MobilePhone number for a contact item.
		/// </summary>
		public string MobilePhone
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.MobilePhone; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.MobilePhone = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents a single email address for a contact.
		/// </summary>
		public string Emailaddress1
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Emailaddress1; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Emailaddress1 = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. PrimaryKey. Readonly. AllowNull.
		/// Contains the unique identifier of an item in the Exchange store. This property is read-only.
		/// </summary>
		public string ItemID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ItemID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ItemID = value; }
		}

		public void ResetToUnmodified()
		{
			if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET);
			CurrentRecord.ResetToUnmodified();
		}

		public void ResetToUnmodifiedExisting()
		{
			if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET);
			CurrentRecord.ResetToUnmodifiedExisting();
		}

		public void ResetToExisting()
		{
			if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET);
			CurrentRecord.ResetToExisting();
		}

		public void Append()
		{
			int index = this.RecordCount;
			this.InsertItem(index, new ContactsRecord());
			this.CurrentRecordIndex = index;
		}

		public void Append(ContactsRecord record)
		{
			int index = this.RecordCount;
			this.InsertItem(index, record);
			this.CurrentRecordIndex = index;
		}

		public ContactsRecord NewRecord()
		{
			return new ContactsRecord();
		}

		protected override ContactsRecord InternalCreateExistingRecordObject(object[] columnvalues) => new ContactsRecord(columnvalues);

		byte[] IRecordsetBase.Hash
		{
			get { return new byte[] { 19, 242, 49, 134, 36, 235, 134, 176, 156, 202, 20, 171, 43, 10, 134, 82 }; }
		}

		string IRecordsetBase.HashString
		{
			get { return "13F2318624EB86B09CCA14AB2B0A8652"; }
		}

		VenturaPlatform IRecordsetBase.GeneratorTarget
		{
			get { return VenturaPlatform.NETStandard; }
		}

		Version IRecordsetBase.GeneratorVersion
		{
			get { return new Version(3,1,70); }
		}

		DateTime IRecordsetBase.GeneratorTimestamp
		{
			get { return new DateTime(2020, 7, 27, 11, 52, 5); } // Monday, 27 July 2020 at 11:52:05
		}

		string IRecordsetBase.GeneratorProviderInvariantName
		{
			get { return "System.Data.CData.Exchange"; }
		}

		IResultsetBase[] IRecordsetBase.Resultsets
		{
			get { return _resultsets; }
		}

		string IRecordsetBase.SqlScript
		{
			get { return _sqlscript; }
		}

		VenturaSchema IRecordsetBase.ParameterSchema
		{
			get { return null; }
		}

		/// <summary>
		/// For internal use by Ventura only. Use SetExecSqlParams() instead.
		/// </summary>
		object[] IRecordsetBase.InputParameterValues
		{
			get { return null; }
		}

		/// <summary>
		/// For internal use by Ventura only. Use Output property instead.
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
			Transactional.ExecSql(VenturaConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public void ExecSql(Connector connector)
		{
			Transactional.ExecSql(connector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync()
		{
			await Transactional.ExecSqlAsync(VenturaConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync(Connector connector)
		{
			await Transactional.ExecSqlAsync(connector, new IRecordsetBase[] { this });
		}

		public void SaveChanges()
		{
			Transactional.SaveChanges(VenturaConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public void SaveChanges(Connector connector)
		{
			Transactional.SaveChanges(connector, new IRecordsetBase[] { this });
		}

		public async Task SaveChangesAsync()
		{
			await Transactional.SaveChangesAsync(VenturaConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public async Task SaveChangesAsync(Connector connector)
		{
			await Transactional.SaveChangesAsync(connector, new IRecordsetBase[] { this });
		}

	}

	public sealed partial class ContactsRecord : IRecordBase, INotifyPropertyChanged
	{
		private DataRecordStatus _recordstatus;
		private bool _started_with_dbvalues;

		private string _cur__DisplayName; private string _ori__DisplayName; private bool _mod__DisplayName;
		private string _cur__MobilePhone; private string _ori__MobilePhone; private bool _mod__MobilePhone;
		private string _cur__Emailaddress1; private string _ori__Emailaddress1; private bool _mod__Emailaddress1;
		private string _cur__ItemID; private string _ori__ItemID; private bool _mod__ItemID;


		public ContactsRecord()
		{
			_cur__DisplayName = null;
			_cur__MobilePhone = null;
			_cur__Emailaddress1 = null;
			_cur__ItemID = null;
			_started_with_dbvalues = false;
			_recordstatus = DataRecordStatus.New;
		}

		public ContactsRecord(object[] columnvalues)
		{
			_cur__DisplayName = (string)columnvalues[0];
			_cur__MobilePhone = (string)columnvalues[1];
			_cur__Emailaddress1 = (string)columnvalues[2];
			_cur__ItemID = (string)columnvalues[3];
			_started_with_dbvalues = true;
			_recordstatus = DataRecordStatus.Existing;
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Defines the display name of a folder, contact, distribution list, delegate user, location, or rule.
		/// </summary>
		public string DisplayName
		{
			get { return _cur__DisplayName; }
			set
			{
				if (_started_with_dbvalues == false) _mod__DisplayName = true;
				if (_cur__DisplayName == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__DisplayName == false) { _ori__DisplayName = _cur__DisplayName; _mod__DisplayName = true; } // existing record and column is not modified
					else { if (value == _ori__DisplayName) { _ori__DisplayName = default(string); _mod__DisplayName = false; } } // existing record and column is modified
				}
				_cur__DisplayName = value; OnPropertyChanged("DisplayName"); OnAfterPropertyChanged("DisplayName");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the MobilePhone number for a contact item.
		/// </summary>
		public string MobilePhone
		{
			get { return _cur__MobilePhone; }
			set
			{
				if (_started_with_dbvalues == false) _mod__MobilePhone = true;
				if (_cur__MobilePhone == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__MobilePhone == false) { _ori__MobilePhone = _cur__MobilePhone; _mod__MobilePhone = true; } // existing record and column is not modified
					else { if (value == _ori__MobilePhone) { _ori__MobilePhone = default(string); _mod__MobilePhone = false; } } // existing record and column is modified
				}
				_cur__MobilePhone = value; OnPropertyChanged("MobilePhone"); OnAfterPropertyChanged("MobilePhone");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents a single email address for a contact.
		/// </summary>
		public string Emailaddress1
		{
			get { return _cur__Emailaddress1; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Emailaddress1 = true;
				if (_cur__Emailaddress1 == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Emailaddress1 == false) { _ori__Emailaddress1 = _cur__Emailaddress1; _mod__Emailaddress1 = true; } // existing record and column is not modified
					else { if (value == _ori__Emailaddress1) { _ori__Emailaddress1 = default(string); _mod__Emailaddress1 = false; } } // existing record and column is modified
				}
				_cur__Emailaddress1 = value; OnPropertyChanged("Emailaddress1"); OnAfterPropertyChanged("Emailaddress1");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. PrimaryKey. Readonly. AllowNull.
		/// Contains the unique identifier of an item in the Exchange store. This property is read-only.
		/// </summary>
		public string ItemID
		{
			get { return _cur__ItemID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ItemID = true;
				if (_cur__ItemID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ItemID == false) { _ori__ItemID = _cur__ItemID; _mod__ItemID = true; } // existing record and column is not modified
					else { if (value == _ori__ItemID) { _ori__ItemID = default(string); _mod__ItemID = false; } } // existing record and column is modified
				}
				_cur__ItemID = value; OnPropertyChanged("ItemID"); OnAfterPropertyChanged("ItemID");
			}
		}

		public bool IsModified(string column_name)
		{
			if (column_name == "DisplayName") return _mod__DisplayName;
			if (column_name == "MobilePhone") return _mod__MobilePhone;
			if (column_name == "Emailaddress1") return _mod__Emailaddress1;
			if (column_name == "ItemID") return _mod__ItemID;
			throw new ArgumentOutOfRangeException(String.Format(VenturaStrings.UNKNOWN_COLUMN_NAME, column_name));
		}

		public int ModifiedColumnCount()
		{
			int count = 0;
			if (_mod__DisplayName == true) count++;
			if (_mod__MobilePhone == true) count++;
			if (_mod__Emailaddress1 == true) count++;
			if (_mod__ItemID == true) count++;
			return count;
		}

		public bool PendingChanges()
		{
			if (_recordstatus == DataRecordStatus.New || _recordstatus == DataRecordStatus.ExistingDelete) return true;
			int count = 0;
			if (_mod__DisplayName == true) count++;
			if (_mod__MobilePhone == true) count++;
			if (_mod__Emailaddress1 == true) count++;
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
				if (_cur__DisplayName != null) track_array.AppendDataValue(0, _cur__DisplayName);
				if (_cur__MobilePhone != null) track_array.AppendDataValue(1, _cur__MobilePhone);
				if (_cur__Emailaddress1 != null) track_array.AppendDataValue(2, _cur__Emailaddress1);
			}
			else if (_recordstatus == DataRecordStatus.Existing)
			{
				if (_mod__DisplayName) track_array.AppendDataValue(0, _cur__DisplayName);
				if (_mod__MobilePhone) track_array.AppendDataValue(1, _cur__MobilePhone);
				if (_mod__Emailaddress1) track_array.AppendDataValue(2, _cur__Emailaddress1);
				if (track_array.HasData == false) return;
			}

			if (_recordstatus == DataRecordStatus.Existing || _recordstatus == DataRecordStatus.ExistingDelete)
			{
				track_array.AppendPrikeyValue(3, (_mod__ItemID && _started_with_dbvalues) ? _ori__ItemID : _cur__ItemID);
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
				if (_mod__DisplayName) _ori__DisplayName = default(string);
				if (_mod__MobilePhone) _ori__MobilePhone = default(string);
				if (_mod__Emailaddress1) _ori__Emailaddress1 = default(string);
				if (_mod__ItemID) _ori__ItemID = default(string);
			}
			_mod__DisplayName = false;
			_mod__MobilePhone = false;
			_mod__Emailaddress1 = false;
			_mod__ItemID = false;
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
// How to guide: https://docs.venturatools.com/CalculatedColumns.html

/*
namespace WpfApp1.VenturaRecordsets
{
	public partial class ContactsRecord
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
