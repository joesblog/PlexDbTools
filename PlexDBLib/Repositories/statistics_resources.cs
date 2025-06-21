using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Repositories {
	public class Repo_statistics_resources : IDisposable {
		public PlexDBLib.Context c {get;set;}
		public Repo_statistics_resources(PlexDBLib.Context x) 
		{
			this.c = x;
		}
		public IEnumerable<PlexDBLib.Models.statistics_resources> statistics_resources_GetAll()
		{
			var r =  c.conn.Query<PlexDBLib.Models.statistics_resources>("SELECT * from statistics_resources;");
			foreach (var x in r){x.changedProperties.Clear();}
			return r;
		}
		public PlexDBLib.Models.statistics_resources? statistics_resources_GetByid (System.Int32 id )
		{
			var r =  c.conn.Query<PlexDBLib.Models.statistics_resources>($"SELECT * FROM statistics_resources WHERE id = {id}").FirstOrDefault();
			r.changedProperties.Clear();
			return r;
		}
		public void statistics_resources_Update (PlexDBLib.Models.statistics_resources _statistics_resources )
		{
			if (_statistics_resources.changedProperties.Count == 0) return;
			string sql = @"UPDATE statistics_resources";
			sql += "\r\nSET";
			foreach (var p in _statistics_resources.changedProperties)
			{
				string cma = (p == _statistics_resources.changedProperties.Last()) ? "" : ",";
				sql += $"\r\n{p} = @{p}{cma}";
			}
			sql += $"\r\nWHERE id = @id;";
			c.conn.Execute(sql,_statistics_resources);
		}
		public void Dispose()
		{
			this.c.Dispose();
		}
	}
}
