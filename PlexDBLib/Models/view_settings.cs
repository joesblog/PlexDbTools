using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
using System.ComponentModel;

#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Models {
	public class view_settings {
		public List<string> changedProperties = new List<string>();
		#region fields
			private Int32 _id;// sqllite type = INTEGER
			private Int32 _account_id;// sqllite type = INTEGER
			private String _client_type;// sqllite type = varchar(255)
			private String _view_group;// sqllite type = varchar(255)
			private Int32 _view_id;// sqllite type = INTEGER
			private Int32 _sort_id;// sqllite type = INTEGER
			private Boolean _sort_asc;// sqllite type = boolean
			private Int64 _created_at;// sqllite type = dt_integer(8)
			private Int64 _updated_at;// sqllite type = dt_integer(8)
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
			
			public String @client_type
			{
				get
				{
					return this._client_type;
				}
				set
				{
					if (_client_type != value)
					{
						_client_type = value;
						this.changedProperties.Add("client_type");
					}
				}
			}
			
			public String @view_group
			{
				get
				{
					return this._view_group;
				}
				set
				{
					if (_view_group != value)
					{
						_view_group = value;
						this.changedProperties.Add("view_group");
					}
				}
			}
			
			public Int32 @view_id
			{
				get
				{
					return this._view_id;
				}
				set
				{
					if (_view_id != value)
					{
						_view_id = value;
						this.changedProperties.Add("view_id");
					}
				}
			}
			
			public Int32 @sort_id
			{
				get
				{
					return this._sort_id;
				}
				set
				{
					if (_sort_id != value)
					{
						_sort_id = value;
						this.changedProperties.Add("sort_id");
					}
				}
			}
			
			public Boolean @sort_asc
			{
				get
				{
					return this._sort_asc;
				}
				set
				{
					if (_sort_asc != value)
					{
						_sort_asc = value;
						this.changedProperties.Add("sort_asc");
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
		#endregion
	}
	#pragma warning restore CS8618
	#pragma warning restore CS8981
}
