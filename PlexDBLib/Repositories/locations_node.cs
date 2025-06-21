using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Repositories {
	public class Repo_locations_node : IDisposable {
		public PlexDBLib.Context c {get;set;}
		public Repo_locations_node(PlexDBLib.Context x) 
		{
			this.c = x;
		}
		public IEnumerable<PlexDBLib.Models.locations_node> locations_node_GetAll()
		{
			var r =  c.conn.Query<PlexDBLib.Models.locations_node>("SELECT * from locations_node;");
			foreach (var x in r){x.changedProperties.Clear();}
			return r;
		}
		public PlexDBLib.Models.locations_node? locations_node_GetBynodeno (System.Int32 nodeno )
		{
			var r =  c.conn.Query<PlexDBLib.Models.locations_node>($"SELECT * FROM locations_node WHERE nodeno = {nodeno}").FirstOrDefault();
			r.changedProperties.Clear();
			return r;
		}
		public void locations_node_Update (PlexDBLib.Models.locations_node _locations_node )
		{
			if (_locations_node.changedProperties.Count == 0) return;
			string sql = @"UPDATE locations_node";
			sql += "\r\nSET";
			foreach (var p in _locations_node.changedProperties)
			{
				string cma = (p == _locations_node.changedProperties.Last()) ? "" : ",";
				sql += $"\r\n{p} = @{p}{cma}";
			}
			sql += $"\r\nWHERE nodeno = @nodeno;";
			c.conn.Execute(sql,_locations_node);
		}
		public void Dispose()
		{
			this.c.Dispose();
		}
	}
}
