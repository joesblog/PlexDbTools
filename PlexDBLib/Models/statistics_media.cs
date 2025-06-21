using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
using System.ComponentModel;

#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Models {
	public class statistics_media {
		public List<string> changedProperties = new List<string>();
		#region fields
			private Int32 _id;// sqllite type = INTEGER
			private Int32 _account_id;// sqllite type = INTEGER
			private Int32 _device_id;// sqllite type = INTEGER
			private Int32 _timespan;// sqllite type = INTEGER
			private Int64 _at;// sqllite type = dt_integer(8)
			private Int32 _metadata_type;// sqllite type = INTEGER
			private Int32 _count;// sqllite type = INTEGER
			private Int32 _duration;// sqllite type = INTEGER
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
			
			public Int32 @timespan
			{
				get
				{
					return this._timespan;
				}
				set
				{
					if (_timespan != value)
					{
						_timespan = value;
						this.changedProperties.Add("timespan");
					}
				}
			}
			
			public Int64 @at
			{
				get
				{
					return this._at;
				}
				set
				{
					if (_at != value)
					{
						_at = value;
						this.changedProperties.Add("at");
					}
				}
			}
			
			public DateTime? dte_at
			{
				get
				{
					try
					{
						var r = @at.ToDateTimeLocal();
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
			
			public Int32 @count
			{
				get
				{
					return this._count;
				}
				set
				{
					if (_count != value)
					{
						_count = value;
						this.changedProperties.Add("count");
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
			
		#endregion
	}
	#pragma warning restore CS8618
	#pragma warning restore CS8981
}
