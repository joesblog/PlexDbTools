using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
using System.ComponentModel;

#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Models {
	public class remote_id_translation {
		public List<string> changedProperties = new List<string>();
		#region fields
			private Int32 _id;// sqllite type = INTEGER
			private Int32 _type;// sqllite type = INTEGER
			private Int32 _local_id;// sqllite type = INTEGER
			private String _remote_id;// sqllite type = VARCHAR(255)
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
			
			public Int32 @type
			{
				get
				{
					return this._type;
				}
				set
				{
					if (_type != value)
					{
						_type = value;
						this.changedProperties.Add("type");
					}
				}
			}
			
			public Int32 @local_id
			{
				get
				{
					return this._local_id;
				}
				set
				{
					if (_local_id != value)
					{
						_local_id = value;
						this.changedProperties.Add("local_id");
					}
				}
			}
			
			public String @remote_id
			{
				get
				{
					return this._remote_id;
				}
				set
				{
					if (_remote_id != value)
					{
						_remote_id = value;
						this.changedProperties.Add("remote_id");
					}
				}
			}
			
		#endregion
	}
	#pragma warning restore CS8618
	#pragma warning restore CS8981
}
