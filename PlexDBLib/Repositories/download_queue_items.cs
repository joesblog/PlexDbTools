using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Repositories {
	public class Repo_download_queue_items : IDisposable {
		public PlexDBLib.Context c {get;set;}
		public Repo_download_queue_items(PlexDBLib.Context x) 
		{
			this.c = x;
		}
		public IEnumerable<PlexDBLib.Models.download_queue_items> download_queue_items_GetAll()
		{
			var r =  c.conn.Query<PlexDBLib.Models.download_queue_items>("SELECT * from download_queue_items;");
			foreach (var x in r){x.changedProperties.Clear();}
			return r;
		}
		public PlexDBLib.Models.download_queue_items? download_queue_items_GetByid (System.Int32 id )
		{
			var r =  c.conn.Query<PlexDBLib.Models.download_queue_items>($"SELECT * FROM download_queue_items WHERE id = {id}").FirstOrDefault();
			r.changedProperties.Clear();
			return r;
		}
		public void download_queue_items_Update (PlexDBLib.Models.download_queue_items _download_queue_items )
		{
			if (_download_queue_items.changedProperties.Count == 0) return;
			string sql = @"UPDATE download_queue_items";
			sql += "\r\nSET";
			foreach (var p in _download_queue_items.changedProperties)
			{
				string cma = (p == _download_queue_items.changedProperties.Last()) ? "" : ",";
				sql += $"\r\n{p} = @{p}{cma}";
			}
			sql += $"\r\nWHERE id = @id;";
			c.conn.Execute(sql,_download_queue_items);
		}
		public void Dispose()
		{
			this.c.Dispose();
		}
	}
}
