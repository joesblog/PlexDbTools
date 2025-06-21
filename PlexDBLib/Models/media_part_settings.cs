using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
using System.ComponentModel;

#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Models {
	public class media_part_settings {
		public List<string> changedProperties = new List<string>();
		#region fields
			private Int32 _id;// sqllite type = INTEGER
			private Int32 _account_id;// sqllite type = INTEGER
			private Int32 _media_part_id;// sqllite type = INTEGER
			private Int32 _selected_audio_stream_id;// sqllite type = INTEGER
			private Int32 _selected_subtitle_stream_id;// sqllite type = INTEGER
			private String _settings;// sqllite type = varchar(255)
			private Int64 _created_at;// sqllite type = dt_integer(8)
			private Int64 _updated_at;// sqllite type = dt_integer(8)
			private Int64 _changed_at;// sqllite type = integer(8)
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
			
			public Int32 @account_id
			{
				get
				{
					return this._account_id;
				}
				set
				{
					if (_account_id != value)
					{
						_account_id = value;
						this.changedProperties.Add("account_id");
					}
				}
			}
			
			public Int32 @media_part_id
			{
				get
				{
					return this._media_part_id;
				}
				set
				{
					if (_media_part_id != value)
					{
						_media_part_id = value;
						this.changedProperties.Add("media_part_id");
					}
				}
			}
			
			public Int32 @selected_audio_stream_id
			{
				get
				{
					return this._selected_audio_stream_id;
				}
				set
				{
					if (_selected_audio_stream_id != value)
					{
						_selected_audio_stream_id = value;
						this.changedProperties.Add("selected_audio_stream_id");
					}
				}
			}
			
			public Int32 @selected_subtitle_stream_id
			{
				get
				{
					return this._selected_subtitle_stream_id;
				}
				set
				{
					if (_selected_subtitle_stream_id != value)
					{
						_selected_subtitle_stream_id = value;
						this.changedProperties.Add("selected_subtitle_stream_id");
					}
				}
			}
			
			public String @settings
			{
				get
				{
					return this._settings;
				}
				set
				{
					if (_settings != value)
					{
						_settings = value;
						this.changedProperties.Add("settings");
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
			public Int64 @changed_at
			{
				get
				{
					return this._changed_at;
				}
				set
				{
					if (_changed_at != value)
					{
						_changed_at = value;
						this.changedProperties.Add("changed_at");
					}
				}
			}
			
		#endregion
	}
	#pragma warning restore CS8618
	#pragma warning restore CS8981
}
