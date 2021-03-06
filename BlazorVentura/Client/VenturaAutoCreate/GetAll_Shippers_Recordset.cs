/*
	Project file: "C:\Active\VenturaSQL\BuildSystem\Templates\BlazorVentura\BlazorVentura.venproj"
	Target platform: NETStandard
	Generator version: 4.0.130
	Generated on: Wednesday, 19 May 2021 at 09:11:42
	At the bottom of this file you find a template for extending Recordsets with calculated columns for XAML data binding.
*/
using VenturaSQL;
using System;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel;

namespace BlazorVentura.Client.VenturaAutoCreate
{
	/// <summary>
	/// The updateable table is [Shippers]. Updateable table column information:
	/// • 3 out of 3 table columns are present in the resultset.
	/// • All primary key columns are present in the resultset: ShipperID.
	/// • Non-primary key columns present in the resultset: Name and Phone.
	/// Recordset item automatically created by VenturaSQL Studio.
	/// </summary>
	public partial class GetAll_Shippers_Recordset : ResultsetObservable<GetAll_Shippers_Recordset, GetAll_Shippers_Record>, IRecordsetBase
	{
		private IResultsetBase[] _resultsets;
		private int _rowlimit = 500;
		private const string CRLF = "\r\n";

		public GetAll_Shippers_Recordset()
		{
			_resultsets = new IResultsetBase[] { this };


			ColumnArrayBuilder schema_array = new ColumnArrayBuilder();

			schema_array.Add(new VenturaSqlColumn("ShipperID", typeof(long), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 19,
				NumericScale = 0,
				IsUnique = true,
				IsKey = true
			});

			schema_array.Add(new VenturaSqlColumn("Name", typeof(string), false)
			{
				Updateable = true
			});

			schema_array.Add(new VenturaSqlColumn("Phone", typeof(string), true)
			{
				Updateable = true
			});

			((IResultsetBase)this).Schema = new VenturaSqlSchema(schema_array);
			((IResultsetBase)this).UpdateableTablename = "[Shippers]";
		}

		/// <summary>
		/// Database Column Updateable. Table [Shippers]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public long ShipperID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ShipperID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ShipperID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Shippers]. NotReadonly. NotNull.
		/// </summary>
		public string Name
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Name; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Name = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Shippers]. NotReadonly. AllowNull.
		/// </summary>
		public string Phone
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Phone; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Phone = value; }
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
			this.InsertItem(index, new GetAll_Shippers_Record());
			this.CurrentRecordIndex = index;
		}

		public void Append(GetAll_Shippers_Record record)
		{
			int index = this.RecordCount;
			this.InsertItem(index, record);
			this.CurrentRecordIndex = index;
		}

		public GetAll_Shippers_Record NewRecord()
		{
			return new GetAll_Shippers_Record();
		}

		protected override GetAll_Shippers_Record InternalCreateExistingRecordObject(object[] columnvalues) => new GetAll_Shippers_Record(columnvalues);

		byte[] IRecordsetBase.Hash
		{
			get { return new byte[] { 53, 11, 172, 181, 172, 94, 249, 209, 242, 82, 99, 239, 26, 231, 29, 154 }; }
		}

		string IRecordsetBase.HashString
		{
			get { return "350BACB5AC5EF9D1F25263EF1AE71D9A"; }
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
			get { return new DateTime(2021, 5, 19, 9, 11, 42); } // Wednesday, 19 May 2021 at 09:11:42
		}

		string IRecordsetBase.GeneratorProviderInvariantName
		{
			get { return null; }
		}

		IResultsetBase[] IRecordsetBase.Resultsets
		{
			get { return _resultsets; }
		}

		string IRecordsetBase.SqlScript
		{
			get { return null; }
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

	public sealed partial class GetAll_Shippers_Record : IRecordBase, INotifyPropertyChanged
	{
		private DataRecordStatus _recordstatus;
		private bool _started_with_dbvalues;

		private long _cur__ShipperID; private long _ori__ShipperID; private bool _mod__ShipperID;
		private string _cur__Name; private string _ori__Name; private bool _mod__Name;
		private string _cur__Phone; private string _ori__Phone; private bool _mod__Phone;


		public GetAll_Shippers_Record()
		{
			_cur__ShipperID = 0;
			_cur__Name = "";
			_cur__Phone = null;
			_started_with_dbvalues = false;
			_recordstatus = DataRecordStatus.New;
		}

		public GetAll_Shippers_Record(object[] columnvalues)
		{
			_cur__ShipperID = (long)columnvalues[0];
			_cur__Name = (string)columnvalues[1];
			_cur__Phone = (string)columnvalues[2];
			_started_with_dbvalues = true;
			_recordstatus = DataRecordStatus.Existing;
		}

		/// <summary>
		/// Database Column Updateable. Table [Shippers]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public long ShipperID
		{
			get { return _cur__ShipperID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ShipperID = true;
				if (_cur__ShipperID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ShipperID == false) { _ori__ShipperID = _cur__ShipperID; _mod__ShipperID = true; } // existing record and column is not modified
					else { if (value == _ori__ShipperID) { _ori__ShipperID = default(long); _mod__ShipperID = false; } } // existing record and column is modified
				}
				_cur__ShipperID = value; OnPropertyChanged("ShipperID"); OnAfterPropertyChanged("ShipperID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Shippers]. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [Shippers]. NotReadonly. AllowNull.
		/// </summary>
		public string Phone
		{
			get { return _cur__Phone; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Phone = true;
				if (_cur__Phone == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Phone == false) { _ori__Phone = _cur__Phone; _mod__Phone = true; } // existing record and column is not modified
					else { if (value == _ori__Phone) { _ori__Phone = default(string); _mod__Phone = false; } } // existing record and column is modified
				}
				_cur__Phone = value; OnPropertyChanged("Phone"); OnAfterPropertyChanged("Phone");
			}
		}

		public bool IsModified(string column_name)
		{
			if (column_name == "ShipperID") return _mod__ShipperID;
			if (column_name == "Name") return _mod__Name;
			if (column_name == "Phone") return _mod__Phone;
			throw new ArgumentOutOfRangeException(String.Format(VenturaSqlStrings.UNKNOWN_COLUMN_NAME, column_name));
		}

		public int ModifiedColumnCount()
		{
			int count = 0;
			if (_mod__ShipperID == true) count++;
			if (_mod__Name == true) count++;
			if (_mod__Phone == true) count++;
			return count;
		}

		public bool PendingChanges()
		{
			if (_recordstatus == DataRecordStatus.New || _recordstatus == DataRecordStatus.ExistingDelete) return true;
			int count = 0;
			if (_started_with_dbvalues)
			{
				if (_mod__ShipperID) count++;
			}
			if (_mod__Name == true) count++;
			if (_mod__Phone == true) count++;
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
			if (_mod__ShipperID == false) throw new Exception(string.Format(VenturaSqlStrings.VALUE_NOT_SET_MSG, record_index_to_display, "ShipperID"));
		}

		void IRecordBase.WriteChangesToTrackArray(TrackArray track_array)
		{
			if (_recordstatus == DataRecordStatus.New)
			{
				track_array.AppendDataValue(0, _cur__ShipperID);
				track_array.AppendDataValue(1, _cur__Name);
				if (_cur__Phone != null) track_array.AppendDataValue(2, _cur__Phone);
			}
			else if (_recordstatus == DataRecordStatus.Existing)
			{
				if (_started_with_dbvalues)
				{
					if (_mod__ShipperID) track_array.AppendDataValue(0, _cur__ShipperID);
				}
				if (_mod__Name) track_array.AppendDataValue(1, _cur__Name);
				if (_mod__Phone) track_array.AppendDataValue(2, _cur__Phone);
				if (track_array.HasData == false) return;
			}

			if (_recordstatus == DataRecordStatus.Existing || _recordstatus == DataRecordStatus.ExistingDelete)
			{
				track_array.AppendPrikeyValue(0, (_mod__ShipperID && _started_with_dbvalues) ? _ori__ShipperID : _cur__ShipperID);
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
				if (_mod__ShipperID) _ori__ShipperID = default(long);
				if (_mod__Name) _ori__Name = default(string);
				if (_mod__Phone) _ori__Phone = default(string);
			}
			_mod__ShipperID = false;
			_mod__Name = false;
			_mod__Phone = false;
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
namespace BlazorVentura.Client.VenturaAutoCreate
{
	public partial class GetAll_Shippers_Record
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
