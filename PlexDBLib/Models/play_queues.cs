using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
using System.ComponentModel;

#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Models {
	public class play_queues {
		public List<string> changedProperties = new List<string>();
		#region fields
			private Int32 _id;// sqllite type = INTEGER
			private String _client_identifier;// sqllite type = varchar(255)
			private Int32 _account_id;// sqllite type = INTEGER
			private Int32 _playlist_id;// sqllite type = INTEGER
			private Int32 _sync_item_id;// sqllite type = INTEGER
			private Int32 _play_queue_generator_id;// sqllite type = INTEGER
			private Int32 _generator_start_index;// sqllite type = INTEGER
			private Int32 _generator_end_index;// sqllite type = INTEGER
			private Int32 _generator_items_count;// sqllite type = INTEGER
			private Byte[] _generator_ids;// sqllite type = BLOB
			private Int32 _seed;// sqllite type = INTEGER
			private Int32 _current_play_queue_item_id;// sqllite type = INTEGER
			private Int32 _last_added_play_queue_item_id;// sqllite type = INTEGER
			private Int32 _version;// sqllite type = INTEGER
			private Int64 _created_at;// sqllite type = dt_integer(8)
			private Int64 _updated_at;// sqllite type = dt_integer(8)
			private Int32 _metadata_type;// sqllite type = INTEGER
			private Int32 _total_items_count;// sqllite type = INTEGER
			private Byte[] _generator_generator_ids;// sqllite type = BLOB
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
			
			public String @client_identifier
			{
				get
				{
					return this._client_identifier;
				}
				set
				{
					if (_client_identifier != value)
					{
						_client_identifier = value;
						this.changedProperties.Add("client_identifier");
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
			
			public Int32 @playlist_id
			{
				get
				{
					return this._playlist_id;
				}
				set
				{
					if (_playlist_id != value)
					{
						_playlist_id = value;
						this.changedProperties.Add("playlist_id");
					}
				}
			}
			
			public Int32 @sync_item_id
			{
				get
				{
					return this._sync_item_id;
				}
				set
				{
					if (_sync_item_id != value)
					{
						_sync_item_id = value;
						this.changedProperties.Add("sync_item_id");
					}
				}
			}
			
			public Int32 @play_queue_generator_id
			{
				get
				{
					return this._play_queue_generator_id;
				}
				set
				{
					if (_play_queue_generator_id != value)
					{
						_play_queue_generator_id = value;
						this.changedProperties.Add("play_queue_generator_id");
					}
				}
			}
			
			public Int32 @generator_start_index
			{
				get
				{
					return this._generator_start_index;
				}
				set
				{
					if (_generator_start_index != value)
					{
						_generator_start_index = value;
						this.changedProperties.Add("generator_start_index");
					}
				}
			}
			
			public Int32 @generator_end_index
			{
				get
				{
					return this._generator_end_index;
				}
				set
				{
					if (_generator_end_index != value)
					{
						_generator_end_index = value;
						this.changedProperties.Add("generator_end_index");
					}
				}
			}
			
			public Int32 @generator_items_count
			{
				get
				{
					return this._generator_items_count;
				}
				set
				{
					if (_generator_items_count != value)
					{
						_generator_items_count = value;
						this.changedProperties.Add("generator_items_count");
					}
				}
			}
			
			public Byte[] @generator_ids
			{
				get
				{
					return this._generator_ids;
				}
				set
				{
					if (_generator_ids != value)
					{
						_generator_ids = value;
						this.changedProperties.Add("generator_ids");
					}
				}
			}
			
			public Int32 @seed
			{
				get
				{
					return this._seed;
				}
				set
				{
					if (_seed != value)
					{
						_seed = value;
						this.changedProperties.Add("seed");
					}
				}
			}
			
			public Int32 @current_play_queue_item_id
			{
				get
				{
					return this._current_play_queue_item_id;
				}
				set
				{
					if (_current_play_queue_item_id != value)
					{
						_current_play_queue_item_id = value;
						this.changedProperties.Add("current_play_queue_item_id");
					}
				}
			}
			
			public Int32 @last_added_play_queue_item_id
			{
				get
				{
					return this._last_added_play_queue_item_id;
				}
				set
				{
					if (_last_added_play_queue_item_id != value)
					{
						_last_added_play_queue_item_id = value;
						this.changedProperties.Add("last_added_play_queue_item_id");
					}
				}
			}
			
			public Int32 @version
			{
				get
				{
					return this._version;
				}
				set
				{
					if (_version != value)
					{
						_version = value;
						this.changedProperties.Add("version");
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
			
			public Int32 @total_items_count
			{
				get
				{
					return this._total_items_count;
				}
				set
				{
					if (_total_items_count != value)
					{
						_total_items_count = value;
						this.changedProperties.Add("total_items_count");
					}
				}
			}
			
			public Byte[] @generator_generator_ids
			{
				get
				{
					return this._generator_generator_ids;
				}
				set
				{
					if (_generator_generator_ids != value)
					{
						_generator_generator_ids = value;
						this.changedProperties.Add("generator_generator_ids");
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
