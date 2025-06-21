using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Repositories {
	public class Repo_metadata_agent_provider_groups : IDisposable {
		public PlexDBLib.Context c {get;set;}
		public Repo_metadata_agent_provider_groups(PlexDBLib.Context x) 
		{
			this.c = x;
		}
		public IEnumerable<PlexDBLib.Models.metadata_agent_provider_groups> metadata_agent_provider_groups_GetAll()
		{
			var r =  c.conn.Query<PlexDBLib.Models.metadata_agent_provider_groups>("SELECT * from metadata_agent_provider_groups;");
			foreach (var x in r){x.changedProperties.Clear();}
			return r;
		}
		public PlexDBLib.Models.metadata_agent_provider_groups? metadata_agent_provider_groups_GetByid (System.Int32 id )
		{
			var r =  c.conn.Query<PlexDBLib.Models.metadata_agent_provider_groups>($"SELECT * FROM metadata_agent_provider_groups WHERE id = {id}").FirstOrDefault();
			r.changedProperties.Clear();
			return r;
		}
		public void metadata_agent_provider_groups_Update (PlexDBLib.Models.metadata_agent_provider_groups _metadata_agent_provider_groups )
		{
			if (_metadata_agent_provider_groups.changedProperties.Count == 0) return;
			string sql = @"UPDATE metadata_agent_provider_groups";
			sql += "\r\nSET";
			foreach (var p in _metadata_agent_provider_groups.changedProperties)
			{
				string cma = (p == _metadata_agent_provider_groups.changedProperties.Last()) ? "" : ",";
				sql += $"\r\n{p} = @{p}{cma}";
			}
			sql += $"\r\nWHERE id = @id;";
			c.conn.Execute(sql,_metadata_agent_provider_groups);
		}
		public void Dispose()
		{
			this.c.Dispose();
		}
	}
}
