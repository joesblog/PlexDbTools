using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Repositories {
	public class Repo_fts4_tag_titles_icu_segdir : IDisposable {
		public PlexDBLib.Context c {get;set;}
		public Repo_fts4_tag_titles_icu_segdir(PlexDBLib.Context x) 
		{
			this.c = x;
		}
		public IEnumerable<PlexDBLib.Models.fts4_tag_titles_icu_segdir> fts4_tag_titles_icu_segdir_GetAll()
		{
			var r =  c.conn.Query<PlexDBLib.Models.fts4_tag_titles_icu_segdir>("SELECT * from fts4_tag_titles_icu_segdir;");
			foreach (var x in r){x.changedProperties.Clear();}
			return r;
		}
		public PlexDBLib.Models.fts4_tag_titles_icu_segdir? fts4_tag_titles_icu_segdir_GetBylevel (System.Int32 level )
		{
			var r =  c.conn.Query<PlexDBLib.Models.fts4_tag_titles_icu_segdir>($"SELECT * FROM fts4_tag_titles_icu_segdir WHERE level = {level}").FirstOrDefault();
			r.changedProperties.Clear();
			return r;
		}
		public void fts4_tag_titles_icu_segdir_Update (PlexDBLib.Models.fts4_tag_titles_icu_segdir _fts4_tag_titles_icu_segdir )
		{
			if (_fts4_tag_titles_icu_segdir.changedProperties.Count == 0) return;
			string sql = @"UPDATE fts4_tag_titles_icu_segdir";
			sql += "\r\nSET";
			foreach (var p in _fts4_tag_titles_icu_segdir.changedProperties)
			{
				string cma = (p == _fts4_tag_titles_icu_segdir.changedProperties.Last()) ? "" : ",";
				sql += $"\r\n{p} = @{p}{cma}";
			}
			sql += $"\r\nWHERE level = @level;";
			c.conn.Execute(sql,_fts4_tag_titles_icu_segdir);
		}
		public void Dispose()
		{
			this.c.Dispose();
		}
	}
}
