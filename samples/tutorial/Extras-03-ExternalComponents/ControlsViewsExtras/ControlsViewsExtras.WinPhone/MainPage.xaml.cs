using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

using Xamarin.Forms;


namespace ControlsViewsExtras.WinPhone
{
	public partial class MainPage 
		: 
		//PhoneApplicationPage
		global::Xamarin.Forms.Platform.WinPhone.FormsApplicationPage // superclass new in 1.3
	{
		public MainPage()
		{
			InitializeComponent();

			SupportedOrientations = SupportedPageOrientation.PortraitOrLandscape;

			global::OxyPlot.XamarinFormsWinPhone.Forms.Init();

			global::Xamarin.Forms.Forms.Init();
			LoadApplication(new ControlsViewsExtras.App()); // new in 1.3

			return;

			// OxyPlot.XamarinFormsWinPhone.Forms.Init();
			// Forms.Init();
			// Content = ControlsViewsExtras.App.GetMainPage().ConvertPageToUIElement(this);
			// 
			// return;
		}
	}
}
