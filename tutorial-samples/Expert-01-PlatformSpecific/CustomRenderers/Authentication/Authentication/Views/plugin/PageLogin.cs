using System;

using Xamarin.Forms;







namespace HolisticWare.XamarinForms.Authentication
{
	public partial class PageLogin : ContentPage
	{
		public PageLogin ()
		{
		}

		public PageLogin (string application_id_aka_client_id, string scope, Uri uri_authorize, Uri uri_callback)
			:
			this ()
		{
			return;
		}
	}
}


