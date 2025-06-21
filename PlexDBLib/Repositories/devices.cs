using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Repositories {
	public class Repo_devices : IDisposable {
		public PlexDBLib.Context c {get;set;}
		public Repo_devices(PlexDBLib.Context x) 
		{
			this.c = x;
		}
		public IEnumerable<PlexDBLib.Models.devices> devices_GetAll()
		{
			var r =  c.conn.Query<PlexDBLib.Models.devices>("SELECT * from devices;");
			foreach (var x in r){x.changedProperties.Clear();}
			return r;
		}
		public PlexDBLib.Models.devices? devices_GetByid (System.Int32 id )
		{
			var r =  c.conn.Query<PlexDBLib.Models.devices>($"SELECT * FROM devices WHERE id = {id}").FirstOrDefault();
			r.changedProperties.Clear();
			return r;
		}
		public void devices_Update (PlexDBLib.Models.devices _devices )
		{
			if (_devices.changedProperties.Count == 0) return;
			string sql = @"UPDATE devices";
			sql += "\r\nSET";
			foreach (var p in _devices.changedProperties)
			{
				string cma = (p == _devices.changedProperties.Last()) ? "" : ",";
				sql += $"\r\n{p} = @{p}{cma}";
			}
			sql += $"\r\nWHERE id = @id;";
			c.conn.Execute(sql,_devices);
		}
		public void Dispose()
		{
			this.c.Dispose();
		}
	}
}
