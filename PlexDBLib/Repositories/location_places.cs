using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Repositories {
	public class Repo_location_places : IDisposable {
		public PlexDBLib.Context c {get;set;}
		public Repo_location_places(PlexDBLib.Context x) 
		{
			this.c = x;
		}
		public IEnumerable<PlexDBLib.Models.location_places> location_places_GetAll()
		{
			var r =  c.conn.Query<PlexDBLib.Models.location_places>("SELECT * from location_places;");
			foreach (var x in r){x.changedProperties.Clear();}
			return r;
		}
		public PlexDBLib.Models.location_places? location_places_GetByid (System.Int32 id )
		{
			var r =  c.conn.Query<PlexDBLib.Models.location_places>($"SELECT * FROM location_places WHERE id = {id}").FirstOrDefault();
			r.changedProperties.Clear();
			return r;
		}
		public void location_places_Update (PlexDBLib.Models.location_places _location_places )
		{
			if (_location_places.changedProperties.Count == 0) return;
			string sql = @"UPDATE location_places";
			sql += "\r\nSET";
			foreach (var p in _location_places.changedProperties)
			{
				string cma = (p == _location_places.changedProperties.Last()) ? "" : ",";
				sql += $"\r\n{p} = @{p}{cma}";
			}
			sql += $"\r\nWHERE id = @id;";
			c.conn.Execute(sql,_location_places);
		}
		public void Dispose()
		{
			this.c.Dispose();
		}
	}
}
