using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
using System.ComponentModel;

#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Models {
	public class schema_migrations {
		public List<string> changedProperties = new List<string>();
		#region fields
			private String _version;// sqllite type = varchar(255)
			private String _rollback_sql;// sqllite type = TEXT
			private Boolean _optimize_on_rollback;// sqllite type = boolean
			private String _min_version;// sqllite type = TEXT
		#endregion
		#region props
			public String @version
			{
				get
				{
					return this._version;
				}
				set
				{
					if (_version != value)
					{
						_version = value;
						this.changedProperties.Add("version");
					}
				}
			}
			
			public String @rollback_sql
			{
				get
				{
					return this._rollback_sql;
				}
				set
				{
					if (_rollback_sql != value)
					{
						_rollback_sql = value;
						this.changedProperties.Add("rollback_sql");
					}
				}
			}
			
			public Boolean @optimize_on_rollback
			{
				get
				{
					return this._optimize_on_rollback;
				}
				set
				{
					if (_optimize_on_rollback != value)
					{
						_optimize_on_rollback = value;
						this.changedProperties.Add("optimize_on_rollback");
					}
				}
			}
			
			public String @min_version
			{
				get
				{
					return this._min_version;
				}
				set
				{
					if (_min_version != value)
					{
						_min_version = value;
						this.changedProperties.Add("min_version");
					}
				}
			}
			
		#endregion
	}
	#pragma warning restore CS8618
	#pragma warning restore CS8981
}
