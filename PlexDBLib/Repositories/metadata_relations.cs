using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Repositories {
	public class Repo_metadata_relations : IDisposable {
		public PlexDBLib.Context c {get;set;}
		public Repo_metadata_relations(PlexDBLib.Context x) 
		{
			this.c = x;
		}
		public IEnumerable<PlexDBLib.Models.metadata_relations> metadata_relations_GetAll()
		{
			var r =  c.conn.Query<PlexDBLib.Models.metadata_relations>("SELECT * from metadata_relations;");
			foreach (var x in r){x.changedProperties.Clear();}
			return r;
		}
		public PlexDBLib.Models.metadata_relations? metadata_relations_GetByid (System.Int32 id )
		{
			var r =  c.conn.Query<PlexDBLib.Models.metadata_relations>($"SELECT * FROM metadata_relations WHERE id = {id}").FirstOrDefault();
			r.changedProperties.Clear();
			return r;
		}
		public void metadata_relations_Update (PlexDBLib.Models.metadata_relations _metadata_relations )
		{
			if (_metadata_relations.changedProperties.Count == 0) return;
			string sql = @"UPDATE metadata_relations";
			sql += "\r\nSET";
			foreach (var p in _metadata_relations.changedProperties)
			{
				string cma = (p == _metadata_relations.changedProperties.Last()) ? "" : ",";
				sql += $"\r\n{p} = @{p}{cma}";
			}
			sql += $"\r\nWHERE id = @id;";
			c.conn.Execute(sql,_metadata_relations);
		}
		public void Dispose()
		{
			this.c.Dispose();
		}
	}
}
