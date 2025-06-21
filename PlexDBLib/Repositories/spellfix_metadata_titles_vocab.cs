using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Repositories {
	public class Repo_spellfix_metadata_titles_vocab : IDisposable {
		public PlexDBLib.Context c {get;set;}
		public Repo_spellfix_metadata_titles_vocab(PlexDBLib.Context x) 
		{
			this.c = x;
		}
		public IEnumerable<PlexDBLib.Models.spellfix_metadata_titles_vocab> spellfix_metadata_titles_vocab_GetAll()
		{
			var r =  c.conn.Query<PlexDBLib.Models.spellfix_metadata_titles_vocab>("SELECT * from spellfix_metadata_titles_vocab;");
			foreach (var x in r){x.changedProperties.Clear();}
			return r;
		}
		public PlexDBLib.Models.spellfix_metadata_titles_vocab? spellfix_metadata_titles_vocab_GetByid (System.Int32 id )
		{
			var r =  c.conn.Query<PlexDBLib.Models.spellfix_metadata_titles_vocab>($"SELECT * FROM spellfix_metadata_titles_vocab WHERE id = {id}").FirstOrDefault();
			r.changedProperties.Clear();
			return r;
		}
		public void spellfix_metadata_titles_vocab_Update (PlexDBLib.Models.spellfix_metadata_titles_vocab _spellfix_metadata_titles_vocab )
		{
			if (_spellfix_metadata_titles_vocab.changedProperties.Count == 0) return;
			string sql = @"UPDATE spellfix_metadata_titles_vocab";
			sql += "\r\nSET";
			foreach (var p in _spellfix_metadata_titles_vocab.changedProperties)
			{
				string cma = (p == _spellfix_metadata_titles_vocab.changedProperties.Last()) ? "" : ",";
				sql += $"\r\n{p} = @{p}{cma}";
			}
			sql += $"\r\nWHERE id = @id;";
			c.conn.Execute(sql,_spellfix_metadata_titles_vocab);
		}
		public void Dispose()
		{
			this.c.Dispose();
		}
	}
}
