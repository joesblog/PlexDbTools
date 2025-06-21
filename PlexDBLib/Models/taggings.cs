using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
using System.ComponentModel;

#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Models {
	public class taggings {
		public List<string> changedProperties = new List<string>();
		#region fields
			private Int32 _id;// sqllite type = INTEGER
			private Int32 _metadata_item_id;// sqllite type = INTEGER
			private Int32 _tag_id;// sqllite type = INTEGER
			private Int32 _index;// sqllite type = INTEGER
			private String _text;// sqllite type = varchar(255)
			private Int32 _time_offset;// sqllite type = INTEGER
			private Int32 _end_time_offset;// sqllite type = INTEGER
			private String _thumb_url;// sqllite type = varchar(255)
			private Int64 _created_at;// sqllite type = dt_integer(8)
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
			
			public Int32 @tag_id
			{
				get
				{
					return this._tag_id;
				}
				set
				{
					if (_tag_id != value)
					{
						_tag_id = value;
						this.changedProperties.Add("tag_id");
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
			
			public String @text
			{
				get
				{
					return this._text;
				}
				set
				{
					if (_text != value)
					{
						_text = value;
						this.changedProperties.Add("text");
					}
				}
			}
			
			public Int32 @time_offset
			{
				get
				{
					return this._time_offset;
				}
				set
				{
					if (_time_offset != value)
					{
						_time_offset = value;
						this.changedProperties.Add("time_offset");
					}
				}
			}
			
			public Int32 @end_time_offset
			{
				get
				{
					return this._end_time_offset;
				}
				set
				{
					if (_end_time_offset != value)
					{
						_end_time_offset = value;
						this.changedProperties.Add("end_time_offset");
					}
				}
			}
			
			public String @thumb_url
			{
				get
				{
					return this._thumb_url;
				}
				set
				{
					if (_thumb_url != value)
					{
						_thumb_url = value;
						this.changedProperties.Add("thumb_url");
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
