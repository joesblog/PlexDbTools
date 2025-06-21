using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Repositories {
	public class Repo_custom_channels : IDisposable {
		public PlexDBLib.Context c {get;set;}
		public Repo_custom_channels(PlexDBLib.Context x) 
		{
			this.c = x;
		}
		public IEnumerable<PlexDBLib.Models.custom_channels> custom_channels_GetAll()
		{
			var r =  c.conn.Query<PlexDBLib.Models.custom_channels>("SELECT * from custom_channels;");
			foreach (var x in r){x.changedProperties.Clear();}
			return r;
		}
		public PlexDBLib.Models.custom_channels? custom_channels_GetByid (System.Int32 id )
		{
			var r =  c.conn.Query<PlexDBLib.Models.custom_channels>($"SELECT * FROM custom_channels WHERE id = {id}").FirstOrDefault();
			r.changedProperties.Clear();
			return r;
		}
		public void custom_channels_Update (PlexDBLib.Models.custom_channels _custom_channels )
		{
			if (_custom_channels.changedProperties.Count == 0) return;
			string sql = @"UPDATE custom_channels";
			sql += "\r\nSET";
			foreach (var p in _custom_channels.changedProperties)
			{
				string cma = (p == _custom_channels.changedProperties.Last()) ? "" : ",";
				sql += $"\r\n{p} = @{p}{cma}";
			}
			sql += $"\r\nWHERE id = @id;";
			c.conn.Execute(sql,_custom_channels);
		}
		public void Dispose()
		{
			this.c.Dispose();
		}
	}
}
