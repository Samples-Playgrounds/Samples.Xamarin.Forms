# Xamarin.Forms Samples

Note: Terms Control and View used interchangeable in docs.

The term Control is used mostly by Windows/WPF/Silverlight/WindowsPhone devs, while Views by Android and iOS devs.

In Xamarin.Forms all Views/Controls derive from Xamarin.Forms.View.


## Structure

1.	Controls/Views samples
	simple samples in XAML and code for
2.	Layouts
3.	Pages
4.	Platform Specific stuff
	1.	Platform class
	2.	Dependency Service
	3.	Custom Controls (Views) with Custom Renderers
	4.	Messaging Service


## References

*	Conceptual docs:
	[http://developer.xamarin.com/guides/cross-platform/xamarin-forms/introduction-to-xamarin-forms/](http://developer.xamarin.com/guides/cross-platform/xamarin-forms/introduction-to-xamarin-forms/)
*	Api docs:
	[http://iosapi.xamarin.com/?link=N:Xamarin.Forms](http://iosapi.xamarin.com/?link=N:Xamarin.Forms)
*	University class:
	[https://university.xamarin.com/classes/intro-to-xamarinforms-xam120](https://university.xamarin.com/classes/intro-to-xamarinforms-xam120)
*	Prebuilt app:
	[https://github.com/xamarin/xamarin-forms-samples/tree/master/MobileCRM](https://github.com/xamarin/xamarin-forms-samples/tree/master/MobileCRM)
*	Samples repo:
	[https://github.com/xamarin/xamarin-forms-samples](https://github.com/xamarin/xamarin-forms-samples)
*	XAML for Xamarin.Forms by Charles Petzold, including new Xaml samples
	[http://developer.xamarin.com/guides/cross-platform/xamarin-forms/xaml-for-xamarin-forms/](http://developer.xamarin.com/guides/cross-platform/xamarin-forms/xaml-for-xamarin-forms/)
*	added more Xaml to the Xamarin.Forms samples on GitHub.



## Some tricks

Xamarin.Forms.Xaml.XamlParseException: No embeddedresources found for ControlsViews.PageMain
  at at Xamarin.Forms.Xaml.XamlLoader.Load (Xamarin.Forms.VisualElement,System.Type) <il 0x0002a, 0x00103>
	at at Xamarin.Forms.Xaml.Extensions.LoadFromXaml<controlsviews.pagemain>
		(ControlsViews.PageMain,System.Type) <0x0002f>
			at ControlsViews.PageMain.InitializeComponent () [0x0000c] in /Users/moljac/Projects/Samples/Samples.XamarinForms/ControlsViews/ControlsViews/obj/Debug/PageMain.xaml.g.cs:24
			at ControlsViews.PageMain..ctor () [0x00008] in /Users/moljac/Projects/Samples/Samples.XamarinForms/ControlsViews/ControlsViews/PageMain.xaml.cs:13
			at ControlsViews.App.GetMainPage () [0x00001] in /Users/moljac/Projects/Samples/Samples.XamarinForms/ControlsViews/ControlsViews/App.cs:14
			at ControlsViews.Droid.MainActivity.OnCreate (Android.OS.Bundle) [0x00010] in /Users/moljac/Projects/Samples/Samples.XamarinForms/ControlsViews/ControlsViews.Android/MainActivity.cs:23
			at Android.App.Activity.n_OnCreate_Landroid_os_Bundle_ (intptr,intptr,intptr) [0x00011] in /Users/builder/data/lanes/1131/2a7b6821/source/monodroid/src/Mono.Android/platforms/android-19/src/generated/Android.App.Activity.cs:2179
			at at (wrapper dynamic-method) object.bf3e2470-ec35-4e97-aeb2-ff6fa6870e02 (intptr,intptr,intptr) <il 0x00017, 0x0001f>









				/Users/moljac/Projects/Samples/Samples.XamarinForms/Controls/Controls/Controls.csproj:
				Error: This project references NuGet package(s) that are missing on this computer.
				Enable NuGet Package Restore to download them.  For more information,
				see http://go.microsoft.com/fwlink/?LinkID=322105.
				The missing file is ../../packages/Xamarin.Forms.1.0.6186/build/portable-win+net45+wp80+MonoAndroid10+MonoTouch10/Xamarin.Forms.targets.
				(Controls)


				Replace version in csproj file with one in packages/ folder

				../../packages/Xamarin.Forms.1.2.2.6243/build/portable-win+net45+wp80+MonoAndroid10+MonoTouch10/Xamarin.Forms.targets. (Controls)
