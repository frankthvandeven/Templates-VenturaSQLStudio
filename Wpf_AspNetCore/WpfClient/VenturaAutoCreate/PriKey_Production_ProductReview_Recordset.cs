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
	/// The updateable table is [Production].[ProductReview]. Updateable table column information:
	/// • 8 out of 8 table columns are present in the resultset.
	/// • All primary key columns are present in the resultset: ProductReviewID.
	/// • Non-primary key columns present in the resultset: ProductID, ReviewerName, ReviewDate, EmailAddress, Rating, Comments
	///   and ModifiedDate.
	/// Recordset item automatically created by VenturaSQL Studio.
	/// </summary>
	public partial class PriKey_Production_ProductReview_Recordset : ResultsetObservable<PriKey_Production_ProductReview_Recordset, PriKey_Production_ProductReview_Record>, IRecordsetBase
	{
		private IResultsetBase[] _resultsets;
		private string _sqlscript;
		private object[] _inputparametervalues;
		private InputParamHolder _inputparamholder;
		private VenturaSqlSchema _parameterschema;
		private int _rowlimit = 500;
		private const string CRLF = "\r\n";

		public PriKey_Production_ProductReview_Recordset()
		{
			_resultsets = new IResultsetBase[] { this };

			_sqlscript = @"SELECT [ProductReviewID],[ProductID],[ReviewerName],[ReviewDate],[EmailAddress],[Rating],[Comments],[ModifiedDate]" + CRLF +
			             @"FROM [Production].[ProductReview]" + CRLF +
			             @"WHERE [ProductReviewID] = @ProductReviewID";

			_inputparametervalues = new object[1];
			_inputparamholder = new InputParamHolder(_inputparametervalues);

			ColumnArrayBuilder param_array = new ColumnArrayBuilder();

			param_array.AddParameterColumn("@ProductReviewID", typeof(int), true, false, DbType.Int32, null, null, null);

			_parameterschema = new VenturaSqlSchema(param_array);

			ColumnArrayBuilder schema_array = new ColumnArrayBuilder();

			schema_array.Add(new VenturaSqlColumn("ProductReviewID", typeof(int), false)
			{
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				IsKey = true,
				IsIdentity = true,
				IsAutoIncrement = true,
				BaseSchemaName = "Production",
				BaseTableName = "ProductReview",
				BaseColumnName = "ProductReviewID"
			});

			schema_array.Add(new VenturaSqlColumn("ProductID", typeof(int), false)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				BaseSchemaName = "Production",
				BaseTableName = "ProductReview",
				BaseColumnName = "ProductID"
			});

			schema_array.Add(new VenturaSqlColumn("ReviewerName", typeof(string), false)
			{
				Updateable = true,
				ColumnSize = 50,
				ProviderType = 12,
				BaseSchemaName = "Production",
				BaseTableName = "ProductReview",
				BaseColumnName = "ReviewerName"
			});

			schema_array.Add(new VenturaSqlColumn("ReviewDate", typeof(DateTime), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 23,
				NumericScale = 3,
				ProviderType = 4,
				BaseSchemaName = "Production",
				BaseTableName = "ProductReview",
				BaseColumnName = "ReviewDate"
			});

			schema_array.Add(new VenturaSqlColumn("EmailAddress", typeof(string), false)
			{
				Updateable = true,
				ColumnSize = 50,
				ProviderType = 12,
				BaseSchemaName = "Production",
				BaseTableName = "ProductReview",
				BaseColumnName = "EmailAddress"
			});

			schema_array.Add(new VenturaSqlColumn("Rating", typeof(int), false)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				BaseSchemaName = "Production",
				BaseTableName = "ProductReview",
				BaseColumnName = "Rating"
			});

			schema_array.Add(new VenturaSqlColumn("Comments", typeof(string), true)
			{
				Updateable = true,
				ColumnSize = 3850,
				ProviderType = 12,
				BaseSchemaName = "Production",
				BaseTableName = "ProductReview",
				BaseColumnName = "Comments"
			});

			schema_array.Add(new VenturaSqlColumn("ModifiedDate", typeof(DateTime), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 23,
				NumericScale = 3,
				ProviderType = 4,
				BaseSchemaName = "Production",
				BaseTableName = "ProductReview",
				BaseColumnName = "ModifiedDate"
			});

			((IResultsetBase)this).Schema = new VenturaSqlSchema(schema_array);
			((IResultsetBase)this).UpdateableTablename = "[Production].[ProductReview]";
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Production].[ProductReview]. PrimaryKey. NotReadonly. NotNull. IsIdentity. AutoIncrement.
		/// </summary>
		public int ProductReviewID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ProductReviewID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ProductReviewID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductReview]. NotReadonly. NotNull.
		/// </summary>
		public int ProductID
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ProductID; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ProductID = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductReview]. NotReadonly. NotNull.
		/// </summary>
		public string ReviewerName
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ReviewerName; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ReviewerName = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductReview]. NotReadonly. NotNull.
		/// </summary>
		public DateTime ReviewDate
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ReviewDate; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ReviewDate = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductReview]. NotReadonly. NotNull.
		/// </summary>
		public string EmailAddress
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.EmailAddress; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.EmailAddress = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductReview]. NotReadonly. NotNull.
		/// </summary>
		public int Rating
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Rating; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Rating = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductReview]. NotReadonly. AllowNull.
		/// </summary>
		public string Comments
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Comments; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Comments = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductReview]. NotReadonly. NotNull.
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
			this.InsertItem(index, new PriKey_Production_ProductReview_Record());
			this.CurrentRecordIndex = index;
		}

		public void Append(PriKey_Production_ProductReview_Record record)
		{
			int index = this.RecordCount;
			this.InsertItem(index, record);
			this.CurrentRecordIndex = index;
		}

		public PriKey_Production_ProductReview_Record NewRecord()
		{
			return new PriKey_Production_ProductReview_Record();
		}

		protected override PriKey_Production_ProductReview_Record InternalCreateExistingRecordObject(object[] columnvalues) => new PriKey_Production_ProductReview_Record(columnvalues);

		byte[] IRecordsetBase.Hash
		{
			get { return new byte[] { 194, 7, 165, 16, 253, 204, 36, 221, 154, 116, 76, 7, 91, 79, 73, 66 }; }
		}

		string IRecordsetBase.HashString
		{
			get { return "C207A510FDCC24DD9A744C075B4F4942"; }
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

		public void SetExecSqlParams(int? ProductReviewID)
		{
			_inputparametervalues[0] = ProductReviewID;
		}

		public void ExecSql(int? ProductReviewID)
		{
			_inputparametervalues[0] = ProductReviewID;
			Transactional.ExecSql(VenturaSqlConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public void ExecSql(Connector connector, int? ProductReviewID)
		{
			_inputparametervalues[0] = ProductReviewID;
			Transactional.ExecSql(connector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync(int? ProductReviewID)
		{
			_inputparametervalues[0] = ProductReviewID;
			await Transactional.ExecSqlAsync(VenturaSqlConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync(Connector connector, int? ProductReviewID)
		{
			_inputparametervalues[0] = ProductReviewID;
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

			public int? ProductReviewID
			{
				get { return (int?)_values[0]; }
				set { _values[0] = value; }
			}

		}

	}

	public sealed partial class PriKey_Production_ProductReview_Record : IRecordBase, INotifyPropertyChanged
	{
		private DataRecordStatus _recordstatus;
		private bool _started_with_dbvalues;

		private int _cur__ProductReviewID; private int _ori__ProductReviewID; private bool _mod__ProductReviewID;
		private int _cur__ProductID; private int _ori__ProductID; private bool _mod__ProductID;
		private string _cur__ReviewerName; private string _ori__ReviewerName; private bool _mod__ReviewerName;
		private DateTime _cur__ReviewDate; private DateTime _ori__ReviewDate; private bool _mod__ReviewDate;
		private string _cur__EmailAddress; private string _ori__EmailAddress; private bool _mod__EmailAddress;
		private int _cur__Rating; private int _ori__Rating; private bool _mod__Rating;
		private string _cur__Comments; private string _ori__Comments; private bool _mod__Comments;
		private DateTime _cur__ModifiedDate; private DateTime _ori__ModifiedDate; private bool _mod__ModifiedDate;


		public PriKey_Production_ProductReview_Record()
		{
			_cur__ProductReviewID = 0;
			_cur__ProductID = 0;
			_cur__ReviewerName = "";
			_cur__ReviewDate = new DateTime(1900, 1, 1);
			_cur__EmailAddress = "";
			_cur__Rating = 0;
			_cur__Comments = null;
			_cur__ModifiedDate = new DateTime(1900, 1, 1);
			_started_with_dbvalues = false;
			_recordstatus = DataRecordStatus.New;
		}

		public PriKey_Production_ProductReview_Record(object[] columnvalues)
		{
			_cur__ProductReviewID = (int)columnvalues[0];
			_cur__ProductID = (int)columnvalues[1];
			_cur__ReviewerName = (string)columnvalues[2];
			_cur__ReviewDate = (DateTime)columnvalues[3];
			_cur__EmailAddress = (string)columnvalues[4];
			_cur__Rating = (int)columnvalues[5];
			_cur__Comments = (string)columnvalues[6];
			_cur__ModifiedDate = (DateTime)columnvalues[7];
			_started_with_dbvalues = true;
			_recordstatus = DataRecordStatus.Existing;
		}

		/// <summary>
		/// Database Column NotUpdateable. Table [Production].[ProductReview]. PrimaryKey. NotReadonly. NotNull. IsIdentity. AutoIncrement.
		/// </summary>
		public int ProductReviewID
		{
			get { return _cur__ProductReviewID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ProductReviewID = true;
				if (_cur__ProductReviewID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ProductReviewID == false) { _ori__ProductReviewID = _cur__ProductReviewID; _mod__ProductReviewID = true; } // existing record and column is not modified
					else { if (value == _ori__ProductReviewID) { _ori__ProductReviewID = default(int); _mod__ProductReviewID = false; } } // existing record and column is modified
				}
				_cur__ProductReviewID = value; OnPropertyChanged("ProductReviewID"); OnAfterPropertyChanged("ProductReviewID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductReview]. NotReadonly. NotNull.
		/// </summary>
		public int ProductID
		{
			get { return _cur__ProductID; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ProductID = true;
				if (_cur__ProductID == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ProductID == false) { _ori__ProductID = _cur__ProductID; _mod__ProductID = true; } // existing record and column is not modified
					else { if (value == _ori__ProductID) { _ori__ProductID = default(int); _mod__ProductID = false; } } // existing record and column is modified
				}
				_cur__ProductID = value; OnPropertyChanged("ProductID"); OnAfterPropertyChanged("ProductID");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductReview]. NotReadonly. NotNull.
		/// </summary>
		public string ReviewerName
		{
			get { return _cur__ReviewerName; }
			set
			{
				if (value == null) throw new ArgumentNullException("ReviewerName", VenturaSqlStrings.SET_NULL_MSG);
				if (_started_with_dbvalues == false) _mod__ReviewerName = true;
				if (_cur__ReviewerName == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ReviewerName == false) { _ori__ReviewerName = _cur__ReviewerName; _mod__ReviewerName = true; } // existing record and column is not modified
					else { if (value == _ori__ReviewerName) { _ori__ReviewerName = default(string); _mod__ReviewerName = false; } } // existing record and column is modified
				}
				_cur__ReviewerName = value; OnPropertyChanged("ReviewerName"); OnAfterPropertyChanged("ReviewerName");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductReview]. NotReadonly. NotNull.
		/// </summary>
		public DateTime ReviewDate
		{
			get { return _cur__ReviewDate; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ReviewDate = true;
				if (_cur__ReviewDate == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ReviewDate == false) { _ori__ReviewDate = _cur__ReviewDate; _mod__ReviewDate = true; } // existing record and column is not modified
					else { if (value == _ori__ReviewDate) { _ori__ReviewDate = default(DateTime); _mod__ReviewDate = false; } } // existing record and column is modified
				}
				_cur__ReviewDate = value; OnPropertyChanged("ReviewDate"); OnAfterPropertyChanged("ReviewDate");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductReview]. NotReadonly. NotNull.
		/// </summary>
		public string EmailAddress
		{
			get { return _cur__EmailAddress; }
			set
			{
				if (value == null) throw new ArgumentNullException("EmailAddress", VenturaSqlStrings.SET_NULL_MSG);
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
		/// Database Column Updateable. Table [Production].[ProductReview]. NotReadonly. NotNull.
		/// </summary>
		public int Rating
		{
			get { return _cur__Rating; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Rating = true;
				if (_cur__Rating == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Rating == false) { _ori__Rating = _cur__Rating; _mod__Rating = true; } // existing record and column is not modified
					else { if (value == _ori__Rating) { _ori__Rating = default(int); _mod__Rating = false; } } // existing record and column is modified
				}
				_cur__Rating = value; OnPropertyChanged("Rating"); OnAfterPropertyChanged("Rating");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductReview]. NotReadonly. AllowNull.
		/// </summary>
		public string Comments
		{
			get { return _cur__Comments; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Comments = true;
				if (_cur__Comments == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Comments == false) { _ori__Comments = _cur__Comments; _mod__Comments = true; } // existing record and column is not modified
					else { if (value == _ori__Comments) { _ori__Comments = default(string); _mod__Comments = false; } } // existing record and column is modified
				}
				_cur__Comments = value; OnPropertyChanged("Comments"); OnAfterPropertyChanged("Comments");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[ProductReview]. NotReadonly. NotNull.
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
			if (column_name == "ProductReviewID") return _mod__ProductReviewID;
			if (column_name == "ProductID") return _mod__ProductID;
			if (column_name == "ReviewerName") return _mod__ReviewerName;
			if (column_name == "ReviewDate") return _mod__ReviewDate;
			if (column_name == "EmailAddress") return _mod__EmailAddress;
			if (column_name == "Rating") return _mod__Rating;
			if (column_name == "Comments") return _mod__Comments;
			if (column_name == "ModifiedDate") return _mod__ModifiedDate;
			throw new ArgumentOutOfRangeException(String.Format(VenturaSqlStrings.UNKNOWN_COLUMN_NAME, column_name));
		}

		public int ModifiedColumnCount()
		{
			int count = 0;
			if (_mod__ProductReviewID == true) count++;
			if (_mod__ProductID == true) count++;
			if (_mod__ReviewerName == true) count++;
			if (_mod__ReviewDate == true) count++;
			if (_mod__EmailAddress == true) count++;
			if (_mod__Rating == true) count++;
			if (_mod__Comments == true) count++;
			if (_mod__ModifiedDate == true) count++;
			return count;
		}

		public bool PendingChanges()
		{
			if (_recordstatus == DataRecordStatus.New || _recordstatus == DataRecordStatus.ExistingDelete) return true;
			int count = 0;
			if (_mod__ProductID == true) count++;
			if (_mod__ReviewerName == true) count++;
			if (_mod__ReviewDate == true) count++;
			if (_mod__EmailAddress == true) count++;
			if (_mod__Rating == true) count++;
			if (_mod__Comments == true) count++;
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
				track_array.AppendDataValue(1, _cur__ProductID);
				track_array.AppendDataValue(2, _cur__ReviewerName);
				track_array.AppendDataValue(3, _cur__ReviewDate);
				track_array.AppendDataValue(4, _cur__EmailAddress);
				track_array.AppendDataValue(5, _cur__Rating);
				if (_cur__Comments != null) track_array.AppendDataValue(6, _cur__Comments);
				track_array.AppendDataValue(7, _cur__ModifiedDate);
			}
			else if (_recordstatus == DataRecordStatus.Existing)
			{
				if (_mod__ProductID) track_array.AppendDataValue(1, _cur__ProductID);
				if (_mod__ReviewerName) track_array.AppendDataValue(2, _cur__ReviewerName);
				if (_mod__ReviewDate) track_array.AppendDataValue(3, _cur__ReviewDate);
				if (_mod__EmailAddress) track_array.AppendDataValue(4, _cur__EmailAddress);
				if (_mod__Rating) track_array.AppendDataValue(5, _cur__Rating);
				if (_mod__Comments) track_array.AppendDataValue(6, _cur__Comments);
				if (_mod__ModifiedDate) track_array.AppendDataValue(7, _cur__ModifiedDate);
				if (track_array.HasData == false) return;
			}

			if (_recordstatus == DataRecordStatus.Existing || _recordstatus == DataRecordStatus.ExistingDelete)
			{
				track_array.AppendPrikeyValue(0, (_mod__ProductReviewID && _started_with_dbvalues) ? _ori__ProductReviewID : _cur__ProductReviewID);
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
				if (_mod__ProductReviewID) _ori__ProductReviewID = default(int);
				if (_mod__ProductID) _ori__ProductID = default(int);
				if (_mod__ReviewerName) _ori__ReviewerName = default(string);
				if (_mod__ReviewDate) _ori__ReviewDate = default(DateTime);
				if (_mod__EmailAddress) _ori__EmailAddress = default(string);
				if (_mod__Rating) _ori__Rating = default(int);
				if (_mod__Comments) _ori__Comments = default(string);
				if (_mod__ModifiedDate) _ori__ModifiedDate = default(DateTime);
			}
			_mod__ProductReviewID = false;
			_mod__ProductID = false;
			_mod__ReviewerName = false;
			_mod__ReviewDate = false;
			_mod__EmailAddress = false;
			_mod__Rating = false;
			_mod__Comments = false;
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
			_cur__ProductReviewID = (int)value;
			OnPropertyChanged("ProductReviewID");
			OnAfterPropertyChanged("ProductReviewID");
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
	public partial class PriKey_Production_ProductReview_Record
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
