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
	/// The updateable table is [Production].[Culture]. Updateable table column information:
	/// • 3 out of 3 table columns are present in the resultset.
	/// • All primary key columns are present in the resultset: CultureID.
	/// • Non-primary key columns present in the resultset: Name and ModifiedDate.
	/// Recordset item automatically created by VenturaSQL Studio.
	/// </summary>
	public partial class PriKey_Production_Culture_Recordset : ResultsetObservable<PriKey_Production_Culture_Recordset, PriKey_Production_Culture_Record>, IRecordsetBase
	{
		private IResultsetBase[] _resultsets;
		private string _sqlscript;
		private object[] _inputparametervalues;
		private InputParamHolder _inputparamholder;
		private VenturaSqlSchema _parameterschema;
		private int _rowlimit = 500;
		private const string CRLF = "\r\n";

		public PriKey_Production_Culture_Recordset()
		{
			_resultsets = new IResultsetBase[] { this };

			_sqlscript = @"SELECT [CultureID],[Name],[ModifiedDate]" + CRLF +
			             @"FROM [Production].[Culture]" + CRLF +
			             @"WHERE [CultureID] = @CultureID";

			_inputparametervalues = new object[1];
			_inputparamholder = new InputParamHolder(_inputparametervalues);

			ColumnArrayBuilder param_array = new ColumnArrayBuilder();

			param_array.AddParameterColumn("@CultureID", typeof(string), true, false, DbType.String, null, null, null);

			_parameterschema = new VenturaSqlSchema(param_array);

			ColumnArrayBuilder schema_array = new ColumnArrayBuilder();

			schema_array.Add(new VenturaSqlColumn("CultureID", typeof(string), false)
			{
				Updateable = true,
				ColumnSize = 6,
				ProviderType = 10,
				IsKey = true,
				BaseSchemaName = "Production",
				BaseTableName = "Culture",
				BaseColumnName = "CultureID"
			});

			schema_array.Add(new VenturaSqlColumn("Name", typeof(string), false)
			{
				Updateable = true,
				ColumnSize = 50,
				ProviderType = 12,
				BaseSchemaName = "Production",
				BaseTableName = "Culture",
				BaseColumnName = "Name"
			});

			schema_array.Add(new VenturaSqlColumn("ModifiedDate", typeof(DateTime), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 23,
				NumericScale = 3,
				ProviderType = 4,
				BaseSchemaName = "Production",
				BaseTableName = "Culture",
				BaseColumnName = "ModifiedDate"
			});

			((IResultsetBase)this).Schema = new VenturaSqlSchema(schema_array);
			((IResultsetBase)this).UpdateableTablename = "[Production].[Culture]";
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Culture]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public string CultureID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.CultureID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.CultureID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Culture]. NotReadonly. NotNull.
		/// </summary>
		public string Name
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Name; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Name = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Culture]. NotReadonly. NotNull.
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
			this.InsertItem(index, new PriKey_Production_Culture_Record());
			this.CurrentRecordIndex = index;
		}

		public void Append(PriKey_Production_Culture_Record record)
		{
			int index = this.RecordCount;
			this.InsertItem(index, record);
			this.CurrentRecordIndex = index;
		}

		public PriKey_Production_Culture_Record NewRecord()
		{
			return new PriKey_Production_Culture_Record();
		}

		protected override PriKey_Production_Culture_Record InternalCreateExistingRecordObject(object[] columnvalues) => new PriKey_Production_Culture_Record(columnvalues);

		byte[] IRecordsetBase.Hash
		{
			get { return new byte[] { 177, 145, 32, 81, 220, 64, 63, 84, 83, 168, 150, 230, 116, 205, 136, 245 }; }
		}

		string IRecordsetBase.HashString
		{
			get { return "B1912051DC403F5453A896E674CD88F5"; }
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

		public void SetExecSqlParams(string CultureID)
		{
			_inputparametervalues[0] = CultureID;
		}

		public void ExecSql(string CultureID)
		{
			_inputparametervalues[0] = CultureID;
			Transactional.ExecSql(VenturaSqlConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public void ExecSql(Connector connector, string CultureID)
		{
			_inputparametervalues[0] = CultureID;
			Transactional.ExecSql(connector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync(string CultureID)
		{
			_inputparametervalues[0] = CultureID;
			await Transactional.ExecSqlAsync(VenturaSqlConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync(Connector connector, string CultureID)
		{
			_inputparametervalues[0] = CultureID;
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

			public string CultureID
			{
				get { return (string)_values[0]; }
				set { _values[0] = value; }
			}

		}

	}

	public sealed partial class PriKey_Production_Culture_Record : IRecordBase, INotifyPropertyChanged
	{
		private DataRecordStatus _recordstatus;
		private bool _started_with_dbvalues;

		private string _cur__CultureID; private string _ori__CultureID; private bool _mod__CultureID;
		private string _cur__Name; private string _ori__Name; private bool _mod__Name;
		private DateTime _cur__ModifiedDate; private DateTime _ori__ModifiedDate; private bool _mod__ModifiedDate;


		public PriKey_Production_Culture_Record()
		{
			_cur__CultureID = "";
			_cur__Name = "";
			_cur__ModifiedDate = new DateTime(1900, 1, 1);
			_started_with_dbvalues = false;
			_recordstatus = DataRecordStatus.New;
		}

		public PriKey_Production_Culture_Record(object[] columnvalues)
		{
			_cur__CultureID = (string)columnvalues[0];
			_cur__Name = (string)columnvalues[1];
			_cur__ModifiedDate = (DateTime)columnvalues[2];
			_started_with_dbvalues = true;
			_recordstatus = DataRecordStatus.Existing;
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Culture]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public string CultureID
		{
			get { return _cur__CultureID; }
			set
			{
				if (value == null) throw new ArgumentNullException("CultureID", VenturaSqlStrings.SET_NULL_MSG);
				if (_started_with_dbvalues == false) _mod__CultureID = true;
				if (_cur__CultureID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__CultureID == false) { _ori__CultureID = _cur__CultureID; _mod__CultureID = true; } // existing record and column is not modified
					else { if (value == _ori__CultureID) { _ori__CultureID = default(string); _mod__CultureID = false; } } // existing record and column is modified
				}
				_cur__CultureID = value; OnPropertyChanged("CultureID"); OnAfterPropertyChanged("CultureID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Culture]. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [Production].[Culture]. NotReadonly. NotNull.
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
			if (column_name == "CultureID") return _mod__CultureID;
			if (column_name == "Name") return _mod__Name;
			if (column_name == "ModifiedDate") return _mod__ModifiedDate;
			throw new ArgumentOutOfRangeException(String.Format(VenturaSqlStrings.UNKNOWN_COLUMN_NAME, column_name));
		}

		public int ModifiedColumnCount()
		{
			int count = 0;
			if (_mod__CultureID == true) count++;
			if (_mod__Name == true) count++;
			if (_mod__ModifiedDate == true) count++;
			return count;
		}

		public bool PendingChanges()
		{
			if (_recordstatus == DataRecordStatus.New || _recordstatus == DataRecordStatus.ExistingDelete) return true;
			int count = 0;
			if (_started_with_dbvalues)
			{
				if (_mod__CultureID) count++;
			}
			if (_mod__Name == true) count++;
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
			if (_started_with_dbvalues) return;
			if (_recordstatus == DataRecordStatus.Existing) return;
			if (_mod__CultureID == false) throw new Exception(string.Format(VenturaSqlStrings.VALUE_NOT_SET_MSG, record_index_to_display, "CultureID"));
		}

		void IRecordBase.WriteChangesToTrackArray(TrackArray track_array)
		{
			if (_recordstatus == DataRecordStatus.New)
			{
				track_array.AppendDataValue(0, _cur__CultureID);
				track_array.AppendDataValue(1, _cur__Name);
				track_array.AppendDataValue(2, _cur__ModifiedDate);
			}
			else if (_recordstatus == DataRecordStatus.Existing)
			{
				if (_started_with_dbvalues)
				{
					if (_mod__CultureID) track_array.AppendDataValue(0, _cur__CultureID);
				}
				if (_mod__Name) track_array.AppendDataValue(1, _cur__Name);
				if (_mod__ModifiedDate) track_array.AppendDataValue(2, _cur__ModifiedDate);
				if (track_array.HasData == false) return;
			}

			if (_recordstatus == DataRecordStatus.Existing || _recordstatus == DataRecordStatus.ExistingDelete)
			{
				track_array.AppendPrikeyValue(0, (_mod__CultureID && _started_with_dbvalues) ? _ori__CultureID : _cur__CultureID);
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
				if (_mod__CultureID) _ori__CultureID = default(string);
				if (_mod__Name) _ori__Name = default(string);
				if (_mod__ModifiedDate) _ori__ModifiedDate = default(DateTime);
			}
			_mod__CultureID = false;
			_mod__Name = false;
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
	public partial class PriKey_Production_Culture_Record
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
