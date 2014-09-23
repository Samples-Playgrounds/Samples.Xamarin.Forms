using System;
using Xamarin.QuickUI;
using Xplat_Core;

namespace ImapClientAppShared
{
	/// <summary>
	/// Mail details page.
	/// </summary>
	public class MailDetailsPage : ContentPage
	{
		readonly MailDetailsViewModel model;

		public MailDetailsPage(MailDetailsViewModel model) : base()
		{
			this.model = model;
			this.BindingContext = this.model;

			this.Title = "Mail Details";

			var fromDescLbl = new Label {
				Text = "From:"
			};

			var fromLbl = new Label ();
			fromLbl.SetBinding (Label.TextProperty, new Binding ("From"));

			var subjectDescLbl = new Label {
				Text = "Subject:",
			};

			var subjectLbl = new Label ();
			subjectLbl.SetBinding (Label.TextProperty, new Binding ("Subject"));

			var bodyLbl = new Label {
				LineBreakMode = LineBreakMode.WordWrap,
				MinimumHeightRequest = 200
			};
			bodyLbl.SetBinding (Label.TextProperty, new Binding ("Body"));


			// Use a GridLayout, just to see how it works.
			var layout = new GridLayout ();

			// Row 1: From
			layout.Add (fromDescLbl, 0, 0);
			layout.Add (fromLbl, 1, 0);

			// Row 2: subject
			layout.Add (subjectDescLbl, 0, 1);
			layout.Add (subjectLbl, 1, 1);

			// Row 3 (spanned): body
			layout.Add (bodyLbl, 0, 2, 2, 3);

			layout.SetColumnSpacing (0, 60);
			layout.SetRowSpacing (2, 20);

			this.Content = layout;
		}
	}
}

