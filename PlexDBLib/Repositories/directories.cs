using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Repositories {
	public class Repo_directories : IDisposable {
		public PlexDBLib.Context c {get;set;}
		public Repo_directories(PlexDBLib.Context x) 
		{
			this.c = x;
		}
		public IEnumerable<PlexDBLib.Models.directories> directories_GetAll()
		{
			var r =  c.conn.Query<PlexDBLib.Models.directories>("SELECT * from directories;");
			foreach (var x in r){x.changedProperties.Clear();}
			return r;
		}
		public PlexDBLib.Models.directories? directories_GetByid (System.Int32 id )
		{
			var r =  c.conn.Query<PlexDBLib.Models.directories>($"SELECT * FROM directories WHERE id = {id}").FirstOrDefault();
			r.changedProperties.Clear();
			return r;
		}
		public void directories_Update (PlexDBLib.Models.directories _directories )
		{
			if (_directories.changedProperties.Count == 0) return;
			string sql = @"UPDATE directories";
			sql += "\r\nSET";
			foreach (var p in _directories.changedProperties)
			{
				string cma = (p == _directories.changedProperties.Last()) ? "" : ",";
				sql += $"\r\n{p} = @{p}{cma}";
			}
			sql += $"\r\nWHERE id = @id;";
			c.conn.Execute(sql,_directories);
		}
		public void Dispose()
		{
			this.c.Dispose();
		}
	}
}
