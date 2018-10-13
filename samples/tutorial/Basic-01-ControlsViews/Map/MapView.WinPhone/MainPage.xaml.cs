using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace ControlsView.MapView.WinPhone
{
	public partial class MainPage : global::Xamarin.Forms.Platform.WinPhone.FormsApplicationPage
	{
		public MainPage()
		{
			InitializeComponent();
			SupportedOrientations = SupportedPageOrientation.PortraitOrLandscape;

			global::Xamarin.Forms.Forms.Init();

			InitializeMapSecretData();
			global::Xamarin.FormsMaps.Init(applicationId, authToken);		

			LoadApplication(new ControlsView.MapView.App());
		}

		string applicationId = "APP_ID_FROM_PORTAL";
		string authToken = "AUTH_TOKEN_FROM_PORTAL";

		partial void InitializeMapSecretData();

	}
}
