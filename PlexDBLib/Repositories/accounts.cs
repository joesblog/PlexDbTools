using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Repositories {
	public class Repo_accounts : IDisposable {
		public PlexDBLib.Context c {get;set;}
		public Repo_accounts(PlexDBLib.Context x) 
		{
			this.c = x;
		}
		public IEnumerable<PlexDBLib.Models.accounts> accounts_GetAll()
		{
			var r =  c.conn.Query<PlexDBLib.Models.accounts>("SELECT * from accounts;");
			foreach (var x in r){x.changedProperties.Clear();}
			return r;
		}
		public PlexDBLib.Models.accounts? accounts_GetByid (System.Int32 id )
		{
			var r =  c.conn.Query<PlexDBLib.Models.accounts>($"SELECT * FROM accounts WHERE id = {id}").FirstOrDefault();
			r.changedProperties.Clear();
			return r;
		}
		public void accounts_Update (PlexDBLib.Models.accounts _accounts )
		{
			if (_accounts.changedProperties.Count == 0) return;
			string sql = @"UPDATE accounts";
			sql += "\r\nSET";
			foreach (var p in _accounts.changedProperties)
			{
				string cma = (p == _accounts.changedProperties.Last()) ? "" : ",";
				sql += $"\r\n{p} = @{p}{cma}";
			}
			sql += $"\r\nWHERE id = @id;";
			c.conn.Execute(sql,_accounts);
		}
		public void Dispose()
		{
			this.c.Dispose();
		}
	}
}
