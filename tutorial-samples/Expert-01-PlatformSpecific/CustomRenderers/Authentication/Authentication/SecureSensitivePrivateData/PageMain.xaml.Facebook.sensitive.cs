using System;

namespace Authentication.Views
{
	public partial class PageMain
	{
		partial void SetSensitiveDataFacebookOAuth2()
		{
			HolisticWare.Auth.OAuth2 oauth2 = new HolisticWare.Auth.OAuth2()
			{
				/*
				Vecernji List OK!!!

				OAuth_IdApplication_IdAPI_KeyAPI_IdClient_IdCustomer = "117486881606473",
				OAuth2_Scope = "", // "", "basic", "email",
				OAuth_UriAuthorization = new Uri("https://m.facebook.com/dialog/oauth/"), 
				OAuth_UriCallbackAKARedirect = new Uri("http://www.vecernji.hr"),
				*/
				OAuth_IdApplication_IdAPI_KeyAPI_IdClient_IdCustomer = "655409847920181",
				OAuth2_Scope = "", // "", "basic", "email",
				OAuth_UriAuthorization = new Uri("https://m.facebook.com/dialog/oauth/"), 
				OAuth_UriCallbackAKARedirect = new Uri("http://xamarin.com"),
			};
			 
			page = new HolisticWare.XamarinForms.Authentication.PageLogin(oauth2);

			return;
		}
	}
}

