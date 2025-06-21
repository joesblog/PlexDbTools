using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Repositories {
	public class Repo_plugins : IDisposable {
		public PlexDBLib.Context c {get;set;}
		public Repo_plugins(PlexDBLib.Context x) 
		{
			this.c = x;
		}
		public IEnumerable<PlexDBLib.Models.plugins> plugins_GetAll()
		{
			var r =  c.conn.Query<PlexDBLib.Models.plugins>("SELECT * from plugins;");
			foreach (var x in r){x.changedProperties.Clear();}
			return r;
		}
		public PlexDBLib.Models.plugins? plugins_GetByid (System.Int32 id )
		{
			var r =  c.conn.Query<PlexDBLib.Models.plugins>($"SELECT * FROM plugins WHERE id = {id}").FirstOrDefault();
			r.changedProperties.Clear();
			return r;
		}
		public void plugins_Update (PlexDBLib.Models.plugins _plugins )
		{
			if (_plugins.changedProperties.Count == 0) return;
			string sql = @"UPDATE plugins";
			sql += "\r\nSET";
			foreach (var p in _plugins.changedProperties)
			{
				string cma = (p == _plugins.changedProperties.Last()) ? "" : ",";
				sql += $"\r\n{p} = @{p}{cma}";
			}
			sql += $"\r\nWHERE id = @id;";
			c.conn.Execute(sql,_plugins);
		}
		public void Dispose()
		{
			this.c.Dispose();
		}
	}
}
