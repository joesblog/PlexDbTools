using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Repositories {
	public class Repo_plugin_prefixes : IDisposable {
		public PlexDBLib.Context c {get;set;}
		public Repo_plugin_prefixes(PlexDBLib.Context x) 
		{
			this.c = x;
		}
		public IEnumerable<PlexDBLib.Models.plugin_prefixes> plugin_prefixes_GetAll()
		{
			var r =  c.conn.Query<PlexDBLib.Models.plugin_prefixes>("SELECT * from plugin_prefixes;");
			foreach (var x in r){x.changedProperties.Clear();}
			return r;
		}
		public PlexDBLib.Models.plugin_prefixes? plugin_prefixes_GetByid (System.Int32 id )
		{
			var r =  c.conn.Query<PlexDBLib.Models.plugin_prefixes>($"SELECT * FROM plugin_prefixes WHERE id = {id}").FirstOrDefault();
			r.changedProperties.Clear();
			return r;
		}
		public void plugin_prefixes_Update (PlexDBLib.Models.plugin_prefixes _plugin_prefixes )
		{
			if (_plugin_prefixes.changedProperties.Count == 0) return;
			string sql = @"UPDATE plugin_prefixes";
			sql += "\r\nSET";
			foreach (var p in _plugin_prefixes.changedProperties)
			{
				string cma = (p == _plugin_prefixes.changedProperties.Last()) ? "" : ",";
				sql += $"\r\n{p} = @{p}{cma}";
			}
			sql += $"\r\nWHERE id = @id;";
			c.conn.Execute(sql,_plugin_prefixes);
		}
		public void Dispose()
		{
			this.c.Dispose();
		}
	}
}
