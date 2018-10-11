//#addin Cake.Curl
#tool nuget:?package=sharpcompress&version=0.22.0

var TARGET = Argument ("t", Argument ("target", "Default"));

Dictionary<string, string> Externals = new Dictionary<string, string>
{
	{
		"Xamarin.Forms-master.zip",
		"https://github.com/xamarin/Xamarin.Forms/archive/master.zip"
	},
	{
		"Xamarin.Essentials-master.zip",
		"https://github.com/xamarin/Essentials/archive/master.zip"
	},
	{
		"xamarin-forms-samples-master.zip",
		"https://github.com/xamarin/xamarin-forms-samples/archive/master.zip"
	},
	{
		"ConceptDev.xamarin-forms-samples-master.zip",
		"https://github.com/conceptdev/xamarin-forms-samples/archive/master.zip"
	},
	{
		"Xamarin-Samples-master.zip",
		"https://github.com/xamarin/mobile-samples/archive/master.zip"
	},
	{
		"xamarin-forms-book-preview-master.zip",
		"https://github.com/xamarin/xamarin-forms-book-preview/archive/master.zip"
	},
	{
		"charlespetzold-xamarin-forms-samples-master.zip",
		"https://github.com/charlespetzold/xamarin-forms-samples/archive/master.zip"
	},	
	{
		"VervetaCRM-master.zip",
		"https://github.com/xamarin/VervetaCRM/archive/master.zip"
	},
	{
		"Xamarin-Forms-Labs-master.zip",
		"https://github.com/XLabs/Xamarin-Forms-Labs/archive/master.zip"
	},
	{
		"Xamarin-Forms-Labs-Samples-master.zip",
		"https://github.com/XLabs/Xamarin-Forms-Labs-Samples/archive/master.zip"
	},
	{
		"Hanselman.Forms-master.zip",
		"https://github.com/jamesmontemagno/Hanselman.Forms/archive/master.zip"
	},
	{
		"Xamarin.Plugins-master.zip",
		"https://github.com/jamesmontemagno/Xamarin.Plugins/archive/master.zip"
	},
	{
		"xamarin-forms-page-transitions-master.zip",
		"https://github.com/jsuarezruiz/xamarin-forms-page-transitions/archive/master.zip"
	},
	{
		"Rg.Plugins.Popup-master.zip",
		"https://github.com/rotorgames/Rg.Plugins.Popup/archive/master.zip"
	},	
	{
		"Xamarin.Mobile-master.zip",
		"https://github.com/xamarin/Xamarin.Mobile/archive/master.zip"
	},
	{
		"PulseMusic-master.zip",
		"https://github.com/jsuarezruiz/PulseMusic/archive/master.zip"
	},
	{
		"xamarin-forms-walkthrough-master.zip",
		"https://github.com/jsuarezruiz/xamarin-forms-walkthrough/archive/master.zip"
	},
	{
		"xamarin-forms-gtk-movies-sample-master.zip",
		"https://github.com/jsuarezruiz/xamarin-forms-gtk-movies-sample/archive/master.zip"
	},
	{
		"xamarin-forms-netflix-sample-master.zip",
		"https://github.com/jsuarezruiz/xamarin-forms-netflix-sample/archive/master.zip"
	},
	{
		"xamarin-forms-gui.cs-master.zip",
		"https://github.com/jsuarezruiz/xamarin-forms-gui.cs/archive/master.zip"
	},
	{
		"MyTripCountdown-master.zip",
		"https://github.com/jsuarezruiz/MyTripCountdown/archive/master.zip"
	},
	{
		"awesome-xamarin-forms-master.zip",
		"https://github.com/jsuarezruiz/awesome-xamarin-forms/archive/master.zip"
	},
	{
		"xamarin-forms-gtk-samples-master.zip",
		"https://github.com/jsuarezruiz/xamarin-forms-gtk-samples/archive/master.zip"
	},
	{
		"KickassUI.ParallaxCarousel-master.zip",
		"https://github.com/sthewissen/KickassUI.ParallaxCarousel/archive/master.zip"
	},
	{
		"ConferenceVision-master.zip",
		"https://github.com/Microsoft/ConferenceVision/archive/master.zip"
	},
	{
		"SmartHotel360-mobile-desktop-apps-master.zip",
		"https://github.com/Microsoft/SmartHotel360-mobile-desktop-apps/archive/master.zip"
	},
	{
		"BikeSharing360_MobileApps-master.zip",
		"https://github.com/Microsoft/BikeSharing360_MobileApps/archive/master.zip"
	},
	{
		"Microcharts.Samples-master.zip",
		"https://github.com/aloisdeniel/Microcharts.Samples/archive/master.zip"
	},
	{
		"KickassUI.Runkeeper-master.zip",
		"https://github.com/sthewissen/KickassUI.Runkeeper/archive/master.zip"
	},
	{
		"xamarin-forms-interfaces-master.zip",
		"https://github.com/ionixjunior/xamarin-forms-interfaces/archive/master.zip"
	},
	{
		"KickassUI.Twitter-master.zip",
		"https://github.com/sthewissen/KickassUI.Twitter/archive/master.zip"
	},
	{
		"SkyAdventures-master.zip",
		"https://github.com/leroygumede/SkyAdventures/archive/master.zip"
	},
	{
		"Xamarin-Forms-InAnger-master.zip",
		"https://github.com/awolf/Xamarin-Forms-InAnger/archive/master.zip"
	},
	{
		"kphillpotts-master.zip",
		"https://github.com/kphillpotts/XamarinFormsLayoutChallenges/archive/master.zip"
	},
	{
		"winstongubantes-master.zip",
		"https://github.com/winstongubantes/Xamarin.Forms/archive/master.zip"
	},
	{
		"Snppts.Foodies-master.zip",
		"https://github.com/snpptsio/Snppts.Foodies/archive/master.zip"
	},
	{
		"Xamarin.Forms.UI-master.zip",
		"https://github.com/CrossGeeks/Xamarin.Forms.UI/archive/master.zip"
	},
	{
		"Layout-master.zip",
		"https://github.com/cacaxiq/Layout/archive/master.zip"
	},
	{
		"WelcomeCarousel-master.zip",
		"https://github.com/leroygumede/WelcomeCarousel/archive/master.zip"
	},
	{
		"AsyncAwaitBestPractices-master.zip",
		"https://github.com/brminnick/AsyncAwaitBestPractices/archive/master.zip"
	},
	{
		"Prism-Samples-Forms-master.zip",
		"https://github.com/PrismLibrary/Prism-Samples-Forms/archive/master.zip"
	},
	{
		"Gastropods-master.zip",
		"https://github.com/davidortinau/Gastropods/archive/master.zip"
	},
	{
		"TheLittleThingsPlayground-master.zip",
		"https://github.com/davidortinau/TheLittleThingsPlayground/archive/master.zip"
	},
	{
		"eShopOnContainers-2.0.7.zip",
		"https://github.com/dotnet-architecture/eShopOnContainers/archive/2.0.7.zip"
	},
	// {
	// 	"-master.zip",
	// 	""
	// },
};

Task("externals")
	.Does
	(
		() =>
		{
			EnsureDirectoryExists("./externals/");
			foreach(KeyValuePair<string, string> url in Externals)
			{
				if (!FileExists($"./externals/{url.Key}"))
				{
					Information ($"DownloadFile(${url.Value}, $''./externals/{url.Key}'');");
					DownloadFile(url.Value, $"./externals/{url.Key}");

					// CurlDownloadFile
					// 	(
					// 		new Uri(url.Value),
					// 		new CurlDownloadSettings
					// 		{
					// 			OutputPaths = new FilePath[] { $"./externals/{url.Key}" }
					// 		}
					// 	);
				}
				try
				{
					//Information ($"Unzip (``{./externals/{url.Key}'', ${./externals/});");
					Unzip ($"./externals/{url.Key}", $"./externals/");
				}
				catch (System.Exception exc)
				{
					Error ($"exception : {exc?.Message}");
				}
			}
		}
	);

RunTarget ("externals");

