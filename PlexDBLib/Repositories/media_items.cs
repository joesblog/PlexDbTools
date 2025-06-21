using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Repositories {
	public class Repo_media_items : IDisposable {
		public PlexDBLib.Context c {get;set;}
		public Repo_media_items(PlexDBLib.Context x) 
		{
			this.c = x;
		}
		public IEnumerable<PlexDBLib.Models.media_items> media_items_GetAll()
		{
			var r =  c.conn.Query<PlexDBLib.Models.media_items>("SELECT * from media_items;");
			foreach (var x in r){x.changedProperties.Clear();}
			return r;
		}
		public PlexDBLib.Models.media_items? media_items_GetByid (System.Int32 id )
		{
			var r =  c.conn.Query<PlexDBLib.Models.media_items>($"SELECT * FROM media_items WHERE id = {id}").FirstOrDefault();
			r.changedProperties.Clear();
			return r;
		}
		public void media_items_Update (PlexDBLib.Models.media_items _media_items )
		{
			if (_media_items.changedProperties.Count == 0) return;
			string sql = @"UPDATE media_items";
			sql += "\r\nSET";
			foreach (var p in _media_items.changedProperties)
			{
				string cma = (p == _media_items.changedProperties.Last()) ? "" : ",";
				sql += $"\r\n{p} = @{p}{cma}";
			}
			sql += $"\r\nWHERE id = @id;";
			c.conn.Execute(sql,_media_items);
		}
		public void Dispose()
		{
			this.c.Dispose();
		}
	}
}
