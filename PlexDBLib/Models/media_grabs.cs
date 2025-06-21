using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
using System.ComponentModel;

#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Models {
	public class media_grabs {
		public List<string> changedProperties = new List<string>();
		#region fields
			private Int32 _id;// sqllite type = INTEGER
			private String _uuid;// sqllite type = varchar(255)
			private Int32 _status;// sqllite type = INTEGER
			private Int32 _error;// sqllite type = INTEGER
			private Int32 _metadata_item_id;// sqllite type = INTEGER
			private Int32 _media_subscription_id;// sqllite type = INTEGER
			private String _extra_data;// sqllite type = varchar(255)
			private Int64 _created_at;// sqllite type = dt_integer(8)
			private Int64 _updated_at;// sqllite type = dt_integer(8)
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
			
			public Int32 @error
			{
				get
				{
					return this._error;
				}
				set
				{
					if (_error != value)
					{
						_error = value;
						this.changedProperties.Add("error");
					}
				}
			}
			
			public Int32 @metadata_item_id
			{
				get
				{
					return this._metadata_item_id;
				}
				set
				{
					if (_metadata_item_id != value)
					{
						_metadata_item_id = value;
						this.changedProperties.Add("metadata_item_id");
					}
				}
			}
			
			public Int32 @media_subscription_id
			{
				get
				{
					return this._media_subscription_id;
				}
				set
				{
					if (_media_subscription_id != value)
					{
						_media_subscription_id = value;
						this.changedProperties.Add("media_subscription_id");
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
		#endregion
	}
	#pragma warning restore CS8618
	#pragma warning restore CS8981
}
