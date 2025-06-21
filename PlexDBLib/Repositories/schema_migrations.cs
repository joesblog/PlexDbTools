using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Repositories {
	public class Repo_schema_migrations : IDisposable {
		public PlexDBLib.Context c {get;set;}
		public Repo_schema_migrations(PlexDBLib.Context x) 
		{
			this.c = x;
		}
		public IEnumerable<PlexDBLib.Models.schema_migrations> schema_migrations_GetAll()
		{
			var r =  c.conn.Query<PlexDBLib.Models.schema_migrations>("SELECT * from schema_migrations;");
			foreach (var x in r){x.changedProperties.Clear();}
			return r;
		}
		public void Dispose()
		{
			this.c.Dispose();
		}
	}
}
