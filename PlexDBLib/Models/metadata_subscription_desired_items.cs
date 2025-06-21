using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
using System.ComponentModel;

#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Models {
	public class metadata_subscription_desired_items {
		public List<string> changedProperties = new List<string>();
		#region fields
			private Int32 _sub_id;// sqllite type = INTEGER
			private String _remote_id;// sqllite type = VARCHAR(255)
		#endregion
		#region props
			public Int32 @sub_id
			{
				get
				{
					return this._sub_id;
				}
				set
				{
					if (_sub_id != value)
					{
						_sub_id = value;
						this.changedProperties.Add("sub_id");
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
