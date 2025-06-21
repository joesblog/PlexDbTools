using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Repositories {
	public class Repo_fts4_tag_titles_docsize : IDisposable {
		public PlexDBLib.Context c {get;set;}
		public Repo_fts4_tag_titles_docsize(PlexDBLib.Context x) 
		{
			this.c = x;
		}
		public IEnumerable<PlexDBLib.Models.fts4_tag_titles_docsize> fts4_tag_titles_docsize_GetAll()
		{
			var r =  c.conn.Query<PlexDBLib.Models.fts4_tag_titles_docsize>("SELECT * from fts4_tag_titles_docsize;");
			foreach (var x in r){x.changedProperties.Clear();}
			return r;
		}
		public PlexDBLib.Models.fts4_tag_titles_docsize? fts4_tag_titles_docsize_GetBydocid (System.Int32 docid )
		{
			var r =  c.conn.Query<PlexDBLib.Models.fts4_tag_titles_docsize>($"SELECT * FROM fts4_tag_titles_docsize WHERE docid = {docid}").FirstOrDefault();
			r.changedProperties.Clear();
			return r;
		}
		public void fts4_tag_titles_docsize_Update (PlexDBLib.Models.fts4_tag_titles_docsize _fts4_tag_titles_docsize )
		{
			if (_fts4_tag_titles_docsize.changedProperties.Count == 0) return;
			string sql = @"UPDATE fts4_tag_titles_docsize";
			sql += "\r\nSET";
			foreach (var p in _fts4_tag_titles_docsize.changedProperties)
			{
				string cma = (p == _fts4_tag_titles_docsize.changedProperties.Last()) ? "" : ",";
				sql += $"\r\n{p} = @{p}{cma}";
			}
			sql += $"\r\nWHERE docid = @docid;";
			c.conn.Execute(sql,_fts4_tag_titles_docsize);
		}
		public void Dispose()
		{
			this.c.Dispose();
		}
	}
}
