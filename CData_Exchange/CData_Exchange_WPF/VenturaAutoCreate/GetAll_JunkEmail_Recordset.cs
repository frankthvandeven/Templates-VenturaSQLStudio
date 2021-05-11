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
	/// The updateable table is [Exchange].[JunkEmail]. Updateable table column information:
	/// • 81 out of 81 table columns are present in the resultset.
	/// • All primary key columns are present in the resultset: ItemId.
	/// • Non-primary key columns present in the resultset: MimeContent, ItemChangeKey, ParentFolderId, ParentFolderChangeKey,
	///   ItemClass, Subject, Sensitivity, Body, AttachmentIds, AttachmentNames, DateTimeReceived, Size, Categories, Importance,
	///   InReplyTo, IsSubmitted, IsDraft, IsFromMe, IsResend, IsUnmodified, InternetMessageHeaders, DateTimeSent, DateTimeCreated,
	///   ReminderDueBy, ReminderIsSet, ReminderMinutesBeforeStart, DisplayCc, DisplayTo, HasAttachments, Culture, SenderName,
	///   SenderEmailAddress, SenderRoutingType, ToRecipients_Name, ToRecipients_EmailAddress, ToRecipients_ItemId,
	///   CcRecipients_Name, CcRecipients_EmailAddress, CcRecipients_ItemId, BccRecipients_Name, BccRecipients_EmailAddress,
	///   BccRecipients_ItemId, IsReadReceiptRequested, IsDeliveryReceiptRequested, ConversationIndex, ConversationTopic, FromName,
	///   FromEmailAddress, FromRoutingType, InternetMessageId, IsRead, IsResponseRequested, References,
	///   EffectiveRights_CreateAssociated, EffectiveRights_CreateContents, EffectiveRights_CreateHierarchy,
	///   EffectiveRights_Delete, EffectiveRights_Modify, EffectiveRights_Read, EffectiveRights_ViewPrivateItems, ReceivedByName,
	///   ReceivedByEmailAddress, ReceivedByRoutingType, ReceivedRepresentingName, ReceivedRepresentingEmailAddress,
	///   ReceivedRepresentingRoutingType, LastModifiedName, LastModifiedTime, IsAssociated, WebClientReadFormQueryString,
	///   WebClientEditFormQueryString, ConversationId, ConversationChangeKey, UniqueBody, UniqueBodyType,
	///   ReminderMessageData_Text, ReminderMessageData_Location, ReminderMessageData_StartTime, ReminderMessageData_EndTime and
	///   ReminderMessageData_AssociatedCalendarId.
	/// Recordset item automatically created by Ventura SQL Studio.
	/// </summary>
	public partial class GetAll_JunkEmail_Recordset : ResultsetObservable<GetAll_JunkEmail_Recordset, GetAll_JunkEmail_Record>, IRecordsetBase
	{
		private IResultsetBase[] _resultsets;
		private string _sqlscript;
		private int _rowlimit = 500;
		private const string CRLF = "\r\n";

		public GetAll_JunkEmail_Recordset()
		{
			_resultsets = new IResultsetBase[] { this };

			_sqlscript = @"SELECT [ItemId],[MimeContent],[ItemChangeKey],[ParentFolderId],[ParentFolderChangeKey],[ItemClass],[Subject],[Sensitivity],[Body],[AttachmentIds],[AttachmentNames]," + CRLF +
			             @"[DateTimeReceived],[Size],[Categories],[Importance],[InReplyTo],[IsSubmitted],[IsDraft],[IsFromMe],[IsResend],[IsUnmodified],[InternetMessageHeaders],[DateTimeSent]," + CRLF +
			             @"[DateTimeCreated],[ReminderDueBy],[ReminderIsSet],[ReminderMinutesBeforeStart],[DisplayCc],[DisplayTo],[HasAttachments],[Culture],[SenderName],[SenderEmailAddress]," + CRLF +
			             @"[SenderRoutingType],[ToRecipients_Name],[ToRecipients_EmailAddress],[ToRecipients_ItemId],[CcRecipients_Name],[CcRecipients_EmailAddress],[CcRecipients_ItemId]," + CRLF +
			             @"[BccRecipients_Name],[BccRecipients_EmailAddress],[BccRecipients_ItemId],[IsReadReceiptRequested],[IsDeliveryReceiptRequested],[ConversationIndex]," + CRLF +
			             @"[ConversationTopic],[FromName],[FromEmailAddress],[FromRoutingType],[InternetMessageId],[IsRead],[IsResponseRequested],[References],[EffectiveRights_CreateAssociated]," + CRLF +
			             @"[EffectiveRights_CreateContents],[EffectiveRights_CreateHierarchy],[EffectiveRights_Delete],[EffectiveRights_Modify],[EffectiveRights_Read],[EffectiveRights_ViewPrivateItems]," + CRLF +
			             @"[ReceivedByName],[ReceivedByEmailAddress],[ReceivedByRoutingType],[ReceivedRepresentingName],[ReceivedRepresentingEmailAddress],[ReceivedRepresentingRoutingType]," + CRLF +
			             @"[LastModifiedName],[LastModifiedTime],[IsAssociated],[WebClientReadFormQueryString],[WebClientEditFormQueryString],[ConversationId],[ConversationChangeKey]," + CRLF +
			             @"[UniqueBody],[UniqueBodyType],[ReminderMessageData_Text],[ReminderMessageData_Location],[ReminderMessageData_StartTime],[ReminderMessageData_EndTime]," + CRLF +
			             @"[ReminderMessageData_AssociatedCalendarId]" + CRLF +
			             @"FROM [Exchange].[JunkEmail]";

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
				BaseTableName = "JunkEmail",
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
				BaseTableName = "JunkEmail",
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
				BaseTableName = "JunkEmail",
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
				BaseTableName = "JunkEmail",
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
				BaseTableName = "JunkEmail",
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
				BaseTableName = "JunkEmail",
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
				BaseTableName = "JunkEmail",
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
				BaseTableName = "JunkEmail",
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
				BaseTableName = "JunkEmail",
				BaseColumnName = "Body"
			});

			schema_array.Add(new VenturaColumn("AttachmentIds", typeof(string), true)
			{
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "JunkEmail",
				BaseColumnName = "AttachmentIds"
			});

			schema_array.Add(new VenturaColumn("AttachmentNames", typeof(string), true)
			{
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "JunkEmail",
				BaseColumnName = "AttachmentNames"
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
				BaseTableName = "JunkEmail",
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
				BaseTableName = "JunkEmail",
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
				BaseTableName = "JunkEmail",
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
				BaseTableName = "JunkEmail",
				BaseColumnName = "Importance"
			});

			schema_array.Add(new VenturaColumn("InReplyTo", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "JunkEmail",
				BaseColumnName = "InReplyTo"
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
				BaseTableName = "JunkEmail",
				BaseColumnName = "IsSubmitted"
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
				BaseTableName = "JunkEmail",
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
				BaseTableName = "JunkEmail",
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
				BaseTableName = "JunkEmail",
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
				BaseTableName = "JunkEmail",
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
				BaseTableName = "JunkEmail",
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
				BaseTableName = "JunkEmail",
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
				BaseTableName = "JunkEmail",
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
				BaseTableName = "JunkEmail",
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
				BaseTableName = "JunkEmail",
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
				BaseTableName = "JunkEmail",
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
				BaseTableName = "JunkEmail",
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
				BaseTableName = "JunkEmail",
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
				BaseTableName = "JunkEmail",
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
				BaseTableName = "JunkEmail",
				BaseColumnName = "Culture"
			});

			schema_array.Add(new VenturaColumn("SenderName", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "JunkEmail",
				BaseColumnName = "SenderName"
			});

			schema_array.Add(new VenturaColumn("SenderEmailAddress", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "JunkEmail",
				BaseColumnName = "SenderEmailAddress"
			});

			schema_array.Add(new VenturaColumn("SenderRoutingType", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "JunkEmail",
				BaseColumnName = "SenderRoutingType"
			});

			schema_array.Add(new VenturaColumn("ToRecipients_Name", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "JunkEmail",
				BaseColumnName = "ToRecipients_Name"
			});

			schema_array.Add(new VenturaColumn("ToRecipients_EmailAddress", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "JunkEmail",
				BaseColumnName = "ToRecipients_EmailAddress"
			});

			schema_array.Add(new VenturaColumn("ToRecipients_ItemId", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "JunkEmail",
				BaseColumnName = "ToRecipients_ItemId"
			});

			schema_array.Add(new VenturaColumn("CcRecipients_Name", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "JunkEmail",
				BaseColumnName = "CcRecipients_Name"
			});

			schema_array.Add(new VenturaColumn("CcRecipients_EmailAddress", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "JunkEmail",
				BaseColumnName = "CcRecipients_EmailAddress"
			});

			schema_array.Add(new VenturaColumn("CcRecipients_ItemId", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "JunkEmail",
				BaseColumnName = "CcRecipients_ItemId"
			});

			schema_array.Add(new VenturaColumn("BccRecipients_Name", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "JunkEmail",
				BaseColumnName = "BccRecipients_Name"
			});

			schema_array.Add(new VenturaColumn("BccRecipients_EmailAddress", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "JunkEmail",
				BaseColumnName = "BccRecipients_EmailAddress"
			});

			schema_array.Add(new VenturaColumn("BccRecipients_ItemId", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "JunkEmail",
				BaseColumnName = "BccRecipients_ItemId"
			});

			schema_array.Add(new VenturaColumn("IsReadReceiptRequested", typeof(bool), true)
			{
				Updateable = true,
				ColumnSize = 1,
				NumericPrecision = 1,
				NumericScale = 0,
				ProviderType = 3,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "JunkEmail",
				BaseColumnName = "IsReadReceiptRequested"
			});

			schema_array.Add(new VenturaColumn("IsDeliveryReceiptRequested", typeof(bool), true)
			{
				Updateable = true,
				ColumnSize = 1,
				NumericPrecision = 1,
				NumericScale = 0,
				ProviderType = 3,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "JunkEmail",
				BaseColumnName = "IsDeliveryReceiptRequested"
			});

			schema_array.Add(new VenturaColumn("ConversationIndex", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "JunkEmail",
				BaseColumnName = "ConversationIndex"
			});

			schema_array.Add(new VenturaColumn("ConversationTopic", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "JunkEmail",
				BaseColumnName = "ConversationTopic"
			});

			schema_array.Add(new VenturaColumn("FromName", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "JunkEmail",
				BaseColumnName = "FromName"
			});

			schema_array.Add(new VenturaColumn("FromEmailAddress", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "JunkEmail",
				BaseColumnName = "FromEmailAddress"
			});

			schema_array.Add(new VenturaColumn("FromRoutingType", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "JunkEmail",
				BaseColumnName = "FromRoutingType"
			});

			schema_array.Add(new VenturaColumn("InternetMessageId", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "JunkEmail",
				BaseColumnName = "InternetMessageId"
			});

			schema_array.Add(new VenturaColumn("IsRead", typeof(bool), true)
			{
				Updateable = true,
				ColumnSize = 1,
				NumericPrecision = 1,
				NumericScale = 0,
				ProviderType = 3,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "JunkEmail",
				BaseColumnName = "IsRead"
			});

			schema_array.Add(new VenturaColumn("IsResponseRequested", typeof(bool), true)
			{
				Updateable = true,
				ColumnSize = 1,
				NumericPrecision = 1,
				NumericScale = 0,
				ProviderType = 3,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "JunkEmail",
				BaseColumnName = "IsResponseRequested"
			});

			schema_array.Add(new VenturaColumn("References", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "JunkEmail",
				BaseColumnName = "References"
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
				BaseTableName = "JunkEmail",
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
				BaseTableName = "JunkEmail",
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
				BaseTableName = "JunkEmail",
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
				BaseTableName = "JunkEmail",
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
				BaseTableName = "JunkEmail",
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
				BaseTableName = "JunkEmail",
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
				BaseTableName = "JunkEmail",
				BaseColumnName = "EffectiveRights_ViewPrivateItems"
			});

			schema_array.Add(new VenturaColumn("ReceivedByName", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "JunkEmail",
				BaseColumnName = "ReceivedByName"
			});

			schema_array.Add(new VenturaColumn("ReceivedByEmailAddress", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "JunkEmail",
				BaseColumnName = "ReceivedByEmailAddress"
			});

			schema_array.Add(new VenturaColumn("ReceivedByRoutingType", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "JunkEmail",
				BaseColumnName = "ReceivedByRoutingType"
			});

			schema_array.Add(new VenturaColumn("ReceivedRepresentingName", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "JunkEmail",
				BaseColumnName = "ReceivedRepresentingName"
			});

			schema_array.Add(new VenturaColumn("ReceivedRepresentingEmailAddress", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "JunkEmail",
				BaseColumnName = "ReceivedRepresentingEmailAddress"
			});

			schema_array.Add(new VenturaColumn("ReceivedRepresentingRoutingType", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "JunkEmail",
				BaseColumnName = "ReceivedRepresentingRoutingType"
			});

			schema_array.Add(new VenturaColumn("LastModifiedName", typeof(string), true)
			{
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "JunkEmail",
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
				BaseTableName = "JunkEmail",
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
				BaseTableName = "JunkEmail",
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
				BaseTableName = "JunkEmail",
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
				BaseTableName = "JunkEmail",
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
				BaseTableName = "JunkEmail",
				BaseColumnName = "ConversationId"
			});

			schema_array.Add(new VenturaColumn("ConversationChangeKey", typeof(string), true)
			{
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "JunkEmail",
				BaseColumnName = "ConversationChangeKey"
			});

			schema_array.Add(new VenturaColumn("UniqueBody", typeof(string), true)
			{
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "JunkEmail",
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
				BaseTableName = "JunkEmail",
				BaseColumnName = "UniqueBodyType"
			});

			schema_array.Add(new VenturaColumn("ReminderMessageData_Text", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "JunkEmail",
				BaseColumnName = "ReminderMessageData_Text"
			});

			schema_array.Add(new VenturaColumn("ReminderMessageData_Location", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "JunkEmail",
				BaseColumnName = "ReminderMessageData_Location"
			});

			schema_array.Add(new VenturaColumn("ReminderMessageData_StartTime", typeof(DateTime), true)
			{
				Updateable = true,
				ColumnSize = 16,
				NumericPrecision = 8,
				NumericScale = 0,
				ProviderType = 6,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "JunkEmail",
				BaseColumnName = "ReminderMessageData_StartTime"
			});

			schema_array.Add(new VenturaColumn("ReminderMessageData_EndTime", typeof(DateTime), true)
			{
				Updateable = true,
				ColumnSize = 16,
				NumericPrecision = 8,
				NumericScale = 0,
				ProviderType = 6,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "JunkEmail",
				BaseColumnName = "ReminderMessageData_EndTime"
			});

			schema_array.Add(new VenturaColumn("ReminderMessageData_AssociatedCalendarId", typeof(string), true)
			{
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "JunkEmail",
				BaseColumnName = "ReminderMessageData_AssociatedCalendarId"
			});

			((IResultsetBase)this).Schema = new VenturaSchema(schema_array);
			((IResultsetBase)this).UpdateableTablename = "[Exchange].[JunkEmail]";
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. PrimaryKey. Readonly. AllowNull.
		/// Contains the unique identifier of an item in the Exchange store.
		/// </summary>
		public string ItemId
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ItemId; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ItemId = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
		/// Contains the native Multipurpose Internet Mail Extensions (MIME) stream of an object that is represented in Base64
		/// binary format.
		/// </summary>
		public string MimeContent
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.MimeContent; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.MimeContent = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
		/// Contains the unique change key of an item in the Exchange store.
		/// </summary>
		public string ItemChangeKey
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ItemChangeKey; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ItemChangeKey = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Represents the unique identifier of the parent folder that contains the item or folder.
		/// </summary>
		public string ParentFolderId
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ParentFolderId; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ParentFolderId = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
		/// Represents the unique change key of the parent folder that contains the item or folder.
		/// </summary>
		public string ParentFolderChangeKey
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ParentFolderChangeKey; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ParentFolderChangeKey = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Represents the message class of an item.
		/// </summary>
		public string ItemClass
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ItemClass; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ItemClass = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Represents the subject for Exchange store items and response objects. The subject is limited to 255 characters.
		/// </summary>
		public string Subject
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Subject; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Subject = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
		/// Indicates the sensitivity level of an item.
		/// </summary>
		public string Sensitivity
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Sensitivity; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Sensitivity = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Represents the actual body content of a message.
		/// </summary>
		public string Body
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Body; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Body = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
		/// Contains a comma-separated list of the Ids of the attached files.
		/// </summary>
		public string AttachmentIds
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.AttachmentIds; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.AttachmentIds = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
		/// Contains a comma-separated list of the names of the attached files.
		/// </summary>
		public string AttachmentNames
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.AttachmentNames; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.AttachmentNames = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
		/// Represents the date and time that an item in a mailbox was received.
		/// </summary>
		public DateTime? DateTimeReceived
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.DateTimeReceived; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.DateTimeReceived = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
		/// Represents the size in bytes of an item. This property is read-only.
		/// </summary>
		public int? Size
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Size; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Size = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Represents a collection of strings that identify to which categories an item in the mailbox belongs.
		/// </summary>
		public string Categories
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Categories; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Categories = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Describes the importance of an item.
		/// </summary>
		public string Importance
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Importance; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Importance = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Represents the identifier of the item to which this item is a reply.
		/// </summary>
		public string InReplyTo
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.InReplyTo; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.InReplyTo = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
		/// Indicates whether an item has been submitted to the Outbox default folder.
		/// </summary>
		public bool? IsSubmitted
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.IsSubmitted; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.IsSubmitted = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
		/// Represents whether an item has not yet been sent.
		/// </summary>
		public bool? IsDraft
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.IsDraft; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.IsDraft = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
		/// Indicates whether a user sent an item to himself or herself.
		/// </summary>
		public bool? IsFromMe
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.IsFromMe; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.IsFromMe = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
		/// Indicates whether the item had previously been sent.
		/// </summary>
		public bool? IsResend
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.IsResend; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.IsResend = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
		/// Indicates whether the item has been modified.
		/// </summary>
		public bool? IsUnmodified
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.IsUnmodified; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.IsUnmodified = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
		/// Represents the collection of all Internet message headers that are contained within an item in a mailbox.
		/// </summary>
		public string InternetMessageHeaders
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.InternetMessageHeaders; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.InternetMessageHeaders = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
		/// Represents the date and time that an item in a mailbox was sent.
		/// </summary>
		public DateTime? DateTimeSent
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.DateTimeSent; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.DateTimeSent = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
		/// Represents the date and time that a given item in the mailbox was created.
		/// </summary>
		public DateTime? DateTimeCreated
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.DateTimeCreated; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.DateTimeCreated = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Represents the date and time when the event occurs. This is used by the ReminderMinutesBeforeStart element to determine
		/// when the reminder is displayed.
		/// </summary>
		public DateTime? ReminderDueBy
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ReminderDueBy; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ReminderDueBy = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Indicates whether a reminder has been set for an item in the Exchange store.
		/// </summary>
		public bool? ReminderIsSet
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ReminderIsSet; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ReminderIsSet = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Represents the number of minutes before an event occurs when a reminder is displayed.
		/// </summary>
		public int? ReminderMinutesBeforeStart
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ReminderMinutesBeforeStart; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ReminderMinutesBeforeStart = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
		/// Represents the display string that is used for the contents of the To box. This is the concatenated string of all To
		/// recipient display names.
		/// </summary>
		public string DisplayCc
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.DisplayCc; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.DisplayCc = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
		/// Represents a property that is set to true if an item has at least one visible attachment. This property is read-only.
		/// </summary>
		public string DisplayTo
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.DisplayTo; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.DisplayTo = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
		/// Indicates whether an item has attachments.
		/// </summary>
		public bool? HasAttachments
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.HasAttachments; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.HasAttachments = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Represents the Culture of an item.
		/// </summary>
		public string Culture
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Culture; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Culture = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Defines the name of the Sender mailbox user.
		/// </summary>
		public string SenderName
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.SenderName; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.SenderName = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Defines the Simple Mail Transfer Protocol (SMTP) address of the Sender mailbox user.
		/// </summary>
		public string SenderEmailAddress
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.SenderEmailAddress; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.SenderEmailAddress = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Defines the routing that is used for the Sender mailbox. The default is SMTP.
		/// </summary>
		public string SenderRoutingType
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.SenderRoutingType; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.SenderRoutingType = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Defines the name of the ToRecipient.
		/// </summary>
		public string ToRecipients_Name
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ToRecipients_Name; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ToRecipients_Name = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Defines the Simple Mail Transfer Protocol (SMTP) address of the ToRecipient.
		/// </summary>
		public string ToRecipients_EmailAddress
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ToRecipients_EmailAddress; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ToRecipients_EmailAddress = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Defines the item identifier of a ToRecipient.
		/// </summary>
		public string ToRecipients_ItemId
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ToRecipients_ItemId; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ToRecipients_ItemId = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Defines the name of the CcRecipient.
		/// </summary>
		public string CcRecipients_Name
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.CcRecipients_Name; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.CcRecipients_Name = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Defines the Simple Mail Transfer Protocol (SMTP) address of the CcRecipient.
		/// </summary>
		public string CcRecipients_EmailAddress
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.CcRecipients_EmailAddress; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.CcRecipients_EmailAddress = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Defines the item identifier of a CcRecipient.
		/// </summary>
		public string CcRecipients_ItemId
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.CcRecipients_ItemId; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.CcRecipients_ItemId = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Defines the name of the BccRecipient.
		/// </summary>
		public string BccRecipients_Name
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.BccRecipients_Name; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.BccRecipients_Name = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Defines the Simple Mail Transfer Protocol (SMTP) address of the BccRecipient.
		/// </summary>
		public string BccRecipients_EmailAddress
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.BccRecipients_EmailAddress; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.BccRecipients_EmailAddress = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Defines the item identifier of a BccRecipient.
		/// </summary>
		public string BccRecipients_ItemId
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.BccRecipients_ItemId; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.BccRecipients_ItemId = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Indicates whether the sender of an item requests a read receipt.
		/// </summary>
		public bool? IsReadReceiptRequested
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.IsReadReceiptRequested; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.IsReadReceiptRequested = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Indicates whether the sender of an item requests a delivery receipt.
		/// </summary>
		public bool? IsDeliveryReceiptRequested
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.IsDeliveryReceiptRequested; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.IsDeliveryReceiptRequested = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Contains a binary Id that represents the thread to which this message belongs.
		/// </summary>
		public string ConversationIndex
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ConversationIndex; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ConversationIndex = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Represents the conversation topic.
		/// </summary>
		public string ConversationTopic
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ConversationTopic; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ConversationTopic = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Defines the name of the From mailbox user.
		/// </summary>
		public string FromName
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.FromName; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.FromName = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Defines the Simple Mail Transfer Protocol (SMTP) address of the From mailbox user.
		/// </summary>
		public string FromEmailAddress
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.FromEmailAddress; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.FromEmailAddress = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Defines the routing that is used for the From mailbox. The default is SMTP.
		/// </summary>
		public string FromRoutingType
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.FromRoutingType; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.FromRoutingType = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Represents the Internet message identifier of an item.
		/// </summary>
		public string InternetMessageId
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.InternetMessageId; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.InternetMessageId = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Indicates whether a message has been read.
		/// </summary>
		public bool? IsRead
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.IsRead; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.IsRead = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Indicates whether a response to an item is requested.
		/// </summary>
		public bool? IsResponseRequested
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.IsResponseRequested; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.IsResponseRequested = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Represents the Usenet header that is used to associate replies with the original messages.
		/// </summary>
		public string References
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.References; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.References = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
		/// Indicates whether a client can create an associated contents table.
		/// </summary>
		public bool? EffectiveRights_CreateAssociated
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.EffectiveRights_CreateAssociated; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.EffectiveRights_CreateAssociated = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
		/// Indicates whether a client can create a contents table.
		/// </summary>
		public bool? EffectiveRights_CreateContents
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.EffectiveRights_CreateContents; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.EffectiveRights_CreateContents = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
		/// Indicates whether a client can create a hierarchy table.
		/// </summary>
		public bool? EffectiveRights_CreateHierarchy
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.EffectiveRights_CreateHierarchy; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.EffectiveRights_CreateHierarchy = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
		/// Indicates whether a client can delete a folder or item.
		/// </summary>
		public bool? EffectiveRights_Delete
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.EffectiveRights_Delete; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.EffectiveRights_Delete = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
		/// Indicates whether a client can modify a folder or item.
		/// </summary>
		public bool? EffectiveRights_Modify
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.EffectiveRights_Modify; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.EffectiveRights_Modify = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
		/// Indicates whether a client can read a folder or item.
		/// </summary>
		public bool? EffectiveRights_Read
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.EffectiveRights_Read; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.EffectiveRights_Read = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
		/// Indicates whether a private item can be viewed.
		/// </summary>
		public bool? EffectiveRights_ViewPrivateItems
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.EffectiveRights_ViewPrivateItems; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.EffectiveRights_ViewPrivateItems = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Defines the name of the ReceivedBy mailbox user.
		/// </summary>
		public string ReceivedByName
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ReceivedByName; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ReceivedByName = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Defines the Simple Mail Transfer Protocol (SMTP) address of the ReceivedBy mailbox user.
		/// </summary>
		public string ReceivedByEmailAddress
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ReceivedByEmailAddress; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ReceivedByEmailAddress = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Defines the routing that is used for the ReceivedBy mailbox. The default is SMTP.
		/// </summary>
		public string ReceivedByRoutingType
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ReceivedByRoutingType; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ReceivedByRoutingType = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Defines the name of the ReceivedRepresenting mailbox user.
		/// </summary>
		public string ReceivedRepresentingName
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ReceivedRepresentingName; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ReceivedRepresentingName = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Defines the Simple Mail Transfer Protocol (SMTP) address of the ReceivedRepresenting mailbox user.
		/// </summary>
		public string ReceivedRepresentingEmailAddress
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ReceivedRepresentingEmailAddress; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ReceivedRepresentingEmailAddress = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Defines the routing that is used for the ReceivedRepresenting mailbox. The default is SMTP.
		/// </summary>
		public string ReceivedRepresentingRoutingType
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ReceivedRepresentingRoutingType; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ReceivedRepresentingRoutingType = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
		/// Contains the display name of the last user to modify an item.
		/// </summary>
		public string LastModifiedName
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.LastModifiedName; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.LastModifiedName = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
		/// Indicates when an item was last modified. This element is read-only.
		/// </summary>
		public DateTime? LastModifiedTime
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.LastModifiedTime; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.LastModifiedTime = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Indicates whether the item is associated with a folder.
		/// </summary>
		public bool? IsAssociated
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.IsAssociated; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.IsAssociated = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
		/// Represents a URL to concatenate to the Microsoft Office Outlook Web App endpoint to read an item in Outlook Web App.
		/// </summary>
		public string WebClientReadFormQueryString
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.WebClientReadFormQueryString; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.WebClientReadFormQueryString = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
		/// Represents a URL to concatenate to the Outlook Web App endpoint to edit an item in Outlook Web App.
		/// </summary>
		public string WebClientEditFormQueryString
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.WebClientEditFormQueryString; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.WebClientEditFormQueryString = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
		/// Identifies a specific conversation in the Exchange store.
		/// </summary>
		public string ConversationId
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ConversationId; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ConversationId = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
		/// Contains the change key of an item or conversation.
		/// </summary>
		public string ConversationChangeKey
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ConversationChangeKey; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ConversationChangeKey = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
		/// Represents an HTML fragment or plain-text which represents the unique body of this conversation.
		/// </summary>
		public string UniqueBody
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.UniqueBody; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.UniqueBody = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
		/// Describes how the unique item body is stored in the item (HTML or TEXT).
		/// </summary>
		public string UniqueBodyType
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.UniqueBodyType; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.UniqueBodyType = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Specifies the text of a reminder message.
		/// </summary>
		public string ReminderMessageData_Text
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ReminderMessageData_Text; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ReminderMessageData_Text = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Represents the location of a meeting, appointment, or persona.
		/// </summary>
		public string ReminderMessageData_Location
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ReminderMessageData_Location; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ReminderMessageData_Location = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Specifies the starting time of the item that the reminder is for.
		/// </summary>
		public DateTime? ReminderMessageData_StartTime
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ReminderMessageData_StartTime; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ReminderMessageData_StartTime = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Specifies the ending time of the item that the reminder is for.
		/// </summary>
		public DateTime? ReminderMessageData_EndTime
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ReminderMessageData_EndTime; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ReminderMessageData_EndTime = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
		/// Represents the calendar item that is associated with the ReminderMessageData.
		/// </summary>
		public string ReminderMessageData_AssociatedCalendarId
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ReminderMessageData_AssociatedCalendarId; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ReminderMessageData_AssociatedCalendarId = value; }
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
			this.InsertItem(index, new GetAll_JunkEmail_Record());
			this.CurrentRecordIndex = index;
		}

		public void Append(GetAll_JunkEmail_Record record)
		{
			int index = this.RecordCount;
			this.InsertItem(index, record);
			this.CurrentRecordIndex = index;
		}

		public GetAll_JunkEmail_Record NewRecord()
		{
			return new GetAll_JunkEmail_Record();
		}

		protected override GetAll_JunkEmail_Record InternalCreateExistingRecordObject(object[] columnvalues) => new GetAll_JunkEmail_Record(columnvalues);

		byte[] IRecordsetBase.Hash
		{
			get { return new byte[] { 172, 240, 38, 190, 118, 255, 164, 101, 1, 1, 90, 187, 45, 67, 125, 85 }; }
		}

		string IRecordsetBase.HashString
		{
			get { return "ACF026BE76FFA46501015ABB2D437D55"; }
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

	public sealed partial class GetAll_JunkEmail_Record : IRecordBase, INotifyPropertyChanged
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
		private string _cur__AttachmentIds; private string _ori__AttachmentIds; private bool _mod__AttachmentIds;
		private string _cur__AttachmentNames; private string _ori__AttachmentNames; private bool _mod__AttachmentNames;
		private DateTime? _cur__DateTimeReceived; private DateTime? _ori__DateTimeReceived; private bool _mod__DateTimeReceived;
		private int? _cur__Size; private int? _ori__Size; private bool _mod__Size;
		private string _cur__Categories; private string _ori__Categories; private bool _mod__Categories;
		private string _cur__Importance; private string _ori__Importance; private bool _mod__Importance;
		private string _cur__InReplyTo; private string _ori__InReplyTo; private bool _mod__InReplyTo;
		private bool? _cur__IsSubmitted; private bool? _ori__IsSubmitted; private bool _mod__IsSubmitted;
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
		private string _cur__SenderName; private string _ori__SenderName; private bool _mod__SenderName;
		private string _cur__SenderEmailAddress; private string _ori__SenderEmailAddress; private bool _mod__SenderEmailAddress;
		private string _cur__SenderRoutingType; private string _ori__SenderRoutingType; private bool _mod__SenderRoutingType;
		private string _cur__ToRecipients_Name; private string _ori__ToRecipients_Name; private bool _mod__ToRecipients_Name;
		private string _cur__ToRecipients_EmailAddress; private string _ori__ToRecipients_EmailAddress; private bool _mod__ToRecipients_EmailAddress;
		private string _cur__ToRecipients_ItemId; private string _ori__ToRecipients_ItemId; private bool _mod__ToRecipients_ItemId;
		private string _cur__CcRecipients_Name; private string _ori__CcRecipients_Name; private bool _mod__CcRecipients_Name;
		private string _cur__CcRecipients_EmailAddress; private string _ori__CcRecipients_EmailAddress; private bool _mod__CcRecipients_EmailAddress;
		private string _cur__CcRecipients_ItemId; private string _ori__CcRecipients_ItemId; private bool _mod__CcRecipients_ItemId;
		private string _cur__BccRecipients_Name; private string _ori__BccRecipients_Name; private bool _mod__BccRecipients_Name;
		private string _cur__BccRecipients_EmailAddress; private string _ori__BccRecipients_EmailAddress; private bool _mod__BccRecipients_EmailAddress;
		private string _cur__BccRecipients_ItemId; private string _ori__BccRecipients_ItemId; private bool _mod__BccRecipients_ItemId;
		private bool? _cur__IsReadReceiptRequested; private bool? _ori__IsReadReceiptRequested; private bool _mod__IsReadReceiptRequested;
		private bool? _cur__IsDeliveryReceiptRequested; private bool? _ori__IsDeliveryReceiptRequested; private bool _mod__IsDeliveryReceiptRequested;
		private string _cur__ConversationIndex; private string _ori__ConversationIndex; private bool _mod__ConversationIndex;
		private string _cur__ConversationTopic; private string _ori__ConversationTopic; private bool _mod__ConversationTopic;
		private string _cur__FromName; private string _ori__FromName; private bool _mod__FromName;
		private string _cur__FromEmailAddress; private string _ori__FromEmailAddress; private bool _mod__FromEmailAddress;
		private string _cur__FromRoutingType; private string _ori__FromRoutingType; private bool _mod__FromRoutingType;
		private string _cur__InternetMessageId; private string _ori__InternetMessageId; private bool _mod__InternetMessageId;
		private bool? _cur__IsRead; private bool? _ori__IsRead; private bool _mod__IsRead;
		private bool? _cur__IsResponseRequested; private bool? _ori__IsResponseRequested; private bool _mod__IsResponseRequested;
		private string _cur__References; private string _ori__References; private bool _mod__References;
		private bool? _cur__EffectiveRights_CreateAssociated; private bool? _ori__EffectiveRights_CreateAssociated; private bool _mod__EffectiveRights_CreateAssociated;
		private bool? _cur__EffectiveRights_CreateContents; private bool? _ori__EffectiveRights_CreateContents; private bool _mod__EffectiveRights_CreateContents;
		private bool? _cur__EffectiveRights_CreateHierarchy; private bool? _ori__EffectiveRights_CreateHierarchy; private bool _mod__EffectiveRights_CreateHierarchy;
		private bool? _cur__EffectiveRights_Delete; private bool? _ori__EffectiveRights_Delete; private bool _mod__EffectiveRights_Delete;
		private bool? _cur__EffectiveRights_Modify; private bool? _ori__EffectiveRights_Modify; private bool _mod__EffectiveRights_Modify;
		private bool? _cur__EffectiveRights_Read; private bool? _ori__EffectiveRights_Read; private bool _mod__EffectiveRights_Read;
		private bool? _cur__EffectiveRights_ViewPrivateItems; private bool? _ori__EffectiveRights_ViewPrivateItems; private bool _mod__EffectiveRights_ViewPrivateItems;
		private string _cur__ReceivedByName; private string _ori__ReceivedByName; private bool _mod__ReceivedByName;
		private string _cur__ReceivedByEmailAddress; private string _ori__ReceivedByEmailAddress; private bool _mod__ReceivedByEmailAddress;
		private string _cur__ReceivedByRoutingType; private string _ori__ReceivedByRoutingType; private bool _mod__ReceivedByRoutingType;
		private string _cur__ReceivedRepresentingName; private string _ori__ReceivedRepresentingName; private bool _mod__ReceivedRepresentingName;
		private string _cur__ReceivedRepresentingEmailAddress; private string _ori__ReceivedRepresentingEmailAddress; private bool _mod__ReceivedRepresentingEmailAddress;
		private string _cur__ReceivedRepresentingRoutingType; private string _ori__ReceivedRepresentingRoutingType; private bool _mod__ReceivedRepresentingRoutingType;
		private string _cur__LastModifiedName; private string _ori__LastModifiedName; private bool _mod__LastModifiedName;
		private DateTime? _cur__LastModifiedTime; private DateTime? _ori__LastModifiedTime; private bool _mod__LastModifiedTime;
		private bool? _cur__IsAssociated; private bool? _ori__IsAssociated; private bool _mod__IsAssociated;
		private string _cur__WebClientReadFormQueryString; private string _ori__WebClientReadFormQueryString; private bool _mod__WebClientReadFormQueryString;
		private string _cur__WebClientEditFormQueryString; private string _ori__WebClientEditFormQueryString; private bool _mod__WebClientEditFormQueryString;
		private string _cur__ConversationId; private string _ori__ConversationId; private bool _mod__ConversationId;
		private string _cur__ConversationChangeKey; private string _ori__ConversationChangeKey; private bool _mod__ConversationChangeKey;
		private string _cur__UniqueBody; private string _ori__UniqueBody; private bool _mod__UniqueBody;
		private string _cur__UniqueBodyType; private string _ori__UniqueBodyType; private bool _mod__UniqueBodyType;
		private string _cur__ReminderMessageData_Text; private string _ori__ReminderMessageData_Text; private bool _mod__ReminderMessageData_Text;
		private string _cur__ReminderMessageData_Location; private string _ori__ReminderMessageData_Location; private bool _mod__ReminderMessageData_Location;
		private DateTime? _cur__ReminderMessageData_StartTime; private DateTime? _ori__ReminderMessageData_StartTime; private bool _mod__ReminderMessageData_StartTime;
		private DateTime? _cur__ReminderMessageData_EndTime; private DateTime? _ori__ReminderMessageData_EndTime; private bool _mod__ReminderMessageData_EndTime;
		private string _cur__ReminderMessageData_AssociatedCalendarId; private string _ori__ReminderMessageData_AssociatedCalendarId; private bool _mod__ReminderMessageData_AssociatedCalendarId;


		public GetAll_JunkEmail_Record()
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
			_cur__AttachmentIds = null;
			_cur__AttachmentNames = null;
			_cur__DateTimeReceived = null;
			_cur__Size = null;
			_cur__Categories = null;
			_cur__Importance = null;
			_cur__InReplyTo = null;
			_cur__IsSubmitted = null;
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
			_cur__SenderName = null;
			_cur__SenderEmailAddress = null;
			_cur__SenderRoutingType = null;
			_cur__ToRecipients_Name = null;
			_cur__ToRecipients_EmailAddress = null;
			_cur__ToRecipients_ItemId = null;
			_cur__CcRecipients_Name = null;
			_cur__CcRecipients_EmailAddress = null;
			_cur__CcRecipients_ItemId = null;
			_cur__BccRecipients_Name = null;
			_cur__BccRecipients_EmailAddress = null;
			_cur__BccRecipients_ItemId = null;
			_cur__IsReadReceiptRequested = null;
			_cur__IsDeliveryReceiptRequested = null;
			_cur__ConversationIndex = null;
			_cur__ConversationTopic = null;
			_cur__FromName = null;
			_cur__FromEmailAddress = null;
			_cur__FromRoutingType = null;
			_cur__InternetMessageId = null;
			_cur__IsRead = null;
			_cur__IsResponseRequested = null;
			_cur__References = null;
			_cur__EffectiveRights_CreateAssociated = null;
			_cur__EffectiveRights_CreateContents = null;
			_cur__EffectiveRights_CreateHierarchy = null;
			_cur__EffectiveRights_Delete = null;
			_cur__EffectiveRights_Modify = null;
			_cur__EffectiveRights_Read = null;
			_cur__EffectiveRights_ViewPrivateItems = null;
			_cur__ReceivedByName = null;
			_cur__ReceivedByEmailAddress = null;
			_cur__ReceivedByRoutingType = null;
			_cur__ReceivedRepresentingName = null;
			_cur__ReceivedRepresentingEmailAddress = null;
			_cur__ReceivedRepresentingRoutingType = null;
			_cur__LastModifiedName = null;
			_cur__LastModifiedTime = null;
			_cur__IsAssociated = null;
			_cur__WebClientReadFormQueryString = null;
			_cur__WebClientEditFormQueryString = null;
			_cur__ConversationId = null;
			_cur__ConversationChangeKey = null;
			_cur__UniqueBody = null;
			_cur__UniqueBodyType = null;
			_cur__ReminderMessageData_Text = null;
			_cur__ReminderMessageData_Location = null;
			_cur__ReminderMessageData_StartTime = null;
			_cur__ReminderMessageData_EndTime = null;
			_cur__ReminderMessageData_AssociatedCalendarId = null;
			_started_with_dbvalues = false;
			_recordstatus = DataRecordStatus.New;
		}

		public GetAll_JunkEmail_Record(object[] columnvalues)
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
			_cur__AttachmentIds = (string)columnvalues[9];
			_cur__AttachmentNames = (string)columnvalues[10];
			_cur__DateTimeReceived = (DateTime?)columnvalues[11];
			_cur__Size = (int?)columnvalues[12];
			_cur__Categories = (string)columnvalues[13];
			_cur__Importance = (string)columnvalues[14];
			_cur__InReplyTo = (string)columnvalues[15];
			_cur__IsSubmitted = (bool?)columnvalues[16];
			_cur__IsDraft = (bool?)columnvalues[17];
			_cur__IsFromMe = (bool?)columnvalues[18];
			_cur__IsResend = (bool?)columnvalues[19];
			_cur__IsUnmodified = (bool?)columnvalues[20];
			_cur__InternetMessageHeaders = (string)columnvalues[21];
			_cur__DateTimeSent = (DateTime?)columnvalues[22];
			_cur__DateTimeCreated = (DateTime?)columnvalues[23];
			_cur__ReminderDueBy = (DateTime?)columnvalues[24];
			_cur__ReminderIsSet = (bool?)columnvalues[25];
			_cur__ReminderMinutesBeforeStart = (int?)columnvalues[26];
			_cur__DisplayCc = (string)columnvalues[27];
			_cur__DisplayTo = (string)columnvalues[28];
			_cur__HasAttachments = (bool?)columnvalues[29];
			_cur__Culture = (string)columnvalues[30];
			_cur__SenderName = (string)columnvalues[31];
			_cur__SenderEmailAddress = (string)columnvalues[32];
			_cur__SenderRoutingType = (string)columnvalues[33];
			_cur__ToRecipients_Name = (string)columnvalues[34];
			_cur__ToRecipients_EmailAddress = (string)columnvalues[35];
			_cur__ToRecipients_ItemId = (string)columnvalues[36];
			_cur__CcRecipients_Name = (string)columnvalues[37];
			_cur__CcRecipients_EmailAddress = (string)columnvalues[38];
			_cur__CcRecipients_ItemId = (string)columnvalues[39];
			_cur__BccRecipients_Name = (string)columnvalues[40];
			_cur__BccRecipients_EmailAddress = (string)columnvalues[41];
			_cur__BccRecipients_ItemId = (string)columnvalues[42];
			_cur__IsReadReceiptRequested = (bool?)columnvalues[43];
			_cur__IsDeliveryReceiptRequested = (bool?)columnvalues[44];
			_cur__ConversationIndex = (string)columnvalues[45];
			_cur__ConversationTopic = (string)columnvalues[46];
			_cur__FromName = (string)columnvalues[47];
			_cur__FromEmailAddress = (string)columnvalues[48];
			_cur__FromRoutingType = (string)columnvalues[49];
			_cur__InternetMessageId = (string)columnvalues[50];
			_cur__IsRead = (bool?)columnvalues[51];
			_cur__IsResponseRequested = (bool?)columnvalues[52];
			_cur__References = (string)columnvalues[53];
			_cur__EffectiveRights_CreateAssociated = (bool?)columnvalues[54];
			_cur__EffectiveRights_CreateContents = (bool?)columnvalues[55];
			_cur__EffectiveRights_CreateHierarchy = (bool?)columnvalues[56];
			_cur__EffectiveRights_Delete = (bool?)columnvalues[57];
			_cur__EffectiveRights_Modify = (bool?)columnvalues[58];
			_cur__EffectiveRights_Read = (bool?)columnvalues[59];
			_cur__EffectiveRights_ViewPrivateItems = (bool?)columnvalues[60];
			_cur__ReceivedByName = (string)columnvalues[61];
			_cur__ReceivedByEmailAddress = (string)columnvalues[62];
			_cur__ReceivedByRoutingType = (string)columnvalues[63];
			_cur__ReceivedRepresentingName = (string)columnvalues[64];
			_cur__ReceivedRepresentingEmailAddress = (string)columnvalues[65];
			_cur__ReceivedRepresentingRoutingType = (string)columnvalues[66];
			_cur__LastModifiedName = (string)columnvalues[67];
			_cur__LastModifiedTime = (DateTime?)columnvalues[68];
			_cur__IsAssociated = (bool?)columnvalues[69];
			_cur__WebClientReadFormQueryString = (string)columnvalues[70];
			_cur__WebClientEditFormQueryString = (string)columnvalues[71];
			_cur__ConversationId = (string)columnvalues[72];
			_cur__ConversationChangeKey = (string)columnvalues[73];
			_cur__UniqueBody = (string)columnvalues[74];
			_cur__UniqueBodyType = (string)columnvalues[75];
			_cur__ReminderMessageData_Text = (string)columnvalues[76];
			_cur__ReminderMessageData_Location = (string)columnvalues[77];
			_cur__ReminderMessageData_StartTime = (DateTime?)columnvalues[78];
			_cur__ReminderMessageData_EndTime = (DateTime?)columnvalues[79];
			_cur__ReminderMessageData_AssociatedCalendarId = (string)columnvalues[80];
			_started_with_dbvalues = true;
			_recordstatus = DataRecordStatus.Existing;
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. PrimaryKey. Readonly. AllowNull.
		/// Contains the unique identifier of an item in the Exchange store.
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
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
		/// Contains the unique change key of an item in the Exchange store.
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
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Represents the unique identifier of the parent folder that contains the item or folder.
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
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
		/// Represents the unique change key of the parent folder that contains the item or folder.
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
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
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
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
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
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
		/// Contains a comma-separated list of the Ids of the attached files.
		/// </summary>
		public string AttachmentIds
		{
			get { return _cur__AttachmentIds; }
			set
			{
				if (_started_with_dbvalues == false) _mod__AttachmentIds = true;
				if (_cur__AttachmentIds == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__AttachmentIds == false) { _ori__AttachmentIds = _cur__AttachmentIds; _mod__AttachmentIds = true; } // existing record and column is not modified
					else { if (value == _ori__AttachmentIds) { _ori__AttachmentIds = default(string); _mod__AttachmentIds = false; } } // existing record and column is modified
				}
				_cur__AttachmentIds = value; OnPropertyChanged("AttachmentIds"); OnAfterPropertyChanged("AttachmentIds");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
		/// Contains a comma-separated list of the names of the attached files.
		/// </summary>
		public string AttachmentNames
		{
			get { return _cur__AttachmentNames; }
			set
			{
				if (_started_with_dbvalues == false) _mod__AttachmentNames = true;
				if (_cur__AttachmentNames == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__AttachmentNames == false) { _ori__AttachmentNames = _cur__AttachmentNames; _mod__AttachmentNames = true; } // existing record and column is not modified
					else { if (value == _ori__AttachmentNames) { _ori__AttachmentNames = default(string); _mod__AttachmentNames = false; } } // existing record and column is modified
				}
				_cur__AttachmentNames = value; OnPropertyChanged("AttachmentNames"); OnAfterPropertyChanged("AttachmentNames");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
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
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
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
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
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
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
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
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Represents the date and time when the event occurs. This is used by the ReminderMinutesBeforeStart element to determine
		/// when the reminder is displayed.
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
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
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
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
		/// Represents the display string that is used for the contents of the To box. This is the concatenated string of all To
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
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
		/// Represents a property that is set to true if an item has at least one visible attachment. This property is read-only.
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
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
		/// Indicates whether an item has attachments.
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
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Represents the Culture of an item.
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
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Defines the name of the Sender mailbox user.
		/// </summary>
		public string SenderName
		{
			get { return _cur__SenderName; }
			set
			{
				if (_started_with_dbvalues == false) _mod__SenderName = true;
				if (_cur__SenderName == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__SenderName == false) { _ori__SenderName = _cur__SenderName; _mod__SenderName = true; } // existing record and column is not modified
					else { if (value == _ori__SenderName) { _ori__SenderName = default(string); _mod__SenderName = false; } } // existing record and column is modified
				}
				_cur__SenderName = value; OnPropertyChanged("SenderName"); OnAfterPropertyChanged("SenderName");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Defines the Simple Mail Transfer Protocol (SMTP) address of the Sender mailbox user.
		/// </summary>
		public string SenderEmailAddress
		{
			get { return _cur__SenderEmailAddress; }
			set
			{
				if (_started_with_dbvalues == false) _mod__SenderEmailAddress = true;
				if (_cur__SenderEmailAddress == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__SenderEmailAddress == false) { _ori__SenderEmailAddress = _cur__SenderEmailAddress; _mod__SenderEmailAddress = true; } // existing record and column is not modified
					else { if (value == _ori__SenderEmailAddress) { _ori__SenderEmailAddress = default(string); _mod__SenderEmailAddress = false; } } // existing record and column is modified
				}
				_cur__SenderEmailAddress = value; OnPropertyChanged("SenderEmailAddress"); OnAfterPropertyChanged("SenderEmailAddress");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Defines the routing that is used for the Sender mailbox. The default is SMTP.
		/// </summary>
		public string SenderRoutingType
		{
			get { return _cur__SenderRoutingType; }
			set
			{
				if (_started_with_dbvalues == false) _mod__SenderRoutingType = true;
				if (_cur__SenderRoutingType == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__SenderRoutingType == false) { _ori__SenderRoutingType = _cur__SenderRoutingType; _mod__SenderRoutingType = true; } // existing record and column is not modified
					else { if (value == _ori__SenderRoutingType) { _ori__SenderRoutingType = default(string); _mod__SenderRoutingType = false; } } // existing record and column is modified
				}
				_cur__SenderRoutingType = value; OnPropertyChanged("SenderRoutingType"); OnAfterPropertyChanged("SenderRoutingType");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Defines the name of the ToRecipient.
		/// </summary>
		public string ToRecipients_Name
		{
			get { return _cur__ToRecipients_Name; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ToRecipients_Name = true;
				if (_cur__ToRecipients_Name == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ToRecipients_Name == false) { _ori__ToRecipients_Name = _cur__ToRecipients_Name; _mod__ToRecipients_Name = true; } // existing record and column is not modified
					else { if (value == _ori__ToRecipients_Name) { _ori__ToRecipients_Name = default(string); _mod__ToRecipients_Name = false; } } // existing record and column is modified
				}
				_cur__ToRecipients_Name = value; OnPropertyChanged("ToRecipients_Name"); OnAfterPropertyChanged("ToRecipients_Name");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Defines the Simple Mail Transfer Protocol (SMTP) address of the ToRecipient.
		/// </summary>
		public string ToRecipients_EmailAddress
		{
			get { return _cur__ToRecipients_EmailAddress; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ToRecipients_EmailAddress = true;
				if (_cur__ToRecipients_EmailAddress == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ToRecipients_EmailAddress == false) { _ori__ToRecipients_EmailAddress = _cur__ToRecipients_EmailAddress; _mod__ToRecipients_EmailAddress = true; } // existing record and column is not modified
					else { if (value == _ori__ToRecipients_EmailAddress) { _ori__ToRecipients_EmailAddress = default(string); _mod__ToRecipients_EmailAddress = false; } } // existing record and column is modified
				}
				_cur__ToRecipients_EmailAddress = value; OnPropertyChanged("ToRecipients_EmailAddress"); OnAfterPropertyChanged("ToRecipients_EmailAddress");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Defines the item identifier of a ToRecipient.
		/// </summary>
		public string ToRecipients_ItemId
		{
			get { return _cur__ToRecipients_ItemId; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ToRecipients_ItemId = true;
				if (_cur__ToRecipients_ItemId == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ToRecipients_ItemId == false) { _ori__ToRecipients_ItemId = _cur__ToRecipients_ItemId; _mod__ToRecipients_ItemId = true; } // existing record and column is not modified
					else { if (value == _ori__ToRecipients_ItemId) { _ori__ToRecipients_ItemId = default(string); _mod__ToRecipients_ItemId = false; } } // existing record and column is modified
				}
				_cur__ToRecipients_ItemId = value; OnPropertyChanged("ToRecipients_ItemId"); OnAfterPropertyChanged("ToRecipients_ItemId");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Defines the name of the CcRecipient.
		/// </summary>
		public string CcRecipients_Name
		{
			get { return _cur__CcRecipients_Name; }
			set
			{
				if (_started_with_dbvalues == false) _mod__CcRecipients_Name = true;
				if (_cur__CcRecipients_Name == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__CcRecipients_Name == false) { _ori__CcRecipients_Name = _cur__CcRecipients_Name; _mod__CcRecipients_Name = true; } // existing record and column is not modified
					else { if (value == _ori__CcRecipients_Name) { _ori__CcRecipients_Name = default(string); _mod__CcRecipients_Name = false; } } // existing record and column is modified
				}
				_cur__CcRecipients_Name = value; OnPropertyChanged("CcRecipients_Name"); OnAfterPropertyChanged("CcRecipients_Name");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Defines the Simple Mail Transfer Protocol (SMTP) address of the CcRecipient.
		/// </summary>
		public string CcRecipients_EmailAddress
		{
			get { return _cur__CcRecipients_EmailAddress; }
			set
			{
				if (_started_with_dbvalues == false) _mod__CcRecipients_EmailAddress = true;
				if (_cur__CcRecipients_EmailAddress == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__CcRecipients_EmailAddress == false) { _ori__CcRecipients_EmailAddress = _cur__CcRecipients_EmailAddress; _mod__CcRecipients_EmailAddress = true; } // existing record and column is not modified
					else { if (value == _ori__CcRecipients_EmailAddress) { _ori__CcRecipients_EmailAddress = default(string); _mod__CcRecipients_EmailAddress = false; } } // existing record and column is modified
				}
				_cur__CcRecipients_EmailAddress = value; OnPropertyChanged("CcRecipients_EmailAddress"); OnAfterPropertyChanged("CcRecipients_EmailAddress");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Defines the item identifier of a CcRecipient.
		/// </summary>
		public string CcRecipients_ItemId
		{
			get { return _cur__CcRecipients_ItemId; }
			set
			{
				if (_started_with_dbvalues == false) _mod__CcRecipients_ItemId = true;
				if (_cur__CcRecipients_ItemId == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__CcRecipients_ItemId == false) { _ori__CcRecipients_ItemId = _cur__CcRecipients_ItemId; _mod__CcRecipients_ItemId = true; } // existing record and column is not modified
					else { if (value == _ori__CcRecipients_ItemId) { _ori__CcRecipients_ItemId = default(string); _mod__CcRecipients_ItemId = false; } } // existing record and column is modified
				}
				_cur__CcRecipients_ItemId = value; OnPropertyChanged("CcRecipients_ItemId"); OnAfterPropertyChanged("CcRecipients_ItemId");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Defines the name of the BccRecipient.
		/// </summary>
		public string BccRecipients_Name
		{
			get { return _cur__BccRecipients_Name; }
			set
			{
				if (_started_with_dbvalues == false) _mod__BccRecipients_Name = true;
				if (_cur__BccRecipients_Name == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__BccRecipients_Name == false) { _ori__BccRecipients_Name = _cur__BccRecipients_Name; _mod__BccRecipients_Name = true; } // existing record and column is not modified
					else { if (value == _ori__BccRecipients_Name) { _ori__BccRecipients_Name = default(string); _mod__BccRecipients_Name = false; } } // existing record and column is modified
				}
				_cur__BccRecipients_Name = value; OnPropertyChanged("BccRecipients_Name"); OnAfterPropertyChanged("BccRecipients_Name");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Defines the Simple Mail Transfer Protocol (SMTP) address of the BccRecipient.
		/// </summary>
		public string BccRecipients_EmailAddress
		{
			get { return _cur__BccRecipients_EmailAddress; }
			set
			{
				if (_started_with_dbvalues == false) _mod__BccRecipients_EmailAddress = true;
				if (_cur__BccRecipients_EmailAddress == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__BccRecipients_EmailAddress == false) { _ori__BccRecipients_EmailAddress = _cur__BccRecipients_EmailAddress; _mod__BccRecipients_EmailAddress = true; } // existing record and column is not modified
					else { if (value == _ori__BccRecipients_EmailAddress) { _ori__BccRecipients_EmailAddress = default(string); _mod__BccRecipients_EmailAddress = false; } } // existing record and column is modified
				}
				_cur__BccRecipients_EmailAddress = value; OnPropertyChanged("BccRecipients_EmailAddress"); OnAfterPropertyChanged("BccRecipients_EmailAddress");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Defines the item identifier of a BccRecipient.
		/// </summary>
		public string BccRecipients_ItemId
		{
			get { return _cur__BccRecipients_ItemId; }
			set
			{
				if (_started_with_dbvalues == false) _mod__BccRecipients_ItemId = true;
				if (_cur__BccRecipients_ItemId == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__BccRecipients_ItemId == false) { _ori__BccRecipients_ItemId = _cur__BccRecipients_ItemId; _mod__BccRecipients_ItemId = true; } // existing record and column is not modified
					else { if (value == _ori__BccRecipients_ItemId) { _ori__BccRecipients_ItemId = default(string); _mod__BccRecipients_ItemId = false; } } // existing record and column is modified
				}
				_cur__BccRecipients_ItemId = value; OnPropertyChanged("BccRecipients_ItemId"); OnAfterPropertyChanged("BccRecipients_ItemId");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Indicates whether the sender of an item requests a read receipt.
		/// </summary>
		public bool? IsReadReceiptRequested
		{
			get { return _cur__IsReadReceiptRequested; }
			set
			{
				if (_started_with_dbvalues == false) _mod__IsReadReceiptRequested = true;
				if (_cur__IsReadReceiptRequested == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__IsReadReceiptRequested == false) { _ori__IsReadReceiptRequested = _cur__IsReadReceiptRequested; _mod__IsReadReceiptRequested = true; } // existing record and column is not modified
					else { if (value == _ori__IsReadReceiptRequested) { _ori__IsReadReceiptRequested = default(bool?); _mod__IsReadReceiptRequested = false; } } // existing record and column is modified
				}
				_cur__IsReadReceiptRequested = value; OnPropertyChanged("IsReadReceiptRequested"); OnAfterPropertyChanged("IsReadReceiptRequested");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Indicates whether the sender of an item requests a delivery receipt.
		/// </summary>
		public bool? IsDeliveryReceiptRequested
		{
			get { return _cur__IsDeliveryReceiptRequested; }
			set
			{
				if (_started_with_dbvalues == false) _mod__IsDeliveryReceiptRequested = true;
				if (_cur__IsDeliveryReceiptRequested == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__IsDeliveryReceiptRequested == false) { _ori__IsDeliveryReceiptRequested = _cur__IsDeliveryReceiptRequested; _mod__IsDeliveryReceiptRequested = true; } // existing record and column is not modified
					else { if (value == _ori__IsDeliveryReceiptRequested) { _ori__IsDeliveryReceiptRequested = default(bool?); _mod__IsDeliveryReceiptRequested = false; } } // existing record and column is modified
				}
				_cur__IsDeliveryReceiptRequested = value; OnPropertyChanged("IsDeliveryReceiptRequested"); OnAfterPropertyChanged("IsDeliveryReceiptRequested");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Contains a binary Id that represents the thread to which this message belongs.
		/// </summary>
		public string ConversationIndex
		{
			get { return _cur__ConversationIndex; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ConversationIndex = true;
				if (_cur__ConversationIndex == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ConversationIndex == false) { _ori__ConversationIndex = _cur__ConversationIndex; _mod__ConversationIndex = true; } // existing record and column is not modified
					else { if (value == _ori__ConversationIndex) { _ori__ConversationIndex = default(string); _mod__ConversationIndex = false; } } // existing record and column is modified
				}
				_cur__ConversationIndex = value; OnPropertyChanged("ConversationIndex"); OnAfterPropertyChanged("ConversationIndex");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Represents the conversation topic.
		/// </summary>
		public string ConversationTopic
		{
			get { return _cur__ConversationTopic; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ConversationTopic = true;
				if (_cur__ConversationTopic == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ConversationTopic == false) { _ori__ConversationTopic = _cur__ConversationTopic; _mod__ConversationTopic = true; } // existing record and column is not modified
					else { if (value == _ori__ConversationTopic) { _ori__ConversationTopic = default(string); _mod__ConversationTopic = false; } } // existing record and column is modified
				}
				_cur__ConversationTopic = value; OnPropertyChanged("ConversationTopic"); OnAfterPropertyChanged("ConversationTopic");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Defines the name of the From mailbox user.
		/// </summary>
		public string FromName
		{
			get { return _cur__FromName; }
			set
			{
				if (_started_with_dbvalues == false) _mod__FromName = true;
				if (_cur__FromName == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__FromName == false) { _ori__FromName = _cur__FromName; _mod__FromName = true; } // existing record and column is not modified
					else { if (value == _ori__FromName) { _ori__FromName = default(string); _mod__FromName = false; } } // existing record and column is modified
				}
				_cur__FromName = value; OnPropertyChanged("FromName"); OnAfterPropertyChanged("FromName");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Defines the Simple Mail Transfer Protocol (SMTP) address of the From mailbox user.
		/// </summary>
		public string FromEmailAddress
		{
			get { return _cur__FromEmailAddress; }
			set
			{
				if (_started_with_dbvalues == false) _mod__FromEmailAddress = true;
				if (_cur__FromEmailAddress == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__FromEmailAddress == false) { _ori__FromEmailAddress = _cur__FromEmailAddress; _mod__FromEmailAddress = true; } // existing record and column is not modified
					else { if (value == _ori__FromEmailAddress) { _ori__FromEmailAddress = default(string); _mod__FromEmailAddress = false; } } // existing record and column is modified
				}
				_cur__FromEmailAddress = value; OnPropertyChanged("FromEmailAddress"); OnAfterPropertyChanged("FromEmailAddress");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Defines the routing that is used for the From mailbox. The default is SMTP.
		/// </summary>
		public string FromRoutingType
		{
			get { return _cur__FromRoutingType; }
			set
			{
				if (_started_with_dbvalues == false) _mod__FromRoutingType = true;
				if (_cur__FromRoutingType == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__FromRoutingType == false) { _ori__FromRoutingType = _cur__FromRoutingType; _mod__FromRoutingType = true; } // existing record and column is not modified
					else { if (value == _ori__FromRoutingType) { _ori__FromRoutingType = default(string); _mod__FromRoutingType = false; } } // existing record and column is modified
				}
				_cur__FromRoutingType = value; OnPropertyChanged("FromRoutingType"); OnAfterPropertyChanged("FromRoutingType");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Represents the Internet message identifier of an item.
		/// </summary>
		public string InternetMessageId
		{
			get { return _cur__InternetMessageId; }
			set
			{
				if (_started_with_dbvalues == false) _mod__InternetMessageId = true;
				if (_cur__InternetMessageId == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__InternetMessageId == false) { _ori__InternetMessageId = _cur__InternetMessageId; _mod__InternetMessageId = true; } // existing record and column is not modified
					else { if (value == _ori__InternetMessageId) { _ori__InternetMessageId = default(string); _mod__InternetMessageId = false; } } // existing record and column is modified
				}
				_cur__InternetMessageId = value; OnPropertyChanged("InternetMessageId"); OnAfterPropertyChanged("InternetMessageId");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Indicates whether a message has been read.
		/// </summary>
		public bool? IsRead
		{
			get { return _cur__IsRead; }
			set
			{
				if (_started_with_dbvalues == false) _mod__IsRead = true;
				if (_cur__IsRead == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__IsRead == false) { _ori__IsRead = _cur__IsRead; _mod__IsRead = true; } // existing record and column is not modified
					else { if (value == _ori__IsRead) { _ori__IsRead = default(bool?); _mod__IsRead = false; } } // existing record and column is modified
				}
				_cur__IsRead = value; OnPropertyChanged("IsRead"); OnAfterPropertyChanged("IsRead");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Indicates whether a response to an item is requested.
		/// </summary>
		public bool? IsResponseRequested
		{
			get { return _cur__IsResponseRequested; }
			set
			{
				if (_started_with_dbvalues == false) _mod__IsResponseRequested = true;
				if (_cur__IsResponseRequested == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__IsResponseRequested == false) { _ori__IsResponseRequested = _cur__IsResponseRequested; _mod__IsResponseRequested = true; } // existing record and column is not modified
					else { if (value == _ori__IsResponseRequested) { _ori__IsResponseRequested = default(bool?); _mod__IsResponseRequested = false; } } // existing record and column is modified
				}
				_cur__IsResponseRequested = value; OnPropertyChanged("IsResponseRequested"); OnAfterPropertyChanged("IsResponseRequested");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Represents the Usenet header that is used to associate replies with the original messages.
		/// </summary>
		public string References
		{
			get { return _cur__References; }
			set
			{
				if (_started_with_dbvalues == false) _mod__References = true;
				if (_cur__References == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__References == false) { _ori__References = _cur__References; _mod__References = true; } // existing record and column is not modified
					else { if (value == _ori__References) { _ori__References = default(string); _mod__References = false; } } // existing record and column is modified
				}
				_cur__References = value; OnPropertyChanged("References"); OnAfterPropertyChanged("References");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
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
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Defines the name of the ReceivedBy mailbox user.
		/// </summary>
		public string ReceivedByName
		{
			get { return _cur__ReceivedByName; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ReceivedByName = true;
				if (_cur__ReceivedByName == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ReceivedByName == false) { _ori__ReceivedByName = _cur__ReceivedByName; _mod__ReceivedByName = true; } // existing record and column is not modified
					else { if (value == _ori__ReceivedByName) { _ori__ReceivedByName = default(string); _mod__ReceivedByName = false; } } // existing record and column is modified
				}
				_cur__ReceivedByName = value; OnPropertyChanged("ReceivedByName"); OnAfterPropertyChanged("ReceivedByName");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Defines the Simple Mail Transfer Protocol (SMTP) address of the ReceivedBy mailbox user.
		/// </summary>
		public string ReceivedByEmailAddress
		{
			get { return _cur__ReceivedByEmailAddress; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ReceivedByEmailAddress = true;
				if (_cur__ReceivedByEmailAddress == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ReceivedByEmailAddress == false) { _ori__ReceivedByEmailAddress = _cur__ReceivedByEmailAddress; _mod__ReceivedByEmailAddress = true; } // existing record and column is not modified
					else { if (value == _ori__ReceivedByEmailAddress) { _ori__ReceivedByEmailAddress = default(string); _mod__ReceivedByEmailAddress = false; } } // existing record and column is modified
				}
				_cur__ReceivedByEmailAddress = value; OnPropertyChanged("ReceivedByEmailAddress"); OnAfterPropertyChanged("ReceivedByEmailAddress");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Defines the routing that is used for the ReceivedBy mailbox. The default is SMTP.
		/// </summary>
		public string ReceivedByRoutingType
		{
			get { return _cur__ReceivedByRoutingType; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ReceivedByRoutingType = true;
				if (_cur__ReceivedByRoutingType == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ReceivedByRoutingType == false) { _ori__ReceivedByRoutingType = _cur__ReceivedByRoutingType; _mod__ReceivedByRoutingType = true; } // existing record and column is not modified
					else { if (value == _ori__ReceivedByRoutingType) { _ori__ReceivedByRoutingType = default(string); _mod__ReceivedByRoutingType = false; } } // existing record and column is modified
				}
				_cur__ReceivedByRoutingType = value; OnPropertyChanged("ReceivedByRoutingType"); OnAfterPropertyChanged("ReceivedByRoutingType");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Defines the name of the ReceivedRepresenting mailbox user.
		/// </summary>
		public string ReceivedRepresentingName
		{
			get { return _cur__ReceivedRepresentingName; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ReceivedRepresentingName = true;
				if (_cur__ReceivedRepresentingName == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ReceivedRepresentingName == false) { _ori__ReceivedRepresentingName = _cur__ReceivedRepresentingName; _mod__ReceivedRepresentingName = true; } // existing record and column is not modified
					else { if (value == _ori__ReceivedRepresentingName) { _ori__ReceivedRepresentingName = default(string); _mod__ReceivedRepresentingName = false; } } // existing record and column is modified
				}
				_cur__ReceivedRepresentingName = value; OnPropertyChanged("ReceivedRepresentingName"); OnAfterPropertyChanged("ReceivedRepresentingName");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Defines the Simple Mail Transfer Protocol (SMTP) address of the ReceivedRepresenting mailbox user.
		/// </summary>
		public string ReceivedRepresentingEmailAddress
		{
			get { return _cur__ReceivedRepresentingEmailAddress; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ReceivedRepresentingEmailAddress = true;
				if (_cur__ReceivedRepresentingEmailAddress == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ReceivedRepresentingEmailAddress == false) { _ori__ReceivedRepresentingEmailAddress = _cur__ReceivedRepresentingEmailAddress; _mod__ReceivedRepresentingEmailAddress = true; } // existing record and column is not modified
					else { if (value == _ori__ReceivedRepresentingEmailAddress) { _ori__ReceivedRepresentingEmailAddress = default(string); _mod__ReceivedRepresentingEmailAddress = false; } } // existing record and column is modified
				}
				_cur__ReceivedRepresentingEmailAddress = value; OnPropertyChanged("ReceivedRepresentingEmailAddress"); OnAfterPropertyChanged("ReceivedRepresentingEmailAddress");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Defines the routing that is used for the ReceivedRepresenting mailbox. The default is SMTP.
		/// </summary>
		public string ReceivedRepresentingRoutingType
		{
			get { return _cur__ReceivedRepresentingRoutingType; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ReceivedRepresentingRoutingType = true;
				if (_cur__ReceivedRepresentingRoutingType == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ReceivedRepresentingRoutingType == false) { _ori__ReceivedRepresentingRoutingType = _cur__ReceivedRepresentingRoutingType; _mod__ReceivedRepresentingRoutingType = true; } // existing record and column is not modified
					else { if (value == _ori__ReceivedRepresentingRoutingType) { _ori__ReceivedRepresentingRoutingType = default(string); _mod__ReceivedRepresentingRoutingType = false; } } // existing record and column is modified
				}
				_cur__ReceivedRepresentingRoutingType = value; OnPropertyChanged("ReceivedRepresentingRoutingType"); OnAfterPropertyChanged("ReceivedRepresentingRoutingType");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
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
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
		/// Contains the change key of an item or conversation.
		/// </summary>
		public string ConversationChangeKey
		{
			get { return _cur__ConversationChangeKey; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ConversationChangeKey = true;
				if (_cur__ConversationChangeKey == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ConversationChangeKey == false) { _ori__ConversationChangeKey = _cur__ConversationChangeKey; _mod__ConversationChangeKey = true; } // existing record and column is not modified
					else { if (value == _ori__ConversationChangeKey) { _ori__ConversationChangeKey = default(string); _mod__ConversationChangeKey = false; } } // existing record and column is modified
				}
				_cur__ConversationChangeKey = value; OnPropertyChanged("ConversationChangeKey"); OnAfterPropertyChanged("ConversationChangeKey");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
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
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Specifies the text of a reminder message.
		/// </summary>
		public string ReminderMessageData_Text
		{
			get { return _cur__ReminderMessageData_Text; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ReminderMessageData_Text = true;
				if (_cur__ReminderMessageData_Text == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ReminderMessageData_Text == false) { _ori__ReminderMessageData_Text = _cur__ReminderMessageData_Text; _mod__ReminderMessageData_Text = true; } // existing record and column is not modified
					else { if (value == _ori__ReminderMessageData_Text) { _ori__ReminderMessageData_Text = default(string); _mod__ReminderMessageData_Text = false; } } // existing record and column is modified
				}
				_cur__ReminderMessageData_Text = value; OnPropertyChanged("ReminderMessageData_Text"); OnAfterPropertyChanged("ReminderMessageData_Text");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Represents the location of a meeting, appointment, or persona.
		/// </summary>
		public string ReminderMessageData_Location
		{
			get { return _cur__ReminderMessageData_Location; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ReminderMessageData_Location = true;
				if (_cur__ReminderMessageData_Location == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ReminderMessageData_Location == false) { _ori__ReminderMessageData_Location = _cur__ReminderMessageData_Location; _mod__ReminderMessageData_Location = true; } // existing record and column is not modified
					else { if (value == _ori__ReminderMessageData_Location) { _ori__ReminderMessageData_Location = default(string); _mod__ReminderMessageData_Location = false; } } // existing record and column is modified
				}
				_cur__ReminderMessageData_Location = value; OnPropertyChanged("ReminderMessageData_Location"); OnAfterPropertyChanged("ReminderMessageData_Location");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Specifies the starting time of the item that the reminder is for.
		/// </summary>
		public DateTime? ReminderMessageData_StartTime
		{
			get { return _cur__ReminderMessageData_StartTime; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ReminderMessageData_StartTime = true;
				if (_cur__ReminderMessageData_StartTime == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ReminderMessageData_StartTime == false) { _ori__ReminderMessageData_StartTime = _cur__ReminderMessageData_StartTime; _mod__ReminderMessageData_StartTime = true; } // existing record and column is not modified
					else { if (value == _ori__ReminderMessageData_StartTime) { _ori__ReminderMessageData_StartTime = default(DateTime?); _mod__ReminderMessageData_StartTime = false; } } // existing record and column is modified
				}
				_cur__ReminderMessageData_StartTime = value; OnPropertyChanged("ReminderMessageData_StartTime"); OnAfterPropertyChanged("ReminderMessageData_StartTime");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[JunkEmail]. NotReadonly. AllowNull.
		/// Specifies the ending time of the item that the reminder is for.
		/// </summary>
		public DateTime? ReminderMessageData_EndTime
		{
			get { return _cur__ReminderMessageData_EndTime; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ReminderMessageData_EndTime = true;
				if (_cur__ReminderMessageData_EndTime == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ReminderMessageData_EndTime == false) { _ori__ReminderMessageData_EndTime = _cur__ReminderMessageData_EndTime; _mod__ReminderMessageData_EndTime = true; } // existing record and column is not modified
					else { if (value == _ori__ReminderMessageData_EndTime) { _ori__ReminderMessageData_EndTime = default(DateTime?); _mod__ReminderMessageData_EndTime = false; } } // existing record and column is modified
				}
				_cur__ReminderMessageData_EndTime = value; OnPropertyChanged("ReminderMessageData_EndTime"); OnAfterPropertyChanged("ReminderMessageData_EndTime");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[JunkEmail]. Readonly. AllowNull.
		/// Represents the calendar item that is associated with the ReminderMessageData.
		/// </summary>
		public string ReminderMessageData_AssociatedCalendarId
		{
			get { return _cur__ReminderMessageData_AssociatedCalendarId; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ReminderMessageData_AssociatedCalendarId = true;
				if (_cur__ReminderMessageData_AssociatedCalendarId == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ReminderMessageData_AssociatedCalendarId == false) { _ori__ReminderMessageData_AssociatedCalendarId = _cur__ReminderMessageData_AssociatedCalendarId; _mod__ReminderMessageData_AssociatedCalendarId = true; } // existing record and column is not modified
					else { if (value == _ori__ReminderMessageData_AssociatedCalendarId) { _ori__ReminderMessageData_AssociatedCalendarId = default(string); _mod__ReminderMessageData_AssociatedCalendarId = false; } } // existing record and column is modified
				}
				_cur__ReminderMessageData_AssociatedCalendarId = value; OnPropertyChanged("ReminderMessageData_AssociatedCalendarId"); OnAfterPropertyChanged("ReminderMessageData_AssociatedCalendarId");
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
			if (column_name == "AttachmentIds") return _mod__AttachmentIds;
			if (column_name == "AttachmentNames") return _mod__AttachmentNames;
			if (column_name == "DateTimeReceived") return _mod__DateTimeReceived;
			if (column_name == "Size") return _mod__Size;
			if (column_name == "Categories") return _mod__Categories;
			if (column_name == "Importance") return _mod__Importance;
			if (column_name == "InReplyTo") return _mod__InReplyTo;
			if (column_name == "IsSubmitted") return _mod__IsSubmitted;
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
			if (column_name == "SenderName") return _mod__SenderName;
			if (column_name == "SenderEmailAddress") return _mod__SenderEmailAddress;
			if (column_name == "SenderRoutingType") return _mod__SenderRoutingType;
			if (column_name == "ToRecipients_Name") return _mod__ToRecipients_Name;
			if (column_name == "ToRecipients_EmailAddress") return _mod__ToRecipients_EmailAddress;
			if (column_name == "ToRecipients_ItemId") return _mod__ToRecipients_ItemId;
			if (column_name == "CcRecipients_Name") return _mod__CcRecipients_Name;
			if (column_name == "CcRecipients_EmailAddress") return _mod__CcRecipients_EmailAddress;
			if (column_name == "CcRecipients_ItemId") return _mod__CcRecipients_ItemId;
			if (column_name == "BccRecipients_Name") return _mod__BccRecipients_Name;
			if (column_name == "BccRecipients_EmailAddress") return _mod__BccRecipients_EmailAddress;
			if (column_name == "BccRecipients_ItemId") return _mod__BccRecipients_ItemId;
			if (column_name == "IsReadReceiptRequested") return _mod__IsReadReceiptRequested;
			if (column_name == "IsDeliveryReceiptRequested") return _mod__IsDeliveryReceiptRequested;
			if (column_name == "ConversationIndex") return _mod__ConversationIndex;
			if (column_name == "ConversationTopic") return _mod__ConversationTopic;
			if (column_name == "FromName") return _mod__FromName;
			if (column_name == "FromEmailAddress") return _mod__FromEmailAddress;
			if (column_name == "FromRoutingType") return _mod__FromRoutingType;
			if (column_name == "InternetMessageId") return _mod__InternetMessageId;
			if (column_name == "IsRead") return _mod__IsRead;
			if (column_name == "IsResponseRequested") return _mod__IsResponseRequested;
			if (column_name == "References") return _mod__References;
			if (column_name == "EffectiveRights_CreateAssociated") return _mod__EffectiveRights_CreateAssociated;
			if (column_name == "EffectiveRights_CreateContents") return _mod__EffectiveRights_CreateContents;
			if (column_name == "EffectiveRights_CreateHierarchy") return _mod__EffectiveRights_CreateHierarchy;
			if (column_name == "EffectiveRights_Delete") return _mod__EffectiveRights_Delete;
			if (column_name == "EffectiveRights_Modify") return _mod__EffectiveRights_Modify;
			if (column_name == "EffectiveRights_Read") return _mod__EffectiveRights_Read;
			if (column_name == "EffectiveRights_ViewPrivateItems") return _mod__EffectiveRights_ViewPrivateItems;
			if (column_name == "ReceivedByName") return _mod__ReceivedByName;
			if (column_name == "ReceivedByEmailAddress") return _mod__ReceivedByEmailAddress;
			if (column_name == "ReceivedByRoutingType") return _mod__ReceivedByRoutingType;
			if (column_name == "ReceivedRepresentingName") return _mod__ReceivedRepresentingName;
			if (column_name == "ReceivedRepresentingEmailAddress") return _mod__ReceivedRepresentingEmailAddress;
			if (column_name == "ReceivedRepresentingRoutingType") return _mod__ReceivedRepresentingRoutingType;
			if (column_name == "LastModifiedName") return _mod__LastModifiedName;
			if (column_name == "LastModifiedTime") return _mod__LastModifiedTime;
			if (column_name == "IsAssociated") return _mod__IsAssociated;
			if (column_name == "WebClientReadFormQueryString") return _mod__WebClientReadFormQueryString;
			if (column_name == "WebClientEditFormQueryString") return _mod__WebClientEditFormQueryString;
			if (column_name == "ConversationId") return _mod__ConversationId;
			if (column_name == "ConversationChangeKey") return _mod__ConversationChangeKey;
			if (column_name == "UniqueBody") return _mod__UniqueBody;
			if (column_name == "UniqueBodyType") return _mod__UniqueBodyType;
			if (column_name == "ReminderMessageData_Text") return _mod__ReminderMessageData_Text;
			if (column_name == "ReminderMessageData_Location") return _mod__ReminderMessageData_Location;
			if (column_name == "ReminderMessageData_StartTime") return _mod__ReminderMessageData_StartTime;
			if (column_name == "ReminderMessageData_EndTime") return _mod__ReminderMessageData_EndTime;
			if (column_name == "ReminderMessageData_AssociatedCalendarId") return _mod__ReminderMessageData_AssociatedCalendarId;
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
			if (_mod__AttachmentIds == true) count++;
			if (_mod__AttachmentNames == true) count++;
			if (_mod__DateTimeReceived == true) count++;
			if (_mod__Size == true) count++;
			if (_mod__Categories == true) count++;
			if (_mod__Importance == true) count++;
			if (_mod__InReplyTo == true) count++;
			if (_mod__IsSubmitted == true) count++;
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
			if (_mod__SenderName == true) count++;
			if (_mod__SenderEmailAddress == true) count++;
			if (_mod__SenderRoutingType == true) count++;
			if (_mod__ToRecipients_Name == true) count++;
			if (_mod__ToRecipients_EmailAddress == true) count++;
			if (_mod__ToRecipients_ItemId == true) count++;
			if (_mod__CcRecipients_Name == true) count++;
			if (_mod__CcRecipients_EmailAddress == true) count++;
			if (_mod__CcRecipients_ItemId == true) count++;
			if (_mod__BccRecipients_Name == true) count++;
			if (_mod__BccRecipients_EmailAddress == true) count++;
			if (_mod__BccRecipients_ItemId == true) count++;
			if (_mod__IsReadReceiptRequested == true) count++;
			if (_mod__IsDeliveryReceiptRequested == true) count++;
			if (_mod__ConversationIndex == true) count++;
			if (_mod__ConversationTopic == true) count++;
			if (_mod__FromName == true) count++;
			if (_mod__FromEmailAddress == true) count++;
			if (_mod__FromRoutingType == true) count++;
			if (_mod__InternetMessageId == true) count++;
			if (_mod__IsRead == true) count++;
			if (_mod__IsResponseRequested == true) count++;
			if (_mod__References == true) count++;
			if (_mod__EffectiveRights_CreateAssociated == true) count++;
			if (_mod__EffectiveRights_CreateContents == true) count++;
			if (_mod__EffectiveRights_CreateHierarchy == true) count++;
			if (_mod__EffectiveRights_Delete == true) count++;
			if (_mod__EffectiveRights_Modify == true) count++;
			if (_mod__EffectiveRights_Read == true) count++;
			if (_mod__EffectiveRights_ViewPrivateItems == true) count++;
			if (_mod__ReceivedByName == true) count++;
			if (_mod__ReceivedByEmailAddress == true) count++;
			if (_mod__ReceivedByRoutingType == true) count++;
			if (_mod__ReceivedRepresentingName == true) count++;
			if (_mod__ReceivedRepresentingEmailAddress == true) count++;
			if (_mod__ReceivedRepresentingRoutingType == true) count++;
			if (_mod__LastModifiedName == true) count++;
			if (_mod__LastModifiedTime == true) count++;
			if (_mod__IsAssociated == true) count++;
			if (_mod__WebClientReadFormQueryString == true) count++;
			if (_mod__WebClientEditFormQueryString == true) count++;
			if (_mod__ConversationId == true) count++;
			if (_mod__ConversationChangeKey == true) count++;
			if (_mod__UniqueBody == true) count++;
			if (_mod__UniqueBodyType == true) count++;
			if (_mod__ReminderMessageData_Text == true) count++;
			if (_mod__ReminderMessageData_Location == true) count++;
			if (_mod__ReminderMessageData_StartTime == true) count++;
			if (_mod__ReminderMessageData_EndTime == true) count++;
			if (_mod__ReminderMessageData_AssociatedCalendarId == true) count++;
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
			if (_mod__InReplyTo == true) count++;
			if (_mod__ReminderDueBy == true) count++;
			if (_mod__ReminderIsSet == true) count++;
			if (_mod__ReminderMinutesBeforeStart == true) count++;
			if (_mod__Culture == true) count++;
			if (_mod__SenderName == true) count++;
			if (_mod__SenderEmailAddress == true) count++;
			if (_mod__SenderRoutingType == true) count++;
			if (_mod__ToRecipients_Name == true) count++;
			if (_mod__ToRecipients_EmailAddress == true) count++;
			if (_mod__ToRecipients_ItemId == true) count++;
			if (_mod__CcRecipients_Name == true) count++;
			if (_mod__CcRecipients_EmailAddress == true) count++;
			if (_mod__CcRecipients_ItemId == true) count++;
			if (_mod__BccRecipients_Name == true) count++;
			if (_mod__BccRecipients_EmailAddress == true) count++;
			if (_mod__BccRecipients_ItemId == true) count++;
			if (_mod__IsReadReceiptRequested == true) count++;
			if (_mod__IsDeliveryReceiptRequested == true) count++;
			if (_mod__ConversationIndex == true) count++;
			if (_mod__ConversationTopic == true) count++;
			if (_mod__FromName == true) count++;
			if (_mod__FromEmailAddress == true) count++;
			if (_mod__FromRoutingType == true) count++;
			if (_mod__InternetMessageId == true) count++;
			if (_mod__IsRead == true) count++;
			if (_mod__IsResponseRequested == true) count++;
			if (_mod__References == true) count++;
			if (_mod__ReceivedByName == true) count++;
			if (_mod__ReceivedByEmailAddress == true) count++;
			if (_mod__ReceivedByRoutingType == true) count++;
			if (_mod__ReceivedRepresentingName == true) count++;
			if (_mod__ReceivedRepresentingEmailAddress == true) count++;
			if (_mod__ReceivedRepresentingRoutingType == true) count++;
			if (_mod__IsAssociated == true) count++;
			if (_mod__ReminderMessageData_Text == true) count++;
			if (_mod__ReminderMessageData_Location == true) count++;
			if (_mod__ReminderMessageData_StartTime == true) count++;
			if (_mod__ReminderMessageData_EndTime == true) count++;
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
				if (_cur__Categories != null) track_array.AppendDataValue(13, _cur__Categories);
				if (_cur__Importance != null) track_array.AppendDataValue(14, _cur__Importance);
				if (_cur__InReplyTo != null) track_array.AppendDataValue(15, _cur__InReplyTo);
				if (_cur__ReminderDueBy != null) track_array.AppendDataValue(24, _cur__ReminderDueBy);
				if (_cur__ReminderIsSet != null) track_array.AppendDataValue(25, _cur__ReminderIsSet);
				if (_cur__ReminderMinutesBeforeStart != null) track_array.AppendDataValue(26, _cur__ReminderMinutesBeforeStart);
				if (_cur__Culture != null) track_array.AppendDataValue(30, _cur__Culture);
				if (_cur__SenderName != null) track_array.AppendDataValue(31, _cur__SenderName);
				if (_cur__SenderEmailAddress != null) track_array.AppendDataValue(32, _cur__SenderEmailAddress);
				if (_cur__SenderRoutingType != null) track_array.AppendDataValue(33, _cur__SenderRoutingType);
				if (_cur__ToRecipients_Name != null) track_array.AppendDataValue(34, _cur__ToRecipients_Name);
				if (_cur__ToRecipients_EmailAddress != null) track_array.AppendDataValue(35, _cur__ToRecipients_EmailAddress);
				if (_cur__ToRecipients_ItemId != null) track_array.AppendDataValue(36, _cur__ToRecipients_ItemId);
				if (_cur__CcRecipients_Name != null) track_array.AppendDataValue(37, _cur__CcRecipients_Name);
				if (_cur__CcRecipients_EmailAddress != null) track_array.AppendDataValue(38, _cur__CcRecipients_EmailAddress);
				if (_cur__CcRecipients_ItemId != null) track_array.AppendDataValue(39, _cur__CcRecipients_ItemId);
				if (_cur__BccRecipients_Name != null) track_array.AppendDataValue(40, _cur__BccRecipients_Name);
				if (_cur__BccRecipients_EmailAddress != null) track_array.AppendDataValue(41, _cur__BccRecipients_EmailAddress);
				if (_cur__BccRecipients_ItemId != null) track_array.AppendDataValue(42, _cur__BccRecipients_ItemId);
				if (_cur__IsReadReceiptRequested != null) track_array.AppendDataValue(43, _cur__IsReadReceiptRequested);
				if (_cur__IsDeliveryReceiptRequested != null) track_array.AppendDataValue(44, _cur__IsDeliveryReceiptRequested);
				if (_cur__ConversationIndex != null) track_array.AppendDataValue(45, _cur__ConversationIndex);
				if (_cur__ConversationTopic != null) track_array.AppendDataValue(46, _cur__ConversationTopic);
				if (_cur__FromName != null) track_array.AppendDataValue(47, _cur__FromName);
				if (_cur__FromEmailAddress != null) track_array.AppendDataValue(48, _cur__FromEmailAddress);
				if (_cur__FromRoutingType != null) track_array.AppendDataValue(49, _cur__FromRoutingType);
				if (_cur__InternetMessageId != null) track_array.AppendDataValue(50, _cur__InternetMessageId);
				if (_cur__IsRead != null) track_array.AppendDataValue(51, _cur__IsRead);
				if (_cur__IsResponseRequested != null) track_array.AppendDataValue(52, _cur__IsResponseRequested);
				if (_cur__References != null) track_array.AppendDataValue(53, _cur__References);
				if (_cur__ReceivedByName != null) track_array.AppendDataValue(61, _cur__ReceivedByName);
				if (_cur__ReceivedByEmailAddress != null) track_array.AppendDataValue(62, _cur__ReceivedByEmailAddress);
				if (_cur__ReceivedByRoutingType != null) track_array.AppendDataValue(63, _cur__ReceivedByRoutingType);
				if (_cur__ReceivedRepresentingName != null) track_array.AppendDataValue(64, _cur__ReceivedRepresentingName);
				if (_cur__ReceivedRepresentingEmailAddress != null) track_array.AppendDataValue(65, _cur__ReceivedRepresentingEmailAddress);
				if (_cur__ReceivedRepresentingRoutingType != null) track_array.AppendDataValue(66, _cur__ReceivedRepresentingRoutingType);
				if (_cur__IsAssociated != null) track_array.AppendDataValue(69, _cur__IsAssociated);
				if (_cur__ReminderMessageData_Text != null) track_array.AppendDataValue(76, _cur__ReminderMessageData_Text);
				if (_cur__ReminderMessageData_Location != null) track_array.AppendDataValue(77, _cur__ReminderMessageData_Location);
				if (_cur__ReminderMessageData_StartTime != null) track_array.AppendDataValue(78, _cur__ReminderMessageData_StartTime);
				if (_cur__ReminderMessageData_EndTime != null) track_array.AppendDataValue(79, _cur__ReminderMessageData_EndTime);
			}
			else if (_recordstatus == DataRecordStatus.Existing)
			{
				if (_mod__ParentFolderId) track_array.AppendDataValue(3, _cur__ParentFolderId);
				if (_mod__ItemClass) track_array.AppendDataValue(5, _cur__ItemClass);
				if (_mod__Subject) track_array.AppendDataValue(6, _cur__Subject);
				if (_mod__Body) track_array.AppendDataValue(8, _cur__Body);
				if (_mod__Categories) track_array.AppendDataValue(13, _cur__Categories);
				if (_mod__Importance) track_array.AppendDataValue(14, _cur__Importance);
				if (_mod__InReplyTo) track_array.AppendDataValue(15, _cur__InReplyTo);
				if (_mod__ReminderDueBy) track_array.AppendDataValue(24, _cur__ReminderDueBy);
				if (_mod__ReminderIsSet) track_array.AppendDataValue(25, _cur__ReminderIsSet);
				if (_mod__ReminderMinutesBeforeStart) track_array.AppendDataValue(26, _cur__ReminderMinutesBeforeStart);
				if (_mod__Culture) track_array.AppendDataValue(30, _cur__Culture);
				if (_mod__SenderName) track_array.AppendDataValue(31, _cur__SenderName);
				if (_mod__SenderEmailAddress) track_array.AppendDataValue(32, _cur__SenderEmailAddress);
				if (_mod__SenderRoutingType) track_array.AppendDataValue(33, _cur__SenderRoutingType);
				if (_mod__ToRecipients_Name) track_array.AppendDataValue(34, _cur__ToRecipients_Name);
				if (_mod__ToRecipients_EmailAddress) track_array.AppendDataValue(35, _cur__ToRecipients_EmailAddress);
				if (_mod__ToRecipients_ItemId) track_array.AppendDataValue(36, _cur__ToRecipients_ItemId);
				if (_mod__CcRecipients_Name) track_array.AppendDataValue(37, _cur__CcRecipients_Name);
				if (_mod__CcRecipients_EmailAddress) track_array.AppendDataValue(38, _cur__CcRecipients_EmailAddress);
				if (_mod__CcRecipients_ItemId) track_array.AppendDataValue(39, _cur__CcRecipients_ItemId);
				if (_mod__BccRecipients_Name) track_array.AppendDataValue(40, _cur__BccRecipients_Name);
				if (_mod__BccRecipients_EmailAddress) track_array.AppendDataValue(41, _cur__BccRecipients_EmailAddress);
				if (_mod__BccRecipients_ItemId) track_array.AppendDataValue(42, _cur__BccRecipients_ItemId);
				if (_mod__IsReadReceiptRequested) track_array.AppendDataValue(43, _cur__IsReadReceiptRequested);
				if (_mod__IsDeliveryReceiptRequested) track_array.AppendDataValue(44, _cur__IsDeliveryReceiptRequested);
				if (_mod__ConversationIndex) track_array.AppendDataValue(45, _cur__ConversationIndex);
				if (_mod__ConversationTopic) track_array.AppendDataValue(46, _cur__ConversationTopic);
				if (_mod__FromName) track_array.AppendDataValue(47, _cur__FromName);
				if (_mod__FromEmailAddress) track_array.AppendDataValue(48, _cur__FromEmailAddress);
				if (_mod__FromRoutingType) track_array.AppendDataValue(49, _cur__FromRoutingType);
				if (_mod__InternetMessageId) track_array.AppendDataValue(50, _cur__InternetMessageId);
				if (_mod__IsRead) track_array.AppendDataValue(51, _cur__IsRead);
				if (_mod__IsResponseRequested) track_array.AppendDataValue(52, _cur__IsResponseRequested);
				if (_mod__References) track_array.AppendDataValue(53, _cur__References);
				if (_mod__ReceivedByName) track_array.AppendDataValue(61, _cur__ReceivedByName);
				if (_mod__ReceivedByEmailAddress) track_array.AppendDataValue(62, _cur__ReceivedByEmailAddress);
				if (_mod__ReceivedByRoutingType) track_array.AppendDataValue(63, _cur__ReceivedByRoutingType);
				if (_mod__ReceivedRepresentingName) track_array.AppendDataValue(64, _cur__ReceivedRepresentingName);
				if (_mod__ReceivedRepresentingEmailAddress) track_array.AppendDataValue(65, _cur__ReceivedRepresentingEmailAddress);
				if (_mod__ReceivedRepresentingRoutingType) track_array.AppendDataValue(66, _cur__ReceivedRepresentingRoutingType);
				if (_mod__IsAssociated) track_array.AppendDataValue(69, _cur__IsAssociated);
				if (_mod__ReminderMessageData_Text) track_array.AppendDataValue(76, _cur__ReminderMessageData_Text);
				if (_mod__ReminderMessageData_Location) track_array.AppendDataValue(77, _cur__ReminderMessageData_Location);
				if (_mod__ReminderMessageData_StartTime) track_array.AppendDataValue(78, _cur__ReminderMessageData_StartTime);
				if (_mod__ReminderMessageData_EndTime) track_array.AppendDataValue(79, _cur__ReminderMessageData_EndTime);
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
				if (_mod__AttachmentIds) _ori__AttachmentIds = default(string);
				if (_mod__AttachmentNames) _ori__AttachmentNames = default(string);
				if (_mod__DateTimeReceived) _ori__DateTimeReceived = default(DateTime?);
				if (_mod__Size) _ori__Size = default(int?);
				if (_mod__Categories) _ori__Categories = default(string);
				if (_mod__Importance) _ori__Importance = default(string);
				if (_mod__InReplyTo) _ori__InReplyTo = default(string);
				if (_mod__IsSubmitted) _ori__IsSubmitted = default(bool?);
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
				if (_mod__SenderName) _ori__SenderName = default(string);
				if (_mod__SenderEmailAddress) _ori__SenderEmailAddress = default(string);
				if (_mod__SenderRoutingType) _ori__SenderRoutingType = default(string);
				if (_mod__ToRecipients_Name) _ori__ToRecipients_Name = default(string);
				if (_mod__ToRecipients_EmailAddress) _ori__ToRecipients_EmailAddress = default(string);
				if (_mod__ToRecipients_ItemId) _ori__ToRecipients_ItemId = default(string);
				if (_mod__CcRecipients_Name) _ori__CcRecipients_Name = default(string);
				if (_mod__CcRecipients_EmailAddress) _ori__CcRecipients_EmailAddress = default(string);
				if (_mod__CcRecipients_ItemId) _ori__CcRecipients_ItemId = default(string);
				if (_mod__BccRecipients_Name) _ori__BccRecipients_Name = default(string);
				if (_mod__BccRecipients_EmailAddress) _ori__BccRecipients_EmailAddress = default(string);
				if (_mod__BccRecipients_ItemId) _ori__BccRecipients_ItemId = default(string);
				if (_mod__IsReadReceiptRequested) _ori__IsReadReceiptRequested = default(bool?);
				if (_mod__IsDeliveryReceiptRequested) _ori__IsDeliveryReceiptRequested = default(bool?);
				if (_mod__ConversationIndex) _ori__ConversationIndex = default(string);
				if (_mod__ConversationTopic) _ori__ConversationTopic = default(string);
				if (_mod__FromName) _ori__FromName = default(string);
				if (_mod__FromEmailAddress) _ori__FromEmailAddress = default(string);
				if (_mod__FromRoutingType) _ori__FromRoutingType = default(string);
				if (_mod__InternetMessageId) _ori__InternetMessageId = default(string);
				if (_mod__IsRead) _ori__IsRead = default(bool?);
				if (_mod__IsResponseRequested) _ori__IsResponseRequested = default(bool?);
				if (_mod__References) _ori__References = default(string);
				if (_mod__EffectiveRights_CreateAssociated) _ori__EffectiveRights_CreateAssociated = default(bool?);
				if (_mod__EffectiveRights_CreateContents) _ori__EffectiveRights_CreateContents = default(bool?);
				if (_mod__EffectiveRights_CreateHierarchy) _ori__EffectiveRights_CreateHierarchy = default(bool?);
				if (_mod__EffectiveRights_Delete) _ori__EffectiveRights_Delete = default(bool?);
				if (_mod__EffectiveRights_Modify) _ori__EffectiveRights_Modify = default(bool?);
				if (_mod__EffectiveRights_Read) _ori__EffectiveRights_Read = default(bool?);
				if (_mod__EffectiveRights_ViewPrivateItems) _ori__EffectiveRights_ViewPrivateItems = default(bool?);
				if (_mod__ReceivedByName) _ori__ReceivedByName = default(string);
				if (_mod__ReceivedByEmailAddress) _ori__ReceivedByEmailAddress = default(string);
				if (_mod__ReceivedByRoutingType) _ori__ReceivedByRoutingType = default(string);
				if (_mod__ReceivedRepresentingName) _ori__ReceivedRepresentingName = default(string);
				if (_mod__ReceivedRepresentingEmailAddress) _ori__ReceivedRepresentingEmailAddress = default(string);
				if (_mod__ReceivedRepresentingRoutingType) _ori__ReceivedRepresentingRoutingType = default(string);
				if (_mod__LastModifiedName) _ori__LastModifiedName = default(string);
				if (_mod__LastModifiedTime) _ori__LastModifiedTime = default(DateTime?);
				if (_mod__IsAssociated) _ori__IsAssociated = default(bool?);
				if (_mod__WebClientReadFormQueryString) _ori__WebClientReadFormQueryString = default(string);
				if (_mod__WebClientEditFormQueryString) _ori__WebClientEditFormQueryString = default(string);
				if (_mod__ConversationId) _ori__ConversationId = default(string);
				if (_mod__ConversationChangeKey) _ori__ConversationChangeKey = default(string);
				if (_mod__UniqueBody) _ori__UniqueBody = default(string);
				if (_mod__UniqueBodyType) _ori__UniqueBodyType = default(string);
				if (_mod__ReminderMessageData_Text) _ori__ReminderMessageData_Text = default(string);
				if (_mod__ReminderMessageData_Location) _ori__ReminderMessageData_Location = default(string);
				if (_mod__ReminderMessageData_StartTime) _ori__ReminderMessageData_StartTime = default(DateTime?);
				if (_mod__ReminderMessageData_EndTime) _ori__ReminderMessageData_EndTime = default(DateTime?);
				if (_mod__ReminderMessageData_AssociatedCalendarId) _ori__ReminderMessageData_AssociatedCalendarId = default(string);
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
			_mod__AttachmentIds = false;
			_mod__AttachmentNames = false;
			_mod__DateTimeReceived = false;
			_mod__Size = false;
			_mod__Categories = false;
			_mod__Importance = false;
			_mod__InReplyTo = false;
			_mod__IsSubmitted = false;
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
			_mod__SenderName = false;
			_mod__SenderEmailAddress = false;
			_mod__SenderRoutingType = false;
			_mod__ToRecipients_Name = false;
			_mod__ToRecipients_EmailAddress = false;
			_mod__ToRecipients_ItemId = false;
			_mod__CcRecipients_Name = false;
			_mod__CcRecipients_EmailAddress = false;
			_mod__CcRecipients_ItemId = false;
			_mod__BccRecipients_Name = false;
			_mod__BccRecipients_EmailAddress = false;
			_mod__BccRecipients_ItemId = false;
			_mod__IsReadReceiptRequested = false;
			_mod__IsDeliveryReceiptRequested = false;
			_mod__ConversationIndex = false;
			_mod__ConversationTopic = false;
			_mod__FromName = false;
			_mod__FromEmailAddress = false;
			_mod__FromRoutingType = false;
			_mod__InternetMessageId = false;
			_mod__IsRead = false;
			_mod__IsResponseRequested = false;
			_mod__References = false;
			_mod__EffectiveRights_CreateAssociated = false;
			_mod__EffectiveRights_CreateContents = false;
			_mod__EffectiveRights_CreateHierarchy = false;
			_mod__EffectiveRights_Delete = false;
			_mod__EffectiveRights_Modify = false;
			_mod__EffectiveRights_Read = false;
			_mod__EffectiveRights_ViewPrivateItems = false;
			_mod__ReceivedByName = false;
			_mod__ReceivedByEmailAddress = false;
			_mod__ReceivedByRoutingType = false;
			_mod__ReceivedRepresentingName = false;
			_mod__ReceivedRepresentingEmailAddress = false;
			_mod__ReceivedRepresentingRoutingType = false;
			_mod__LastModifiedName = false;
			_mod__LastModifiedTime = false;
			_mod__IsAssociated = false;
			_mod__WebClientReadFormQueryString = false;
			_mod__WebClientEditFormQueryString = false;
			_mod__ConversationId = false;
			_mod__ConversationChangeKey = false;
			_mod__UniqueBody = false;
			_mod__UniqueBodyType = false;
			_mod__ReminderMessageData_Text = false;
			_mod__ReminderMessageData_Location = false;
			_mod__ReminderMessageData_StartTime = false;
			_mod__ReminderMessageData_EndTime = false;
			_mod__ReminderMessageData_AssociatedCalendarId = false;
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
	public partial class GetAll_JunkEmail_Record
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
