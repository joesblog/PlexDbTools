using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
using System.ComponentModel;

#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Models {
	public class location_places {
		public List<string> changedProperties = new List<string>();
		#region fields
			private Int32 _id;// sqllite type = INTEGER
			private Int32 _location_id;// sqllite type = INTEGER
			private String _guid;// sqllite type = VARCHAR(255)
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
			
			public Int32 @location_id
			{
				get
				{
					return this._location_id;
				}
				set
				{
					if (_location_id != value)
					{
						_location_id = value;
						this.changedProperties.Add("location_id");
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
			
		#endregion
	}
	#pragma warning restore CS8618
	#pragma warning restore CS8981
}
