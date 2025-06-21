using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
using System.ComponentModel;

#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Models {
	public class media_provider_resources {
		public List<string> changedProperties = new List<string>();
		#region fields
			private Int32 _id;// sqllite type = INTEGER
			private Int32 _parent_id;// sqllite type = INTEGER
			private Int32 _type;// sqllite type = INTEGER
			private Int32 _status;// sqllite type = INTEGER
			private Int32 _state;// sqllite type = INTEGER
			private String _identifier;// sqllite type = varchar(255)
			private String _protocol;// sqllite type = varchar(255)
			private String _uri;// sqllite type = varchar(255)
			private String _uuid;// sqllite type = varchar(255)
			private String _extra_data;// sqllite type = varchar(255)
			private Int64 _last_seen_at;// sqllite type = dt_integer(8)
			private Int64 _created_at;// sqllite type = dt_integer(8)
			private Int64 _updated_at;// sqllite type = dt_integer(8)
			private Byte[] _data;// sqllite type = BLOB
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
			
			public Int32 @parent_id
			{
				get
				{
					return this._parent_id;
				}
				set
				{
					if (_parent_id != value)
					{
						_parent_id = value;
						this.changedProperties.Add("parent_id");
					}
				}
			}
			
			public Int32 @type
			{
				get
				{
					return this._type;
				}
				set
				{
					if (_type != value)
					{
						_type = value;
						this.changedProperties.Add("type");
					}
				}
			}
			
			public Int32 @status
			{
				get
				{
					return this._status;
				}
				set
				{
					if (_status != value)
					{
						_status = value;
						this.changedProperties.Add("status");
					}
				}
			}
			
			public Int32 @state
			{
				get
				{
					return this._state;
				}
				set
				{
					if (_state != value)
					{
						_state = value;
						this.changedProperties.Add("state");
					}
				}
			}
			
			public String @identifier
			{
				get
				{
					return this._identifier;
				}
				set
				{
					if (_identifier != value)
					{
						_identifier = value;
						this.changedProperties.Add("identifier");
					}
				}
			}
			
			public String @protocol
			{
				get
				{
					return this._protocol;
				}
				set
				{
					if (_protocol != value)
					{
						_protocol = value;
						this.changedProperties.Add("protocol");
					}
				}
			}
			
			public String @uri
			{
				get
				{
					return this._uri;
				}
				set
				{
					if (_uri != value)
					{
						_uri = value;
						this.changedProperties.Add("uri");
					}
				}
			}
			
			public String @uuid
			{
				get
				{
					return this._uuid;
				}
				set
				{
					if (_uuid != value)
					{
						_uuid = value;
						this.changedProperties.Add("uuid");
					}
				}
			}
			
			public String @extra_data
			{
				get
				{
					return this._extra_data;
				}
				set
				{
					if (_extra_data != value)
					{
						_extra_data = value;
						this.changedProperties.Add("extra_data");
					}
				}
			}
			
			public Int64 @last_seen_at
			{
				get
				{
					return this._last_seen_at;
				}
				set
				{
					if (_last_seen_at != value)
					{
						_last_seen_at = value;
						this.changedProperties.Add("last_seen_at");
					}
				}
			}
			
			public DateTime? dte_last_seen_at
			{
				get
				{
					try
					{
						var r = @last_seen_at.ToDateTimeLocal();
						return r;
					}
					catch(Exception ex)
					{
						return null;
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
			public Int64 @updated_at
			{
				get
				{
					return this._updated_at;
				}
				set
				{
					if (_updated_at != value)
					{
						_updated_at = value;
						this.changedProperties.Add("updated_at");
					}
				}
			}
			
			public DateTime? dte_updated_at
			{
				get
				{
					try
					{
						var r = @updated_at.ToDateTimeLocal();
						return r;
					}
					catch(Exception ex)
					{
						return null;
					}
				}
			}
			public Byte[] @data
			{
				get
				{
					return this._data;
				}
				set
				{
					if (_data != value)
					{
						_data = value;
						this.changedProperties.Add("data");
					}
				}
			}
			
		#endregion
	}
	#pragma warning restore CS8618
	#pragma warning restore CS8981
}
