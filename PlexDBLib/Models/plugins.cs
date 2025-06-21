using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
using System.ComponentModel;

#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Models {
	public class plugins {
		public List<string> changedProperties = new List<string>();
		#region fields
			private Int32 _id;// sqllite type = INTEGER
			private String _identifier;// sqllite type = varchar(255)
			private Int32 _framework_version;// sqllite type = INTEGER
			private Int32 _access_count;// sqllite type = INTEGER
			private Int64 _installed_at;// sqllite type = dt_integer(8)
			private Int64 _accessed_at;// sqllite type = dt_integer(8)
			private Int64 _modified_at;// sqllite type = dt_integer(8)
		#endregion
		#region props
			public Int32 @id
			{
				get
				{
					return this._id;
				}
				set
				{
					if (_id != value)
					{
						_id = value;
						this.changedProperties.Add("id");
					}
				}
			}
			
			public String @identifier
			{
				get
				{
					return this._identifier;
				}
				set
				{
					if (_identifier != value)
					{
						_identifier = value;
						this.changedProperties.Add("identifier");
					}
				}
			}
			
			public Int32 @framework_version
			{
				get
				{
					return this._framework_version;
				}
				set
				{
					if (_framework_version != value)
					{
						_framework_version = value;
						this.changedProperties.Add("framework_version");
					}
				}
			}
			
			public Int32 @access_count
			{
				get
				{
					return this._access_count;
				}
				set
				{
					if (_access_count != value)
					{
						_access_count = value;
						this.changedProperties.Add("access_count");
					}
				}
			}
			
			public Int64 @installed_at
			{
				get
				{
					return this._installed_at;
				}
				set
				{
					if (_installed_at != value)
					{
						_installed_at = value;
						this.changedProperties.Add("installed_at");
					}
				}
			}
			
			public DateTime? dte_installed_at
			{
				get
				{
					try
					{
						var r = @installed_at.ToDateTimeLocal();
						return r;
					}
					catch(Exception ex)
					{
						return null;
					}
				}
			}
			public Int64 @accessed_at
			{
				get
				{
					return this._accessed_at;
				}
				set
				{
					if (_accessed_at != value)
					{
						_accessed_at = value;
						this.changedProperties.Add("accessed_at");
					}
				}
			}
			
			public DateTime? dte_accessed_at
			{
				get
				{
					try
					{
						var r = @accessed_at.ToDateTimeLocal();
						return r;
					}
					catch(Exception ex)
					{
						return null;
					}
				}
			}
			public Int64 @modified_at
			{
				get
				{
					return this._modified_at;
				}
				set
				{
					if (_modified_at != value)
					{
						_modified_at = value;
						this.changedProperties.Add("modified_at");
					}
				}
			}
			
			public DateTime? dte_modified_at
			{
				get
				{
					try
					{
						var r = @modified_at.ToDateTimeLocal();
						return r;
					}
					catch(Exception ex)
					{
						return null;
					}
				}
			}
		#endregion
	}
	#pragma warning restore CS8618
	#pragma warning restore CS8981
}
