using System;

namespace XamarinAuth.Views
{
	public partial class PageMain
	{
		partial void SetPublicDemoDataLinkedInOAuth2()
		{
			/*	
			https://www.linkedin.com/secure/developer
			https://developer.linkedin.com/docs/oauth2
			https://developer.linkedin.com/docs/
			https://developer.linkedin.com/docs/signin-with-linkedin


			http://forums.xamarin.com/discussion/14883/login-with-linkedin
			https://www.linkedin.com/uas/oauth2/authorization?response_type=code&client_id=***"

			http://forums.xamarin.com/discussion/25457/xamarin-auth

			TODO: need testing... not quite correct

			*/
			oauth2 = new HolisticWare.Auth.OAuth2()
			{
				OAuth_IdApplication_IdAPI_KeyAPI_IdClient_IdCustomer = "",
				OAuth2_Scope = "r_basicprofile",
				OAuth_UriAuthorization = 
							new Uri
								(
									"https://www.linkedin.com/uas/oauth2/authorization?response_type=code"
									+
									"&client_id=" + ""
									+
									"&scope=" + Uri.EscapeDataString("r_basicprofile")
									+ 
									"&redirect_uri=" + Uri.EscapeDataString("https://xamarin.com/")
								), 
				OAuth_UriCallbackAKARedirect = new Uri("https://xamarin.com/"),
			};
			 
			return;
		}
	}
}

