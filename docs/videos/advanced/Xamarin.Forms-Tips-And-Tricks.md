# Xamarin.Forms problems


## The name `InitializeComponent' does not exist in the current context (CS0103) 

### Error: No embeddedresources found for <PageName>

### Error:


	Xamarin.Forms.Xaml.XamlParseException: No embeddedresources found for PlatformSpecific.DependencyService.PageMain
	  at at Xamarin.Forms.Xaml.XamlLoader.Load (Xamarin.Forms.BindableObject,System.Type) <IL 0x0002a, 0x00103>
	  at at Xamarin.Forms.Xaml.Extensions.LoadFromXaml<PlatformSpecific.DependencyService.PageMain> (PlatformSpecific.DependencyService.PageMain,System.Type) <0x0002f>
	  at PlatformSpecific.DependencyService.PageMain.InitializeComponent () [0x0000c] in /Users/moljac/Projects/Samples/Samples.Xamarin.Forms/tutorial-samples/PlatformSpecific/DependencyService/Sample/PlatformSpecific.DependencyService/obj/Debug/PageMain.xaml.g.cs:28
	  at PlatformSpecific.DependencyService.PageMain..ctor () [0x00008] in /Users/moljac/Projects/Samples/Samples.Xamarin.Forms/tutorial-samples/PlatformSpecific/DependencyService/Sample/PlatformSpecific.DependencyService/PageMain.xaml.cs:15
	  at PlatformSpecific.DependencyService.App..ctor () [0x00008] in /Users/moljac/Projects/Samples/Samples.Xamarin.Forms/tutorial-samples/PlatformSpecific/DependencyService/Sample/PlatformSpecific.DependencyService/App.cs:17
	  at PlatformSpecific.DependencyService.Droid.MainActivity.OnCreate (Android.OS.Bundle) [0x00010] in /Users/moljac/Projects/Samples/Samples.Xamarin.Forms/tutorial-samples/PlatformSpecific/DependencyService/Sample/PlatformSpecific.DependencyService.Android/MainActivity.cs:29
	  at Android.App.Activity.n_OnCreate_Landroid_os_Bundle_ (intptr,intptr,intptr) [0x00011] in /Users/builder/data/lanes/monodroid-mlion-monodroid-4.20-series/ba9bbbdd/source/monodroid/src/Mono.Android/platforms/android-19/src/generated/Android.App.Activity.cs:2179
	  at at (wrapper dynamic-method) object.8033be6d-1a0c-43cb-a348-3a3923e99b14 (intptr,intptr,intptr) <IL 0x00017, 0x0001f>


##### Analysis

This error occurs when renaming classnames or namespaces in Xaml.
 

##### [Re]Solution/Workaround

Delete/remove bin and obj/ folders in projects both 

*	portable 
*	platform specific

After solving this error user might find out further errors in Xaml.


### Error

	PageAudioRecorder.xaml.cs(4,4): 
		Error CS0103: 
		The name `InitializeComponent' does not exist in the current context (CS0103) 
		(PlatformSpecific.DependencyService)

### Cause[s]:
	
#### Case 01	

##### Analysis

Look for xaml in csproj:

Cause:

	<ItemGroup>
		<None Include="FeaturesCapabilities\MultiMedia\Audio\PageAudioRecorder.xaml" />
	</ItemGroup>

	<!-- ..... -->
	
	<Compile Include="FeaturesCapabilities\MultiMedia\Audio\PageAudioRecorder.xaml.cs" />

Sometimes:

Cause:

  <EmbeddedResource Include="$(MSBuildThisFileDirectory)Pages\myWorkingForm.xaml"> 
    <SubType>Designer</SubType> 
    <Generator>MSBuild:UpdateDesignTimeXaml</Generator> 
  </EmbeddedResource> 
  <Page Include="$(MSBuildThisFileDirectory)Pages\TestForm.xaml"> 
    <SubType>Designer</SubType> 
    <Generator>MSBuild:Compile</Generator> 
  </Page> 


	
##### [Re]Solution/Workaround

*	XAML file 
	*	Build Action = EmbeddedResource		
		not Page
	*	XAML code behind 
		*	BUildAction = Compile
		*	DependentUpon node: XAML file name


    <EmbeddedResource Include="FeaturesCapabilities\MultiMedia\Audio\PageAudioRecorder.xaml">
      <Generator>MSBuild:Compile</Generator>
    </EmbeddedResource>
	<Compile Include="FeaturesCapabilities\MultiMedia\Audio\PageAudioRecorder.xaml.cs">
		<DependentUpon>PageAudioRecorder.xaml</DependentUpon>
	</Compile>
 
 