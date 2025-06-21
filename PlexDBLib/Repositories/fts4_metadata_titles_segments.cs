using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Repositories {
	public class Repo_fts4_metadata_titles_segments : IDisposable {
		public PlexDBLib.Context c {get;set;}
		public Repo_fts4_metadata_titles_segments(PlexDBLib.Context x) 
		{
			this.c = x;
		}
		public IEnumerable<PlexDBLib.Models.fts4_metadata_titles_segments> fts4_metadata_titles_segments_GetAll()
		{
			var r =  c.conn.Query<PlexDBLib.Models.fts4_metadata_titles_segments>("SELECT * from fts4_metadata_titles_segments;");
			foreach (var x in r){x.changedProperties.Clear();}
			return r;
		}
		public PlexDBLib.Models.fts4_metadata_titles_segments? fts4_metadata_titles_segments_GetByblockid (System.Int32 blockid )
		{
			var r =  c.conn.Query<PlexDBLib.Models.fts4_metadata_titles_segments>($"SELECT * FROM fts4_metadata_titles_segments WHERE blockid = {blockid}").FirstOrDefault();
			r.changedProperties.Clear();
			return r;
		}
		public void fts4_metadata_titles_segments_Update (PlexDBLib.Models.fts4_metadata_titles_segments _fts4_metadata_titles_segments )
		{
			if (_fts4_metadata_titles_segments.changedProperties.Count == 0) return;
			string sql = @"UPDATE fts4_metadata_titles_segments";
			sql += "\r\nSET";
			foreach (var p in _fts4_metadata_titles_segments.changedProperties)
			{
				string cma = (p == _fts4_metadata_titles_segments.changedProperties.Last()) ? "" : ",";
				sql += $"\r\n{p} = @{p}{cma}";
			}
			sql += $"\r\nWHERE blockid = @blockid;";
			c.conn.Execute(sql,_fts4_metadata_titles_segments);
		}
		public void Dispose()
		{
			this.c.Dispose();
		}
	}
}
