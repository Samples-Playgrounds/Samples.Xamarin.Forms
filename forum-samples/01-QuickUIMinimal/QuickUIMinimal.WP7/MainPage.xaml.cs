using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace Xamarin.QuickUI.ControlGallery.WP7
{
	public partial class MainPage : PhoneApplicationPage
	{
		// Constructor
		public MainPage ()
		{
			InitializeComponent ();

			QuickUI.Init ();
			Content = Controls.QuickUIApp.GetQuickUIApp ().ConvertPageToUIElement (this);
		}

		protected override void OnNavigatedTo (NavigationEventArgs e)
		{
		}
	}
}