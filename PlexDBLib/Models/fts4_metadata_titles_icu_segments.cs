using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
using System.ComponentModel;

#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Models {
	public class fts4_metadata_titles_icu_segments {
		public List<string> changedProperties = new List<string>();
		#region fields
			private Int32 _blockid;// sqllite type = INTEGER
			private Byte[] _block;// sqllite type = BLOB
		#endregion
		#region props
			public Int32 @blockid
			{
				get
				{
					return this._blockid;
				}
				set
				{
					if (_blockid != value)
					{
						_blockid = value;
						this.changedProperties.Add("blockid");
					}
				}
			}
			
			public Byte[] @block
			{
				get
				{
					return this._block;
				}
				set
				{
					if (_block != value)
					{
						_block = value;
						this.changedProperties.Add("block");
					}
				}
			}
			
		#endregion
	}
	#pragma warning restore CS8618
	#pragma warning restore CS8981
}
