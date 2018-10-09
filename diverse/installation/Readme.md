# Install the nuget package 

## Xamarin Studio

Get the .nupkg from the beginning post of this thread. If it has the .zip extension, unzip it. 
Put that in any folder, or leave it in ~/Downloads.

Install the monodevelop-nuget-addin 0.8 from mrward. 
(add http://mrward.github.com/monodevelop-nuget-addin-repository/4.0/main.mrep as new addin 
repository if you don't have it yet)

Create a new package source pointing to the folder containing your nupkg: 
XamarinStudio +/ Preferences... +/ Nuget +/ Package Sources

Right-click on your solution, pick **Manage NuGet packages...*, choose your new source 
and install QuickUI.

If it complains about not finding the WPToolkit package, install it from the nuget.org source 
first, then try again


## Visual Studio Studio

Xamarin.Forms version from 2015-05-15 exits with error during installation with Nuget 
packet Manager if PCL's target frameworks contain Silverlight (any version)

	Installing 'Xamarin.Forms 1.0.6183'.
	Successfully installed 'Xamarin.Forms 1.0.6183'.
	Adding 'Xamarin.Forms 1.0.6183' to Common.PCL.
	Uninstalling 'Xamarin.Forms 1.0.6183'.
	Successfully uninstalled 'Xamarin.Forms 1.0.6183'.
	Install failed. Rolling back...
	Could not install package 'Xamarin.Forms 1.0.6183'. You are trying to install 
	this package into a project that targets 'portable-win+net45+sl50+wp80+MonoAndroid10+MonoTouch10',
	but the package does not contain any assembly references or content files that are 
	compatible with that framework. For more information, contact the package author.

