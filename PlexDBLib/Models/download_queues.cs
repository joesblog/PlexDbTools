using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
using System.ComponentModel;

#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Models {
	public class download_queues {
		public List<string> changedProperties = new List<string>();
		#region fields
			private Int32 _id;// sqllite type = INTEGER
			private Int32 _owner;// sqllite type = INTEGER
			private String _client_identifier;// sqllite type = varchar(255)
			private String _extra_data;// sqllite type = varchar(255)
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
			
			public Int32 @owner
			{
				get
				{
					return this._owner;
				}
				set
				{
					if (_owner != value)
					{
						_owner = value;
						this.changedProperties.Add("owner");
					}
				}
			}
			
			public String @client_identifier
			{
				get
				{
					return this._client_identifier;
				}
				set
				{
					if (_client_identifier != value)
					{
						_client_identifier = value;
						this.changedProperties.Add("client_identifier");
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
			
		#endregion
	}
	#pragma warning restore CS8618
	#pragma warning restore CS8981
}
