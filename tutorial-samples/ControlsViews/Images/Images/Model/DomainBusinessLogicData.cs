using System;
using System.Collections.Generic;

namespace Images
{
	public class DomainBusinessLogicData
	{
		public DomainBusinessLogicData ()
		{
		}



		//-------------------------------------------------------
		// testing binding to a Field vs Property

		// Xamarin.Forms.Xaml.XamlParseException: No embeddedresources found for Images.Views.MainPage
		//at Xamarin.Forms.Xaml.XamlLoader.Load (Xamarin.Forms.BindableObject view, System.Type callingType) [0x00000] in <filename unknown>:0
		//at Xamarin.Forms.Xaml.Extensions.LoadFromXaml[MainPage] (Images.Views.MainPage view, System.Type callingType) [0x00000] in <filename unknown>:0
		//at Images.Views.MainPage.InitializeComponent () [0x0000c] in /Users/moljac/Projects/Samples/Samples.Xamarin.Forms/tutorial-samples/ControlsViews/Images/Images/obj/Debug/MainPage.xaml.g.cs:22
		//at Images.Views.MainPage..ctor () [0x00008] in /Users/moljac/Projects/Samples/Samples.Xamarin.Forms/tutorial-samples/ControlsViews/Images/Images/Views/MainPage.xaml.cs:13
		//at Images.App.GetMainPage () [0x00001] in /Users/moljac/Projects/Samples/Samples.Xamarin.Forms/tutorial-samples/ControlsViews/Images/Images/App.cs:21
		//at Images.iOS.AppDelegate.FinishedLaunching (MonoTouch.UIKit.UIApplication app, MonoTouch.Foundation.NSDictionary options) [0x00021] in /Users/moljac/Projects/Samples/Samples.Xamarin.Forms/tutorial-samples/ControlsViews/Images/Images.iOS/AppDelegate.cs:34
		//at at (wrapper managed-to-native) MonoTouch.UIKit.UIApplication:UIApplicationMain (int,string[],intptr,intptr)
		//at MonoTouch.UIKit.UIApplication.Main (System.String[] args, IntPtr principal, IntPtr delegate) [0x00005] in /Developer/MonoTouch/Source/monotouch/src/UIKit/UIApplication.cs:62
		//at MonoTouch.UIKit.UIApplication.Main (System.String[] args, System.String principalClassName, System.String delegateClassName) [0x00038] in /Developer/MonoTouch/Source/monotouch/src/UIKit/UIApplication.cs:46
		//at Images.iOS.Application.Main (System.String[] args) [0x00008] in /Users/moljac/Projects/Samples/Samples.Xamarin.Forms/tutorial-samples/ControlsViews/Images/Images.iOS/Main.cs:17

		//public static List<ImageWrapper> Images = null;

		public static List<ImageWrapper> Images
		{
			get;
			set;
		}
		//-------------------------------------------------------

		static DomainBusinessLogicData ()
		{
			Images = new List<ImageWrapper>()
			{
				
				new ImageWrapper()
				{
					ImageUrl="icon-xamarin-studio-not-included-in-project.png",
					Filename="icon-xamarin-studio-not-included-in-project.png",
				},
				new ImageWrapper()
				{
					ImageUrl="./Xamarin-logo-hexagon-blue-200x200.png",
					Filename="./Xamarin-logo-hexagon-blue-200x200.png",
				},
				new ImageWrapper()
				{
					ImageUrl="./Xamarin_logo_and_wordmark.png",
					Filename="./Xamarin_logo_and_wordmark.png",
				},
				new ImageWrapper()
				{
					ImageUrl="./icon-xamarin-studio.png",
					Filename="./icon-xamarin-studio.png",
				},
				new ImageWrapper()
				{
					ImageUrl="./image.png",
					Filename="./image.png",
				},
				new ImageWrapper()
				{	
					ImageUrl="./mono-logo.png",
					Filename="./mono-logo.png",
				},
				new ImageWrapper()
				{
					ImageUrl="./xamarin copy.jpg",
					Filename="./xamarin copy.jpg",
				},
				new ImageWrapper()
				{
					ImageUrl="./xamarin-authorized-partner@2x.png",
					Filename="./xamarin-authorized-partner@2x.png",
				},
				new ImageWrapper()
				{
					ImageUrl="./xamarin-hexagon.gif",
					Filename="./xamarin-hexagon.gif",
				},
				new ImageWrapper()
				{
					ImageUrl="./xamarin-hexagon.jpg",
					Filename="./xamarin-hexagon.jpg",
				},
				new ImageWrapper()
				{
					ImageUrl="./xamarin-hexagon.png",
					Filename="./xamarin-hexagon.png",
				},
				new ImageWrapper()
				{
					ImageUrl="./xamarin-logo copy.jpg",
					Filename="./xamarin-logo copy.jpg",
				},
				new ImageWrapper()
				{
					ImageUrl="./xamarin-logo.jpg",
					Filename="./xamarin-logo.jpg",
				},
				new ImageWrapper()
				{
					ImageUrl="./xamarin-premier-partner@2x.png",
					Filename="./xamarin-premier-partner@2x.png",
				},
				new ImageWrapper()
				{
					ImageUrl="./xamarin-studio.jpeg",
					Filename="./xamarin-studio.jpeg",
				},
				new ImageWrapper()
				{
					ImageUrl="./xamarin.jpg",
					Filename="./xamarin.jpg",
				},
				new ImageWrapper()
				{
					ImageUrl="./xamarin.tiff",
					Filename="./xamarin.tiff",
				},
				new ImageWrapper()
				{
					ImageUrl="./subfolder/Xamarin-logo-hexagon-blue-200x200.png",
					Filename="./subfolder/Xamarin-logo-hexagon-blue-200x200.png",
				},
				new ImageWrapper()
				{
					ImageUrl="./subfolder/Xamarin_logo_and_wordmark.png",
					Filename="./subfolder/Xamarin_logo_and_wordmark.png",
				},
				new ImageWrapper()
				{
					ImageUrl="./subfolder/icon-xamarin-studio.png",
					Filename="./subfolder/icon-xamarin-studio.png",
				},
				new ImageWrapper()
				{
					ImageUrl="./subfolder/ide-xamarin-studio.png",
					Filename="./subfolder/ide-xamarin-studio.png",
				},
				new ImageWrapper()
				{
					ImageUrl="./subfolder/image.png",
					Filename="./subfolder/image.png",
				},
				new ImageWrapper()
				{
					ImageUrl="./subfolder/mono-logo.png",
					Filename="./subfolder/mono-logo.png",
				},
				new ImageWrapper()
				{
					ImageUrl="./subfolder/xamarin copy.jpg",
					Filename="./subfolder/xamarin copy.jpg",
				},
				new ImageWrapper()
				{
					ImageUrl="./subfolder/xamarin-authorized-partner@2x.png",
					Filename="./subfolder/xamarin-authorized-partner@2x.png",
				},
				new ImageWrapper()
				{
					ImageUrl="./subfolder/xamarin-hexagon.gif",
					Filename="./subfolder/xamarin-hexagon.gif",
				},
				new ImageWrapper()
				{
					ImageUrl="./subfolder/xamarin-hexagon.jpg",
					Filename="./subfolder/xamarin-hexagon.jpg",
				},
				new ImageWrapper()
				{
					ImageUrl="./subfolder/xamarin-hexagon.png",
					Filename="./subfolder/xamarin-hexagon.png",
				},
				new ImageWrapper()
				{
					ImageUrl="./subfolder/xamarin-logo copy.jpg",
					Filename="./subfolder/xamarin-logo copy.jpg",
				},
				new ImageWrapper()
				{
					ImageUrl="./subfolder/xamarin-logo.jpg",
					Filename="./subfolder/xamarin-logo.jpg",
				},
				new ImageWrapper()
				{
					ImageUrl="./subfolder/xamarin-premier-partner@2x.png",
					Filename="./subfolder/xamarin-premier-partner@2x.png",
				},
				new ImageWrapper()
				{
					ImageUrl="./subfolder/xamarin-studio.jpeg",
					Filename="./subfolder/xamarin-studio.jpeg",
				},
				new ImageWrapper()
				{
					ImageUrl="./subfolder/xamarin.jpg",
					Filename="./subfolder/xamarin.jpg",
				},
				new ImageWrapper()
				{
					ImageUrl="./subfolder/xamarin.tiff",
					Filename="./subfolder/xamarin.tiff",
				},
			};

			return;
		}







		public static Dictionary<string,string> samples = new Dictionary<string,string>()
		{
			{ 
				"Loading Formats from file sample", 
				"Images.Views.Xaml.ImagesFormatLoadTest"
			},
			{ 
				"Images as Embedded Resources in Portable Class", 
				"Images.Views.Xaml.ImagesEmbeddedResources"
			},
		};

		public static Dictionary<string,string> Samples
		{
			get
			{
				return samples;
			}
			set
			{
				samples = value;
			}
		}
	}
}

