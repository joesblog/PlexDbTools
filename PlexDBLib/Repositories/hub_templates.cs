using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Repositories {
	public class Repo_hub_templates : IDisposable {
		public PlexDBLib.Context c {get;set;}
		public Repo_hub_templates(PlexDBLib.Context x) 
		{
			this.c = x;
		}
		public IEnumerable<PlexDBLib.Models.hub_templates> hub_templates_GetAll()
		{
			var r =  c.conn.Query<PlexDBLib.Models.hub_templates>("SELECT * from hub_templates;");
			foreach (var x in r){x.changedProperties.Clear();}
			return r;
		}
		public PlexDBLib.Models.hub_templates? hub_templates_GetByid (System.Int32 id )
		{
			var r =  c.conn.Query<PlexDBLib.Models.hub_templates>($"SELECT * FROM hub_templates WHERE id = {id}").FirstOrDefault();
			r.changedProperties.Clear();
			return r;
		}
		public void hub_templates_Update (PlexDBLib.Models.hub_templates _hub_templates )
		{
			if (_hub_templates.changedProperties.Count == 0) return;
			string sql = @"UPDATE hub_templates";
			sql += "\r\nSET";
			foreach (var p in _hub_templates.changedProperties)
			{
				string cma = (p == _hub_templates.changedProperties.Last()) ? "" : ",";
				sql += $"\r\n{p} = @{p}{cma}";
			}
			sql += $"\r\nWHERE id = @id;";
			c.conn.Execute(sql,_hub_templates);
		}
		public void Dispose()
		{
			this.c.Dispose();
		}
	}
}
