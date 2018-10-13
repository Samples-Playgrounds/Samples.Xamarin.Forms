using System;

namespace XamarinAuth.Views
{
	public partial class PageMain
	{
		partial void SetPublicDemoDataLinkedInOAuth1()
		{
			oauth1 = new HolisticWare.Auth.OAuth1()
			{
				OAuth_IdApplication_IdAPI_KeyAPI_IdClient_IdCustomer = "",
				OAuth1_SecretKey_ConsumerSecret_APISecret = "",
				OAuth1_UriRequestToken = new Uri("https://api.linkedin.com/uas/oauth/requestToken"),
				OAuth_UriAuthorization = new Uri("https://api.linkedin.com/uas/oauth/authorize"), 
				OAuth_UriCallbackAKARedirect = new Uri("http://xamarin.com"),
				OAuth1_UriAccessToken = new Uri("https://api.linkedin.com/uas/oauth/accessToken"),
			};

			page = new HolisticWare.XamarinForms.Authentication.PageLogin(oauth1);

			return;

			return;
		}
	}
}

