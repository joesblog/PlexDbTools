using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
using System.ComponentModel;

#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Models {
	public class media_streams {
		public List<string> changedProperties = new List<string>();
		#region fields
			private Int32 _id;// sqllite type = INTEGER
			private Int32 _stream_type_id;// sqllite type = INTEGER
			private Int32 _media_item_id;// sqllite type = INTEGER
			private String _url;// sqllite type = varchar(255)
			private String _codec;// sqllite type = varchar(255)
			private String _language;// sqllite type = varchar(255)
			private Int64 _created_at;// sqllite type = dt_integer(8)
			private Int64 _updated_at;// sqllite type = dt_integer(8)
			private Int32 _index;// sqllite type = INTEGER
			private Int32 _media_part_id;// sqllite type = INTEGER
			private Int32 _channels;// sqllite type = INTEGER
			private Int32 _bitrate;// sqllite type = INTEGER
			private Int32 _url_index;// sqllite type = INTEGER
			private Boolean _default;// sqllite type = boolean
			private Boolean _forced;// sqllite type = boolean
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
			
			public Int32 @stream_type_id
			{
				get
				{
					return this._stream_type_id;
				}
				set
				{
					if (_stream_type_id != value)
					{
						_stream_type_id = value;
						this.changedProperties.Add("stream_type_id");
					}
				}
			}
			
			public Int32 @media_item_id
			{
				get
				{
					return this._media_item_id;
				}
				set
				{
					if (_media_item_id != value)
					{
						_media_item_id = value;
						this.changedProperties.Add("media_item_id");
					}
				}
			}
			
			public String @url
			{
				get
				{
					return this._url;
				}
				set
				{
					if (_url != value)
					{
						_url = value;
						this.changedProperties.Add("url");
					}
				}
			}
			
			public String @codec
			{
				get
				{
					return this._codec;
				}
				set
				{
					if (_codec != value)
					{
						_codec = value;
						this.changedProperties.Add("codec");
					}
				}
			}
			
			public String @language
			{
				get
				{
					return this._language;
				}
				set
				{
					if (_language != value)
					{
						_language = value;
						this.changedProperties.Add("language");
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
			public Int32 @index
			{
				get
				{
					return this._index;
				}
				set
				{
					if (_index != value)
					{
						_index = value;
						this.changedProperties.Add("index");
					}
				}
			}
			
			public Int32 @media_part_id
			{
				get
				{
					return this._media_part_id;
				}
				set
				{
					if (_media_part_id != value)
					{
						_media_part_id = value;
						this.changedProperties.Add("media_part_id");
					}
				}
			}
			
			public Int32 @channels
			{
				get
				{
					return this._channels;
				}
				set
				{
					if (_channels != value)
					{
						_channels = value;
						this.changedProperties.Add("channels");
					}
				}
			}
			
			public Int32 @bitrate
			{
				get
				{
					return this._bitrate;
				}
				set
				{
					if (_bitrate != value)
					{
						_bitrate = value;
						this.changedProperties.Add("bitrate");
					}
				}
			}
			
			public Int32 @url_index
			{
				get
				{
					return this._url_index;
				}
				set
				{
					if (_url_index != value)
					{
						_url_index = value;
						this.changedProperties.Add("url_index");
					}
				}
			}
			
			public Boolean @default
			{
				get
				{
					return this._default;
				}
				set
				{
					if (_default != value)
					{
						_default = value;
						this.changedProperties.Add("default");
					}
				}
			}
			
			public Boolean @forced
			{
				get
				{
					return this._forced;
				}
				set
				{
					if (_forced != value)
					{
						_forced = value;
						this.changedProperties.Add("forced");
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
