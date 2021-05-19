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
	/// The updateable table is [Production].[ProductModel]. Updateable table column information:
	/// • 6 out of 6 table columns are present in the resultset.
	/// • All primary key columns are present in the resultset: ProductModelID.
	/// • Non-primary key columns present in the resultset: Name, CatalogDescription, Instructions, rowguid and ModifiedDate.
	/// Recordset item automatically created by VenturaSQL Studio.
	/// </summary>
	public partial class GetAll_Production_ProductModel_Recordset : ResultsetObservable<GetAll_Production_ProductModel_Recordset, GetAll_Production_ProductModel_Record>, IRecordsetBase
	{
		private IResultsetBase[] _resultsets;
		private string _sqlscript;
		private int _rowlimit = 500;
		private const string CRLF = "\r\n";

		public GetAll_Production_ProductModel_Recordset()
		{
			_resultsets = new IResultsetBase[] { this };

			_sqlscript = @"SELECT TOP(@RowLimit) [ProductModelID],[Name],[CatalogDescription],[Instructions],[rowguid],[ModifiedDate]" + CRLF +
			             @"FROM [Production].[ProductModel]";

			ColumnArrayBuilder schema_array = new ColumnArrayBuilder();

			schema_array.Add(new VenturaSqlColumn("ProductModelID", typeof(int), false)
			{
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				IsKey = true,
				IsIdentity = true,
				IsAutoIncrement = true,
				BaseSchemaName = "Production",
				BaseTableName = "ProductModel",
				BaseColumnName = "ProductModelID"
			});

			schema_array.Add(new VenturaSqlColumn("Name", typeof(string), false)
			{
				Updateable = true,
				ColumnSize = 50,
				ProviderType = 12,
				BaseSchemaName = "Production",
				BaseTableName = "ProductModel",
				BaseColumnName = "Name"
			});

			schema_array.Add(new VenturaSqlColumn("CatalogDescription", typeof(string), true)
			{
				Updateable = true,
				ProviderType = 25,
				IsLong = true,
				XmlSchemaCollectionDatabase = "AdventureWorks2017",
				XmlSchemaCollectionOwningSchema = "Production",
				XmlSchemaCollectionName = "ProductDescriptionSchemaCollection",
				BaseSchemaName = "Production",
				BaseTableName = "ProductModel",
				BaseColumnName = "CatalogDescription"
			});

			schema_array.Add(new VenturaSqlColumn("Instructions", typeof(string), true)
			{
				Updateable = true,
				ProviderType = 25,
				IsLong = true,
				XmlSchemaCollectionDatabase = "AdventureWorks2017",
				XmlSchemaCollectionOwningSchema = "Production",
				XmlSchemaCollectionName = "ManuInstructionsSchemaCollection",
				BaseSchemaName = "Production",
				BaseTableName = "ProductModel",
				BaseColumnName = "Instructions"
			});

			schema_array.Add(new VenturaSqlColumn("rowguid", typeof(Guid), false)
			{
				Updateable = true,
				ColumnSize = 16,
				ProviderType = 14,
				BaseSchemaName = "Production",
				BaseTableName = "ProductModel",
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
				BaseTableName = "ProductModel",
				BaseColumnName = "ModifiedDate"
			});

			((IResultsetBase)this).Schema = new VenturaSqlSchema(schema_array);
			((IResultsetBase)this).UpdateableTablename = "[Production].[ProductModel]";
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Production].[ProductModel]. PrimaryKey. NotReadonly. NotNull. IsIdentity. AutoIncrement.
		/// </summary>
		public int ProductModelID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ProductModelID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ProductModelID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductModel]. NotReadonly. NotNull.
		/// </summary>
		public string Name
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Name; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Name = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductModel]. NotReadonly. AllowNull.
		/// </summary>
		public string CatalogDescription
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.CatalogDescription; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.CatalogDescription = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductModel]. NotReadonly. AllowNull.
		/// </summary>
		public string Instructions
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Instructions; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Instructions = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductModel]. NotReadonly. NotNull.
		/// </summary>
		public Guid rowguid
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.rowguid; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.rowguid = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductModel]. NotReadonly. NotNull.
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
			this.InsertItem(index, new GetAll_Production_ProductModel_Record());
			this.CurrentRecordIndex = index;
		}

		public void Append(GetAll_Production_ProductModel_Record record)
		{
			int index = this.RecordCount;
			this.InsertItem(index, record);
			this.CurrentRecordIndex = index;
		}

		public GetAll_Production_ProductModel_Record NewRecord()
		{
			return new GetAll_Production_ProductModel_Record();
		}

		protected override GetAll_Production_ProductModel_Record InternalCreateExistingRecordObject(object[] columnvalues) => new GetAll_Production_ProductModel_Record(columnvalues);

		byte[] IRecordsetBase.Hash
		{
			get { return new byte[] { 224, 79, 243, 40, 22, 71, 211, 176, 249, 74, 132, 1, 241, 64, 171, 44 }; }
		}

		string IRecordsetBase.HashString
		{
			get { return "E04FF3281647D3B0F94A8401F140AB2C"; }
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

	}

	public sealed partial class GetAll_Production_ProductModel_Record : IRecordBase, INotifyPropertyChanged
	{
		private DataRecordStatus _recordstatus;
		private bool _started_with_dbvalues;

		private int _cur__ProductModelID; private int _ori__ProductModelID; private bool _mod__ProductModelID;
		private string _cur__Name; private string _ori__Name; private bool _mod__Name;
		private string _cur__CatalogDescription; private string _ori__CatalogDescription; private bool _mod__CatalogDescription;
		private string _cur__Instructions; private string _ori__Instructions; private bool _mod__Instructions;
		private Guid _cur__rowguid; private Guid _ori__rowguid; private bool _mod__rowguid;
		private DateTime _cur__ModifiedDate; private DateTime _ori__ModifiedDate; private bool _mod__ModifiedDate;


		public GetAll_Production_ProductModel_Record()
		{
			_cur__ProductModelID = 0;
			_cur__Name = "";
			_cur__CatalogDescription = null;
			_cur__Instructions = null;
			_cur__rowguid = Guid.Empty;
			_cur__ModifiedDate = new DateTime(1900, 1, 1);
			_started_with_dbvalues = false;
			_recordstatus = DataRecordStatus.New;
		}

		public GetAll_Production_ProductModel_Record(object[] columnvalues)
		{
			_cur__ProductModelID = (int)columnvalues[0];
			_cur__Name = (string)columnvalues[1];
			_cur__CatalogDescription = (string)columnvalues[2];
			_cur__Instructions = (string)columnvalues[3];
			_cur__rowguid = (Guid)columnvalues[4];
			_cur__ModifiedDate = (DateTime)columnvalues[5];
			_started_with_dbvalues = true;
			_recordstatus = DataRecordStatus.Existing;
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Production].[ProductModel]. PrimaryKey. NotReadonly. NotNull. IsIdentity. AutoIncrement.
		/// </summary>
		public int ProductModelID
		{
			get { return _cur__ProductModelID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ProductModelID = true;
				if (_cur__ProductModelID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ProductModelID == false) { _ori__ProductModelID = _cur__ProductModelID; _mod__ProductModelID = true; } // existing record and column is not modified
					else { if (value == _ori__ProductModelID) { _ori__ProductModelID = default(int); _mod__ProductModelID = false; } } // existing record and column is modified
				}
				_cur__ProductModelID = value; OnPropertyChanged("ProductModelID"); OnAfterPropertyChanged("ProductModelID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductModel]. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [Production].[ProductModel]. NotReadonly. AllowNull.
		/// </summary>
		public string CatalogDescription
		{
			get { return _cur__CatalogDescription; }
			set
			{
				if (_started_with_dbvalues == false) _mod__CatalogDescription = true;
				if (_cur__CatalogDescription == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__CatalogDescription == false) { _ori__CatalogDescription = _cur__CatalogDescription; _mod__CatalogDescription = true; } // existing record and column is not modified
					else { if (value == _ori__CatalogDescription) { _ori__CatalogDescription = default(string); _mod__CatalogDescription = false; } } // existing record and column is modified
				}
				_cur__CatalogDescription = value; OnPropertyChanged("CatalogDescription"); OnAfterPropertyChanged("CatalogDescription");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductModel]. NotReadonly. AllowNull.
		/// </summary>
		public string Instructions
		{
			get { return _cur__Instructions; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Instructions = true;
				if (_cur__Instructions == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Instructions == false) { _ori__Instructions = _cur__Instructions; _mod__Instructions = true; } // existing record and column is not modified
					else { if (value == _ori__Instructions) { _ori__Instructions = default(string); _mod__Instructions = false; } } // existing record and column is modified
				}
				_cur__Instructions = value; OnPropertyChanged("Instructions"); OnAfterPropertyChanged("Instructions");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductModel]. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [Production].[ProductModel]. NotReadonly. NotNull.
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
			if (column_name == "ProductModelID") return _mod__ProductModelID;
			if (column_name == "Name") return _mod__Name;
			if (column_name == "CatalogDescription") return _mod__CatalogDescription;
			if (column_name == "Instructions") return _mod__Instructions;
			if (column_name == "rowguid") return _mod__rowguid;
			if (column_name == "ModifiedDate") return _mod__ModifiedDate;
			throw new ArgumentOutOfRangeException(String.Format(VenturaSqlStrings.UNKNOWN_COLUMN_NAME, column_name));
		}

		public int ModifiedColumnCount()
		{
			int count = 0;
			if (_mod__ProductModelID == true) count++;
			if (_mod__Name == true) count++;
			if (_mod__CatalogDescription == true) count++;
			if (_mod__Instructions == true) count++;
			if (_mod__rowguid == true) count++;
			if (_mod__ModifiedDate == true) count++;
			return count;
		}

		public bool PendingChanges()
		{
			if (_recordstatus == DataRecordStatus.New || _recordstatus == DataRecordStatus.ExistingDelete) return true;
			int count = 0;
			if (_mod__Name == true) count++;
			if (_mod__CatalogDescription == true) count++;
			if (_mod__Instructions == true) count++;
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
				if (_cur__CatalogDescription != null) track_array.AppendDataValue(2, _cur__CatalogDescription);
				if (_cur__Instructions != null) track_array.AppendDataValue(3, _cur__Instructions);
				track_array.AppendDataValue(4, _cur__rowguid);
				track_array.AppendDataValue(5, _cur__ModifiedDate);
			}
			else if (_recordstatus == DataRecordStatus.Existing)
			{
				if (_mod__Name) track_array.AppendDataValue(1, _cur__Name);
				if (_mod__CatalogDescription) track_array.AppendDataValue(2, _cur__CatalogDescription);
				if (_mod__Instructions) track_array.AppendDataValue(3, _cur__Instructions);
				if (_mod__rowguid) track_array.AppendDataValue(4, _cur__rowguid);
				if (_mod__ModifiedDate) track_array.AppendDataValue(5, _cur__ModifiedDate);
				if (track_array.HasData == false) return;
			}

			if (_recordstatus == DataRecordStatus.Existing || _recordstatus == DataRecordStatus.ExistingDelete)
			{
				track_array.AppendPrikeyValue(0, (_mod__ProductModelID && _started_with_dbvalues) ? _ori__ProductModelID : _cur__ProductModelID);
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
				if (_mod__ProductModelID) _ori__ProductModelID = default(int);
				if (_mod__Name) _ori__Name = default(string);
				if (_mod__CatalogDescription) _ori__CatalogDescription = default(string);
				if (_mod__Instructions) _ori__Instructions = default(string);
				if (_mod__rowguid) _ori__rowguid = default(Guid);
				if (_mod__ModifiedDate) _ori__ModifiedDate = default(DateTime);
			}
			_mod__ProductModelID = false;
			_mod__Name = false;
			_mod__CatalogDescription = false;
			_mod__Instructions = false;
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
			_cur__ProductModelID = (int)value;
			OnPropertyChanged("ProductModelID");
			OnAfterPropertyChanged("ProductModelID");
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
	public partial class GetAll_Production_ProductModel_Record
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
