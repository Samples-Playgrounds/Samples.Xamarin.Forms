using System;
using Xamarin.QuickUI;

namespace Spin2Win
{
	public class Spin2WinApp
	{
		LoginPage loginPage;
		NavigationPage navigation;
		Person user;

		public Spin2WinApp ()
		{
			user = new Person ();

			loginPage = new LoginPage { Title = "Login" };
			navigation = new NavigationPage(loginPage);
			loginPage.SpinButtonPressed += OnSpinButtonPressed;
		}

		void OnSpinButtonPressed (object sender, SpinButtonPressedArgs eventArgs)
		{
			user.Name = eventArgs.Name;
			user.Email = eventArgs.Email;
			user.Company = eventArgs.Company;
			user.CompletedAzureChallenge = eventArgs.CompletedAzureChallenge;

			var slotsPage = new SlotsPage { Title = "Slots" };
			navigation.Push (slotsPage);
			slotsPage.SpinFinished += OnSpinFinished;
		}

		void OnSpinFinished (object sender, SpinFinishedArgs eventArgs)
		{
			var youWonPage = new YouWonPage (eventArgs.Prize) { Title = "You Won" };
			user.Prize = eventArgs.Prize;
			navigation.Push (youWonPage);
			youWonPage.DoneButtonPressed += OnDoneButtonPressed;

			var dataService = new DataService ();
			dataService.WriteUserData (user);
		}

		void OnDoneButtonPressed (object sender, EventArgs eventArgs)
		{
			navigation.PopToRoot ();
		}

		public Page GetMainPage ()
	    {
			return navigation;
	    }
    }
}
