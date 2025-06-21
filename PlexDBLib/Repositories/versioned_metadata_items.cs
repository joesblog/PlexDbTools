using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Repositories {
	public class Repo_versioned_metadata_items : IDisposable {
		public PlexDBLib.Context c {get;set;}
		public Repo_versioned_metadata_items(PlexDBLib.Context x) 
		{
			this.c = x;
		}
		public IEnumerable<PlexDBLib.Models.versioned_metadata_items> versioned_metadata_items_GetAll()
		{
			var r =  c.conn.Query<PlexDBLib.Models.versioned_metadata_items>("SELECT * from versioned_metadata_items;");
			foreach (var x in r){x.changedProperties.Clear();}
			return r;
		}
		public PlexDBLib.Models.versioned_metadata_items? versioned_metadata_items_GetByid (System.Int32 id )
		{
			var r =  c.conn.Query<PlexDBLib.Models.versioned_metadata_items>($"SELECT * FROM versioned_metadata_items WHERE id = {id}").FirstOrDefault();
			r.changedProperties.Clear();
			return r;
		}
		public void versioned_metadata_items_Update (PlexDBLib.Models.versioned_metadata_items _versioned_metadata_items )
		{
			if (_versioned_metadata_items.changedProperties.Count == 0) return;
			string sql = @"UPDATE versioned_metadata_items";
			sql += "\r\nSET";
			foreach (var p in _versioned_metadata_items.changedProperties)
			{
				string cma = (p == _versioned_metadata_items.changedProperties.Last()) ? "" : ",";
				sql += $"\r\n{p} = @{p}{cma}";
			}
			sql += $"\r\nWHERE id = @id;";
			c.conn.Execute(sql,_versioned_metadata_items);
		}
		public void Dispose()
		{
			this.c.Dispose();
		}
	}
}
