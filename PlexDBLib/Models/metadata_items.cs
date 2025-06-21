using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
using System.ComponentModel;

#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Models {
	public class metadata_items {
		public List<string> changedProperties = new List<string>();
		#region fields
			private Int32 _id;// sqllite type = INTEGER
			private Int32 _library_section_id;// sqllite type = INTEGER
			private Int32 _parent_id;// sqllite type = INTEGER
			private Int32 _metadata_type;// sqllite type = INTEGER
			private String _guid;// sqllite type = varchar(255)
			private Int32 _media_item_count;// sqllite type = INTEGER
			private String _title;// sqllite type = varchar(255)
			private String _title_sort;// sqllite type = varchar(255)
			private String _original_title;// sqllite type = varchar(255)
			private String _studio;// sqllite type = varchar(255)
			private Double _rating;// sqllite type = float
			private Int32 _rating_count;// sqllite type = INTEGER
			private String _tagline;// sqllite type = varchar(255)
			private String _summary;// sqllite type = TEXT
			private String _trivia;// sqllite type = TEXT
			private String _quotes;// sqllite type = TEXT
			private String _content_rating;// sqllite type = varchar(255)
			private Int32 _content_rating_age;// sqllite type = INTEGER
			private Int32 _index;// sqllite type = INTEGER
			private Int32 _absolute_index;// sqllite type = INTEGER
			private Int32 _duration;// sqllite type = INTEGER
			private String _user_thumb_url;// sqllite type = varchar(255)
			private String _user_art_url;// sqllite type = varchar(255)
			private String _user_banner_url;// sqllite type = varchar(255)
			private String _user_music_url;// sqllite type = varchar(255)
			private String _user_fields;// sqllite type = varchar(255)
			private String _tags_genre;// sqllite type = varchar(255)
			private String _tags_collection;// sqllite type = varchar(255)
			private String _tags_director;// sqllite type = varchar(255)
			private String _tags_writer;// sqllite type = varchar(255)
			private String _tags_star;// sqllite type = varchar(255)
			private Int64 _originally_available_at;// sqllite type = dt_integer(8)
			private Int64 _available_at;// sqllite type = dt_integer(8)
			private Int64 _expires_at;// sqllite type = dt_integer(8)
			private Int64 _refreshed_at;// sqllite type = dt_integer(8)
			private Int32 _year;// sqllite type = INTEGER
			private Int64 _added_at;// sqllite type = dt_integer(8)
			private Int64 _created_at;// sqllite type = dt_integer(8)
			private Int64 _updated_at;// sqllite type = dt_integer(8)
			private Int64 _deleted_at;// sqllite type = dt_integer(8)
			private String _tags_country;// sqllite type = varchar(255)
			private String _extra_data;// sqllite type = varchar(255)
			private String _hash;// sqllite type = varchar(255)
			private Double _audience_rating;// sqllite type = float
			private Int64 _changed_at;// sqllite type = integer(8)
			private Int64 _resources_changed_at;// sqllite type = integer(8)
			private Int32 _remote;// sqllite type = INTEGER
			private String _edition_title;// sqllite type = varchar(255)
			private String _slug;// sqllite type = varchar(255)
			private String _user_clear_logo_url;// sqllite type = varchar(255)
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
			
			public Int32 @media_item_count
			{
				get
				{
					return this._media_item_count;
				}
				set
				{
					if (_media_item_count != value)
					{
						_media_item_count = value;
						this.changedProperties.Add("media_item_count");
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
			
			public String @title_sort
			{
				get
				{
					return this._title_sort;
				}
				set
				{
					if (_title_sort != value)
					{
						_title_sort = value;
						this.changedProperties.Add("title_sort");
					}
				}
			}
			
			public String @original_title
			{
				get
				{
					return this._original_title;
				}
				set
				{
					if (_original_title != value)
					{
						_original_title = value;
						this.changedProperties.Add("original_title");
					}
				}
			}
			
			public String @studio
			{
				get
				{
					return this._studio;
				}
				set
				{
					if (_studio != value)
					{
						_studio = value;
						this.changedProperties.Add("studio");
					}
				}
			}
			
			public Double @rating
			{
				get
				{
					return this._rating;
				}
				set
				{
					if (_rating != value)
					{
						_rating = value;
						this.changedProperties.Add("rating");
					}
				}
			}
			
			public Int32 @rating_count
			{
				get
				{
					return this._rating_count;
				}
				set
				{
					if (_rating_count != value)
					{
						_rating_count = value;
						this.changedProperties.Add("rating_count");
					}
				}
			}
			
			public String @tagline
			{
				get
				{
					return this._tagline;
				}
				set
				{
					if (_tagline != value)
					{
						_tagline = value;
						this.changedProperties.Add("tagline");
					}
				}
			}
			
			public String @summary
			{
				get
				{
					return this._summary;
				}
				set
				{
					if (_summary != value)
					{
						_summary = value;
						this.changedProperties.Add("summary");
					}
				}
			}
			
			public String @trivia
			{
				get
				{
					return this._trivia;
				}
				set
				{
					if (_trivia != value)
					{
						_trivia = value;
						this.changedProperties.Add("trivia");
					}
				}
			}
			
			public String @quotes
			{
				get
				{
					return this._quotes;
				}
				set
				{
					if (_quotes != value)
					{
						_quotes = value;
						this.changedProperties.Add("quotes");
					}
				}
			}
			
			public String @content_rating
			{
				get
				{
					return this._content_rating;
				}
				set
				{
					if (_content_rating != value)
					{
						_content_rating = value;
						this.changedProperties.Add("content_rating");
					}
				}
			}
			
			public Int32 @content_rating_age
			{
				get
				{
					return this._content_rating_age;
				}
				set
				{
					if (_content_rating_age != value)
					{
						_content_rating_age = value;
						this.changedProperties.Add("content_rating_age");
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
			
			public Int32 @absolute_index
			{
				get
				{
					return this._absolute_index;
				}
				set
				{
					if (_absolute_index != value)
					{
						_absolute_index = value;
						this.changedProperties.Add("absolute_index");
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
			
			public String @user_banner_url
			{
				get
				{
					return this._user_banner_url;
				}
				set
				{
					if (_user_banner_url != value)
					{
						_user_banner_url = value;
						this.changedProperties.Add("user_banner_url");
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
			
			public String @tags_genre
			{
				get
				{
					return this._tags_genre;
				}
				set
				{
					if (_tags_genre != value)
					{
						_tags_genre = value;
						this.changedProperties.Add("tags_genre");
					}
				}
			}
			
			public String @tags_collection
			{
				get
				{
					return this._tags_collection;
				}
				set
				{
					if (_tags_collection != value)
					{
						_tags_collection = value;
						this.changedProperties.Add("tags_collection");
					}
				}
			}
			
			public String @tags_director
			{
				get
				{
					return this._tags_director;
				}
				set
				{
					if (_tags_director != value)
					{
						_tags_director = value;
						this.changedProperties.Add("tags_director");
					}
				}
			}
			
			public String @tags_writer
			{
				get
				{
					return this._tags_writer;
				}
				set
				{
					if (_tags_writer != value)
					{
						_tags_writer = value;
						this.changedProperties.Add("tags_writer");
					}
				}
			}
			
			public String @tags_star
			{
				get
				{
					return this._tags_star;
				}
				set
				{
					if (_tags_star != value)
					{
						_tags_star = value;
						this.changedProperties.Add("tags_star");
					}
				}
			}
			
			public Int64 @originally_available_at
			{
				get
				{
					return this._originally_available_at;
				}
				set
				{
					if (_originally_available_at != value)
					{
						_originally_available_at = value;
						this.changedProperties.Add("originally_available_at");
					}
				}
			}
			
			public DateTime? dte_originally_available_at
			{
				get
				{
					try
					{
						var r = @originally_available_at.ToDateTimeLocal();
						return r;
					}
					catch(Exception ex)
					{
						return null;
					}
				}
			}
			public Int64 @available_at
			{
				get
				{
					return this._available_at;
				}
				set
				{
					if (_available_at != value)
					{
						_available_at = value;
						this.changedProperties.Add("available_at");
					}
				}
			}
			
			public DateTime? dte_available_at
			{
				get
				{
					try
					{
						var r = @available_at.ToDateTimeLocal();
						return r;
					}
					catch(Exception ex)
					{
						return null;
					}
				}
			}
			public Int64 @expires_at
			{
				get
				{
					return this._expires_at;
				}
				set
				{
					if (_expires_at != value)
					{
						_expires_at = value;
						this.changedProperties.Add("expires_at");
					}
				}
			}
			
			public DateTime? dte_expires_at
			{
				get
				{
					try
					{
						var r = @expires_at.ToDateTimeLocal();
						return r;
					}
					catch(Exception ex)
					{
						return null;
					}
				}
			}
			public Int64 @refreshed_at
			{
				get
				{
					return this._refreshed_at;
				}
				set
				{
					if (_refreshed_at != value)
					{
						_refreshed_at = value;
						this.changedProperties.Add("refreshed_at");
					}
				}
			}
			
			public DateTime? dte_refreshed_at
			{
				get
				{
					try
					{
						var r = @refreshed_at.ToDateTimeLocal();
						return r;
					}
					catch(Exception ex)
					{
						return null;
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
			
			public Int64 @added_at
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
			
			public DateTime? dte_added_at
			{
				get
				{
					try
					{
						var r = @added_at.ToDateTimeLocal();
						return r;
					}
					catch(Exception ex)
					{
						return null;
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
			public String @tags_country
			{
				get
				{
					return this._tags_country;
				}
				set
				{
					if (_tags_country != value)
					{
						_tags_country = value;
						this.changedProperties.Add("tags_country");
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
			
			public String @hash
			{
				get
				{
					return this._hash;
				}
				set
				{
					if (_hash != value)
					{
						_hash = value;
						this.changedProperties.Add("hash");
					}
				}
			}
			
			public Double @audience_rating
			{
				get
				{
					return this._audience_rating;
				}
				set
				{
					if (_audience_rating != value)
					{
						_audience_rating = value;
						this.changedProperties.Add("audience_rating");
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
			
			public Int64 @resources_changed_at
			{
				get
				{
					return this._resources_changed_at;
				}
				set
				{
					if (_resources_changed_at != value)
					{
						_resources_changed_at = value;
						this.changedProperties.Add("resources_changed_at");
					}
				}
			}
			
			public Int32 @remote
			{
				get
				{
					return this._remote;
				}
				set
				{
					if (_remote != value)
					{
						_remote = value;
						this.changedProperties.Add("remote");
					}
				}
			}
			
			public String @edition_title
			{
				get
				{
					return this._edition_title;
				}
				set
				{
					if (_edition_title != value)
					{
						_edition_title = value;
						this.changedProperties.Add("edition_title");
					}
				}
			}
			
			public String @slug
			{
				get
				{
					return this._slug;
				}
				set
				{
					if (_slug != value)
					{
						_slug = value;
						this.changedProperties.Add("slug");
					}
				}
			}
			
			public String @user_clear_logo_url
			{
				get
				{
					return this._user_clear_logo_url;
				}
				set
				{
					if (_user_clear_logo_url != value)
					{
						_user_clear_logo_url = value;
						this.changedProperties.Add("user_clear_logo_url");
					}
				}
			}
			
		#endregion
	}
	#pragma warning restore CS8618
	#pragma warning restore CS8981
}
