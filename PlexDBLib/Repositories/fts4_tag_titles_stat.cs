using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Repositories {
	public class Repo_fts4_tag_titles_stat : IDisposable {
		public PlexDBLib.Context c {get;set;}
		public Repo_fts4_tag_titles_stat(PlexDBLib.Context x) 
		{
			this.c = x;
		}
		public IEnumerable<PlexDBLib.Models.fts4_tag_titles_stat> fts4_tag_titles_stat_GetAll()
		{
			var r =  c.conn.Query<PlexDBLib.Models.fts4_tag_titles_stat>("SELECT * from fts4_tag_titles_stat;");
			foreach (var x in r){x.changedProperties.Clear();}
			return r;
		}
		public PlexDBLib.Models.fts4_tag_titles_stat? fts4_tag_titles_stat_GetByid (System.Int32 id )
		{
			var r =  c.conn.Query<PlexDBLib.Models.fts4_tag_titles_stat>($"SELECT * FROM fts4_tag_titles_stat WHERE id = {id}").FirstOrDefault();
			r.changedProperties.Clear();
			return r;
		}
		public void fts4_tag_titles_stat_Update (PlexDBLib.Models.fts4_tag_titles_stat _fts4_tag_titles_stat )
		{
			if (_fts4_tag_titles_stat.changedProperties.Count == 0) return;
			string sql = @"UPDATE fts4_tag_titles_stat";
			sql += "\r\nSET";
			foreach (var p in _fts4_tag_titles_stat.changedProperties)
			{
				string cma = (p == _fts4_tag_titles_stat.changedProperties.Last()) ? "" : ",";
				sql += $"\r\n{p} = @{p}{cma}";
			}
			sql += $"\r\nWHERE id = @id;";
			c.conn.Execute(sql,_fts4_tag_titles_stat);
		}
		public void Dispose()
		{
			this.c.Dispose();
		}
	}
}
