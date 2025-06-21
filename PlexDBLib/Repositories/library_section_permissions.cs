using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Repositories {
	public class Repo_library_section_permissions : IDisposable {
		public PlexDBLib.Context c {get;set;}
		public Repo_library_section_permissions(PlexDBLib.Context x) 
		{
			this.c = x;
		}
		public IEnumerable<PlexDBLib.Models.library_section_permissions> library_section_permissions_GetAll()
		{
			var r =  c.conn.Query<PlexDBLib.Models.library_section_permissions>("SELECT * from library_section_permissions;");
			foreach (var x in r){x.changedProperties.Clear();}
			return r;
		}
		public PlexDBLib.Models.library_section_permissions? library_section_permissions_GetByid (System.Int32 id )
		{
			var r =  c.conn.Query<PlexDBLib.Models.library_section_permissions>($"SELECT * FROM library_section_permissions WHERE id = {id}").FirstOrDefault();
			r.changedProperties.Clear();
			return r;
		}
		public void library_section_permissions_Update (PlexDBLib.Models.library_section_permissions _library_section_permissions )
		{
			if (_library_section_permissions.changedProperties.Count == 0) return;
			string sql = @"UPDATE library_section_permissions";
			sql += "\r\nSET";
			foreach (var p in _library_section_permissions.changedProperties)
			{
				string cma = (p == _library_section_permissions.changedProperties.Last()) ? "" : ",";
				sql += $"\r\n{p} = @{p}{cma}";
			}
			sql += $"\r\nWHERE id = @id;";
			c.conn.Execute(sql,_library_section_permissions);
		}
		public void Dispose()
		{
			this.c.Dispose();
		}
	}
}
