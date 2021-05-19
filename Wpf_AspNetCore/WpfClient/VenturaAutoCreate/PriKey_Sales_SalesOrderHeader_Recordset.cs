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
	/// The updateable table is [Sales].[SalesOrderHeader]. Updateable table column information:
	/// • 26 out of 26 table columns are present in the resultset.
	/// • All primary key columns are present in the resultset: SalesOrderID.
	/// • Non-primary key columns present in the resultset: RevisionNumber, OrderDate, DueDate, ShipDate, Status, OnlineOrderFlag,
	///   SalesOrderNumber, PurchaseOrderNumber, AccountNumber, CustomerID, SalesPersonID, TerritoryID, BillToAddressID,
	///   ShipToAddressID, ShipMethodID, CreditCardID, CreditCardApprovalCode, CurrencyRateID, SubTotal, TaxAmt, Freight, TotalDue,
	///   Comment, rowguid and ModifiedDate.
	/// Recordset item automatically created by VenturaSQL Studio.
	/// </summary>
	public partial class PriKey_Sales_SalesOrderHeader_Recordset : ResultsetObservable<PriKey_Sales_SalesOrderHeader_Recordset, PriKey_Sales_SalesOrderHeader_Record>, IRecordsetBase
	{
		private IResultsetBase[] _resultsets;
		private string _sqlscript;
		private object[] _inputparametervalues;
		private InputParamHolder _inputparamholder;
		private VenturaSqlSchema _parameterschema;
		private int _rowlimit = 500;
		private const string CRLF = "\r\n";

		public PriKey_Sales_SalesOrderHeader_Recordset()
		{
			_resultsets = new IResultsetBase[] { this };

			_sqlscript = @"SELECT [SalesOrderID],[RevisionNumber],[OrderDate],[DueDate],[ShipDate],[Status],[OnlineOrderFlag],[SalesOrderNumber],[PurchaseOrderNumber],[AccountNumber]," + CRLF +
			             @"[CustomerID],[SalesPersonID],[TerritoryID],[BillToAddressID],[ShipToAddressID],[ShipMethodID],[CreditCardID],[CreditCardApprovalCode],[CurrencyRateID]," + CRLF +
			             @"[SubTotal],[TaxAmt],[Freight],[TotalDue],[Comment],[rowguid],[ModifiedDate]" + CRLF +
			             @"FROM [Sales].[SalesOrderHeader]" + CRLF +
			             @"WHERE [SalesOrderID] = @SalesOrderID";

			_inputparametervalues = new object[1];
			_inputparamholder = new InputParamHolder(_inputparametervalues);

			ColumnArrayBuilder param_array = new ColumnArrayBuilder();

			param_array.AddParameterColumn("@SalesOrderID", typeof(int), true, false, DbType.Int32, null, null, null);

			_parameterschema = new VenturaSqlSchema(param_array);

			ColumnArrayBuilder schema_array = new ColumnArrayBuilder();

			schema_array.Add(new VenturaSqlColumn("SalesOrderID", typeof(int), false)
			{
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				IsKey = true,
				IsIdentity = true,
				IsAutoIncrement = true,
				BaseSchemaName = "Sales",
				BaseTableName = "SalesOrderHeader",
				BaseColumnName = "SalesOrderID"
			});

			schema_array.Add(new VenturaSqlColumn("RevisionNumber", typeof(byte), false)
			{
				Updateable = true,
				ColumnSize = 1,
				NumericPrecision = 3,
				ProviderType = 20,
				BaseSchemaName = "Sales",
				BaseTableName = "SalesOrderHeader",
				BaseColumnName = "RevisionNumber"
			});

			schema_array.Add(new VenturaSqlColumn("OrderDate", typeof(DateTime), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 23,
				NumericScale = 3,
				ProviderType = 4,
				BaseSchemaName = "Sales",
				BaseTableName = "SalesOrderHeader",
				BaseColumnName = "OrderDate"
			});

			schema_array.Add(new VenturaSqlColumn("DueDate", typeof(DateTime), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 23,
				NumericScale = 3,
				ProviderType = 4,
				BaseSchemaName = "Sales",
				BaseTableName = "SalesOrderHeader",
				BaseColumnName = "DueDate"
			});

			schema_array.Add(new VenturaSqlColumn("ShipDate", typeof(DateTime), true)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 23,
				NumericScale = 3,
				ProviderType = 4,
				BaseSchemaName = "Sales",
				BaseTableName = "SalesOrderHeader",
				BaseColumnName = "ShipDate"
			});

			schema_array.Add(new VenturaSqlColumn("Status", typeof(byte), false)
			{
				Updateable = true,
				ColumnSize = 1,
				NumericPrecision = 3,
				ProviderType = 20,
				BaseSchemaName = "Sales",
				BaseTableName = "SalesOrderHeader",
				BaseColumnName = "Status"
			});

			schema_array.Add(new VenturaSqlColumn("OnlineOrderFlag", typeof(bool), false)
			{
				Updateable = true,
				ColumnSize = 1,
				ProviderType = 2,
				BaseSchemaName = "Sales",
				BaseTableName = "SalesOrderHeader",
				BaseColumnName = "OnlineOrderFlag"
			});

			schema_array.Add(new VenturaSqlColumn("SalesOrderNumber", typeof(string), false)
			{
				Updateable = true,
				ColumnSize = 25,
				ProviderType = 12,
				BaseSchemaName = "Sales",
				BaseTableName = "SalesOrderHeader",
				BaseColumnName = "SalesOrderNumber"
			});

			schema_array.Add(new VenturaSqlColumn("PurchaseOrderNumber", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 25,
				ProviderType = 12,
				BaseSchemaName = "Sales",
				BaseTableName = "SalesOrderHeader",
				BaseColumnName = "PurchaseOrderNumber"
			});

			schema_array.Add(new VenturaSqlColumn("AccountNumber", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 15,
				ProviderType = 12,
				BaseSchemaName = "Sales",
				BaseTableName = "SalesOrderHeader",
				BaseColumnName = "AccountNumber"
			});

			schema_array.Add(new VenturaSqlColumn("CustomerID", typeof(int), false)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				BaseSchemaName = "Sales",
				BaseTableName = "SalesOrderHeader",
				BaseColumnName = "CustomerID"
			});

			schema_array.Add(new VenturaSqlColumn("SalesPersonID", typeof(int), true)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				BaseSchemaName = "Sales",
				BaseTableName = "SalesOrderHeader",
				BaseColumnName = "SalesPersonID"
			});

			schema_array.Add(new VenturaSqlColumn("TerritoryID", typeof(int), true)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				BaseSchemaName = "Sales",
				BaseTableName = "SalesOrderHeader",
				BaseColumnName = "TerritoryID"
			});

			schema_array.Add(new VenturaSqlColumn("BillToAddressID", typeof(int), false)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				BaseSchemaName = "Sales",
				BaseTableName = "SalesOrderHeader",
				BaseColumnName = "BillToAddressID"
			});

			schema_array.Add(new VenturaSqlColumn("ShipToAddressID", typeof(int), false)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				BaseSchemaName = "Sales",
				BaseTableName = "SalesOrderHeader",
				BaseColumnName = "ShipToAddressID"
			});

			schema_array.Add(new VenturaSqlColumn("ShipMethodID", typeof(int), false)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				BaseSchemaName = "Sales",
				BaseTableName = "SalesOrderHeader",
				BaseColumnName = "ShipMethodID"
			});

			schema_array.Add(new VenturaSqlColumn("CreditCardID", typeof(int), true)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				BaseSchemaName = "Sales",
				BaseTableName = "SalesOrderHeader",
				BaseColumnName = "CreditCardID"
			});

			schema_array.Add(new VenturaSqlColumn("CreditCardApprovalCode", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 15,
				ProviderType = 22,
				BaseSchemaName = "Sales",
				BaseTableName = "SalesOrderHeader",
				BaseColumnName = "CreditCardApprovalCode"
			});

			schema_array.Add(new VenturaSqlColumn("CurrencyRateID", typeof(int), true)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				BaseSchemaName = "Sales",
				BaseTableName = "SalesOrderHeader",
				BaseColumnName = "CurrencyRateID"
			});

			schema_array.Add(new VenturaSqlColumn("SubTotal", typeof(decimal), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 19,
				ProviderType = 9,
				BaseSchemaName = "Sales",
				BaseTableName = "SalesOrderHeader",
				BaseColumnName = "SubTotal"
			});

			schema_array.Add(new VenturaSqlColumn("TaxAmt", typeof(decimal), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 19,
				ProviderType = 9,
				BaseSchemaName = "Sales",
				BaseTableName = "SalesOrderHeader",
				BaseColumnName = "TaxAmt"
			});

			schema_array.Add(new VenturaSqlColumn("Freight", typeof(decimal), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 19,
				ProviderType = 9,
				BaseSchemaName = "Sales",
				BaseTableName = "SalesOrderHeader",
				BaseColumnName = "Freight"
			});

			schema_array.Add(new VenturaSqlColumn("TotalDue", typeof(decimal), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 19,
				ProviderType = 9,
				BaseSchemaName = "Sales",
				BaseTableName = "SalesOrderHeader",
				BaseColumnName = "TotalDue"
			});

			schema_array.Add(new VenturaSqlColumn("Comment", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 128,
				ProviderType = 12,
				BaseSchemaName = "Sales",
				BaseTableName = "SalesOrderHeader",
				BaseColumnName = "Comment"
			});

			schema_array.Add(new VenturaSqlColumn("rowguid", typeof(Guid), false)
			{
				Updateable = true,
				ColumnSize = 16,
				ProviderType = 14,
				BaseSchemaName = "Sales",
				BaseTableName = "SalesOrderHeader",
				BaseColumnName = "rowguid"
			});

			schema_array.Add(new VenturaSqlColumn("ModifiedDate", typeof(DateTime), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 23,
				NumericScale = 3,
				ProviderType = 4,
				BaseSchemaName = "Sales",
				BaseTableName = "SalesOrderHeader",
				BaseColumnName = "ModifiedDate"
			});

			((IResultsetBase)this).Schema = new VenturaSqlSchema(schema_array);
			((IResultsetBase)this).UpdateableTablename = "[Sales].[SalesOrderHeader]";
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Sales].[SalesOrderHeader]. PrimaryKey. NotReadonly. NotNull. IsIdentity. AutoIncrement.
		/// </summary>
		public int SalesOrderID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.SalesOrderID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.SalesOrderID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderHeader]. NotReadonly. NotNull.
		/// </summary>
		public byte RevisionNumber
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.RevisionNumber; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.RevisionNumber = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderHeader]. NotReadonly. NotNull.
		/// </summary>
		public DateTime OrderDate
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.OrderDate; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.OrderDate = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderHeader]. NotReadonly. NotNull.
		/// </summary>
		public DateTime DueDate
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.DueDate; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.DueDate = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderHeader]. NotReadonly. AllowNull.
		/// </summary>
		public DateTime? ShipDate
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ShipDate; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ShipDate = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderHeader]. NotReadonly. NotNull.
		/// </summary>
		public byte Status
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Status; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Status = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderHeader]. NotReadonly. NotNull.
		/// </summary>
		public bool OnlineOrderFlag
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.OnlineOrderFlag; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.OnlineOrderFlag = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderHeader]. NotReadonly. NotNull.
		/// </summary>
		public string SalesOrderNumber
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.SalesOrderNumber; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.SalesOrderNumber = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderHeader]. NotReadonly. AllowNull.
		/// </summary>
		public string PurchaseOrderNumber
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.PurchaseOrderNumber; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.PurchaseOrderNumber = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderHeader]. NotReadonly. AllowNull.
		/// </summary>
		public string AccountNumber
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.AccountNumber; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.AccountNumber = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderHeader]. NotReadonly. NotNull.
		/// </summary>
		public int CustomerID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.CustomerID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.CustomerID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderHeader]. NotReadonly. AllowNull.
		/// </summary>
		public int? SalesPersonID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.SalesPersonID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.SalesPersonID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderHeader]. NotReadonly. AllowNull.
		/// </summary>
		public int? TerritoryID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.TerritoryID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.TerritoryID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderHeader]. NotReadonly. NotNull.
		/// </summary>
		public int BillToAddressID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.BillToAddressID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.BillToAddressID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderHeader]. NotReadonly. NotNull.
		/// </summary>
		public int ShipToAddressID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ShipToAddressID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ShipToAddressID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderHeader]. NotReadonly. NotNull.
		/// </summary>
		public int ShipMethodID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ShipMethodID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ShipMethodID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderHeader]. NotReadonly. AllowNull.
		/// </summary>
		public int? CreditCardID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.CreditCardID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.CreditCardID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderHeader]. NotReadonly. AllowNull.
		/// </summary>
		public string CreditCardApprovalCode
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.CreditCardApprovalCode; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.CreditCardApprovalCode = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderHeader]. NotReadonly. AllowNull.
		/// </summary>
		public int? CurrencyRateID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.CurrencyRateID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.CurrencyRateID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderHeader]. NotReadonly. NotNull.
		/// </summary>
		public decimal SubTotal
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.SubTotal; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.SubTotal = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderHeader]. NotReadonly. NotNull.
		/// </summary>
		public decimal TaxAmt
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.TaxAmt; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.TaxAmt = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderHeader]. NotReadonly. NotNull.
		/// </summary>
		public decimal Freight
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Freight; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Freight = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderHeader]. NotReadonly. NotNull.
		/// </summary>
		public decimal TotalDue
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.TotalDue; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.TotalDue = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderHeader]. NotReadonly. AllowNull.
		/// </summary>
		public string Comment
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Comment; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Comment = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderHeader]. NotReadonly. NotNull.
		/// </summary>
		public Guid rowguid
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.rowguid; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.rowguid = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderHeader]. NotReadonly. NotNull.
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
			this.InsertItem(index, new PriKey_Sales_SalesOrderHeader_Record());
			this.CurrentRecordIndex = index;
		}

		public void Append(PriKey_Sales_SalesOrderHeader_Record record)
		{
			int index = this.RecordCount;
			this.InsertItem(index, record);
			this.CurrentRecordIndex = index;
		}

		public PriKey_Sales_SalesOrderHeader_Record NewRecord()
		{
			return new PriKey_Sales_SalesOrderHeader_Record();
		}

		protected override PriKey_Sales_SalesOrderHeader_Record InternalCreateExistingRecordObject(object[] columnvalues) => new PriKey_Sales_SalesOrderHeader_Record(columnvalues);

		byte[] IRecordsetBase.Hash
		{
			get { return new byte[] { 17, 112, 37, 183, 32, 199, 226, 189, 192, 124, 115, 44, 17, 25, 54, 230 }; }
		}

		string IRecordsetBase.HashString
		{
			get { return "117025B720C7E2BDC07C732C111936E6"; }
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

		public void SetExecSqlParams(int? SalesOrderID)
		{
			_inputparametervalues[0] = SalesOrderID;
		}

		public void ExecSql(int? SalesOrderID)
		{
			_inputparametervalues[0] = SalesOrderID;
			Transactional.ExecSql(VenturaSqlConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public void ExecSql(Connector connector, int? SalesOrderID)
		{
			_inputparametervalues[0] = SalesOrderID;
			Transactional.ExecSql(connector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync(int? SalesOrderID)
		{
			_inputparametervalues[0] = SalesOrderID;
			await Transactional.ExecSqlAsync(VenturaSqlConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync(Connector connector, int? SalesOrderID)
		{
			_inputparametervalues[0] = SalesOrderID;
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

			public int? SalesOrderID
			{
				get { return (int?)_values[0]; }
				set { _values[0] = value; }
			}

		}

	}

	public sealed partial class PriKey_Sales_SalesOrderHeader_Record : IRecordBase, INotifyPropertyChanged
	{
		private DataRecordStatus _recordstatus;
		private bool _started_with_dbvalues;

		private int _cur__SalesOrderID; private int _ori__SalesOrderID; private bool _mod__SalesOrderID;
		private byte _cur__RevisionNumber; private byte _ori__RevisionNumber; private bool _mod__RevisionNumber;
		private DateTime _cur__OrderDate; private DateTime _ori__OrderDate; private bool _mod__OrderDate;
		private DateTime _cur__DueDate; private DateTime _ori__DueDate; private bool _mod__DueDate;
		private DateTime? _cur__ShipDate; private DateTime? _ori__ShipDate; private bool _mod__ShipDate;
		private byte _cur__Status; private byte _ori__Status; private bool _mod__Status;
		private bool _cur__OnlineOrderFlag; private bool _ori__OnlineOrderFlag; private bool _mod__OnlineOrderFlag;
		private string _cur__SalesOrderNumber; private string _ori__SalesOrderNumber; private bool _mod__SalesOrderNumber;
		private string _cur__PurchaseOrderNumber; private string _ori__PurchaseOrderNumber; private bool _mod__PurchaseOrderNumber;
		private string _cur__AccountNumber; private string _ori__AccountNumber; private bool _mod__AccountNumber;
		private int _cur__CustomerID; private int _ori__CustomerID; private bool _mod__CustomerID;
		private int? _cur__SalesPersonID; private int? _ori__SalesPersonID; private bool _mod__SalesPersonID;
		private int? _cur__TerritoryID; private int? _ori__TerritoryID; private bool _mod__TerritoryID;
		private int _cur__BillToAddressID; private int _ori__BillToAddressID; private bool _mod__BillToAddressID;
		private int _cur__ShipToAddressID; private int _ori__ShipToAddressID; private bool _mod__ShipToAddressID;
		private int _cur__ShipMethodID; private int _ori__ShipMethodID; private bool _mod__ShipMethodID;
		private int? _cur__CreditCardID; private int? _ori__CreditCardID; private bool _mod__CreditCardID;
		private string _cur__CreditCardApprovalCode; private string _ori__CreditCardApprovalCode; private bool _mod__CreditCardApprovalCode;
		private int? _cur__CurrencyRateID; private int? _ori__CurrencyRateID; private bool _mod__CurrencyRateID;
		private decimal _cur__SubTotal; private decimal _ori__SubTotal; private bool _mod__SubTotal;
		private decimal _cur__TaxAmt; private decimal _ori__TaxAmt; private bool _mod__TaxAmt;
		private decimal _cur__Freight; private decimal _ori__Freight; private bool _mod__Freight;
		private decimal _cur__TotalDue; private decimal _ori__TotalDue; private bool _mod__TotalDue;
		private string _cur__Comment; private string _ori__Comment; private bool _mod__Comment;
		private Guid _cur__rowguid; private Guid _ori__rowguid; private bool _mod__rowguid;
		private DateTime _cur__ModifiedDate; private DateTime _ori__ModifiedDate; private bool _mod__ModifiedDate;


		public PriKey_Sales_SalesOrderHeader_Record()
		{
			_cur__SalesOrderID = 0;
			_cur__RevisionNumber = 0;
			_cur__OrderDate = new DateTime(1900, 1, 1);
			_cur__DueDate = new DateTime(1900, 1, 1);
			_cur__ShipDate = null;
			_cur__Status = 0;
			_cur__OnlineOrderFlag = false;
			_cur__SalesOrderNumber = "";
			_cur__PurchaseOrderNumber = null;
			_cur__AccountNumber = null;
			_cur__CustomerID = 0;
			_cur__SalesPersonID = null;
			_cur__TerritoryID = null;
			_cur__BillToAddressID = 0;
			_cur__ShipToAddressID = 0;
			_cur__ShipMethodID = 0;
			_cur__CreditCardID = null;
			_cur__CreditCardApprovalCode = null;
			_cur__CurrencyRateID = null;
			_cur__SubTotal = 0.0m;
			_cur__TaxAmt = 0.0m;
			_cur__Freight = 0.0m;
			_cur__TotalDue = 0.0m;
			_cur__Comment = null;
			_cur__rowguid = Guid.Empty;
			_cur__ModifiedDate = new DateTime(1900, 1, 1);
			_started_with_dbvalues = false;
			_recordstatus = DataRecordStatus.New;
		}

		public PriKey_Sales_SalesOrderHeader_Record(object[] columnvalues)
		{
			_cur__SalesOrderID = (int)columnvalues[0];
			_cur__RevisionNumber = (byte)columnvalues[1];
			_cur__OrderDate = (DateTime)columnvalues[2];
			_cur__DueDate = (DateTime)columnvalues[3];
			_cur__ShipDate = (DateTime?)columnvalues[4];
			_cur__Status = (byte)columnvalues[5];
			_cur__OnlineOrderFlag = (bool)columnvalues[6];
			_cur__SalesOrderNumber = (string)columnvalues[7];
			_cur__PurchaseOrderNumber = (string)columnvalues[8];
			_cur__AccountNumber = (string)columnvalues[9];
			_cur__CustomerID = (int)columnvalues[10];
			_cur__SalesPersonID = (int?)columnvalues[11];
			_cur__TerritoryID = (int?)columnvalues[12];
			_cur__BillToAddressID = (int)columnvalues[13];
			_cur__ShipToAddressID = (int)columnvalues[14];
			_cur__ShipMethodID = (int)columnvalues[15];
			_cur__CreditCardID = (int?)columnvalues[16];
			_cur__CreditCardApprovalCode = (string)columnvalues[17];
			_cur__CurrencyRateID = (int?)columnvalues[18];
			_cur__SubTotal = (decimal)columnvalues[19];
			_cur__TaxAmt = (decimal)columnvalues[20];
			_cur__Freight = (decimal)columnvalues[21];
			_cur__TotalDue = (decimal)columnvalues[22];
			_cur__Comment = (string)columnvalues[23];
			_cur__rowguid = (Guid)columnvalues[24];
			_cur__ModifiedDate = (DateTime)columnvalues[25];
			_started_with_dbvalues = true;
			_recordstatus = DataRecordStatus.Existing;
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Sales].[SalesOrderHeader]. PrimaryKey. NotReadonly. NotNull. IsIdentity. AutoIncrement.
		/// </summary>
		public int SalesOrderID
		{
			get { return _cur__SalesOrderID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__SalesOrderID = true;
				if (_cur__SalesOrderID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__SalesOrderID == false) { _ori__SalesOrderID = _cur__SalesOrderID; _mod__SalesOrderID = true; } // existing record and column is not modified
					else { if (value == _ori__SalesOrderID) { _ori__SalesOrderID = default(int); _mod__SalesOrderID = false; } } // existing record and column is modified
				}
				_cur__SalesOrderID = value; OnPropertyChanged("SalesOrderID"); OnAfterPropertyChanged("SalesOrderID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderHeader]. NotReadonly. NotNull.
		/// </summary>
		public byte RevisionNumber
		{
			get { return _cur__RevisionNumber; }
			set
			{
				if (_started_with_dbvalues == false) _mod__RevisionNumber = true;
				if (_cur__RevisionNumber == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__RevisionNumber == false) { _ori__RevisionNumber = _cur__RevisionNumber; _mod__RevisionNumber = true; } // existing record and column is not modified
					else { if (value == _ori__RevisionNumber) { _ori__RevisionNumber = default(byte); _mod__RevisionNumber = false; } } // existing record and column is modified
				}
				_cur__RevisionNumber = value; OnPropertyChanged("RevisionNumber"); OnAfterPropertyChanged("RevisionNumber");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderHeader]. NotReadonly. NotNull.
		/// </summary>
		public DateTime OrderDate
		{
			get { return _cur__OrderDate; }
			set
			{
				if (_started_with_dbvalues == false) _mod__OrderDate = true;
				if (_cur__OrderDate == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__OrderDate == false) { _ori__OrderDate = _cur__OrderDate; _mod__OrderDate = true; } // existing record and column is not modified
					else { if (value == _ori__OrderDate) { _ori__OrderDate = default(DateTime); _mod__OrderDate = false; } } // existing record and column is modified
				}
				_cur__OrderDate = value; OnPropertyChanged("OrderDate"); OnAfterPropertyChanged("OrderDate");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderHeader]. NotReadonly. NotNull.
		/// </summary>
		public DateTime DueDate
		{
			get { return _cur__DueDate; }
			set
			{
				if (_started_with_dbvalues == false) _mod__DueDate = true;
				if (_cur__DueDate == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__DueDate == false) { _ori__DueDate = _cur__DueDate; _mod__DueDate = true; } // existing record and column is not modified
					else { if (value == _ori__DueDate) { _ori__DueDate = default(DateTime); _mod__DueDate = false; } } // existing record and column is modified
				}
				_cur__DueDate = value; OnPropertyChanged("DueDate"); OnAfterPropertyChanged("DueDate");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderHeader]. NotReadonly. AllowNull.
		/// </summary>
		public DateTime? ShipDate
		{
			get { return _cur__ShipDate; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ShipDate = true;
				if (_cur__ShipDate == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ShipDate == false) { _ori__ShipDate = _cur__ShipDate; _mod__ShipDate = true; } // existing record and column is not modified
					else { if (value == _ori__ShipDate) { _ori__ShipDate = default(DateTime?); _mod__ShipDate = false; } } // existing record and column is modified
				}
				_cur__ShipDate = value; OnPropertyChanged("ShipDate"); OnAfterPropertyChanged("ShipDate");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderHeader]. NotReadonly. NotNull.
		/// </summary>
		public byte Status
		{
			get { return _cur__Status; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Status = true;
				if (_cur__Status == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Status == false) { _ori__Status = _cur__Status; _mod__Status = true; } // existing record and column is not modified
					else { if (value == _ori__Status) { _ori__Status = default(byte); _mod__Status = false; } } // existing record and column is modified
				}
				_cur__Status = value; OnPropertyChanged("Status"); OnAfterPropertyChanged("Status");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderHeader]. NotReadonly. NotNull.
		/// </summary>
		public bool OnlineOrderFlag
		{
			get { return _cur__OnlineOrderFlag; }
			set
			{
				if (_started_with_dbvalues == false) _mod__OnlineOrderFlag = true;
				if (_cur__OnlineOrderFlag == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__OnlineOrderFlag == false) { _ori__OnlineOrderFlag = _cur__OnlineOrderFlag; _mod__OnlineOrderFlag = true; } // existing record and column is not modified
					else { if (value == _ori__OnlineOrderFlag) { _ori__OnlineOrderFlag = default(bool); _mod__OnlineOrderFlag = false; } } // existing record and column is modified
				}
				_cur__OnlineOrderFlag = value; OnPropertyChanged("OnlineOrderFlag"); OnAfterPropertyChanged("OnlineOrderFlag");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderHeader]. NotReadonly. NotNull.
		/// </summary>
		public string SalesOrderNumber
		{
			get { return _cur__SalesOrderNumber; }
			set
			{
				if (value == null) throw new ArgumentNullException("SalesOrderNumber", VenturaSqlStrings.SET_NULL_MSG);
				if (_started_with_dbvalues == false) _mod__SalesOrderNumber = true;
				if (_cur__SalesOrderNumber == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__SalesOrderNumber == false) { _ori__SalesOrderNumber = _cur__SalesOrderNumber; _mod__SalesOrderNumber = true; } // existing record and column is not modified
					else { if (value == _ori__SalesOrderNumber) { _ori__SalesOrderNumber = default(string); _mod__SalesOrderNumber = false; } } // existing record and column is modified
				}
				_cur__SalesOrderNumber = value; OnPropertyChanged("SalesOrderNumber"); OnAfterPropertyChanged("SalesOrderNumber");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderHeader]. NotReadonly. AllowNull.
		/// </summary>
		public string PurchaseOrderNumber
		{
			get { return _cur__PurchaseOrderNumber; }
			set
			{
				if (_started_with_dbvalues == false) _mod__PurchaseOrderNumber = true;
				if (_cur__PurchaseOrderNumber == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__PurchaseOrderNumber == false) { _ori__PurchaseOrderNumber = _cur__PurchaseOrderNumber; _mod__PurchaseOrderNumber = true; } // existing record and column is not modified
					else { if (value == _ori__PurchaseOrderNumber) { _ori__PurchaseOrderNumber = default(string); _mod__PurchaseOrderNumber = false; } } // existing record and column is modified
				}
				_cur__PurchaseOrderNumber = value; OnPropertyChanged("PurchaseOrderNumber"); OnAfterPropertyChanged("PurchaseOrderNumber");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderHeader]. NotReadonly. AllowNull.
		/// </summary>
		public string AccountNumber
		{
			get { return _cur__AccountNumber; }
			set
			{
				if (_started_with_dbvalues == false) _mod__AccountNumber = true;
				if (_cur__AccountNumber == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__AccountNumber == false) { _ori__AccountNumber = _cur__AccountNumber; _mod__AccountNumber = true; } // existing record and column is not modified
					else { if (value == _ori__AccountNumber) { _ori__AccountNumber = default(string); _mod__AccountNumber = false; } } // existing record and column is modified
				}
				_cur__AccountNumber = value; OnPropertyChanged("AccountNumber"); OnAfterPropertyChanged("AccountNumber");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderHeader]. NotReadonly. NotNull.
		/// </summary>
		public int CustomerID
		{
			get { return _cur__CustomerID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__CustomerID = true;
				if (_cur__CustomerID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__CustomerID == false) { _ori__CustomerID = _cur__CustomerID; _mod__CustomerID = true; } // existing record and column is not modified
					else { if (value == _ori__CustomerID) { _ori__CustomerID = default(int); _mod__CustomerID = false; } } // existing record and column is modified
				}
				_cur__CustomerID = value; OnPropertyChanged("CustomerID"); OnAfterPropertyChanged("CustomerID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderHeader]. NotReadonly. AllowNull.
		/// </summary>
		public int? SalesPersonID
		{
			get { return _cur__SalesPersonID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__SalesPersonID = true;
				if (_cur__SalesPersonID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__SalesPersonID == false) { _ori__SalesPersonID = _cur__SalesPersonID; _mod__SalesPersonID = true; } // existing record and column is not modified
					else { if (value == _ori__SalesPersonID) { _ori__SalesPersonID = default(int?); _mod__SalesPersonID = false; } } // existing record and column is modified
				}
				_cur__SalesPersonID = value; OnPropertyChanged("SalesPersonID"); OnAfterPropertyChanged("SalesPersonID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderHeader]. NotReadonly. AllowNull.
		/// </summary>
		public int? TerritoryID
		{
			get { return _cur__TerritoryID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__TerritoryID = true;
				if (_cur__TerritoryID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__TerritoryID == false) { _ori__TerritoryID = _cur__TerritoryID; _mod__TerritoryID = true; } // existing record and column is not modified
					else { if (value == _ori__TerritoryID) { _ori__TerritoryID = default(int?); _mod__TerritoryID = false; } } // existing record and column is modified
				}
				_cur__TerritoryID = value; OnPropertyChanged("TerritoryID"); OnAfterPropertyChanged("TerritoryID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderHeader]. NotReadonly. NotNull.
		/// </summary>
		public int BillToAddressID
		{
			get { return _cur__BillToAddressID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__BillToAddressID = true;
				if (_cur__BillToAddressID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__BillToAddressID == false) { _ori__BillToAddressID = _cur__BillToAddressID; _mod__BillToAddressID = true; } // existing record and column is not modified
					else { if (value == _ori__BillToAddressID) { _ori__BillToAddressID = default(int); _mod__BillToAddressID = false; } } // existing record and column is modified
				}
				_cur__BillToAddressID = value; OnPropertyChanged("BillToAddressID"); OnAfterPropertyChanged("BillToAddressID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderHeader]. NotReadonly. NotNull.
		/// </summary>
		public int ShipToAddressID
		{
			get { return _cur__ShipToAddressID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ShipToAddressID = true;
				if (_cur__ShipToAddressID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ShipToAddressID == false) { _ori__ShipToAddressID = _cur__ShipToAddressID; _mod__ShipToAddressID = true; } // existing record and column is not modified
					else { if (value == _ori__ShipToAddressID) { _ori__ShipToAddressID = default(int); _mod__ShipToAddressID = false; } } // existing record and column is modified
				}
				_cur__ShipToAddressID = value; OnPropertyChanged("ShipToAddressID"); OnAfterPropertyChanged("ShipToAddressID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderHeader]. NotReadonly. NotNull.
		/// </summary>
		public int ShipMethodID
		{
			get { return _cur__ShipMethodID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ShipMethodID = true;
				if (_cur__ShipMethodID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ShipMethodID == false) { _ori__ShipMethodID = _cur__ShipMethodID; _mod__ShipMethodID = true; } // existing record and column is not modified
					else { if (value == _ori__ShipMethodID) { _ori__ShipMethodID = default(int); _mod__ShipMethodID = false; } } // existing record and column is modified
				}
				_cur__ShipMethodID = value; OnPropertyChanged("ShipMethodID"); OnAfterPropertyChanged("ShipMethodID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderHeader]. NotReadonly. AllowNull.
		/// </summary>
		public int? CreditCardID
		{
			get { return _cur__CreditCardID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__CreditCardID = true;
				if (_cur__CreditCardID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__CreditCardID == false) { _ori__CreditCardID = _cur__CreditCardID; _mod__CreditCardID = true; } // existing record and column is not modified
					else { if (value == _ori__CreditCardID) { _ori__CreditCardID = default(int?); _mod__CreditCardID = false; } } // existing record and column is modified
				}
				_cur__CreditCardID = value; OnPropertyChanged("CreditCardID"); OnAfterPropertyChanged("CreditCardID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderHeader]. NotReadonly. AllowNull.
		/// </summary>
		public string CreditCardApprovalCode
		{
			get { return _cur__CreditCardApprovalCode; }
			set
			{
				if (_started_with_dbvalues == false) _mod__CreditCardApprovalCode = true;
				if (_cur__CreditCardApprovalCode == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__CreditCardApprovalCode == false) { _ori__CreditCardApprovalCode = _cur__CreditCardApprovalCode; _mod__CreditCardApprovalCode = true; } // existing record and column is not modified
					else { if (value == _ori__CreditCardApprovalCode) { _ori__CreditCardApprovalCode = default(string); _mod__CreditCardApprovalCode = false; } } // existing record and column is modified
				}
				_cur__CreditCardApprovalCode = value; OnPropertyChanged("CreditCardApprovalCode"); OnAfterPropertyChanged("CreditCardApprovalCode");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderHeader]. NotReadonly. AllowNull.
		/// </summary>
		public int? CurrencyRateID
		{
			get { return _cur__CurrencyRateID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__CurrencyRateID = true;
				if (_cur__CurrencyRateID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__CurrencyRateID == false) { _ori__CurrencyRateID = _cur__CurrencyRateID; _mod__CurrencyRateID = true; } // existing record and column is not modified
					else { if (value == _ori__CurrencyRateID) { _ori__CurrencyRateID = default(int?); _mod__CurrencyRateID = false; } } // existing record and column is modified
				}
				_cur__CurrencyRateID = value; OnPropertyChanged("CurrencyRateID"); OnAfterPropertyChanged("CurrencyRateID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderHeader]. NotReadonly. NotNull.
		/// </summary>
		public decimal SubTotal
		{
			get { return _cur__SubTotal; }
			set
			{
				if (_started_with_dbvalues == false) _mod__SubTotal = true;
				if (_cur__SubTotal == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__SubTotal == false) { _ori__SubTotal = _cur__SubTotal; _mod__SubTotal = true; } // existing record and column is not modified
					else { if (value == _ori__SubTotal) { _ori__SubTotal = default(decimal); _mod__SubTotal = false; } } // existing record and column is modified
				}
				_cur__SubTotal = value; OnPropertyChanged("SubTotal"); OnAfterPropertyChanged("SubTotal");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderHeader]. NotReadonly. NotNull.
		/// </summary>
		public decimal TaxAmt
		{
			get { return _cur__TaxAmt; }
			set
			{
				if (_started_with_dbvalues == false) _mod__TaxAmt = true;
				if (_cur__TaxAmt == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__TaxAmt == false) { _ori__TaxAmt = _cur__TaxAmt; _mod__TaxAmt = true; } // existing record and column is not modified
					else { if (value == _ori__TaxAmt) { _ori__TaxAmt = default(decimal); _mod__TaxAmt = false; } } // existing record and column is modified
				}
				_cur__TaxAmt = value; OnPropertyChanged("TaxAmt"); OnAfterPropertyChanged("TaxAmt");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderHeader]. NotReadonly. NotNull.
		/// </summary>
		public decimal Freight
		{
			get { return _cur__Freight; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Freight = true;
				if (_cur__Freight == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Freight == false) { _ori__Freight = _cur__Freight; _mod__Freight = true; } // existing record and column is not modified
					else { if (value == _ori__Freight) { _ori__Freight = default(decimal); _mod__Freight = false; } } // existing record and column is modified
				}
				_cur__Freight = value; OnPropertyChanged("Freight"); OnAfterPropertyChanged("Freight");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderHeader]. NotReadonly. NotNull.
		/// </summary>
		public decimal TotalDue
		{
			get { return _cur__TotalDue; }
			set
			{
				if (_started_with_dbvalues == false) _mod__TotalDue = true;
				if (_cur__TotalDue == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__TotalDue == false) { _ori__TotalDue = _cur__TotalDue; _mod__TotalDue = true; } // existing record and column is not modified
					else { if (value == _ori__TotalDue) { _ori__TotalDue = default(decimal); _mod__TotalDue = false; } } // existing record and column is modified
				}
				_cur__TotalDue = value; OnPropertyChanged("TotalDue"); OnAfterPropertyChanged("TotalDue");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Sales].[SalesOrderHeader]. NotReadonly. AllowNull.
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
		/// Database Column Updateable. Table [Sales].[SalesOrderHeader]. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [Sales].[SalesOrderHeader]. NotReadonly. NotNull.
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
			if (column_name == "SalesOrderID") return _mod__SalesOrderID;
			if (column_name == "RevisionNumber") return _mod__RevisionNumber;
			if (column_name == "OrderDate") return _mod__OrderDate;
			if (column_name == "DueDate") return _mod__DueDate;
			if (column_name == "ShipDate") return _mod__ShipDate;
			if (column_name == "Status") return _mod__Status;
			if (column_name == "OnlineOrderFlag") return _mod__OnlineOrderFlag;
			if (column_name == "SalesOrderNumber") return _mod__SalesOrderNumber;
			if (column_name == "PurchaseOrderNumber") return _mod__PurchaseOrderNumber;
			if (column_name == "AccountNumber") return _mod__AccountNumber;
			if (column_name == "CustomerID") return _mod__CustomerID;
			if (column_name == "SalesPersonID") return _mod__SalesPersonID;
			if (column_name == "TerritoryID") return _mod__TerritoryID;
			if (column_name == "BillToAddressID") return _mod__BillToAddressID;
			if (column_name == "ShipToAddressID") return _mod__ShipToAddressID;
			if (column_name == "ShipMethodID") return _mod__ShipMethodID;
			if (column_name == "CreditCardID") return _mod__CreditCardID;
			if (column_name == "CreditCardApprovalCode") return _mod__CreditCardApprovalCode;
			if (column_name == "CurrencyRateID") return _mod__CurrencyRateID;
			if (column_name == "SubTotal") return _mod__SubTotal;
			if (column_name == "TaxAmt") return _mod__TaxAmt;
			if (column_name == "Freight") return _mod__Freight;
			if (column_name == "TotalDue") return _mod__TotalDue;
			if (column_name == "Comment") return _mod__Comment;
			if (column_name == "rowguid") return _mod__rowguid;
			if (column_name == "ModifiedDate") return _mod__ModifiedDate;
			throw new ArgumentOutOfRangeException(String.Format(VenturaSqlStrings.UNKNOWN_COLUMN_NAME, column_name));
		}

		public int ModifiedColumnCount()
		{
			int count = 0;
			if (_mod__SalesOrderID == true) count++;
			if (_mod__RevisionNumber == true) count++;
			if (_mod__OrderDate == true) count++;
			if (_mod__DueDate == true) count++;
			if (_mod__ShipDate == true) count++;
			if (_mod__Status == true) count++;
			if (_mod__OnlineOrderFlag == true) count++;
			if (_mod__SalesOrderNumber == true) count++;
			if (_mod__PurchaseOrderNumber == true) count++;
			if (_mod__AccountNumber == true) count++;
			if (_mod__CustomerID == true) count++;
			if (_mod__SalesPersonID == true) count++;
			if (_mod__TerritoryID == true) count++;
			if (_mod__BillToAddressID == true) count++;
			if (_mod__ShipToAddressID == true) count++;
			if (_mod__ShipMethodID == true) count++;
			if (_mod__CreditCardID == true) count++;
			if (_mod__CreditCardApprovalCode == true) count++;
			if (_mod__CurrencyRateID == true) count++;
			if (_mod__SubTotal == true) count++;
			if (_mod__TaxAmt == true) count++;
			if (_mod__Freight == true) count++;
			if (_mod__TotalDue == true) count++;
			if (_mod__Comment == true) count++;
			if (_mod__rowguid == true) count++;
			if (_mod__ModifiedDate == true) count++;
			return count;
		}

		public bool PendingChanges()
		{
			if (_recordstatus == DataRecordStatus.New || _recordstatus == DataRecordStatus.ExistingDelete) return true;
			int count = 0;
			if (_mod__RevisionNumber == true) count++;
			if (_mod__OrderDate == true) count++;
			if (_mod__DueDate == true) count++;
			if (_mod__ShipDate == true) count++;
			if (_mod__Status == true) count++;
			if (_mod__OnlineOrderFlag == true) count++;
			if (_mod__SalesOrderNumber == true) count++;
			if (_mod__PurchaseOrderNumber == true) count++;
			if (_mod__AccountNumber == true) count++;
			if (_mod__CustomerID == true) count++;
			if (_mod__SalesPersonID == true) count++;
			if (_mod__TerritoryID == true) count++;
			if (_mod__BillToAddressID == true) count++;
			if (_mod__ShipToAddressID == true) count++;
			if (_mod__ShipMethodID == true) count++;
			if (_mod__CreditCardID == true) count++;
			if (_mod__CreditCardApprovalCode == true) count++;
			if (_mod__CurrencyRateID == true) count++;
			if (_mod__SubTotal == true) count++;
			if (_mod__TaxAmt == true) count++;
			if (_mod__Freight == true) count++;
			if (_mod__TotalDue == true) count++;
			if (_mod__Comment == true) count++;
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
				track_array.AppendDataValue(1, _cur__RevisionNumber);
				track_array.AppendDataValue(2, _cur__OrderDate);
				track_array.AppendDataValue(3, _cur__DueDate);
				if (_cur__ShipDate != null) track_array.AppendDataValue(4, _cur__ShipDate);
				track_array.AppendDataValue(5, _cur__Status);
				track_array.AppendDataValue(6, _cur__OnlineOrderFlag);
				track_array.AppendDataValue(7, _cur__SalesOrderNumber);
				if (_cur__PurchaseOrderNumber != null) track_array.AppendDataValue(8, _cur__PurchaseOrderNumber);
				if (_cur__AccountNumber != null) track_array.AppendDataValue(9, _cur__AccountNumber);
				track_array.AppendDataValue(10, _cur__CustomerID);
				if (_cur__SalesPersonID != null) track_array.AppendDataValue(11, _cur__SalesPersonID);
				if (_cur__TerritoryID != null) track_array.AppendDataValue(12, _cur__TerritoryID);
				track_array.AppendDataValue(13, _cur__BillToAddressID);
				track_array.AppendDataValue(14, _cur__ShipToAddressID);
				track_array.AppendDataValue(15, _cur__ShipMethodID);
				if (_cur__CreditCardID != null) track_array.AppendDataValue(16, _cur__CreditCardID);
				if (_cur__CreditCardApprovalCode != null) track_array.AppendDataValue(17, _cur__CreditCardApprovalCode);
				if (_cur__CurrencyRateID != null) track_array.AppendDataValue(18, _cur__CurrencyRateID);
				track_array.AppendDataValue(19, _cur__SubTotal);
				track_array.AppendDataValue(20, _cur__TaxAmt);
				track_array.AppendDataValue(21, _cur__Freight);
				track_array.AppendDataValue(22, _cur__TotalDue);
				if (_cur__Comment != null) track_array.AppendDataValue(23, _cur__Comment);
				track_array.AppendDataValue(24, _cur__rowguid);
				track_array.AppendDataValue(25, _cur__ModifiedDate);
			}
			else if (_recordstatus == DataRecordStatus.Existing)
			{
				if (_mod__RevisionNumber) track_array.AppendDataValue(1, _cur__RevisionNumber);
				if (_mod__OrderDate) track_array.AppendDataValue(2, _cur__OrderDate);
				if (_mod__DueDate) track_array.AppendDataValue(3, _cur__DueDate);
				if (_mod__ShipDate) track_array.AppendDataValue(4, _cur__ShipDate);
				if (_mod__Status) track_array.AppendDataValue(5, _cur__Status);
				if (_mod__OnlineOrderFlag) track_array.AppendDataValue(6, _cur__OnlineOrderFlag);
				if (_mod__SalesOrderNumber) track_array.AppendDataValue(7, _cur__SalesOrderNumber);
				if (_mod__PurchaseOrderNumber) track_array.AppendDataValue(8, _cur__PurchaseOrderNumber);
				if (_mod__AccountNumber) track_array.AppendDataValue(9, _cur__AccountNumber);
				if (_mod__CustomerID) track_array.AppendDataValue(10, _cur__CustomerID);
				if (_mod__SalesPersonID) track_array.AppendDataValue(11, _cur__SalesPersonID);
				if (_mod__TerritoryID) track_array.AppendDataValue(12, _cur__TerritoryID);
				if (_mod__BillToAddressID) track_array.AppendDataValue(13, _cur__BillToAddressID);
				if (_mod__ShipToAddressID) track_array.AppendDataValue(14, _cur__ShipToAddressID);
				if (_mod__ShipMethodID) track_array.AppendDataValue(15, _cur__ShipMethodID);
				if (_mod__CreditCardID) track_array.AppendDataValue(16, _cur__CreditCardID);
				if (_mod__CreditCardApprovalCode) track_array.AppendDataValue(17, _cur__CreditCardApprovalCode);
				if (_mod__CurrencyRateID) track_array.AppendDataValue(18, _cur__CurrencyRateID);
				if (_mod__SubTotal) track_array.AppendDataValue(19, _cur__SubTotal);
				if (_mod__TaxAmt) track_array.AppendDataValue(20, _cur__TaxAmt);
				if (_mod__Freight) track_array.AppendDataValue(21, _cur__Freight);
				if (_mod__TotalDue) track_array.AppendDataValue(22, _cur__TotalDue);
				if (_mod__Comment) track_array.AppendDataValue(23, _cur__Comment);
				if (_mod__rowguid) track_array.AppendDataValue(24, _cur__rowguid);
				if (_mod__ModifiedDate) track_array.AppendDataValue(25, _cur__ModifiedDate);
				if (track_array.HasData == false) return;
			}

			if (_recordstatus == DataRecordStatus.Existing || _recordstatus == DataRecordStatus.ExistingDelete)
			{
				track_array.AppendPrikeyValue(0, (_mod__SalesOrderID && _started_with_dbvalues) ? _ori__SalesOrderID : _cur__SalesOrderID);
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
				if (_mod__SalesOrderID) _ori__SalesOrderID = default(int);
				if (_mod__RevisionNumber) _ori__RevisionNumber = default(byte);
				if (_mod__OrderDate) _ori__OrderDate = default(DateTime);
				if (_mod__DueDate) _ori__DueDate = default(DateTime);
				if (_mod__ShipDate) _ori__ShipDate = default(DateTime?);
				if (_mod__Status) _ori__Status = default(byte);
				if (_mod__OnlineOrderFlag) _ori__OnlineOrderFlag = default(bool);
				if (_mod__SalesOrderNumber) _ori__SalesOrderNumber = default(string);
				if (_mod__PurchaseOrderNumber) _ori__PurchaseOrderNumber = default(string);
				if (_mod__AccountNumber) _ori__AccountNumber = default(string);
				if (_mod__CustomerID) _ori__CustomerID = default(int);
				if (_mod__SalesPersonID) _ori__SalesPersonID = default(int?);
				if (_mod__TerritoryID) _ori__TerritoryID = default(int?);
				if (_mod__BillToAddressID) _ori__BillToAddressID = default(int);
				if (_mod__ShipToAddressID) _ori__ShipToAddressID = default(int);
				if (_mod__ShipMethodID) _ori__ShipMethodID = default(int);
				if (_mod__CreditCardID) _ori__CreditCardID = default(int?);
				if (_mod__CreditCardApprovalCode) _ori__CreditCardApprovalCode = default(string);
				if (_mod__CurrencyRateID) _ori__CurrencyRateID = default(int?);
				if (_mod__SubTotal) _ori__SubTotal = default(decimal);
				if (_mod__TaxAmt) _ori__TaxAmt = default(decimal);
				if (_mod__Freight) _ori__Freight = default(decimal);
				if (_mod__TotalDue) _ori__TotalDue = default(decimal);
				if (_mod__Comment) _ori__Comment = default(string);
				if (_mod__rowguid) _ori__rowguid = default(Guid);
				if (_mod__ModifiedDate) _ori__ModifiedDate = default(DateTime);
			}
			_mod__SalesOrderID = false;
			_mod__RevisionNumber = false;
			_mod__OrderDate = false;
			_mod__DueDate = false;
			_mod__ShipDate = false;
			_mod__Status = false;
			_mod__OnlineOrderFlag = false;
			_mod__SalesOrderNumber = false;
			_mod__PurchaseOrderNumber = false;
			_mod__AccountNumber = false;
			_mod__CustomerID = false;
			_mod__SalesPersonID = false;
			_mod__TerritoryID = false;
			_mod__BillToAddressID = false;
			_mod__ShipToAddressID = false;
			_mod__ShipMethodID = false;
			_mod__CreditCardID = false;
			_mod__CreditCardApprovalCode = false;
			_mod__CurrencyRateID = false;
			_mod__SubTotal = false;
			_mod__TaxAmt = false;
			_mod__Freight = false;
			_mod__TotalDue = false;
			_mod__Comment = false;
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
			_cur__SalesOrderID = (int)value;
			OnPropertyChanged("SalesOrderID");
			OnAfterPropertyChanged("SalesOrderID");
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
	public partial class PriKey_Sales_SalesOrderHeader_Record
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
