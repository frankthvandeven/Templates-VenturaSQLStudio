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

namespace WpfApp1.VenturaAutoCreate
{
	/// <summary>
	/// The updateable table is [Exchange].[Contacts]. Updateable table column information:
	/// • 135 out of 135 table columns are present in the resultset.
	/// • All primary key columns are present in the resultset: ItemId.
	/// • Non-primary key columns present in the resultset: MimeContent, ItemChangeKey, ParentFolderId, ParentFolderChangeKey,
	///   ItemClass, Subject, Sensitivity, Body, DateTimeReceived, Size, Categories, Importance, IsSubmitted, InReplyTo, IsDraft,
	///   IsFromMe, IsResend, IsUnmodified, InternetMessageHeaders, DateTimeSent, DateTimeCreated, ReminderDueBy, ReminderIsSet,
	///   ReminderMinutesBeforeStart, DisplayCc, DisplayTo, HasAttachments, Culture, EffectiveRights_CreateAssociated,
	///   EffectiveRights_CreateContents, EffectiveRights_CreateHierarchy, EffectiveRights_Delete, EffectiveRights_Modify,
	///   EffectiveRights_Read, EffectiveRights_ViewPrivateItems, LastModifiedName, LastModifiedTime, IsAssociated,
	///   WebClientReadFormQueryString, WebClientEditFormQueryString, ConversationId, UniqueBody, UniqueBodyType, FileAs,
	///   FileAsMapping, DisplayName, GivenName, Initials, MiddleName, Nickname, CompleteName_Title, CompleteName_FirstName,
	///   CompleteName_MiddleName, CompleteName_LastName, CompleteName_Suffix, CompleteName_Initials, CompleteName_FullName,
	///   CompleteName_Nickname, CompleteName_YomiFirstName, CompleteName_YomiLastName, CompanyName, EmailAddress1, EmailAddress2,
	///   EmailAddress3, BusinessAddress_Street, BusinessAddress_City, BusinessAddress_State, BusinessAddress_Country,
	///   BusinessAddress_PostalCode, HomeAddress_Street, HomeAddress_City, HomeAddress_State, HomeAddress_Country,
	///   HomeAddress_PostalCode, OtherAddress_Street, OtherAddress_City, OtherAddress_State, OtherAddress_Country,
	///   OtherAddress_PostalCode, AssistantPhone, BusinessFax, BusinessPhone, BusinessPhone2, Callback, CarPhone,
	///   CompanyMainPhone, HomeFax, HomePhone, HomePhone2, Isdn, MobilePhone, OtherFax, OtherTelephone, Pager, PrimaryPhone,
	///   RadioPhone, Telex, TtyTddPhone, AssistantName, Birthday, BusinessHomePage, Children_1, Children_2, Children_3,
	///   Companies_1, Companies_2, Companies_3, ContactSource, Department, Generation, ImAddress1, ImAddress2, ImAddress3,
	///   JobTitle, Manager, Mileage, OfficeLocation, PostalAddressIndex, Profession, SpouseName, Surname, WeddingAnniversary,
	///   HasPicture, PhoneticFullName, PhoneticFirstName, PhoneticLastName, Alias, Notes, Photo, UserSMIMECertificate,
	///   MSExchangeCertificate, DirectoryId, ManagerMailbox and DirectReports.
	/// Recordset item automatically created by Ventura SQL Studio.
	/// </summary>
	public partial class PriKey_Contacts_Recordset : ResultsetObservable<PriKey_Contacts_Recordset, PriKey_Contacts_Record>, IRecordsetBase
	{
		private IResultsetBase[] _resultsets;
		private string _sqlscript;
		private object[] _inputparametervalues;
		private InputParamHolder _inputparamholder;
		private VenturaSchema _parameterschema;
		private int _rowlimit = 500;
		private const string CRLF = "\r\n";

		public PriKey_Contacts_Recordset()
		{
			_resultsets = new IResultsetBase[] { this };

			_sqlscript = @"SELECT [ItemId],[MimeContent],[ItemChangeKey],[ParentFolderId],[ParentFolderChangeKey],[ItemClass],[Subject],[Sensitivity],[Body],[DateTimeReceived],[Size]," + CRLF +
			             @"[Categories],[Importance],[IsSubmitted],[InReplyTo],[IsDraft],[IsFromMe],[IsResend],[IsUnmodified],[InternetMessageHeaders],[DateTimeSent],[DateTimeCreated]," + CRLF +
			             @"[ReminderDueBy],[ReminderIsSet],[ReminderMinutesBeforeStart],[DisplayCc],[DisplayTo],[HasAttachments],[Culture],[EffectiveRights_CreateAssociated],[EffectiveRights_CreateContents]," + CRLF +
			             @"[EffectiveRights_CreateHierarchy],[EffectiveRights_Delete],[EffectiveRights_Modify],[EffectiveRights_Read],[EffectiveRights_ViewPrivateItems],[LastModifiedName]," + CRLF +
			             @"[LastModifiedTime],[IsAssociated],[WebClientReadFormQueryString],[WebClientEditFormQueryString],[ConversationId],[UniqueBody],[UniqueBodyType],[FileAs]," + CRLF +
			             @"[FileAsMapping],[DisplayName],[GivenName],[Initials],[MiddleName],[Nickname],[CompleteName_Title],[CompleteName_FirstName],[CompleteName_MiddleName],[CompleteName_LastName]," + CRLF +
			             @"[CompleteName_Suffix],[CompleteName_Initials],[CompleteName_FullName],[CompleteName_Nickname],[CompleteName_YomiFirstName],[CompleteName_YomiLastName]," + CRLF +
			             @"[CompanyName],[EmailAddress1],[EmailAddress2],[EmailAddress3],[BusinessAddress_Street],[BusinessAddress_City],[BusinessAddress_State],[BusinessAddress_Country]," + CRLF +
			             @"[BusinessAddress_PostalCode],[HomeAddress_Street],[HomeAddress_City],[HomeAddress_State],[HomeAddress_Country],[HomeAddress_PostalCode],[OtherAddress_Street]," + CRLF +
			             @"[OtherAddress_City],[OtherAddress_State],[OtherAddress_Country],[OtherAddress_PostalCode],[AssistantPhone],[BusinessFax],[BusinessPhone],[BusinessPhone2]," + CRLF +
			             @"[Callback],[CarPhone],[CompanyMainPhone],[HomeFax],[HomePhone],[HomePhone2],[Isdn],[MobilePhone],[OtherFax],[OtherTelephone],[Pager],[PrimaryPhone],[RadioPhone]," + CRLF +
			             @"[Telex],[TtyTddPhone],[AssistantName],[Birthday],[BusinessHomePage],[Children_1],[Children_2],[Children_3],[Companies_1],[Companies_2],[Companies_3],[ContactSource]," + CRLF +
			             @"[Department],[Generation],[ImAddress1],[ImAddress2],[ImAddress3],[JobTitle],[Manager],[Mileage],[OfficeLocation],[PostalAddressIndex],[Profession],[SpouseName]," + CRLF +
			             @"[Surname],[WeddingAnniversary],[HasPicture],[PhoneticFullName],[PhoneticFirstName],[PhoneticLastName],[Alias],[Notes],[Photo],[UserSMIMECertificate],[MSExchangeCertificate]," + CRLF +
			             @"[DirectoryId],[ManagerMailbox],[DirectReports]" + CRLF +
			             @"FROM [Exchange].[Contacts]" + CRLF +
			             @"WHERE [ItemId] = @ItemId";

			_inputparametervalues = new object[1];
			_inputparamholder = new InputParamHolder(_inputparametervalues);

			ColumnArrayBuilder param_array = new ColumnArrayBuilder();

			param_array.AddParameterColumn("@ItemId", typeof(string), true, false, DbType.String, null, null, null);

			_parameterschema = new VenturaSchema(param_array);

			ColumnArrayBuilder schema_array = new ColumnArrayBuilder();

			schema_array.Add(new VenturaColumn("ItemId", typeof(string), true)
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

			schema_array.Add(new VenturaColumn("MimeContent", typeof(string), true)
			{
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "MimeContent"
			});

			schema_array.Add(new VenturaColumn("ItemChangeKey", typeof(string), true)
			{
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "ItemChangeKey"
			});

			schema_array.Add(new VenturaColumn("ParentFolderId", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "ParentFolderId"
			});

			schema_array.Add(new VenturaColumn("ParentFolderChangeKey", typeof(string), true)
			{
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "ParentFolderChangeKey"
			});

			schema_array.Add(new VenturaColumn("ItemClass", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "ItemClass"
			});

			schema_array.Add(new VenturaColumn("Subject", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "Subject"
			});

			schema_array.Add(new VenturaColumn("Sensitivity", typeof(string), true)
			{
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "Sensitivity"
			});

			schema_array.Add(new VenturaColumn("Body", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "Body"
			});

			schema_array.Add(new VenturaColumn("DateTimeReceived", typeof(DateTime), true)
			{
				ColumnSize = 16,
				NumericPrecision = 8,
				NumericScale = 0,
				ProviderType = 6,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "DateTimeReceived"
			});

			schema_array.Add(new VenturaColumn("Size", typeof(int), true)
			{
				ColumnSize = 11,
				NumericPrecision = 10,
				NumericScale = 0,
				ProviderType = 11,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "Size"
			});

			schema_array.Add(new VenturaColumn("Categories", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "Categories"
			});

			schema_array.Add(new VenturaColumn("Importance", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "Importance"
			});

			schema_array.Add(new VenturaColumn("IsSubmitted", typeof(bool), true)
			{
				ColumnSize = 1,
				NumericPrecision = 1,
				NumericScale = 0,
				ProviderType = 3,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "IsSubmitted"
			});

			schema_array.Add(new VenturaColumn("InReplyTo", typeof(string), true)
			{
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "InReplyTo"
			});

			schema_array.Add(new VenturaColumn("IsDraft", typeof(bool), true)
			{
				ColumnSize = 1,
				NumericPrecision = 1,
				NumericScale = 0,
				ProviderType = 3,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "IsDraft"
			});

			schema_array.Add(new VenturaColumn("IsFromMe", typeof(bool), true)
			{
				ColumnSize = 1,
				NumericPrecision = 1,
				NumericScale = 0,
				ProviderType = 3,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "IsFromMe"
			});

			schema_array.Add(new VenturaColumn("IsResend", typeof(bool), true)
			{
				ColumnSize = 1,
				NumericPrecision = 1,
				NumericScale = 0,
				ProviderType = 3,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "IsResend"
			});

			schema_array.Add(new VenturaColumn("IsUnmodified", typeof(bool), true)
			{
				ColumnSize = 1,
				NumericPrecision = 1,
				NumericScale = 0,
				ProviderType = 3,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "IsUnmodified"
			});

			schema_array.Add(new VenturaColumn("InternetMessageHeaders", typeof(string), true)
			{
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "InternetMessageHeaders"
			});

			schema_array.Add(new VenturaColumn("DateTimeSent", typeof(DateTime), true)
			{
				ColumnSize = 16,
				NumericPrecision = 8,
				NumericScale = 0,
				ProviderType = 6,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "DateTimeSent"
			});

			schema_array.Add(new VenturaColumn("DateTimeCreated", typeof(DateTime), true)
			{
				ColumnSize = 16,
				NumericPrecision = 8,
				NumericScale = 0,
				ProviderType = 6,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "DateTimeCreated"
			});

			schema_array.Add(new VenturaColumn("ReminderDueBy", typeof(DateTime), true)
			{
				Updateable = true,
				ColumnSize = 16,
				NumericPrecision = 8,
				NumericScale = 0,
				ProviderType = 6,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "ReminderDueBy"
			});

			schema_array.Add(new VenturaColumn("ReminderIsSet", typeof(bool), true)
			{
				Updateable = true,
				ColumnSize = 1,
				NumericPrecision = 1,
				NumericScale = 0,
				ProviderType = 3,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "ReminderIsSet"
			});

			schema_array.Add(new VenturaColumn("ReminderMinutesBeforeStart", typeof(int), true)
			{
				Updateable = true,
				ColumnSize = 11,
				NumericPrecision = 10,
				NumericScale = 0,
				ProviderType = 11,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "ReminderMinutesBeforeStart"
			});

			schema_array.Add(new VenturaColumn("DisplayCc", typeof(string), true)
			{
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "DisplayCc"
			});

			schema_array.Add(new VenturaColumn("DisplayTo", typeof(string), true)
			{
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "DisplayTo"
			});

			schema_array.Add(new VenturaColumn("HasAttachments", typeof(bool), true)
			{
				ColumnSize = 1,
				NumericPrecision = 1,
				NumericScale = 0,
				ProviderType = 3,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "HasAttachments"
			});

			schema_array.Add(new VenturaColumn("Culture", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "Culture"
			});

			schema_array.Add(new VenturaColumn("EffectiveRights_CreateAssociated", typeof(bool), true)
			{
				ColumnSize = 1,
				NumericPrecision = 1,
				NumericScale = 0,
				ProviderType = 3,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "EffectiveRights_CreateAssociated"
			});

			schema_array.Add(new VenturaColumn("EffectiveRights_CreateContents", typeof(bool), true)
			{
				ColumnSize = 1,
				NumericPrecision = 1,
				NumericScale = 0,
				ProviderType = 3,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "EffectiveRights_CreateContents"
			});

			schema_array.Add(new VenturaColumn("EffectiveRights_CreateHierarchy", typeof(bool), true)
			{
				ColumnSize = 1,
				NumericPrecision = 1,
				NumericScale = 0,
				ProviderType = 3,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "EffectiveRights_CreateHierarchy"
			});

			schema_array.Add(new VenturaColumn("EffectiveRights_Delete", typeof(bool), true)
			{
				ColumnSize = 1,
				NumericPrecision = 1,
				NumericScale = 0,
				ProviderType = 3,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "EffectiveRights_Delete"
			});

			schema_array.Add(new VenturaColumn("EffectiveRights_Modify", typeof(bool), true)
			{
				ColumnSize = 1,
				NumericPrecision = 1,
				NumericScale = 0,
				ProviderType = 3,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "EffectiveRights_Modify"
			});

			schema_array.Add(new VenturaColumn("EffectiveRights_Read", typeof(bool), true)
			{
				ColumnSize = 1,
				NumericPrecision = 1,
				NumericScale = 0,
				ProviderType = 3,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "EffectiveRights_Read"
			});

			schema_array.Add(new VenturaColumn("EffectiveRights_ViewPrivateItems", typeof(bool), true)
			{
				ColumnSize = 1,
				NumericPrecision = 1,
				NumericScale = 0,
				ProviderType = 3,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "EffectiveRights_ViewPrivateItems"
			});

			schema_array.Add(new VenturaColumn("LastModifiedName", typeof(string), true)
			{
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "LastModifiedName"
			});

			schema_array.Add(new VenturaColumn("LastModifiedTime", typeof(DateTime), true)
			{
				ColumnSize = 16,
				NumericPrecision = 8,
				NumericScale = 0,
				ProviderType = 6,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "LastModifiedTime"
			});

			schema_array.Add(new VenturaColumn("IsAssociated", typeof(bool), true)
			{
				Updateable = true,
				ColumnSize = 1,
				NumericPrecision = 1,
				NumericScale = 0,
				ProviderType = 3,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "IsAssociated"
			});

			schema_array.Add(new VenturaColumn("WebClientReadFormQueryString", typeof(string), true)
			{
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "WebClientReadFormQueryString"
			});

			schema_array.Add(new VenturaColumn("WebClientEditFormQueryString", typeof(string), true)
			{
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "WebClientEditFormQueryString"
			});

			schema_array.Add(new VenturaColumn("ConversationId", typeof(string), true)
			{
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "ConversationId"
			});

			schema_array.Add(new VenturaColumn("UniqueBody", typeof(string), true)
			{
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "UniqueBody"
			});

			schema_array.Add(new VenturaColumn("UniqueBodyType", typeof(string), true)
			{
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "UniqueBodyType"
			});

			schema_array.Add(new VenturaColumn("FileAs", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "FileAs"
			});

			schema_array.Add(new VenturaColumn("FileAsMapping", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "FileAsMapping"
			});

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

			schema_array.Add(new VenturaColumn("GivenName", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "GivenName"
			});

			schema_array.Add(new VenturaColumn("Initials", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "Initials"
			});

			schema_array.Add(new VenturaColumn("MiddleName", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "MiddleName"
			});

			schema_array.Add(new VenturaColumn("Nickname", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "Nickname"
			});

			schema_array.Add(new VenturaColumn("CompleteName_Title", typeof(string), true)
			{
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "CompleteName_Title"
			});

			schema_array.Add(new VenturaColumn("CompleteName_FirstName", typeof(string), true)
			{
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "CompleteName_FirstName"
			});

			schema_array.Add(new VenturaColumn("CompleteName_MiddleName", typeof(string), true)
			{
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "CompleteName_MiddleName"
			});

			schema_array.Add(new VenturaColumn("CompleteName_LastName", typeof(string), true)
			{
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "CompleteName_LastName"
			});

			schema_array.Add(new VenturaColumn("CompleteName_Suffix", typeof(string), true)
			{
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "CompleteName_Suffix"
			});

			schema_array.Add(new VenturaColumn("CompleteName_Initials", typeof(string), true)
			{
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "CompleteName_Initials"
			});

			schema_array.Add(new VenturaColumn("CompleteName_FullName", typeof(string), true)
			{
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "CompleteName_FullName"
			});

			schema_array.Add(new VenturaColumn("CompleteName_Nickname", typeof(string), true)
			{
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "CompleteName_Nickname"
			});

			schema_array.Add(new VenturaColumn("CompleteName_YomiFirstName", typeof(string), true)
			{
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "CompleteName_YomiFirstName"
			});

			schema_array.Add(new VenturaColumn("CompleteName_YomiLastName", typeof(string), true)
			{
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "CompleteName_YomiLastName"
			});

			schema_array.Add(new VenturaColumn("CompanyName", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "CompanyName"
			});

			schema_array.Add(new VenturaColumn("EmailAddress1", typeof(string), true)
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

			schema_array.Add(new VenturaColumn("EmailAddress2", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "EmailAddress2"
			});

			schema_array.Add(new VenturaColumn("EmailAddress3", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "EmailAddress3"
			});

			schema_array.Add(new VenturaColumn("BusinessAddress_Street", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "BusinessAddress_Street"
			});

			schema_array.Add(new VenturaColumn("BusinessAddress_City", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "BusinessAddress_City"
			});

			schema_array.Add(new VenturaColumn("BusinessAddress_State", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "BusinessAddress_State"
			});

			schema_array.Add(new VenturaColumn("BusinessAddress_Country", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "BusinessAddress_Country"
			});

			schema_array.Add(new VenturaColumn("BusinessAddress_PostalCode", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "BusinessAddress_PostalCode"
			});

			schema_array.Add(new VenturaColumn("HomeAddress_Street", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "HomeAddress_Street"
			});

			schema_array.Add(new VenturaColumn("HomeAddress_City", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "HomeAddress_City"
			});

			schema_array.Add(new VenturaColumn("HomeAddress_State", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "HomeAddress_State"
			});

			schema_array.Add(new VenturaColumn("HomeAddress_Country", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "HomeAddress_Country"
			});

			schema_array.Add(new VenturaColumn("HomeAddress_PostalCode", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "HomeAddress_PostalCode"
			});

			schema_array.Add(new VenturaColumn("OtherAddress_Street", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "OtherAddress_Street"
			});

			schema_array.Add(new VenturaColumn("OtherAddress_City", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "OtherAddress_City"
			});

			schema_array.Add(new VenturaColumn("OtherAddress_State", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "OtherAddress_State"
			});

			schema_array.Add(new VenturaColumn("OtherAddress_Country", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "OtherAddress_Country"
			});

			schema_array.Add(new VenturaColumn("OtherAddress_PostalCode", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "OtherAddress_PostalCode"
			});

			schema_array.Add(new VenturaColumn("AssistantPhone", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "AssistantPhone"
			});

			schema_array.Add(new VenturaColumn("BusinessFax", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "BusinessFax"
			});

			schema_array.Add(new VenturaColumn("BusinessPhone", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "BusinessPhone"
			});

			schema_array.Add(new VenturaColumn("BusinessPhone2", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "BusinessPhone2"
			});

			schema_array.Add(new VenturaColumn("Callback", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "Callback"
			});

			schema_array.Add(new VenturaColumn("CarPhone", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "CarPhone"
			});

			schema_array.Add(new VenturaColumn("CompanyMainPhone", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "CompanyMainPhone"
			});

			schema_array.Add(new VenturaColumn("HomeFax", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "HomeFax"
			});

			schema_array.Add(new VenturaColumn("HomePhone", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "HomePhone"
			});

			schema_array.Add(new VenturaColumn("HomePhone2", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "HomePhone2"
			});

			schema_array.Add(new VenturaColumn("Isdn", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "Isdn"
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

			schema_array.Add(new VenturaColumn("OtherFax", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "OtherFax"
			});

			schema_array.Add(new VenturaColumn("OtherTelephone", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "OtherTelephone"
			});

			schema_array.Add(new VenturaColumn("Pager", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "Pager"
			});

			schema_array.Add(new VenturaColumn("PrimaryPhone", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "PrimaryPhone"
			});

			schema_array.Add(new VenturaColumn("RadioPhone", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "RadioPhone"
			});

			schema_array.Add(new VenturaColumn("Telex", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "Telex"
			});

			schema_array.Add(new VenturaColumn("TtyTddPhone", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "TtyTddPhone"
			});

			schema_array.Add(new VenturaColumn("AssistantName", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "AssistantName"
			});

			schema_array.Add(new VenturaColumn("Birthday", typeof(DateTime), true)
			{
				Updateable = true,
				ColumnSize = 16,
				NumericPrecision = 8,
				NumericScale = 0,
				ProviderType = 6,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "Birthday"
			});

			schema_array.Add(new VenturaColumn("BusinessHomePage", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "BusinessHomePage"
			});

			schema_array.Add(new VenturaColumn("Children_1", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "Children_1"
			});

			schema_array.Add(new VenturaColumn("Children_2", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "Children_2"
			});

			schema_array.Add(new VenturaColumn("Children_3", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "Children_3"
			});

			schema_array.Add(new VenturaColumn("Companies_1", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "Companies_1"
			});

			schema_array.Add(new VenturaColumn("Companies_2", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "Companies_2"
			});

			schema_array.Add(new VenturaColumn("Companies_3", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "Companies_3"
			});

			schema_array.Add(new VenturaColumn("ContactSource", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "ContactSource"
			});

			schema_array.Add(new VenturaColumn("Department", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "Department"
			});

			schema_array.Add(new VenturaColumn("Generation", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "Generation"
			});

			schema_array.Add(new VenturaColumn("ImAddress1", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "ImAddress1"
			});

			schema_array.Add(new VenturaColumn("ImAddress2", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "ImAddress2"
			});

			schema_array.Add(new VenturaColumn("ImAddress3", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "ImAddress3"
			});

			schema_array.Add(new VenturaColumn("JobTitle", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "JobTitle"
			});

			schema_array.Add(new VenturaColumn("Manager", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "Manager"
			});

			schema_array.Add(new VenturaColumn("Mileage", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "Mileage"
			});

			schema_array.Add(new VenturaColumn("OfficeLocation", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "OfficeLocation"
			});

			schema_array.Add(new VenturaColumn("PostalAddressIndex", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "PostalAddressIndex"
			});

			schema_array.Add(new VenturaColumn("Profession", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "Profession"
			});

			schema_array.Add(new VenturaColumn("SpouseName", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "SpouseName"
			});

			schema_array.Add(new VenturaColumn("Surname", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "Surname"
			});

			schema_array.Add(new VenturaColumn("WeddingAnniversary", typeof(DateTime), true)
			{
				Updateable = true,
				ColumnSize = 16,
				NumericPrecision = 8,
				NumericScale = 0,
				ProviderType = 6,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "WeddingAnniversary"
			});

			schema_array.Add(new VenturaColumn("HasPicture", typeof(bool), true)
			{
				Updateable = true,
				ColumnSize = 1,
				NumericPrecision = 1,
				NumericScale = 0,
				ProviderType = 3,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "HasPicture"
			});

			schema_array.Add(new VenturaColumn("PhoneticFullName", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "PhoneticFullName"
			});

			schema_array.Add(new VenturaColumn("PhoneticFirstName", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "PhoneticFirstName"
			});

			schema_array.Add(new VenturaColumn("PhoneticLastName", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "PhoneticLastName"
			});

			schema_array.Add(new VenturaColumn("Alias", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "Alias"
			});

			schema_array.Add(new VenturaColumn("Notes", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "Notes"
			});

			schema_array.Add(new VenturaColumn("Photo", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "Photo"
			});

			schema_array.Add(new VenturaColumn("UserSMIMECertificate", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "UserSMIMECertificate"
			});

			schema_array.Add(new VenturaColumn("MSExchangeCertificate", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "MSExchangeCertificate"
			});

			schema_array.Add(new VenturaColumn("DirectoryId", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "DirectoryId"
			});

			schema_array.Add(new VenturaColumn("ManagerMailbox", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "ManagerMailbox"
			});

			schema_array.Add(new VenturaColumn("DirectReports", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Contacts",
				BaseColumnName = "DirectReports"
			});

			((IResultsetBase)this).Schema = new VenturaSchema(schema_array);
			((IResultsetBase)this).UpdateableTablename = "[Exchange].[Contacts]";
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. PrimaryKey. Readonly. AllowNull.
		/// Contains the unique identifier of an item in the Exchange store. This property is read-only.
		/// </summary>
		public string ItemId
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ItemId; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ItemId = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Contains the native Multipurpose Internet Mail Extensions (MIME) stream of an object that is represented in Base64
		/// binary format.
		/// </summary>
		public string MimeContent
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.MimeContent; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.MimeContent = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Contains the unique change key of an item in the Exchange store. This property is read-only.
		/// </summary>
		public string ItemChangeKey
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ItemChangeKey; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ItemChangeKey = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the unique identifier of the parent folder that contains the item or folder. This property is read-only.
		/// </summary>
		public string ParentFolderId
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ParentFolderId; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ParentFolderId = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Represents the unique change key of the parent folder that contains the item or folder. This property is read-only.
		/// </summary>
		public string ParentFolderChangeKey
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ParentFolderChangeKey; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ParentFolderChangeKey = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the message class of an item.
		/// </summary>
		public string ItemClass
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ItemClass; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ItemClass = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the subject for Exchange store items and response objects. The subject is limited to 255 characters.
		/// </summary>
		public string Subject
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Subject; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Subject = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Indicates the sensitivity level of an item.
		/// </summary>
		public string Sensitivity
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Sensitivity; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Sensitivity = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the actual body content of a message.
		/// </summary>
		public string Body
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Body; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Body = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Represents the date and time that an item in a mailbox was received.
		/// </summary>
		public DateTime? DateTimeReceived
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.DateTimeReceived; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.DateTimeReceived = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Represents the size in bytes of an item. This property is read-only.
		/// </summary>
		public int? Size
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Size; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Size = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents a collection of strings that identify to which categories an item in the mailbox belongs.
		/// </summary>
		public string Categories
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Categories; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Categories = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Describes the importance of an item.
		/// </summary>
		public string Importance
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Importance; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Importance = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Indicates whether an item has been submitted to the Outbox default folder.
		/// </summary>
		public bool? IsSubmitted
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.IsSubmitted; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.IsSubmitted = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Represents the identifier of the item to which this item is a reply.
		/// </summary>
		public string InReplyTo
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.InReplyTo; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.InReplyTo = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Represents whether an item has not yet been sent.
		/// </summary>
		public bool? IsDraft
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.IsDraft; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.IsDraft = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Indicates whether a user sent an item to himself or herself.
		/// </summary>
		public bool? IsFromMe
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.IsFromMe; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.IsFromMe = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Indicates whether the item had previously been sent.
		/// </summary>
		public bool? IsResend
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.IsResend; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.IsResend = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Indicates whether the item has been modified.
		/// </summary>
		public bool? IsUnmodified
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.IsUnmodified; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.IsUnmodified = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Represents the collection of all Internet message headers that are contained within an item in a mailbox.
		/// </summary>
		public string InternetMessageHeaders
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.InternetMessageHeaders; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.InternetMessageHeaders = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Represents the date and time that an item in a mailbox was sent.
		/// </summary>
		public DateTime? DateTimeSent
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.DateTimeSent; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.DateTimeSent = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Represents the date and time that a given item in the mailbox was created.
		/// </summary>
		public DateTime? DateTimeCreated
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.DateTimeCreated; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.DateTimeCreated = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the date and time when the event occurs.
		/// </summary>
		public DateTime? ReminderDueBy
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ReminderDueBy; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ReminderDueBy = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Indicates whether a reminder has been set for an item in the Exchange store.
		/// </summary>
		public bool? ReminderIsSet
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ReminderIsSet; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ReminderIsSet = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the number of minutes before an event occurs when a reminder is displayed.
		/// </summary>
		public int? ReminderMinutesBeforeStart
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ReminderMinutesBeforeStart; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ReminderMinutesBeforeStart = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Represents the display string that is used for the contents of the Cc box. This is the concatenated string of all Cc
		/// recipient display names.
		/// </summary>
		public string DisplayCc
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.DisplayCc; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.DisplayCc = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Represents the display string that is used for the contents of the To box. This is the concatenated string of all To
		/// recipient display names.
		/// </summary>
		public string DisplayTo
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.DisplayTo; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.DisplayTo = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Represents a property that is set to true if an item has at least one visible attachment. This property is read-only.
		/// </summary>
		public bool? HasAttachments
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.HasAttachments; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.HasAttachments = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the culture for a given item in a mailbox.
		/// </summary>
		public string Culture
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Culture; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Culture = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Indicates whether a client can create an associated contents table.
		/// </summary>
		public bool? EffectiveRights_CreateAssociated
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.EffectiveRights_CreateAssociated; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.EffectiveRights_CreateAssociated = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Indicates whether a client can create a contents table.
		/// </summary>
		public bool? EffectiveRights_CreateContents
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.EffectiveRights_CreateContents; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.EffectiveRights_CreateContents = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Indicates whether a client can create a hierarchy table.
		/// </summary>
		public bool? EffectiveRights_CreateHierarchy
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.EffectiveRights_CreateHierarchy; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.EffectiveRights_CreateHierarchy = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Indicates whether a client can delete a folder or item.
		/// </summary>
		public bool? EffectiveRights_Delete
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.EffectiveRights_Delete; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.EffectiveRights_Delete = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Indicates whether a client can modify a folder or item.
		/// </summary>
		public bool? EffectiveRights_Modify
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.EffectiveRights_Modify; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.EffectiveRights_Modify = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Indicates whether a client can read a folder or item.
		/// </summary>
		public bool? EffectiveRights_Read
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.EffectiveRights_Read; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.EffectiveRights_Read = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Indicates whether a private item can be viewed.
		/// </summary>
		public bool? EffectiveRights_ViewPrivateItems
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.EffectiveRights_ViewPrivateItems; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.EffectiveRights_ViewPrivateItems = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Contains the display name of the last user to modify an item.
		/// </summary>
		public string LastModifiedName
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.LastModifiedName; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.LastModifiedName = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Indicates when an item was last modified. This element is read-only.
		/// </summary>
		public DateTime? LastModifiedTime
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.LastModifiedTime; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.LastModifiedTime = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Indicates whether the item is associated with a folder.
		/// </summary>
		public bool? IsAssociated
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.IsAssociated; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.IsAssociated = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Represents a URL to concatenate to the Microsoft Office Outlook Web App endpoint to read an item in Outlook Web App.
		/// </summary>
		public string WebClientReadFormQueryString
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.WebClientReadFormQueryString; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.WebClientReadFormQueryString = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Represents a URL to concatenate to the Outlook Web App endpoint to edit an item in Outlook Web App.
		/// </summary>
		public string WebClientEditFormQueryString
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.WebClientEditFormQueryString; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.WebClientEditFormQueryString = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Identifies a specific conversation in the Exchange store.
		/// </summary>
		public string ConversationId
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ConversationId; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ConversationId = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Represents an HTML fragment or plain-text which represents the unique body of this conversation.
		/// </summary>
		public string UniqueBody
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.UniqueBody; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.UniqueBody = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Describes how the unique item body is stored in the item (HTML or TEXT).
		/// </summary>
		public string UniqueBodyType
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.UniqueBodyType; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.UniqueBodyType = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents how a contact or distribution list is filed in the Contacts folder.
		/// </summary>
		public string FileAs
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.FileAs; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.FileAs = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Defines how to construct what is displayed for a contact.
		/// </summary>
		public string FileAsMapping
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.FileAsMapping; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.FileAsMapping = value; }
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
		/// Contains the given name of a contact.
		/// </summary>
		public string GivenName
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.GivenName; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.GivenName = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the initials of a contact.
		/// </summary>
		public string Initials
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Initials; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Initials = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the middle name of a contact.
		/// </summary>
		public string MiddleName
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.MiddleName; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.MiddleName = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the nickname of a contact.
		/// </summary>
		public string Nickname
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Nickname; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Nickname = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Represents the title of a contact.
		/// </summary>
		public string CompleteName_Title
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.CompleteName_Title; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.CompleteName_Title = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Represents the first name of a contact.
		/// </summary>
		public string CompleteName_FirstName
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.CompleteName_FirstName; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.CompleteName_FirstName = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Represents the middle name of a contact.
		/// </summary>
		public string CompleteName_MiddleName
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.CompleteName_MiddleName; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.CompleteName_MiddleName = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Represents the last name of a contact.
		/// </summary>
		public string CompleteName_LastName
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.CompleteName_LastName; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.CompleteName_LastName = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Represents the suffix of a contact.
		/// </summary>
		public string CompleteName_Suffix
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.CompleteName_Suffix; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.CompleteName_Suffix = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Represents the initials of a contact.
		/// </summary>
		public string CompleteName_Initials
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.CompleteName_Initials; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.CompleteName_Initials = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Represents the full name of a contact.
		/// </summary>
		public string CompleteName_FullName
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.CompleteName_FullName; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.CompleteName_FullName = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Represents the nickname of a contact.
		/// </summary>
		public string CompleteName_Nickname
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.CompleteName_Nickname; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.CompleteName_Nickname = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Represents the name used in Japan for the searchable or phonetic spelling of a Japanese first name.
		/// </summary>
		public string CompleteName_YomiFirstName
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.CompleteName_YomiFirstName; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.CompleteName_YomiFirstName = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Represents the name used in Japan for the searchable or phonetic spelling of a Japanese first name.
		/// </summary>
		public string CompleteName_YomiLastName
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.CompleteName_YomiLastName; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.CompleteName_YomiLastName = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the company name that is associated with a contact.
		/// </summary>
		public string CompanyName
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.CompanyName; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.CompanyName = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents a single email address for a contact.
		/// </summary>
		public string EmailAddress1
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.EmailAddress1; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.EmailAddress1 = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents a single email address for a contact.
		/// </summary>
		public string EmailAddress2
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.EmailAddress2; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.EmailAddress2 = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents a single email address for a contact.
		/// </summary>
		public string EmailAddress3
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.EmailAddress3; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.EmailAddress3 = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the Business street address for a contact item.
		/// </summary>
		public string BusinessAddress_Street
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.BusinessAddress_Street; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.BusinessAddress_Street = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the Business city name for a contact item.
		/// </summary>
		public string BusinessAddress_City
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.BusinessAddress_City; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.BusinessAddress_City = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the Business state of residence for a contact item.
		/// </summary>
		public string BusinessAddress_State
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.BusinessAddress_State; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.BusinessAddress_State = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the Business country or region for a contact item.
		/// </summary>
		public string BusinessAddress_Country
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.BusinessAddress_Country; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.BusinessAddress_Country = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the Business postal code for a contact item.
		/// </summary>
		public string BusinessAddress_PostalCode
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.BusinessAddress_PostalCode; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.BusinessAddress_PostalCode = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the Home street address for a contact item.
		/// </summary>
		public string HomeAddress_Street
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.HomeAddress_Street; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.HomeAddress_Street = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the Home city name for a contact item.
		/// </summary>
		public string HomeAddress_City
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.HomeAddress_City; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.HomeAddress_City = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the Home state of residence for a contact item.
		/// </summary>
		public string HomeAddress_State
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.HomeAddress_State; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.HomeAddress_State = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the Home country or region for a contact item.
		/// </summary>
		public string HomeAddress_Country
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.HomeAddress_Country; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.HomeAddress_Country = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the Home postal code for a contact item.
		/// </summary>
		public string HomeAddress_PostalCode
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.HomeAddress_PostalCode; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.HomeAddress_PostalCode = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the Other street address for a contact item.
		/// </summary>
		public string OtherAddress_Street
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.OtherAddress_Street; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.OtherAddress_Street = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the Other city name for a contact item.
		/// </summary>
		public string OtherAddress_City
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.OtherAddress_City; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.OtherAddress_City = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the Other state of residence for a contact item.
		/// </summary>
		public string OtherAddress_State
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.OtherAddress_State; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.OtherAddress_State = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the Other country or region for a contact item.
		/// </summary>
		public string OtherAddress_Country
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.OtherAddress_Country; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.OtherAddress_Country = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the Other postal code for a contact item.
		/// </summary>
		public string OtherAddress_PostalCode
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.OtherAddress_PostalCode; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.OtherAddress_PostalCode = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the AssistantPhone number for a contact item.
		/// </summary>
		public string AssistantPhone
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.AssistantPhone; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.AssistantPhone = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the BusinessFax number for a contact item.
		/// </summary>
		public string BusinessFax
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.BusinessFax; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.BusinessFax = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the BusinessPhone number for a contact item.
		/// </summary>
		public string BusinessPhone
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.BusinessPhone; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.BusinessPhone = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the BusinessPhone2 number for a contact item.
		/// </summary>
		public string BusinessPhone2
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.BusinessPhone2; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.BusinessPhone2 = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the Callback number for a contact item.
		/// </summary>
		public string Callback
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Callback; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Callback = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the CarPhone number for a contact item.
		/// </summary>
		public string CarPhone
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.CarPhone; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.CarPhone = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the CompanyMainPhone number for a contact item.
		/// </summary>
		public string CompanyMainPhone
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.CompanyMainPhone; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.CompanyMainPhone = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the HomeFax number for a contact item.
		/// </summary>
		public string HomeFax
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.HomeFax; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.HomeFax = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the HomePhone number for a contact item.
		/// </summary>
		public string HomePhone
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.HomePhone; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.HomePhone = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the HomePhone2 number for a contact item.
		/// </summary>
		public string HomePhone2
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.HomePhone2; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.HomePhone2 = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the Isdn number for a contact item.
		/// </summary>
		public string Isdn
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Isdn; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Isdn = value; }
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
		/// Represents the OtherFax number for a contact item.
		/// </summary>
		public string OtherFax
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.OtherFax; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.OtherFax = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the OtherTelephone number for a contact item.
		/// </summary>
		public string OtherTelephone
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.OtherTelephone; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.OtherTelephone = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the Pager number for a contact item.
		/// </summary>
		public string Pager
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Pager; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Pager = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the PrimaryPhone number for a contact item.
		/// </summary>
		public string PrimaryPhone
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.PrimaryPhone; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.PrimaryPhone = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the RadioPhone number for a contact item.
		/// </summary>
		public string RadioPhone
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.RadioPhone; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.RadioPhone = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the Telex number for a contact item.
		/// </summary>
		public string Telex
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Telex; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Telex = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the TtyTddPhone number for a contact item.
		/// </summary>
		public string TtyTddPhone
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.TtyTddPhone; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.TtyTddPhone = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents an assistant to a contact.
		/// </summary>
		public string AssistantName
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.AssistantName; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.AssistantName = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the birth date of a contact.
		/// </summary>
		public DateTime? Birthday
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Birthday; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Birthday = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the Home page (Web address) for the contact.
		/// </summary>
		public string BusinessHomePage
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.BusinessHomePage; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.BusinessHomePage = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Contains the name of the child of a contact.
		/// </summary>
		public string Children_1
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Children_1; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Children_1 = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Contains the name of the child of a contact.
		/// </summary>
		public string Children_2
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Children_2; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Children_2 = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Contains the name of the child of a contact.
		/// </summary>
		public string Children_3
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Children_3; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Children_3 = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the name of a company associated with a contact.
		/// </summary>
		public string Companies_1
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Companies_1; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Companies_1 = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the name of a company associated with a contact.
		/// </summary>
		public string Companies_2
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Companies_2; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Companies_2 = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the name of a company associated with a contact.
		/// </summary>
		public string Companies_3
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Companies_3; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Companies_3 = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Describes whether the contact is located in the Exchange store or Active Directory Domain Services.
		/// </summary>
		public string ContactSource
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ContactSource; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ContactSource = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the department of a contact.
		/// </summary>
		public string Department
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Department; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Department = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents a generational abbreviation that follows the full name of a contact.
		/// </summary>
		public string Generation
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Generation; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Generation = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents an instant messaging (IM) address for a contact.
		/// </summary>
		public string ImAddress1
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ImAddress1; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ImAddress1 = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents an instant messaging (IM) address for a contact.
		/// </summary>
		public string ImAddress2
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ImAddress2; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ImAddress2 = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents an instant messaging (IM) address for a contact.
		/// </summary>
		public string ImAddress3
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ImAddress3; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ImAddress3 = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the job title of a contact.
		/// </summary>
		public string JobTitle
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.JobTitle; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.JobTitle = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the manager of a contact.
		/// </summary>
		public string Manager
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Manager; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Manager = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the mileage for a contact item.
		/// </summary>
		public string Mileage
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Mileage; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Mileage = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the office location of a contact.
		/// </summary>
		public string OfficeLocation
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.OfficeLocation; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.OfficeLocation = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the display type for the physical address of a contact.
		/// </summary>
		public string PostalAddressIndex
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.PostalAddressIndex; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.PostalAddressIndex = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the profession of a contact.
		/// </summary>
		public string Profession
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Profession; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Profession = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the name of the spouse or partner of the contact.
		/// </summary>
		public string SpouseName
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.SpouseName; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.SpouseName = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the surname of a contact.
		/// </summary>
		public string Surname
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Surname; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Surname = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Contains the wedding anniversary of a contact.
		/// </summary>
		public DateTime? WeddingAnniversary
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.WeddingAnniversary; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.WeddingAnniversary = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Indicates whether the contact item has a file attachment that represents the picture of a contact.
		/// </summary>
		public bool? HasPicture
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.HasPicture; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.HasPicture = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Contains the full name of a contact, including the first and last name, spelled phonetically.
		/// </summary>
		public string PhoneticFullName
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.PhoneticFullName; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.PhoneticFullName = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Contains the first name of a contact, spelled phonetically.
		/// </summary>
		public string PhoneticFirstName
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.PhoneticFirstName; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.PhoneticFirstName = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Contains the last name of a contact, spelled phonetically.
		/// </summary>
		public string PhoneticLastName
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.PhoneticLastName; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.PhoneticLastName = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Contains the email alias of a contact.
		/// </summary>
		public string Alias
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Alias; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Alias = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Contains supplementary contact information.
		/// </summary>
		public string Notes
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Notes; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Notes = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Contains a value that encodes the photo of a contact.
		/// </summary>
		public string Photo
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Photo; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Photo = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Contains a value that encodes the SMIME certificate of a contact.
		/// </summary>
		public string UserSMIMECertificate
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.UserSMIMECertificate; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.UserSMIMECertificate = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Contains a value that encodes the Microsoft Exchange certificate of a contact.
		/// </summary>
		public string MSExchangeCertificate
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.MSExchangeCertificate; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.MSExchangeCertificate = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Contains the directory Id of a contact.
		/// </summary>
		public string DirectoryId
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.DirectoryId; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.DirectoryId = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Contains SMTP information that identifies the mailbox of the manager of a contact.
		/// </summary>
		public string ManagerMailbox
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ManagerMailbox; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ManagerMailbox = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Contains SMTP information that identifies the direct reports of a contact.
		/// </summary>
		public string DirectReports
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.DirectReports; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.DirectReports = value; }
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
			this.InsertItem(index, new PriKey_Contacts_Record());
			this.CurrentRecordIndex = index;
		}

		public void Append(PriKey_Contacts_Record record)
		{
			int index = this.RecordCount;
			this.InsertItem(index, record);
			this.CurrentRecordIndex = index;
		}

		public PriKey_Contacts_Record NewRecord()
		{
			return new PriKey_Contacts_Record();
		}

		protected override PriKey_Contacts_Record InternalCreateExistingRecordObject(object[] columnvalues) => new PriKey_Contacts_Record(columnvalues);

		byte[] IRecordsetBase.Hash
		{
			get { return new byte[] { 221, 199, 208, 3, 138, 113, 6, 70, 159, 250, 252, 125, 113, 247, 135, 177 }; }
		}

		string IRecordsetBase.HashString
		{
			get { return "DDC7D0038A7106469FFAFC7D71F787B1"; }
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
			get { return _parameterschema; }
		}

		/// <summary>
		/// For internal use by Ventura only. Use SetExecSqlParams() instead.
		/// </summary>
		object[] IRecordsetBase.InputParameterValues
		{
			get { return _inputparametervalues; }
		}

		/// <summary>
		/// For internal use by Ventura only. Use Output property instead.
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

		public void SetExecSqlParams(string ItemId)
		{
			_inputparametervalues[0] = ItemId;
		}

		public void ExecSql(string ItemId)
		{
			_inputparametervalues[0] = ItemId;
			Transactional.ExecSql(VenturaConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public void ExecSql(Connector connector, string ItemId)
		{
			_inputparametervalues[0] = ItemId;
			Transactional.ExecSql(connector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync(string ItemId)
		{
			_inputparametervalues[0] = ItemId;
			await Transactional.ExecSqlAsync(VenturaConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync(Connector connector, string ItemId)
		{
			_inputparametervalues[0] = ItemId;
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

		public class InputParamHolder
		{
			private object[] _values;

			public InputParamHolder(object[] values)
			{
				_values = values;
			}

			public string ItemId
			{
				get { return (string)_values[0]; }
				set { _values[0] = value; }
			}

		}

	}

	public sealed partial class PriKey_Contacts_Record : IRecordBase, INotifyPropertyChanged
	{
		private DataRecordStatus _recordstatus;
		private bool _started_with_dbvalues;

		private string _cur__ItemId; private string _ori__ItemId; private bool _mod__ItemId;
		private string _cur__MimeContent; private string _ori__MimeContent; private bool _mod__MimeContent;
		private string _cur__ItemChangeKey; private string _ori__ItemChangeKey; private bool _mod__ItemChangeKey;
		private string _cur__ParentFolderId; private string _ori__ParentFolderId; private bool _mod__ParentFolderId;
		private string _cur__ParentFolderChangeKey; private string _ori__ParentFolderChangeKey; private bool _mod__ParentFolderChangeKey;
		private string _cur__ItemClass; private string _ori__ItemClass; private bool _mod__ItemClass;
		private string _cur__Subject; private string _ori__Subject; private bool _mod__Subject;
		private string _cur__Sensitivity; private string _ori__Sensitivity; private bool _mod__Sensitivity;
		private string _cur__Body; private string _ori__Body; private bool _mod__Body;
		private DateTime? _cur__DateTimeReceived; private DateTime? _ori__DateTimeReceived; private bool _mod__DateTimeReceived;
		private int? _cur__Size; private int? _ori__Size; private bool _mod__Size;
		private string _cur__Categories; private string _ori__Categories; private bool _mod__Categories;
		private string _cur__Importance; private string _ori__Importance; private bool _mod__Importance;
		private bool? _cur__IsSubmitted; private bool? _ori__IsSubmitted; private bool _mod__IsSubmitted;
		private string _cur__InReplyTo; private string _ori__InReplyTo; private bool _mod__InReplyTo;
		private bool? _cur__IsDraft; private bool? _ori__IsDraft; private bool _mod__IsDraft;
		private bool? _cur__IsFromMe; private bool? _ori__IsFromMe; private bool _mod__IsFromMe;
		private bool? _cur__IsResend; private bool? _ori__IsResend; private bool _mod__IsResend;
		private bool? _cur__IsUnmodified; private bool? _ori__IsUnmodified; private bool _mod__IsUnmodified;
		private string _cur__InternetMessageHeaders; private string _ori__InternetMessageHeaders; private bool _mod__InternetMessageHeaders;
		private DateTime? _cur__DateTimeSent; private DateTime? _ori__DateTimeSent; private bool _mod__DateTimeSent;
		private DateTime? _cur__DateTimeCreated; private DateTime? _ori__DateTimeCreated; private bool _mod__DateTimeCreated;
		private DateTime? _cur__ReminderDueBy; private DateTime? _ori__ReminderDueBy; private bool _mod__ReminderDueBy;
		private bool? _cur__ReminderIsSet; private bool? _ori__ReminderIsSet; private bool _mod__ReminderIsSet;
		private int? _cur__ReminderMinutesBeforeStart; private int? _ori__ReminderMinutesBeforeStart; private bool _mod__ReminderMinutesBeforeStart;
		private string _cur__DisplayCc; private string _ori__DisplayCc; private bool _mod__DisplayCc;
		private string _cur__DisplayTo; private string _ori__DisplayTo; private bool _mod__DisplayTo;
		private bool? _cur__HasAttachments; private bool? _ori__HasAttachments; private bool _mod__HasAttachments;
		private string _cur__Culture; private string _ori__Culture; private bool _mod__Culture;
		private bool? _cur__EffectiveRights_CreateAssociated; private bool? _ori__EffectiveRights_CreateAssociated; private bool _mod__EffectiveRights_CreateAssociated;
		private bool? _cur__EffectiveRights_CreateContents; private bool? _ori__EffectiveRights_CreateContents; private bool _mod__EffectiveRights_CreateContents;
		private bool? _cur__EffectiveRights_CreateHierarchy; private bool? _ori__EffectiveRights_CreateHierarchy; private bool _mod__EffectiveRights_CreateHierarchy;
		private bool? _cur__EffectiveRights_Delete; private bool? _ori__EffectiveRights_Delete; private bool _mod__EffectiveRights_Delete;
		private bool? _cur__EffectiveRights_Modify; private bool? _ori__EffectiveRights_Modify; private bool _mod__EffectiveRights_Modify;
		private bool? _cur__EffectiveRights_Read; private bool? _ori__EffectiveRights_Read; private bool _mod__EffectiveRights_Read;
		private bool? _cur__EffectiveRights_ViewPrivateItems; private bool? _ori__EffectiveRights_ViewPrivateItems; private bool _mod__EffectiveRights_ViewPrivateItems;
		private string _cur__LastModifiedName; private string _ori__LastModifiedName; private bool _mod__LastModifiedName;
		private DateTime? _cur__LastModifiedTime; private DateTime? _ori__LastModifiedTime; private bool _mod__LastModifiedTime;
		private bool? _cur__IsAssociated; private bool? _ori__IsAssociated; private bool _mod__IsAssociated;
		private string _cur__WebClientReadFormQueryString; private string _ori__WebClientReadFormQueryString; private bool _mod__WebClientReadFormQueryString;
		private string _cur__WebClientEditFormQueryString; private string _ori__WebClientEditFormQueryString; private bool _mod__WebClientEditFormQueryString;
		private string _cur__ConversationId; private string _ori__ConversationId; private bool _mod__ConversationId;
		private string _cur__UniqueBody; private string _ori__UniqueBody; private bool _mod__UniqueBody;
		private string _cur__UniqueBodyType; private string _ori__UniqueBodyType; private bool _mod__UniqueBodyType;
		private string _cur__FileAs; private string _ori__FileAs; private bool _mod__FileAs;
		private string _cur__FileAsMapping; private string _ori__FileAsMapping; private bool _mod__FileAsMapping;
		private string _cur__DisplayName; private string _ori__DisplayName; private bool _mod__DisplayName;
		private string _cur__GivenName; private string _ori__GivenName; private bool _mod__GivenName;
		private string _cur__Initials; private string _ori__Initials; private bool _mod__Initials;
		private string _cur__MiddleName; private string _ori__MiddleName; private bool _mod__MiddleName;
		private string _cur__Nickname; private string _ori__Nickname; private bool _mod__Nickname;
		private string _cur__CompleteName_Title; private string _ori__CompleteName_Title; private bool _mod__CompleteName_Title;
		private string _cur__CompleteName_FirstName; private string _ori__CompleteName_FirstName; private bool _mod__CompleteName_FirstName;
		private string _cur__CompleteName_MiddleName; private string _ori__CompleteName_MiddleName; private bool _mod__CompleteName_MiddleName;
		private string _cur__CompleteName_LastName; private string _ori__CompleteName_LastName; private bool _mod__CompleteName_LastName;
		private string _cur__CompleteName_Suffix; private string _ori__CompleteName_Suffix; private bool _mod__CompleteName_Suffix;
		private string _cur__CompleteName_Initials; private string _ori__CompleteName_Initials; private bool _mod__CompleteName_Initials;
		private string _cur__CompleteName_FullName; private string _ori__CompleteName_FullName; private bool _mod__CompleteName_FullName;
		private string _cur__CompleteName_Nickname; private string _ori__CompleteName_Nickname; private bool _mod__CompleteName_Nickname;
		private string _cur__CompleteName_YomiFirstName; private string _ori__CompleteName_YomiFirstName; private bool _mod__CompleteName_YomiFirstName;
		private string _cur__CompleteName_YomiLastName; private string _ori__CompleteName_YomiLastName; private bool _mod__CompleteName_YomiLastName;
		private string _cur__CompanyName; private string _ori__CompanyName; private bool _mod__CompanyName;
		private string _cur__EmailAddress1; private string _ori__EmailAddress1; private bool _mod__EmailAddress1;
		private string _cur__EmailAddress2; private string _ori__EmailAddress2; private bool _mod__EmailAddress2;
		private string _cur__EmailAddress3; private string _ori__EmailAddress3; private bool _mod__EmailAddress3;
		private string _cur__BusinessAddress_Street; private string _ori__BusinessAddress_Street; private bool _mod__BusinessAddress_Street;
		private string _cur__BusinessAddress_City; private string _ori__BusinessAddress_City; private bool _mod__BusinessAddress_City;
		private string _cur__BusinessAddress_State; private string _ori__BusinessAddress_State; private bool _mod__BusinessAddress_State;
		private string _cur__BusinessAddress_Country; private string _ori__BusinessAddress_Country; private bool _mod__BusinessAddress_Country;
		private string _cur__BusinessAddress_PostalCode; private string _ori__BusinessAddress_PostalCode; private bool _mod__BusinessAddress_PostalCode;
		private string _cur__HomeAddress_Street; private string _ori__HomeAddress_Street; private bool _mod__HomeAddress_Street;
		private string _cur__HomeAddress_City; private string _ori__HomeAddress_City; private bool _mod__HomeAddress_City;
		private string _cur__HomeAddress_State; private string _ori__HomeAddress_State; private bool _mod__HomeAddress_State;
		private string _cur__HomeAddress_Country; private string _ori__HomeAddress_Country; private bool _mod__HomeAddress_Country;
		private string _cur__HomeAddress_PostalCode; private string _ori__HomeAddress_PostalCode; private bool _mod__HomeAddress_PostalCode;
		private string _cur__OtherAddress_Street; private string _ori__OtherAddress_Street; private bool _mod__OtherAddress_Street;
		private string _cur__OtherAddress_City; private string _ori__OtherAddress_City; private bool _mod__OtherAddress_City;
		private string _cur__OtherAddress_State; private string _ori__OtherAddress_State; private bool _mod__OtherAddress_State;
		private string _cur__OtherAddress_Country; private string _ori__OtherAddress_Country; private bool _mod__OtherAddress_Country;
		private string _cur__OtherAddress_PostalCode; private string _ori__OtherAddress_PostalCode; private bool _mod__OtherAddress_PostalCode;
		private string _cur__AssistantPhone; private string _ori__AssistantPhone; private bool _mod__AssistantPhone;
		private string _cur__BusinessFax; private string _ori__BusinessFax; private bool _mod__BusinessFax;
		private string _cur__BusinessPhone; private string _ori__BusinessPhone; private bool _mod__BusinessPhone;
		private string _cur__BusinessPhone2; private string _ori__BusinessPhone2; private bool _mod__BusinessPhone2;
		private string _cur__Callback; private string _ori__Callback; private bool _mod__Callback;
		private string _cur__CarPhone; private string _ori__CarPhone; private bool _mod__CarPhone;
		private string _cur__CompanyMainPhone; private string _ori__CompanyMainPhone; private bool _mod__CompanyMainPhone;
		private string _cur__HomeFax; private string _ori__HomeFax; private bool _mod__HomeFax;
		private string _cur__HomePhone; private string _ori__HomePhone; private bool _mod__HomePhone;
		private string _cur__HomePhone2; private string _ori__HomePhone2; private bool _mod__HomePhone2;
		private string _cur__Isdn; private string _ori__Isdn; private bool _mod__Isdn;
		private string _cur__MobilePhone; private string _ori__MobilePhone; private bool _mod__MobilePhone;
		private string _cur__OtherFax; private string _ori__OtherFax; private bool _mod__OtherFax;
		private string _cur__OtherTelephone; private string _ori__OtherTelephone; private bool _mod__OtherTelephone;
		private string _cur__Pager; private string _ori__Pager; private bool _mod__Pager;
		private string _cur__PrimaryPhone; private string _ori__PrimaryPhone; private bool _mod__PrimaryPhone;
		private string _cur__RadioPhone; private string _ori__RadioPhone; private bool _mod__RadioPhone;
		private string _cur__Telex; private string _ori__Telex; private bool _mod__Telex;
		private string _cur__TtyTddPhone; private string _ori__TtyTddPhone; private bool _mod__TtyTddPhone;
		private string _cur__AssistantName; private string _ori__AssistantName; private bool _mod__AssistantName;
		private DateTime? _cur__Birthday; private DateTime? _ori__Birthday; private bool _mod__Birthday;
		private string _cur__BusinessHomePage; private string _ori__BusinessHomePage; private bool _mod__BusinessHomePage;
		private string _cur__Children_1; private string _ori__Children_1; private bool _mod__Children_1;
		private string _cur__Children_2; private string _ori__Children_2; private bool _mod__Children_2;
		private string _cur__Children_3; private string _ori__Children_3; private bool _mod__Children_3;
		private string _cur__Companies_1; private string _ori__Companies_1; private bool _mod__Companies_1;
		private string _cur__Companies_2; private string _ori__Companies_2; private bool _mod__Companies_2;
		private string _cur__Companies_3; private string _ori__Companies_3; private bool _mod__Companies_3;
		private string _cur__ContactSource; private string _ori__ContactSource; private bool _mod__ContactSource;
		private string _cur__Department; private string _ori__Department; private bool _mod__Department;
		private string _cur__Generation; private string _ori__Generation; private bool _mod__Generation;
		private string _cur__ImAddress1; private string _ori__ImAddress1; private bool _mod__ImAddress1;
		private string _cur__ImAddress2; private string _ori__ImAddress2; private bool _mod__ImAddress2;
		private string _cur__ImAddress3; private string _ori__ImAddress3; private bool _mod__ImAddress3;
		private string _cur__JobTitle; private string _ori__JobTitle; private bool _mod__JobTitle;
		private string _cur__Manager; private string _ori__Manager; private bool _mod__Manager;
		private string _cur__Mileage; private string _ori__Mileage; private bool _mod__Mileage;
		private string _cur__OfficeLocation; private string _ori__OfficeLocation; private bool _mod__OfficeLocation;
		private string _cur__PostalAddressIndex; private string _ori__PostalAddressIndex; private bool _mod__PostalAddressIndex;
		private string _cur__Profession; private string _ori__Profession; private bool _mod__Profession;
		private string _cur__SpouseName; private string _ori__SpouseName; private bool _mod__SpouseName;
		private string _cur__Surname; private string _ori__Surname; private bool _mod__Surname;
		private DateTime? _cur__WeddingAnniversary; private DateTime? _ori__WeddingAnniversary; private bool _mod__WeddingAnniversary;
		private bool? _cur__HasPicture; private bool? _ori__HasPicture; private bool _mod__HasPicture;
		private string _cur__PhoneticFullName; private string _ori__PhoneticFullName; private bool _mod__PhoneticFullName;
		private string _cur__PhoneticFirstName; private string _ori__PhoneticFirstName; private bool _mod__PhoneticFirstName;
		private string _cur__PhoneticLastName; private string _ori__PhoneticLastName; private bool _mod__PhoneticLastName;
		private string _cur__Alias; private string _ori__Alias; private bool _mod__Alias;
		private string _cur__Notes; private string _ori__Notes; private bool _mod__Notes;
		private string _cur__Photo; private string _ori__Photo; private bool _mod__Photo;
		private string _cur__UserSMIMECertificate; private string _ori__UserSMIMECertificate; private bool _mod__UserSMIMECertificate;
		private string _cur__MSExchangeCertificate; private string _ori__MSExchangeCertificate; private bool _mod__MSExchangeCertificate;
		private string _cur__DirectoryId; private string _ori__DirectoryId; private bool _mod__DirectoryId;
		private string _cur__ManagerMailbox; private string _ori__ManagerMailbox; private bool _mod__ManagerMailbox;
		private string _cur__DirectReports; private string _ori__DirectReports; private bool _mod__DirectReports;


		public PriKey_Contacts_Record()
		{
			_cur__ItemId = null;
			_cur__MimeContent = null;
			_cur__ItemChangeKey = null;
			_cur__ParentFolderId = null;
			_cur__ParentFolderChangeKey = null;
			_cur__ItemClass = null;
			_cur__Subject = null;
			_cur__Sensitivity = null;
			_cur__Body = null;
			_cur__DateTimeReceived = null;
			_cur__Size = null;
			_cur__Categories = null;
			_cur__Importance = null;
			_cur__IsSubmitted = null;
			_cur__InReplyTo = null;
			_cur__IsDraft = null;
			_cur__IsFromMe = null;
			_cur__IsResend = null;
			_cur__IsUnmodified = null;
			_cur__InternetMessageHeaders = null;
			_cur__DateTimeSent = null;
			_cur__DateTimeCreated = null;
			_cur__ReminderDueBy = null;
			_cur__ReminderIsSet = null;
			_cur__ReminderMinutesBeforeStart = null;
			_cur__DisplayCc = null;
			_cur__DisplayTo = null;
			_cur__HasAttachments = null;
			_cur__Culture = null;
			_cur__EffectiveRights_CreateAssociated = null;
			_cur__EffectiveRights_CreateContents = null;
			_cur__EffectiveRights_CreateHierarchy = null;
			_cur__EffectiveRights_Delete = null;
			_cur__EffectiveRights_Modify = null;
			_cur__EffectiveRights_Read = null;
			_cur__EffectiveRights_ViewPrivateItems = null;
			_cur__LastModifiedName = null;
			_cur__LastModifiedTime = null;
			_cur__IsAssociated = null;
			_cur__WebClientReadFormQueryString = null;
			_cur__WebClientEditFormQueryString = null;
			_cur__ConversationId = null;
			_cur__UniqueBody = null;
			_cur__UniqueBodyType = null;
			_cur__FileAs = null;
			_cur__FileAsMapping = null;
			_cur__DisplayName = null;
			_cur__GivenName = null;
			_cur__Initials = null;
			_cur__MiddleName = null;
			_cur__Nickname = null;
			_cur__CompleteName_Title = null;
			_cur__CompleteName_FirstName = null;
			_cur__CompleteName_MiddleName = null;
			_cur__CompleteName_LastName = null;
			_cur__CompleteName_Suffix = null;
			_cur__CompleteName_Initials = null;
			_cur__CompleteName_FullName = null;
			_cur__CompleteName_Nickname = null;
			_cur__CompleteName_YomiFirstName = null;
			_cur__CompleteName_YomiLastName = null;
			_cur__CompanyName = null;
			_cur__EmailAddress1 = null;
			_cur__EmailAddress2 = null;
			_cur__EmailAddress3 = null;
			_cur__BusinessAddress_Street = null;
			_cur__BusinessAddress_City = null;
			_cur__BusinessAddress_State = null;
			_cur__BusinessAddress_Country = null;
			_cur__BusinessAddress_PostalCode = null;
			_cur__HomeAddress_Street = null;
			_cur__HomeAddress_City = null;
			_cur__HomeAddress_State = null;
			_cur__HomeAddress_Country = null;
			_cur__HomeAddress_PostalCode = null;
			_cur__OtherAddress_Street = null;
			_cur__OtherAddress_City = null;
			_cur__OtherAddress_State = null;
			_cur__OtherAddress_Country = null;
			_cur__OtherAddress_PostalCode = null;
			_cur__AssistantPhone = null;
			_cur__BusinessFax = null;
			_cur__BusinessPhone = null;
			_cur__BusinessPhone2 = null;
			_cur__Callback = null;
			_cur__CarPhone = null;
			_cur__CompanyMainPhone = null;
			_cur__HomeFax = null;
			_cur__HomePhone = null;
			_cur__HomePhone2 = null;
			_cur__Isdn = null;
			_cur__MobilePhone = null;
			_cur__OtherFax = null;
			_cur__OtherTelephone = null;
			_cur__Pager = null;
			_cur__PrimaryPhone = null;
			_cur__RadioPhone = null;
			_cur__Telex = null;
			_cur__TtyTddPhone = null;
			_cur__AssistantName = null;
			_cur__Birthday = null;
			_cur__BusinessHomePage = null;
			_cur__Children_1 = null;
			_cur__Children_2 = null;
			_cur__Children_3 = null;
			_cur__Companies_1 = null;
			_cur__Companies_2 = null;
			_cur__Companies_3 = null;
			_cur__ContactSource = null;
			_cur__Department = null;
			_cur__Generation = null;
			_cur__ImAddress1 = null;
			_cur__ImAddress2 = null;
			_cur__ImAddress3 = null;
			_cur__JobTitle = null;
			_cur__Manager = null;
			_cur__Mileage = null;
			_cur__OfficeLocation = null;
			_cur__PostalAddressIndex = null;
			_cur__Profession = null;
			_cur__SpouseName = null;
			_cur__Surname = null;
			_cur__WeddingAnniversary = null;
			_cur__HasPicture = null;
			_cur__PhoneticFullName = null;
			_cur__PhoneticFirstName = null;
			_cur__PhoneticLastName = null;
			_cur__Alias = null;
			_cur__Notes = null;
			_cur__Photo = null;
			_cur__UserSMIMECertificate = null;
			_cur__MSExchangeCertificate = null;
			_cur__DirectoryId = null;
			_cur__ManagerMailbox = null;
			_cur__DirectReports = null;
			_started_with_dbvalues = false;
			_recordstatus = DataRecordStatus.New;
		}

		public PriKey_Contacts_Record(object[] columnvalues)
		{
			_cur__ItemId = (string)columnvalues[0];
			_cur__MimeContent = (string)columnvalues[1];
			_cur__ItemChangeKey = (string)columnvalues[2];
			_cur__ParentFolderId = (string)columnvalues[3];
			_cur__ParentFolderChangeKey = (string)columnvalues[4];
			_cur__ItemClass = (string)columnvalues[5];
			_cur__Subject = (string)columnvalues[6];
			_cur__Sensitivity = (string)columnvalues[7];
			_cur__Body = (string)columnvalues[8];
			_cur__DateTimeReceived = (DateTime?)columnvalues[9];
			_cur__Size = (int?)columnvalues[10];
			_cur__Categories = (string)columnvalues[11];
			_cur__Importance = (string)columnvalues[12];
			_cur__IsSubmitted = (bool?)columnvalues[13];
			_cur__InReplyTo = (string)columnvalues[14];
			_cur__IsDraft = (bool?)columnvalues[15];
			_cur__IsFromMe = (bool?)columnvalues[16];
			_cur__IsResend = (bool?)columnvalues[17];
			_cur__IsUnmodified = (bool?)columnvalues[18];
			_cur__InternetMessageHeaders = (string)columnvalues[19];
			_cur__DateTimeSent = (DateTime?)columnvalues[20];
			_cur__DateTimeCreated = (DateTime?)columnvalues[21];
			_cur__ReminderDueBy = (DateTime?)columnvalues[22];
			_cur__ReminderIsSet = (bool?)columnvalues[23];
			_cur__ReminderMinutesBeforeStart = (int?)columnvalues[24];
			_cur__DisplayCc = (string)columnvalues[25];
			_cur__DisplayTo = (string)columnvalues[26];
			_cur__HasAttachments = (bool?)columnvalues[27];
			_cur__Culture = (string)columnvalues[28];
			_cur__EffectiveRights_CreateAssociated = (bool?)columnvalues[29];
			_cur__EffectiveRights_CreateContents = (bool?)columnvalues[30];
			_cur__EffectiveRights_CreateHierarchy = (bool?)columnvalues[31];
			_cur__EffectiveRights_Delete = (bool?)columnvalues[32];
			_cur__EffectiveRights_Modify = (bool?)columnvalues[33];
			_cur__EffectiveRights_Read = (bool?)columnvalues[34];
			_cur__EffectiveRights_ViewPrivateItems = (bool?)columnvalues[35];
			_cur__LastModifiedName = (string)columnvalues[36];
			_cur__LastModifiedTime = (DateTime?)columnvalues[37];
			_cur__IsAssociated = (bool?)columnvalues[38];
			_cur__WebClientReadFormQueryString = (string)columnvalues[39];
			_cur__WebClientEditFormQueryString = (string)columnvalues[40];
			_cur__ConversationId = (string)columnvalues[41];
			_cur__UniqueBody = (string)columnvalues[42];
			_cur__UniqueBodyType = (string)columnvalues[43];
			_cur__FileAs = (string)columnvalues[44];
			_cur__FileAsMapping = (string)columnvalues[45];
			_cur__DisplayName = (string)columnvalues[46];
			_cur__GivenName = (string)columnvalues[47];
			_cur__Initials = (string)columnvalues[48];
			_cur__MiddleName = (string)columnvalues[49];
			_cur__Nickname = (string)columnvalues[50];
			_cur__CompleteName_Title = (string)columnvalues[51];
			_cur__CompleteName_FirstName = (string)columnvalues[52];
			_cur__CompleteName_MiddleName = (string)columnvalues[53];
			_cur__CompleteName_LastName = (string)columnvalues[54];
			_cur__CompleteName_Suffix = (string)columnvalues[55];
			_cur__CompleteName_Initials = (string)columnvalues[56];
			_cur__CompleteName_FullName = (string)columnvalues[57];
			_cur__CompleteName_Nickname = (string)columnvalues[58];
			_cur__CompleteName_YomiFirstName = (string)columnvalues[59];
			_cur__CompleteName_YomiLastName = (string)columnvalues[60];
			_cur__CompanyName = (string)columnvalues[61];
			_cur__EmailAddress1 = (string)columnvalues[62];
			_cur__EmailAddress2 = (string)columnvalues[63];
			_cur__EmailAddress3 = (string)columnvalues[64];
			_cur__BusinessAddress_Street = (string)columnvalues[65];
			_cur__BusinessAddress_City = (string)columnvalues[66];
			_cur__BusinessAddress_State = (string)columnvalues[67];
			_cur__BusinessAddress_Country = (string)columnvalues[68];
			_cur__BusinessAddress_PostalCode = (string)columnvalues[69];
			_cur__HomeAddress_Street = (string)columnvalues[70];
			_cur__HomeAddress_City = (string)columnvalues[71];
			_cur__HomeAddress_State = (string)columnvalues[72];
			_cur__HomeAddress_Country = (string)columnvalues[73];
			_cur__HomeAddress_PostalCode = (string)columnvalues[74];
			_cur__OtherAddress_Street = (string)columnvalues[75];
			_cur__OtherAddress_City = (string)columnvalues[76];
			_cur__OtherAddress_State = (string)columnvalues[77];
			_cur__OtherAddress_Country = (string)columnvalues[78];
			_cur__OtherAddress_PostalCode = (string)columnvalues[79];
			_cur__AssistantPhone = (string)columnvalues[80];
			_cur__BusinessFax = (string)columnvalues[81];
			_cur__BusinessPhone = (string)columnvalues[82];
			_cur__BusinessPhone2 = (string)columnvalues[83];
			_cur__Callback = (string)columnvalues[84];
			_cur__CarPhone = (string)columnvalues[85];
			_cur__CompanyMainPhone = (string)columnvalues[86];
			_cur__HomeFax = (string)columnvalues[87];
			_cur__HomePhone = (string)columnvalues[88];
			_cur__HomePhone2 = (string)columnvalues[89];
			_cur__Isdn = (string)columnvalues[90];
			_cur__MobilePhone = (string)columnvalues[91];
			_cur__OtherFax = (string)columnvalues[92];
			_cur__OtherTelephone = (string)columnvalues[93];
			_cur__Pager = (string)columnvalues[94];
			_cur__PrimaryPhone = (string)columnvalues[95];
			_cur__RadioPhone = (string)columnvalues[96];
			_cur__Telex = (string)columnvalues[97];
			_cur__TtyTddPhone = (string)columnvalues[98];
			_cur__AssistantName = (string)columnvalues[99];
			_cur__Birthday = (DateTime?)columnvalues[100];
			_cur__BusinessHomePage = (string)columnvalues[101];
			_cur__Children_1 = (string)columnvalues[102];
			_cur__Children_2 = (string)columnvalues[103];
			_cur__Children_3 = (string)columnvalues[104];
			_cur__Companies_1 = (string)columnvalues[105];
			_cur__Companies_2 = (string)columnvalues[106];
			_cur__Companies_3 = (string)columnvalues[107];
			_cur__ContactSource = (string)columnvalues[108];
			_cur__Department = (string)columnvalues[109];
			_cur__Generation = (string)columnvalues[110];
			_cur__ImAddress1 = (string)columnvalues[111];
			_cur__ImAddress2 = (string)columnvalues[112];
			_cur__ImAddress3 = (string)columnvalues[113];
			_cur__JobTitle = (string)columnvalues[114];
			_cur__Manager = (string)columnvalues[115];
			_cur__Mileage = (string)columnvalues[116];
			_cur__OfficeLocation = (string)columnvalues[117];
			_cur__PostalAddressIndex = (string)columnvalues[118];
			_cur__Profession = (string)columnvalues[119];
			_cur__SpouseName = (string)columnvalues[120];
			_cur__Surname = (string)columnvalues[121];
			_cur__WeddingAnniversary = (DateTime?)columnvalues[122];
			_cur__HasPicture = (bool?)columnvalues[123];
			_cur__PhoneticFullName = (string)columnvalues[124];
			_cur__PhoneticFirstName = (string)columnvalues[125];
			_cur__PhoneticLastName = (string)columnvalues[126];
			_cur__Alias = (string)columnvalues[127];
			_cur__Notes = (string)columnvalues[128];
			_cur__Photo = (string)columnvalues[129];
			_cur__UserSMIMECertificate = (string)columnvalues[130];
			_cur__MSExchangeCertificate = (string)columnvalues[131];
			_cur__DirectoryId = (string)columnvalues[132];
			_cur__ManagerMailbox = (string)columnvalues[133];
			_cur__DirectReports = (string)columnvalues[134];
			_started_with_dbvalues = true;
			_recordstatus = DataRecordStatus.Existing;
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. PrimaryKey. Readonly. AllowNull.
		/// Contains the unique identifier of an item in the Exchange store. This property is read-only.
		/// </summary>
		public string ItemId
		{
			get { return _cur__ItemId; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ItemId = true;
				if (_cur__ItemId == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ItemId == false) { _ori__ItemId = _cur__ItemId; _mod__ItemId = true; } // existing record and column is not modified
					else { if (value == _ori__ItemId) { _ori__ItemId = default(string); _mod__ItemId = false; } } // existing record and column is modified
				}
				_cur__ItemId = value; OnPropertyChanged("ItemId"); OnAfterPropertyChanged("ItemId");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Contains the native Multipurpose Internet Mail Extensions (MIME) stream of an object that is represented in Base64
		/// binary format.
		/// </summary>
		public string MimeContent
		{
			get { return _cur__MimeContent; }
			set
			{
				if (_started_with_dbvalues == false) _mod__MimeContent = true;
				if (_cur__MimeContent == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__MimeContent == false) { _ori__MimeContent = _cur__MimeContent; _mod__MimeContent = true; } // existing record and column is not modified
					else { if (value == _ori__MimeContent) { _ori__MimeContent = default(string); _mod__MimeContent = false; } } // existing record and column is modified
				}
				_cur__MimeContent = value; OnPropertyChanged("MimeContent"); OnAfterPropertyChanged("MimeContent");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Contains the unique change key of an item in the Exchange store. This property is read-only.
		/// </summary>
		public string ItemChangeKey
		{
			get { return _cur__ItemChangeKey; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ItemChangeKey = true;
				if (_cur__ItemChangeKey == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ItemChangeKey == false) { _ori__ItemChangeKey = _cur__ItemChangeKey; _mod__ItemChangeKey = true; } // existing record and column is not modified
					else { if (value == _ori__ItemChangeKey) { _ori__ItemChangeKey = default(string); _mod__ItemChangeKey = false; } } // existing record and column is modified
				}
				_cur__ItemChangeKey = value; OnPropertyChanged("ItemChangeKey"); OnAfterPropertyChanged("ItemChangeKey");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the unique identifier of the parent folder that contains the item or folder. This property is read-only.
		/// </summary>
		public string ParentFolderId
		{
			get { return _cur__ParentFolderId; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ParentFolderId = true;
				if (_cur__ParentFolderId == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ParentFolderId == false) { _ori__ParentFolderId = _cur__ParentFolderId; _mod__ParentFolderId = true; } // existing record and column is not modified
					else { if (value == _ori__ParentFolderId) { _ori__ParentFolderId = default(string); _mod__ParentFolderId = false; } } // existing record and column is modified
				}
				_cur__ParentFolderId = value; OnPropertyChanged("ParentFolderId"); OnAfterPropertyChanged("ParentFolderId");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Represents the unique change key of the parent folder that contains the item or folder. This property is read-only.
		/// </summary>
		public string ParentFolderChangeKey
		{
			get { return _cur__ParentFolderChangeKey; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ParentFolderChangeKey = true;
				if (_cur__ParentFolderChangeKey == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ParentFolderChangeKey == false) { _ori__ParentFolderChangeKey = _cur__ParentFolderChangeKey; _mod__ParentFolderChangeKey = true; } // existing record and column is not modified
					else { if (value == _ori__ParentFolderChangeKey) { _ori__ParentFolderChangeKey = default(string); _mod__ParentFolderChangeKey = false; } } // existing record and column is modified
				}
				_cur__ParentFolderChangeKey = value; OnPropertyChanged("ParentFolderChangeKey"); OnAfterPropertyChanged("ParentFolderChangeKey");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the message class of an item.
		/// </summary>
		public string ItemClass
		{
			get { return _cur__ItemClass; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ItemClass = true;
				if (_cur__ItemClass == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ItemClass == false) { _ori__ItemClass = _cur__ItemClass; _mod__ItemClass = true; } // existing record and column is not modified
					else { if (value == _ori__ItemClass) { _ori__ItemClass = default(string); _mod__ItemClass = false; } } // existing record and column is modified
				}
				_cur__ItemClass = value; OnPropertyChanged("ItemClass"); OnAfterPropertyChanged("ItemClass");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the subject for Exchange store items and response objects. The subject is limited to 255 characters.
		/// </summary>
		public string Subject
		{
			get { return _cur__Subject; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Subject = true;
				if (_cur__Subject == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Subject == false) { _ori__Subject = _cur__Subject; _mod__Subject = true; } // existing record and column is not modified
					else { if (value == _ori__Subject) { _ori__Subject = default(string); _mod__Subject = false; } } // existing record and column is modified
				}
				_cur__Subject = value; OnPropertyChanged("Subject"); OnAfterPropertyChanged("Subject");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Indicates the sensitivity level of an item.
		/// </summary>
		public string Sensitivity
		{
			get { return _cur__Sensitivity; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Sensitivity = true;
				if (_cur__Sensitivity == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Sensitivity == false) { _ori__Sensitivity = _cur__Sensitivity; _mod__Sensitivity = true; } // existing record and column is not modified
					else { if (value == _ori__Sensitivity) { _ori__Sensitivity = default(string); _mod__Sensitivity = false; } } // existing record and column is modified
				}
				_cur__Sensitivity = value; OnPropertyChanged("Sensitivity"); OnAfterPropertyChanged("Sensitivity");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the actual body content of a message.
		/// </summary>
		public string Body
		{
			get { return _cur__Body; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Body = true;
				if (_cur__Body == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Body == false) { _ori__Body = _cur__Body; _mod__Body = true; } // existing record and column is not modified
					else { if (value == _ori__Body) { _ori__Body = default(string); _mod__Body = false; } } // existing record and column is modified
				}
				_cur__Body = value; OnPropertyChanged("Body"); OnAfterPropertyChanged("Body");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Represents the date and time that an item in a mailbox was received.
		/// </summary>
		public DateTime? DateTimeReceived
		{
			get { return _cur__DateTimeReceived; }
			set
			{
				if (_started_with_dbvalues == false) _mod__DateTimeReceived = true;
				if (_cur__DateTimeReceived == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__DateTimeReceived == false) { _ori__DateTimeReceived = _cur__DateTimeReceived; _mod__DateTimeReceived = true; } // existing record and column is not modified
					else { if (value == _ori__DateTimeReceived) { _ori__DateTimeReceived = default(DateTime?); _mod__DateTimeReceived = false; } } // existing record and column is modified
				}
				_cur__DateTimeReceived = value; OnPropertyChanged("DateTimeReceived"); OnAfterPropertyChanged("DateTimeReceived");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Represents the size in bytes of an item. This property is read-only.
		/// </summary>
		public int? Size
		{
			get { return _cur__Size; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Size = true;
				if (_cur__Size == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Size == false) { _ori__Size = _cur__Size; _mod__Size = true; } // existing record and column is not modified
					else { if (value == _ori__Size) { _ori__Size = default(int?); _mod__Size = false; } } // existing record and column is modified
				}
				_cur__Size = value; OnPropertyChanged("Size"); OnAfterPropertyChanged("Size");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents a collection of strings that identify to which categories an item in the mailbox belongs.
		/// </summary>
		public string Categories
		{
			get { return _cur__Categories; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Categories = true;
				if (_cur__Categories == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Categories == false) { _ori__Categories = _cur__Categories; _mod__Categories = true; } // existing record and column is not modified
					else { if (value == _ori__Categories) { _ori__Categories = default(string); _mod__Categories = false; } } // existing record and column is modified
				}
				_cur__Categories = value; OnPropertyChanged("Categories"); OnAfterPropertyChanged("Categories");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Describes the importance of an item.
		/// </summary>
		public string Importance
		{
			get { return _cur__Importance; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Importance = true;
				if (_cur__Importance == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Importance == false) { _ori__Importance = _cur__Importance; _mod__Importance = true; } // existing record and column is not modified
					else { if (value == _ori__Importance) { _ori__Importance = default(string); _mod__Importance = false; } } // existing record and column is modified
				}
				_cur__Importance = value; OnPropertyChanged("Importance"); OnAfterPropertyChanged("Importance");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Indicates whether an item has been submitted to the Outbox default folder.
		/// </summary>
		public bool? IsSubmitted
		{
			get { return _cur__IsSubmitted; }
			set
			{
				if (_started_with_dbvalues == false) _mod__IsSubmitted = true;
				if (_cur__IsSubmitted == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__IsSubmitted == false) { _ori__IsSubmitted = _cur__IsSubmitted; _mod__IsSubmitted = true; } // existing record and column is not modified
					else { if (value == _ori__IsSubmitted) { _ori__IsSubmitted = default(bool?); _mod__IsSubmitted = false; } } // existing record and column is modified
				}
				_cur__IsSubmitted = value; OnPropertyChanged("IsSubmitted"); OnAfterPropertyChanged("IsSubmitted");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Represents the identifier of the item to which this item is a reply.
		/// </summary>
		public string InReplyTo
		{
			get { return _cur__InReplyTo; }
			set
			{
				if (_started_with_dbvalues == false) _mod__InReplyTo = true;
				if (_cur__InReplyTo == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__InReplyTo == false) { _ori__InReplyTo = _cur__InReplyTo; _mod__InReplyTo = true; } // existing record and column is not modified
					else { if (value == _ori__InReplyTo) { _ori__InReplyTo = default(string); _mod__InReplyTo = false; } } // existing record and column is modified
				}
				_cur__InReplyTo = value; OnPropertyChanged("InReplyTo"); OnAfterPropertyChanged("InReplyTo");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Represents whether an item has not yet been sent.
		/// </summary>
		public bool? IsDraft
		{
			get { return _cur__IsDraft; }
			set
			{
				if (_started_with_dbvalues == false) _mod__IsDraft = true;
				if (_cur__IsDraft == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__IsDraft == false) { _ori__IsDraft = _cur__IsDraft; _mod__IsDraft = true; } // existing record and column is not modified
					else { if (value == _ori__IsDraft) { _ori__IsDraft = default(bool?); _mod__IsDraft = false; } } // existing record and column is modified
				}
				_cur__IsDraft = value; OnPropertyChanged("IsDraft"); OnAfterPropertyChanged("IsDraft");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Indicates whether a user sent an item to himself or herself.
		/// </summary>
		public bool? IsFromMe
		{
			get { return _cur__IsFromMe; }
			set
			{
				if (_started_with_dbvalues == false) _mod__IsFromMe = true;
				if (_cur__IsFromMe == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__IsFromMe == false) { _ori__IsFromMe = _cur__IsFromMe; _mod__IsFromMe = true; } // existing record and column is not modified
					else { if (value == _ori__IsFromMe) { _ori__IsFromMe = default(bool?); _mod__IsFromMe = false; } } // existing record and column is modified
				}
				_cur__IsFromMe = value; OnPropertyChanged("IsFromMe"); OnAfterPropertyChanged("IsFromMe");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Indicates whether the item had previously been sent.
		/// </summary>
		public bool? IsResend
		{
			get { return _cur__IsResend; }
			set
			{
				if (_started_with_dbvalues == false) _mod__IsResend = true;
				if (_cur__IsResend == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__IsResend == false) { _ori__IsResend = _cur__IsResend; _mod__IsResend = true; } // existing record and column is not modified
					else { if (value == _ori__IsResend) { _ori__IsResend = default(bool?); _mod__IsResend = false; } } // existing record and column is modified
				}
				_cur__IsResend = value; OnPropertyChanged("IsResend"); OnAfterPropertyChanged("IsResend");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Indicates whether the item has been modified.
		/// </summary>
		public bool? IsUnmodified
		{
			get { return _cur__IsUnmodified; }
			set
			{
				if (_started_with_dbvalues == false) _mod__IsUnmodified = true;
				if (_cur__IsUnmodified == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__IsUnmodified == false) { _ori__IsUnmodified = _cur__IsUnmodified; _mod__IsUnmodified = true; } // existing record and column is not modified
					else { if (value == _ori__IsUnmodified) { _ori__IsUnmodified = default(bool?); _mod__IsUnmodified = false; } } // existing record and column is modified
				}
				_cur__IsUnmodified = value; OnPropertyChanged("IsUnmodified"); OnAfterPropertyChanged("IsUnmodified");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Represents the collection of all Internet message headers that are contained within an item in a mailbox.
		/// </summary>
		public string InternetMessageHeaders
		{
			get { return _cur__InternetMessageHeaders; }
			set
			{
				if (_started_with_dbvalues == false) _mod__InternetMessageHeaders = true;
				if (_cur__InternetMessageHeaders == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__InternetMessageHeaders == false) { _ori__InternetMessageHeaders = _cur__InternetMessageHeaders; _mod__InternetMessageHeaders = true; } // existing record and column is not modified
					else { if (value == _ori__InternetMessageHeaders) { _ori__InternetMessageHeaders = default(string); _mod__InternetMessageHeaders = false; } } // existing record and column is modified
				}
				_cur__InternetMessageHeaders = value; OnPropertyChanged("InternetMessageHeaders"); OnAfterPropertyChanged("InternetMessageHeaders");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Represents the date and time that an item in a mailbox was sent.
		/// </summary>
		public DateTime? DateTimeSent
		{
			get { return _cur__DateTimeSent; }
			set
			{
				if (_started_with_dbvalues == false) _mod__DateTimeSent = true;
				if (_cur__DateTimeSent == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__DateTimeSent == false) { _ori__DateTimeSent = _cur__DateTimeSent; _mod__DateTimeSent = true; } // existing record and column is not modified
					else { if (value == _ori__DateTimeSent) { _ori__DateTimeSent = default(DateTime?); _mod__DateTimeSent = false; } } // existing record and column is modified
				}
				_cur__DateTimeSent = value; OnPropertyChanged("DateTimeSent"); OnAfterPropertyChanged("DateTimeSent");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Represents the date and time that a given item in the mailbox was created.
		/// </summary>
		public DateTime? DateTimeCreated
		{
			get { return _cur__DateTimeCreated; }
			set
			{
				if (_started_with_dbvalues == false) _mod__DateTimeCreated = true;
				if (_cur__DateTimeCreated == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__DateTimeCreated == false) { _ori__DateTimeCreated = _cur__DateTimeCreated; _mod__DateTimeCreated = true; } // existing record and column is not modified
					else { if (value == _ori__DateTimeCreated) { _ori__DateTimeCreated = default(DateTime?); _mod__DateTimeCreated = false; } } // existing record and column is modified
				}
				_cur__DateTimeCreated = value; OnPropertyChanged("DateTimeCreated"); OnAfterPropertyChanged("DateTimeCreated");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the date and time when the event occurs.
		/// </summary>
		public DateTime? ReminderDueBy
		{
			get { return _cur__ReminderDueBy; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ReminderDueBy = true;
				if (_cur__ReminderDueBy == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ReminderDueBy == false) { _ori__ReminderDueBy = _cur__ReminderDueBy; _mod__ReminderDueBy = true; } // existing record and column is not modified
					else { if (value == _ori__ReminderDueBy) { _ori__ReminderDueBy = default(DateTime?); _mod__ReminderDueBy = false; } } // existing record and column is modified
				}
				_cur__ReminderDueBy = value; OnPropertyChanged("ReminderDueBy"); OnAfterPropertyChanged("ReminderDueBy");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Indicates whether a reminder has been set for an item in the Exchange store.
		/// </summary>
		public bool? ReminderIsSet
		{
			get { return _cur__ReminderIsSet; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ReminderIsSet = true;
				if (_cur__ReminderIsSet == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ReminderIsSet == false) { _ori__ReminderIsSet = _cur__ReminderIsSet; _mod__ReminderIsSet = true; } // existing record and column is not modified
					else { if (value == _ori__ReminderIsSet) { _ori__ReminderIsSet = default(bool?); _mod__ReminderIsSet = false; } } // existing record and column is modified
				}
				_cur__ReminderIsSet = value; OnPropertyChanged("ReminderIsSet"); OnAfterPropertyChanged("ReminderIsSet");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the number of minutes before an event occurs when a reminder is displayed.
		/// </summary>
		public int? ReminderMinutesBeforeStart
		{
			get { return _cur__ReminderMinutesBeforeStart; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ReminderMinutesBeforeStart = true;
				if (_cur__ReminderMinutesBeforeStart == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ReminderMinutesBeforeStart == false) { _ori__ReminderMinutesBeforeStart = _cur__ReminderMinutesBeforeStart; _mod__ReminderMinutesBeforeStart = true; } // existing record and column is not modified
					else { if (value == _ori__ReminderMinutesBeforeStart) { _ori__ReminderMinutesBeforeStart = default(int?); _mod__ReminderMinutesBeforeStart = false; } } // existing record and column is modified
				}
				_cur__ReminderMinutesBeforeStart = value; OnPropertyChanged("ReminderMinutesBeforeStart"); OnAfterPropertyChanged("ReminderMinutesBeforeStart");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Represents the display string that is used for the contents of the Cc box. This is the concatenated string of all Cc
		/// recipient display names.
		/// </summary>
		public string DisplayCc
		{
			get { return _cur__DisplayCc; }
			set
			{
				if (_started_with_dbvalues == false) _mod__DisplayCc = true;
				if (_cur__DisplayCc == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__DisplayCc == false) { _ori__DisplayCc = _cur__DisplayCc; _mod__DisplayCc = true; } // existing record and column is not modified
					else { if (value == _ori__DisplayCc) { _ori__DisplayCc = default(string); _mod__DisplayCc = false; } } // existing record and column is modified
				}
				_cur__DisplayCc = value; OnPropertyChanged("DisplayCc"); OnAfterPropertyChanged("DisplayCc");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Represents the display string that is used for the contents of the To box. This is the concatenated string of all To
		/// recipient display names.
		/// </summary>
		public string DisplayTo
		{
			get { return _cur__DisplayTo; }
			set
			{
				if (_started_with_dbvalues == false) _mod__DisplayTo = true;
				if (_cur__DisplayTo == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__DisplayTo == false) { _ori__DisplayTo = _cur__DisplayTo; _mod__DisplayTo = true; } // existing record and column is not modified
					else { if (value == _ori__DisplayTo) { _ori__DisplayTo = default(string); _mod__DisplayTo = false; } } // existing record and column is modified
				}
				_cur__DisplayTo = value; OnPropertyChanged("DisplayTo"); OnAfterPropertyChanged("DisplayTo");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Represents a property that is set to true if an item has at least one visible attachment. This property is read-only.
		/// </summary>
		public bool? HasAttachments
		{
			get { return _cur__HasAttachments; }
			set
			{
				if (_started_with_dbvalues == false) _mod__HasAttachments = true;
				if (_cur__HasAttachments == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__HasAttachments == false) { _ori__HasAttachments = _cur__HasAttachments; _mod__HasAttachments = true; } // existing record and column is not modified
					else { if (value == _ori__HasAttachments) { _ori__HasAttachments = default(bool?); _mod__HasAttachments = false; } } // existing record and column is modified
				}
				_cur__HasAttachments = value; OnPropertyChanged("HasAttachments"); OnAfterPropertyChanged("HasAttachments");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the culture for a given item in a mailbox.
		/// </summary>
		public string Culture
		{
			get { return _cur__Culture; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Culture = true;
				if (_cur__Culture == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Culture == false) { _ori__Culture = _cur__Culture; _mod__Culture = true; } // existing record and column is not modified
					else { if (value == _ori__Culture) { _ori__Culture = default(string); _mod__Culture = false; } } // existing record and column is modified
				}
				_cur__Culture = value; OnPropertyChanged("Culture"); OnAfterPropertyChanged("Culture");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Indicates whether a client can create an associated contents table.
		/// </summary>
		public bool? EffectiveRights_CreateAssociated
		{
			get { return _cur__EffectiveRights_CreateAssociated; }
			set
			{
				if (_started_with_dbvalues == false) _mod__EffectiveRights_CreateAssociated = true;
				if (_cur__EffectiveRights_CreateAssociated == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__EffectiveRights_CreateAssociated == false) { _ori__EffectiveRights_CreateAssociated = _cur__EffectiveRights_CreateAssociated; _mod__EffectiveRights_CreateAssociated = true; } // existing record and column is not modified
					else { if (value == _ori__EffectiveRights_CreateAssociated) { _ori__EffectiveRights_CreateAssociated = default(bool?); _mod__EffectiveRights_CreateAssociated = false; } } // existing record and column is modified
				}
				_cur__EffectiveRights_CreateAssociated = value; OnPropertyChanged("EffectiveRights_CreateAssociated"); OnAfterPropertyChanged("EffectiveRights_CreateAssociated");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Indicates whether a client can create a contents table.
		/// </summary>
		public bool? EffectiveRights_CreateContents
		{
			get { return _cur__EffectiveRights_CreateContents; }
			set
			{
				if (_started_with_dbvalues == false) _mod__EffectiveRights_CreateContents = true;
				if (_cur__EffectiveRights_CreateContents == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__EffectiveRights_CreateContents == false) { _ori__EffectiveRights_CreateContents = _cur__EffectiveRights_CreateContents; _mod__EffectiveRights_CreateContents = true; } // existing record and column is not modified
					else { if (value == _ori__EffectiveRights_CreateContents) { _ori__EffectiveRights_CreateContents = default(bool?); _mod__EffectiveRights_CreateContents = false; } } // existing record and column is modified
				}
				_cur__EffectiveRights_CreateContents = value; OnPropertyChanged("EffectiveRights_CreateContents"); OnAfterPropertyChanged("EffectiveRights_CreateContents");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Indicates whether a client can create a hierarchy table.
		/// </summary>
		public bool? EffectiveRights_CreateHierarchy
		{
			get { return _cur__EffectiveRights_CreateHierarchy; }
			set
			{
				if (_started_with_dbvalues == false) _mod__EffectiveRights_CreateHierarchy = true;
				if (_cur__EffectiveRights_CreateHierarchy == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__EffectiveRights_CreateHierarchy == false) { _ori__EffectiveRights_CreateHierarchy = _cur__EffectiveRights_CreateHierarchy; _mod__EffectiveRights_CreateHierarchy = true; } // existing record and column is not modified
					else { if (value == _ori__EffectiveRights_CreateHierarchy) { _ori__EffectiveRights_CreateHierarchy = default(bool?); _mod__EffectiveRights_CreateHierarchy = false; } } // existing record and column is modified
				}
				_cur__EffectiveRights_CreateHierarchy = value; OnPropertyChanged("EffectiveRights_CreateHierarchy"); OnAfterPropertyChanged("EffectiveRights_CreateHierarchy");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Indicates whether a client can delete a folder or item.
		/// </summary>
		public bool? EffectiveRights_Delete
		{
			get { return _cur__EffectiveRights_Delete; }
			set
			{
				if (_started_with_dbvalues == false) _mod__EffectiveRights_Delete = true;
				if (_cur__EffectiveRights_Delete == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__EffectiveRights_Delete == false) { _ori__EffectiveRights_Delete = _cur__EffectiveRights_Delete; _mod__EffectiveRights_Delete = true; } // existing record and column is not modified
					else { if (value == _ori__EffectiveRights_Delete) { _ori__EffectiveRights_Delete = default(bool?); _mod__EffectiveRights_Delete = false; } } // existing record and column is modified
				}
				_cur__EffectiveRights_Delete = value; OnPropertyChanged("EffectiveRights_Delete"); OnAfterPropertyChanged("EffectiveRights_Delete");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Indicates whether a client can modify a folder or item.
		/// </summary>
		public bool? EffectiveRights_Modify
		{
			get { return _cur__EffectiveRights_Modify; }
			set
			{
				if (_started_with_dbvalues == false) _mod__EffectiveRights_Modify = true;
				if (_cur__EffectiveRights_Modify == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__EffectiveRights_Modify == false) { _ori__EffectiveRights_Modify = _cur__EffectiveRights_Modify; _mod__EffectiveRights_Modify = true; } // existing record and column is not modified
					else { if (value == _ori__EffectiveRights_Modify) { _ori__EffectiveRights_Modify = default(bool?); _mod__EffectiveRights_Modify = false; } } // existing record and column is modified
				}
				_cur__EffectiveRights_Modify = value; OnPropertyChanged("EffectiveRights_Modify"); OnAfterPropertyChanged("EffectiveRights_Modify");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Indicates whether a client can read a folder or item.
		/// </summary>
		public bool? EffectiveRights_Read
		{
			get { return _cur__EffectiveRights_Read; }
			set
			{
				if (_started_with_dbvalues == false) _mod__EffectiveRights_Read = true;
				if (_cur__EffectiveRights_Read == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__EffectiveRights_Read == false) { _ori__EffectiveRights_Read = _cur__EffectiveRights_Read; _mod__EffectiveRights_Read = true; } // existing record and column is not modified
					else { if (value == _ori__EffectiveRights_Read) { _ori__EffectiveRights_Read = default(bool?); _mod__EffectiveRights_Read = false; } } // existing record and column is modified
				}
				_cur__EffectiveRights_Read = value; OnPropertyChanged("EffectiveRights_Read"); OnAfterPropertyChanged("EffectiveRights_Read");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Indicates whether a private item can be viewed.
		/// </summary>
		public bool? EffectiveRights_ViewPrivateItems
		{
			get { return _cur__EffectiveRights_ViewPrivateItems; }
			set
			{
				if (_started_with_dbvalues == false) _mod__EffectiveRights_ViewPrivateItems = true;
				if (_cur__EffectiveRights_ViewPrivateItems == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__EffectiveRights_ViewPrivateItems == false) { _ori__EffectiveRights_ViewPrivateItems = _cur__EffectiveRights_ViewPrivateItems; _mod__EffectiveRights_ViewPrivateItems = true; } // existing record and column is not modified
					else { if (value == _ori__EffectiveRights_ViewPrivateItems) { _ori__EffectiveRights_ViewPrivateItems = default(bool?); _mod__EffectiveRights_ViewPrivateItems = false; } } // existing record and column is modified
				}
				_cur__EffectiveRights_ViewPrivateItems = value; OnPropertyChanged("EffectiveRights_ViewPrivateItems"); OnAfterPropertyChanged("EffectiveRights_ViewPrivateItems");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Contains the display name of the last user to modify an item.
		/// </summary>
		public string LastModifiedName
		{
			get { return _cur__LastModifiedName; }
			set
			{
				if (_started_with_dbvalues == false) _mod__LastModifiedName = true;
				if (_cur__LastModifiedName == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__LastModifiedName == false) { _ori__LastModifiedName = _cur__LastModifiedName; _mod__LastModifiedName = true; } // existing record and column is not modified
					else { if (value == _ori__LastModifiedName) { _ori__LastModifiedName = default(string); _mod__LastModifiedName = false; } } // existing record and column is modified
				}
				_cur__LastModifiedName = value; OnPropertyChanged("LastModifiedName"); OnAfterPropertyChanged("LastModifiedName");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Indicates when an item was last modified. This element is read-only.
		/// </summary>
		public DateTime? LastModifiedTime
		{
			get { return _cur__LastModifiedTime; }
			set
			{
				if (_started_with_dbvalues == false) _mod__LastModifiedTime = true;
				if (_cur__LastModifiedTime == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__LastModifiedTime == false) { _ori__LastModifiedTime = _cur__LastModifiedTime; _mod__LastModifiedTime = true; } // existing record and column is not modified
					else { if (value == _ori__LastModifiedTime) { _ori__LastModifiedTime = default(DateTime?); _mod__LastModifiedTime = false; } } // existing record and column is modified
				}
				_cur__LastModifiedTime = value; OnPropertyChanged("LastModifiedTime"); OnAfterPropertyChanged("LastModifiedTime");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Indicates whether the item is associated with a folder.
		/// </summary>
		public bool? IsAssociated
		{
			get { return _cur__IsAssociated; }
			set
			{
				if (_started_with_dbvalues == false) _mod__IsAssociated = true;
				if (_cur__IsAssociated == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__IsAssociated == false) { _ori__IsAssociated = _cur__IsAssociated; _mod__IsAssociated = true; } // existing record and column is not modified
					else { if (value == _ori__IsAssociated) { _ori__IsAssociated = default(bool?); _mod__IsAssociated = false; } } // existing record and column is modified
				}
				_cur__IsAssociated = value; OnPropertyChanged("IsAssociated"); OnAfterPropertyChanged("IsAssociated");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Represents a URL to concatenate to the Microsoft Office Outlook Web App endpoint to read an item in Outlook Web App.
		/// </summary>
		public string WebClientReadFormQueryString
		{
			get { return _cur__WebClientReadFormQueryString; }
			set
			{
				if (_started_with_dbvalues == false) _mod__WebClientReadFormQueryString = true;
				if (_cur__WebClientReadFormQueryString == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__WebClientReadFormQueryString == false) { _ori__WebClientReadFormQueryString = _cur__WebClientReadFormQueryString; _mod__WebClientReadFormQueryString = true; } // existing record and column is not modified
					else { if (value == _ori__WebClientReadFormQueryString) { _ori__WebClientReadFormQueryString = default(string); _mod__WebClientReadFormQueryString = false; } } // existing record and column is modified
				}
				_cur__WebClientReadFormQueryString = value; OnPropertyChanged("WebClientReadFormQueryString"); OnAfterPropertyChanged("WebClientReadFormQueryString");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Represents a URL to concatenate to the Outlook Web App endpoint to edit an item in Outlook Web App.
		/// </summary>
		public string WebClientEditFormQueryString
		{
			get { return _cur__WebClientEditFormQueryString; }
			set
			{
				if (_started_with_dbvalues == false) _mod__WebClientEditFormQueryString = true;
				if (_cur__WebClientEditFormQueryString == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__WebClientEditFormQueryString == false) { _ori__WebClientEditFormQueryString = _cur__WebClientEditFormQueryString; _mod__WebClientEditFormQueryString = true; } // existing record and column is not modified
					else { if (value == _ori__WebClientEditFormQueryString) { _ori__WebClientEditFormQueryString = default(string); _mod__WebClientEditFormQueryString = false; } } // existing record and column is modified
				}
				_cur__WebClientEditFormQueryString = value; OnPropertyChanged("WebClientEditFormQueryString"); OnAfterPropertyChanged("WebClientEditFormQueryString");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Identifies a specific conversation in the Exchange store.
		/// </summary>
		public string ConversationId
		{
			get { return _cur__ConversationId; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ConversationId = true;
				if (_cur__ConversationId == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ConversationId == false) { _ori__ConversationId = _cur__ConversationId; _mod__ConversationId = true; } // existing record and column is not modified
					else { if (value == _ori__ConversationId) { _ori__ConversationId = default(string); _mod__ConversationId = false; } } // existing record and column is modified
				}
				_cur__ConversationId = value; OnPropertyChanged("ConversationId"); OnAfterPropertyChanged("ConversationId");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Represents an HTML fragment or plain-text which represents the unique body of this conversation.
		/// </summary>
		public string UniqueBody
		{
			get { return _cur__UniqueBody; }
			set
			{
				if (_started_with_dbvalues == false) _mod__UniqueBody = true;
				if (_cur__UniqueBody == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__UniqueBody == false) { _ori__UniqueBody = _cur__UniqueBody; _mod__UniqueBody = true; } // existing record and column is not modified
					else { if (value == _ori__UniqueBody) { _ori__UniqueBody = default(string); _mod__UniqueBody = false; } } // existing record and column is modified
				}
				_cur__UniqueBody = value; OnPropertyChanged("UniqueBody"); OnAfterPropertyChanged("UniqueBody");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Describes how the unique item body is stored in the item (HTML or TEXT).
		/// </summary>
		public string UniqueBodyType
		{
			get { return _cur__UniqueBodyType; }
			set
			{
				if (_started_with_dbvalues == false) _mod__UniqueBodyType = true;
				if (_cur__UniqueBodyType == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__UniqueBodyType == false) { _ori__UniqueBodyType = _cur__UniqueBodyType; _mod__UniqueBodyType = true; } // existing record and column is not modified
					else { if (value == _ori__UniqueBodyType) { _ori__UniqueBodyType = default(string); _mod__UniqueBodyType = false; } } // existing record and column is modified
				}
				_cur__UniqueBodyType = value; OnPropertyChanged("UniqueBodyType"); OnAfterPropertyChanged("UniqueBodyType");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents how a contact or distribution list is filed in the Contacts folder.
		/// </summary>
		public string FileAs
		{
			get { return _cur__FileAs; }
			set
			{
				if (_started_with_dbvalues == false) _mod__FileAs = true;
				if (_cur__FileAs == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__FileAs == false) { _ori__FileAs = _cur__FileAs; _mod__FileAs = true; } // existing record and column is not modified
					else { if (value == _ori__FileAs) { _ori__FileAs = default(string); _mod__FileAs = false; } } // existing record and column is modified
				}
				_cur__FileAs = value; OnPropertyChanged("FileAs"); OnAfterPropertyChanged("FileAs");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Defines how to construct what is displayed for a contact.
		/// </summary>
		public string FileAsMapping
		{
			get { return _cur__FileAsMapping; }
			set
			{
				if (_started_with_dbvalues == false) _mod__FileAsMapping = true;
				if (_cur__FileAsMapping == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__FileAsMapping == false) { _ori__FileAsMapping = _cur__FileAsMapping; _mod__FileAsMapping = true; } // existing record and column is not modified
					else { if (value == _ori__FileAsMapping) { _ori__FileAsMapping = default(string); _mod__FileAsMapping = false; } } // existing record and column is modified
				}
				_cur__FileAsMapping = value; OnPropertyChanged("FileAsMapping"); OnAfterPropertyChanged("FileAsMapping");
			}
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
		/// Contains the given name of a contact.
		/// </summary>
		public string GivenName
		{
			get { return _cur__GivenName; }
			set
			{
				if (_started_with_dbvalues == false) _mod__GivenName = true;
				if (_cur__GivenName == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__GivenName == false) { _ori__GivenName = _cur__GivenName; _mod__GivenName = true; } // existing record and column is not modified
					else { if (value == _ori__GivenName) { _ori__GivenName = default(string); _mod__GivenName = false; } } // existing record and column is modified
				}
				_cur__GivenName = value; OnPropertyChanged("GivenName"); OnAfterPropertyChanged("GivenName");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the initials of a contact.
		/// </summary>
		public string Initials
		{
			get { return _cur__Initials; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Initials = true;
				if (_cur__Initials == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Initials == false) { _ori__Initials = _cur__Initials; _mod__Initials = true; } // existing record and column is not modified
					else { if (value == _ori__Initials) { _ori__Initials = default(string); _mod__Initials = false; } } // existing record and column is modified
				}
				_cur__Initials = value; OnPropertyChanged("Initials"); OnAfterPropertyChanged("Initials");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the middle name of a contact.
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
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the nickname of a contact.
		/// </summary>
		public string Nickname
		{
			get { return _cur__Nickname; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Nickname = true;
				if (_cur__Nickname == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Nickname == false) { _ori__Nickname = _cur__Nickname; _mod__Nickname = true; } // existing record and column is not modified
					else { if (value == _ori__Nickname) { _ori__Nickname = default(string); _mod__Nickname = false; } } // existing record and column is modified
				}
				_cur__Nickname = value; OnPropertyChanged("Nickname"); OnAfterPropertyChanged("Nickname");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Represents the title of a contact.
		/// </summary>
		public string CompleteName_Title
		{
			get { return _cur__CompleteName_Title; }
			set
			{
				if (_started_with_dbvalues == false) _mod__CompleteName_Title = true;
				if (_cur__CompleteName_Title == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__CompleteName_Title == false) { _ori__CompleteName_Title = _cur__CompleteName_Title; _mod__CompleteName_Title = true; } // existing record and column is not modified
					else { if (value == _ori__CompleteName_Title) { _ori__CompleteName_Title = default(string); _mod__CompleteName_Title = false; } } // existing record and column is modified
				}
				_cur__CompleteName_Title = value; OnPropertyChanged("CompleteName_Title"); OnAfterPropertyChanged("CompleteName_Title");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Represents the first name of a contact.
		/// </summary>
		public string CompleteName_FirstName
		{
			get { return _cur__CompleteName_FirstName; }
			set
			{
				if (_started_with_dbvalues == false) _mod__CompleteName_FirstName = true;
				if (_cur__CompleteName_FirstName == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__CompleteName_FirstName == false) { _ori__CompleteName_FirstName = _cur__CompleteName_FirstName; _mod__CompleteName_FirstName = true; } // existing record and column is not modified
					else { if (value == _ori__CompleteName_FirstName) { _ori__CompleteName_FirstName = default(string); _mod__CompleteName_FirstName = false; } } // existing record and column is modified
				}
				_cur__CompleteName_FirstName = value; OnPropertyChanged("CompleteName_FirstName"); OnAfterPropertyChanged("CompleteName_FirstName");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Represents the middle name of a contact.
		/// </summary>
		public string CompleteName_MiddleName
		{
			get { return _cur__CompleteName_MiddleName; }
			set
			{
				if (_started_with_dbvalues == false) _mod__CompleteName_MiddleName = true;
				if (_cur__CompleteName_MiddleName == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__CompleteName_MiddleName == false) { _ori__CompleteName_MiddleName = _cur__CompleteName_MiddleName; _mod__CompleteName_MiddleName = true; } // existing record and column is not modified
					else { if (value == _ori__CompleteName_MiddleName) { _ori__CompleteName_MiddleName = default(string); _mod__CompleteName_MiddleName = false; } } // existing record and column is modified
				}
				_cur__CompleteName_MiddleName = value; OnPropertyChanged("CompleteName_MiddleName"); OnAfterPropertyChanged("CompleteName_MiddleName");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Represents the last name of a contact.
		/// </summary>
		public string CompleteName_LastName
		{
			get { return _cur__CompleteName_LastName; }
			set
			{
				if (_started_with_dbvalues == false) _mod__CompleteName_LastName = true;
				if (_cur__CompleteName_LastName == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__CompleteName_LastName == false) { _ori__CompleteName_LastName = _cur__CompleteName_LastName; _mod__CompleteName_LastName = true; } // existing record and column is not modified
					else { if (value == _ori__CompleteName_LastName) { _ori__CompleteName_LastName = default(string); _mod__CompleteName_LastName = false; } } // existing record and column is modified
				}
				_cur__CompleteName_LastName = value; OnPropertyChanged("CompleteName_LastName"); OnAfterPropertyChanged("CompleteName_LastName");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Represents the suffix of a contact.
		/// </summary>
		public string CompleteName_Suffix
		{
			get { return _cur__CompleteName_Suffix; }
			set
			{
				if (_started_with_dbvalues == false) _mod__CompleteName_Suffix = true;
				if (_cur__CompleteName_Suffix == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__CompleteName_Suffix == false) { _ori__CompleteName_Suffix = _cur__CompleteName_Suffix; _mod__CompleteName_Suffix = true; } // existing record and column is not modified
					else { if (value == _ori__CompleteName_Suffix) { _ori__CompleteName_Suffix = default(string); _mod__CompleteName_Suffix = false; } } // existing record and column is modified
				}
				_cur__CompleteName_Suffix = value; OnPropertyChanged("CompleteName_Suffix"); OnAfterPropertyChanged("CompleteName_Suffix");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Represents the initials of a contact.
		/// </summary>
		public string CompleteName_Initials
		{
			get { return _cur__CompleteName_Initials; }
			set
			{
				if (_started_with_dbvalues == false) _mod__CompleteName_Initials = true;
				if (_cur__CompleteName_Initials == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__CompleteName_Initials == false) { _ori__CompleteName_Initials = _cur__CompleteName_Initials; _mod__CompleteName_Initials = true; } // existing record and column is not modified
					else { if (value == _ori__CompleteName_Initials) { _ori__CompleteName_Initials = default(string); _mod__CompleteName_Initials = false; } } // existing record and column is modified
				}
				_cur__CompleteName_Initials = value; OnPropertyChanged("CompleteName_Initials"); OnAfterPropertyChanged("CompleteName_Initials");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Represents the full name of a contact.
		/// </summary>
		public string CompleteName_FullName
		{
			get { return _cur__CompleteName_FullName; }
			set
			{
				if (_started_with_dbvalues == false) _mod__CompleteName_FullName = true;
				if (_cur__CompleteName_FullName == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__CompleteName_FullName == false) { _ori__CompleteName_FullName = _cur__CompleteName_FullName; _mod__CompleteName_FullName = true; } // existing record and column is not modified
					else { if (value == _ori__CompleteName_FullName) { _ori__CompleteName_FullName = default(string); _mod__CompleteName_FullName = false; } } // existing record and column is modified
				}
				_cur__CompleteName_FullName = value; OnPropertyChanged("CompleteName_FullName"); OnAfterPropertyChanged("CompleteName_FullName");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Represents the nickname of a contact.
		/// </summary>
		public string CompleteName_Nickname
		{
			get { return _cur__CompleteName_Nickname; }
			set
			{
				if (_started_with_dbvalues == false) _mod__CompleteName_Nickname = true;
				if (_cur__CompleteName_Nickname == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__CompleteName_Nickname == false) { _ori__CompleteName_Nickname = _cur__CompleteName_Nickname; _mod__CompleteName_Nickname = true; } // existing record and column is not modified
					else { if (value == _ori__CompleteName_Nickname) { _ori__CompleteName_Nickname = default(string); _mod__CompleteName_Nickname = false; } } // existing record and column is modified
				}
				_cur__CompleteName_Nickname = value; OnPropertyChanged("CompleteName_Nickname"); OnAfterPropertyChanged("CompleteName_Nickname");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Represents the name used in Japan for the searchable or phonetic spelling of a Japanese first name.
		/// </summary>
		public string CompleteName_YomiFirstName
		{
			get { return _cur__CompleteName_YomiFirstName; }
			set
			{
				if (_started_with_dbvalues == false) _mod__CompleteName_YomiFirstName = true;
				if (_cur__CompleteName_YomiFirstName == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__CompleteName_YomiFirstName == false) { _ori__CompleteName_YomiFirstName = _cur__CompleteName_YomiFirstName; _mod__CompleteName_YomiFirstName = true; } // existing record and column is not modified
					else { if (value == _ori__CompleteName_YomiFirstName) { _ori__CompleteName_YomiFirstName = default(string); _mod__CompleteName_YomiFirstName = false; } } // existing record and column is modified
				}
				_cur__CompleteName_YomiFirstName = value; OnPropertyChanged("CompleteName_YomiFirstName"); OnAfterPropertyChanged("CompleteName_YomiFirstName");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Contacts]. Readonly. AllowNull.
		/// Represents the name used in Japan for the searchable or phonetic spelling of a Japanese first name.
		/// </summary>
		public string CompleteName_YomiLastName
		{
			get { return _cur__CompleteName_YomiLastName; }
			set
			{
				if (_started_with_dbvalues == false) _mod__CompleteName_YomiLastName = true;
				if (_cur__CompleteName_YomiLastName == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__CompleteName_YomiLastName == false) { _ori__CompleteName_YomiLastName = _cur__CompleteName_YomiLastName; _mod__CompleteName_YomiLastName = true; } // existing record and column is not modified
					else { if (value == _ori__CompleteName_YomiLastName) { _ori__CompleteName_YomiLastName = default(string); _mod__CompleteName_YomiLastName = false; } } // existing record and column is modified
				}
				_cur__CompleteName_YomiLastName = value; OnPropertyChanged("CompleteName_YomiLastName"); OnAfterPropertyChanged("CompleteName_YomiLastName");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the company name that is associated with a contact.
		/// </summary>
		public string CompanyName
		{
			get { return _cur__CompanyName; }
			set
			{
				if (_started_with_dbvalues == false) _mod__CompanyName = true;
				if (_cur__CompanyName == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__CompanyName == false) { _ori__CompanyName = _cur__CompanyName; _mod__CompanyName = true; } // existing record and column is not modified
					else { if (value == _ori__CompanyName) { _ori__CompanyName = default(string); _mod__CompanyName = false; } } // existing record and column is modified
				}
				_cur__CompanyName = value; OnPropertyChanged("CompanyName"); OnAfterPropertyChanged("CompanyName");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents a single email address for a contact.
		/// </summary>
		public string EmailAddress1
		{
			get { return _cur__EmailAddress1; }
			set
			{
				if (_started_with_dbvalues == false) _mod__EmailAddress1 = true;
				if (_cur__EmailAddress1 == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__EmailAddress1 == false) { _ori__EmailAddress1 = _cur__EmailAddress1; _mod__EmailAddress1 = true; } // existing record and column is not modified
					else { if (value == _ori__EmailAddress1) { _ori__EmailAddress1 = default(string); _mod__EmailAddress1 = false; } } // existing record and column is modified
				}
				_cur__EmailAddress1 = value; OnPropertyChanged("EmailAddress1"); OnAfterPropertyChanged("EmailAddress1");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents a single email address for a contact.
		/// </summary>
		public string EmailAddress2
		{
			get { return _cur__EmailAddress2; }
			set
			{
				if (_started_with_dbvalues == false) _mod__EmailAddress2 = true;
				if (_cur__EmailAddress2 == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__EmailAddress2 == false) { _ori__EmailAddress2 = _cur__EmailAddress2; _mod__EmailAddress2 = true; } // existing record and column is not modified
					else { if (value == _ori__EmailAddress2) { _ori__EmailAddress2 = default(string); _mod__EmailAddress2 = false; } } // existing record and column is modified
				}
				_cur__EmailAddress2 = value; OnPropertyChanged("EmailAddress2"); OnAfterPropertyChanged("EmailAddress2");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents a single email address for a contact.
		/// </summary>
		public string EmailAddress3
		{
			get { return _cur__EmailAddress3; }
			set
			{
				if (_started_with_dbvalues == false) _mod__EmailAddress3 = true;
				if (_cur__EmailAddress3 == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__EmailAddress3 == false) { _ori__EmailAddress3 = _cur__EmailAddress3; _mod__EmailAddress3 = true; } // existing record and column is not modified
					else { if (value == _ori__EmailAddress3) { _ori__EmailAddress3 = default(string); _mod__EmailAddress3 = false; } } // existing record and column is modified
				}
				_cur__EmailAddress3 = value; OnPropertyChanged("EmailAddress3"); OnAfterPropertyChanged("EmailAddress3");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the Business street address for a contact item.
		/// </summary>
		public string BusinessAddress_Street
		{
			get { return _cur__BusinessAddress_Street; }
			set
			{
				if (_started_with_dbvalues == false) _mod__BusinessAddress_Street = true;
				if (_cur__BusinessAddress_Street == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__BusinessAddress_Street == false) { _ori__BusinessAddress_Street = _cur__BusinessAddress_Street; _mod__BusinessAddress_Street = true; } // existing record and column is not modified
					else { if (value == _ori__BusinessAddress_Street) { _ori__BusinessAddress_Street = default(string); _mod__BusinessAddress_Street = false; } } // existing record and column is modified
				}
				_cur__BusinessAddress_Street = value; OnPropertyChanged("BusinessAddress_Street"); OnAfterPropertyChanged("BusinessAddress_Street");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the Business city name for a contact item.
		/// </summary>
		public string BusinessAddress_City
		{
			get { return _cur__BusinessAddress_City; }
			set
			{
				if (_started_with_dbvalues == false) _mod__BusinessAddress_City = true;
				if (_cur__BusinessAddress_City == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__BusinessAddress_City == false) { _ori__BusinessAddress_City = _cur__BusinessAddress_City; _mod__BusinessAddress_City = true; } // existing record and column is not modified
					else { if (value == _ori__BusinessAddress_City) { _ori__BusinessAddress_City = default(string); _mod__BusinessAddress_City = false; } } // existing record and column is modified
				}
				_cur__BusinessAddress_City = value; OnPropertyChanged("BusinessAddress_City"); OnAfterPropertyChanged("BusinessAddress_City");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the Business state of residence for a contact item.
		/// </summary>
		public string BusinessAddress_State
		{
			get { return _cur__BusinessAddress_State; }
			set
			{
				if (_started_with_dbvalues == false) _mod__BusinessAddress_State = true;
				if (_cur__BusinessAddress_State == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__BusinessAddress_State == false) { _ori__BusinessAddress_State = _cur__BusinessAddress_State; _mod__BusinessAddress_State = true; } // existing record and column is not modified
					else { if (value == _ori__BusinessAddress_State) { _ori__BusinessAddress_State = default(string); _mod__BusinessAddress_State = false; } } // existing record and column is modified
				}
				_cur__BusinessAddress_State = value; OnPropertyChanged("BusinessAddress_State"); OnAfterPropertyChanged("BusinessAddress_State");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the Business country or region for a contact item.
		/// </summary>
		public string BusinessAddress_Country
		{
			get { return _cur__BusinessAddress_Country; }
			set
			{
				if (_started_with_dbvalues == false) _mod__BusinessAddress_Country = true;
				if (_cur__BusinessAddress_Country == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__BusinessAddress_Country == false) { _ori__BusinessAddress_Country = _cur__BusinessAddress_Country; _mod__BusinessAddress_Country = true; } // existing record and column is not modified
					else { if (value == _ori__BusinessAddress_Country) { _ori__BusinessAddress_Country = default(string); _mod__BusinessAddress_Country = false; } } // existing record and column is modified
				}
				_cur__BusinessAddress_Country = value; OnPropertyChanged("BusinessAddress_Country"); OnAfterPropertyChanged("BusinessAddress_Country");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the Business postal code for a contact item.
		/// </summary>
		public string BusinessAddress_PostalCode
		{
			get { return _cur__BusinessAddress_PostalCode; }
			set
			{
				if (_started_with_dbvalues == false) _mod__BusinessAddress_PostalCode = true;
				if (_cur__BusinessAddress_PostalCode == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__BusinessAddress_PostalCode == false) { _ori__BusinessAddress_PostalCode = _cur__BusinessAddress_PostalCode; _mod__BusinessAddress_PostalCode = true; } // existing record and column is not modified
					else { if (value == _ori__BusinessAddress_PostalCode) { _ori__BusinessAddress_PostalCode = default(string); _mod__BusinessAddress_PostalCode = false; } } // existing record and column is modified
				}
				_cur__BusinessAddress_PostalCode = value; OnPropertyChanged("BusinessAddress_PostalCode"); OnAfterPropertyChanged("BusinessAddress_PostalCode");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the Home street address for a contact item.
		/// </summary>
		public string HomeAddress_Street
		{
			get { return _cur__HomeAddress_Street; }
			set
			{
				if (_started_with_dbvalues == false) _mod__HomeAddress_Street = true;
				if (_cur__HomeAddress_Street == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__HomeAddress_Street == false) { _ori__HomeAddress_Street = _cur__HomeAddress_Street; _mod__HomeAddress_Street = true; } // existing record and column is not modified
					else { if (value == _ori__HomeAddress_Street) { _ori__HomeAddress_Street = default(string); _mod__HomeAddress_Street = false; } } // existing record and column is modified
				}
				_cur__HomeAddress_Street = value; OnPropertyChanged("HomeAddress_Street"); OnAfterPropertyChanged("HomeAddress_Street");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the Home city name for a contact item.
		/// </summary>
		public string HomeAddress_City
		{
			get { return _cur__HomeAddress_City; }
			set
			{
				if (_started_with_dbvalues == false) _mod__HomeAddress_City = true;
				if (_cur__HomeAddress_City == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__HomeAddress_City == false) { _ori__HomeAddress_City = _cur__HomeAddress_City; _mod__HomeAddress_City = true; } // existing record and column is not modified
					else { if (value == _ori__HomeAddress_City) { _ori__HomeAddress_City = default(string); _mod__HomeAddress_City = false; } } // existing record and column is modified
				}
				_cur__HomeAddress_City = value; OnPropertyChanged("HomeAddress_City"); OnAfterPropertyChanged("HomeAddress_City");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the Home state of residence for a contact item.
		/// </summary>
		public string HomeAddress_State
		{
			get { return _cur__HomeAddress_State; }
			set
			{
				if (_started_with_dbvalues == false) _mod__HomeAddress_State = true;
				if (_cur__HomeAddress_State == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__HomeAddress_State == false) { _ori__HomeAddress_State = _cur__HomeAddress_State; _mod__HomeAddress_State = true; } // existing record and column is not modified
					else { if (value == _ori__HomeAddress_State) { _ori__HomeAddress_State = default(string); _mod__HomeAddress_State = false; } } // existing record and column is modified
				}
				_cur__HomeAddress_State = value; OnPropertyChanged("HomeAddress_State"); OnAfterPropertyChanged("HomeAddress_State");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the Home country or region for a contact item.
		/// </summary>
		public string HomeAddress_Country
		{
			get { return _cur__HomeAddress_Country; }
			set
			{
				if (_started_with_dbvalues == false) _mod__HomeAddress_Country = true;
				if (_cur__HomeAddress_Country == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__HomeAddress_Country == false) { _ori__HomeAddress_Country = _cur__HomeAddress_Country; _mod__HomeAddress_Country = true; } // existing record and column is not modified
					else { if (value == _ori__HomeAddress_Country) { _ori__HomeAddress_Country = default(string); _mod__HomeAddress_Country = false; } } // existing record and column is modified
				}
				_cur__HomeAddress_Country = value; OnPropertyChanged("HomeAddress_Country"); OnAfterPropertyChanged("HomeAddress_Country");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the Home postal code for a contact item.
		/// </summary>
		public string HomeAddress_PostalCode
		{
			get { return _cur__HomeAddress_PostalCode; }
			set
			{
				if (_started_with_dbvalues == false) _mod__HomeAddress_PostalCode = true;
				if (_cur__HomeAddress_PostalCode == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__HomeAddress_PostalCode == false) { _ori__HomeAddress_PostalCode = _cur__HomeAddress_PostalCode; _mod__HomeAddress_PostalCode = true; } // existing record and column is not modified
					else { if (value == _ori__HomeAddress_PostalCode) { _ori__HomeAddress_PostalCode = default(string); _mod__HomeAddress_PostalCode = false; } } // existing record and column is modified
				}
				_cur__HomeAddress_PostalCode = value; OnPropertyChanged("HomeAddress_PostalCode"); OnAfterPropertyChanged("HomeAddress_PostalCode");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the Other street address for a contact item.
		/// </summary>
		public string OtherAddress_Street
		{
			get { return _cur__OtherAddress_Street; }
			set
			{
				if (_started_with_dbvalues == false) _mod__OtherAddress_Street = true;
				if (_cur__OtherAddress_Street == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__OtherAddress_Street == false) { _ori__OtherAddress_Street = _cur__OtherAddress_Street; _mod__OtherAddress_Street = true; } // existing record and column is not modified
					else { if (value == _ori__OtherAddress_Street) { _ori__OtherAddress_Street = default(string); _mod__OtherAddress_Street = false; } } // existing record and column is modified
				}
				_cur__OtherAddress_Street = value; OnPropertyChanged("OtherAddress_Street"); OnAfterPropertyChanged("OtherAddress_Street");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the Other city name for a contact item.
		/// </summary>
		public string OtherAddress_City
		{
			get { return _cur__OtherAddress_City; }
			set
			{
				if (_started_with_dbvalues == false) _mod__OtherAddress_City = true;
				if (_cur__OtherAddress_City == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__OtherAddress_City == false) { _ori__OtherAddress_City = _cur__OtherAddress_City; _mod__OtherAddress_City = true; } // existing record and column is not modified
					else { if (value == _ori__OtherAddress_City) { _ori__OtherAddress_City = default(string); _mod__OtherAddress_City = false; } } // existing record and column is modified
				}
				_cur__OtherAddress_City = value; OnPropertyChanged("OtherAddress_City"); OnAfterPropertyChanged("OtherAddress_City");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the Other state of residence for a contact item.
		/// </summary>
		public string OtherAddress_State
		{
			get { return _cur__OtherAddress_State; }
			set
			{
				if (_started_with_dbvalues == false) _mod__OtherAddress_State = true;
				if (_cur__OtherAddress_State == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__OtherAddress_State == false) { _ori__OtherAddress_State = _cur__OtherAddress_State; _mod__OtherAddress_State = true; } // existing record and column is not modified
					else { if (value == _ori__OtherAddress_State) { _ori__OtherAddress_State = default(string); _mod__OtherAddress_State = false; } } // existing record and column is modified
				}
				_cur__OtherAddress_State = value; OnPropertyChanged("OtherAddress_State"); OnAfterPropertyChanged("OtherAddress_State");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the Other country or region for a contact item.
		/// </summary>
		public string OtherAddress_Country
		{
			get { return _cur__OtherAddress_Country; }
			set
			{
				if (_started_with_dbvalues == false) _mod__OtherAddress_Country = true;
				if (_cur__OtherAddress_Country == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__OtherAddress_Country == false) { _ori__OtherAddress_Country = _cur__OtherAddress_Country; _mod__OtherAddress_Country = true; } // existing record and column is not modified
					else { if (value == _ori__OtherAddress_Country) { _ori__OtherAddress_Country = default(string); _mod__OtherAddress_Country = false; } } // existing record and column is modified
				}
				_cur__OtherAddress_Country = value; OnPropertyChanged("OtherAddress_Country"); OnAfterPropertyChanged("OtherAddress_Country");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the Other postal code for a contact item.
		/// </summary>
		public string OtherAddress_PostalCode
		{
			get { return _cur__OtherAddress_PostalCode; }
			set
			{
				if (_started_with_dbvalues == false) _mod__OtherAddress_PostalCode = true;
				if (_cur__OtherAddress_PostalCode == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__OtherAddress_PostalCode == false) { _ori__OtherAddress_PostalCode = _cur__OtherAddress_PostalCode; _mod__OtherAddress_PostalCode = true; } // existing record and column is not modified
					else { if (value == _ori__OtherAddress_PostalCode) { _ori__OtherAddress_PostalCode = default(string); _mod__OtherAddress_PostalCode = false; } } // existing record and column is modified
				}
				_cur__OtherAddress_PostalCode = value; OnPropertyChanged("OtherAddress_PostalCode"); OnAfterPropertyChanged("OtherAddress_PostalCode");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the AssistantPhone number for a contact item.
		/// </summary>
		public string AssistantPhone
		{
			get { return _cur__AssistantPhone; }
			set
			{
				if (_started_with_dbvalues == false) _mod__AssistantPhone = true;
				if (_cur__AssistantPhone == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__AssistantPhone == false) { _ori__AssistantPhone = _cur__AssistantPhone; _mod__AssistantPhone = true; } // existing record and column is not modified
					else { if (value == _ori__AssistantPhone) { _ori__AssistantPhone = default(string); _mod__AssistantPhone = false; } } // existing record and column is modified
				}
				_cur__AssistantPhone = value; OnPropertyChanged("AssistantPhone"); OnAfterPropertyChanged("AssistantPhone");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the BusinessFax number for a contact item.
		/// </summary>
		public string BusinessFax
		{
			get { return _cur__BusinessFax; }
			set
			{
				if (_started_with_dbvalues == false) _mod__BusinessFax = true;
				if (_cur__BusinessFax == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__BusinessFax == false) { _ori__BusinessFax = _cur__BusinessFax; _mod__BusinessFax = true; } // existing record and column is not modified
					else { if (value == _ori__BusinessFax) { _ori__BusinessFax = default(string); _mod__BusinessFax = false; } } // existing record and column is modified
				}
				_cur__BusinessFax = value; OnPropertyChanged("BusinessFax"); OnAfterPropertyChanged("BusinessFax");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the BusinessPhone number for a contact item.
		/// </summary>
		public string BusinessPhone
		{
			get { return _cur__BusinessPhone; }
			set
			{
				if (_started_with_dbvalues == false) _mod__BusinessPhone = true;
				if (_cur__BusinessPhone == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__BusinessPhone == false) { _ori__BusinessPhone = _cur__BusinessPhone; _mod__BusinessPhone = true; } // existing record and column is not modified
					else { if (value == _ori__BusinessPhone) { _ori__BusinessPhone = default(string); _mod__BusinessPhone = false; } } // existing record and column is modified
				}
				_cur__BusinessPhone = value; OnPropertyChanged("BusinessPhone"); OnAfterPropertyChanged("BusinessPhone");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the BusinessPhone2 number for a contact item.
		/// </summary>
		public string BusinessPhone2
		{
			get { return _cur__BusinessPhone2; }
			set
			{
				if (_started_with_dbvalues == false) _mod__BusinessPhone2 = true;
				if (_cur__BusinessPhone2 == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__BusinessPhone2 == false) { _ori__BusinessPhone2 = _cur__BusinessPhone2; _mod__BusinessPhone2 = true; } // existing record and column is not modified
					else { if (value == _ori__BusinessPhone2) { _ori__BusinessPhone2 = default(string); _mod__BusinessPhone2 = false; } } // existing record and column is modified
				}
				_cur__BusinessPhone2 = value; OnPropertyChanged("BusinessPhone2"); OnAfterPropertyChanged("BusinessPhone2");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the Callback number for a contact item.
		/// </summary>
		public string Callback
		{
			get { return _cur__Callback; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Callback = true;
				if (_cur__Callback == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Callback == false) { _ori__Callback = _cur__Callback; _mod__Callback = true; } // existing record and column is not modified
					else { if (value == _ori__Callback) { _ori__Callback = default(string); _mod__Callback = false; } } // existing record and column is modified
				}
				_cur__Callback = value; OnPropertyChanged("Callback"); OnAfterPropertyChanged("Callback");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the CarPhone number for a contact item.
		/// </summary>
		public string CarPhone
		{
			get { return _cur__CarPhone; }
			set
			{
				if (_started_with_dbvalues == false) _mod__CarPhone = true;
				if (_cur__CarPhone == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__CarPhone == false) { _ori__CarPhone = _cur__CarPhone; _mod__CarPhone = true; } // existing record and column is not modified
					else { if (value == _ori__CarPhone) { _ori__CarPhone = default(string); _mod__CarPhone = false; } } // existing record and column is modified
				}
				_cur__CarPhone = value; OnPropertyChanged("CarPhone"); OnAfterPropertyChanged("CarPhone");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the CompanyMainPhone number for a contact item.
		/// </summary>
		public string CompanyMainPhone
		{
			get { return _cur__CompanyMainPhone; }
			set
			{
				if (_started_with_dbvalues == false) _mod__CompanyMainPhone = true;
				if (_cur__CompanyMainPhone == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__CompanyMainPhone == false) { _ori__CompanyMainPhone = _cur__CompanyMainPhone; _mod__CompanyMainPhone = true; } // existing record and column is not modified
					else { if (value == _ori__CompanyMainPhone) { _ori__CompanyMainPhone = default(string); _mod__CompanyMainPhone = false; } } // existing record and column is modified
				}
				_cur__CompanyMainPhone = value; OnPropertyChanged("CompanyMainPhone"); OnAfterPropertyChanged("CompanyMainPhone");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the HomeFax number for a contact item.
		/// </summary>
		public string HomeFax
		{
			get { return _cur__HomeFax; }
			set
			{
				if (_started_with_dbvalues == false) _mod__HomeFax = true;
				if (_cur__HomeFax == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__HomeFax == false) { _ori__HomeFax = _cur__HomeFax; _mod__HomeFax = true; } // existing record and column is not modified
					else { if (value == _ori__HomeFax) { _ori__HomeFax = default(string); _mod__HomeFax = false; } } // existing record and column is modified
				}
				_cur__HomeFax = value; OnPropertyChanged("HomeFax"); OnAfterPropertyChanged("HomeFax");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the HomePhone number for a contact item.
		/// </summary>
		public string HomePhone
		{
			get { return _cur__HomePhone; }
			set
			{
				if (_started_with_dbvalues == false) _mod__HomePhone = true;
				if (_cur__HomePhone == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__HomePhone == false) { _ori__HomePhone = _cur__HomePhone; _mod__HomePhone = true; } // existing record and column is not modified
					else { if (value == _ori__HomePhone) { _ori__HomePhone = default(string); _mod__HomePhone = false; } } // existing record and column is modified
				}
				_cur__HomePhone = value; OnPropertyChanged("HomePhone"); OnAfterPropertyChanged("HomePhone");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the HomePhone2 number for a contact item.
		/// </summary>
		public string HomePhone2
		{
			get { return _cur__HomePhone2; }
			set
			{
				if (_started_with_dbvalues == false) _mod__HomePhone2 = true;
				if (_cur__HomePhone2 == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__HomePhone2 == false) { _ori__HomePhone2 = _cur__HomePhone2; _mod__HomePhone2 = true; } // existing record and column is not modified
					else { if (value == _ori__HomePhone2) { _ori__HomePhone2 = default(string); _mod__HomePhone2 = false; } } // existing record and column is modified
				}
				_cur__HomePhone2 = value; OnPropertyChanged("HomePhone2"); OnAfterPropertyChanged("HomePhone2");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the Isdn number for a contact item.
		/// </summary>
		public string Isdn
		{
			get { return _cur__Isdn; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Isdn = true;
				if (_cur__Isdn == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Isdn == false) { _ori__Isdn = _cur__Isdn; _mod__Isdn = true; } // existing record and column is not modified
					else { if (value == _ori__Isdn) { _ori__Isdn = default(string); _mod__Isdn = false; } } // existing record and column is modified
				}
				_cur__Isdn = value; OnPropertyChanged("Isdn"); OnAfterPropertyChanged("Isdn");
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
		/// Represents the OtherFax number for a contact item.
		/// </summary>
		public string OtherFax
		{
			get { return _cur__OtherFax; }
			set
			{
				if (_started_with_dbvalues == false) _mod__OtherFax = true;
				if (_cur__OtherFax == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__OtherFax == false) { _ori__OtherFax = _cur__OtherFax; _mod__OtherFax = true; } // existing record and column is not modified
					else { if (value == _ori__OtherFax) { _ori__OtherFax = default(string); _mod__OtherFax = false; } } // existing record and column is modified
				}
				_cur__OtherFax = value; OnPropertyChanged("OtherFax"); OnAfterPropertyChanged("OtherFax");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the OtherTelephone number for a contact item.
		/// </summary>
		public string OtherTelephone
		{
			get { return _cur__OtherTelephone; }
			set
			{
				if (_started_with_dbvalues == false) _mod__OtherTelephone = true;
				if (_cur__OtherTelephone == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__OtherTelephone == false) { _ori__OtherTelephone = _cur__OtherTelephone; _mod__OtherTelephone = true; } // existing record and column is not modified
					else { if (value == _ori__OtherTelephone) { _ori__OtherTelephone = default(string); _mod__OtherTelephone = false; } } // existing record and column is modified
				}
				_cur__OtherTelephone = value; OnPropertyChanged("OtherTelephone"); OnAfterPropertyChanged("OtherTelephone");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the Pager number for a contact item.
		/// </summary>
		public string Pager
		{
			get { return _cur__Pager; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Pager = true;
				if (_cur__Pager == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Pager == false) { _ori__Pager = _cur__Pager; _mod__Pager = true; } // existing record and column is not modified
					else { if (value == _ori__Pager) { _ori__Pager = default(string); _mod__Pager = false; } } // existing record and column is modified
				}
				_cur__Pager = value; OnPropertyChanged("Pager"); OnAfterPropertyChanged("Pager");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the PrimaryPhone number for a contact item.
		/// </summary>
		public string PrimaryPhone
		{
			get { return _cur__PrimaryPhone; }
			set
			{
				if (_started_with_dbvalues == false) _mod__PrimaryPhone = true;
				if (_cur__PrimaryPhone == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__PrimaryPhone == false) { _ori__PrimaryPhone = _cur__PrimaryPhone; _mod__PrimaryPhone = true; } // existing record and column is not modified
					else { if (value == _ori__PrimaryPhone) { _ori__PrimaryPhone = default(string); _mod__PrimaryPhone = false; } } // existing record and column is modified
				}
				_cur__PrimaryPhone = value; OnPropertyChanged("PrimaryPhone"); OnAfterPropertyChanged("PrimaryPhone");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the RadioPhone number for a contact item.
		/// </summary>
		public string RadioPhone
		{
			get { return _cur__RadioPhone; }
			set
			{
				if (_started_with_dbvalues == false) _mod__RadioPhone = true;
				if (_cur__RadioPhone == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__RadioPhone == false) { _ori__RadioPhone = _cur__RadioPhone; _mod__RadioPhone = true; } // existing record and column is not modified
					else { if (value == _ori__RadioPhone) { _ori__RadioPhone = default(string); _mod__RadioPhone = false; } } // existing record and column is modified
				}
				_cur__RadioPhone = value; OnPropertyChanged("RadioPhone"); OnAfterPropertyChanged("RadioPhone");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the Telex number for a contact item.
		/// </summary>
		public string Telex
		{
			get { return _cur__Telex; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Telex = true;
				if (_cur__Telex == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Telex == false) { _ori__Telex = _cur__Telex; _mod__Telex = true; } // existing record and column is not modified
					else { if (value == _ori__Telex) { _ori__Telex = default(string); _mod__Telex = false; } } // existing record and column is modified
				}
				_cur__Telex = value; OnPropertyChanged("Telex"); OnAfterPropertyChanged("Telex");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the TtyTddPhone number for a contact item.
		/// </summary>
		public string TtyTddPhone
		{
			get { return _cur__TtyTddPhone; }
			set
			{
				if (_started_with_dbvalues == false) _mod__TtyTddPhone = true;
				if (_cur__TtyTddPhone == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__TtyTddPhone == false) { _ori__TtyTddPhone = _cur__TtyTddPhone; _mod__TtyTddPhone = true; } // existing record and column is not modified
					else { if (value == _ori__TtyTddPhone) { _ori__TtyTddPhone = default(string); _mod__TtyTddPhone = false; } } // existing record and column is modified
				}
				_cur__TtyTddPhone = value; OnPropertyChanged("TtyTddPhone"); OnAfterPropertyChanged("TtyTddPhone");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents an assistant to a contact.
		/// </summary>
		public string AssistantName
		{
			get { return _cur__AssistantName; }
			set
			{
				if (_started_with_dbvalues == false) _mod__AssistantName = true;
				if (_cur__AssistantName == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__AssistantName == false) { _ori__AssistantName = _cur__AssistantName; _mod__AssistantName = true; } // existing record and column is not modified
					else { if (value == _ori__AssistantName) { _ori__AssistantName = default(string); _mod__AssistantName = false; } } // existing record and column is modified
				}
				_cur__AssistantName = value; OnPropertyChanged("AssistantName"); OnAfterPropertyChanged("AssistantName");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the birth date of a contact.
		/// </summary>
		public DateTime? Birthday
		{
			get { return _cur__Birthday; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Birthday = true;
				if (_cur__Birthday == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Birthday == false) { _ori__Birthday = _cur__Birthday; _mod__Birthday = true; } // existing record and column is not modified
					else { if (value == _ori__Birthday) { _ori__Birthday = default(DateTime?); _mod__Birthday = false; } } // existing record and column is modified
				}
				_cur__Birthday = value; OnPropertyChanged("Birthday"); OnAfterPropertyChanged("Birthday");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the Home page (Web address) for the contact.
		/// </summary>
		public string BusinessHomePage
		{
			get { return _cur__BusinessHomePage; }
			set
			{
				if (_started_with_dbvalues == false) _mod__BusinessHomePage = true;
				if (_cur__BusinessHomePage == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__BusinessHomePage == false) { _ori__BusinessHomePage = _cur__BusinessHomePage; _mod__BusinessHomePage = true; } // existing record and column is not modified
					else { if (value == _ori__BusinessHomePage) { _ori__BusinessHomePage = default(string); _mod__BusinessHomePage = false; } } // existing record and column is modified
				}
				_cur__BusinessHomePage = value; OnPropertyChanged("BusinessHomePage"); OnAfterPropertyChanged("BusinessHomePage");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Contains the name of the child of a contact.
		/// </summary>
		public string Children_1
		{
			get { return _cur__Children_1; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Children_1 = true;
				if (_cur__Children_1 == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Children_1 == false) { _ori__Children_1 = _cur__Children_1; _mod__Children_1 = true; } // existing record and column is not modified
					else { if (value == _ori__Children_1) { _ori__Children_1 = default(string); _mod__Children_1 = false; } } // existing record and column is modified
				}
				_cur__Children_1 = value; OnPropertyChanged("Children_1"); OnAfterPropertyChanged("Children_1");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Contains the name of the child of a contact.
		/// </summary>
		public string Children_2
		{
			get { return _cur__Children_2; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Children_2 = true;
				if (_cur__Children_2 == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Children_2 == false) { _ori__Children_2 = _cur__Children_2; _mod__Children_2 = true; } // existing record and column is not modified
					else { if (value == _ori__Children_2) { _ori__Children_2 = default(string); _mod__Children_2 = false; } } // existing record and column is modified
				}
				_cur__Children_2 = value; OnPropertyChanged("Children_2"); OnAfterPropertyChanged("Children_2");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Contains the name of the child of a contact.
		/// </summary>
		public string Children_3
		{
			get { return _cur__Children_3; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Children_3 = true;
				if (_cur__Children_3 == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Children_3 == false) { _ori__Children_3 = _cur__Children_3; _mod__Children_3 = true; } // existing record and column is not modified
					else { if (value == _ori__Children_3) { _ori__Children_3 = default(string); _mod__Children_3 = false; } } // existing record and column is modified
				}
				_cur__Children_3 = value; OnPropertyChanged("Children_3"); OnAfterPropertyChanged("Children_3");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the name of a company associated with a contact.
		/// </summary>
		public string Companies_1
		{
			get { return _cur__Companies_1; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Companies_1 = true;
				if (_cur__Companies_1 == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Companies_1 == false) { _ori__Companies_1 = _cur__Companies_1; _mod__Companies_1 = true; } // existing record and column is not modified
					else { if (value == _ori__Companies_1) { _ori__Companies_1 = default(string); _mod__Companies_1 = false; } } // existing record and column is modified
				}
				_cur__Companies_1 = value; OnPropertyChanged("Companies_1"); OnAfterPropertyChanged("Companies_1");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the name of a company associated with a contact.
		/// </summary>
		public string Companies_2
		{
			get { return _cur__Companies_2; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Companies_2 = true;
				if (_cur__Companies_2 == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Companies_2 == false) { _ori__Companies_2 = _cur__Companies_2; _mod__Companies_2 = true; } // existing record and column is not modified
					else { if (value == _ori__Companies_2) { _ori__Companies_2 = default(string); _mod__Companies_2 = false; } } // existing record and column is modified
				}
				_cur__Companies_2 = value; OnPropertyChanged("Companies_2"); OnAfterPropertyChanged("Companies_2");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the name of a company associated with a contact.
		/// </summary>
		public string Companies_3
		{
			get { return _cur__Companies_3; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Companies_3 = true;
				if (_cur__Companies_3 == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Companies_3 == false) { _ori__Companies_3 = _cur__Companies_3; _mod__Companies_3 = true; } // existing record and column is not modified
					else { if (value == _ori__Companies_3) { _ori__Companies_3 = default(string); _mod__Companies_3 = false; } } // existing record and column is modified
				}
				_cur__Companies_3 = value; OnPropertyChanged("Companies_3"); OnAfterPropertyChanged("Companies_3");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Describes whether the contact is located in the Exchange store or Active Directory Domain Services.
		/// </summary>
		public string ContactSource
		{
			get { return _cur__ContactSource; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ContactSource = true;
				if (_cur__ContactSource == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ContactSource == false) { _ori__ContactSource = _cur__ContactSource; _mod__ContactSource = true; } // existing record and column is not modified
					else { if (value == _ori__ContactSource) { _ori__ContactSource = default(string); _mod__ContactSource = false; } } // existing record and column is modified
				}
				_cur__ContactSource = value; OnPropertyChanged("ContactSource"); OnAfterPropertyChanged("ContactSource");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the department of a contact.
		/// </summary>
		public string Department
		{
			get { return _cur__Department; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Department = true;
				if (_cur__Department == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Department == false) { _ori__Department = _cur__Department; _mod__Department = true; } // existing record and column is not modified
					else { if (value == _ori__Department) { _ori__Department = default(string); _mod__Department = false; } } // existing record and column is modified
				}
				_cur__Department = value; OnPropertyChanged("Department"); OnAfterPropertyChanged("Department");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents a generational abbreviation that follows the full name of a contact.
		/// </summary>
		public string Generation
		{
			get { return _cur__Generation; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Generation = true;
				if (_cur__Generation == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Generation == false) { _ori__Generation = _cur__Generation; _mod__Generation = true; } // existing record and column is not modified
					else { if (value == _ori__Generation) { _ori__Generation = default(string); _mod__Generation = false; } } // existing record and column is modified
				}
				_cur__Generation = value; OnPropertyChanged("Generation"); OnAfterPropertyChanged("Generation");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents an instant messaging (IM) address for a contact.
		/// </summary>
		public string ImAddress1
		{
			get { return _cur__ImAddress1; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ImAddress1 = true;
				if (_cur__ImAddress1 == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ImAddress1 == false) { _ori__ImAddress1 = _cur__ImAddress1; _mod__ImAddress1 = true; } // existing record and column is not modified
					else { if (value == _ori__ImAddress1) { _ori__ImAddress1 = default(string); _mod__ImAddress1 = false; } } // existing record and column is modified
				}
				_cur__ImAddress1 = value; OnPropertyChanged("ImAddress1"); OnAfterPropertyChanged("ImAddress1");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents an instant messaging (IM) address for a contact.
		/// </summary>
		public string ImAddress2
		{
			get { return _cur__ImAddress2; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ImAddress2 = true;
				if (_cur__ImAddress2 == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ImAddress2 == false) { _ori__ImAddress2 = _cur__ImAddress2; _mod__ImAddress2 = true; } // existing record and column is not modified
					else { if (value == _ori__ImAddress2) { _ori__ImAddress2 = default(string); _mod__ImAddress2 = false; } } // existing record and column is modified
				}
				_cur__ImAddress2 = value; OnPropertyChanged("ImAddress2"); OnAfterPropertyChanged("ImAddress2");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents an instant messaging (IM) address for a contact.
		/// </summary>
		public string ImAddress3
		{
			get { return _cur__ImAddress3; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ImAddress3 = true;
				if (_cur__ImAddress3 == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ImAddress3 == false) { _ori__ImAddress3 = _cur__ImAddress3; _mod__ImAddress3 = true; } // existing record and column is not modified
					else { if (value == _ori__ImAddress3) { _ori__ImAddress3 = default(string); _mod__ImAddress3 = false; } } // existing record and column is modified
				}
				_cur__ImAddress3 = value; OnPropertyChanged("ImAddress3"); OnAfterPropertyChanged("ImAddress3");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the job title of a contact.
		/// </summary>
		public string JobTitle
		{
			get { return _cur__JobTitle; }
			set
			{
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
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the manager of a contact.
		/// </summary>
		public string Manager
		{
			get { return _cur__Manager; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Manager = true;
				if (_cur__Manager == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Manager == false) { _ori__Manager = _cur__Manager; _mod__Manager = true; } // existing record and column is not modified
					else { if (value == _ori__Manager) { _ori__Manager = default(string); _mod__Manager = false; } } // existing record and column is modified
				}
				_cur__Manager = value; OnPropertyChanged("Manager"); OnAfterPropertyChanged("Manager");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the mileage for a contact item.
		/// </summary>
		public string Mileage
		{
			get { return _cur__Mileage; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Mileage = true;
				if (_cur__Mileage == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Mileage == false) { _ori__Mileage = _cur__Mileage; _mod__Mileage = true; } // existing record and column is not modified
					else { if (value == _ori__Mileage) { _ori__Mileage = default(string); _mod__Mileage = false; } } // existing record and column is modified
				}
				_cur__Mileage = value; OnPropertyChanged("Mileage"); OnAfterPropertyChanged("Mileage");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the office location of a contact.
		/// </summary>
		public string OfficeLocation
		{
			get { return _cur__OfficeLocation; }
			set
			{
				if (_started_with_dbvalues == false) _mod__OfficeLocation = true;
				if (_cur__OfficeLocation == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__OfficeLocation == false) { _ori__OfficeLocation = _cur__OfficeLocation; _mod__OfficeLocation = true; } // existing record and column is not modified
					else { if (value == _ori__OfficeLocation) { _ori__OfficeLocation = default(string); _mod__OfficeLocation = false; } } // existing record and column is modified
				}
				_cur__OfficeLocation = value; OnPropertyChanged("OfficeLocation"); OnAfterPropertyChanged("OfficeLocation");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the display type for the physical address of a contact.
		/// </summary>
		public string PostalAddressIndex
		{
			get { return _cur__PostalAddressIndex; }
			set
			{
				if (_started_with_dbvalues == false) _mod__PostalAddressIndex = true;
				if (_cur__PostalAddressIndex == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__PostalAddressIndex == false) { _ori__PostalAddressIndex = _cur__PostalAddressIndex; _mod__PostalAddressIndex = true; } // existing record and column is not modified
					else { if (value == _ori__PostalAddressIndex) { _ori__PostalAddressIndex = default(string); _mod__PostalAddressIndex = false; } } // existing record and column is modified
				}
				_cur__PostalAddressIndex = value; OnPropertyChanged("PostalAddressIndex"); OnAfterPropertyChanged("PostalAddressIndex");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the profession of a contact.
		/// </summary>
		public string Profession
		{
			get { return _cur__Profession; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Profession = true;
				if (_cur__Profession == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Profession == false) { _ori__Profession = _cur__Profession; _mod__Profession = true; } // existing record and column is not modified
					else { if (value == _ori__Profession) { _ori__Profession = default(string); _mod__Profession = false; } } // existing record and column is modified
				}
				_cur__Profession = value; OnPropertyChanged("Profession"); OnAfterPropertyChanged("Profession");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the name of the spouse or partner of the contact.
		/// </summary>
		public string SpouseName
		{
			get { return _cur__SpouseName; }
			set
			{
				if (_started_with_dbvalues == false) _mod__SpouseName = true;
				if (_cur__SpouseName == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__SpouseName == false) { _ori__SpouseName = _cur__SpouseName; _mod__SpouseName = true; } // existing record and column is not modified
					else { if (value == _ori__SpouseName) { _ori__SpouseName = default(string); _mod__SpouseName = false; } } // existing record and column is modified
				}
				_cur__SpouseName = value; OnPropertyChanged("SpouseName"); OnAfterPropertyChanged("SpouseName");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Represents the surname of a contact.
		/// </summary>
		public string Surname
		{
			get { return _cur__Surname; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Surname = true;
				if (_cur__Surname == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Surname == false) { _ori__Surname = _cur__Surname; _mod__Surname = true; } // existing record and column is not modified
					else { if (value == _ori__Surname) { _ori__Surname = default(string); _mod__Surname = false; } } // existing record and column is modified
				}
				_cur__Surname = value; OnPropertyChanged("Surname"); OnAfterPropertyChanged("Surname");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Contains the wedding anniversary of a contact.
		/// </summary>
		public DateTime? WeddingAnniversary
		{
			get { return _cur__WeddingAnniversary; }
			set
			{
				if (_started_with_dbvalues == false) _mod__WeddingAnniversary = true;
				if (_cur__WeddingAnniversary == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__WeddingAnniversary == false) { _ori__WeddingAnniversary = _cur__WeddingAnniversary; _mod__WeddingAnniversary = true; } // existing record and column is not modified
					else { if (value == _ori__WeddingAnniversary) { _ori__WeddingAnniversary = default(DateTime?); _mod__WeddingAnniversary = false; } } // existing record and column is modified
				}
				_cur__WeddingAnniversary = value; OnPropertyChanged("WeddingAnniversary"); OnAfterPropertyChanged("WeddingAnniversary");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Indicates whether the contact item has a file attachment that represents the picture of a contact.
		/// </summary>
		public bool? HasPicture
		{
			get { return _cur__HasPicture; }
			set
			{
				if (_started_with_dbvalues == false) _mod__HasPicture = true;
				if (_cur__HasPicture == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__HasPicture == false) { _ori__HasPicture = _cur__HasPicture; _mod__HasPicture = true; } // existing record and column is not modified
					else { if (value == _ori__HasPicture) { _ori__HasPicture = default(bool?); _mod__HasPicture = false; } } // existing record and column is modified
				}
				_cur__HasPicture = value; OnPropertyChanged("HasPicture"); OnAfterPropertyChanged("HasPicture");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Contains the full name of a contact, including the first and last name, spelled phonetically.
		/// </summary>
		public string PhoneticFullName
		{
			get { return _cur__PhoneticFullName; }
			set
			{
				if (_started_with_dbvalues == false) _mod__PhoneticFullName = true;
				if (_cur__PhoneticFullName == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__PhoneticFullName == false) { _ori__PhoneticFullName = _cur__PhoneticFullName; _mod__PhoneticFullName = true; } // existing record and column is not modified
					else { if (value == _ori__PhoneticFullName) { _ori__PhoneticFullName = default(string); _mod__PhoneticFullName = false; } } // existing record and column is modified
				}
				_cur__PhoneticFullName = value; OnPropertyChanged("PhoneticFullName"); OnAfterPropertyChanged("PhoneticFullName");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Contains the first name of a contact, spelled phonetically.
		/// </summary>
		public string PhoneticFirstName
		{
			get { return _cur__PhoneticFirstName; }
			set
			{
				if (_started_with_dbvalues == false) _mod__PhoneticFirstName = true;
				if (_cur__PhoneticFirstName == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__PhoneticFirstName == false) { _ori__PhoneticFirstName = _cur__PhoneticFirstName; _mod__PhoneticFirstName = true; } // existing record and column is not modified
					else { if (value == _ori__PhoneticFirstName) { _ori__PhoneticFirstName = default(string); _mod__PhoneticFirstName = false; } } // existing record and column is modified
				}
				_cur__PhoneticFirstName = value; OnPropertyChanged("PhoneticFirstName"); OnAfterPropertyChanged("PhoneticFirstName");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Contains the last name of a contact, spelled phonetically.
		/// </summary>
		public string PhoneticLastName
		{
			get { return _cur__PhoneticLastName; }
			set
			{
				if (_started_with_dbvalues == false) _mod__PhoneticLastName = true;
				if (_cur__PhoneticLastName == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__PhoneticLastName == false) { _ori__PhoneticLastName = _cur__PhoneticLastName; _mod__PhoneticLastName = true; } // existing record and column is not modified
					else { if (value == _ori__PhoneticLastName) { _ori__PhoneticLastName = default(string); _mod__PhoneticLastName = false; } } // existing record and column is modified
				}
				_cur__PhoneticLastName = value; OnPropertyChanged("PhoneticLastName"); OnAfterPropertyChanged("PhoneticLastName");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Contains the email alias of a contact.
		/// </summary>
		public string Alias
		{
			get { return _cur__Alias; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Alias = true;
				if (_cur__Alias == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Alias == false) { _ori__Alias = _cur__Alias; _mod__Alias = true; } // existing record and column is not modified
					else { if (value == _ori__Alias) { _ori__Alias = default(string); _mod__Alias = false; } } // existing record and column is modified
				}
				_cur__Alias = value; OnPropertyChanged("Alias"); OnAfterPropertyChanged("Alias");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Contains supplementary contact information.
		/// </summary>
		public string Notes
		{
			get { return _cur__Notes; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Notes = true;
				if (_cur__Notes == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Notes == false) { _ori__Notes = _cur__Notes; _mod__Notes = true; } // existing record and column is not modified
					else { if (value == _ori__Notes) { _ori__Notes = default(string); _mod__Notes = false; } } // existing record and column is modified
				}
				_cur__Notes = value; OnPropertyChanged("Notes"); OnAfterPropertyChanged("Notes");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Contains a value that encodes the photo of a contact.
		/// </summary>
		public string Photo
		{
			get { return _cur__Photo; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Photo = true;
				if (_cur__Photo == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Photo == false) { _ori__Photo = _cur__Photo; _mod__Photo = true; } // existing record and column is not modified
					else { if (value == _ori__Photo) { _ori__Photo = default(string); _mod__Photo = false; } } // existing record and column is modified
				}
				_cur__Photo = value; OnPropertyChanged("Photo"); OnAfterPropertyChanged("Photo");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Contains a value that encodes the SMIME certificate of a contact.
		/// </summary>
		public string UserSMIMECertificate
		{
			get { return _cur__UserSMIMECertificate; }
			set
			{
				if (_started_with_dbvalues == false) _mod__UserSMIMECertificate = true;
				if (_cur__UserSMIMECertificate == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__UserSMIMECertificate == false) { _ori__UserSMIMECertificate = _cur__UserSMIMECertificate; _mod__UserSMIMECertificate = true; } // existing record and column is not modified
					else { if (value == _ori__UserSMIMECertificate) { _ori__UserSMIMECertificate = default(string); _mod__UserSMIMECertificate = false; } } // existing record and column is modified
				}
				_cur__UserSMIMECertificate = value; OnPropertyChanged("UserSMIMECertificate"); OnAfterPropertyChanged("UserSMIMECertificate");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Contains a value that encodes the Microsoft Exchange certificate of a contact.
		/// </summary>
		public string MSExchangeCertificate
		{
			get { return _cur__MSExchangeCertificate; }
			set
			{
				if (_started_with_dbvalues == false) _mod__MSExchangeCertificate = true;
				if (_cur__MSExchangeCertificate == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__MSExchangeCertificate == false) { _ori__MSExchangeCertificate = _cur__MSExchangeCertificate; _mod__MSExchangeCertificate = true; } // existing record and column is not modified
					else { if (value == _ori__MSExchangeCertificate) { _ori__MSExchangeCertificate = default(string); _mod__MSExchangeCertificate = false; } } // existing record and column is modified
				}
				_cur__MSExchangeCertificate = value; OnPropertyChanged("MSExchangeCertificate"); OnAfterPropertyChanged("MSExchangeCertificate");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Contains the directory Id of a contact.
		/// </summary>
		public string DirectoryId
		{
			get { return _cur__DirectoryId; }
			set
			{
				if (_started_with_dbvalues == false) _mod__DirectoryId = true;
				if (_cur__DirectoryId == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__DirectoryId == false) { _ori__DirectoryId = _cur__DirectoryId; _mod__DirectoryId = true; } // existing record and column is not modified
					else { if (value == _ori__DirectoryId) { _ori__DirectoryId = default(string); _mod__DirectoryId = false; } } // existing record and column is modified
				}
				_cur__DirectoryId = value; OnPropertyChanged("DirectoryId"); OnAfterPropertyChanged("DirectoryId");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Contains SMTP information that identifies the mailbox of the manager of a contact.
		/// </summary>
		public string ManagerMailbox
		{
			get { return _cur__ManagerMailbox; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ManagerMailbox = true;
				if (_cur__ManagerMailbox == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ManagerMailbox == false) { _ori__ManagerMailbox = _cur__ManagerMailbox; _mod__ManagerMailbox = true; } // existing record and column is not modified
					else { if (value == _ori__ManagerMailbox) { _ori__ManagerMailbox = default(string); _mod__ManagerMailbox = false; } } // existing record and column is modified
				}
				_cur__ManagerMailbox = value; OnPropertyChanged("ManagerMailbox"); OnAfterPropertyChanged("ManagerMailbox");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Contacts]. NotReadonly. AllowNull.
		/// Contains SMTP information that identifies the direct reports of a contact.
		/// </summary>
		public string DirectReports
		{
			get { return _cur__DirectReports; }
			set
			{
				if (_started_with_dbvalues == false) _mod__DirectReports = true;
				if (_cur__DirectReports == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__DirectReports == false) { _ori__DirectReports = _cur__DirectReports; _mod__DirectReports = true; } // existing record and column is not modified
					else { if (value == _ori__DirectReports) { _ori__DirectReports = default(string); _mod__DirectReports = false; } } // existing record and column is modified
				}
				_cur__DirectReports = value; OnPropertyChanged("DirectReports"); OnAfterPropertyChanged("DirectReports");
			}
		}

		public bool IsModified(string column_name)
		{
			if (column_name == "ItemId") return _mod__ItemId;
			if (column_name == "MimeContent") return _mod__MimeContent;
			if (column_name == "ItemChangeKey") return _mod__ItemChangeKey;
			if (column_name == "ParentFolderId") return _mod__ParentFolderId;
			if (column_name == "ParentFolderChangeKey") return _mod__ParentFolderChangeKey;
			if (column_name == "ItemClass") return _mod__ItemClass;
			if (column_name == "Subject") return _mod__Subject;
			if (column_name == "Sensitivity") return _mod__Sensitivity;
			if (column_name == "Body") return _mod__Body;
			if (column_name == "DateTimeReceived") return _mod__DateTimeReceived;
			if (column_name == "Size") return _mod__Size;
			if (column_name == "Categories") return _mod__Categories;
			if (column_name == "Importance") return _mod__Importance;
			if (column_name == "IsSubmitted") return _mod__IsSubmitted;
			if (column_name == "InReplyTo") return _mod__InReplyTo;
			if (column_name == "IsDraft") return _mod__IsDraft;
			if (column_name == "IsFromMe") return _mod__IsFromMe;
			if (column_name == "IsResend") return _mod__IsResend;
			if (column_name == "IsUnmodified") return _mod__IsUnmodified;
			if (column_name == "InternetMessageHeaders") return _mod__InternetMessageHeaders;
			if (column_name == "DateTimeSent") return _mod__DateTimeSent;
			if (column_name == "DateTimeCreated") return _mod__DateTimeCreated;
			if (column_name == "ReminderDueBy") return _mod__ReminderDueBy;
			if (column_name == "ReminderIsSet") return _mod__ReminderIsSet;
			if (column_name == "ReminderMinutesBeforeStart") return _mod__ReminderMinutesBeforeStart;
			if (column_name == "DisplayCc") return _mod__DisplayCc;
			if (column_name == "DisplayTo") return _mod__DisplayTo;
			if (column_name == "HasAttachments") return _mod__HasAttachments;
			if (column_name == "Culture") return _mod__Culture;
			if (column_name == "EffectiveRights_CreateAssociated") return _mod__EffectiveRights_CreateAssociated;
			if (column_name == "EffectiveRights_CreateContents") return _mod__EffectiveRights_CreateContents;
			if (column_name == "EffectiveRights_CreateHierarchy") return _mod__EffectiveRights_CreateHierarchy;
			if (column_name == "EffectiveRights_Delete") return _mod__EffectiveRights_Delete;
			if (column_name == "EffectiveRights_Modify") return _mod__EffectiveRights_Modify;
			if (column_name == "EffectiveRights_Read") return _mod__EffectiveRights_Read;
			if (column_name == "EffectiveRights_ViewPrivateItems") return _mod__EffectiveRights_ViewPrivateItems;
			if (column_name == "LastModifiedName") return _mod__LastModifiedName;
			if (column_name == "LastModifiedTime") return _mod__LastModifiedTime;
			if (column_name == "IsAssociated") return _mod__IsAssociated;
			if (column_name == "WebClientReadFormQueryString") return _mod__WebClientReadFormQueryString;
			if (column_name == "WebClientEditFormQueryString") return _mod__WebClientEditFormQueryString;
			if (column_name == "ConversationId") return _mod__ConversationId;
			if (column_name == "UniqueBody") return _mod__UniqueBody;
			if (column_name == "UniqueBodyType") return _mod__UniqueBodyType;
			if (column_name == "FileAs") return _mod__FileAs;
			if (column_name == "FileAsMapping") return _mod__FileAsMapping;
			if (column_name == "DisplayName") return _mod__DisplayName;
			if (column_name == "GivenName") return _mod__GivenName;
			if (column_name == "Initials") return _mod__Initials;
			if (column_name == "MiddleName") return _mod__MiddleName;
			if (column_name == "Nickname") return _mod__Nickname;
			if (column_name == "CompleteName_Title") return _mod__CompleteName_Title;
			if (column_name == "CompleteName_FirstName") return _mod__CompleteName_FirstName;
			if (column_name == "CompleteName_MiddleName") return _mod__CompleteName_MiddleName;
			if (column_name == "CompleteName_LastName") return _mod__CompleteName_LastName;
			if (column_name == "CompleteName_Suffix") return _mod__CompleteName_Suffix;
			if (column_name == "CompleteName_Initials") return _mod__CompleteName_Initials;
			if (column_name == "CompleteName_FullName") return _mod__CompleteName_FullName;
			if (column_name == "CompleteName_Nickname") return _mod__CompleteName_Nickname;
			if (column_name == "CompleteName_YomiFirstName") return _mod__CompleteName_YomiFirstName;
			if (column_name == "CompleteName_YomiLastName") return _mod__CompleteName_YomiLastName;
			if (column_name == "CompanyName") return _mod__CompanyName;
			if (column_name == "EmailAddress1") return _mod__EmailAddress1;
			if (column_name == "EmailAddress2") return _mod__EmailAddress2;
			if (column_name == "EmailAddress3") return _mod__EmailAddress3;
			if (column_name == "BusinessAddress_Street") return _mod__BusinessAddress_Street;
			if (column_name == "BusinessAddress_City") return _mod__BusinessAddress_City;
			if (column_name == "BusinessAddress_State") return _mod__BusinessAddress_State;
			if (column_name == "BusinessAddress_Country") return _mod__BusinessAddress_Country;
			if (column_name == "BusinessAddress_PostalCode") return _mod__BusinessAddress_PostalCode;
			if (column_name == "HomeAddress_Street") return _mod__HomeAddress_Street;
			if (column_name == "HomeAddress_City") return _mod__HomeAddress_City;
			if (column_name == "HomeAddress_State") return _mod__HomeAddress_State;
			if (column_name == "HomeAddress_Country") return _mod__HomeAddress_Country;
			if (column_name == "HomeAddress_PostalCode") return _mod__HomeAddress_PostalCode;
			if (column_name == "OtherAddress_Street") return _mod__OtherAddress_Street;
			if (column_name == "OtherAddress_City") return _mod__OtherAddress_City;
			if (column_name == "OtherAddress_State") return _mod__OtherAddress_State;
			if (column_name == "OtherAddress_Country") return _mod__OtherAddress_Country;
			if (column_name == "OtherAddress_PostalCode") return _mod__OtherAddress_PostalCode;
			if (column_name == "AssistantPhone") return _mod__AssistantPhone;
			if (column_name == "BusinessFax") return _mod__BusinessFax;
			if (column_name == "BusinessPhone") return _mod__BusinessPhone;
			if (column_name == "BusinessPhone2") return _mod__BusinessPhone2;
			if (column_name == "Callback") return _mod__Callback;
			if (column_name == "CarPhone") return _mod__CarPhone;
			if (column_name == "CompanyMainPhone") return _mod__CompanyMainPhone;
			if (column_name == "HomeFax") return _mod__HomeFax;
			if (column_name == "HomePhone") return _mod__HomePhone;
			if (column_name == "HomePhone2") return _mod__HomePhone2;
			if (column_name == "Isdn") return _mod__Isdn;
			if (column_name == "MobilePhone") return _mod__MobilePhone;
			if (column_name == "OtherFax") return _mod__OtherFax;
			if (column_name == "OtherTelephone") return _mod__OtherTelephone;
			if (column_name == "Pager") return _mod__Pager;
			if (column_name == "PrimaryPhone") return _mod__PrimaryPhone;
			if (column_name == "RadioPhone") return _mod__RadioPhone;
			if (column_name == "Telex") return _mod__Telex;
			if (column_name == "TtyTddPhone") return _mod__TtyTddPhone;
			if (column_name == "AssistantName") return _mod__AssistantName;
			if (column_name == "Birthday") return _mod__Birthday;
			if (column_name == "BusinessHomePage") return _mod__BusinessHomePage;
			if (column_name == "Children_1") return _mod__Children_1;
			if (column_name == "Children_2") return _mod__Children_2;
			if (column_name == "Children_3") return _mod__Children_3;
			if (column_name == "Companies_1") return _mod__Companies_1;
			if (column_name == "Companies_2") return _mod__Companies_2;
			if (column_name == "Companies_3") return _mod__Companies_3;
			if (column_name == "ContactSource") return _mod__ContactSource;
			if (column_name == "Department") return _mod__Department;
			if (column_name == "Generation") return _mod__Generation;
			if (column_name == "ImAddress1") return _mod__ImAddress1;
			if (column_name == "ImAddress2") return _mod__ImAddress2;
			if (column_name == "ImAddress3") return _mod__ImAddress3;
			if (column_name == "JobTitle") return _mod__JobTitle;
			if (column_name == "Manager") return _mod__Manager;
			if (column_name == "Mileage") return _mod__Mileage;
			if (column_name == "OfficeLocation") return _mod__OfficeLocation;
			if (column_name == "PostalAddressIndex") return _mod__PostalAddressIndex;
			if (column_name == "Profession") return _mod__Profession;
			if (column_name == "SpouseName") return _mod__SpouseName;
			if (column_name == "Surname") return _mod__Surname;
			if (column_name == "WeddingAnniversary") return _mod__WeddingAnniversary;
			if (column_name == "HasPicture") return _mod__HasPicture;
			if (column_name == "PhoneticFullName") return _mod__PhoneticFullName;
			if (column_name == "PhoneticFirstName") return _mod__PhoneticFirstName;
			if (column_name == "PhoneticLastName") return _mod__PhoneticLastName;
			if (column_name == "Alias") return _mod__Alias;
			if (column_name == "Notes") return _mod__Notes;
			if (column_name == "Photo") return _mod__Photo;
			if (column_name == "UserSMIMECertificate") return _mod__UserSMIMECertificate;
			if (column_name == "MSExchangeCertificate") return _mod__MSExchangeCertificate;
			if (column_name == "DirectoryId") return _mod__DirectoryId;
			if (column_name == "ManagerMailbox") return _mod__ManagerMailbox;
			if (column_name == "DirectReports") return _mod__DirectReports;
			throw new ArgumentOutOfRangeException(String.Format(VenturaStrings.UNKNOWN_COLUMN_NAME, column_name));
		}

		public int ModifiedColumnCount()
		{
			int count = 0;
			if (_mod__ItemId == true) count++;
			if (_mod__MimeContent == true) count++;
			if (_mod__ItemChangeKey == true) count++;
			if (_mod__ParentFolderId == true) count++;
			if (_mod__ParentFolderChangeKey == true) count++;
			if (_mod__ItemClass == true) count++;
			if (_mod__Subject == true) count++;
			if (_mod__Sensitivity == true) count++;
			if (_mod__Body == true) count++;
			if (_mod__DateTimeReceived == true) count++;
			if (_mod__Size == true) count++;
			if (_mod__Categories == true) count++;
			if (_mod__Importance == true) count++;
			if (_mod__IsSubmitted == true) count++;
			if (_mod__InReplyTo == true) count++;
			if (_mod__IsDraft == true) count++;
			if (_mod__IsFromMe == true) count++;
			if (_mod__IsResend == true) count++;
			if (_mod__IsUnmodified == true) count++;
			if (_mod__InternetMessageHeaders == true) count++;
			if (_mod__DateTimeSent == true) count++;
			if (_mod__DateTimeCreated == true) count++;
			if (_mod__ReminderDueBy == true) count++;
			if (_mod__ReminderIsSet == true) count++;
			if (_mod__ReminderMinutesBeforeStart == true) count++;
			if (_mod__DisplayCc == true) count++;
			if (_mod__DisplayTo == true) count++;
			if (_mod__HasAttachments == true) count++;
			if (_mod__Culture == true) count++;
			if (_mod__EffectiveRights_CreateAssociated == true) count++;
			if (_mod__EffectiveRights_CreateContents == true) count++;
			if (_mod__EffectiveRights_CreateHierarchy == true) count++;
			if (_mod__EffectiveRights_Delete == true) count++;
			if (_mod__EffectiveRights_Modify == true) count++;
			if (_mod__EffectiveRights_Read == true) count++;
			if (_mod__EffectiveRights_ViewPrivateItems == true) count++;
			if (_mod__LastModifiedName == true) count++;
			if (_mod__LastModifiedTime == true) count++;
			if (_mod__IsAssociated == true) count++;
			if (_mod__WebClientReadFormQueryString == true) count++;
			if (_mod__WebClientEditFormQueryString == true) count++;
			if (_mod__ConversationId == true) count++;
			if (_mod__UniqueBody == true) count++;
			if (_mod__UniqueBodyType == true) count++;
			if (_mod__FileAs == true) count++;
			if (_mod__FileAsMapping == true) count++;
			if (_mod__DisplayName == true) count++;
			if (_mod__GivenName == true) count++;
			if (_mod__Initials == true) count++;
			if (_mod__MiddleName == true) count++;
			if (_mod__Nickname == true) count++;
			if (_mod__CompleteName_Title == true) count++;
			if (_mod__CompleteName_FirstName == true) count++;
			if (_mod__CompleteName_MiddleName == true) count++;
			if (_mod__CompleteName_LastName == true) count++;
			if (_mod__CompleteName_Suffix == true) count++;
			if (_mod__CompleteName_Initials == true) count++;
			if (_mod__CompleteName_FullName == true) count++;
			if (_mod__CompleteName_Nickname == true) count++;
			if (_mod__CompleteName_YomiFirstName == true) count++;
			if (_mod__CompleteName_YomiLastName == true) count++;
			if (_mod__CompanyName == true) count++;
			if (_mod__EmailAddress1 == true) count++;
			if (_mod__EmailAddress2 == true) count++;
			if (_mod__EmailAddress3 == true) count++;
			if (_mod__BusinessAddress_Street == true) count++;
			if (_mod__BusinessAddress_City == true) count++;
			if (_mod__BusinessAddress_State == true) count++;
			if (_mod__BusinessAddress_Country == true) count++;
			if (_mod__BusinessAddress_PostalCode == true) count++;
			if (_mod__HomeAddress_Street == true) count++;
			if (_mod__HomeAddress_City == true) count++;
			if (_mod__HomeAddress_State == true) count++;
			if (_mod__HomeAddress_Country == true) count++;
			if (_mod__HomeAddress_PostalCode == true) count++;
			if (_mod__OtherAddress_Street == true) count++;
			if (_mod__OtherAddress_City == true) count++;
			if (_mod__OtherAddress_State == true) count++;
			if (_mod__OtherAddress_Country == true) count++;
			if (_mod__OtherAddress_PostalCode == true) count++;
			if (_mod__AssistantPhone == true) count++;
			if (_mod__BusinessFax == true) count++;
			if (_mod__BusinessPhone == true) count++;
			if (_mod__BusinessPhone2 == true) count++;
			if (_mod__Callback == true) count++;
			if (_mod__CarPhone == true) count++;
			if (_mod__CompanyMainPhone == true) count++;
			if (_mod__HomeFax == true) count++;
			if (_mod__HomePhone == true) count++;
			if (_mod__HomePhone2 == true) count++;
			if (_mod__Isdn == true) count++;
			if (_mod__MobilePhone == true) count++;
			if (_mod__OtherFax == true) count++;
			if (_mod__OtherTelephone == true) count++;
			if (_mod__Pager == true) count++;
			if (_mod__PrimaryPhone == true) count++;
			if (_mod__RadioPhone == true) count++;
			if (_mod__Telex == true) count++;
			if (_mod__TtyTddPhone == true) count++;
			if (_mod__AssistantName == true) count++;
			if (_mod__Birthday == true) count++;
			if (_mod__BusinessHomePage == true) count++;
			if (_mod__Children_1 == true) count++;
			if (_mod__Children_2 == true) count++;
			if (_mod__Children_3 == true) count++;
			if (_mod__Companies_1 == true) count++;
			if (_mod__Companies_2 == true) count++;
			if (_mod__Companies_3 == true) count++;
			if (_mod__ContactSource == true) count++;
			if (_mod__Department == true) count++;
			if (_mod__Generation == true) count++;
			if (_mod__ImAddress1 == true) count++;
			if (_mod__ImAddress2 == true) count++;
			if (_mod__ImAddress3 == true) count++;
			if (_mod__JobTitle == true) count++;
			if (_mod__Manager == true) count++;
			if (_mod__Mileage == true) count++;
			if (_mod__OfficeLocation == true) count++;
			if (_mod__PostalAddressIndex == true) count++;
			if (_mod__Profession == true) count++;
			if (_mod__SpouseName == true) count++;
			if (_mod__Surname == true) count++;
			if (_mod__WeddingAnniversary == true) count++;
			if (_mod__HasPicture == true) count++;
			if (_mod__PhoneticFullName == true) count++;
			if (_mod__PhoneticFirstName == true) count++;
			if (_mod__PhoneticLastName == true) count++;
			if (_mod__Alias == true) count++;
			if (_mod__Notes == true) count++;
			if (_mod__Photo == true) count++;
			if (_mod__UserSMIMECertificate == true) count++;
			if (_mod__MSExchangeCertificate == true) count++;
			if (_mod__DirectoryId == true) count++;
			if (_mod__ManagerMailbox == true) count++;
			if (_mod__DirectReports == true) count++;
			return count;
		}

		public bool PendingChanges()
		{
			if (_recordstatus == DataRecordStatus.New || _recordstatus == DataRecordStatus.ExistingDelete) return true;
			int count = 0;
			if (_mod__ParentFolderId == true) count++;
			if (_mod__ItemClass == true) count++;
			if (_mod__Subject == true) count++;
			if (_mod__Body == true) count++;
			if (_mod__Categories == true) count++;
			if (_mod__Importance == true) count++;
			if (_mod__ReminderDueBy == true) count++;
			if (_mod__ReminderIsSet == true) count++;
			if (_mod__ReminderMinutesBeforeStart == true) count++;
			if (_mod__Culture == true) count++;
			if (_mod__IsAssociated == true) count++;
			if (_mod__FileAs == true) count++;
			if (_mod__FileAsMapping == true) count++;
			if (_mod__DisplayName == true) count++;
			if (_mod__GivenName == true) count++;
			if (_mod__Initials == true) count++;
			if (_mod__MiddleName == true) count++;
			if (_mod__Nickname == true) count++;
			if (_mod__CompanyName == true) count++;
			if (_mod__EmailAddress1 == true) count++;
			if (_mod__EmailAddress2 == true) count++;
			if (_mod__EmailAddress3 == true) count++;
			if (_mod__BusinessAddress_Street == true) count++;
			if (_mod__BusinessAddress_City == true) count++;
			if (_mod__BusinessAddress_State == true) count++;
			if (_mod__BusinessAddress_Country == true) count++;
			if (_mod__BusinessAddress_PostalCode == true) count++;
			if (_mod__HomeAddress_Street == true) count++;
			if (_mod__HomeAddress_City == true) count++;
			if (_mod__HomeAddress_State == true) count++;
			if (_mod__HomeAddress_Country == true) count++;
			if (_mod__HomeAddress_PostalCode == true) count++;
			if (_mod__OtherAddress_Street == true) count++;
			if (_mod__OtherAddress_City == true) count++;
			if (_mod__OtherAddress_State == true) count++;
			if (_mod__OtherAddress_Country == true) count++;
			if (_mod__OtherAddress_PostalCode == true) count++;
			if (_mod__AssistantPhone == true) count++;
			if (_mod__BusinessFax == true) count++;
			if (_mod__BusinessPhone == true) count++;
			if (_mod__BusinessPhone2 == true) count++;
			if (_mod__Callback == true) count++;
			if (_mod__CarPhone == true) count++;
			if (_mod__CompanyMainPhone == true) count++;
			if (_mod__HomeFax == true) count++;
			if (_mod__HomePhone == true) count++;
			if (_mod__HomePhone2 == true) count++;
			if (_mod__Isdn == true) count++;
			if (_mod__MobilePhone == true) count++;
			if (_mod__OtherFax == true) count++;
			if (_mod__OtherTelephone == true) count++;
			if (_mod__Pager == true) count++;
			if (_mod__PrimaryPhone == true) count++;
			if (_mod__RadioPhone == true) count++;
			if (_mod__Telex == true) count++;
			if (_mod__TtyTddPhone == true) count++;
			if (_mod__AssistantName == true) count++;
			if (_mod__Birthday == true) count++;
			if (_mod__BusinessHomePage == true) count++;
			if (_mod__Children_1 == true) count++;
			if (_mod__Children_2 == true) count++;
			if (_mod__Children_3 == true) count++;
			if (_mod__Companies_1 == true) count++;
			if (_mod__Companies_2 == true) count++;
			if (_mod__Companies_3 == true) count++;
			if (_mod__ContactSource == true) count++;
			if (_mod__Department == true) count++;
			if (_mod__Generation == true) count++;
			if (_mod__ImAddress1 == true) count++;
			if (_mod__ImAddress2 == true) count++;
			if (_mod__ImAddress3 == true) count++;
			if (_mod__JobTitle == true) count++;
			if (_mod__Manager == true) count++;
			if (_mod__Mileage == true) count++;
			if (_mod__OfficeLocation == true) count++;
			if (_mod__PostalAddressIndex == true) count++;
			if (_mod__Profession == true) count++;
			if (_mod__SpouseName == true) count++;
			if (_mod__Surname == true) count++;
			if (_mod__WeddingAnniversary == true) count++;
			if (_mod__HasPicture == true) count++;
			if (_mod__PhoneticFullName == true) count++;
			if (_mod__PhoneticFirstName == true) count++;
			if (_mod__PhoneticLastName == true) count++;
			if (_mod__Alias == true) count++;
			if (_mod__Notes == true) count++;
			if (_mod__Photo == true) count++;
			if (_mod__UserSMIMECertificate == true) count++;
			if (_mod__MSExchangeCertificate == true) count++;
			if (_mod__DirectoryId == true) count++;
			if (_mod__ManagerMailbox == true) count++;
			if (_mod__DirectReports == true) count++;
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
				if (_cur__ParentFolderId != null) track_array.AppendDataValue(3, _cur__ParentFolderId);
				if (_cur__ItemClass != null) track_array.AppendDataValue(5, _cur__ItemClass);
				if (_cur__Subject != null) track_array.AppendDataValue(6, _cur__Subject);
				if (_cur__Body != null) track_array.AppendDataValue(8, _cur__Body);
				if (_cur__Categories != null) track_array.AppendDataValue(11, _cur__Categories);
				if (_cur__Importance != null) track_array.AppendDataValue(12, _cur__Importance);
				if (_cur__ReminderDueBy != null) track_array.AppendDataValue(22, _cur__ReminderDueBy);
				if (_cur__ReminderIsSet != null) track_array.AppendDataValue(23, _cur__ReminderIsSet);
				if (_cur__ReminderMinutesBeforeStart != null) track_array.AppendDataValue(24, _cur__ReminderMinutesBeforeStart);
				if (_cur__Culture != null) track_array.AppendDataValue(28, _cur__Culture);
				if (_cur__IsAssociated != null) track_array.AppendDataValue(38, _cur__IsAssociated);
				if (_cur__FileAs != null) track_array.AppendDataValue(44, _cur__FileAs);
				if (_cur__FileAsMapping != null) track_array.AppendDataValue(45, _cur__FileAsMapping);
				if (_cur__DisplayName != null) track_array.AppendDataValue(46, _cur__DisplayName);
				if (_cur__GivenName != null) track_array.AppendDataValue(47, _cur__GivenName);
				if (_cur__Initials != null) track_array.AppendDataValue(48, _cur__Initials);
				if (_cur__MiddleName != null) track_array.AppendDataValue(49, _cur__MiddleName);
				if (_cur__Nickname != null) track_array.AppendDataValue(50, _cur__Nickname);
				if (_cur__CompanyName != null) track_array.AppendDataValue(61, _cur__CompanyName);
				if (_cur__EmailAddress1 != null) track_array.AppendDataValue(62, _cur__EmailAddress1);
				if (_cur__EmailAddress2 != null) track_array.AppendDataValue(63, _cur__EmailAddress2);
				if (_cur__EmailAddress3 != null) track_array.AppendDataValue(64, _cur__EmailAddress3);
				if (_cur__BusinessAddress_Street != null) track_array.AppendDataValue(65, _cur__BusinessAddress_Street);
				if (_cur__BusinessAddress_City != null) track_array.AppendDataValue(66, _cur__BusinessAddress_City);
				if (_cur__BusinessAddress_State != null) track_array.AppendDataValue(67, _cur__BusinessAddress_State);
				if (_cur__BusinessAddress_Country != null) track_array.AppendDataValue(68, _cur__BusinessAddress_Country);
				if (_cur__BusinessAddress_PostalCode != null) track_array.AppendDataValue(69, _cur__BusinessAddress_PostalCode);
				if (_cur__HomeAddress_Street != null) track_array.AppendDataValue(70, _cur__HomeAddress_Street);
				if (_cur__HomeAddress_City != null) track_array.AppendDataValue(71, _cur__HomeAddress_City);
				if (_cur__HomeAddress_State != null) track_array.AppendDataValue(72, _cur__HomeAddress_State);
				if (_cur__HomeAddress_Country != null) track_array.AppendDataValue(73, _cur__HomeAddress_Country);
				if (_cur__HomeAddress_PostalCode != null) track_array.AppendDataValue(74, _cur__HomeAddress_PostalCode);
				if (_cur__OtherAddress_Street != null) track_array.AppendDataValue(75, _cur__OtherAddress_Street);
				if (_cur__OtherAddress_City != null) track_array.AppendDataValue(76, _cur__OtherAddress_City);
				if (_cur__OtherAddress_State != null) track_array.AppendDataValue(77, _cur__OtherAddress_State);
				if (_cur__OtherAddress_Country != null) track_array.AppendDataValue(78, _cur__OtherAddress_Country);
				if (_cur__OtherAddress_PostalCode != null) track_array.AppendDataValue(79, _cur__OtherAddress_PostalCode);
				if (_cur__AssistantPhone != null) track_array.AppendDataValue(80, _cur__AssistantPhone);
				if (_cur__BusinessFax != null) track_array.AppendDataValue(81, _cur__BusinessFax);
				if (_cur__BusinessPhone != null) track_array.AppendDataValue(82, _cur__BusinessPhone);
				if (_cur__BusinessPhone2 != null) track_array.AppendDataValue(83, _cur__BusinessPhone2);
				if (_cur__Callback != null) track_array.AppendDataValue(84, _cur__Callback);
				if (_cur__CarPhone != null) track_array.AppendDataValue(85, _cur__CarPhone);
				if (_cur__CompanyMainPhone != null) track_array.AppendDataValue(86, _cur__CompanyMainPhone);
				if (_cur__HomeFax != null) track_array.AppendDataValue(87, _cur__HomeFax);
				if (_cur__HomePhone != null) track_array.AppendDataValue(88, _cur__HomePhone);
				if (_cur__HomePhone2 != null) track_array.AppendDataValue(89, _cur__HomePhone2);
				if (_cur__Isdn != null) track_array.AppendDataValue(90, _cur__Isdn);
				if (_cur__MobilePhone != null) track_array.AppendDataValue(91, _cur__MobilePhone);
				if (_cur__OtherFax != null) track_array.AppendDataValue(92, _cur__OtherFax);
				if (_cur__OtherTelephone != null) track_array.AppendDataValue(93, _cur__OtherTelephone);
				if (_cur__Pager != null) track_array.AppendDataValue(94, _cur__Pager);
				if (_cur__PrimaryPhone != null) track_array.AppendDataValue(95, _cur__PrimaryPhone);
				if (_cur__RadioPhone != null) track_array.AppendDataValue(96, _cur__RadioPhone);
				if (_cur__Telex != null) track_array.AppendDataValue(97, _cur__Telex);
				if (_cur__TtyTddPhone != null) track_array.AppendDataValue(98, _cur__TtyTddPhone);
				if (_cur__AssistantName != null) track_array.AppendDataValue(99, _cur__AssistantName);
				if (_cur__Birthday != null) track_array.AppendDataValue(100, _cur__Birthday);
				if (_cur__BusinessHomePage != null) track_array.AppendDataValue(101, _cur__BusinessHomePage);
				if (_cur__Children_1 != null) track_array.AppendDataValue(102, _cur__Children_1);
				if (_cur__Children_2 != null) track_array.AppendDataValue(103, _cur__Children_2);
				if (_cur__Children_3 != null) track_array.AppendDataValue(104, _cur__Children_3);
				if (_cur__Companies_1 != null) track_array.AppendDataValue(105, _cur__Companies_1);
				if (_cur__Companies_2 != null) track_array.AppendDataValue(106, _cur__Companies_2);
				if (_cur__Companies_3 != null) track_array.AppendDataValue(107, _cur__Companies_3);
				if (_cur__ContactSource != null) track_array.AppendDataValue(108, _cur__ContactSource);
				if (_cur__Department != null) track_array.AppendDataValue(109, _cur__Department);
				if (_cur__Generation != null) track_array.AppendDataValue(110, _cur__Generation);
				if (_cur__ImAddress1 != null) track_array.AppendDataValue(111, _cur__ImAddress1);
				if (_cur__ImAddress2 != null) track_array.AppendDataValue(112, _cur__ImAddress2);
				if (_cur__ImAddress3 != null) track_array.AppendDataValue(113, _cur__ImAddress3);
				if (_cur__JobTitle != null) track_array.AppendDataValue(114, _cur__JobTitle);
				if (_cur__Manager != null) track_array.AppendDataValue(115, _cur__Manager);
				if (_cur__Mileage != null) track_array.AppendDataValue(116, _cur__Mileage);
				if (_cur__OfficeLocation != null) track_array.AppendDataValue(117, _cur__OfficeLocation);
				if (_cur__PostalAddressIndex != null) track_array.AppendDataValue(118, _cur__PostalAddressIndex);
				if (_cur__Profession != null) track_array.AppendDataValue(119, _cur__Profession);
				if (_cur__SpouseName != null) track_array.AppendDataValue(120, _cur__SpouseName);
				if (_cur__Surname != null) track_array.AppendDataValue(121, _cur__Surname);
				if (_cur__WeddingAnniversary != null) track_array.AppendDataValue(122, _cur__WeddingAnniversary);
				if (_cur__HasPicture != null) track_array.AppendDataValue(123, _cur__HasPicture);
				if (_cur__PhoneticFullName != null) track_array.AppendDataValue(124, _cur__PhoneticFullName);
				if (_cur__PhoneticFirstName != null) track_array.AppendDataValue(125, _cur__PhoneticFirstName);
				if (_cur__PhoneticLastName != null) track_array.AppendDataValue(126, _cur__PhoneticLastName);
				if (_cur__Alias != null) track_array.AppendDataValue(127, _cur__Alias);
				if (_cur__Notes != null) track_array.AppendDataValue(128, _cur__Notes);
				if (_cur__Photo != null) track_array.AppendDataValue(129, _cur__Photo);
				if (_cur__UserSMIMECertificate != null) track_array.AppendDataValue(130, _cur__UserSMIMECertificate);
				if (_cur__MSExchangeCertificate != null) track_array.AppendDataValue(131, _cur__MSExchangeCertificate);
				if (_cur__DirectoryId != null) track_array.AppendDataValue(132, _cur__DirectoryId);
				if (_cur__ManagerMailbox != null) track_array.AppendDataValue(133, _cur__ManagerMailbox);
				if (_cur__DirectReports != null) track_array.AppendDataValue(134, _cur__DirectReports);
			}
			else if (_recordstatus == DataRecordStatus.Existing)
			{
				if (_mod__ParentFolderId) track_array.AppendDataValue(3, _cur__ParentFolderId);
				if (_mod__ItemClass) track_array.AppendDataValue(5, _cur__ItemClass);
				if (_mod__Subject) track_array.AppendDataValue(6, _cur__Subject);
				if (_mod__Body) track_array.AppendDataValue(8, _cur__Body);
				if (_mod__Categories) track_array.AppendDataValue(11, _cur__Categories);
				if (_mod__Importance) track_array.AppendDataValue(12, _cur__Importance);
				if (_mod__ReminderDueBy) track_array.AppendDataValue(22, _cur__ReminderDueBy);
				if (_mod__ReminderIsSet) track_array.AppendDataValue(23, _cur__ReminderIsSet);
				if (_mod__ReminderMinutesBeforeStart) track_array.AppendDataValue(24, _cur__ReminderMinutesBeforeStart);
				if (_mod__Culture) track_array.AppendDataValue(28, _cur__Culture);
				if (_mod__IsAssociated) track_array.AppendDataValue(38, _cur__IsAssociated);
				if (_mod__FileAs) track_array.AppendDataValue(44, _cur__FileAs);
				if (_mod__FileAsMapping) track_array.AppendDataValue(45, _cur__FileAsMapping);
				if (_mod__DisplayName) track_array.AppendDataValue(46, _cur__DisplayName);
				if (_mod__GivenName) track_array.AppendDataValue(47, _cur__GivenName);
				if (_mod__Initials) track_array.AppendDataValue(48, _cur__Initials);
				if (_mod__MiddleName) track_array.AppendDataValue(49, _cur__MiddleName);
				if (_mod__Nickname) track_array.AppendDataValue(50, _cur__Nickname);
				if (_mod__CompanyName) track_array.AppendDataValue(61, _cur__CompanyName);
				if (_mod__EmailAddress1) track_array.AppendDataValue(62, _cur__EmailAddress1);
				if (_mod__EmailAddress2) track_array.AppendDataValue(63, _cur__EmailAddress2);
				if (_mod__EmailAddress3) track_array.AppendDataValue(64, _cur__EmailAddress3);
				if (_mod__BusinessAddress_Street) track_array.AppendDataValue(65, _cur__BusinessAddress_Street);
				if (_mod__BusinessAddress_City) track_array.AppendDataValue(66, _cur__BusinessAddress_City);
				if (_mod__BusinessAddress_State) track_array.AppendDataValue(67, _cur__BusinessAddress_State);
				if (_mod__BusinessAddress_Country) track_array.AppendDataValue(68, _cur__BusinessAddress_Country);
				if (_mod__BusinessAddress_PostalCode) track_array.AppendDataValue(69, _cur__BusinessAddress_PostalCode);
				if (_mod__HomeAddress_Street) track_array.AppendDataValue(70, _cur__HomeAddress_Street);
				if (_mod__HomeAddress_City) track_array.AppendDataValue(71, _cur__HomeAddress_City);
				if (_mod__HomeAddress_State) track_array.AppendDataValue(72, _cur__HomeAddress_State);
				if (_mod__HomeAddress_Country) track_array.AppendDataValue(73, _cur__HomeAddress_Country);
				if (_mod__HomeAddress_PostalCode) track_array.AppendDataValue(74, _cur__HomeAddress_PostalCode);
				if (_mod__OtherAddress_Street) track_array.AppendDataValue(75, _cur__OtherAddress_Street);
				if (_mod__OtherAddress_City) track_array.AppendDataValue(76, _cur__OtherAddress_City);
				if (_mod__OtherAddress_State) track_array.AppendDataValue(77, _cur__OtherAddress_State);
				if (_mod__OtherAddress_Country) track_array.AppendDataValue(78, _cur__OtherAddress_Country);
				if (_mod__OtherAddress_PostalCode) track_array.AppendDataValue(79, _cur__OtherAddress_PostalCode);
				if (_mod__AssistantPhone) track_array.AppendDataValue(80, _cur__AssistantPhone);
				if (_mod__BusinessFax) track_array.AppendDataValue(81, _cur__BusinessFax);
				if (_mod__BusinessPhone) track_array.AppendDataValue(82, _cur__BusinessPhone);
				if (_mod__BusinessPhone2) track_array.AppendDataValue(83, _cur__BusinessPhone2);
				if (_mod__Callback) track_array.AppendDataValue(84, _cur__Callback);
				if (_mod__CarPhone) track_array.AppendDataValue(85, _cur__CarPhone);
				if (_mod__CompanyMainPhone) track_array.AppendDataValue(86, _cur__CompanyMainPhone);
				if (_mod__HomeFax) track_array.AppendDataValue(87, _cur__HomeFax);
				if (_mod__HomePhone) track_array.AppendDataValue(88, _cur__HomePhone);
				if (_mod__HomePhone2) track_array.AppendDataValue(89, _cur__HomePhone2);
				if (_mod__Isdn) track_array.AppendDataValue(90, _cur__Isdn);
				if (_mod__MobilePhone) track_array.AppendDataValue(91, _cur__MobilePhone);
				if (_mod__OtherFax) track_array.AppendDataValue(92, _cur__OtherFax);
				if (_mod__OtherTelephone) track_array.AppendDataValue(93, _cur__OtherTelephone);
				if (_mod__Pager) track_array.AppendDataValue(94, _cur__Pager);
				if (_mod__PrimaryPhone) track_array.AppendDataValue(95, _cur__PrimaryPhone);
				if (_mod__RadioPhone) track_array.AppendDataValue(96, _cur__RadioPhone);
				if (_mod__Telex) track_array.AppendDataValue(97, _cur__Telex);
				if (_mod__TtyTddPhone) track_array.AppendDataValue(98, _cur__TtyTddPhone);
				if (_mod__AssistantName) track_array.AppendDataValue(99, _cur__AssistantName);
				if (_mod__Birthday) track_array.AppendDataValue(100, _cur__Birthday);
				if (_mod__BusinessHomePage) track_array.AppendDataValue(101, _cur__BusinessHomePage);
				if (_mod__Children_1) track_array.AppendDataValue(102, _cur__Children_1);
				if (_mod__Children_2) track_array.AppendDataValue(103, _cur__Children_2);
				if (_mod__Children_3) track_array.AppendDataValue(104, _cur__Children_3);
				if (_mod__Companies_1) track_array.AppendDataValue(105, _cur__Companies_1);
				if (_mod__Companies_2) track_array.AppendDataValue(106, _cur__Companies_2);
				if (_mod__Companies_3) track_array.AppendDataValue(107, _cur__Companies_3);
				if (_mod__ContactSource) track_array.AppendDataValue(108, _cur__ContactSource);
				if (_mod__Department) track_array.AppendDataValue(109, _cur__Department);
				if (_mod__Generation) track_array.AppendDataValue(110, _cur__Generation);
				if (_mod__ImAddress1) track_array.AppendDataValue(111, _cur__ImAddress1);
				if (_mod__ImAddress2) track_array.AppendDataValue(112, _cur__ImAddress2);
				if (_mod__ImAddress3) track_array.AppendDataValue(113, _cur__ImAddress3);
				if (_mod__JobTitle) track_array.AppendDataValue(114, _cur__JobTitle);
				if (_mod__Manager) track_array.AppendDataValue(115, _cur__Manager);
				if (_mod__Mileage) track_array.AppendDataValue(116, _cur__Mileage);
				if (_mod__OfficeLocation) track_array.AppendDataValue(117, _cur__OfficeLocation);
				if (_mod__PostalAddressIndex) track_array.AppendDataValue(118, _cur__PostalAddressIndex);
				if (_mod__Profession) track_array.AppendDataValue(119, _cur__Profession);
				if (_mod__SpouseName) track_array.AppendDataValue(120, _cur__SpouseName);
				if (_mod__Surname) track_array.AppendDataValue(121, _cur__Surname);
				if (_mod__WeddingAnniversary) track_array.AppendDataValue(122, _cur__WeddingAnniversary);
				if (_mod__HasPicture) track_array.AppendDataValue(123, _cur__HasPicture);
				if (_mod__PhoneticFullName) track_array.AppendDataValue(124, _cur__PhoneticFullName);
				if (_mod__PhoneticFirstName) track_array.AppendDataValue(125, _cur__PhoneticFirstName);
				if (_mod__PhoneticLastName) track_array.AppendDataValue(126, _cur__PhoneticLastName);
				if (_mod__Alias) track_array.AppendDataValue(127, _cur__Alias);
				if (_mod__Notes) track_array.AppendDataValue(128, _cur__Notes);
				if (_mod__Photo) track_array.AppendDataValue(129, _cur__Photo);
				if (_mod__UserSMIMECertificate) track_array.AppendDataValue(130, _cur__UserSMIMECertificate);
				if (_mod__MSExchangeCertificate) track_array.AppendDataValue(131, _cur__MSExchangeCertificate);
				if (_mod__DirectoryId) track_array.AppendDataValue(132, _cur__DirectoryId);
				if (_mod__ManagerMailbox) track_array.AppendDataValue(133, _cur__ManagerMailbox);
				if (_mod__DirectReports) track_array.AppendDataValue(134, _cur__DirectReports);
				if (track_array.HasData == false) return;
			}

			if (_recordstatus == DataRecordStatus.Existing || _recordstatus == DataRecordStatus.ExistingDelete)
			{
				track_array.AppendPrikeyValue(0, (_mod__ItemId && _started_with_dbvalues) ? _ori__ItemId : _cur__ItemId);
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
				if (_mod__ItemId) _ori__ItemId = default(string);
				if (_mod__MimeContent) _ori__MimeContent = default(string);
				if (_mod__ItemChangeKey) _ori__ItemChangeKey = default(string);
				if (_mod__ParentFolderId) _ori__ParentFolderId = default(string);
				if (_mod__ParentFolderChangeKey) _ori__ParentFolderChangeKey = default(string);
				if (_mod__ItemClass) _ori__ItemClass = default(string);
				if (_mod__Subject) _ori__Subject = default(string);
				if (_mod__Sensitivity) _ori__Sensitivity = default(string);
				if (_mod__Body) _ori__Body = default(string);
				if (_mod__DateTimeReceived) _ori__DateTimeReceived = default(DateTime?);
				if (_mod__Size) _ori__Size = default(int?);
				if (_mod__Categories) _ori__Categories = default(string);
				if (_mod__Importance) _ori__Importance = default(string);
				if (_mod__IsSubmitted) _ori__IsSubmitted = default(bool?);
				if (_mod__InReplyTo) _ori__InReplyTo = default(string);
				if (_mod__IsDraft) _ori__IsDraft = default(bool?);
				if (_mod__IsFromMe) _ori__IsFromMe = default(bool?);
				if (_mod__IsResend) _ori__IsResend = default(bool?);
				if (_mod__IsUnmodified) _ori__IsUnmodified = default(bool?);
				if (_mod__InternetMessageHeaders) _ori__InternetMessageHeaders = default(string);
				if (_mod__DateTimeSent) _ori__DateTimeSent = default(DateTime?);
				if (_mod__DateTimeCreated) _ori__DateTimeCreated = default(DateTime?);
				if (_mod__ReminderDueBy) _ori__ReminderDueBy = default(DateTime?);
				if (_mod__ReminderIsSet) _ori__ReminderIsSet = default(bool?);
				if (_mod__ReminderMinutesBeforeStart) _ori__ReminderMinutesBeforeStart = default(int?);
				if (_mod__DisplayCc) _ori__DisplayCc = default(string);
				if (_mod__DisplayTo) _ori__DisplayTo = default(string);
				if (_mod__HasAttachments) _ori__HasAttachments = default(bool?);
				if (_mod__Culture) _ori__Culture = default(string);
				if (_mod__EffectiveRights_CreateAssociated) _ori__EffectiveRights_CreateAssociated = default(bool?);
				if (_mod__EffectiveRights_CreateContents) _ori__EffectiveRights_CreateContents = default(bool?);
				if (_mod__EffectiveRights_CreateHierarchy) _ori__EffectiveRights_CreateHierarchy = default(bool?);
				if (_mod__EffectiveRights_Delete) _ori__EffectiveRights_Delete = default(bool?);
				if (_mod__EffectiveRights_Modify) _ori__EffectiveRights_Modify = default(bool?);
				if (_mod__EffectiveRights_Read) _ori__EffectiveRights_Read = default(bool?);
				if (_mod__EffectiveRights_ViewPrivateItems) _ori__EffectiveRights_ViewPrivateItems = default(bool?);
				if (_mod__LastModifiedName) _ori__LastModifiedName = default(string);
				if (_mod__LastModifiedTime) _ori__LastModifiedTime = default(DateTime?);
				if (_mod__IsAssociated) _ori__IsAssociated = default(bool?);
				if (_mod__WebClientReadFormQueryString) _ori__WebClientReadFormQueryString = default(string);
				if (_mod__WebClientEditFormQueryString) _ori__WebClientEditFormQueryString = default(string);
				if (_mod__ConversationId) _ori__ConversationId = default(string);
				if (_mod__UniqueBody) _ori__UniqueBody = default(string);
				if (_mod__UniqueBodyType) _ori__UniqueBodyType = default(string);
				if (_mod__FileAs) _ori__FileAs = default(string);
				if (_mod__FileAsMapping) _ori__FileAsMapping = default(string);
				if (_mod__DisplayName) _ori__DisplayName = default(string);
				if (_mod__GivenName) _ori__GivenName = default(string);
				if (_mod__Initials) _ori__Initials = default(string);
				if (_mod__MiddleName) _ori__MiddleName = default(string);
				if (_mod__Nickname) _ori__Nickname = default(string);
				if (_mod__CompleteName_Title) _ori__CompleteName_Title = default(string);
				if (_mod__CompleteName_FirstName) _ori__CompleteName_FirstName = default(string);
				if (_mod__CompleteName_MiddleName) _ori__CompleteName_MiddleName = default(string);
				if (_mod__CompleteName_LastName) _ori__CompleteName_LastName = default(string);
				if (_mod__CompleteName_Suffix) _ori__CompleteName_Suffix = default(string);
				if (_mod__CompleteName_Initials) _ori__CompleteName_Initials = default(string);
				if (_mod__CompleteName_FullName) _ori__CompleteName_FullName = default(string);
				if (_mod__CompleteName_Nickname) _ori__CompleteName_Nickname = default(string);
				if (_mod__CompleteName_YomiFirstName) _ori__CompleteName_YomiFirstName = default(string);
				if (_mod__CompleteName_YomiLastName) _ori__CompleteName_YomiLastName = default(string);
				if (_mod__CompanyName) _ori__CompanyName = default(string);
				if (_mod__EmailAddress1) _ori__EmailAddress1 = default(string);
				if (_mod__EmailAddress2) _ori__EmailAddress2 = default(string);
				if (_mod__EmailAddress3) _ori__EmailAddress3 = default(string);
				if (_mod__BusinessAddress_Street) _ori__BusinessAddress_Street = default(string);
				if (_mod__BusinessAddress_City) _ori__BusinessAddress_City = default(string);
				if (_mod__BusinessAddress_State) _ori__BusinessAddress_State = default(string);
				if (_mod__BusinessAddress_Country) _ori__BusinessAddress_Country = default(string);
				if (_mod__BusinessAddress_PostalCode) _ori__BusinessAddress_PostalCode = default(string);
				if (_mod__HomeAddress_Street) _ori__HomeAddress_Street = default(string);
				if (_mod__HomeAddress_City) _ori__HomeAddress_City = default(string);
				if (_mod__HomeAddress_State) _ori__HomeAddress_State = default(string);
				if (_mod__HomeAddress_Country) _ori__HomeAddress_Country = default(string);
				if (_mod__HomeAddress_PostalCode) _ori__HomeAddress_PostalCode = default(string);
				if (_mod__OtherAddress_Street) _ori__OtherAddress_Street = default(string);
				if (_mod__OtherAddress_City) _ori__OtherAddress_City = default(string);
				if (_mod__OtherAddress_State) _ori__OtherAddress_State = default(string);
				if (_mod__OtherAddress_Country) _ori__OtherAddress_Country = default(string);
				if (_mod__OtherAddress_PostalCode) _ori__OtherAddress_PostalCode = default(string);
				if (_mod__AssistantPhone) _ori__AssistantPhone = default(string);
				if (_mod__BusinessFax) _ori__BusinessFax = default(string);
				if (_mod__BusinessPhone) _ori__BusinessPhone = default(string);
				if (_mod__BusinessPhone2) _ori__BusinessPhone2 = default(string);
				if (_mod__Callback) _ori__Callback = default(string);
				if (_mod__CarPhone) _ori__CarPhone = default(string);
				if (_mod__CompanyMainPhone) _ori__CompanyMainPhone = default(string);
				if (_mod__HomeFax) _ori__HomeFax = default(string);
				if (_mod__HomePhone) _ori__HomePhone = default(string);
				if (_mod__HomePhone2) _ori__HomePhone2 = default(string);
				if (_mod__Isdn) _ori__Isdn = default(string);
				if (_mod__MobilePhone) _ori__MobilePhone = default(string);
				if (_mod__OtherFax) _ori__OtherFax = default(string);
				if (_mod__OtherTelephone) _ori__OtherTelephone = default(string);
				if (_mod__Pager) _ori__Pager = default(string);
				if (_mod__PrimaryPhone) _ori__PrimaryPhone = default(string);
				if (_mod__RadioPhone) _ori__RadioPhone = default(string);
				if (_mod__Telex) _ori__Telex = default(string);
				if (_mod__TtyTddPhone) _ori__TtyTddPhone = default(string);
				if (_mod__AssistantName) _ori__AssistantName = default(string);
				if (_mod__Birthday) _ori__Birthday = default(DateTime?);
				if (_mod__BusinessHomePage) _ori__BusinessHomePage = default(string);
				if (_mod__Children_1) _ori__Children_1 = default(string);
				if (_mod__Children_2) _ori__Children_2 = default(string);
				if (_mod__Children_3) _ori__Children_3 = default(string);
				if (_mod__Companies_1) _ori__Companies_1 = default(string);
				if (_mod__Companies_2) _ori__Companies_2 = default(string);
				if (_mod__Companies_3) _ori__Companies_3 = default(string);
				if (_mod__ContactSource) _ori__ContactSource = default(string);
				if (_mod__Department) _ori__Department = default(string);
				if (_mod__Generation) _ori__Generation = default(string);
				if (_mod__ImAddress1) _ori__ImAddress1 = default(string);
				if (_mod__ImAddress2) _ori__ImAddress2 = default(string);
				if (_mod__ImAddress3) _ori__ImAddress3 = default(string);
				if (_mod__JobTitle) _ori__JobTitle = default(string);
				if (_mod__Manager) _ori__Manager = default(string);
				if (_mod__Mileage) _ori__Mileage = default(string);
				if (_mod__OfficeLocation) _ori__OfficeLocation = default(string);
				if (_mod__PostalAddressIndex) _ori__PostalAddressIndex = default(string);
				if (_mod__Profession) _ori__Profession = default(string);
				if (_mod__SpouseName) _ori__SpouseName = default(string);
				if (_mod__Surname) _ori__Surname = default(string);
				if (_mod__WeddingAnniversary) _ori__WeddingAnniversary = default(DateTime?);
				if (_mod__HasPicture) _ori__HasPicture = default(bool?);
				if (_mod__PhoneticFullName) _ori__PhoneticFullName = default(string);
				if (_mod__PhoneticFirstName) _ori__PhoneticFirstName = default(string);
				if (_mod__PhoneticLastName) _ori__PhoneticLastName = default(string);
				if (_mod__Alias) _ori__Alias = default(string);
				if (_mod__Notes) _ori__Notes = default(string);
				if (_mod__Photo) _ori__Photo = default(string);
				if (_mod__UserSMIMECertificate) _ori__UserSMIMECertificate = default(string);
				if (_mod__MSExchangeCertificate) _ori__MSExchangeCertificate = default(string);
				if (_mod__DirectoryId) _ori__DirectoryId = default(string);
				if (_mod__ManagerMailbox) _ori__ManagerMailbox = default(string);
				if (_mod__DirectReports) _ori__DirectReports = default(string);
			}
			_mod__ItemId = false;
			_mod__MimeContent = false;
			_mod__ItemChangeKey = false;
			_mod__ParentFolderId = false;
			_mod__ParentFolderChangeKey = false;
			_mod__ItemClass = false;
			_mod__Subject = false;
			_mod__Sensitivity = false;
			_mod__Body = false;
			_mod__DateTimeReceived = false;
			_mod__Size = false;
			_mod__Categories = false;
			_mod__Importance = false;
			_mod__IsSubmitted = false;
			_mod__InReplyTo = false;
			_mod__IsDraft = false;
			_mod__IsFromMe = false;
			_mod__IsResend = false;
			_mod__IsUnmodified = false;
			_mod__InternetMessageHeaders = false;
			_mod__DateTimeSent = false;
			_mod__DateTimeCreated = false;
			_mod__ReminderDueBy = false;
			_mod__ReminderIsSet = false;
			_mod__ReminderMinutesBeforeStart = false;
			_mod__DisplayCc = false;
			_mod__DisplayTo = false;
			_mod__HasAttachments = false;
			_mod__Culture = false;
			_mod__EffectiveRights_CreateAssociated = false;
			_mod__EffectiveRights_CreateContents = false;
			_mod__EffectiveRights_CreateHierarchy = false;
			_mod__EffectiveRights_Delete = false;
			_mod__EffectiveRights_Modify = false;
			_mod__EffectiveRights_Read = false;
			_mod__EffectiveRights_ViewPrivateItems = false;
			_mod__LastModifiedName = false;
			_mod__LastModifiedTime = false;
			_mod__IsAssociated = false;
			_mod__WebClientReadFormQueryString = false;
			_mod__WebClientEditFormQueryString = false;
			_mod__ConversationId = false;
			_mod__UniqueBody = false;
			_mod__UniqueBodyType = false;
			_mod__FileAs = false;
			_mod__FileAsMapping = false;
			_mod__DisplayName = false;
			_mod__GivenName = false;
			_mod__Initials = false;
			_mod__MiddleName = false;
			_mod__Nickname = false;
			_mod__CompleteName_Title = false;
			_mod__CompleteName_FirstName = false;
			_mod__CompleteName_MiddleName = false;
			_mod__CompleteName_LastName = false;
			_mod__CompleteName_Suffix = false;
			_mod__CompleteName_Initials = false;
			_mod__CompleteName_FullName = false;
			_mod__CompleteName_Nickname = false;
			_mod__CompleteName_YomiFirstName = false;
			_mod__CompleteName_YomiLastName = false;
			_mod__CompanyName = false;
			_mod__EmailAddress1 = false;
			_mod__EmailAddress2 = false;
			_mod__EmailAddress3 = false;
			_mod__BusinessAddress_Street = false;
			_mod__BusinessAddress_City = false;
			_mod__BusinessAddress_State = false;
			_mod__BusinessAddress_Country = false;
			_mod__BusinessAddress_PostalCode = false;
			_mod__HomeAddress_Street = false;
			_mod__HomeAddress_City = false;
			_mod__HomeAddress_State = false;
			_mod__HomeAddress_Country = false;
			_mod__HomeAddress_PostalCode = false;
			_mod__OtherAddress_Street = false;
			_mod__OtherAddress_City = false;
			_mod__OtherAddress_State = false;
			_mod__OtherAddress_Country = false;
			_mod__OtherAddress_PostalCode = false;
			_mod__AssistantPhone = false;
			_mod__BusinessFax = false;
			_mod__BusinessPhone = false;
			_mod__BusinessPhone2 = false;
			_mod__Callback = false;
			_mod__CarPhone = false;
			_mod__CompanyMainPhone = false;
			_mod__HomeFax = false;
			_mod__HomePhone = false;
			_mod__HomePhone2 = false;
			_mod__Isdn = false;
			_mod__MobilePhone = false;
			_mod__OtherFax = false;
			_mod__OtherTelephone = false;
			_mod__Pager = false;
			_mod__PrimaryPhone = false;
			_mod__RadioPhone = false;
			_mod__Telex = false;
			_mod__TtyTddPhone = false;
			_mod__AssistantName = false;
			_mod__Birthday = false;
			_mod__BusinessHomePage = false;
			_mod__Children_1 = false;
			_mod__Children_2 = false;
			_mod__Children_3 = false;
			_mod__Companies_1 = false;
			_mod__Companies_2 = false;
			_mod__Companies_3 = false;
			_mod__ContactSource = false;
			_mod__Department = false;
			_mod__Generation = false;
			_mod__ImAddress1 = false;
			_mod__ImAddress2 = false;
			_mod__ImAddress3 = false;
			_mod__JobTitle = false;
			_mod__Manager = false;
			_mod__Mileage = false;
			_mod__OfficeLocation = false;
			_mod__PostalAddressIndex = false;
			_mod__Profession = false;
			_mod__SpouseName = false;
			_mod__Surname = false;
			_mod__WeddingAnniversary = false;
			_mod__HasPicture = false;
			_mod__PhoneticFullName = false;
			_mod__PhoneticFirstName = false;
			_mod__PhoneticLastName = false;
			_mod__Alias = false;
			_mod__Notes = false;
			_mod__Photo = false;
			_mod__UserSMIMECertificate = false;
			_mod__MSExchangeCertificate = false;
			_mod__DirectoryId = false;
			_mod__ManagerMailbox = false;
			_mod__DirectReports = false;
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
namespace WpfApp1.VenturaAutoCreate
{
	public partial class PriKey_Contacts_Record
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
