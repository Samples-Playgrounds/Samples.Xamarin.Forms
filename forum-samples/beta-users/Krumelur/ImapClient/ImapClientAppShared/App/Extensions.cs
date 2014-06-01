using System;
using Xamarin.QuickUI;

namespace ImapClientAppShared
{
	/// <summary>
	/// Various extension methods.
	/// </summary>
	public static class Extensions
	{
		/// <summary>
		/// Navigates a page to another page. This supports tablet and phone form factor.
		/// </summary>
		/// <param name="fromPage">From page.</param>
		/// <param name="toPage">To page.</param>
		/// <param name="modal">If set to <c>true</c> modal.</param>
		public static void NavigateTo(this ContentPage fromPage, ContentPage toPage, bool modal = false)
		{
			if(fromPage == null)
			{
				return;
			}
			if(toPage == null)
			{
				throw new InvalidOperationException ("No page to navigate to!");
			}
			if(fromPage.Navigation == null)
			{
				throw new InvalidOperationException ("No Navigation available on source page!");
			}

			// TODO: Support tablets. Master-detail-view is still buggy in QuickUI!

			//if(Device.Idiom == TargetIdiom.Phone)
			{
				if(modal)
				{
					fromPage.Navigation.PushModal (toPage);

				}
				else
				{
					fromPage.Navigation.Push (toPage);
				}
			}
//			else
//			{
//				// Tablet or other.
//				var splitPage = (MasterDetailPage)ImapClientApp.MainApp.MainPage;
//				if(modal)
//				{
//					splitPage.Detail.Navigation.PushModal(toPage);
//				}
//				else
//				{
//					// TODO: Brrr....the pages should know where they want to be displayed. Stitch in a subclass of ContentPage?
//					if(toPage is MailDetailsPage)
//					{
//						splitPage.Detail.Navigation.Push (toPage);
//					}
//				}
//
//
//			}

		}
	}
}

