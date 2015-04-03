using System;

namespace Authentication.Views
{
	public partial class PageMain
	{
		partial void SetSensitiveDataTwitterOAuth2()
		{
			HolisticWare.Auth.OAuth2 oauth1 = new HolisticWare.Auth.OAuth2()
			{
				OAuth_IdApplication_IdAPI_KeyAPI_IdClient_IdCustomer = "etd7kEcbqOGnCYKb9D1zoqqr7",
				OAuth2_Scope = "",
				OAuth_UriAuthorization = new Uri("https://api.twitter.com/oauth/authorize"), 
				OAuth_UriCallbackAKARedirect = new Uri("http://xamarin.com"),
			};

			page = new HolisticWare.XamarinForms.Authentication.PageLogin(oauth1);

			return;
		}
	}
}

