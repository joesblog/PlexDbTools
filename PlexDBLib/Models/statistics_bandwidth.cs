using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
using System.ComponentModel;

#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Models {
	public class statistics_bandwidth {
		public List<string> changedProperties = new List<string>();
		#region fields
			private Int32 _id;// sqllite type = INTEGER
			private Int32 _account_id;// sqllite type = INTEGER
			private Int32 _device_id;// sqllite type = INTEGER
			private Int32 _timespan;// sqllite type = INTEGER
			private Int64 _at;// sqllite type = dt_integer(8)
			private Boolean _lan;// sqllite type = boolean
			private Int64 _bytes;// sqllite type = integer(8)
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
			public Boolean @lan
			{
				get
				{
					return this._lan;
				}
				set
				{
					if (_lan != value)
					{
						_lan = value;
						this.changedProperties.Add("lan");
					}
				}
			}
			
			public Int64 @bytes
			{
				get
				{
					return this._bytes;
				}
				set
				{
					if (_bytes != value)
					{
						_bytes = value;
						this.changedProperties.Add("bytes");
					}
				}
			}
			
		#endregion
	}
	#pragma warning restore CS8618
	#pragma warning restore CS8981
}
