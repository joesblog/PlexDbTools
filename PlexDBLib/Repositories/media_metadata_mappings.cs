using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Repositories {
	public class Repo_media_metadata_mappings : IDisposable {
		public PlexDBLib.Context c {get;set;}
		public Repo_media_metadata_mappings(PlexDBLib.Context x) 
		{
			this.c = x;
		}
		public IEnumerable<PlexDBLib.Models.media_metadata_mappings> media_metadata_mappings_GetAll()
		{
			var r =  c.conn.Query<PlexDBLib.Models.media_metadata_mappings>("SELECT * from media_metadata_mappings;");
			foreach (var x in r){x.changedProperties.Clear();}
			return r;
		}
		public PlexDBLib.Models.media_metadata_mappings? media_metadata_mappings_GetByid (System.Int32 id )
		{
			var r =  c.conn.Query<PlexDBLib.Models.media_metadata_mappings>($"SELECT * FROM media_metadata_mappings WHERE id = {id}").FirstOrDefault();
			r.changedProperties.Clear();
			return r;
		}
		public void media_metadata_mappings_Update (PlexDBLib.Models.media_metadata_mappings _media_metadata_mappings )
		{
			if (_media_metadata_mappings.changedProperties.Count == 0) return;
			string sql = @"UPDATE media_metadata_mappings";
			sql += "\r\nSET";
			foreach (var p in _media_metadata_mappings.changedProperties)
			{
				string cma = (p == _media_metadata_mappings.changedProperties.Last()) ? "" : ",";
				sql += $"\r\n{p} = @{p}{cma}";
			}
			sql += $"\r\nWHERE id = @id;";
			c.conn.Execute(sql,_media_metadata_mappings);
		}
		public void Dispose()
		{
			this.c.Dispose();
		}
	}
}
