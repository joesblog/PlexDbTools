using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
using System.ComponentModel;

#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Models {
	public class external_metadata_items {
		public List<string> changedProperties = new List<string>();
		#region fields
			private Int32 _id;// sqllite type = INTEGER
			private Int32 _external_metadata_source_id;// sqllite type = INTEGER
			private Int32 _library_section_id;// sqllite type = INTEGER
			private Int32 _metadata_type;// sqllite type = INTEGER
			private String _guid;// sqllite type = varchar(255)
			private String _title;// sqllite type = varchar(255)
			private String _parent_title;// sqllite type = varchar(255)
			private Int32 _year;// sqllite type = INTEGER
			private Int32 _added_at;// sqllite type = INTEGER
			private Int32 _updated_at;// sqllite type = INTEGER
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
			
			public Int32 @external_metadata_source_id
			{
				get
				{
					return this._external_metadata_source_id;
				}
				set
				{
					if (_external_metadata_source_id != value)
					{
						_external_metadata_source_id = value;
						this.changedProperties.Add("external_metadata_source_id");
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
			
			public Int32 @metadata_type
			{
				get
				{
					return this._metadata_type;
				}
				set
				{
					if (_metadata_type != value)
					{
						_metadata_type = value;
						this.changedProperties.Add("metadata_type");
					}
				}
			}
			
			public String @guid
			{
				get
				{
					return this._guid;
				}
				set
				{
					if (_guid != value)
					{
						_guid = value;
						this.changedProperties.Add("guid");
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
			
			public String @parent_title
			{
				get
				{
					return this._parent_title;
				}
				set
				{
					if (_parent_title != value)
					{
						_parent_title = value;
						this.changedProperties.Add("parent_title");
					}
				}
			}
			
			public Int32 @year
			{
				get
				{
					return this._year;
				}
				set
				{
					if (_year != value)
					{
						_year = value;
						this.changedProperties.Add("year");
					}
				}
			}
			
			public Int32 @added_at
			{
				get
				{
					return this._added_at;
				}
				set
				{
					if (_added_at != value)
					{
						_added_at = value;
						this.changedProperties.Add("added_at");
					}
				}
			}
			
			public Int32 @updated_at
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
