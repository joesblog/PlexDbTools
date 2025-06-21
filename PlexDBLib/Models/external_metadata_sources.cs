using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
using System.ComponentModel;

#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Models {
	public class external_metadata_sources {
		public List<string> changedProperties = new List<string>();
		#region fields
			private Int32 _id;// sqllite type = INTEGER
			private String _uri;// sqllite type = varchar(255)
			private String _source_title;// sqllite type = varchar(255)
			private String _user_title;// sqllite type = varchar(255)
			private Int32 _online;// sqllite type = INTEGER
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
			
			public String @uri
			{
				get
				{
					return this._uri;
				}
				set
				{
					if (_uri != value)
					{
						_uri = value;
						this.changedProperties.Add("uri");
					}
				}
			}
			
			public String @source_title
			{
				get
				{
					return this._source_title;
				}
				set
				{
					if (_source_title != value)
					{
						_source_title = value;
						this.changedProperties.Add("source_title");
					}
				}
			}
			
			public String @user_title
			{
				get
				{
					return this._user_title;
				}
				set
				{
					if (_user_title != value)
					{
						_user_title = value;
						this.changedProperties.Add("user_title");
					}
				}
			}
			
			public Int32 @online
			{
				get
				{
					return this._online;
				}
				set
				{
					if (_online != value)
					{
						_online = value;
						this.changedProperties.Add("online");
					}
				}
			}
			
		#endregion
	}
	#pragma warning restore CS8618
	#pragma warning restore CS8981
}
