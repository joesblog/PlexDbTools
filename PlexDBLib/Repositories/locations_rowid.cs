using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Repositories {
	public class Repo_locations_rowid : IDisposable {
		public PlexDBLib.Context c {get;set;}
		public Repo_locations_rowid(PlexDBLib.Context x) 
		{
			this.c = x;
		}
		public IEnumerable<PlexDBLib.Models.locations_rowid> locations_rowid_GetAll()
		{
			var r =  c.conn.Query<PlexDBLib.Models.locations_rowid>("SELECT * from locations_rowid;");
			foreach (var x in r){x.changedProperties.Clear();}
			return r;
		}
		public PlexDBLib.Models.locations_rowid? locations_rowid_GetByrowid (System.Int32 rowid )
		{
			var r =  c.conn.Query<PlexDBLib.Models.locations_rowid>($"SELECT * FROM locations_rowid WHERE rowid = {rowid}").FirstOrDefault();
			r.changedProperties.Clear();
			return r;
		}
		public void locations_rowid_Update (PlexDBLib.Models.locations_rowid _locations_rowid )
		{
			if (_locations_rowid.changedProperties.Count == 0) return;
			string sql = @"UPDATE locations_rowid";
			sql += "\r\nSET";
			foreach (var p in _locations_rowid.changedProperties)
			{
				string cma = (p == _locations_rowid.changedProperties.Last()) ? "" : ",";
				sql += $"\r\n{p} = @{p}{cma}";
			}
			sql += $"\r\nWHERE rowid = @rowid;";
			c.conn.Execute(sql,_locations_rowid);
		}
		public void Dispose()
		{
			this.c.Dispose();
		}
	}
}
