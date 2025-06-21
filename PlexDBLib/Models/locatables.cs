using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
using System.ComponentModel;

#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Models {
	public class locatables {
		public List<string> changedProperties = new List<string>();
		#region fields
			private Int32 _id;// sqllite type = INTEGER
			private Int32 _location_id;// sqllite type = INTEGER
			private Int32 _locatable_id;// sqllite type = INTEGER
			private String _locatable_type;// sqllite type = VARCHAR(255)
			private Int64 _created_at;// sqllite type = dt_integer(8)
			private Int64 _updated_at;// sqllite type = dt_integer(8)
			private String _extra_data;// sqllite type = VARCHAR(255)
			private Int32 _geocoding_version;// sqllite type = INTEGER
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
			
			public Int32 @locatable_id
			{
				get
				{
					return this._locatable_id;
				}
				set
				{
					if (_locatable_id != value)
					{
						_locatable_id = value;
						this.changedProperties.Add("locatable_id");
					}
				}
			}
			
			public String @locatable_type
			{
				get
				{
					return this._locatable_type;
				}
				set
				{
					if (_locatable_type != value)
					{
						_locatable_type = value;
						this.changedProperties.Add("locatable_type");
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
			
			public Int32 @geocoding_version
			{
				get
				{
					return this._geocoding_version;
				}
				set
				{
					if (_geocoding_version != value)
					{
						_geocoding_version = value;
						this.changedProperties.Add("geocoding_version");
					}
				}
			}
			
		#endregion
	}
	#pragma warning restore CS8618
	#pragma warning restore CS8981
}
