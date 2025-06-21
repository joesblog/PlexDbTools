using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
using System.ComponentModel;

#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Models {
	public class library_sections {
		public List<string> changedProperties = new List<string>();
		#region fields
			private Int32 _id;// sqllite type = INTEGER
			private Int32 _library_id;// sqllite type = INTEGER
			private String _name;// sqllite type = varchar(255)
			private String _name_sort;// sqllite type = varchar(255)
			private Int32 _section_type;// sqllite type = INTEGER
			private String _language;// sqllite type = varchar(255)
			private String _agent;// sqllite type = varchar(255)
			private String _scanner;// sqllite type = varchar(255)
			private String _user_thumb_url;// sqllite type = varchar(255)
			private String _user_art_url;// sqllite type = varchar(255)
			private String _user_theme_music_url;// sqllite type = varchar(255)
			private Boolean _public;// sqllite type = boolean
			private Int64 _created_at;// sqllite type = dt_integer(8)
			private Int64 _updated_at;// sqllite type = dt_integer(8)
			private Int64 _scanned_at;// sqllite type = dt_integer(8)
			private Boolean _display_secondary_level;// sqllite type = boolean
			private String _user_fields;// sqllite type = varchar(255)
			private String _query_xml;// sqllite type = TEXT
			private Int32 _query_type;// sqllite type = INTEGER
			private String _uuid;// sqllite type = varchar(255)
			private Int64 _changed_at;// sqllite type = integer(8)
			private Int64 _content_changed_at;// sqllite type = integer(8)
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
			
			public Int32 @library_id
			{
				get
				{
					return this._library_id;
				}
				set
				{
					if (_library_id != value)
					{
						_library_id = value;
						this.changedProperties.Add("library_id");
					}
				}
			}
			
			public String @name
			{
				get
				{
					return this._name;
				}
				set
				{
					if (_name != value)
					{
						_name = value;
						this.changedProperties.Add("name");
					}
				}
			}
			
			public String @name_sort
			{
				get
				{
					return this._name_sort;
				}
				set
				{
					if (_name_sort != value)
					{
						_name_sort = value;
						this.changedProperties.Add("name_sort");
					}
				}
			}
			
			public Int32 @section_type
			{
				get
				{
					return this._section_type;
				}
				set
				{
					if (_section_type != value)
					{
						_section_type = value;
						this.changedProperties.Add("section_type");
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
			
			public String @agent
			{
				get
				{
					return this._agent;
				}
				set
				{
					if (_agent != value)
					{
						_agent = value;
						this.changedProperties.Add("agent");
					}
				}
			}
			
			public String @scanner
			{
				get
				{
					return this._scanner;
				}
				set
				{
					if (_scanner != value)
					{
						_scanner = value;
						this.changedProperties.Add("scanner");
					}
				}
			}
			
			public String @user_thumb_url
			{
				get
				{
					return this._user_thumb_url;
				}
				set
				{
					if (_user_thumb_url != value)
					{
						_user_thumb_url = value;
						this.changedProperties.Add("user_thumb_url");
					}
				}
			}
			
			public String @user_art_url
			{
				get
				{
					return this._user_art_url;
				}
				set
				{
					if (_user_art_url != value)
					{
						_user_art_url = value;
						this.changedProperties.Add("user_art_url");
					}
				}
			}
			
			public String @user_theme_music_url
			{
				get
				{
					return this._user_theme_music_url;
				}
				set
				{
					if (_user_theme_music_url != value)
					{
						_user_theme_music_url = value;
						this.changedProperties.Add("user_theme_music_url");
					}
				}
			}
			
			public Boolean @public
			{
				get
				{
					return this._public;
				}
				set
				{
					if (_public != value)
					{
						_public = value;
						this.changedProperties.Add("public");
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
			public Int64 @scanned_at
			{
				get
				{
					return this._scanned_at;
				}
				set
				{
					if (_scanned_at != value)
					{
						_scanned_at = value;
						this.changedProperties.Add("scanned_at");
					}
				}
			}
			
			public DateTime? dte_scanned_at
			{
				get
				{
					try
					{
						var r = @scanned_at.ToDateTimeLocal();
						return r;
					}
					catch(Exception ex)
					{
						return null;
					}
				}
			}
			public Boolean @display_secondary_level
			{
				get
				{
					return this._display_secondary_level;
				}
				set
				{
					if (_display_secondary_level != value)
					{
						_display_secondary_level = value;
						this.changedProperties.Add("display_secondary_level");
					}
				}
			}
			
			public String @user_fields
			{
				get
				{
					return this._user_fields;
				}
				set
				{
					if (_user_fields != value)
					{
						_user_fields = value;
						this.changedProperties.Add("user_fields");
					}
				}
			}
			
			public String @query_xml
			{
				get
				{
					return this._query_xml;
				}
				set
				{
					if (_query_xml != value)
					{
						_query_xml = value;
						this.changedProperties.Add("query_xml");
					}
				}
			}
			
			public Int32 @query_type
			{
				get
				{
					return this._query_type;
				}
				set
				{
					if (_query_type != value)
					{
						_query_type = value;
						this.changedProperties.Add("query_type");
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
			
			public Int64 @content_changed_at
			{
				get
				{
					return this._content_changed_at;
				}
				set
				{
					if (_content_changed_at != value)
					{
						_content_changed_at = value;
						this.changedProperties.Add("content_changed_at");
					}
				}
			}
			
		#endregion
	}
	#pragma warning restore CS8618
	#pragma warning restore CS8981
}
