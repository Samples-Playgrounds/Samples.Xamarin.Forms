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


		string application_id_aka_client_id = "655409847920181";
		string scope = "";
		Uri uri_authorize = null;
		Uri uri_callback = null;

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
		partial void SetSensitiveDataFacebook();
		partial void SetSensitiveDataTwitter();
		partial void SetSensitiveDataLinkedInOAuth2();
		//---------------------------------------------------------------------------------


		public void OnItemSelected (object sender, ItemTappedEventArgs args_tapped)
		{
			object item = args_tapped.Item;

			KeyValuePair<string, string> kvp = (KeyValuePair<string, string>)item;

			string authentication_provider = kvp.Value;



			switch (authentication_provider)
			{
				case "Facebook":
					SetSensitiveDataFacebook();
					break;
				case "Twitter":
					SetSensitiveDataTwitter();
					break;
				case "LinkedIn OAuth2":
					SetSensitiveDataLinkedInOAuth2();
					break;
				default:
					string msg = "Unknown Authentication Provider: " + authentication_provider;
					throw new NotImplementedException(msg);
			}


			Page page = 
				new HolisticWare.XamarinForms.Authentication.PageLogin
							(
							application_id_aka_client_id,
							scope,
							uri_authorize,
							uri_callback
							);

			this.Navigation.PushAsync(page);

			return;

		}

	}
}

