using System;

namespace XamarinAuth.Views
{
	public partial class PageMain
	{
		partial void SetPublicDemoDataFacebookOAuth2()
		{
			oauth2 = new HolisticWare.Auth.OAuth2()
			{
				OAuth_IdApplication_IdAPI_KeyAPI_IdClient_IdCustomer = "",
				OAuth2_Scope = "", // "", "basic", "email",
				OAuth_UriAuthorization = new Uri("https://m.facebook.com/dialog/oauth/"), 
				OAuth_UriCallbackAKARedirect = new Uri("http://xamarin.com"),
			};
			 
			page = new HolisticWare.XamarinForms.Authentication.PageLogin(oauth2);

			return;
		}
	}
}

