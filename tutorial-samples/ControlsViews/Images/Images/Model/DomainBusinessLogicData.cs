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
					ImageUrl="icon_xamarin_studio_not_included_in_project.png",
					Filename="icon_xamarin_studio_not_included_in_project.png",
				},
				new ImageWrapper()
				{
					ImageUrl="./Xamarin_logo_hexagon_blue_200x200.png",
					Filename="./Xamarin_logo_hexagon_blue_200x200.png",
				},
				new ImageWrapper()
				{
					ImageUrl="./Xamarin_logo_and_wordmark.png",
					Filename="./Xamarin_logo_and_wordmark.png",
				},
				new ImageWrapper()
				{
					ImageUrl="./icon_xamarin_studio.png",
					Filename="./icon_xamarin_studio.png",
				},
				new ImageWrapper()
				{
					ImageUrl="./image.png",
					Filename="./image.png",
				},
				new ImageWrapper()
				{	
					ImageUrl="./mono_logo.png",
					Filename="./mono_logo.png",
				},
				new ImageWrapper()
				{
					ImageUrl="./xamarin_copy.jpg",
					Filename="./xamarin_copy.jpg",
				},
				new ImageWrapper()
				{
					ImageUrl="./xamarin_authorized_partner_2x.png",
					Filename="./xamarin_authorized_partner_2x.png",
				},
				new ImageWrapper()
				{
					ImageUrl="./xamarin_hexagon_gif.gif",
					Filename="./xamarin_hexagon_gif.gif",
				},
				new ImageWrapper()
				{
					ImageUrl="./xamarin_hexagon.jpg.jpg",
					Filename="./xamarin_hexagon.jpg.jpg",
				},
				new ImageWrapper()
				{
					ImageUrl="./xamarin_hexagon_png.png",
					Filename="./xamarin_hexagon_png.png",
				},
				new ImageWrapper()
				{
					ImageUrl="./xamarin_logo_copy.jpg",
					Filename="./xamarin_logo_copy.jpg",
				},
				new ImageWrapper()
				{
					ImageUrl="./xamarin_logo.jpg",
					Filename="./xamarin_logo.jpg",
				},
				new ImageWrapper()
				{
					ImageUrl="./xamarin_premier_partner_2x.png",
					Filename="./xamarin_premier_partner_2x.png",
				},
				new ImageWrapper()
				{
					ImageUrl="./xamarin_studio.jpeg",
					Filename="./xamarin_studio.jpeg",
				},
				new ImageWrapper()
				{
					ImageUrl="./xamarin_jpg.jpg",
					Filename="./xamarin_jpg.jpg",
				},
				new ImageWrapper()
				{
					ImageUrl="./xamarin_tiff.tiff",
					Filename="./xamarin_tiff.tiff",
				},
				new ImageWrapper()
				{
					ImageUrl="./subfolder/Xamarin_logo_hexagon_blue_200x200.png",
					Filename="./subfolder/Xamarin_logo_hexagon_blue_200x200.png",
				},
				new ImageWrapper()
				{
					ImageUrl="./subfolder/Xamarin_logo_and_wordmark.png",
					Filename="./subfolder/Xamarin_logo_and_wordmark.png",
				},
				new ImageWrapper()
				{
					ImageUrl="./subfolder/icon_xamarin_studio.png",
					Filename="./subfolder/icon_xamarin_studio.png",
				},
				new ImageWrapper()
				{
					ImageUrl="./subfolder/ide_xamarin_studio.png",
					Filename="./subfolder/ide_xamarin_studio.png",
				},
				new ImageWrapper()
				{
					ImageUrl="./subfolder/image.png",
					Filename="./subfolder/image.png",
				},
				new ImageWrapper()
				{
					ImageUrl="./subfolder/mono_logo.png",
					Filename="./subfolder/mono_logo.png",
				},
				new ImageWrapper()
				{
					ImageUrl="./subfolder/xamarin_copy.jpg",
					Filename="./subfolder/xamarin_copy.jpg",
				},
				new ImageWrapper()
				{
					ImageUrl="./subfolder/xamarin_authorized_partner_2x.png",
					Filename="./subfolder/xamarin_authorized_partner_2x.png",
				},
				new ImageWrapper()
				{
					ImageUrl="./subfolder/xamarin_hexagon_gif.gif",
					Filename="./subfolder/xamarin_hexagon_gif.gif",
				},
				new ImageWrapper()
				{
					ImageUrl="./subfolder/xamarin_hexagon.jpg.jpg",
					Filename="./subfolder/xamarin_hexagon.jpg.jpg",
				},
				new ImageWrapper()
				{
					ImageUrl="./subfolder/xamarin_hexagon_png.png",
					Filename="./subfolder/xamarin_hexagon_png.png",
				},
				new ImageWrapper()
				{
					ImageUrl="./subfolder/xamarin_logo_copy.jpg",
					Filename="./subfolder/xamarin_logo_copy.jpg",
				},
				new ImageWrapper()
				{
					ImageUrl="./subfolder/xamarin_logo.jpg",
					Filename="./subfolder/xamarin_logo.jpg",
				},
				new ImageWrapper()
				{
					ImageUrl="./subfolder/xamarin_premier_partner_2x.png",
					Filename="./subfolder/xamarin_premier_partner_2x.png",
				},
				new ImageWrapper()
				{
					ImageUrl="./subfolder/xamarin_studio.jpeg",
					Filename="./subfolder/xamarin_studio.jpeg",
				},
				new ImageWrapper()
				{
					ImageUrl="./subfolder/xamarin_jpg.jpg",
					Filename="./subfolder/xamarin_jpg.jpg",
				},
				new ImageWrapper()
				{
					ImageUrl="./subfolder/xamarin_tiff.tiff",
					Filename="./subfolder/xamarin_tiff.tiff",
				},
			};

			return;
		}







		public static Dictionary<string,string> samples = new Dictionary<string,string>()
		{
			{ 
				"Loading Formats from file sample", 
				"Images.Views.Xaml.PageImagesFormatLoadTest"
			},
			{ 
				"Images as Embedded Resources in Portable Class", 
				"Images.Views.Xaml.PageImagesEmbeddedResources"
			},
			{ 
				"Image defined in Xaml with OnDevice statements", 
				"Images.Views.Xaml.PageImageOnDevice"
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

