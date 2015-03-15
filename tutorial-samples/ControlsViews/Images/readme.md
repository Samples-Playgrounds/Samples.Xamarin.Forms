# Images

[http://developer.xamarin.com/guides/cross-platform/xamarin-forms/working-with/images/](http://developer.xamarin.com/guides/cross-platform/xamarin-forms/working-with/images/)


## Important Platform Information

Android supports bitmap files in three formats: 
	1.	.png (preferred),
	2.	.jpg (acceptable),
	3.	.gif (discouraged)	
		may be not rendered


Note:

1.	Android resources dictate filenaming!
	1.	Allowed characters: a-z0-9_.	
		xamarin logo.png
		xamarin-logo.png
		1.	replace forbidden characters before adding images to project	
	2.	Resource filenames with more than 1 extensions - not allowed		
		xamarin_hexagon.png.png		
		1.	add sufix/prefix to file
			xamarin_hexagon_png.png		
	2.	Resource filenames with different extensions - not allowed		
		xamarin_hexagon.png		
		xamarin_hexagon.gif		
		xamarin_hexagon.jpg
		1.	add sufix/prefix to file
			xamarin_hexagon_png.png		
			xamarin_hexagon_gif.gif		
			xamarin_hexagon_jpg.jpg

			
### Tips and Tricks

*	Start with Android when everything works copy files to	
	*	iOS project
	*	Windows Phone project
			


## 	Local using Image and ImageSource		

	*	Android	
		BuildAction:	AndroidResource		
		Location:		
			*	<ApplicationRoot>/Resources/Drawable/	
			*	<ApplicationRoot>/Resources/Drawable-ldpi/	
			*	<ApplicationRoot>/Resources/Drawable-hdpi/	
			*	<ApplicationRoot>/Resources/Drawable-xhdpi/	
			*	<ApplicationRoot>/Resources/Drawable-xxhdpi/	
		Location notes: subfolders not allowed
	*	iOS	
		BuildAction:	AndroidResource		
		Location:		<ApplicationRoot>/Resources/	
		Location notes: subfolders allowed
	*	WindowsPhone	
		BuildAction:	Content	
		Location:		<ApplicationRoot>/		
		Location notes: subfolders allowed			
*	Embeded		
	BuildAction: EmbeddedResource
*	Downloaded	

Notes:

*	Android needs flat folder structure in Resources/Drawable/	
	no subfolders allowed.		
	workaround:	name files with folder prefix!!		
*	iOS Resources must be
	

## Embedded Images (in PCL assembly)

*	[]()
*	[]()
*	[http://forums.xamarin.com/discussion/19525/image-source-with-onplatform-in-xaml](http://forums.xamarin.com/discussion/19525/image-source-with-onplatform-in-xaml)
*	[https://forums.xamarin.com/discussion/20585/how-to-load-embedded-image-resource-in-pcl-assembly](https://forums.xamarin.com/discussion/20585/how-to-load-embedded-image-resource-in-pcl-assembly)
*	[http://blog.falafel.com/xamarin-forms-storing-and-retrieving-photos/](http://blog.falafel.com/xamarin-forms-storing-and-retrieving-photos/)
*	[https://github.com/xamarin/xamarin-forms-samples/blob/master/WorkingWithImages/WorkingWithImages/LocalImagesXaml.xaml](https://github.com/xamarin/xamarin-forms-samples/blob/master/WorkingWithImages/WorkingWithImages/LocalImagesXaml.xaml)
*	[]()



## Icons

*	Android
*	iOS
*	Windows Phone

## Splasscreens

required in:

*	iOS		
	SplashScreen - Startup Image		
	[http://developer.xamarin.com/guides/ios/application_fundamentals/working_with_images/](http://developer.xamarin.com/guides/ios/application_fundamentals/working_with_images/)
*	Windows Phone		
	SplashScreen - Default Image		
	[http://msdn.microsoft.com/en-us/library/windowsphone/develop/jj206974(v=vs.105).aspx](http://msdn.microsoft.com/en-us/library/windowsphone/develop/jj206974(v=vs.105).aspx)
	
	
	
	
	
	
	
	
/Library/Frameworks/Mono.framework/External/xbuild/Xamarin/Android/Xamarin.Android.Common.targets: Error: Tool exited with code: 1. Output: obj/Debug/res/drawable/icon-xamarin-studio.png: libpng warning: iCCP: Not recognizing known sRGB profile that has been edited
res/drawable/icon-xamarin-studio.png: Invalid file name: must contain only [a-z0-9_.]
res/drawable/icon-xamarin-studio.png: Invalid file name: must contain only [a-z0-9_.]
res/drawable/ide-xamarin-studio.png: Invalid file name: must contain only [a-z0-9_.]
res/drawable/ide-xamarin-studio.png: Invalid file name: must contain only [a-z0-9_.]
res/drawable/mono-logo.png: Invalid file name: must contain only [a-z0-9_.]
res/drawable/xamarin copy.jpg: Invalid file name: must contain only [a-z0-9_.]
res/drawable/xamarin-authorized-partner@2x.png: Invalid file name: must contain only [a-z0-9_.]
res/drawable/xamarin-authorized-partner@2x.png: Invalid file name: must contain only [a-z0-9_.]
res/drawable/xamarin-authorized-partner@2x.png: Invalid file name: must contain only [a-z0-9_.]
res/drawable/xamarin-hexagon.gif: Invalid file name: must contain only [a-z0-9_.]
res/drawable/xamarin-hexagon.jpg: Invalid file name: must contain only [a-z0-9_.]
res/drawable/xamarin-hexagon.png: Invalid file name: must contain only [a-z0-9_.]
res/drawable/xamarin-logo copy.jpg: Invalid file name: must contain only [a-z0-9_.]
res/drawable/xamarin-logo copy.jpg: Invalid file name: must contain only [a-z0-9_.]
res/drawable/xamarin-logo-hexagon-blue-200x200.png: Invalid file name: must contain only [a-z0-9_.]
res/drawable/xamarin-logo-hexagon-blue-200x200.png: Invalid file name: must contain only [a-z0-9_.]
res/drawable/xamarin-logo-hexagon-blue-200x200.png: Invalid file name: must contain only [a-z0-9_.]
res/drawable/xamarin-logo-hexagon-blue-200x200.png: Invalid file name: must contain only [a-z0-9_.]
res/drawable/xamarin-logo.jpg: Invalid file name: must contain only [a-z0-9_.]
res/drawable/xamarin-premier-partner@2x.png: Invalid file name: must contain only [a-z0-9_.]
res/drawable/xamarin-premier-partner@2x.png: Invalid file name: must contain only [a-z0-9_.]
res/drawable/xamarin-premier-partner@2x.png: Invalid file name: must contain only [a-z0-9_.]
res/drawable/xamarin-studio.jpeg: Invalid file name: must contain only [a-z0-9_.]
res/drawable/xamarin-hexagon.jpg:0: error: Resource entry xamarin-hexagon is already defined.
res/drawable/xamarin-hexagon.gif:0: Originally defined here.

res/drawable/xamarin-hexagon.png:0: error: Resource entry xamarin-hexagon is already defined.
res/drawable/xamarin-hexagon.gif:0: Originally defined here.

res/drawable/xamarin.tiff:0: error: Resource entry xamarin is already defined.
res/drawable/xamarin.jpg:0: Originally defined here.

 (Images.Android)



 