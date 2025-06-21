using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Repositories {
	public class Repo_external_metadata_sources : IDisposable {
		public PlexDBLib.Context c {get;set;}
		public Repo_external_metadata_sources(PlexDBLib.Context x) 
		{
			this.c = x;
		}
		public IEnumerable<PlexDBLib.Models.external_metadata_sources> external_metadata_sources_GetAll()
		{
			var r =  c.conn.Query<PlexDBLib.Models.external_metadata_sources>("SELECT * from external_metadata_sources;");
			foreach (var x in r){x.changedProperties.Clear();}
			return r;
		}
		public PlexDBLib.Models.external_metadata_sources? external_metadata_sources_GetByid (System.Int32 id )
		{
			var r =  c.conn.Query<PlexDBLib.Models.external_metadata_sources>($"SELECT * FROM external_metadata_sources WHERE id = {id}").FirstOrDefault();
			r.changedProperties.Clear();
			return r;
		}
		public void external_metadata_sources_Update (PlexDBLib.Models.external_metadata_sources _external_metadata_sources )
		{
			if (_external_metadata_sources.changedProperties.Count == 0) return;
			string sql = @"UPDATE external_metadata_sources";
			sql += "\r\nSET";
			foreach (var p in _external_metadata_sources.changedProperties)
			{
				string cma = (p == _external_metadata_sources.changedProperties.Last()) ? "" : ",";
				sql += $"\r\n{p} = @{p}{cma}";
			}
			sql += $"\r\nWHERE id = @id;";
			c.conn.Execute(sql,_external_metadata_sources);
		}
		public void Dispose()
		{
			this.c.Dispose();
		}
	}
}
