using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Repositories {
	public class Repo_stream_types : IDisposable {
		public PlexDBLib.Context c {get;set;}
		public Repo_stream_types(PlexDBLib.Context x) 
		{
			this.c = x;
		}
		public IEnumerable<PlexDBLib.Models.stream_types> stream_types_GetAll()
		{
			var r =  c.conn.Query<PlexDBLib.Models.stream_types>("SELECT * from stream_types;");
			foreach (var x in r){x.changedProperties.Clear();}
			return r;
		}
		public PlexDBLib.Models.stream_types? stream_types_GetByid (System.Int32 id )
		{
			var r =  c.conn.Query<PlexDBLib.Models.stream_types>($"SELECT * FROM stream_types WHERE id = {id}").FirstOrDefault();
			r.changedProperties.Clear();
			return r;
		}
		public void stream_types_Update (PlexDBLib.Models.stream_types _stream_types )
		{
			if (_stream_types.changedProperties.Count == 0) return;
			string sql = @"UPDATE stream_types";
			sql += "\r\nSET";
			foreach (var p in _stream_types.changedProperties)
			{
				string cma = (p == _stream_types.changedProperties.Last()) ? "" : ",";
				sql += $"\r\n{p} = @{p}{cma}";
			}
			sql += $"\r\nWHERE id = @id;";
			c.conn.Execute(sql,_stream_types);
		}
		public void Dispose()
		{
			this.c.Dispose();
		}
	}
}
