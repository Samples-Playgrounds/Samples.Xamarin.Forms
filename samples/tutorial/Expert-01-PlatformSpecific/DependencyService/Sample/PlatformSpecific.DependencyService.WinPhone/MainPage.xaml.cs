﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

using Xamarin.Forms;


namespace PlatformSpecific.DependencyService.WinPhone
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

			global::Xamarin.Forms.Forms.Init();
			LoadApplication(new PlatformSpecific.DependencyService.App()); // new in 1.3

			return;
			
			// Forms.Init();
			// Content = PlatformSpecific.DependencyService.App.GetMainPage().ConvertPageToUIElement(this);
			
			//return;
		}
	}
}
