using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
using System.ComponentModel;

#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Models {
	public class metadata_relations {
		public List<string> changedProperties = new List<string>();
		#region fields
			private Int32 _id;// sqllite type = INTEGER
			private Int32 _metadata_item_id;// sqllite type = INTEGER
			private Int32 _related_metadata_item_id;// sqllite type = INTEGER
			private Int32 _relation_type;// sqllite type = INTEGER
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
			
			public Int32 @related_metadata_item_id
			{
				get
				{
					return this._related_metadata_item_id;
				}
				set
				{
					if (_related_metadata_item_id != value)
					{
						_related_metadata_item_id = value;
						this.changedProperties.Add("related_metadata_item_id");
					}
				}
			}
			
			public Int32 @relation_type
			{
				get
				{
					return this._relation_type;
				}
				set
				{
					if (_relation_type != value)
					{
						_relation_type = value;
						this.changedProperties.Add("relation_type");
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
