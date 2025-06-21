using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Repositories {
	public class Repo_section_locations : IDisposable {
		public PlexDBLib.Context c {get;set;}
		public Repo_section_locations(PlexDBLib.Context x) 
		{
			this.c = x;
		}
		public IEnumerable<PlexDBLib.Models.section_locations> section_locations_GetAll()
		{
			var r =  c.conn.Query<PlexDBLib.Models.section_locations>("SELECT * from section_locations;");
			foreach (var x in r){x.changedProperties.Clear();}
			return r;
		}
		public PlexDBLib.Models.section_locations? section_locations_GetByid (System.Int32 id )
		{
			var r =  c.conn.Query<PlexDBLib.Models.section_locations>($"SELECT * FROM section_locations WHERE id = {id}").FirstOrDefault();
			r.changedProperties.Clear();
			return r;
		}
		public void section_locations_Update (PlexDBLib.Models.section_locations _section_locations )
		{
			if (_section_locations.changedProperties.Count == 0) return;
			string sql = @"UPDATE section_locations";
			sql += "\r\nSET";
			foreach (var p in _section_locations.changedProperties)
			{
				string cma = (p == _section_locations.changedProperties.Last()) ? "" : ",";
				sql += $"\r\n{p} = @{p}{cma}";
			}
			sql += $"\r\nWHERE id = @id;";
			c.conn.Execute(sql,_section_locations);
		}
		public void Dispose()
		{
			this.c.Dispose();
		}
	}
}
