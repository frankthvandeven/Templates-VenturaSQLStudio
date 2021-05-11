/*
	Project file: "C:\Active\VenturaSQL\BuildSystem\Templates\ProgrammingPattern\ProgrammingPattern.venproj"
	Target platform: NETStandard
	Generator version: 4.0.126
	Generated on: Tuesday, 11 May 2021 at 12:04:14
	At the bottom of this file you find a template for extending Recordsets with calculated columns for XAML data binding.
*/
using VenturaSQL;
using System;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel;

namespace ProgrammingPattern.VenturaAutoCreate
{
	/// <summary>
	/// The updateable table is [CountryCodes]. Updateable table column information:
	/// • 2 out of 2 table columns are present in the resultset.
	/// • All primary key columns are present in the resultset: CountryCodeID.
	/// • Non-primary key column present in the resultset: Name.
	/// Recordset item automatically created by VenturaSQL Studio.
	/// </summary>
	public partial class GetAll_CountryCodes_Recordset : ResultsetObservable<GetAll_CountryCodes_Recordset, GetAll_CountryCodes_Record>, IRecordsetBase
	{
		private IResultsetBase[] _resultsets;
		private string _sqlscript;
		private int _rowlimit = 500;
		private const string CRLF = "\r\n";

		public GetAll_CountryCodes_Recordset()
		{
			_resultsets = new IResultsetBase[] { this };

			_sqlscript = @"SELECT [CountryCodeID],[Name]" + CRLF +
			             @"FROM [CountryCodes]";

			ColumnArrayBuilder schema_array = new ColumnArrayBuilder();

			schema_array.Add(new VenturaSqlColumn("CountryCodeID", typeof(string), false)
			{
				Updateable = true,
				ProviderType = 16,
				IsUnique = true,
				IsKey = true,
				BaseCatalogName = "main",
				BaseTableName = "CountryCodes",
				BaseColumnName = "CountryCodeID"
			});

			schema_array.Add(new VenturaSqlColumn("Name", typeof(string), false)
			{
				Updateable = true,
				ProviderType = 16,
				BaseCatalogName = "main",
				BaseTableName = "CountryCodes",
				BaseColumnName = "Name"
			});

			((IResultsetBase)this).Schema = new VenturaSqlSchema(schema_array);
			((IResultsetBase)this).UpdateableTablename = "[CountryCodes]";
		}

		/// <summary>
		/// Database Column Updateable. Table [CountryCodes]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public string CountryCodeID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.CountryCodeID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.CountryCodeID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [CountryCodes]. NotReadonly. NotNull.
		/// </summary>
		public string Name
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Name; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Name = value; }
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
			this.InsertItem(index, new GetAll_CountryCodes_Record());
			this.CurrentRecordIndex = index;
		}

		public void Append(GetAll_CountryCodes_Record record)
		{
			int index = this.RecordCount;
			this.InsertItem(index, record);
			this.CurrentRecordIndex = index;
		}

		public GetAll_CountryCodes_Record NewRecord()
		{
			return new GetAll_CountryCodes_Record();
		}

		protected override GetAll_CountryCodes_Record InternalCreateExistingRecordObject(object[] columnvalues) => new GetAll_CountryCodes_Record(columnvalues);

		byte[] IRecordsetBase.Hash
		{
			get { return new byte[] { 142, 248, 101, 207, 185, 26, 153, 14, 78, 178, 39, 80, 234, 114, 51, 70 }; }
		}

		string IRecordsetBase.HashString
		{
			get { return "8EF865CFB91A990E4EB22750EA723346"; }
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
			get { return new DateTime(2021, 5, 11, 12, 4, 14); } // Tuesday, 11 May 2021 at 12:04:14
		}

		string IRecordsetBase.GeneratorProviderInvariantName
		{
			get { return "System.Data.SQLite"; }
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

	public sealed partial class GetAll_CountryCodes_Record : IRecordBase, INotifyPropertyChanged
	{
		private DataRecordStatus _recordstatus;
		private bool _started_with_dbvalues;

		private string _cur__CountryCodeID; private string _ori__CountryCodeID; private bool _mod__CountryCodeID;
		private string _cur__Name; private string _ori__Name; private bool _mod__Name;


		public GetAll_CountryCodes_Record()
		{
			_cur__CountryCodeID = "";
			_cur__Name = "";
			_started_with_dbvalues = false;
			_recordstatus = DataRecordStatus.New;
		}

		public GetAll_CountryCodes_Record(object[] columnvalues)
		{
			_cur__CountryCodeID = (string)columnvalues[0];
			_cur__Name = (string)columnvalues[1];
			_started_with_dbvalues = true;
			_recordstatus = DataRecordStatus.Existing;
		}

		/// <summary>
		/// Database Column Updateable. Table [CountryCodes]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public string CountryCodeID
		{
			get { return _cur__CountryCodeID; }
			set
			{
				if (value == null) throw new ArgumentNullException("CountryCodeID", VenturaSqlStrings.SET_NULL_MSG);
				if (_started_with_dbvalues == false) _mod__CountryCodeID = true;
				if (_cur__CountryCodeID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__CountryCodeID == false) { _ori__CountryCodeID = _cur__CountryCodeID; _mod__CountryCodeID = true; } // existing record and column is not modified
					else { if (value == _ori__CountryCodeID) { _ori__CountryCodeID = default(string); _mod__CountryCodeID = false; } } // existing record and column is modified
				}
				_cur__CountryCodeID = value; OnPropertyChanged("CountryCodeID"); OnAfterPropertyChanged("CountryCodeID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [CountryCodes]. NotReadonly. NotNull.
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

		public bool IsModified(string column_name)
		{
			if (column_name == "CountryCodeID") return _mod__CountryCodeID;
			if (column_name == "Name") return _mod__Name;
			throw new ArgumentOutOfRangeException(String.Format(VenturaSqlStrings.UNKNOWN_COLUMN_NAME, column_name));
		}

		public int ModifiedColumnCount()
		{
			int count = 0;
			if (_mod__CountryCodeID == true) count++;
			if (_mod__Name == true) count++;
			return count;
		}

		public bool PendingChanges()
		{
			if (_recordstatus == DataRecordStatus.New || _recordstatus == DataRecordStatus.ExistingDelete) return true;
			int count = 0;
			if (_started_with_dbvalues)
			{
				if (_mod__CountryCodeID) count++;
			}
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
			if (_started_with_dbvalues) return;
			if (_recordstatus == DataRecordStatus.Existing) return;
			if (_mod__CountryCodeID == false) throw new Exception(string.Format(VenturaSqlStrings.VALUE_NOT_SET_MSG, record_index_to_display, "CountryCodeID"));
		}

		void IRecordBase.WriteChangesToTrackArray(TrackArray track_array)
		{
			if (_recordstatus == DataRecordStatus.New)
			{
				track_array.AppendDataValue(0, _cur__CountryCodeID);
				track_array.AppendDataValue(1, _cur__Name);
			}
			else if (_recordstatus == DataRecordStatus.Existing)
			{
				if (_started_with_dbvalues)
				{
					if (_mod__CountryCodeID) track_array.AppendDataValue(0, _cur__CountryCodeID);
				}
				if (_mod__Name) track_array.AppendDataValue(1, _cur__Name);
				if (track_array.HasData == false) return;
			}

			if (_recordstatus == DataRecordStatus.Existing || _recordstatus == DataRecordStatus.ExistingDelete)
			{
				track_array.AppendPrikeyValue(0, (_mod__CountryCodeID && _started_with_dbvalues) ? _ori__CountryCodeID : _cur__CountryCodeID);
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
				if (_mod__CountryCodeID) _ori__CountryCodeID = default(string);
				if (_mod__Name) _ori__Name = default(string);
			}
			_mod__CountryCodeID = false;
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
// How to guide: https://docs.sysdev.nl/CalculatedColumns.html

/*
namespace ProgrammingPattern.VenturaAutoCreate
{
	public partial class GetAll_CountryCodes_Record
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
