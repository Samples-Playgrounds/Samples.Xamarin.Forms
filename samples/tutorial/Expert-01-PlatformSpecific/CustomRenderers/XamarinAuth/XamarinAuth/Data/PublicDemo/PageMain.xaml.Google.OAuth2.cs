using System;

namespace XamarinAuth.Views
{
	public partial class PageMain
	{
		partial void SetPublicDemoDataGoogleOAuth2()
		{
			// https://www.snip2code.com/Snippet/245686/Xamarin-Google-and-Facebook-authenticati
			/*
				clientId: "123456789.apps.googleusercontent.com", 
				scope: "https://www.googleapis.com/auth/userinfo.email", 
				authorizeUrl: new Uri ("https://accounts.google.com/o/oauth2/auth"),
				redirectUrl: new Uri ("http://bunchy.com/oauth2callback"), 
				getUsernameAsync: null)
			*/
			oauth2 = new HolisticWare.Auth.OAuth2()
			{
				OAuth_IdApplication_IdAPI_KeyAPI_IdClient_IdCustomer = "",
				OAuth2_Scope = "https://www.googleapis.com/auth/userinfo.email",
				OAuth_UriAuthorization = new Uri("https://accounts.google.com/o/oauth2/auth"), 
				OAuth_UriCallbackAKARedirect = new Uri("http://xamarin.com"),
			};
			 
			page = new HolisticWare.XamarinForms.Authentication.PageLogin(oauth2);

			return;
		}
	}
}

