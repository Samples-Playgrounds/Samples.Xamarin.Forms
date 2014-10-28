# Xamarin.Forms Samples

Samples and cheat-sheet for working with Xamarin.Forms

*	[http://iosapi.xamarin.com/?link=root:/Xamarin.Forms](http://iosapi.xamarin.com/?link=root:/Xamarin.Forms)
*	[http://iosapi.xamarin.com/?link=N%3aXamarin.Forms](http://iosapi.xamarin.com/?link=N%3aXamarin.Forms)
*	[http://iosapi.xamarin.com/?link=N%3aXamarin.Forms.Xaml](http://iosapi.xamarin.com/?link=N%3aXamarin.Forms.Xaml)

4 applications:

1.	ControlsViews	
	showing basic Views (Controls, Widgest) 		
	xaml and code
2.	ControlsViewsMap	
	*	Map is special form of View	(Control, Widget)	
	*	located in Xamarin.Forms.Map nuget package		
	*	[http://iosapi.xamarin.com/?link=N%3aXamarin.Forms.Maps]](http://iosapi.xamarin.com/?link=N%3aXamarin.Forms.Maps)
3.	Layouts		
	xaml and code			
4.	Pages
	xaml and code			
		

## Installation

### Xamarin.Forms.Map
	
	Get-Project ControlsViewsMap 			| Install-Package Xamarin.Forms.Maps
	Get-Project ControlsViewsMap.iOS		| Install-Package Xamarin.Forms.Maps
	Get-Project ControlsViewsMap.Android 	| Install-Package Xamarin.Forms.Maps
	Get-Project ControlsViewsMap.WinPhone 	| Install-Package Xamarin.Forms.Maps

	Get-Project Project1,Project2,Project3	| Install-Package Xamarin.Forms.Maps
	
	Install-Package Xamarin.Forms.Map -Project ControlsViewsMap
	Install-Package Xamarin.Forms.Map -Project ControlsViewsMap.iOS
	Install-Package Xamarin.Forms.Map -Project ControlsViewMap.Android
	Install-Package Xamarin.Forms.Map -Project ControlsViewsMap.WindowsPhone
	
		
Note: Terms Control and View used interchangeable in docs.

The term Control is used mostly by Windows/WPF/Silverlight/WindowsPhone devs, while Views by Android and iOS devs.

In Xamarin.Forms all Views/Controls derive from Xamarin.Forms.View.

## Demo flow

1.	Archiecture / Project Structure
	1.	New Project: Mobile Apps
	2.	IDE
		1.	Visual Studio (if possible)
		2.	Xamarin Studio
	3.	PCL
	4.	Entry Points structure
2.	UI
	1.	Views / Controls
		1.	Device.OnPlatform
		2.	Visual Studio (if possible)
		3.	Xamarin Studio
	2.	Layouts
		1.	ContentView
		2.	ContentView as reusable UserControl
		3.	StackLayout
		2.	Grid
		3.	RelativeLayout
		4.	AbsoluteLayout
		5. 	
	3.	Pages
		1.	ContentPage
		2.	CarouselPage
		3.	TabbedPage
3.	Platform Specific
	1.	Device class
		1.	OnPlatform()
	2.	Dependency Service
		1.	shared in PCL
			1.	Interface
			2.	Location (DependencyService.Get<>)
		2.	Platform Specific
			1.	Android
				1.	Permissions / Entitlements / Capabilities
				2.	Android.Bluetooth.*



## Structure

1.	Controls/Views samples
	simple samples in XAML and code for
2.	Layouts
	[]()
3.	Pages
	[http://developer.xamarin.com/guides/cross-platform/xamarin-forms/controls/pages/](http://developer.xamarin.com/guides/cross-platform/xamarin-forms/controls/pages/)
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
*	Introducton			
	[http://developer.xamarin.com/guides/cross-platform/xamarin-forms/introduction-to-xamarin-forms/#Using_XAML_to_Create_and_Customize_A_List](http://developer.xamarin.com/guides/cross-platform/xamarin-forms/introduction-to-xamarin-forms/#Using_XAML_to_Create_and_Customize_A_List)
*	Xamarin Forms Labs			
	[https://github.com/XForms/Xamarin-Forms-Labs](https://github.com/XForms/Xamarin-Forms-Labs)


## Some tricks


### No embeddedresources found for <SomePageInXaml>

#### Problem : Error No embeddedresources found for <SomePageInXaml>

Sample:

	Xamarin.Forms.Xaml.XamlParseException: No embeddedresources found for ControlsViews.PageMain
	  at at Xamarin.Forms.Xaml.XamlLoader.Load (Xamarin.Forms.VisualElement,System.Type) <il 0x0002a, 0x00103>
		at at Xamarin.Forms.Xaml.Extensions.LoadFromXaml<controlsviews.pagemain>
			(ControlsViews.PageMain,System.Type) <0x0002f>
				at ControlsViews.PageMain.InitializeComponent () [0x0000c] in /Samples.XamarinForms/ControlsViews/ControlsViews/obj/Debug/PageMain.xaml.g.cs:24
				at ControlsViews.PageMain..ctor () [0x00008] in /Samples.XamarinForms/ControlsViews/ControlsViews/PageMain.xaml.cs:13
				at ControlsViews.App.GetMainPage () [0x00001] in /Samples.XamarinForms/ControlsViews/ControlsViews/App.cs:14
				at ControlsViews.Droid.MainActivity.OnCreate (Android.OS.Bundle) [0x00010] in /Samples.XamarinForms/ControlsViews/ControlsViews.Android/MainActivity.cs:23
				at Android.App.Activity.n_OnCreate_Landroid_os_Bundle_ (intptr,intptr,intptr) [0x00011] in /Users/builder/data/lanes/1131/2a7b6821/source/monodroid/src/Mono.Android/platforms/android-19/src/generated/Android.App.Activity.cs:2179
				at at (wrapper dynamic-method) object.bf3e2470-ec35-4e97-aeb2-ff6fa6870e02 (intptr,intptr,intptr) <il 0x00017, 0x0001f>

#### Analysis

Locked bin/  obj/ folders. 

#### [Re]Solution

Delete manually or add pre-build MSBuild action in csproj file:

	  <Target Name="RemoveObjAndBin" AfterTargets="Clean">
	    <RemoveDir Directories="$(BaseIntermediateOutputPath)" />
	    <RemoveDir Directories="$(TargetDir)" />
	  </Target>
	  <Target Name="BeforeBuild">
	    <!-- Remove obj folder -->
	    <RemoveDir Directories="$(BaseIntermediateOutputPath)" />
	    <!-- Remove bin folder -->
	    <RemoveDir Directories="$(BaseOutputPath)" />
	  </Target>	

Caveat: WinPhone projects might have obj/ folder locked if iOS simulator or Android emulators are running on MacOSX.



### Error: This project references NuGet package(s) that are missing on this computer.

#### Problem

Error: This project references NuGet package(s) that are missing on this computer.


	/Samples.XamarinForms/Controls/Controls/Controls.csproj:
	Error: This project references NuGet package(s) that are missing on this computer.
	Enable NuGet Package Restore to download them.  For more information,
	see http://go.microsoft.com/fwlink/?LinkID=322105.
	The missing file is ../../packages/Xamarin.Forms.1.0.6186/build/portable-win+net45+wp80+MonoAndroid10+MonoTouch10/Xamarin.Forms.targets.
	(Controls)

#### Analysis

Something went wrong with package update/restore. Probably locked folders from Virtual Machine (not sure)


#### [Re]Solution

1.	Nuke nuget packages/ folder		
2.	Replace version (1.0.6186) in csproj file with one in packages/ folder (.1.2.2.6243).		

	../../packages/Xamarin.Forms.1.2.2.6243/build/portable-win+net45+wp80+MonoAndroid10+MonoTouch10/Xamarin.Forms.targets. (Controls)



### "Object type Xamarin.Forms.TextCell cannot be converted to target type: Xamarin.Forms.View"

#### Problem

Runtime error: "Object type Xamarin.Forms.TextCell cannot be converted to target type: Xamarin.Forms.View"

				<TableView>
				<TableRoot>
				<TableSection Title="Test">
				<Text
				Cell Text="Test"></TextCell>
			</TableSection>
				</TableRoot>
	</TableView>
				

todo: Picker sample


### Property Content is null or is not IEnumerable

	Xamarin.Forms.Xaml.XamlParseException: Position 14:3. Property Content is null or is not IEnumerable
	at at Xamarin.Forms.Xaml.ListNode.ApplyTo (object,Xamarin.Forms.Xaml.XmlName,bool) <IL 0x00132, 0x0093b>
	at at Xamarin.Forms.Xaml.INodeExtensio<il 0x00132, 0x0093b>
		at at Xamarin.Forms.Xaml.INodeExtension.ApplyProperties (Xamarin.Forms.Xaml.IElementNode,object,bool) <il 0x00049, 0x00348>
			at at Xamarin.Forms.Xaml.RootNode.ApplyProperties (bool) <il 0x00008, 0x0004b>
				at at Xamarin.Forms.Xaml.XamlLoader.Load (Xamarin.Forms.VisualElement,string) <il 0x00069, 0x00263>
					at at Xamarin.Forms.Xaml.XamlLoader.Load (Xamarin.Forms.VisualElement,System.Type) <il 0x0002d, 0x0011b>
						at at Xamarin.Forms.Xaml.Extensions.LoadFromXaml<controlsviews.pagetableviewinxaml>
							(ControlsViews.PageTableViewInXaml,System.Type) <0x0002f>
								at ControlsViews.PageTableViewInXaml.InitializeComponent () [0x0000c] in /Samples.Xamarin.Forms/tutorial-samples/ControlsViews/ControlsViews/obj/Debug/PageTableViewInXaml.xaml.g.cs:22
								at ControlsViews.PageTableViewInXaml..ctor () [0x00008] in /Samples.Xamarin.Forms/tutorial-samples/ControlsViews/ControlsViews/PageTableViewInXaml.xaml.cs:13
								at ControlsViews.PageMain.buttonTableViewInXaml_Clicked (object,System.EventArgs) [0x00007] in /Samples.Xamarin.Forms/tutorial-samples/ControlsViews/ControlsViews/PageMain.xaml.cs:36
								at at Xamarin.Forms.Button.SendClicked () <il 0x00027, 0x000c2>
									at at Xamarin.Forms.Platform.Android.ButtonRenderer/ButtonClickListener.OnClick (Android.Views.View) <il 0x00015, 0x000a7>
										at Android.Views.View/IOnClickListenerInvoker.n_OnClick_Landroid_view_View_ (intptr,intptr,intptr) [0x00011] in /Users/builder/data/lanes/1131/2a7b6821/source/monodroid/src/Mono.Android/platforms/android-19/src/generated/Android.Views.View.cs:1840
										at at (wrapper dynamic-method) object.c02f3264-e236-45c6-a92c-b6e70c81d30f (intptr,intptr,intptr) <il 0x00017, 0x0001f>


#### Analysis

2 Views (Tables not in StackPanel)

TODO: Sample


#### [Re]Solution

Wrap more than 1 View/Control into Layouts

TODO: Sample



### Data Binding

*	[http://forums.xamarin.com/discussion/18873/can-the-tableview-have-multiple-headers]()http://forums.xamarin.com/discussion/18873/can-the-tableview-have-multiple-headers
*	[http://forums.xamarin.com/discussion/18475/is-it-possible-to-use-a-tableview-listview-to-function-similar-to-a-gridview](http://forums.xamarin.com/discussion/18475/is-it-possible-to-use-a-tableview-listview-to-function-similar-to-a-gridview)
*	[]()






Error	2	
Deployment failed because an app with target platform ARM cannot be deployed to Emulator WVGA 512MB. 
If the target platform is win32/ x86, select an emulator. If the target platform is ARM, select Device.		
0	0	


System.Reflection.TargetInvocationException was unhandled
Message: An unhandled exception of type 'System.Reflection.TargetInvocationException' occurred in System.Windows.ni.dll
Additional information: Exception has been thrown by the target of an invocation.

