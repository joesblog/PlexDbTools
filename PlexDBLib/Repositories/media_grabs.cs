using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Repositories {
	public class Repo_media_grabs : IDisposable {
		public PlexDBLib.Context c {get;set;}
		public Repo_media_grabs(PlexDBLib.Context x) 
		{
			this.c = x;
		}
		public IEnumerable<PlexDBLib.Models.media_grabs> media_grabs_GetAll()
		{
			var r =  c.conn.Query<PlexDBLib.Models.media_grabs>("SELECT * from media_grabs;");
			foreach (var x in r){x.changedProperties.Clear();}
			return r;
		}
		public PlexDBLib.Models.media_grabs? media_grabs_GetByid (System.Int32 id )
		{
			var r =  c.conn.Query<PlexDBLib.Models.media_grabs>($"SELECT * FROM media_grabs WHERE id = {id}").FirstOrDefault();
			r.changedProperties.Clear();
			return r;
		}
		public void media_grabs_Update (PlexDBLib.Models.media_grabs _media_grabs )
		{
			if (_media_grabs.changedProperties.Count == 0) return;
			string sql = @"UPDATE media_grabs";
			sql += "\r\nSET";
			foreach (var p in _media_grabs.changedProperties)
			{
				string cma = (p == _media_grabs.changedProperties.Last()) ? "" : ",";
				sql += $"\r\n{p} = @{p}{cma}";
			}
			sql += $"\r\nWHERE id = @id;";
			c.conn.Execute(sql,_media_grabs);
		}
		public void Dispose()
		{
			this.c.Dispose();
		}
	}
}
