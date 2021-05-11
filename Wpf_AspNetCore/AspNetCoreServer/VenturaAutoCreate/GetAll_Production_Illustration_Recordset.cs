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

namespace AspNetCoreServer.VenturaAutoCreate
{
	/// <summary>
	/// The updateable table is [Production].[Illustration]. Updateable table column information:
	/// • 3 out of 3 table columns are present in the resultset.
	/// • All primary key columns are present in the resultset: IllustrationID.
	/// • Non-primary key columns present in the resultset: Diagram and ModifiedDate.
	/// Recordset item automatically created by VenturaSQL Studio.
	/// </summary>
	public partial class GetAll_Production_Illustration_Recordset : ResultsetObservable<GetAll_Production_Illustration_Recordset, GetAll_Production_Illustration_Record>, IRecordsetBase
	{
		private IResultsetBase[] _resultsets;
		private string _sqlscript;
		private int _rowlimit = 500;
		private const string CRLF = "\r\n";

		public GetAll_Production_Illustration_Recordset()
		{
			_resultsets = new IResultsetBase[] { this };

			_sqlscript = @"SELECT [IllustrationID],[Diagram],[ModifiedDate]" + CRLF +
			             @"FROM [Production].[Illustration]";

			ColumnArrayBuilder schema_array = new ColumnArrayBuilder();

			schema_array.Add(new VenturaSqlColumn("IllustrationID", typeof(int), false)
			{
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				IsKey = true,
				IsIdentity = true,
				IsAutoIncrement = true,
				BaseSchemaName = "Production",
				BaseTableName = "Illustration",
				BaseColumnName = "IllustrationID"
			});

			schema_array.Add(new VenturaSqlColumn("Diagram", typeof(string), true)
			{
				Updateable = true,
				ProviderType = 25,
				IsLong = true,
				BaseSchemaName = "Production",
				BaseTableName = "Illustration",
				BaseColumnName = "Diagram"
			});

			schema_array.Add(new VenturaSqlColumn("ModifiedDate", typeof(DateTime), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 23,
				NumericScale = 3,
				ProviderType = 4,
				BaseSchemaName = "Production",
				BaseTableName = "Illustration",
				BaseColumnName = "ModifiedDate"
			});

			((IResultsetBase)this).Schema = new VenturaSqlSchema(schema_array);
			((IResultsetBase)this).UpdateableTablename = "[Production].[Illustration]";
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Production].[Illustration]. PrimaryKey. NotReadonly. NotNull. IsIdentity. AutoIncrement.
		/// </summary>
		public int IllustrationID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.IllustrationID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.IllustrationID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Illustration]. NotReadonly. AllowNull.
		/// </summary>
		public string Diagram
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Diagram; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Diagram = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Illustration]. NotReadonly. NotNull.
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
			this.InsertItem(index, new GetAll_Production_Illustration_Record());
			this.CurrentRecordIndex = index;
		}

		public void Append(GetAll_Production_Illustration_Record record)
		{
			int index = this.RecordCount;
			this.InsertItem(index, record);
			this.CurrentRecordIndex = index;
		}

		public GetAll_Production_Illustration_Record NewRecord()
		{
			return new GetAll_Production_Illustration_Record();
		}

		protected override GetAll_Production_Illustration_Record InternalCreateExistingRecordObject(object[] columnvalues) => new GetAll_Production_Illustration_Record(columnvalues);

		byte[] IRecordsetBase.Hash
		{
			get { return new byte[] { 39, 65, 65, 61, 126, 94, 144, 220, 91, 249, 165, 205, 12, 14, 95, 11 }; }
		}

		string IRecordsetBase.HashString
		{
			get { return "2741413D7E5E90DC5BF9A5CD0C0E5F0B"; }
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

	public sealed partial class GetAll_Production_Illustration_Record : IRecordBase, INotifyPropertyChanged
	{
		private DataRecordStatus _recordstatus;
		private bool _started_with_dbvalues;

		private int _cur__IllustrationID; private int _ori__IllustrationID; private bool _mod__IllustrationID;
		private string _cur__Diagram; private string _ori__Diagram; private bool _mod__Diagram;
		private DateTime _cur__ModifiedDate; private DateTime _ori__ModifiedDate; private bool _mod__ModifiedDate;


		public GetAll_Production_Illustration_Record()
		{
			_cur__IllustrationID = 0;
			_cur__Diagram = null;
			_cur__ModifiedDate = new DateTime(1900, 1, 1);
			_started_with_dbvalues = false;
			_recordstatus = DataRecordStatus.New;
		}

		public GetAll_Production_Illustration_Record(object[] columnvalues)
		{
			_cur__IllustrationID = (int)columnvalues[0];
			_cur__Diagram = (string)columnvalues[1];
			_cur__ModifiedDate = (DateTime)columnvalues[2];
			_started_with_dbvalues = true;
			_recordstatus = DataRecordStatus.Existing;
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Production].[Illustration]. PrimaryKey. NotReadonly. NotNull. IsIdentity. AutoIncrement.
		/// </summary>
		public int IllustrationID
		{
			get { return _cur__IllustrationID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__IllustrationID = true;
				if (_cur__IllustrationID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__IllustrationID == false) { _ori__IllustrationID = _cur__IllustrationID; _mod__IllustrationID = true; } // existing record and column is not modified
					else { if (value == _ori__IllustrationID) { _ori__IllustrationID = default(int); _mod__IllustrationID = false; } } // existing record and column is modified
				}
				_cur__IllustrationID = value; OnPropertyChanged("IllustrationID"); OnAfterPropertyChanged("IllustrationID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Illustration]. NotReadonly. AllowNull.
		/// </summary>
		public string Diagram
		{
			get { return _cur__Diagram; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Diagram = true;
				if (_cur__Diagram == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Diagram == false) { _ori__Diagram = _cur__Diagram; _mod__Diagram = true; } // existing record and column is not modified
					else { if (value == _ori__Diagram) { _ori__Diagram = default(string); _mod__Diagram = false; } } // existing record and column is modified
				}
				_cur__Diagram = value; OnPropertyChanged("Diagram"); OnAfterPropertyChanged("Diagram");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Illustration]. NotReadonly. NotNull.
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
			if (column_name == "IllustrationID") return _mod__IllustrationID;
			if (column_name == "Diagram") return _mod__Diagram;
			if (column_name == "ModifiedDate") return _mod__ModifiedDate;
			throw new ArgumentOutOfRangeException(String.Format(VenturaSqlStrings.UNKNOWN_COLUMN_NAME, column_name));
		}

		public int ModifiedColumnCount()
		{
			int count = 0;
			if (_mod__IllustrationID == true) count++;
			if (_mod__Diagram == true) count++;
			if (_mod__ModifiedDate == true) count++;
			return count;
		}

		public bool PendingChanges()
		{
			if (_recordstatus == DataRecordStatus.New || _recordstatus == DataRecordStatus.ExistingDelete) return true;
			int count = 0;
			if (_mod__Diagram == true) count++;
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
				if (_cur__Diagram != null) track_array.AppendDataValue(1, _cur__Diagram);
				track_array.AppendDataValue(2, _cur__ModifiedDate);
			}
			else if (_recordstatus == DataRecordStatus.Existing)
			{
				if (_mod__Diagram) track_array.AppendDataValue(1, _cur__Diagram);
				if (_mod__ModifiedDate) track_array.AppendDataValue(2, _cur__ModifiedDate);
				if (track_array.HasData == false) return;
			}

			if (_recordstatus == DataRecordStatus.Existing || _recordstatus == DataRecordStatus.ExistingDelete)
			{
				track_array.AppendPrikeyValue(0, (_mod__IllustrationID && _started_with_dbvalues) ? _ori__IllustrationID : _cur__IllustrationID);
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
				if (_mod__IllustrationID) _ori__IllustrationID = default(int);
				if (_mod__Diagram) _ori__Diagram = default(string);
				if (_mod__ModifiedDate) _ori__ModifiedDate = default(DateTime);
			}
			_mod__IllustrationID = false;
			_mod__Diagram = false;
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
			_cur__IllustrationID = (int)value;
			OnPropertyChanged("IllustrationID");
			OnAfterPropertyChanged("IllustrationID");
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
	public partial class GetAll_Production_Illustration_Record
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
