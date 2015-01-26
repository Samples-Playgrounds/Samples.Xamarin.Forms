# Xamarin.Forms.Maps Android error in v.1.3.1

channels:
*	stable and 
*	alpha

error:

	/Library/Frameworks/Mono.framework/External/xbuild/Xamarin/Android/Xamarin.Android.Common.targets: Error: Tool exited with code: 1. Output: max res 19, skipping values-v21
	~/.local/share/Xamarin/Android.Support.v7.AppCompat/21.0.3/embedded/./res/drawable-mdpi/abc_ab_share_pack_holo_dark.9.png: libpng warning: iCCP: Not recognizing known sRGB profile that has been edited
	~/.local/share/Xamarin/Android.Support.v7.AppCompat/21.0.3/embedded/./res/drawable-xhdpi/abc_ab_share_pack_holo_dark.9.png: libpng warning: iCCP: Not recognizing known sRGB profile that has been edited
	~/.local/share/Xamarin/Android.Support.v7.AppCompat/21.0.3/embedded/./res/drawable-hdpi/abc_ab_share_pack_holo_dark.9.png: libpng warning: iCCP: Not recognizing known sRGB profile that has been edited
	~/.local/share/Xamarin/Android.Support.v7.AppCompat/21.0.3/embedded/./res/drawable-hdpi/abc_ab_share_pack_holo_light.9.png: libpng warning: iCCP: Not recognizing known sRGB profile that has been edited
	~/.local/share/Xamarin/Android.Support.v7.AppCompat/21.0.3/embedded/./res/drawable-xhdpi/abc_ab_share_pack_holo_light.9.png: libpng warning: iCCP: Not recognizing known sRGB profile that has been edited
	~/.local/share/Xamarin/Android.Support.v7.AppCompat/21.0.3/embedded/./res/drawable-hdpi/abc_spinner_mtrl_am_alpha.9.png: libpng warning: iCCP: Not recognizing known sRGB profile that has been edited
	~/.local/share/Xamarin/Android.Support.v7.AppCompat/21.0.3/embedded/./res/values-v11/values.xml:50: error: Error: No resource found that matches the given name: attr 'android:actionModeShareDrawable'.
	~/.local/share/Xamarin/Android.Support.v7.AppCompat/21.0.3/embedded/./res/values-v14/values.xml:9: error: Error: No resource found that matches the given name: attr 'android:actionModeShareDrawable'.
	~/.local/share/Xamarin/Android.Support.v7.AppCompat/21.0.3/embedded/./res/values-v11/values.xml:57: error: Error: No resource found that matches the given name: attr 'android:actionModeShareDrawable'.
	~/.local/share/Xamarin/Android.Support.v7.AppCompat/21.0.3/embedded/./res/values-v14/values.xml:17: error: Error: No resource found that matches the given name: attr 'android:actionModeShareDrawable'.
	~/.local/share/Xamarin/Android.Support.v7.AppCompat/21.0.3/embedded/./res/values-v11/values.xml:64: error: Error: No resource found that matches the given name: attr 'android:actionModeShareDrawable'.
	~/.local/share/Xamarin/Android.Support.v7.AppCompat/21.0.3/embedded/./res/values-v14/values.xml:25: error: Error: No resource found that matches the given name: attr 'android:actionModeShareDrawable'.
	~/.local/share/Xamarin/Android.Support.v7.AppCompat/21.0.3/embedded/./res/values-v11/values.xml:71: error: Error: No resource found that matches the given name: attr 'android:actionModeShareDrawable'.
	~/.local/share/Xamarin/Android.Support.v7.AppCompat/21.0.3/embedded/./res/values-v14/values.xml:33: error: Error: No resource found that matches the given name: attr 'android:actionModeShareDrawable'.

 (ControlsViewsMap.Android)
 
 
Tried:

	*	uninstall-package Xamarin.Forms.Maps
	*	uninstall-package Xamarin.Forms 
	*	install-package Xamarin.Forms
	*	install-package Xamarin.Forms.Maps
 
 

 
 
 
 
 
 
 
 
 
 ControlsViewsMap.Android: Error XA5206: . 
Android resource directory packages/Xamarin.GooglePlayServices.16.0.0/lib/MonoAndroid10/16/content/google-play-services/libproject/google-play-services_lib doesn't exist. 
(XA5206) 
(ControlsViewsMap.Android)

ControlsViewsMap/ControlsViewsMap.Android: Error XA5207: . 
Java library file ~/Projects/Samples/Samples.Xamarin.Forms/tutorial-samples/packages/Xamarin.GooglePlayServices.16.0.0/lib/MonoAndroid10/16/content/google-play-services/libproject/google-play-services_lib/libs/google-play-services.jar doesn't exist. 
(XA5207) 
(ControlsViewsMap.Android)