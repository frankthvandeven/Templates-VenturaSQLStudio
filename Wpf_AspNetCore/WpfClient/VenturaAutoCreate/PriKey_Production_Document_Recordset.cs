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
	/// The updateable table is [Production].[Document]. Updateable table column information:
	/// • 14 out of 14 table columns are present in the resultset.
	/// • All primary key columns are present in the resultset: DocumentNode.
	/// • Non-primary key columns present in the resultset: DocumentLevel, Title, Owner, FolderFlag, FileName, FileExtension,
	///   Revision, ChangeNumber, Status, DocumentSummary, Document, rowguid and ModifiedDate.
	/// Recordset item automatically created by VenturaSQL Studio.
	/// </summary>
	public partial class PriKey_Production_Document_Recordset : ResultsetObservable<PriKey_Production_Document_Recordset, PriKey_Production_Document_Record>, IRecordsetBase
	{
		private IResultsetBase[] _resultsets;
		private string _sqlscript;
		private object[] _inputparametervalues;
		private InputParamHolder _inputparamholder;
		private VenturaSqlSchema _parameterschema;
		private int _rowlimit = 500;
		private const string CRLF = "\r\n";

		public PriKey_Production_Document_Recordset()
		{
			_resultsets = new IResultsetBase[] { this };

			_sqlscript = @"SELECT [DocumentNode],[DocumentLevel],[Title],[Owner],[FolderFlag],[FileName],[FileExtension],[Revision],[ChangeNumber],[Status],[DocumentSummary],[Document]," + CRLF +
			             @"[rowguid],[ModifiedDate]" + CRLF +
			             @"FROM [Production].[Document]" + CRLF +
			             @"WHERE [DocumentNode] = @DocumentNode";

			_inputparametervalues = new object[1];
			_inputparamholder = new InputParamHolder(_inputparametervalues);

			ColumnArrayBuilder param_array = new ColumnArrayBuilder();

			param_array.AddParameterColumn("@DocumentNode", typeof(object), true, false, DbType.Object, null, null, null);

			_parameterschema = new VenturaSqlSchema(param_array);

			ColumnArrayBuilder schema_array = new ColumnArrayBuilder();

			schema_array.Add(new VenturaSqlColumn("DocumentNode", typeof(object), false)
			{
				Updateable = true,
				ColumnSize = 892,
				ProviderType = 29,
				IsKey = true,
				UdtAssemblyQualifiedName = "Microsoft.SqlServer.Types.SqlHierarchyId, Microsoft.SqlServer.Types, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91",
				BaseSchemaName = "Production",
				BaseTableName = "Document",
				BaseColumnName = "DocumentNode"
			});

			schema_array.Add(new VenturaSqlColumn("DocumentLevel", typeof(short), true)
			{
				Updateable = true,
				ColumnSize = 2,
				NumericPrecision = 5,
				ProviderType = 16,
				BaseSchemaName = "Production",
				BaseTableName = "Document",
				BaseColumnName = "DocumentLevel"
			});

			schema_array.Add(new VenturaSqlColumn("Title", typeof(string), false)
			{
				Updateable = true,
				ColumnSize = 50,
				ProviderType = 12,
				BaseSchemaName = "Production",
				BaseTableName = "Document",
				BaseColumnName = "Title"
			});

			schema_array.Add(new VenturaSqlColumn("Owner", typeof(int), false)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				BaseSchemaName = "Production",
				BaseTableName = "Document",
				BaseColumnName = "Owner"
			});

			schema_array.Add(new VenturaSqlColumn("FolderFlag", typeof(bool), false)
			{
				Updateable = true,
				ColumnSize = 1,
				ProviderType = 2,
				BaseSchemaName = "Production",
				BaseTableName = "Document",
				BaseColumnName = "FolderFlag"
			});

			schema_array.Add(new VenturaSqlColumn("FileName", typeof(string), false)
			{
				Updateable = true,
				ColumnSize = 400,
				ProviderType = 12,
				BaseSchemaName = "Production",
				BaseTableName = "Document",
				BaseColumnName = "FileName"
			});

			schema_array.Add(new VenturaSqlColumn("FileExtension", typeof(string), false)
			{
				Updateable = true,
				ColumnSize = 8,
				ProviderType = 12,
				BaseSchemaName = "Production",
				BaseTableName = "Document",
				BaseColumnName = "FileExtension"
			});

			schema_array.Add(new VenturaSqlColumn("Revision", typeof(string), false)
			{
				Updateable = true,
				ColumnSize = 5,
				ProviderType = 10,
				BaseSchemaName = "Production",
				BaseTableName = "Document",
				BaseColumnName = "Revision"
			});

			schema_array.Add(new VenturaSqlColumn("ChangeNumber", typeof(int), false)
			{
				Updateable = true,
				ColumnSize = 4,
				NumericPrecision = 10,
				ProviderType = 8,
				BaseSchemaName = "Production",
				BaseTableName = "Document",
				BaseColumnName = "ChangeNumber"
			});

			schema_array.Add(new VenturaSqlColumn("Status", typeof(byte), false)
			{
				Updateable = true,
				ColumnSize = 1,
				NumericPrecision = 3,
				ProviderType = 20,
				BaseSchemaName = "Production",
				BaseTableName = "Document",
				BaseColumnName = "Status"
			});

			schema_array.Add(new VenturaSqlColumn("DocumentSummary", typeof(string), true)
			{
				Updateable = true,
				ProviderType = 12,
				IsLong = true,
				BaseSchemaName = "Production",
				BaseTableName = "Document",
				BaseColumnName = "DocumentSummary"
			});

			schema_array.Add(new VenturaSqlColumn("Document", typeof(byte[]), true)
			{
				Updateable = true,
				ProviderType = 21,
				IsLong = true,
				BaseSchemaName = "Production",
				BaseTableName = "Document",
				BaseColumnName = "Document"
			});

			schema_array.Add(new VenturaSqlColumn("rowguid", typeof(Guid), false)
			{
				Updateable = true,
				ColumnSize = 16,
				ProviderType = 14,
				BaseSchemaName = "Production",
				BaseTableName = "Document",
				BaseColumnName = "rowguid"
			});

			schema_array.Add(new VenturaSqlColumn("ModifiedDate", typeof(DateTime), false)
			{
				Updateable = true,
				ColumnSize = 8,
				NumericPrecision = 23,
				NumericScale = 3,
				ProviderType = 4,
				BaseSchemaName = "Production",
				BaseTableName = "Document",
				BaseColumnName = "ModifiedDate"
			});

			((IResultsetBase)this).Schema = new VenturaSqlSchema(schema_array);
			((IResultsetBase)this).UpdateableTablename = "[Production].[Document]";
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Document]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public object DocumentNode
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.DocumentNode; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.DocumentNode = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Document]. NotReadonly. AllowNull.
		/// </summary>
		public short? DocumentLevel
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.DocumentLevel; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.DocumentLevel = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Document]. NotReadonly. NotNull.
		/// </summary>
		public string Title
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Title; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Title = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Document]. NotReadonly. NotNull.
		/// </summary>
		public int Owner
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Owner; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Owner = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Document]. NotReadonly. NotNull.
		/// </summary>
		public bool FolderFlag
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.FolderFlag; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.FolderFlag = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Document]. NotReadonly. NotNull.
		/// </summary>
		public string FileName
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.FileName; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.FileName = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Document]. NotReadonly. NotNull.
		/// </summary>
		public string FileExtension
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.FileExtension; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.FileExtension = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Document]. NotReadonly. NotNull.
		/// </summary>
		public string Revision
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Revision; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Revision = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Document]. NotReadonly. NotNull.
		/// </summary>
		public int ChangeNumber
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.ChangeNumber; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.ChangeNumber = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Document]. NotReadonly. NotNull.
		/// </summary>
		public byte Status
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Status; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Status = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Document]. NotReadonly. AllowNull.
		/// </summary>
		public string DocumentSummary
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.DocumentSummary; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.DocumentSummary = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Document]. NotReadonly. AllowNull.
		/// </summary>
		public byte[] Document
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.Document; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.Document = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Document]. NotReadonly. NotNull.
		/// </summary>
		public Guid rowguid
		{
			get { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); return CurrentRecord.rowguid; }
			set { if (CurrentRecord == null) throw new InvalidOperationException(VenturaSqlStrings.CURRENT_RECORD_NOT_SET); CurrentRecord.rowguid = value; }
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Document]. NotReadonly. NotNull.
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
			this.InsertItem(index, new PriKey_Production_Document_Record());
			this.CurrentRecordIndex = index;
		}

		public void Append(PriKey_Production_Document_Record record)
		{
			int index = this.RecordCount;
			this.InsertItem(index, record);
			this.CurrentRecordIndex = index;
		}

		public PriKey_Production_Document_Record NewRecord()
		{
			return new PriKey_Production_Document_Record();
		}

		protected override PriKey_Production_Document_Record InternalCreateExistingRecordObject(object[] columnvalues) => new PriKey_Production_Document_Record(columnvalues);

		byte[] IRecordsetBase.Hash
		{
			get { return new byte[] { 68, 248, 26, 191, 251, 206, 30, 174, 118, 208, 176, 10, 171, 155, 169, 124 }; }
		}

		string IRecordsetBase.HashString
		{
			get { return "44F81ABFFBCE1EAE76D0B00AAB9BA97C"; }
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

		public void SetExecSqlParams(object DocumentNode)
		{
			_inputparametervalues[0] = DocumentNode;
		}

		public void ExecSql(object DocumentNode)
		{
			_inputparametervalues[0] = DocumentNode;
			Transactional.ExecSql(VenturaSqlConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public void ExecSql(Connector connector, object DocumentNode)
		{
			_inputparametervalues[0] = DocumentNode;
			Transactional.ExecSql(connector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync(object DocumentNode)
		{
			_inputparametervalues[0] = DocumentNode;
			await Transactional.ExecSqlAsync(VenturaSqlConfig.DefaultConnector, new IRecordsetBase[] { this });
		}

		public async Task ExecSqlAsync(Connector connector, object DocumentNode)
		{
			_inputparametervalues[0] = DocumentNode;
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

			public object DocumentNode
			{
				get { return (object)_values[0]; }
				set { _values[0] = value; }
			}

		}

	}

	public sealed partial class PriKey_Production_Document_Record : IRecordBase, INotifyPropertyChanged
	{
		private DataRecordStatus _recordstatus;
		private bool _started_with_dbvalues;

		private object _cur__DocumentNode; private object _ori__DocumentNode; private bool _mod__DocumentNode;
		private short? _cur__DocumentLevel; private short? _ori__DocumentLevel; private bool _mod__DocumentLevel;
		private string _cur__Title; private string _ori__Title; private bool _mod__Title;
		private int _cur__Owner; private int _ori__Owner; private bool _mod__Owner;
		private bool _cur__FolderFlag; private bool _ori__FolderFlag; private bool _mod__FolderFlag;
		private string _cur__FileName; private string _ori__FileName; private bool _mod__FileName;
		private string _cur__FileExtension; private string _ori__FileExtension; private bool _mod__FileExtension;
		private string _cur__Revision; private string _ori__Revision; private bool _mod__Revision;
		private int _cur__ChangeNumber; private int _ori__ChangeNumber; private bool _mod__ChangeNumber;
		private byte _cur__Status; private byte _ori__Status; private bool _mod__Status;
		private string _cur__DocumentSummary; private string _ori__DocumentSummary; private bool _mod__DocumentSummary;
		private byte[] _cur__Document; private byte[] _ori__Document; private bool _mod__Document;
		private Guid _cur__rowguid; private Guid _ori__rowguid; private bool _mod__rowguid;
		private DateTime _cur__ModifiedDate; private DateTime _ori__ModifiedDate; private bool _mod__ModifiedDate;


		public PriKey_Production_Document_Record()
		{
			_cur__DocumentNode = new object();
			_cur__DocumentLevel = null;
			_cur__Title = "";
			_cur__Owner = 0;
			_cur__FolderFlag = false;
			_cur__FileName = "";
			_cur__FileExtension = "";
			_cur__Revision = "";
			_cur__ChangeNumber = 0;
			_cur__Status = 0;
			_cur__DocumentSummary = null;
			_cur__Document = null;
			_cur__rowguid = Guid.Empty;
			_cur__ModifiedDate = new DateTime(1900, 1, 1);
			_started_with_dbvalues = false;
			_recordstatus = DataRecordStatus.New;
		}

		public PriKey_Production_Document_Record(object[] columnvalues)
		{
			_cur__DocumentNode = (object)columnvalues[0];
			_cur__DocumentLevel = (short?)columnvalues[1];
			_cur__Title = (string)columnvalues[2];
			_cur__Owner = (int)columnvalues[3];
			_cur__FolderFlag = (bool)columnvalues[4];
			_cur__FileName = (string)columnvalues[5];
			_cur__FileExtension = (string)columnvalues[6];
			_cur__Revision = (string)columnvalues[7];
			_cur__ChangeNumber = (int)columnvalues[8];
			_cur__Status = (byte)columnvalues[9];
			_cur__DocumentSummary = (string)columnvalues[10];
			_cur__Document = (byte[])columnvalues[11];
			_cur__rowguid = (Guid)columnvalues[12];
			_cur__ModifiedDate = (DateTime)columnvalues[13];
			_started_with_dbvalues = true;
			_recordstatus = DataRecordStatus.Existing;
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Document]. PrimaryKey. NotReadonly. NotNull.
		/// </summary>
		public object DocumentNode
		{
			get { return _cur__DocumentNode; }
			set
			{
				if (value == null) throw new ArgumentNullException("DocumentNode", VenturaSqlStrings.SET_NULL_MSG);
				if (_started_with_dbvalues == false) _mod__DocumentNode = true;
				if (_cur__DocumentNode == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__DocumentNode == false) { _ori__DocumentNode = _cur__DocumentNode; _mod__DocumentNode = true; } // existing record and column is not modified
					else { if (value == _ori__DocumentNode) { _ori__DocumentNode = default(object); _mod__DocumentNode = false; } } // existing record and column is modified
				}
				_cur__DocumentNode = value; OnPropertyChanged("DocumentNode"); OnAfterPropertyChanged("DocumentNode");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Document]. NotReadonly. AllowNull.
		/// </summary>
		public short? DocumentLevel
		{
			get { return _cur__DocumentLevel; }
			set
			{
				if (_started_with_dbvalues == false) _mod__DocumentLevel = true;
				if (_cur__DocumentLevel == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__DocumentLevel == false) { _ori__DocumentLevel = _cur__DocumentLevel; _mod__DocumentLevel = true; } // existing record and column is not modified
					else { if (value == _ori__DocumentLevel) { _ori__DocumentLevel = default(short?); _mod__DocumentLevel = false; } } // existing record and column is modified
				}
				_cur__DocumentLevel = value; OnPropertyChanged("DocumentLevel"); OnAfterPropertyChanged("DocumentLevel");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Document]. NotReadonly. NotNull.
		/// </summary>
		public string Title
		{
			get { return _cur__Title; }
			set
			{
				if (value == null) throw new ArgumentNullException("Title", VenturaSqlStrings.SET_NULL_MSG);
				if (_started_with_dbvalues == false) _mod__Title = true;
				if (_cur__Title == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Title == false) { _ori__Title = _cur__Title; _mod__Title = true; } // existing record and column is not modified
					else { if (value == _ori__Title) { _ori__Title = default(string); _mod__Title = false; } } // existing record and column is modified
				}
				_cur__Title = value; OnPropertyChanged("Title"); OnAfterPropertyChanged("Title");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Document]. NotReadonly. NotNull.
		/// </summary>
		public int Owner
		{
			get { return _cur__Owner; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Owner = true;
				if (_cur__Owner == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Owner == false) { _ori__Owner = _cur__Owner; _mod__Owner = true; } // existing record and column is not modified
					else { if (value == _ori__Owner) { _ori__Owner = default(int); _mod__Owner = false; } } // existing record and column is modified
				}
				_cur__Owner = value; OnPropertyChanged("Owner"); OnAfterPropertyChanged("Owner");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Document]. NotReadonly. NotNull.
		/// </summary>
		public bool FolderFlag
		{
			get { return _cur__FolderFlag; }
			set
			{
				if (_started_with_dbvalues == false) _mod__FolderFlag = true;
				if (_cur__FolderFlag == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__FolderFlag == false) { _ori__FolderFlag = _cur__FolderFlag; _mod__FolderFlag = true; } // existing record and column is not modified
					else { if (value == _ori__FolderFlag) { _ori__FolderFlag = default(bool); _mod__FolderFlag = false; } } // existing record and column is modified
				}
				_cur__FolderFlag = value; OnPropertyChanged("FolderFlag"); OnAfterPropertyChanged("FolderFlag");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Document]. NotReadonly. NotNull.
		/// </summary>
		public string FileName
		{
			get { return _cur__FileName; }
			set
			{
				if (value == null) throw new ArgumentNullException("FileName", VenturaSqlStrings.SET_NULL_MSG);
				if (_started_with_dbvalues == false) _mod__FileName = true;
				if (_cur__FileName == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__FileName == false) { _ori__FileName = _cur__FileName; _mod__FileName = true; } // existing record and column is not modified
					else { if (value == _ori__FileName) { _ori__FileName = default(string); _mod__FileName = false; } } // existing record and column is modified
				}
				_cur__FileName = value; OnPropertyChanged("FileName"); OnAfterPropertyChanged("FileName");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Document]. NotReadonly. NotNull.
		/// </summary>
		public string FileExtension
		{
			get { return _cur__FileExtension; }
			set
			{
				if (value == null) throw new ArgumentNullException("FileExtension", VenturaSqlStrings.SET_NULL_MSG);
				if (_started_with_dbvalues == false) _mod__FileExtension = true;
				if (_cur__FileExtension == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__FileExtension == false) { _ori__FileExtension = _cur__FileExtension; _mod__FileExtension = true; } // existing record and column is not modified
					else { if (value == _ori__FileExtension) { _ori__FileExtension = default(string); _mod__FileExtension = false; } } // existing record and column is modified
				}
				_cur__FileExtension = value; OnPropertyChanged("FileExtension"); OnAfterPropertyChanged("FileExtension");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Document]. NotReadonly. NotNull.
		/// </summary>
		public string Revision
		{
			get { return _cur__Revision; }
			set
			{
				if (value == null) throw new ArgumentNullException("Revision", VenturaSqlStrings.SET_NULL_MSG);
				if (_started_with_dbvalues == false) _mod__Revision = true;
				if (_cur__Revision == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Revision == false) { _ori__Revision = _cur__Revision; _mod__Revision = true; } // existing record and column is not modified
					else { if (value == _ori__Revision) { _ori__Revision = default(string); _mod__Revision = false; } } // existing record and column is modified
				}
				_cur__Revision = value; OnPropertyChanged("Revision"); OnAfterPropertyChanged("Revision");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Document]. NotReadonly. NotNull.
		/// </summary>
		public int ChangeNumber
		{
			get { return _cur__ChangeNumber; }
			set
			{
				if (_started_with_dbvalues == false) _mod__ChangeNumber = true;
				if (_cur__ChangeNumber == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__ChangeNumber == false) { _ori__ChangeNumber = _cur__ChangeNumber; _mod__ChangeNumber = true; } // existing record and column is not modified
					else { if (value == _ori__ChangeNumber) { _ori__ChangeNumber = default(int); _mod__ChangeNumber = false; } } // existing record and column is modified
				}
				_cur__ChangeNumber = value; OnPropertyChanged("ChangeNumber"); OnAfterPropertyChanged("ChangeNumber");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Document]. NotReadonly. NotNull.
		/// </summary>
		public byte Status
		{
			get { return _cur__Status; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Status = true;
				if (_cur__Status == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Status == false) { _ori__Status = _cur__Status; _mod__Status = true; } // existing record and column is not modified
					else { if (value == _ori__Status) { _ori__Status = default(byte); _mod__Status = false; } } // existing record and column is modified
				}
				_cur__Status = value; OnPropertyChanged("Status"); OnAfterPropertyChanged("Status");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Document]. NotReadonly. AllowNull.
		/// </summary>
		public string DocumentSummary
		{
			get { return _cur__DocumentSummary; }
			set
			{
				if (_started_with_dbvalues == false) _mod__DocumentSummary = true;
				if (_cur__DocumentSummary == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__DocumentSummary == false) { _ori__DocumentSummary = _cur__DocumentSummary; _mod__DocumentSummary = true; } // existing record and column is not modified
					else { if (value == _ori__DocumentSummary) { _ori__DocumentSummary = default(string); _mod__DocumentSummary = false; } } // existing record and column is modified
				}
				_cur__DocumentSummary = value; OnPropertyChanged("DocumentSummary"); OnAfterPropertyChanged("DocumentSummary");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Document]. NotReadonly. AllowNull.
		/// </summary>
		public byte[] Document
		{
			get { return _cur__Document; }
			set
			{
				if (_started_with_dbvalues == false) _mod__Document = true;
				if (_cur__Document == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__Document == false) { _ori__Document = _cur__Document; _mod__Document = true; } // existing record and column is not modified
					else { if (value == _ori__Document) { _ori__Document = default(byte[]); _mod__Document = false; } } // existing record and column is modified
				}
				_cur__Document = value; OnPropertyChanged("Document"); OnAfterPropertyChanged("Document");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Document]. NotReadonly. NotNull.
		/// </summary>
		public Guid rowguid
		{
			get { return _cur__rowguid; }
			set
			{
				if (_started_with_dbvalues == false) _mod__rowguid = true;
				if (_cur__rowguid == value) return;
				if (_started_with_dbvalues == true)
				{
					if (_mod__rowguid == false) { _ori__rowguid = _cur__rowguid; _mod__rowguid = true; } // existing record and column is not modified
					else { if (value == _ori__rowguid) { _ori__rowguid = default(Guid); _mod__rowguid = false; } } // existing record and column is modified
				}
				_cur__rowguid = value; OnPropertyChanged("rowguid"); OnAfterPropertyChanged("rowguid");
			}
		}

		/// <summary>
		/// Database Column Updateable. Table [Production].[Document]. NotReadonly. NotNull.
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
			if (column_name == "DocumentNode") return _mod__DocumentNode;
			if (column_name == "DocumentLevel") return _mod__DocumentLevel;
			if (column_name == "Title") return _mod__Title;
			if (column_name == "Owner") return _mod__Owner;
			if (column_name == "FolderFlag") return _mod__FolderFlag;
			if (column_name == "FileName") return _mod__FileName;
			if (column_name == "FileExtension") return _mod__FileExtension;
			if (column_name == "Revision") return _mod__Revision;
			if (column_name == "ChangeNumber") return _mod__ChangeNumber;
			if (column_name == "Status") return _mod__Status;
			if (column_name == "DocumentSummary") return _mod__DocumentSummary;
			if (column_name == "Document") return _mod__Document;
			if (column_name == "rowguid") return _mod__rowguid;
			if (column_name == "ModifiedDate") return _mod__ModifiedDate;
			throw new ArgumentOutOfRangeException(String.Format(VenturaSqlStrings.UNKNOWN_COLUMN_NAME, column_name));
		}

		public int ModifiedColumnCount()
		{
			int count = 0;
			if (_mod__DocumentNode == true) count++;
			if (_mod__DocumentLevel == true) count++;
			if (_mod__Title == true) count++;
			if (_mod__Owner == true) count++;
			if (_mod__FolderFlag == true) count++;
			if (_mod__FileName == true) count++;
			if (_mod__FileExtension == true) count++;
			if (_mod__Revision == true) count++;
			if (_mod__ChangeNumber == true) count++;
			if (_mod__Status == true) count++;
			if (_mod__DocumentSummary == true) count++;
			if (_mod__Document == true) count++;
			if (_mod__rowguid == true) count++;
			if (_mod__ModifiedDate == true) count++;
			return count;
		}

		public bool PendingChanges()
		{
			if (_recordstatus == DataRecordStatus.New || _recordstatus == DataRecordStatus.ExistingDelete) return true;
			int count = 0;
			if (_started_with_dbvalues)
			{
				if (_mod__DocumentNode) count++;
			}
			if (_mod__DocumentLevel == true) count++;
			if (_mod__Title == true) count++;
			if (_mod__Owner == true) count++;
			if (_mod__FolderFlag == true) count++;
			if (_mod__FileName == true) count++;
			if (_mod__FileExtension == true) count++;
			if (_mod__Revision == true) count++;
			if (_mod__ChangeNumber == true) count++;
			if (_mod__Status == true) count++;
			if (_mod__DocumentSummary == true) count++;
			if (_mod__Document == true) count++;
			if (_mod__rowguid == true) count++;
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
			if (_mod__DocumentNode == false) throw new Exception(string.Format(VenturaSqlStrings.VALUE_NOT_SET_MSG, record_index_to_display, "DocumentNode"));
		}

		void IRecordBase.WriteChangesToTrackArray(TrackArray track_array)
		{
			if (_recordstatus == DataRecordStatus.New)
			{
				track_array.AppendDataValue(0, _cur__DocumentNode);
				if (_cur__DocumentLevel != null) track_array.AppendDataValue(1, _cur__DocumentLevel);
				track_array.AppendDataValue(2, _cur__Title);
				track_array.AppendDataValue(3, _cur__Owner);
				track_array.AppendDataValue(4, _cur__FolderFlag);
				track_array.AppendDataValue(5, _cur__FileName);
				track_array.AppendDataValue(6, _cur__FileExtension);
				track_array.AppendDataValue(7, _cur__Revision);
				track_array.AppendDataValue(8, _cur__ChangeNumber);
				track_array.AppendDataValue(9, _cur__Status);
				if (_cur__DocumentSummary != null) track_array.AppendDataValue(10, _cur__DocumentSummary);
				if (_cur__Document != null) track_array.AppendDataValue(11, _cur__Document);
				track_array.AppendDataValue(12, _cur__rowguid);
				track_array.AppendDataValue(13, _cur__ModifiedDate);
			}
			else if (_recordstatus == DataRecordStatus.Existing)
			{
				if (_started_with_dbvalues)
				{
					if (_mod__DocumentNode) track_array.AppendDataValue(0, _cur__DocumentNode);
				}
				if (_mod__DocumentLevel) track_array.AppendDataValue(1, _cur__DocumentLevel);
				if (_mod__Title) track_array.AppendDataValue(2, _cur__Title);
				if (_mod__Owner) track_array.AppendDataValue(3, _cur__Owner);
				if (_mod__FolderFlag) track_array.AppendDataValue(4, _cur__FolderFlag);
				if (_mod__FileName) track_array.AppendDataValue(5, _cur__FileName);
				if (_mod__FileExtension) track_array.AppendDataValue(6, _cur__FileExtension);
				if (_mod__Revision) track_array.AppendDataValue(7, _cur__Revision);
				if (_mod__ChangeNumber) track_array.AppendDataValue(8, _cur__ChangeNumber);
				if (_mod__Status) track_array.AppendDataValue(9, _cur__Status);
				if (_mod__DocumentSummary) track_array.AppendDataValue(10, _cur__DocumentSummary);
				if (_mod__Document) track_array.AppendDataValue(11, _cur__Document);
				if (_mod__rowguid) track_array.AppendDataValue(12, _cur__rowguid);
				if (_mod__ModifiedDate) track_array.AppendDataValue(13, _cur__ModifiedDate);
				if (track_array.HasData == false) return;
			}

			if (_recordstatus == DataRecordStatus.Existing || _recordstatus == DataRecordStatus.ExistingDelete)
			{
				track_array.AppendPrikeyValue(0, (_mod__DocumentNode && _started_with_dbvalues) ? _ori__DocumentNode : _cur__DocumentNode);
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
				if (_mod__DocumentNode) _ori__DocumentNode = default(object);
				if (_mod__DocumentLevel) _ori__DocumentLevel = default(short?);
				if (_mod__Title) _ori__Title = default(string);
				if (_mod__Owner) _ori__Owner = default(int);
				if (_mod__FolderFlag) _ori__FolderFlag = default(bool);
				if (_mod__FileName) _ori__FileName = default(string);
				if (_mod__FileExtension) _ori__FileExtension = default(string);
				if (_mod__Revision) _ori__Revision = default(string);
				if (_mod__ChangeNumber) _ori__ChangeNumber = default(int);
				if (_mod__Status) _ori__Status = default(byte);
				if (_mod__DocumentSummary) _ori__DocumentSummary = default(string);
				if (_mod__Document) _ori__Document = default(byte[]);
				if (_mod__rowguid) _ori__rowguid = default(Guid);
				if (_mod__ModifiedDate) _ori__ModifiedDate = default(DateTime);
			}
			_mod__DocumentNode = false;
			_mod__DocumentLevel = false;
			_mod__Title = false;
			_mod__Owner = false;
			_mod__FolderFlag = false;
			_mod__FileName = false;
			_mod__FileExtension = false;
			_mod__Revision = false;
			_mod__ChangeNumber = false;
			_mod__Status = false;
			_mod__DocumentSummary = false;
			_mod__Document = false;
			_mod__rowguid = false;
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
namespace WpfClient.VenturaAutoCreate
{
	public partial class PriKey_Production_Document_Record
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
