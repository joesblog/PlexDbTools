using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
using System.ComponentModel;

#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Models {
	public class locations_node {
		public List<string> changedProperties = new List<string>();
		#region fields
			private Int32 _nodeno;// sqllite type = INTEGER
			private Byte[] _data;// sqllite type = BLOB
		#endregion
		#region props
			public Int32 @nodeno
			{
				get
				{
					return this._nodeno;
				}
				set
				{
					if (_nodeno != value)
					{
						_nodeno = value;
						this.changedProperties.Add("nodeno");
					}
				}
			}
			
			public Byte[] @data
			{
				get
				{
					return this._data;
				}
				set
				{
					if (_data != value)
					{
						_data = value;
						this.changedProperties.Add("data");
					}
				}
			}
			
		#endregion
	}
	#pragma warning restore CS8618
	#pragma warning restore CS8981
}
