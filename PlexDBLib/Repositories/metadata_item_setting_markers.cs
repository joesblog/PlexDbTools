using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Repositories {
	public class Repo_metadata_item_setting_markers : IDisposable {
		public PlexDBLib.Context c {get;set;}
		public Repo_metadata_item_setting_markers(PlexDBLib.Context x) 
		{
			this.c = x;
		}
		public IEnumerable<PlexDBLib.Models.metadata_item_setting_markers> metadata_item_setting_markers_GetAll()
		{
			var r =  c.conn.Query<PlexDBLib.Models.metadata_item_setting_markers>("SELECT * from metadata_item_setting_markers;");
			foreach (var x in r){x.changedProperties.Clear();}
			return r;
		}
		public PlexDBLib.Models.metadata_item_setting_markers? metadata_item_setting_markers_GetByid (System.Int32 id )
		{
			var r =  c.conn.Query<PlexDBLib.Models.metadata_item_setting_markers>($"SELECT * FROM metadata_item_setting_markers WHERE id = {id}").FirstOrDefault();
			r.changedProperties.Clear();
			return r;
		}
		public void metadata_item_setting_markers_Update (PlexDBLib.Models.metadata_item_setting_markers _metadata_item_setting_markers )
		{
			if (_metadata_item_setting_markers.changedProperties.Count == 0) return;
			string sql = @"UPDATE metadata_item_setting_markers";
			sql += "\r\nSET";
			foreach (var p in _metadata_item_setting_markers.changedProperties)
			{
				string cma = (p == _metadata_item_setting_markers.changedProperties.Last()) ? "" : ",";
				sql += $"\r\n{p} = @{p}{cma}";
			}
			sql += $"\r\nWHERE id = @id;";
			c.conn.Execute(sql,_metadata_item_setting_markers);
		}
		public void Dispose()
		{
			this.c.Dispose();
		}
	}
}
