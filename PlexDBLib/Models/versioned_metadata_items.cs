using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
using System.ComponentModel;

#pragma warning disable CS8618
#pragma warning disable CS8981
namespace PlexDBLib.Models {
	public class versioned_metadata_items {
		public List<string> changedProperties = new List<string>();
		#region fields
			private Int32 _id;// sqllite type = INTEGER
			private Int32 _metadata_item_id;// sqllite type = INTEGER
			private Int32 _generator_id;// sqllite type = INTEGER
			private Int32 _target_tag_id;// sqllite type = INTEGER
			private Int32 _state;// sqllite type = INTEGER
			private Int32 _state_context;// sqllite type = INTEGER
			private Int32 _selected_media_id;// sqllite type = INTEGER
			private Int32 _version_media_id;// sqllite type = INTEGER
			private Int32 _media_decision;// sqllite type = INTEGER
			private Int64 _file_size;// sqllite type = integer(8)
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
			
			public Int32 @metadata_item_id
			{
				get
				{
					return this._metadata_item_id;
				}
				set
				{
					if (_metadata_item_id != value)
					{
						_metadata_item_id = value;
						this.changedProperties.Add("metadata_item_id");
					}
				}
			}
			
			public Int32 @generator_id
			{
				get
				{
					return this._generator_id;
				}
				set
				{
					if (_generator_id != value)
					{
						_generator_id = value;
						this.changedProperties.Add("generator_id");
					}
				}
			}
			
			public Int32 @target_tag_id
			{
				get
				{
					return this._target_tag_id;
				}
				set
				{
					if (_target_tag_id != value)
					{
						_target_tag_id = value;
						this.changedProperties.Add("target_tag_id");
					}
				}
			}
			
			public Int32 @state
			{
				get
				{
					return this._state;
				}
				set
				{
					if (_state != value)
					{
						_state = value;
						this.changedProperties.Add("state");
					}
				}
			}
			
			public Int32 @state_context
			{
				get
				{
					return this._state_context;
				}
				set
				{
					if (_state_context != value)
					{
						_state_context = value;
						this.changedProperties.Add("state_context");
					}
				}
			}
			
			public Int32 @selected_media_id
			{
				get
				{
					return this._selected_media_id;
				}
				set
				{
					if (_selected_media_id != value)
					{
						_selected_media_id = value;
						this.changedProperties.Add("selected_media_id");
					}
				}
			}
			
			public Int32 @version_media_id
			{
				get
				{
					return this._version_media_id;
				}
				set
				{
					if (_version_media_id != value)
					{
						_version_media_id = value;
						this.changedProperties.Add("version_media_id");
					}
				}
			}
			
			public Int32 @media_decision
			{
				get
				{
					return this._media_decision;
				}
				set
				{
					if (_media_decision != value)
					{
						_media_decision = value;
						this.changedProperties.Add("media_decision");
					}
				}
			}
			
			public Int64 @file_size
			{
				get
				{
					return this._file_size;
				}
				set
				{
					if (_file_size != value)
					{
						_file_size = value;
						this.changedProperties.Add("file_size");
					}
				}
			}
			
		#endregion
	}
	#pragma warning restore CS8618
	#pragma warning restore CS8981
}
