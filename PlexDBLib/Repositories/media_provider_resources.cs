using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Repositories {
	public class Repo_media_provider_resources : IDisposable {
		public PlexDBLib.Context c {get;set;}
		public Repo_media_provider_resources(PlexDBLib.Context x) 
		{
			this.c = x;
		}
		public IEnumerable<PlexDBLib.Models.media_provider_resources> media_provider_resources_GetAll()
		{
			var r =  c.conn.Query<PlexDBLib.Models.media_provider_resources>("SELECT * from media_provider_resources;");
			foreach (var x in r){x.changedProperties.Clear();}
			return r;
		}
		public PlexDBLib.Models.media_provider_resources? media_provider_resources_GetByid (System.Int32 id )
		{
			var r =  c.conn.Query<PlexDBLib.Models.media_provider_resources>($"SELECT * FROM media_provider_resources WHERE id = {id}").FirstOrDefault();
			r.changedProperties.Clear();
			return r;
		}
		public void media_provider_resources_Update (PlexDBLib.Models.media_provider_resources _media_provider_resources )
		{
			if (_media_provider_resources.changedProperties.Count == 0) return;
			string sql = @"UPDATE media_provider_resources";
			sql += "\r\nSET";
			foreach (var p in _media_provider_resources.changedProperties)
			{
				string cma = (p == _media_provider_resources.changedProperties.Last()) ? "" : ",";
				sql += $"\r\n{p} = @{p}{cma}";
			}
			sql += $"\r\nWHERE id = @id;";
			c.conn.Execute(sql,_media_provider_resources);
		}
		public void Dispose()
		{
			this.c.Dispose();
		}
	}
}
