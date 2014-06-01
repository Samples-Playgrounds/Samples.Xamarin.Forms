using System;
using Xamarin.QuickUI;
using Tramchester.App.Models;

namespace Tramchester.App.Views
{
	public partial class TramstopsView
	{
		public TramstopsView ()
		{
			this.InitializeComponent ();

		}

		public void TramSelected(object sender, EventArg<object> e)
		{
			MessagingCenter.Send<Tramstop>((Tramstop)e.Data, "TramstopSelected");
		}
	}
}

