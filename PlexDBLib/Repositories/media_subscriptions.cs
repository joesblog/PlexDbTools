using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Repositories {
	public class Repo_media_subscriptions : IDisposable {
		public PlexDBLib.Context c {get;set;}
		public Repo_media_subscriptions(PlexDBLib.Context x) 
		{
			this.c = x;
		}
		public IEnumerable<PlexDBLib.Models.media_subscriptions> media_subscriptions_GetAll()
		{
			var r =  c.conn.Query<PlexDBLib.Models.media_subscriptions>("SELECT * from media_subscriptions;");
			foreach (var x in r){x.changedProperties.Clear();}
			return r;
		}
		public PlexDBLib.Models.media_subscriptions? media_subscriptions_GetByid (System.Int32 id )
		{
			var r =  c.conn.Query<PlexDBLib.Models.media_subscriptions>($"SELECT * FROM media_subscriptions WHERE id = {id}").FirstOrDefault();
			r.changedProperties.Clear();
			return r;
		}
		public void media_subscriptions_Update (PlexDBLib.Models.media_subscriptions _media_subscriptions )
		{
			if (_media_subscriptions.changedProperties.Count == 0) return;
			string sql = @"UPDATE media_subscriptions";
			sql += "\r\nSET";
			foreach (var p in _media_subscriptions.changedProperties)
			{
				string cma = (p == _media_subscriptions.changedProperties.Last()) ? "" : ",";
				sql += $"\r\n{p} = @{p}{cma}";
			}
			sql += $"\r\nWHERE id = @id;";
			c.conn.Execute(sql,_media_subscriptions);
		}
		public void Dispose()
		{
			this.c.Dispose();
		}
	}
}
