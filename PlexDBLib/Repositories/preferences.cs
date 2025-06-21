using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Repositories {
	public class Repo_preferences : IDisposable {
		public PlexDBLib.Context c {get;set;}
		public Repo_preferences(PlexDBLib.Context x) 
		{
			this.c = x;
		}
		public IEnumerable<PlexDBLib.Models.preferences> preferences_GetAll()
		{
			var r =  c.conn.Query<PlexDBLib.Models.preferences>("SELECT * from preferences;");
			foreach (var x in r){x.changedProperties.Clear();}
			return r;
		}
		public PlexDBLib.Models.preferences? preferences_GetByid (System.Int32 id )
		{
			var r =  c.conn.Query<PlexDBLib.Models.preferences>($"SELECT * FROM preferences WHERE id = {id}").FirstOrDefault();
			r.changedProperties.Clear();
			return r;
		}
		public void preferences_Update (PlexDBLib.Models.preferences _preferences )
		{
			if (_preferences.changedProperties.Count == 0) return;
			string sql = @"UPDATE preferences";
			sql += "\r\nSET";
			foreach (var p in _preferences.changedProperties)
			{
				string cma = (p == _preferences.changedProperties.Last()) ? "" : ",";
				sql += $"\r\n{p} = @{p}{cma}";
			}
			sql += $"\r\nWHERE id = @id;";
			c.conn.Execute(sql,_preferences);
		}
		public void Dispose()
		{
			this.c.Dispose();
		}
	}
}
