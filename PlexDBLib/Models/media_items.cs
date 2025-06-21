using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
using System.ComponentModel;

#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Models {
	public class media_items {
		public List<string> changedProperties = new List<string>();
		#region fields
			private Int32 _id;// sqllite type = INTEGER
			private Int32 _library_section_id;// sqllite type = INTEGER
			private Int32 _section_location_id;// sqllite type = INTEGER
			private Int32 _metadata_item_id;// sqllite type = INTEGER
			private Int32 _type_id;// sqllite type = INTEGER
			private Int32 _width;// sqllite type = INTEGER
			private Int32 _height;// sqllite type = INTEGER
			private Int64 _size;// sqllite type = integer(8)
			private Int32 _duration;// sqllite type = INTEGER
			private Int32 _bitrate;// sqllite type = INTEGER
			private String _container;// sqllite type = varchar(255)
			private String _video_codec;// sqllite type = varchar(255)
			private String _audio_codec;// sqllite type = varchar(255)
			private Double _display_aspect_ratio;// sqllite type = float
			private Double _frames_per_second;// sqllite type = float
			private Int32 _audio_channels;// sqllite type = INTEGER
			private Boolean _interlaced;// sqllite type = boolean
			private String _source;// sqllite type = varchar(255)
			private String _hints;// sqllite type = varchar(255)
			private Int32 _display_offset;// sqllite type = INTEGER
			private String _settings;// sqllite type = varchar(255)
			private Int64 _created_at;// sqllite type = dt_integer(8)
			private Int64 _updated_at;// sqllite type = dt_integer(8)
			private Boolean _optimized_for_streaming;// sqllite type = boolean
			private Int64 _deleted_at;// sqllite type = dt_integer(8)
			private Int32 _media_analysis_version;// sqllite type = INTEGER
			private Double _sample_aspect_ratio;// sqllite type = float
			private String _extra_data;// sqllite type = varchar(255)
			private Int32 _proxy_type;// sqllite type = INTEGER
			private Int32 _channel_id;// sqllite type = INTEGER
			private Int64 _begins_at;// sqllite type = dt_integer(8)
			private Int64 _ends_at;// sqllite type = dt_integer(8)
			private String _color_trc;// sqllite type = varchar(255)
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
			
			public Int32 @library_section_id
			{
				get
				{
					return this._library_section_id;
				}
				set
				{
					if (_library_section_id != value)
					{
						_library_section_id = value;
						this.changedProperties.Add("library_section_id");
					}
				}
			}
			
			public Int32 @section_location_id
			{
				get
				{
					return this._section_location_id;
				}
				set
				{
					if (_section_location_id != value)
					{
						_section_location_id = value;
						this.changedProperties.Add("section_location_id");
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
			
			public Int32 @type_id
			{
				get
				{
					return this._type_id;
				}
				set
				{
					if (_type_id != value)
					{
						_type_id = value;
						this.changedProperties.Add("type_id");
					}
				}
			}
			
			public Int32 @width
			{
				get
				{
					return this._width;
				}
				set
				{
					if (_width != value)
					{
						_width = value;
						this.changedProperties.Add("width");
					}
				}
			}
			
			public Int32 @height
			{
				get
				{
					return this._height;
				}
				set
				{
					if (_height != value)
					{
						_height = value;
						this.changedProperties.Add("height");
					}
				}
			}
			
			public Int64 @size
			{
				get
				{
					return this._size;
				}
				set
				{
					if (_size != value)
					{
						_size = value;
						this.changedProperties.Add("size");
					}
				}
			}
			
			public Int32 @duration
			{
				get
				{
					return this._duration;
				}
				set
				{
					if (_duration != value)
					{
						_duration = value;
						this.changedProperties.Add("duration");
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
			
			public String @container
			{
				get
				{
					return this._container;
				}
				set
				{
					if (_container != value)
					{
						_container = value;
						this.changedProperties.Add("container");
					}
				}
			}
			
			public String @video_codec
			{
				get
				{
					return this._video_codec;
				}
				set
				{
					if (_video_codec != value)
					{
						_video_codec = value;
						this.changedProperties.Add("video_codec");
					}
				}
			}
			
			public String @audio_codec
			{
				get
				{
					return this._audio_codec;
				}
				set
				{
					if (_audio_codec != value)
					{
						_audio_codec = value;
						this.changedProperties.Add("audio_codec");
					}
				}
			}
			
			public Double @display_aspect_ratio
			{
				get
				{
					return this._display_aspect_ratio;
				}
				set
				{
					if (_display_aspect_ratio != value)
					{
						_display_aspect_ratio = value;
						this.changedProperties.Add("display_aspect_ratio");
					}
				}
			}
			
			public Double @frames_per_second
			{
				get
				{
					return this._frames_per_second;
				}
				set
				{
					if (_frames_per_second != value)
					{
						_frames_per_second = value;
						this.changedProperties.Add("frames_per_second");
					}
				}
			}
			
			public Int32 @audio_channels
			{
				get
				{
					return this._audio_channels;
				}
				set
				{
					if (_audio_channels != value)
					{
						_audio_channels = value;
						this.changedProperties.Add("audio_channels");
					}
				}
			}
			
			public Boolean @interlaced
			{
				get
				{
					return this._interlaced;
				}
				set
				{
					if (_interlaced != value)
					{
						_interlaced = value;
						this.changedProperties.Add("interlaced");
					}
				}
			}
			
			public String @source
			{
				get
				{
					return this._source;
				}
				set
				{
					if (_source != value)
					{
						_source = value;
						this.changedProperties.Add("source");
					}
				}
			}
			
			public String @hints
			{
				get
				{
					return this._hints;
				}
				set
				{
					if (_hints != value)
					{
						_hints = value;
						this.changedProperties.Add("hints");
					}
				}
			}
			
			public Int32 @display_offset
			{
				get
				{
					return this._display_offset;
				}
				set
				{
					if (_display_offset != value)
					{
						_display_offset = value;
						this.changedProperties.Add("display_offset");
					}
				}
			}
			
			public String @settings
			{
				get
				{
					return this._settings;
				}
				set
				{
					if (_settings != value)
					{
						_settings = value;
						this.changedProperties.Add("settings");
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
			public Boolean @optimized_for_streaming
			{
				get
				{
					return this._optimized_for_streaming;
				}
				set
				{
					if (_optimized_for_streaming != value)
					{
						_optimized_for_streaming = value;
						this.changedProperties.Add("optimized_for_streaming");
					}
				}
			}
			
			public Int64 @deleted_at
			{
				get
				{
					return this._deleted_at;
				}
				set
				{
					if (_deleted_at != value)
					{
						_deleted_at = value;
						this.changedProperties.Add("deleted_at");
					}
				}
			}
			
			public DateTime? dte_deleted_at
			{
				get
				{
					try
					{
						var r = @deleted_at.ToDateTimeLocal();
						return r;
					}
					catch(Exception ex)
					{
						return null;
					}
				}
			}
			public Int32 @media_analysis_version
			{
				get
				{
					return this._media_analysis_version;
				}
				set
				{
					if (_media_analysis_version != value)
					{
						_media_analysis_version = value;
						this.changedProperties.Add("media_analysis_version");
					}
				}
			}
			
			public Double @sample_aspect_ratio
			{
				get
				{
					return this._sample_aspect_ratio;
				}
				set
				{
					if (_sample_aspect_ratio != value)
					{
						_sample_aspect_ratio = value;
						this.changedProperties.Add("sample_aspect_ratio");
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
			
			public Int32 @proxy_type
			{
				get
				{
					return this._proxy_type;
				}
				set
				{
					if (_proxy_type != value)
					{
						_proxy_type = value;
						this.changedProperties.Add("proxy_type");
					}
				}
			}
			
			public Int32 @channel_id
			{
				get
				{
					return this._channel_id;
				}
				set
				{
					if (_channel_id != value)
					{
						_channel_id = value;
						this.changedProperties.Add("channel_id");
					}
				}
			}
			
			public Int64 @begins_at
			{
				get
				{
					return this._begins_at;
				}
				set
				{
					if (_begins_at != value)
					{
						_begins_at = value;
						this.changedProperties.Add("begins_at");
					}
				}
			}
			
			public DateTime? dte_begins_at
			{
				get
				{
					try
					{
						var r = @begins_at.ToDateTimeLocal();
						return r;
					}
					catch(Exception ex)
					{
						return null;
					}
				}
			}
			public Int64 @ends_at
			{
				get
				{
					return this._ends_at;
				}
				set
				{
					if (_ends_at != value)
					{
						_ends_at = value;
						this.changedProperties.Add("ends_at");
					}
				}
			}
			
			public DateTime? dte_ends_at
			{
				get
				{
					try
					{
						var r = @ends_at.ToDateTimeLocal();
						return r;
					}
					catch(Exception ex)
					{
						return null;
					}
				}
			}
			public String @color_trc
			{
				get
				{
					return this._color_trc;
				}
				set
				{
					if (_color_trc != value)
					{
						_color_trc = value;
						this.changedProperties.Add("color_trc");
					}
				}
			}
			
		#endregion
	}
	#pragma warning restore CS8618
	#pragma warning restore CS8981
}
