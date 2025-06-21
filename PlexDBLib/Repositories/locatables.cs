using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Repositories {
	public class Repo_locatables : IDisposable {
		public PlexDBLib.Context c {get;set;}
		public Repo_locatables(PlexDBLib.Context x) 
		{
			this.c = x;
		}
		public IEnumerable<PlexDBLib.Models.locatables> locatables_GetAll()
		{
			var r =  c.conn.Query<PlexDBLib.Models.locatables>("SELECT * from locatables;");
			foreach (var x in r){x.changedProperties.Clear();}
			return r;
		}
		public PlexDBLib.Models.locatables? locatables_GetByid (System.Int32 id )
		{
			var r =  c.conn.Query<PlexDBLib.Models.locatables>($"SELECT * FROM locatables WHERE id = {id}").FirstOrDefault();
			r.changedProperties.Clear();
			return r;
		}
		public void locatables_Update (PlexDBLib.Models.locatables _locatables )
		{
			if (_locatables.changedProperties.Count == 0) return;
			string sql = @"UPDATE locatables";
			sql += "\r\nSET";
			foreach (var p in _locatables.changedProperties)
			{
				string cma = (p == _locatables.changedProperties.Last()) ? "" : ",";
				sql += $"\r\n{p} = @{p}{cma}";
			}
			sql += $"\r\nWHERE id = @id;";
			c.conn.Execute(sql,_locatables);
		}
		public void Dispose()
		{
			this.c.Dispose();
		}
	}
}
