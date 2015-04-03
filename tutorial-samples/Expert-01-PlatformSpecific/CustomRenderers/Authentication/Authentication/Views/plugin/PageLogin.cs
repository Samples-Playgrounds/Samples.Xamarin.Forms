using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HolisticWare.XamarinForms.Authentication
{
	/// <summary>
	/// Page login.
	///		Facebook:	OAuth2
	///					https://developers.facebook.com/apps/
	///					https://developers.facebook.com/
	///		Twitter:	OAuth1
	///					https://apps.twitter.com/apps
	///					https://dev.twitter.com/
	///		LinkedIn:	OAuth1
	///					https://www.linkedin.com/secure/developer
	///					https://developer.linkedin.com/
	/// </summary>
	/// <see cref="http://forums.xamarin.com/discussion/36687/how-to-pass-paramaters-to-custom-renderers"/>
	/// <see cref="https://hedgehogjim.wordpress.com/2015/01/29/simplify-using-xamarin-auth-with-async-tasks-a-twitter-example/"/>
	/// <see cref="http://thirteendaysaweek.com/2013/04/25/xamarin-ios-and-authentication-in-windows-azure-mobile-services-part-i-configuration/"/>
	/// <see cref="http://chrisrisner.com/Authentication-with-Windows-Azure-Mobile-Services"/>
	/// <see cref="http://alejandroruizvarela.blogspot.com/2014/03/xamarinauth-custom-accounts.html"/>
	/// <see cref="http://blog.falafel.com/using-xamarin-forms-dependencyservice-and-azure-mobile-services-to-add-authentication-to-cross-platform-apps/"/>
	public partial class PageLogin : ContentPage
	{
		public HolisticWare.Auth.OAuth OAuth
		{
			get;
			set;
		}

		public PageLogin 
					(
					string application_id_aka_client_id, 
					string scope, 
					Uri uri_authorization, 
					Uri uri_callback_redirect
					)
		{
			this.OAuth = new HolisticWare.Auth.OAuth2()
			{
				OAuth_IdApplication_IdAPI_KeyAPI_IdClient_IdCustomer = application_id_aka_client_id,
				OAuth2_Scope = scope,
				OAuth_UriAuthorization = uri_authorization,
				OAuth_UriCallbackAKARedirect = uri_callback_redirect,
			};

			return;
		}

		public PageLogin (HolisticWare.Auth.OAuth2 oauth2)
			: this
					(
					oauth2.OAuth_IdApplication_IdAPI_KeyAPI_IdClient_IdCustomer,
					oauth2.OAuth2_Scope,
					oauth2.OAuth_UriAuthorization,
					oauth2.OAuth_UriCallbackAKARedirect
					)
		{
			return;
		}



		public PageLogin 
					(
					string application_id_aka_client_id, 
					string client_customer_secret, 
					Uri uri_request_token, 
					Uri uri_authorization, 
					Uri uri_access_token, 
					Uri uri_callback_redirect
					)
		{
			this.OAuth =  new HolisticWare.Auth.OAuth1()
			{
				OAuth_IdApplication_IdAPI_KeyAPI_IdClient_IdCustomer = application_id_aka_client_id,
				OAuth1_SecretKey_ConsumerSecret_APISecret = client_customer_secret,
				OAuth1_UriRequestToken = uri_request_token,
				OAuth_UriAuthorization = uri_authorization,
				OAuth1_UriAccessToken = uri_access_token,
				OAuth_UriCallbackAKARedirect = uri_callback_redirect,
			};

			return;
		}

		public PageLogin (HolisticWare.Auth.OAuth1 oauth1)
			: this
					(
					oauth1.OAuth_IdApplication_IdAPI_KeyAPI_IdClient_IdCustomer,
					oauth1.OAuth1_SecretKey_ConsumerSecret_APISecret,
					oauth1.OAuth1_UriRequestToken,
					oauth1.OAuth_UriAuthorization,
					oauth1.OAuth1_UriAccessToken,
					oauth1.OAuth_UriCallbackAKARedirect
					)
		{
			return;
		}


	}
}


