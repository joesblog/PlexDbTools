using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Repositories {
	public class Repo_view_settings : IDisposable {
		public PlexDBLib.Context c {get;set;}
		public Repo_view_settings(PlexDBLib.Context x) 
		{
			this.c = x;
		}
		public IEnumerable<PlexDBLib.Models.view_settings> view_settings_GetAll()
		{
			var r =  c.conn.Query<PlexDBLib.Models.view_settings>("SELECT * from view_settings;");
			foreach (var x in r){x.changedProperties.Clear();}
			return r;
		}
		public PlexDBLib.Models.view_settings? view_settings_GetByid (System.Int32 id )
		{
			var r =  c.conn.Query<PlexDBLib.Models.view_settings>($"SELECT * FROM view_settings WHERE id = {id}").FirstOrDefault();
			r.changedProperties.Clear();
			return r;
		}
		public void view_settings_Update (PlexDBLib.Models.view_settings _view_settings )
		{
			if (_view_settings.changedProperties.Count == 0) return;
			string sql = @"UPDATE view_settings";
			sql += "\r\nSET";
			foreach (var p in _view_settings.changedProperties)
			{
				string cma = (p == _view_settings.changedProperties.Last()) ? "" : ",";
				sql += $"\r\n{p} = @{p}{cma}";
			}
			sql += $"\r\nWHERE id = @id;";
			c.conn.Execute(sql,_view_settings);
		}
		public void Dispose()
		{
			this.c.Dispose();
		}
	}
}
