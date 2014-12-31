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
	public partial class MainPage : PhoneApplicationPage
	{
		public MainPage()
		{
			InitializeComponent();

			OxyPlot.XamarinFormsWinPhone.Forms.Init();
			Forms.Init();
			Content = ControlsViewsExtras.App.GetMainPage().ConvertPageToUIElement(this);
		}
	}
}
