# XamarinForms Charles Petzold Book

Notes from XamarinForms Charles Petzold Book.

## Introduction

Xamarin Froms - cross platform mobile development platform:

*	platforms (operating systems)
	*	Android
	*	iOS
	* 	Windows Phone
*	purpose
	*	business apps (line of business apps)		
	*	c# and XAML		
	*	shared code (single code base)		
		sharing up to 100% code
	*	proof of concepts applications, prototypes
	*	c# developers to target Android and iOS
*	targeting audience	
	*	management (cost reduction factor 2.0+)
	*	c# developers to target Android and iOS
	*	platform novices (c#/.net developers moving to Android and iOS)		
		Note: platform knowledge is MUST HAVE

*	[http://api.xamarin.com/](http://api.xamarin.com/)
*	[http://xamarin.com/forms](http://xamarin.com/forms)
*	[http://developer.xamarin.com/guides/cross-platform/xamarin-forms/](http://developer.xamarin.com/guides/cross-platform/xamarin-forms/)
*	[https://github.com/xamarin/xamarin-forms-book-preview](https://github.com/xamarin/xamarin-forms-book-preview)
*	[http://forums.xamarin.com/categories/xamarin-forms](http://forums.xamarin.com/categories/xamarin-forms)
*	[http://aka.ms/mspressfree](http://aka.ms/mspressfree)


### Programming languages

*	c/c++
*	vendor chosen	
	*	iOS: objective-c
	*	Android: java
	*	Windows Phone: c#
	
#### Definition: native

*	Windows: .net or win32 API (C/c++) ??
*	Android: java or NDK (c/c++) ??
*	iOS: objective-c or c/c++

 
### Development environments

*	iOS: Mac OSX + XCode
*	Android: Eclipse || Android Studio
*	Windows Phone: Visual Studio

### Programming interfaces

*	iOS		
	*	Views (UISwitch)		
*	Android		
	*	Widgets		
*	Windows Phone		
	*	Controls (FrameworkElement)
	
	
### Productivity, Resource problems

#### Problem

*	knowledge
	*	programming language
	*	Development environment IDE
	*	Platform details (programming interfaces)
*	problem for management		
	*	more resources (more developers and or more time)
	*	costs
	
	
#### Solution

*	factors
	*	single programming language
	*	similar tools

*	options
	*	HTML, CSS, javascript
	*	java 
	*	c#
		*	Xamarin.Mac = MonoMac + commercial tools
		*	Xamarin.iOS - commercial
		*	Xamarin.Android - commercial 
		
* Xamarin solution
	*	native APIs wrapped with c#
	*	PInvoke technology (advenced, duplex, callbacks)
	*	Xamarin Studio = MonoDevelop + commercial plugins
		*	Windows and MacOSX
		*	MonoDevelop: MacOSX, Windows, Linux		
			open source
		
### Code Sharing

*	tools
	*	linking c# files
		*	simple: Add File as Link
		*	Project Linker		
			*	Microsoft Prism project
			*	automatic Add File as Link
			*	source project + N target projects
		*	Portable Class Libraries (Portables, PCL)
		* 	Shared Asset Projects (SAP)
			*	modern /  recent  //BUILD 2014-04
			*	advanced, integrated "Project Linker"

	
### Xamarin.Forms

*	cross platform abstraction
*	purpose:
	*	for business apps (line of business apps, enterprise apps)	
	*	function is dominant, not form (design)
*	pros
	*	cost savings (resources) 
		*	single code base (c#) 
		*	up to 100% code sharing for 3 platofrms
			*	decreases with complexity (using platform specifics)
				*	UI complexity
				*	platform specifics (hardware, bluetooth, sensors, filesystem)
*	cons
	*	knowledge needed for customizing
		*	platform knowledge (Android, iOS, Windows Phone) needed
		

#### Architecture

*	projects
	*	1 shared code project 		
		PCL or SAP
	*	3 platform specific projects	
			startup, main - entry points		
			XamarinForms.Init(); boilerplate
		*	Android		
			MainActivity, Launcher
		*	iOS		
			Main + App delegate
		*	Windows Phone
*	UI definition
	*	c# code
	*	XAML		
		Note: not WPF or Silverlight flavor od XAML - Xamarin specifics
		
### Platform specificity

*	several utilities
	* 	class Device
		*	information about platform, device, etc
		*	defining features for each platform separately
			*	fonts
			8	paddings
	*	class DependencyService
		*	Dependency Injection
		*	in shared code defines Interface[s]				
			IInterface			
		*	in platform specific projects implementation			
		*	access/instantiate platform specific implementation in shared code		
			DependencyService.Get<IInterface>();	
	*	custom renderers			
		*	custom visual object in shared code		
			usually derived from existing UI class		
		*	custom renderers in platform specific code	
			usually derived from some existing renderer
	*	messaging			
 
 *	cons	
	stick to native API				
	*	intensive hardware (capabilities) usage		
	*	vector graphics		
	*	complex touch interaction scenarios			
* pros			
	*	business/enterprise apps (LOB line-of-business)		
		no complex UI (animations, grpahics)
	*	proof of concepts	
	*	wireframing/mocking		
		
#### DependencyService
 

#### Custom Renderers 
 
???
	CreateViewController 
		Xamarin.Forms.Page -> UIViewController
		AndroidActivity.SetPage(Xamarin.Forms.Page p) ????
	ConvertPageToUIElement
		Xamarin.Forms.Page -> UIElement


		
### Environment Setup

* 	IDE / tools	
	not different than for native	
	*	Android	
		PC or Mac with Xamarin Studio or Visual Studio	
	*	iOS		
		Mac is mandatory for compilation		
		PC or Mac with Xamarin Studio or Visual Studio	for development
	*	Windows Phone	
		PC with Visual Studio and Windows Phone SDK
* Devices and emulators/simulators	
	*	simulators/emulators	
		*	installation setup		
			*	iOS 		
				XCode		
			*	Android			
				*	XAP Xamarin Android Player
				*	Genymotiona
				*	Google + HAXM - otherwise too slow
			*	WindowsPhone		
				installed with Windows Phone SDK
		* 	cons	
			*	difficult to test touches		
			*	some capabilities/features missing (sensors, bluetooth)
			*	slow startup
			*	can give false image/information		
				have more ram and faster processors than real device
	*	real devices - nice to have
		*	cons	
			*	for iOS 
				provisioning (developer account)
			*	WindowsPhone 
				developers accounts
				

## Pages, Layouts and Views

*	nomenclature		
	*	Android			
		Activity		
		Fragment		
		View (Widget)		
		ViewLayout		
	*	iOS		
		ViewContorller - UIViewController		
		View - UIView 		
	*	WindowsPhone			
		WindowsPhonePage		
		Control, UserControl, CustomControl		
		UIElement 	

*	Xamarin.Forms nomenclature	
	*	visual elements - everything on the screen
	*	concepts:
		*	Pages
		*	Layouts
		* 	Views
	*	classes:
		*	VisualElement
			* 	exceptionally important
			*	anything that occupies space on screen
		*	Page
			*	Aplication consists of 1+ Pages
				*	single page apps
				*	multiple pages apps with navigation
			*	page occupies whole or part of the screen
			*	organized hierarchally (parent - child[ren])
			*	ContentPage genneraly has a Layout for child		
				*	purpose of layout is organization of visuals
		*	Layout	
		* 	View
			Widget/View (Android) UIView (iOS), Control (WindowsPhone)
			
			
			
			