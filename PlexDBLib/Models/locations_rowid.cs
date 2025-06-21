using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
using System.ComponentModel;

#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Models {
	public class locations_rowid {
		public List<string> changedProperties = new List<string>();
		#region fields
			private Int32 _rowid;// sqllite type = INTEGER
			private Int32 _nodeno;// sqllite type = INTEGER
		#endregion
		#region props
			public Int32 @rowid
			{
				get
				{
					return this._rowid;
				}
				set
				{
					if (_rowid != value)
					{
						_rowid = value;
						this.changedProperties.Add("rowid");
					}
				}
			}
			
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
			
		#endregion
	}
	#pragma warning restore CS8618
	#pragma warning restore CS8981
}
