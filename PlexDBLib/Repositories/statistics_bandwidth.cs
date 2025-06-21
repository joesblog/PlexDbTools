using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Repositories {
	public class Repo_statistics_bandwidth : IDisposable {
		public PlexDBLib.Context c {get;set;}
		public Repo_statistics_bandwidth(PlexDBLib.Context x) 
		{
			this.c = x;
		}
		public IEnumerable<PlexDBLib.Models.statistics_bandwidth> statistics_bandwidth_GetAll()
		{
			var r =  c.conn.Query<PlexDBLib.Models.statistics_bandwidth>("SELECT * from statistics_bandwidth;");
			foreach (var x in r){x.changedProperties.Clear();}
			return r;
		}
		public PlexDBLib.Models.statistics_bandwidth? statistics_bandwidth_GetByid (System.Int32 id )
		{
			var r =  c.conn.Query<PlexDBLib.Models.statistics_bandwidth>($"SELECT * FROM statistics_bandwidth WHERE id = {id}").FirstOrDefault();
			r.changedProperties.Clear();
			return r;
		}
		public void statistics_bandwidth_Update (PlexDBLib.Models.statistics_bandwidth _statistics_bandwidth )
		{
			if (_statistics_bandwidth.changedProperties.Count == 0) return;
			string sql = @"UPDATE statistics_bandwidth";
			sql += "\r\nSET";
			foreach (var p in _statistics_bandwidth.changedProperties)
			{
				string cma = (p == _statistics_bandwidth.changedProperties.Last()) ? "" : ",";
				sql += $"\r\n{p} = @{p}{cma}";
			}
			sql += $"\r\nWHERE id = @id;";
			c.conn.Execute(sql,_statistics_bandwidth);
		}
		public void Dispose()
		{
			this.c.Dispose();
		}
	}
}
