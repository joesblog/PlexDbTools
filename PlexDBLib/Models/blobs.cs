using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
using System.ComponentModel;

#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Models {
	public class blobs {
		public List<string> changedProperties = new List<string>();
		#region fields
			private Int32 _id;// sqllite type = INTEGER
			private Byte[] _blob;// sqllite type = BLOB
			private String _linked_type;// sqllite type = varchar(255)
			private Int32 _linked_id;// sqllite type = INTEGER
			private String _linked_guid;// sqllite type = varchar(255)
			private Int64 _created_at;// sqllite type = dt_integer(8)
			private Int32 _blob_type;// sqllite type = INTEGER
		#endregion
		#region props
			public Int32 @id
			{
				get
				{
					return this._id;
				}
				set
				{
					if (_id != value)
					{
						_id = value;
						this.changedProperties.Add("id");
					}
				}
			}
			
			public Byte[] @blob
			{
				get
				{
					return this._blob;
				}
				set
				{
					if (_blob != value)
					{
						_blob = value;
						this.changedProperties.Add("blob");
					}
				}
			}
			
			public String @linked_type
			{
				get
				{
					return this._linked_type;
				}
				set
				{
					if (_linked_type != value)
					{
						_linked_type = value;
						this.changedProperties.Add("linked_type");
					}
				}
			}
			
			public Int32 @linked_id
			{
				get
				{
					return this._linked_id;
				}
				set
				{
					if (_linked_id != value)
					{
						_linked_id = value;
						this.changedProperties.Add("linked_id");
					}
				}
			}
			
			public String @linked_guid
			{
				get
				{
					return this._linked_guid;
				}
				set
				{
					if (_linked_guid != value)
					{
						_linked_guid = value;
						this.changedProperties.Add("linked_guid");
					}
				}
			}
			
			public Int64 @created_at
			{
				get
				{
					return this._created_at;
				}
				set
				{
					if (_created_at != value)
					{
						_created_at = value;
						this.changedProperties.Add("created_at");
					}
				}
			}
			
			public DateTime? dte_created_at
			{
				get
				{
					try
					{
						var r = @created_at.ToDateTimeLocal();
						return r;
					}
					catch(Exception ex)
					{
						return null;
					}
				}
			}
			public Int32 @blob_type
			{
				get
				{
					return this._blob_type;
				}
				set
				{
					if (_blob_type != value)
					{
						_blob_type = value;
						this.changedProperties.Add("blob_type");
					}
				}
			}
			
		#endregion
	}
	#pragma warning restore CS8618
	#pragma warning restore CS8981
}
