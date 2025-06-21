using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
using System.ComponentModel;

#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Models {
	public class tags {
		public List<string> changedProperties = new List<string>();
		#region fields
			private Int32 _id;// sqllite type = INTEGER
			private Int32 _metadata_item_id;// sqllite type = INTEGER
			private String _tag;// sqllite type = varchar(255)
			private Int32 _tag_type;// sqllite type = INTEGER
			private String _user_thumb_url;// sqllite type = varchar(255)
			private String _user_art_url;// sqllite type = varchar(255)
			private String _user_music_url;// sqllite type = varchar(255)
			private Int64 _created_at;// sqllite type = dt_integer(8)
			private Int64 _updated_at;// sqllite type = dt_integer(8)
			private Int32 _tag_value;// sqllite type = INTEGER
			private String _extra_data;// sqllite type = varchar(255)
			private String _key;// sqllite type = varchar(255)
			private Int32 _parent_id;// sqllite type = INTEGER
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
			
			public String @tag
			{
				get
				{
					return this._tag;
				}
				set
				{
					if (_tag != value)
					{
						_tag = value;
						this.changedProperties.Add("tag");
					}
				}
			}
			
			public Int32 @tag_type
			{
				get
				{
					return this._tag_type;
				}
				set
				{
					if (_tag_type != value)
					{
						_tag_type = value;
						this.changedProperties.Add("tag_type");
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
			
			public String @user_music_url
			{
				get
				{
					return this._user_music_url;
				}
				set
				{
					if (_user_music_url != value)
					{
						_user_music_url = value;
						this.changedProperties.Add("user_music_url");
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
			public Int32 @tag_value
			{
				get
				{
					return this._tag_value;
				}
				set
				{
					if (_tag_value != value)
					{
						_tag_value = value;
						this.changedProperties.Add("tag_value");
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
			
			public String @key
			{
				get
				{
					return this._key;
				}
				set
				{
					if (_key != value)
					{
						_key = value;
						this.changedProperties.Add("key");
					}
				}
			}
			
			public Int32 @parent_id
			{
				get
				{
					return this._parent_id;
				}
				set
				{
					if (_parent_id != value)
					{
						_parent_id = value;
						this.changedProperties.Add("parent_id");
					}
				}
			}
			
		#endregion
	}
	#pragma warning restore CS8618
	#pragma warning restore CS8981
}
