using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Repositories {
	public class Repo_media_parts : IDisposable {
		public PlexDBLib.Context c {get;set;}
		public Repo_media_parts(PlexDBLib.Context x) 
		{
			this.c = x;
		}
		public IEnumerable<PlexDBLib.Models.media_parts> media_parts_GetAll()
		{
			var r =  c.conn.Query<PlexDBLib.Models.media_parts>("SELECT * from media_parts;");
			foreach (var x in r){x.changedProperties.Clear();}
			return r;
		}
		public PlexDBLib.Models.media_parts? media_parts_GetByid (System.Int32 id )
		{
			var r =  c.conn.Query<PlexDBLib.Models.media_parts>($"SELECT * FROM media_parts WHERE id = {id}").FirstOrDefault();
			r.changedProperties.Clear();
			return r;
		}
		public void media_parts_Update (PlexDBLib.Models.media_parts _media_parts )
		{
			if (_media_parts.changedProperties.Count == 0) return;
			string sql = @"UPDATE media_parts";
			sql += "\r\nSET";
			foreach (var p in _media_parts.changedProperties)
			{
				string cma = (p == _media_parts.changedProperties.Last()) ? "" : ",";
				sql += $"\r\n{p} = @{p}{cma}";
			}
			sql += $"\r\nWHERE id = @id;";
			c.conn.Execute(sql,_media_parts);
		}
		public void Dispose()
		{
			this.c.Dispose();
		}
	}
}
