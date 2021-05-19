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

namespace AspNetCoreServer.VenturaAutoCreate
{
	/// <summary>
	/// The updateable table is [HumanResources].[JobCandidate]. Updateable table column information:
	/// • 4 out of 4 table columns are present in the resultset.
	/// • All primary key columns are present in the resultset: JobCandidateID.
	/// • Non-primary key columns present in the resultset: BusinessEntityID, Resume and ModifiedDate.
	/// Recordset item automatically created by VenturaSQL Studio.
	/// </summary>
	public partial class PriKey_HumanResources_JobCandidate_Recordset : ResultsetObservable<PriKey_HumanResources_JobCandidate_Recordset, PriKey_HumanResources_JobCandidate_Record>, IRecordsetBase
	{
		private IResultsetBase[] _resultsets;
		private string _sqlscript;
		private object[] _inputparametervalues;
		private InputParamHolder _inputparamholder;
		private VenturaSqlSchema _parameterschema;
		private int _rowlimit = 500;
		private const string CRLF = "\r\n";

		public PriKey_HumanResources_JobCandidate_Recordset()
		{
			_resultsets = new IResultsetBase[] { this };

			_sqlscript = @"SELECT [JobCandidateID],[BusinessEntityID],[Resume],[ModifiedDate]" + CRLF +
			             @"FROM [HumanResources].[JobCandidate]" + CRLF +
			             @"WHERE [JobCandidateID] = @JobCandidateID";

			_inputparametervalues = new object[1];
			_inputparamholder = new InputParamHolder(_inputparametervalues);

			ColumnArrayBuilder param_array = new ColumnArrayBuilder();

			param_array.AddParameterColumn("@JobCandidateID", typeof(int), true, false, DbType.Int32, null, null, null);

			_parameterschema = new VenturaSqlSchema(param_array);

			ColumnArrayBuilder schema_array = new ColumnArrayBuilder();

			schema_array.Add(new VenturaSqlColumn("JobCandidateID", typeof(int), false)
			{
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				IsKey = true,
				IsIdentity = true,
				IsAutoIncrement = true,
				BaseSchemaName = "HumanResources",
				BaseTableName = "JobCandidate",
				BaseColumnName = "JobCandidateID"
			});

			schema_array.Add(new VenturaSqlColumn("BusinessEntityID", typeof(int), true)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				BaseSchemaName = "HumanResources",
				BaseTableName = "JobCandidate",
				BaseColumnName = "BusinessEntityID"
			});

			schema_array.Add(new VenturaSqlColumn("Resume", typeof(string), true)
			{
				Updateable = true,
				ProviderType = 25,
				IsLong = true,
				XmlSchemaCollectionDatabase = "AdventureWorks2017",
				XmlSchemaCollectionOwningSchema = "HumanResources",
				XmlSchemaCollectionName = "HRResumeSchemaCollection",
				BaseSchemaName = "HumanResources",
				BaseTableName = "JobCandidate",
				BaseColumnName = "Resume"
			});

			schema_array.Add(new VenturaSqlColumn("ModifiedDate", typeof(DateTime), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 23,
				NumericScale = 3,
				ProviderType = 4,
				BaseSchemaName = "HumanResources",
				BaseTableName = "JobCandidate",
				BaseColumnName = "ModifiedDate"
			});

			((IResultsetBase)this).Schema = new VenturaSqlSchema(schema_array);
			((IResultsetBase)this).UpdateableTablename = "[HumanResources].[JobCandidate]";
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [HumanResources].[JobCandidate]. PrimaryKey. NotReadonly. NotNull. IsIdentity. AutoIncrement.
		/// </summary>
		public int JobCandidateID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.JobCandidateID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.JobCandidateID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[JobCandidate]. NotReadonly. AllowNull.
		/// </summary>
		public int? BusinessEntityID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.BusinessEntityID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.BusinessEntityID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[JobCandidate]. NotReadonly. AllowNull.
		/// </summary>
		public string Resume
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Resume; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Resume = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[JobCandidate]. NotReadonly. NotNull.
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
			this.InsertItem(index, new PriKey_HumanResources_JobCandidate_Record());
			this.CurrentRecordIndex = index;
		}

		public void Append(PriKey_HumanResources_JobCandidate_Record record)
		{
			int index = this.RecordCount;
			this.InsertItem(index, record);
			this.CurrentRecordIndex = index;
		}

		public PriKey_HumanResources_JobCandidate_Record NewRecord()
		{
			return new PriKey_HumanResources_JobCandidate_Record();
		}

		protected override PriKey_HumanResources_JobCandidate_Record InternalCreateExistingRecordObject(object[] columnvalues) => new PriKey_HumanResources_JobCandidate_Record(columnvalues);

		byte[] IRecordsetBase.Hash
		{
			get { return new byte[] { 61, 47, 6, 248, 61, 184, 159, 104, 144, 255, 107, 60, 2, 177, 175, 88 }; }
		}

		string IRecordsetBase.HashString
		{
			get { return "3D2F06F83DB89F6890FF6B3C02B1AF58"; }
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

		public void SetExecSqlParams(int? JobCandidateID)
		{
			_inputparametervalues[0] = JobCandidateID;
		}

		public void ExecSql(int? JobCandidateID)
		{
			_inputparametervalues[0] = JobCandidateID;
			Transactional.ExecSql(VenturaSqlConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public void ExecSql(Connector connector, int? JobCandidateID)
		{
			_inputparametervalues[0] = JobCandidateID;
			Transactional.ExecSql(connector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync(int? JobCandidateID)
		{
			_inputparametervalues[0] = JobCandidateID;
			await Transactional.ExecSqlAsync(VenturaSqlConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync(Connector connector, int? JobCandidateID)
		{
			_inputparametervalues[0] = JobCandidateID;
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

			public int? JobCandidateID
			{
				get { return (int?)_values[0]; }
				set { _values[0] = value; }
			}

		}

	}

	public sealed partial class PriKey_HumanResources_JobCandidate_Record : IRecordBase, INotifyPropertyChanged
	{
		private DataRecordStatus _recordstatus;
		private bool _started_with_dbvalues;

		private int _cur__JobCandidateID; private int _ori__JobCandidateID; private bool _mod__JobCandidateID;
		private int? _cur__BusinessEntityID; private int? _ori__BusinessEntityID; private bool _mod__BusinessEntityID;
		private string _cur__Resume; private string _ori__Resume; private bool _mod__Resume;
		private DateTime _cur__ModifiedDate; private DateTime _ori__ModifiedDate; private bool _mod__ModifiedDate;


		public PriKey_HumanResources_JobCandidate_Record()
		{
			_cur__JobCandidateID = 0;
			_cur__BusinessEntityID = null;
			_cur__Resume = null;
			_cur__ModifiedDate = new DateTime(1900, 1, 1);
			_started_with_dbvalues = false;
			_recordstatus = DataRecordStatus.New;
		}

		public PriKey_HumanResources_JobCandidate_Record(object[] columnvalues)
		{
			_cur__JobCandidateID = (int)columnvalues[0];
			_cur__BusinessEntityID = (int?)columnvalues[1];
			_cur__Resume = (string)columnvalues[2];
			_cur__ModifiedDate = (DateTime)columnvalues[3];
			_started_with_dbvalues = true;
			_recordstatus = DataRecordStatus.Existing;
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [HumanResources].[JobCandidate]. PrimaryKey. NotReadonly. NotNull. IsIdentity. AutoIncrement.
		/// </summary>
		public int JobCandidateID
		{
			get { return _cur__JobCandidateID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__JobCandidateID = true;
				if (_cur__JobCandidateID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__JobCandidateID == false) { _ori__JobCandidateID = _cur__JobCandidateID; _mod__JobCandidateID = true; } // existing record and column is not modified
					else { if (value == _ori__JobCandidateID) { _ori__JobCandidateID = default(int); _mod__JobCandidateID = false; } } // existing record and column is modified
				}
				_cur__JobCandidateID = value; OnPropertyChanged("JobCandidateID"); OnAfterPropertyChanged("JobCandidateID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[JobCandidate]. NotReadonly. AllowNull.
		/// </summary>
		public int? BusinessEntityID
		{
			get { return _cur__BusinessEntityID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__BusinessEntityID = true;
				if (_cur__BusinessEntityID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__BusinessEntityID == false) { _ori__BusinessEntityID = _cur__BusinessEntityID; _mod__BusinessEntityID = true; } // existing record and column is not modified
					else { if (value == _ori__BusinessEntityID) { _ori__BusinessEntityID = default(int?); _mod__BusinessEntityID = false; } } // existing record and column is modified
				}
				_cur__BusinessEntityID = value; OnPropertyChanged("BusinessEntityID"); OnAfterPropertyChanged("BusinessEntityID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[JobCandidate]. NotReadonly. AllowNull.
		/// </summary>
		public string Resume
		{
			get { return _cur__Resume; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Resume = true;
				if (_cur__Resume == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Resume == false) { _ori__Resume = _cur__Resume; _mod__Resume = true; } // existing record and column is not modified
					else { if (value == _ori__Resume) { _ori__Resume = default(string); _mod__Resume = false; } } // existing record and column is modified
				}
				_cur__Resume = value; OnPropertyChanged("Resume"); OnAfterPropertyChanged("Resume");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [HumanResources].[JobCandidate]. NotReadonly. NotNull.
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
			if (column_name == "JobCandidateID") return _mod__JobCandidateID;
			if (column_name == "BusinessEntityID") return _mod__BusinessEntityID;
			if (column_name == "Resume") return _mod__Resume;
			if (column_name == "ModifiedDate") return _mod__ModifiedDate;
			throw new ArgumentOutOfRangeException(String.Format(VenturaSqlStrings.UNKNOWN_COLUMN_NAME, column_name));
		}

		public int ModifiedColumnCount()
		{
			int count = 0;
			if (_mod__JobCandidateID == true) count++;
			if (_mod__BusinessEntityID == true) count++;
			if (_mod__Resume == true) count++;
			if (_mod__ModifiedDate == true) count++;
			return count;
		}

		public bool PendingChanges()
		{
			if (_recordstatus == DataRecordStatus.New || _recordstatus == DataRecordStatus.ExistingDelete) return true;
			int count = 0;
			if (_mod__BusinessEntityID == true) count++;
			if (_mod__Resume == true) count++;
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
				if (_cur__BusinessEntityID != null) track_array.AppendDataValue(1, _cur__BusinessEntityID);
				if (_cur__Resume != null) track_array.AppendDataValue(2, _cur__Resume);
				track_array.AppendDataValue(3, _cur__ModifiedDate);
			}
			else if (_recordstatus == DataRecordStatus.Existing)
			{
				if (_mod__BusinessEntityID) track_array.AppendDataValue(1, _cur__BusinessEntityID);
				if (_mod__Resume) track_array.AppendDataValue(2, _cur__Resume);
				if (_mod__ModifiedDate) track_array.AppendDataValue(3, _cur__ModifiedDate);
				if (track_array.HasData == false) return;
			}

			if (_recordstatus == DataRecordStatus.Existing || _recordstatus == DataRecordStatus.ExistingDelete)
			{
				track_array.AppendPrikeyValue(0, (_mod__JobCandidateID && _started_with_dbvalues) ? _ori__JobCandidateID : _cur__JobCandidateID);
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
				if (_mod__JobCandidateID) _ori__JobCandidateID = default(int);
				if (_mod__BusinessEntityID) _ori__BusinessEntityID = default(int?);
				if (_mod__Resume) _ori__Resume = default(string);
				if (_mod__ModifiedDate) _ori__ModifiedDate = default(DateTime);
			}
			_mod__JobCandidateID = false;
			_mod__BusinessEntityID = false;
			_mod__Resume = false;
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
			_cur__JobCandidateID = (int)value;
			OnPropertyChanged("JobCandidateID");
			OnAfterPropertyChanged("JobCandidateID");
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
	public partial class PriKey_HumanResources_JobCandidate_Record
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
