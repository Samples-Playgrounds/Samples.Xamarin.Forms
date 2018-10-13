using System;

namespace XamarinAuth.Views
{
	public partial class PageMain
	{
		partial void SetPublicDemoDataGithubOAuth2()
		{
			/// https://developer.github.com/v3/oauth/#scopes
			oauth2 = new HolisticWare.Auth.OAuth2()
			{
				OAuth_IdApplication_IdAPI_KeyAPI_IdClient_IdCustomer = "",
				OAuth2_Scope = "", // "", "user",
				OAuth_UriAuthorization = new Uri("https://github.com/login/oauth/authorize"), 
				OAuth_UriCallbackAKARedirect = new Uri("http://xamarin.com"),
			};
			 
			page = new HolisticWare.XamarinForms.Authentication.PageLogin(oauth2);

			return;
		}
	}
}

