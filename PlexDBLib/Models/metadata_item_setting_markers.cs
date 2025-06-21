using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
using System.ComponentModel;

#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Models {
	public class metadata_item_setting_markers {
		public List<string> changedProperties = new List<string>();
		#region fields
			private Int32 _id;// sqllite type = INTEGER
			private Int32 _marker_type;// sqllite type = INTEGER
			private Int32 _metadata_item_setting_id;// sqllite type = INTEGER
			private Int32 _start_time_offset;// sqllite type = INTEGER
			private Int32 _end_time_offset;// sqllite type = INTEGER
			private String _title;// sqllite type = varchar(255)
			private Int64 _created_at;// sqllite type = integer(8)
			private Int64 _updated_at;// sqllite type = integer(8)
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
			
			public Int32 @marker_type
			{
				get
				{
					return this._marker_type;
				}
				set
				{
					if (_marker_type != value)
					{
						_marker_type = value;
						this.changedProperties.Add("marker_type");
					}
				}
			}
			
			public Int32 @metadata_item_setting_id
			{
				get
				{
					return this._metadata_item_setting_id;
				}
				set
				{
					if (_metadata_item_setting_id != value)
					{
						_metadata_item_setting_id = value;
						this.changedProperties.Add("metadata_item_setting_id");
					}
				}
			}
			
			public Int32 @start_time_offset
			{
				get
				{
					return this._start_time_offset;
				}
				set
				{
					if (_start_time_offset != value)
					{
						_start_time_offset = value;
						this.changedProperties.Add("start_time_offset");
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
