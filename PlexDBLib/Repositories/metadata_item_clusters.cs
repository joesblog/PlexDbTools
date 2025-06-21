using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Repositories {
	public class Repo_metadata_item_clusters : IDisposable {
		public PlexDBLib.Context c {get;set;}
		public Repo_metadata_item_clusters(PlexDBLib.Context x) 
		{
			this.c = x;
		}
		public IEnumerable<PlexDBLib.Models.metadata_item_clusters> metadata_item_clusters_GetAll()
		{
			var r =  c.conn.Query<PlexDBLib.Models.metadata_item_clusters>("SELECT * from metadata_item_clusters;");
			foreach (var x in r){x.changedProperties.Clear();}
			return r;
		}
		public PlexDBLib.Models.metadata_item_clusters? metadata_item_clusters_GetByid (System.Int32 id )
		{
			var r =  c.conn.Query<PlexDBLib.Models.metadata_item_clusters>($"SELECT * FROM metadata_item_clusters WHERE id = {id}").FirstOrDefault();
			r.changedProperties.Clear();
			return r;
		}
		public void metadata_item_clusters_Update (PlexDBLib.Models.metadata_item_clusters _metadata_item_clusters )
		{
			if (_metadata_item_clusters.changedProperties.Count == 0) return;
			string sql = @"UPDATE metadata_item_clusters";
			sql += "\r\nSET";
			foreach (var p in _metadata_item_clusters.changedProperties)
			{
				string cma = (p == _metadata_item_clusters.changedProperties.Last()) ? "" : ",";
				sql += $"\r\n{p} = @{p}{cma}";
			}
			sql += $"\r\nWHERE id = @id;";
			c.conn.Execute(sql,_metadata_item_clusters);
		}
		public void Dispose()
		{
			this.c.Dispose();
		}
	}
}
