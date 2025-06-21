using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
using System.ComponentModel;

#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Models {
	public class media_parts {
		public List<string> changedProperties = new List<string>();
		#region fields
			private Int32 _id;// sqllite type = INTEGER
			private Int32 _media_item_id;// sqllite type = INTEGER
			private Int32 _directory_id;// sqllite type = INTEGER
			private String _hash;// sqllite type = varchar(255)
			private String _open_subtitle_hash;// sqllite type = varchar(255)
			private String _file;// sqllite type = varchar(255)
			private Int32 _index;// sqllite type = INTEGER
			private Int64 _size;// sqllite type = integer(8)
			private Int32 _duration;// sqllite type = INTEGER
			private Int64 _created_at;// sqllite type = dt_integer(8)
			private Int64 _updated_at;// sqllite type = dt_integer(8)
			private Int64 _deleted_at;// sqllite type = dt_integer(8)
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
			
			public Int32 @directory_id
			{
				get
				{
					return this._directory_id;
				}
				set
				{
					if (_directory_id != value)
					{
						_directory_id = value;
						this.changedProperties.Add("directory_id");
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
			
			public String @open_subtitle_hash
			{
				get
				{
					return this._open_subtitle_hash;
				}
				set
				{
					if (_open_subtitle_hash != value)
					{
						_open_subtitle_hash = value;
						this.changedProperties.Add("open_subtitle_hash");
					}
				}
			}
			
			public String @file
			{
				get
				{
					return this._file;
				}
				set
				{
					if (_file != value)
					{
						_file = value;
						this.changedProperties.Add("file");
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
