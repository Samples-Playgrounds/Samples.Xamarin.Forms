using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Authentication.Views
{
	public partial class PageMain : ContentPage
	{
		public PageMain ()
		{
			InitializeComponent ();
		}

		HolisticWare.Auth.OAuth oauth = null;

		//---------------------------------------------------------------------------------
		// methods implemented in other file which is included in project through wildcard
		// in this case files are in folder
		//			SecureSensitivePrivateData/
		//	patterns
		//			*.secure.cs
		//			*.sensitive.cs
		//			*.sensitive.cs
		//
		//		<Compile Include="SecureSensitivePrivateData/*.secure.cs" />
	    //		<Compile Include="SecureSensitivePrivateData/*.secret.cs" />
    	//		<Compile Include="SecureSensitivePrivateData/*.sensitive.cs" />
		//
		// csproj include
		partial void SetSensitiveDataFacebookOAuth2();
		partial void SetSensitiveDataTwitterOAuth1();
		partial void SetSensitiveDataTwitterOAuth2();
		partial void SetSensitiveDataLinkedInOAuth1();
		partial void SetSensitiveDataLinkedInOAuth2();
		//---------------------------------------------------------------------------------

		Page page = null;

		public void OnItemSelected (object sender, ItemTappedEventArgs args_tapped)
		{
			object item = args_tapped.Item;

			KeyValuePair<string, string> kvp = (KeyValuePair<string, string>)item;

			string authentication_provider = kvp.Value;



			switch (authentication_provider)
			{
				case "Facebook OAuth2":
					SetSensitiveDataFacebookOAuth2();
					break;
				case "Twitter OAuth1":
					SetSensitiveDataTwitterOAuth1();
					break;
				case "Twitter OAuth2":
					SetSensitiveDataTwitterOAuth2();
					break;
				case "LinkedIn OAuth1":
					SetSensitiveDataLinkedInOAuth1();
					break;
				case "LinkedIn OAuth2":
					SetSensitiveDataLinkedInOAuth2();
					break;
				default:
					string msg = "Unknown Authentication Provider: " + authentication_provider;
					throw new NotImplementedException(msg);
			}

			this.Navigation.PushAsync(page);

			return;

		}

	}
}

