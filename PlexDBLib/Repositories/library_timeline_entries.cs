using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Repositories {
	public class Repo_library_timeline_entries : IDisposable {
		public PlexDBLib.Context c {get;set;}
		public Repo_library_timeline_entries(PlexDBLib.Context x) 
		{
			this.c = x;
		}
		public IEnumerable<PlexDBLib.Models.library_timeline_entries> library_timeline_entries_GetAll()
		{
			var r =  c.conn.Query<PlexDBLib.Models.library_timeline_entries>("SELECT * from library_timeline_entries;");
			foreach (var x in r){x.changedProperties.Clear();}
			return r;
		}
		public PlexDBLib.Models.library_timeline_entries? library_timeline_entries_GetByid (System.Int32 id )
		{
			var r =  c.conn.Query<PlexDBLib.Models.library_timeline_entries>($"SELECT * FROM library_timeline_entries WHERE id = {id}").FirstOrDefault();
			r.changedProperties.Clear();
			return r;
		}
		public void library_timeline_entries_Update (PlexDBLib.Models.library_timeline_entries _library_timeline_entries )
		{
			if (_library_timeline_entries.changedProperties.Count == 0) return;
			string sql = @"UPDATE library_timeline_entries";
			sql += "\r\nSET";
			foreach (var p in _library_timeline_entries.changedProperties)
			{
				string cma = (p == _library_timeline_entries.changedProperties.Last()) ? "" : ",";
				sql += $"\r\n{p} = @{p}{cma}";
			}
			sql += $"\r\nWHERE id = @id;";
			c.conn.Execute(sql,_library_timeline_entries);
		}
		public void Dispose()
		{
			this.c.Dispose();
		}
	}
}
