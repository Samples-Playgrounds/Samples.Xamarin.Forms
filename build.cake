//#addin Cake.Curl
#tool nuget:?package=sharpcompress&version=0.22.0

var TARGET = Argument ("t", Argument ("target", "Default"));

Dictionary<string, string> Externals = new Dictionary<string, string>
{
	{
		"Xamarin.Forms-master",
		"https://github.com/xamarin/Xamarin.Forms/archive/master.zip"
	},
	{
		"Xamarin.Essentials-master",
		"https://github.com/xamarin/Essentials/archive/master.zip"
	},
	{
		"xamarin-xamarin-forms-samples-master",
		"https://github.com/xamarin/xamarin-forms-samples/archive/master.zip"
	},
	{
		"conceptdev-xamarin-forms-samples-master",
		"https://github.com/conceptdev/xamarin-forms-samples/archive/master.zip"
	},
	{
		"charlespetzold-xamarin-forms-samples-master",
		"https://github.com/charlespetzold/xamarin-forms-samples/archive/master.zip"
	},	
	{
		"mobile-samples-master",
		"https://github.com/xamarin/mobile-samples/archive/master.zip"
	},
	{
		"xamarin-forms-book-preview-master",
		"https://github.com/xamarin/xamarin-forms-book-preview/archive/master.zip"
	},
	{
		"VervetaCRM-master",
		"https://github.com/xamarin/VervetaCRM/archive/master.zip"
	},
	{
		"Xamarin-Forms-Labs-master",
		"https://github.com/XLabs/Xamarin-Forms-Labs/archive/master.zip"
	},
	{
		"Xamarin-Forms-Labs-Samples-master",
		"https://github.com/XLabs/Xamarin-Forms-Labs-Samples/archive/master.zip"
	},
	{
		"Hanselman.Forms-master",
		"https://github.com/jamesmontemagno/Hanselman.Forms/archive/master.zip"
	},
	{
		"Xamarin.Plugins-master",
		"https://github.com/jamesmontemagno/Xamarin.Plugins/archive/master.zip"
	},
	{
		"xamarin-forms-page-transitions-master",
		"https://github.com/jsuarezruiz/xamarin-forms-page-transitions/archive/master.zip"
	},
	{
		"Rg.Plugins.Popup-master",
		"https://github.com/rotorgames/Rg.Plugins.Popup/archive/master.zip"
	},	
	{
		"Xamarin.Mobile-master",
		"https://github.com/xamarin/Xamarin.Mobile/archive/master.zip"
	},
	{
		"PulseMusic-master",
		"https://github.com/jsuarezruiz/PulseMusic/archive/master.zip"
	},
	{
		"xamarin-forms-walkthrough-master",
		"https://github.com/jsuarezruiz/xamarin-forms-walkthrough/archive/master.zip"
	},
	{
		"xamarin-forms-gtk-movies-sample-master",
		"https://github.com/jsuarezruiz/xamarin-forms-gtk-movies-sample/archive/master.zip"
	},
	{
		"xamarin-forms-netflix-sample-master",
		"https://github.com/jsuarezruiz/xamarin-forms-netflix-sample/archive/master.zip"
	},
	{
		"xamarin-forms-gui.cs-master",
		"https://github.com/jsuarezruiz/xamarin-forms-gui.cs/archive/master.zip"
	},
	{
		"MyTripCountdown-master",
		"https://github.com/jsuarezruiz/MyTripCountdown/archive/master.zip"
	},
	{
		"awesome-xamarin-forms-master",
		"https://github.com/jsuarezruiz/awesome-xamarin-forms/archive/master.zip"
	},
	{
		"xamarin-forms-gtk-samples-master",
		"https://github.com/jsuarezruiz/xamarin-forms-gtk-samples/archive/master.zip"
	},
	{
		"KickassUI.ParallaxCarousel-master",
		"https://github.com/sthewissen/KickassUI.ParallaxCarousel/archive/master.zip"
	},
	{
		"ConferenceVision-master",
		"https://github.com/Microsoft/ConferenceVision/archive/master.zip"
	},
	{
		"SmartHotel360-mobile-desktop-apps-master",
		"https://github.com/Microsoft/SmartHotel360-mobile-desktop-apps/archive/master.zip"
	},
	{
		"BikeSharing360_MobileApps-master",
		"https://github.com/Microsoft/BikeSharing360_MobileApps/archive/master.zip"
	},
	{
		"Microcharts.Samples-master",
		"https://github.com/aloisdeniel/Microcharts.Samples/archive/master.zip"
	},
	{
		"KickassUI.Runkeeper-master",
		"https://github.com/sthewissen/KickassUI.Runkeeper/archive/master.zip"
	},
	{
		"xamarin-forms-interfaces-master",
		"https://github.com/ionixjunior/xamarin-forms-interfaces/archive/master.zip"
	},
	{
		"KickassUI.Twitter-master",
		"https://github.com/sthewissen/KickassUI.Twitter/archive/master.zip"
	},
	{
		"SkyAdventures-master",
		"https://github.com/leroygumede/SkyAdventures/archive/master.zip"
	},
	{
		"Xamarin-Forms-InAnger-master",
		"https://github.com/awolf/Xamarin-Forms-InAnger/archive/master.zip"
	},
	{
		"kphillpotts-master",
		"https://github.com/kphillpotts/XamarinFormsLayoutChallenges/archive/master.zip"
	},
	{
		"winstongubantes-master",
		"https://github.com/winstongubantes/Xamarin.Forms/archive/master.zip"
	},
	{
		"Snppts.Foodies-master",
		"https://github.com/snpptsio/Snppts.Foodies/archive/master.zip"
	},
	{
		"Xamarin.Forms.UI-master",
		"https://github.com/CrossGeeks/Xamarin.Forms.UI/archive/master.zip"
	},
	{
		"Layout-master",
		"https://github.com/cacaxiq/Layout/archive/master.zip"
	},
	{
		"WelcomeCarousel-master",
		"https://github.com/leroygumede/WelcomeCarousel/archive/master.zip"
	},
	{
		"AsyncAwaitBestPractices-master",
		"https://github.com/brminnick/AsyncAwaitBestPractices/archive/master.zip"
	},
	{
		"Prism-Samples-Forms-master",
		"https://github.com/PrismLibrary/Prism-Samples-Forms/archive/master.zip"
	},
	{
		"Gastropods-master",
		"https://github.com/davidortinau/Gastropods/archive/master.zip"
	},
	{
		"TheLittleThingsPlayground-master",
		"https://github.com/davidortinau/TheLittleThingsPlayground/archive/master.zip"
	},
	{
		"eShopOnContainers-2.0.7",
		"https://github.com/dotnet-architecture/eShopOnContainers/archive/2.0.7.zip"
	},
	// {
	// 	"-master",
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
					Information ($"DownloadFile(${url.Value}.zip, ./externals/{url.Key});");
					DownloadFile($"{url.Value}", $"./externals/{url.Key}.zip");

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
					Information ($"Unzip (./externals/{url.Key}.zip, ./externals/);");
					Unzip ($"./externals/{url.Key}.zip", $"./externals/{url.Key}");
				}
				catch (System.Exception exc)
				{
					Error ($"exception : {exc?.Message}");
				}
			}
		}
	);

RunTarget ("externals");

