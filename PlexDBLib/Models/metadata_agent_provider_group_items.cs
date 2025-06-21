using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
using System.ComponentModel;

#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Models {
	public class metadata_agent_provider_group_items {
		public List<string> changedProperties = new List<string>();
		#region fields
			private Int32 _id;// sqllite type = INTEGER
			private Int32 _metadata_agent_provider_group_id;// sqllite type = INTEGER
			private Int32 _metadata_agent_provider_id;// sqllite type = INTEGER
			private Double _order;// sqllite type = FLOAT
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
			
			public Int32 @metadata_agent_provider_group_id
			{
				get
				{
					return this._metadata_agent_provider_group_id;
				}
				set
				{
					if (_metadata_agent_provider_group_id != value)
					{
						_metadata_agent_provider_group_id = value;
						this.changedProperties.Add("metadata_agent_provider_group_id");
					}
				}
			}
			
			public Int32 @metadata_agent_provider_id
			{
				get
				{
					return this._metadata_agent_provider_id;
				}
				set
				{
					if (_metadata_agent_provider_id != value)
					{
						_metadata_agent_provider_id = value;
						this.changedProperties.Add("metadata_agent_provider_id");
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
			
		#endregion
	}
	#pragma warning restore CS8618
	#pragma warning restore CS8981
}
