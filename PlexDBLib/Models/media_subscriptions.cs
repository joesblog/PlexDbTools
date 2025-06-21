using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
using System.ComponentModel;

#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Models {
	public class media_subscriptions {
		public List<string> changedProperties = new List<string>();
		#region fields
			private Int32 _id;// sqllite type = INTEGER
			private Double _order;// sqllite type = float
			private Int32 _metadata_type;// sqllite type = INTEGER
			private Int32 _target_metadata_item_id;// sqllite type = INTEGER
			private Int32 _target_library_section_id;// sqllite type = INTEGER
			private Int32 _target_section_location_id;// sqllite type = INTEGER
			private String _extra_data;// sqllite type = varchar(255)
			private Int64 _created_at;// sqllite type = dt_integer(8)
			private Int64 _updated_at;// sqllite type = dt_integer(8)
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
			
			public Int32 @target_metadata_item_id
			{
				get
				{
					return this._target_metadata_item_id;
				}
				set
				{
					if (_target_metadata_item_id != value)
					{
						_target_metadata_item_id = value;
						this.changedProperties.Add("target_metadata_item_id");
					}
				}
			}
			
			public Int32 @target_library_section_id
			{
				get
				{
					return this._target_library_section_id;
				}
				set
				{
					if (_target_library_section_id != value)
					{
						_target_library_section_id = value;
						this.changedProperties.Add("target_library_section_id");
					}
				}
			}
			
			public Int32 @target_section_location_id
			{
				get
				{
					return this._target_section_location_id;
				}
				set
				{
					if (_target_section_location_id != value)
					{
						_target_section_location_id = value;
						this.changedProperties.Add("target_section_location_id");
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
		#endregion
	}
	#pragma warning restore CS8618
	#pragma warning restore CS8981
}
