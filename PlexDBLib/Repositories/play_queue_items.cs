using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Repositories {
	public class Repo_play_queue_items : IDisposable {
		public PlexDBLib.Context c {get;set;}
		public Repo_play_queue_items(PlexDBLib.Context x) 
		{
			this.c = x;
		}
		public IEnumerable<PlexDBLib.Models.play_queue_items> play_queue_items_GetAll()
		{
			var r =  c.conn.Query<PlexDBLib.Models.play_queue_items>("SELECT * from play_queue_items;");
			foreach (var x in r){x.changedProperties.Clear();}
			return r;
		}
		public PlexDBLib.Models.play_queue_items? play_queue_items_GetByid (System.Int32 id )
		{
			var r =  c.conn.Query<PlexDBLib.Models.play_queue_items>($"SELECT * FROM play_queue_items WHERE id = {id}").FirstOrDefault();
			r.changedProperties.Clear();
			return r;
		}
		public void play_queue_items_Update (PlexDBLib.Models.play_queue_items _play_queue_items )
		{
			if (_play_queue_items.changedProperties.Count == 0) return;
			string sql = @"UPDATE play_queue_items";
			sql += "\r\nSET";
			foreach (var p in _play_queue_items.changedProperties)
			{
				string cma = (p == _play_queue_items.changedProperties.Last()) ? "" : ",";
				sql += $"\r\n{p} = @{p}{cma}";
			}
			sql += $"\r\nWHERE id = @id;";
			c.conn.Execute(sql,_play_queue_items);
		}
		public void Dispose()
		{
			this.c.Dispose();
		}
	}
}
