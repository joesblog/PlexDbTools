using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
using System.ComponentModel;

#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Models {
	public class accounts {
		public List<string> changedProperties = new List<string>();
		#region fields
			private Int32 _id;// sqllite type = INTEGER
			private String _name;// sqllite type = varchar(255)
			private String _hashed_password;// sqllite type = varchar(255)
			private String _salt;// sqllite type = varchar(255)
			private Int64 _created_at;// sqllite type = dt_integer(8)
			private Int64 _updated_at;// sqllite type = dt_integer(8)
			private String _default_audio_language;// sqllite type = varchar(255)
			private String _default_subtitle_language;// sqllite type = varchar(255)
			private Boolean _auto_select_subtitle;// sqllite type = boolean
			private Boolean _auto_select_audio;// sqllite type = boolean
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
			
			public String @hashed_password
			{
				get
				{
					return this._hashed_password;
				}
				set
				{
					if (_hashed_password != value)
					{
						_hashed_password = value;
						this.changedProperties.Add("hashed_password");
					}
				}
			}
			
			public String @salt
			{
				get
				{
					return this._salt;
				}
				set
				{
					if (_salt != value)
					{
						_salt = value;
						this.changedProperties.Add("salt");
					}
				}
			}
			
			public Int64 @created_at
			{
				get
				{
					return this._created_at;
				}
				set
				{
					if (_created_at != value)
					{
						_created_at = value;
						this.changedProperties.Add("created_at");
					}
				}
			}
			
			public DateTime? dte_created_at
			{
				get
				{
					try
					{
						var r = @created_at.ToDateTimeLocal();
						return r;
					}
					catch(Exception ex)
					{
						return null;
					}
				}
			}
			public Int64 @updated_at
			{
				get
				{
					return this._updated_at;
				}
				set
				{
					if (_updated_at != value)
					{
						_updated_at = value;
						this.changedProperties.Add("updated_at");
					}
				}
			}
			
			public DateTime? dte_updated_at
			{
				get
				{
					try
					{
						var r = @updated_at.ToDateTimeLocal();
						return r;
					}
					catch(Exception ex)
					{
						return null;
					}
				}
			}
			public String @default_audio_language
			{
				get
				{
					return this._default_audio_language;
				}
				set
				{
					if (_default_audio_language != value)
					{
						_default_audio_language = value;
						this.changedProperties.Add("default_audio_language");
					}
				}
			}
			
			public String @default_subtitle_language
			{
				get
				{
					return this._default_subtitle_language;
				}
				set
				{
					if (_default_subtitle_language != value)
					{
						_default_subtitle_language = value;
						this.changedProperties.Add("default_subtitle_language");
					}
				}
			}
			
			public Boolean @auto_select_subtitle
			{
				get
				{
					return this._auto_select_subtitle;
				}
				set
				{
					if (_auto_select_subtitle != value)
					{
						_auto_select_subtitle = value;
						this.changedProperties.Add("auto_select_subtitle");
					}
				}
			}
			
			public Boolean @auto_select_audio
			{
				get
				{
					return this._auto_select_audio;
				}
				set
				{
					if (_auto_select_audio != value)
					{
						_auto_select_audio = value;
						this.changedProperties.Add("auto_select_audio");
					}
				}
			}
			
		#endregion
	}
	#pragma warning restore CS8618
	#pragma warning restore CS8981
}
