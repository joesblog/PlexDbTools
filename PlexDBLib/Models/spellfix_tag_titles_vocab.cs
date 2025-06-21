using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
using System.ComponentModel;

#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Models {
	public class spellfix_tag_titles_vocab {
		public List<string> changedProperties = new List<string>();
		#region fields
			private Int32 _id;// sqllite type = INTEGER
			private Int32 _rank;// sqllite type = INT
			private Int32 _langid;// sqllite type = INT
			private String _word;// sqllite type = TEXT
			private String _k1;// sqllite type = TEXT
			private String _k2;// sqllite type = TEXT
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
			
			public Int32 @rank
			{
				get
				{
					return this._rank;
				}
				set
				{
					if (_rank != value)
					{
						_rank = value;
						this.changedProperties.Add("rank");
					}
				}
			}
			
			public Int32 @langid
			{
				get
				{
					return this._langid;
				}
				set
				{
					if (_langid != value)
					{
						_langid = value;
						this.changedProperties.Add("langid");
					}
				}
			}
			
			public String @word
			{
				get
				{
					return this._word;
				}
				set
				{
					if (_word != value)
					{
						_word = value;
						this.changedProperties.Add("word");
					}
				}
			}
			
			public String @k1
			{
				get
				{
					return this._k1;
				}
				set
				{
					if (_k1 != value)
					{
						_k1 = value;
						this.changedProperties.Add("k1");
					}
				}
			}
			
			public String @k2
			{
				get
				{
					return this._k2;
				}
				set
				{
					if (_k2 != value)
					{
						_k2 = value;
						this.changedProperties.Add("k2");
					}
				}
			}
			
		#endregion
	}
	#pragma warning restore CS8618
	#pragma warning restore CS8981
}
