using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
using System.ComponentModel;

#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Models {
	public class custom_channels {
		public List<string> changedProperties = new List<string>();
		#region fields
			private Int32 _id;// sqllite type = INTEGER
			private String _name;// sqllite type = varchar(255)
			private String _description;// sqllite type = varchar(255)
			private Int32 _playlist_id;// sqllite type = INTEGER
			private Int64 _start_time;// sqllite type = dt_integer(8)
			private Int32 _ordering;// sqllite type = INTEGER
			private Int32 _visibility;// sqllite type = INTEGER
			private Int32 _displayed_on;// sqllite type = INTEGER
			private String _content_rating;// sqllite type = varchar(255)
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
			
			public String @description
			{
				get
				{
					return this._description;
				}
				set
				{
					if (_description != value)
					{
						_description = value;
						this.changedProperties.Add("description");
					}
				}
			}
			
			public Int32 @playlist_id
			{
				get
				{
					return this._playlist_id;
				}
				set
				{
					if (_playlist_id != value)
					{
						_playlist_id = value;
						this.changedProperties.Add("playlist_id");
					}
				}
			}
			
			public Int64 @start_time
			{
				get
				{
					return this._start_time;
				}
				set
				{
					if (_start_time != value)
					{
						_start_time = value;
						this.changedProperties.Add("start_time");
					}
				}
			}
			
			public DateTime? dte_start_time
			{
				get
				{
					try
					{
						var r = @start_time.ToDateTimeLocal();
						return r;
					}
					catch(Exception ex)
					{
						return null;
					}
				}
			}
			public Int32 @ordering
			{
				get
				{
					return this._ordering;
				}
				set
				{
					if (_ordering != value)
					{
						_ordering = value;
						this.changedProperties.Add("ordering");
					}
				}
			}
			
			public Int32 @visibility
			{
				get
				{
					return this._visibility;
				}
				set
				{
					if (_visibility != value)
					{
						_visibility = value;
						this.changedProperties.Add("visibility");
					}
				}
			}
			
			public Int32 @displayed_on
			{
				get
				{
					return this._displayed_on;
				}
				set
				{
					if (_displayed_on != value)
					{
						_displayed_on = value;
						this.changedProperties.Add("displayed_on");
					}
				}
			}
			
			public String @content_rating
			{
				get
				{
					return this._content_rating;
				}
				set
				{
					if (_content_rating != value)
					{
						_content_rating = value;
						this.changedProperties.Add("content_rating");
					}
				}
			}
			
		#endregion
	}
	#pragma warning restore CS8618
	#pragma warning restore CS8981
}
