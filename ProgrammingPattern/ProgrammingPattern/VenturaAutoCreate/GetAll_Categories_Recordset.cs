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
	/// The updateable table is [Categories]. Updateable table column information:
	/// • 5 out of 5 table columns are present in the resultset.
	/// • All primary key columns are present in the resultset: CategoryID.
	/// • Non-primary key columns present in the resultset: Description, Name, Picture and Thumbnail.
	/// Recordset item automatically created by VenturaSQL Studio.
	/// </summary>
	public partial class GetAll_Categories_Recordset : ResultsetObservable<GetAll_Categories_Recordset, GetAll_Categories_Record>, IRecordsetBase
	{
		private IResultsetBase[] _resultsets;
		private string _sqlscript;
		private int _rowlimit = 500;
		private const string CRLF = "\r\n";

		public GetAll_Categories_Recordset()
		{
			_resultsets = new IResultsetBase[] { this };

			_sqlscript = @"SELECT [CategoryID],[Description],[Name],[Picture],[Thumbnail]" + CRLF +
			             @"FROM [Categories]";

			ColumnArrayBuilder schema_array = new ColumnArrayBuilder();

			schema_array.Add(new VenturaSqlColumn("CategoryID", typeof(long), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 19,
				NumericScale = 0,
				ProviderType = 12,
				IsUnique = true,
				IsKey = true,
				BaseCatalogName = "main",
				BaseTableName = "Categories",
				BaseColumnName = "CategoryID"
			});

			schema_array.Add(new VenturaSqlColumn("Description", typeof(string), true)
			{
				Updateable = true,
				ProviderType = 16,
				BaseCatalogName = "main",
				BaseTableName = "Categories",
				BaseColumnName = "Description"
			});

			schema_array.Add(new VenturaSqlColumn("Name", typeof(string), false)
			{
				Updateable = true,
				ProviderType = 16,
				BaseCatalogName = "main",
				BaseTableName = "Categories",
				BaseColumnName = "Name"
			});

			schema_array.Add(new VenturaSqlColumn("Picture", typeof(byte[]), true)
			{
				Updateable = true,
				ProviderType = 1,
				BaseCatalogName = "main",
				BaseTableName = "Categories",
				BaseColumnName = "Picture"
			});

			schema_array.Add(new VenturaSqlColumn("Thumbnail", typeof(byte[]), true)
			{
				Updateable = true,
				ProviderType = 1,
				BaseCatalogName = "main",
				BaseTableName = "Categories",
				BaseColumnName = "Thumbnail"
			});

			((IResultsetBase)this).Schema = new VenturaSqlSchema(schema_array);
			((IResultsetBase)this).UpdateableTablename = "[Categories]";
		}

		/// <summary>
		/// Database Column Updateable. Table [Categories]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public long CategoryID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.CategoryID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.CategoryID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Categories]. NotReadonly. AllowNull.
		/// </summary>
		public string Description
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Description; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Description = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Categories]. NotReadonly. NotNull.
		/// </summary>
		public string Name
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Name; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Name = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Categories]. NotReadonly. AllowNull.
		/// </summary>
		public byte[] Picture
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Picture; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Picture = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Categories]. NotReadonly. AllowNull.
		/// </summary>
		public byte[] Thumbnail
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Thumbnail; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Thumbnail = value; }
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
			this.InsertItem(index, new GetAll_Categories_Record());
			this.CurrentRecordIndex = index;
		}

		public void Append(GetAll_Categories_Record record)
		{
			int index = this.RecordCount;
			this.InsertItem(index, record);
			this.CurrentRecordIndex = index;
		}

		public GetAll_Categories_Record NewRecord()
		{
			return new GetAll_Categories_Record();
		}

		protected override GetAll_Categories_Record InternalCreateExistingRecordObject(object[] columnvalues) => new GetAll_Categories_Record(columnvalues);

		byte[] IRecordsetBase.Hash
		{
			get { return new byte[] { 195, 217, 5, 197, 122, 81, 216, 4, 103, 166, 146, 33, 232, 43, 4, 242 }; }
		}

		string IRecordsetBase.HashString
		{
			get { return "C3D905C57A51D80467A69221E82B04F2"; }
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

	public sealed partial class GetAll_Categories_Record : IRecordBase, INotifyPropertyChanged
	{
		private DataRecordStatus _recordstatus;
		private bool _started_with_dbvalues;

		private long _cur__CategoryID; private long _ori__CategoryID; private bool _mod__CategoryID;
		private string _cur__Description; private string _ori__Description; private bool _mod__Description;
		private string _cur__Name; private string _ori__Name; private bool _mod__Name;
		private byte[] _cur__Picture; private byte[] _ori__Picture; private bool _mod__Picture;
		private byte[] _cur__Thumbnail; private byte[] _ori__Thumbnail; private bool _mod__Thumbnail;


		public GetAll_Categories_Record()
		{
			_cur__CategoryID = 0;
			_cur__Description = null;
			_cur__Name = "";
			_cur__Picture = null;
			_cur__Thumbnail = null;
			_started_with_dbvalues = false;
			_recordstatus = DataRecordStatus.New;
		}

		public GetAll_Categories_Record(object[] columnvalues)
		{
			_cur__CategoryID = (long)columnvalues[0];
			_cur__Description = (string)columnvalues[1];
			_cur__Name = (string)columnvalues[2];
			_cur__Picture = (byte[])columnvalues[3];
			_cur__Thumbnail = (byte[])columnvalues[4];
			_started_with_dbvalues = true;
			_recordstatus = DataRecordStatus.Existing;
		}

		/// <summary>
		/// Database Column Updateable. Table [Categories]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public long CategoryID
		{
			get { return _cur__CategoryID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__CategoryID = true;
				if (_cur__CategoryID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__CategoryID == false) { _ori__CategoryID = _cur__CategoryID; _mod__CategoryID = true; } // existing record and column is not modified
					else { if (value == _ori__CategoryID) { _ori__CategoryID = default(long); _mod__CategoryID = false; } } // existing record and column is modified
				}
				_cur__CategoryID = value; OnPropertyChanged("CategoryID"); OnAfterPropertyChanged("CategoryID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Categories]. NotReadonly. AllowNull.
		/// </summary>
		public string Description
		{
			get { return _cur__Description; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Description = true;
				if (_cur__Description == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Description == false) { _ori__Description = _cur__Description; _mod__Description = true; } // existing record and column is not modified
					else { if (value == _ori__Description) { _ori__Description = default(string); _mod__Description = false; } } // existing record and column is modified
				}
				_cur__Description = value; OnPropertyChanged("Description"); OnAfterPropertyChanged("Description");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Categories]. NotReadonly. NotNull.
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
		/// Database Column Updateable. Table [Categories]. NotReadonly. AllowNull.
		/// </summary>
		public byte[] Picture
		{
			get { return _cur__Picture; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Picture = true;
				if (_cur__Picture == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Picture == false) { _ori__Picture = _cur__Picture; _mod__Picture = true; } // existing record and column is not modified
					else { if (value == _ori__Picture) { _ori__Picture = default(byte[]); _mod__Picture = false; } } // existing record and column is modified
				}
				_cur__Picture = value; OnPropertyChanged("Picture"); OnAfterPropertyChanged("Picture");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Categories]. NotReadonly. AllowNull.
		/// </summary>
		public byte[] Thumbnail
		{
			get { return _cur__Thumbnail; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Thumbnail = true;
				if (_cur__Thumbnail == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Thumbnail == false) { _ori__Thumbnail = _cur__Thumbnail; _mod__Thumbnail = true; } // existing record and column is not modified
					else { if (value == _ori__Thumbnail) { _ori__Thumbnail = default(byte[]); _mod__Thumbnail = false; } } // existing record and column is modified
				}
				_cur__Thumbnail = value; OnPropertyChanged("Thumbnail"); OnAfterPropertyChanged("Thumbnail");
			}
		}

		public bool IsModified(string column_name)
		{
			if (column_name == "CategoryID") return _mod__CategoryID;
			if (column_name == "Description") return _mod__Description;
			if (column_name == "Name") return _mod__Name;
			if (column_name == "Picture") return _mod__Picture;
			if (column_name == "Thumbnail") return _mod__Thumbnail;
			throw new ArgumentOutOfRangeException(String.Format(VenturaSqlStrings.UNKNOWN_COLUMN_NAME, column_name));
		}

		public int ModifiedColumnCount()
		{
			int count = 0;
			if (_mod__CategoryID == true) count++;
			if (_mod__Description == true) count++;
			if (_mod__Name == true) count++;
			if (_mod__Picture == true) count++;
			if (_mod__Thumbnail == true) count++;
			return count;
		}

		public bool PendingChanges()
		{
			if (_recordstatus == DataRecordStatus.New || _recordstatus == DataRecordStatus.ExistingDelete) return true;
			int count = 0;
			if (_started_with_dbvalues)
			{
				if (_mod__CategoryID) count++;
			}
			if (_mod__Description == true) count++;
			if (_mod__Name == true) count++;
			if (_mod__Picture == true) count++;
			if (_mod__Thumbnail == true) count++;
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
			if (_mod__CategoryID == false) throw new Exception(string.Format(VenturaSqlStrings.VALUE_NOT_SET_MSG, record_index_to_display, "CategoryID"));
		}

		void IRecordBase.WriteChangesToTrackArray(TrackArray track_array)
		{
			if (_recordstatus == DataRecordStatus.New)
			{
				track_array.AppendDataValue(0, _cur__CategoryID);
				if (_cur__Description != null) track_array.AppendDataValue(1, _cur__Description);
				track_array.AppendDataValue(2, _cur__Name);
				if (_cur__Picture != null) track_array.AppendDataValue(3, _cur__Picture);
				if (_cur__Thumbnail != null) track_array.AppendDataValue(4, _cur__Thumbnail);
			}
			else if (_recordstatus == DataRecordStatus.Existing)
			{
				if (_started_with_dbvalues)
				{
					if (_mod__CategoryID) track_array.AppendDataValue(0, _cur__CategoryID);
				}
				if (_mod__Description) track_array.AppendDataValue(1, _cur__Description);
				if (_mod__Name) track_array.AppendDataValue(2, _cur__Name);
				if (_mod__Picture) track_array.AppendDataValue(3, _cur__Picture);
				if (_mod__Thumbnail) track_array.AppendDataValue(4, _cur__Thumbnail);
				if (track_array.HasData == false) return;
			}

			if (_recordstatus == DataRecordStatus.Existing || _recordstatus == DataRecordStatus.ExistingDelete)
			{
				track_array.AppendPrikeyValue(0, (_mod__CategoryID && _started_with_dbvalues) ? _ori__CategoryID : _cur__CategoryID);
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
				if (_mod__CategoryID) _ori__CategoryID = default(long);
				if (_mod__Description) _ori__Description = default(string);
				if (_mod__Name) _ori__Name = default(string);
				if (_mod__Picture) _ori__Picture = default(byte[]);
				if (_mod__Thumbnail) _ori__Thumbnail = default(byte[]);
			}
			_mod__CategoryID = false;
			_mod__Description = false;
			_mod__Name = false;
			_mod__Picture = false;
			_mod__Thumbnail = false;
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
	public partial class GetAll_Categories_Record
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
