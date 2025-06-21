using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
using System.ComponentModel;

#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Models {
	public class download_queue_items {
		public List<string> changedProperties = new List<string>();
		#region fields
			private Int32 _id;// sqllite type = INTEGER
			private Int32 _queue_id;// sqllite type = INTEGER
			private String _key;// sqllite type = varchar(255)
			private Int32 _order;// sqllite type = INTEGER
			private Int32 _status;// sqllite type = INTEGER
			private String _decision_params;// sqllite type = varchar(255)
			private String _error;// sqllite type = varchar(255)
			private String _decision_result;// sqllite type = varchar(255)
			private Int32 _metadata_item_id;// sqllite type = INTEGER
			private Int32 _media_part_id;// sqllite type = INTEGER
			private Int64 _expiration;// sqllite type = dt_integer(8)
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
			
			public Int32 @queue_id
			{
				get
				{
					return this._queue_id;
				}
				set
				{
					if (_queue_id != value)
					{
						_queue_id = value;
						this.changedProperties.Add("queue_id");
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
			
			public Int32 @order
			{
				get
				{
					return this._order;
				}
				set
				{
					if (_order != value)
					{
						_order = value;
						this.changedProperties.Add("order");
					}
				}
			}
			
			public Int32 @status
			{
				get
				{
					return this._status;
				}
				set
				{
					if (_status != value)
					{
						_status = value;
						this.changedProperties.Add("status");
					}
				}
			}
			
			public String @decision_params
			{
				get
				{
					return this._decision_params;
				}
				set
				{
					if (_decision_params != value)
					{
						_decision_params = value;
						this.changedProperties.Add("decision_params");
					}
				}
			}
			
			public String @error
			{
				get
				{
					return this._error;
				}
				set
				{
					if (_error != value)
					{
						_error = value;
						this.changedProperties.Add("error");
					}
				}
			}
			
			public String @decision_result
			{
				get
				{
					return this._decision_result;
				}
				set
				{
					if (_decision_result != value)
					{
						_decision_result = value;
						this.changedProperties.Add("decision_result");
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
			
			public Int32 @media_part_id
			{
				get
				{
					return this._media_part_id;
				}
				set
				{
					if (_media_part_id != value)
					{
						_media_part_id = value;
						this.changedProperties.Add("media_part_id");
					}
				}
			}
			
			public Int64 @expiration
			{
				get
				{
					return this._expiration;
				}
				set
				{
					if (_expiration != value)
					{
						_expiration = value;
						this.changedProperties.Add("expiration");
					}
				}
			}
			
			public DateTime? dte_expiration
			{
				get
				{
					try
					{
						var r = @expiration.ToDateTimeLocal();
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
