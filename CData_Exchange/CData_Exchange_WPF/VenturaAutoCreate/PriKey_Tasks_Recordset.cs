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
	/// The updateable table is [Exchange].[Tasks]. Updateable table column information:
	/// • 80 out of 80 table columns are present in the resultset.
	/// • All primary key columns are present in the resultset: ItemId.
	/// • Non-primary key columns present in the resultset: MimeContent, ItemChangeKey, ParentFolderId, ParentFolderChangeKey,
	///   ItemClass, Subject, Sensitivity, Body, DateTimeReceived, Size, Categories, InReplyTo, IsSubmitted, IsDraft, IsFromMe,
	///   IsResend, IsUnmodified, InternetMessageHeaders, DateTimeSent, DateTimeCreated, ReminderDueBy, ReminderIsSet,
	///   ReminderMinutesBeforeStart, DisplayCc, DisplayTo, HasAttachments, Culture, ActualWork, AssignedTime, BillingInformation,
	///   ChangeCount, Companies1, Companies2, Companies3, CompleteDate, Contacts1, Contacts2, Contacts3, DelegationState,
	///   Delegator, DueDate, IsAssignmentEditable, IsComplete, IsRecurring, IsTeamTask, Mileage, Owner, PercentComplete,
	///   Recurrence_Type, Recurrence_DaysOfWeek, Recurrence_DayOfWeekIndex, Recurrence_Month, Recurrence_DayOfMonth,
	///   Recurrence_Interval, Recurrence_FirstDayOfWeek, Recurrence_Duration, Recurrence_StartDate, Recurrence_EndDate,
	///   Recurrence_NumberOfOccurrences, StartDate, Status, StatusDescription, TotalWork, EffectiveRights_CreateAssociated,
	///   EffectiveRights_CreateContents, EffectiveRights_CreateHierarchy, EffectiveRights_Delete, EffectiveRights_Modify,
	///   EffectiveRights_Read, EffectiveRights_ViewPrivateItems, LastModifiedName, LastModifiedTime, IsAssociated,
	///   WebClientReadFormQueryString, WebClientEditFormQueryString, ConversationId, ConversationChangeKey, UniqueBody and
	///   UniqueBodyType.
	/// Recordset item automatically created by Ventura SQL Studio.
	/// </summary>
	public partial class PriKey_Tasks_Recordset : ResultsetObservable<PriKey_Tasks_Recordset, PriKey_Tasks_Record>, IRecordsetBase
	{
		private IResultsetBase[] _resultsets;
		private string _sqlscript;
		private object[] _inputparametervalues;
		private InputParamHolder _inputparamholder;
		private VenturaSchema _parameterschema;
		private int _rowlimit = 500;
		private const string CRLF = "\r\n";

		public PriKey_Tasks_Recordset()
		{
			_resultsets = new IResultsetBase[] { this };

			_sqlscript = @"SELECT [ItemId],[MimeContent],[ItemChangeKey],[ParentFolderId],[ParentFolderChangeKey],[ItemClass],[Subject],[Sensitivity],[Body],[DateTimeReceived],[Size]," + CRLF +
			             @"[Categories],[InReplyTo],[IsSubmitted],[IsDraft],[IsFromMe],[IsResend],[IsUnmodified],[InternetMessageHeaders],[DateTimeSent],[DateTimeCreated],[ReminderDueBy]," + CRLF +
			             @"[ReminderIsSet],[ReminderMinutesBeforeStart],[DisplayCc],[DisplayTo],[HasAttachments],[Culture],[ActualWork],[AssignedTime],[BillingInformation],[ChangeCount]," + CRLF +
			             @"[Companies1],[Companies2],[Companies3],[CompleteDate],[Contacts1],[Contacts2],[Contacts3],[DelegationState],[Delegator],[DueDate],[IsAssignmentEditable]," + CRLF +
			             @"[IsComplete],[IsRecurring],[IsTeamTask],[Mileage],[Owner],[PercentComplete],[Recurrence_Type],[Recurrence_DaysOfWeek],[Recurrence_DayOfWeekIndex],[Recurrence_Month]," + CRLF +
			             @"[Recurrence_DayOfMonth],[Recurrence_Interval],[Recurrence_FirstDayOfWeek],[Recurrence_Duration],[Recurrence_StartDate],[Recurrence_EndDate],[Recurrence_NumberOfOccurrences]," + CRLF +
			             @"[StartDate],[Status],[StatusDescription],[TotalWork],[EffectiveRights_CreateAssociated],[EffectiveRights_CreateContents],[EffectiveRights_CreateHierarchy]," + CRLF +
			             @"[EffectiveRights_Delete],[EffectiveRights_Modify],[EffectiveRights_Read],[EffectiveRights_ViewPrivateItems],[LastModifiedName],[LastModifiedTime],[IsAssociated]," + CRLF +
			             @"[WebClientReadFormQueryString],[WebClientEditFormQueryString],[ConversationId],[ConversationChangeKey],[UniqueBody],[UniqueBodyType]" + CRLF +
			             @"FROM [Exchange].[Tasks]" + CRLF +
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
				BaseTableName = "Tasks",
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
				BaseTableName = "Tasks",
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
				BaseTableName = "Tasks",
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
				BaseTableName = "Tasks",
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
				BaseTableName = "Tasks",
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
				BaseTableName = "Tasks",
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
				BaseTableName = "Tasks",
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
				BaseTableName = "Tasks",
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
				BaseTableName = "Tasks",
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
				BaseTableName = "Tasks",
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
				BaseTableName = "Tasks",
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
				BaseTableName = "Tasks",
				BaseColumnName = "Categories"
			});

			schema_array.Add(new VenturaColumn("InReplyTo", typeof(string), true)
			{
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Tasks",
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
				BaseTableName = "Tasks",
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
				BaseTableName = "Tasks",
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
				BaseTableName = "Tasks",
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
				BaseTableName = "Tasks",
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
				BaseTableName = "Tasks",
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
				BaseTableName = "Tasks",
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
				BaseTableName = "Tasks",
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
				BaseTableName = "Tasks",
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
				BaseTableName = "Tasks",
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
				BaseTableName = "Tasks",
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
				BaseTableName = "Tasks",
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
				BaseTableName = "Tasks",
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
				BaseTableName = "Tasks",
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
				BaseTableName = "Tasks",
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
				BaseTableName = "Tasks",
				BaseColumnName = "Culture"
			});

			schema_array.Add(new VenturaColumn("ActualWork", typeof(int), true)
			{
				Updateable = true,
				ColumnSize = 11,
				NumericPrecision = 10,
				NumericScale = 0,
				ProviderType = 11,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Tasks",
				BaseColumnName = "ActualWork"
			});

			schema_array.Add(new VenturaColumn("AssignedTime", typeof(DateTime), true)
			{
				Updateable = true,
				ColumnSize = 16,
				NumericPrecision = 8,
				NumericScale = 0,
				ProviderType = 6,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Tasks",
				BaseColumnName = "AssignedTime"
			});

			schema_array.Add(new VenturaColumn("BillingInformation", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Tasks",
				BaseColumnName = "BillingInformation"
			});

			schema_array.Add(new VenturaColumn("ChangeCount", typeof(int), true)
			{
				Updateable = true,
				ColumnSize = 11,
				NumericPrecision = 10,
				NumericScale = 0,
				ProviderType = 11,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Tasks",
				BaseColumnName = "ChangeCount"
			});

			schema_array.Add(new VenturaColumn("Companies1", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Tasks",
				BaseColumnName = "Companies1"
			});

			schema_array.Add(new VenturaColumn("Companies2", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Tasks",
				BaseColumnName = "Companies2"
			});

			schema_array.Add(new VenturaColumn("Companies3", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Tasks",
				BaseColumnName = "Companies3"
			});

			schema_array.Add(new VenturaColumn("CompleteDate", typeof(DateTime), true)
			{
				Updateable = true,
				ColumnSize = 16,
				NumericPrecision = 8,
				NumericScale = 0,
				ProviderType = 6,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Tasks",
				BaseColumnName = "CompleteDate"
			});

			schema_array.Add(new VenturaColumn("Contacts1", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Tasks",
				BaseColumnName = "Contacts1"
			});

			schema_array.Add(new VenturaColumn("Contacts2", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Tasks",
				BaseColumnName = "Contacts2"
			});

			schema_array.Add(new VenturaColumn("Contacts3", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Tasks",
				BaseColumnName = "Contacts3"
			});

			schema_array.Add(new VenturaColumn("DelegationState", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Tasks",
				BaseColumnName = "DelegationState"
			});

			schema_array.Add(new VenturaColumn("Delegator", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Tasks",
				BaseColumnName = "Delegator"
			});

			schema_array.Add(new VenturaColumn("DueDate", typeof(DateTime), true)
			{
				Updateable = true,
				ColumnSize = 16,
				NumericPrecision = 8,
				NumericScale = 0,
				ProviderType = 6,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Tasks",
				BaseColumnName = "DueDate"
			});

			schema_array.Add(new VenturaColumn("IsAssignmentEditable", typeof(bool), true)
			{
				Updateable = true,
				ColumnSize = 1,
				NumericPrecision = 1,
				NumericScale = 0,
				ProviderType = 3,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Tasks",
				BaseColumnName = "IsAssignmentEditable"
			});

			schema_array.Add(new VenturaColumn("IsComplete", typeof(bool), true)
			{
				Updateable = true,
				ColumnSize = 1,
				NumericPrecision = 1,
				NumericScale = 0,
				ProviderType = 3,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Tasks",
				BaseColumnName = "IsComplete"
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
				BaseTableName = "Tasks",
				BaseColumnName = "IsRecurring"
			});

			schema_array.Add(new VenturaColumn("IsTeamTask", typeof(bool), true)
			{
				Updateable = true,
				ColumnSize = 1,
				NumericPrecision = 1,
				NumericScale = 0,
				ProviderType = 3,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Tasks",
				BaseColumnName = "IsTeamTask"
			});

			schema_array.Add(new VenturaColumn("Mileage", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Tasks",
				BaseColumnName = "Mileage"
			});

			schema_array.Add(new VenturaColumn("Owner", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Tasks",
				BaseColumnName = "Owner"
			});

			schema_array.Add(new VenturaColumn("PercentComplete", typeof(double), true)
			{
				Updateable = true,
				ColumnSize = 22,
				NumericPrecision = 15,
				NumericScale = 0,
				ProviderType = 8,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Tasks",
				BaseColumnName = "PercentComplete"
			});

			schema_array.Add(new VenturaColumn("Recurrence_Type", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Tasks",
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
				BaseTableName = "Tasks",
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
				BaseTableName = "Tasks",
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
				BaseTableName = "Tasks",
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
				BaseTableName = "Tasks",
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
				BaseTableName = "Tasks",
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
				BaseTableName = "Tasks",
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
				BaseTableName = "Tasks",
				BaseColumnName = "Recurrence_Duration"
			});

			schema_array.Add(new VenturaColumn("Recurrence_StartDate", typeof(DateTime), true)
			{
				Updateable = true,
				ColumnSize = 16,
				NumericPrecision = 8,
				NumericScale = 0,
				ProviderType = 6,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Tasks",
				BaseColumnName = "Recurrence_StartDate"
			});

			schema_array.Add(new VenturaColumn("Recurrence_EndDate", typeof(DateTime), true)
			{
				Updateable = true,
				ColumnSize = 16,
				NumericPrecision = 8,
				NumericScale = 0,
				ProviderType = 6,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Tasks",
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
				BaseTableName = "Tasks",
				BaseColumnName = "Recurrence_NumberOfOccurrences"
			});

			schema_array.Add(new VenturaColumn("StartDate", typeof(DateTime), true)
			{
				Updateable = true,
				ColumnSize = 16,
				NumericPrecision = 8,
				NumericScale = 0,
				ProviderType = 6,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Tasks",
				BaseColumnName = "StartDate"
			});

			schema_array.Add(new VenturaColumn("Status", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Tasks",
				BaseColumnName = "Status"
			});

			schema_array.Add(new VenturaColumn("StatusDescription", typeof(string), true)
			{
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Tasks",
				BaseColumnName = "StatusDescription"
			});

			schema_array.Add(new VenturaColumn("TotalWork", typeof(int), true)
			{
				Updateable = true,
				ColumnSize = 11,
				NumericPrecision = 10,
				NumericScale = 0,
				ProviderType = 11,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Tasks",
				BaseColumnName = "TotalWork"
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
				BaseTableName = "Tasks",
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
				BaseTableName = "Tasks",
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
				BaseTableName = "Tasks",
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
				BaseTableName = "Tasks",
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
				BaseTableName = "Tasks",
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
				BaseTableName = "Tasks",
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
				BaseTableName = "Tasks",
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
				BaseTableName = "Tasks",
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
				BaseTableName = "Tasks",
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
				BaseTableName = "Tasks",
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
				BaseTableName = "Tasks",
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
				BaseTableName = "Tasks",
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
				BaseTableName = "Tasks",
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
				BaseTableName = "Tasks",
				BaseColumnName = "ConversationChangeKey"
			});

			schema_array.Add(new VenturaColumn("UniqueBody", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Tasks",
				BaseColumnName = "UniqueBody"
			});

			schema_array.Add(new VenturaColumn("UniqueBodyType", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Tasks",
				BaseColumnName = "UniqueBodyType"
			});

			((IResultsetBase)this).Schema = new VenturaSchema(schema_array);
			((IResultsetBase)this).UpdateableTablename = "[Exchange].[Tasks]";
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. PrimaryKey. Readonly. AllowNull.
		/// Contains the unique identifier of an item in the Exchange store. This property is read-only.
		/// </summary>
		public string ItemId
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ItemId; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ItemId = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
		/// Contains the native Multipurpose Internet Mail Extensions (MIME) stream of an object that is represented in Base64
		/// binary format.
		/// </summary>
		public string MimeContent
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.MimeContent; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.MimeContent = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
		/// Contains the unique change key of an item in the Exchange store. This property is read-only.
		/// </summary>
		public string ItemChangeKey
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ItemChangeKey; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ItemChangeKey = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Represents the unique identifier of the parent folder that contains the item or folder. This property is read-only.
		/// </summary>
		public string ParentFolderId
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ParentFolderId; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ParentFolderId = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
		/// Represents the unique change key of the parent folder that contains the item or folder. This property is read-only.
		/// </summary>
		public string ParentFolderChangeKey
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ParentFolderChangeKey; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ParentFolderChangeKey = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Represents the message class of an item.
		/// </summary>
		public string ItemClass
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ItemClass; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ItemClass = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Represents the subject for Exchange store items and response objects. The subject is limited to 255 characters.
		/// </summary>
		public string Subject
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Subject; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Subject = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
		/// Indicates the sensitivity level of an item.
		/// </summary>
		public string Sensitivity
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Sensitivity; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Sensitivity = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// This field contains the body for the Task.
		/// </summary>
		public string Body
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Body; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Body = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
		/// Represents the date and time that an item in a mailbox was received.
		/// </summary>
		public DateTime? DateTimeReceived
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.DateTimeReceived; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.DateTimeReceived = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
		/// Represents the size in bytes of an item. This property is read-only.
		/// </summary>
		public int? Size
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Size; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Size = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Represents a collection of strings that identify to which categories an item in the mailbox belongs.
		/// </summary>
		public string Categories
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Categories; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Categories = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
		/// Represents the identifier of the item to which this item is a reply.
		/// </summary>
		public string InReplyTo
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.InReplyTo; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.InReplyTo = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
		/// Indicates whether an item has been submitted to the Outbox default folder.
		/// </summary>
		public bool? IsSubmitted
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.IsSubmitted; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.IsSubmitted = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
		/// Represents whether an item has not yet been sent.
		/// </summary>
		public bool? IsDraft
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.IsDraft; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.IsDraft = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
		/// Indicates whether a user sent an item to himself or herself.
		/// </summary>
		public bool? IsFromMe
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.IsFromMe; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.IsFromMe = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
		/// Indicates whether the item had previously been sent.
		/// </summary>
		public bool? IsResend
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.IsResend; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.IsResend = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
		/// Indicates whether the item has been modified.
		/// </summary>
		public bool? IsUnmodified
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.IsUnmodified; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.IsUnmodified = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
		/// Represents the collection of all Internet message headers that are contained within an item in a mailbox.
		/// </summary>
		public string InternetMessageHeaders
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.InternetMessageHeaders; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.InternetMessageHeaders = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
		/// Represents the date and time that an item in a mailbox was sent.
		/// </summary>
		public DateTime? DateTimeSent
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.DateTimeSent; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.DateTimeSent = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
		/// Represents the date and time that a given item in the mailbox was created.
		/// </summary>
		public DateTime? DateTimeCreated
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.DateTimeCreated; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.DateTimeCreated = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Represents the date and time when the event occurs.
		/// </summary>
		public DateTime? ReminderDueBy
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ReminderDueBy; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ReminderDueBy = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Indicates whether a reminder has been set for an item in the Exchange store.
		/// </summary>
		public bool? ReminderIsSet
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ReminderIsSet; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ReminderIsSet = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Represents the number of minutes before an event occurs when a reminder is displayed.
		/// </summary>
		public int? ReminderMinutesBeforeStart
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ReminderMinutesBeforeStart; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ReminderMinutesBeforeStart = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
		/// Represents the display string that is used for the contents of the To box. This is the concatenated string of all To
		/// recipient display names.
		/// </summary>
		public string DisplayCc
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.DisplayCc; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.DisplayCc = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
		/// Represents a property that is set to true if an item has at least one visible attachment. This property is read-only.
		/// </summary>
		public string DisplayTo
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.DisplayTo; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.DisplayTo = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
		/// Indicates whether an item has attachments.
		/// </summary>
		public bool? HasAttachments
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.HasAttachments; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.HasAttachments = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Represents the Culture of an item.
		/// </summary>
		public string Culture
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Culture; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Culture = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Represents the actual amount of time that is spent on a task.
		/// </summary>
		public int? ActualWork
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ActualWork; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ActualWork = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Represents the time when a task is assigned to a contact.
		/// </summary>
		public DateTime? AssignedTime
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.AssignedTime; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.AssignedTime = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Holds billing information for a task.
		/// </summary>
		public string BillingInformation
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.BillingInformation; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.BillingInformation = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Specifies the version of the task.
		/// </summary>
		public int? ChangeCount
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ChangeCount; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ChangeCount = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Represents the collection of companies that are associated with a contact or task.
		/// </summary>
		public string Companies1
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Companies1; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Companies1 = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Represents the collection of companies that are associated with a contact or task.
		/// </summary>
		public string Companies2
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Companies2; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Companies2 = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Represents the collection of companies that are associated with a contact or task.
		/// </summary>
		public string Companies3
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Companies3; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Companies3 = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Represents the date on which a task is completed.
		/// </summary>
		public DateTime? CompleteDate
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.CompleteDate; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.CompleteDate = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Contains a list of contacts who are associated with a task.
		/// </summary>
		public string Contacts1
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Contacts1; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Contacts1 = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Contains a list of contacts who are associated with a task.
		/// </summary>
		public string Contacts2
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Contacts2; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Contacts2 = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Contains a list of contacts who are associated with a task.
		/// </summary>
		public string Contacts3
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Contacts3; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Contacts3 = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Represents the status of a delegated task.
		/// </summary>
		public string DelegationState
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.DelegationState; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.DelegationState = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Contains the name of the delegator who assigned the task.
		/// </summary>
		public string Delegator
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Delegator; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Delegator = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Represents the date when a task item is due.
		/// </summary>
		public DateTime? DueDate
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.DueDate; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.DueDate = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Indicates whether the task is editable or not.
		/// </summary>
		public bool? IsAssignmentEditable
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.IsAssignmentEditable; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.IsAssignmentEditable = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Indicates whether the task has been completed or not.
		/// </summary>
		public bool? IsComplete
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.IsComplete; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.IsComplete = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
		/// Indicates whether a task is part of a recurring item.
		/// </summary>
		public bool? IsRecurring
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.IsRecurring; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.IsRecurring = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Indicates whether the task is owned by a team or not.
		/// </summary>
		public bool? IsTeamTask
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.IsTeamTask; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.IsTeamTask = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Represents mileage for a task item.
		/// </summary>
		public string Mileage
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Mileage; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Mileage = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Represents the owner of a task.
		/// </summary>
		public string Owner
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Owner; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Owner = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Describes the completion status of a task.
		/// </summary>
		public double? PercentComplete
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.PercentComplete; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.PercentComplete = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Contains the recurrence type for task items and meeting requests.
		/// </summary>
		public string Recurrence_Type
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Recurrence_Type; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Recurrence_Type = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Describes days of the week that are used in item recurrence patterns.
		/// </summary>
		public string Recurrence_DaysOfWeek
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Recurrence_DaysOfWeek; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Recurrence_DaysOfWeek = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Describes which week in a month is used in a relative yearly recurrence pattern.
		/// </summary>
		public string Recurrence_DayOfWeekIndex
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Recurrence_DayOfWeekIndex; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Recurrence_DayOfWeekIndex = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Describes the month when a yearly recurring item occurs.
		/// </summary>
		public string Recurrence_Month
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Recurrence_Month; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Recurrence_Month = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Describes the day in a month on which a recurring item occurs.
		/// </summary>
		public int? Recurrence_DayOfMonth
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Recurrence_DayOfMonth; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Recurrence_DayOfMonth = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Defines the interval between two consecutive recurring items.
		/// </summary>
		public int? Recurrence_Interval
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Recurrence_Interval; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Recurrence_Interval = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Specifies the first day of the week.
		/// </summary>
		public string Recurrence_FirstDayOfWeek
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Recurrence_FirstDayOfWeek; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Recurrence_FirstDayOfWeek = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Contains the recurrence duration type for task items and meeting requests.
		/// </summary>
		public string Recurrence_Duration
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Recurrence_Duration; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Recurrence_Duration = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Represents the start date of a recurring task or calendar item.
		/// </summary>
		public DateTime? Recurrence_StartDate
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Recurrence_StartDate; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Recurrence_StartDate = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Represents the end date of a recurring task or calendar item.
		/// </summary>
		public DateTime? Recurrence_EndDate
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Recurrence_EndDate; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Recurrence_EndDate = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Contains the number of occurrences of a recurring item.
		/// </summary>
		public int? Recurrence_NumberOfOccurrences
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Recurrence_NumberOfOccurrences; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Recurrence_NumberOfOccurrences = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Represents the start date of a task item.
		/// </summary>
		public DateTime? StartDate
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.StartDate; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.StartDate = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Represents the status of a task item.
		/// </summary>
		public string Status
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Status; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Status = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
		/// Contains an explanation of the task status.
		/// </summary>
		public string StatusDescription
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.StatusDescription; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.StatusDescription = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Contains a description of how much work is associated with an item.
		/// </summary>
		public int? TotalWork
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.TotalWork; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.TotalWork = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
		/// Indicates whether a client can create an associated contents table.
		/// </summary>
		public bool? EffectiveRights_CreateAssociated
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.EffectiveRights_CreateAssociated; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.EffectiveRights_CreateAssociated = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
		/// Indicates whether a client can create a contents table.
		/// </summary>
		public bool? EffectiveRights_CreateContents
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.EffectiveRights_CreateContents; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.EffectiveRights_CreateContents = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
		/// Indicates whether a client can create a hierarchy table.
		/// </summary>
		public bool? EffectiveRights_CreateHierarchy
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.EffectiveRights_CreateHierarchy; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.EffectiveRights_CreateHierarchy = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
		/// Indicates whether a client can delete a folder or item.
		/// </summary>
		public bool? EffectiveRights_Delete
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.EffectiveRights_Delete; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.EffectiveRights_Delete = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
		/// Indicates whether a client can modify a folder or item.
		/// </summary>
		public bool? EffectiveRights_Modify
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.EffectiveRights_Modify; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.EffectiveRights_Modify = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
		/// Indicates whether a client can read a folder or item.
		/// </summary>
		public bool? EffectiveRights_Read
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.EffectiveRights_Read; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.EffectiveRights_Read = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
		/// Indicates whether a private item can be viewed.
		/// </summary>
		public bool? EffectiveRights_ViewPrivateItems
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.EffectiveRights_ViewPrivateItems; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.EffectiveRights_ViewPrivateItems = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
		/// Contains the display name of the last user to modify an item.
		/// </summary>
		public string LastModifiedName
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.LastModifiedName; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.LastModifiedName = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
		/// Indicates when an item was last modified.
		/// </summary>
		public DateTime? LastModifiedTime
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.LastModifiedTime; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.LastModifiedTime = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Indicates whether the item is associated with a folder.
		/// </summary>
		public bool? IsAssociated
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.IsAssociated; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.IsAssociated = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
		/// Represents a URL to concatenate to the Microsoft Office Outlook Web App endpoint to read an item in Outlook Web App.
		/// </summary>
		public string WebClientReadFormQueryString
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.WebClientReadFormQueryString; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.WebClientReadFormQueryString = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
		/// Represents a URL to concatenate to the Outlook Web App endpoint to edit an item in Outlook Web App.
		/// </summary>
		public string WebClientEditFormQueryString
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.WebClientEditFormQueryString; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.WebClientEditFormQueryString = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
		/// Contains the identifier of an item or conversation.
		/// </summary>
		public string ConversationId
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ConversationId; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ConversationId = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
		/// Contains the change key of an item or conversation.
		/// </summary>
		public string ConversationChangeKey
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ConversationChangeKey; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ConversationChangeKey = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Represents an HTML fragment or plain-text which represents the unique body of this conversation.
		/// </summary>
		public string UniqueBody
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.UniqueBody; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.UniqueBody = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
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
			this.InsertItem(index, new PriKey_Tasks_Record());
			this.CurrentRecordIndex = index;
		}

		public void Append(PriKey_Tasks_Record record)
		{
			int index = this.RecordCount;
			this.InsertItem(index, record);
			this.CurrentRecordIndex = index;
		}

		public PriKey_Tasks_Record NewRecord()
		{
			return new PriKey_Tasks_Record();
		}

		protected override PriKey_Tasks_Record InternalCreateExistingRecordObject(object[] columnvalues) => new PriKey_Tasks_Record(columnvalues);

		byte[] IRecordsetBase.Hash
		{
			get { return new byte[] { 118, 56, 84, 201, 49, 151, 41, 42, 146, 161, 46, 197, 176, 220, 44, 92 }; }
		}

		string IRecordsetBase.HashString
		{
			get { return "763854C93197292A92A12EC5B0DC2C5C"; }
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

	public sealed partial class PriKey_Tasks_Record : IRecordBase, INotifyPropertyChanged
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
		private int? _cur__ActualWork; private int? _ori__ActualWork; private bool _mod__ActualWork;
		private DateTime? _cur__AssignedTime; private DateTime? _ori__AssignedTime; private bool _mod__AssignedTime;
		private string _cur__BillingInformation; private string _ori__BillingInformation; private bool _mod__BillingInformation;
		private int? _cur__ChangeCount; private int? _ori__ChangeCount; private bool _mod__ChangeCount;
		private string _cur__Companies1; private string _ori__Companies1; private bool _mod__Companies1;
		private string _cur__Companies2; private string _ori__Companies2; private bool _mod__Companies2;
		private string _cur__Companies3; private string _ori__Companies3; private bool _mod__Companies3;
		private DateTime? _cur__CompleteDate; private DateTime? _ori__CompleteDate; private bool _mod__CompleteDate;
		private string _cur__Contacts1; private string _ori__Contacts1; private bool _mod__Contacts1;
		private string _cur__Contacts2; private string _ori__Contacts2; private bool _mod__Contacts2;
		private string _cur__Contacts3; private string _ori__Contacts3; private bool _mod__Contacts3;
		private string _cur__DelegationState; private string _ori__DelegationState; private bool _mod__DelegationState;
		private string _cur__Delegator; private string _ori__Delegator; private bool _mod__Delegator;
		private DateTime? _cur__DueDate; private DateTime? _ori__DueDate; private bool _mod__DueDate;
		private bool? _cur__IsAssignmentEditable; private bool? _ori__IsAssignmentEditable; private bool _mod__IsAssignmentEditable;
		private bool? _cur__IsComplete; private bool? _ori__IsComplete; private bool _mod__IsComplete;
		private bool? _cur__IsRecurring; private bool? _ori__IsRecurring; private bool _mod__IsRecurring;
		private bool? _cur__IsTeamTask; private bool? _ori__IsTeamTask; private bool _mod__IsTeamTask;
		private string _cur__Mileage; private string _ori__Mileage; private bool _mod__Mileage;
		private string _cur__Owner; private string _ori__Owner; private bool _mod__Owner;
		private double? _cur__PercentComplete; private double? _ori__PercentComplete; private bool _mod__PercentComplete;
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
		private DateTime? _cur__StartDate; private DateTime? _ori__StartDate; private bool _mod__StartDate;
		private string _cur__Status; private string _ori__Status; private bool _mod__Status;
		private string _cur__StatusDescription; private string _ori__StatusDescription; private bool _mod__StatusDescription;
		private int? _cur__TotalWork; private int? _ori__TotalWork; private bool _mod__TotalWork;
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


		public PriKey_Tasks_Record()
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
			_cur__ActualWork = null;
			_cur__AssignedTime = null;
			_cur__BillingInformation = null;
			_cur__ChangeCount = null;
			_cur__Companies1 = null;
			_cur__Companies2 = null;
			_cur__Companies3 = null;
			_cur__CompleteDate = null;
			_cur__Contacts1 = null;
			_cur__Contacts2 = null;
			_cur__Contacts3 = null;
			_cur__DelegationState = null;
			_cur__Delegator = null;
			_cur__DueDate = null;
			_cur__IsAssignmentEditable = null;
			_cur__IsComplete = null;
			_cur__IsRecurring = null;
			_cur__IsTeamTask = null;
			_cur__Mileage = null;
			_cur__Owner = null;
			_cur__PercentComplete = null;
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
			_cur__StartDate = null;
			_cur__Status = null;
			_cur__StatusDescription = null;
			_cur__TotalWork = null;
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

		public PriKey_Tasks_Record(object[] columnvalues)
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
			_cur__InReplyTo = (string)columnvalues[12];
			_cur__IsSubmitted = (bool?)columnvalues[13];
			_cur__IsDraft = (bool?)columnvalues[14];
			_cur__IsFromMe = (bool?)columnvalues[15];
			_cur__IsResend = (bool?)columnvalues[16];
			_cur__IsUnmodified = (bool?)columnvalues[17];
			_cur__InternetMessageHeaders = (string)columnvalues[18];
			_cur__DateTimeSent = (DateTime?)columnvalues[19];
			_cur__DateTimeCreated = (DateTime?)columnvalues[20];
			_cur__ReminderDueBy = (DateTime?)columnvalues[21];
			_cur__ReminderIsSet = (bool?)columnvalues[22];
			_cur__ReminderMinutesBeforeStart = (int?)columnvalues[23];
			_cur__DisplayCc = (string)columnvalues[24];
			_cur__DisplayTo = (string)columnvalues[25];
			_cur__HasAttachments = (bool?)columnvalues[26];
			_cur__Culture = (string)columnvalues[27];
			_cur__ActualWork = (int?)columnvalues[28];
			_cur__AssignedTime = (DateTime?)columnvalues[29];
			_cur__BillingInformation = (string)columnvalues[30];
			_cur__ChangeCount = (int?)columnvalues[31];
			_cur__Companies1 = (string)columnvalues[32];
			_cur__Companies2 = (string)columnvalues[33];
			_cur__Companies3 = (string)columnvalues[34];
			_cur__CompleteDate = (DateTime?)columnvalues[35];
			_cur__Contacts1 = (string)columnvalues[36];
			_cur__Contacts2 = (string)columnvalues[37];
			_cur__Contacts3 = (string)columnvalues[38];
			_cur__DelegationState = (string)columnvalues[39];
			_cur__Delegator = (string)columnvalues[40];
			_cur__DueDate = (DateTime?)columnvalues[41];
			_cur__IsAssignmentEditable = (bool?)columnvalues[42];
			_cur__IsComplete = (bool?)columnvalues[43];
			_cur__IsRecurring = (bool?)columnvalues[44];
			_cur__IsTeamTask = (bool?)columnvalues[45];
			_cur__Mileage = (string)columnvalues[46];
			_cur__Owner = (string)columnvalues[47];
			_cur__PercentComplete = (double?)columnvalues[48];
			_cur__Recurrence_Type = (string)columnvalues[49];
			_cur__Recurrence_DaysOfWeek = (string)columnvalues[50];
			_cur__Recurrence_DayOfWeekIndex = (string)columnvalues[51];
			_cur__Recurrence_Month = (string)columnvalues[52];
			_cur__Recurrence_DayOfMonth = (int?)columnvalues[53];
			_cur__Recurrence_Interval = (int?)columnvalues[54];
			_cur__Recurrence_FirstDayOfWeek = (string)columnvalues[55];
			_cur__Recurrence_Duration = (string)columnvalues[56];
			_cur__Recurrence_StartDate = (DateTime?)columnvalues[57];
			_cur__Recurrence_EndDate = (DateTime?)columnvalues[58];
			_cur__Recurrence_NumberOfOccurrences = (int?)columnvalues[59];
			_cur__StartDate = (DateTime?)columnvalues[60];
			_cur__Status = (string)columnvalues[61];
			_cur__StatusDescription = (string)columnvalues[62];
			_cur__TotalWork = (int?)columnvalues[63];
			_cur__EffectiveRights_CreateAssociated = (bool?)columnvalues[64];
			_cur__EffectiveRights_CreateContents = (bool?)columnvalues[65];
			_cur__EffectiveRights_CreateHierarchy = (bool?)columnvalues[66];
			_cur__EffectiveRights_Delete = (bool?)columnvalues[67];
			_cur__EffectiveRights_Modify = (bool?)columnvalues[68];
			_cur__EffectiveRights_Read = (bool?)columnvalues[69];
			_cur__EffectiveRights_ViewPrivateItems = (bool?)columnvalues[70];
			_cur__LastModifiedName = (string)columnvalues[71];
			_cur__LastModifiedTime = (DateTime?)columnvalues[72];
			_cur__IsAssociated = (bool?)columnvalues[73];
			_cur__WebClientReadFormQueryString = (string)columnvalues[74];
			_cur__WebClientEditFormQueryString = (string)columnvalues[75];
			_cur__ConversationId = (string)columnvalues[76];
			_cur__ConversationChangeKey = (string)columnvalues[77];
			_cur__UniqueBody = (string)columnvalues[78];
			_cur__UniqueBodyType = (string)columnvalues[79];
			_started_with_dbvalues = true;
			_recordstatus = DataRecordStatus.Existing;
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. PrimaryKey. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
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
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
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
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
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
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
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
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// This field contains the body for the Task.
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
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
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
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
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
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
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
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
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
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
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
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
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
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Represents the actual amount of time that is spent on a task.
		/// </summary>
		public int? ActualWork
		{
			get { return _cur__ActualWork; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ActualWork = true;
				if (_cur__ActualWork == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ActualWork == false) { _ori__ActualWork = _cur__ActualWork; _mod__ActualWork = true; } // existing record and column is not modified
					else { if (value == _ori__ActualWork) { _ori__ActualWork = default(int?); _mod__ActualWork = false; } } // existing record and column is modified
				}
				_cur__ActualWork = value; OnPropertyChanged("ActualWork"); OnAfterPropertyChanged("ActualWork");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Represents the time when a task is assigned to a contact.
		/// </summary>
		public DateTime? AssignedTime
		{
			get { return _cur__AssignedTime; }
			set
			{
				if (_started_with_dbvalues == false) _mod__AssignedTime = true;
				if (_cur__AssignedTime == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__AssignedTime == false) { _ori__AssignedTime = _cur__AssignedTime; _mod__AssignedTime = true; } // existing record and column is not modified
					else { if (value == _ori__AssignedTime) { _ori__AssignedTime = default(DateTime?); _mod__AssignedTime = false; } } // existing record and column is modified
				}
				_cur__AssignedTime = value; OnPropertyChanged("AssignedTime"); OnAfterPropertyChanged("AssignedTime");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Holds billing information for a task.
		/// </summary>
		public string BillingInformation
		{
			get { return _cur__BillingInformation; }
			set
			{
				if (_started_with_dbvalues == false) _mod__BillingInformation = true;
				if (_cur__BillingInformation == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__BillingInformation == false) { _ori__BillingInformation = _cur__BillingInformation; _mod__BillingInformation = true; } // existing record and column is not modified
					else { if (value == _ori__BillingInformation) { _ori__BillingInformation = default(string); _mod__BillingInformation = false; } } // existing record and column is modified
				}
				_cur__BillingInformation = value; OnPropertyChanged("BillingInformation"); OnAfterPropertyChanged("BillingInformation");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Specifies the version of the task.
		/// </summary>
		public int? ChangeCount
		{
			get { return _cur__ChangeCount; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ChangeCount = true;
				if (_cur__ChangeCount == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ChangeCount == false) { _ori__ChangeCount = _cur__ChangeCount; _mod__ChangeCount = true; } // existing record and column is not modified
					else { if (value == _ori__ChangeCount) { _ori__ChangeCount = default(int?); _mod__ChangeCount = false; } } // existing record and column is modified
				}
				_cur__ChangeCount = value; OnPropertyChanged("ChangeCount"); OnAfterPropertyChanged("ChangeCount");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Represents the collection of companies that are associated with a contact or task.
		/// </summary>
		public string Companies1
		{
			get { return _cur__Companies1; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Companies1 = true;
				if (_cur__Companies1 == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Companies1 == false) { _ori__Companies1 = _cur__Companies1; _mod__Companies1 = true; } // existing record and column is not modified
					else { if (value == _ori__Companies1) { _ori__Companies1 = default(string); _mod__Companies1 = false; } } // existing record and column is modified
				}
				_cur__Companies1 = value; OnPropertyChanged("Companies1"); OnAfterPropertyChanged("Companies1");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Represents the collection of companies that are associated with a contact or task.
		/// </summary>
		public string Companies2
		{
			get { return _cur__Companies2; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Companies2 = true;
				if (_cur__Companies2 == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Companies2 == false) { _ori__Companies2 = _cur__Companies2; _mod__Companies2 = true; } // existing record and column is not modified
					else { if (value == _ori__Companies2) { _ori__Companies2 = default(string); _mod__Companies2 = false; } } // existing record and column is modified
				}
				_cur__Companies2 = value; OnPropertyChanged("Companies2"); OnAfterPropertyChanged("Companies2");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Represents the collection of companies that are associated with a contact or task.
		/// </summary>
		public string Companies3
		{
			get { return _cur__Companies3; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Companies3 = true;
				if (_cur__Companies3 == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Companies3 == false) { _ori__Companies3 = _cur__Companies3; _mod__Companies3 = true; } // existing record and column is not modified
					else { if (value == _ori__Companies3) { _ori__Companies3 = default(string); _mod__Companies3 = false; } } // existing record and column is modified
				}
				_cur__Companies3 = value; OnPropertyChanged("Companies3"); OnAfterPropertyChanged("Companies3");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Represents the date on which a task is completed.
		/// </summary>
		public DateTime? CompleteDate
		{
			get { return _cur__CompleteDate; }
			set
			{
				if (_started_with_dbvalues == false) _mod__CompleteDate = true;
				if (_cur__CompleteDate == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__CompleteDate == false) { _ori__CompleteDate = _cur__CompleteDate; _mod__CompleteDate = true; } // existing record and column is not modified
					else { if (value == _ori__CompleteDate) { _ori__CompleteDate = default(DateTime?); _mod__CompleteDate = false; } } // existing record and column is modified
				}
				_cur__CompleteDate = value; OnPropertyChanged("CompleteDate"); OnAfterPropertyChanged("CompleteDate");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Contains a list of contacts who are associated with a task.
		/// </summary>
		public string Contacts1
		{
			get { return _cur__Contacts1; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Contacts1 = true;
				if (_cur__Contacts1 == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Contacts1 == false) { _ori__Contacts1 = _cur__Contacts1; _mod__Contacts1 = true; } // existing record and column is not modified
					else { if (value == _ori__Contacts1) { _ori__Contacts1 = default(string); _mod__Contacts1 = false; } } // existing record and column is modified
				}
				_cur__Contacts1 = value; OnPropertyChanged("Contacts1"); OnAfterPropertyChanged("Contacts1");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Contains a list of contacts who are associated with a task.
		/// </summary>
		public string Contacts2
		{
			get { return _cur__Contacts2; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Contacts2 = true;
				if (_cur__Contacts2 == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Contacts2 == false) { _ori__Contacts2 = _cur__Contacts2; _mod__Contacts2 = true; } // existing record and column is not modified
					else { if (value == _ori__Contacts2) { _ori__Contacts2 = default(string); _mod__Contacts2 = false; } } // existing record and column is modified
				}
				_cur__Contacts2 = value; OnPropertyChanged("Contacts2"); OnAfterPropertyChanged("Contacts2");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Contains a list of contacts who are associated with a task.
		/// </summary>
		public string Contacts3
		{
			get { return _cur__Contacts3; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Contacts3 = true;
				if (_cur__Contacts3 == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Contacts3 == false) { _ori__Contacts3 = _cur__Contacts3; _mod__Contacts3 = true; } // existing record and column is not modified
					else { if (value == _ori__Contacts3) { _ori__Contacts3 = default(string); _mod__Contacts3 = false; } } // existing record and column is modified
				}
				_cur__Contacts3 = value; OnPropertyChanged("Contacts3"); OnAfterPropertyChanged("Contacts3");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Represents the status of a delegated task.
		/// </summary>
		public string DelegationState
		{
			get { return _cur__DelegationState; }
			set
			{
				if (_started_with_dbvalues == false) _mod__DelegationState = true;
				if (_cur__DelegationState == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__DelegationState == false) { _ori__DelegationState = _cur__DelegationState; _mod__DelegationState = true; } // existing record and column is not modified
					else { if (value == _ori__DelegationState) { _ori__DelegationState = default(string); _mod__DelegationState = false; } } // existing record and column is modified
				}
				_cur__DelegationState = value; OnPropertyChanged("DelegationState"); OnAfterPropertyChanged("DelegationState");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Contains the name of the delegator who assigned the task.
		/// </summary>
		public string Delegator
		{
			get { return _cur__Delegator; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Delegator = true;
				if (_cur__Delegator == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Delegator == false) { _ori__Delegator = _cur__Delegator; _mod__Delegator = true; } // existing record and column is not modified
					else { if (value == _ori__Delegator) { _ori__Delegator = default(string); _mod__Delegator = false; } } // existing record and column is modified
				}
				_cur__Delegator = value; OnPropertyChanged("Delegator"); OnAfterPropertyChanged("Delegator");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Represents the date when a task item is due.
		/// </summary>
		public DateTime? DueDate
		{
			get { return _cur__DueDate; }
			set
			{
				if (_started_with_dbvalues == false) _mod__DueDate = true;
				if (_cur__DueDate == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__DueDate == false) { _ori__DueDate = _cur__DueDate; _mod__DueDate = true; } // existing record and column is not modified
					else { if (value == _ori__DueDate) { _ori__DueDate = default(DateTime?); _mod__DueDate = false; } } // existing record and column is modified
				}
				_cur__DueDate = value; OnPropertyChanged("DueDate"); OnAfterPropertyChanged("DueDate");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Indicates whether the task is editable or not.
		/// </summary>
		public bool? IsAssignmentEditable
		{
			get { return _cur__IsAssignmentEditable; }
			set
			{
				if (_started_with_dbvalues == false) _mod__IsAssignmentEditable = true;
				if (_cur__IsAssignmentEditable == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__IsAssignmentEditable == false) { _ori__IsAssignmentEditable = _cur__IsAssignmentEditable; _mod__IsAssignmentEditable = true; } // existing record and column is not modified
					else { if (value == _ori__IsAssignmentEditable) { _ori__IsAssignmentEditable = default(bool?); _mod__IsAssignmentEditable = false; } } // existing record and column is modified
				}
				_cur__IsAssignmentEditable = value; OnPropertyChanged("IsAssignmentEditable"); OnAfterPropertyChanged("IsAssignmentEditable");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Indicates whether the task has been completed or not.
		/// </summary>
		public bool? IsComplete
		{
			get { return _cur__IsComplete; }
			set
			{
				if (_started_with_dbvalues == false) _mod__IsComplete = true;
				if (_cur__IsComplete == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__IsComplete == false) { _ori__IsComplete = _cur__IsComplete; _mod__IsComplete = true; } // existing record and column is not modified
					else { if (value == _ori__IsComplete) { _ori__IsComplete = default(bool?); _mod__IsComplete = false; } } // existing record and column is modified
				}
				_cur__IsComplete = value; OnPropertyChanged("IsComplete"); OnAfterPropertyChanged("IsComplete");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
		/// Indicates whether a task is part of a recurring item.
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
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Indicates whether the task is owned by a team or not.
		/// </summary>
		public bool? IsTeamTask
		{
			get { return _cur__IsTeamTask; }
			set
			{
				if (_started_with_dbvalues == false) _mod__IsTeamTask = true;
				if (_cur__IsTeamTask == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__IsTeamTask == false) { _ori__IsTeamTask = _cur__IsTeamTask; _mod__IsTeamTask = true; } // existing record and column is not modified
					else { if (value == _ori__IsTeamTask) { _ori__IsTeamTask = default(bool?); _mod__IsTeamTask = false; } } // existing record and column is modified
				}
				_cur__IsTeamTask = value; OnPropertyChanged("IsTeamTask"); OnAfterPropertyChanged("IsTeamTask");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Represents mileage for a task item.
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
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Represents the owner of a task.
		/// </summary>
		public string Owner
		{
			get { return _cur__Owner; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Owner = true;
				if (_cur__Owner == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Owner == false) { _ori__Owner = _cur__Owner; _mod__Owner = true; } // existing record and column is not modified
					else { if (value == _ori__Owner) { _ori__Owner = default(string); _mod__Owner = false; } } // existing record and column is modified
				}
				_cur__Owner = value; OnPropertyChanged("Owner"); OnAfterPropertyChanged("Owner");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Describes the completion status of a task.
		/// </summary>
		public double? PercentComplete
		{
			get { return _cur__PercentComplete; }
			set
			{
				if (_started_with_dbvalues == false) _mod__PercentComplete = true;
				if (_cur__PercentComplete == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__PercentComplete == false) { _ori__PercentComplete = _cur__PercentComplete; _mod__PercentComplete = true; } // existing record and column is not modified
					else { if (value == _ori__PercentComplete) { _ori__PercentComplete = default(double?); _mod__PercentComplete = false; } } // existing record and column is modified
				}
				_cur__PercentComplete = value; OnPropertyChanged("PercentComplete"); OnAfterPropertyChanged("PercentComplete");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Contains the recurrence type for task items and meeting requests.
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
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
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
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
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
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
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
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
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
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
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
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
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
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Contains the recurrence duration type for task items and meeting requests.
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
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
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
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
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
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
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
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Represents the start date of a task item.
		/// </summary>
		public DateTime? StartDate
		{
			get { return _cur__StartDate; }
			set
			{
				if (_started_with_dbvalues == false) _mod__StartDate = true;
				if (_cur__StartDate == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__StartDate == false) { _ori__StartDate = _cur__StartDate; _mod__StartDate = true; } // existing record and column is not modified
					else { if (value == _ori__StartDate) { _ori__StartDate = default(DateTime?); _mod__StartDate = false; } } // existing record and column is modified
				}
				_cur__StartDate = value; OnPropertyChanged("StartDate"); OnAfterPropertyChanged("StartDate");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Represents the status of a task item.
		/// </summary>
		public string Status
		{
			get { return _cur__Status; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Status = true;
				if (_cur__Status == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Status == false) { _ori__Status = _cur__Status; _mod__Status = true; } // existing record and column is not modified
					else { if (value == _ori__Status) { _ori__Status = default(string); _mod__Status = false; } } // existing record and column is modified
				}
				_cur__Status = value; OnPropertyChanged("Status"); OnAfterPropertyChanged("Status");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
		/// Contains an explanation of the task status.
		/// </summary>
		public string StatusDescription
		{
			get { return _cur__StatusDescription; }
			set
			{
				if (_started_with_dbvalues == false) _mod__StatusDescription = true;
				if (_cur__StatusDescription == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__StatusDescription == false) { _ori__StatusDescription = _cur__StatusDescription; _mod__StatusDescription = true; } // existing record and column is not modified
					else { if (value == _ori__StatusDescription) { _ori__StatusDescription = default(string); _mod__StatusDescription = false; } } // existing record and column is modified
				}
				_cur__StatusDescription = value; OnPropertyChanged("StatusDescription"); OnAfterPropertyChanged("StatusDescription");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
		/// Contains a description of how much work is associated with an item.
		/// </summary>
		public int? TotalWork
		{
			get { return _cur__TotalWork; }
			set
			{
				if (_started_with_dbvalues == false) _mod__TotalWork = true;
				if (_cur__TotalWork == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__TotalWork == false) { _ori__TotalWork = _cur__TotalWork; _mod__TotalWork = true; } // existing record and column is not modified
					else { if (value == _ori__TotalWork) { _ori__TotalWork = default(int?); _mod__TotalWork = false; } } // existing record and column is modified
				}
				_cur__TotalWork = value; OnPropertyChanged("TotalWork"); OnAfterPropertyChanged("TotalWork");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
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
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Tasks]. Readonly. AllowNull.
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
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
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
		/// Database Column Updateable. Table [Exchange].[Tasks]. NotReadonly. AllowNull.
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
			if (column_name == "ActualWork") return _mod__ActualWork;
			if (column_name == "AssignedTime") return _mod__AssignedTime;
			if (column_name == "BillingInformation") return _mod__BillingInformation;
			if (column_name == "ChangeCount") return _mod__ChangeCount;
			if (column_name == "Companies1") return _mod__Companies1;
			if (column_name == "Companies2") return _mod__Companies2;
			if (column_name == "Companies3") return _mod__Companies3;
			if (column_name == "CompleteDate") return _mod__CompleteDate;
			if (column_name == "Contacts1") return _mod__Contacts1;
			if (column_name == "Contacts2") return _mod__Contacts2;
			if (column_name == "Contacts3") return _mod__Contacts3;
			if (column_name == "DelegationState") return _mod__DelegationState;
			if (column_name == "Delegator") return _mod__Delegator;
			if (column_name == "DueDate") return _mod__DueDate;
			if (column_name == "IsAssignmentEditable") return _mod__IsAssignmentEditable;
			if (column_name == "IsComplete") return _mod__IsComplete;
			if (column_name == "IsRecurring") return _mod__IsRecurring;
			if (column_name == "IsTeamTask") return _mod__IsTeamTask;
			if (column_name == "Mileage") return _mod__Mileage;
			if (column_name == "Owner") return _mod__Owner;
			if (column_name == "PercentComplete") return _mod__PercentComplete;
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
			if (column_name == "StartDate") return _mod__StartDate;
			if (column_name == "Status") return _mod__Status;
			if (column_name == "StatusDescription") return _mod__StatusDescription;
			if (column_name == "TotalWork") return _mod__TotalWork;
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
			if (_mod__ActualWork == true) count++;
			if (_mod__AssignedTime == true) count++;
			if (_mod__BillingInformation == true) count++;
			if (_mod__ChangeCount == true) count++;
			if (_mod__Companies1 == true) count++;
			if (_mod__Companies2 == true) count++;
			if (_mod__Companies3 == true) count++;
			if (_mod__CompleteDate == true) count++;
			if (_mod__Contacts1 == true) count++;
			if (_mod__Contacts2 == true) count++;
			if (_mod__Contacts3 == true) count++;
			if (_mod__DelegationState == true) count++;
			if (_mod__Delegator == true) count++;
			if (_mod__DueDate == true) count++;
			if (_mod__IsAssignmentEditable == true) count++;
			if (_mod__IsComplete == true) count++;
			if (_mod__IsRecurring == true) count++;
			if (_mod__IsTeamTask == true) count++;
			if (_mod__Mileage == true) count++;
			if (_mod__Owner == true) count++;
			if (_mod__PercentComplete == true) count++;
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
			if (_mod__StartDate == true) count++;
			if (_mod__Status == true) count++;
			if (_mod__StatusDescription == true) count++;
			if (_mod__TotalWork == true) count++;
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
			if (_mod__ReminderDueBy == true) count++;
			if (_mod__ReminderIsSet == true) count++;
			if (_mod__ReminderMinutesBeforeStart == true) count++;
			if (_mod__Culture == true) count++;
			if (_mod__ActualWork == true) count++;
			if (_mod__AssignedTime == true) count++;
			if (_mod__BillingInformation == true) count++;
			if (_mod__ChangeCount == true) count++;
			if (_mod__Companies1 == true) count++;
			if (_mod__Companies2 == true) count++;
			if (_mod__Companies3 == true) count++;
			if (_mod__CompleteDate == true) count++;
			if (_mod__Contacts1 == true) count++;
			if (_mod__Contacts2 == true) count++;
			if (_mod__Contacts3 == true) count++;
			if (_mod__DelegationState == true) count++;
			if (_mod__Delegator == true) count++;
			if (_mod__DueDate == true) count++;
			if (_mod__IsAssignmentEditable == true) count++;
			if (_mod__IsComplete == true) count++;
			if (_mod__IsTeamTask == true) count++;
			if (_mod__Mileage == true) count++;
			if (_mod__Owner == true) count++;
			if (_mod__PercentComplete == true) count++;
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
			if (_mod__StartDate == true) count++;
			if (_mod__Status == true) count++;
			if (_mod__TotalWork == true) count++;
			if (_mod__IsAssociated == true) count++;
			if (_mod__UniqueBody == true) count++;
			if (_mod__UniqueBodyType == true) count++;
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
				if (_cur__ReminderDueBy != null) track_array.AppendDataValue(21, _cur__ReminderDueBy);
				if (_cur__ReminderIsSet != null) track_array.AppendDataValue(22, _cur__ReminderIsSet);
				if (_cur__ReminderMinutesBeforeStart != null) track_array.AppendDataValue(23, _cur__ReminderMinutesBeforeStart);
				if (_cur__Culture != null) track_array.AppendDataValue(27, _cur__Culture);
				if (_cur__ActualWork != null) track_array.AppendDataValue(28, _cur__ActualWork);
				if (_cur__AssignedTime != null) track_array.AppendDataValue(29, _cur__AssignedTime);
				if (_cur__BillingInformation != null) track_array.AppendDataValue(30, _cur__BillingInformation);
				if (_cur__ChangeCount != null) track_array.AppendDataValue(31, _cur__ChangeCount);
				if (_cur__Companies1 != null) track_array.AppendDataValue(32, _cur__Companies1);
				if (_cur__Companies2 != null) track_array.AppendDataValue(33, _cur__Companies2);
				if (_cur__Companies3 != null) track_array.AppendDataValue(34, _cur__Companies3);
				if (_cur__CompleteDate != null) track_array.AppendDataValue(35, _cur__CompleteDate);
				if (_cur__Contacts1 != null) track_array.AppendDataValue(36, _cur__Contacts1);
				if (_cur__Contacts2 != null) track_array.AppendDataValue(37, _cur__Contacts2);
				if (_cur__Contacts3 != null) track_array.AppendDataValue(38, _cur__Contacts3);
				if (_cur__DelegationState != null) track_array.AppendDataValue(39, _cur__DelegationState);
				if (_cur__Delegator != null) track_array.AppendDataValue(40, _cur__Delegator);
				if (_cur__DueDate != null) track_array.AppendDataValue(41, _cur__DueDate);
				if (_cur__IsAssignmentEditable != null) track_array.AppendDataValue(42, _cur__IsAssignmentEditable);
				if (_cur__IsComplete != null) track_array.AppendDataValue(43, _cur__IsComplete);
				if (_cur__IsTeamTask != null) track_array.AppendDataValue(45, _cur__IsTeamTask);
				if (_cur__Mileage != null) track_array.AppendDataValue(46, _cur__Mileage);
				if (_cur__Owner != null) track_array.AppendDataValue(47, _cur__Owner);
				if (_cur__PercentComplete != null) track_array.AppendDataValue(48, _cur__PercentComplete);
				if (_cur__Recurrence_Type != null) track_array.AppendDataValue(49, _cur__Recurrence_Type);
				if (_cur__Recurrence_DaysOfWeek != null) track_array.AppendDataValue(50, _cur__Recurrence_DaysOfWeek);
				if (_cur__Recurrence_DayOfWeekIndex != null) track_array.AppendDataValue(51, _cur__Recurrence_DayOfWeekIndex);
				if (_cur__Recurrence_Month != null) track_array.AppendDataValue(52, _cur__Recurrence_Month);
				if (_cur__Recurrence_DayOfMonth != null) track_array.AppendDataValue(53, _cur__Recurrence_DayOfMonth);
				if (_cur__Recurrence_Interval != null) track_array.AppendDataValue(54, _cur__Recurrence_Interval);
				if (_cur__Recurrence_FirstDayOfWeek != null) track_array.AppendDataValue(55, _cur__Recurrence_FirstDayOfWeek);
				if (_cur__Recurrence_Duration != null) track_array.AppendDataValue(56, _cur__Recurrence_Duration);
				if (_cur__Recurrence_StartDate != null) track_array.AppendDataValue(57, _cur__Recurrence_StartDate);
				if (_cur__Recurrence_EndDate != null) track_array.AppendDataValue(58, _cur__Recurrence_EndDate);
				if (_cur__Recurrence_NumberOfOccurrences != null) track_array.AppendDataValue(59, _cur__Recurrence_NumberOfOccurrences);
				if (_cur__StartDate != null) track_array.AppendDataValue(60, _cur__StartDate);
				if (_cur__Status != null) track_array.AppendDataValue(61, _cur__Status);
				if (_cur__TotalWork != null) track_array.AppendDataValue(63, _cur__TotalWork);
				if (_cur__IsAssociated != null) track_array.AppendDataValue(73, _cur__IsAssociated);
				if (_cur__UniqueBody != null) track_array.AppendDataValue(78, _cur__UniqueBody);
				if (_cur__UniqueBodyType != null) track_array.AppendDataValue(79, _cur__UniqueBodyType);
			}
			else if (_recordstatus == DataRecordStatus.Existing)
			{
				if (_mod__ParentFolderId) track_array.AppendDataValue(3, _cur__ParentFolderId);
				if (_mod__ItemClass) track_array.AppendDataValue(5, _cur__ItemClass);
				if (_mod__Subject) track_array.AppendDataValue(6, _cur__Subject);
				if (_mod__Body) track_array.AppendDataValue(8, _cur__Body);
				if (_mod__Categories) track_array.AppendDataValue(11, _cur__Categories);
				if (_mod__ReminderDueBy) track_array.AppendDataValue(21, _cur__ReminderDueBy);
				if (_mod__ReminderIsSet) track_array.AppendDataValue(22, _cur__ReminderIsSet);
				if (_mod__ReminderMinutesBeforeStart) track_array.AppendDataValue(23, _cur__ReminderMinutesBeforeStart);
				if (_mod__Culture) track_array.AppendDataValue(27, _cur__Culture);
				if (_mod__ActualWork) track_array.AppendDataValue(28, _cur__ActualWork);
				if (_mod__AssignedTime) track_array.AppendDataValue(29, _cur__AssignedTime);
				if (_mod__BillingInformation) track_array.AppendDataValue(30, _cur__BillingInformation);
				if (_mod__ChangeCount) track_array.AppendDataValue(31, _cur__ChangeCount);
				if (_mod__Companies1) track_array.AppendDataValue(32, _cur__Companies1);
				if (_mod__Companies2) track_array.AppendDataValue(33, _cur__Companies2);
				if (_mod__Companies3) track_array.AppendDataValue(34, _cur__Companies3);
				if (_mod__CompleteDate) track_array.AppendDataValue(35, _cur__CompleteDate);
				if (_mod__Contacts1) track_array.AppendDataValue(36, _cur__Contacts1);
				if (_mod__Contacts2) track_array.AppendDataValue(37, _cur__Contacts2);
				if (_mod__Contacts3) track_array.AppendDataValue(38, _cur__Contacts3);
				if (_mod__DelegationState) track_array.AppendDataValue(39, _cur__DelegationState);
				if (_mod__Delegator) track_array.AppendDataValue(40, _cur__Delegator);
				if (_mod__DueDate) track_array.AppendDataValue(41, _cur__DueDate);
				if (_mod__IsAssignmentEditable) track_array.AppendDataValue(42, _cur__IsAssignmentEditable);
				if (_mod__IsComplete) track_array.AppendDataValue(43, _cur__IsComplete);
				if (_mod__IsTeamTask) track_array.AppendDataValue(45, _cur__IsTeamTask);
				if (_mod__Mileage) track_array.AppendDataValue(46, _cur__Mileage);
				if (_mod__Owner) track_array.AppendDataValue(47, _cur__Owner);
				if (_mod__PercentComplete) track_array.AppendDataValue(48, _cur__PercentComplete);
				if (_mod__Recurrence_Type) track_array.AppendDataValue(49, _cur__Recurrence_Type);
				if (_mod__Recurrence_DaysOfWeek) track_array.AppendDataValue(50, _cur__Recurrence_DaysOfWeek);
				if (_mod__Recurrence_DayOfWeekIndex) track_array.AppendDataValue(51, _cur__Recurrence_DayOfWeekIndex);
				if (_mod__Recurrence_Month) track_array.AppendDataValue(52, _cur__Recurrence_Month);
				if (_mod__Recurrence_DayOfMonth) track_array.AppendDataValue(53, _cur__Recurrence_DayOfMonth);
				if (_mod__Recurrence_Interval) track_array.AppendDataValue(54, _cur__Recurrence_Interval);
				if (_mod__Recurrence_FirstDayOfWeek) track_array.AppendDataValue(55, _cur__Recurrence_FirstDayOfWeek);
				if (_mod__Recurrence_Duration) track_array.AppendDataValue(56, _cur__Recurrence_Duration);
				if (_mod__Recurrence_StartDate) track_array.AppendDataValue(57, _cur__Recurrence_StartDate);
				if (_mod__Recurrence_EndDate) track_array.AppendDataValue(58, _cur__Recurrence_EndDate);
				if (_mod__Recurrence_NumberOfOccurrences) track_array.AppendDataValue(59, _cur__Recurrence_NumberOfOccurrences);
				if (_mod__StartDate) track_array.AppendDataValue(60, _cur__StartDate);
				if (_mod__Status) track_array.AppendDataValue(61, _cur__Status);
				if (_mod__TotalWork) track_array.AppendDataValue(63, _cur__TotalWork);
				if (_mod__IsAssociated) track_array.AppendDataValue(73, _cur__IsAssociated);
				if (_mod__UniqueBody) track_array.AppendDataValue(78, _cur__UniqueBody);
				if (_mod__UniqueBodyType) track_array.AppendDataValue(79, _cur__UniqueBodyType);
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
				if (_mod__ActualWork) _ori__ActualWork = default(int?);
				if (_mod__AssignedTime) _ori__AssignedTime = default(DateTime?);
				if (_mod__BillingInformation) _ori__BillingInformation = default(string);
				if (_mod__ChangeCount) _ori__ChangeCount = default(int?);
				if (_mod__Companies1) _ori__Companies1 = default(string);
				if (_mod__Companies2) _ori__Companies2 = default(string);
				if (_mod__Companies3) _ori__Companies3 = default(string);
				if (_mod__CompleteDate) _ori__CompleteDate = default(DateTime?);
				if (_mod__Contacts1) _ori__Contacts1 = default(string);
				if (_mod__Contacts2) _ori__Contacts2 = default(string);
				if (_mod__Contacts3) _ori__Contacts3 = default(string);
				if (_mod__DelegationState) _ori__DelegationState = default(string);
				if (_mod__Delegator) _ori__Delegator = default(string);
				if (_mod__DueDate) _ori__DueDate = default(DateTime?);
				if (_mod__IsAssignmentEditable) _ori__IsAssignmentEditable = default(bool?);
				if (_mod__IsComplete) _ori__IsComplete = default(bool?);
				if (_mod__IsRecurring) _ori__IsRecurring = default(bool?);
				if (_mod__IsTeamTask) _ori__IsTeamTask = default(bool?);
				if (_mod__Mileage) _ori__Mileage = default(string);
				if (_mod__Owner) _ori__Owner = default(string);
				if (_mod__PercentComplete) _ori__PercentComplete = default(double?);
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
				if (_mod__StartDate) _ori__StartDate = default(DateTime?);
				if (_mod__Status) _ori__Status = default(string);
				if (_mod__StatusDescription) _ori__StatusDescription = default(string);
				if (_mod__TotalWork) _ori__TotalWork = default(int?);
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
			_mod__ActualWork = false;
			_mod__AssignedTime = false;
			_mod__BillingInformation = false;
			_mod__ChangeCount = false;
			_mod__Companies1 = false;
			_mod__Companies2 = false;
			_mod__Companies3 = false;
			_mod__CompleteDate = false;
			_mod__Contacts1 = false;
			_mod__Contacts2 = false;
			_mod__Contacts3 = false;
			_mod__DelegationState = false;
			_mod__Delegator = false;
			_mod__DueDate = false;
			_mod__IsAssignmentEditable = false;
			_mod__IsComplete = false;
			_mod__IsRecurring = false;
			_mod__IsTeamTask = false;
			_mod__Mileage = false;
			_mod__Owner = false;
			_mod__PercentComplete = false;
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
			_mod__StartDate = false;
			_mod__Status = false;
			_mod__StatusDescription = false;
			_mod__TotalWork = false;
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
	public partial class PriKey_Tasks_Record
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
