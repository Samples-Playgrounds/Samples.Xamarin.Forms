QuickUI


/Library/Frameworks/Mono.framework/External/xbuild/Xamarin/Android/Xamarin.Android.Common.targets: Error: Tool exited with code: 3. Output: 
UNEXPECTED TOP-LEVEL ERROR:
java.lang.OutOfMemoryError: Java heap space
	at com.android.dx.cf.code.BasicBlocker.getBlockList(BasicBlocker.java:310)
	at com.android.dx.cf.code.BasicBlocker.identifyBlocks(BasicBlocker.java:82)
	at com.android.dx.cf.code.Ropper.<init>(Ropper.java:278)
	at com.android.dx.cf.code.Ropper.convert(Ropper.java:251)
	at com.android.dx.dex.cf.CfTranslator.processMethods(CfTranslator.java:256)
	at com.android.dx.dex.cf.CfTranslator.translate0(CfTranslator.java:134)
	at com.android.dx.dex.cf.CfTranslator.translate(CfTranslator.java:87)
	at com.android.dx.command.dexer.Main.processClass(Main.java:487)
	at com.android.dx.command.dexer.Main.processFileBytes(Main.java:459)
	at com.android.dx.command.dexer.Main.access$400(Main.java:67)
	at com.android.dx.command.dexer.Main$1.processFileBytes(Main.java:398)
	at com.android.dx.cf.direct.ClassPathOpener.processArchive(ClassPathOpener.java:245)
	at com.android.dx.cf.direct.ClassPathOpener.processOne(ClassPathOpener.java:131)
	at com.android.dx.cf.direct.ClassPathOpener.process(ClassPathOpener.java:109)
	at com.android.dx.command.dexer.Main.processOne(Main.java:422)
	at com.android.dx.command.dexer.Main.processAllFiles(Main.java:333)
	at com.android.dx.command.dexer.Main.run(Main.java:209)
	at com.android.dx.command.dexer.Main.main(Main.java:174)
	at com.android.dx.command.Main.main(Main.java:91)
 (QuickUIDemo.Android)




 
Building: QuickUIDemo.Android (Debug)

Build started 12/14/2013 09:24:12.
__________________________________________________
Project "/Users/moljac/Projects/QuickUI/QuickUI/QuickUIDemo.sln/QuickUIDemo.Android/QuickUIDemo.Android.csproj" (Build target(s)):
	
	Target _CheckProjectItems:
		CheckProjectItems Task
		  NativeLibraries:
		  JavaLibraries:
		  JavaSourceFiles:
	
	Target _ComputeAndroidAssetsPaths:
		  ResourceFiles:
		  IntermediateFiles:
	
	Target _GenerateAndroidAssetsDir:
	No output files were specified for target _GenerateAndroidAssetsDir, skipping.
	
	Target _ComputeAndroidResourcePaths:
		  ResourceFiles:
		    Resources/Layout/SplashScreen.axml
		    Resources/Layout/FirstView.axml
		    Resources/Layout/Main.axml
		    Resources/Values/Strings.xml
		    Resources/Drawable/Icon.png
		    Resources/Values/SplashStyle.xml
		    Resources/Values/MvxBindingAttributes.xml
		    Resources/Drawable/splash.png
		  IntermediateFiles:
	
	Target _GenerateAndroidResourceDir:
	Skipping target "_GenerateAndroidResourceDir" because its outputs are up-to-date.
	
	Target _ResolveMonoAndroidSdks:
		MonoAndroid Tools: /Library/Frameworks/Xamarin.Android.framework/Versions/Current/lib/mandroid/
		MonoAndroid Binaries: /Library/Frameworks/Xamarin.Android.framework/Versions/Current/bin/
		Android Platform API level: 15
		TargetFrameworkVersion: v4.0.3
		Android NDK: /Users/moljac/Library/Developer/Xamarin/android-ndk/android-ndk-r8d/
		Android SDK: /Users/moljac/Downloads/adt-bundle-mac-x86_64-20131030/sdk/
		Android SDK Build Tools: /Users/moljac/Downloads/adt-bundle-mac-x86_64-20131030/sdk/build-tools/17.0.0/
		Java SDK: /usr/
	
	Target _ValidateAndroidPackageProperties:
		GetAndroidPackageName Task
		  ManifestFile: /Users/moljac/Projects/QuickUI/QuickUI/QuickUIDemo.sln/QuickUIDemo.Android/Properties/AndroidManifest.xml
		  AssemblyName: QuickUIDemo.Android
		  PackageName: QuickUIDemo.Android
	
	Target _BuildDependencies:
		Resolved library outputs: 
	
	Target _ExtractLibraryProjectImports:
		  Assemblies: 
		    ../packages/MvvmCross.HotTuna.CrossCore.3.0.14-beta2/lib/MonoAndroid16/Cirrious.CrossCore.dll
		    ../packages/MvvmCross.HotTuna.CrossCore.3.0.14-beta2/lib/MonoAndroid16/Cirrious.CrossCore.Droid.dll
		    ../packages/MvvmCross.HotTuna.MvvmCrossLibraries.3.0.14-beta2/lib/MonoAndroid16/Cirrious.MvvmCross.dll
		    ../packages/MvvmCross.HotTuna.CrossCore.3.0.14-beta2/lib/MonoAndroid16/Cirrious.MvvmCross.Binding.dll
		    ../packages/MvvmCross.HotTuna.CrossCore.3.0.14-beta2/lib/MonoAndroid16/Cirrious.MvvmCross.Binding.Droid.dll
		    ../packages/MvvmCross.HotTuna.MvvmCrossLibraries.3.0.14-beta2/lib/MonoAndroid16/Cirrious.MvvmCross.Droid.dll
		    ../packages/MvvmCross.HotTuna.CrossCore.3.0.14-beta2/lib/MonoAndroid16/Cirrious.MvvmCross.Localization.dll
		    /Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v4.0.3/Mono.Android.dll
		    /Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v4.0.3/Mono.Android.Support.v13.dll
		    /Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v1.0/mscorlib.dll
		    /Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v1.0/System.dll
		    ../packages/MvvmCross.PortableSupport.3.0.14-beta2/lib/MonoAndroid16/System.Net.dll
		    ../packages/MvvmCross.PortableSupport.3.0.14-beta2/lib/MonoAndroid16/System.Windows.dll
		    /Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v1.0/System.Xml.Linq.dll
		    /Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v1.0/System.Xml.dll
		    ../packages/MvvmCross.PortableSupport.3.0.14-beta2/lib/MonoAndroid16/System.Xml.Serialization.dll
		    ../Components/googleplayservices12-12.0.0/lib/android/GooglePlayServicesLib.dll
		    ../Components/quickui-1.0/lib/android/Xamarin.QuickUI.Core.Android.dll
		    ../Components/quickui-1.0/lib/android/Xamarin.QuickUI.Platform.Android.dll
		    /Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v1.0/System.Core.dll
		  Jars: 
		    /Users/moljac/Projects/QuickUI/QuickUI/QuickUIDemo.sln/QuickUIDemo.Android/obj/Debug/__library_projects__/android-support-v13.jar
		  ResolvedResourceDirectories: 
		  ResolvedAssetDirectories: 
		  ResolvedEnvironmentFiles: 
	
	Target _GetLibraryImports:
		  NativeLibraries: 
		  Jars: 
		    obj/Debug/__library_projects__/android-support-v13.jar
		    obj/Debug/__library_projects__/Mono.Android.Support.v13/library_project_imports/android-support-v13.jar
	
	Target _CheckDuplicateJavaLibraries:
		  JavaSourceFiles:
		  JavaLibraries:
	
	Target _GetAdditionalResourcesFromAssemblies:
		  Assemblies: 
		    ../packages/MvvmCross.HotTuna.CrossCore.3.0.14-beta2/lib/MonoAndroid16/Cirrious.CrossCore.dll
		    ../packages/MvvmCross.HotTuna.CrossCore.3.0.14-beta2/lib/MonoAndroid16/Cirrious.CrossCore.Droid.dll
		    ../packages/MvvmCross.HotTuna.MvvmCrossLibraries.3.0.14-beta2/lib/MonoAndroid16/Cirrious.MvvmCross.dll
		    ../packages/MvvmCross.HotTuna.CrossCore.3.0.14-beta2/lib/MonoAndroid16/Cirrious.MvvmCross.Binding.dll
		    ../packages/MvvmCross.HotTuna.CrossCore.3.0.14-beta2/lib/MonoAndroid16/Cirrious.MvvmCross.Binding.Droid.dll
		    ../packages/MvvmCross.HotTuna.MvvmCrossLibraries.3.0.14-beta2/lib/MonoAndroid16/Cirrious.MvvmCross.Droid.dll
		    ../packages/MvvmCross.HotTuna.CrossCore.3.0.14-beta2/lib/MonoAndroid16/Cirrious.MvvmCross.Localization.dll
		    /Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v4.0.3/Mono.Android.dll
		    /Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v4.0.3/Mono.Android.Support.v13.dll
		    /Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v1.0/mscorlib.dll
		    /Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v1.0/System.dll
		    ../packages/MvvmCross.PortableSupport.3.0.14-beta2/lib/MonoAndroid16/System.Net.dll
		    ../packages/MvvmCross.PortableSupport.3.0.14-beta2/lib/MonoAndroid16/System.Windows.dll
		    /Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v1.0/System.Xml.Linq.dll
		    /Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v1.0/System.Xml.dll
		    ../packages/MvvmCross.PortableSupport.3.0.14-beta2/lib/MonoAndroid16/System.Xml.Serialization.dll
		    ../Components/googleplayservices12-12.0.0/lib/android/GooglePlayServicesLib.dll
		    ../Components/quickui-1.0/lib/android/Xamarin.QuickUI.Core.Android.dll
		    ../Components/quickui-1.0/lib/android/Xamarin.QuickUI.Platform.Android.dll
		    /Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v1.0/System.Core.dll
		  AdditionalAndroidResourcePaths: /Users/moljac/Downloads/adt-bundle-mac-x86_64-20131030/sdk/extras/google/google_play_services/libproject/google-play-services_lib
		  AdditionalJavaLibraryReferences: /Users/moljac/Downloads/adt-bundle-mac-x86_64-20131030/sdk/extras/google/google_play_services/libproject/google-play-services_lib/libs/google-play-services.jar
	
	Target _UpdateAndroidResgen:
	Skipping target "_UpdateAndroidResgen" because its outputs are up-to-date.
	
	Target _GenerateJavaDesignerForComponent:
		  AdditionalResourceDirectories: 
		Tool /Users/moljac/Downloads/adt-bundle-mac-x86_64-20131030/sdk/build-tools/17.0.0/aapt execution started with arguments: package --non-constant-id -f -m -M /Users/moljac/Downloads/adt-bundle-mac-x86_64-20131030/sdk/extras/google/google_play_services/libproject/google-play-services_lib/AndroidManifest.xml -J obj/Debug/android/src -S obj/Debug/res/ -S /Users/moljac/Downloads/adt-bundle-mac-x86_64-20131030/sdk/extras/google/google_play_services/libproject/google-play-services_lib/res -I /Users/moljac/Downloads/adt-bundle-mac-x86_64-20131030/sdk/platforms/android-15/android.jar --auto-add-overlay 
	
	Target PrepareForBuild:
		Configuration: Debug Platform: AnyCPU
	
	Target GenerateSatelliteAssemblies:
	No input files were specified for target GenerateSatelliteAssemblies, skipping.
	
	Target GenerateTargetFrameworkMonikerAttribute:
	Skipping target "GenerateTargetFrameworkMonikerAttribute" because its outputs are up-to-date.
	
	Target CoreCompile:
	Skipping target "CoreCompile" because its outputs are up-to-date.
	
	Target _ResolveAssemblies:
		ResolveAssemblies Task
		  ReferenceAssembliesDirectory: /Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v4.0.3;/Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v1.0;/Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v1.0/Facades/
		  I18nAssemblies: 
		  LinkMode: None
		  Assemblies:
		    bin/Debug/QuickUIDemo.Android.dll
		    ../packages/MvvmCross.HotTuna.CrossCore.3.0.14-beta2/lib/MonoAndroid16/Cirrious.CrossCore.dll
		    ../packages/MvvmCross.HotTuna.CrossCore.3.0.14-beta2/lib/MonoAndroid16/Cirrious.CrossCore.Droid.dll
		    ../packages/MvvmCross.HotTuna.MvvmCrossLibraries.3.0.14-beta2/lib/MonoAndroid16/Cirrious.MvvmCross.dll
		    ../packages/MvvmCross.HotTuna.CrossCore.3.0.14-beta2/lib/MonoAndroid16/Cirrious.MvvmCross.Binding.dll
		    ../packages/MvvmCross.HotTuna.CrossCore.3.0.14-beta2/lib/MonoAndroid16/Cirrious.MvvmCross.Binding.Droid.dll
		    ../packages/MvvmCross.HotTuna.MvvmCrossLibraries.3.0.14-beta2/lib/MonoAndroid16/Cirrious.MvvmCross.Droid.dll
		    ../packages/MvvmCross.HotTuna.CrossCore.3.0.14-beta2/lib/MonoAndroid16/Cirrious.MvvmCross.Localization.dll
		    /Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v4.0.3/Mono.Android.dll
		    /Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v4.0.3/Mono.Android.Support.v13.dll
		    /Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v1.0/mscorlib.dll
		    /Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v1.0/System.dll
		    ../packages/MvvmCross.PortableSupport.3.0.14-beta2/lib/MonoAndroid16/System.Net.dll
		    ../packages/MvvmCross.PortableSupport.3.0.14-beta2/lib/MonoAndroid16/System.Windows.dll
		    /Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v1.0/System.Xml.Linq.dll
		    /Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v1.0/System.Xml.dll
		    ../packages/MvvmCross.PortableSupport.3.0.14-beta2/lib/MonoAndroid16/System.Xml.Serialization.dll
		    ../Components/googleplayservices12-12.0.0/lib/android/GooglePlayServicesLib.dll
		    ../Components/quickui-1.0/lib/android/Xamarin.QuickUI.Core.Android.dll
		    ../Components/quickui-1.0/lib/android/Xamarin.QuickUI.Platform.Android.dll
		    /Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v1.0/System.Core.dll
		  Assembly /Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v4.0.3/Mono.Android.dll is ignored: system assembly is used instead.
		  Assembly /Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v4.0.3/Mono.Android.Support.v13.dll is ignored: system assembly is used instead.
		  Assembly /Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v1.0/mscorlib.dll is ignored: system assembly is used instead.
		  Assembly /Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v1.0/System.dll is ignored: system assembly is used instead.
		  Assembly ../packages/MvvmCross.PortableSupport.3.0.14-beta2/lib/MonoAndroid16/System.Net.dll is ignored: system assembly is used instead.
		  Assembly ../packages/MvvmCross.PortableSupport.3.0.14-beta2/lib/MonoAndroid16/System.Windows.dll is ignored: system assembly is used instead.
		  Assembly /Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v1.0/System.Xml.Linq.dll is ignored: system assembly is used instead.
		  Assembly /Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v1.0/System.Xml.dll is ignored: system assembly is used instead.
		  Assembly ../packages/MvvmCross.PortableSupport.3.0.14-beta2/lib/MonoAndroid16/System.Xml.Serialization.dll is ignored: system assembly is used instead.
		  Assembly /Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v1.0/System.Core.dll is ignored: system assembly is used instead.
		  [Output] ResolvedAssemblies:
		    /Users/moljac/Projects/QuickUI/QuickUI/QuickUIDemo.sln/QuickUIDemo.Android/bin/Debug/QuickUIDemo.Android.dll
		    /Users/moljac/Projects/QuickUI/QuickUI/QuickUIDemo.sln/packages/MvvmCross.HotTuna.CrossCore.3.0.14-beta2/lib/MonoAndroid16/Cirrious.CrossCore.dll
		    /Users/moljac/Projects/QuickUI/QuickUI/QuickUIDemo.sln/packages/MvvmCross.HotTuna.CrossCore.3.0.14-beta2/lib/MonoAndroid16/Cirrious.CrossCore.Droid.dll
		    /Users/moljac/Projects/QuickUI/QuickUI/QuickUIDemo.sln/packages/MvvmCross.HotTuna.MvvmCrossLibraries.3.0.14-beta2/lib/MonoAndroid16/Cirrious.MvvmCross.dll
		    /Users/moljac/Projects/QuickUI/QuickUI/QuickUIDemo.sln/packages/MvvmCross.HotTuna.CrossCore.3.0.14-beta2/lib/MonoAndroid16/Cirrious.MvvmCross.Binding.dll
		    /Users/moljac/Projects/QuickUI/QuickUI/QuickUIDemo.sln/packages/MvvmCross.HotTuna.CrossCore.3.0.14-beta2/lib/MonoAndroid16/Cirrious.MvvmCross.Binding.Droid.dll
		    /Users/moljac/Projects/QuickUI/QuickUI/QuickUIDemo.sln/packages/MvvmCross.HotTuna.MvvmCrossLibraries.3.0.14-beta2/lib/MonoAndroid16/Cirrious.MvvmCross.Droid.dll
		    /Users/moljac/Projects/QuickUI/QuickUI/QuickUIDemo.sln/packages/MvvmCross.HotTuna.CrossCore.3.0.14-beta2/lib/MonoAndroid16/Cirrious.MvvmCross.Localization.dll
		    /Users/moljac/Projects/QuickUI/QuickUI/QuickUIDemo.sln/Components/googleplayservices12-12.0.0/lib/android/GooglePlayServicesLib.dll
		    /Users/moljac/Projects/QuickUI/QuickUI/QuickUIDemo.sln/Components/quickui-1.0/lib/android/Xamarin.QuickUI.Core.Android.dll
		    /Users/moljac/Projects/QuickUI/QuickUI/QuickUIDemo.sln/Components/quickui-1.0/lib/android/Xamarin.QuickUI.Platform.Android.dll
		    /Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v1.0/mscorlib.dll
		    /Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v4.0.3/Mono.Android.dll
		    /Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v1.0/System.Xml.dll
		    /Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v1.0/System.dll
		    /Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v1.0/Mono.Security.dll
		    /Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v1.0/System.Core.dll
		    /Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v1.0/System.Windows.dll
		    /Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v4.0.3/Mono.Android.Support.v13.dll
		  [Output] ResolvedUserAssemblies:
		    /Users/moljac/Projects/QuickUI/QuickUI/QuickUIDemo.sln/QuickUIDemo.Android/bin/Debug/QuickUIDemo.Android.dll
		    /Users/moljac/Projects/QuickUI/QuickUI/QuickUIDemo.sln/packages/MvvmCross.HotTuna.CrossCore.3.0.14-beta2/lib/MonoAndroid16/Cirrious.CrossCore.dll
		    /Users/moljac/Projects/QuickUI/QuickUI/QuickUIDemo.sln/packages/MvvmCross.HotTuna.CrossCore.3.0.14-beta2/lib/MonoAndroid16/Cirrious.CrossCore.Droid.dll
		    /Users/moljac/Projects/QuickUI/QuickUI/QuickUIDemo.sln/packages/MvvmCross.HotTuna.MvvmCrossLibraries.3.0.14-beta2/lib/MonoAndroid16/Cirrious.MvvmCross.dll
		    /Users/moljac/Projects/QuickUI/QuickUI/QuickUIDemo.sln/packages/MvvmCross.HotTuna.CrossCore.3.0.14-beta2/lib/MonoAndroid16/Cirrious.MvvmCross.Binding.dll
		    /Users/moljac/Projects/QuickUI/QuickUI/QuickUIDemo.sln/packages/MvvmCross.HotTuna.CrossCore.3.0.14-beta2/lib/MonoAndroid16/Cirrious.MvvmCross.Binding.Droid.dll
		    /Users/moljac/Projects/QuickUI/QuickUI/QuickUIDemo.sln/packages/MvvmCross.HotTuna.MvvmCrossLibraries.3.0.14-beta2/lib/MonoAndroid16/Cirrious.MvvmCross.Droid.dll
		    /Users/moljac/Projects/QuickUI/QuickUI/QuickUIDemo.sln/packages/MvvmCross.HotTuna.CrossCore.3.0.14-beta2/lib/MonoAndroid16/Cirrious.MvvmCross.Localization.dll
		    /Users/moljac/Projects/QuickUI/QuickUI/QuickUIDemo.sln/Components/googleplayservices12-12.0.0/lib/android/GooglePlayServicesLib.dll
		    /Users/moljac/Projects/QuickUI/QuickUI/QuickUIDemo.sln/Components/quickui-1.0/lib/android/Xamarin.QuickUI.Core.Android.dll
		    /Users/moljac/Projects/QuickUI/QuickUI/QuickUIDemo.sln/Components/quickui-1.0/lib/android/Xamarin.QuickUI.Platform.Android.dll
		  [Output] ResolvedFrameworkAssemblies:
		    /Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v1.0/mscorlib.dll
		    /Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v4.0.3/Mono.Android.dll
		    /Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v1.0/System.Xml.dll
		    /Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v1.0/System.dll
		    /Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v1.0/Mono.Security.dll
		    /Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v1.0/System.Core.dll
		    /Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v1.0/System.Windows.dll
		    /Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v4.0.3/Mono.Android.Support.v13.dll
	
	Target _CopyIntermediateAssemblies:
		Copying file from '/Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v4.0.3/Mono.Android.Support.v13.dll' to '/Users/moljac/Projects/QuickUI/QuickUI/QuickUIDemo.sln/QuickUIDemo.Android/obj/Debug/assemblies/Mono.Android.Support.v13.dll'
		SourceFiles:
		    /Users/moljac/Projects/QuickUI/QuickUI/QuickUIDemo.sln/QuickUIDemo.Android/bin/Debug/QuickUIDemo.Android.dll
		    /Users/moljac/Projects/QuickUI/QuickUI/QuickUIDemo.sln/packages/MvvmCross.HotTuna.CrossCore.3.0.14-beta2/lib/MonoAndroid16/Cirrious.CrossCore.dll
		    /Users/moljac/Projects/QuickUI/QuickUI/QuickUIDemo.sln/packages/MvvmCross.HotTuna.CrossCore.3.0.14-beta2/lib/MonoAndroid16/Cirrious.CrossCore.Droid.dll
		    /Users/moljac/Projects/QuickUI/QuickUI/QuickUIDemo.sln/packages/MvvmCross.HotTuna.MvvmCrossLibraries.3.0.14-beta2/lib/MonoAndroid16/Cirrious.MvvmCross.dll
		    /Users/moljac/Projects/QuickUI/QuickUI/QuickUIDemo.sln/packages/MvvmCross.HotTuna.CrossCore.3.0.14-beta2/lib/MonoAndroid16/Cirrious.MvvmCross.Binding.dll
		    /Users/moljac/Projects/QuickUI/QuickUI/QuickUIDemo.sln/packages/MvvmCross.HotTuna.CrossCore.3.0.14-beta2/lib/MonoAndroid16/Cirrious.MvvmCross.Binding.Droid.dll
		    /Users/moljac/Projects/QuickUI/QuickUI/QuickUIDemo.sln/packages/MvvmCross.HotTuna.MvvmCrossLibraries.3.0.14-beta2/lib/MonoAndroid16/Cirrious.MvvmCross.Droid.dll
		    /Users/moljac/Projects/QuickUI/QuickUI/QuickUIDemo.sln/packages/MvvmCross.HotTuna.CrossCore.3.0.14-beta2/lib/MonoAndroid16/Cirrious.MvvmCross.Localization.dll
		    /Users/moljac/Projects/QuickUI/QuickUI/QuickUIDemo.sln/Components/googleplayservices12-12.0.0/lib/android/GooglePlayServicesLib.dll
		    /Users/moljac/Projects/QuickUI/QuickUI/QuickUIDemo.sln/Components/quickui-1.0/lib/android/Xamarin.QuickUI.Core.Android.dll
		    /Users/moljac/Projects/QuickUI/QuickUI/QuickUIDemo.sln/Components/quickui-1.0/lib/android/Xamarin.QuickUI.Platform.Android.dll
		    /Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v1.0/mscorlib.dll
		    /Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v4.0.3/Mono.Android.dll
		    /Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v1.0/System.Xml.dll
		    /Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v1.0/System.dll
		    /Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v1.0/Mono.Security.dll
		    /Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v1.0/System.Core.dll
		    /Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v1.0/System.Windows.dll
		    /Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v4.0.3/Mono.Android.Support.v13.dll
		DestinationFiles:
		    obj/Debug/assemblies/QuickUIDemo.Android.dll
		    obj/Debug/assemblies/Cirrious.CrossCore.dll
		    obj/Debug/assemblies/Cirrious.CrossCore.Droid.dll
		    obj/Debug/assemblies/Cirrious.MvvmCross.dll
		    obj/Debug/assemblies/Cirrious.MvvmCross.Binding.dll
		    obj/Debug/assemblies/Cirrious.MvvmCross.Binding.Droid.dll
		    obj/Debug/assemblies/Cirrious.MvvmCross.Droid.dll
		    obj/Debug/assemblies/Cirrious.MvvmCross.Localization.dll
		    obj/Debug/assemblies/GooglePlayServicesLib.dll
		    obj/Debug/assemblies/Xamarin.QuickUI.Core.Android.dll
		    obj/Debug/assemblies/Xamarin.QuickUI.Platform.Android.dll
		    obj/Debug/assemblies/mscorlib.dll
		    obj/Debug/assemblies/Mono.Android.dll
		    obj/Debug/assemblies/System.Xml.dll
		    obj/Debug/assemblies/System.dll
		    obj/Debug/assemblies/Mono.Security.dll
		    obj/Debug/assemblies/System.Core.dll
		    obj/Debug/assemblies/System.Windows.dll
		    obj/Debug/assemblies/Mono.Android.Support.v13.dll
		SourceFiles:
		    /Users/moljac/Projects/QuickUI/QuickUI/QuickUIDemo.sln/QuickUIDemo.Android/bin/Debug/QuickUIDemo.Android.dll
		    /Users/moljac/Projects/QuickUI/QuickUI/QuickUIDemo.sln/packages/MvvmCross.HotTuna.CrossCore.3.0.14-beta2/lib/MonoAndroid16/Cirrious.CrossCore.dll
		    /Users/moljac/Projects/QuickUI/QuickUI/QuickUIDemo.sln/packages/MvvmCross.HotTuna.CrossCore.3.0.14-beta2/lib/MonoAndroid16/Cirrious.CrossCore.Droid.dll
		    /Users/moljac/Projects/QuickUI/QuickUI/QuickUIDemo.sln/packages/MvvmCross.HotTuna.MvvmCrossLibraries.3.0.14-beta2/lib/MonoAndroid16/Cirrious.MvvmCross.dll
		    /Users/moljac/Projects/QuickUI/QuickUI/QuickUIDemo.sln/packages/MvvmCross.HotTuna.CrossCore.3.0.14-beta2/lib/MonoAndroid16/Cirrious.MvvmCross.Binding.dll
		    /Users/moljac/Projects/QuickUI/QuickUI/QuickUIDemo.sln/packages/MvvmCross.HotTuna.CrossCore.3.0.14-beta2/lib/MonoAndroid16/Cirrious.MvvmCross.Binding.Droid.dll
		    /Users/moljac/Projects/QuickUI/QuickUI/QuickUIDemo.sln/packages/MvvmCross.HotTuna.MvvmCrossLibraries.3.0.14-beta2/lib/MonoAndroid16/Cirrious.MvvmCross.Droid.dll
		    /Users/moljac/Projects/QuickUI/QuickUI/QuickUIDemo.sln/packages/MvvmCross.HotTuna.CrossCore.3.0.14-beta2/lib/MonoAndroid16/Cirrious.MvvmCross.Localization.dll
		    /Users/moljac/Projects/QuickUI/QuickUI/QuickUIDemo.sln/Components/googleplayservices12-12.0.0/lib/android/GooglePlayServicesLib.dll
		    /Users/moljac/Projects/QuickUI/QuickUI/QuickUIDemo.sln/Components/quickui-1.0/lib/android/Xamarin.QuickUI.Core.Android.dll
		    /Users/moljac/Projects/QuickUI/QuickUI/QuickUIDemo.sln/Components/quickui-1.0/lib/android/Xamarin.QuickUI.Platform.Android.dll
		    /Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v1.0/mscorlib.dll
		    /Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v4.0.3/Mono.Android.dll
		    /Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v1.0/System.Xml.dll
		    /Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v1.0/System.dll
		    /Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v1.0/Mono.Security.dll
		    /Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v1.0/System.Core.dll
		    /Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v1.0/System.Windows.dll
		    /Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v4.0.3/Mono.Android.Support.v13.dll
		DestinationFiles:
		    obj/Debug/assemblies/QuickUIDemo.Android.dll
		    obj/Debug/assemblies/Cirrious.CrossCore.dll
		    obj/Debug/assemblies/Cirrious.CrossCore.Droid.dll
		    obj/Debug/assemblies/Cirrious.MvvmCross.dll
		    obj/Debug/assemblies/Cirrious.MvvmCross.Binding.dll
		    obj/Debug/assemblies/Cirrious.MvvmCross.Binding.Droid.dll
		    obj/Debug/assemblies/Cirrious.MvvmCross.Droid.dll
		    obj/Debug/assemblies/Cirrious.MvvmCross.Localization.dll
		    obj/Debug/assemblies/GooglePlayServicesLib.dll
		    obj/Debug/assemblies/Xamarin.QuickUI.Core.Android.dll
		    obj/Debug/assemblies/Xamarin.QuickUI.Platform.Android.dll
		    obj/Debug/assemblies/mscorlib.dll
		    obj/Debug/assemblies/Mono.Android.dll
		    obj/Debug/assemblies/System.Xml.dll
		    obj/Debug/assemblies/System.dll
		    obj/Debug/assemblies/Mono.Security.dll
		    obj/Debug/assemblies/System.Core.dll
		    obj/Debug/assemblies/System.Windows.dll
		    obj/Debug/assemblies/Mono.Android.Support.v13.dll
	
	Target _ScanAssemblies:
		LinkAssemblies Task
		  UseSharedRuntime: true
		  MainAssembly: obj/Debug/assemblies/QuickUIDemo.Android.dll
		  OutputDirectory: obj/Debug/android/assets/
		  I18nAssemblies: 
		  ReferenceAssembliesDirectory: /Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v4.0.3;/Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v1.0;/Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v1.0/Facades/
		  ResolvedAssemblies:
		    obj/Debug/assemblies/QuickUIDemo.Android.dll
		    obj/Debug/assemblies/Cirrious.CrossCore.dll
		    obj/Debug/assemblies/Cirrious.CrossCore.Droid.dll
		    obj/Debug/assemblies/Cirrious.MvvmCross.dll
		    obj/Debug/assemblies/Cirrious.MvvmCross.Binding.dll
		    obj/Debug/assemblies/Cirrious.MvvmCross.Binding.Droid.dll
		    obj/Debug/assemblies/Cirrious.MvvmCross.Droid.dll
		    obj/Debug/assemblies/Cirrious.MvvmCross.Localization.dll
		    obj/Debug/assemblies/GooglePlayServicesLib.dll
		    obj/Debug/assemblies/Xamarin.QuickUI.Core.Android.dll
		    obj/Debug/assemblies/Xamarin.QuickUI.Platform.Android.dll
		    obj/Debug/assemblies/mscorlib.dll
		    obj/Debug/assemblies/Mono.Android.dll
		    obj/Debug/assemblies/System.Xml.dll
		    obj/Debug/assemblies/System.dll
		    obj/Debug/assemblies/Mono.Security.dll
		    obj/Debug/assemblies/System.Core.dll
		    obj/Debug/assemblies/System.Windows.dll
		    obj/Debug/assemblies/Mono.Android.Support.v13.dll
	
	Target _StripEmbeddedLibraries:
		  Assemblies: 
		    obj/Debug/assemblies/QuickUIDemo.Android.dll
		    obj/Debug/assemblies/Cirrious.CrossCore.dll
		    obj/Debug/assemblies/Cirrious.CrossCore.Droid.dll
		    obj/Debug/assemblies/Cirrious.MvvmCross.dll
		    obj/Debug/assemblies/Cirrious.MvvmCross.Binding.dll
		    obj/Debug/assemblies/Cirrious.MvvmCross.Binding.Droid.dll
		    obj/Debug/assemblies/Cirrious.MvvmCross.Droid.dll
		    obj/Debug/assemblies/Cirrious.MvvmCross.Localization.dll
		    obj/Debug/assemblies/GooglePlayServicesLib.dll
		    obj/Debug/assemblies/Xamarin.QuickUI.Core.Android.dll
		    obj/Debug/assemblies/Xamarin.QuickUI.Platform.Android.dll
		    obj/Debug/assemblies/mscorlib.dll
		    obj/Debug/assemblies/Mono.Android.dll
		    obj/Debug/assemblies/System.Xml.dll
		    obj/Debug/assemblies/System.dll
		    obj/Debug/assemblies/Mono.Security.dll
		    obj/Debug/assemblies/System.Core.dll
		    obj/Debug/assemblies/System.Windows.dll
		    obj/Debug/assemblies/Mono.Android.Support.v13.dll
	
	Target _GenerateJavaStubs:
	Skipping target "_GenerateJavaStubs" because its outputs are up-to-date.
	
	Target _AddStaticResources:
		Resource obj/Debug/android/assets/machine.config is unchanged. Skipping.
		Resource obj/Debug/android/src/mono/MonoRuntimeProvider.java is unchanged. Skipping.
		Resource obj/Debug/android/src/mono/android/Seppuku.java is unchanged. Skipping.
	
	Target _GeneratePackageManagerJava:
	Skipping target "_GeneratePackageManagerJava" because its outputs are up-to-date.
	
	Target _CreateBaseApk:
	Skipping target "_CreateBaseApk" because its outputs are up-to-date.
	
	Target _CompileJava:
		  JavaSourceFiles:
		  JavaLibraries:
		  ExternalJavaLibraries:
		  AddOnPlatformLibraries:
		Tool /usr//bin/javac execution started with arguments: -d obj/Debug/android/bin/classes -classpath /Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v4.0.3/mono.android.jar:obj/Debug/__library_projects__/android-support-v13.jar:/Users/moljac/Downloads/adt-bundle-mac-x86_64-20131030/sdk/extras/google/google_play_services/libproject/google-play-services_lib/libs/google-play-services.jar -bootclasspath /Users/moljac/Downloads/adt-bundle-mac-x86_64-20131030/sdk/platforms/android-15/android.jar -encoding UTF-8 @/var/folders/8b/l3jkjtld7fj2fp3ps1z865rr0000gn/T/tmp52cc5837.tmp 
		Note: obj/Debug/android/src/cirrious/crosscore/droid/views/MvxEventSourceTabActivity.java uses or overrides a deprecated API.
		Note: Recompile with -Xlint:deprecation for details.
		Note: Some input files use unchecked or unsafe operations.
		Note: Recompile with -Xlint:unchecked for details.
	
	Target _CompileDex:
		  JavaSourceFiles:
		  JavaLibraries:
		  ExternalJavaLibraries:
		Tool /usr//bin/java execution started with arguments: -jar /Users/moljac/Downloads/adt-bundle-mac-x86_64-20131030/sdk/build-tools/17.0.0//lib/dx.jar --no-strict --dex --output=obj/Debug/android/bin/classes.dex obj/Debug/android/bin/classes /Library/Frameworks/Mono.framework/External/xbuild-frameworks/MonoAndroid/v4.0.3/mono.android.jar /Users/moljac/Projects/QuickUI/QuickUI/QuickUIDemo.sln/QuickUIDemo.Android/obj/Debug/__library_projects__/android-support-v13.jar /Users/moljac/Downloads/adt-bundle-mac-x86_64-20131030/sdk/extras/google/google_play_services/libproject/google-play-services_lib/libs/google-play-services.jar 
		
		UNEXPECTED TOP-LEVEL ERROR:
		java.lang.OutOfMemoryError: Java heap space
			at com.android.dx.cf.code.BasicBlocker.getBlockList(BasicBlocker.java:310)
			at com.android.dx.cf.code.BasicBlocker.identifyBlocks(BasicBlocker.java:82)
			at com.android.dx.cf.code.Ropper.<init>(Ropper.java:278)
			at com.android.dx.cf.code.Ropper.convert(Ropper.java:251)
			at com.android.dx.dex.cf.CfTranslator.processMethods(CfTranslator.java:256)
			at com.android.dx.dex.cf.CfTranslator.translate0(CfTranslator.java:134)
			at com.android.dx.dex.cf.CfTranslator.translate(CfTranslator.java:87)
			at com.android.dx.command.dexer.Main.processClass(Main.java:487)
			at com.android.dx.command.dexer.Main.processFileBytes(Main.java:459)
			at com.android.dx.command.dexer.Main.access$400(Main.java:67)
			at com.android.dx.command.dexer.Main$1.processFileBytes(Main.java:398)
			at com.android.dx.cf.direct.ClassPathOpener.processArchive(ClassPathOpener.java:245)
			at com.android.dx.cf.direct.ClassPathOpener.processOne(ClassPathOpener.java:131)
			at com.android.dx.cf.direct.ClassPathOpener.process(ClassPathOpener.java:109)
			at com.android.dx.command.dexer.Main.processOne(Main.java:422)
			at com.android.dx.command.dexer.Main.processAllFiles(Main.java:333)
			at com.android.dx.command.dexer.Main.run(Main.java:209)
			at com.android.dx.command.dexer.Main.main(Main.java:174)
			at com.android.dx.command.Main.main(Main.java:91)
/Library/Frameworks/Mono.framework/External/xbuild/Xamarin/Android/Xamarin.Android.Common.targets: error : Tool exited with code: 3. Output: 
UNEXPECTED TOP-LEVEL ERROR:
java.lang.OutOfMemoryError: Java heap space
	at com.android.dx.cf.code.BasicBlocker.getBlockList(BasicBlocker.java:310)
	at com.android.dx.cf.code.BasicBlocker.identifyBlocks(BasicBlocker.java:82)
	at com.android.dx.cf.code.Ropper.<init>(Ropper.java:278)
	at com.android.dx.cf.code.Ropper.convert(Ropper.java:251)
	at com.android.dx.dex.cf.CfTranslator.processMethods(CfTranslator.java:256)
	at com.android.dx.dex.cf.CfTranslator.translate0(CfTranslator.java:134)
	at com.android.dx.dex.cf.CfTranslator.translate(CfTranslator.java:87)
	at com.android.dx.command.dexer.Main.processClass(Main.java:487)
	at com.android.dx.command.dexer.Main.processFileBytes(Main.java:459)
	at com.android.dx.command.dexer.Main.access$400(Main.java:67)
	at com.android.dx.command.dexer.Main$1.processFileBytes(Main.java:398)
	at com.android.dx.cf.direct.ClassPathOpener.processArchive(ClassPathOpener.java:245)
	at com.android.dx.cf.direct.ClassPathOpener.processOne(ClassPathOpener.java:131)
	at com.android.dx.cf.direct.ClassPathOpener.process(ClassPathOpener.java:109)
	at com.android.dx.command.dexer.Main.processOne(Main.java:422)
	at com.android.dx.command.dexer.Main.processAllFiles(Main.java:333)
	at com.android.dx.command.dexer.Main.run(Main.java:209)
	at com.android.dx.command.dexer.Main.main(Main.java:174)
	at com.android.dx.command.Main.main(Main.java:91)

	Task "CompileToDalvik" execution -- FAILED
	Done building target "_CompileDex" in project "/Users/moljac/Projects/QuickUI/QuickUI/QuickUIDemo.sln/QuickUIDemo.Android/QuickUIDemo.Android.csproj".-- FAILED
	
Done building project "/Users/moljac/Projects/QuickUI/QuickUI/QuickUIDemo.sln/QuickUIDemo.Android/QuickUIDemo.Android.csproj".-- FAILED

Build FAILED.
Errors:

/Users/moljac/Projects/QuickUI/QuickUI/QuickUIDemo.sln/QuickUIDemo.Android/QuickUIDemo.Android.csproj (Build) ->
/Library/Frameworks/Mono.framework/External/xbuild/Xamarin/Android/Xamarin.Android.Common.targets (_CompileDex target) ->

	/Library/Frameworks/Mono.framework/External/xbuild/Xamarin/Android/Xamarin.Android.Common.targets: error : Tool exited with code: 3. Output: 
UNEXPECTED TOP-LEVEL ERROR:
java.lang.OutOfMemoryError: Java heap space
	at com.android.dx.cf.code.BasicBlocker.getBlockList(BasicBlocker.java:310)
	at com.android.dx.cf.code.BasicBlocker.identifyBlocks(BasicBlocker.java:82)
	at com.android.dx.cf.code.Ropper.<init>(Ropper.java:278)
	at com.android.dx.cf.code.Ropper.convert(Ropper.java:251)
	at com.android.dx.dex.cf.CfTranslator.processMethods(CfTranslator.java:256)
	at com.android.dx.dex.cf.CfTranslator.translate0(CfTranslator.java:134)
	at com.android.dx.dex.cf.CfTranslator.translate(CfTranslator.java:87)
	at com.android.dx.command.dexer.Main.processClass(Main.java:487)
	at com.android.dx.command.dexer.Main.processFileBytes(Main.java:459)
	at com.android.dx.command.dexer.Main.access$400(Main.java:67)
	at com.android.dx.command.dexer.Main$1.processFileBytes(Main.java:398)
	at com.android.dx.cf.direct.ClassPathOpener.processArchive(ClassPathOpener.java:245)
	at com.android.dx.cf.direct.ClassPathOpener.processOne(ClassPathOpener.java:131)
	at com.android.dx.cf.direct.ClassPathOpener.process(ClassPathOpener.java:109)
	at com.android.dx.command.dexer.Main.processOne(Main.java:422)
	at com.android.dx.command.dexer.Main.processAllFiles(Main.java:333)
	at com.android.dx.command.dexer.Main.run(Main.java:209)
	at com.android.dx.command.dexer.Main.main(Main.java:174)
	at com.android.dx.command.Main.main(Main.java:91)


	 0 Warning(s)
	 1 Error(s)

Time Elapsed 00:00:19.0389610

---------------------- Done ----------------------

Build: 1 error, 0 warnings
