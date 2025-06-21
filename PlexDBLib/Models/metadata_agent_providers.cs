using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
using System.ComponentModel;

#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Models {
	public class metadata_agent_providers {
		public List<string> changedProperties = new List<string>();
		#region fields
			private Int32 _id;// sqllite type = INTEGER
			private String _identifier;// sqllite type = varchar(255)
			private String _title;// sqllite type = varchar(255)
			private String _uri;// sqllite type = varchar(255)
			private Int32 _agent_type;// sqllite type = INTEGER
			private String _metadata_types;// sqllite type = varchar(255)
			private Boolean _online;// sqllite type = boolean
			private Int64 _created_at;// sqllite type = dt_integer(8)
			private Int64 _updated_at;// sqllite type = dt_integer(8)
			private String _extra_data;// sqllite type = varchar(255)
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
			
			public String @title
			{
				get
				{
					return this._title;
				}
				set
				{
					if (_title != value)
					{
						_title = value;
						this.changedProperties.Add("title");
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
			
			public Int32 @agent_type
			{
				get
				{
					return this._agent_type;
				}
				set
				{
					if (_agent_type != value)
					{
						_agent_type = value;
						this.changedProperties.Add("agent_type");
					}
				}
			}
			
			public String @metadata_types
			{
				get
				{
					return this._metadata_types;
				}
				set
				{
					if (_metadata_types != value)
					{
						_metadata_types = value;
						this.changedProperties.Add("metadata_types");
					}
				}
			}
			
			public Boolean @online
			{
				get
				{
					return this._online;
				}
				set
				{
					if (_online != value)
					{
						_online = value;
						this.changedProperties.Add("online");
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
			
		#endregion
	}
	#pragma warning restore CS8618
	#pragma warning restore CS8981
}
