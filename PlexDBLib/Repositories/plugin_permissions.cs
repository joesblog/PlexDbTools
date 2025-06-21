using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Repositories {
	public class Repo_plugin_permissions : IDisposable {
		public PlexDBLib.Context c {get;set;}
		public Repo_plugin_permissions(PlexDBLib.Context x) 
		{
			this.c = x;
		}
		public IEnumerable<PlexDBLib.Models.plugin_permissions> plugin_permissions_GetAll()
		{
			var r =  c.conn.Query<PlexDBLib.Models.plugin_permissions>("SELECT * from plugin_permissions;");
			foreach (var x in r){x.changedProperties.Clear();}
			return r;
		}
		public PlexDBLib.Models.plugin_permissions? plugin_permissions_GetByid (System.Int32 id )
		{
			var r =  c.conn.Query<PlexDBLib.Models.plugin_permissions>($"SELECT * FROM plugin_permissions WHERE id = {id}").FirstOrDefault();
			r.changedProperties.Clear();
			return r;
		}
		public void plugin_permissions_Update (PlexDBLib.Models.plugin_permissions _plugin_permissions )
		{
			if (_plugin_permissions.changedProperties.Count == 0) return;
			string sql = @"UPDATE plugin_permissions";
			sql += "\r\nSET";
			foreach (var p in _plugin_permissions.changedProperties)
			{
				string cma = (p == _plugin_permissions.changedProperties.Last()) ? "" : ",";
				sql += $"\r\n{p} = @{p}{cma}";
			}
			sql += $"\r\nWHERE id = @id;";
			c.conn.Execute(sql,_plugin_permissions);
		}
		public void Dispose()
		{
			this.c.Dispose();
		}
	}
}
