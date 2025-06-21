using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
using System.ComponentModel;

#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Models {
	public class metadata_item_settings {
		public List<string> changedProperties = new List<string>();
		#region fields
			private Int32 _id;// sqllite type = INTEGER
			private Int32 _account_id;// sqllite type = INTEGER
			private String _guid;// sqllite type = varchar(255)
			private Double _rating;// sqllite type = float
			private Int32 _view_offset;// sqllite type = INTEGER
			private Int32 _view_count;// sqllite type = INTEGER
			private Int64 _last_viewed_at;// sqllite type = dt_integer(8)
			private Int64 _created_at;// sqllite type = dt_integer(8)
			private Int64 _updated_at;// sqllite type = dt_integer(8)
			private Int32 _skip_count;// sqllite type = INTEGER
			private Int64 _last_skipped_at;// sqllite type = dt_integer(8)
			private Int64 _changed_at;// sqllite type = integer(8)
			private String _extra_data;// sqllite type = varchar(255)
			private Int64 _last_rated_at;// sqllite type = dt_integer(8)
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
			
			public Int32 @view_offset
			{
				get
				{
					return this._view_offset;
				}
				set
				{
					if (_view_offset != value)
					{
						_view_offset = value;
						this.changedProperties.Add("view_offset");
					}
				}
			}
			
			public Int32 @view_count
			{
				get
				{
					return this._view_count;
				}
				set
				{
					if (_view_count != value)
					{
						_view_count = value;
						this.changedProperties.Add("view_count");
					}
				}
			}
			
			public Int64 @last_viewed_at
			{
				get
				{
					return this._last_viewed_at;
				}
				set
				{
					if (_last_viewed_at != value)
					{
						_last_viewed_at = value;
						this.changedProperties.Add("last_viewed_at");
					}
				}
			}
			
			public DateTime? dte_last_viewed_at
			{
				get
				{
					try
					{
						var r = @last_viewed_at.ToDateTimeLocal();
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
			public Int32 @skip_count
			{
				get
				{
					return this._skip_count;
				}
				set
				{
					if (_skip_count != value)
					{
						_skip_count = value;
						this.changedProperties.Add("skip_count");
					}
				}
			}
			
			public Int64 @last_skipped_at
			{
				get
				{
					return this._last_skipped_at;
				}
				set
				{
					if (_last_skipped_at != value)
					{
						_last_skipped_at = value;
						this.changedProperties.Add("last_skipped_at");
					}
				}
			}
			
			public DateTime? dte_last_skipped_at
			{
				get
				{
					try
					{
						var r = @last_skipped_at.ToDateTimeLocal();
						return r;
					}
					catch(Exception ex)
					{
						return null;
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
			
			public Int64 @last_rated_at
			{
				get
				{
					return this._last_rated_at;
				}
				set
				{
					if (_last_rated_at != value)
					{
						_last_rated_at = value;
						this.changedProperties.Add("last_rated_at");
					}
				}
			}
			
			public DateTime? dte_last_rated_at
			{
				get
				{
					try
					{
						var r = @last_rated_at.ToDateTimeLocal();
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
