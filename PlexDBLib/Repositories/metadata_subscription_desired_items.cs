using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Repositories {
	public class Repo_metadata_subscription_desired_items : IDisposable {
		public PlexDBLib.Context c {get;set;}
		public Repo_metadata_subscription_desired_items(PlexDBLib.Context x) 
		{
			this.c = x;
		}
		public IEnumerable<PlexDBLib.Models.metadata_subscription_desired_items> metadata_subscription_desired_items_GetAll()
		{
			var r =  c.conn.Query<PlexDBLib.Models.metadata_subscription_desired_items>("SELECT * from metadata_subscription_desired_items;");
			foreach (var x in r){x.changedProperties.Clear();}
			return r;
		}
		public void Dispose()
		{
			this.c.Dispose();
		}
	}
}
