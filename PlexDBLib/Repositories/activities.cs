using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Repositories {
	public class Repo_activities : IDisposable {
		public PlexDBLib.Context c {get;set;}
		public Repo_activities(PlexDBLib.Context x) 
		{
			this.c = x;
		}
		public IEnumerable<PlexDBLib.Models.activities> activities_GetAll()
		{
			var r =  c.conn.Query<PlexDBLib.Models.activities>("SELECT * from activities;");
			foreach (var x in r){x.changedProperties.Clear();}
			return r;
		}
		public PlexDBLib.Models.activities? activities_GetByid (System.Int32 id )
		{
			var r =  c.conn.Query<PlexDBLib.Models.activities>($"SELECT * FROM activities WHERE id = {id}").FirstOrDefault();
			r.changedProperties.Clear();
			return r;
		}
		public void activities_Update (PlexDBLib.Models.activities _activities )
		{
			if (_activities.changedProperties.Count == 0) return;
			string sql = @"UPDATE activities";
			sql += "\r\nSET";
			foreach (var p in _activities.changedProperties)
			{
				string cma = (p == _activities.changedProperties.Last()) ? "" : ",";
				sql += $"\r\n{p} = @{p}{cma}";
			}
			sql += $"\r\nWHERE id = @id;";
			c.conn.Execute(sql,_activities);
		}
		public void Dispose()
		{
			this.c.Dispose();
		}
	}
}
