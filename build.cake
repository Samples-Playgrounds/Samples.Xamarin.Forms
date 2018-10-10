
var TARGET = Argument ("t", Argument ("target", "Default"));

Dictionary<string, string> Externals = new Dictionary<string, string>
{
	{
		"eShopOnContainers-2.0.7.zip",
		"https://github.com/dotnet-architecture/eShopOnContainers/archive/2.0.7.zip"
	},
	{
		"Xamarin.Forms-master.zip",
		"https://github.com/xamarin/Xamarin.Forms/archive/master.zip"
	},
	{
		"Xamarin.Essentials-master.zip",
		"https://github.com/xamarin/Essentials/archive/master.zip"
	},
	{
		"Xamarin.Forms.Samples-master.zip",
		"https://github.com/xamarin/xamarin-forms-samples/archive/master.zip"
	},
	{
		"ConceptDev.Xamarin.Forms.Samples-master.zip",
		"https://github.com/conceptdev/xamarin-forms-samples/archive/master.zip"
	},
	{
		"Xamarin-Samples-master.zip",
		"https://github.com/xamarin/mobile-samples/archive/master.zip"
	},
	/* 
	{
		"",
		"https://github.com/xamarin/xamarin-forms-book-preview/archive/master.zip"
	},
	https://github.com/charlespetzold/xamarin-forms-samples/archive/master.zip
	{
		"",
		"https://github.com/xamarin/VervetaCRM/archive/master.zip"
	},
	{
		"",
		"https://github.com/XLabs/Xamarin-Forms-Labs/archive/master.zip"
	},
	{
		"",
		"https://github.com/XLabs/Xamarin-Forms-Labs-Samples/archive/master.zip"
	},
	{
		"",
		"https://github.com/jamesmontemagno/Hanselman.Forms/archive/master.zip"
	},
	{
		"",
		"https://github.com/jamesmontemagno/Xamarin.Plugins/archive/master.zip"
	},
	{
		"",
		"https://github.com/jsuarezruiz/xamarin-forms-page-transitions/archive/master.zip"
	},
	{
		"",
		"https://github.com/rotorgames/Rg.Plugins.Popup/archive/master.zip"
	},	
	{
		"Xamarin.Mobile-master.zip",
		"https://github.com/xamarin/Xamarin.Mobile/archive/master.zip"
	},

	https://github.com/jsuarezruiz/awesome-xamarin-forms/archive/master.zip
	https://github.com/jsuarezruiz/MyTripCountdown/archive/master.zip
	https://github.com/jsuarezruiz/xamarin-forms-gui.cs/archive/master.zip
	https://github.com/jsuarezruiz/xamarin-forms-netflix-sample/archive/master.zip
	https://github.com/jsuarezruiz/xamarin-forms-gtk-movies-sample/archive/master.zip
	https://github.com/jsuarezruiz/xamarin-forms-walkthrough/archive/master.zip
	https://github.com/jsuarezruiz/PulseMusic/archive/master.zip
	https://github.com/jsuarezruiz/xamarin-forms-gtk-samples/archive/master.zip
	https://github.com/sthewissen/KickassUI.ParallaxCarousel/archive/master.zip
	https://github.com/Microsoft/ConferenceVision/archive/master.zip
	https://github.com/Microsoft/SmartHotel360-mobile-desktop-apps/archive/master.zip
	https://github.com/Microsoft/BikeSharing360_MobileApps/archive/master.zip
	https://github.com/aloisdeniel/Microcharts.Samples/archive/master.zip
	https://github.com/sthewissen/KickassUI.Runkeeper/archive/master.zip
	https://github.com/ionixjunior/xamarin-forms-interfaces/archive/master.zip
	https://github.com/sthewissen/KickassUI.Twitter/archive/master.zip
	https://github.com/leroygumede/SkyAdventures/archive/master.zip
	https://github.com/awolf/Xamarin-Forms-InAnger/archive/master.zip
	https://github.com/kphillpotts/XamarinFormsLayoutChallenges/archive/master.zip
	https://github.com/winstongubantes/Xamarin.Forms/archive/master.zip
	https://github.com/snpptsio/Snppts.Foodies/archive/master.zip
	https://github.com/CrossGeeks/Xamarin.Forms.UI/archive/master.zip
	https://github.com/cacaxiq/Layout/archive/master.zip
	https://github.com/leroygumede/WelcomeCarousel/archive/master.zip
	https://github.com/brminnick/AsyncAwaitBestPractices/archive/master.zip
	https://github.com/PrismLibrary/Prism-Samples-Forms/archive/master.zip
	https://github.com/davidortinau/Gastropods/archive/master.zip
	https://github.com/davidortinau/TheLittleThingsPlayground/archive/master.zip
	*/
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
					DownloadFile(url.Value, $"./externals/{url.Key}");
				}
				Unzip ($"./externals/{url.Key}", $"./externals/{url.Key}.unzipped");
			}
		}
	);

RunTarget ("externals");
