using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
using System.ComponentModel;

#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Models {
	public class play_queue_generators {
		public List<string> changedProperties = new List<string>();
		#region fields
			private Int32 _id;// sqllite type = INTEGER
			private Int32 _playlist_id;// sqllite type = INTEGER
			private Int32 _metadata_item_id;// sqllite type = INTEGER
			private String _uri;// sqllite type = varchar(255)
			private Int32 _limit;// sqllite type = INTEGER
			private Boolean _continuous;// sqllite type = boolean
			private Double _order;// sqllite type = float
			private Int64 _created_at;// sqllite type = dt_integer(8)
			private Int64 _updated_at;// sqllite type = dt_integer(8)
			private Int64 _changed_at;// sqllite type = integer(8)
			private Boolean _recursive;// sqllite type = boolean
			private Int32 _type;// sqllite type = INTEGER
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
			
			public Int32 @playlist_id
			{
				get
				{
					return this._playlist_id;
				}
				set
				{
					if (_playlist_id != value)
					{
						_playlist_id = value;
						this.changedProperties.Add("playlist_id");
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
			
			public Int32 @limit
			{
				get
				{
					return this._limit;
				}
				set
				{
					if (_limit != value)
					{
						_limit = value;
						this.changedProperties.Add("limit");
					}
				}
			}
			
			public Boolean @continuous
			{
				get
				{
					return this._continuous;
				}
				set
				{
					if (_continuous != value)
					{
						_continuous = value;
						this.changedProperties.Add("continuous");
					}
				}
			}
			
			public Double @order
			{
				get
				{
					return this._order;
				}
				set
				{
					if (_order != value)
					{
						_order = value;
						this.changedProperties.Add("order");
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
			public Int64 @changed_at
			{
				get
				{
					return this._changed_at;
				}
				set
				{
					if (_changed_at != value)
					{
						_changed_at = value;
						this.changedProperties.Add("changed_at");
					}
				}
			}
			
			public Boolean @recursive
			{
				get
				{
					return this._recursive;
				}
				set
				{
					if (_recursive != value)
					{
						_recursive = value;
						this.changedProperties.Add("recursive");
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
