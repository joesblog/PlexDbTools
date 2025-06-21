using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Repositories {
	public class Repo_tags : IDisposable {
		public PlexDBLib.Context c {get;set;}
		public Repo_tags(PlexDBLib.Context x) 
		{
			this.c = x;
		}
		public IEnumerable<PlexDBLib.Models.tags> tags_GetAll()
		{
			var r =  c.conn.Query<PlexDBLib.Models.tags>("SELECT * from tags;");
			foreach (var x in r){x.changedProperties.Clear();}
			return r;
		}
		public PlexDBLib.Models.tags? tags_GetByid (System.Int32 id )
		{
			var r =  c.conn.Query<PlexDBLib.Models.tags>($"SELECT * FROM tags WHERE id = {id}").FirstOrDefault();
			r.changedProperties.Clear();
			return r;
		}
		public void tags_Update (PlexDBLib.Models.tags _tags )
		{
			if (_tags.changedProperties.Count == 0) return;
			string sql = @"UPDATE tags";
			sql += "\r\nSET";
			foreach (var p in _tags.changedProperties)
			{
				string cma = (p == _tags.changedProperties.Last()) ? "" : ",";
				sql += $"\r\n{p} = @{p}{cma}";
			}
			sql += $"\r\nWHERE id = @id;";
			c.conn.Execute(sql,_tags);
		}
		public void Dispose()
		{
			this.c.Dispose();
		}
	}
}
