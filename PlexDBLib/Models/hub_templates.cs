using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
using System.ComponentModel;

#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Models {
	public class hub_templates {
		public List<string> changedProperties = new List<string>();
		#region fields
			private Int32 _id;// sqllite type = INTEGER
			private String _section;// sqllite type = varchar(255)
			private String _identifier;// sqllite type = varchar(255)
			private String _title;// sqllite type = varchar(255)
			private Int32 _home_visibility;// sqllite type = INTEGER
			private Int32 _recommended_visibility;// sqllite type = INTEGER
			private Double _order;// sqllite type = float
			private String _extra_data;// sqllite type = varchar(255)
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
			
			public String @section
			{
				get
				{
					return this._section;
				}
				set
				{
					if (_section != value)
					{
						_section = value;
						this.changedProperties.Add("section");
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
			
			public Int32 @home_visibility
			{
				get
				{
					return this._home_visibility;
				}
				set
				{
					if (_home_visibility != value)
					{
						_home_visibility = value;
						this.changedProperties.Add("home_visibility");
					}
				}
			}
			
			public Int32 @recommended_visibility
			{
				get
				{
					return this._recommended_visibility;
				}
				set
				{
					if (_recommended_visibility != value)
					{
						_recommended_visibility = value;
						this.changedProperties.Add("recommended_visibility");
					}
				}
			}
			
			public Double @order
			{
				get
				{
					return this._order;
				}
				set
				{
					if (_order != value)
					{
						_order = value;
						this.changedProperties.Add("order");
					}
				}
			}
			
			public String @extra_data
			{
				get
				{
					return this._extra_data;
				}
				set
				{
					if (_extra_data != value)
					{
						_extra_data = value;
						this.changedProperties.Add("extra_data");
					}
				}
			}
			
		#endregion
	}
	#pragma warning restore CS8618
	#pragma warning restore CS8981
}
