using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Repositories {
	public class Repo_download_queues : IDisposable {
		public PlexDBLib.Context c {get;set;}
		public Repo_download_queues(PlexDBLib.Context x) 
		{
			this.c = x;
		}
		public IEnumerable<PlexDBLib.Models.download_queues> download_queues_GetAll()
		{
			var r =  c.conn.Query<PlexDBLib.Models.download_queues>("SELECT * from download_queues;");
			foreach (var x in r){x.changedProperties.Clear();}
			return r;
		}
		public PlexDBLib.Models.download_queues? download_queues_GetByid (System.Int32 id )
		{
			var r =  c.conn.Query<PlexDBLib.Models.download_queues>($"SELECT * FROM download_queues WHERE id = {id}").FirstOrDefault();
			r.changedProperties.Clear();
			return r;
		}
		public void download_queues_Update (PlexDBLib.Models.download_queues _download_queues )
		{
			if (_download_queues.changedProperties.Count == 0) return;
			string sql = @"UPDATE download_queues";
			sql += "\r\nSET";
			foreach (var p in _download_queues.changedProperties)
			{
				string cma = (p == _download_queues.changedProperties.Last()) ? "" : ",";
				sql += $"\r\n{p} = @{p}{cma}";
			}
			sql += $"\r\nWHERE id = @id;";
			c.conn.Execute(sql,_download_queues);
		}
		public void Dispose()
		{
			this.c.Dispose();
		}
	}
}
