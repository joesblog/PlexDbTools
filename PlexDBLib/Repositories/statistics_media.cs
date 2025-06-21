using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Repositories {
	public class Repo_statistics_media : IDisposable {
		public PlexDBLib.Context c {get;set;}
		public Repo_statistics_media(PlexDBLib.Context x) 
		{
			this.c = x;
		}
		public IEnumerable<PlexDBLib.Models.statistics_media> statistics_media_GetAll()
		{
			var r =  c.conn.Query<PlexDBLib.Models.statistics_media>("SELECT * from statistics_media;");
			foreach (var x in r){x.changedProperties.Clear();}
			return r;
		}
		public PlexDBLib.Models.statistics_media? statistics_media_GetByid (System.Int32 id )
		{
			var r =  c.conn.Query<PlexDBLib.Models.statistics_media>($"SELECT * FROM statistics_media WHERE id = {id}").FirstOrDefault();
			r.changedProperties.Clear();
			return r;
		}
		public void statistics_media_Update (PlexDBLib.Models.statistics_media _statistics_media )
		{
			if (_statistics_media.changedProperties.Count == 0) return;
			string sql = @"UPDATE statistics_media";
			sql += "\r\nSET";
			foreach (var p in _statistics_media.changedProperties)
			{
				string cma = (p == _statistics_media.changedProperties.Last()) ? "" : ",";
				sql += $"\r\n{p} = @{p}{cma}";
			}
			sql += $"\r\nWHERE id = @id;";
			c.conn.Execute(sql,_statistics_media);
		}
		public void Dispose()
		{
			this.c.Dispose();
		}
	}
}
