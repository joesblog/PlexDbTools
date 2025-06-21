using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
using System.ComponentModel;

#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Models {
	public class plugin_prefixes {
		public List<string> changedProperties = new List<string>();
		#region fields
			private Int32 _id;// sqllite type = INTEGER
			private Int32 _plugin_id;// sqllite type = INTEGER
			private String _name;// sqllite type = varchar(255)
			private String _prefix;// sqllite type = varchar(255)
			private String _art_url;// sqllite type = varchar(255)
			private String _thumb_url;// sqllite type = varchar(255)
			private String _titlebar_url;// sqllite type = varchar(255)
			private Boolean _share;// sqllite type = boolean
			private Boolean _has_store_services;// sqllite type = boolean
			private Boolean _prefs;// sqllite type = boolean
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
			
			public Int32 @plugin_id
			{
				get
				{
					return this._plugin_id;
				}
				set
				{
					if (_plugin_id != value)
					{
						_plugin_id = value;
						this.changedProperties.Add("plugin_id");
					}
				}
			}
			
			public String @name
			{
				get
				{
					return this._name;
				}
				set
				{
					if (_name != value)
					{
						_name = value;
						this.changedProperties.Add("name");
					}
				}
			}
			
			public String @prefix
			{
				get
				{
					return this._prefix;
				}
				set
				{
					if (_prefix != value)
					{
						_prefix = value;
						this.changedProperties.Add("prefix");
					}
				}
			}
			
			public String @art_url
			{
				get
				{
					return this._art_url;
				}
				set
				{
					if (_art_url != value)
					{
						_art_url = value;
						this.changedProperties.Add("art_url");
					}
				}
			}
			
			public String @thumb_url
			{
				get
				{
					return this._thumb_url;
				}
				set
				{
					if (_thumb_url != value)
					{
						_thumb_url = value;
						this.changedProperties.Add("thumb_url");
					}
				}
			}
			
			public String @titlebar_url
			{
				get
				{
					return this._titlebar_url;
				}
				set
				{
					if (_titlebar_url != value)
					{
						_titlebar_url = value;
						this.changedProperties.Add("titlebar_url");
					}
				}
			}
			
			public Boolean @share
			{
				get
				{
					return this._share;
				}
				set
				{
					if (_share != value)
					{
						_share = value;
						this.changedProperties.Add("share");
					}
				}
			}
			
			public Boolean @has_store_services
			{
				get
				{
					return this._has_store_services;
				}
				set
				{
					if (_has_store_services != value)
					{
						_has_store_services = value;
						this.changedProperties.Add("has_store_services");
					}
				}
			}
			
			public Boolean @prefs
			{
				get
				{
					return this._prefs;
				}
				set
				{
					if (_prefs != value)
					{
						_prefs = value;
						this.changedProperties.Add("prefs");
					}
				}
			}
			
		#endregion
	}
	#pragma warning restore CS8618
	#pragma warning restore CS8981
}
