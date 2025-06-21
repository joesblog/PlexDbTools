using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Repositories {
	public class Repo_external_metadata_items : IDisposable {
		public PlexDBLib.Context c {get;set;}
		public Repo_external_metadata_items(PlexDBLib.Context x) 
		{
			this.c = x;
		}
		public IEnumerable<PlexDBLib.Models.external_metadata_items> external_metadata_items_GetAll()
		{
			var r =  c.conn.Query<PlexDBLib.Models.external_metadata_items>("SELECT * from external_metadata_items;");
			foreach (var x in r){x.changedProperties.Clear();}
			return r;
		}
		public void Dispose()
		{
			this.c.Dispose();
		}
	}
}
