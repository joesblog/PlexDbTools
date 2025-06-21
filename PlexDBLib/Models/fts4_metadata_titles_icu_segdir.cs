using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
using System.ComponentModel;

#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Models {
	public class fts4_metadata_titles_icu_segdir {
		public List<string> changedProperties = new List<string>();
		#region fields
			private Int32 _level;// sqllite type = INTEGER
			private Int32 _idx;// sqllite type = INTEGER
			private Int32 _start_block;// sqllite type = INTEGER
			private Int32 _leaves_end_block;// sqllite type = INTEGER
			private Int32 _end_block;// sqllite type = INTEGER
			private Byte[] _root;// sqllite type = BLOB
		#endregion
		#region props
			public Int32 @level
			{
				get
				{
					return this._level;
				}
				set
				{
					if (_level != value)
					{
						_level = value;
						this.changedProperties.Add("level");
					}
				}
			}
			
			public Int32 @idx
			{
				get
				{
					return this._idx;
				}
				set
				{
					if (_idx != value)
					{
						_idx = value;
						this.changedProperties.Add("idx");
					}
				}
			}
			
			public Int32 @start_block
			{
				get
				{
					return this._start_block;
				}
				set
				{
					if (_start_block != value)
					{
						_start_block = value;
						this.changedProperties.Add("start_block");
					}
				}
			}
			
			public Int32 @leaves_end_block
			{
				get
				{
					return this._leaves_end_block;
				}
				set
				{
					if (_leaves_end_block != value)
					{
						_leaves_end_block = value;
						this.changedProperties.Add("leaves_end_block");
					}
				}
			}
			
			public Int32 @end_block
			{
				get
				{
					return this._end_block;
				}
				set
				{
					if (_end_block != value)
					{
						_end_block = value;
						this.changedProperties.Add("end_block");
					}
				}
			}
			
			public Byte[] @root
			{
				get
				{
					return this._root;
				}
				set
				{
					if (_root != value)
					{
						_root = value;
						this.changedProperties.Add("root");
					}
				}
			}
			
		#endregion
	}
	#pragma warning restore CS8618
	#pragma warning restore CS8981
}
