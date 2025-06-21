using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
using System.ComponentModel;

#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Models {
	public class activities {
		public List<string> changedProperties = new List<string>();
		#region fields
			private Int32 _id;// sqllite type = INTEGER
			private Int32 _parent_id;// sqllite type = INTEGER
			private String _type;// sqllite type = varchar(255)
			private String _title;// sqllite type = varchar(255)
			private String _subtitle;// sqllite type = varchar(255)
			private DateTime _scheduled_at;// sqllite type = timestamp
			private DateTime _started_at;// sqllite type = timestamp
			private DateTime _finished_at;// sqllite type = timestamp
			private Boolean _cancelled;// sqllite type = boolean
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
			
			public Int32 @parent_id
			{
				get
				{
					return this._parent_id;
				}
				set
				{
					if (_parent_id != value)
					{
						_parent_id = value;
						this.changedProperties.Add("parent_id");
					}
				}
			}
			
			public String @type
			{
				get
				{
					return this._type;
				}
				set
				{
					if (_type != value)
					{
						_type = value;
						this.changedProperties.Add("type");
					}
				}
			}
			
			public String @title
			{
				get
				{
					return this._title;
				}
				set
				{
					if (_title != value)
					{
						_title = value;
						this.changedProperties.Add("title");
					}
				}
			}
			
			public String @subtitle
			{
				get
				{
					return this._subtitle;
				}
				set
				{
					if (_subtitle != value)
					{
						_subtitle = value;
						this.changedProperties.Add("subtitle");
					}
				}
			}
			
			public DateTime @scheduled_at
			{
				get
				{
					return this._scheduled_at;
				}
				set
				{
					if (_scheduled_at != value)
					{
						_scheduled_at = value;
						this.changedProperties.Add("scheduled_at");
					}
				}
			}
			
			public DateTime @started_at
			{
				get
				{
					return this._started_at;
				}
				set
				{
					if (_started_at != value)
					{
						_started_at = value;
						this.changedProperties.Add("started_at");
					}
				}
			}
			
			public DateTime @finished_at
			{
				get
				{
					return this._finished_at;
				}
				set
				{
					if (_finished_at != value)
					{
						_finished_at = value;
						this.changedProperties.Add("finished_at");
					}
				}
			}
			
			public Boolean @cancelled
			{
				get
				{
					return this._cancelled;
				}
				set
				{
					if (_cancelled != value)
					{
						_cancelled = value;
						this.changedProperties.Add("cancelled");
					}
				}
			}
			
		#endregion
	}
	#pragma warning restore CS8618
	#pragma warning restore CS8981
}
