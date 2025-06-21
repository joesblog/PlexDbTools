using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Repositories {
	public class Repo_metadata_item_views : IDisposable {
		public PlexDBLib.Context c {get;set;}
		public Repo_metadata_item_views(PlexDBLib.Context x) 
		{
			this.c = x;
		}
		public IEnumerable<PlexDBLib.Models.metadata_item_views> metadata_item_views_GetAll()
		{
			var r =  c.conn.Query<PlexDBLib.Models.metadata_item_views>("SELECT * from metadata_item_views;");
			foreach (var x in r){x.changedProperties.Clear();}
			return r;
		}
		public PlexDBLib.Models.metadata_item_views? metadata_item_views_GetByid (System.Int32 id )
		{
			var r =  c.conn.Query<PlexDBLib.Models.metadata_item_views>($"SELECT * FROM metadata_item_views WHERE id = {id}").FirstOrDefault();
			r.changedProperties.Clear();
			return r;
		}
		public void metadata_item_views_Update (PlexDBLib.Models.metadata_item_views _metadata_item_views )
		{
			if (_metadata_item_views.changedProperties.Count == 0) return;
			string sql = @"UPDATE metadata_item_views";
			sql += "\r\nSET";
			foreach (var p in _metadata_item_views.changedProperties)
			{
				string cma = (p == _metadata_item_views.changedProperties.Last()) ? "" : ",";
				sql += $"\r\n{p} = @{p}{cma}";
			}
			sql += $"\r\nWHERE id = @id;";
			c.conn.Execute(sql,_metadata_item_views);
		}
		public void Dispose()
		{
			this.c.Dispose();
		}
	}
}
