using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Repositories {
	public class Repo_metadata_agent_providers : IDisposable {
		public PlexDBLib.Context c {get;set;}
		public Repo_metadata_agent_providers(PlexDBLib.Context x) 
		{
			this.c = x;
		}
		public IEnumerable<PlexDBLib.Models.metadata_agent_providers> metadata_agent_providers_GetAll()
		{
			var r =  c.conn.Query<PlexDBLib.Models.metadata_agent_providers>("SELECT * from metadata_agent_providers;");
			foreach (var x in r){x.changedProperties.Clear();}
			return r;
		}
		public PlexDBLib.Models.metadata_agent_providers? metadata_agent_providers_GetByid (System.Int32 id )
		{
			var r =  c.conn.Query<PlexDBLib.Models.metadata_agent_providers>($"SELECT * FROM metadata_agent_providers WHERE id = {id}").FirstOrDefault();
			r.changedProperties.Clear();
			return r;
		}
		public void metadata_agent_providers_Update (PlexDBLib.Models.metadata_agent_providers _metadata_agent_providers )
		{
			if (_metadata_agent_providers.changedProperties.Count == 0) return;
			string sql = @"UPDATE metadata_agent_providers";
			sql += "\r\nSET";
			foreach (var p in _metadata_agent_providers.changedProperties)
			{
				string cma = (p == _metadata_agent_providers.changedProperties.Last()) ? "" : ",";
				sql += $"\r\n{p} = @{p}{cma}";
			}
			sql += $"\r\nWHERE id = @id;";
			c.conn.Execute(sql,_metadata_agent_providers);
		}
		public void Dispose()
		{
			this.c.Dispose();
		}
	}
}
