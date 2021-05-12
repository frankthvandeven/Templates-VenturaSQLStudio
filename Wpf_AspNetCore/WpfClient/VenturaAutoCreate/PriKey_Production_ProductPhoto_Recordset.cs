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

namespace WpfClient.VenturaAutoCreate
{
	/// <summary>
	/// The updateable table is [Production].[ProductPhoto]. Updateable table column information:
	/// • 6 out of 6 table columns are present in the resultset.
	/// • All primary key columns are present in the resultset: ProductPhotoID.
	/// • Non-primary key columns present in the resultset: ThumbNailPhoto, ThumbnailPhotoFileName, LargePhoto, LargePhotoFileName
	///   and ModifiedDate.
	/// Recordset item automatically created by VenturaSQL Studio.
	/// </summary>
	public partial class PriKey_Production_ProductPhoto_Recordset : ResultsetObservable<PriKey_Production_ProductPhoto_Recordset, PriKey_Production_ProductPhoto_Record>, IRecordsetBase
	{
		private IResultsetBase[] _resultsets;
		private string _sqlscript;
		private object[] _inputparametervalues;
		private InputParamHolder _inputparamholder;
		private VenturaSqlSchema _parameterschema;
		private int _rowlimit = 500;
		private const string CRLF = "\r\n";

		public PriKey_Production_ProductPhoto_Recordset()
		{
			_resultsets = new IResultsetBase[] { this };

			_sqlscript = @"SELECT [ProductPhotoID],[ThumbNailPhoto],[ThumbnailPhotoFileName],[LargePhoto],[LargePhotoFileName],[ModifiedDate]" + CRLF +
			             @"FROM [Production].[ProductPhoto]" + CRLF +
			             @"WHERE [ProductPhotoID] = @ProductPhotoID";

			_inputparametervalues = new object[1];
			_inputparamholder = new InputParamHolder(_inputparametervalues);

			ColumnArrayBuilder param_array = new ColumnArrayBuilder();

			param_array.AddParameterColumn("@ProductPhotoID", typeof(int), true, false, DbType.Int32, null, null, null);

			_parameterschema = new VenturaSqlSchema(param_array);

			ColumnArrayBuilder schema_array = new ColumnArrayBuilder();

			schema_array.Add(new VenturaSqlColumn("ProductPhotoID", typeof(int), false)
			{
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				IsKey = true,
				IsIdentity = true,
				IsAutoIncrement = true,
				BaseSchemaName = "Production",
				BaseTableName = "ProductPhoto",
				BaseColumnName = "ProductPhotoID"
			});

			schema_array.Add(new VenturaSqlColumn("ThumbNailPhoto", typeof(byte[]), true)
			{
				Updateable = true,
				ProviderType = 21,
				IsLong = true,
				BaseSchemaName = "Production",
				BaseTableName = "ProductPhoto",
				BaseColumnName = "ThumbNailPhoto"
			});

			schema_array.Add(new VenturaSqlColumn("ThumbnailPhotoFileName", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 50,
				ProviderType = 12,
				BaseSchemaName = "Production",
				BaseTableName = "ProductPhoto",
				BaseColumnName = "ThumbnailPhotoFileName"
			});

			schema_array.Add(new VenturaSqlColumn("LargePhoto", typeof(byte[]), true)
			{
				Updateable = true,
				ProviderType = 21,
				IsLong = true,
				BaseSchemaName = "Production",
				BaseTableName = "ProductPhoto",
				BaseColumnName = "LargePhoto"
			});

			schema_array.Add(new VenturaSqlColumn("LargePhotoFileName", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 50,
				ProviderType = 12,
				BaseSchemaName = "Production",
				BaseTableName = "ProductPhoto",
				BaseColumnName = "LargePhotoFileName"
			});

			schema_array.Add(new VenturaSqlColumn("ModifiedDate", typeof(DateTime), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 23,
				NumericScale = 3,
				ProviderType = 4,
				BaseSchemaName = "Production",
				BaseTableName = "ProductPhoto",
				BaseColumnName = "ModifiedDate"
			});

			((IResultsetBase)this).Schema = new VenturaSqlSchema(schema_array);
			((IResultsetBase)this).UpdateableTablename = "[Production].[ProductPhoto]";
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Production].[ProductPhoto]. PrimaryKey. NotReadonly. NotNull. IsIdentity. AutoIncrement.
		/// </summary>
		public int ProductPhotoID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ProductPhotoID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ProductPhotoID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductPhoto]. NotReadonly. AllowNull.
		/// </summary>
		public byte[] ThumbNailPhoto
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ThumbNailPhoto; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ThumbNailPhoto = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductPhoto]. NotReadonly. AllowNull.
		/// </summary>
		public string ThumbnailPhotoFileName
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ThumbnailPhotoFileName; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ThumbnailPhotoFileName = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductPhoto]. NotReadonly. AllowNull.
		/// </summary>
		public byte[] LargePhoto
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.LargePhoto; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.LargePhoto = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductPhoto]. NotReadonly. AllowNull.
		/// </summary>
		public string LargePhotoFileName
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.LargePhotoFileName; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.LargePhotoFileName = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductPhoto]. NotReadonly. NotNull.
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
			this.InsertItem(index, new PriKey_Production_ProductPhoto_Record());
			this.CurrentRecordIndex = index;
		}

		public void Append(PriKey_Production_ProductPhoto_Record record)
		{
			int index = this.RecordCount;
			this.InsertItem(index, record);
			this.CurrentRecordIndex = index;
		}

		public PriKey_Production_ProductPhoto_Record NewRecord()
		{
			return new PriKey_Production_ProductPhoto_Record();
		}

		protected override PriKey_Production_ProductPhoto_Record InternalCreateExistingRecordObject(object[] columnvalues) => new PriKey_Production_ProductPhoto_Record(columnvalues);

		byte[] IRecordsetBase.Hash
		{
			get { return new byte[] { 149, 218, 142, 120, 234, 151, 148, 205, 69, 206, 34, 8, 59, 85, 208, 27 }; }
		}

		string IRecordsetBase.HashString
		{
			get { return "95DA8E78EA9794CD45CE22083B55D01B"; }
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

		public void SetExecSqlParams(int? ProductPhotoID)
		{
			_inputparametervalues[0] = ProductPhotoID;
		}

		public void ExecSql(int? ProductPhotoID)
		{
			_inputparametervalues[0] = ProductPhotoID;
			Transactional.ExecSql(VenturaSqlConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public void ExecSql(Connector connector, int? ProductPhotoID)
		{
			_inputparametervalues[0] = ProductPhotoID;
			Transactional.ExecSql(connector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync(int? ProductPhotoID)
		{
			_inputparametervalues[0] = ProductPhotoID;
			await Transactional.ExecSqlAsync(VenturaSqlConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync(Connector connector, int? ProductPhotoID)
		{
			_inputparametervalues[0] = ProductPhotoID;
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

			public int? ProductPhotoID
			{
				get { return (int?)_values[0]; }
				set { _values[0] = value; }
			}

		}

	}

	public sealed partial class PriKey_Production_ProductPhoto_Record : IRecordBase, INotifyPropertyChanged
	{
		private DataRecordStatus _recordstatus;
		private bool _started_with_dbvalues;

		private int _cur__ProductPhotoID; private int _ori__ProductPhotoID; private bool _mod__ProductPhotoID;
		private byte[] _cur__ThumbNailPhoto; private byte[] _ori__ThumbNailPhoto; private bool _mod__ThumbNailPhoto;
		private string _cur__ThumbnailPhotoFileName; private string _ori__ThumbnailPhotoFileName; private bool _mod__ThumbnailPhotoFileName;
		private byte[] _cur__LargePhoto; private byte[] _ori__LargePhoto; private bool _mod__LargePhoto;
		private string _cur__LargePhotoFileName; private string _ori__LargePhotoFileName; private bool _mod__LargePhotoFileName;
		private DateTime _cur__ModifiedDate; private DateTime _ori__ModifiedDate; private bool _mod__ModifiedDate;


		public PriKey_Production_ProductPhoto_Record()
		{
			_cur__ProductPhotoID = 0;
			_cur__ThumbNailPhoto = null;
			_cur__ThumbnailPhotoFileName = null;
			_cur__LargePhoto = null;
			_cur__LargePhotoFileName = null;
			_cur__ModifiedDate = new DateTime(1900, 1, 1);
			_started_with_dbvalues = false;
			_recordstatus = DataRecordStatus.New;
		}

		public PriKey_Production_ProductPhoto_Record(object[] columnvalues)
		{
			_cur__ProductPhotoID = (int)columnvalues[0];
			_cur__ThumbNailPhoto = (byte[])columnvalues[1];
			_cur__ThumbnailPhotoFileName = (string)columnvalues[2];
			_cur__LargePhoto = (byte[])columnvalues[3];
			_cur__LargePhotoFileName = (string)columnvalues[4];
			_cur__ModifiedDate = (DateTime)columnvalues[5];
			_started_with_dbvalues = true;
			_recordstatus = DataRecordStatus.Existing;
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Production].[ProductPhoto]. PrimaryKey. NotReadonly. NotNull. IsIdentity. AutoIncrement.
		/// </summary>
		public int ProductPhotoID
		{
			get { return _cur__ProductPhotoID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ProductPhotoID = true;
				if (_cur__ProductPhotoID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ProductPhotoID == false) { _ori__ProductPhotoID = _cur__ProductPhotoID; _mod__ProductPhotoID = true; } // existing record and column is not modified
					else { if (value == _ori__ProductPhotoID) { _ori__ProductPhotoID = default(int); _mod__ProductPhotoID = false; } } // existing record and column is modified
				}
				_cur__ProductPhotoID = value; OnPropertyChanged("ProductPhotoID"); OnAfterPropertyChanged("ProductPhotoID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductPhoto]. NotReadonly. AllowNull.
		/// </summary>
		public byte[] ThumbNailPhoto
		{
			get { return _cur__ThumbNailPhoto; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ThumbNailPhoto = true;
				if (_cur__ThumbNailPhoto == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ThumbNailPhoto == false) { _ori__ThumbNailPhoto = _cur__ThumbNailPhoto; _mod__ThumbNailPhoto = true; } // existing record and column is not modified
					else { if (value == _ori__ThumbNailPhoto) { _ori__ThumbNailPhoto = default(byte[]); _mod__ThumbNailPhoto = false; } } // existing record and column is modified
				}
				_cur__ThumbNailPhoto = value; OnPropertyChanged("ThumbNailPhoto"); OnAfterPropertyChanged("ThumbNailPhoto");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductPhoto]. NotReadonly. AllowNull.
		/// </summary>
		public string ThumbnailPhotoFileName
		{
			get { return _cur__ThumbnailPhotoFileName; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ThumbnailPhotoFileName = true;
				if (_cur__ThumbnailPhotoFileName == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ThumbnailPhotoFileName == false) { _ori__ThumbnailPhotoFileName = _cur__ThumbnailPhotoFileName; _mod__ThumbnailPhotoFileName = true; } // existing record and column is not modified
					else { if (value == _ori__ThumbnailPhotoFileName) { _ori__ThumbnailPhotoFileName = default(string); _mod__ThumbnailPhotoFileName = false; } } // existing record and column is modified
				}
				_cur__ThumbnailPhotoFileName = value; OnPropertyChanged("ThumbnailPhotoFileName"); OnAfterPropertyChanged("ThumbnailPhotoFileName");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductPhoto]. NotReadonly. AllowNull.
		/// </summary>
		public byte[] LargePhoto
		{
			get { return _cur__LargePhoto; }
			set
			{
				if (_started_with_dbvalues == false) _mod__LargePhoto = true;
				if (_cur__LargePhoto == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__LargePhoto == false) { _ori__LargePhoto = _cur__LargePhoto; _mod__LargePhoto = true; } // existing record and column is not modified
					else { if (value == _ori__LargePhoto) { _ori__LargePhoto = default(byte[]); _mod__LargePhoto = false; } } // existing record and column is modified
				}
				_cur__LargePhoto = value; OnPropertyChanged("LargePhoto"); OnAfterPropertyChanged("LargePhoto");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductPhoto]. NotReadonly. AllowNull.
		/// </summary>
		public string LargePhotoFileName
		{
			get { return _cur__LargePhotoFileName; }
			set
			{
				if (_started_with_dbvalues == false) _mod__LargePhotoFileName = true;
				if (_cur__LargePhotoFileName == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__LargePhotoFileName == false) { _ori__LargePhotoFileName = _cur__LargePhotoFileName; _mod__LargePhotoFileName = true; } // existing record and column is not modified
					else { if (value == _ori__LargePhotoFileName) { _ori__LargePhotoFileName = default(string); _mod__LargePhotoFileName = false; } } // existing record and column is modified
				}
				_cur__LargePhotoFileName = value; OnPropertyChanged("LargePhotoFileName"); OnAfterPropertyChanged("LargePhotoFileName");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductPhoto]. NotReadonly. NotNull.
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
			if (column_name == "ProductPhotoID") return _mod__ProductPhotoID;
			if (column_name == "ThumbNailPhoto") return _mod__ThumbNailPhoto;
			if (column_name == "ThumbnailPhotoFileName") return _mod__ThumbnailPhotoFileName;
			if (column_name == "LargePhoto") return _mod__LargePhoto;
			if (column_name == "LargePhotoFileName") return _mod__LargePhotoFileName;
			if (column_name == "ModifiedDate") return _mod__ModifiedDate;
			throw new ArgumentOutOfRangeException(String.Format(VenturaSqlStrings.UNKNOWN_COLUMN_NAME, column_name));
		}

		public int ModifiedColumnCount()
		{
			int count = 0;
			if (_mod__ProductPhotoID == true) count++;
			if (_mod__ThumbNailPhoto == true) count++;
			if (_mod__ThumbnailPhotoFileName == true) count++;
			if (_mod__LargePhoto == true) count++;
			if (_mod__LargePhotoFileName == true) count++;
			if (_mod__ModifiedDate == true) count++;
			return count;
		}

		public bool PendingChanges()
		{
			if (_recordstatus == DataRecordStatus.New || _recordstatus == DataRecordStatus.ExistingDelete) return true;
			int count = 0;
			if (_mod__ThumbNailPhoto == true) count++;
			if (_mod__ThumbnailPhotoFileName == true) count++;
			if (_mod__LargePhoto == true) count++;
			if (_mod__LargePhotoFileName == true) count++;
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
				if (_cur__ThumbNailPhoto != null) track_array.AppendDataValue(1, _cur__ThumbNailPhoto);
				if (_cur__ThumbnailPhotoFileName != null) track_array.AppendDataValue(2, _cur__ThumbnailPhotoFileName);
				if (_cur__LargePhoto != null) track_array.AppendDataValue(3, _cur__LargePhoto);
				if (_cur__LargePhotoFileName != null) track_array.AppendDataValue(4, _cur__LargePhotoFileName);
				track_array.AppendDataValue(5, _cur__ModifiedDate);
			}
			else if (_recordstatus == DataRecordStatus.Existing)
			{
				if (_mod__ThumbNailPhoto) track_array.AppendDataValue(1, _cur__ThumbNailPhoto);
				if (_mod__ThumbnailPhotoFileName) track_array.AppendDataValue(2, _cur__ThumbnailPhotoFileName);
				if (_mod__LargePhoto) track_array.AppendDataValue(3, _cur__LargePhoto);
				if (_mod__LargePhotoFileName) track_array.AppendDataValue(4, _cur__LargePhotoFileName);
				if (_mod__ModifiedDate) track_array.AppendDataValue(5, _cur__ModifiedDate);
				if (track_array.HasData == false) return;
			}

			if (_recordstatus == DataRecordStatus.Existing || _recordstatus == DataRecordStatus.ExistingDelete)
			{
				track_array.AppendPrikeyValue(0, (_mod__ProductPhotoID && _started_with_dbvalues) ? _ori__ProductPhotoID : _cur__ProductPhotoID);
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
				if (_mod__ProductPhotoID) _ori__ProductPhotoID = default(int);
				if (_mod__ThumbNailPhoto) _ori__ThumbNailPhoto = default(byte[]);
				if (_mod__ThumbnailPhotoFileName) _ori__ThumbnailPhotoFileName = default(string);
				if (_mod__LargePhoto) _ori__LargePhoto = default(byte[]);
				if (_mod__LargePhotoFileName) _ori__LargePhotoFileName = default(string);
				if (_mod__ModifiedDate) _ori__ModifiedDate = default(DateTime);
			}
			_mod__ProductPhotoID = false;
			_mod__ThumbNailPhoto = false;
			_mod__ThumbnailPhotoFileName = false;
			_mod__LargePhoto = false;
			_mod__LargePhotoFileName = false;
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
			_cur__ProductPhotoID = (int)value;
			OnPropertyChanged("ProductPhotoID");
			OnAfterPropertyChanged("ProductPhotoID");
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
	public partial class PriKey_Production_ProductPhoto_Record
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
