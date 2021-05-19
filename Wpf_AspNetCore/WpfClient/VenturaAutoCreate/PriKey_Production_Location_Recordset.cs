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
	/// The updateable table is [Production].[Location]. Updateable table column information:
	/// • 5 out of 5 table columns are present in the resultset.
	/// • All primary key columns are present in the resultset: LocationID.
	/// • Non-primary key columns present in the resultset: Name, CostRate, Availability and ModifiedDate.
	/// Recordset item automatically created by VenturaSQL Studio.
	/// </summary>
	public partial class PriKey_Production_Location_Recordset : ResultsetObservable<PriKey_Production_Location_Recordset, PriKey_Production_Location_Record>, IRecordsetBase
	{
		private IResultsetBase[] _resultsets;
		private string _sqlscript;
		private object[] _inputparametervalues;
		private InputParamHolder _inputparamholder;
		private VenturaSqlSchema _parameterschema;
		private int _rowlimit = 500;
		private const string CRLF = "\r\n";

		public PriKey_Production_Location_Recordset()
		{
			_resultsets = new IResultsetBase[] { this };

			_sqlscript = @"SELECT [LocationID],[Name],[CostRate],[Availability],[ModifiedDate]" + CRLF +
			             @"FROM [Production].[Location]" + CRLF +
			             @"WHERE [LocationID] = @LocationID";

			_inputparametervalues = new object[1];
			_inputparamholder = new InputParamHolder(_inputparametervalues);

			ColumnArrayBuilder param_array = new ColumnArrayBuilder();

			param_array.AddParameterColumn("@LocationID", typeof(short), true, false, DbType.Int16, null, null, null);

			_parameterschema = new VenturaSqlSchema(param_array);

			ColumnArrayBuilder schema_array = new ColumnArrayBuilder();

			schema_array.Add(new VenturaSqlColumn("LocationID", typeof(short), false)
			{
				ColumnSize = 2,
				NumericPrecision = 5,
				ProviderType = 16,
				IsKey = true,
				IsIdentity = true,
				IsAutoIncrement = true,
				BaseSchemaName = "Production",
				BaseTableName = "Location",
				BaseColumnName = "LocationID"
			});

			schema_array.Add(new VenturaSqlColumn("Name", typeof(string), false)
			{
				Updateable = true,
				ColumnSize = 50,
				ProviderType = 12,
				BaseSchemaName = "Production",
				BaseTableName = "Location",
				BaseColumnName = "Name"
			});

			schema_array.Add(new VenturaSqlColumn("CostRate", typeof(decimal), false)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 17,
				BaseSchemaName = "Production",
				BaseTableName = "Location",
				BaseColumnName = "CostRate"
			});

			schema_array.Add(new VenturaSqlColumn("Availability", typeof(decimal), false)
			{
				Updateable = true,
				ColumnSize = 17,
				NumericPrecision = 8,
				NumericScale = 2,
				ProviderType = 5,
				BaseSchemaName = "Production",
				BaseTableName = "Location",
				BaseColumnName = "Availability"
			});

			schema_array.Add(new VenturaSqlColumn("ModifiedDate", typeof(DateTime), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 23,
				NumericScale = 3,
				ProviderType = 4,
				BaseSchemaName = "Production",
				BaseTableName = "Location",
				BaseColumnName = "ModifiedDate"
			});

			((IResultsetBase)this).Schema = new VenturaSqlSchema(schema_array);
			((IResultsetBase)this).UpdateableTablename = "[Production].[Location]";
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Production].[Location]. PrimaryKey. NotReadonly. NotNull. IsIdentity. AutoIncrement.
		/// </summary>
		public short LocationID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.LocationID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.LocationID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Location]. NotReadonly. NotNull.
		/// </summary>
		public string Name
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Name; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Name = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Location]. NotReadonly. NotNull.
		/// </summary>
		public decimal CostRate
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.CostRate; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.CostRate = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Location]. NotReadonly. NotNull.
		/// </summary>
		public decimal Availability
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Availability; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Availability = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Location]. NotReadonly. NotNull.
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
			this.InsertItem(index, new PriKey_Production_Location_Record());
			this.CurrentRecordIndex = index;
		}

		public void Append(PriKey_Production_Location_Record record)
		{
			int index = this.RecordCount;
			this.InsertItem(index, record);
			this.CurrentRecordIndex = index;
		}

		public PriKey_Production_Location_Record NewRecord()
		{
			return new PriKey_Production_Location_Record();
		}

		protected override PriKey_Production_Location_Record InternalCreateExistingRecordObject(object[] columnvalues) => new PriKey_Production_Location_Record(columnvalues);

		byte[] IRecordsetBase.Hash
		{
			get { return new byte[] { 55, 117, 199, 110, 173, 34, 111, 41, 127, 78, 14, 96, 162, 250, 127, 57 }; }
		}

		string IRecordsetBase.HashString
		{
			get { return "3775C76EAD226F297F4E0E60A2FA7F39"; }
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

		public void SetExecSqlParams(short? LocationID)
		{
			_inputparametervalues[0] = LocationID;
		}

		public void ExecSql(short? LocationID)
		{
			_inputparametervalues[0] = LocationID;
			Transactional.ExecSql(VenturaSqlConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public void ExecSql(Connector connector, short? LocationID)
		{
			_inputparametervalues[0] = LocationID;
			Transactional.ExecSql(connector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync(short? LocationID)
		{
			_inputparametervalues[0] = LocationID;
			await Transactional.ExecSqlAsync(VenturaSqlConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync(Connector connector, short? LocationID)
		{
			_inputparametervalues[0] = LocationID;
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

			public short? LocationID
			{
				get { return (short?)_values[0]; }
				set { _values[0] = value; }
			}

		}

	}

	public sealed partial class PriKey_Production_Location_Record : IRecordBase, INotifyPropertyChanged
	{
		private DataRecordStatus _recordstatus;
		private bool _started_with_dbvalues;

		private short _cur__LocationID; private short _ori__LocationID; private bool _mod__LocationID;
		private string _cur__Name; private string _ori__Name; private bool _mod__Name;
		private decimal _cur__CostRate; private decimal _ori__CostRate; private bool _mod__CostRate;
		private decimal _cur__Availability; private decimal _ori__Availability; private bool _mod__Availability;
		private DateTime _cur__ModifiedDate; private DateTime _ori__ModifiedDate; private bool _mod__ModifiedDate;


		public PriKey_Production_Location_Record()
		{
			_cur__LocationID = 0;
			_cur__Name = "";
			_cur__CostRate = 0.0m;
			_cur__Availability = 0.0m;
			_cur__ModifiedDate = new DateTime(1900, 1, 1);
			_started_with_dbvalues = false;
			_recordstatus = DataRecordStatus.New;
		}

		public PriKey_Production_Location_Record(object[] columnvalues)
		{
			_cur__LocationID = (short)columnvalues[0];
			_cur__Name = (string)columnvalues[1];
			_cur__CostRate = (decimal)columnvalues[2];
			_cur__Availability = (decimal)columnvalues[3];
			_cur__ModifiedDate = (DateTime)columnvalues[4];
			_started_with_dbvalues = true;
			_recordstatus = DataRecordStatus.Existing;
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Production].[Location]. PrimaryKey. NotReadonly. NotNull. IsIdentity. AutoIncrement.
		/// </summary>
		public short LocationID
		{
			get { return _cur__LocationID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__LocationID = true;
				if (_cur__LocationID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__LocationID == false) { _ori__LocationID = _cur__LocationID; _mod__LocationID = true; } // existing record and column is not modified
					else { if (value == _ori__LocationID) { _ori__LocationID = default(short); _mod__LocationID = false; } } // existing record and column is modified
				}
				_cur__LocationID = value; OnPropertyChanged("LocationID"); OnAfterPropertyChanged("LocationID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Location]. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [Production].[Location]. NotReadonly. NotNull.
		/// </summary>
		public decimal CostRate
		{
			get { return _cur__CostRate; }
			set
			{
				if (_started_with_dbvalues == false) _mod__CostRate = true;
				if (_cur__CostRate == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__CostRate == false) { _ori__CostRate = _cur__CostRate; _mod__CostRate = true; } // existing record and column is not modified
					else { if (value == _ori__CostRate) { _ori__CostRate = default(decimal); _mod__CostRate = false; } } // existing record and column is modified
				}
				_cur__CostRate = value; OnPropertyChanged("CostRate"); OnAfterPropertyChanged("CostRate");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Location]. NotReadonly. NotNull.
		/// </summary>
		public decimal Availability
		{
			get { return _cur__Availability; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Availability = true;
				if (_cur__Availability == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Availability == false) { _ori__Availability = _cur__Availability; _mod__Availability = true; } // existing record and column is not modified
					else { if (value == _ori__Availability) { _ori__Availability = default(decimal); _mod__Availability = false; } } // existing record and column is modified
				}
				_cur__Availability = value; OnPropertyChanged("Availability"); OnAfterPropertyChanged("Availability");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Location]. NotReadonly. NotNull.
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
			if (column_name == "LocationID") return _mod__LocationID;
			if (column_name == "Name") return _mod__Name;
			if (column_name == "CostRate") return _mod__CostRate;
			if (column_name == "Availability") return _mod__Availability;
			if (column_name == "ModifiedDate") return _mod__ModifiedDate;
			throw new ArgumentOutOfRangeException(String.Format(VenturaSqlStrings.UNKNOWN_COLUMN_NAME, column_name));
		}

		public int ModifiedColumnCount()
		{
			int count = 0;
			if (_mod__LocationID == true) count++;
			if (_mod__Name == true) count++;
			if (_mod__CostRate == true) count++;
			if (_mod__Availability == true) count++;
			if (_mod__ModifiedDate == true) count++;
			return count;
		}

		public bool PendingChanges()
		{
			if (_recordstatus == DataRecordStatus.New || _recordstatus == DataRecordStatus.ExistingDelete) return true;
			int count = 0;
			if (_mod__Name == true) count++;
			if (_mod__CostRate == true) count++;
			if (_mod__Availability == true) count++;
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
				track_array.AppendDataValue(2, _cur__CostRate);
				track_array.AppendDataValue(3, _cur__Availability);
				track_array.AppendDataValue(4, _cur__ModifiedDate);
			}
			else if (_recordstatus == DataRecordStatus.Existing)
			{
				if (_mod__Name) track_array.AppendDataValue(1, _cur__Name);
				if (_mod__CostRate) track_array.AppendDataValue(2, _cur__CostRate);
				if (_mod__Availability) track_array.AppendDataValue(3, _cur__Availability);
				if (_mod__ModifiedDate) track_array.AppendDataValue(4, _cur__ModifiedDate);
				if (track_array.HasData == false) return;
			}

			if (_recordstatus == DataRecordStatus.Existing || _recordstatus == DataRecordStatus.ExistingDelete)
			{
				track_array.AppendPrikeyValue(0, (_mod__LocationID && _started_with_dbvalues) ? _ori__LocationID : _cur__LocationID);
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
				if (_mod__LocationID) _ori__LocationID = default(short);
				if (_mod__Name) _ori__Name = default(string);
				if (_mod__CostRate) _ori__CostRate = default(decimal);
				if (_mod__Availability) _ori__Availability = default(decimal);
				if (_mod__ModifiedDate) _ori__ModifiedDate = default(DateTime);
			}
			_mod__LocationID = false;
			_mod__Name = false;
			_mod__CostRate = false;
			_mod__Availability = false;
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
			_cur__LocationID = (short)value;
			OnPropertyChanged("LocationID");
			OnAfterPropertyChanged("LocationID");
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
	public partial class PriKey_Production_Location_Record
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
