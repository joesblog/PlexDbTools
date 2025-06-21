using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
using System.ComponentModel;

#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Models {
	public class metadata_item_views {
		public List<string> changedProperties = new List<string>();
		#region fields
			private Int32 _id;// sqllite type = INTEGER
			private Int32 _account_id;// sqllite type = INTEGER
			private String _guid;// sqllite type = varchar(255)
			private Int32 _metadata_type;// sqllite type = INTEGER
			private Int32 _library_section_id;// sqllite type = INTEGER
			private String _grandparent_title;// sqllite type = varchar(255)
			private Int32 _parent_index;// sqllite type = INTEGER
			private String _parent_title;// sqllite type = varchar(255)
			private Int32 _index;// sqllite type = INTEGER
			private String _title;// sqllite type = varchar(255)
			private String _thumb_url;// sqllite type = varchar(255)
			private Int64 _viewed_at;// sqllite type = dt_integer(8)
			private String _grandparent_guid;// sqllite type = varchar(255)
			private Int64 _originally_available_at;// sqllite type = dt_integer(8)
			private Int32 _device_id;// sqllite type = INTEGER
			private Int32 _view_type;// sqllite type = INTEGER
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
			
			public Int32 @account_id
			{
				get
				{
					return this._account_id;
				}
				set
				{
					if (_account_id != value)
					{
						_account_id = value;
						this.changedProperties.Add("account_id");
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
			
			public String @grandparent_title
			{
				get
				{
					return this._grandparent_title;
				}
				set
				{
					if (_grandparent_title != value)
					{
						_grandparent_title = value;
						this.changedProperties.Add("grandparent_title");
					}
				}
			}
			
			public Int32 @parent_index
			{
				get
				{
					return this._parent_index;
				}
				set
				{
					if (_parent_index != value)
					{
						_parent_index = value;
						this.changedProperties.Add("parent_index");
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
			
			public Int64 @viewed_at
			{
				get
				{
					return this._viewed_at;
				}
				set
				{
					if (_viewed_at != value)
					{
						_viewed_at = value;
						this.changedProperties.Add("viewed_at");
					}
				}
			}
			
			public DateTime? dte_viewed_at
			{
				get
				{
					try
					{
						var r = @viewed_at.ToDateTimeLocal();
						return r;
					}
					catch(Exception ex)
					{
						return null;
					}
				}
			}
			public String @grandparent_guid
			{
				get
				{
					return this._grandparent_guid;
				}
				set
				{
					if (_grandparent_guid != value)
					{
						_grandparent_guid = value;
						this.changedProperties.Add("grandparent_guid");
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
			public Int32 @device_id
			{
				get
				{
					return this._device_id;
				}
				set
				{
					if (_device_id != value)
					{
						_device_id = value;
						this.changedProperties.Add("device_id");
					}
				}
			}
			
			public Int32 @view_type
			{
				get
				{
					return this._view_type;
				}
				set
				{
					if (_view_type != value)
					{
						_view_type = value;
						this.changedProperties.Add("view_type");
					}
				}
			}
			
		#endregion
	}
	#pragma warning restore CS8618
	#pragma warning restore CS8981
}
