using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
using System.ComponentModel;

#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Models {
	public class directories {
		public List<string> changedProperties = new List<string>();
		#region fields
			private Int32 _id;// sqllite type = INTEGER
			private Int32 _library_section_id;// sqllite type = INTEGER
			private Int32 _parent_directory_id;// sqllite type = INTEGER
			private String _path;// sqllite type = varchar(255)
			private Int64 _created_at;// sqllite type = dt_integer(8)
			private Int64 _updated_at;// sqllite type = dt_integer(8)
			private Int64 _deleted_at;// sqllite type = dt_integer(8)
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
			
			public Int32 @parent_directory_id
			{
				get
				{
					return this._parent_directory_id;
				}
				set
				{
					if (_parent_directory_id != value)
					{
						_parent_directory_id = value;
						this.changedProperties.Add("parent_directory_id");
					}
				}
			}
			
			public String @path
			{
				get
				{
					return this._path;
				}
				set
				{
					if (_path != value)
					{
						_path = value;
						this.changedProperties.Add("path");
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
		#endregion
	}
	#pragma warning restore CS8618
	#pragma warning restore CS8981
}
