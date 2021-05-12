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

namespace AspNetCoreServer.VenturaAutoCreate
{
	/// <summary>
	/// The updateable table is [Purchasing].[PurchaseOrderHeader]. Updateable table column information:
	/// • 13 out of 13 table columns are present in the resultset.
	/// • All primary key columns are present in the resultset: PurchaseOrderID.
	/// • Non-primary key columns present in the resultset: RevisionNumber, Status, EmployeeID, VendorID, ShipMethodID, OrderDate,
	///   ShipDate, SubTotal, TaxAmt, Freight, TotalDue and ModifiedDate.
	/// Recordset item automatically created by VenturaSQL Studio.
	/// </summary>
	public partial class PriKey_Purchasing_PurchaseOrderHeader_Recordset : ResultsetObservable<PriKey_Purchasing_PurchaseOrderHeader_Recordset, PriKey_Purchasing_PurchaseOrderHeader_Record>, IRecordsetBase
	{
		private IResultsetBase[] _resultsets;
		private string _sqlscript;
		private object[] _inputparametervalues;
		private InputParamHolder _inputparamholder;
		private VenturaSqlSchema _parameterschema;
		private int _rowlimit = 500;
		private const string CRLF = "\r\n";

		public PriKey_Purchasing_PurchaseOrderHeader_Recordset()
		{
			_resultsets = new IResultsetBase[] { this };

			_sqlscript = @"SELECT [PurchaseOrderID],[RevisionNumber],[Status],[EmployeeID],[VendorID],[ShipMethodID],[OrderDate],[ShipDate],[SubTotal],[TaxAmt],[Freight],[TotalDue]," + CRLF +
			             @"[ModifiedDate]" + CRLF +
			             @"FROM [Purchasing].[PurchaseOrderHeader]" + CRLF +
			             @"WHERE [PurchaseOrderID] = @PurchaseOrderID";

			_inputparametervalues = new object[1];
			_inputparamholder = new InputParamHolder(_inputparametervalues);

			ColumnArrayBuilder param_array = new ColumnArrayBuilder();

			param_array.AddParameterColumn("@PurchaseOrderID", typeof(int), true, false, DbType.Int32, null, null, null);

			_parameterschema = new VenturaSqlSchema(param_array);

			ColumnArrayBuilder schema_array = new ColumnArrayBuilder();

			schema_array.Add(new VenturaSqlColumn("PurchaseOrderID", typeof(int), false)
			{
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				IsKey = true,
				IsIdentity = true,
				IsAutoIncrement = true,
				BaseSchemaName = "Purchasing",
				BaseTableName = "PurchaseOrderHeader",
				BaseColumnName = "PurchaseOrderID"
			});

			schema_array.Add(new VenturaSqlColumn("RevisionNumber", typeof(byte), false)
			{
				Updateable = true,
				ColumnSize = 1,
				NumericPrecision = 3,
				ProviderType = 20,
				BaseSchemaName = "Purchasing",
				BaseTableName = "PurchaseOrderHeader",
				BaseColumnName = "RevisionNumber"
			});

			schema_array.Add(new VenturaSqlColumn("Status", typeof(byte), false)
			{
				Updateable = true,
				ColumnSize = 1,
				NumericPrecision = 3,
				ProviderType = 20,
				BaseSchemaName = "Purchasing",
				BaseTableName = "PurchaseOrderHeader",
				BaseColumnName = "Status"
			});

			schema_array.Add(new VenturaSqlColumn("EmployeeID", typeof(int), false)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				BaseSchemaName = "Purchasing",
				BaseTableName = "PurchaseOrderHeader",
				BaseColumnName = "EmployeeID"
			});

			schema_array.Add(new VenturaSqlColumn("VendorID", typeof(int), false)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				BaseSchemaName = "Purchasing",
				BaseTableName = "PurchaseOrderHeader",
				BaseColumnName = "VendorID"
			});

			schema_array.Add(new VenturaSqlColumn("ShipMethodID", typeof(int), false)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				BaseSchemaName = "Purchasing",
				BaseTableName = "PurchaseOrderHeader",
				BaseColumnName = "ShipMethodID"
			});

			schema_array.Add(new VenturaSqlColumn("OrderDate", typeof(DateTime), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 23,
				NumericScale = 3,
				ProviderType = 4,
				BaseSchemaName = "Purchasing",
				BaseTableName = "PurchaseOrderHeader",
				BaseColumnName = "OrderDate"
			});

			schema_array.Add(new VenturaSqlColumn("ShipDate", typeof(DateTime), true)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 23,
				NumericScale = 3,
				ProviderType = 4,
				BaseSchemaName = "Purchasing",
				BaseTableName = "PurchaseOrderHeader",
				BaseColumnName = "ShipDate"
			});

			schema_array.Add(new VenturaSqlColumn("SubTotal", typeof(decimal), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 19,
				ProviderType = 9,
				BaseSchemaName = "Purchasing",
				BaseTableName = "PurchaseOrderHeader",
				BaseColumnName = "SubTotal"
			});

			schema_array.Add(new VenturaSqlColumn("TaxAmt", typeof(decimal), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 19,
				ProviderType = 9,
				BaseSchemaName = "Purchasing",
				BaseTableName = "PurchaseOrderHeader",
				BaseColumnName = "TaxAmt"
			});

			schema_array.Add(new VenturaSqlColumn("Freight", typeof(decimal), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 19,
				ProviderType = 9,
				BaseSchemaName = "Purchasing",
				BaseTableName = "PurchaseOrderHeader",
				BaseColumnName = "Freight"
			});

			schema_array.Add(new VenturaSqlColumn("TotalDue", typeof(decimal), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 19,
				ProviderType = 9,
				BaseSchemaName = "Purchasing",
				BaseTableName = "PurchaseOrderHeader",
				BaseColumnName = "TotalDue"
			});

			schema_array.Add(new VenturaSqlColumn("ModifiedDate", typeof(DateTime), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 23,
				NumericScale = 3,
				ProviderType = 4,
				BaseSchemaName = "Purchasing",
				BaseTableName = "PurchaseOrderHeader",
				BaseColumnName = "ModifiedDate"
			});

			((IResultsetBase)this).Schema = new VenturaSqlSchema(schema_array);
			((IResultsetBase)this).UpdateableTablename = "[Purchasing].[PurchaseOrderHeader]";
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Purchasing].[PurchaseOrderHeader]. PrimaryKey. NotReadonly. NotNull. IsIdentity. AutoIncrement.
		/// </summary>
		public int PurchaseOrderID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.PurchaseOrderID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.PurchaseOrderID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[PurchaseOrderHeader]. NotReadonly. NotNull.
		/// </summary>
		public byte RevisionNumber
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.RevisionNumber; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.RevisionNumber = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[PurchaseOrderHeader]. NotReadonly. NotNull.
		/// </summary>
		public byte Status
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Status; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Status = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[PurchaseOrderHeader]. NotReadonly. NotNull.
		/// </summary>
		public int EmployeeID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.EmployeeID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.EmployeeID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[PurchaseOrderHeader]. NotReadonly. NotNull.
		/// </summary>
		public int VendorID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.VendorID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.VendorID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[PurchaseOrderHeader]. NotReadonly. NotNull.
		/// </summary>
		public int ShipMethodID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ShipMethodID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ShipMethodID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[PurchaseOrderHeader]. NotReadonly. NotNull.
		/// </summary>
		public DateTime OrderDate
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.OrderDate; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.OrderDate = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[PurchaseOrderHeader]. NotReadonly. AllowNull.
		/// </summary>
		public DateTime? ShipDate
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ShipDate; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ShipDate = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[PurchaseOrderHeader]. NotReadonly. NotNull.
		/// </summary>
		public decimal SubTotal
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.SubTotal; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.SubTotal = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[PurchaseOrderHeader]. NotReadonly. NotNull.
		/// </summary>
		public decimal TaxAmt
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.TaxAmt; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.TaxAmt = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[PurchaseOrderHeader]. NotReadonly. NotNull.
		/// </summary>
		public decimal Freight
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Freight; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Freight = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[PurchaseOrderHeader]. NotReadonly. NotNull.
		/// </summary>
		public decimal TotalDue
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.TotalDue; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.TotalDue = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[PurchaseOrderHeader]. NotReadonly. NotNull.
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
			this.InsertItem(index, new PriKey_Purchasing_PurchaseOrderHeader_Record());
			this.CurrentRecordIndex = index;
		}

		public void Append(PriKey_Purchasing_PurchaseOrderHeader_Record record)
		{
			int index = this.RecordCount;
			this.InsertItem(index, record);
			this.CurrentRecordIndex = index;
		}

		public PriKey_Purchasing_PurchaseOrderHeader_Record NewRecord()
		{
			return new PriKey_Purchasing_PurchaseOrderHeader_Record();
		}

		protected override PriKey_Purchasing_PurchaseOrderHeader_Record InternalCreateExistingRecordObject(object[] columnvalues) => new PriKey_Purchasing_PurchaseOrderHeader_Record(columnvalues);

		byte[] IRecordsetBase.Hash
		{
			get { return new byte[] { 97, 217, 220, 87, 187, 102, 186, 162, 248, 168, 164, 236, 199, 68, 204, 84 }; }
		}

		string IRecordsetBase.HashString
		{
			get { return "61D9DC57BB66BAA2F8A8A4ECC744CC54"; }
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

		public void SetExecSqlParams(int? PurchaseOrderID)
		{
			_inputparametervalues[0] = PurchaseOrderID;
		}

		public void ExecSql(int? PurchaseOrderID)
		{
			_inputparametervalues[0] = PurchaseOrderID;
			Transactional.ExecSql(VenturaSqlConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public void ExecSql(Connector connector, int? PurchaseOrderID)
		{
			_inputparametervalues[0] = PurchaseOrderID;
			Transactional.ExecSql(connector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync(int? PurchaseOrderID)
		{
			_inputparametervalues[0] = PurchaseOrderID;
			await Transactional.ExecSqlAsync(VenturaSqlConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync(Connector connector, int? PurchaseOrderID)
		{
			_inputparametervalues[0] = PurchaseOrderID;
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

			public int? PurchaseOrderID
			{
				get { return (int?)_values[0]; }
				set { _values[0] = value; }
			}

		}

	}

	public sealed partial class PriKey_Purchasing_PurchaseOrderHeader_Record : IRecordBase, INotifyPropertyChanged
	{
		private DataRecordStatus _recordstatus;
		private bool _started_with_dbvalues;

		private int _cur__PurchaseOrderID; private int _ori__PurchaseOrderID; private bool _mod__PurchaseOrderID;
		private byte _cur__RevisionNumber; private byte _ori__RevisionNumber; private bool _mod__RevisionNumber;
		private byte _cur__Status; private byte _ori__Status; private bool _mod__Status;
		private int _cur__EmployeeID; private int _ori__EmployeeID; private bool _mod__EmployeeID;
		private int _cur__VendorID; private int _ori__VendorID; private bool _mod__VendorID;
		private int _cur__ShipMethodID; private int _ori__ShipMethodID; private bool _mod__ShipMethodID;
		private DateTime _cur__OrderDate; private DateTime _ori__OrderDate; private bool _mod__OrderDate;
		private DateTime? _cur__ShipDate; private DateTime? _ori__ShipDate; private bool _mod__ShipDate;
		private decimal _cur__SubTotal; private decimal _ori__SubTotal; private bool _mod__SubTotal;
		private decimal _cur__TaxAmt; private decimal _ori__TaxAmt; private bool _mod__TaxAmt;
		private decimal _cur__Freight; private decimal _ori__Freight; private bool _mod__Freight;
		private decimal _cur__TotalDue; private decimal _ori__TotalDue; private bool _mod__TotalDue;
		private DateTime _cur__ModifiedDate; private DateTime _ori__ModifiedDate; private bool _mod__ModifiedDate;


		public PriKey_Purchasing_PurchaseOrderHeader_Record()
		{
			_cur__PurchaseOrderID = 0;
			_cur__RevisionNumber = 0;
			_cur__Status = 0;
			_cur__EmployeeID = 0;
			_cur__VendorID = 0;
			_cur__ShipMethodID = 0;
			_cur__OrderDate = new DateTime(1900, 1, 1);
			_cur__ShipDate = null;
			_cur__SubTotal = 0.0m;
			_cur__TaxAmt = 0.0m;
			_cur__Freight = 0.0m;
			_cur__TotalDue = 0.0m;
			_cur__ModifiedDate = new DateTime(1900, 1, 1);
			_started_with_dbvalues = false;
			_recordstatus = DataRecordStatus.New;
		}

		public PriKey_Purchasing_PurchaseOrderHeader_Record(object[] columnvalues)
		{
			_cur__PurchaseOrderID = (int)columnvalues[0];
			_cur__RevisionNumber = (byte)columnvalues[1];
			_cur__Status = (byte)columnvalues[2];
			_cur__EmployeeID = (int)columnvalues[3];
			_cur__VendorID = (int)columnvalues[4];
			_cur__ShipMethodID = (int)columnvalues[5];
			_cur__OrderDate = (DateTime)columnvalues[6];
			_cur__ShipDate = (DateTime?)columnvalues[7];
			_cur__SubTotal = (decimal)columnvalues[8];
			_cur__TaxAmt = (decimal)columnvalues[9];
			_cur__Freight = (decimal)columnvalues[10];
			_cur__TotalDue = (decimal)columnvalues[11];
			_cur__ModifiedDate = (DateTime)columnvalues[12];
			_started_with_dbvalues = true;
			_recordstatus = DataRecordStatus.Existing;
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Purchasing].[PurchaseOrderHeader]. PrimaryKey. NotReadonly. NotNull. IsIdentity. AutoIncrement.
		/// </summary>
		public int PurchaseOrderID
		{
			get { return _cur__PurchaseOrderID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__PurchaseOrderID = true;
				if (_cur__PurchaseOrderID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__PurchaseOrderID == false) { _ori__PurchaseOrderID = _cur__PurchaseOrderID; _mod__PurchaseOrderID = true; } // existing record and column is not modified
					else { if (value == _ori__PurchaseOrderID) { _ori__PurchaseOrderID = default(int); _mod__PurchaseOrderID = false; } } // existing record and column is modified
				}
				_cur__PurchaseOrderID = value; OnPropertyChanged("PurchaseOrderID"); OnAfterPropertyChanged("PurchaseOrderID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[PurchaseOrderHeader]. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [Purchasing].[PurchaseOrderHeader]. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [Purchasing].[PurchaseOrderHeader]. NotReadonly. NotNull.
		/// </summary>
		public int EmployeeID
		{
			get { return _cur__EmployeeID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__EmployeeID = true;
				if (_cur__EmployeeID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__EmployeeID == false) { _ori__EmployeeID = _cur__EmployeeID; _mod__EmployeeID = true; } // existing record and column is not modified
					else { if (value == _ori__EmployeeID) { _ori__EmployeeID = default(int); _mod__EmployeeID = false; } } // existing record and column is modified
				}
				_cur__EmployeeID = value; OnPropertyChanged("EmployeeID"); OnAfterPropertyChanged("EmployeeID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[PurchaseOrderHeader]. NotReadonly. NotNull.
		/// </summary>
		public int VendorID
		{
			get { return _cur__VendorID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__VendorID = true;
				if (_cur__VendorID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__VendorID == false) { _ori__VendorID = _cur__VendorID; _mod__VendorID = true; } // existing record and column is not modified
					else { if (value == _ori__VendorID) { _ori__VendorID = default(int); _mod__VendorID = false; } } // existing record and column is modified
				}
				_cur__VendorID = value; OnPropertyChanged("VendorID"); OnAfterPropertyChanged("VendorID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Purchasing].[PurchaseOrderHeader]. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [Purchasing].[PurchaseOrderHeader]. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [Purchasing].[PurchaseOrderHeader]. NotReadonly. AllowNull.
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
		/// Database Column Updateable. Table [Purchasing].[PurchaseOrderHeader]. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [Purchasing].[PurchaseOrderHeader]. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [Purchasing].[PurchaseOrderHeader]. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [Purchasing].[PurchaseOrderHeader]. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [Purchasing].[PurchaseOrderHeader]. NotReadonly. NotNull.
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
			if (column_name == "PurchaseOrderID") return _mod__PurchaseOrderID;
			if (column_name == "RevisionNumber") return _mod__RevisionNumber;
			if (column_name == "Status") return _mod__Status;
			if (column_name == "EmployeeID") return _mod__EmployeeID;
			if (column_name == "VendorID") return _mod__VendorID;
			if (column_name == "ShipMethodID") return _mod__ShipMethodID;
			if (column_name == "OrderDate") return _mod__OrderDate;
			if (column_name == "ShipDate") return _mod__ShipDate;
			if (column_name == "SubTotal") return _mod__SubTotal;
			if (column_name == "TaxAmt") return _mod__TaxAmt;
			if (column_name == "Freight") return _mod__Freight;
			if (column_name == "TotalDue") return _mod__TotalDue;
			if (column_name == "ModifiedDate") return _mod__ModifiedDate;
			throw new ArgumentOutOfRangeException(String.Format(VenturaSqlStrings.UNKNOWN_COLUMN_NAME, column_name));
		}

		public int ModifiedColumnCount()
		{
			int count = 0;
			if (_mod__PurchaseOrderID == true) count++;
			if (_mod__RevisionNumber == true) count++;
			if (_mod__Status == true) count++;
			if (_mod__EmployeeID == true) count++;
			if (_mod__VendorID == true) count++;
			if (_mod__ShipMethodID == true) count++;
			if (_mod__OrderDate == true) count++;
			if (_mod__ShipDate == true) count++;
			if (_mod__SubTotal == true) count++;
			if (_mod__TaxAmt == true) count++;
			if (_mod__Freight == true) count++;
			if (_mod__TotalDue == true) count++;
			if (_mod__ModifiedDate == true) count++;
			return count;
		}

		public bool PendingChanges()
		{
			if (_recordstatus == DataRecordStatus.New || _recordstatus == DataRecordStatus.ExistingDelete) return true;
			int count = 0;
			if (_mod__RevisionNumber == true) count++;
			if (_mod__Status == true) count++;
			if (_mod__EmployeeID == true) count++;
			if (_mod__VendorID == true) count++;
			if (_mod__ShipMethodID == true) count++;
			if (_mod__OrderDate == true) count++;
			if (_mod__ShipDate == true) count++;
			if (_mod__SubTotal == true) count++;
			if (_mod__TaxAmt == true) count++;
			if (_mod__Freight == true) count++;
			if (_mod__TotalDue == true) count++;
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
				track_array.AppendDataValue(2, _cur__Status);
				track_array.AppendDataValue(3, _cur__EmployeeID);
				track_array.AppendDataValue(4, _cur__VendorID);
				track_array.AppendDataValue(5, _cur__ShipMethodID);
				track_array.AppendDataValue(6, _cur__OrderDate);
				if (_cur__ShipDate != null) track_array.AppendDataValue(7, _cur__ShipDate);
				track_array.AppendDataValue(8, _cur__SubTotal);
				track_array.AppendDataValue(9, _cur__TaxAmt);
				track_array.AppendDataValue(10, _cur__Freight);
				track_array.AppendDataValue(11, _cur__TotalDue);
				track_array.AppendDataValue(12, _cur__ModifiedDate);
			}
			else if (_recordstatus == DataRecordStatus.Existing)
			{
				if (_mod__RevisionNumber) track_array.AppendDataValue(1, _cur__RevisionNumber);
				if (_mod__Status) track_array.AppendDataValue(2, _cur__Status);
				if (_mod__EmployeeID) track_array.AppendDataValue(3, _cur__EmployeeID);
				if (_mod__VendorID) track_array.AppendDataValue(4, _cur__VendorID);
				if (_mod__ShipMethodID) track_array.AppendDataValue(5, _cur__ShipMethodID);
				if (_mod__OrderDate) track_array.AppendDataValue(6, _cur__OrderDate);
				if (_mod__ShipDate) track_array.AppendDataValue(7, _cur__ShipDate);
				if (_mod__SubTotal) track_array.AppendDataValue(8, _cur__SubTotal);
				if (_mod__TaxAmt) track_array.AppendDataValue(9, _cur__TaxAmt);
				if (_mod__Freight) track_array.AppendDataValue(10, _cur__Freight);
				if (_mod__TotalDue) track_array.AppendDataValue(11, _cur__TotalDue);
				if (_mod__ModifiedDate) track_array.AppendDataValue(12, _cur__ModifiedDate);
				if (track_array.HasData == false) return;
			}

			if (_recordstatus == DataRecordStatus.Existing || _recordstatus == DataRecordStatus.ExistingDelete)
			{
				track_array.AppendPrikeyValue(0, (_mod__PurchaseOrderID && _started_with_dbvalues) ? _ori__PurchaseOrderID : _cur__PurchaseOrderID);
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
				if (_mod__PurchaseOrderID) _ori__PurchaseOrderID = default(int);
				if (_mod__RevisionNumber) _ori__RevisionNumber = default(byte);
				if (_mod__Status) _ori__Status = default(byte);
				if (_mod__EmployeeID) _ori__EmployeeID = default(int);
				if (_mod__VendorID) _ori__VendorID = default(int);
				if (_mod__ShipMethodID) _ori__ShipMethodID = default(int);
				if (_mod__OrderDate) _ori__OrderDate = default(DateTime);
				if (_mod__ShipDate) _ori__ShipDate = default(DateTime?);
				if (_mod__SubTotal) _ori__SubTotal = default(decimal);
				if (_mod__TaxAmt) _ori__TaxAmt = default(decimal);
				if (_mod__Freight) _ori__Freight = default(decimal);
				if (_mod__TotalDue) _ori__TotalDue = default(decimal);
				if (_mod__ModifiedDate) _ori__ModifiedDate = default(DateTime);
			}
			_mod__PurchaseOrderID = false;
			_mod__RevisionNumber = false;
			_mod__Status = false;
			_mod__EmployeeID = false;
			_mod__VendorID = false;
			_mod__ShipMethodID = false;
			_mod__OrderDate = false;
			_mod__ShipDate = false;
			_mod__SubTotal = false;
			_mod__TaxAmt = false;
			_mod__Freight = false;
			_mod__TotalDue = false;
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
			_cur__PurchaseOrderID = (int)value;
			OnPropertyChanged("PurchaseOrderID");
			OnAfterPropertyChanged("PurchaseOrderID");
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
namespace AspNetCoreServer.VenturaAutoCreate
{
	public partial class PriKey_Purchasing_PurchaseOrderHeader_Record
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
