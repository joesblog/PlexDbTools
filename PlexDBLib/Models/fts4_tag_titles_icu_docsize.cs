using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
using System.ComponentModel;

#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Models {
	public class fts4_tag_titles_icu_docsize {
		public List<string> changedProperties = new List<string>();
		#region fields
			private Int32 _docid;// sqllite type = INTEGER
			private Byte[] _size;// sqllite type = BLOB
		#endregion
		#region props
			public Int32 @docid
			{
				get
				{
					return this._docid;
				}
				set
				{
					if (_docid != value)
					{
						_docid = value;
						this.changedProperties.Add("docid");
					}
				}
			}
			
			public Byte[] @size
			{
				get
				{
					return this._size;
				}
				set
				{
					if (_size != value)
					{
						_size = value;
						this.changedProperties.Add("size");
					}
				}
			}
			
		#endregion
	}
	#pragma warning restore CS8618
	#pragma warning restore CS8981
}
