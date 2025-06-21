using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
using System.ComponentModel;

#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Models {
	public class locations {
		public List<string> changedProperties = new List<string>();
		#region fields
			private Int32 _id;// sqllite type = INT
			private Double _lat_min;// sqllite type = REAL
			private Double _lat_max;// sqllite type = REAL
			private Double _lon_min;// sqllite type = REAL
			private Double _lon_max;// sqllite type = REAL
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
			
			public Double @lat_min
			{
				get
				{
					return this._lat_min;
				}
				set
				{
					if (_lat_min != value)
					{
						_lat_min = value;
						this.changedProperties.Add("lat_min");
					}
				}
			}
			
			public Double @lat_max
			{
				get
				{
					return this._lat_max;
				}
				set
				{
					if (_lat_max != value)
					{
						_lat_max = value;
						this.changedProperties.Add("lat_max");
					}
				}
			}
			
			public Double @lon_min
			{
				get
				{
					return this._lon_min;
				}
				set
				{
					if (_lon_min != value)
					{
						_lon_min = value;
						this.changedProperties.Add("lon_min");
					}
				}
			}
			
			public Double @lon_max
			{
				get
				{
					return this._lon_max;
				}
				set
				{
					if (_lon_max != value)
					{
						_lon_max = value;
						this.changedProperties.Add("lon_max");
					}
				}
			}
			
		#endregion
	}
	#pragma warning restore CS8618
	#pragma warning restore CS8981
}
