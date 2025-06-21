using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
using System.ComponentModel;

#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Models {
	public class metadata_item_clusterings {
		public List<string> changedProperties = new List<string>();
		#region fields
			private Int32 _id;// sqllite type = INTEGER
			private Int32 _metadata_item_id;// sqllite type = INTEGER
			private Int32 _metadata_item_cluster_id;// sqllite type = INTEGER
			private Int32 _index;// sqllite type = INTEGER
			private Int32 _version;// sqllite type = INTEGER
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
			
			public Int32 @metadata_item_cluster_id
			{
				get
				{
					return this._metadata_item_cluster_id;
				}
				set
				{
					if (_metadata_item_cluster_id != value)
					{
						_metadata_item_cluster_id = value;
						this.changedProperties.Add("metadata_item_cluster_id");
					}
				}
			}
			
			public Int32 @index
			{
				get
				{
					return this._index;
				}
				set
				{
					if (_index != value)
					{
						_index = value;
						this.changedProperties.Add("index");
					}
				}
			}
			
			public Int32 @version
			{
				get
				{
					return this._version;
				}
				set
				{
					if (_version != value)
					{
						_version = value;
						this.changedProperties.Add("version");
					}
				}
			}
			
		#endregion
	}
	#pragma warning restore CS8618
	#pragma warning restore CS8981
}
