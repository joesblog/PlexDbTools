using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
using System.ComponentModel;

#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Models {
	public class metadata_item_clusters {
		public List<string> changedProperties = new List<string>();
		#region fields
			private Int32 _id;// sqllite type = INTEGER
			private Int32 _zoom_level;// sqllite type = INTEGER
			private Int32 _library_section_id;// sqllite type = INTEGER
			private String _title;// sqllite type = varchar(255)
			private Int32 _count;// sqllite type = INTEGER
			private Int64 _starts_at;// sqllite type = dt_integer(8)
			private Int64 _ends_at;// sqllite type = dt_integer(8)
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
			
			public Int32 @zoom_level
			{
				get
				{
					return this._zoom_level;
				}
				set
				{
					if (_zoom_level != value)
					{
						_zoom_level = value;
						this.changedProperties.Add("zoom_level");
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
			
			public Int32 @count
			{
				get
				{
					return this._count;
				}
				set
				{
					if (_count != value)
					{
						_count = value;
						this.changedProperties.Add("count");
					}
				}
			}
			
			public Int64 @starts_at
			{
				get
				{
					return this._starts_at;
				}
				set
				{
					if (_starts_at != value)
					{
						_starts_at = value;
						this.changedProperties.Add("starts_at");
					}
				}
			}
			
			public DateTime? dte_starts_at
			{
				get
				{
					try
					{
						var r = @starts_at.ToDateTimeLocal();
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
