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
	/// The updateable table is [Exchange].[Calendar_RequiredAttendees]. Updateable table column information:
	/// • 3 out of 3 table columns are present in the resultset.
	/// • All primary key columns are present in the resultset: EmailAddress.
	/// • Non-primary key columns present in the resultset: ItemId and Name.
	/// Recordset item automatically created by Ventura SQL Studio.
	/// </summary>
	public partial class GetAll_Calendar_RequiredAttendees_Recordset : ResultsetObservable<GetAll_Calendar_RequiredAttendees_Recordset, GetAll_Calendar_RequiredAttendees_Record>, IRecordsetBase
	{
		private IResultsetBase[] _resultsets;
		private string _sqlscript;
		private int _rowlimit = 500;
		private const string CRLF = "\r\n";

		public GetAll_Calendar_RequiredAttendees_Recordset()
		{
			_resultsets = new IResultsetBase[] { this };

			_sqlscript = @"SELECT [EmailAddress],[ItemId],[Name]" + CRLF +
			             @"FROM [Exchange].[Calendar_RequiredAttendees]";

			ColumnArrayBuilder schema_array = new ColumnArrayBuilder();

			schema_array.Add(new VenturaColumn("EmailAddress", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 255,
				NumericScale = 0,
				ProviderType = 16,
				IsUnique = true,
				IsKey = true,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Calendar_RequiredAttendees",
				BaseColumnName = "EmailAddress"
			});

			schema_array.Add(new VenturaColumn("ItemId", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Calendar_RequiredAttendees",
				BaseColumnName = "ItemId"
			});

			schema_array.Add(new VenturaColumn("Name", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 2000,
				NumericScale = 0,
				ProviderType = 16,
				BaseCatalogName = "CData",
				BaseSchemaName = "Exchange",
				BaseTableName = "Calendar_RequiredAttendees",
				BaseColumnName = "Name"
			});

			((IResultsetBase)this).Schema = new VenturaSchema(schema_array);
			((IResultsetBase)this).UpdateableTablename = "[Exchange].[Calendar_RequiredAttendees]";
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar_RequiredAttendees]. PrimaryKey. NotReadonly. AllowNull.
		/// EmailAddress
		/// </summary>
		public string EmailAddress
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.EmailAddress; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.EmailAddress = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar_RequiredAttendees]. NotReadonly. AllowNull.
		/// ItemId
		/// </summary>
		public string ItemId
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ItemId; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ItemId = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar_RequiredAttendees]. NotReadonly. AllowNull.
		/// Name
		/// </summary>
		public string Name
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Name; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Name = value; }
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
			this.InsertItem(index, new GetAll_Calendar_RequiredAttendees_Record());
			this.CurrentRecordIndex = index;
		}

		public void Append(GetAll_Calendar_RequiredAttendees_Record record)
		{
			int index = this.RecordCount;
			this.InsertItem(index, record);
			this.CurrentRecordIndex = index;
		}

		public GetAll_Calendar_RequiredAttendees_Record NewRecord()
		{
			return new GetAll_Calendar_RequiredAttendees_Record();
		}

		protected override GetAll_Calendar_RequiredAttendees_Record InternalCreateExistingRecordObject(object[] columnvalues) => new GetAll_Calendar_RequiredAttendees_Record(columnvalues);

		byte[] IRecordsetBase.Hash
		{
			get { return new byte[] { 175, 184, 138, 141, 128, 188, 93, 132, 164, 169, 178, 26, 237, 144, 171, 33 }; }
		}

		string IRecordsetBase.HashString
		{
			get { return "AFB88A8D80BC5D84A4A9B21AED90AB21"; }
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

	public sealed partial class GetAll_Calendar_RequiredAttendees_Record : IRecordBase, INotifyPropertyChanged
	{
		private DataRecordStatus _recordstatus;
		private bool _started_with_dbvalues;

		private string _cur__EmailAddress; private string _ori__EmailAddress; private bool _mod__EmailAddress;
		private string _cur__ItemId; private string _ori__ItemId; private bool _mod__ItemId;
		private string _cur__Name; private string _ori__Name; private bool _mod__Name;


		public GetAll_Calendar_RequiredAttendees_Record()
		{
			_cur__EmailAddress = null;
			_cur__ItemId = null;
			_cur__Name = null;
			_started_with_dbvalues = false;
			_recordstatus = DataRecordStatus.New;
		}

		public GetAll_Calendar_RequiredAttendees_Record(object[] columnvalues)
		{
			_cur__EmailAddress = (string)columnvalues[0];
			_cur__ItemId = (string)columnvalues[1];
			_cur__Name = (string)columnvalues[2];
			_started_with_dbvalues = true;
			_recordstatus = DataRecordStatus.Existing;
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar_RequiredAttendees]. PrimaryKey. NotReadonly. AllowNull.
		/// EmailAddress
		/// </summary>
		public string EmailAddress
		{
			get { return _cur__EmailAddress; }
			set
			{
				if (_started_with_dbvalues == false) _mod__EmailAddress = true;
				if (_cur__EmailAddress == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__EmailAddress == false) { _ori__EmailAddress = _cur__EmailAddress; _mod__EmailAddress = true; } // existing record and column is not modified
					else { if (value == _ori__EmailAddress) { _ori__EmailAddress = default(string); _mod__EmailAddress = false; } } // existing record and column is modified
				}
				_cur__EmailAddress = value; OnPropertyChanged("EmailAddress"); OnAfterPropertyChanged("EmailAddress");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Exchange].[Calendar_RequiredAttendees]. NotReadonly. AllowNull.
		/// ItemId
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
		/// Database Column Updateable. Table [Exchange].[Calendar_RequiredAttendees]. NotReadonly. AllowNull.
		/// Name
		/// </summary>
		public string Name
		{
			get { return _cur__Name; }
			set
			{
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

		public bool IsModified(string column_name)
		{
			if (column_name == "EmailAddress") return _mod__EmailAddress;
			if (column_name == "ItemId") return _mod__ItemId;
			if (column_name == "Name") return _mod__Name;
			throw new ArgumentOutOfRangeException(String.Format(VenturaStrings.UNKNOWN_COLUMN_NAME, column_name));
		}

		public int ModifiedColumnCount()
		{
			int count = 0;
			if (_mod__EmailAddress == true) count++;
			if (_mod__ItemId == true) count++;
			if (_mod__Name == true) count++;
			return count;
		}

		public bool PendingChanges()
		{
			if (_recordstatus == DataRecordStatus.New || _recordstatus == DataRecordStatus.ExistingDelete) return true;
			int count = 0;
			if (_started_with_dbvalues)
			{
				if (_mod__EmailAddress) count++;
			}
			if (_mod__ItemId == true) count++;
			if (_mod__Name == true) count++;
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
				if (_cur__EmailAddress != null) track_array.AppendDataValue(0, _cur__EmailAddress);
				if (_cur__ItemId != null) track_array.AppendDataValue(1, _cur__ItemId);
				if (_cur__Name != null) track_array.AppendDataValue(2, _cur__Name);
			}
			else if (_recordstatus == DataRecordStatus.Existing)
			{
				if (_started_with_dbvalues)
				{
					if (_mod__EmailAddress) track_array.AppendDataValue(0, _cur__EmailAddress);
				}
				if (_mod__ItemId) track_array.AppendDataValue(1, _cur__ItemId);
				if (_mod__Name) track_array.AppendDataValue(2, _cur__Name);
				if (track_array.HasData == false) return;
			}

			if (_recordstatus == DataRecordStatus.Existing || _recordstatus == DataRecordStatus.ExistingDelete)
			{
				track_array.AppendPrikeyValue(0, (_mod__EmailAddress && _started_with_dbvalues) ? _ori__EmailAddress : _cur__EmailAddress);
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
				if (_mod__EmailAddress) _ori__EmailAddress = default(string);
				if (_mod__ItemId) _ori__ItemId = default(string);
				if (_mod__Name) _ori__Name = default(string);
			}
			_mod__EmailAddress = false;
			_mod__ItemId = false;
			_mod__Name = false;
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
	public partial class GetAll_Calendar_RequiredAttendees_Record
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
