using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
using System.ComponentModel;

#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Models {
	public class library_section_permissions {
		public List<string> changedProperties = new List<string>();
		#region fields
			private Int32 _id;// sqllite type = INTEGER
			private Int32 _library_section_id;// sqllite type = INTEGER
			private Int32 _account_id;// sqllite type = INTEGER
			private Int32 _permission;// sqllite type = INTEGER
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
			
			public Int32 @library_section_id
			{
				get
				{
					return this._library_section_id;
				}
				set
				{
					if (_library_section_id != value)
					{
						_library_section_id = value;
						this.changedProperties.Add("library_section_id");
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
			
			public Int32 @permission
			{
				get
				{
					return this._permission;
				}
				set
				{
					if (_permission != value)
					{
						_permission = value;
						this.changedProperties.Add("permission");
					}
				}
			}
			
		#endregion
	}
	#pragma warning restore CS8618
	#pragma warning restore CS8981
}
