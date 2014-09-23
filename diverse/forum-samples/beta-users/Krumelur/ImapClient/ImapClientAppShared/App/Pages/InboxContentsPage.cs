using System;
using Xamarin.QuickUI;
using Xplat_Core;
using System.Net.Mail;

namespace ImapClientAppShared
{
	/// <summary>
	/// Uses a ListView to show the mail account's inbox messages.
	/// </summary>
	public class InboxContentsPage : ContentPage
	{
		readonly InboxContentViewModel model;

		public InboxContentsPage() : base()
		{
			this.model = ServiceContainer.Resolve<InboxContentViewModel> ();

			this.BindingContext = this.model;

			this.Title = "Inbox Messages";

			// TODO: Remove this hack if toolbar buttons are fixed in Android!
			Button androidRefreshButton = null;
			Button androidExportButton = null;
			if(Device.OS != TargetPlatform.Android)
			{
				var refreshBtn = new ToolbarItem ("Refresh", null, () => {
					if (this.model.RefreshMessagesCommand.CanExecute (null))
					{
						this.model.RefreshMessagesCommand.Execute (null);
					}
				});
				this.ToolbarItems.Add (refreshBtn);

				var exportBtn = new ToolbarItem ("Export", null, () => this.NavigateTo (new ExportAccountPage ()));
				this.ToolbarItems.Add (exportBtn);
			}
			else
			{
				// ToolbarItems don't work on Android. Create a normal button and add it to the layout.
				androidRefreshButton = new Button {
					Text = "Refresh"
				};
				androidRefreshButton.SetBinding (Button.CommandProperty, new Binding ("RefreshMessagesCommand"));

				androidExportButton = new Button {
					Text = "Export"
				}.WhenActivated ((sender, args) => this.NavigateTo (new ExportAccountPage ()));
			}

			// TODO: Use custom cell to make it look nicer!
			var messageList = new ListView {
				// There is no direct way of binding an ICommand to a TextCellTemplate, hence the workaround using DataTemplate<T>.
				ItemTemplate = DataTemplate<Cell>.Create (() => {
					var cell = new TextCell {
						Command = this.model.MessageSelectedCommand
					};
					return (Cell)cell;
				})
			};
			// Bind the source of the list view to the list of messages in the view model.
			messageList.SetBinding (ListView.ItemSourceProperty, new Binding ("Messages"));

			messageList.ItemTemplate.SetBinding (TextCell.TextProperty, new Binding ("From.Address"));
			messageList.ItemTemplate.SetBinding (TextCell.DetailProperty, new Binding ("Subject"));
			// Bind the MailMessage itself to the command property. Figured that out by trial and error: simply "."!
			messageList.ItemTemplate.SetBinding (TextCell.CommandParameterProperty, new Binding ("."));
		
			var layout = new StackLayout {
				Orientation = StackLayout.StackOrientation.Vertical
			};

			if(androidRefreshButton != null)
			{
				layout.Add (androidRefreshButton);
			}

			if(androidExportButton != null)
			{
				layout.Add (androidExportButton);
			}

			layout.Add (messageList);

			this.Content = layout;

			// Log user in if required. Show modal to prevent the login page being pushed onto the stack.
			if(!ImapClientApp.MainApp.IsUserAuthenticated)
			{
				this.NavigateTo(new LoginPage (), true);
			}
		}

		protected override void OnAppearing ()
		{
			base.OnAppearing ();
			this.model.IsBusyChanged += this.HandleBusyChanged;

			// Refresh the inbox list once when the page appears
			if (!this.model.HasSyncedMessagesOnce) {
				this.model.RefreshMessagesCommand.Execute (null);
			}

			this.model.MessageSelected += this.HandleMessageSelected;
		}

		protected override void OnDisappearing ()
		{
			base.OnDisappearing ();

			this.model.IsBusyChanged -= this.HandleBusyChanged;
			this.model.MessageSelected -= this.HandleMessageSelected;
		}

		void HandleMessageSelected(MailDetailsViewModel mailDetailViewModel)
		{
			this.NavigateTo(new MailDetailsPage (mailDetailViewModel));
		}

		void HandleBusyChanged(object sender, EventArgs args)
		{
			this.IsBusy = this.model.IsBusy;
		}
	}
}

