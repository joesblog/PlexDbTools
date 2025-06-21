using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Repositories {
	public class Repo_library_sections : IDisposable {
		public PlexDBLib.Context c {get;set;}
		public Repo_library_sections(PlexDBLib.Context x) 
		{
			this.c = x;
		}
		public IEnumerable<PlexDBLib.Models.library_sections> library_sections_GetAll()
		{
			var r =  c.conn.Query<PlexDBLib.Models.library_sections>("SELECT * from library_sections;");
			foreach (var x in r){x.changedProperties.Clear();}
			return r;
		}
		public PlexDBLib.Models.library_sections? library_sections_GetByid (System.Int32 id )
		{
			var r =  c.conn.Query<PlexDBLib.Models.library_sections>($"SELECT * FROM library_sections WHERE id = {id}").FirstOrDefault();
			r.changedProperties.Clear();
			return r;
		}
		public void library_sections_Update (PlexDBLib.Models.library_sections _library_sections )
		{
			if (_library_sections.changedProperties.Count == 0) return;
			string sql = @"UPDATE library_sections";
			sql += "\r\nSET";
			foreach (var p in _library_sections.changedProperties)
			{
				string cma = (p == _library_sections.changedProperties.Last()) ? "" : ",";
				sql += $"\r\n{p} = @{p}{cma}";
			}
			sql += $"\r\nWHERE id = @id;";
			c.conn.Execute(sql,_library_sections);
		}
		public void Dispose()
		{
			this.c.Dispose();
		}
	}
}
