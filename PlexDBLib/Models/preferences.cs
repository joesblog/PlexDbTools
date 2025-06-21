using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
using System.ComponentModel;

#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Models {
	public class preferences {
		public List<string> changedProperties = new List<string>();
		#region fields
			private Int32 _id;// sqllite type = INTEGER
			private String _name;// sqllite type = varchar(255)
			private String _value;// sqllite type = varchar(255)
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
			
			public String @value
			{
				get
				{
					return this._value;
				}
				set
				{
					if (_value != value)
					{
						_value = value;
						this.changedProperties.Add("value");
					}
				}
			}
			
		#endregion
	}
	#pragma warning restore CS8618
	#pragma warning restore CS8981
}
