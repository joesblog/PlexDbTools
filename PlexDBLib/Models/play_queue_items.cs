using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
using System.ComponentModel;

#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Models {
	public class play_queue_items {
		public List<string> changedProperties = new List<string>();
		#region fields
			private Int32 _id;// sqllite type = INTEGER
			private Int32 _play_queue_id;// sqllite type = INTEGER
			private Int32 _metadata_item_id;// sqllite type = INTEGER
			private Double _order;// sqllite type = float
			private Boolean _up_next;// sqllite type = boolean
			private Int32 _play_queue_generator_id;// sqllite type = INTEGER
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
			
			public Int32 @play_queue_id
			{
				get
				{
					return this._play_queue_id;
				}
				set
				{
					if (_play_queue_id != value)
					{
						_play_queue_id = value;
						this.changedProperties.Add("play_queue_id");
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
			
			public Double @order
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
			
			public Boolean @up_next
			{
				get
				{
					return this._up_next;
				}
				set
				{
					if (_up_next != value)
					{
						_up_next = value;
						this.changedProperties.Add("up_next");
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
			
		#endregion
	}
	#pragma warning restore CS8618
	#pragma warning restore CS8981
}
