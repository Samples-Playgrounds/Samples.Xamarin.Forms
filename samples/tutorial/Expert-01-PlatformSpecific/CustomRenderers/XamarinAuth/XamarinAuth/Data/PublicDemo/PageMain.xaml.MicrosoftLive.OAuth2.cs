using System;

namespace XamarinAuth.Views
{
	public partial class PageMain
	{
		partial void SetPublicDemoDataMicrosoftLiveOAuth2()
		{
			oauth2 = new HolisticWare.Auth.OAuth2()
			{
				/*
				clientId: "<MyclientI>",
				scope: "wl.basic, wl.signin, wl.offline_access",
				authorizeUrl: new Uri(""https://login.live.com/oauth20_authorize.srf"),
				redirectUrl: new Uri("https://login.live.com/oauth20_desktop.srf"))
				*/
				OAuth_IdApplication_IdAPI_KeyAPI_IdClient_IdCustomer = "",
				OAuth2_Scope = "wl.basic, wl.signin, wl.offline_access",
				OAuth_UriAuthorization = new Uri("https://login.live.com/oauth20_authorize.srf"), 
				OAuth_UriCallbackAKARedirect = new Uri("http://xamarin.com"),
			};
			 
			return;
		}
	}
}

