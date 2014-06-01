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
using Xamarin.QuickUI;

namespace Spin2Win.WP7
{
	public partial class MainPage : PhoneApplicationPage
	{
		// Constructor
		public MainPage ()
		{
			InitializeComponent ();
			QuickUI.Init ();
			var app = new Spin2WinApp ();
			Content = app.GetMainPage ().ConvertPageToUIElement (this);

		}

	}
}