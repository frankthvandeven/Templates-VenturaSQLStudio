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
	/// The updateable table is [Exchange].[Folders]. Updateable table column information:
	/// • 27 out of 27 table columns are present in the resultset.
	/// • All primary key columns are present in the resultset: FolderId.
	/// • Non-primary key columns present in the resultset: FolderChangeKey, ParentFolderId, ParentFolderChangeKey, FolderClass,
	///   DisplayName, TotalCount, ChildFolderCount, CanDelete, CanRenameOrMove, MustDisplayComment, HasQuota,
	///   IsManagedFoldersRoot, ManagedFolderId, Comment, StorageQuota, FolderSize, HomePage, UnreadCount,
	///   EffectiveRights_CreateAssociated, EffectiveRights_CreateContents, EffectiveRights_CreateHierarchy,
	///   EffectiveRights_Delete, EffectiveRights_Modify, EffectiveRights_Read, EffectiveRights_ViewPrivateItems and
	///   SharingEffectiveRights.
	/// Recordset item automatically created by Ventura SQL Studio.
	/// </summary>
	public partial class PriKey_Folders_Recordset : ResultsetObservable<PriKey_Folders_Recordset, PriKey_Folders_Record>, IRecordsetBase
	{
		private IResultsetBase[] _resultsets;
		private string _sqlscript;
		private object[] _inputparametervalues;
		private InputParamHolder _inputparamholder;
		private VenturaSchema _parameterschema;
		private int _rowlimit = 500;
		private const string CRLF = "\r\n";

		public PriKey_Folders_Recordset()
		{
			_resultsets = new IResultsetBase[] { this };

			_sqlscript = @"SELECT [FolderId],[FolderChangeKey],[ParentFolderId],[ParentFolderChangeKey],[FolderClass],[DisplayName],[TotalCount],[ChildFolderCount],[CanDelete],[CanRenameOrMove]," + CRLF +
			             @"[MustDisplayComment],[HasQuota],[IsManagedFoldersRoot],[ManagedFolderId],[Comment],[StorageQuota],[FolderSize],[HomePage],[UnreadCount],[EffectiveRights_CreateAssociated]," + CRLF +
			             @"[EffectiveRights_CreateContents],[EffectiveRights_CreateHierarchy],[EffectiveRights_Delete],[EffectiveRights_Modify],[EffectiveRights_Read],[EffectiveRights_ViewPrivateItems]," + CRLF +
			             @"[SharingEffectiveRights]" + CRLF +
			             @"FROM [Exchange].[Folders]" + CRLF +
			             @"WHERE [FolderId] = @FolderId";

			_inputparametervalues = new object[1];
			_inputparamholder = new InputParamHolder(_inputparametervalues);

			ColumnArrayBuilder param_array = new ColumnArrayBuilder();

			param_array.AddParameterColumn("@FolderId", typeof(string), true, false, DbType.String, null, null, null);

			_parameterschema = new VenturaSchema(param_array);

			ColumnArrayBuilder schema_array = new ColumnArrayBuilder();

			schema_array.Add(new VenturaColumn("FolderId", typeof(string), true)
			{
				ColumnSize = 255,
				NumericScale = 0,
				ProviderType = 16,
				IsUnique = true,
				IsKey = true,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Folders",
				BaseColumnName = "FolderId"
			});

			schema_array.Add(new VenturaColumn("FolderChangeKey", typeof(string), true)
			{
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Folders",
				BaseColumnName = "FolderChangeKey"
			});

			schema_array.Add(new VenturaColumn("ParentFolderId", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Folders",
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
				BaseTableName = "Folders",
				BaseColumnName = "ParentFolderChangeKey"
			});

			schema_array.Add(new VenturaColumn("FolderClass", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Folders",
				BaseColumnName = "FolderClass"
			});

			schema_array.Add(new VenturaColumn("DisplayName", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Folders",
				BaseColumnName = "DisplayName"
			});

			schema_array.Add(new VenturaColumn("TotalCount", typeof(int), true)
			{
				ColumnSize = 11,
				NumericPrecision = 10,
				NumericScale = 0,
				ProviderType = 11,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Folders",
				BaseColumnName = "TotalCount"
			});

			schema_array.Add(new VenturaColumn("ChildFolderCount", typeof(int), true)
			{
				ColumnSize = 11,
				NumericPrecision = 10,
				NumericScale = 0,
				ProviderType = 11,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Folders",
				BaseColumnName = "ChildFolderCount"
			});

			schema_array.Add(new VenturaColumn("CanDelete", typeof(bool), true)
			{
				ColumnSize = 1,
				NumericPrecision = 1,
				NumericScale = 0,
				ProviderType = 3,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Folders",
				BaseColumnName = "CanDelete"
			});

			schema_array.Add(new VenturaColumn("CanRenameOrMove", typeof(bool), true)
			{
				ColumnSize = 1,
				NumericPrecision = 1,
				NumericScale = 0,
				ProviderType = 3,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Folders",
				BaseColumnName = "CanRenameOrMove"
			});

			schema_array.Add(new VenturaColumn("MustDisplayComment", typeof(bool), true)
			{
				ColumnSize = 1,
				NumericPrecision = 1,
				NumericScale = 0,
				ProviderType = 3,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Folders",
				BaseColumnName = "MustDisplayComment"
			});

			schema_array.Add(new VenturaColumn("HasQuota", typeof(bool), true)
			{
				ColumnSize = 1,
				NumericPrecision = 1,
				NumericScale = 0,
				ProviderType = 3,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Folders",
				BaseColumnName = "HasQuota"
			});

			schema_array.Add(new VenturaColumn("IsManagedFoldersRoot", typeof(bool), true)
			{
				ColumnSize = 1,
				NumericPrecision = 1,
				NumericScale = 0,
				ProviderType = 3,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Folders",
				BaseColumnName = "IsManagedFoldersRoot"
			});

			schema_array.Add(new VenturaColumn("ManagedFolderId", typeof(string), true)
			{
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Folders",
				BaseColumnName = "ManagedFolderId"
			});

			schema_array.Add(new VenturaColumn("Comment", typeof(string), true)
			{
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Folders",
				BaseColumnName = "Comment"
			});

			schema_array.Add(new VenturaColumn("StorageQuota", typeof(int), true)
			{
				ColumnSize = 11,
				NumericPrecision = 10,
				NumericScale = 0,
				ProviderType = 11,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Folders",
				BaseColumnName = "StorageQuota"
			});

			schema_array.Add(new VenturaColumn("FolderSize", typeof(int), true)
			{
				ColumnSize = 11,
				NumericPrecision = 10,
				NumericScale = 0,
				ProviderType = 11,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Folders",
				BaseColumnName = "FolderSize"
			});

			schema_array.Add(new VenturaColumn("HomePage", typeof(string), true)
			{
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Folders",
				BaseColumnName = "HomePage"
			});

			schema_array.Add(new VenturaColumn("UnreadCount", typeof(int), true)
			{
				ColumnSize = 11,
				NumericPrecision = 10,
				NumericScale = 0,
				ProviderType = 11,
				IsReadOnly = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Folders",
				BaseColumnName = "UnreadCount"
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
				BaseTableName = "Folders",
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
				BaseTableName = "Folders",
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
				BaseTableName = "Folders",
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
				BaseTableName = "Folders",
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
				BaseTableName = "Folders",
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
				BaseTableName = "Folders",
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
				BaseTableName = "Folders",
				BaseColumnName = "EffectiveRights_ViewPrivateItems"
			});

			schema_array.Add(new VenturaColumn("SharingEffectiveRights", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Folders",
				BaseColumnName = "SharingEffectiveRights"
			});

			((IResultsetBase)this).Schema = new VenturaSchema(schema_array);
			((IResultsetBase)this).UpdateableTablename = "[Exchange].[Folders]";
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Folders]. PrimaryKey. Readonly. AllowNull.
		/// Contains the unique identifier of an folder in the Exchange store.
		/// </summary>
		public string FolderId
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.FolderId; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.FolderId = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Folders]. Readonly. AllowNull.
		/// Contains the unique change key of an folder in the Exchange store.
		/// </summary>
		public string FolderChangeKey
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.FolderChangeKey; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.FolderChangeKey = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Folders]. NotReadonly. AllowNull.
		/// Represents the unique identifier of the parent folder that contains the item or folder.
		/// </summary>
		public string ParentFolderId
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ParentFolderId; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ParentFolderId = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Folders]. Readonly. AllowNull.
		/// Represents the unique change key of the parent folder that contains the item or folder.
		/// </summary>
		public string ParentFolderChangeKey
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ParentFolderChangeKey; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ParentFolderChangeKey = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Folders]. NotReadonly. AllowNull.
		/// Represents the folder class for a given folder.
		/// </summary>
		public string FolderClass
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.FolderClass; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.FolderClass = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Folders]. NotReadonly. AllowNull.
		/// Contains the display name of a folder.
		/// </summary>
		public string DisplayName
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.DisplayName; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.DisplayName = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Folders]. Readonly. AllowNull.
		/// Represents the total count of items within a given folder.
		/// </summary>
		public int? TotalCount
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.TotalCount; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.TotalCount = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Folders]. Readonly. AllowNull.
		/// Represents the number of child folders that are contained within a folder.
		/// </summary>
		public int? ChildFolderCount
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ChildFolderCount; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ChildFolderCount = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Folders]. Readonly. AllowNull.
		/// Indicates whether a managed folder can be deleted by a customer.
		/// </summary>
		public bool? CanDelete
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.CanDelete; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.CanDelete = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Folders]. Readonly. AllowNull.
		/// Indicates whether a given managed folder can be renamed or moved by the customer.
		/// </summary>
		public bool? CanRenameOrMove
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.CanRenameOrMove; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.CanRenameOrMove = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Folders]. Readonly. AllowNull.
		/// Indicates whether the managed folder comment must be displayed.
		/// </summary>
		public bool? MustDisplayComment
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.MustDisplayComment; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.MustDisplayComment = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Folders]. Readonly. AllowNull.
		/// Indicates whether the managed folder has a quota.
		/// </summary>
		public bool? HasQuota
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.HasQuota; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.HasQuota = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Folders]. Readonly. AllowNull.
		/// Indicates whether the managed folder is the root for all managed folders.
		/// </summary>
		public bool? IsManagedFoldersRoot
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.IsManagedFoldersRoot; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.IsManagedFoldersRoot = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Folders]. Readonly. AllowNull.
		/// Contains the folder Id of the managed folder.
		/// </summary>
		public string ManagedFolderId
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ManagedFolderId; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ManagedFolderId = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Folders]. Readonly. AllowNull.
		/// Contains the comment that is associated with a managed folder.
		/// </summary>
		public string Comment
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Comment; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Comment = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Folders]. Readonly. AllowNull.
		/// Describes the storage quota for the managed folder.
		/// </summary>
		public int? StorageQuota
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.StorageQuota; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.StorageQuota = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Folders]. Readonly. AllowNull.
		/// Describes the total size of all the contents of a managed folder.
		/// </summary>
		public int? FolderSize
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.FolderSize; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.FolderSize = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Folders]. Readonly. AllowNull.
		/// Specifies the URL that will be the default home page for the managed folder.
		/// </summary>
		public string HomePage
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.HomePage; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.HomePage = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Folders]. Readonly. AllowNull.
		/// Represents the count of unread items within a given folder.
		/// </summary>
		public int? UnreadCount
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.UnreadCount; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.UnreadCount = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Folders]. Readonly. AllowNull.
		/// Indicates whether a client can create an associated contents table.
		/// </summary>
		public bool? EffectiveRights_CreateAssociated
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.EffectiveRights_CreateAssociated; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.EffectiveRights_CreateAssociated = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Folders]. Readonly. AllowNull.
		/// Indicates whether a client can create a contents table.
		/// </summary>
		public bool? EffectiveRights_CreateContents
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.EffectiveRights_CreateContents; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.EffectiveRights_CreateContents = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Folders]. Readonly. AllowNull.
		/// Indicates whether a client can create a hierarchy table.
		/// </summary>
		public bool? EffectiveRights_CreateHierarchy
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.EffectiveRights_CreateHierarchy; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.EffectiveRights_CreateHierarchy = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Folders]. Readonly. AllowNull.
		/// Indicates whether a client can delete a folder or item.
		/// </summary>
		public bool? EffectiveRights_Delete
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.EffectiveRights_Delete; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.EffectiveRights_Delete = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Folders]. Readonly. AllowNull.
		/// Indicates whether a client can modify a folder or item.
		/// </summary>
		public bool? EffectiveRights_Modify
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.EffectiveRights_Modify; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.EffectiveRights_Modify = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Folders]. Readonly. AllowNull.
		/// Indicates whether a client can read a folder or item.
		/// </summary>
		public bool? EffectiveRights_Read
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.EffectiveRights_Read; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.EffectiveRights_Read = value; }
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Folders]. Readonly. AllowNull.
		/// Indicates whether a private item can be viewed.
		/// </summary>
		public bool? EffectiveRights_ViewPrivateItems
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.EffectiveRights_ViewPrivateItems; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.EffectiveRights_ViewPrivateItems = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Folders]. NotReadonly. AllowNull.
		/// Indicates the permissions that the user has for the contact data that is being shared.
		/// </summary>
		public string SharingEffectiveRights
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.SharingEffectiveRights; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.SharingEffectiveRights = value; }
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
			this.InsertItem(index, new PriKey_Folders_Record());
			this.CurrentRecordIndex = index;
		}

		public void Append(PriKey_Folders_Record record)
		{
			int index = this.RecordCount;
			this.InsertItem(index, record);
			this.CurrentRecordIndex = index;
		}

		public PriKey_Folders_Record NewRecord()
		{
			return new PriKey_Folders_Record();
		}

		protected override PriKey_Folders_Record InternalCreateExistingRecordObject(object[] columnvalues) => new PriKey_Folders_Record(columnvalues);

		byte[] IRecordsetBase.Hash
		{
			get { return new byte[] { 225, 159, 124, 185, 167, 250, 201, 132, 143, 24, 101, 163, 42, 194, 111, 189 }; }
		}

		string IRecordsetBase.HashString
		{
			get { return "E19F7CB9A7FAC9848F1865A32AC26FBD"; }
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

		public void SetExecSqlParams(string FolderId)
		{
			_inputparametervalues[0] = FolderId;
		}

		public void ExecSql(string FolderId)
		{
			_inputparametervalues[0] = FolderId;
			Transactional.ExecSql(VenturaConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public void ExecSql(Connector connector, string FolderId)
		{
			_inputparametervalues[0] = FolderId;
			Transactional.ExecSql(connector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync(string FolderId)
		{
			_inputparametervalues[0] = FolderId;
			await Transactional.ExecSqlAsync(VenturaConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync(Connector connector, string FolderId)
		{
			_inputparametervalues[0] = FolderId;
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

			public string FolderId
			{
				get { return (string)_values[0]; }
				set { _values[0] = value; }
			}

		}

	}

	public sealed partial class PriKey_Folders_Record : IRecordBase, INotifyPropertyChanged
	{
		private DataRecordStatus _recordstatus;
		private bool _started_with_dbvalues;

		private string _cur__FolderId; private string _ori__FolderId; private bool _mod__FolderId;
		private string _cur__FolderChangeKey; private string _ori__FolderChangeKey; private bool _mod__FolderChangeKey;
		private string _cur__ParentFolderId; private string _ori__ParentFolderId; private bool _mod__ParentFolderId;
		private string _cur__ParentFolderChangeKey; private string _ori__ParentFolderChangeKey; private bool _mod__ParentFolderChangeKey;
		private string _cur__FolderClass; private string _ori__FolderClass; private bool _mod__FolderClass;
		private string _cur__DisplayName; private string _ori__DisplayName; private bool _mod__DisplayName;
		private int? _cur__TotalCount; private int? _ori__TotalCount; private bool _mod__TotalCount;
		private int? _cur__ChildFolderCount; private int? _ori__ChildFolderCount; private bool _mod__ChildFolderCount;
		private bool? _cur__CanDelete; private bool? _ori__CanDelete; private bool _mod__CanDelete;
		private bool? _cur__CanRenameOrMove; private bool? _ori__CanRenameOrMove; private bool _mod__CanRenameOrMove;
		private bool? _cur__MustDisplayComment; private bool? _ori__MustDisplayComment; private bool _mod__MustDisplayComment;
		private bool? _cur__HasQuota; private bool? _ori__HasQuota; private bool _mod__HasQuota;
		private bool? _cur__IsManagedFoldersRoot; private bool? _ori__IsManagedFoldersRoot; private bool _mod__IsManagedFoldersRoot;
		private string _cur__ManagedFolderId; private string _ori__ManagedFolderId; private bool _mod__ManagedFolderId;
		private string _cur__Comment; private string _ori__Comment; private bool _mod__Comment;
		private int? _cur__StorageQuota; private int? _ori__StorageQuota; private bool _mod__StorageQuota;
		private int? _cur__FolderSize; private int? _ori__FolderSize; private bool _mod__FolderSize;
		private string _cur__HomePage; private string _ori__HomePage; private bool _mod__HomePage;
		private int? _cur__UnreadCount; private int? _ori__UnreadCount; private bool _mod__UnreadCount;
		private bool? _cur__EffectiveRights_CreateAssociated; private bool? _ori__EffectiveRights_CreateAssociated; private bool _mod__EffectiveRights_CreateAssociated;
		private bool? _cur__EffectiveRights_CreateContents; private bool? _ori__EffectiveRights_CreateContents; private bool _mod__EffectiveRights_CreateContents;
		private bool? _cur__EffectiveRights_CreateHierarchy; private bool? _ori__EffectiveRights_CreateHierarchy; private bool _mod__EffectiveRights_CreateHierarchy;
		private bool? _cur__EffectiveRights_Delete; private bool? _ori__EffectiveRights_Delete; private bool _mod__EffectiveRights_Delete;
		private bool? _cur__EffectiveRights_Modify; private bool? _ori__EffectiveRights_Modify; private bool _mod__EffectiveRights_Modify;
		private bool? _cur__EffectiveRights_Read; private bool? _ori__EffectiveRights_Read; private bool _mod__EffectiveRights_Read;
		private bool? _cur__EffectiveRights_ViewPrivateItems; private bool? _ori__EffectiveRights_ViewPrivateItems; private bool _mod__EffectiveRights_ViewPrivateItems;
		private string _cur__SharingEffectiveRights; private string _ori__SharingEffectiveRights; private bool _mod__SharingEffectiveRights;


		public PriKey_Folders_Record()
		{
			_cur__FolderId = null;
			_cur__FolderChangeKey = null;
			_cur__ParentFolderId = null;
			_cur__ParentFolderChangeKey = null;
			_cur__FolderClass = null;
			_cur__DisplayName = null;
			_cur__TotalCount = null;
			_cur__ChildFolderCount = null;
			_cur__CanDelete = null;
			_cur__CanRenameOrMove = null;
			_cur__MustDisplayComment = null;
			_cur__HasQuota = null;
			_cur__IsManagedFoldersRoot = null;
			_cur__ManagedFolderId = null;
			_cur__Comment = null;
			_cur__StorageQuota = null;
			_cur__FolderSize = null;
			_cur__HomePage = null;
			_cur__UnreadCount = null;
			_cur__EffectiveRights_CreateAssociated = null;
			_cur__EffectiveRights_CreateContents = null;
			_cur__EffectiveRights_CreateHierarchy = null;
			_cur__EffectiveRights_Delete = null;
			_cur__EffectiveRights_Modify = null;
			_cur__EffectiveRights_Read = null;
			_cur__EffectiveRights_ViewPrivateItems = null;
			_cur__SharingEffectiveRights = null;
			_started_with_dbvalues = false;
			_recordstatus = DataRecordStatus.New;
		}

		public PriKey_Folders_Record(object[] columnvalues)
		{
			_cur__FolderId = (string)columnvalues[0];
			_cur__FolderChangeKey = (string)columnvalues[1];
			_cur__ParentFolderId = (string)columnvalues[2];
			_cur__ParentFolderChangeKey = (string)columnvalues[3];
			_cur__FolderClass = (string)columnvalues[4];
			_cur__DisplayName = (string)columnvalues[5];
			_cur__TotalCount = (int?)columnvalues[6];
			_cur__ChildFolderCount = (int?)columnvalues[7];
			_cur__CanDelete = (bool?)columnvalues[8];
			_cur__CanRenameOrMove = (bool?)columnvalues[9];
			_cur__MustDisplayComment = (bool?)columnvalues[10];
			_cur__HasQuota = (bool?)columnvalues[11];
			_cur__IsManagedFoldersRoot = (bool?)columnvalues[12];
			_cur__ManagedFolderId = (string)columnvalues[13];
			_cur__Comment = (string)columnvalues[14];
			_cur__StorageQuota = (int?)columnvalues[15];
			_cur__FolderSize = (int?)columnvalues[16];
			_cur__HomePage = (string)columnvalues[17];
			_cur__UnreadCount = (int?)columnvalues[18];
			_cur__EffectiveRights_CreateAssociated = (bool?)columnvalues[19];
			_cur__EffectiveRights_CreateContents = (bool?)columnvalues[20];
			_cur__EffectiveRights_CreateHierarchy = (bool?)columnvalues[21];
			_cur__EffectiveRights_Delete = (bool?)columnvalues[22];
			_cur__EffectiveRights_Modify = (bool?)columnvalues[23];
			_cur__EffectiveRights_Read = (bool?)columnvalues[24];
			_cur__EffectiveRights_ViewPrivateItems = (bool?)columnvalues[25];
			_cur__SharingEffectiveRights = (string)columnvalues[26];
			_started_with_dbvalues = true;
			_recordstatus = DataRecordStatus.Existing;
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Folders]. PrimaryKey. Readonly. AllowNull.
		/// Contains the unique identifier of an folder in the Exchange store.
		/// </summary>
		public string FolderId
		{
			get { return _cur__FolderId; }
			set
			{
				if (_started_with_dbvalues == false) _mod__FolderId = true;
				if (_cur__FolderId == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__FolderId == false) { _ori__FolderId = _cur__FolderId; _mod__FolderId = true; } // existing record and column is not modified
					else { if (value == _ori__FolderId) { _ori__FolderId = default(string); _mod__FolderId = false; } } // existing record and column is modified
				}
				_cur__FolderId = value; OnPropertyChanged("FolderId"); OnAfterPropertyChanged("FolderId");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Folders]. Readonly. AllowNull.
		/// Contains the unique change key of an folder in the Exchange store.
		/// </summary>
		public string FolderChangeKey
		{
			get { return _cur__FolderChangeKey; }
			set
			{
				if (_started_with_dbvalues == false) _mod__FolderChangeKey = true;
				if (_cur__FolderChangeKey == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__FolderChangeKey == false) { _ori__FolderChangeKey = _cur__FolderChangeKey; _mod__FolderChangeKey = true; } // existing record and column is not modified
					else { if (value == _ori__FolderChangeKey) { _ori__FolderChangeKey = default(string); _mod__FolderChangeKey = false; } } // existing record and column is modified
				}
				_cur__FolderChangeKey = value; OnPropertyChanged("FolderChangeKey"); OnAfterPropertyChanged("FolderChangeKey");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Folders]. NotReadonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Folders]. Readonly. AllowNull.
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
		/// Database Column Updateable. Table [Exchange].[Folders]. NotReadonly. AllowNull.
		/// Represents the folder class for a given folder.
		/// </summary>
		public string FolderClass
		{
			get { return _cur__FolderClass; }
			set
			{
				if (_started_with_dbvalues == false) _mod__FolderClass = true;
				if (_cur__FolderClass == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__FolderClass == false) { _ori__FolderClass = _cur__FolderClass; _mod__FolderClass = true; } // existing record and column is not modified
					else { if (value == _ori__FolderClass) { _ori__FolderClass = default(string); _mod__FolderClass = false; } } // existing record and column is modified
				}
				_cur__FolderClass = value; OnPropertyChanged("FolderClass"); OnAfterPropertyChanged("FolderClass");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Folders]. NotReadonly. AllowNull.
		/// Contains the display name of a folder.
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
		/// Database Column NotUpdateable. Table [Exchange].[Folders]. Readonly. AllowNull.
		/// Represents the total count of items within a given folder.
		/// </summary>
		public int? TotalCount
		{
			get { return _cur__TotalCount; }
			set
			{
				if (_started_with_dbvalues == false) _mod__TotalCount = true;
				if (_cur__TotalCount == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__TotalCount == false) { _ori__TotalCount = _cur__TotalCount; _mod__TotalCount = true; } // existing record and column is not modified
					else { if (value == _ori__TotalCount) { _ori__TotalCount = default(int?); _mod__TotalCount = false; } } // existing record and column is modified
				}
				_cur__TotalCount = value; OnPropertyChanged("TotalCount"); OnAfterPropertyChanged("TotalCount");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Folders]. Readonly. AllowNull.
		/// Represents the number of child folders that are contained within a folder.
		/// </summary>
		public int? ChildFolderCount
		{
			get { return _cur__ChildFolderCount; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ChildFolderCount = true;
				if (_cur__ChildFolderCount == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ChildFolderCount == false) { _ori__ChildFolderCount = _cur__ChildFolderCount; _mod__ChildFolderCount = true; } // existing record and column is not modified
					else { if (value == _ori__ChildFolderCount) { _ori__ChildFolderCount = default(int?); _mod__ChildFolderCount = false; } } // existing record and column is modified
				}
				_cur__ChildFolderCount = value; OnPropertyChanged("ChildFolderCount"); OnAfterPropertyChanged("ChildFolderCount");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Folders]. Readonly. AllowNull.
		/// Indicates whether a managed folder can be deleted by a customer.
		/// </summary>
		public bool? CanDelete
		{
			get { return _cur__CanDelete; }
			set
			{
				if (_started_with_dbvalues == false) _mod__CanDelete = true;
				if (_cur__CanDelete == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__CanDelete == false) { _ori__CanDelete = _cur__CanDelete; _mod__CanDelete = true; } // existing record and column is not modified
					else { if (value == _ori__CanDelete) { _ori__CanDelete = default(bool?); _mod__CanDelete = false; } } // existing record and column is modified
				}
				_cur__CanDelete = value; OnPropertyChanged("CanDelete"); OnAfterPropertyChanged("CanDelete");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Folders]. Readonly. AllowNull.
		/// Indicates whether a given managed folder can be renamed or moved by the customer.
		/// </summary>
		public bool? CanRenameOrMove
		{
			get { return _cur__CanRenameOrMove; }
			set
			{
				if (_started_with_dbvalues == false) _mod__CanRenameOrMove = true;
				if (_cur__CanRenameOrMove == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__CanRenameOrMove == false) { _ori__CanRenameOrMove = _cur__CanRenameOrMove; _mod__CanRenameOrMove = true; } // existing record and column is not modified
					else { if (value == _ori__CanRenameOrMove) { _ori__CanRenameOrMove = default(bool?); _mod__CanRenameOrMove = false; } } // existing record and column is modified
				}
				_cur__CanRenameOrMove = value; OnPropertyChanged("CanRenameOrMove"); OnAfterPropertyChanged("CanRenameOrMove");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Folders]. Readonly. AllowNull.
		/// Indicates whether the managed folder comment must be displayed.
		/// </summary>
		public bool? MustDisplayComment
		{
			get { return _cur__MustDisplayComment; }
			set
			{
				if (_started_with_dbvalues == false) _mod__MustDisplayComment = true;
				if (_cur__MustDisplayComment == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__MustDisplayComment == false) { _ori__MustDisplayComment = _cur__MustDisplayComment; _mod__MustDisplayComment = true; } // existing record and column is not modified
					else { if (value == _ori__MustDisplayComment) { _ori__MustDisplayComment = default(bool?); _mod__MustDisplayComment = false; } } // existing record and column is modified
				}
				_cur__MustDisplayComment = value; OnPropertyChanged("MustDisplayComment"); OnAfterPropertyChanged("MustDisplayComment");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Folders]. Readonly. AllowNull.
		/// Indicates whether the managed folder has a quota.
		/// </summary>
		public bool? HasQuota
		{
			get { return _cur__HasQuota; }
			set
			{
				if (_started_with_dbvalues == false) _mod__HasQuota = true;
				if (_cur__HasQuota == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__HasQuota == false) { _ori__HasQuota = _cur__HasQuota; _mod__HasQuota = true; } // existing record and column is not modified
					else { if (value == _ori__HasQuota) { _ori__HasQuota = default(bool?); _mod__HasQuota = false; } } // existing record and column is modified
				}
				_cur__HasQuota = value; OnPropertyChanged("HasQuota"); OnAfterPropertyChanged("HasQuota");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Folders]. Readonly. AllowNull.
		/// Indicates whether the managed folder is the root for all managed folders.
		/// </summary>
		public bool? IsManagedFoldersRoot
		{
			get { return _cur__IsManagedFoldersRoot; }
			set
			{
				if (_started_with_dbvalues == false) _mod__IsManagedFoldersRoot = true;
				if (_cur__IsManagedFoldersRoot == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__IsManagedFoldersRoot == false) { _ori__IsManagedFoldersRoot = _cur__IsManagedFoldersRoot; _mod__IsManagedFoldersRoot = true; } // existing record and column is not modified
					else { if (value == _ori__IsManagedFoldersRoot) { _ori__IsManagedFoldersRoot = default(bool?); _mod__IsManagedFoldersRoot = false; } } // existing record and column is modified
				}
				_cur__IsManagedFoldersRoot = value; OnPropertyChanged("IsManagedFoldersRoot"); OnAfterPropertyChanged("IsManagedFoldersRoot");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Folders]. Readonly. AllowNull.
		/// Contains the folder Id of the managed folder.
		/// </summary>
		public string ManagedFolderId
		{
			get { return _cur__ManagedFolderId; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ManagedFolderId = true;
				if (_cur__ManagedFolderId == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ManagedFolderId == false) { _ori__ManagedFolderId = _cur__ManagedFolderId; _mod__ManagedFolderId = true; } // existing record and column is not modified
					else { if (value == _ori__ManagedFolderId) { _ori__ManagedFolderId = default(string); _mod__ManagedFolderId = false; } } // existing record and column is modified
				}
				_cur__ManagedFolderId = value; OnPropertyChanged("ManagedFolderId"); OnAfterPropertyChanged("ManagedFolderId");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Folders]. Readonly. AllowNull.
		/// Contains the comment that is associated with a managed folder.
		/// </summary>
		public string Comment
		{
			get { return _cur__Comment; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Comment = true;
				if (_cur__Comment == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Comment == false) { _ori__Comment = _cur__Comment; _mod__Comment = true; } // existing record and column is not modified
					else { if (value == _ori__Comment) { _ori__Comment = default(string); _mod__Comment = false; } } // existing record and column is modified
				}
				_cur__Comment = value; OnPropertyChanged("Comment"); OnAfterPropertyChanged("Comment");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Folders]. Readonly. AllowNull.
		/// Describes the storage quota for the managed folder.
		/// </summary>
		public int? StorageQuota
		{
			get { return _cur__StorageQuota; }
			set
			{
				if (_started_with_dbvalues == false) _mod__StorageQuota = true;
				if (_cur__StorageQuota == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__StorageQuota == false) { _ori__StorageQuota = _cur__StorageQuota; _mod__StorageQuota = true; } // existing record and column is not modified
					else { if (value == _ori__StorageQuota) { _ori__StorageQuota = default(int?); _mod__StorageQuota = false; } } // existing record and column is modified
				}
				_cur__StorageQuota = value; OnPropertyChanged("StorageQuota"); OnAfterPropertyChanged("StorageQuota");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Folders]. Readonly. AllowNull.
		/// Describes the total size of all the contents of a managed folder.
		/// </summary>
		public int? FolderSize
		{
			get { return _cur__FolderSize; }
			set
			{
				if (_started_with_dbvalues == false) _mod__FolderSize = true;
				if (_cur__FolderSize == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__FolderSize == false) { _ori__FolderSize = _cur__FolderSize; _mod__FolderSize = true; } // existing record and column is not modified
					else { if (value == _ori__FolderSize) { _ori__FolderSize = default(int?); _mod__FolderSize = false; } } // existing record and column is modified
				}
				_cur__FolderSize = value; OnPropertyChanged("FolderSize"); OnAfterPropertyChanged("FolderSize");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Folders]. Readonly. AllowNull.
		/// Specifies the URL that will be the default home page for the managed folder.
		/// </summary>
		public string HomePage
		{
			get { return _cur__HomePage; }
			set
			{
				if (_started_with_dbvalues == false) _mod__HomePage = true;
				if (_cur__HomePage == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__HomePage == false) { _ori__HomePage = _cur__HomePage; _mod__HomePage = true; } // existing record and column is not modified
					else { if (value == _ori__HomePage) { _ori__HomePage = default(string); _mod__HomePage = false; } } // existing record and column is modified
				}
				_cur__HomePage = value; OnPropertyChanged("HomePage"); OnAfterPropertyChanged("HomePage");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Folders]. Readonly. AllowNull.
		/// Represents the count of unread items within a given folder.
		/// </summary>
		public int? UnreadCount
		{
			get { return _cur__UnreadCount; }
			set
			{
				if (_started_with_dbvalues == false) _mod__UnreadCount = true;
				if (_cur__UnreadCount == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__UnreadCount == false) { _ori__UnreadCount = _cur__UnreadCount; _mod__UnreadCount = true; } // existing record and column is not modified
					else { if (value == _ori__UnreadCount) { _ori__UnreadCount = default(int?); _mod__UnreadCount = false; } } // existing record and column is modified
				}
				_cur__UnreadCount = value; OnPropertyChanged("UnreadCount"); OnAfterPropertyChanged("UnreadCount");
			}
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Exchange].[Folders]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Folders]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Folders]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Folders]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Folders]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Folders]. Readonly. AllowNull.
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
		/// Database Column NotUpdateable. Table [Exchange].[Folders]. Readonly. AllowNull.
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
		/// Database Column Updateable. Table [Exchange].[Folders]. NotReadonly. AllowNull.
		/// Indicates the permissions that the user has for the contact data that is being shared.
		/// </summary>
		public string SharingEffectiveRights
		{
			get { return _cur__SharingEffectiveRights; }
			set
			{
				if (_started_with_dbvalues == false) _mod__SharingEffectiveRights = true;
				if (_cur__SharingEffectiveRights == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__SharingEffectiveRights == false) { _ori__SharingEffectiveRights = _cur__SharingEffectiveRights; _mod__SharingEffectiveRights = true; } // existing record and column is not modified
					else { if (value == _ori__SharingEffectiveRights) { _ori__SharingEffectiveRights = default(string); _mod__SharingEffectiveRights = false; } } // existing record and column is modified
				}
				_cur__SharingEffectiveRights = value; OnPropertyChanged("SharingEffectiveRights"); OnAfterPropertyChanged("SharingEffectiveRights");
			}
		}

		public bool IsModified(string column_name)
		{
			if (column_name == "FolderId") return _mod__FolderId;
			if (column_name == "FolderChangeKey") return _mod__FolderChangeKey;
			if (column_name == "ParentFolderId") return _mod__ParentFolderId;
			if (column_name == "ParentFolderChangeKey") return _mod__ParentFolderChangeKey;
			if (column_name == "FolderClass") return _mod__FolderClass;
			if (column_name == "DisplayName") return _mod__DisplayName;
			if (column_name == "TotalCount") return _mod__TotalCount;
			if (column_name == "ChildFolderCount") return _mod__ChildFolderCount;
			if (column_name == "CanDelete") return _mod__CanDelete;
			if (column_name == "CanRenameOrMove") return _mod__CanRenameOrMove;
			if (column_name == "MustDisplayComment") return _mod__MustDisplayComment;
			if (column_name == "HasQuota") return _mod__HasQuota;
			if (column_name == "IsManagedFoldersRoot") return _mod__IsManagedFoldersRoot;
			if (column_name == "ManagedFolderId") return _mod__ManagedFolderId;
			if (column_name == "Comment") return _mod__Comment;
			if (column_name == "StorageQuota") return _mod__StorageQuota;
			if (column_name == "FolderSize") return _mod__FolderSize;
			if (column_name == "HomePage") return _mod__HomePage;
			if (column_name == "UnreadCount") return _mod__UnreadCount;
			if (column_name == "EffectiveRights_CreateAssociated") return _mod__EffectiveRights_CreateAssociated;
			if (column_name == "EffectiveRights_CreateContents") return _mod__EffectiveRights_CreateContents;
			if (column_name == "EffectiveRights_CreateHierarchy") return _mod__EffectiveRights_CreateHierarchy;
			if (column_name == "EffectiveRights_Delete") return _mod__EffectiveRights_Delete;
			if (column_name == "EffectiveRights_Modify") return _mod__EffectiveRights_Modify;
			if (column_name == "EffectiveRights_Read") return _mod__EffectiveRights_Read;
			if (column_name == "EffectiveRights_ViewPrivateItems") return _mod__EffectiveRights_ViewPrivateItems;
			if (column_name == "SharingEffectiveRights") return _mod__SharingEffectiveRights;
			throw new ArgumentOutOfRangeException(String.Format(VenturaStrings.UNKNOWN_COLUMN_NAME, column_name));
		}

		public int ModifiedColumnCount()
		{
			int count = 0;
			if (_mod__FolderId == true) count++;
			if (_mod__FolderChangeKey == true) count++;
			if (_mod__ParentFolderId == true) count++;
			if (_mod__ParentFolderChangeKey == true) count++;
			if (_mod__FolderClass == true) count++;
			if (_mod__DisplayName == true) count++;
			if (_mod__TotalCount == true) count++;
			if (_mod__ChildFolderCount == true) count++;
			if (_mod__CanDelete == true) count++;
			if (_mod__CanRenameOrMove == true) count++;
			if (_mod__MustDisplayComment == true) count++;
			if (_mod__HasQuota == true) count++;
			if (_mod__IsManagedFoldersRoot == true) count++;
			if (_mod__ManagedFolderId == true) count++;
			if (_mod__Comment == true) count++;
			if (_mod__StorageQuota == true) count++;
			if (_mod__FolderSize == true) count++;
			if (_mod__HomePage == true) count++;
			if (_mod__UnreadCount == true) count++;
			if (_mod__EffectiveRights_CreateAssociated == true) count++;
			if (_mod__EffectiveRights_CreateContents == true) count++;
			if (_mod__EffectiveRights_CreateHierarchy == true) count++;
			if (_mod__EffectiveRights_Delete == true) count++;
			if (_mod__EffectiveRights_Modify == true) count++;
			if (_mod__EffectiveRights_Read == true) count++;
			if (_mod__EffectiveRights_ViewPrivateItems == true) count++;
			if (_mod__SharingEffectiveRights == true) count++;
			return count;
		}

		public bool PendingChanges()
		{
			if (_recordstatus == DataRecordStatus.New || _recordstatus == DataRecordStatus.ExistingDelete) return true;
			int count = 0;
			if (_mod__ParentFolderId == true) count++;
			if (_mod__FolderClass == true) count++;
			if (_mod__DisplayName == true) count++;
			if (_mod__SharingEffectiveRights == true) count++;
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
				if (_cur__ParentFolderId != null) track_array.AppendDataValue(2, _cur__ParentFolderId);
				if (_cur__FolderClass != null) track_array.AppendDataValue(4, _cur__FolderClass);
				if (_cur__DisplayName != null) track_array.AppendDataValue(5, _cur__DisplayName);
				if (_cur__SharingEffectiveRights != null) track_array.AppendDataValue(26, _cur__SharingEffectiveRights);
			}
			else if (_recordstatus == DataRecordStatus.Existing)
			{
				if (_mod__ParentFolderId) track_array.AppendDataValue(2, _cur__ParentFolderId);
				if (_mod__FolderClass) track_array.AppendDataValue(4, _cur__FolderClass);
				if (_mod__DisplayName) track_array.AppendDataValue(5, _cur__DisplayName);
				if (_mod__SharingEffectiveRights) track_array.AppendDataValue(26, _cur__SharingEffectiveRights);
				if (track_array.HasData == false) return;
			}

			if (_recordstatus == DataRecordStatus.Existing || _recordstatus == DataRecordStatus.ExistingDelete)
			{
				track_array.AppendPrikeyValue(0, (_mod__FolderId && _started_with_dbvalues) ? _ori__FolderId : _cur__FolderId);
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
				if (_mod__FolderId) _ori__FolderId = default(string);
				if (_mod__FolderChangeKey) _ori__FolderChangeKey = default(string);
				if (_mod__ParentFolderId) _ori__ParentFolderId = default(string);
				if (_mod__ParentFolderChangeKey) _ori__ParentFolderChangeKey = default(string);
				if (_mod__FolderClass) _ori__FolderClass = default(string);
				if (_mod__DisplayName) _ori__DisplayName = default(string);
				if (_mod__TotalCount) _ori__TotalCount = default(int?);
				if (_mod__ChildFolderCount) _ori__ChildFolderCount = default(int?);
				if (_mod__CanDelete) _ori__CanDelete = default(bool?);
				if (_mod__CanRenameOrMove) _ori__CanRenameOrMove = default(bool?);
				if (_mod__MustDisplayComment) _ori__MustDisplayComment = default(bool?);
				if (_mod__HasQuota) _ori__HasQuota = default(bool?);
				if (_mod__IsManagedFoldersRoot) _ori__IsManagedFoldersRoot = default(bool?);
				if (_mod__ManagedFolderId) _ori__ManagedFolderId = default(string);
				if (_mod__Comment) _ori__Comment = default(string);
				if (_mod__StorageQuota) _ori__StorageQuota = default(int?);
				if (_mod__FolderSize) _ori__FolderSize = default(int?);
				if (_mod__HomePage) _ori__HomePage = default(string);
				if (_mod__UnreadCount) _ori__UnreadCount = default(int?);
				if (_mod__EffectiveRights_CreateAssociated) _ori__EffectiveRights_CreateAssociated = default(bool?);
				if (_mod__EffectiveRights_CreateContents) _ori__EffectiveRights_CreateContents = default(bool?);
				if (_mod__EffectiveRights_CreateHierarchy) _ori__EffectiveRights_CreateHierarchy = default(bool?);
				if (_mod__EffectiveRights_Delete) _ori__EffectiveRights_Delete = default(bool?);
				if (_mod__EffectiveRights_Modify) _ori__EffectiveRights_Modify = default(bool?);
				if (_mod__EffectiveRights_Read) _ori__EffectiveRights_Read = default(bool?);
				if (_mod__EffectiveRights_ViewPrivateItems) _ori__EffectiveRights_ViewPrivateItems = default(bool?);
				if (_mod__SharingEffectiveRights) _ori__SharingEffectiveRights = default(string);
			}
			_mod__FolderId = false;
			_mod__FolderChangeKey = false;
			_mod__ParentFolderId = false;
			_mod__ParentFolderChangeKey = false;
			_mod__FolderClass = false;
			_mod__DisplayName = false;
			_mod__TotalCount = false;
			_mod__ChildFolderCount = false;
			_mod__CanDelete = false;
			_mod__CanRenameOrMove = false;
			_mod__MustDisplayComment = false;
			_mod__HasQuota = false;
			_mod__IsManagedFoldersRoot = false;
			_mod__ManagedFolderId = false;
			_mod__Comment = false;
			_mod__StorageQuota = false;
			_mod__FolderSize = false;
			_mod__HomePage = false;
			_mod__UnreadCount = false;
			_mod__EffectiveRights_CreateAssociated = false;
			_mod__EffectiveRights_CreateContents = false;
			_mod__EffectiveRights_CreateHierarchy = false;
			_mod__EffectiveRights_Delete = false;
			_mod__EffectiveRights_Modify = false;
			_mod__EffectiveRights_Read = false;
			_mod__EffectiveRights_ViewPrivateItems = false;
			_mod__SharingEffectiveRights = false;
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
	public partial class PriKey_Folders_Record
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
