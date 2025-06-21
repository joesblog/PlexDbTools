using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Repositories {
	public class Repo_media_streams : IDisposable {
		public PlexDBLib.Context c {get;set;}
		public Repo_media_streams(PlexDBLib.Context x) 
		{
			this.c = x;
		}
		public IEnumerable<PlexDBLib.Models.media_streams> media_streams_GetAll()
		{
			var r =  c.conn.Query<PlexDBLib.Models.media_streams>("SELECT * from media_streams;");
			foreach (var x in r){x.changedProperties.Clear();}
			return r;
		}
		public PlexDBLib.Models.media_streams? media_streams_GetByid (System.Int32 id )
		{
			var r =  c.conn.Query<PlexDBLib.Models.media_streams>($"SELECT * FROM media_streams WHERE id = {id}").FirstOrDefault();
			r.changedProperties.Clear();
			return r;
		}
		public void media_streams_Update (PlexDBLib.Models.media_streams _media_streams )
		{
			if (_media_streams.changedProperties.Count == 0) return;
			string sql = @"UPDATE media_streams";
			sql += "\r\nSET";
			foreach (var p in _media_streams.changedProperties)
			{
				string cma = (p == _media_streams.changedProperties.Last()) ? "" : ",";
				sql += $"\r\n{p} = @{p}{cma}";
			}
			sql += $"\r\nWHERE id = @id;";
			c.conn.Execute(sql,_media_streams);
		}
		public void Dispose()
		{
			this.c.Dispose();
		}
	}
}
