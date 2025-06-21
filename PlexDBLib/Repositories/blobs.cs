using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Repositories {
	public class Repo_blobs : IDisposable {
		public PlexDBLib.Context c {get;set;}
		public Repo_blobs(PlexDBLib.Context x) 
		{
			this.c = x;
		}
		public IEnumerable<PlexDBLib.Models.blobs> blobs_GetAll()
		{
			var r =  c.conn.Query<PlexDBLib.Models.blobs>("SELECT * from blobs;");
			foreach (var x in r){x.changedProperties.Clear();}
			return r;
		}
		public PlexDBLib.Models.blobs? blobs_GetByid (System.Int32 id )
		{
			var r =  c.conn.Query<PlexDBLib.Models.blobs>($"SELECT * FROM blobs WHERE id = {id}").FirstOrDefault();
			r.changedProperties.Clear();
			return r;
		}
		public void blobs_Update (PlexDBLib.Models.blobs _blobs )
		{
			if (_blobs.changedProperties.Count == 0) return;
			string sql = @"UPDATE blobs";
			sql += "\r\nSET";
			foreach (var p in _blobs.changedProperties)
			{
				string cma = (p == _blobs.changedProperties.Last()) ? "" : ",";
				sql += $"\r\n{p} = @{p}{cma}";
			}
			sql += $"\r\nWHERE id = @id;";
			c.conn.Execute(sql,_blobs);
		}
		public void Dispose()
		{
			this.c.Dispose();
		}
	}
}
