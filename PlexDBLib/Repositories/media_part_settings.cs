using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Repositories {
	public class Repo_media_part_settings : IDisposable {
		public PlexDBLib.Context c {get;set;}
		public Repo_media_part_settings(PlexDBLib.Context x) 
		{
			this.c = x;
		}
		public IEnumerable<PlexDBLib.Models.media_part_settings> media_part_settings_GetAll()
		{
			var r =  c.conn.Query<PlexDBLib.Models.media_part_settings>("SELECT * from media_part_settings;");
			foreach (var x in r){x.changedProperties.Clear();}
			return r;
		}
		public PlexDBLib.Models.media_part_settings? media_part_settings_GetByid (System.Int32 id )
		{
			var r =  c.conn.Query<PlexDBLib.Models.media_part_settings>($"SELECT * FROM media_part_settings WHERE id = {id}").FirstOrDefault();
			r.changedProperties.Clear();
			return r;
		}
		public void media_part_settings_Update (PlexDBLib.Models.media_part_settings _media_part_settings )
		{
			if (_media_part_settings.changedProperties.Count == 0) return;
			string sql = @"UPDATE media_part_settings";
			sql += "\r\nSET";
			foreach (var p in _media_part_settings.changedProperties)
			{
				string cma = (p == _media_part_settings.changedProperties.Last()) ? "" : ",";
				sql += $"\r\n{p} = @{p}{cma}";
			}
			sql += $"\r\nWHERE id = @id;";
			c.conn.Execute(sql,_media_part_settings);
		}
		public void Dispose()
		{
			this.c.Dispose();
		}
	}
}
