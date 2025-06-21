using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Repositories {
	public class Repo_metadata_item_accounts : IDisposable {
		public PlexDBLib.Context c {get;set;}
		public Repo_metadata_item_accounts(PlexDBLib.Context x) 
		{
			this.c = x;
		}
		public IEnumerable<PlexDBLib.Models.metadata_item_accounts> metadata_item_accounts_GetAll()
		{
			var r =  c.conn.Query<PlexDBLib.Models.metadata_item_accounts>("SELECT * from metadata_item_accounts;");
			foreach (var x in r){x.changedProperties.Clear();}
			return r;
		}
		public PlexDBLib.Models.metadata_item_accounts? metadata_item_accounts_GetByid (System.Int32 id )
		{
			var r =  c.conn.Query<PlexDBLib.Models.metadata_item_accounts>($"SELECT * FROM metadata_item_accounts WHERE id = {id}").FirstOrDefault();
			r.changedProperties.Clear();
			return r;
		}
		public void metadata_item_accounts_Update (PlexDBLib.Models.metadata_item_accounts _metadata_item_accounts )
		{
			if (_metadata_item_accounts.changedProperties.Count == 0) return;
			string sql = @"UPDATE metadata_item_accounts";
			sql += "\r\nSET";
			foreach (var p in _metadata_item_accounts.changedProperties)
			{
				string cma = (p == _metadata_item_accounts.changedProperties.Last()) ? "" : ",";
				sql += $"\r\n{p} = @{p}{cma}";
			}
			sql += $"\r\nWHERE id = @id;";
			c.conn.Execute(sql,_metadata_item_accounts);
		}
		public void Dispose()
		{
			this.c.Dispose();
		}
	}
}
