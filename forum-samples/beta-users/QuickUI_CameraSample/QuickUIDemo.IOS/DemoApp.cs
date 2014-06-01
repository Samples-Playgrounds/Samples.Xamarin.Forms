using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.QuickUI;
using Xamarin.Media;

namespace QuickUIDemo
{
	public static class DemoApp
	{
		public static Page GetMainPage()
		{
			var result = new NavigationPage(new WelcomePage());

			return result;
		}
	}

	public class WelcomePage : ContentPage
	{
		StackLayout mainLayout;
		Button cameraButton1;
		Button cameraButton2;

		public WelcomePage()
		{
			Title = "QuickUI Demo";
			Content = mainLayout = new StackLayout
			{
				Padding = new Thickness(20, 20, 20, 100),
				Spacing = 10,
				Orientation = StackLayout.StackOrientation.Vertical,
				VerticalOptions = LayoutOptions.Center
			};

			mainLayout.Add(new Label
			{
				Text = "Welcome to the QuickUI Demo App!",
				XAlign = TextAlignment.Center
			});

			mainLayout.Add(cameraButton1 = new Button()
			{
				Text = "Take Picture With MediaPickerController",
				IsEnabled = true,
				MinimumWidthRequest = 100,
				MinimumHeightRequest = 100
			});

			mainLayout.Add(cameraButton2 = new Button()
			{
				Text = "Take Picture With MediaPicker TakePhotoAsync.",
				IsEnabled = true,
				MinimumWidthRequest = 100,
				MinimumHeightRequest = 100
			});

			cameraButton1.Activated += (sender, args) =>
			{
				//var picker = new MediaPicker();
				//MediaPickerController controller = picker.GetTakePhotoUI(new StoreCameraMediaOptions
				//{
				//    Name = "test.jpg",
				//    Directory = "MediaPickerSample"
				//});
				//controller.ModalPresentationStyle = UIModalPresentationStyle.FullScreen;
				//controller.ModalTransitionStyle = UIModalTransitionStyle.CoverVertical;
				//var pageController = this.GetViewController();

				////I tried to add the controller as a child to the pagecontroller, but it hangs the app
				////pageController.AddChildViewController(controller);

				//pageController.PresentViewController(controller, true, null);
			};

			cameraButton2.Activated += (sender, args) =>
			{
				//var picker = new MediaPicker();
				//picker.TakePhotoAsync(new StoreCameraMediaOptions() { Name = "test.jpg" }).ContinueWith(t =>
				//{
				//    MediaFile file = t.Result;
				//    Console.WriteLine(file.Path);
				//}, TaskScheduler.FromCurrentSynchronizationContext());
			};
		}


	}

}
