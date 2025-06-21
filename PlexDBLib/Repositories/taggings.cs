using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Repositories {
	public class Repo_taggings : IDisposable {
		public PlexDBLib.Context c {get;set;}
		public Repo_taggings(PlexDBLib.Context x) 
		{
			this.c = x;
		}
		public IEnumerable<PlexDBLib.Models.taggings> taggings_GetAll()
		{
			var r =  c.conn.Query<PlexDBLib.Models.taggings>("SELECT * from taggings;");
			foreach (var x in r){x.changedProperties.Clear();}
			return r;
		}
		public PlexDBLib.Models.taggings? taggings_GetByid (System.Int32 id )
		{
			var r =  c.conn.Query<PlexDBLib.Models.taggings>($"SELECT * FROM taggings WHERE id = {id}").FirstOrDefault();
			r.changedProperties.Clear();
			return r;
		}
		public void taggings_Update (PlexDBLib.Models.taggings _taggings )
		{
			if (_taggings.changedProperties.Count == 0) return;
			string sql = @"UPDATE taggings";
			sql += "\r\nSET";
			foreach (var p in _taggings.changedProperties)
			{
				string cma = (p == _taggings.changedProperties.Last()) ? "" : ",";
				sql += $"\r\n{p} = @{p}{cma}";
			}
			sql += $"\r\nWHERE id = @id;";
			c.conn.Execute(sql,_taggings);
		}
		public void Dispose()
		{
			this.c.Dispose();
		}
	}
}
