using System;

namespace Authentication.Views
{
	public partial class PageMain
	{
		partial void SetPublicDemoDataLinkedInOAuth2()
		{
			/*	
			http://forums.xamarin.com/discussion/14883/login-with-linkedin
			http://forums.xamarin.com/discussion/25457/xamarin-auth

			*/
			oauth2 = new HolisticWare.Auth.OAuth2()
			{
				OAuth_IdApplication_IdAPI_KeyAPI_IdClient_IdCustomer = "",
				OAuth1_SecretKey_ConsumerSecret_APISecret = "",
				OAuth2_Scope = "",
				OAuth_UriAuthorization = new Uri("https://www.linkedin.com/uas/oauth2/authorization"), 
				OAuth_UriCallbackAKARedirect = new Uri("http://xamarin.com"),
				OAuth1_UriAccessToken = new Uri("https://www.linkedin.com/uas/oauth2/accessToken"),
			};
			 
			return;
		}
	}
}

