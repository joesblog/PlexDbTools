using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Repositories {
	public class Repo_locations_parent : IDisposable {
		public PlexDBLib.Context c {get;set;}
		public Repo_locations_parent(PlexDBLib.Context x) 
		{
			this.c = x;
		}
		public IEnumerable<PlexDBLib.Models.locations_parent> locations_parent_GetAll()
		{
			var r =  c.conn.Query<PlexDBLib.Models.locations_parent>("SELECT * from locations_parent;");
			foreach (var x in r){x.changedProperties.Clear();}
			return r;
		}
		public PlexDBLib.Models.locations_parent? locations_parent_GetBynodeno (System.Int32 nodeno )
		{
			var r =  c.conn.Query<PlexDBLib.Models.locations_parent>($"SELECT * FROM locations_parent WHERE nodeno = {nodeno}").FirstOrDefault();
			r.changedProperties.Clear();
			return r;
		}
		public void locations_parent_Update (PlexDBLib.Models.locations_parent _locations_parent )
		{
			if (_locations_parent.changedProperties.Count == 0) return;
			string sql = @"UPDATE locations_parent";
			sql += "\r\nSET";
			foreach (var p in _locations_parent.changedProperties)
			{
				string cma = (p == _locations_parent.changedProperties.Last()) ? "" : ",";
				sql += $"\r\n{p} = @{p}{cma}";
			}
			sql += $"\r\nWHERE nodeno = @nodeno;";
			c.conn.Execute(sql,_locations_parent);
		}
		public void Dispose()
		{
			this.c.Dispose();
		}
	}
}
