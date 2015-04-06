using System;

namespace XamarinAuth.Views
{
	public partial class PageMain
	{
		partial void SetPublicDemoDataInstagramOAuth2()
		{
			oauth2 = new HolisticWare.Auth.OAuth2()
			{
				OAuth_IdApplication_IdAPI_KeyAPI_IdClient_IdCustomer = "",
				OAuth2_Scope = "basic",
				OAuth_UriAuthorization = new Uri("https://api.instagram.com/oauth/authorize/"), 
				OAuth_UriCallbackAKARedirect = new Uri("http://xamarin.com"),
			};
			 
			return;
		}
	}
}

