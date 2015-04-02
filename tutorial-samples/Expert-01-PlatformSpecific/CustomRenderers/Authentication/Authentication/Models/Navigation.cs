using System;
using System.Collections.Generic;

namespace Authentication.Models
{
	/// <summary>
	/// Navigation.
	/// </summary>
	/// <see cref=""/>
	/// <see cref=""/>
	/// <see cref=""/>
	/// <see cref=""/>
	/// <see cref=""/>
	/// <see cref=""/>
	/// <see cref=""/>
	/// <see cref=""/>
	/// <see cref=""/>
	/// <see cref=""/>
	/// <see cref=""/>
	/// <see cref=""/>
	public class Navigation
	{
		/// <summary>
		/// The samples.
		/// </summary>
		public static Dictionary<string,string> samples = new Dictionary<string,string>()
		{
			{ 
				"Login with Facebook", 
				"Facebook"
			},
			{ 
				"Login with Twitter", 
				"Twitter"
			},
			{ 
				"Login with LinkedIn OAuth1", 
				"Authentication.Models.Twitter"
			},
			{ 
				"Login with LinkedIn OAuth2", 
				"ControlsView.MapView.Views.Code.PageMap"
			},
		};


		public static Dictionary<string,string> Samples
		{
			get
			{
				return samples;
			}
			set
			{
				samples = value;
			}
		}

	}
}

