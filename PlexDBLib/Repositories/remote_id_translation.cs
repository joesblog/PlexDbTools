using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Repositories {
	public class Repo_remote_id_translation : IDisposable {
		public PlexDBLib.Context c {get;set;}
		public Repo_remote_id_translation(PlexDBLib.Context x) 
		{
			this.c = x;
		}
		public IEnumerable<PlexDBLib.Models.remote_id_translation> remote_id_translation_GetAll()
		{
			var r =  c.conn.Query<PlexDBLib.Models.remote_id_translation>("SELECT * from remote_id_translation;");
			foreach (var x in r){x.changedProperties.Clear();}
			return r;
		}
		public PlexDBLib.Models.remote_id_translation? remote_id_translation_GetByid (System.Int32 id )
		{
			var r =  c.conn.Query<PlexDBLib.Models.remote_id_translation>($"SELECT * FROM remote_id_translation WHERE id = {id}").FirstOrDefault();
			r.changedProperties.Clear();
			return r;
		}
		public void remote_id_translation_Update (PlexDBLib.Models.remote_id_translation _remote_id_translation )
		{
			if (_remote_id_translation.changedProperties.Count == 0) return;
			string sql = @"UPDATE remote_id_translation";
			sql += "\r\nSET";
			foreach (var p in _remote_id_translation.changedProperties)
			{
				string cma = (p == _remote_id_translation.changedProperties.Last()) ? "" : ",";
				sql += $"\r\n{p} = @{p}{cma}";
			}
			sql += $"\r\nWHERE id = @id;";
			c.conn.Execute(sql,_remote_id_translation);
		}
		public void Dispose()
		{
			this.c.Dispose();
		}
	}
}
