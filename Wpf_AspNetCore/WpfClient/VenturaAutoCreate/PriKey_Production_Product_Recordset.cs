/*
	Project file: "C:\Active\VenturaSQL\BuildSystem\Templates\Wpf_AspNetCore\Template.venproj"
	Target platform: NETStandard
	Generator version: 4.0.126
	Generated on: Tuesday, 11 May 2021 at 12:04:37
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
	/// The updateable table is [Production].[Product]. Updateable table column information:
	/// • 25 out of 25 table columns are present in the resultset.
	/// • All primary key columns are present in the resultset: ProductID.
	/// • Non-primary key columns present in the resultset: Name, ProductNumber, MakeFlag, FinishedGoodsFlag, Color,
	///   SafetyStockLevel, ReorderPoint, StandardCost, ListPrice, Size, SizeUnitMeasureCode, WeightUnitMeasureCode, Weight,
	///   DaysToManufacture, ProductLine, Class, Style, ProductSubcategoryID, ProductModelID, SellStartDate, SellEndDate,
	///   DiscontinuedDate, rowguid and ModifiedDate.
	/// Recordset item automatically created by VenturaSQL Studio.
	/// </summary>
	public partial class PriKey_Production_Product_Recordset : ResultsetObservable<PriKey_Production_Product_Recordset, PriKey_Production_Product_Record>, IRecordsetBase
	{
		private IResultsetBase[] _resultsets;
		private string _sqlscript;
		private object[] _inputparametervalues;
		private InputParamHolder _inputparamholder;
		private VenturaSqlSchema _parameterschema;
		private int _rowlimit = 500;
		private const string CRLF = "\r\n";

		public PriKey_Production_Product_Recordset()
		{
			_resultsets = new IResultsetBase[] { this };

			_sqlscript = @"SELECT [ProductID],[Name],[ProductNumber],[MakeFlag],[FinishedGoodsFlag],[Color],[SafetyStockLevel],[ReorderPoint],[StandardCost],[ListPrice],[Size],[SizeUnitMeasureCode]," + CRLF +
			             @"[WeightUnitMeasureCode],[Weight],[DaysToManufacture],[ProductLine],[Class],[Style],[ProductSubcategoryID],[ProductModelID],[SellStartDate],[SellEndDate]," + CRLF +
			             @"[DiscontinuedDate],[rowguid],[ModifiedDate]" + CRLF +
			             @"FROM [Production].[Product]" + CRLF +
			             @"WHERE [ProductID] = @ProductID";

			_inputparametervalues = new object[1];
			_inputparamholder = new InputParamHolder(_inputparametervalues);

			ColumnArrayBuilder param_array = new ColumnArrayBuilder();

			param_array.AddParameterColumn("@ProductID", typeof(int), true, false, DbType.Int32, null, null, null);

			_parameterschema = new VenturaSqlSchema(param_array);

			ColumnArrayBuilder schema_array = new ColumnArrayBuilder();

			schema_array.Add(new VenturaSqlColumn("ProductID", typeof(int), false)
			{
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				IsKey = true,
				IsIdentity = true,
				IsAutoIncrement = true,
				BaseSchemaName = "Production",
				BaseTableName = "Product",
				BaseColumnName = "ProductID"
			});

			schema_array.Add(new VenturaSqlColumn("Name", typeof(string), false)
			{
				Updateable = true,
				ColumnSize = 50,
				ProviderType = 12,
				BaseSchemaName = "Production",
				BaseTableName = "Product",
				BaseColumnName = "Name"
			});

			schema_array.Add(new VenturaSqlColumn("ProductNumber", typeof(string), false)
			{
				Updateable = true,
				ColumnSize = 25,
				ProviderType = 12,
				BaseSchemaName = "Production",
				BaseTableName = "Product",
				BaseColumnName = "ProductNumber"
			});

			schema_array.Add(new VenturaSqlColumn("MakeFlag", typeof(bool), false)
			{
				Updateable = true,
				ColumnSize = 1,
				ProviderType = 2,
				BaseSchemaName = "Production",
				BaseTableName = "Product",
				BaseColumnName = "MakeFlag"
			});

			schema_array.Add(new VenturaSqlColumn("FinishedGoodsFlag", typeof(bool), false)
			{
				Updateable = true,
				ColumnSize = 1,
				ProviderType = 2,
				BaseSchemaName = "Production",
				BaseTableName = "Product",
				BaseColumnName = "FinishedGoodsFlag"
			});

			schema_array.Add(new VenturaSqlColumn("Color", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 15,
				ProviderType = 12,
				BaseSchemaName = "Production",
				BaseTableName = "Product",
				BaseColumnName = "Color"
			});

			schema_array.Add(new VenturaSqlColumn("SafetyStockLevel", typeof(short), false)
			{
				Updateable = true,
				ColumnSize = 2,
				NumericPrecision = 5,
				ProviderType = 16,
				BaseSchemaName = "Production",
				BaseTableName = "Product",
				BaseColumnName = "SafetyStockLevel"
			});

			schema_array.Add(new VenturaSqlColumn("ReorderPoint", typeof(short), false)
			{
				Updateable = true,
				ColumnSize = 2,
				NumericPrecision = 5,
				ProviderType = 16,
				BaseSchemaName = "Production",
				BaseTableName = "Product",
				BaseColumnName = "ReorderPoint"
			});

			schema_array.Add(new VenturaSqlColumn("StandardCost", typeof(decimal), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 19,
				ProviderType = 9,
				BaseSchemaName = "Production",
				BaseTableName = "Product",
				BaseColumnName = "StandardCost"
			});

			schema_array.Add(new VenturaSqlColumn("ListPrice", typeof(decimal), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 19,
				ProviderType = 9,
				BaseSchemaName = "Production",
				BaseTableName = "Product",
				BaseColumnName = "ListPrice"
			});

			schema_array.Add(new VenturaSqlColumn("Size", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 5,
				ProviderType = 12,
				BaseSchemaName = "Production",
				BaseTableName = "Product",
				BaseColumnName = "Size"
			});

			schema_array.Add(new VenturaSqlColumn("SizeUnitMeasureCode", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 3,
				ProviderType = 10,
				BaseSchemaName = "Production",
				BaseTableName = "Product",
				BaseColumnName = "SizeUnitMeasureCode"
			});

			schema_array.Add(new VenturaSqlColumn("WeightUnitMeasureCode", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 3,
				ProviderType = 10,
				BaseSchemaName = "Production",
				BaseTableName = "Product",
				BaseColumnName = "WeightUnitMeasureCode"
			});

			schema_array.Add(new VenturaSqlColumn("Weight", typeof(decimal), true)
			{
				Updateable = true,
				ColumnSize = 17,
				NumericPrecision = 8,
				NumericScale = 2,
				ProviderType = 5,
				BaseSchemaName = "Production",
				BaseTableName = "Product",
				BaseColumnName = "Weight"
			});

			schema_array.Add(new VenturaSqlColumn("DaysToManufacture", typeof(int), false)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				BaseSchemaName = "Production",
				BaseTableName = "Product",
				BaseColumnName = "DaysToManufacture"
			});

			schema_array.Add(new VenturaSqlColumn("ProductLine", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2,
				ProviderType = 10,
				BaseSchemaName = "Production",
				BaseTableName = "Product",
				BaseColumnName = "ProductLine"
			});

			schema_array.Add(new VenturaSqlColumn("Class", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2,
				ProviderType = 10,
				BaseSchemaName = "Production",
				BaseTableName = "Product",
				BaseColumnName = "Class"
			});

			schema_array.Add(new VenturaSqlColumn("Style", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2,
				ProviderType = 10,
				BaseSchemaName = "Production",
				BaseTableName = "Product",
				BaseColumnName = "Style"
			});

			schema_array.Add(new VenturaSqlColumn("ProductSubcategoryID", typeof(int), true)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				BaseSchemaName = "Production",
				BaseTableName = "Product",
				BaseColumnName = "ProductSubcategoryID"
			});

			schema_array.Add(new VenturaSqlColumn("ProductModelID", typeof(int), true)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				BaseSchemaName = "Production",
				BaseTableName = "Product",
				BaseColumnName = "ProductModelID"
			});

			schema_array.Add(new VenturaSqlColumn("SellStartDate", typeof(DateTime), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 23,
				NumericScale = 3,
				ProviderType = 4,
				BaseSchemaName = "Production",
				BaseTableName = "Product",
				BaseColumnName = "SellStartDate"
			});

			schema_array.Add(new VenturaSqlColumn("SellEndDate", typeof(DateTime), true)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 23,
				NumericScale = 3,
				ProviderType = 4,
				BaseSchemaName = "Production",
				BaseTableName = "Product",
				BaseColumnName = "SellEndDate"
			});

			schema_array.Add(new VenturaSqlColumn("DiscontinuedDate", typeof(DateTime), true)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 23,
				NumericScale = 3,
				ProviderType = 4,
				BaseSchemaName = "Production",
				BaseTableName = "Product",
				BaseColumnName = "DiscontinuedDate"
			});

			schema_array.Add(new VenturaSqlColumn("rowguid", typeof(Guid), false)
			{
				Updateable = true,
				ColumnSize = 16,
				ProviderType = 14,
				BaseSchemaName = "Production",
				BaseTableName = "Product",
				BaseColumnName = "rowguid"
			});

			schema_array.Add(new VenturaSqlColumn("ModifiedDate", typeof(DateTime), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 23,
				NumericScale = 3,
				ProviderType = 4,
				BaseSchemaName = "Production",
				BaseTableName = "Product",
				BaseColumnName = "ModifiedDate"
			});

			((IResultsetBase)this).Schema = new VenturaSqlSchema(schema_array);
			((IResultsetBase)this).UpdateableTablename = "[Production].[Product]";
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Production].[Product]. PrimaryKey. NotReadonly. NotNull. IsIdentity. AutoIncrement.
		/// </summary>
		public int ProductID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ProductID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ProductID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Product]. NotReadonly. NotNull.
		/// </summary>
		public string Name
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Name; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Name = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Product]. NotReadonly. NotNull.
		/// </summary>
		public string ProductNumber
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ProductNumber; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ProductNumber = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Product]. NotReadonly. NotNull.
		/// </summary>
		public bool MakeFlag
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.MakeFlag; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.MakeFlag = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Product]. NotReadonly. NotNull.
		/// </summary>
		public bool FinishedGoodsFlag
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.FinishedGoodsFlag; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.FinishedGoodsFlag = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Product]. NotReadonly. AllowNull.
		/// </summary>
		public string Color
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Color; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Color = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Product]. NotReadonly. NotNull.
		/// </summary>
		public short SafetyStockLevel
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.SafetyStockLevel; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.SafetyStockLevel = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Product]. NotReadonly. NotNull.
		/// </summary>
		public short ReorderPoint
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ReorderPoint; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ReorderPoint = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Product]. NotReadonly. NotNull.
		/// </summary>
		public decimal StandardCost
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.StandardCost; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.StandardCost = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Product]. NotReadonly. NotNull.
		/// </summary>
		public decimal ListPrice
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ListPrice; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ListPrice = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Product]. NotReadonly. AllowNull.
		/// </summary>
		public string Size
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Size; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Size = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Product]. NotReadonly. AllowNull.
		/// </summary>
		public string SizeUnitMeasureCode
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.SizeUnitMeasureCode; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.SizeUnitMeasureCode = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Product]. NotReadonly. AllowNull.
		/// </summary>
		public string WeightUnitMeasureCode
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.WeightUnitMeasureCode; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.WeightUnitMeasureCode = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Product]. NotReadonly. AllowNull.
		/// </summary>
		public decimal? Weight
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Weight; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Weight = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Product]. NotReadonly. NotNull.
		/// </summary>
		public int DaysToManufacture
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.DaysToManufacture; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.DaysToManufacture = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Product]. NotReadonly. AllowNull.
		/// </summary>
		public string ProductLine
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ProductLine; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ProductLine = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Product]. NotReadonly. AllowNull.
		/// </summary>
		public string Class
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Class; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Class = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Product]. NotReadonly. AllowNull.
		/// </summary>
		public string Style
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Style; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Style = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Product]. NotReadonly. AllowNull.
		/// </summary>
		public int? ProductSubcategoryID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ProductSubcategoryID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ProductSubcategoryID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Product]. NotReadonly. AllowNull.
		/// </summary>
		public int? ProductModelID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ProductModelID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ProductModelID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Product]. NotReadonly. NotNull.
		/// </summary>
		public DateTime SellStartDate
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.SellStartDate; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.SellStartDate = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Product]. NotReadonly. AllowNull.
		/// </summary>
		public DateTime? SellEndDate
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.SellEndDate; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.SellEndDate = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Product]. NotReadonly. AllowNull.
		/// </summary>
		public DateTime? DiscontinuedDate
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.DiscontinuedDate; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.DiscontinuedDate = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Product]. NotReadonly. NotNull.
		/// </summary>
		public Guid rowguid
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.rowguid; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.rowguid = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Product]. NotReadonly. NotNull.
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
			this.InsertItem(index, new PriKey_Production_Product_Record());
			this.CurrentRecordIndex = index;
		}

		public void Append(PriKey_Production_Product_Record record)
		{
			int index = this.RecordCount;
			this.InsertItem(index, record);
			this.CurrentRecordIndex = index;
		}

		public PriKey_Production_Product_Record NewRecord()
		{
			return new PriKey_Production_Product_Record();
		}

		protected override PriKey_Production_Product_Record InternalCreateExistingRecordObject(object[] columnvalues) => new PriKey_Production_Product_Record(columnvalues);

		byte[] IRecordsetBase.Hash
		{
			get { return new byte[] { 244, 10, 218, 150, 222, 18, 203, 18, 188, 129, 186, 70, 57, 76, 125, 58 }; }
		}

		string IRecordsetBase.HashString
		{
			get { return "F40ADA96DE12CB12BC81BA46394C7D3A"; }
		}

		VenturaSqlPlatform IRecordsetBase.GeneratorTarget
		{
			get { return VenturaSqlPlatform.NETStandard; }
		}

		Version IRecordsetBase.GeneratorVersion
		{
			get { return new Version(4,0,126); }
		}

		DateTime IRecordsetBase.GeneratorTimestamp
		{
			get { return new DateTime(2021, 5, 11, 12, 4, 37); } // Tuesday, 11 May 2021 at 12:04:37
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

		public void SetExecSqlParams(int? ProductID)
		{
			_inputparametervalues[0] = ProductID;
		}

		public void ExecSql(int? ProductID)
		{
			_inputparametervalues[0] = ProductID;
			Transactional.ExecSql(VenturaSqlConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public void ExecSql(Connector connector, int? ProductID)
		{
			_inputparametervalues[0] = ProductID;
			Transactional.ExecSql(connector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync(int? ProductID)
		{
			_inputparametervalues[0] = ProductID;
			await Transactional.ExecSqlAsync(VenturaSqlConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync(Connector connector, int? ProductID)
		{
			_inputparametervalues[0] = ProductID;
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

			public int? ProductID
			{
				get { return (int?)_values[0]; }
				set { _values[0] = value; }
			}

		}

	}

	public sealed partial class PriKey_Production_Product_Record : IRecordBase, INotifyPropertyChanged
	{
		private DataRecordStatus _recordstatus;
		private bool _started_with_dbvalues;

		private int _cur__ProductID; private int _ori__ProductID; private bool _mod__ProductID;
		private string _cur__Name; private string _ori__Name; private bool _mod__Name;
		private string _cur__ProductNumber; private string _ori__ProductNumber; private bool _mod__ProductNumber;
		private bool _cur__MakeFlag; private bool _ori__MakeFlag; private bool _mod__MakeFlag;
		private bool _cur__FinishedGoodsFlag; private bool _ori__FinishedGoodsFlag; private bool _mod__FinishedGoodsFlag;
		private string _cur__Color; private string _ori__Color; private bool _mod__Color;
		private short _cur__SafetyStockLevel; private short _ori__SafetyStockLevel; private bool _mod__SafetyStockLevel;
		private short _cur__ReorderPoint; private short _ori__ReorderPoint; private bool _mod__ReorderPoint;
		private decimal _cur__StandardCost; private decimal _ori__StandardCost; private bool _mod__StandardCost;
		private decimal _cur__ListPrice; private decimal _ori__ListPrice; private bool _mod__ListPrice;
		private string _cur__Size; private string _ori__Size; private bool _mod__Size;
		private string _cur__SizeUnitMeasureCode; private string _ori__SizeUnitMeasureCode; private bool _mod__SizeUnitMeasureCode;
		private string _cur__WeightUnitMeasureCode; private string _ori__WeightUnitMeasureCode; private bool _mod__WeightUnitMeasureCode;
		private decimal? _cur__Weight; private decimal? _ori__Weight; private bool _mod__Weight;
		private int _cur__DaysToManufacture; private int _ori__DaysToManufacture; private bool _mod__DaysToManufacture;
		private string _cur__ProductLine; private string _ori__ProductLine; private bool _mod__ProductLine;
		private string _cur__Class; private string _ori__Class; private bool _mod__Class;
		private string _cur__Style; private string _ori__Style; private bool _mod__Style;
		private int? _cur__ProductSubcategoryID; private int? _ori__ProductSubcategoryID; private bool _mod__ProductSubcategoryID;
		private int? _cur__ProductModelID; private int? _ori__ProductModelID; private bool _mod__ProductModelID;
		private DateTime _cur__SellStartDate; private DateTime _ori__SellStartDate; private bool _mod__SellStartDate;
		private DateTime? _cur__SellEndDate; private DateTime? _ori__SellEndDate; private bool _mod__SellEndDate;
		private DateTime? _cur__DiscontinuedDate; private DateTime? _ori__DiscontinuedDate; private bool _mod__DiscontinuedDate;
		private Guid _cur__rowguid; private Guid _ori__rowguid; private bool _mod__rowguid;
		private DateTime _cur__ModifiedDate; private DateTime _ori__ModifiedDate; private bool _mod__ModifiedDate;


		public PriKey_Production_Product_Record()
		{
			_cur__ProductID = 0;
			_cur__Name = "";
			_cur__ProductNumber = "";
			_cur__MakeFlag = false;
			_cur__FinishedGoodsFlag = false;
			_cur__Color = null;
			_cur__SafetyStockLevel = 0;
			_cur__ReorderPoint = 0;
			_cur__StandardCost = 0.0m;
			_cur__ListPrice = 0.0m;
			_cur__Size = null;
			_cur__SizeUnitMeasureCode = null;
			_cur__WeightUnitMeasureCode = null;
			_cur__Weight = null;
			_cur__DaysToManufacture = 0;
			_cur__ProductLine = null;
			_cur__Class = null;
			_cur__Style = null;
			_cur__ProductSubcategoryID = null;
			_cur__ProductModelID = null;
			_cur__SellStartDate = new DateTime(1900, 1, 1);
			_cur__SellEndDate = null;
			_cur__DiscontinuedDate = null;
			_cur__rowguid = Guid.Empty;
			_cur__ModifiedDate = new DateTime(1900, 1, 1);
			_started_with_dbvalues = false;
			_recordstatus = DataRecordStatus.New;
		}

		public PriKey_Production_Product_Record(object[] columnvalues)
		{
			_cur__ProductID = (int)columnvalues[0];
			_cur__Name = (string)columnvalues[1];
			_cur__ProductNumber = (string)columnvalues[2];
			_cur__MakeFlag = (bool)columnvalues[3];
			_cur__FinishedGoodsFlag = (bool)columnvalues[4];
			_cur__Color = (string)columnvalues[5];
			_cur__SafetyStockLevel = (short)columnvalues[6];
			_cur__ReorderPoint = (short)columnvalues[7];
			_cur__StandardCost = (decimal)columnvalues[8];
			_cur__ListPrice = (decimal)columnvalues[9];
			_cur__Size = (string)columnvalues[10];
			_cur__SizeUnitMeasureCode = (string)columnvalues[11];
			_cur__WeightUnitMeasureCode = (string)columnvalues[12];
			_cur__Weight = (decimal?)columnvalues[13];
			_cur__DaysToManufacture = (int)columnvalues[14];
			_cur__ProductLine = (string)columnvalues[15];
			_cur__Class = (string)columnvalues[16];
			_cur__Style = (string)columnvalues[17];
			_cur__ProductSubcategoryID = (int?)columnvalues[18];
			_cur__ProductModelID = (int?)columnvalues[19];
			_cur__SellStartDate = (DateTime)columnvalues[20];
			_cur__SellEndDate = (DateTime?)columnvalues[21];
			_cur__DiscontinuedDate = (DateTime?)columnvalues[22];
			_cur__rowguid = (Guid)columnvalues[23];
			_cur__ModifiedDate = (DateTime)columnvalues[24];
			_started_with_dbvalues = true;
			_recordstatus = DataRecordStatus.Existing;
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Production].[Product]. PrimaryKey. NotReadonly. NotNull. IsIdentity. AutoIncrement.
		/// </summary>
		public int ProductID
		{
			get { return _cur__ProductID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ProductID = true;
				if (_cur__ProductID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ProductID == false) { _ori__ProductID = _cur__ProductID; _mod__ProductID = true; } // existing record and column is not modified
					else { if (value == _ori__ProductID) { _ori__ProductID = default(int); _mod__ProductID = false; } } // existing record and column is modified
				}
				_cur__ProductID = value; OnPropertyChanged("ProductID"); OnAfterPropertyChanged("ProductID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Product]. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [Production].[Product]. NotReadonly. NotNull.
		/// </summary>
		public string ProductNumber
		{
			get { return _cur__ProductNumber; }
			set
			{
				if (value == null) throw new ArgumentNullException("ProductNumber", VenturaSqlStrings.SET_NULL_MSG);
				if (_started_with_dbvalues == false) _mod__ProductNumber = true;
				if (_cur__ProductNumber == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ProductNumber == false) { _ori__ProductNumber = _cur__ProductNumber; _mod__ProductNumber = true; } // existing record and column is not modified
					else { if (value == _ori__ProductNumber) { _ori__ProductNumber = default(string); _mod__ProductNumber = false; } } // existing record and column is modified
				}
				_cur__ProductNumber = value; OnPropertyChanged("ProductNumber"); OnAfterPropertyChanged("ProductNumber");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Product]. NotReadonly. NotNull.
		/// </summary>
		public bool MakeFlag
		{
			get { return _cur__MakeFlag; }
			set
			{
				if (_started_with_dbvalues == false) _mod__MakeFlag = true;
				if (_cur__MakeFlag == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__MakeFlag == false) { _ori__MakeFlag = _cur__MakeFlag; _mod__MakeFlag = true; } // existing record and column is not modified
					else { if (value == _ori__MakeFlag) { _ori__MakeFlag = default(bool); _mod__MakeFlag = false; } } // existing record and column is modified
				}
				_cur__MakeFlag = value; OnPropertyChanged("MakeFlag"); OnAfterPropertyChanged("MakeFlag");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Product]. NotReadonly. NotNull.
		/// </summary>
		public bool FinishedGoodsFlag
		{
			get { return _cur__FinishedGoodsFlag; }
			set
			{
				if (_started_with_dbvalues == false) _mod__FinishedGoodsFlag = true;
				if (_cur__FinishedGoodsFlag == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__FinishedGoodsFlag == false) { _ori__FinishedGoodsFlag = _cur__FinishedGoodsFlag; _mod__FinishedGoodsFlag = true; } // existing record and column is not modified
					else { if (value == _ori__FinishedGoodsFlag) { _ori__FinishedGoodsFlag = default(bool); _mod__FinishedGoodsFlag = false; } } // existing record and column is modified
				}
				_cur__FinishedGoodsFlag = value; OnPropertyChanged("FinishedGoodsFlag"); OnAfterPropertyChanged("FinishedGoodsFlag");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Product]. NotReadonly. AllowNull.
		/// </summary>
		public string Color
		{
			get { return _cur__Color; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Color = true;
				if (_cur__Color == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Color == false) { _ori__Color = _cur__Color; _mod__Color = true; } // existing record and column is not modified
					else { if (value == _ori__Color) { _ori__Color = default(string); _mod__Color = false; } } // existing record and column is modified
				}
				_cur__Color = value; OnPropertyChanged("Color"); OnAfterPropertyChanged("Color");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Product]. NotReadonly. NotNull.
		/// </summary>
		public short SafetyStockLevel
		{
			get { return _cur__SafetyStockLevel; }
			set
			{
				if (_started_with_dbvalues == false) _mod__SafetyStockLevel = true;
				if (_cur__SafetyStockLevel == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__SafetyStockLevel == false) { _ori__SafetyStockLevel = _cur__SafetyStockLevel; _mod__SafetyStockLevel = true; } // existing record and column is not modified
					else { if (value == _ori__SafetyStockLevel) { _ori__SafetyStockLevel = default(short); _mod__SafetyStockLevel = false; } } // existing record and column is modified
				}
				_cur__SafetyStockLevel = value; OnPropertyChanged("SafetyStockLevel"); OnAfterPropertyChanged("SafetyStockLevel");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Product]. NotReadonly. NotNull.
		/// </summary>
		public short ReorderPoint
		{
			get { return _cur__ReorderPoint; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ReorderPoint = true;
				if (_cur__ReorderPoint == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ReorderPoint == false) { _ori__ReorderPoint = _cur__ReorderPoint; _mod__ReorderPoint = true; } // existing record and column is not modified
					else { if (value == _ori__ReorderPoint) { _ori__ReorderPoint = default(short); _mod__ReorderPoint = false; } } // existing record and column is modified
				}
				_cur__ReorderPoint = value; OnPropertyChanged("ReorderPoint"); OnAfterPropertyChanged("ReorderPoint");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Product]. NotReadonly. NotNull.
		/// </summary>
		public decimal StandardCost
		{
			get { return _cur__StandardCost; }
			set
			{
				if (_started_with_dbvalues == false) _mod__StandardCost = true;
				if (_cur__StandardCost == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__StandardCost == false) { _ori__StandardCost = _cur__StandardCost; _mod__StandardCost = true; } // existing record and column is not modified
					else { if (value == _ori__StandardCost) { _ori__StandardCost = default(decimal); _mod__StandardCost = false; } } // existing record and column is modified
				}
				_cur__StandardCost = value; OnPropertyChanged("StandardCost"); OnAfterPropertyChanged("StandardCost");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Product]. NotReadonly. NotNull.
		/// </summary>
		public decimal ListPrice
		{
			get { return _cur__ListPrice; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ListPrice = true;
				if (_cur__ListPrice == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ListPrice == false) { _ori__ListPrice = _cur__ListPrice; _mod__ListPrice = true; } // existing record and column is not modified
					else { if (value == _ori__ListPrice) { _ori__ListPrice = default(decimal); _mod__ListPrice = false; } } // existing record and column is modified
				}
				_cur__ListPrice = value; OnPropertyChanged("ListPrice"); OnAfterPropertyChanged("ListPrice");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Product]. NotReadonly. AllowNull.
		/// </summary>
		public string Size
		{
			get { return _cur__Size; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Size = true;
				if (_cur__Size == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Size == false) { _ori__Size = _cur__Size; _mod__Size = true; } // existing record and column is not modified
					else { if (value == _ori__Size) { _ori__Size = default(string); _mod__Size = false; } } // existing record and column is modified
				}
				_cur__Size = value; OnPropertyChanged("Size"); OnAfterPropertyChanged("Size");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Product]. NotReadonly. AllowNull.
		/// </summary>
		public string SizeUnitMeasureCode
		{
			get { return _cur__SizeUnitMeasureCode; }
			set
			{
				if (_started_with_dbvalues == false) _mod__SizeUnitMeasureCode = true;
				if (_cur__SizeUnitMeasureCode == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__SizeUnitMeasureCode == false) { _ori__SizeUnitMeasureCode = _cur__SizeUnitMeasureCode; _mod__SizeUnitMeasureCode = true; } // existing record and column is not modified
					else { if (value == _ori__SizeUnitMeasureCode) { _ori__SizeUnitMeasureCode = default(string); _mod__SizeUnitMeasureCode = false; } } // existing record and column is modified
				}
				_cur__SizeUnitMeasureCode = value; OnPropertyChanged("SizeUnitMeasureCode"); OnAfterPropertyChanged("SizeUnitMeasureCode");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Product]. NotReadonly. AllowNull.
		/// </summary>
		public string WeightUnitMeasureCode
		{
			get { return _cur__WeightUnitMeasureCode; }
			set
			{
				if (_started_with_dbvalues == false) _mod__WeightUnitMeasureCode = true;
				if (_cur__WeightUnitMeasureCode == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__WeightUnitMeasureCode == false) { _ori__WeightUnitMeasureCode = _cur__WeightUnitMeasureCode; _mod__WeightUnitMeasureCode = true; } // existing record and column is not modified
					else { if (value == _ori__WeightUnitMeasureCode) { _ori__WeightUnitMeasureCode = default(string); _mod__WeightUnitMeasureCode = false; } } // existing record and column is modified
				}
				_cur__WeightUnitMeasureCode = value; OnPropertyChanged("WeightUnitMeasureCode"); OnAfterPropertyChanged("WeightUnitMeasureCode");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Product]. NotReadonly. AllowNull.
		/// </summary>
		public decimal? Weight
		{
			get { return _cur__Weight; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Weight = true;
				if (_cur__Weight == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Weight == false) { _ori__Weight = _cur__Weight; _mod__Weight = true; } // existing record and column is not modified
					else { if (value == _ori__Weight) { _ori__Weight = default(decimal?); _mod__Weight = false; } } // existing record and column is modified
				}
				_cur__Weight = value; OnPropertyChanged("Weight"); OnAfterPropertyChanged("Weight");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Product]. NotReadonly. NotNull.
		/// </summary>
		public int DaysToManufacture
		{
			get { return _cur__DaysToManufacture; }
			set
			{
				if (_started_with_dbvalues == false) _mod__DaysToManufacture = true;
				if (_cur__DaysToManufacture == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__DaysToManufacture == false) { _ori__DaysToManufacture = _cur__DaysToManufacture; _mod__DaysToManufacture = true; } // existing record and column is not modified
					else { if (value == _ori__DaysToManufacture) { _ori__DaysToManufacture = default(int); _mod__DaysToManufacture = false; } } // existing record and column is modified
				}
				_cur__DaysToManufacture = value; OnPropertyChanged("DaysToManufacture"); OnAfterPropertyChanged("DaysToManufacture");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Product]. NotReadonly. AllowNull.
		/// </summary>
		public string ProductLine
		{
			get { return _cur__ProductLine; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ProductLine = true;
				if (_cur__ProductLine == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ProductLine == false) { _ori__ProductLine = _cur__ProductLine; _mod__ProductLine = true; } // existing record and column is not modified
					else { if (value == _ori__ProductLine) { _ori__ProductLine = default(string); _mod__ProductLine = false; } } // existing record and column is modified
				}
				_cur__ProductLine = value; OnPropertyChanged("ProductLine"); OnAfterPropertyChanged("ProductLine");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Product]. NotReadonly. AllowNull.
		/// </summary>
		public string Class
		{
			get { return _cur__Class; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Class = true;
				if (_cur__Class == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Class == false) { _ori__Class = _cur__Class; _mod__Class = true; } // existing record and column is not modified
					else { if (value == _ori__Class) { _ori__Class = default(string); _mod__Class = false; } } // existing record and column is modified
				}
				_cur__Class = value; OnPropertyChanged("Class"); OnAfterPropertyChanged("Class");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Product]. NotReadonly. AllowNull.
		/// </summary>
		public string Style
		{
			get { return _cur__Style; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Style = true;
				if (_cur__Style == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Style == false) { _ori__Style = _cur__Style; _mod__Style = true; } // existing record and column is not modified
					else { if (value == _ori__Style) { _ori__Style = default(string); _mod__Style = false; } } // existing record and column is modified
				}
				_cur__Style = value; OnPropertyChanged("Style"); OnAfterPropertyChanged("Style");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Product]. NotReadonly. AllowNull.
		/// </summary>
		public int? ProductSubcategoryID
		{
			get { return _cur__ProductSubcategoryID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ProductSubcategoryID = true;
				if (_cur__ProductSubcategoryID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ProductSubcategoryID == false) { _ori__ProductSubcategoryID = _cur__ProductSubcategoryID; _mod__ProductSubcategoryID = true; } // existing record and column is not modified
					else { if (value == _ori__ProductSubcategoryID) { _ori__ProductSubcategoryID = default(int?); _mod__ProductSubcategoryID = false; } } // existing record and column is modified
				}
				_cur__ProductSubcategoryID = value; OnPropertyChanged("ProductSubcategoryID"); OnAfterPropertyChanged("ProductSubcategoryID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Product]. NotReadonly. AllowNull.
		/// </summary>
		public int? ProductModelID
		{
			get { return _cur__ProductModelID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ProductModelID = true;
				if (_cur__ProductModelID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ProductModelID == false) { _ori__ProductModelID = _cur__ProductModelID; _mod__ProductModelID = true; } // existing record and column is not modified
					else { if (value == _ori__ProductModelID) { _ori__ProductModelID = default(int?); _mod__ProductModelID = false; } } // existing record and column is modified
				}
				_cur__ProductModelID = value; OnPropertyChanged("ProductModelID"); OnAfterPropertyChanged("ProductModelID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Product]. NotReadonly. NotNull.
		/// </summary>
		public DateTime SellStartDate
		{
			get { return _cur__SellStartDate; }
			set
			{
				if (_started_with_dbvalues == false) _mod__SellStartDate = true;
				if (_cur__SellStartDate == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__SellStartDate == false) { _ori__SellStartDate = _cur__SellStartDate; _mod__SellStartDate = true; } // existing record and column is not modified
					else { if (value == _ori__SellStartDate) { _ori__SellStartDate = default(DateTime); _mod__SellStartDate = false; } } // existing record and column is modified
				}
				_cur__SellStartDate = value; OnPropertyChanged("SellStartDate"); OnAfterPropertyChanged("SellStartDate");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Product]. NotReadonly. AllowNull.
		/// </summary>
		public DateTime? SellEndDate
		{
			get { return _cur__SellEndDate; }
			set
			{
				if (_started_with_dbvalues == false) _mod__SellEndDate = true;
				if (_cur__SellEndDate == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__SellEndDate == false) { _ori__SellEndDate = _cur__SellEndDate; _mod__SellEndDate = true; } // existing record and column is not modified
					else { if (value == _ori__SellEndDate) { _ori__SellEndDate = default(DateTime?); _mod__SellEndDate = false; } } // existing record and column is modified
				}
				_cur__SellEndDate = value; OnPropertyChanged("SellEndDate"); OnAfterPropertyChanged("SellEndDate");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Product]. NotReadonly. AllowNull.
		/// </summary>
		public DateTime? DiscontinuedDate
		{
			get { return _cur__DiscontinuedDate; }
			set
			{
				if (_started_with_dbvalues == false) _mod__DiscontinuedDate = true;
				if (_cur__DiscontinuedDate == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__DiscontinuedDate == false) { _ori__DiscontinuedDate = _cur__DiscontinuedDate; _mod__DiscontinuedDate = true; } // existing record and column is not modified
					else { if (value == _ori__DiscontinuedDate) { _ori__DiscontinuedDate = default(DateTime?); _mod__DiscontinuedDate = false; } } // existing record and column is modified
				}
				_cur__DiscontinuedDate = value; OnPropertyChanged("DiscontinuedDate"); OnAfterPropertyChanged("DiscontinuedDate");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Product]. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [Production].[Product]. NotReadonly. NotNull.
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
			if (column_name == "ProductID") return _mod__ProductID;
			if (column_name == "Name") return _mod__Name;
			if (column_name == "ProductNumber") return _mod__ProductNumber;
			if (column_name == "MakeFlag") return _mod__MakeFlag;
			if (column_name == "FinishedGoodsFlag") return _mod__FinishedGoodsFlag;
			if (column_name == "Color") return _mod__Color;
			if (column_name == "SafetyStockLevel") return _mod__SafetyStockLevel;
			if (column_name == "ReorderPoint") return _mod__ReorderPoint;
			if (column_name == "StandardCost") return _mod__StandardCost;
			if (column_name == "ListPrice") return _mod__ListPrice;
			if (column_name == "Size") return _mod__Size;
			if (column_name == "SizeUnitMeasureCode") return _mod__SizeUnitMeasureCode;
			if (column_name == "WeightUnitMeasureCode") return _mod__WeightUnitMeasureCode;
			if (column_name == "Weight") return _mod__Weight;
			if (column_name == "DaysToManufacture") return _mod__DaysToManufacture;
			if (column_name == "ProductLine") return _mod__ProductLine;
			if (column_name == "Class") return _mod__Class;
			if (column_name == "Style") return _mod__Style;
			if (column_name == "ProductSubcategoryID") return _mod__ProductSubcategoryID;
			if (column_name == "ProductModelID") return _mod__ProductModelID;
			if (column_name == "SellStartDate") return _mod__SellStartDate;
			if (column_name == "SellEndDate") return _mod__SellEndDate;
			if (column_name == "DiscontinuedDate") return _mod__DiscontinuedDate;
			if (column_name == "rowguid") return _mod__rowguid;
			if (column_name == "ModifiedDate") return _mod__ModifiedDate;
			throw new ArgumentOutOfRangeException(String.Format(VenturaSqlStrings.UNKNOWN_COLUMN_NAME, column_name));
		}

		public int ModifiedColumnCount()
		{
			int count = 0;
			if (_mod__ProductID == true) count++;
			if (_mod__Name == true) count++;
			if (_mod__ProductNumber == true) count++;
			if (_mod__MakeFlag == true) count++;
			if (_mod__FinishedGoodsFlag == true) count++;
			if (_mod__Color == true) count++;
			if (_mod__SafetyStockLevel == true) count++;
			if (_mod__ReorderPoint == true) count++;
			if (_mod__StandardCost == true) count++;
			if (_mod__ListPrice == true) count++;
			if (_mod__Size == true) count++;
			if (_mod__SizeUnitMeasureCode == true) count++;
			if (_mod__WeightUnitMeasureCode == true) count++;
			if (_mod__Weight == true) count++;
			if (_mod__DaysToManufacture == true) count++;
			if (_mod__ProductLine == true) count++;
			if (_mod__Class == true) count++;
			if (_mod__Style == true) count++;
			if (_mod__ProductSubcategoryID == true) count++;
			if (_mod__ProductModelID == true) count++;
			if (_mod__SellStartDate == true) count++;
			if (_mod__SellEndDate == true) count++;
			if (_mod__DiscontinuedDate == true) count++;
			if (_mod__rowguid == true) count++;
			if (_mod__ModifiedDate == true) count++;
			return count;
		}

		public bool PendingChanges()
		{
			if (_recordstatus == DataRecordStatus.New || _recordstatus == DataRecordStatus.ExistingDelete) return true;
			int count = 0;
			if (_mod__Name == true) count++;
			if (_mod__ProductNumber == true) count++;
			if (_mod__MakeFlag == true) count++;
			if (_mod__FinishedGoodsFlag == true) count++;
			if (_mod__Color == true) count++;
			if (_mod__SafetyStockLevel == true) count++;
			if (_mod__ReorderPoint == true) count++;
			if (_mod__StandardCost == true) count++;
			if (_mod__ListPrice == true) count++;
			if (_mod__Size == true) count++;
			if (_mod__SizeUnitMeasureCode == true) count++;
			if (_mod__WeightUnitMeasureCode == true) count++;
			if (_mod__Weight == true) count++;
			if (_mod__DaysToManufacture == true) count++;
			if (_mod__ProductLine == true) count++;
			if (_mod__Class == true) count++;
			if (_mod__Style == true) count++;
			if (_mod__ProductSubcategoryID == true) count++;
			if (_mod__ProductModelID == true) count++;
			if (_mod__SellStartDate == true) count++;
			if (_mod__SellEndDate == true) count++;
			if (_mod__DiscontinuedDate == true) count++;
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
				track_array.AppendDataValue(1, _cur__Name);
				track_array.AppendDataValue(2, _cur__ProductNumber);
				track_array.AppendDataValue(3, _cur__MakeFlag);
				track_array.AppendDataValue(4, _cur__FinishedGoodsFlag);
				if (_cur__Color != null) track_array.AppendDataValue(5, _cur__Color);
				track_array.AppendDataValue(6, _cur__SafetyStockLevel);
				track_array.AppendDataValue(7, _cur__ReorderPoint);
				track_array.AppendDataValue(8, _cur__StandardCost);
				track_array.AppendDataValue(9, _cur__ListPrice);
				if (_cur__Size != null) track_array.AppendDataValue(10, _cur__Size);
				if (_cur__SizeUnitMeasureCode != null) track_array.AppendDataValue(11, _cur__SizeUnitMeasureCode);
				if (_cur__WeightUnitMeasureCode != null) track_array.AppendDataValue(12, _cur__WeightUnitMeasureCode);
				if (_cur__Weight != null) track_array.AppendDataValue(13, _cur__Weight);
				track_array.AppendDataValue(14, _cur__DaysToManufacture);
				if (_cur__ProductLine != null) track_array.AppendDataValue(15, _cur__ProductLine);
				if (_cur__Class != null) track_array.AppendDataValue(16, _cur__Class);
				if (_cur__Style != null) track_array.AppendDataValue(17, _cur__Style);
				if (_cur__ProductSubcategoryID != null) track_array.AppendDataValue(18, _cur__ProductSubcategoryID);
				if (_cur__ProductModelID != null) track_array.AppendDataValue(19, _cur__ProductModelID);
				track_array.AppendDataValue(20, _cur__SellStartDate);
				if (_cur__SellEndDate != null) track_array.AppendDataValue(21, _cur__SellEndDate);
				if (_cur__DiscontinuedDate != null) track_array.AppendDataValue(22, _cur__DiscontinuedDate);
				track_array.AppendDataValue(23, _cur__rowguid);
				track_array.AppendDataValue(24, _cur__ModifiedDate);
			}
			else if (_recordstatus == DataRecordStatus.Existing)
			{
				if (_mod__Name) track_array.AppendDataValue(1, _cur__Name);
				if (_mod__ProductNumber) track_array.AppendDataValue(2, _cur__ProductNumber);
				if (_mod__MakeFlag) track_array.AppendDataValue(3, _cur__MakeFlag);
				if (_mod__FinishedGoodsFlag) track_array.AppendDataValue(4, _cur__FinishedGoodsFlag);
				if (_mod__Color) track_array.AppendDataValue(5, _cur__Color);
				if (_mod__SafetyStockLevel) track_array.AppendDataValue(6, _cur__SafetyStockLevel);
				if (_mod__ReorderPoint) track_array.AppendDataValue(7, _cur__ReorderPoint);
				if (_mod__StandardCost) track_array.AppendDataValue(8, _cur__StandardCost);
				if (_mod__ListPrice) track_array.AppendDataValue(9, _cur__ListPrice);
				if (_mod__Size) track_array.AppendDataValue(10, _cur__Size);
				if (_mod__SizeUnitMeasureCode) track_array.AppendDataValue(11, _cur__SizeUnitMeasureCode);
				if (_mod__WeightUnitMeasureCode) track_array.AppendDataValue(12, _cur__WeightUnitMeasureCode);
				if (_mod__Weight) track_array.AppendDataValue(13, _cur__Weight);
				if (_mod__DaysToManufacture) track_array.AppendDataValue(14, _cur__DaysToManufacture);
				if (_mod__ProductLine) track_array.AppendDataValue(15, _cur__ProductLine);
				if (_mod__Class) track_array.AppendDataValue(16, _cur__Class);
				if (_mod__Style) track_array.AppendDataValue(17, _cur__Style);
				if (_mod__ProductSubcategoryID) track_array.AppendDataValue(18, _cur__ProductSubcategoryID);
				if (_mod__ProductModelID) track_array.AppendDataValue(19, _cur__ProductModelID);
				if (_mod__SellStartDate) track_array.AppendDataValue(20, _cur__SellStartDate);
				if (_mod__SellEndDate) track_array.AppendDataValue(21, _cur__SellEndDate);
				if (_mod__DiscontinuedDate) track_array.AppendDataValue(22, _cur__DiscontinuedDate);
				if (_mod__rowguid) track_array.AppendDataValue(23, _cur__rowguid);
				if (_mod__ModifiedDate) track_array.AppendDataValue(24, _cur__ModifiedDate);
				if (track_array.HasData == false) return;
			}

			if (_recordstatus == DataRecordStatus.Existing || _recordstatus == DataRecordStatus.ExistingDelete)
			{
				track_array.AppendPrikeyValue(0, (_mod__ProductID && _started_with_dbvalues) ? _ori__ProductID : _cur__ProductID);
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
				if (_mod__ProductID) _ori__ProductID = default(int);
				if (_mod__Name) _ori__Name = default(string);
				if (_mod__ProductNumber) _ori__ProductNumber = default(string);
				if (_mod__MakeFlag) _ori__MakeFlag = default(bool);
				if (_mod__FinishedGoodsFlag) _ori__FinishedGoodsFlag = default(bool);
				if (_mod__Color) _ori__Color = default(string);
				if (_mod__SafetyStockLevel) _ori__SafetyStockLevel = default(short);
				if (_mod__ReorderPoint) _ori__ReorderPoint = default(short);
				if (_mod__StandardCost) _ori__StandardCost = default(decimal);
				if (_mod__ListPrice) _ori__ListPrice = default(decimal);
				if (_mod__Size) _ori__Size = default(string);
				if (_mod__SizeUnitMeasureCode) _ori__SizeUnitMeasureCode = default(string);
				if (_mod__WeightUnitMeasureCode) _ori__WeightUnitMeasureCode = default(string);
				if (_mod__Weight) _ori__Weight = default(decimal?);
				if (_mod__DaysToManufacture) _ori__DaysToManufacture = default(int);
				if (_mod__ProductLine) _ori__ProductLine = default(string);
				if (_mod__Class) _ori__Class = default(string);
				if (_mod__Style) _ori__Style = default(string);
				if (_mod__ProductSubcategoryID) _ori__ProductSubcategoryID = default(int?);
				if (_mod__ProductModelID) _ori__ProductModelID = default(int?);
				if (_mod__SellStartDate) _ori__SellStartDate = default(DateTime);
				if (_mod__SellEndDate) _ori__SellEndDate = default(DateTime?);
				if (_mod__DiscontinuedDate) _ori__DiscontinuedDate = default(DateTime?);
				if (_mod__rowguid) _ori__rowguid = default(Guid);
				if (_mod__ModifiedDate) _ori__ModifiedDate = default(DateTime);
			}
			_mod__ProductID = false;
			_mod__Name = false;
			_mod__ProductNumber = false;
			_mod__MakeFlag = false;
			_mod__FinishedGoodsFlag = false;
			_mod__Color = false;
			_mod__SafetyStockLevel = false;
			_mod__ReorderPoint = false;
			_mod__StandardCost = false;
			_mod__ListPrice = false;
			_mod__Size = false;
			_mod__SizeUnitMeasureCode = false;
			_mod__WeightUnitMeasureCode = false;
			_mod__Weight = false;
			_mod__DaysToManufacture = false;
			_mod__ProductLine = false;
			_mod__Class = false;
			_mod__Style = false;
			_mod__ProductSubcategoryID = false;
			_mod__ProductModelID = false;
			_mod__SellStartDate = false;
			_mod__SellEndDate = false;
			_mod__DiscontinuedDate = false;
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
			_cur__ProductID = (int)value;
			OnPropertyChanged("ProductID");
			OnAfterPropertyChanged("ProductID");
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
	public partial class PriKey_Production_Product_Record
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
