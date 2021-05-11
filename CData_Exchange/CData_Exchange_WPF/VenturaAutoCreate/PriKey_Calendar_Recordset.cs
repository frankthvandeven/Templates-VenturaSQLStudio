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
	/// The updateable table is [Exchange].[Calendar]. Updateable table column information:
	/// • 99 out of 99 table columns are present in the resultset.
	/// • All primary key columns are present in the resultset: ItemId.
	/// • Non-primary key columns present in the resultset: MimeContent, ItemChangeKey, ParentFolderId, ParentFolderChangeKey,
	///   ItemClass, Subject, Sensitivity, Body, DateTimeReceived, Size, Categories, Importance, InReplyTo, IsSubmitted, IsDraft,
	///   IsFromMe, IsResend, IsUnmodified, InternetMessageHeaders, DateTimeSent, DateTimeCreated, ReminderDueBy, ReminderIsSet,
	///   ReminderMinutesBeforeStart, DisplayCc, DisplayTo, HasAttachments, Culture, Start, End, OriginalStart, IsAllDayEvent,
	///   LegacyFreeBusyStatus, Location, When, IsMeeting, IsCancelled, IsRecurring, MeetingRequestWasSent, IsResponseRequested,
	///   CalendarItemType, MyResponseType, OrganizerName, OrganizerEmailAddress, OrganizerRoutingType, ConflictingMeetingCount,
	///   AdjacentMeetingCount, Duration, TimeZone, AppointmentReplyTime, AppointmentSequenceNumber, AppointmentState,
	///   Recurrence_Type, Recurrence_DaysOfWeek, Recurrence_DayOfWeekIndex, Recurrence_Month, Recurrence_DayOfMonth,
	///   Recurrence_Interval, Recurrence_FirstDayOfWeek, Recurrence_Duration, Recurrence_StartDate, Recurrence_EndDate,
	///   Recurrence_NumberOfOccurrences, FirstOccurrence_ItemId, FirstOccurrence_Start, FirstOccurrence_End,
	///   FirstOccurrence_OriginalStart, LastOccurrence_ItemId, LastOccurrence_Start, LastOccurrence_End,
	///   LastOccurrence_OriginalStart, ModifiedOccurrences_Aggregate, DeletedOccurrences_Aggregate, StartTimeZone_Id,
	///   StartTimeZone_Name, EndTimeZone_Id, EndTimeZone_Name, ConferenceType, AllowNewTimeProposal, IsOnlineMeeting,
	///   MeetingWorkspaceUrl, NetShowUrl, EffectiveRights_CreateAssociated, EffectiveRights_CreateContents,
	///   EffectiveRights_CreateHierarchy, EffectiveRights_Delete, EffectiveRights_Modify, EffectiveRights_Read,
	///   EffectiveRights_ViewPrivateItems, LastModifiedName, LastModifiedTime, IsAssociated, WebClientReadFormQueryString,
	///   WebClientEditFormQueryString, ConversationId, ConversationChangeKey, UniqueBody and UniqueBodyType.
	/// Recordset item automatically created by Ventura SQL Studio.
	/// </summary>
	public partial class PriKey_Calendar_Recordset : ResultsetObservable<PriKey_Calendar_Recordset, PriKey_Calendar_Record>, IRecordsetBase
	{
		private IResultsetBase[] _resultsets;
		private string _sqlscript;
		private object[] _inputparametervalues;
		private InputParamHolder _inputparamholder;
		private VenturaSchema _parameterschema;
		private int _rowlimit = 500;
		private const string CRLF = "\r\n";

		public PriKey_Calendar_Recordset()
		{
			_resultsets = new IResultsetBase[] { this };

			_sqlscript = @"SELECT [ItemId],[MimeContent],[ItemChangeKey],[ParentFolderId],[ParentFolderChangeKey],[ItemClass],[Subject],[Sensitivity],[Body],[DateTimeReceived],[Size]," + CRLF +
			             @"[Categories],[Importance],[InReplyTo],[IsSubmitted],[IsDraft],[IsFromMe],[IsResend],[IsUnmodified],[InternetMessageHeaders],[DateTimeSent],[DateTimeCreated]," + CRLF +
			             @"[ReminderDueBy],[ReminderIsSet],[ReminderMinutesBeforeStart],[DisplayCc],[DisplayTo],[HasAttachments],[Culture],[Start],[End],[OriginalStart],[IsAllDayEvent]," + CRLF +
			             @"[LegacyFreeBusyStatus],[Location],[When],[IsMeeting],[IsCancelled],[IsRecurring],[MeetingRequestWasSent],[IsResponseRequested],[CalendarItemType],[MyResponseType]," + CRLF +
			             @"[OrganizerName],[OrganizerEmailAddress],[OrganizerRoutingType],[ConflictingMeetingCount],[AdjacentMeetingCount],[Duration],[TimeZone],[AppointmentReplyTime]," + CRLF +
			             @"[AppointmentSequenceNumber],[AppointmentState],[Recurrence_Type],[Recurrence_DaysOfWeek],[Recurrence_DayOfWeekIndex],[Recurrence_Month],[Recurrence_DayOfMonth]," + CRLF +
			             @"[Recurrence_Interval],[Recurrence_FirstDayOfWeek],[Recurrence_Duration],[Recurrence_StartDate],[Recurrence_EndDate],[Recurrence_NumberOfOccurrences]," + CRLF +
			             @"[FirstOccurrence_ItemId],[FirstOccurrence_Start],[FirstOccurrence_End],[FirstOccurrence_OriginalStart],[LastOccurrence_ItemId],[LastOccurrence_Start]," + CRLF +
			             @"[LastOccurrence_End],[LastOccurrence_OriginalStart],[ModifiedOccurrences_Aggregate],[DeletedOccurrences_Aggregate],[StartTimeZone_Id],[StartTimeZone_Name]," + CRLF +
			             @"[EndTimeZone_Id],[EndTimeZone_Name],[ConferenceType],[AllowNewTimeProposal],[IsOnlineMeeting],[MeetingWorkspaceUrl],[NetShowUrl],[EffectiveRights_CreateAssociated]," + CRLF +
			             @"[EffectiveRights_CreateContents],[EffectiveRights_CreateHierarchy],[EffectiveRights_Delete],[EffectiveRights_Modify],[EffectiveRights_Read],[EffectiveRights_ViewPrivateItems]," + CRLF +
			             @"[LastModifiedName],[LastModifiedTime],[IsAssociated],[WebClientReadFormQueryString],[WebClientEditFormQueryString],[ConversationId],[ConversationChangeKey]," + CRLF +
			             @"[UniqueBody],[UniqueBodyType]" + CRLF +
			             @"FROM [Exchange].[Calendar]" + CRLF +
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
				BaseTableName = "Calendar",
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
				BaseTableName = "Calendar",
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
				BaseTableName = "Calendar",
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
				BaseTableName = "Calendar",
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
				BaseTableName = "Calendar",
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
				BaseTableName = "Calendar",
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
				BaseTableName = "Calendar",
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
				BaseTableName = "Calendar",
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
				BaseTableName = "Calendar",
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
				BaseTableName = "Calendar",
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
				BaseTableName = "Calendar",
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
				BaseTableName = "Calendar",
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
				BaseTableName = "Calendar",
				BaseColumnName = "Importance"
			});

			schema_array.Add(new VenturaColumn("InReplyTo", typeof(string), true)
			{
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Calendar",
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
				BaseTableName = "Calendar",
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
				BaseTableName = "Calendar",
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
				BaseTableName = "Calendar",
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
				BaseTableName = "Calendar",
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
				BaseTableName = "Calendar",
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
				BaseTableName = "Calendar",
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
				BaseTableName = "Calendar",
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
				BaseTableName = "Calendar",
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
				BaseTableName = "Calendar",
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
				BaseTableName = "Calendar",
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
				BaseTableName = "Calendar",
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
				BaseTableName = "Calendar",
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
				BaseTableName = "Calendar",
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
				BaseTableName = "Calendar",
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
				BaseTableName = "Calendar",
				BaseColumnName = "Culture"
			});

			schema_array.Add(new VenturaColumn("Start", typeof(DateTime), true)
			{
				Updateable = true,
				ColumnSize = 16,
				NumericPrecision = 8,
				NumericScale = 0,
				ProviderType = 6,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Calendar",
				BaseColumnName = "Start"
			});

			schema_array.Add(new VenturaColumn("End", typeof(DateTime), true)
			{
				Updateable = true,
				ColumnSize = 16,
				NumericPrecision = 8,
				NumericScale = 0,
				ProviderType = 6,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Calendar",
				BaseColumnName = "End"
			});

			schema_array.Add(new VenturaColumn("OriginalStart", typeof(DateTime), true)
			{
				Updateable = true,
				ColumnSize = 16,
				NumericPrecision = 8,
				NumericScale = 0,
				ProviderType = 6,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Calendar",
				BaseColumnName = "OriginalStart"
			});

			schema_array.Add(new VenturaColumn("IsAllDayEvent", typeof(bool), true)
			{
				Updateable = true,
				ColumnSize = 1,
				NumericPrecision = 1,
				NumericScale = 0,
				ProviderType = 3,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Calendar",
				BaseColumnName = "IsAllDayEvent"
			});

			schema_array.Add(new VenturaColumn("LegacyFreeBusyStatus", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Calendar",
				BaseColumnName = "LegacyFreeBusyStatus"
			});

			schema_array.Add(new VenturaColumn("Location", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Calendar",
				BaseColumnName = "Location"
			});

			schema_array.Add(new VenturaColumn("When", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Calendar",
				BaseColumnName = "When"
			});

			schema_array.Add(new VenturaColumn("IsMeeting", typeof(bool), true)
			{
				Updateable = true,
				ColumnSize = 1,
				NumericPrecision = 1,
				NumericScale = 0,
				ProviderType = 3,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Calendar",
				BaseColumnName = "IsMeeting"
			});

			schema_array.Add(new VenturaColumn("IsCancelled", typeof(bool), true)
			{
				Updateable = true,
				ColumnSize = 1,
				NumericPrecision = 1,
				NumericScale = 0,
				ProviderType = 3,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Calendar",
				BaseColumnName = "IsCancelled"
			});

			schema_array.Add(new VenturaColumn("IsRecurring", typeof(bool), true)
			{
				ColumnSize = 1,
				NumericPrecision = 1,
				NumericScale = 0,
				ProviderType = 3,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Calendar",
				BaseColumnName = "IsRecurring"
			});

			schema_array.Add(new VenturaColumn("MeetingRequestWasSent", typeof(bool), true)
			{
				ColumnSize = 1,
				NumericPrecision = 1,
				NumericScale = 0,
				ProviderType = 3,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Calendar",
				BaseColumnName = "MeetingRequestWasSent"
			});

			schema_array.Add(new VenturaColumn("IsResponseRequested", typeof(bool), true)
			{
				ColumnSize = 1,
				NumericPrecision = 1,
				NumericScale = 0,
				ProviderType = 3,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Calendar",
				BaseColumnName = "IsResponseRequested"
			});

			schema_array.Add(new VenturaColumn("CalendarItemType", typeof(string), true)
			{
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Calendar",
				BaseColumnName = "CalendarItemType"
			});

			schema_array.Add(new VenturaColumn("MyResponseType", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Calendar",
				BaseColumnName = "MyResponseType"
			});

			schema_array.Add(new VenturaColumn("OrganizerName", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Calendar",
				BaseColumnName = "OrganizerName"
			});

			schema_array.Add(new VenturaColumn("OrganizerEmailAddress", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Calendar",
				BaseColumnName = "OrganizerEmailAddress"
			});

			schema_array.Add(new VenturaColumn("OrganizerRoutingType", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Calendar",
				BaseColumnName = "OrganizerRoutingType"
			});

			schema_array.Add(new VenturaColumn("ConflictingMeetingCount", typeof(int), true)
			{
				ColumnSize = 11,
				NumericPrecision = 10,
				NumericScale = 0,
				ProviderType = 11,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Calendar",
				BaseColumnName = "ConflictingMeetingCount"
			});

			schema_array.Add(new VenturaColumn("AdjacentMeetingCount", typeof(int), true)
			{
				ColumnSize = 11,
				NumericPrecision = 10,
				NumericScale = 0,
				ProviderType = 11,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Calendar",
				BaseColumnName = "AdjacentMeetingCount"
			});

			schema_array.Add(new VenturaColumn("Duration", typeof(string), true)
			{
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Calendar",
				BaseColumnName = "Duration"
			});

			schema_array.Add(new VenturaColumn("TimeZone", typeof(string), true)
			{
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Calendar",
				BaseColumnName = "TimeZone"
			});

			schema_array.Add(new VenturaColumn("AppointmentReplyTime", typeof(DateTime), true)
			{
				Updateable = true,
				ColumnSize = 16,
				NumericPrecision = 8,
				NumericScale = 0,
				ProviderType = 6,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Calendar",
				BaseColumnName = "AppointmentReplyTime"
			});

			schema_array.Add(new VenturaColumn("AppointmentSequenceNumber", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Calendar",
				BaseColumnName = "AppointmentSequenceNumber"
			});

			schema_array.Add(new VenturaColumn("AppointmentState", typeof(string), true)
			{
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Calendar",
				BaseColumnName = "AppointmentState"
			});

			schema_array.Add(new VenturaColumn("Recurrence_Type", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Calendar",
				BaseColumnName = "Recurrence_Type"
			});

			schema_array.Add(new VenturaColumn("Recurrence_DaysOfWeek", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Calendar",
				BaseColumnName = "Recurrence_DaysOfWeek"
			});

			schema_array.Add(new VenturaColumn("Recurrence_DayOfWeekIndex", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Calendar",
				BaseColumnName = "Recurrence_DayOfWeekIndex"
			});

			schema_array.Add(new VenturaColumn("Recurrence_Month", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Calendar",
				BaseColumnName = "Recurrence_Month"
			});

			schema_array.Add(new VenturaColumn("Recurrence_DayOfMonth", typeof(int), true)
			{
				Updateable = true,
				ColumnSize = 11,
				NumericPrecision = 10,
				NumericScale = 0,
				ProviderType = 11,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Calendar",
				BaseColumnName = "Recurrence_DayOfMonth"
			});

			schema_array.Add(new VenturaColumn("Recurrence_Interval", typeof(int), true)
			{
				Updateable = true,
				ColumnSize = 11,
				NumericPrecision = 10,
				NumericScale = 0,
				ProviderType = 11,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Calendar",
				BaseColumnName = "Recurrence_Interval"
			});

			schema_array.Add(new VenturaColumn("Recurrence_FirstDayOfWeek", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Calendar",
				BaseColumnName = "Recurrence_FirstDayOfWeek"
			});

			schema_array.Add(new VenturaColumn("Recurrence_Duration", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Calendar",
				BaseColumnName = "Recurrence_Duration"
			});

			schema_array.Add(new VenturaColumn("Recurrence_StartDate", typeof(DateTime), true)
			{
				Updateable = true,
				ColumnSize = 10,
				NumericPrecision = 10,
				NumericScale = 0,
				ProviderType = 5,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Calendar",
				BaseColumnName = "Recurrence_StartDate"
			});

			schema_array.Add(new VenturaColumn("Recurrence_EndDate", typeof(DateTime), true)
			{
				Updateable = true,
				ColumnSize = 10,
				NumericPrecision = 10,
				NumericScale = 0,
				ProviderType = 5,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Calendar",
				BaseColumnName = "Recurrence_EndDate"
			});

			schema_array.Add(new VenturaColumn("Recurrence_NumberOfOccurrences", typeof(int), true)
			{
				Updateable = true,
				ColumnSize = 11,
				NumericPrecision = 10,
				NumericScale = 0,
				ProviderType = 11,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Calendar",
				BaseColumnName = "Recurrence_NumberOfOccurrences"
			});

			schema_array.Add(new VenturaColumn("FirstOccurrence_ItemId", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Calendar",
				BaseColumnName = "FirstOccurrence_ItemId"
			});

			schema_array.Add(new VenturaColumn("FirstOccurrence_Start", typeof(DateTime), true)
			{
				Updateable = true,
				ColumnSize = 16,
				NumericPrecision = 8,
				NumericScale = 0,
				ProviderType = 6,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Calendar",
				BaseColumnName = "FirstOccurrence_Start"
			});

			schema_array.Add(new VenturaColumn("FirstOccurrence_End", typeof(DateTime), true)
			{
				Updateable = true,
				ColumnSize = 16,
				NumericPrecision = 8,
				NumericScale = 0,
				ProviderType = 6,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Calendar",
				BaseColumnName = "FirstOccurrence_End"
			});

			schema_array.Add(new VenturaColumn("FirstOccurrence_OriginalStart", typeof(DateTime), true)
			{
				Updateable = true,
				ColumnSize = 16,
				NumericPrecision = 8,
				NumericScale = 0,
				ProviderType = 6,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Calendar",
				BaseColumnName = "FirstOccurrence_OriginalStart"
			});

			schema_array.Add(new VenturaColumn("LastOccurrence_ItemId", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Calendar",
				BaseColumnName = "LastOccurrence_ItemId"
			});

			schema_array.Add(new VenturaColumn("LastOccurrence_Start", typeof(DateTime), true)
			{
				Updateable = true,
				ColumnSize = 16,
				NumericPrecision = 8,
				NumericScale = 0,
				ProviderType = 6,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Calendar",
				BaseColumnName = "LastOccurrence_Start"
			});

			schema_array.Add(new VenturaColumn("LastOccurrence_End", typeof(DateTime), true)
			{
				Updateable = true,
				ColumnSize = 16,
				NumericPrecision = 8,
				NumericScale = 0,
				ProviderType = 6,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Calendar",
				BaseColumnName = "LastOccurrence_End"
			});

			schema_array.Add(new VenturaColumn("LastOccurrence_OriginalStart", typeof(DateTime), true)
			{
				Updateable = true,
				ColumnSize = 16,
				NumericPrecision = 8,
				NumericScale = 0,
				ProviderType = 6,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Calendar",
				BaseColumnName = "LastOccurrence_OriginalStart"
			});

			schema_array.Add(new VenturaColumn("ModifiedOccurrences_Aggregate", typeof(string), true)
			{
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Calendar",
				BaseColumnName = "ModifiedOccurrences_Aggregate"
			});

			schema_array.Add(new VenturaColumn("DeletedOccurrences_Aggregate", typeof(string), true)
			{
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Calendar",
				BaseColumnName = "DeletedOccurrences_Aggregate"
			});

			schema_array.Add(new VenturaColumn("StartTimeZone_Id", typeof(string), true)
			{
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Calendar",
				BaseColumnName = "StartTimeZone_Id"
			});

			schema_array.Add(new VenturaColumn("StartTimeZone_Name", typeof(string), true)
			{
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Calendar",
				BaseColumnName = "StartTimeZone_Name"
			});

			schema_array.Add(new VenturaColumn("EndTimeZone_Id", typeof(string), true)
			{
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Calendar",
				BaseColumnName = "EndTimeZone_Id"
			});

			schema_array.Add(new VenturaColumn("EndTimeZone_Name", typeof(string), true)
			{
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Calendar",
				BaseColumnName = "EndTimeZone_Name"
			});

			schema_array.Add(new VenturaColumn("ConferenceType", typeof(int), true)
			{
				Updateable = true,
				ColumnSize = 11,
				NumericPrecision = 10,
				NumericScale = 0,
				ProviderType = 11,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Calendar",
				BaseColumnName = "ConferenceType"
			});

			schema_array.Add(new VenturaColumn("AllowNewTimeProposal", typeof(bool), true)
			{
				Updateable = true,
				ColumnSize = 1,
				NumericPrecision = 1,
				NumericScale = 0,
				ProviderType = 3,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Calendar",
				BaseColumnName = "AllowNewTimeProposal"
			});

			schema_array.Add(new VenturaColumn("IsOnlineMeeting", typeof(bool), true)
			{
				Updateable = true,
				ColumnSize = 1,
				NumericPrecision = 1,
				NumericScale = 0,
				ProviderType = 3,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Calendar",
				BaseColumnName = "IsOnlineMeeting"
			});

			schema_array.Add(new VenturaColumn("MeetingWorkspaceUrl", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Calendar",
				BaseColumnName = "MeetingWorkspaceUrl"
			});

			schema_array.Add(new VenturaColumn("NetShowUrl", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Calendar",
				BaseColumnName = "NetShowUrl"
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
				BaseTableName = "Calendar",
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
				BaseTableName = "Calendar",
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
				BaseTableName = "Calendar",
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
				BaseTableName = "Calendar",
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
				BaseTableName = "Calendar",
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
				BaseTableName = "Calendar",
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
				BaseTableName = "Calendar",
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
				BaseTableName = "Calendar",
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
				BaseTableName = "Calendar",
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
				BaseTableName = "Calendar",
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
				BaseTableName = "Calendar",
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
				BaseTableName = "Calendar",
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
				BaseTableName = "Calendar",
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
				BaseTableName = "Calendar",
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
				BaseTableName = "Calendar",
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
				BaseTableName = "Calendar",
				BaseColumnName = "UniqueBodyType"
			});

			((IResultsetBase)this).Schema = new VenturaSchema(schema_array);
			((IResultsetBase)this).UpdateableTablename = "[Exchange].[Calendar]";
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. PrimaryKey. Readonly. AllowNull.
		/// Contains the unique identifier of an item in the Exchange store. This property is read-only.
		/// </summary>
		public string ItemId
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ItemId; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ItemId = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
		/// Contains the native Multipurpose Internet Mail Extensions (MIME) stream of an object that is represented in Base64
		/// binary format.
		/// </summary>
		public string MimeContent
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.MimeContent; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.MimeContent = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
		/// Contains the unique change key of an item in the Exchange store. This property is read-only.
		/// </summary>
		public string ItemChangeKey
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ItemChangeKey; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ItemChangeKey = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Represents the unique identifier of the parent folder that contains the item or folder. This property is read-only.
		/// </summary>
		public string ParentFolderId
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ParentFolderId; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ParentFolderId = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
		/// Represents the unique change key of the parent folder that contains the item or folder. This property is read-only.
		/// </summary>
		public string ParentFolderChangeKey
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ParentFolderChangeKey; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ParentFolderChangeKey = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Represents the message class of an item.
		/// </summary>
		public string ItemClass
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ItemClass; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ItemClass = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Represents the subject for Exchange store items and response objects. The subject is limited to 255 characters.
		/// </summary>
		public string Subject
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Subject; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Subject = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
		/// Indicates the sensitivity level of an item.
		/// </summary>
		public string Sensitivity
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Sensitivity; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Sensitivity = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Body of the Calendar Item.
		/// </summary>
		public string Body
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Body; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Body = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
		/// Represents the date and time that an item in a mailbox was received.
		/// </summary>
		public DateTime? DateTimeReceived
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.DateTimeReceived; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.DateTimeReceived = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
		/// Represents the size in bytes of an item. This property is read-only.
		/// </summary>
		public int? Size
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Size; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Size = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Represents a collection of strings that identify to which categories an item in the mailbox belongs.
		/// </summary>
		public string Categories
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Categories; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Categories = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Describes the importance of an item.
		/// </summary>
		public string Importance
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Importance; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Importance = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
		/// Represents the identifier of the item to which this item is a reply.
		/// </summary>
		public string InReplyTo
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.InReplyTo; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.InReplyTo = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
		/// Indicates whether an item has been submitted to the Outbox default folder.
		/// </summary>
		public bool? IsSubmitted
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.IsSubmitted; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.IsSubmitted = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
		/// Represents whether an item has not yet been sent.
		/// </summary>
		public bool? IsDraft
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.IsDraft; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.IsDraft = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
		/// Indicates whether a user sent an item to himself or herself.
		/// </summary>
		public bool? IsFromMe
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.IsFromMe; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.IsFromMe = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
		/// Indicates whether the item had previously been sent.
		/// </summary>
		public bool? IsResend
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.IsResend; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.IsResend = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
		/// Indicates whether the item has been modified.
		/// </summary>
		public bool? IsUnmodified
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.IsUnmodified; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.IsUnmodified = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
		/// Represents the collection of all Internet message headers that are contained within an item in a mailbox.
		/// </summary>
		public string InternetMessageHeaders
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.InternetMessageHeaders; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.InternetMessageHeaders = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
		/// Represents the date and time that an item in a mailbox was sent.
		/// </summary>
		public DateTime? DateTimeSent
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.DateTimeSent; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.DateTimeSent = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
		/// Represents the date and time that a given item in the mailbox was created.
		/// </summary>
		public DateTime? DateTimeCreated
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.DateTimeCreated; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.DateTimeCreated = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Represents the date and time when the event occurs.
		/// </summary>
		public DateTime? ReminderDueBy
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ReminderDueBy; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ReminderDueBy = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Indicates whether a reminder has been set for an item in the Exchange store.
		/// </summary>
		public bool? ReminderIsSet
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ReminderIsSet; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ReminderIsSet = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Represents the number of minutes before an event occurs when a reminder is displayed.
		/// </summary>
		public int? ReminderMinutesBeforeStart
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ReminderMinutesBeforeStart; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ReminderMinutesBeforeStart = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
		/// Represents the display string that is used for the contents of the To box. This is the concatenated string of all To
		/// recipient display names.
		/// </summary>
		public string DisplayCc
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.DisplayCc; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.DisplayCc = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
		/// Represents a property that is set to true if an item has at least one visible attachment. This property is read-only.
		/// </summary>
		public string DisplayTo
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.DisplayTo; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.DisplayTo = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
		/// Indicates whether an item has attachments.
		/// </summary>
		public bool? HasAttachments
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.HasAttachments; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.HasAttachments = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Represents the Culture of an item.
		/// </summary>
		public string Culture
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Culture; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Culture = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Represents the start of a duration.
		/// </summary>
		public DateTime? Start
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Start; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Start = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Represents the end of a duration.
		/// </summary>
		public DateTime? End
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.End; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.End = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Represents the original start time of a calendar item.
		/// </summary>
		public DateTime? OriginalStart
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.OriginalStart; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.OriginalStart = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Indicates whether a calendar item or meeting request represents an all-day event.
		/// </summary>
		public bool? IsAllDayEvent
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.IsAllDayEvent; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.IsAllDayEvent = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Represents the free/busy status of the calendar item.
		/// </summary>
		public string LegacyFreeBusyStatus
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.LegacyFreeBusyStatus; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.LegacyFreeBusyStatus = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Represents the location of a meeting, appointment, or persona.
		/// </summary>
		public string Location
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Location; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Location = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Provides information about when a calendar or meeting item occurs.
		/// </summary>
		public string When
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.When; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.When = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Indicates whether the calendar item is a meeting or an appointment.
		/// </summary>
		public bool? IsMeeting
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.IsMeeting; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.IsMeeting = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Indicates whether an appointment or meeting has been cancelled.
		/// </summary>
		public bool? IsCancelled
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.IsCancelled; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.IsCancelled = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
		/// Indicates whether a calendar item, meeting request, or task is part of a recurring item. This element is read-only.
		/// </summary>
		public bool? IsRecurring
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.IsRecurring; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.IsRecurring = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
		/// Indicates whether a meeting request has been sent to requested attendees.
		/// </summary>
		public bool? MeetingRequestWasSent
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.MeetingRequestWasSent; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.MeetingRequestWasSent = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
		/// Indicates whether a response to an item is requested.
		/// </summary>
		public bool? IsResponseRequested
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.IsResponseRequested; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.IsResponseRequested = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
		/// Represents the type of a calendar item.
		/// </summary>
		public string CalendarItemType
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.CalendarItemType; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.CalendarItemType = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Contains the status of or response to a calendar item.
		/// </summary>
		public string MyResponseType
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.MyResponseType; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.MyResponseType = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Defines the name of the mailbox user.
		/// </summary>
		public string OrganizerName
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.OrganizerName; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.OrganizerName = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Defines the Simple Mail Transfer Protocol (SMTP) address of the Organizer mailbox user.
		/// </summary>
		public string OrganizerEmailAddress
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.OrganizerEmailAddress; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.OrganizerEmailAddress = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Defines the routing that is used for the Organizer mailbox. The default is SMTP.
		/// </summary>
		public string OrganizerRoutingType
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.OrganizerRoutingType; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.OrganizerRoutingType = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
		/// Represents the number of meetings that conflict with the calendar item.
		/// </summary>
		public int? ConflictingMeetingCount
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ConflictingMeetingCount; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ConflictingMeetingCount = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
		/// Represents the total number of calendar items that are adjacent to a meeting time.
		/// </summary>
		public int? AdjacentMeetingCount
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.AdjacentMeetingCount; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.AdjacentMeetingCount = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
		/// Represents the duration of a calendar item.
		/// </summary>
		public string Duration
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Duration; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Duration = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
		/// Provides a text description of a time zone.
		/// </summary>
		public string TimeZone
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.TimeZone; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.TimeZone = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Represents the date and time that an attendee replied to a meeting request.
		/// </summary>
		public DateTime? AppointmentReplyTime
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.AppointmentReplyTime; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.AppointmentReplyTime = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Specifies the sequence number of a version of an appointment.
		/// </summary>
		public string AppointmentSequenceNumber
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.AppointmentSequenceNumber; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.AppointmentSequenceNumber = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
		/// Specifies the status of the appointment.
		/// </summary>
		public string AppointmentState
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.AppointmentState; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.AppointmentState = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Contains the recurrence type for calendar items and meeting requests.
		/// </summary>
		public string Recurrence_Type
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Recurrence_Type; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Recurrence_Type = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Describes days of the week that are used in item recurrence patterns.
		/// </summary>
		public string Recurrence_DaysOfWeek
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Recurrence_DaysOfWeek; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Recurrence_DaysOfWeek = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Describes which week in a month is used in a relative yearly recurrence pattern.
		/// </summary>
		public string Recurrence_DayOfWeekIndex
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Recurrence_DayOfWeekIndex; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Recurrence_DayOfWeekIndex = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Describes the month when a yearly recurring item occurs.
		/// </summary>
		public string Recurrence_Month
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Recurrence_Month; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Recurrence_Month = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Describes the day in a month on which a recurring item occurs.
		/// </summary>
		public int? Recurrence_DayOfMonth
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Recurrence_DayOfMonth; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Recurrence_DayOfMonth = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Defines the interval between two consecutive recurring items.
		/// </summary>
		public int? Recurrence_Interval
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Recurrence_Interval; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Recurrence_Interval = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Specifies the first day of the week.
		/// </summary>
		public string Recurrence_FirstDayOfWeek
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Recurrence_FirstDayOfWeek; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Recurrence_FirstDayOfWeek = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Contains the recurrence duration type for calendar items and meeting requests.
		/// </summary>
		public string Recurrence_Duration
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Recurrence_Duration; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Recurrence_Duration = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Represents the start date of a recurring task or calendar item.
		/// </summary>
		public DateTime? Recurrence_StartDate
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Recurrence_StartDate; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Recurrence_StartDate = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Represents the end date of a recurring task or calendar item.
		/// </summary>
		public DateTime? Recurrence_EndDate
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Recurrence_EndDate; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Recurrence_EndDate = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Contains the number of occurrences of a recurring item.
		/// </summary>
		public int? Recurrence_NumberOfOccurrences
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Recurrence_NumberOfOccurrences; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Recurrence_NumberOfOccurrences = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Contains the unique identifier of the last occurrence of a recurring calendar item.
		/// </summary>
		public string FirstOccurrence_ItemId
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.FirstOccurrence_ItemId; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.FirstOccurrence_ItemId = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Represents the start time of the last occurrence of a recurring calendar item.
		/// </summary>
		public DateTime? FirstOccurrence_Start
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.FirstOccurrence_Start; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.FirstOccurrence_Start = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Represents the end time of the last occurrence of a recurring calendar item.
		/// </summary>
		public DateTime? FirstOccurrence_End
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.FirstOccurrence_End; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.FirstOccurrence_End = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Represents the original start time of the last occurrence of a recurring calendar item.
		/// </summary>
		public DateTime? FirstOccurrence_OriginalStart
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.FirstOccurrence_OriginalStart; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.FirstOccurrence_OriginalStart = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Contains the unique identifier of the last occurrence of a recurring calendar item.
		/// </summary>
		public string LastOccurrence_ItemId
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.LastOccurrence_ItemId; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.LastOccurrence_ItemId = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Represents the start time of the last occurrence of a recurring calendar item.
		/// </summary>
		public DateTime? LastOccurrence_Start
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.LastOccurrence_Start; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.LastOccurrence_Start = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Represents the end time of the last occurrence of a recurring calendar item.
		/// </summary>
		public DateTime? LastOccurrence_End
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.LastOccurrence_End; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.LastOccurrence_End = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Represents the original start time of the last occurrence of a recurring calendar item.
		/// </summary>
		public DateTime? LastOccurrence_OriginalStart
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.LastOccurrence_OriginalStart; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.LastOccurrence_OriginalStart = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
		/// Modified occurrences of the calendar, as aggregate.
		/// </summary>
		public string ModifiedOccurrences_Aggregate
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ModifiedOccurrences_Aggregate; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ModifiedOccurrences_Aggregate = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
		/// Deleted occurrences as aggregate.
		/// </summary>
		public string DeletedOccurrences_Aggregate
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.DeletedOccurrences_Aggregate; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.DeletedOccurrences_Aggregate = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
		/// Represents the unique identifier of the time zone definition for the start time.
		/// </summary>
		public string StartTimeZone_Id
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.StartTimeZone_Id; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.StartTimeZone_Id = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
		/// Represents the descriptive name of the time zone definition for the start time.
		/// </summary>
		public string StartTimeZone_Name
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.StartTimeZone_Name; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.StartTimeZone_Name = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
		/// Represents the unique identifier of the time zone definition for the end time.
		/// </summary>
		public string EndTimeZone_Id
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.EndTimeZone_Id; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.EndTimeZone_Id = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
		/// Represents the descriptive name of the time zone definition for the end time.
		/// </summary>
		public string EndTimeZone_Name
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.EndTimeZone_Name; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.EndTimeZone_Name = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Describes the type of conferencing that is performed with a calendar item (0 = NetMeeting, 1 = NetShow, 2 = Chat.
		/// </summary>
		public int? ConferenceType
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ConferenceType; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ConferenceType = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Indicates whether a new meeting time can be proposed for a meeting by an attendee.
		/// </summary>
		public bool? AllowNewTimeProposal
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.AllowNewTimeProposal; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.AllowNewTimeProposal = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Indicates whether the meeting is online.
		/// </summary>
		public bool? IsOnlineMeeting
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.IsOnlineMeeting; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.IsOnlineMeeting = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Contains the URL for the meeting workspace that is linked to by the calendar item.
		/// </summary>
		public string MeetingWorkspaceUrl
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.MeetingWorkspaceUrl; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.MeetingWorkspaceUrl = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Specifies the URL for a Microsoft NetShow online meeting.
		/// </summary>
		public string NetShowUrl
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.NetShowUrl; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.NetShowUrl = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
		/// Indicates whether a client can create an associated contents table.
		/// </summary>
		public bool? EffectiveRights_CreateAssociated
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.EffectiveRights_CreateAssociated; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.EffectiveRights_CreateAssociated = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
		/// Indicates whether a client can create a contents table.
		/// </summary>
		public bool? EffectiveRights_CreateContents
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.EffectiveRights_CreateContents; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.EffectiveRights_CreateContents = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
		/// Indicates whether a client can create a hierarchy table.
		/// </summary>
		public bool? EffectiveRights_CreateHierarchy
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.EffectiveRights_CreateHierarchy; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.EffectiveRights_CreateHierarchy = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
		/// Indicates whether a client can delete a folder or item.
		/// </summary>
		public bool? EffectiveRights_Delete
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.EffectiveRights_Delete; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.EffectiveRights_Delete = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
		/// Indicates whether a client can modify a folder or item.
		/// </summary>
		public bool? EffectiveRights_Modify
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.EffectiveRights_Modify; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.EffectiveRights_Modify = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
		/// Indicates whether a client can read a folder or item.
		/// </summary>
		public bool? EffectiveRights_Read
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.EffectiveRights_Read; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.EffectiveRights_Read = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
		/// Indicates whether a private item can be viewed.
		/// </summary>
		public bool? EffectiveRights_ViewPrivateItems
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.EffectiveRights_ViewPrivateItems; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.EffectiveRights_ViewPrivateItems = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
		/// Contains the display name of the last user to modify an item.
		/// </summary>
		public string LastModifiedName
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.LastModifiedName; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.LastModifiedName = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
		/// Indicates when an item was last modified.
		/// </summary>
		public DateTime? LastModifiedTime
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.LastModifiedTime; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.LastModifiedTime = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Indicates whether the item is associated with a folder.
		/// </summary>
		public bool? IsAssociated
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.IsAssociated; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.IsAssociated = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
		/// Represents a URL to concatenate to the Microsoft Office Outlook Web App endpoint to read an item in Outlook Web App.
		/// </summary>
		public string WebClientReadFormQueryString
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.WebClientReadFormQueryString; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.WebClientReadFormQueryString = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
		/// Represents a URL to concatenate to the Outlook Web App endpoint to edit an item in Outlook Web App.
		/// </summary>
		public string WebClientEditFormQueryString
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.WebClientEditFormQueryString; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.WebClientEditFormQueryString = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
		/// Contains the identifier of an item or conversation.
		/// </summary>
		public string ConversationId
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ConversationId; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ConversationId = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
		/// Contains the change key of an item or conversation.
		/// </summary>
		public string ConversationChangeKey
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ConversationChangeKey; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ConversationChangeKey = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
		/// Represents an HTML fragment or plain-text which represents the unique body of this conversation.
		/// </summary>
		public string UniqueBody
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.UniqueBody; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.UniqueBody = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
		/// Describes how the unique item body is stored in the item (HTML or TEXT).
		/// </summary>
		public string UniqueBodyType
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.UniqueBodyType; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.UniqueBodyType = value; }
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
			this.InsertItem(index, new PriKey_Calendar_Record());
			this.CurrentRecordIndex = index;
		}

		public void Append(PriKey_Calendar_Record record)
		{
			int index = this.RecordCount;
			this.InsertItem(index, record);
			this.CurrentRecordIndex = index;
		}

		public PriKey_Calendar_Record NewRecord()
		{
			return new PriKey_Calendar_Record();
		}

		protected override PriKey_Calendar_Record InternalCreateExistingRecordObject(object[] columnvalues) => new PriKey_Calendar_Record(columnvalues);

		byte[] IRecordsetBase.Hash
		{
			get { return new byte[] { 153, 181, 167, 252, 222, 121, 14, 31, 252, 228, 50, 245, 194, 2, 109, 53 }; }
		}

		string IRecordsetBase.HashString
		{
			get { return "99B5A7FCDE790E1FFCE432F5C2026D35"; }
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

	public sealed partial class PriKey_Calendar_Record : IRecordBase, INotifyPropertyChanged
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
		private DateTime? _cur__Start; private DateTime? _ori__Start; private bool _mod__Start;
		private DateTime? _cur__End; private DateTime? _ori__End; private bool _mod__End;
		private DateTime? _cur__OriginalStart; private DateTime? _ori__OriginalStart; private bool _mod__OriginalStart;
		private bool? _cur__IsAllDayEvent; private bool? _ori__IsAllDayEvent; private bool _mod__IsAllDayEvent;
		private string _cur__LegacyFreeBusyStatus; private string _ori__LegacyFreeBusyStatus; private bool _mod__LegacyFreeBusyStatus;
		private string _cur__Location; private string _ori__Location; private bool _mod__Location;
		private string _cur__When; private string _ori__When; private bool _mod__When;
		private bool? _cur__IsMeeting; private bool? _ori__IsMeeting; private bool _mod__IsMeeting;
		private bool? _cur__IsCancelled; private bool? _ori__IsCancelled; private bool _mod__IsCancelled;
		private bool? _cur__IsRecurring; private bool? _ori__IsRecurring; private bool _mod__IsRecurring;
		private bool? _cur__MeetingRequestWasSent; private bool? _ori__MeetingRequestWasSent; private bool _mod__MeetingRequestWasSent;
		private bool? _cur__IsResponseRequested; private bool? _ori__IsResponseRequested; private bool _mod__IsResponseRequested;
		private string _cur__CalendarItemType; private string _ori__CalendarItemType; private bool _mod__CalendarItemType;
		private string _cur__MyResponseType; private string _ori__MyResponseType; private bool _mod__MyResponseType;
		private string _cur__OrganizerName; private string _ori__OrganizerName; private bool _mod__OrganizerName;
		private string _cur__OrganizerEmailAddress; private string _ori__OrganizerEmailAddress; private bool _mod__OrganizerEmailAddress;
		private string _cur__OrganizerRoutingType; private string _ori__OrganizerRoutingType; private bool _mod__OrganizerRoutingType;
		private int? _cur__ConflictingMeetingCount; private int? _ori__ConflictingMeetingCount; private bool _mod__ConflictingMeetingCount;
		private int? _cur__AdjacentMeetingCount; private int? _ori__AdjacentMeetingCount; private bool _mod__AdjacentMeetingCount;
		private string _cur__Duration; private string _ori__Duration; private bool _mod__Duration;
		private string _cur__TimeZone; private string _ori__TimeZone; private bool _mod__TimeZone;
		private DateTime? _cur__AppointmentReplyTime; private DateTime? _ori__AppointmentReplyTime; private bool _mod__AppointmentReplyTime;
		private string _cur__AppointmentSequenceNumber; private string _ori__AppointmentSequenceNumber; private bool _mod__AppointmentSequenceNumber;
		private string _cur__AppointmentState; private string _ori__AppointmentState; private bool _mod__AppointmentState;
		private string _cur__Recurrence_Type; private string _ori__Recurrence_Type; private bool _mod__Recurrence_Type;
		private string _cur__Recurrence_DaysOfWeek; private string _ori__Recurrence_DaysOfWeek; private bool _mod__Recurrence_DaysOfWeek;
		private string _cur__Recurrence_DayOfWeekIndex; private string _ori__Recurrence_DayOfWeekIndex; private bool _mod__Recurrence_DayOfWeekIndex;
		private string _cur__Recurrence_Month; private string _ori__Recurrence_Month; private bool _mod__Recurrence_Month;
		private int? _cur__Recurrence_DayOfMonth; private int? _ori__Recurrence_DayOfMonth; private bool _mod__Recurrence_DayOfMonth;
		private int? _cur__Recurrence_Interval; private int? _ori__Recurrence_Interval; private bool _mod__Recurrence_Interval;
		private string _cur__Recurrence_FirstDayOfWeek; private string _ori__Recurrence_FirstDayOfWeek; private bool _mod__Recurrence_FirstDayOfWeek;
		private string _cur__Recurrence_Duration; private string _ori__Recurrence_Duration; private bool _mod__Recurrence_Duration;
		private DateTime? _cur__Recurrence_StartDate; private DateTime? _ori__Recurrence_StartDate; private bool _mod__Recurrence_StartDate;
		private DateTime? _cur__Recurrence_EndDate; private DateTime? _ori__Recurrence_EndDate; private bool _mod__Recurrence_EndDate;
		private int? _cur__Recurrence_NumberOfOccurrences; private int? _ori__Recurrence_NumberOfOccurrences; private bool _mod__Recurrence_NumberOfOccurrences;
		private string _cur__FirstOccurrence_ItemId; private string _ori__FirstOccurrence_ItemId; private bool _mod__FirstOccurrence_ItemId;
		private DateTime? _cur__FirstOccurrence_Start; private DateTime? _ori__FirstOccurrence_Start; private bool _mod__FirstOccurrence_Start;
		private DateTime? _cur__FirstOccurrence_End; private DateTime? _ori__FirstOccurrence_End; private bool _mod__FirstOccurrence_End;
		private DateTime? _cur__FirstOccurrence_OriginalStart; private DateTime? _ori__FirstOccurrence_OriginalStart; private bool _mod__FirstOccurrence_OriginalStart;
		private string _cur__LastOccurrence_ItemId; private string _ori__LastOccurrence_ItemId; private bool _mod__LastOccurrence_ItemId;
		private DateTime? _cur__LastOccurrence_Start; private DateTime? _ori__LastOccurrence_Start; private bool _mod__LastOccurrence_Start;
		private DateTime? _cur__LastOccurrence_End; private DateTime? _ori__LastOccurrence_End; private bool _mod__LastOccurrence_End;
		private DateTime? _cur__LastOccurrence_OriginalStart; private DateTime? _ori__LastOccurrence_OriginalStart; private bool _mod__LastOccurrence_OriginalStart;
		private string _cur__ModifiedOccurrences_Aggregate; private string _ori__ModifiedOccurrences_Aggregate; private bool _mod__ModifiedOccurrences_Aggregate;
		private string _cur__DeletedOccurrences_Aggregate; private string _ori__DeletedOccurrences_Aggregate; private bool _mod__DeletedOccurrences_Aggregate;
		private string _cur__StartTimeZone_Id; private string _ori__StartTimeZone_Id; private bool _mod__StartTimeZone_Id;
		private string _cur__StartTimeZone_Name; private string _ori__StartTimeZone_Name; private bool _mod__StartTimeZone_Name;
		private string _cur__EndTimeZone_Id; private string _ori__EndTimeZone_Id; private bool _mod__EndTimeZone_Id;
		private string _cur__EndTimeZone_Name; private string _ori__EndTimeZone_Name; private bool _mod__EndTimeZone_Name;
		private int? _cur__ConferenceType; private int? _ori__ConferenceType; private bool _mod__ConferenceType;
		private bool? _cur__AllowNewTimeProposal; private bool? _ori__AllowNewTimeProposal; private bool _mod__AllowNewTimeProposal;
		private bool? _cur__IsOnlineMeeting; private bool? _ori__IsOnlineMeeting; private bool _mod__IsOnlineMeeting;
		private string _cur__MeetingWorkspaceUrl; private string _ori__MeetingWorkspaceUrl; private bool _mod__MeetingWorkspaceUrl;
		private string _cur__NetShowUrl; private string _ori__NetShowUrl; private bool _mod__NetShowUrl;
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
		private string _cur__ConversationChangeKey; private string _ori__ConversationChangeKey; private bool _mod__ConversationChangeKey;
		private string _cur__UniqueBody; private string _ori__UniqueBody; private bool _mod__UniqueBody;
		private string _cur__UniqueBodyType; private string _ori__UniqueBodyType; private bool _mod__UniqueBodyType;


		public PriKey_Calendar_Record()
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
			_cur__Start = null;
			_cur__End = null;
			_cur__OriginalStart = null;
			_cur__IsAllDayEvent = null;
			_cur__LegacyFreeBusyStatus = null;
			_cur__Location = null;
			_cur__When = null;
			_cur__IsMeeting = null;
			_cur__IsCancelled = null;
			_cur__IsRecurring = null;
			_cur__MeetingRequestWasSent = null;
			_cur__IsResponseRequested = null;
			_cur__CalendarItemType = null;
			_cur__MyResponseType = null;
			_cur__OrganizerName = null;
			_cur__OrganizerEmailAddress = null;
			_cur__OrganizerRoutingType = null;
			_cur__ConflictingMeetingCount = null;
			_cur__AdjacentMeetingCount = null;
			_cur__Duration = null;
			_cur__TimeZone = null;
			_cur__AppointmentReplyTime = null;
			_cur__AppointmentSequenceNumber = null;
			_cur__AppointmentState = null;
			_cur__Recurrence_Type = null;
			_cur__Recurrence_DaysOfWeek = null;
			_cur__Recurrence_DayOfWeekIndex = null;
			_cur__Recurrence_Month = null;
			_cur__Recurrence_DayOfMonth = null;
			_cur__Recurrence_Interval = null;
			_cur__Recurrence_FirstDayOfWeek = null;
			_cur__Recurrence_Duration = null;
			_cur__Recurrence_StartDate = null;
			_cur__Recurrence_EndDate = null;
			_cur__Recurrence_NumberOfOccurrences = null;
			_cur__FirstOccurrence_ItemId = null;
			_cur__FirstOccurrence_Start = null;
			_cur__FirstOccurrence_End = null;
			_cur__FirstOccurrence_OriginalStart = null;
			_cur__LastOccurrence_ItemId = null;
			_cur__LastOccurrence_Start = null;
			_cur__LastOccurrence_End = null;
			_cur__LastOccurrence_OriginalStart = null;
			_cur__ModifiedOccurrences_Aggregate = null;
			_cur__DeletedOccurrences_Aggregate = null;
			_cur__StartTimeZone_Id = null;
			_cur__StartTimeZone_Name = null;
			_cur__EndTimeZone_Id = null;
			_cur__EndTimeZone_Name = null;
			_cur__ConferenceType = null;
			_cur__AllowNewTimeProposal = null;
			_cur__IsOnlineMeeting = null;
			_cur__MeetingWorkspaceUrl = null;
			_cur__NetShowUrl = null;
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
			_cur__ConversationChangeKey = null;
			_cur__UniqueBody = null;
			_cur__UniqueBodyType = null;
			_started_with_dbvalues = false;
			_recordstatus = DataRecordStatus.New;
		}

		public PriKey_Calendar_Record(object[] columnvalues)
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
			_cur__InReplyTo = (string)columnvalues[13];
			_cur__IsSubmitted = (bool?)columnvalues[14];
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
			_cur__Start = (DateTime?)columnvalues[29];
			_cur__End = (DateTime?)columnvalues[30];
			_cur__OriginalStart = (DateTime?)columnvalues[31];
			_cur__IsAllDayEvent = (bool?)columnvalues[32];
			_cur__LegacyFreeBusyStatus = (string)columnvalues[33];
			_cur__Location = (string)columnvalues[34];
			_cur__When = (string)columnvalues[35];
			_cur__IsMeeting = (bool?)columnvalues[36];
			_cur__IsCancelled = (bool?)columnvalues[37];
			_cur__IsRecurring = (bool?)columnvalues[38];
			_cur__MeetingRequestWasSent = (bool?)columnvalues[39];
			_cur__IsResponseRequested = (bool?)columnvalues[40];
			_cur__CalendarItemType = (string)columnvalues[41];
			_cur__MyResponseType = (string)columnvalues[42];
			_cur__OrganizerName = (string)columnvalues[43];
			_cur__OrganizerEmailAddress = (string)columnvalues[44];
			_cur__OrganizerRoutingType = (string)columnvalues[45];
			_cur__ConflictingMeetingCount = (int?)columnvalues[46];
			_cur__AdjacentMeetingCount = (int?)columnvalues[47];
			_cur__Duration = (string)columnvalues[48];
			_cur__TimeZone = (string)columnvalues[49];
			_cur__AppointmentReplyTime = (DateTime?)columnvalues[50];
			_cur__AppointmentSequenceNumber = (string)columnvalues[51];
			_cur__AppointmentState = (string)columnvalues[52];
			_cur__Recurrence_Type = (string)columnvalues[53];
			_cur__Recurrence_DaysOfWeek = (string)columnvalues[54];
			_cur__Recurrence_DayOfWeekIndex = (string)columnvalues[55];
			_cur__Recurrence_Month = (string)columnvalues[56];
			_cur__Recurrence_DayOfMonth = (int?)columnvalues[57];
			_cur__Recurrence_Interval = (int?)columnvalues[58];
			_cur__Recurrence_FirstDayOfWeek = (string)columnvalues[59];
			_cur__Recurrence_Duration = (string)columnvalues[60];
			_cur__Recurrence_StartDate = (DateTime?)columnvalues[61];
			_cur__Recurrence_EndDate = (DateTime?)columnvalues[62];
			_cur__Recurrence_NumberOfOccurrences = (int?)columnvalues[63];
			_cur__FirstOccurrence_ItemId = (string)columnvalues[64];
			_cur__FirstOccurrence_Start = (DateTime?)columnvalues[65];
			_cur__FirstOccurrence_End = (DateTime?)columnvalues[66];
			_cur__FirstOccurrence_OriginalStart = (DateTime?)columnvalues[67];
			_cur__LastOccurrence_ItemId = (string)columnvalues[68];
			_cur__LastOccurrence_Start = (DateTime?)columnvalues[69];
			_cur__LastOccurrence_End = (DateTime?)columnvalues[70];
			_cur__LastOccurrence_OriginalStart = (DateTime?)columnvalues[71];
			_cur__ModifiedOccurrences_Aggregate = (string)columnvalues[72];
			_cur__DeletedOccurrences_Aggregate = (string)columnvalues[73];
			_cur__StartTimeZone_Id = (string)columnvalues[74];
			_cur__StartTimeZone_Name = (string)columnvalues[75];
			_cur__EndTimeZone_Id = (string)columnvalues[76];
			_cur__EndTimeZone_Name = (string)columnvalues[77];
			_cur__ConferenceType = (int?)columnvalues[78];
			_cur__AllowNewTimeProposal = (bool?)columnvalues[79];
			_cur__IsOnlineMeeting = (bool?)columnvalues[80];
			_cur__MeetingWorkspaceUrl = (string)columnvalues[81];
			_cur__NetShowUrl = (string)columnvalues[82];
			_cur__EffectiveRights_CreateAssociated = (bool?)columnvalues[83];
			_cur__EffectiveRights_CreateContents = (bool?)columnvalues[84];
			_cur__EffectiveRights_CreateHierarchy = (bool?)columnvalues[85];
			_cur__EffectiveRights_Delete = (bool?)columnvalues[86];
			_cur__EffectiveRights_Modify = (bool?)columnvalues[87];
			_cur__EffectiveRights_Read = (bool?)columnvalues[88];
			_cur__EffectiveRights_ViewPrivateItems = (bool?)columnvalues[89];
			_cur__LastModifiedName = (string)columnvalues[90];
			_cur__LastModifiedTime = (DateTime?)columnvalues[91];
			_cur__IsAssociated = (bool?)columnvalues[92];
			_cur__WebClientReadFormQueryString = (string)columnvalues[93];
			_cur__WebClientEditFormQueryString = (string)columnvalues[94];
			_cur__ConversationId = (string)columnvalues[95];
			_cur__ConversationChangeKey = (string)columnvalues[96];
			_cur__UniqueBody = (string)columnvalues[97];
			_cur__UniqueBodyType = (string)columnvalues[98];
			_started_with_dbvalues = true;
			_recordstatus = DataRecordStatus.Existing;
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. PrimaryKey. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
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
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
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
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
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
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
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
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Body of the Calendar Item.
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
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
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
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
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
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
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
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
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
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
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
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
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
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
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
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Represents the start of a duration.
		/// </summary>
		public DateTime? Start
		{
			get { return _cur__Start; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Start = true;
				if (_cur__Start == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Start == false) { _ori__Start = _cur__Start; _mod__Start = true; } // existing record and column is not modified
					else { if (value == _ori__Start) { _ori__Start = default(DateTime?); _mod__Start = false; } } // existing record and column is modified
				}
				_cur__Start = value; OnPropertyChanged("Start"); OnAfterPropertyChanged("Start");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Represents the end of a duration.
		/// </summary>
		public DateTime? End
		{
			get { return _cur__End; }
			set
			{
				if (_started_with_dbvalues == false) _mod__End = true;
				if (_cur__End == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__End == false) { _ori__End = _cur__End; _mod__End = true; } // existing record and column is not modified
					else { if (value == _ori__End) { _ori__End = default(DateTime?); _mod__End = false; } } // existing record and column is modified
				}
				_cur__End = value; OnPropertyChanged("End"); OnAfterPropertyChanged("End");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Represents the original start time of a calendar item.
		/// </summary>
		public DateTime? OriginalStart
		{
			get { return _cur__OriginalStart; }
			set
			{
				if (_started_with_dbvalues == false) _mod__OriginalStart = true;
				if (_cur__OriginalStart == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__OriginalStart == false) { _ori__OriginalStart = _cur__OriginalStart; _mod__OriginalStart = true; } // existing record and column is not modified
					else { if (value == _ori__OriginalStart) { _ori__OriginalStart = default(DateTime?); _mod__OriginalStart = false; } } // existing record and column is modified
				}
				_cur__OriginalStart = value; OnPropertyChanged("OriginalStart"); OnAfterPropertyChanged("OriginalStart");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Indicates whether a calendar item or meeting request represents an all-day event.
		/// </summary>
		public bool? IsAllDayEvent
		{
			get { return _cur__IsAllDayEvent; }
			set
			{
				if (_started_with_dbvalues == false) _mod__IsAllDayEvent = true;
				if (_cur__IsAllDayEvent == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__IsAllDayEvent == false) { _ori__IsAllDayEvent = _cur__IsAllDayEvent; _mod__IsAllDayEvent = true; } // existing record and column is not modified
					else { if (value == _ori__IsAllDayEvent) { _ori__IsAllDayEvent = default(bool?); _mod__IsAllDayEvent = false; } } // existing record and column is modified
				}
				_cur__IsAllDayEvent = value; OnPropertyChanged("IsAllDayEvent"); OnAfterPropertyChanged("IsAllDayEvent");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Represents the free/busy status of the calendar item.
		/// </summary>
		public string LegacyFreeBusyStatus
		{
			get { return _cur__LegacyFreeBusyStatus; }
			set
			{
				if (_started_with_dbvalues == false) _mod__LegacyFreeBusyStatus = true;
				if (_cur__LegacyFreeBusyStatus == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__LegacyFreeBusyStatus == false) { _ori__LegacyFreeBusyStatus = _cur__LegacyFreeBusyStatus; _mod__LegacyFreeBusyStatus = true; } // existing record and column is not modified
					else { if (value == _ori__LegacyFreeBusyStatus) { _ori__LegacyFreeBusyStatus = default(string); _mod__LegacyFreeBusyStatus = false; } } // existing record and column is modified
				}
				_cur__LegacyFreeBusyStatus = value; OnPropertyChanged("LegacyFreeBusyStatus"); OnAfterPropertyChanged("LegacyFreeBusyStatus");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Represents the location of a meeting, appointment, or persona.
		/// </summary>
		public string Location
		{
			get { return _cur__Location; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Location = true;
				if (_cur__Location == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Location == false) { _ori__Location = _cur__Location; _mod__Location = true; } // existing record and column is not modified
					else { if (value == _ori__Location) { _ori__Location = default(string); _mod__Location = false; } } // existing record and column is modified
				}
				_cur__Location = value; OnPropertyChanged("Location"); OnAfterPropertyChanged("Location");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Provides information about when a calendar or meeting item occurs.
		/// </summary>
		public string When
		{
			get { return _cur__When; }
			set
			{
				if (_started_with_dbvalues == false) _mod__When = true;
				if (_cur__When == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__When == false) { _ori__When = _cur__When; _mod__When = true; } // existing record and column is not modified
					else { if (value == _ori__When) { _ori__When = default(string); _mod__When = false; } } // existing record and column is modified
				}
				_cur__When = value; OnPropertyChanged("When"); OnAfterPropertyChanged("When");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Indicates whether the calendar item is a meeting or an appointment.
		/// </summary>
		public bool? IsMeeting
		{
			get { return _cur__IsMeeting; }
			set
			{
				if (_started_with_dbvalues == false) _mod__IsMeeting = true;
				if (_cur__IsMeeting == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__IsMeeting == false) { _ori__IsMeeting = _cur__IsMeeting; _mod__IsMeeting = true; } // existing record and column is not modified
					else { if (value == _ori__IsMeeting) { _ori__IsMeeting = default(bool?); _mod__IsMeeting = false; } } // existing record and column is modified
				}
				_cur__IsMeeting = value; OnPropertyChanged("IsMeeting"); OnAfterPropertyChanged("IsMeeting");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Indicates whether an appointment or meeting has been cancelled.
		/// </summary>
		public bool? IsCancelled
		{
			get { return _cur__IsCancelled; }
			set
			{
				if (_started_with_dbvalues == false) _mod__IsCancelled = true;
				if (_cur__IsCancelled == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__IsCancelled == false) { _ori__IsCancelled = _cur__IsCancelled; _mod__IsCancelled = true; } // existing record and column is not modified
					else { if (value == _ori__IsCancelled) { _ori__IsCancelled = default(bool?); _mod__IsCancelled = false; } } // existing record and column is modified
				}
				_cur__IsCancelled = value; OnPropertyChanged("IsCancelled"); OnAfterPropertyChanged("IsCancelled");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
		/// Indicates whether a calendar item, meeting request, or task is part of a recurring item. This element is read-only.
		/// </summary>
		public bool? IsRecurring
		{
			get { return _cur__IsRecurring; }
			set
			{
				if (_started_with_dbvalues == false) _mod__IsRecurring = true;
				if (_cur__IsRecurring == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__IsRecurring == false) { _ori__IsRecurring = _cur__IsRecurring; _mod__IsRecurring = true; } // existing record and column is not modified
					else { if (value == _ori__IsRecurring) { _ori__IsRecurring = default(bool?); _mod__IsRecurring = false; } } // existing record and column is modified
				}
				_cur__IsRecurring = value; OnPropertyChanged("IsRecurring"); OnAfterPropertyChanged("IsRecurring");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
		/// Indicates whether a meeting request has been sent to requested attendees.
		/// </summary>
		public bool? MeetingRequestWasSent
		{
			get { return _cur__MeetingRequestWasSent; }
			set
			{
				if (_started_with_dbvalues == false) _mod__MeetingRequestWasSent = true;
				if (_cur__MeetingRequestWasSent == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__MeetingRequestWasSent == false) { _ori__MeetingRequestWasSent = _cur__MeetingRequestWasSent; _mod__MeetingRequestWasSent = true; } // existing record and column is not modified
					else { if (value == _ori__MeetingRequestWasSent) { _ori__MeetingRequestWasSent = default(bool?); _mod__MeetingRequestWasSent = false; } } // existing record and column is modified
				}
				_cur__MeetingRequestWasSent = value; OnPropertyChanged("MeetingRequestWasSent"); OnAfterPropertyChanged("MeetingRequestWasSent");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
		/// Represents the type of a calendar item.
		/// </summary>
		public string CalendarItemType
		{
			get { return _cur__CalendarItemType; }
			set
			{
				if (_started_with_dbvalues == false) _mod__CalendarItemType = true;
				if (_cur__CalendarItemType == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__CalendarItemType == false) { _ori__CalendarItemType = _cur__CalendarItemType; _mod__CalendarItemType = true; } // existing record and column is not modified
					else { if (value == _ori__CalendarItemType) { _ori__CalendarItemType = default(string); _mod__CalendarItemType = false; } } // existing record and column is modified
				}
				_cur__CalendarItemType = value; OnPropertyChanged("CalendarItemType"); OnAfterPropertyChanged("CalendarItemType");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Contains the status of or response to a calendar item.
		/// </summary>
		public string MyResponseType
		{
			get { return _cur__MyResponseType; }
			set
			{
				if (_started_with_dbvalues == false) _mod__MyResponseType = true;
				if (_cur__MyResponseType == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__MyResponseType == false) { _ori__MyResponseType = _cur__MyResponseType; _mod__MyResponseType = true; } // existing record and column is not modified
					else { if (value == _ori__MyResponseType) { _ori__MyResponseType = default(string); _mod__MyResponseType = false; } } // existing record and column is modified
				}
				_cur__MyResponseType = value; OnPropertyChanged("MyResponseType"); OnAfterPropertyChanged("MyResponseType");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Defines the name of the mailbox user.
		/// </summary>
		public string OrganizerName
		{
			get { return _cur__OrganizerName; }
			set
			{
				if (_started_with_dbvalues == false) _mod__OrganizerName = true;
				if (_cur__OrganizerName == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__OrganizerName == false) { _ori__OrganizerName = _cur__OrganizerName; _mod__OrganizerName = true; } // existing record and column is not modified
					else { if (value == _ori__OrganizerName) { _ori__OrganizerName = default(string); _mod__OrganizerName = false; } } // existing record and column is modified
				}
				_cur__OrganizerName = value; OnPropertyChanged("OrganizerName"); OnAfterPropertyChanged("OrganizerName");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Defines the Simple Mail Transfer Protocol (SMTP) address of the Organizer mailbox user.
		/// </summary>
		public string OrganizerEmailAddress
		{
			get { return _cur__OrganizerEmailAddress; }
			set
			{
				if (_started_with_dbvalues == false) _mod__OrganizerEmailAddress = true;
				if (_cur__OrganizerEmailAddress == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__OrganizerEmailAddress == false) { _ori__OrganizerEmailAddress = _cur__OrganizerEmailAddress; _mod__OrganizerEmailAddress = true; } // existing record and column is not modified
					else { if (value == _ori__OrganizerEmailAddress) { _ori__OrganizerEmailAddress = default(string); _mod__OrganizerEmailAddress = false; } } // existing record and column is modified
				}
				_cur__OrganizerEmailAddress = value; OnPropertyChanged("OrganizerEmailAddress"); OnAfterPropertyChanged("OrganizerEmailAddress");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Defines the routing that is used for the Organizer mailbox. The default is SMTP.
		/// </summary>
		public string OrganizerRoutingType
		{
			get { return _cur__OrganizerRoutingType; }
			set
			{
				if (_started_with_dbvalues == false) _mod__OrganizerRoutingType = true;
				if (_cur__OrganizerRoutingType == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__OrganizerRoutingType == false) { _ori__OrganizerRoutingType = _cur__OrganizerRoutingType; _mod__OrganizerRoutingType = true; } // existing record and column is not modified
					else { if (value == _ori__OrganizerRoutingType) { _ori__OrganizerRoutingType = default(string); _mod__OrganizerRoutingType = false; } } // existing record and column is modified
				}
				_cur__OrganizerRoutingType = value; OnPropertyChanged("OrganizerRoutingType"); OnAfterPropertyChanged("OrganizerRoutingType");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
		/// Represents the number of meetings that conflict with the calendar item.
		/// </summary>
		public int? ConflictingMeetingCount
		{
			get { return _cur__ConflictingMeetingCount; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ConflictingMeetingCount = true;
				if (_cur__ConflictingMeetingCount == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ConflictingMeetingCount == false) { _ori__ConflictingMeetingCount = _cur__ConflictingMeetingCount; _mod__ConflictingMeetingCount = true; } // existing record and column is not modified
					else { if (value == _ori__ConflictingMeetingCount) { _ori__ConflictingMeetingCount = default(int?); _mod__ConflictingMeetingCount = false; } } // existing record and column is modified
				}
				_cur__ConflictingMeetingCount = value; OnPropertyChanged("ConflictingMeetingCount"); OnAfterPropertyChanged("ConflictingMeetingCount");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
		/// Represents the total number of calendar items that are adjacent to a meeting time.
		/// </summary>
		public int? AdjacentMeetingCount
		{
			get { return _cur__AdjacentMeetingCount; }
			set
			{
				if (_started_with_dbvalues == false) _mod__AdjacentMeetingCount = true;
				if (_cur__AdjacentMeetingCount == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__AdjacentMeetingCount == false) { _ori__AdjacentMeetingCount = _cur__AdjacentMeetingCount; _mod__AdjacentMeetingCount = true; } // existing record and column is not modified
					else { if (value == _ori__AdjacentMeetingCount) { _ori__AdjacentMeetingCount = default(int?); _mod__AdjacentMeetingCount = false; } } // existing record and column is modified
				}
				_cur__AdjacentMeetingCount = value; OnPropertyChanged("AdjacentMeetingCount"); OnAfterPropertyChanged("AdjacentMeetingCount");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
		/// Represents the duration of a calendar item.
		/// </summary>
		public string Duration
		{
			get { return _cur__Duration; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Duration = true;
				if (_cur__Duration == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Duration == false) { _ori__Duration = _cur__Duration; _mod__Duration = true; } // existing record and column is not modified
					else { if (value == _ori__Duration) { _ori__Duration = default(string); _mod__Duration = false; } } // existing record and column is modified
				}
				_cur__Duration = value; OnPropertyChanged("Duration"); OnAfterPropertyChanged("Duration");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
		/// Provides a text description of a time zone.
		/// </summary>
		public string TimeZone
		{
			get { return _cur__TimeZone; }
			set
			{
				if (_started_with_dbvalues == false) _mod__TimeZone = true;
				if (_cur__TimeZone == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__TimeZone == false) { _ori__TimeZone = _cur__TimeZone; _mod__TimeZone = true; } // existing record and column is not modified
					else { if (value == _ori__TimeZone) { _ori__TimeZone = default(string); _mod__TimeZone = false; } } // existing record and column is modified
				}
				_cur__TimeZone = value; OnPropertyChanged("TimeZone"); OnAfterPropertyChanged("TimeZone");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Represents the date and time that an attendee replied to a meeting request.
		/// </summary>
		public DateTime? AppointmentReplyTime
		{
			get { return _cur__AppointmentReplyTime; }
			set
			{
				if (_started_with_dbvalues == false) _mod__AppointmentReplyTime = true;
				if (_cur__AppointmentReplyTime == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__AppointmentReplyTime == false) { _ori__AppointmentReplyTime = _cur__AppointmentReplyTime; _mod__AppointmentReplyTime = true; } // existing record and column is not modified
					else { if (value == _ori__AppointmentReplyTime) { _ori__AppointmentReplyTime = default(DateTime?); _mod__AppointmentReplyTime = false; } } // existing record and column is modified
				}
				_cur__AppointmentReplyTime = value; OnPropertyChanged("AppointmentReplyTime"); OnAfterPropertyChanged("AppointmentReplyTime");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Specifies the sequence number of a version of an appointment.
		/// </summary>
		public string AppointmentSequenceNumber
		{
			get { return _cur__AppointmentSequenceNumber; }
			set
			{
				if (_started_with_dbvalues == false) _mod__AppointmentSequenceNumber = true;
				if (_cur__AppointmentSequenceNumber == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__AppointmentSequenceNumber == false) { _ori__AppointmentSequenceNumber = _cur__AppointmentSequenceNumber; _mod__AppointmentSequenceNumber = true; } // existing record and column is not modified
					else { if (value == _ori__AppointmentSequenceNumber) { _ori__AppointmentSequenceNumber = default(string); _mod__AppointmentSequenceNumber = false; } } // existing record and column is modified
				}
				_cur__AppointmentSequenceNumber = value; OnPropertyChanged("AppointmentSequenceNumber"); OnAfterPropertyChanged("AppointmentSequenceNumber");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
		/// Specifies the status of the appointment.
		/// </summary>
		public string AppointmentState
		{
			get { return _cur__AppointmentState; }
			set
			{
				if (_started_with_dbvalues == false) _mod__AppointmentState = true;
				if (_cur__AppointmentState == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__AppointmentState == false) { _ori__AppointmentState = _cur__AppointmentState; _mod__AppointmentState = true; } // existing record and column is not modified
					else { if (value == _ori__AppointmentState) { _ori__AppointmentState = default(string); _mod__AppointmentState = false; } } // existing record and column is modified
				}
				_cur__AppointmentState = value; OnPropertyChanged("AppointmentState"); OnAfterPropertyChanged("AppointmentState");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Contains the recurrence type for calendar items and meeting requests.
		/// </summary>
		public string Recurrence_Type
		{
			get { return _cur__Recurrence_Type; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Recurrence_Type = true;
				if (_cur__Recurrence_Type == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Recurrence_Type == false) { _ori__Recurrence_Type = _cur__Recurrence_Type; _mod__Recurrence_Type = true; } // existing record and column is not modified
					else { if (value == _ori__Recurrence_Type) { _ori__Recurrence_Type = default(string); _mod__Recurrence_Type = false; } } // existing record and column is modified
				}
				_cur__Recurrence_Type = value; OnPropertyChanged("Recurrence_Type"); OnAfterPropertyChanged("Recurrence_Type");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Describes days of the week that are used in item recurrence patterns.
		/// </summary>
		public string Recurrence_DaysOfWeek
		{
			get { return _cur__Recurrence_DaysOfWeek; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Recurrence_DaysOfWeek = true;
				if (_cur__Recurrence_DaysOfWeek == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Recurrence_DaysOfWeek == false) { _ori__Recurrence_DaysOfWeek = _cur__Recurrence_DaysOfWeek; _mod__Recurrence_DaysOfWeek = true; } // existing record and column is not modified
					else { if (value == _ori__Recurrence_DaysOfWeek) { _ori__Recurrence_DaysOfWeek = default(string); _mod__Recurrence_DaysOfWeek = false; } } // existing record and column is modified
				}
				_cur__Recurrence_DaysOfWeek = value; OnPropertyChanged("Recurrence_DaysOfWeek"); OnAfterPropertyChanged("Recurrence_DaysOfWeek");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Describes which week in a month is used in a relative yearly recurrence pattern.
		/// </summary>
		public string Recurrence_DayOfWeekIndex
		{
			get { return _cur__Recurrence_DayOfWeekIndex; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Recurrence_DayOfWeekIndex = true;
				if (_cur__Recurrence_DayOfWeekIndex == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Recurrence_DayOfWeekIndex == false) { _ori__Recurrence_DayOfWeekIndex = _cur__Recurrence_DayOfWeekIndex; _mod__Recurrence_DayOfWeekIndex = true; } // existing record and column is not modified
					else { if (value == _ori__Recurrence_DayOfWeekIndex) { _ori__Recurrence_DayOfWeekIndex = default(string); _mod__Recurrence_DayOfWeekIndex = false; } } // existing record and column is modified
				}
				_cur__Recurrence_DayOfWeekIndex = value; OnPropertyChanged("Recurrence_DayOfWeekIndex"); OnAfterPropertyChanged("Recurrence_DayOfWeekIndex");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Describes the month when a yearly recurring item occurs.
		/// </summary>
		public string Recurrence_Month
		{
			get { return _cur__Recurrence_Month; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Recurrence_Month = true;
				if (_cur__Recurrence_Month == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Recurrence_Month == false) { _ori__Recurrence_Month = _cur__Recurrence_Month; _mod__Recurrence_Month = true; } // existing record and column is not modified
					else { if (value == _ori__Recurrence_Month) { _ori__Recurrence_Month = default(string); _mod__Recurrence_Month = false; } } // existing record and column is modified
				}
				_cur__Recurrence_Month = value; OnPropertyChanged("Recurrence_Month"); OnAfterPropertyChanged("Recurrence_Month");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Describes the day in a month on which a recurring item occurs.
		/// </summary>
		public int? Recurrence_DayOfMonth
		{
			get { return _cur__Recurrence_DayOfMonth; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Recurrence_DayOfMonth = true;
				if (_cur__Recurrence_DayOfMonth == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Recurrence_DayOfMonth == false) { _ori__Recurrence_DayOfMonth = _cur__Recurrence_DayOfMonth; _mod__Recurrence_DayOfMonth = true; } // existing record and column is not modified
					else { if (value == _ori__Recurrence_DayOfMonth) { _ori__Recurrence_DayOfMonth = default(int?); _mod__Recurrence_DayOfMonth = false; } } // existing record and column is modified
				}
				_cur__Recurrence_DayOfMonth = value; OnPropertyChanged("Recurrence_DayOfMonth"); OnAfterPropertyChanged("Recurrence_DayOfMonth");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Defines the interval between two consecutive recurring items.
		/// </summary>
		public int? Recurrence_Interval
		{
			get { return _cur__Recurrence_Interval; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Recurrence_Interval = true;
				if (_cur__Recurrence_Interval == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Recurrence_Interval == false) { _ori__Recurrence_Interval = _cur__Recurrence_Interval; _mod__Recurrence_Interval = true; } // existing record and column is not modified
					else { if (value == _ori__Recurrence_Interval) { _ori__Recurrence_Interval = default(int?); _mod__Recurrence_Interval = false; } } // existing record and column is modified
				}
				_cur__Recurrence_Interval = value; OnPropertyChanged("Recurrence_Interval"); OnAfterPropertyChanged("Recurrence_Interval");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Specifies the first day of the week.
		/// </summary>
		public string Recurrence_FirstDayOfWeek
		{
			get { return _cur__Recurrence_FirstDayOfWeek; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Recurrence_FirstDayOfWeek = true;
				if (_cur__Recurrence_FirstDayOfWeek == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Recurrence_FirstDayOfWeek == false) { _ori__Recurrence_FirstDayOfWeek = _cur__Recurrence_FirstDayOfWeek; _mod__Recurrence_FirstDayOfWeek = true; } // existing record and column is not modified
					else { if (value == _ori__Recurrence_FirstDayOfWeek) { _ori__Recurrence_FirstDayOfWeek = default(string); _mod__Recurrence_FirstDayOfWeek = false; } } // existing record and column is modified
				}
				_cur__Recurrence_FirstDayOfWeek = value; OnPropertyChanged("Recurrence_FirstDayOfWeek"); OnAfterPropertyChanged("Recurrence_FirstDayOfWeek");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Contains the recurrence duration type for calendar items and meeting requests.
		/// </summary>
		public string Recurrence_Duration
		{
			get { return _cur__Recurrence_Duration; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Recurrence_Duration = true;
				if (_cur__Recurrence_Duration == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Recurrence_Duration == false) { _ori__Recurrence_Duration = _cur__Recurrence_Duration; _mod__Recurrence_Duration = true; } // existing record and column is not modified
					else { if (value == _ori__Recurrence_Duration) { _ori__Recurrence_Duration = default(string); _mod__Recurrence_Duration = false; } } // existing record and column is modified
				}
				_cur__Recurrence_Duration = value; OnPropertyChanged("Recurrence_Duration"); OnAfterPropertyChanged("Recurrence_Duration");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Represents the start date of a recurring task or calendar item.
		/// </summary>
		public DateTime? Recurrence_StartDate
		{
			get { return _cur__Recurrence_StartDate; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Recurrence_StartDate = true;
				if (_cur__Recurrence_StartDate == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Recurrence_StartDate == false) { _ori__Recurrence_StartDate = _cur__Recurrence_StartDate; _mod__Recurrence_StartDate = true; } // existing record and column is not modified
					else { if (value == _ori__Recurrence_StartDate) { _ori__Recurrence_StartDate = default(DateTime?); _mod__Recurrence_StartDate = false; } } // existing record and column is modified
				}
				_cur__Recurrence_StartDate = value; OnPropertyChanged("Recurrence_StartDate"); OnAfterPropertyChanged("Recurrence_StartDate");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Represents the end date of a recurring task or calendar item.
		/// </summary>
		public DateTime? Recurrence_EndDate
		{
			get { return _cur__Recurrence_EndDate; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Recurrence_EndDate = true;
				if (_cur__Recurrence_EndDate == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Recurrence_EndDate == false) { _ori__Recurrence_EndDate = _cur__Recurrence_EndDate; _mod__Recurrence_EndDate = true; } // existing record and column is not modified
					else { if (value == _ori__Recurrence_EndDate) { _ori__Recurrence_EndDate = default(DateTime?); _mod__Recurrence_EndDate = false; } } // existing record and column is modified
				}
				_cur__Recurrence_EndDate = value; OnPropertyChanged("Recurrence_EndDate"); OnAfterPropertyChanged("Recurrence_EndDate");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Contains the number of occurrences of a recurring item.
		/// </summary>
		public int? Recurrence_NumberOfOccurrences
		{
			get { return _cur__Recurrence_NumberOfOccurrences; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Recurrence_NumberOfOccurrences = true;
				if (_cur__Recurrence_NumberOfOccurrences == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Recurrence_NumberOfOccurrences == false) { _ori__Recurrence_NumberOfOccurrences = _cur__Recurrence_NumberOfOccurrences; _mod__Recurrence_NumberOfOccurrences = true; } // existing record and column is not modified
					else { if (value == _ori__Recurrence_NumberOfOccurrences) { _ori__Recurrence_NumberOfOccurrences = default(int?); _mod__Recurrence_NumberOfOccurrences = false; } } // existing record and column is modified
				}
				_cur__Recurrence_NumberOfOccurrences = value; OnPropertyChanged("Recurrence_NumberOfOccurrences"); OnAfterPropertyChanged("Recurrence_NumberOfOccurrences");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Contains the unique identifier of the last occurrence of a recurring calendar item.
		/// </summary>
		public string FirstOccurrence_ItemId
		{
			get { return _cur__FirstOccurrence_ItemId; }
			set
			{
				if (_started_with_dbvalues == false) _mod__FirstOccurrence_ItemId = true;
				if (_cur__FirstOccurrence_ItemId == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__FirstOccurrence_ItemId == false) { _ori__FirstOccurrence_ItemId = _cur__FirstOccurrence_ItemId; _mod__FirstOccurrence_ItemId = true; } // existing record and column is not modified
					else { if (value == _ori__FirstOccurrence_ItemId) { _ori__FirstOccurrence_ItemId = default(string); _mod__FirstOccurrence_ItemId = false; } } // existing record and column is modified
				}
				_cur__FirstOccurrence_ItemId = value; OnPropertyChanged("FirstOccurrence_ItemId"); OnAfterPropertyChanged("FirstOccurrence_ItemId");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Represents the start time of the last occurrence of a recurring calendar item.
		/// </summary>
		public DateTime? FirstOccurrence_Start
		{
			get { return _cur__FirstOccurrence_Start; }
			set
			{
				if (_started_with_dbvalues == false) _mod__FirstOccurrence_Start = true;
				if (_cur__FirstOccurrence_Start == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__FirstOccurrence_Start == false) { _ori__FirstOccurrence_Start = _cur__FirstOccurrence_Start; _mod__FirstOccurrence_Start = true; } // existing record and column is not modified
					else { if (value == _ori__FirstOccurrence_Start) { _ori__FirstOccurrence_Start = default(DateTime?); _mod__FirstOccurrence_Start = false; } } // existing record and column is modified
				}
				_cur__FirstOccurrence_Start = value; OnPropertyChanged("FirstOccurrence_Start"); OnAfterPropertyChanged("FirstOccurrence_Start");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Represents the end time of the last occurrence of a recurring calendar item.
		/// </summary>
		public DateTime? FirstOccurrence_End
		{
			get { return _cur__FirstOccurrence_End; }
			set
			{
				if (_started_with_dbvalues == false) _mod__FirstOccurrence_End = true;
				if (_cur__FirstOccurrence_End == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__FirstOccurrence_End == false) { _ori__FirstOccurrence_End = _cur__FirstOccurrence_End; _mod__FirstOccurrence_End = true; } // existing record and column is not modified
					else { if (value == _ori__FirstOccurrence_End) { _ori__FirstOccurrence_End = default(DateTime?); _mod__FirstOccurrence_End = false; } } // existing record and column is modified
				}
				_cur__FirstOccurrence_End = value; OnPropertyChanged("FirstOccurrence_End"); OnAfterPropertyChanged("FirstOccurrence_End");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Represents the original start time of the last occurrence of a recurring calendar item.
		/// </summary>
		public DateTime? FirstOccurrence_OriginalStart
		{
			get { return _cur__FirstOccurrence_OriginalStart; }
			set
			{
				if (_started_with_dbvalues == false) _mod__FirstOccurrence_OriginalStart = true;
				if (_cur__FirstOccurrence_OriginalStart == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__FirstOccurrence_OriginalStart == false) { _ori__FirstOccurrence_OriginalStart = _cur__FirstOccurrence_OriginalStart; _mod__FirstOccurrence_OriginalStart = true; } // existing record and column is not modified
					else { if (value == _ori__FirstOccurrence_OriginalStart) { _ori__FirstOccurrence_OriginalStart = default(DateTime?); _mod__FirstOccurrence_OriginalStart = false; } } // existing record and column is modified
				}
				_cur__FirstOccurrence_OriginalStart = value; OnPropertyChanged("FirstOccurrence_OriginalStart"); OnAfterPropertyChanged("FirstOccurrence_OriginalStart");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Contains the unique identifier of the last occurrence of a recurring calendar item.
		/// </summary>
		public string LastOccurrence_ItemId
		{
			get { return _cur__LastOccurrence_ItemId; }
			set
			{
				if (_started_with_dbvalues == false) _mod__LastOccurrence_ItemId = true;
				if (_cur__LastOccurrence_ItemId == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__LastOccurrence_ItemId == false) { _ori__LastOccurrence_ItemId = _cur__LastOccurrence_ItemId; _mod__LastOccurrence_ItemId = true; } // existing record and column is not modified
					else { if (value == _ori__LastOccurrence_ItemId) { _ori__LastOccurrence_ItemId = default(string); _mod__LastOccurrence_ItemId = false; } } // existing record and column is modified
				}
				_cur__LastOccurrence_ItemId = value; OnPropertyChanged("LastOccurrence_ItemId"); OnAfterPropertyChanged("LastOccurrence_ItemId");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Represents the start time of the last occurrence of a recurring calendar item.
		/// </summary>
		public DateTime? LastOccurrence_Start
		{
			get { return _cur__LastOccurrence_Start; }
			set
			{
				if (_started_with_dbvalues == false) _mod__LastOccurrence_Start = true;
				if (_cur__LastOccurrence_Start == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__LastOccurrence_Start == false) { _ori__LastOccurrence_Start = _cur__LastOccurrence_Start; _mod__LastOccurrence_Start = true; } // existing record and column is not modified
					else { if (value == _ori__LastOccurrence_Start) { _ori__LastOccurrence_Start = default(DateTime?); _mod__LastOccurrence_Start = false; } } // existing record and column is modified
				}
				_cur__LastOccurrence_Start = value; OnPropertyChanged("LastOccurrence_Start"); OnAfterPropertyChanged("LastOccurrence_Start");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Represents the end time of the last occurrence of a recurring calendar item.
		/// </summary>
		public DateTime? LastOccurrence_End
		{
			get { return _cur__LastOccurrence_End; }
			set
			{
				if (_started_with_dbvalues == false) _mod__LastOccurrence_End = true;
				if (_cur__LastOccurrence_End == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__LastOccurrence_End == false) { _ori__LastOccurrence_End = _cur__LastOccurrence_End; _mod__LastOccurrence_End = true; } // existing record and column is not modified
					else { if (value == _ori__LastOccurrence_End) { _ori__LastOccurrence_End = default(DateTime?); _mod__LastOccurrence_End = false; } } // existing record and column is modified
				}
				_cur__LastOccurrence_End = value; OnPropertyChanged("LastOccurrence_End"); OnAfterPropertyChanged("LastOccurrence_End");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Represents the original start time of the last occurrence of a recurring calendar item.
		/// </summary>
		public DateTime? LastOccurrence_OriginalStart
		{
			get { return _cur__LastOccurrence_OriginalStart; }
			set
			{
				if (_started_with_dbvalues == false) _mod__LastOccurrence_OriginalStart = true;
				if (_cur__LastOccurrence_OriginalStart == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__LastOccurrence_OriginalStart == false) { _ori__LastOccurrence_OriginalStart = _cur__LastOccurrence_OriginalStart; _mod__LastOccurrence_OriginalStart = true; } // existing record and column is not modified
					else { if (value == _ori__LastOccurrence_OriginalStart) { _ori__LastOccurrence_OriginalStart = default(DateTime?); _mod__LastOccurrence_OriginalStart = false; } } // existing record and column is modified
				}
				_cur__LastOccurrence_OriginalStart = value; OnPropertyChanged("LastOccurrence_OriginalStart"); OnAfterPropertyChanged("LastOccurrence_OriginalStart");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
		/// Modified occurrences of the calendar, as aggregate.
		/// </summary>
		public string ModifiedOccurrences_Aggregate
		{
			get { return _cur__ModifiedOccurrences_Aggregate; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ModifiedOccurrences_Aggregate = true;
				if (_cur__ModifiedOccurrences_Aggregate == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ModifiedOccurrences_Aggregate == false) { _ori__ModifiedOccurrences_Aggregate = _cur__ModifiedOccurrences_Aggregate; _mod__ModifiedOccurrences_Aggregate = true; } // existing record and column is not modified
					else { if (value == _ori__ModifiedOccurrences_Aggregate) { _ori__ModifiedOccurrences_Aggregate = default(string); _mod__ModifiedOccurrences_Aggregate = false; } } // existing record and column is modified
				}
				_cur__ModifiedOccurrences_Aggregate = value; OnPropertyChanged("ModifiedOccurrences_Aggregate"); OnAfterPropertyChanged("ModifiedOccurrences_Aggregate");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
		/// Deleted occurrences as aggregate.
		/// </summary>
		public string DeletedOccurrences_Aggregate
		{
			get { return _cur__DeletedOccurrences_Aggregate; }
			set
			{
				if (_started_with_dbvalues == false) _mod__DeletedOccurrences_Aggregate = true;
				if (_cur__DeletedOccurrences_Aggregate == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__DeletedOccurrences_Aggregate == false) { _ori__DeletedOccurrences_Aggregate = _cur__DeletedOccurrences_Aggregate; _mod__DeletedOccurrences_Aggregate = true; } // existing record and column is not modified
					else { if (value == _ori__DeletedOccurrences_Aggregate) { _ori__DeletedOccurrences_Aggregate = default(string); _mod__DeletedOccurrences_Aggregate = false; } } // existing record and column is modified
				}
				_cur__DeletedOccurrences_Aggregate = value; OnPropertyChanged("DeletedOccurrences_Aggregate"); OnAfterPropertyChanged("DeletedOccurrences_Aggregate");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
		/// Represents the unique identifier of the time zone definition for the start time.
		/// </summary>
		public string StartTimeZone_Id
		{
			get { return _cur__StartTimeZone_Id; }
			set
			{
				if (_started_with_dbvalues == false) _mod__StartTimeZone_Id = true;
				if (_cur__StartTimeZone_Id == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__StartTimeZone_Id == false) { _ori__StartTimeZone_Id = _cur__StartTimeZone_Id; _mod__StartTimeZone_Id = true; } // existing record and column is not modified
					else { if (value == _ori__StartTimeZone_Id) { _ori__StartTimeZone_Id = default(string); _mod__StartTimeZone_Id = false; } } // existing record and column is modified
				}
				_cur__StartTimeZone_Id = value; OnPropertyChanged("StartTimeZone_Id"); OnAfterPropertyChanged("StartTimeZone_Id");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
		/// Represents the descriptive name of the time zone definition for the start time.
		/// </summary>
		public string StartTimeZone_Name
		{
			get { return _cur__StartTimeZone_Name; }
			set
			{
				if (_started_with_dbvalues == false) _mod__StartTimeZone_Name = true;
				if (_cur__StartTimeZone_Name == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__StartTimeZone_Name == false) { _ori__StartTimeZone_Name = _cur__StartTimeZone_Name; _mod__StartTimeZone_Name = true; } // existing record and column is not modified
					else { if (value == _ori__StartTimeZone_Name) { _ori__StartTimeZone_Name = default(string); _mod__StartTimeZone_Name = false; } } // existing record and column is modified
				}
				_cur__StartTimeZone_Name = value; OnPropertyChanged("StartTimeZone_Name"); OnAfterPropertyChanged("StartTimeZone_Name");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
		/// Represents the unique identifier of the time zone definition for the end time.
		/// </summary>
		public string EndTimeZone_Id
		{
			get { return _cur__EndTimeZone_Id; }
			set
			{
				if (_started_with_dbvalues == false) _mod__EndTimeZone_Id = true;
				if (_cur__EndTimeZone_Id == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__EndTimeZone_Id == false) { _ori__EndTimeZone_Id = _cur__EndTimeZone_Id; _mod__EndTimeZone_Id = true; } // existing record and column is not modified
					else { if (value == _ori__EndTimeZone_Id) { _ori__EndTimeZone_Id = default(string); _mod__EndTimeZone_Id = false; } } // existing record and column is modified
				}
				_cur__EndTimeZone_Id = value; OnPropertyChanged("EndTimeZone_Id"); OnAfterPropertyChanged("EndTimeZone_Id");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
		/// Represents the descriptive name of the time zone definition for the end time.
		/// </summary>
		public string EndTimeZone_Name
		{
			get { return _cur__EndTimeZone_Name; }
			set
			{
				if (_started_with_dbvalues == false) _mod__EndTimeZone_Name = true;
				if (_cur__EndTimeZone_Name == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__EndTimeZone_Name == false) { _ori__EndTimeZone_Name = _cur__EndTimeZone_Name; _mod__EndTimeZone_Name = true; } // existing record and column is not modified
					else { if (value == _ori__EndTimeZone_Name) { _ori__EndTimeZone_Name = default(string); _mod__EndTimeZone_Name = false; } } // existing record and column is modified
				}
				_cur__EndTimeZone_Name = value; OnPropertyChanged("EndTimeZone_Name"); OnAfterPropertyChanged("EndTimeZone_Name");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Describes the type of conferencing that is performed with a calendar item (0 = NetMeeting, 1 = NetShow, 2 = Chat.
		/// </summary>
		public int? ConferenceType
		{
			get { return _cur__ConferenceType; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ConferenceType = true;
				if (_cur__ConferenceType == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ConferenceType == false) { _ori__ConferenceType = _cur__ConferenceType; _mod__ConferenceType = true; } // existing record and column is not modified
					else { if (value == _ori__ConferenceType) { _ori__ConferenceType = default(int?); _mod__ConferenceType = false; } } // existing record and column is modified
				}
				_cur__ConferenceType = value; OnPropertyChanged("ConferenceType"); OnAfterPropertyChanged("ConferenceType");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Indicates whether a new meeting time can be proposed for a meeting by an attendee.
		/// </summary>
		public bool? AllowNewTimeProposal
		{
			get { return _cur__AllowNewTimeProposal; }
			set
			{
				if (_started_with_dbvalues == false) _mod__AllowNewTimeProposal = true;
				if (_cur__AllowNewTimeProposal == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__AllowNewTimeProposal == false) { _ori__AllowNewTimeProposal = _cur__AllowNewTimeProposal; _mod__AllowNewTimeProposal = true; } // existing record and column is not modified
					else { if (value == _ori__AllowNewTimeProposal) { _ori__AllowNewTimeProposal = default(bool?); _mod__AllowNewTimeProposal = false; } } // existing record and column is modified
				}
				_cur__AllowNewTimeProposal = value; OnPropertyChanged("AllowNewTimeProposal"); OnAfterPropertyChanged("AllowNewTimeProposal");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Indicates whether the meeting is online.
		/// </summary>
		public bool? IsOnlineMeeting
		{
			get { return _cur__IsOnlineMeeting; }
			set
			{
				if (_started_with_dbvalues == false) _mod__IsOnlineMeeting = true;
				if (_cur__IsOnlineMeeting == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__IsOnlineMeeting == false) { _ori__IsOnlineMeeting = _cur__IsOnlineMeeting; _mod__IsOnlineMeeting = true; } // existing record and column is not modified
					else { if (value == _ori__IsOnlineMeeting) { _ori__IsOnlineMeeting = default(bool?); _mod__IsOnlineMeeting = false; } } // existing record and column is modified
				}
				_cur__IsOnlineMeeting = value; OnPropertyChanged("IsOnlineMeeting"); OnAfterPropertyChanged("IsOnlineMeeting");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Contains the URL for the meeting workspace that is linked to by the calendar item.
		/// </summary>
		public string MeetingWorkspaceUrl
		{
			get { return _cur__MeetingWorkspaceUrl; }
			set
			{
				if (_started_with_dbvalues == false) _mod__MeetingWorkspaceUrl = true;
				if (_cur__MeetingWorkspaceUrl == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__MeetingWorkspaceUrl == false) { _ori__MeetingWorkspaceUrl = _cur__MeetingWorkspaceUrl; _mod__MeetingWorkspaceUrl = true; } // existing record and column is not modified
					else { if (value == _ori__MeetingWorkspaceUrl) { _ori__MeetingWorkspaceUrl = default(string); _mod__MeetingWorkspaceUrl = false; } } // existing record and column is modified
				}
				_cur__MeetingWorkspaceUrl = value; OnPropertyChanged("MeetingWorkspaceUrl"); OnAfterPropertyChanged("MeetingWorkspaceUrl");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
		/// Specifies the URL for a Microsoft NetShow online meeting.
		/// </summary>
		public string NetShowUrl
		{
			get { return _cur__NetShowUrl; }
			set
			{
				if (_started_with_dbvalues == false) _mod__NetShowUrl = true;
				if (_cur__NetShowUrl == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__NetShowUrl == false) { _ori__NetShowUrl = _cur__NetShowUrl; _mod__NetShowUrl = true; } // existing record and column is not modified
					else { if (value == _ori__NetShowUrl) { _ori__NetShowUrl = default(string); _mod__NetShowUrl = false; } } // existing record and column is modified
				}
				_cur__NetShowUrl = value; OnPropertyChanged("NetShowUrl"); OnAfterPropertyChanged("NetShowUrl");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
		/// Indicates when an item was last modified.
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
		/// Database Column Updateable. Table [Exchange].[Calendar]. NotReadonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
		/// Contains the identifier of an item or conversation.
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
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Calendar]. Readonly. AllowNull.
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
			if (column_name == "Start") return _mod__Start;
			if (column_name == "End") return _mod__End;
			if (column_name == "OriginalStart") return _mod__OriginalStart;
			if (column_name == "IsAllDayEvent") return _mod__IsAllDayEvent;
			if (column_name == "LegacyFreeBusyStatus") return _mod__LegacyFreeBusyStatus;
			if (column_name == "Location") return _mod__Location;
			if (column_name == "When") return _mod__When;
			if (column_name == "IsMeeting") return _mod__IsMeeting;
			if (column_name == "IsCancelled") return _mod__IsCancelled;
			if (column_name == "IsRecurring") return _mod__IsRecurring;
			if (column_name == "MeetingRequestWasSent") return _mod__MeetingRequestWasSent;
			if (column_name == "IsResponseRequested") return _mod__IsResponseRequested;
			if (column_name == "CalendarItemType") return _mod__CalendarItemType;
			if (column_name == "MyResponseType") return _mod__MyResponseType;
			if (column_name == "OrganizerName") return _mod__OrganizerName;
			if (column_name == "OrganizerEmailAddress") return _mod__OrganizerEmailAddress;
			if (column_name == "OrganizerRoutingType") return _mod__OrganizerRoutingType;
			if (column_name == "ConflictingMeetingCount") return _mod__ConflictingMeetingCount;
			if (column_name == "AdjacentMeetingCount") return _mod__AdjacentMeetingCount;
			if (column_name == "Duration") return _mod__Duration;
			if (column_name == "TimeZone") return _mod__TimeZone;
			if (column_name == "AppointmentReplyTime") return _mod__AppointmentReplyTime;
			if (column_name == "AppointmentSequenceNumber") return _mod__AppointmentSequenceNumber;
			if (column_name == "AppointmentState") return _mod__AppointmentState;
			if (column_name == "Recurrence_Type") return _mod__Recurrence_Type;
			if (column_name == "Recurrence_DaysOfWeek") return _mod__Recurrence_DaysOfWeek;
			if (column_name == "Recurrence_DayOfWeekIndex") return _mod__Recurrence_DayOfWeekIndex;
			if (column_name == "Recurrence_Month") return _mod__Recurrence_Month;
			if (column_name == "Recurrence_DayOfMonth") return _mod__Recurrence_DayOfMonth;
			if (column_name == "Recurrence_Interval") return _mod__Recurrence_Interval;
			if (column_name == "Recurrence_FirstDayOfWeek") return _mod__Recurrence_FirstDayOfWeek;
			if (column_name == "Recurrence_Duration") return _mod__Recurrence_Duration;
			if (column_name == "Recurrence_StartDate") return _mod__Recurrence_StartDate;
			if (column_name == "Recurrence_EndDate") return _mod__Recurrence_EndDate;
			if (column_name == "Recurrence_NumberOfOccurrences") return _mod__Recurrence_NumberOfOccurrences;
			if (column_name == "FirstOccurrence_ItemId") return _mod__FirstOccurrence_ItemId;
			if (column_name == "FirstOccurrence_Start") return _mod__FirstOccurrence_Start;
			if (column_name == "FirstOccurrence_End") return _mod__FirstOccurrence_End;
			if (column_name == "FirstOccurrence_OriginalStart") return _mod__FirstOccurrence_OriginalStart;
			if (column_name == "LastOccurrence_ItemId") return _mod__LastOccurrence_ItemId;
			if (column_name == "LastOccurrence_Start") return _mod__LastOccurrence_Start;
			if (column_name == "LastOccurrence_End") return _mod__LastOccurrence_End;
			if (column_name == "LastOccurrence_OriginalStart") return _mod__LastOccurrence_OriginalStart;
			if (column_name == "ModifiedOccurrences_Aggregate") return _mod__ModifiedOccurrences_Aggregate;
			if (column_name == "DeletedOccurrences_Aggregate") return _mod__DeletedOccurrences_Aggregate;
			if (column_name == "StartTimeZone_Id") return _mod__StartTimeZone_Id;
			if (column_name == "StartTimeZone_Name") return _mod__StartTimeZone_Name;
			if (column_name == "EndTimeZone_Id") return _mod__EndTimeZone_Id;
			if (column_name == "EndTimeZone_Name") return _mod__EndTimeZone_Name;
			if (column_name == "ConferenceType") return _mod__ConferenceType;
			if (column_name == "AllowNewTimeProposal") return _mod__AllowNewTimeProposal;
			if (column_name == "IsOnlineMeeting") return _mod__IsOnlineMeeting;
			if (column_name == "MeetingWorkspaceUrl") return _mod__MeetingWorkspaceUrl;
			if (column_name == "NetShowUrl") return _mod__NetShowUrl;
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
			if (column_name == "ConversationChangeKey") return _mod__ConversationChangeKey;
			if (column_name == "UniqueBody") return _mod__UniqueBody;
			if (column_name == "UniqueBodyType") return _mod__UniqueBodyType;
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
			if (_mod__Start == true) count++;
			if (_mod__End == true) count++;
			if (_mod__OriginalStart == true) count++;
			if (_mod__IsAllDayEvent == true) count++;
			if (_mod__LegacyFreeBusyStatus == true) count++;
			if (_mod__Location == true) count++;
			if (_mod__When == true) count++;
			if (_mod__IsMeeting == true) count++;
			if (_mod__IsCancelled == true) count++;
			if (_mod__IsRecurring == true) count++;
			if (_mod__MeetingRequestWasSent == true) count++;
			if (_mod__IsResponseRequested == true) count++;
			if (_mod__CalendarItemType == true) count++;
			if (_mod__MyResponseType == true) count++;
			if (_mod__OrganizerName == true) count++;
			if (_mod__OrganizerEmailAddress == true) count++;
			if (_mod__OrganizerRoutingType == true) count++;
			if (_mod__ConflictingMeetingCount == true) count++;
			if (_mod__AdjacentMeetingCount == true) count++;
			if (_mod__Duration == true) count++;
			if (_mod__TimeZone == true) count++;
			if (_mod__AppointmentReplyTime == true) count++;
			if (_mod__AppointmentSequenceNumber == true) count++;
			if (_mod__AppointmentState == true) count++;
			if (_mod__Recurrence_Type == true) count++;
			if (_mod__Recurrence_DaysOfWeek == true) count++;
			if (_mod__Recurrence_DayOfWeekIndex == true) count++;
			if (_mod__Recurrence_Month == true) count++;
			if (_mod__Recurrence_DayOfMonth == true) count++;
			if (_mod__Recurrence_Interval == true) count++;
			if (_mod__Recurrence_FirstDayOfWeek == true) count++;
			if (_mod__Recurrence_Duration == true) count++;
			if (_mod__Recurrence_StartDate == true) count++;
			if (_mod__Recurrence_EndDate == true) count++;
			if (_mod__Recurrence_NumberOfOccurrences == true) count++;
			if (_mod__FirstOccurrence_ItemId == true) count++;
			if (_mod__FirstOccurrence_Start == true) count++;
			if (_mod__FirstOccurrence_End == true) count++;
			if (_mod__FirstOccurrence_OriginalStart == true) count++;
			if (_mod__LastOccurrence_ItemId == true) count++;
			if (_mod__LastOccurrence_Start == true) count++;
			if (_mod__LastOccurrence_End == true) count++;
			if (_mod__LastOccurrence_OriginalStart == true) count++;
			if (_mod__ModifiedOccurrences_Aggregate == true) count++;
			if (_mod__DeletedOccurrences_Aggregate == true) count++;
			if (_mod__StartTimeZone_Id == true) count++;
			if (_mod__StartTimeZone_Name == true) count++;
			if (_mod__EndTimeZone_Id == true) count++;
			if (_mod__EndTimeZone_Name == true) count++;
			if (_mod__ConferenceType == true) count++;
			if (_mod__AllowNewTimeProposal == true) count++;
			if (_mod__IsOnlineMeeting == true) count++;
			if (_mod__MeetingWorkspaceUrl == true) count++;
			if (_mod__NetShowUrl == true) count++;
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
			if (_mod__ConversationChangeKey == true) count++;
			if (_mod__UniqueBody == true) count++;
			if (_mod__UniqueBodyType == true) count++;
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
			if (_mod__Start == true) count++;
			if (_mod__End == true) count++;
			if (_mod__OriginalStart == true) count++;
			if (_mod__IsAllDayEvent == true) count++;
			if (_mod__LegacyFreeBusyStatus == true) count++;
			if (_mod__Location == true) count++;
			if (_mod__When == true) count++;
			if (_mod__IsMeeting == true) count++;
			if (_mod__IsCancelled == true) count++;
			if (_mod__MyResponseType == true) count++;
			if (_mod__OrganizerName == true) count++;
			if (_mod__OrganizerEmailAddress == true) count++;
			if (_mod__OrganizerRoutingType == true) count++;
			if (_mod__AppointmentReplyTime == true) count++;
			if (_mod__AppointmentSequenceNumber == true) count++;
			if (_mod__Recurrence_Type == true) count++;
			if (_mod__Recurrence_DaysOfWeek == true) count++;
			if (_mod__Recurrence_DayOfWeekIndex == true) count++;
			if (_mod__Recurrence_Month == true) count++;
			if (_mod__Recurrence_DayOfMonth == true) count++;
			if (_mod__Recurrence_Interval == true) count++;
			if (_mod__Recurrence_FirstDayOfWeek == true) count++;
			if (_mod__Recurrence_Duration == true) count++;
			if (_mod__Recurrence_StartDate == true) count++;
			if (_mod__Recurrence_EndDate == true) count++;
			if (_mod__Recurrence_NumberOfOccurrences == true) count++;
			if (_mod__FirstOccurrence_ItemId == true) count++;
			if (_mod__FirstOccurrence_Start == true) count++;
			if (_mod__FirstOccurrence_End == true) count++;
			if (_mod__FirstOccurrence_OriginalStart == true) count++;
			if (_mod__LastOccurrence_ItemId == true) count++;
			if (_mod__LastOccurrence_Start == true) count++;
			if (_mod__LastOccurrence_End == true) count++;
			if (_mod__LastOccurrence_OriginalStart == true) count++;
			if (_mod__ConferenceType == true) count++;
			if (_mod__AllowNewTimeProposal == true) count++;
			if (_mod__IsOnlineMeeting == true) count++;
			if (_mod__MeetingWorkspaceUrl == true) count++;
			if (_mod__NetShowUrl == true) count++;
			if (_mod__IsAssociated == true) count++;
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
				if (_cur__Start != null) track_array.AppendDataValue(29, _cur__Start);
				if (_cur__End != null) track_array.AppendDataValue(30, _cur__End);
				if (_cur__OriginalStart != null) track_array.AppendDataValue(31, _cur__OriginalStart);
				if (_cur__IsAllDayEvent != null) track_array.AppendDataValue(32, _cur__IsAllDayEvent);
				if (_cur__LegacyFreeBusyStatus != null) track_array.AppendDataValue(33, _cur__LegacyFreeBusyStatus);
				if (_cur__Location != null) track_array.AppendDataValue(34, _cur__Location);
				if (_cur__When != null) track_array.AppendDataValue(35, _cur__When);
				if (_cur__IsMeeting != null) track_array.AppendDataValue(36, _cur__IsMeeting);
				if (_cur__IsCancelled != null) track_array.AppendDataValue(37, _cur__IsCancelled);
				if (_cur__MyResponseType != null) track_array.AppendDataValue(42, _cur__MyResponseType);
				if (_cur__OrganizerName != null) track_array.AppendDataValue(43, _cur__OrganizerName);
				if (_cur__OrganizerEmailAddress != null) track_array.AppendDataValue(44, _cur__OrganizerEmailAddress);
				if (_cur__OrganizerRoutingType != null) track_array.AppendDataValue(45, _cur__OrganizerRoutingType);
				if (_cur__AppointmentReplyTime != null) track_array.AppendDataValue(50, _cur__AppointmentReplyTime);
				if (_cur__AppointmentSequenceNumber != null) track_array.AppendDataValue(51, _cur__AppointmentSequenceNumber);
				if (_cur__Recurrence_Type != null) track_array.AppendDataValue(53, _cur__Recurrence_Type);
				if (_cur__Recurrence_DaysOfWeek != null) track_array.AppendDataValue(54, _cur__Recurrence_DaysOfWeek);
				if (_cur__Recurrence_DayOfWeekIndex != null) track_array.AppendDataValue(55, _cur__Recurrence_DayOfWeekIndex);
				if (_cur__Recurrence_Month != null) track_array.AppendDataValue(56, _cur__Recurrence_Month);
				if (_cur__Recurrence_DayOfMonth != null) track_array.AppendDataValue(57, _cur__Recurrence_DayOfMonth);
				if (_cur__Recurrence_Interval != null) track_array.AppendDataValue(58, _cur__Recurrence_Interval);
				if (_cur__Recurrence_FirstDayOfWeek != null) track_array.AppendDataValue(59, _cur__Recurrence_FirstDayOfWeek);
				if (_cur__Recurrence_Duration != null) track_array.AppendDataValue(60, _cur__Recurrence_Duration);
				if (_cur__Recurrence_StartDate != null) track_array.AppendDataValue(61, _cur__Recurrence_StartDate);
				if (_cur__Recurrence_EndDate != null) track_array.AppendDataValue(62, _cur__Recurrence_EndDate);
				if (_cur__Recurrence_NumberOfOccurrences != null) track_array.AppendDataValue(63, _cur__Recurrence_NumberOfOccurrences);
				if (_cur__FirstOccurrence_ItemId != null) track_array.AppendDataValue(64, _cur__FirstOccurrence_ItemId);
				if (_cur__FirstOccurrence_Start != null) track_array.AppendDataValue(65, _cur__FirstOccurrence_Start);
				if (_cur__FirstOccurrence_End != null) track_array.AppendDataValue(66, _cur__FirstOccurrence_End);
				if (_cur__FirstOccurrence_OriginalStart != null) track_array.AppendDataValue(67, _cur__FirstOccurrence_OriginalStart);
				if (_cur__LastOccurrence_ItemId != null) track_array.AppendDataValue(68, _cur__LastOccurrence_ItemId);
				if (_cur__LastOccurrence_Start != null) track_array.AppendDataValue(69, _cur__LastOccurrence_Start);
				if (_cur__LastOccurrence_End != null) track_array.AppendDataValue(70, _cur__LastOccurrence_End);
				if (_cur__LastOccurrence_OriginalStart != null) track_array.AppendDataValue(71, _cur__LastOccurrence_OriginalStart);
				if (_cur__ConferenceType != null) track_array.AppendDataValue(78, _cur__ConferenceType);
				if (_cur__AllowNewTimeProposal != null) track_array.AppendDataValue(79, _cur__AllowNewTimeProposal);
				if (_cur__IsOnlineMeeting != null) track_array.AppendDataValue(80, _cur__IsOnlineMeeting);
				if (_cur__MeetingWorkspaceUrl != null) track_array.AppendDataValue(81, _cur__MeetingWorkspaceUrl);
				if (_cur__NetShowUrl != null) track_array.AppendDataValue(82, _cur__NetShowUrl);
				if (_cur__IsAssociated != null) track_array.AppendDataValue(92, _cur__IsAssociated);
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
				if (_mod__Start) track_array.AppendDataValue(29, _cur__Start);
				if (_mod__End) track_array.AppendDataValue(30, _cur__End);
				if (_mod__OriginalStart) track_array.AppendDataValue(31, _cur__OriginalStart);
				if (_mod__IsAllDayEvent) track_array.AppendDataValue(32, _cur__IsAllDayEvent);
				if (_mod__LegacyFreeBusyStatus) track_array.AppendDataValue(33, _cur__LegacyFreeBusyStatus);
				if (_mod__Location) track_array.AppendDataValue(34, _cur__Location);
				if (_mod__When) track_array.AppendDataValue(35, _cur__When);
				if (_mod__IsMeeting) track_array.AppendDataValue(36, _cur__IsMeeting);
				if (_mod__IsCancelled) track_array.AppendDataValue(37, _cur__IsCancelled);
				if (_mod__MyResponseType) track_array.AppendDataValue(42, _cur__MyResponseType);
				if (_mod__OrganizerName) track_array.AppendDataValue(43, _cur__OrganizerName);
				if (_mod__OrganizerEmailAddress) track_array.AppendDataValue(44, _cur__OrganizerEmailAddress);
				if (_mod__OrganizerRoutingType) track_array.AppendDataValue(45, _cur__OrganizerRoutingType);
				if (_mod__AppointmentReplyTime) track_array.AppendDataValue(50, _cur__AppointmentReplyTime);
				if (_mod__AppointmentSequenceNumber) track_array.AppendDataValue(51, _cur__AppointmentSequenceNumber);
				if (_mod__Recurrence_Type) track_array.AppendDataValue(53, _cur__Recurrence_Type);
				if (_mod__Recurrence_DaysOfWeek) track_array.AppendDataValue(54, _cur__Recurrence_DaysOfWeek);
				if (_mod__Recurrence_DayOfWeekIndex) track_array.AppendDataValue(55, _cur__Recurrence_DayOfWeekIndex);
				if (_mod__Recurrence_Month) track_array.AppendDataValue(56, _cur__Recurrence_Month);
				if (_mod__Recurrence_DayOfMonth) track_array.AppendDataValue(57, _cur__Recurrence_DayOfMonth);
				if (_mod__Recurrence_Interval) track_array.AppendDataValue(58, _cur__Recurrence_Interval);
				if (_mod__Recurrence_FirstDayOfWeek) track_array.AppendDataValue(59, _cur__Recurrence_FirstDayOfWeek);
				if (_mod__Recurrence_Duration) track_array.AppendDataValue(60, _cur__Recurrence_Duration);
				if (_mod__Recurrence_StartDate) track_array.AppendDataValue(61, _cur__Recurrence_StartDate);
				if (_mod__Recurrence_EndDate) track_array.AppendDataValue(62, _cur__Recurrence_EndDate);
				if (_mod__Recurrence_NumberOfOccurrences) track_array.AppendDataValue(63, _cur__Recurrence_NumberOfOccurrences);
				if (_mod__FirstOccurrence_ItemId) track_array.AppendDataValue(64, _cur__FirstOccurrence_ItemId);
				if (_mod__FirstOccurrence_Start) track_array.AppendDataValue(65, _cur__FirstOccurrence_Start);
				if (_mod__FirstOccurrence_End) track_array.AppendDataValue(66, _cur__FirstOccurrence_End);
				if (_mod__FirstOccurrence_OriginalStart) track_array.AppendDataValue(67, _cur__FirstOccurrence_OriginalStart);
				if (_mod__LastOccurrence_ItemId) track_array.AppendDataValue(68, _cur__LastOccurrence_ItemId);
				if (_mod__LastOccurrence_Start) track_array.AppendDataValue(69, _cur__LastOccurrence_Start);
				if (_mod__LastOccurrence_End) track_array.AppendDataValue(70, _cur__LastOccurrence_End);
				if (_mod__LastOccurrence_OriginalStart) track_array.AppendDataValue(71, _cur__LastOccurrence_OriginalStart);
				if (_mod__ConferenceType) track_array.AppendDataValue(78, _cur__ConferenceType);
				if (_mod__AllowNewTimeProposal) track_array.AppendDataValue(79, _cur__AllowNewTimeProposal);
				if (_mod__IsOnlineMeeting) track_array.AppendDataValue(80, _cur__IsOnlineMeeting);
				if (_mod__MeetingWorkspaceUrl) track_array.AppendDataValue(81, _cur__MeetingWorkspaceUrl);
				if (_mod__NetShowUrl) track_array.AppendDataValue(82, _cur__NetShowUrl);
				if (_mod__IsAssociated) track_array.AppendDataValue(92, _cur__IsAssociated);
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
				if (_mod__Start) _ori__Start = default(DateTime?);
				if (_mod__End) _ori__End = default(DateTime?);
				if (_mod__OriginalStart) _ori__OriginalStart = default(DateTime?);
				if (_mod__IsAllDayEvent) _ori__IsAllDayEvent = default(bool?);
				if (_mod__LegacyFreeBusyStatus) _ori__LegacyFreeBusyStatus = default(string);
				if (_mod__Location) _ori__Location = default(string);
				if (_mod__When) _ori__When = default(string);
				if (_mod__IsMeeting) _ori__IsMeeting = default(bool?);
				if (_mod__IsCancelled) _ori__IsCancelled = default(bool?);
				if (_mod__IsRecurring) _ori__IsRecurring = default(bool?);
				if (_mod__MeetingRequestWasSent) _ori__MeetingRequestWasSent = default(bool?);
				if (_mod__IsResponseRequested) _ori__IsResponseRequested = default(bool?);
				if (_mod__CalendarItemType) _ori__CalendarItemType = default(string);
				if (_mod__MyResponseType) _ori__MyResponseType = default(string);
				if (_mod__OrganizerName) _ori__OrganizerName = default(string);
				if (_mod__OrganizerEmailAddress) _ori__OrganizerEmailAddress = default(string);
				if (_mod__OrganizerRoutingType) _ori__OrganizerRoutingType = default(string);
				if (_mod__ConflictingMeetingCount) _ori__ConflictingMeetingCount = default(int?);
				if (_mod__AdjacentMeetingCount) _ori__AdjacentMeetingCount = default(int?);
				if (_mod__Duration) _ori__Duration = default(string);
				if (_mod__TimeZone) _ori__TimeZone = default(string);
				if (_mod__AppointmentReplyTime) _ori__AppointmentReplyTime = default(DateTime?);
				if (_mod__AppointmentSequenceNumber) _ori__AppointmentSequenceNumber = default(string);
				if (_mod__AppointmentState) _ori__AppointmentState = default(string);
				if (_mod__Recurrence_Type) _ori__Recurrence_Type = default(string);
				if (_mod__Recurrence_DaysOfWeek) _ori__Recurrence_DaysOfWeek = default(string);
				if (_mod__Recurrence_DayOfWeekIndex) _ori__Recurrence_DayOfWeekIndex = default(string);
				if (_mod__Recurrence_Month) _ori__Recurrence_Month = default(string);
				if (_mod__Recurrence_DayOfMonth) _ori__Recurrence_DayOfMonth = default(int?);
				if (_mod__Recurrence_Interval) _ori__Recurrence_Interval = default(int?);
				if (_mod__Recurrence_FirstDayOfWeek) _ori__Recurrence_FirstDayOfWeek = default(string);
				if (_mod__Recurrence_Duration) _ori__Recurrence_Duration = default(string);
				if (_mod__Recurrence_StartDate) _ori__Recurrence_StartDate = default(DateTime?);
				if (_mod__Recurrence_EndDate) _ori__Recurrence_EndDate = default(DateTime?);
				if (_mod__Recurrence_NumberOfOccurrences) _ori__Recurrence_NumberOfOccurrences = default(int?);
				if (_mod__FirstOccurrence_ItemId) _ori__FirstOccurrence_ItemId = default(string);
				if (_mod__FirstOccurrence_Start) _ori__FirstOccurrence_Start = default(DateTime?);
				if (_mod__FirstOccurrence_End) _ori__FirstOccurrence_End = default(DateTime?);
				if (_mod__FirstOccurrence_OriginalStart) _ori__FirstOccurrence_OriginalStart = default(DateTime?);
				if (_mod__LastOccurrence_ItemId) _ori__LastOccurrence_ItemId = default(string);
				if (_mod__LastOccurrence_Start) _ori__LastOccurrence_Start = default(DateTime?);
				if (_mod__LastOccurrence_End) _ori__LastOccurrence_End = default(DateTime?);
				if (_mod__LastOccurrence_OriginalStart) _ori__LastOccurrence_OriginalStart = default(DateTime?);
				if (_mod__ModifiedOccurrences_Aggregate) _ori__ModifiedOccurrences_Aggregate = default(string);
				if (_mod__DeletedOccurrences_Aggregate) _ori__DeletedOccurrences_Aggregate = default(string);
				if (_mod__StartTimeZone_Id) _ori__StartTimeZone_Id = default(string);
				if (_mod__StartTimeZone_Name) _ori__StartTimeZone_Name = default(string);
				if (_mod__EndTimeZone_Id) _ori__EndTimeZone_Id = default(string);
				if (_mod__EndTimeZone_Name) _ori__EndTimeZone_Name = default(string);
				if (_mod__ConferenceType) _ori__ConferenceType = default(int?);
				if (_mod__AllowNewTimeProposal) _ori__AllowNewTimeProposal = default(bool?);
				if (_mod__IsOnlineMeeting) _ori__IsOnlineMeeting = default(bool?);
				if (_mod__MeetingWorkspaceUrl) _ori__MeetingWorkspaceUrl = default(string);
				if (_mod__NetShowUrl) _ori__NetShowUrl = default(string);
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
				if (_mod__ConversationChangeKey) _ori__ConversationChangeKey = default(string);
				if (_mod__UniqueBody) _ori__UniqueBody = default(string);
				if (_mod__UniqueBodyType) _ori__UniqueBodyType = default(string);
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
			_mod__Start = false;
			_mod__End = false;
			_mod__OriginalStart = false;
			_mod__IsAllDayEvent = false;
			_mod__LegacyFreeBusyStatus = false;
			_mod__Location = false;
			_mod__When = false;
			_mod__IsMeeting = false;
			_mod__IsCancelled = false;
			_mod__IsRecurring = false;
			_mod__MeetingRequestWasSent = false;
			_mod__IsResponseRequested = false;
			_mod__CalendarItemType = false;
			_mod__MyResponseType = false;
			_mod__OrganizerName = false;
			_mod__OrganizerEmailAddress = false;
			_mod__OrganizerRoutingType = false;
			_mod__ConflictingMeetingCount = false;
			_mod__AdjacentMeetingCount = false;
			_mod__Duration = false;
			_mod__TimeZone = false;
			_mod__AppointmentReplyTime = false;
			_mod__AppointmentSequenceNumber = false;
			_mod__AppointmentState = false;
			_mod__Recurrence_Type = false;
			_mod__Recurrence_DaysOfWeek = false;
			_mod__Recurrence_DayOfWeekIndex = false;
			_mod__Recurrence_Month = false;
			_mod__Recurrence_DayOfMonth = false;
			_mod__Recurrence_Interval = false;
			_mod__Recurrence_FirstDayOfWeek = false;
			_mod__Recurrence_Duration = false;
			_mod__Recurrence_StartDate = false;
			_mod__Recurrence_EndDate = false;
			_mod__Recurrence_NumberOfOccurrences = false;
			_mod__FirstOccurrence_ItemId = false;
			_mod__FirstOccurrence_Start = false;
			_mod__FirstOccurrence_End = false;
			_mod__FirstOccurrence_OriginalStart = false;
			_mod__LastOccurrence_ItemId = false;
			_mod__LastOccurrence_Start = false;
			_mod__LastOccurrence_End = false;
			_mod__LastOccurrence_OriginalStart = false;
			_mod__ModifiedOccurrences_Aggregate = false;
			_mod__DeletedOccurrences_Aggregate = false;
			_mod__StartTimeZone_Id = false;
			_mod__StartTimeZone_Name = false;
			_mod__EndTimeZone_Id = false;
			_mod__EndTimeZone_Name = false;
			_mod__ConferenceType = false;
			_mod__AllowNewTimeProposal = false;
			_mod__IsOnlineMeeting = false;
			_mod__MeetingWorkspaceUrl = false;
			_mod__NetShowUrl = false;
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
			_mod__ConversationChangeKey = false;
			_mod__UniqueBody = false;
			_mod__UniqueBodyType = false;
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
	public partial class PriKey_Calendar_Record
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
