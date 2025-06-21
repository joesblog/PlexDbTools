using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
using System.ComponentModel;

#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Models {
	public class statistics_resources {
		public List<string> changedProperties = new List<string>();
		#region fields
			private Int32 _id;// sqllite type = INTEGER
			private Int32 _timespan;// sqllite type = INTEGER
			private Int64 _at;// sqllite type = dt_integer(8)
			private Double _host_cpu_utilization;// sqllite type = float
			private Double _process_cpu_utilization;// sqllite type = float
			private Double _host_memory_utilization;// sqllite type = float
			private Double _process_memory_utilization;// sqllite type = float
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
			public Double @host_cpu_utilization
			{
				get
				{
					return this._host_cpu_utilization;
				}
				set
				{
					if (_host_cpu_utilization != value)
					{
						_host_cpu_utilization = value;
						this.changedProperties.Add("host_cpu_utilization");
					}
				}
			}
			
			public Double @process_cpu_utilization
			{
				get
				{
					return this._process_cpu_utilization;
				}
				set
				{
					if (_process_cpu_utilization != value)
					{
						_process_cpu_utilization = value;
						this.changedProperties.Add("process_cpu_utilization");
					}
				}
			}
			
			public Double @host_memory_utilization
			{
				get
				{
					return this._host_memory_utilization;
				}
				set
				{
					if (_host_memory_utilization != value)
					{
						_host_memory_utilization = value;
						this.changedProperties.Add("host_memory_utilization");
					}
				}
			}
			
			public Double @process_memory_utilization
			{
				get
				{
					return this._process_memory_utilization;
				}
				set
				{
					if (_process_memory_utilization != value)
					{
						_process_memory_utilization = value;
						this.changedProperties.Add("process_memory_utilization");
					}
				}
			}
			
		#endregion
	}
	#pragma warning restore CS8618
	#pragma warning restore CS8981
}
